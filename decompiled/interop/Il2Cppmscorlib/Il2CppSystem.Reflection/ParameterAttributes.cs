using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "ParameterAttributes")]
[System.Flags]
public enum ParameterAttributes
{
	None = 0,
	In = 1,
	Out = 2,
	Lcid = 4,
	Retval = 8,
	Optional = 0x10,
	HasDefault = 0x1000,
	HasFieldMarshal = 0x2000,
	Reserved3 = 0x4000,
	Reserved4 = 0x8000,
	ReservedMask = 0xF000
}
