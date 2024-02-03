using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2ETest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class TwoItemSortableListTest : PageTest
{
    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions()
        {
            BaseURL = "https://red-mushroom-0fcb8c710.4.azurestaticapps.net/",
        };
    }

    [Test]
    public async Task TwoItemSortableList()
    {
        await Page.GotoAsync("/");

        Playwright.Selectors.SetTestIdAttribute("aria-label");

        await Page.GetByTestId("TwoItemSortableList").IsVisibleAsync();
        await Page.GetByTestId("TwoItemSortableList").ClickAsync();

        await Page.GetByTestId("sortablelisttitle").IsVisibleAsync();

        await Page.GetByTestId("explanation").IsVisibleAsync();
    }
}
