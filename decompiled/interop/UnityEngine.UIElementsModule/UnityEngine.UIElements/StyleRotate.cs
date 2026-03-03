using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DF")]
public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
{
	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x0")]
	private Rotate m_Value;

	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x18")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700083A")]
	public Rotate value
	{
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x29E9C10", Offset = "0x29E8E10", VA = "0x1829E9C10", Slot = "4")]
		get
		{
			return default(Rotate);
		}
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x29E9BD0", Offset = "0x29E8DD0", VA = "0x1829E9BD0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700083B")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x138AC10", Offset = "0x1389E10", VA = "0x18138AC10", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x29E9BD0", Offset = "0x29E8DD0", VA = "0x1829E9BD0")]
	public StyleRotate(Rotate v)
	{
	}

	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x29E9BA0", Offset = "0x29E8DA0", VA = "0x1829E9BA0")]
	public StyleRotate(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x29E9BF0", Offset = "0x29E8DF0", VA = "0x1829E9BF0")]
	internal StyleRotate(Rotate v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x29E9D40", Offset = "0x29E8F40", VA = "0x1829E9D40")]
	public static bool operator ==(StyleRotate lhs, StyleRotate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x29E9E00", Offset = "0x29E9000", VA = "0x1829E9E00")]
	public static implicit operator StyleRotate(StyleKeyword keyword)
	{
		return default(StyleRotate);
	}

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x29E9DD0", Offset = "0x29E8FD0", VA = "0x1829E9DD0")]
	public static implicit operator StyleRotate(Rotate v)
	{
		return default(StyleRotate);
	}

	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x29E9A70", Offset = "0x29E8C70", VA = "0x1829E9A70", Slot = "8")]
	public bool Equals(StyleRotate other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x29E9970", Offset = "0x29E8B70", VA = "0x1829E9970", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x29E9B00", Offset = "0x29E8D00", VA = "0x1829E9B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x29E9B20", Offset = "0x29E8D20", VA = "0x1829E9B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
