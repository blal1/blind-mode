using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005BE")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class StylePropertyCache
{
	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly Dictionary<string, string> s_PropertySyntaxCache;

	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly Dictionary<string, string> s_NonTerminalValues;

	[Token(Token = "0x6002835")]
	[Address(RVA = "0x2A77310", Offset = "0x2A76510", VA = "0x182A77310")]
	public static bool TryGetSyntax(string name, out string syntax)
	{
		return default(bool);
	}

	[Token(Token = "0x6002836")]
	[Address(RVA = "0x2A77280", Offset = "0x2A76480", VA = "0x182A77280")]
	public static bool TryGetNonTerminalValue(string name, out string syntax)
	{
		return default(bool);
	}
}
