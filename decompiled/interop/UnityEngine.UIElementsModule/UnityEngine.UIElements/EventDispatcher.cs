using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001B2")]
public sealed class EventDispatcher
{
	[Token(Token = "0x20001B3")]
	private struct EventRecord
	{
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x0")]
		public EventBase m_Event;

		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x8")]
		public BaseVisualElementPanel m_Panel;
	}

	[Token(Token = "0x20001B4")]
	private struct DispatchContext
	{
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x0")]
		public uint m_GateCount;

		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x8")]
		public Queue<EventRecord> m_Queue;
	}

	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x10")]
	internal ClickDetector m_ClickDetector;

	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool;

	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x18")]
	private Queue<EventRecord> m_Queue;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x28")]
	private uint m_GateCount;

	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_GateDepth;

	[Token(Token = "0x4000800")]
	internal const int k_MaxGateDepth = 500;

	[Token(Token = "0x4000801")]
	internal const int k_NumberOfEventsWithStackInfo = 10;

	[Token(Token = "0x4000802")]
	internal const int k_NumberOfEventsWithEventInfo = 100;

	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x30")]
	private int m_DispatchStackFrame;

	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x38")]
	private EventBase m_CurrentEvent;

	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x40")]
	private Stack<DispatchContext> m_DispatchContexts;

	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Immediate;

	[Token(Token = "0x17000240")]
	internal PointerDispatchState pointerState
	{
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000241")]
	private bool dispatchImmediately
	{
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2B16900", Offset = "0x2B15B00", VA = "0x182B16900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000242")]
	private bool processingEvents
	{
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0xD99E80", Offset = "0xD99080", VA = "0x180D99E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x2B15850", Offset = "0x2B14A50", VA = "0x182B15850")]
	internal static EventDispatcher CreateDefault()
	{
		return null;
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x2B167A0", Offset = "0x2B159A0", VA = "0x182B167A0")]
	[Obsolete("Please use EventDispatcher.CreateDefault().")]
	internal EventDispatcher()
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x2B159D0", Offset = "0x2B14BD0", VA = "0x182B159D0")]
	internal void Dispatch(EventBase evt, [NotNull] BaseVisualElementPanel panel, DispatchMode dispatchMode)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x2B15BD0", Offset = "0x2B14DD0", VA = "0x182B15BD0")]
	private bool HandleRecursiveState(EventBase evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x2B15840", Offset = "0x2B14A40", VA = "0x182B15840")]
	internal void CloseGate()
	{
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x2B15FC0", Offset = "0x2B151C0", VA = "0x182B15FC0")]
	internal void OpenGate()
	{
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x2B160A0", Offset = "0x2B152A0", VA = "0x182B160A0")]
	private void ProcessEventQueue()
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x2B16340", Offset = "0x2B15540", VA = "0x182B16340")]
	private void ProcessEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel)
	{
	}
}
