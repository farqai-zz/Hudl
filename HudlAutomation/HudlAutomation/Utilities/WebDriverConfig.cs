using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

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

        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
