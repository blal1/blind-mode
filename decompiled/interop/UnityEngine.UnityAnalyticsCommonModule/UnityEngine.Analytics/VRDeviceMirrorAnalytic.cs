using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class VRDeviceMirrorAnalytic : VRDeviceAnalyticBase
{
	private static readonly IntPtr NativeFieldInfoPtr_vr_device_mirror_mode;

	private static readonly IntPtr NativeMethodInfoPtr_CreateVRDeviceMirrorAnalytic_Internal_Static_VRDeviceMirrorAnalytic_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool vr_device_mirror_mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_device_mirror_mode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_device_mirror_mode)) = value;
		}
	}

	static VRDeviceMirrorAnalytic()
	{
		Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "VRDeviceMirrorAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_vr_device_mirror_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr, "vr_device_mirror_mode");
		NativeMethodInfoPtr_CreateVRDeviceMirrorAnalytic_Internal_Static_VRDeviceMirrorAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr, 100663308);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407639, XrefRangeEnd = 1407647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVRDeviceMirrorAnalytic_Internal_Static_VRDeviceMirrorAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VRDeviceMirrorAnalytic>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VRDeviceMirrorAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRDeviceMirrorAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VRDeviceMirrorAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
