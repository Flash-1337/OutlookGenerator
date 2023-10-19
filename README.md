# Outlook Account Generator

![GitHub repo size](https://img.shields.io/github/repo-size/Flash-1337/OutlookGenerator)
![GitHub issues](https://img.shields.io/github/issues/Flash-1337/OutlookGenerator)
![GitHub stars](https://img.shields.io/github/stars/Flash-1337/OutlookGenerator)
![GitHub forks](https://img.shields.io/github/forks/Flash-1337/OutlookGenerator)

A C# .NET 7.0 Outlook account generator that leverages Puppeteer Sharp. This tool allows you to automate the creation of Outlook email accounts programmatically using the power of Puppeteer Sharp, a .NET port of the Puppeteer JavaScript library.

## Download

- You can download the latest release [here](https://github.com/Flash-1337/OutlookGenerator/releases/latest)

## Features

- Create Outlook email accounts programmatically.
- Automate the process of filling out account registration forms.
- Generate strong and secure passwords for each account.

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Puppeteer Sharp](https://github.com/hardkoded/puppeteer-sharp)

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Flash-1337/OutlookGenerator.git
   ```

2. Open the solution file `OutlookAccountGenerator.sln` in Visual Studio.

3. Restore the NuGet packages by right-clicking on the solution in Solution Explorer and selecting **Restore NuGet Packages**.

4. Build the solution by right-clicking on the solution in Solution Explorer and selecting **Build Solution**.

## Usage

1. Modify the `Program.cs` file to customize the account generation process according to your requirements.

2. Run the application and observe the automated account generation process.

3. Upon completion, the generated account details will be saved to a CSV file named `accounts.csv`.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## Support

For support or questions, please [open an issue](https://github.com/Flash-1337/OutlookGenerator/issues).

## Acknowledgements

This project uses the following third-party libraries:

- [Puppeteer Sharp](https://github.com/hardkoded/puppeteer-sharp)

Special thanks to the contributors of Puppeteer Sharp for their amazing work.

## Disclaimer

This tool is provided for educational and research purposes only. Usage of this tool for any malicious activities is strictly prohibited. The author and contributors of this repository are not responsible for any misuse or damage caused by this tool.
