using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Base
{
    public class Base_PageProperties
    {
        protected IWebDriver? Driver {get; set;}
        protected WebDriverWait? wait {get; set;}
        public Base_PageProperties(IWebDriver? driver)
        {
            Driver = driver;
        }
    }
    
}