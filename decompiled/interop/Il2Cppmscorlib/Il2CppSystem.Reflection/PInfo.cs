using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "PInfo")]
[System.Flags]
public enum PInfo
{
	Attributes = 1,
	GetMethod = 2,
	SetMethod = 4,
	ReflectedType = 8,
	DeclaringType = 0x10,
	Name = 0x20
}
