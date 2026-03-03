using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D6")]
internal class EventCallbackRegistry
{
	[Token(Token = "0x20001D7")]
	internal struct DynamicCallbackList
	{
		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TrickleDown m_UseTrickleDown;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[NotNull]
		private EventCallbackList m_Callbacks;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CanBeNull]
		private EventCallbackList m_TemporaryCallbacks;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CanBeNull]
		private List<EventCallbackFunctorBase> m_UnregisteredCallbacksDuringInvoke;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_IsInvoking;

		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x2B0FAF0", Offset = "0x2B0ECF0", VA = "0x182B0FAF0")]
		public static DynamicCallbackList Create(TrickleDown useTrickleDown)
		{
			return default(DynamicCallbackList);
		}

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x2B0FE30", Offset = "0x2B0F030", VA = "0x182B0FE30")]
		[NotNull]
		public EventCallbackList GetCallbackListForWriting()
		{
			return null;
		}

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x2B0FE20", Offset = "0x2B0F020", VA = "0x182B0FE20")]
		[NotNull]
		public readonly EventCallbackList GetCallbackListForReading()
		{
			return null;
		}

		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x2B101F0", Offset = "0x2B0F3F0", VA = "0x182B101F0")]
		public bool UnregisterCallback(long eventTypeId, [NotNull] Delegate callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x2B0FF30", Offset = "0x2B0F130", VA = "0x182B0FF30")]
		public void Invoke(EventBase evt, BaseVisualElementPanel panel, VisualElement target)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x2B0FAE0", Offset = "0x2B0ECE0", VA = "0x182B0FAE0")]
		private void BeginInvoke()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x2B0FBE0", Offset = "0x2B0EDE0", VA = "0x182B0FBE0")]
		private void EndInvoke()
		{
		}
	}

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly EventCallbackListPool s_ListPool;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal DynamicCallbackList m_TrickleDownCallbacks;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal DynamicCallbackList m_BubbleUpCallbacks;

	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x2B12B10", Offset = "0x2B11D10", VA = "0x182B12B10")]
	private static EventCallbackList GetCallbackList([Optional] EventCallbackList initializer)
	{
		return null;
	}

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x2B12BA0", Offset = "0x2B11DA0", VA = "0x182B12BA0")]
	private static void ReleaseCallbackList(EventCallbackList toRelease)
	{
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x2B12B80", Offset = "0x2B11D80", VA = "0x182B12B80")]
	private unsafe ref DynamicCallbackList GetDynamicCallbackList(TrickleDown useTrickleDown)
	{
		return ref *(DynamicCallbackList*)null;
	}

	[Token(Token = "0x6000D5B")]
	public void RegisterCallback<TEventType>([NotNull] EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D5C")]
	public void RegisterCallback<TEventType, TCallbackArgs>([NotNull] EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D5D")]
	public bool UnregisterCallback<TEventType>([NotNull] EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D5E")]
	public bool UnregisterCallback<TEventType, TCallbackArgs>([NotNull] EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x2B12D40", Offset = "0x2B11F40", VA = "0x182B12D40")]
	public EventCallbackRegistry()
	{
	}
}
