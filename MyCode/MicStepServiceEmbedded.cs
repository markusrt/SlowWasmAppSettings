using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SlowWasmAppSettings.MyCode
{
    public class MicStepsServiceEmbedded
    {
        private BreakpointSettings _configValue;

        public MicStepsServiceEmbedded(IOptions<BreakpointSettings> config, ILogger<MicStepsServiceEmbedded> logger)
        {
            logger.LogInformation($"Entering constructor");
            
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SlowWasmAppSettings.MyCode.EmbeddedSettings.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var settings = JsonSerializer.Deserialize<BreakpointSettings>(json);
                logger.LogInformation($"Found: {settings.Breakpoint.MicSteps.SelectMany(m => m.Value).SelectMany(a => a.Value).Count()} values in total");
            }

            logger.LogInformation($"Exiting constructor after: {stopWatch.ElapsedMilliseconds}ms");
        }
    }
}