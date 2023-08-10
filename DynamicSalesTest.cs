using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Microsoft.Playwright;

namespace DynamicCRMAutomationDemo
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class DynamicSalesTest :PageTest
    {
        [Test]
        public async Task DynamicSaleTest()
        {
            //Page
            await Page.GotoAsync("https://orgdd908431.crm.dynamics.com/");
            //title
            await Expect(Page).ToHaveTitleAsync(new Regex("Sign in to your account"));
            //input
            await Page.GetByPlaceholder("someone@example.com").FillAsync("UserName");
            //button click
            await Page.GetByRole(AriaRole.Button, new() { Name = "Next" }).ClickAsync();
            //Assert Password dialog
            Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Enter password" }));
            //Enter Password
            await Page.GetByPlaceholder("Password").FillAsync("YourPassword");
            //Button Click
            await Page.GetByRole(AriaRole.Button, new() { Name = "Sign in" }).ClickAsync();
            //Stay Sign in Assertion
            Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Stay signed in?" }));
            //Button Click
            await Page.GetByRole(AriaRole.Button, new() { Name = "Yes" }).ClickAsync();
            //Asert Home Page
            Expect(Page.GetByLabel("Sales Team Member"));

        }

    }
}
