# School financial benchmarking test Automation Framework

This repository contains a test project developed using Selenium WebDriver and C#. The purpose of this project is to showcase automated testing for web applications. Below are the instructions to set up the project and run the tests successfully.

## Getting Started

### Prerequisites

Make sure you have the following installed on your system:

1. [Visual Studio](https://visualstudio.microsoft.com/downloads/) - A development IDE for C#.
2. [.NET SDK](https://dotnet.microsoft.com/download) - The .NET Software Development Kit.
3. [Chrome](https://www.google.com/chrome/) or [Firefox](https://www.mozilla.org/en-US/firefox/new/) browser installed on your machine.

### Clone the Repository

To get started, clone this repository to your local machine using the following command:

```
git clone https://github.com/yourusername/selenium-test-project.git
```

### Downloading NuGet Dependencies

1. Open the solution file `SeleniumTestProject.sln` in Visual Studio.
2. Once the solution is open, right-click on the solution name in the Solution Explorer and select "Restore NuGet Packages." This will download all the necessary dependencies for the project.

### Configuring Browser Driver Locations

In this project, we use the WebDriver executables to interact with browsers. To make it work correctly, you need to provide the appropriate browser driver locations.

1. Open the `config.cs` file located in the  project.
2. Update the `ChromeDriverPath` and `FirefoxDriverPath` with the absolute path of the respective browser driver executables on your machine. For example:

   ```
   {
     "ChromeDriverPath": "C:\\path\\to\\chromedriver.exe",
     "FirefoxDriverPath": "C:\\path\\to\\geckodriver.exe"
   }
   ```

  

## Running Tests.

To run the tests, follow these steps:

1. Build the solution in Visual Studio to ensure there are no compilation errors.
2. Open the Test Explorer (usually found under "Test" > "Windows" > "Test Explorer").
3. In the Test Explorer window, click on the "Run All" button to execute all the tests.

The automated tests will now run using the configured browsers and driver locations.

## Contributing

If you find any issues or have improvements to suggest, feel free to create a pull request or open an issue. We welcome contributions from the community!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Thank you for using our Selenium Test Project. Happy testing! If you have any questions, feel free to reach out to me (carlossik@gmail.com).
