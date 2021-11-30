using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SlowWasmAppSettings;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

 // My code start
builder.Services.AddSingleton<SlowWasmAppSettings.MyCode.MicStepsService>();
builder.Services.AddSingleton<SlowWasmAppSettings.MyCode.MicStepsServiceEmbedded>();
builder.Services.Configure<SlowWasmAppSettings.MyCode.BreakpointSettings>(options =>
{
    builder.Configuration.Bind(options);
});
// my code end


await builder.Build().RunAsync();
