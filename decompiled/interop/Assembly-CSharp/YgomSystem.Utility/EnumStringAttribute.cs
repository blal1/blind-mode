using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003B6")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class EnumStringAttribute : PropertyAttribute
{
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x18")]
	public readonly Type enumType;

	[Token(Token = "0x600165A")]
	[Address(RVA = "0x5A0AD0", Offset = "0x59FCD0", VA = "0x1805A0AD0")]
	public EnumStringAttribute(Type enumType)
	{
	}
}
