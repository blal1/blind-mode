using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003C2")]
internal class StyleValueCollection
{
	[Token(Token = "0x4000C96")]
	[FieldOffset(Offset = "0x10")]
	internal List<StyleValue> m_Values;

	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x29EB4E0", Offset = "0x29EA6E0", VA = "0x1829EB4E0")]
	public StyleLength GetStyleLength(StylePropertyId id)
	{
		return default(StyleLength);
	}

	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x29EB210", Offset = "0x29EA410", VA = "0x1829EB210")]
	public StyleFloat GetStyleFloat(StylePropertyId id)
	{
		return default(StyleFloat);
	}

	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0x29EB460", Offset = "0x29EA660", VA = "0x1829EB460")]
	public StyleInt GetStyleInt(StylePropertyId id)
	{
		return default(StyleInt);
	}

	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x29EB1A0", Offset = "0x29EA3A0", VA = "0x1829EB1A0")]
	public StyleColor GetStyleColor(StylePropertyId id)
	{
		return default(StyleColor);
	}

	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0x29EAF50", Offset = "0x29EA150", VA = "0x1829EAF50")]
	public StyleBackground GetStyleBackground(StylePropertyId id)
	{
		return default(StyleBackground);
	}

	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0x29EAE40", Offset = "0x29EA040", VA = "0x1829EAE40")]
	public StyleBackgroundPosition GetStyleBackgroundPosition(StylePropertyId id)
	{
		return default(StyleBackgroundPosition);
	}

	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x29EAEC0", Offset = "0x29EA0C0", VA = "0x1829EAEC0")]
	public StyleBackgroundRepeat GetStyleBackgroundRepeat(StylePropertyId id)
	{
		return default(StyleBackgroundRepeat);
	}

	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x29EB370", Offset = "0x29EA570", VA = "0x1829EB370")]
	public StyleFont GetStyleFont(StylePropertyId id)
	{
		return default(StyleFont);
	}

	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x29EB280", Offset = "0x29EA480", VA = "0x1829EB280")]
	public StyleFontDefinition GetStyleFontDefinition(StylePropertyId id)
	{
		return default(StyleFontDefinition);
	}

	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x29EB760", Offset = "0x29EA960", VA = "0x1829EB760")]
	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x29EB590", Offset = "0x29EA790", VA = "0x1829EB590")]
	public void SetStyleValue(StyleValue value)
	{
	}

	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x29EB8B0", Offset = "0x29EAAB0", VA = "0x1829EB8B0")]
	public StyleValueCollection()
	{
	}
}
