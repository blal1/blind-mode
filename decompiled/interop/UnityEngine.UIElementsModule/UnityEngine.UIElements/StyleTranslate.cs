using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E1")]
public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
{
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x0")]
	private Translate m_Value;

	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x18")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700083E")]
	public Translate value
	{
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x29EAD00", Offset = "0x29E9F00", VA = "0x1829EAD00", Slot = "4")]
		get
		{
			return default(Translate);
		}
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x29E9BD0", Offset = "0x29E8DD0", VA = "0x1829E9BD0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700083F")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x138AC10", Offset = "0x1389E10", VA = "0x18138AC10", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x29E9BD0", Offset = "0x29E8DD0", VA = "0x1829E9BD0")]
	public StyleTranslate(Translate v)
	{
	}

	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x29E9BA0", Offset = "0x29E8DA0", VA = "0x1829E9BA0")]
	public StyleTranslate(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x29E9BF0", Offset = "0x29E8DF0", VA = "0x1829E9BF0")]
	internal StyleTranslate(Translate v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x29EADB0", Offset = "0x29E9FB0", VA = "0x1829EADB0")]
	public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x29E9E00", Offset = "0x29E9000", VA = "0x1829E9E00")]
	public static implicit operator StyleTranslate(StyleKeyword keyword)
	{
		return default(StyleTranslate);
	}

	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x29E9DD0", Offset = "0x29E8FD0", VA = "0x1829E9DD0")]
	public static implicit operator StyleTranslate(Translate v)
	{
		return default(StyleTranslate);
	}

	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x29EAAD0", Offset = "0x29E9CD0", VA = "0x1829EAAD0", Slot = "8")]
	public bool Equals(StyleTranslate other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x29EAB60", Offset = "0x29E9D60", VA = "0x1829EAB60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x29EAC60", Offset = "0x29E9E60", VA = "0x1829EAC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x29EAC80", Offset = "0x29E9E80", VA = "0x1829EAC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
