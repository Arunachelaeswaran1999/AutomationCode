using Base;
using PageObjects;


namespace Automation___SwagLabs
{
    [TestClass]
    [TestCategory("LoginPage Scripts")]
    public class LoginScripts : BaseClass
    {
        [TestMethod]
        [Description("To check the Product Page is displayed whether we pass Valid Username and Password")]
        [TestProperty("Author", "Arunachelaeswaran S")]
        public void TC_1()
        {
            SetUsernameAndPassword("standard_user", "secret_sauce");

            loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            productPage = loginpage.FillUserCredentials(crendentials);
            Assert.IsTrue(productPage.isvisible, "ProductPage is not displayed");
        }

        [TestMethod]
        [Description("To check the validation message is displayed or not. Without giving the Username")]
        [TestProperty("Author", "Arunachelaeswaran S")]
        public void TC_2()
        {
            SetUsernameAndPassword("", "secret_sauce");

            loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
            Assert.AreEqual("Epic sadface: Username is required", loginpage.validateusercredentials);
        }

        [TestMethod]
        [Description("To check the validation message is displayed or not. Without giving the Password")]
        [TestProperty("Author", "Arunachelaeswaran S")]
        public void TC_3()
        {
            SetUsernameAndPassword("standard_user", "");

            loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
            Assert.AreEqual("Epic sadface: Password is required", loginpage.validateusercredentials);
        }

        [TestMethod]
        [Description("To check the validation message is displayed or not. If we give Invalid Username and Password")]
        [TestProperty("Author", "Arunachelaeswaran S")]
        public void TC_4()
        {
            SetUsernameAndPassword("Arun", "Test@123");

            loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", loginpage.validateusercredentials);
        }

        [TestMethod]
        [Description("To check the validation message is displayed or not. Without giving both Username and Password")]
        [TestProperty("Author", "Arunachelaeswaran S")]
        public void TC_5()
        {
            SetUsernameAndPassword("", "");

            loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
            Assert.AreEqual("Epic sadface: Username is required", loginpage.validateusercredentials);
        }
    }


}