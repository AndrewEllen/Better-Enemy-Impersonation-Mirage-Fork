<p align="center">
  <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">BETTER-ENEMY-IMPERSONATION-MIRAGE-FORK</h1>
</p>
<p align="center">
    <em><code>► INSERT-TEXT-HERE</code></em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork?style=default&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary><br>

- [📍 Overview](#-overview)
- [🧩 Features](#-features)
- [🗂️ Repository Structure](#️-repository-structure)
- [📦 Modules](#-modules)
- [🚀 Getting Started](#-getting-started)
  - [⚙️ Installation](#️-installation)
  - [🤖 Usage](#-usage)
  - [🧪 Tests](#-tests)
- [🛠 Project Roadmap](#-project-roadmap)
- [🤝 Contributing](#-contributing)
- [🎗 License](#-license)
- [🔗 Acknowledgments](#-acknowledgments)
</details>
<hr>

## 📍 Overview

<code>► INSERT-TEXT-HERE</code>

---

## 🧩 Features

|    |   Feature         | Description |
|----|-------------------|---------------------------------------------------------------|
| ⚙️  | **Architecture**  | The project architecture includes essential files like `onnxruntime` for executing ML models efficiently, `silero-vad` for voice activity detection, and `mirage-core` for async operations, audio processing, and file handling. It provides a robust foundation for real-time transcription and behavior prediction within the Mirage framework. |
| 🔩 | **Code Quality**  | The codebase maintains good quality with structured modules like `Predictor`, `ActionSelector`, and `ProviderOptions`. It leverages asynchronous operations, error handling, and policy-based scoring to ensure maintainability and reliability during behavior prediction and policy updates. |
| 📄 | **Documentation** | Extensive documentation exists for key components such as `Predictor`, `Embedding`, and `Model` functionalities. The `ThirdPartyNotices.txt` file ensures transparency about third-party software, while API headers like `onnxruntime_c_api.h` guide developers on interacting with machine learning models effectively. |
| 🔌 | **Integrations**  | Key integrations include `Whisper` and `Silero` for audio transcription, `NAudio` for audio processing, and `FSharpPlus` for functional constructs. The project seamlessly combines these dependencies to enhance voice mimicry and behavior prediction functionalities. |
| 🧩 | **Modularity**    | The codebase demonstrates modularity through packages like `behaviour-predictor`, `openai-whisper`, and `silero-vad`, enabling independent development and maintenance. The structured organization facilitates easy integration and scalability within the Mirage ecosystem. |
| 🧪 | **Testing**       | Testing is supported by frameworks like `NUnit` for assertions and `dotnet test` for automated tests. Test scripts like `Test.fsproj` and `test.py` ensure the quality and reliability of key functionalities like behavior prediction and voice transcription. |
| ⚡️  | **Performance**   | The project focuses on efficiency with features like real-time audio processing, speech recognition, and asynchronous task handling. Optimizations in `onnxruntime` enhance ML model execution, while `Whisper` and `Silero` ensure accurate voice mimicry and detection. |
| 🛡️ | **Security**      | Security measures include configuring permissions with `AssemblyInfo.fs` and providing secure access to features like audio processing, speech detection, and behavior prediction modules. These ensure data protection and access control within the Mirage system. |
| 📦 | **Dependencies**  | Key dependencies like `onnxruntime`, `NAudio`, `FSharpPlus`, and `Silero` play a vital role in enhancing the functionality of the Mirage project. These libraries enable efficient ML model execution, audio processing, and voice mimicry capabilities within the system. |

---

## 🗂️ Repository Structure

```sh
└── Better-Enemy-Impersonation-Mirage-Fork/
    ├── .git
    │   └── objects
    ├── CHANGELOG.md
    ├── lib
    │   ├── FSharpx.Async
    │   ├── MMHOOK
    │   ├── NAudio
    │   ├── NAudio.Lame
    │   └── onnxruntime
    ├── LICENSE
    ├── model
    │   ├── silero-vad
    │   └── whisper-base
    ├── package
    │   ├── assertion
    │   ├── behaviour-predictor
    │   ├── mirage-core
    │   ├── mirage-cw
    │   ├── mirage-lc
    │   ├── openai-whisper
    │   └── silero-vad
    └── README.md
```

---

## 📦 Modules

<details closed><summary>lib.onnxruntime</summary>

| File                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [ThirdPartyNotices.txt](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\ThirdPartyNotices.txt) | The `ThirdPartyNotices.txt` file in the `lib\onnxruntime` directory of the `Better-Enemy-Impersonation-Mirage-Fork` repository serves the crucial purpose of documenting third-party software incorporated into the project. It provides information about open-source components used, including where to find the source code and instructions for compliance with licensing terms. This file ensures transparency and adherence to licensing requirements within the repository architecture. |
| [VERSION_NUMBER](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\VERSION_NUMBER)               | Manages the version number for the onnxruntime library. Key for maintaining consistency and compatibility within the Better-Enemy-Impersonation-Mirage-Fork repository.                                                                                                                                                                                                                                                                                                                          |

</details>

<details closed><summary>lib.onnxruntime.include</summary>

| File                                                                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [cpu_provider_factory.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\cpu_provider_factory.h)                                       | Enables appending CPU execution provider to session options in the repository for improved performance.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [onnxruntime_cxx_api.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_cxx_api.h)                                         | This code file in the onnxruntime library provides a simplified C++ wrapper around the Ort C API within the parent repository. It enhances usability by directly returning values, using exceptions for error handling, and automating resource release, thereby streamlining interactions with the underlying Ort functionalities.                                                                                                                                                                                                                                                      |
| [onnxruntime_cxx_inline.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_cxx_inline.h)                                   | This code file is critical to the Better-Enemy-Impersonation-Mirage-Fork repositorys architecture, housed within the lib/onnxruntime/include directory. Its main purpose is to direct users to include onnxruntime_cxx_api.h" instead of directly accessing it, as it is designed for experimental features of the new C++ API. This organization ensures proper usage and adherence to licensing standards within the repository.                                                                                                                                                       |
| [onnxruntime_c_api.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_c_api.h)                                             | This code file in the `onnxruntime` directory of the repository contributes to the implementation of the ONNX Runtime project, a key component for executing machine learning models efficiently. It offers a high-level C API for interfacing with the runtime system, enabling seamless integration of ONNX models across various platforms. The file serves as a critical interface for developers to leverage the capabilities of ONNX Runtime without delving into intricate implementation details.                                                                                |
| [onnxruntime_float16.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_float16.h)                                         | Implements float16 and bfloat16 conversion features adhering to IEEE standards. Handles sign, NaN, infinity, and normal/zero checks. Uses CRTP pattern for shared functionality. Byte-order aware for endianness.                                                                                                                                                                                                                                                                                                                                                                        |
| [onnxruntime_lite_custom_op.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_lite_custom_op.h)                           | The `onnxruntime_lite_custom_op.h` header file in the `lib/onnxruntime` directory of the `Better-Enemy-Impersonation-Mirage-Fork` repository provides a set of APIs to streamline the process for custom op authors. By leveraging these APIs, authors can avoid explicitly defining schemas, as they will be automatically inferred based on the functions signature and supported argument types. The supported input types include tensors, spans, and scalars of onnx data types. This header file simplifies the development of custom operations within the onnxruntime ecosystem. |
| [onnxruntime_run_options_config_keys.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_run_options_config_keys.h)         | Defines RunOptions Config Keys for memory arena shrinkage and synchronization control. Key formats and value constraints outlined.Enable memory arena shrinkage by specifying devices, avoid synchronization with CPU post-session run for performance optimization.                                                                                                                                                                                                                                                                                                                     |
| [onnxruntime_session_options_config_keys.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_session_options_config_keys.h) | Disable prepacking, use env allocators, load/save model format, set denormals as zero, and more. Enables optimization and customization of ONNX session behavior for performance and accuracy.                                                                                                                                                                                                                                                                                                                                                                                           |
| [onnxruntime_training_cxx_api.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_training_cxx_api.h)                       | Defines training session state, handles model parameters, and provides training, evaluation, and optimization methods. Resumable training via checkpoint states. Offers learning rate control and model export for inferencing. Maintains reproducibility with SetSeed function.                                                                                                                                                                                                                                                                                                         |
| [onnxruntime_training_cxx_inline.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_training_cxx_inline.h)                 | Enables interacting with training sessions, including creating, training, and evaluating models, setting learning rates, and handling checkpoint states in the training process.                                                                                                                                                                                                                                                                                                                                                                                                         |
| [onnxruntime_training_c_api.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\onnxruntime_training_c_api.h)                           | Implements training C APIs for generating training artifacts, creating a training session, training loop, model manipulation, and resource release. Supports loading/saving checkpoints, optimizing, and exporting models for inferencing within Microsofts training framework.                                                                                                                                                                                                                                                                                                          |
| [provider_options.h](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/lib\onnxruntime\include\provider_options.h)                                               | ProviderOptions`, `ProviderOptionsVector`, and `ProviderOptionsMap`. Facilitates flexible configuration and customization within the parent repositorys architecture.                                                                                                                                                                                                                                                                                                                                                                                                                    |

</details>

<details closed><summary>model.silero-vad</summary>

| File                                                                                                                                                  | Summary                                                                                                                                                                                                    |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                        |
| [lang_dict_95.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/model\silero-vad\lang_dict_95.json)             | Maps language codes to their respective full names for the Silero VAD model configuration. Identifies diverse language support for accurate speech recognition within the parent repositorys architecture. |
| [lang_group_dict_95.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/model\silero-vad\lang_group_dict_95.json) | Defines language groups for speech signals, improving accurate transcription for diverse languages. Facilitates language identification and processing in the Mirage system.                               |

</details>

<details closed><summary>model.whisper-base</summary>

| File                                                                                                                                  | Summary                                                                                                                                                                                             |
| ---                                                                                                                                   | ---                                                                                                                                                                                                 |
| [config.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/model\whisper-base\config.json)       | Specifies alignment and suppression settings for a speech-based model in the whisper-base module, crucial for enhancing model performance in the Better-Enemy-Impersonation-Mirage-Fork repository. |
| [tokenizer.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/model\whisper-base\tokenizer.json) | <code>► INSERT-TEXT-HERE</code>                                                                                                                                                                     |
| [vocabulary.txt](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/model\whisper-base\vocabulary.txt) | <code>► INSERT-TEXT-HERE</code>                                                                                                                                                                     |

</details>

<details closed><summary>package.assertion</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                    |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                        |
| [Assertion.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\assertion\Assertion.fs)         | Ensures test assertions using NUnit framework for validating expected and actual values, confirming true conditions, and triggering failures when necessary. Vital for maintaining code quality within the Assertion module.                               |
| [Assertion.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\assertion\Assertion.fsproj) | Defines project configuration for the Assertion package, specifying target framework, dependencies, and compilation settings. Forms a crucial component within the repository structure, supporting key functionalities related to assertions and testing. |

</details>

<details closed><summary>package.behaviour-predictor.app</summary>

| File                                                                                                                                       | Summary                                                                                                                                                                                                                                                     |
| ---                                                                                                                                        | ---                                                                                                                                                                                                                                                         |
| [App.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\app\App.fsproj) | Enables building a behavior predictor app in the Better-Enemy-Impersonation-Mirage-Fork repository. Integrates Predictor, Embedding, and Whisper features through project references. Facilitates net8.0 development with documentation generation support. |
| [Main.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\app\Main.fs)       | Defines functions for registering user and mimic text input, along with error logging and test scenarios. Initiates asynchronous operations for text encoding and printouts, demonstrating policy and behavior prediction.                                  |

</details>

<details closed><summary>package.behaviour-predictor.embedding</summary>

| File                                                                                                                                                         | Summary                                                                                                                                                                                                                          |
| ---                                                                                                                                                          | ---                                                                                                                                                                                                                              |
| [Embedding.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\embedding\Embedding.fs)         | Defines and provides functions for initializing, encoding text batches, and calculating embedding similarity using an external BERT model. Supports asynchronous text embedding with batch processing.                           |
| [Embedding.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\embedding\Embedding.fsproj) | Defines dependencies, references, and file copies for the `Embedding` project in the `Behaviour Predictor` package. Facilitates integration with Mirage core functionality using FSharpPlus library and FSharpx.Async reference. |
| [NuGet.config](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\embedding\NuGet.config)         | Specifies NuGet package source for BepInEx in the repositorys package structure.                                                                                                                                                 |

</details>

<details closed><summary>package.behaviour-predictor.script</summary>

| File                                                                                                                                                    | Summary                                                                                                                                                                                                                                        |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                            |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\script\build.bat)             | Orchestrates building and packaging of the `behaviour-predictor` module by compiling associated projects, organizing DLLs, and creating necessary directories to streamline development and deployment processes.                              |
| [main.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\script\main.bat)               | Executes behavior prediction app using dotnet, navigating to the corresponding project file. Facilitates running the app within the overall repository architecture.                                                                           |
| [test.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\script\test.bat)               | Runs tests for behaviour prediction within the repository. Uses `dotnet test` to execute tests defined in the specified project file. Impacts quality assurance by verifying the accuracy and reliability of the behaviour prediction feature. |
| [test_single.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\script\test_single.bat) | Executes dotnet tests with specified filter argument for behavior predictor, enhancing test coverage and efficiency.                                                                                                                           |

</details>

<details closed><summary>package.behaviour-predictor.src</summary>

| File                                                                                                                                                   | Summary                                                                                                                                                                                                            |
| ---                                                                                                                                                    | ---                                                                                                                                                                                                                |
| [Predictor.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor.fsproj) | Defines project settings, dependencies, and source files for the behavior predictor module. Contributes to the Mirage architecture by enabling behavior prediction using various utilities, actions, and controls. |

</details>

<details closed><summary>package.behaviour-predictor.src.Predictor</summary>

| File                                                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                                                      | ---                                                                                                                                                                                                                                                                                    |
| [ActionSelector.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\ActionSelector.fs)       | Generates future actions based on observations using policy-based scoring, enabling seamless interaction. Leverages behavioral predictors and action selection to enhance player interactions within the Mirage game environment.                                                      |
| [Config.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Config.fs)                       | Defines configuration for behavior prediction model including voice buffer, observation interval, AFK threshold, file split size, policy update frequency, and talk bias scoring. Configurable values optimize model performance in predicting user behavior accurately.               |
| [DisposableAsync.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\DisposableAsync.fs)     | Enables asynchronous task cancellation using a disposable pattern. Creates a disposable object with a cancellation token source for managing async operations. Enhances control and resource cleanup within the parent repositorys architecture.                                       |
| [Domain.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Domain.fs)                       | Defines domain types and processing logic for generating observations and actions in a policy-based mimicry system. Manages data structures for learning and decision-making, including audio responses and future actions. Ensures efficient storage and access through policy files. |
| [EmitAction.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\EmitAction.fs)               | Generates action emissions with mimic text and timings, consuming queued actions in sequence for delayed playback. Maintains queue length consistency and logs whisper and VAD timings for each emitted action.                                                                        |
| [Learner.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Learner.fs)                     | Manages learner behavior by adding observations and responses, updating models, and sending data to relevant components within the system. Enables real-time learning and adaptation based on user interactions.                                                                       |
| [Lib.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Lib.fs)                             | Initializes and starts the behavior predictor, encoding text, loading models, and creating policy handlers. Handles user and mimic registrations, pings, and inactivity. Clear storage and memory functions included for testing purposes.                                             |
| [MimicPool.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\MimicPool.fs)                 | Manages mimics lifecycle, behavior, and statistics updates in a pool. Handles mimic initialization, removal, and communication with action emitters. Maintains a dictionary of active mimics for interaction with models.                                                              |
| [Model.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Model.fs)                         | Introduces a model with policies and recordings management, copy functions, and loading capabilities for behavior prediction. It facilitates interactions with policies and recordings data structures.                                                                                |
| [Observation.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Observation.fs)             | Generates observations, updates statistics, and handles cutoffs for a game AI. Manages spoken and heard data embeddings to enhance entity interactions, ensuring timely data processing and reducing memory load.                                                                      |
| [PolicyController.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\PolicyController.fs)   | Implements a policy updater for individual mimics, managing policy updates and recordings within the Mirage Framework architecture. The controller handles various actions like adding or removing recordings based on received messages.                                              |
| [PolicyFileHandler.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\PolicyFileHandler.fs) | Reading, writing, updating with Observation data and FutureAction, and managing storage size. Utilizes async processing, JSON serialization, error logging, and file manipulation tools.                                                                                               |
| [Score.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Score.fs)                         | Defines scoring, sampling, and future action logic to predict behaviors from observations in the Mirage architectures behaviour-predictor package.                                                                                                                                     |
| [Utilities.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\src\Predictor\Utilities.fs)                 | Enables asynchronous repeating of tasks with backoff strategy, comparison of embeddings, conversion of sorted dict to map, and weighted random sampling.                                                                                                                               |

</details>

<details closed><summary>package.behaviour-predictor.test</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                                                                         |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                             |
| [Test.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\test\Test.fsproj) | Defines test project configuration for the Behavior Predictor module, referencing related modules and necessary testing packages. Establishes targeted framework, test project status, and specific test files for behavior prediction testing. |

</details>

<details closed><summary>package.behaviour-predictor.test.Predictor.Test</summary>

| File                                                                                                                                               | Summary                                                                                                                                                                                                                                        |
| ---                                                                                                                                                | ---                                                                                                                                                                                                                                            |
| [Bar.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\test\Predictor\Test\Bar.fs) | Manages test scenarios for a behavior predictor, verifying actions and model performance. Supports mimic functionalities, timing computations, and user interactions. Tests mimic behavior, clear statistics, and replies in various contexts. |
| [Foo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\behaviour-predictor\test\Predictor\Test\Foo.fs) | Verifies predictor behavior through automated tests. Ensures expected behavior conforms to predefined assertions. Integration with external predictor library is validated.                                                                    |

</details>

<details closed><summary>package.mirage-core.script</summary>

| File                                                                                                                                | Summary                                                                                                                                                                                           |
| ---                                                                                                                                 | ---                                                                                                                                                                                               |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\script\build.bat) | Compiles and organizes Mirage.Core.dll in repositorys /bin.Initiates build process for Mirage.fsproj from src, clears existing bin directory, then moves the compiled dll to /bin for deployment. |

</details>

<details closed><summary>package.mirage-core.src</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                 |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                     |
| [Mirage.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage.fsproj) | Defines project settings and references for core functionality. Manages async operations, audio processing, and file handling. Facilitates seamless integration of essential libraries for async tasks and audio management within Mirage-Core package. |
| [NuGet.config](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\NuGet.config)   | Configures package source key and value for BepInEx in NuGet for the Mirage Core, facilitating dependency management within the repository structure.                                                                                                   |

</details>

<details closed><summary>package.mirage-core.src.Mirage.Core.Async</summary>

| File                                                                                                                                                               | Summary                                                                                                                                                                                                                                                                                      |
| ---                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                          |
| [AtomicFile.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\AtomicFile.fs)         | Implements atomic file writing and temp file cleanup. Supports retry on failure writes. Ensures data integrity during file updates.                                                                                                                                                          |
| [BatchProcessor.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\BatchProcessor.fs) | Enables creating a BatchProcessor from a batch processing function. Generates a function to process single values from the BatchProcessor. Ensures proper disposal of the BatchProcessor when necessary.                                                                                     |
| [Fork.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\Fork.fs)                     | Enables asynchronous program execution and value retrieval from a thread pool. Integrates BlockingQueueAgent to initiate and return async tasks, enhancing concurrency in Mirage Cores architecture.                                                                                         |
| [Lazy.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\Lazy.fs)                     | Enables seamless conversion of Task to Async without immediate evaluation, enhancing Mirage Cores asynchronous operations for efficient task handling and performance optimization.                                                                                                          |
| [Lock.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\Lock.fs)                     | Facilitates asynchronous locking mechanisms for thread safety. Provides methods to acquire, release, and manage locks efficiently. Supports ensuring exclusive access in concurrent environments by handling synchronization using SemaphoreSlim.                                            |
| [LVar.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\LVar.fs)                     | Implements locked variable operations for thread-safe concurrency handling in the Mirage Core Async module. Functions include reading, writing with or without return, accessing with transformation, and modifying values atomically.                                                       |
| [MVar.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\MVar.fs)                     | Implements MVar for concurrent operations based on Haskells Control.Concurrent.MVar. The MVar is backed by a MailboxProcessor, handling Put, Take, Read, IsEmpty, TryRead, and TryPut operations, ensuring proper thread management and operation synchronization.                           |
| [Print.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\Print.fs)                   | Print module synchronizes output and provides a function to print sequences, enhancing text clarity in async scenarios.                                                                                                                                                                      |
| [TVar.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Async\TVar.fs)                     | Defines transactional variables and a memory log, enabling atomic operations in software transactions. Implements retry and orElse functionality for robust transaction support. Introduces a builder pattern for composing software transactional memory operations easily and efficiently. |

</details>

<details closed><summary>package.mirage-core.src.Mirage.Core.Audio</summary>

| File                                                                                                                                         | Summary                                                                                                                                                                                                                             |
| ---                                                                                                                                          | ---                                                                                                                                                                                                                                 |
| [PCM.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\PCM.fs) | Converts PCM data to float32 array and vice versa, assuming 2 bytes/sample. Calculates audio sample length in milliseconds based on sample rate and channels. Key for manipulating audio data within the Mirage core functionality. |

</details>

<details closed><summary>package.mirage-core.src.Mirage.Core.Audio.File</summary>

| File                                                                                                                                                          | Summary                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                           | ---                                                                                                                                                                                                                                                           |
| [Mp3Reader.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\File\Mp3Reader.fs) | Enables reading mp3 files asynchronously, loading them in the background, and transferring them to the main thread. This functionality is encapsulated within the Mp3Reader module, facilitating seamless audio file processing in Mirages core architecture. |
| [Mp3Writer.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\File\Mp3Writer.fs) | Enables asynchronous creation and management of MP3 files for audio data, with capabilities to write frames, close files, retrieve file identifiers, and get file paths. Facilitates efficient audio file handling in the Mirage Core architecture.           |

</details>

<details closed><summary>package.mirage-core.src.Mirage.Core.Audio.Microphone</summary>

| File                                                                                                                                                                    | Summary                                                                                                                                                                                                                                               |
| ---                                                                                                                                                                     | ---                                                                                                                                                                                                                                                   |
| [Detection.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\Microphone\Detection.fs)     | Detects speech presence in audio using a VAD algorithm and triggers actions based on detection events. Async voice detection runs on separate threads, processing audio samples to determine speech probability.                                      |
| [Recognition.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\Microphone\Recognition.fs) | Enables real-time transcription of vocal audio, handling multiple players speech recognition and recording stages. Manages the transcription lifecycle and linguistic processing for seamless in-game communication within the Mirage-Core framework. |
| [Recorder.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\Microphone\Recorder.fs)       | Enables asynchronous recording of live audio from a microphone feed. Utilizes a blocking queue agent to handle detection actions and trigger corresponding recording events. Handles actions such as start, end, and found audio segments.            |
| [Resampler.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Core\Audio\Microphone\Resampler.fs)     | Defines a live microphone input resampler that processes audio frames by resampling audio samples to 16kHz mono-channel format. Handles input-driven resampling and triggers processing asynchronously.                                               |

</details>

<details closed><summary>package.mirage-core.src.Mirage.Prelude</summary>

| File                                                                                                                                                | Summary                                                                                                                                                                             |
| ---                                                                                                                                                 | ---                                                                                                                                                                                 |
| [Operator.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Mirage\Prelude\Operator.fs) | Enhances Mirages operations with inline operators for quick and efficient value modifications, including addition, subtraction, multiplication, division, and custom modifications. |

</details>

<details closed><summary>package.mirage-core.src.Properties</summary>

| File                                                                                                                                                    | Summary                                                                                                             |
| ---                                                                                                                                                     | ---                                                                                                                 |
| [AssemblyInfo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-core\src\Properties\AssemblyInfo.fs) | Defines security permissions for the Mirage Core assembly to request minimum access with skip verification enabled. |

</details>

<details closed><summary>package.mirage-cw</summary>

| File                                                                                                                               | Summary                                                                                                                                                             |
| ---                                                                                                                                | ---                                                                                                                                                                 |
| [manifest.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\manifest.json) | Name, version, description, dependencies. Facilitates enemy voice mimicry. Integral to Mirage-CW package functionality within the repositorys modular architecture. |

</details>

<details closed><summary>package.mirage-cw.script</summary>

| File                                                                                                                                  | Summary                                                                                                                                                                                                               |
| ---                                                                                                                                   | ---                                                                                                                                                                                                                   |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\script\build.bat)     | Builds the Mirage project, moves the resulting DLL to the bin directory, and cleans up previous builds. Key for compiling and organizing project outputs in the Mirage-Core package within the repositorys structure. |
| [package.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\script\package.bat) | Handles building, packaging, and distributing Mirage plugin files within the project structure, consolidating essential components for seamless deployment.                                                           |

</details>

<details closed><summary>package.mirage-cw.src</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                                                                                                             |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                                                                 |
| [Mirage.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage.fsproj) | Integrates key dependencies for Mirage, enhancing audio network functionalities, configuring plugin info, and supporting Unity components. Organizes namespaces and compiles essential modules for seamless integration within the parent repositorys architecture. |
| [NuGet.config](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\NuGet.config)   | Configures NuGet package sources for the Mirage-CW package in the repository. Enables access to external packages hosted on the BepInEx server for dependency management within the Mirage-CW project.                                                              |

</details>

<details closed><summary>package.mirage-cw.src.Mirage</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                    |
| ---                                                                                                                                           | ---                                                                                                                                                                                        |
| [Plugin.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Plugin.fs)         | Enhances Mirage plugin functionality by initializing logging, configurations, and patches. Manages audio recordings, DLL loading, and Harmony patches on Unity application start and exit. |
| [PluginInfo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\PluginInfo.fs) | PluginName, pluginId, pluginVersion. Centralizes plugin metadata for easy access and consistency across the repositorys Mirage component.                                                  |

</details>

<details closed><summary>package.mirage-cw.src.Mirage.Core</summary>

| File                                                                                                                                       | Summary                                                                                                                                                                                                                                                 |
| ---                                                                                                                                        | ---                                                                                                                                                                                                                                                     |
| [Config.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Config.fs) | Defines configuration settings for voice mimicry, enemy behavior, and personal preferences. Transforms local settings to synchronized format. Provides actions for syncing configurations. Functions enable retrieving and initializing configurations. |
| [Field.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Field.fs)   | Defines convenience types for class fields and getters, providing easy field initialization, retrieval, and modification in Mirage-Core. Promotes code readability and usability for managing field values in class instances seamlessly.               |
| [Logger.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Logger.fs) | Implements asynchronous logging functionality for Mirage plugin. Enables logging of different message types and handling of errors without rethrowing. Supports initialization and logging operations to enhance plugin robustness and performance.     |
| [Monad.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Monad.fs)   | Enables running and forking asynchronous operations with cancellation handling. Lifts a Result into ResultT, enhancing error handling through functional programming constructs.                                                                        |

</details>

<details closed><summary>package.mirage-cw.src.Mirage.Core.Audio</summary>

| File                                                                                                                                                   | Summary                                                                                                                                                                                                                                                |
| ---                                                                                                                                                    | ---                                                                                                                                                                                                                                                    |
| [Data.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Data.fs)           | Defines FrameData and PcmHeader structs. Extracts PCM header from an Mp3FileReader. Contributing to Mirage Cores audio data processing capabilities.                                                                                                   |
| [Format.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Format.fs)       | Converts MP3 frame data to PCM format-Throws exception if invalid bytes-Compresses WAV to MP3 in-memory-Decompresses MP3 to WAV-Converts WaveFileReader to AudioClip-Handles byte-to-float32 array conversion-Handles float32-to-byte array conversion |
| [Recording.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Recording.fs) | Manages audio recordings for local player, including deletion and retrieval functionalities based on imitation mode configuration.                                                                                                                     |
| [Resampler.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Resampler.fs) | Resampling audio samples while managing buffer sizes efficiently. Works seamlessly within the Mirage-CW packages audio processing architecture.                                                                                                        |

</details>

<details closed><summary>package.mirage-cw.src.Mirage.Core.Audio.Network</summary>

| File                                                                                                                                                         | Summary                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                                          | ---                                                                                                                                                                                                                                                                            |
| [Receiver.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Network\Receiver.fs) | Manages audio reception, playback, and timeouts for the Mirage system. Functions include stopping playback, starting reception, setting audio frames, and handling timeouts. Enables dynamic audio processing and live playback integration.                                   |
| [Sender.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Network\Sender.fs)     | Facilitates audio streaming to multiple recipients. Manages audio sender state, initiates and ceases audio transmission. Monitors sender activity and ensures proper resource cleanup. Crucial for real-time audio communication in the Mirage projects architecture.          |
| [Stream.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Core\Audio\Network\Stream.fs)     | Generates audio stream delays for accurate buffering. Handles timing intricacies efficiently to ensure smooth playback, incorporating precise delay calculations to maintain the desired audio buffer. Integrates with the Mirage frameworks audio processing flow seamlessly. |

</details>

<details closed><summary>package.mirage-cw.src.Mirage.Patch</summary>

| File                                                                                                                                                        | Summary                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                |
| [RecordAudio.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Patch\RecordAudio.fs)       | Orchestrates real-time audio recording, resampling, and voice activity detection.-Manages audio buffer processing, disk recording, and integrates with PhotonVoice and HarmonyLib for game audio management.                                                                                       |
| [RegisterPrefab.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Patch\RegisterPrefab.fs) | Implements dynamic prefab registrations for audio-related components in Unity game enemy entities. Handles prefab creation and attachment of necessary components for voice mimicry and audio streaming during gameplay. Aims to enhance immersion and player experience in the Mirage-CW package. |
| [SyncConfig.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Patch\SyncConfig.fs)         | Implements SyncConfig to handle configuration synchronization in gameplay events. Utilizes HarmonyLib to manage config handlers for client-server communication triggers.                                                                                                                          |

</details>

<details closed><summary>package.mirage-cw.src.Mirage.Unity</summary>

| File                                                                                                                                                      | Summary                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                       | ---                                                                                                                                                                                                                                                                      |
| [AudioStream.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Unity\AudioStream.fs)     | Enables streaming audio between host and clients, facilitating audio upload and playback synchronization. Implements audio streaming functionalities, broadcast capabilities, and client-server interactions for seamless audio transmission in a networked environment. |
| [ConfigHandler.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Unity\ConfigHandler.fs) | Implements a Unity ConfigHandler for syncing config data bidirectionally between host and clients. Enables setting and updating various configuration parameters for networked entities within the Mirage framework.                                                     |
| [MimicPlayer.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Unity\MimicPlayer.fs)     | Manages player mirroring based on config settings and handles RPC calls for audio mixing. Acquires mimicked player data on non-host clients and sets audio accordingly. Maintains a player pool to prevent duplicates.                                                   |
| [MimicVoice.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Unity\MimicVoice.fs)       | Implements RPC voice mirroring with Unity components. Handles mimicking local players voice, audio streaming, player configuration, and dynamic playback positioning. Offers flexibility for voice mimic timing and local player muting.                                 |
| [RpcBehaviour.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Mirage\Unity\RpcBehaviour.fs)   | Defines network behavior for Unity game objects, registering and deregistering them. Facilitates server and client RPC method invocations with specified or default reliability. Integrated with MyceliumNetworking and Photon.Pun libraries.                            |

</details>

<details closed><summary>package.mirage-cw.src.Properties</summary>

| File                                                                                                                                                  | Summary                                                                                                                                               |
| ---                                                                                                                                                   | ---                                                                                                                                                   |
| [AssemblyInfo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-cw\src\Properties\AssemblyInfo.fs) | Defines security permissions for assembly. Enforces SkipVerification. Part of Mirage-CW package in Better-Enemy-Impersonation-Mirage-Fork repository. |

</details>

<details closed><summary>package.mirage-lc</summary>

| File                                                                                                                                                         | Summary                                                                                                                                                    |
| ---                                                                                                                                                          | ---                                                                                                                                                        |
| [manifest-experimental.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\manifest-experimental.json) | Defines dependencies and metadata for MirageExperimental in the Mirage-lc package. Marks as experimental with caution. Links to GitHub for more.           |
| [manifest.json](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\manifest.json)                           | Defines Mirage' mod details for synced voice mimicking in-game enemy interactions.-Specifies version, dependencies, and website for independent operation. |

</details>

<details closed><summary>package.mirage-lc.script</summary>

| File                                                                                                                                                            | Summary                                                                                                                                                                                                    |
| ---                                                                                                                                                             | ---                                                                                                                                                                                                        |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\script\build.bat)                               | Build script automates Mirage project compilation and packaging by executing dotnet build, relocating generated DLL to bin folder, and cleaning previous builds.                                           |
| [package-experimental.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\script\package-experimental.bat) | Creates experimental package by building, moving, and compressing files. Transfers Mirage.dll, generates manifest.json, and bundles essential project files into mirage-experimental.zip for distribution. |
| [package.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\script\package.bat)                           | Automates build process by moving, compressing files to create mirage.zip for BepInEx plugins.                                                                                                             |

</details>

<details closed><summary>package.mirage-lc.src</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                                                                                                            |
| [Mirage.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage.fsproj) | Enables seamless integration of audio manipulation and prediction features into the Mirage framework. Key inclusions comprise domain entities, audio recording and streaming capabilities, mimicry functionalities, and Unity-specific hooks. Dependencies are efficiently managed for holistic functionality. |
| [NuGet.config](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\NuGet.config)   | Configures NuGet package source for BepInEx within Mirage-LC package.                                                                                                                                                                                                                                          |

</details>

<details closed><summary>package.mirage-lc.src.Mirage</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                   |
| ---                                                                                                                                           | ---                                                                                                                                                                                       |
| [Plugin.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Plugin.fs)         | Initiates key system components, such as Whisper and SileroVAD, configures behavior predictor, and hooks audio functionalities. Orchestrates voice recognition and processing for gaming. |
| [PluginInfo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\PluginInfo.fs) | PluginName, pluginId, and pluginVersion, essential for plugin identity and version tracking in the repository architecture.                                                               |

</details>

<details closed><summary>package.mirage-lc.src.Mirage.Domain</summary>

| File                                                                                                                                           | Summary                                                                                                                                                                                                                   |
| ---                                                                                                                                            | ---                                                                                                                                                                                                                       |
| [Logger.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Logger.fs)   | Facilitates logging operations within the Mirage domain. Implements different log types and manages log messages using a blocking queue agent. Supports logging methods for information, debugging, warnings, and errors. |
| [Netcode.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Netcode.fs) | Enables automatic initialization of netcode patcher upon plugin startup by invoking methods with specific attributes. Facilitates seamless integration for enhancing netcode functionalities in Unity projects.           |

</details>

<details closed><summary>package.mirage-lc.src.Mirage.Domain.Audio</summary>

| File                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                       |
| [Frame.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Frame.fs)           | Defines structures for audio frame data and PCM header with network serialization. Creates PCM header from MP3 reader. Implements decompression function converting MP3 frames to PCM format.                                                                                                                             |
| [Microphone.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Microphone.fs) | Processes microphone audio for transcription, detecting speech & transcribing it locally or via a host. Manages requests & responses, enabling real-time audio processing. Handles audio frames using resampling, detection, recording, and transcription functionality within the Mirage repositorys audio architecture. |
| [Receiver.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Receiver.fs)     | Enables receiving and playing live audio data through the AudioReceiver component. Handles audio source management and frame data playback. Facilitates seamless integration for real-time audio processing.                                                                                                              |
| [Recording.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Recording.fs)   | Manages, deletes, and retrieves recordings in the designated directory, optimizing for performance and reducing redundancies. Enables efficient handling of audio files based on imitation mode configurations within the Mirage application.                                                                             |
| [Sender.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Sender.fs)         | Coordinates audio transmission to all receivers.-Initializes sender, starts sending audio frames.-Producer processes frames, consumer triggers send function.-File supports.wav audio files.                                                                                                                              |
| [Stream.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Domain\Audio\Stream.fs)         | Streams audio frames with buffer delay management, ensuring real-time processing and disposal of the audio reader. Handles timing between payloads for seamless playback.                                                                                                                                                 |

</details>

<details closed><summary>package.mirage-lc.src.Mirage.Hook</summary>

| File                                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                |
| [AudioSpatializer.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\AudioSpatializer.fs)   | Enhances audio spatial performance by eliminating log spam. Credits to IAmBatby and mattymatty. Disables spatializer plugin if nonexistent or zero, improving overall sound quality.                                                                                                               |
| [Dissonance.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\Dissonance.fs)               | Implements functionality to fetch and store a Dissonance communication component within the Mirage application.                                                                                                                                                                                    |
| [MaskedPlayerEnemy.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\MaskedPlayerEnemy.fs) | Initiates player-mimicking for masked enemies, aligning with mod compatibility. Triggers MimicPlayer.StartMimicking() within MaskedPlayerEnemy.Start(). Maintains harmony with mods that mimic players on startup.                                                                                 |
| [Microphone.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\Microphone.fs)               | Enables microphone data processing for real-time transcription and async audio recording synchronization. Handles audio glitches during gameplay, ensuring reliable recording start after the opening sequence. Implements hooks for client connection events, optimizing performance on the host. |
| [Predictor.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\Predictor.fs)                 | Initiates Steam client and starts behavior predictor on facepunch transport awake. Logs and handles errors for steam initialization. Ensures smooth interactions between Steamworks and MirageAI for reliable performance within the repository architecture.                                      |
| [RegisterPrefab.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Hook\RegisterPrefab.fs)       | Implements networked prefab registration and component initialization for EnemyAI types. Adds necessary components to prefabs on game initialization and player awakenings, enhancing gameplay with audio, voice mimic, and prediction functionalities in the Mirage-LC package.                   |

</details>

<details closed><summary>package.mirage-lc.src.Mirage.Unity</summary>

| File                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                    |
| [AudioStream.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Unity\AudioStream.fs) | Enables audio streaming between players, triggering playback locally while broadcasting to others. Validates sender client ID, loads and streams audio files server-side, and initializes audio receivers. Facilitates bidirectional frame communication and audio playback management across clients. |
| [MimicPlayer.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Unity\MimicPlayer.fs) | Implements functionality to mimic player behavior and visuals for specific enemy types. Controls player selection, mimicry activation, and event triggers for seamless gameplay interaction.                                                                                                           |
| [MimicVoice.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Unity\MimicVoice.fs)   | Implements voice mimicry functionality for Mirage-LC package, synchronizing mimic audio with parent location, handling audio streaming, and network spawning/despawning. Mimics player voice and manages audio playback objects.                                                                       |
| [Predictor.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Unity\Predictor.fs)     | Manages game input handling with MimicPlayer and PlayerControllerB, synchronizing audio and text data through client and server RPCs for local and non-local player entities.                                                                                                                          |
| [Recognition.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Mirage\Unity\Recognition.fs) | Enables real-time transcription for multiplayer game voice chat. Handles speech detection, processing, and communication between players. Maintains player states and synchronizes speech data across clients and the host server.                                                                     |

</details>

<details closed><summary>package.mirage-lc.src.Properties</summary>

| File                                                                                                                                                  | Summary                                                                                       |
| ---                                                                                                                                                   | ---                                                                                           |
| [AssemblyInfo.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\mirage-lc\src\Properties\AssemblyInfo.fs) | Enables security permissions for Mirage-LC package in the repository via AssemblyInfo module. |

</details>

<details closed><summary>package.openai-whisper.app</summary>

| File                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                  |
| [App.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\app\App.fsproj) | Defines project settings, references dependencies, and manages content for the `openai-whisper` app. Integrates with Whisper and Silero projects, includes NAudio references, and configures content paths for output directory.                                                                                                     |
| [Main.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\app\Main.fs)       | Initiates a continuous speech transcription process, incorporating audio frame handling and speech detection. Implements a real-time audio recording setup with speech recognition functionalities. Extensively leverages the Silero API and Whisper API for transcription and audio handling tasks in the Mirage core architecture. |

</details>

<details closed><summary>package.openai-whisper.lib</summary>

| File                                                                                                                                | Summary                                                                                                                                                                                                                                   |
| ---                                                                                                                                 | ---                                                                                                                                                                                                                                       |
| [main.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\main.py)     | Handles real-time speech transcription requests, leveraging the WhisperModelCT2 for processing audio samples with VAD. Determines CUDA availability, initializes models, receives and responds to requests. Log exceptions for debugging. |
| [main.spec](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\main.spec) | Facilitates PyInstaller setup for key Python modules, ensuring seamless binary compilation. Manages data files and hidden imports, optimizing the packaging process for the main executable with specified configurations.                |
| [test.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\test.py)     | Tests transcribing speech using the Whisper model from the `WhisperModelCT2` class. Verifies correct output against expected text.                                                                                                        |

</details>

<details closed><summary>package.openai-whisper.lib.src</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                         |
| [audio.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\audio.py)         | Enhances audio processing for in-memory transcription. Converts signals, pads or trims arrays to N_SAMPLES, and computes mel spectrograms. Employs Torch, numpy, and whisper_s2t for robust transcription support.                                                                                                                          |
| [frame_vad.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\frame_vad.py) | Implements frame-based voice activity detection using pretrained models for efficient speech segmentation. Resides in the openai-whisper package of the repository.                                                                                                                                                                         |
| [loader.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\loader.py)       | Generates segmented audio data batches for processing based on audio signal properties, leveraging speech segmenting and data loading functionalities within the repositorys WhisperS2T package.                                                                                                                                            |
| [model.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\model.py)         | Enhances open-source WhisperS2T for in-memory transcriptions, providing customizable ASR options, multilingual support, and efficient word timings alignment. Facilitates seamless transcription improvements with dynamic time axis padding and speech segmentation. Maintains compatibility with MIT-licensed WhisperS2T functionalities. |
| [segmenter.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\segmenter.py) | Implements speech segmentation for transcriptions in WhisperS2T with adjustable parameters and efficient merging logic. Segments audio based on silence thresholds and segment length, handling silent audio cases gracefully.                                                                                                              |
| [tokenizer.py](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\lib\src\tokenizer.py) | Implements tokenization and encoding for multi-language tasks in WhisperS2T. Handles splitting text into word tokens based on language-specific characteristics, supporting in-memory transcriptions. Manages special tokens and language codes for efficient processing.                                                                   |

</details>

<details closed><summary>package.openai-whisper.script</summary>

| File                                                                                                                                                             | Summary                                                                                                                                                                                                                                       |
| ---                                                                                                                                                              | ---                                                                                                                                                                                                                                           |
| [build-lib.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\build-lib.bat)                   | Build script automates packaging for openai-whisper module. Activates environment, compiles with PyInstaller based on main.spec, and copies necessary DLL file for distribution.                                                              |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\build.bat)                           | Compiles `OpenAI.Whisper` project to `bin` directory, ensuring build success and relocating the DLL for repository integration.                                                                                                               |
| [export-environment.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\export-environment.bat) | Exports Conda environment to YAML file for Mirage project from whisper environment, excluding the prefix.                                                                                                                                     |
| [main.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\main.bat)                             | Executes Mirage core functionality via a script, integrating the openai-whisper package into the parent repositorys architecture..kerasologizes the application utilizing dotnet run command.                                                 |
| [test-lib.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\test-lib.bat)                     | Runs unit tests for the openai-whisper package by invoking Python scripts through Conda. The script navigates to the lib directory, executes tests, then returns to the script directory for test execution.                                  |
| [test.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\script\test.bat)                             | Executes automated tests in the `Test.fsproj` file using `dotnet test` command. Supports testing functionalities within the openai-whisper package. Key component contributing to the quality assurance of the parent repository's functions. |

</details>

<details closed><summary>package.openai-whisper.src</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                                                                              |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                                  |
| [Whisper.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\src\Whisper.fsproj) | Defines project settings, references, and files for the OpenAI Whisper package. This file sets the target framework, assembly details, references Mirage core, includes necessary libraries, and compiles relevant Whisper API and Transcribe files. |

</details>

<details closed><summary>package.openai-whisper.src.Whisper</summary>

| File                                                                                                                                                | Summary                                                                                                                                                                                                                |
| ---                                                                                                                                                 | ---                                                                                                                                                                                                                    |
| [API.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\src\Whisper\API.fs)               | Initializes whisper process, manages logging, and controls access via locks.-Transcribes audio samples to text, handling process communication and error responses.-Handles process start and shutdown gracefully.     |
| [Transcribe.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\src\Whisper\Transcribe.fs) | Enables real-time transcription using the Whisper API. Implements a Transcriber type with a Whisper instance and a lock, facilitating thread-safe transcription operations within the parent repositorys architecture. |

</details>

<details closed><summary>package.openai-whisper.test</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                       |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                           |
| [Test.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\test\Test.fsproj) | Defines project settings and dependencies for testing Whisper functionality. References core project files and external libraries (NAudio). Copies necessary files to the output directory, facilitating transcription tests using pre-made audio recordings. |

</details>

<details closed><summary>package.openai-whisper.test.Whisper.Test</summary>

| File                                                                                                                                                      | Summary                                                                                                                                                                                                                                  |
| ---                                                                                                                                                       | ---                                                                                                                                                                                                                                      |
| [Transcribe.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\openai-whisper\test\Whisper\Test\Transcribe.fs) | Tests transcription on audio samples using the Whisper API. Runs batch transcriptions and measures elapsed time. Initializes and stops Whisper for testing, reading audio data from a file. Verifies test results against expected text. |

</details>

<details closed><summary>package.silero-vad</summary>

| File                                                                                                                    | Summary                                                                  |
| ---                                                                                                                     | ---                                                                      |
| [jfk.txt](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\jfk.txt) | Reveal version information for the silero-vad package in the repository. |

</details>

<details closed><summary>package.silero-vad.app</summary>

| File                                                                                                                              | Summary                                                                                                                                                                                                                               |
| ---                                                                                                                               | ---                                                                                                                                                                                                                                   |
| [App.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\app\App.fsproj) | Defines project settings, references dependencies, and compiles the main file for the Silero Voice Activity Detection package within the repository. Integrates FSharpPlus, NAudio, and Mirage components for seamless functionality. |
| [Main.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\app\Main.fs)       | Implements real-time audio detection and transcription with Silero using LAME encoding. Handles speech events, recording to MP3 files, within the Mirage projects architecture.                                                       |

</details>

<details closed><summary>package.silero-vad.lib</summary>

| File                                                                                                                                  | Summary                                                                                                                                                                                                                                          |
| ---                                                                                                                                   | ---                                                                                                                                                                                                                                              |
| [silero-vad.c](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\lib\silero-vad.c) | Enables speech detection using specified PCM data structure and inference model. Initializes and releases resources for running audio analysis. Key features include handling input tensors, running inference, and managing memory effectively. |

</details>

<details closed><summary>package.silero-vad.script</summary>

| File                                                                                                                                                         | Summary                                                                                                                                                                                                                            |
| ---                                                                                                                                                          | ---                                                                                                                                                                                                                                |
| [build-lib.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\script\build-lib.bat)                   | Compiles Silero VAD API by linking implementation files and external libraries. Cleans and creates necessary directories for the build process. Contributes to the audio processing functionalities of the Mirage Fork repository. |
| [build.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\script\build.bat)                           | Builds and moves Silero Voice Activity Detection API binaries to the designated bin directory, supporting the parent repositorys modularity and encapsulation through clear separation of concerns.                                |
| [export-environment.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\script\export-environment.bat) | Updates environment.yml in lib folder by exporting whisper Conda environment settings, excluding prefix. Enhances project configuration and ensures consistent environment replication for silero-vad package.                     |
| [main.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\script\main.bat)                             | Executes voice activity detection using Silero VAD model with a simple batch script. Invokes the app project for functionality, contributing to Mirages voice impersonation capabilities.                                          |
| [test.bat](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\script\test.bat)                             | Runs test suite for voice activity detection using Silero VAD package. Initiates automated tests for voice detection functionality in the system.                                                                                  |

</details>

<details closed><summary>package.silero-vad.src</summary>

| File                                                                                                                                    | Summary                                                                                                                                                                                                                              |
| ---                                                                                                                                     | ---                                                                                                                                                                                                                                  |
| [Silero.fsproj](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\src\Silero.fsproj) | Defines project settings and dependencies for the Silero Voice Activity Detection library. Maps required files for compilation and includes necessary components. Facilitates integration with FSharpPlus and onnxruntime libraries. |

</details>

<details closed><summary>package.silero-vad.src.Silero</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                                       |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                                           |
| [API.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\src\Silero\API.fs)         | Defines SileroVAD initialization, resource release, and speech detection for audio samples in the repositorys Speech Detection package. It leverages native resources efficiently to analyze speech presence based on specific audio data specifications.                     |
| [Foreign.fs](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/master/package\silero-vad\src\Silero\Foreign.fs) | Enables interfacing with Silero VAD API DLL for speech detection. Initializes and releases resources, as well as detects speech using specified parameters. Integrates seamlessly within the Mirage Fork repositorys architecture for enhanced audio processing capabilities. |

</details>

---

## 🚀 Getting Started

**System Requirements:**

* **FSharp**: `version x.y.z`

### ⚙️ Installation

<h4>From <code>source</code></h4>

> 1. Clone the Better-Enemy-Impersonation-Mirage-Fork repository:
>
> ```console
> $ git clone https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd Better-Enemy-Impersonation-Mirage-Fork
> ```
>
> 3. Install the dependencies:
> ```console
> $ > INSERT-INSTALL-COMMANDS
> ```

### 🤖 Usage

<h4>From <code>source</code></h4>

> Run Better-Enemy-Impersonation-Mirage-Fork using the command below:
> ```console
> $ > INSERT-RUN-COMMANDS
> ```

### 🧪 Tests

> Run the test suite using the command below:
> ```console
> $ > INSERT-TEST-COMMANDS
> ```

---

## 🛠 Project Roadmap

- [X] `► INSERT-TASK-1`
- [ ] `► INSERT-TASK-2`
- [ ] `► ...`

---

## 🤝 Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Report Issues](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/issues)**: Submit bugs found or log feature requests for the `Better-Enemy-Impersonation-Mirage-Fork` project.
- **[Submit Pull Requests](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/discussions)**: Share your insights, provide feedback, or ask questions.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="center">
   <a href="https://github.com{/AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=AndrewEllen/Better-Enemy-Impersonation-Mirage-Fork">
   </a>
</p>
</details>

---

## 🎗 License

This project is protected under the [SELECT-A-LICENSE](https://choosealicense.com/licenses) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

## 🔗 Acknowledgments

- List any resources, contributors, inspiration, etc. here.

[**Return**](#-overview)

---
