using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D5")]
public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
{
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x0")]
	private Cursor m_Value;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x18")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000829")]
	public Cursor value
	{
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x29E7360", Offset = "0x29E6560", VA = "0x1829E7360", Slot = "4")]
		get
		{
			return default(Cursor);
		}
		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x29E7480", Offset = "0x29E6680", VA = "0x1829E7480", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700082A")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x138AC10", Offset = "0x1389E10", VA = "0x18138AC10", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x29E7310", Offset = "0x29E6510", VA = "0x1829E7310")]
	public StyleCursor(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x29E7340", Offset = "0x29E6540", VA = "0x1829E7340")]
	internal StyleCursor(Cursor v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x29E73B0", Offset = "0x29E65B0", VA = "0x1829E73B0")]
	public static bool operator ==(StyleCursor lhs, StyleCursor rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x29E7420", Offset = "0x29E6620", VA = "0x1829E7420")]
	public static implicit operator StyleCursor(StyleKeyword keyword)
	{
		return default(StyleCursor);
	}

	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x29E7140", Offset = "0x29E6340", VA = "0x1829E7140", Slot = "8")]
	public bool Equals(StyleCursor other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x29E71B0", Offset = "0x29E63B0", VA = "0x1829E71B0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x29E7280", Offset = "0x29E6480", VA = "0x1829E7280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x29E72A0", Offset = "0x29E64A0", VA = "0x1829E72A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
