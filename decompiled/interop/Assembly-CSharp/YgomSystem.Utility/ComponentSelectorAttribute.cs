using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003B4")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class ComponentSelectorAttribute : PropertyAttribute
{
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x18")]
	public readonly bool useAlias;

	[Token(Token = "0x6001656")]
	[Address(RVA = "0x5B9F60", Offset = "0x5B9160", VA = "0x1805B9F60")]
	public ComponentSelectorAttribute(bool useAlias)
	{
	}
}
