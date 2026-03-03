using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D2")]
public struct StyleBackgroundRepeat : IStyleValue<BackgroundRepeat>, IEquatable<StyleBackgroundRepeat>
{
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x0")]
	private BackgroundRepeat m_Value;

	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x8")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000823")]
	public BackgroundRepeat value
	{
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x29E6430", Offset = "0x29E5630", VA = "0x1829E6430", Slot = "4")]
		get
		{
			return default(BackgroundRepeat);
		}
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x29E6490", Offset = "0x29E5690", VA = "0x1829E6490", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000824")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x12CF490", Offset = "0x12CE690", VA = "0x1812CF490", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x1EDF6D0", Offset = "0x1EDE8D0", VA = "0x181EDF6D0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x29E6400", Offset = "0x29E5600", VA = "0x1829E6400")]
	public StyleBackgroundRepeat(BackgroundRepeat v)
	{
	}

	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x29E6420", Offset = "0x29E5620", VA = "0x1829E6420")]
	public StyleBackgroundRepeat(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x29E6410", Offset = "0x29E5610", VA = "0x1829E6410")]
	internal StyleBackgroundRepeat(BackgroundRepeat v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x29E6440", Offset = "0x29E5640", VA = "0x1829E6440")]
	public static bool operator ==(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x29E6470", Offset = "0x29E5670", VA = "0x1829E6470")]
	public static implicit operator StyleBackgroundRepeat(StyleKeyword keyword)
	{
		return default(StyleBackgroundRepeat);
	}

	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x29E6250", Offset = "0x29E5450", VA = "0x1829E6250", Slot = "8")]
	public bool Equals(StyleBackgroundRepeat other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x29E62B0", Offset = "0x29E54B0", VA = "0x1829E62B0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x29E6370", Offset = "0x29E5570", VA = "0x1829E6370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x29E6390", Offset = "0x29E5590", VA = "0x1829E6390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
