using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2ETest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class SortableListTest : PageTest
{
    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions()
        {
            BaseURL = "https://red-mushroom-0fcb8c710.4.azurestaticapps.net/",
        };
    }

    [Test]
    public async Task SortableList()
    {
        await Page.GotoAsync("/");

        Playwright.Selectors.SetTestIdAttribute("aria-label");

        await Page.GetByTestId("SortableList").IsVisibleAsync();
        await Page.GetByTestId("SortableList").ClickAsync();

        // Expect a title "to contain" a substring.
        //await Expect(Page).ToHaveTitleAsync(new Regex("BlazorApp26"));

        await Page.GetByTestId("sortablelisttitle").IsVisibleAsync();

    }
}
