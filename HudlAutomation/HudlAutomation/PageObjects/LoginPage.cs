using System.Threading;
using OpenQA.Selenium;

namespace HudlAutomation.PageObjects
{
    class LoginPage
    {
        private readonly IWebDriver _webDriver;
        private readonly By _email = By.Id("email");
        private readonly By _password = By.Id("password");
        private readonly By _logIn = By.Id("logIn");
        private readonly By _failedLoginMessage = By.LinkText("Need help?");
        private readonly By _forgotLoginBtn = By.Id("forgot-password-link");
        private readonly By _resetPasswordBtn = By.Id("resetBtn");
        private readonly By _checkYourEmail = By.ClassName("reset-sent-container");

        public LoginPage(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        public void PopulateLoginForm(string email, string passwordIn)
        {
            _webDriver.FindElement(_email).SendKeys(email);
            _webDriver.FindElement(_password).SendKeys(passwordIn);
        }

        public void SubmitLoginForm()
        {
            _webDriver.FindElement(_logIn).Click();
        }

        public bool ErrorMessageOnLoginAttempt()
        {
            return _webDriver.FindElement(_failedLoginMessage).Displayed;
        }

        public void ForgotLoginClick()
        {
            _webDriver.FindElement(_forgotLoginBtn).Click();
        }

        public void ResetPasswordClick()
        {
            Thread.Sleep(3000);
            _webDriver.FindElement(_resetPasswordBtn).Click();
        }

        public bool SuccessMessageOnReset()
        {
            Thread.Sleep(3000);
            return _webDriver.FindElement(_checkYourEmail).Displayed;
        }
    }
}