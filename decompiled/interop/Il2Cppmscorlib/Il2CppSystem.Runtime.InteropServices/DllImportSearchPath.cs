using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices;

[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "DllImportSearchPath")]
[System.Flags]
public enum DllImportSearchPath
{
	UseDllDirectoryForDependencies = 0x100,
	ApplicationDirectory = 0x200,
	UserDirectories = 0x400,
	System32 = 0x800,
	SafeDirectories = 0x1000,
	AssemblyDirectory = 2,
	LegacyBehavior = 0
}
