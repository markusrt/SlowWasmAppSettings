using System.ComponentModel;

namespace SlowWasmAppSettings.MyCode
{
    public enum SpeciesTestingMethod
    {
        Vitek,
        [Description("Mikrodilution")]
        Microdilution,
        [Description("Yeast One")]
        YeastOne,
        Micronaut,
        [Description("E-Test")]
        ETest
    }
}