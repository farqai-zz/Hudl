using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HudlAutomation.Utilities
{

    [TestFixture]
    class BaseSetupTearDown
    {
        private WebDriverConfig _webDriver;
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new WebDriverConfig(_driver);
            _webDriver.InitLocalDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.CleanUp();
        }
    }
}
