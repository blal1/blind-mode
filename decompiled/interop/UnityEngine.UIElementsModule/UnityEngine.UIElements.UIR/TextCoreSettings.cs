using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000571")]
internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x0")]
	public Color faceColor;

	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x10")]
	public Color outlineColor;

	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x20")]
	public float outlineWidth;

	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x24")]
	public Color underlayColor;

	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 underlayOffset;

	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x3C")]
	public float underlaySoftness;

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x2A65090", Offset = "0x2A64290", VA = "0x182A65090", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0x2A65140", Offset = "0x2A64340", VA = "0x182A65140", Slot = "4")]
	public bool Equals(TextCoreSettings other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0x2A652E0", Offset = "0x2A644E0", VA = "0x182A652E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
