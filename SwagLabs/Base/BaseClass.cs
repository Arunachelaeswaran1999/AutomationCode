using EnumProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;
using WebDriverManager.DriverConfigs.Impl;

namespace Base
{
    public class BaseClass
    {
        protected IWebDriver? Driver { get; set; }
        private WebDriverFactory? factory;
        public UserCrendentials? crendentials { get; set; }

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

        public void SetUsernameAndPassword(string usename, string password)
        {
            crendentials = new UserCrendentials();
            crendentials.Username = usename;
            crendentials.Password = password;
        }

    }

}