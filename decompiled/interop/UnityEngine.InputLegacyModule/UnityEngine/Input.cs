using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

public class Input : Il2CppSystem.Object
{
	private delegate bool GetKeyUpIntDelegate(KeyCode key);

	private delegate void ResetInputAxesDelegate();

	private delegate System.IntPtr GetJoystickNamesDelegate();

	private delegate void ResetPenEventsDelegate();

	private delegate bool get_simulateMouseWithTouchesDelegate();

	private delegate void set_simulateMouseWithTouchesDelegate(bool value);

	private delegate bool get_imeIsSelectedDelegate();

	private delegate bool get_eatKeyPressOnTextFieldFocusDelegate();

	private delegate void set_eatKeyPressOnTextFieldFocusDelegate(bool value);

	private delegate int get_penEventCountDelegate();

	private delegate bool get_touchPressureSupportedDelegate();

	private delegate bool get_stylusTouchSupportedDelegate();

	private delegate bool get_multiTouchEnabledDelegate();

	private delegate bool get_isGyroAvailableDelegate();

	private delegate DeviceOrientation get_deviceOrientationDelegate();

	private delegate bool get_compensateSensorsDelegate();

	private delegate void set_compensateSensorsDelegate(bool value);

	private delegate int get_accelerationEventCountDelegate();

	private delegate bool get_backButtonLeavesAppDelegate();

	private delegate void set_backButtonLeavesAppDelegate(bool value);

	private delegate int GetGyroInternalDelegate();

	private delegate void GetPenEvent_InjectedDelegate(int index, [Out] System.IntPtr ret);

	private delegate void SimulateTouchInternal_InjectedDelegate([In] System.IntPtr touch, long timestamp);

	private delegate void get_inputString_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_mousePositionDelta_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_acceleration_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr__simulateTouchEnabled_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_simulateTouchEnabled_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMousePresentInternal_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchSupportedInternal_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

	private static readonly GetKeyUpIntDelegate GetKeyUpIntDelegateField;

	private static readonly ResetInputAxesDelegate ResetInputAxesDelegateField;

	private static readonly GetJoystickNamesDelegate GetJoystickNamesDelegateField;

	private static readonly ResetPenEventsDelegate ResetPenEventsDelegateField;

	private static readonly get_simulateMouseWithTouchesDelegate get_simulateMouseWithTouchesDelegateField;

	private static readonly set_simulateMouseWithTouchesDelegate set_simulateMouseWithTouchesDelegateField;

	private static readonly get_imeIsSelectedDelegate get_imeIsSelectedDelegateField;

	private static readonly get_eatKeyPressOnTextFieldFocusDelegate get_eatKeyPressOnTextFieldFocusDelegateField;

	private static readonly set_eatKeyPressOnTextFieldFocusDelegate set_eatKeyPressOnTextFieldFocusDelegateField;

	private static readonly get_penEventCountDelegate get_penEventCountDelegateField;

	private static readonly get_touchPressureSupportedDelegate get_touchPressureSupportedDelegateField;

	private static readonly get_stylusTouchSupportedDelegate get_stylusTouchSupportedDelegateField;

	private static readonly get_multiTouchEnabledDelegate get_multiTouchEnabledDelegateField;

	private static readonly get_isGyroAvailableDelegate get_isGyroAvailableDelegateField;

	private static readonly get_deviceOrientationDelegate get_deviceOrientationDelegateField;

	private static readonly get_compensateSensorsDelegate get_compensateSensorsDelegateField;

	private static readonly set_compensateSensorsDelegate set_compensateSensorsDelegateField;

	private static readonly get_accelerationEventCountDelegate get_accelerationEventCountDelegateField;

	private static readonly get_backButtonLeavesAppDelegate get_backButtonLeavesAppDelegateField;

	private static readonly set_backButtonLeavesAppDelegate set_backButtonLeavesAppDelegateField;

	private static readonly GetGyroInternalDelegate GetGyroInternalDelegateField;

	private static readonly GetPenEvent_InjectedDelegate GetPenEvent_InjectedDelegateField;

	private static readonly SimulateTouchInternal_InjectedDelegate SimulateTouchInternal_InjectedDelegateField;

	private static readonly get_inputString_InjectedDelegate get_inputString_InjectedDelegateField;

	private static readonly get_mousePositionDelta_InjectedDelegate get_mousePositionDelta_InjectedDelegateField;

	private static readonly get_acceleration_InjectedDelegate get_acceleration_InjectedDelegateField;

	public unsafe static bool _simulateTouchEnabled_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__simulateTouchEnabled_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__simulateTouchEnabled_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool anyKey
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252683, RefRangeEnd = 1252684, XrefRangeStart = 1252681, XrefRangeEnd = 1252683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool anyKeyDown
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252686, RefRangeEnd = 1252687, XrefRangeStart = 1252684, XrefRangeEnd = 1252686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector3 mousePosition
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1252689, RefRangeEnd = 1252703, XrefRangeStart = 1252687, XrefRangeEnd = 1252689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector2 mouseScrollDelta
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1252705, RefRangeEnd = 1252711, XrefRangeStart = 1252703, XrefRangeEnd = 1252705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static IMECompositionMode imeCompositionMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252713, RefRangeEnd = 1252714, XrefRangeStart = 1252711, XrefRangeEnd = 1252713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(IMECompositionMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252716, RefRangeEnd = 1252717, XrefRangeStart = 1252714, XrefRangeEnd = 1252716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string compositionString
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1252722, RefRangeEnd = 1252726, XrefRangeStart = 1252717, XrefRangeEnd = 1252722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static Vector2 compositionCursorPos
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252728, RefRangeEnd = 1252729, XrefRangeStart = 1252726, XrefRangeEnd = 1252728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252731, RefRangeEnd = 1252732, XrefRangeStart = 1252729, XrefRangeEnd = 1252731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool simulateTouchEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252732, XrefRangeEnd = 1252734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_simulateTouchEnabled_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_simulateTouchEnabled_k__BackingField = value;
		}
	}

	public unsafe static bool mousePresent
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1252740, RefRangeEnd = 1252744, XrefRangeStart = 1252738, XrefRangeEnd = 1252740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool touchSupported
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1252746, RefRangeEnd = 1252756, XrefRangeStart = 1252744, XrefRangeEnd = 1252746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int touchCount
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1252758, RefRangeEnd = 1252768, XrefRangeStart = 1252756, XrefRangeEnd = 1252758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool multiTouchEnabled
	{
		get
		{
			return get_multiTouchEnabledDelegateField();
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252770, RefRangeEnd = 1252771, XrefRangeStart = 1252768, XrefRangeEnd = 1252770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Il2CppStructArray<Touch> touches
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1252778, RefRangeEnd = 1252782, XrefRangeStart = 1252771, XrefRangeEnd = 1252778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Touch>>(intPtr2) : null;
		}
	}

	public static bool simulateMouseWithTouches
	{
		get
		{
			return get_simulateMouseWithTouchesDelegateField();
		}
		set
		{
			set_simulateMouseWithTouchesDelegateField(value);
		}
	}

	public static string inputString
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_inputString_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static Vector3 mousePositionDelta
	{
		get
		{
			get_mousePositionDelta_Injected(out var ret);
			return ret;
		}
	}

	public static bool imeIsSelected => get_imeIsSelectedDelegateField();

	public static bool eatKeyPressOnTextFieldFocus
	{
		get
		{
			return get_eatKeyPressOnTextFieldFocusDelegateField();
		}
		set
		{
			set_eatKeyPressOnTextFieldFocusDelegateField(value);
		}
	}

	public static int penEventCount => get_penEventCountDelegateField();

	public static bool touchPressureSupported => get_touchPressureSupportedDelegateField();

	public static bool stylusTouchSupported => get_stylusTouchSupportedDelegateField();

	public static bool isGyroAvailable => get_isGyroAvailableDelegateField();

	public static DeviceOrientation deviceOrientation => get_deviceOrientationDelegateField();

	public static Vector3 acceleration
	{
		get
		{
			get_acceleration_Injected(out var ret);
			return ret;
		}
	}

	public static bool compensateSensors
	{
		get
		{
			return get_compensateSensorsDelegateField();
		}
		set
		{
			set_compensateSensorsDelegateField(value);
		}
	}

	public static int accelerationEventCount => get_accelerationEventCountDelegateField();

	public static bool backButtonLeavesApp
	{
		get
		{
			return get_backButtonLeavesAppDelegateField();
		}
		set
		{
			set_backButtonLeavesAppDelegateField(value);
		}
	}

	public static LocationService location
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static Compass compass
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static Gyroscope gyro
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static Input()
	{
		Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Input");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
		NativeFieldInfoPtr__simulateTouchEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Input>.NativeClassPtr, "<simulateTouchEnabled>k__BackingField");
		NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_get_anyKey_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_get_anyKeyDown_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_get_simulateTouchEnabled_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_GetMousePresentInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_GetTouchSupportedInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_set_multiTouchEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_get_touches_Public_Static_get_Il2CppStructArray_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663356);
		GetKeyUpIntDelegateField = IL2CPP.ResolveICall<GetKeyUpIntDelegate>("UnityEngine.Input::GetKeyUpInt");
		ResetInputAxesDelegateField = IL2CPP.ResolveICall<ResetInputAxesDelegate>("UnityEngine.Input::ResetInputAxes");
		GetJoystickNamesDelegateField = IL2CPP.ResolveICall<GetJoystickNamesDelegate>("UnityEngine.Input::GetJoystickNames");
		ResetPenEventsDelegateField = IL2CPP.ResolveICall<ResetPenEventsDelegate>("UnityEngine.Input::ResetPenEvents");
		get_simulateMouseWithTouchesDelegateField = IL2CPP.ResolveICall<get_simulateMouseWithTouchesDelegate>("UnityEngine.Input::get_simulateMouseWithTouches");
		set_simulateMouseWithTouchesDelegateField = IL2CPP.ResolveICall<set_simulateMouseWithTouchesDelegate>("UnityEngine.Input::set_simulateMouseWithTouches");
		get_imeIsSelectedDelegateField = IL2CPP.ResolveICall<get_imeIsSelectedDelegate>("UnityEngine.Input::get_imeIsSelected");
		get_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<get_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::get_eatKeyPressOnTextFieldFocus");
		set_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<set_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::set_eatKeyPressOnTextFieldFocus");
		get_penEventCountDelegateField = IL2CPP.ResolveICall<get_penEventCountDelegate>("UnityEngine.Input::get_penEventCount");
		get_touchPressureSupportedDelegateField = IL2CPP.ResolveICall<get_touchPressureSupportedDelegate>("UnityEngine.Input::get_touchPressureSupported");
		get_stylusTouchSupportedDelegateField = IL2CPP.ResolveICall<get_stylusTouchSupportedDelegate>("UnityEngine.Input::get_stylusTouchSupported");
		get_multiTouchEnabledDelegateField = IL2CPP.ResolveICall<get_multiTouchEnabledDelegate>("UnityEngine.Input::get_multiTouchEnabled");
		get_isGyroAvailableDelegateField = IL2CPP.ResolveICall<get_isGyroAvailableDelegate>("UnityEngine.Input::get_isGyroAvailable");
		get_deviceOrientationDelegateField = IL2CPP.ResolveICall<get_deviceOrientationDelegate>("UnityEngine.Input::get_deviceOrientation");
		get_compensateSensorsDelegateField = IL2CPP.ResolveICall<get_compensateSensorsDelegate>("UnityEngine.Input::get_compensateSensors");
		set_compensateSensorsDelegateField = IL2CPP.ResolveICall<set_compensateSensorsDelegate>("UnityEngine.Input::set_compensateSensors");
		get_accelerationEventCountDelegateField = IL2CPP.ResolveICall<get_accelerationEventCountDelegate>("UnityEngine.Input::get_accelerationEventCount");
		get_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<get_backButtonLeavesAppDelegate>("UnityEngine.Input::get_backButtonLeavesApp");
		set_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<set_backButtonLeavesAppDelegate>("UnityEngine.Input::set_backButtonLeavesApp");
		GetGyroInternalDelegateField = IL2CPP.ResolveICall<GetGyroInternalDelegate>("UnityEngine.Input::GetGyroInternal");
		GetPenEvent_InjectedDelegateField = IL2CPP.ResolveICall<GetPenEvent_InjectedDelegate>("UnityEngine.Input::GetPenEvent_Injected");
		SimulateTouchInternal_InjectedDelegateField = IL2CPP.ResolveICall<SimulateTouchInternal_InjectedDelegate>("UnityEngine.Input::SimulateTouchInternal_Injected");
		get_inputString_InjectedDelegateField = IL2CPP.ResolveICall<get_inputString_InjectedDelegate>("UnityEngine.Input::get_inputString_Injected");
		get_mousePositionDelta_InjectedDelegateField = IL2CPP.ResolveICall<get_mousePositionDelta_InjectedDelegate>("UnityEngine.Input::get_mousePositionDelta_Injected");
		get_acceleration_InjectedDelegateField = IL2CPP.ResolveICall<get_acceleration_InjectedDelegate>("UnityEngine.Input::get_acceleration_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252601, RefRangeEnd = 1252602, XrefRangeStart = 1252600, XrefRangeEnd = 1252601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxis(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1252603, RefRangeEnd = 1252606, XrefRangeStart = 1252602, XrefRangeEnd = 1252603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxisRaw(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1252607, RefRangeEnd = 1252609, XrefRangeStart = 1252606, XrefRangeEnd = 1252607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButton(string buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1252610, RefRangeEnd = 1252613, XrefRangeStart = 1252609, XrefRangeEnd = 1252610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonDown(string buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1252615, RefRangeEnd = 1252623, XrefRangeStart = 1252613, XrefRangeEnd = 1252615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyInt(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1252625, RefRangeEnd = 1252636, XrefRangeStart = 1252623, XrefRangeEnd = 1252625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyDownInt(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1252638, RefRangeEnd = 1252656, XrefRangeStart = 1252636, XrefRangeEnd = 1252638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButton(int button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1252658, RefRangeEnd = 1252662, XrefRangeStart = 1252656, XrefRangeEnd = 1252658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButtonDown(int button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1252664, RefRangeEnd = 1252668, XrefRangeStart = 1252662, XrefRangeEnd = 1252664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButtonUp(int button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1252670, RefRangeEnd = 1252674, XrefRangeStart = 1252668, XrefRangeEnd = 1252670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Touch GetTouch(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Touch*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1252676, RefRangeEnd = 1252678, XrefRangeStart = 1252674, XrefRangeEnd = 1252676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PenData GetLastPenContactEvent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastPenContactEvent_Public_Static_PenData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PenData*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1252680, RefRangeEnd = 1252681, XrefRangeStart = 1252678, XrefRangeEnd = 1252680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearLastPenContactEvent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLastPenContactEvent_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1252615, RefRangeEnd = 1252623, XrefRangeStart = 1252615, XrefRangeEnd = 1252623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKey(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1252625, RefRangeEnd = 1252636, XrefRangeStart = 1252625, XrefRangeEnd = 1252636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyDown(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252734, XrefRangeEnd = 1252736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMousePresentInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMousePresentInternal_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252736, XrefRangeEnd = 1252738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTouchSupportedInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchSupportedInternal_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252782, XrefRangeEnd = 1252784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckDisabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDisabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252784, XrefRangeEnd = 1252786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTouch_Injected(int index, out Touch ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252786, XrefRangeEnd = 1252788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLastPenContactEvent_Injected(out PenData ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastPenContactEvent_Injected_Private_Static_Void_byref_PenData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252788, XrefRangeEnd = 1252790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_mousePosition_Injected(out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252790, XrefRangeEnd = 1252792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_mouseScrollDelta_Injected(out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252792, XrefRangeEnd = 1252794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_compositionString_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252794, XrefRangeEnd = 1252796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_compositionCursorPos_Injected(out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252796, XrefRangeEnd = 1252798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_compositionCursorPos_Injected([In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Input(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool GetButtonUp(string buttonName)
	{
		return InputUnsafeUtility.GetButtonUp(buttonName);
	}

	public static bool GetKeyUpInt(KeyCode key)
	{
		return GetKeyUpIntDelegateField(key);
	}

	public static void ResetInputAxes()
	{
		ResetInputAxesDelegateField();
	}

	public static Il2CppStringArray GetJoystickNames()
	{
		System.IntPtr intPtr = GetJoystickNamesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static PenData GetPenEvent(int index)
	{
		GetPenEvent_Injected(index, out var ret);
		return ret;
	}

	public static void ResetPenEvents()
	{
		ResetPenEventsDelegateField();
	}

	public static bool GetKey(string name)
	{
		return InputUnsafeUtility.GetKeyString(name);
	}

	public static bool GetKeyUp(KeyCode key)
	{
		return GetKeyUpInt(key);
	}

	public static bool GetKeyUp(string name)
	{
		return InputUnsafeUtility.GetKeyUpString(name);
	}

	public static bool GetKeyDown(string name)
	{
		return InputUnsafeUtility.GetKeyDownString(name);
	}

	public static void SimulateTouch(Touch touch)
	{
	}

	public static void SimulateTouchInternal(Touch touch, long timestamp)
	{
		SimulateTouchInternal_Injected(ref touch, timestamp);
	}

	public static int GetGyroInternal()
	{
		return GetGyroInternalDelegateField();
	}

	public unsafe static void GetPenEvent_Injected(int index, out PenData ret)
	{
		GetPenEvent_InjectedDelegateField(index, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SimulateTouchInternal_Injected([In] ref Touch touch, long timestamp)
	{
		SimulateTouchInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref touch), timestamp);
	}

	public unsafe static void get_inputString_Injected(out ManagedSpanWrapper ret)
	{
		get_inputString_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_mousePositionDelta_Injected(out Vector3 ret)
	{
		get_mousePositionDelta_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_acceleration_Injected(out Vector3 ret)
	{
		get_acceleration_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
