# Facebook Desktop App

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

The Facebook Desktop App is a Windows Forms application that provides a desktop-friendly interface for using Facebook features. This project showcases the implementation of several design patterns such as Singleton, Facade, and Strategy, which improve the application's maintainability, flexibility, and structure.

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Design Patterns](#design-patterns)
  - [Singleton](#singleton)
  - [Facade](#facade)
  - [Strategy](#strategy)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites

Before running the Facebook Desktop App, make sure you have the following prerequisites installed on your system:

- .NET Framework 4.8 or higher
- Windows Operating System (Tested on Windows 10)

### Installation

1. Clone this repository to your local machine using Git:

   ```bash
   git clone https://github.com/your-username/facebook-desktop-app.git
   ```

2. Navigate to the `facebookwinformsapp` folder:

   ```bash
   cd facebook-desktop-app/facebookwinformsapp
   ```

3. Compile and run the application by executing `Program.cs`.

## Design Patterns

This application utilizes the following design patterns:

### Singleton

The Singleton pattern ensures that a class has only one instance and provides a global access point to that instance. In the Facebook Desktop App, the Singleton pattern is used in the `FacebookApiService` class to ensure there is only one instance of the Facebook API service throughout the application's lifecycle.

### Facade

The Facade pattern provides a simplified interface to a complex subsystem. In this app, the `FacebookFacade` class acts as a facade, hiding the complexities of interacting with various Facebook services and APIs. It provides a unified and straightforward interface for the rest of the application to communicate with Facebook services.

### Strategy

The Strategy pattern defines a family of algorithms, encapsulates each one of them, and makes them interchangeable. The Facebook Desktop App employs the Strategy pattern to implement different posting strategies, such as text posts, image posts, and video posts. Each posting strategy is encapsulated in its class, allowing the application to switch between strategies dynamically.

## Usage

Upon launching the Facebook Desktop App, you will be presented with an intuitive user interface that mimics the Facebook web application. You can log in with your Facebook credentials and access various features, such as viewing the news feed, posting updates, commenting on posts, and more.

The design patterns utilized in this application make it easy to extend and modify functionality. Developers can add new posting strategies, integrate additional Facebook APIs, or enhance the facade to include more features without affecting the core structure of the application.

## Contributing

We welcome contributions to improve the Facebook Desktop App. If you have any bug fixes, new features, or improvements to offer, please follow the standard GitHub fork and pull request workflow. We review all pull requests and appreciate your contributions.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
