using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SlowWasmAppSettings
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // My code start
            builder.Services.AddSingleton<MyCode.MicStepsService>();
            builder.Services.Configure<MyCode.BreakpointSettings>(options =>
            {
                builder.Configuration.Bind(options);
            });
            // my code end

            await builder.Build().RunAsync();
        }
    }
}
