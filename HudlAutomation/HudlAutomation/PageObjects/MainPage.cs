using System;
using System.Threading;
using HudlAutomation.Utilities;
using OpenQA.Selenium;

namespace HudlAutomation.PageObjects
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverExtension _extension;
        private readonly By _exploreLink = By.CssSelector("a[href*='/explore']");


        public MainPage(IWebDriver driver)
        {
            this._webDriver = driver;
            _extension = new WebDriverExtension(driver);
        }

        public bool IsExploreOptionPresent()
        {
            _extension.StaleWait(_exploreLink);
            return _webDriver.FindElement(_exploreLink).Displayed;
        }
    }
}