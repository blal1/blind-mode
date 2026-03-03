using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005CD")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class StyleSheetCache
{
	[Token(Token = "0x20005CE")]
	private struct SheetHandleKey
	{
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0x0")]
		public readonly int sheetInstanceID;

		[Token(Token = "0x4001570")]
		[FieldOffset(Offset = "0x4")]
		public readonly int index;

		[Token(Token = "0x600288C")]
		[Address(RVA = "0x2A84350", Offset = "0x2A83550", VA = "0x182A84350")]
		public SheetHandleKey(StyleSheet sheet, int index)
		{
		}
	}

	[Token(Token = "0x20005CF")]
	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x2A84300", Offset = "0x2A83500", VA = "0x182A84300", Slot = "4")]
		public bool Equals(SheetHandleKey x, SheetHandleKey y)
		{
			return default(bool);
		}

		[Token(Token = "0x600288E")]
		[Address(RVA = "0x2A84320", Offset = "0x2A83520", VA = "0x182A84320", Slot = "5")]
		public int GetHashCode(SheetHandleKey key)
		{
			return default(int);
		}

		[Token(Token = "0x600288F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SheetHandleKeyComparer()
		{
		}
	}

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x0")]
	private static SheetHandleKeyComparer s_Comparer;

	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache;

	[Token(Token = "0x6002888")]
	[Address(RVA = "0x2A8B0C0", Offset = "0x2A8A2C0", VA = "0x182A8B0C0")]
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex)
	{
		return null;
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x2A8B2A0", Offset = "0x2A8A4A0", VA = "0x182A8B2A0")]
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule)
	{
		return null;
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0x2A8AFD0", Offset = "0x2A8A1D0", VA = "0x182A8AFD0")]
	private static StylePropertyId GetPropertyId(StyleRule rule, int index)
	{
		return default(StylePropertyId);
	}
}
