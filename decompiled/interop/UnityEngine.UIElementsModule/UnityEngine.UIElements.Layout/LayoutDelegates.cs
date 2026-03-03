using System;
using AOT;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200058F")]
internal static class LayoutDelegates
{
	[Token(Token = "0x40013E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker;

	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker;

	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0x10")]
	private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate;

	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x18")]
	private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate;

	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly IntPtr s_InvokeMeasureFunction;

	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x28")]
	internal static readonly IntPtr s_InvokeBaselineFunction;

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x2A6EF70", Offset = "0x2A6E170", VA = "0x182A6EF70")]
	[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
	private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result)
	{
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x2A6EE20", Offset = "0x2A6E020", VA = "0x182A6EE20")]
	[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
	private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height)
	{
		return default(float);
	}
}
