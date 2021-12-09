using System.Collections.Generic;

namespace SlowWasmAppSettings.MyCode
{
    public class BreakpointSettings
    {
        public Breakpoint Breakpoint { get; set; }
    }

    public class Breakpoint
    {
        public Dictionary<string, Dictionary<string, List<MicStep>>> MicSteps { get; set; }
        
        // The following is even slower (prob. due to the fact that it needs to traverse one level deeper)
        // public Dictionary<string, Dictionary<string, List<Dictionary<string,object>>>> MicSteps { get; set; }
    }
}