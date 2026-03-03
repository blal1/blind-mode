using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003E3")]
public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
{
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x0")]
	private TransformOrigin m_Value;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x14")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x17000842")]
	public TransformOrigin value
	{
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x29EA890", Offset = "0x29E9A90", VA = "0x1829EA890", Slot = "4")]
		get
		{
			return default(TransformOrigin);
		}
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x29E6820", Offset = "0x29E5A20", VA = "0x1829E6820", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000843")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x1991C20", Offset = "0x1990E20", VA = "0x181991C20", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x29E6820", Offset = "0x29E5A20", VA = "0x1829E6820")]
	public StyleTransformOrigin(TransformOrigin v)
	{
	}

	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x29E6710", Offset = "0x29E5910", VA = "0x1829E6710")]
	public StyleTransformOrigin(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x29E66F0", Offset = "0x29E58F0", VA = "0x1829E66F0")]
	internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x29EA9B0", Offset = "0x29E9BB0", VA = "0x1829EA9B0")]
	public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x29E67F0", Offset = "0x29E59F0", VA = "0x1829E67F0")]
	public static implicit operator StyleTransformOrigin(StyleKeyword keyword)
	{
		return default(StyleTransformOrigin);
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x29EAAA0", Offset = "0x29E9CA0", VA = "0x1829EAAA0")]
	public static implicit operator StyleTransformOrigin(TransformOrigin v)
	{
		return default(StyleTransformOrigin);
	}

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x29EA670", Offset = "0x29E9870", VA = "0x1829EA670", Slot = "8")]
	public bool Equals(StyleTransformOrigin other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x29EA760", Offset = "0x29E9960", VA = "0x1829EA760", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x29EA800", Offset = "0x29E9A00", VA = "0x1829EA800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x29EA820", Offset = "0x29E9A20", VA = "0x1829EA820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
