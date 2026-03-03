using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DD")]
public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x0")]
	private Length m_Value;

	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x8")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000836")]
	public Length value
	{
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x29E8220", Offset = "0x29E7420", VA = "0x1829E8220", Slot = "4")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x29E83A0", Offset = "0x29E75A0", VA = "0x1829E83A0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000837")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x12CF490", Offset = "0x12CE690", VA = "0x1812CF490", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x29E8350", Offset = "0x29E7550", VA = "0x1829E8350", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x29E8160", Offset = "0x29E7360", VA = "0x1829E8160")]
	public StyleLength(float v)
	{
	}

	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x29E81F0", Offset = "0x29E73F0", VA = "0x1829E81F0")]
	public StyleLength(Length v)
	{
	}

	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x29E6420", Offset = "0x29E5620", VA = "0x1829E6420")]
	public StyleLength(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x29E81C0", Offset = "0x29E73C0", VA = "0x1829E81C0")]
	internal StyleLength(Length v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x29E8240", Offset = "0x29E7440", VA = "0x1829E8240")]
	public static bool operator ==(StyleLength lhs, StyleLength rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x29E6470", Offset = "0x29E5670", VA = "0x1829E6470")]
	public static implicit operator StyleLength(StyleKeyword keyword)
	{
		return default(StyleLength);
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x29E82C0", Offset = "0x29E74C0", VA = "0x1829E82C0")]
	public static implicit operator StyleLength(float v)
	{
		return default(StyleLength);
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x29E8280", Offset = "0x29E7480", VA = "0x1829E8280")]
	public static implicit operator StyleLength(Length v)
	{
		return default(StyleLength);
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x29E7F60", Offset = "0x29E7160", VA = "0x1829E7F60", Slot = "8")]
	public bool Equals(StyleLength other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x29E7FD0", Offset = "0x29E71D0", VA = "0x1829E7FD0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x29E80C0", Offset = "0x29E72C0", VA = "0x1829E80C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x29E80F0", Offset = "0x29E72F0", VA = "0x1829E80F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
