using System;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200057E")]
[AttributeUsage(AttributeTargets.Field)]
public class DirectionalPropertyAttribute : Attribute
{
	[Token(Token = "0x200057F")]
	public enum Direction
	{
		[Token(Token = "0x4001AC8")]
		Up = 2,
		[Token(Token = "0x4001AC9")]
		Down = 4,
		[Token(Token = "0x4001ACA")]
		Left = 8,
		[Token(Token = "0x4001ACB")]
		Right = 16,
		[Token(Token = "0x4001ACC")]
		All = 30
	}

	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0x10")]
	public readonly Direction direction;

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x65C4A0", Offset = "0x65B6A0", VA = "0x18065C4A0")]
	public DirectionalPropertyAttribute(Direction direction)
	{
	}
}
