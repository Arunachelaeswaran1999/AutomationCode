using Base;
using OpenQA.Selenium;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver? Driver;

        public LoginPage(IWebDriver? driver)
        {
            Driver = driver;
        }

        private string Page => "Swag Labs";

        public bool? isvisible => Driver?.Title.Contains(Page);

        internal void GotoAndAssertPage()
        {
            Driver?.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            Assert.IsTrue(isvisible, $"LoginPage is not Displayed. ExpectedPage: {Page}. But, ActualPage: {Driver?.Title}");
        }
    }
    
}