using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F7")]
internal static class VisualElementUtils
{
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x0")]
	private static readonly HashSet<string> s_usedNames;

	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Type s_FoldoutType;

	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string s_InspectorElementUssClassName;

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x2A3F2C0", Offset = "0x2A3E4C0", VA = "0x182A3F2C0")]
	public static string GetUniqueName(string nameBase)
	{
		return null;
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x2A3F1D0", Offset = "0x2A3E3D0", VA = "0x182A3F1D0")]
	internal static int GetFoldoutDepth(this VisualElement element)
	{
		return default(int);
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x2A3F0A0", Offset = "0x2A3E2A0", VA = "0x182A3F0A0")]
	internal static void AssignInspectorStyleIfNecessary(this VisualElement element, string classNameToEnable)
	{
	}
}
