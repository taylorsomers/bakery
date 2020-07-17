# Bakery

  ### By Taylor Somers

## Description

  This is a console program created with C# and .NET and is the first major project I have completed using this new programming language. It simulates a bakery user-interface that will greet a customer, confirm whether the customer would like to place an order, collect the number of bread loaves and pastries the customer would like to order, and calculate a discounted price for the total order depending on the amount of each item ordered.

## Languages & Technologies Used:

  ### Programming Languages & Libraries
  * C#
  * .NET

  ### Operating Systems & Programs
  * Brave
  * Git Bash
  * Microsoft Windows 10
  * Visual Studio Code
  * .NET Core

## Installation

  1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
  2.  Navigate to https://github.com/taylorsomers/bakery.
  3.  Click the green "Clone or download" button at the right of the screen.
  4.  Select "Download ZIP."
  5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
  6.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  7.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
  8.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
  9.  Enter the command "dotnet build" in the terminal.
  10. Enter the command "dotnet run" in the terminal. The program should begin to run in the console.
  

## Specifications

  | Program Behavior | Example Behavior | Example Output |
  | ----------- | ----------- | ----------- |
  | Program will prompt the user with a welcome message and prices for both bread and pastries. | "dotnet run" | "Welcome to Pierre's Bakery! We are very happy to serve you today. At Pierre's we offer bread loaves and pastries, both freshly made to order. Would you like to place an order today? Type Y for Yes or N for No." |
  | Program will collect the number of loaves of bread the user wants to order. | "Y" | "Great! Our price per loaf of bread is $5. For every two loaves you order, the third is free! Pastries are $2 per item, and $1 off for every third pastry you order. To get started, please tell us how many loaves of bread you would like to order: " |
  | Program will collect the number of pastries the user wants to order. | "4" |  |
  | Program will calculate the order price based on the number of loaves of bread and the number of pastries the user wants to order. |  |  |
  | In calculating the total order price, the program will apply a discount on bread in the amount of $5.00 for every three loaves that are ordered. |  |  |
  | In calculating the total order price, the program will apply a discount on patries in the amount of $1.00 for every three pastries that are ordered. |  |  |


## Known Bugs

  * No known bugs at this time. If any are discovered, please feel free to reach out and let me know. If you would like to contribute any fixes or improvements, please do!

### Contributors

  * Taylor Somers

### License

This program is free to use under the GNU General Public License GPLv3. (C) 2020 Taylor Somers. All rights reserved.