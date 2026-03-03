using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct TouchState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_touchId;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_phaseId;

	private static readonly System.IntPtr NativeFieldInfoPtr_tapCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateStepCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startPosition;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_phase_Public_set_Void_TouchPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isNoneEndedOrCanceled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isInProgress_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPrimaryTouch_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isPrimaryTouch_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOrphanedPrimaryTouch_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isOrphanedPrimaryTouch_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isIndirectTouch_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isIndirectTouch_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTap_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTap_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTapPress_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTapPress_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTapRelease_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTapRelease_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_beganInSameFrame_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_beganInSameFrame_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public int touchId;

	[FieldOffset(4)]
	public Vector2 position;

	[FieldOffset(12)]
	public Vector2 delta;

	[FieldOffset(20)]
	public float pressure;

	[FieldOffset(24)]
	public Vector2 radius;

	[FieldOffset(32)]
	public byte phaseId;

	[FieldOffset(33)]
	public byte tapCount;

	[FieldOffset(34)]
	public byte displayIndex;

	[FieldOffset(35)]
	public byte flags;

	[FieldOffset(36)]
	public uint updateStepCount;

	[FieldOffset(40)]
	public double startTime;

	[FieldOffset(48)]
	public Vector2 startPosition;

	public unsafe static int kSizeInBytes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&value));
		}
	}

	public unsafe static FourCC Format
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1008058, RefRangeEnd = 1008064, XrefRangeStart = 1008057, XrefRangeEnd = 1008058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TouchPhase phase
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TouchPhase*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_phase_Public_set_Void_TouchPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isNoneEndedOrCanceled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008064, RefRangeEnd = 1008065, XrefRangeStart = 1008064, XrefRangeEnd = 1008064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isNoneEndedOrCanceled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isInProgress
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008065, RefRangeEnd = 1008066, XrefRangeStart = 1008065, XrefRangeEnd = 1008065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isInProgress_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPrimaryTouch
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPrimaryTouch_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isPrimaryTouch_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isOrphanedPrimaryTouch
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOrphanedPrimaryTouch_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isOrphanedPrimaryTouch_Internal_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isIndirectTouch
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isIndirectTouch_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isIndirectTouch_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isTap
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTap_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1008066, RefRangeEnd = 1008069, XrefRangeStart = 1008066, XrefRangeEnd = 1008066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTap_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isTapPress
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTapPress_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1008066, RefRangeEnd = 1008069, XrefRangeStart = 1008066, XrefRangeEnd = 1008069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTapPress_Internal_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isTapRelease
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTapRelease_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008069, RefRangeEnd = 1008073, XrefRangeStart = 1008069, XrefRangeEnd = 1008069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTapRelease_Internal_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool beganInSameFrame
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_beganInSameFrame_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_beganInSameFrame_Internal_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008074, RefRangeEnd = 1008075, XrefRangeStart = 1008073, XrefRangeEnd = 1008074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TouchState()
	{
		Il2CppClassPointerStore<TouchState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "TouchState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchState>.NativeClassPtr);
		NativeFieldInfoPtr_kSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "kSizeInBytes");
		NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "touchId");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "position");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "pressure");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_phaseId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "phaseId");
		NativeFieldInfoPtr_tapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "tapCount");
		NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "displayIndex");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_updateStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "updateStepCount");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchState>.NativeClassPtr, "startPosition");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667416);
		NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667417);
		NativeMethodInfoPtr_set_phase_Public_set_Void_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667418);
		NativeMethodInfoPtr_get_isNoneEndedOrCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667419);
		NativeMethodInfoPtr_get_isInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667420);
		NativeMethodInfoPtr_get_isPrimaryTouch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667421);
		NativeMethodInfoPtr_set_isPrimaryTouch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667422);
		NativeMethodInfoPtr_get_isOrphanedPrimaryTouch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667423);
		NativeMethodInfoPtr_set_isOrphanedPrimaryTouch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667424);
		NativeMethodInfoPtr_get_isIndirectTouch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667425);
		NativeMethodInfoPtr_set_isIndirectTouch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667426);
		NativeMethodInfoPtr_get_isTap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667427);
		NativeMethodInfoPtr_set_isTap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr_get_isTapPress_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_set_isTapPress_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_get_isTapRelease_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr_set_isTapRelease_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667432);
		NativeMethodInfoPtr_get_beganInSameFrame_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667433);
		NativeMethodInfoPtr_set_beganInSameFrame_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667434);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667435);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchState>.NativeClassPtr, 100667436);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008075, XrefRangeEnd = 1008111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
