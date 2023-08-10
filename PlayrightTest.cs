using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DynamicCRMAutomationDemo.Tests.Models;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        var page = new SearchPage(await Browser.NewPageAsync());
        await page.GotoAsync();
        await page.SearchAsync("search query");
    }
}