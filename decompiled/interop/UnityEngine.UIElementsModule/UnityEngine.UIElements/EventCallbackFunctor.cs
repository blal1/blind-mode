using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D0")]
internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
{
	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x0")]
	private EventCallback<TEventType> m_Callback;

	[Token(Token = "0x6000D3E")]
	public static EventCallbackFunctor<TEventType> GetPooled(long eventTypeId, EventCallback<TEventType> callback, InvokePolicy invokePolicy = InvokePolicy.Default)
	{
		return null;
	}

	[Token(Token = "0x6000D3F")]
	public override void Dispose()
	{
	}

	[Token(Token = "0x6000D40")]
	public override void Invoke(EventBase evt)
	{
	}

	[Token(Token = "0x6000D41")]
	public override void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown)
	{
	}

	[Token(Token = "0x6000D42")]
	public override bool IsEquivalentTo(long eventTypeId, Delegate callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D43")]
	public EventCallbackFunctor()
	{
	}
}
[Token(Token = "0x20001D1")]
internal class EventCallbackFunctor<TEventType, TCallbackArgs> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
{
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x0")]
	private EventCallback<TEventType, TCallbackArgs> m_Callback;

	[Token(Token = "0x17000263")]
	internal TCallbackArgs userArgs
	{
		[Token(Token = "0x6000D44")]
		[CompilerGenerated]
		get
		{
			return (TCallbackArgs)null;
		}
		[Token(Token = "0x6000D45")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000D46")]
	public static EventCallbackFunctor<TEventType, TCallbackArgs> GetPooled(long eventTypeId, EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, InvokePolicy invokePolicy = InvokePolicy.Default)
	{
		return null;
	}

	[Token(Token = "0x6000D47")]
	public override void Dispose()
	{
	}

	[Token(Token = "0x6000D48")]
	public override void Invoke(EventBase evt)
	{
	}

	[Token(Token = "0x6000D49")]
	public override void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown)
	{
	}

	[Token(Token = "0x6000D4A")]
	public override bool IsEquivalentTo(long eventTypeId, Delegate callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D4B")]
	public EventCallbackFunctor()
	{
	}
}
