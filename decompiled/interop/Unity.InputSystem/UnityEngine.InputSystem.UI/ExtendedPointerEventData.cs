using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine.InputSystem.UI;

public class ExtendedPointerEventData : PointerEventData
{
	private static readonly IntPtr NativeFieldInfoPtr__control_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__device_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__touchId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__pointerType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__uiToolkitPointerId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__trackedDevicePosition_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__trackedDeviceOrientation_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_control_Public_get_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_control_Public_set_Void_InputControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_device_Public_get_InputDevice_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_touchId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_touchId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_get_UIPointerType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_pointerType_Public_set_Void_UIPointerType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_uiToolkitPointerId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_uiToolkitPointerId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_trackedDevicePosition_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_trackedDevicePosition_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_trackedDeviceOrientation_Public_get_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_trackedDeviceOrientation_Public_set_Void_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakePointerIdForTouch_Internal_Static_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_TouchIdFromPointerId_Internal_Static_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadDeviceState_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPenPointerId_Private_Static_Int32_Pen_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTouchPointerId_Private_Static_Int32_TouchControl_0;

	public unsafe InputControl _control_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__control_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__control_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputDevice _device_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _touchId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchId_k__BackingField)) = value;
		}
	}

	public unsafe UIPointerType _pointerType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerType_k__BackingField);
			return *(UIPointerType*)num;
		}
		set
		{
			*(UIPointerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerType_k__BackingField)) = value;
		}
	}

	public unsafe int _uiToolkitPointerId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiToolkitPointerId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiToolkitPointerId_k__BackingField)) = value;
		}
	}

	public unsafe Vector3 _trackedDevicePosition_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackedDevicePosition_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackedDevicePosition_k__BackingField)) = value;
		}
	}

	public unsafe Quaternion _trackedDeviceOrientation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackedDeviceOrientation_k__BackingField);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trackedDeviceOrientation_k__BackingField)) = value;
		}
	}

	public unsafe InputControl control
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_control_Public_get_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_control_Public_set_Void_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputDevice device
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_device_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int touchId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_touchId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe UIPointerType pointerType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerType_Public_get_UIPointerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UIPointerType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pointerType_Public_set_Void_UIPointerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int uiToolkitPointerId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiToolkitPointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uiToolkitPointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 trackedDevicePosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_trackedDevicePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_trackedDevicePosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion trackedDeviceOrientation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_trackedDeviceOrientation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_trackedDeviceOrientation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ExtendedPointerEventData()
	{
		Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "ExtendedPointerEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr);
		NativeFieldInfoPtr__control_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<control>k__BackingField");
		NativeFieldInfoPtr__device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<device>k__BackingField");
		NativeFieldInfoPtr__touchId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<touchId>k__BackingField");
		NativeFieldInfoPtr__pointerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<pointerType>k__BackingField");
		NativeFieldInfoPtr__uiToolkitPointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<uiToolkitPointerId>k__BackingField");
		NativeFieldInfoPtr__trackedDevicePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<trackedDevicePosition>k__BackingField");
		NativeFieldInfoPtr__trackedDeviceOrientation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, "<trackedDeviceOrientation>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_get_control_Public_get_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666687);
		NativeMethodInfoPtr_set_control_Public_set_Void_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666688);
		NativeMethodInfoPtr_get_device_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666689);
		NativeMethodInfoPtr_set_device_Public_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666690);
		NativeMethodInfoPtr_get_touchId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666691);
		NativeMethodInfoPtr_set_touchId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666692);
		NativeMethodInfoPtr_get_pointerType_Public_get_UIPointerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666693);
		NativeMethodInfoPtr_set_pointerType_Public_set_Void_UIPointerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666694);
		NativeMethodInfoPtr_get_uiToolkitPointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666695);
		NativeMethodInfoPtr_set_uiToolkitPointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666696);
		NativeMethodInfoPtr_get_trackedDevicePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666697);
		NativeMethodInfoPtr_set_trackedDevicePosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666698);
		NativeMethodInfoPtr_get_trackedDeviceOrientation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666699);
		NativeMethodInfoPtr_set_trackedDeviceOrientation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666700);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666701);
		NativeMethodInfoPtr_MakePointerIdForTouch_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666702);
		NativeMethodInfoPtr_TouchIdFromPointerId_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666703);
		NativeMethodInfoPtr_ReadDeviceState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666704);
		NativeMethodInfoPtr_GetPenPointerId_Private_Static_Int32_Pen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666705);
		NativeMethodInfoPtr_GetTouchPointerId_Private_Static_Int32_TouchControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr, 100666706);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002048, XrefRangeEnd = 1002049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExtendedPointerEventData(EventSystem eventSystem)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedPointerEventData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventSystem);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002049, XrefRangeEnd = 1002134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int MakePointerIdForTouch(int deviceId, int touchId)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&deviceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &touchId;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePointerIdForTouch_Internal_Static_Int32_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TouchIdFromPointerId(int pointerId)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pointerId);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TouchIdFromPointerId_Internal_Static_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002152, RefRangeEnd = 1002153, XrefRangeStart = 1002134, XrefRangeEnd = 1002152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadDeviceState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDeviceState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1002176, RefRangeEnd = 1002177, XrefRangeStart = 1002153, XrefRangeEnd = 1002176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPenPointerId(Pen pen)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pen);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPenPointerId_Private_Static_Int32_Pen_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002177, XrefRangeEnd = 1002186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTouchPointerId(TouchControl touchControl)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchControl);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchPointerId_Private_Static_Int32_TouchControl_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ExtendedPointerEventData(IntPtr pointer)
		: base(pointer)
	{
	}
}
