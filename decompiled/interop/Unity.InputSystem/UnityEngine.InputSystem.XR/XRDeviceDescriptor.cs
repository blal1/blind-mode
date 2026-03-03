using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.XR;

namespace UnityEngine.InputSystem.XR;

[System.Serializable]
public class XRDeviceDescriptor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_deviceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_manufacturer;

	private static readonly System.IntPtr NativeFieldInfoPtr_serialNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_characteristics;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFeatures;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJson_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromJson_Public_Static_XRDeviceDescriptor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string deviceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string manufacturer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manufacturer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manufacturer)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string serialNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serialNumber);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serialNumber)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe InputDeviceCharacteristics characteristics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characteristics);
			return *(InputDeviceCharacteristics*)num;
		}
		set
		{
			*(InputDeviceCharacteristics*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characteristics)) = value;
		}
	}

	public unsafe int deviceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId)) = value;
		}
	}

	public unsafe List<XRFeatureDescriptor> inputFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<XRFeatureDescriptor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XRDeviceDescriptor()
	{
		Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "XRDeviceDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_deviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "deviceName");
		NativeFieldInfoPtr_manufacturer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "manufacturer");
		NativeFieldInfoPtr_serialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "serialNumber");
		NativeFieldInfoPtr_characteristics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "characteristics");
		NativeFieldInfoPtr_deviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "deviceId");
		NativeFieldInfoPtr_inputFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, "inputFeatures");
		NativeMethodInfoPtr_ToJson_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, 100666469);
		NativeMethodInfoPtr_FromJson_Public_Static_XRDeviceDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, 100666470);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr, 100666471);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToJson()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJson_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000093, XrefRangeEnd = 1000096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRDeviceDescriptor FromJson(string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromJson_Public_Static_XRDeviceDescriptor_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRDeviceDescriptor>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRDeviceDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDeviceDescriptor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRDeviceDescriptor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
