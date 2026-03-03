using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002CE")]
internal static class ComputedTransitionUtils
{
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x0")]
	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer;

	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x2B5CCA0", Offset = "0x2B5BEA0", VA = "0x182B5CCA0")]
	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x2B5C7B0", Offset = "0x2B5B9B0", VA = "0x182B5C7B0")]
	internal static bool HasTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id)
	{
		return default(bool);
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x2B5C680", Offset = "0x2B5B880", VA = "0x182B5C680")]
	internal static bool GetTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result)
	{
		return default(bool);
	}

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x2B5C050", Offset = "0x2B5B250", VA = "0x182B5C050")]
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle)
	{
		return null;
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x2B5C210", Offset = "0x2B5B410", VA = "0x182B5C210")]
	private static int GetTransitionHashCode(ref ComputedStyle cs)
	{
		return default(int);
	}

	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x2B5C9A0", Offset = "0x2B5BBA0", VA = "0x182B5C9A0")]
	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y)
	{
		return default(bool);
	}

	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x2B5C880", Offset = "0x2B5BA80", VA = "0x182B5C880")]
	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b)
	{
		return default(bool);
	}

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x2B5CBA0", Offset = "0x2B5BDA0", VA = "0x182B5CBA0")]
	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b)
	{
		return default(bool);
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0x2B5ACC0", Offset = "0x2B59EC0", VA = "0x182B5ACC0")]
	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData)
	{
	}

	[Token(Token = "0x6001401")]
	private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0x2B5C020", Offset = "0x2B5B220", VA = "0x182B5C020")]
	private static int ConvertTransitionTime(TimeValue time)
	{
		return default(int);
	}

	[Token(Token = "0x6001403")]
	[Address(RVA = "0x2B5B010", Offset = "0x2B5A210", VA = "0x182B5B010")]
	private static Func<float, float> ConvertTransitionFunction(EasingMode mode)
	{
		return null;
	}
}
