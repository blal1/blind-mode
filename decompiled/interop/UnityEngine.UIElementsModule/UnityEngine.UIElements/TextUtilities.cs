using Il2CppDummyDll;
using UnityEngine.TextCore;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x200045B")]
internal static class TextUtilities
{
	[Token(Token = "0x6002065")]
	[Address(RVA = "0x2A01B40", Offset = "0x2A00D40", VA = "0x182A01B40")]
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, in UnityEngine.TextCore.Text.RenderedText textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x2A01190", Offset = "0x2A00390", VA = "0x182A01190")]
	internal static FontAsset GetFontAsset(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x2A01A70", Offset = "0x2A00C70", VA = "0x182A01A70")]
	internal static bool IsFontAssigned(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x2A01880", Offset = "0x2A00A80", VA = "0x182A01880")]
	internal static TextSettings GetTextSettingsFrom(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x6002069")]
	[Address(RVA = "0x2A01950", Offset = "0x2A00B50", VA = "0x182A01950")]
	internal static bool IsAdvancedTextEnabledForElement(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x600206A")]
	[Address(RVA = "0x2A01370", Offset = "0x2A00570", VA = "0x182A01370")]
	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve, bool ignoreColors)
	{
		return default(TextCoreSettings);
	}

	[Token(Token = "0x600206B")]
	[Address(RVA = "0x2A01F90", Offset = "0x2A01190", VA = "0x182A01F90")]
	public static UnityEngine.TextCore.Text.TextWrappingMode toTextWrappingMode(this WhiteSpace whiteSpace, bool isSingleLineInputField)
	{
		return default(UnityEngine.TextCore.Text.TextWrappingMode);
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x2A01F30", Offset = "0x2A01130", VA = "0x182A01F30")]
	public static UnityEngine.TextCore.WhiteSpace toTextCore(this WhiteSpace whiteSpace, bool isInputField)
	{
		return default(UnityEngine.TextCore.WhiteSpace);
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x2A01F70", Offset = "0x2A01170", VA = "0x182A01F70")]
	public static UnityEngine.TextCore.TextOverflow toTextCore(this TextOverflow textOverflow, OverflowInternal overflow)
	{
		return default(UnityEngine.TextCore.TextOverflow);
	}
}
