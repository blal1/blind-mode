using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "EventAttributes")]
[System.Flags]
public enum EventAttributes
{
	None = 0,
	SpecialName = 0x200,
	RTSpecialName = 0x400,
	ReservedMask = 0x400
}
