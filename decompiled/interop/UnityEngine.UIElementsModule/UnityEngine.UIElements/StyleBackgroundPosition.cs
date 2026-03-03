using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D1")]
public struct StyleBackgroundPosition : IStyleValue<BackgroundPosition>, IEquatable<StyleBackgroundPosition>
{
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x0")]
	private BackgroundPosition m_Value;

	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0xC")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000821")]
	public BackgroundPosition value
	{
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x29E6190", Offset = "0x29E5390", VA = "0x1829E6190", Slot = "4")]
		get
		{
			return default(BackgroundPosition);
		}
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x29E6170", Offset = "0x29E5370", VA = "0x1829E6170", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000822")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x13251C0", Offset = "0x13243C0", VA = "0x1813251C0", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0xAA0C30", Offset = "0xA9FE30", VA = "0x180AA0C30", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x29E6170", Offset = "0x29E5370", VA = "0x1829E6170")]
	public StyleBackgroundPosition(BackgroundPosition v)
	{
	}

	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x29E6150", Offset = "0x29E5350", VA = "0x1829E6150")]
	public StyleBackgroundPosition(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x2496A10", Offset = "0x2495C10", VA = "0x182496A10")]
	internal StyleBackgroundPosition(BackgroundPosition v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x29E61D0", Offset = "0x29E53D0", VA = "0x1829E61D0")]
	public static bool operator ==(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x29E6220", Offset = "0x29E5420", VA = "0x1829E6220")]
	public static implicit operator StyleBackgroundPosition(StyleKeyword keyword)
	{
		return default(StyleBackgroundPosition);
	}

	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x29E6070", Offset = "0x29E5270", VA = "0x1829E6070", Slot = "8")]
	public bool Equals(StyleBackgroundPosition other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D0A")]
	[Address(RVA = "0x29E5FA0", Offset = "0x29E51A0", VA = "0x1829E5FA0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D0B")]
	[Address(RVA = "0x29E60D0", Offset = "0x29E52D0", VA = "0x1829E60D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x29E60F0", Offset = "0x29E52F0", VA = "0x1829E60F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
