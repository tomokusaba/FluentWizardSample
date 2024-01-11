using BlazorApp26;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluentUIComponents();
FluentWizard.LabelButtonDone = "Š®—¹";
FluentWizard.LabelButtonNext = "ŽŸ‚Ö";
FluentWizard.LabelButtonPrevious = "‘O‚Ö";

await builder.Build().RunAsync();
