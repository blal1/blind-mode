using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Profiling;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class Touchscreen : Pointer
{
	private static readonly IntPtr NativeFieldInfoPtr__primaryTouch_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__touches_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_k_TouchscreenUpdateMarker;

	private static readonly IntPtr NativeFieldInfoPtr_k_TouchAllocateMarker;

	private static readonly IntPtr NativeFieldInfoPtr__current_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_s_TapTime;

	private static readonly IntPtr NativeFieldInfoPtr_s_TapDelayTime;

	private static readonly IntPtr NativeFieldInfoPtr_s_TapRadiusSquared;

	private static readonly IntPtr NativeMethodInfoPtr_get_primaryTouch_Public_get_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_primaryTouch_Protected_set_Void_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_touches_Public_get_ReadOnlyArray_1_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_touches_Protected_set_Void_ReadOnlyArray_1_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_touchControlArray_Protected_get_Il2CppReferenceArray_1_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_touchControlArray_Protected_set_Void_Il2CppReferenceArray_1_TouchControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Touchscreen_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_current_Internal_Static_set_Void_Touchscreen_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_GetStateOffsetForEvent_Private_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_ICustomDeviceReset_Reset_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_TriggerTap_Private_Static_Void_TouchControl_byref_TouchState_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TouchControl _primaryTouch_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryTouch_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TouchControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryTouch_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReadOnlyArray<TouchControl> _touches_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touches_k__BackingField);
			return new ReadOnlyArray<TouchControl>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlyArray<TouchControl>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touches_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlyArray<TouchControl>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static ProfilerMarker k_TouchscreenUpdateMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TouchscreenUpdateMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TouchscreenUpdateMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_TouchAllocateMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TouchAllocateMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TouchAllocateMarker, (void*)(&value));
		}
	}

	public new unsafe static Touchscreen _current_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__current_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Touchscreen>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__current_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static float s_TapTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TapTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TapTime, (void*)(&value));
		}
	}

	public unsafe static float s_TapDelayTime
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TapDelayTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TapDelayTime, (void*)(&value));
		}
	}

	public unsafe static float s_TapRadiusSquared
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TapRadiusSquared, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TapRadiusSquared, (void*)(&value));
		}
	}

	public unsafe TouchControl primaryTouch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryTouch_Public_get_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TouchControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_primaryTouch_Protected_set_Void_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReadOnlyArray<TouchControl> touches
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touches_Public_get_ReadOnlyArray_1_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<TouchControl>(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993295, XrefRangeEnd = 993296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_touches_Protected_set_Void_ReadOnlyArray_1_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<TouchControl> touchControlArray
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 392554, RefRangeEnd = 392564, XrefRangeStart = 392554, XrefRangeEnd = 392564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchControlArray_Protected_get_Il2CppReferenceArray_1_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TouchControl>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 993300, RefRangeEnd = 993301, XrefRangeStart = 993296, XrefRangeEnd = 993300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_touchControlArray_Protected_set_Void_Il2CppReferenceArray_1_TouchControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public new unsafe static Touchscreen current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993301, XrefRangeEnd = 993305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Public_Static_get_Touchscreen_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Touchscreen>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993305, XrefRangeEnd = 993311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_current_Internal_Static_set_Void_Touchscreen_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Touchscreen()
	{
		Il2CppClassPointerStore<Touchscreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "Touchscreen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr);
		NativeFieldInfoPtr__primaryTouch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "<primaryTouch>k__BackingField");
		NativeFieldInfoPtr__touches_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "<touches>k__BackingField");
		NativeFieldInfoPtr_k_TouchscreenUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "k_TouchscreenUpdateMarker");
		NativeFieldInfoPtr_k_TouchAllocateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "k_TouchAllocateMarker");
		NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "<current>k__BackingField");
		NativeFieldInfoPtr_s_TapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "s_TapTime");
		NativeFieldInfoPtr_s_TapDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "s_TapDelayTime");
		NativeFieldInfoPtr_s_TapRadiusSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, "s_TapRadiusSquared");
		NativeMethodInfoPtr_get_primaryTouch_Public_get_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_set_primaryTouch_Protected_set_Void_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665902);
		NativeMethodInfoPtr_get_touches_Public_get_ReadOnlyArray_1_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665903);
		NativeMethodInfoPtr_set_touches_Protected_set_Void_ReadOnlyArray_1_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665904);
		NativeMethodInfoPtr_get_touchControlArray_Protected_get_Il2CppReferenceArray_1_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665905);
		NativeMethodInfoPtr_set_touchControlArray_Protected_set_Void_Il2CppReferenceArray_1_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665906);
		NativeMethodInfoPtr_get_current_Public_Static_get_Touchscreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665907);
		NativeMethodInfoPtr_set_current_Internal_Static_set_Void_Touchscreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665908);
		NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665909);
		NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665910);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665911);
		NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665912);
		NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665913);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665914);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665915);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_GetStateOffsetForEvent_Private_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665916);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_ICustomDeviceReset_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665917);
		NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665918);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665919);
		NativeMethodInfoPtr_TriggerTap_Private_Static_Void_TouchControl_byref_TouchState_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665920);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr, 100665921);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993311, XrefRangeEnd = 993321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void MakeCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993321, XrefRangeEnd = 993336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993336, XrefRangeEnd = 993385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 993419, RefRangeEnd = 993420, XrefRangeStart = 993385, XrefRangeEnd = 993419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 993445, RefRangeEnd = 993446, XrefRangeStart = 993420, XrefRangeEnd = 993445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993446, XrefRangeEnd = 993447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993447, XrefRangeEnd = 993457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993457, XrefRangeEnd = 993479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual bool UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_GetStateOffsetForEvent_Private_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993479, XrefRangeEnd = 993522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_InputSystem_LowLevel_ICustomDeviceReset_Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_ICustomDeviceReset_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993522, XrefRangeEnd = 993530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeForward_Internal_Static_Boolean_InputEventPtr_InputEventPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993530, XrefRangeEnd = 993541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993541, XrefRangeEnd = 993551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref state);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerTap_Private_Static_Void_TouchControl_byref_TouchState_InputEventPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 962989, RefRangeEnd = 963003, XrefRangeStart = 962989, XrefRangeEnd = 963003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Touchscreen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Touchscreen>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Touchscreen(IntPtr pointer)
		: base(pointer)
	{
	}
}
