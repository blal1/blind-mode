using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DE")]
public struct StyleList<T> : IStyleValue<List<T>>, IEquatable<StyleList<T>>
{
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x0")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_Value;

	[Token(Token = "0x17000838")]
	public List<T> value
	{
		[Token(Token = "0x6001DA9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001DAA")]
		set
		{
		}
	}

	[Token(Token = "0x17000839")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DAB")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DAC")]
		set
		{
		}
	}

	[Token(Token = "0x6001DAD")]
	public StyleList(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DAE")]
	internal StyleList(List<T> v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DAF")]
	public static bool operator ==(StyleList<T> lhs, StyleList<T> rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DB0")]
	public static implicit operator StyleList<T>(StyleKeyword keyword)
	{
		return default(StyleList<T>);
	}

	[Token(Token = "0x6001DB1")]
	public bool Equals(StyleList<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DB2")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DB3")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DB4")]
	public override string ToString()
	{
		return null;
	}
}
