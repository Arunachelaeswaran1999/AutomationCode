using EnumProperties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Base
{
    public class BaseClass
    {
        public IWebDriver? Driver;
        private WebDriverFactory? factory;

        [TestInitialize]
        public void ExecuteBeforeAllTestMethods()
        {
            factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }

        [TestCleanup]
        public void ExecuteAfterAllTestMethods()
        {
            Driver?.Close();
            Driver?.Quit();
        }

    }

}