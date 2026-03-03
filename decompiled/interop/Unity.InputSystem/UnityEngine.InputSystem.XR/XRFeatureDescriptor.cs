using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.InputSystem.XR;

[System.Serializable]
public sealed class XRFeatureDescriptor : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_usageHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_featureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_customSize;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe List<UsageHint> usageHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageHints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UsageHint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageHints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FeatureType featureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureType);
			return *(FeatureType*)num;
		}
		set
		{
			*(FeatureType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureType)) = value;
		}
	}

	public unsafe uint customSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSize);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customSize)) = value;
		}
	}

	static XRFeatureDescriptor()
	{
		Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "XRFeatureDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr, "name");
		NativeFieldInfoPtr_usageHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr, "usageHints");
		NativeFieldInfoPtr_featureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr, "featureType");
		NativeFieldInfoPtr_customSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr, "customSize");
	}

	public XRFeatureDescriptor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public XRFeatureDescriptor()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRFeatureDescriptor>.NativeClassPtr))
	{
	}
}
