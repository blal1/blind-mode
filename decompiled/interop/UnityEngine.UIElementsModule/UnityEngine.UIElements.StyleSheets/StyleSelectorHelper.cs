using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005CB")]
internal static class StyleSelectorHelper
{
	[Token(Token = "0x20005CC")]
	private struct SelectorWorkItem
	{
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x0")]
		public StyleSheet.OrderedSelectorType type;

		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x8")]
		public string input;

		[Token(Token = "0x6002887")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		public SelectorWorkItem(StyleSheet.OrderedSelectorType type, string input)
		{
		}
	}

	[Token(Token = "0x6002882")]
	[Address(RVA = "0x2A8AC00", Offset = "0x2A89E00", VA = "0x182A8AC00")]
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector)
	{
		return default(MatchResultInfo);
	}

	[Token(Token = "0x6002883")]
	[Address(RVA = "0x2A8A9F0", Offset = "0x2A89BF0", VA = "0x182A8A9F0")]
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult)
	{
		return default(bool);
	}

	[Token(Token = "0x6002884")]
	[Address(RVA = "0x2A8AED0", Offset = "0x2A8A0D0", VA = "0x182A8AED0")]
	private static void TestSelectorLinkedList(StyleComplexSelector currentComplexSelector, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, ref SelectorMatchRecord record)
	{
	}

	[Token(Token = "0x6002885")]
	[Address(RVA = "0x2A89DB0", Offset = "0x2A88FB0", VA = "0x182A89DB0")]
	private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record)
	{
	}

	[Token(Token = "0x6002886")]
	[Address(RVA = "0x2A8A190", Offset = "0x2A89390", VA = "0x182A8A190")]
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex)
	{
	}
}
