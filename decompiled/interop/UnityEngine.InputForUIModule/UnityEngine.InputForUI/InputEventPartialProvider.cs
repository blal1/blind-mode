using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public class InputEventPartialProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__ev;

	private static readonly System.IntPtr NativeFieldInfoPtr__operatingSystemFamily;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardButtonsState;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr__sendNavigationEventOnTabKey;

	private static readonly System.IntPtr NativeFieldInfoPtr__IMGUICommandToInputForUICommandType;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Private_DiscreteTime_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEventModifiers_Private_Void_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToKeyEvent_Private_KeyEvent_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTextInputEvent_Private_TextInputEvent_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendNextOrPreviousNavigationEventOnTabKeyDownEvent_Private_Void_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCommandEvent_Private_CommandEvent_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public const int kDefaultPlayerId = 0;

	public unsafe UnityEngine.Event _ev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ev);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Event>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ev)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe OperatingSystemFamily _operatingSystemFamily
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__operatingSystemFamily);
			return *(OperatingSystemFamily*)num;
		}
		set
		{
			*(OperatingSystemFamily*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__operatingSystemFamily)) = value;
		}
	}

	public unsafe KeyEvent.ButtonsState _keyboardButtonsState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardButtonsState);
			return *(KeyEvent.ButtonsState*)num;
		}
		set
		{
			*(KeyEvent.ButtonsState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardButtonsState)) = value;
		}
	}

	public unsafe EventModifiers _eventModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventModifiers);
			return *(EventModifiers*)num;
		}
		set
		{
			*(EventModifiers*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventModifiers)) = value;
		}
	}

	public unsafe bool _sendNavigationEventOnTabKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendNavigationEventOnTabKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendNavigationEventOnTabKey)) = value;
		}
	}

	public unsafe IDictionary<string, CommandEvent.Command> _IMGUICommandToInputForUICommandType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IMGUICommandToInputForUICommandType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, CommandEvent.Command>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IMGUICommandToInputForUICommandType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public uint playerCount => 0u;

	static InputEventPartialProvider()
	{
		Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "InputEventPartialProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr);
		NativeFieldInfoPtr__ev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_ev");
		NativeFieldInfoPtr__operatingSystemFamily = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_operatingSystemFamily");
		NativeFieldInfoPtr__keyboardButtonsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_keyboardButtonsState");
		NativeFieldInfoPtr__eventModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_eventModifiers");
		NativeFieldInfoPtr__sendNavigationEventOnTabKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_sendNavigationEventOnTabKey");
		NativeFieldInfoPtr__IMGUICommandToInputForUICommandType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, "_IMGUICommandToInputForUICommandType");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_GetTimestamp_Private_DiscreteTime_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_UpdateEventModifiers_Private_Void_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_ToKeyEvent_Private_KeyEvent_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_ToTextInputEvent_Private_TextInputEvent_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_SendNextOrPreviousNavigationEventOnTabKeyDownEvent_Private_Void_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_ToCommandEvent_Private_CommandEvent_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr, 100663438);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251658, RefRangeEnd = 1251659, XrefRangeStart = 1251657, XrefRangeEnd = 1251658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Shutdown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1251685, RefRangeEnd = 1251687, XrefRangeStart = 1251659, XrefRangeEnd = 1251685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251687, RefRangeEnd = 1251688, XrefRangeStart = 1251687, XrefRangeEnd = 1251687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnFocusChanged(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFocusChanged_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251688, XrefRangeEnd = 1251690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscreteTime GetTimestamp([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimestamp_Private_DiscreteTime_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251713, RefRangeEnd = 1251714, XrefRangeStart = 1251690, XrefRangeEnd = 1251713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEventModifiers([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEventModifiers_Private_Void_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251721, RefRangeEnd = 1251722, XrefRangeStart = 1251714, XrefRangeEnd = 1251721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyEvent ToKeyEvent([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToKeyEvent_Private_KeyEvent_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
		return *(KeyEvent*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251725, RefRangeEnd = 1251726, XrefRangeStart = 1251722, XrefRangeEnd = 1251725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextInputEvent ToTextInputEvent([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTextInputEvent_Private_TextInputEvent_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
		return *(TextInputEvent*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251738, RefRangeEnd = 1251739, XrefRangeStart = 1251726, XrefRangeEnd = 1251738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendNextOrPreviousNavigationEventOnTabKeyDownEvent([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendNextOrPreviousNavigationEventOnTabKeyDownEvent_Private_Void_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251756, RefRangeEnd = 1251757, XrefRangeStart = 1251739, XrefRangeEnd = 1251756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CommandEvent ToCommandEvent([In] ref UnityEngine.Event ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCommandEvent_Private_CommandEvent_byref_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		ev = ((intPtr4 == (System.IntPtr)0) ? null : new UnityEngine.Event(intPtr4));
		return *(CommandEvent*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1251864, RefRangeEnd = 1251866, XrefRangeStart = 1251757, XrefRangeEnd = 1251864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEventPartialProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventPartialProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputEventPartialProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool RequestCurrentState(Event.Type type)
	{
		if (type == Event.Type.KeyEvent)
		{
			KeyEvent keyEvent = default(KeyEvent);
			keyEvent.type = KeyEvent.Type.State;
			keyEvent.keyCode = KeyCode.None;
			keyEvent.buttonsState = _keyboardButtonsState;
			keyEvent.timestamp = (DiscreteTime)Time.timeAsRational;
			keyEvent.eventSource = EventSource.Keyboard;
			keyEvent.playerId = 0u;
			keyEvent.eventModifiers = _eventModifiers;
			Event ev = Event.From(keyEvent);
			EventProvider.Dispatch(ref ev);
			return true;
		}
		return false;
	}
}
