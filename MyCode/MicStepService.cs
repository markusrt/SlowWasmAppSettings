using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SlowWasmAppSettings.MyCode
{
    public class MicStepsService
    {
        private BreakpointSettings _configValue;

        public MicStepsService(IOptions<BreakpointSettings> config, ILogger<MicStepsService> logger)
        {
            logger.LogInformation($"Entering constructor");
            
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            var settings = config.Value;
            
            logger.LogInformation($"Found: {settings.Breakpoint.MicSteps.SelectMany(m => m.Value).SelectMany(a => a.Value).Count()} values in total");
            
            logger.LogInformation($"Exiting constructor after: {stopWatch.ElapsedMilliseconds}ms");
        }
    }
}