
using EnumProperties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace Base
{
    public class WebDriverFactory
    {
        internal IWebDriver Create(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    return ChromeDriver();

                case BrowserType.FireFox:
                    return FirefoxDriver();

                case BrowserType.Edge:
                    return EdgeDriver();

                default:
                    throw new ArgumentOutOfRangeException("No such driver is available");
            }

        }

        private static IWebDriver EdgeDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new EdgeDriver();
        }

        private static IWebDriver FirefoxDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new FirefoxDriver();
        }

        private static IWebDriver ChromeDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }


    }


}