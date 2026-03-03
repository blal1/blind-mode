using System;
using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003DB")]
public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x0")]
	private StyleKeyword m_Keyword;

	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x8")]
	private FontDefinition m_Value;

	[Token(Token = "0x17000832")]
	public FontDefinition value
	{
		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x29E7970", Offset = "0x29E6B70", VA = "0x1829E7970", Slot = "4")]
		get
		{
			return default(FontDefinition);
		}
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x29E7A30", Offset = "0x29E6C30", VA = "0x1829E7A30", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000833")]
	public StyleKeyword keyword
	{
		[Token(Token = "0x6001D7E")]
		[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10", Slot = "6")]
		get
		{
			return default(StyleKeyword);
		}
		[Token(Token = "0x6001D7F")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x29E7850", Offset = "0x29E6A50", VA = "0x1829E7850")]
	public StyleFontDefinition(FontDefinition f)
	{
	}

	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x29E7810", Offset = "0x29E6A10", VA = "0x1829E7810")]
	public StyleFontDefinition(FontAsset f)
	{
	}

	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x29E78B0", Offset = "0x29E6AB0", VA = "0x1829E78B0")]
	public StyleFontDefinition(Font f)
	{
	}

	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x29E77F0", Offset = "0x29E69F0", VA = "0x1829E77F0")]
	public StyleFontDefinition(StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x29E78F0", Offset = "0x29E6AF0", VA = "0x1829E78F0")]
	internal StyleFontDefinition(object obj, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x29E7870", Offset = "0x29E6A70", VA = "0x1829E7870")]
	internal StyleFontDefinition(FontAsset f, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x29E7930", Offset = "0x29E6B30", VA = "0x1829E7930")]
	internal StyleFontDefinition(Font f, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x29E77D0", Offset = "0x29E69D0", VA = "0x1829E77D0")]
	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword)
	{
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x29E7990", Offset = "0x29E6B90", VA = "0x1829E7990")]
	public static implicit operator StyleFontDefinition(StyleKeyword keyword)
	{
		return default(StyleFontDefinition);
	}

	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x29E79E0", Offset = "0x29E6BE0", VA = "0x1829E79E0")]
	public static implicit operator StyleFontDefinition(FontDefinition f)
	{
		return default(StyleFontDefinition);
	}

	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x29E7750", Offset = "0x29E6950", VA = "0x1829E7750", Slot = "8")]
	public bool Equals(StyleFontDefinition other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0x29E7690", Offset = "0x29E6890", VA = "0x1829E7690", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x29E77A0", Offset = "0x29E69A0", VA = "0x1829E77A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
