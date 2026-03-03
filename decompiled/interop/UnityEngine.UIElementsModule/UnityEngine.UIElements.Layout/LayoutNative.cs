using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005B5")]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
internal static class LayoutNative
{
	[Token(Token = "0x20005B6")]
	internal enum LayoutLogEventType
	{
		[Token(Token = "0x4001493")]
		None,
		[Token(Token = "0x4001494")]
		Error,
		[Token(Token = "0x4001495")]
		Measure,
		[Token(Token = "0x4001496")]
		Layout,
		[Token(Token = "0x4001497")]
		CacheUsage,
		[Token(Token = "0x4001498")]
		BeginLayout,
		[Token(Token = "0x4001499")]
		EndLayout
	}

	[Token(Token = "0x20005B7")]
	internal class LayoutLogData
	{
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0x10")]
		public LayoutNode node;

		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0x40")]
		public LayoutLogEventType eventType;

		[Token(Token = "0x400149C")]
		[FieldOffset(Offset = "0x48")]
		public string message;

		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LayoutLogData()
		{
		}
	}

	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<LayoutLogData> onLayoutLog;

	[MethodImpl(4096)]
	[Token(Token = "0x60027BE")]
	[Address(RVA = "0x2A713A0", Offset = "0x2A705A0", VA = "0x182A713A0")]
	[UnityEngine.Bindings.NativeMethod(IsThreadSafe = false)]
	internal static extern void CalculateLayout(IntPtr node, float parentWidth, float parentHeight, int parentDirection, IntPtr state, IntPtr exceptionGCHandle);

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0x2A71410", Offset = "0x2A70610", VA = "0x182A71410")]
	[UnityEngine.Scripting.RequiredByNativeCode]
	private static void LayoutLog_Internal(IntPtr nodePtr, LayoutLogEventType type, string message)
	{
	}
}
