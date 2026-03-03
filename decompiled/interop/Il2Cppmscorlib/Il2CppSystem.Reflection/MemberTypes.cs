using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "MemberTypes")]
[System.Flags]
public enum MemberTypes
{
	Constructor = 1,
	Event = 2,
	Field = 4,
	Method = 8,
	Property = 0x10,
	TypeInfo = 0x20,
	Custom = 0x40,
	NestedType = 0x80,
	All = 0xBF
}
