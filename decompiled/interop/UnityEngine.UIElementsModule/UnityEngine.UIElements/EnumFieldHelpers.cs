using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000C2")]
internal static class EnumFieldHelpers
{
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly UxmlTypeAttributeDescription<Enum> type;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly UxmlStringAttributeDescription value;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues;

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x2AAB080", Offset = "0x2AAA280", VA = "0x182AAB080")]
	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues)
	{
		return default(bool);
	}
}
