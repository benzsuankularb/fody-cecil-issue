using System;
using System.Linq;
using Mono.Cecil;
using System.Collections.Generic;
using Mono.Cecil.Rocks;
using Fody;

public partial class ModuleWeaver : BaseModuleWeaver
{
	
	public override void Execute()
	{
		TESTONLY();
	}

	void TESTONLY () {
		ModuleDefinition.ImportReference(typeof(Action)).Resolve();
		ModuleDefinition.ImportReference(typeof(Action)).Resolve().GetConstructors();
		ModuleDefinition.ImportReference(typeof(Action)).Resolve().GetConstructors().First();
	}

	public override IEnumerable<string> GetAssembliesForScanning()
	{
		return Array.Empty<string>();
	}
}