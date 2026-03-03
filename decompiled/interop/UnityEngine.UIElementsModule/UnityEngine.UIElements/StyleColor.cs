using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D4")]
public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x0")]
	private Color m_Value;

	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x10")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000827")]
	public Color value
	{
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x29E7070", Offset = "0x29E6270", VA = "0x1829E7070", Slot = "4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x29E7050", Offset = "0x29E6250", VA = "0x1829E7050", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000828")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x27BFAA0", Offset = "0x27BECA0", VA = "0x1827BFAA0", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x29E7050", Offset = "0x29E6250", VA = "0x1829E7050")]
	public StyleColor(Color v)
	{
	}

	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x29E7060", Offset = "0x29E6260", VA = "0x1829E7060")]
	public StyleColor(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D2C")]
	[Address(RVA = "0x16AB180", Offset = "0x16AA380", VA = "0x1816AB180")]
	internal StyleColor(Color v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D2D")]
	[Address(RVA = "0x29E7090", Offset = "0x29E6290", VA = "0x1829E7090")]
	public static bool operator ==(StyleColor lhs, StyleColor rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x29E7110", Offset = "0x29E6310", VA = "0x1829E7110")]
	public static implicit operator StyleColor(StyleKeyword keyword)
	{
		return default(StyleColor);
	}

	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x29E7120", Offset = "0x29E6320", VA = "0x1829E7120")]
	public static implicit operator StyleColor(Color v)
	{
		return default(StyleColor);
	}

	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x29E6E40", Offset = "0x29E6040", VA = "0x1829E6E40", Slot = "8")]
	public bool Equals(StyleColor other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x29E6EC0", Offset = "0x29E60C0", VA = "0x1829E6EC0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x29E6FC0", Offset = "0x29E61C0", VA = "0x1829E6FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x29E6FE0", Offset = "0x29E61E0", VA = "0x1829E6FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
