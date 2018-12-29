using System.Threading;
using OpenQA.Selenium;

namespace HudlAutomation.PageObjects
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly By _exploreLink = By.CssSelector("a[href*='/explore']");

        public MainPage(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        public bool IsSearchBarPresent()
        {
            Thread.Sleep(3000);
            return _webDriver.FindElement(_exploreLink).Displayed;
        }
    }
}