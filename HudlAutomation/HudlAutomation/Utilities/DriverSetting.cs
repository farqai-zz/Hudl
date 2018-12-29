using OpenQA.Selenium;

namespace HudlAutomation.Utilities
{
    public abstract class DriverSetting
    {
        private readonly IWebDriver _driver;

        protected IWebDriver GetWebDriver()
        {
            var webDriver = new WebDriverConfig(_driver);
            return webDriver.InitLocalDriver();
        }
    }
}