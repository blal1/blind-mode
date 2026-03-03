using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DC")]
public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt>
{
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x0")]
	private int m_Value;

	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x4")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000834")]
	public int value
	{
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x14FEB40", Offset = "0x14FDD40", VA = "0x1814FEB40", Slot = "4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x14FF400", Offset = "0x14FE600", VA = "0x1814FF400", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000835")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x14FE960", Offset = "0x14FDB60", VA = "0x1814FE960", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x29E7600", Offset = "0x29E6800", VA = "0x1829E7600")]
	public StyleInt(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x14FE900", Offset = "0x14FDB00", VA = "0x1814FE900")]
	internal StyleInt(int v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x29E7F40", Offset = "0x29E7140", VA = "0x1829E7F40")]
	public static bool operator ==(StyleInt lhs, StyleInt rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x29E7670", Offset = "0x29E6870", VA = "0x1829E7670")]
	public static implicit operator StyleInt(StyleKeyword keyword)
	{
		return default(StyleInt);
	}

	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x29E7EB0", Offset = "0x29E70B0", VA = "0x1829E7EB0", Slot = "8")]
	public bool Equals(StyleInt other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x29E7E10", Offset = "0x29E7010", VA = "0x1829E7E10", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x2855780", Offset = "0x2854980", VA = "0x182855780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x29E7EE0", Offset = "0x29E70E0", VA = "0x1829E7EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
