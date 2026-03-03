using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "CallingConventions")]
[System.Flags]
public enum CallingConventions
{
	Standard = 1,
	VarArgs = 2,
	Any = 3,
	HasThis = 0x20,
	ExplicitThis = 0x40
}
