# Hudl
Hudl Automation Tests that test for login along with password rest functionality.

## Requirements

### Software and specifications
* Windows 10 
* Visual Studio 2017
* .NET Framework 4.6.1
* ReSharper (latest)
* Chrome browser 
* Screen with minimum resolution 1280px x 800px

### Plugins & Assemblies

System.Configuration reference added in the project from References management in Visual Studio

### Nuget Packages
* NUnit version="3.0.0"
* Selenium.Support version="3.141.0"
* Selenium.WebDriver version="3.141.0" 
* Selenium.WebDriver.ChromeDriver

## Running Steps
* After installing advised software, clone the repro from github
* Open the .sln file
* Restore/Install all mentioned Nuget packages in Visual Studio
* Add the System.Configuration reference in the project from References management in Visual Studio
* Ensure you have installed Selenium.WebDriver.ChromeDriver Nuget package by author jsakamoto
* Build solution
* Using Resharper Unit Tests option, run the tests

## Tests
1) Test "CanLoginSuccessfullyUsingCorrectCredentials" tests for successful login of resgistered user.

2) Test "CannotLoginUsingIncorrectCredentials" tests for unauthorised login of registered user when providing incorrect password

3) Test "CanRequestPasswordResetEmail" tests for journey of requesting a password reset email successfully.
