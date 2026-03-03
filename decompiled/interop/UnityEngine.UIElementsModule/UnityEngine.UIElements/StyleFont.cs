using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DA")]
public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x0")]
	private Font m_Value;

	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x8")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000830")]
	public Font value
	{
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x29E6430", Offset = "0x29E5630", VA = "0x1829E6430", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x29E7DF0", Offset = "0x29E6FF0", VA = "0x1829E7DF0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000831")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x12CF490", Offset = "0x12CE690", VA = "0x1812CF490", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x1EDF6D0", Offset = "0x1EDE8D0", VA = "0x181EDF6D0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x29E7CF0", Offset = "0x29E6EF0", VA = "0x1829E7CF0")]
	public StyleFont(Font v)
	{
	}

	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x1E454B0", Offset = "0x1E446B0", VA = "0x181E454B0")]
	public StyleFont(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D74")]
	[Address(RVA = "0x29E7CE0", Offset = "0x29E6EE0", VA = "0x1829E7CE0")]
	internal StyleFont(Font v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D75")]
	[Address(RVA = "0x29E7D00", Offset = "0x29E6F00", VA = "0x1829E7D00")]
	public static bool operator ==(StyleFont lhs, StyleFont rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D76")]
	[Address(RVA = "0x29E7D70", Offset = "0x29E6F70", VA = "0x1829E7D70")]
	public static implicit operator StyleFont(StyleKeyword keyword)
	{
		return default(StyleFont);
	}

	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x29E7DB0", Offset = "0x29E6FB0", VA = "0x1829E7DB0")]
	public static implicit operator StyleFont(Font v)
	{
		return default(StyleFont);
	}

	[Token(Token = "0x6001D78")]
	[Address(RVA = "0x29E7B70", Offset = "0x29E6D70", VA = "0x1829E7B70", Slot = "8")]
	public bool Equals(StyleFont other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D79")]
	[Address(RVA = "0x29E7A60", Offset = "0x29E6C60", VA = "0x1829E7A60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0x29E7BF0", Offset = "0x29E6DF0", VA = "0x1829E7BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D7B")]
	[Address(RVA = "0x29E7C80", Offset = "0x29E6E80", VA = "0x1829E7C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
