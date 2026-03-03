using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

[StructLayout(LayoutKind.Explicit)]
public struct PointerEvent
{
	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Type")]
	public enum Type
	{
		PointerMoved = 1,
		Scroll,
		ButtonPressed,
		ButtonReleased,
		State,
		TouchCanceled
	}

	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Button")]
	[System.Flags]
	public enum Button : uint
	{
		None = 0u,
		Primary = 1u,
		FingerInTouch = 1u,
		PenTipInTouch = 1u,
		PenEraserInTouch = 2u,
		PenBarrelButton = 4u,
		MouseLeft = 1u,
		MouseRight = 2u,
		MouseMiddle = 4u,
		MouseForward = 8u,
		MouseBack = 0x10u
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ButtonsState
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__state;

		private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Boolean_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		[FieldOffset(0)]
		public uint _state;

		static ButtonsState()
		{
			Il2CppClassPointerStore<ButtonsState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "ButtonsState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr);
			NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, "_state");
			NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, 100663395);
			NativeMethodInfoPtr_Get_Public_Boolean_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, 100663396);
			NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, 100663397);
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, 100663398);
		}

		[CallerCount(0)]
		public unsafe void Set(Button button, bool pressed)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&button);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressed;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool Get(Button button)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Boolean_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 713915, RefRangeEnd = 713916, XrefRangeStart = 713915, XrefRangeEnd = 713916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251201, XrefRangeEnd = 1251206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ButtonsState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_scroll;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilt;

	private static readonly System.IntPtr NativeFieldInfoPtr_twist;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInverted;

	private static readonly System.IntPtr NativeFieldInfoPtr_button;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonsState;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__timestamp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventSource_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventModifiers_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPrimaryPointer_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_azimuth_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_altitude_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timestamp_Public_Virtual_Final_New_get_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ButtonFromButtonIndex_Internal_Static_Button_Int32_0;

	[FieldOffset(0)]
	public Type type;

	[FieldOffset(4)]
	public int pointerIndex;

	[FieldOffset(8)]
	public Vector2 position;

	[FieldOffset(16)]
	public Vector2 deltaPosition;

	[FieldOffset(24)]
	public Vector2 scroll;

	[FieldOffset(32)]
	public int displayIndex;

	[FieldOffset(36)]
	public Vector2 tilt;

	[FieldOffset(44)]
	public float twist;

	[FieldOffset(48)]
	public float pressure;

	[FieldOffset(52)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isInverted;

	[FieldOffset(56)]
	public Button button;

	[FieldOffset(60)]
	public ButtonsState buttonsState;

	[FieldOffset(64)]
	public int clickCount;

	[FieldOffset(72)]
	public DiscreteTime _timestamp_k__BackingField;

	[FieldOffset(80)]
	public EventSource _eventSource_k__BackingField;

	[FieldOffset(84)]
	public uint _playerId_k__BackingField;

	[FieldOffset(88)]
	public EventModifiers _eventModifiers_k__BackingField;

	public unsafe bool isPrimaryPointer
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1019790, RefRangeEnd = 1019796, XrefRangeStart = 1019790, XrefRangeEnd = 1019796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPrimaryPointer_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float azimuth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251213, RefRangeEnd = 1251215, XrefRangeStart = 1251206, XrefRangeEnd = 1251213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_azimuth_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float altitude
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251218, RefRangeEnd = 1251219, XrefRangeStart = 1251215, XrefRangeEnd = 1251218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_altitude_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual DiscreteTime timestamp
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timestamp_Public_Virtual_Final_New_get_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventSource eventSource
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180373, RefRangeEnd = 180378, XrefRangeStart = 180373, XrefRangeEnd = 180378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint playerId
	{
		get
		{
			return _playerId_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventModifiers eventModifiers
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41565, RefRangeEnd = 41568, XrefRangeStart = 41565, XrefRangeEnd = 41568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293993, RefRangeEnd = 293998, XrefRangeStart = 293993, XrefRangeEnd = 293998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool isPressed => buttonsState.Get((!isInverted) ? Button.Primary : Button.PenEraserInTouch);

	static PointerEvent()
	{
		Il2CppClassPointerStore<PointerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "PointerEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "type");
		NativeFieldInfoPtr_pointerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "pointerIndex");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "position");
		NativeFieldInfoPtr_deltaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "deltaPosition");
		NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "scroll");
		NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "displayIndex");
		NativeFieldInfoPtr_tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "tilt");
		NativeFieldInfoPtr_twist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "twist");
		NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "pressure");
		NativeFieldInfoPtr_isInverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "isInverted");
		NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "button");
		NativeFieldInfoPtr_buttonsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "buttonsState");
		NativeFieldInfoPtr_clickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "clickCount");
		NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "<timestamp>k__BackingField");
		NativeFieldInfoPtr__eventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "<eventSource>k__BackingField");
		NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "<playerId>k__BackingField");
		NativeFieldInfoPtr__eventModifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, "<eventModifiers>k__BackingField");
		NativeMethodInfoPtr_get_isPrimaryPointer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_get_azimuth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_get_altitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_get_timestamp_Public_Virtual_Final_New_get_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_ButtonFromButtonIndex_Internal_Static_Button_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, 100663394);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251384, RefRangeEnd = 1251385, XrefRangeStart = 1251219, XrefRangeEnd = 1251384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Button ButtonFromButtonIndex(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ButtonFromButtonIndex_Internal_Static_Button_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Button*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointerEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
