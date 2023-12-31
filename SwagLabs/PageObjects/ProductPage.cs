using Base;
using OpenQA.Selenium;

namespace PageObjects
{
    public class ProductPage:Base_PageProperties
    {
        public ProductPage(IWebDriver? driver):base(driver){}

        public bool? isvisible => Driver?.FindElement(By.CssSelector(".product_label")).Displayed;
    }
    
}