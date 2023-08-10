using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCRMAutomationDemo.Tests.Models
{
    public class SearchPage
    {
        private readonly IPage _page;
        private readonly ILocator _searchTermInput;

        public SearchPage(IPage page)
        {
            _page = page;
            _searchTermInput = page.Locator("[aria-label='Enter your search term']");
        }

        public async Task GotoAsync()
        {
            await _page.GotoAsync("https://bing.com");
        }

        public async Task SearchAsync(string text)
        {
            await _searchTermInput.FillAsync(text);
            await _searchTermInput.PressAsync("Enter");
        }
    }
}
