using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E2")]
public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
{
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x0")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x4")]
	private TextShadow m_Value;

	[Token(Token = "0x17000840")]
	public TextShadow value
	{
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x29EA510", Offset = "0x29E9710", VA = "0x1829EA510", Slot = "4")]
		get
		{
			return default(TextShadow);
		}
		[Token(Token = "0x6001DE0")]
		[Address(RVA = "0x29EA650", Offset = "0x29E9850", VA = "0x1829EA650", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000841")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x29EA4C0", Offset = "0x29E96C0", VA = "0x1829EA4C0")]
	public StyleTextShadow(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x29EA4F0", Offset = "0x29E96F0", VA = "0x1829EA4F0")]
	internal StyleTextShadow(TextShadow v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x29EA560", Offset = "0x29E9760", VA = "0x1829EA560")]
	public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x29EA610", Offset = "0x29E9810", VA = "0x1829EA610")]
	public static implicit operator StyleTextShadow(StyleKeyword keyword)
	{
		return default(StyleTextShadow);
	}

	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0x29EA360", Offset = "0x29E9560", VA = "0x1829EA360", Slot = "8")]
	public bool Equals(StyleTextShadow other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x29EA230", Offset = "0x29E9430", VA = "0x1829EA230", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x29EA410", Offset = "0x29E9610", VA = "0x1829EA410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x29EA450", Offset = "0x29E9650", VA = "0x1829EA450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
