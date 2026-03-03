using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005BD")]
[UnityEngine.Bindings.VisibleToOtherModules]
internal static class ShorthandApplicator
{
	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x0")]
	private static List<TimeValue> s_TransitionDelayList;

	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x8")]
	private static List<TimeValue> s_TransitionDurationList;

	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x10")]
	private static List<StylePropertyName> s_TransitionPropertyList;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x18")]
	private static List<EasingFunction> s_TransitionTimingFunctionList;

	[Token(Token = "0x6002820")]
	[Address(RVA = "0x2A74610", Offset = "0x2A73810", VA = "0x182A74610")]
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002821")]
	[Address(RVA = "0x2A746E0", Offset = "0x2A738E0", VA = "0x182A746E0")]
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002822")]
	[Address(RVA = "0x2A74910", Offset = "0x2A73B10", VA = "0x182A74910")]
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0x2A74AF0", Offset = "0x2A73CF0", VA = "0x182A74AF0")]
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x2A74D30", Offset = "0x2A73F30", VA = "0x182A74D30")]
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x2A74E10", Offset = "0x2A74010", VA = "0x182A74E10")]
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0x2A75000", Offset = "0x2A74200", VA = "0x182A75000")]
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002827")]
	[Address(RVA = "0x2A751F0", Offset = "0x2A743F0", VA = "0x182A751F0")]
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002828")]
	[Address(RVA = "0x2A75340", Offset = "0x2A74540", VA = "0x182A75340")]
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x6002829")]
	[Address(RVA = "0x2A754B0", Offset = "0x2A746B0", VA = "0x182A754B0")]
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x600282A")]
	[Address(RVA = "0x2A762C0", Offset = "0x2A754C0", VA = "0x182A762C0")]
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis)
	{
		return default(bool);
	}

	[Token(Token = "0x600282B")]
	[Address(RVA = "0x2A75C80", Offset = "0x2A74E80", VA = "0x182A75C80")]
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
	{
	}

	[Token(Token = "0x600282C")]
	[Address(RVA = "0x2A755D0", Offset = "0x2A747D0", VA = "0x182A755D0")]
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY)
	{
	}

	[Token(Token = "0x600282D")]
	[Address(RVA = "0x2A77010", Offset = "0x2A76210", VA = "0x182A77010")]
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize)
	{
	}

	[Token(Token = "0x600282E")]
	[Address(RVA = "0x2A76150", Offset = "0x2A75350", VA = "0x182A76150")]
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
	{
	}

	[Token(Token = "0x600282F")]
	[Address(RVA = "0x2A75F70", Offset = "0x2A75170", VA = "0x182A75F70")]
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left)
	{
	}

	[Token(Token = "0x6002830")]
	[Address(RVA = "0x2A75DC0", Offset = "0x2A74FC0", VA = "0x182A75DC0")]
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left)
	{
	}

	[Token(Token = "0x6002831")]
	[Address(RVA = "0x2A764C0", Offset = "0x2A756C0", VA = "0x182A764C0")]
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth)
	{
	}

	[Token(Token = "0x6002832")]
	[Address(RVA = "0x2A76580", Offset = "0x2A75780", VA = "0x182A76580")]
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction)
	{
	}
}
