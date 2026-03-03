using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003D8")]
public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> where T : struct, IConvertible
{
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x0")]
	private T m_Value;

	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x0")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x1700082C")]
	public T value
	{
		[Token(Token = "0x6001D51")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6001D52")]
		set
		{
		}
	}

	[Token(Token = "0x1700082D")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D53")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D54")]
		set
		{
		}
	}

	[Token(Token = "0x6001D55")]
	public StyleEnum(T v)
	{
	}

	[Token(Token = "0x6001D56")]
	public StyleEnum(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D57")]
	internal StyleEnum(T v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D58")]
	public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D59")]
	public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D5A")]
	public static implicit operator StyleEnum<T>(StyleKeyword keyword)
	{
		return default(StyleEnum<T>);
	}

	[Token(Token = "0x6001D5B")]
	public static implicit operator StyleEnum<T>(T v)
	{
		return default(StyleEnum<T>);
	}

	[Token(Token = "0x6001D5C")]
	public bool Equals(StyleEnum<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D5D")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D5E")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D5F")]
	public override string ToString()
	{
		return null;
	}
}
