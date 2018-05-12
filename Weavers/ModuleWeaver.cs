using System.Collections.Generic;
using System.Linq;
using Mono.Cecil.Rocks;
using Fody;

public partial class ModuleWeaver : BaseModuleWeaver
{
    public override void Execute()
    {
        var actionDefinition = FindType("System.Action");
        actionDefinition.GetConstructors().First();
    }

    public override IEnumerable<string> GetAssembliesForScanning()
    {
        yield return "netstandard";
        yield return "mscorlib";
        yield return "System";
        yield return "System.Runtime";
        yield return "System.Core";
    }
}