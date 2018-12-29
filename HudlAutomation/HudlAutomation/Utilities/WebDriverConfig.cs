using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HudlAutomation.Utilities
{
    class WebDriverConfig
    {
        private IWebDriver _driver;
   
        public WebDriverConfig(IWebDriver context)
        {
            this._driver = context;
        }

        public IWebDriver InitLocalDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("url"));
            return _driver;
        }

        public void CloseDriver()
        {
            _driver.Quit();
        }
    }
}