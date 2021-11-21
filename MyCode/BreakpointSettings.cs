using System.Collections.Generic;

namespace SlowWasmAppSettings.MyCode
{
    public class BreakpointSettings
    {
        public Breakpoint Breakpoint { get; set; }
    }

    public class Breakpoint
    {
        public Dictionary<SpeciesTestingMethod, Dictionary<AntifungalAgent, List<MicStep>>> MicSteps { get; set; }
    }
}