using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace SwagLabs___CSharp_Playwright_Automation;

public class Tests:PageTest
{

    [Test]
    public async Task Test1()
    {
        //Navigate to the given URL
        await Page.GotoAsync(url:"https://www.saucedemo.com/v1/");

        //Validate or check the current Page Title
        await Expect(Page).ToHaveTitleAsync(new Regex("Swag Labs"));

        //Expect an attribute "to be strictly equal" to the value.
        var username = Page.GetByPlaceholder("Username");
        await Expect(username).ToHaveAttributeAsync("class","form_input");

        //Send Username on the username Field
        await username.FillAsync("standard_user");

        //Send Password on the Password Field
        await Page.FillAsync(selector:"#password",value:"secret_sauce");

        //click the Login button
        await Page.GetByRole(AriaRole.Button, new PageGetByRoleOptions{Name="LOGIN"}).ClickAsync();

    }
}
