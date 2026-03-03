using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D0")]
public struct StyleBackground : IStyleValue<Background>, IEquatable<StyleBackground>
{
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x0")]
	private Background m_Value;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x20")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700081F")]
	public Background value
	{
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x29E6CD0", Offset = "0x29E5ED0", VA = "0x1829E6CD0", Slot = "4")]
		get
		{
			return default(Background);
		}
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x29E6E10", Offset = "0x29E6010", VA = "0x1829E6E10", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000820")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x158E340", Offset = "0x158D540", VA = "0x18158E340", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x29E6B50", Offset = "0x29E5D50", VA = "0x1829E6B50")]
	public StyleBackground(Background v)
	{
	}

	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x29E6B70", Offset = "0x29E5D70", VA = "0x1829E6B70")]
	public StyleBackground(Texture2D v)
	{
	}

	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x29E6C90", Offset = "0x29E5E90", VA = "0x1829E6C90")]
	public StyleBackground(Sprite v)
	{
	}

	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x29E6B10", Offset = "0x29E5D10", VA = "0x1829E6B10")]
	public StyleBackground(VectorImage v)
	{
	}

	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x29E6C00", Offset = "0x29E5E00", VA = "0x1829E6C00")]
	public StyleBackground(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x29E6AC0", Offset = "0x29E5CC0", VA = "0x1829E6AC0")]
	internal StyleBackground(Texture2D v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001CF7")]
	[Address(RVA = "0x29E6BB0", Offset = "0x29E5DB0", VA = "0x1829E6BB0")]
	internal StyleBackground(Sprite v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001CF8")]
	[Address(RVA = "0x29E6C20", Offset = "0x29E5E20", VA = "0x1829E6C20")]
	internal StyleBackground(VectorImage v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001CF9")]
	[Address(RVA = "0x29E6C70", Offset = "0x29E5E70", VA = "0x1829E6C70")]
	internal StyleBackground(Background v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x29E6D00", Offset = "0x29E5F00", VA = "0x1829E6D00")]
	public static bool operator ==(StyleBackground lhs, StyleBackground rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x29E6DB0", Offset = "0x29E5FB0", VA = "0x1829E6DB0")]
	public static implicit operator StyleBackground(StyleKeyword keyword)
	{
		return default(StyleBackground);
	}

	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x29E6840", Offset = "0x29E5A40", VA = "0x1829E6840", Slot = "8")]
	public bool Equals(StyleBackground other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CFD")]
	[Address(RVA = "0x29E68F0", Offset = "0x29E5AF0", VA = "0x1829E68F0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x29E6A20", Offset = "0x29E5C20", VA = "0x1829E6A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x29E6A40", Offset = "0x29E5C40", VA = "0x1829E6A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
