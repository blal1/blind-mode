using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005CA")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct SelectorMatchRecord
{
	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x0")]
	public StyleSheet sheet;

	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x8")]
	public int styleSheetIndexInStack;

	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x10")]
	public StyleComplexSelector complexSelector;

	[Token(Token = "0x6002880")]
	[Address(RVA = "0x2A842D0", Offset = "0x2A834D0", VA = "0x182A842D0")]
	public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack)
	{
	}

	[Token(Token = "0x6002881")]
	[Address(RVA = "0x2A84180", Offset = "0x2A83380", VA = "0x182A84180")]
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b)
	{
		return default(int);
	}
}
