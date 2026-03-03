using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001CF")]
internal abstract class EventCallbackFunctorBase : IDisposable
{
	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x10")]
	public long eventTypeId;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x18")]
	public InvokePolicy invokePolicy;

	[Token(Token = "0x6000D39")]
	public abstract void Invoke(EventBase evt);

	[Token(Token = "0x6000D3A")]
	public abstract void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown);

	[Token(Token = "0x6000D3B")]
	public abstract void Dispose();

	[Token(Token = "0x6000D3C")]
	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback);

	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected EventCallbackFunctorBase()
	{
	}
}
