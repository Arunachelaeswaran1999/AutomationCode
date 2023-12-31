using Base;
using PageObjects;


namespace Automation___SwagLabs
{
    [TestClass]
    [TestCategory("LoginPage Scripts")]
    public class LoginScripts : BaseClass
    {

        [TestMethod]
        [Description("Validating the loginpage using valid username and password")]
        public void TC1()
        {
            SetUsernameAndPassword("standard_usersdsdf","secret_sauce");
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
        }

        [TestMethod]
        [Description("Validating the loginpage using Invalid username and password")]
        public void TC2()
        {
            SetUsernameAndPassword("standard_usersdsdf","secret_sauce");
            LoginPage loginpage = new LoginPage(Driver);
            loginpage.GotoAndAssertPage();
            loginpage.FillUserCredentials(crendentials);
        }
    }


}