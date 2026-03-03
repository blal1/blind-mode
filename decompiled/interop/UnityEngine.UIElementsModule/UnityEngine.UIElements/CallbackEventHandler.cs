using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001DB")]
public abstract class CallbackEventHandler : IEventHandler
{
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x10")]
	internal bool isIMGUIContainer;

	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x18")]
	internal EventCallbackRegistry m_CallbackRegistry;

	[Token(Token = "0x4000863")]
	internal const string HandleEventBubbleUpName = "HandleEventBubbleUp";

	[Token(Token = "0x4000864")]
	internal const string HandleEventTrickleDownName = "HandleEventTrickleDown";

	[Token(Token = "0x4000865")]
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction";

	[Token(Token = "0x4000866")]
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget";

	[Token(Token = "0x6000D7F")]
	public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D80")]
	private void AddEventCategories<TEventType>(TrickleDown useTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D81")]
	public void RegisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D82")]
	internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D83")]
	public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D84")]
	public void UnregisterCallback<TEventType, TUserArgsType>(EventCallback<TEventType, TUserArgsType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
	{
	}

	[Token(Token = "0x6000D85")]
	public abstract void SendEvent(EventBase e);

	[Token(Token = "0x6000D86")]
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	[EventInterest(EventInterestOptions.Inherit)]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	[EventInterest(EventInterestOptions.Inherit)]
	protected virtual void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void HandleEventBubbleUpDisabled(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x21186B0", Offset = "0x21178B0", VA = "0x1821186B0")]
	internal void HandleEventBubbleUpInternal(EventBase evt)
	{
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	[EventInterest(EventInterestOptions.Inherit)]
	protected virtual void HandleEventTrickleDown(EventBase evt)
	{
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void HandleEventTrickleDownDisabled(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x2346EE0", Offset = "0x23460E0", VA = "0x182346EE0")]
	internal void HandleEventTrickleDownInternal(EventBase evt)
	{
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	[EventInterest(EventInterestOptions.Inherit)]
	protected virtual void ExecuteDefaultAction(EventBase evt)
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
	{
	}

	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[EventInterest(EventInterestOptions.Inherit)]
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x2B0E010", Offset = "0x2B0D210", VA = "0x182B0E010")]
	internal void ExecuteDefaultActionInternal(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x2B0DFF0", Offset = "0x2B0D1F0", VA = "0x182B0DFF0")]
	internal void ExecuteDefaultActionDisabledInternal(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x29745D0", Offset = "0x29737D0", VA = "0x1829745D0")]
	internal void ExecuteDefaultActionAtTargetInternal(EventBase evt)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x2B0DFD0", Offset = "0x2B0D1D0", VA = "0x182B0DFD0")]
	internal void ExecuteDefaultActionDisabledAtTargetInternal(EventBase evt)
	{
	}

	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x2B0E030", Offset = "0x2B0D230", VA = "0x182B0E030")]
	protected void NotifyPropertyChanged(in BindingId property)
	{
	}

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x2B0E1E0", Offset = "0x2B0D3E0", VA = "0x182B0E1E0")]
	protected CallbackEventHandler()
	{
	}
}
