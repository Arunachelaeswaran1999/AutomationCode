using System;
using Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PageObjects
{
    public class LoginPage : Base_PageProperties
    {
        public string validateusercredentials
        {
            get
            {
                try
                {
                    wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
                    IWebElement val = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".product_label")));
                    return val.Text;

                }
                catch (System.Exception)
                {
                    string? validation_message = Driver?.FindElement(By.CssSelector("h3[data-test='error']")).Text;
                    switch (validation_message)
                    {
                        case "Epic sadface: Username is required":
                            return validation_message;

                        case "Epic sadface: Password is required":
                            return validation_message;

                        case "Epic sadface: Username and password do not match any user in this service":
                            return validation_message;

                        default:
                            return "No Such Validation is not available";

                    }
                }
            }
        }

        public LoginPage(IWebDriver? driver) : base(driver) { }

        private string Page => "Swag Labs";
        public bool? isvisible => Driver?.Title.Contains(Page);

        private IWebElement? Username => Driver?.FindElement(By.Id("user-name"));
        private IWebElement? Password => Driver?.FindElement(By.Id("password"));
        private IWebElement? Submit => Driver?.FindElement(By.Id("login-button"));

        public void GotoAndAssertPage()
        {
            Driver?.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            Assert.IsTrue(isvisible, $"LoginPage is not Displayed. ExpectedPage: {Page}. But, ActualPage: {Driver?.Title}");
        }

        public ProductPage FillUserCredentials(UserCrendentials? crendentials)
        {
            Username?.SendKeys(crendentials?.Username);
            Password?.SendKeys(crendentials?.Password);
            Submit?.Click();
            return new ProductPage(Driver);
        }

    }

    public class UserCrendentials
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}