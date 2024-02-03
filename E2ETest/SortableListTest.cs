using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2ETest;

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

        await Page.GetByTestId("sortablelist").IsVisibleAsync();
        await Page.GetByTestId("sortablelist").ClickAsync();

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("BlazorApp26"));

        await Page.GetByTestId("sortablelisttitle").IsVisibleAsync();

    }
}
