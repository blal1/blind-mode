using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "AssemblyNameFlags")]
[System.Flags]
public enum AssemblyNameFlags
{
	None = 0,
	PublicKey = 1,
	EnableJITcompileOptimizer = 0x4000,
	EnableJITcompileTracking = 0x8000,
	Retargetable = 0x100
}
