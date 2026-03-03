using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D9")]
public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat>
{
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x0")]
	private float m_Value;

	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x4")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700082E")]
	public float value
	{
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x29E7610", Offset = "0x29E6810", VA = "0x1829E7610", Slot = "4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x29E75F0", Offset = "0x29E67F0", VA = "0x1829E75F0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700082F")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x14FE960", Offset = "0x14FDB60", VA = "0x1814FE960", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x29E75F0", Offset = "0x29E67F0", VA = "0x1829E75F0")]
	public StyleFloat(float v)
	{
	}

	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x29E7600", Offset = "0x29E6800", VA = "0x1829E7600")]
	public StyleFloat(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x1800AC0", Offset = "0x17FFCC0", VA = "0x181800AC0")]
	internal StyleFloat(float v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x29E7620", Offset = "0x29E6820", VA = "0x1829E7620")]
	public static bool operator ==(StyleFloat lhs, StyleFloat rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x29E7670", Offset = "0x29E6870", VA = "0x1829E7670")]
	public static implicit operator StyleFloat(StyleKeyword keyword)
	{
		return default(StyleFloat);
	}

	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x29E7650", Offset = "0x29E6850", VA = "0x1829E7650")]
	public static implicit operator StyleFloat(float v)
	{
		return default(StyleFloat);
	}

	[Token(Token = "0x6001D6A")]
	[Address(RVA = "0x29E7560", Offset = "0x29E6760", VA = "0x1829E7560", Slot = "8")]
	public bool Equals(StyleFloat other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D6B")]
	[Address(RVA = "0x29E74B0", Offset = "0x29E66B0", VA = "0x1829E74B0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x29E1050", Offset = "0x29E0250", VA = "0x1829E1050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0x29E7590", Offset = "0x29E6790", VA = "0x1829E7590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
