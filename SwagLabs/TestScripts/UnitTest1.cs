using Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation___SwagLabs
{


    [TestClass]
    [TestCategory("LoginPage Scripts")]
    public class LoginScripts : BaseClass
    {
        [TestMethod]
        [Description("Login with Valid Username and Password")]
        public void TC1()
        {
           LoginPage loginpage = new LoginPage(Driver);
           loginpage.GotoAndAssertPage();
        }

    }

    
}