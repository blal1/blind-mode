using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E0")]
public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
{
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x0")]
	private Scale m_Value;

	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x10")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700083C")]
	public Scale value
	{
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x29EA060", Offset = "0x29E9260", VA = "0x1829EA060", Slot = "4")]
		get
		{
			return default(Scale);
		}
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x29E7050", Offset = "0x29E6250", VA = "0x1829E7050", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700083D")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x27BFAA0", Offset = "0x27BECA0", VA = "0x1827BFAA0", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x29E7050", Offset = "0x29E6250", VA = "0x1829E7050")]
	public StyleScale(Scale v)
	{
	}

	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x29EA050", Offset = "0x29E9250", VA = "0x1829EA050")]
	public StyleScale(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x16AB180", Offset = "0x16AA380", VA = "0x1816AB180")]
	internal StyleScale(Scale v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x29EA1B0", Offset = "0x29E93B0", VA = "0x1829EA1B0")]
	public static bool operator ==(StyleScale lhs, StyleScale rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x29EA220", Offset = "0x29E9420", VA = "0x1829EA220")]
	public static implicit operator StyleScale(StyleKeyword keyword)
	{
		return default(StyleScale);
	}

	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x29E7120", Offset = "0x29E6320", VA = "0x1829E7120")]
	public static implicit operator StyleScale(Scale v)
	{
		return default(StyleScale);
	}

	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x29E9E30", Offset = "0x29E9030", VA = "0x1829E9E30", Slot = "8")]
	public bool Equals(StyleScale other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x29E9EA0", Offset = "0x29E90A0", VA = "0x1829E9EA0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x29E9F80", Offset = "0x29E9180", VA = "0x1829E9F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x29E9FE0", Offset = "0x29E91E0", VA = "0x1829E9FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
