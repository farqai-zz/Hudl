using System.Threading;
using HudlAutomation.PageObjects;
using HudlAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HudlAutomation.Tests
{
    [TestFixture]
    class LoginTests : DriverSetting
    {
        private IWebDriver _driver;
        private HomePage _homePage;
        private LoginPage _loginPage;
        private MainPage _mainPage;

        [TestCase("farhad_89@hotmail.com", "qwerty123!")]
        public void CanLoginSuccessfullyUsingCorrectCredentials(string email, string password)
        {
            _driver = GetWebDriver();
            _homePage = new HomePage(_driver);
            _loginPage = new LoginPage(_driver);
            _mainPage = new MainPage(_driver);
            
            _homePage.GoToLoginPage();
            _loginPage.PopulateLoginForm(email, password);
            _loginPage.SubmitLoginForm();

            Assert.IsTrue(_mainPage.IsSearchBarPresent(), "Could not login the user.");
        }

        [TestCase("farhad_89@hotmail.com", "qwerty123")]
        public void CannotLoginUsingIncorrectCredentials(string email, string password)
        {
            _driver = GetWebDriver();
            _homePage = new HomePage(_driver);
            _loginPage = new LoginPage(_driver);

            _homePage.GoToLoginPage();
            _loginPage.PopulateLoginForm(email, password);
            _loginPage.SubmitLoginForm();

            Assert.IsTrue(_loginPage.ErrorMessageOnLoginAttempt(), "Could not login the user.");
        }

        [TestCase("farhad_89@hotmail.com", "qwerty12")]
        public void CanRequestPasswordResetEmail(string email, string password)
        {
            _driver = GetWebDriver();
            _homePage = new HomePage(_driver);
            _loginPage = new LoginPage(_driver);

            _homePage.GoToLoginPage();
            _loginPage.PopulateLoginForm(email, password);
            _loginPage.ForgotLoginClick();
            _loginPage.ResetPasswordClick();
            
            Thread.Sleep(3000);
            Assert.IsTrue(_loginPage.SuccessMessageOnReset(),"Could not send password reset email.");
        }


        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}