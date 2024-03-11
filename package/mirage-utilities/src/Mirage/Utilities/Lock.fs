module Mirage.Utilities.Lock

open Async
open System
open System.Threading
open FSharpPlus

type Lock =
    private { semaphore: SemaphoreSlim }
    interface IDisposable with
        member this.Dispose() =
            dispose this.semaphore

let createLock () : Lock = { semaphore =  new SemaphoreSlim(1) }

// Returns a key to send back to release the lock.
// It is written in this way to catch bugs with thread A acquiring a lock and thread B tries to release the lock that thread A acquired.
let lockAcquire (lock: Lock) : Async<unit> = Lazy.toAsync <| fun () -> lock.semaphore.WaitAsync()

let lockRelease (lock: Lock) : Unit = ignore <| lock.semaphore.Release()

type LockContext =
    {   lock: Lock
    }
    
    interface IDisposable with
        member this.Dispose() =
            lockRelease this.lock

/// Implicitly acquire/release a lock by using the ``use`` keyword.
let withLock (lock: Lock) : Async<LockContext> = 
    async {
        do! lockAcquire lock
        return { lock = lock }
    }

/// Implicitly acquire/release the given locks by entering/exiting the scope of the given program.
let withLock'<'A> (lock: Lock) (program: Async<'A>) : Async<'A> =
    async {
        return! lockAcquire lock
        try return! program
        finally lockRelease lock
    }