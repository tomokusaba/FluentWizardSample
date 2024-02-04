using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace E2ETest;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{


    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions()
        {
            BaseURL = "https://red-mushroom-0fcb8c710.4.azurestaticapps.net/",
        };
    }



    [Test]
    public async Task Home()
    {
        await Page.GotoAsync("/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("BlazorApp26"));

    }
}
