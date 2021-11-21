using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SlowWasmAppSettings.MyCode
{
    public class MicStepsService
    {
        private BreakpointSettings _configValue;

        public MicStepsService(IOptions<BreakpointSettings> config, ILogger<MicStepsService> logger)
        {
            logger.LogInformation($"Entering constructor: {DateTime.Now}");

            _configValue = config.Value;
            
            logger.LogInformation($"Exiting constructor: {DateTime.Now}");
        }
    }
}