using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005C1")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class StylePropertyUtil
{
	[Token(Token = "0x400153E")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly Dictionary<string, StylePropertyId> s_NameToId;

	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly Dictionary<StylePropertyId, string> s_IdToName;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly Dictionary<string, string> s_UssNameToCSharpName;

	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x18")]
	internal static readonly Dictionary<string, string> s_CSharpNameToUssName;

	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties;

	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x28")]
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties;

	[Token(Token = "0x6002838")]
	[Address(RVA = "0x2A78920", Offset = "0x2A77B20", VA = "0x182A78920")]
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x2A787C0", Offset = "0x2A779C0", VA = "0x182A787C0")]
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
	{
		return default(bool);
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0x2A78740", Offset = "0x2A77940", VA = "0x182A78740")]
	public static bool IsAnimatable(StylePropertyId id)
	{
		return default(bool);
	}
}
