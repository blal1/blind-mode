using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004E5")]
internal static class EventInterestReflectionUtils
{
	[Token(Token = "0x20004E6")]
	private struct DefaultEventInterests
	{
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x0")]
		public int DefaultActionCategories;

		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x4")]
		public int DefaultActionAtTargetCategories;

		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x8")]
		public int HandleEventTrickleDownCategories;

		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0xC")]
		public int HandleEventBubbleUpCategories;
	}

	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests;

	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<Type, EventCategory> s_EventCategories;

	[Token(Token = "0x600238D")]
	[Address(RVA = "0x2A31010", Offset = "0x2A30210", VA = "0x182A31010")]
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories, out int handleEventTrickleDownCategories, out int handleEventBubbleUpCategories)
	{
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0x2A30DF0", Offset = "0x2A2FFF0", VA = "0x182A30DF0")]
	private static int ComputeDefaultEventInterests(Type elementType, string methodName)
	{
		return default(int);
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0x2A31300", Offset = "0x2A30500", VA = "0x182A31300")]
	internal static EventCategory GetEventCategory(Type eventType)
	{
		return default(EventCategory);
	}
}
