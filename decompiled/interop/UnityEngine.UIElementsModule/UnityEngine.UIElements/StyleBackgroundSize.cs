using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D3")]
public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize>
{
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x0")]
	private BackgroundSize m_Value;

	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x14")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000825")]
	public BackgroundSize value
	{
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x29E6720", Offset = "0x29E5920", VA = "0x1829E6720", Slot = "4")]
		get
		{
			return default(BackgroundSize);
		}
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x29E6820", Offset = "0x29E5A20", VA = "0x1829E6820", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000826")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x1991C20", Offset = "0x1990E20", VA = "0x181991C20", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x29E6710", Offset = "0x29E5910", VA = "0x1829E6710")]
	public StyleBackgroundSize(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0x29E66F0", Offset = "0x29E58F0", VA = "0x1829E66F0")]
	internal StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x29E6750", Offset = "0x29E5950", VA = "0x1829E6750")]
	public static bool operator ==(StyleBackgroundSize lhs, StyleBackgroundSize rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x29E67F0", Offset = "0x29E59F0", VA = "0x1829E67F0")]
	public static implicit operator StyleBackgroundSize(StyleKeyword keyword)
	{
		return default(StyleBackgroundSize);
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x29E65C0", Offset = "0x29E57C0", VA = "0x1829E65C0", Slot = "8")]
	public bool Equals(StyleBackgroundSize other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x29E64A0", Offset = "0x29E56A0", VA = "0x1829E64A0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x29E6660", Offset = "0x29E5860", VA = "0x1829E6660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x29E6680", Offset = "0x29E5880", VA = "0x1829E6680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
