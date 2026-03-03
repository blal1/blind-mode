using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class VRDeviceAnalyticAspect : VRDeviceAnalyticBase
{
	private static readonly IntPtr NativeFieldInfoPtr_vr_aspect_ratio;

	private static readonly IntPtr NativeMethodInfoPtr_CreateVRDeviceAnalyticAspect_Internal_Static_VRDeviceAnalyticAspect_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float vr_aspect_ratio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_aspect_ratio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_aspect_ratio)) = value;
		}
	}

	static VRDeviceAnalyticAspect()
	{
		Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "VRDeviceAnalyticAspect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr);
		NativeFieldInfoPtr_vr_aspect_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr, "vr_aspect_ratio");
		NativeMethodInfoPtr_CreateVRDeviceAnalyticAspect_Internal_Static_VRDeviceAnalyticAspect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr, 100663306);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407631, XrefRangeEnd = 1407639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVRDeviceAnalyticAspect_Internal_Static_VRDeviceAnalyticAspect_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VRDeviceAnalyticAspect>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VRDeviceAnalyticAspect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRDeviceAnalyticAspect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VRDeviceAnalyticAspect(IntPtr pointer)
		: base(pointer)
	{
	}
}
