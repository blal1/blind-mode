using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000581")]
[AttributeUsage(AttributeTargets.Field)]
public class DirectionalLinePropertyAttribute : Attribute
{
	[Token(Token = "0x4001ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly bool head;

	[Token(Token = "0x4001ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string displayName;

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x65C450", Offset = "0x65B650", VA = "0x18065C450")]
	public DirectionalLinePropertyAttribute(bool head, [Optional] string displayName)
	{
	}
}
