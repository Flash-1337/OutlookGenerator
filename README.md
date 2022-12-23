# Outlook Generator
**An automated Outlook account generator**
![image](https://media.discordapp.net/attachments/995854349488103485/996307097480331294/unknown.png)

## Packages 
All of these can be found on NuGet under the project tab in Visual Studio.
 - [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms/2.0.3.2?_src=template) - WinForms UI library (what makes the interface look really nice)
 - [Selenium](https://www.nuget.org/packages/Selenium.WebDriver/4.3.0?_src=template) - Lets the program control a browser to automate account creation
 - [Bogus](https://www.nuget.org/packages/Bogus) - Creates fake user agents to bypass some fingerprinting, allowing for less captchas
 - [Costura.Fody](https://www.nuget.org/packages/Costura.Fody/5.7.0?_src=template) - Packs all of these libraries into one .exe file

## Open source
What you CAN do:
- Really anything as long as you abide by the license and give me credit for any code used

## How to setup
- Download the generator and place it in its own folder
- Download the Firefox driver that matches your version from https://github.com/mozilla/geckodriver/releases
  - If you're not sure, download the latest one
- Once downloaded, place the driver in the same folder as the account generator
- Run the generator and have fun making accounts
