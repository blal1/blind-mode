using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004FF")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal static class StyleCache
{
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<long, ComputedStyle> s_ComputedStyleCache;

	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache;

	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache;

	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x2A32760", Offset = "0x2A31960", VA = "0x182A32760")]
	public static bool TryGetValue(long hash, out ComputedStyle data)
	{
		return default(bool);
	}

	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x2A32460", Offset = "0x2A31660", VA = "0x182A32460")]
	public static void SetValue(long hash, ref ComputedStyle data)
	{
	}

	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x2A32640", Offset = "0x2A31840", VA = "0x182A32640")]
	public static bool TryGetValue(int hash, out StyleVariableContext data)
	{
		return default(bool);
	}

	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x2A32520", Offset = "0x2A31720", VA = "0x182A32520")]
	public static void SetValue(int hash, StyleVariableContext data)
	{
	}

	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x2A326D0", Offset = "0x2A318D0", VA = "0x182A326D0")]
	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x2A325B0", Offset = "0x2A317B0", VA = "0x182A325B0")]
	public static void SetValue(int hash, ComputedTransitionProperty[] data)
	{
	}
}
