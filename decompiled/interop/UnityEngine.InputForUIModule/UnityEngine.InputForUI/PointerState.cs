using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

[StructLayout(LayoutKind.Explicit)]
public struct PointerState
{
	private static readonly System.IntPtr NativeFieldInfoPtr__LastPressedButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__buttonsState;

	private static readonly System.IntPtr NativeFieldInfoPtr__NextPressTime_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ClickCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LastPosition_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LastDisplayIndex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LastPositionValid_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_kClickDelay;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastPressedButton_Public_get_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastPressedButton_Private_set_Void_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ButtonsState_Public_get_ButtonsState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NextPressTime_Public_get_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NextPressTime_Private_set_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClickCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClickCount_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastPosition_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastPosition_Private_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastDisplayIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastDisplayIndex_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastPositionValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastPositionValid_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonDown_Public_Void_DiscreteTime_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonUp_Public_Void_DiscreteTime_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonChange_Public_Void_DiscreteTime_Button_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMove_Public_Void_DiscreteTime_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	[FieldOffset(0)]
	public PointerEvent.Button _LastPressedButton_k__BackingField;

	[FieldOffset(4)]
	public PointerEvent.ButtonsState _buttonsState;

	[FieldOffset(8)]
	public DiscreteTime _NextPressTime_k__BackingField;

	[FieldOffset(16)]
	public int _ClickCount_k__BackingField;

	[FieldOffset(20)]
	public Vector2 _LastPosition_k__BackingField;

	[FieldOffset(28)]
	public int _LastDisplayIndex_k__BackingField;

	[FieldOffset(32)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _LastPositionValid_k__BackingField;

	public unsafe static DiscreteTime kClickDelay
	{
		get
		{
			Unsafe.SkipInit(out DiscreteTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kClickDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kClickDelay, (void*)(&value));
		}
	}

	public unsafe PointerEvent.Button LastPressedButton
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastPressedButton_Public_get_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PointerEvent.Button*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastPressedButton_Private_set_Void_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PointerEvent.ButtonsState ButtonsState
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ButtonsState_Public_get_ButtonsState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PointerEvent.ButtonsState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DiscreteTime NextPressTime
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NextPressTime_Public_get_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NextPressTime_Private_set_Void_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int ClickCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClickCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClickCount_Private_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 LastPosition
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastPosition_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1252394, RefRangeEnd = 1252396, XrefRangeStart = 1252394, XrefRangeEnd = 1252394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastPosition_Private_set_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int LastDisplayIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastDisplayIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastDisplayIndex_Private_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool LastPositionValid
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastPositionValid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastPositionValid_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static PointerState()
	{
		Il2CppClassPointerStore<PointerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "PointerState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerState>.NativeClassPtr);
		NativeFieldInfoPtr__LastPressedButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<LastPressedButton>k__BackingField");
		NativeFieldInfoPtr__buttonsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "_buttonsState");
		NativeFieldInfoPtr__NextPressTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<NextPressTime>k__BackingField");
		NativeFieldInfoPtr__ClickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<ClickCount>k__BackingField");
		NativeFieldInfoPtr__LastPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<LastPosition>k__BackingField");
		NativeFieldInfoPtr__LastDisplayIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<LastDisplayIndex>k__BackingField");
		NativeFieldInfoPtr__LastPositionValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "<LastPositionValid>k__BackingField");
		NativeFieldInfoPtr_kClickDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "kClickDelay");
		NativeMethodInfoPtr_get_LastPressedButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_set_LastPressedButton_Private_set_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_get_ButtonsState_Public_get_ButtonsState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_get_NextPressTime_Public_get_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_set_NextPressTime_Private_set_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_get_ClickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_set_ClickCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_get_LastPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_set_LastPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_get_LastDisplayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_set_LastDisplayIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_get_LastPositionValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_set_LastPositionValid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_OnButtonDown_Public_Void_DiscreteTime_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_OnButtonUp_Public_Void_DiscreteTime_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_OnButtonChange_Public_Void_DiscreteTime_Button_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_OnMove_Public_Void_DiscreteTime_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100663527);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1252414, RefRangeEnd = 1252417, XrefRangeStart = 1252396, XrefRangeEnd = 1252414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonDown(DiscreteTime currentTime, PointerEvent.Button button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(PointerEvent.Button**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &button;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonDown_Public_Void_DiscreteTime_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1252422, RefRangeEnd = 1252425, XrefRangeStart = 1252417, XrefRangeEnd = 1252422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonUp(DiscreteTime currentTime, PointerEvent.Button button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentTime);
		*(PointerEvent.Button**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &button;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonUp_Public_Void_DiscreteTime_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1252433, RefRangeEnd = 1252435, XrefRangeStart = 1252425, XrefRangeEnd = 1252433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonChange(DiscreteTime currentTime, PointerEvent.Button button, bool previousState, bool newState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&currentTime);
		*(PointerEvent.Button**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &button;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &previousState;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonChange_Public_Void_DiscreteTime_Button_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1252438, RefRangeEnd = 1252440, XrefRangeStart = 1252435, XrefRangeEnd = 1252438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&currentTime);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &displayIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMove_Public_Void_DiscreteTime_Vector2_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1252449, RefRangeEnd = 1252458, XrefRangeStart = 1252440, XrefRangeEnd = 1252449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointerState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
