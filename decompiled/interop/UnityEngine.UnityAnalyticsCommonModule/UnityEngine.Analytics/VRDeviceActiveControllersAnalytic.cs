using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase
{
	private static readonly IntPtr NativeFieldInfoPtr_vr_active_controllers;

	private static readonly IntPtr NativeMethodInfoPtr_CreateVRDeviceActiveControllersAnalytic_Internal_Static_VRDeviceActiveControllersAnalytic_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStringArray vr_active_controllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_active_controllers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_active_controllers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static VRDeviceActiveControllersAnalytic()
	{
		Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "VRDeviceActiveControllersAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_vr_active_controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr, "vr_active_controllers");
		NativeMethodInfoPtr_CreateVRDeviceActiveControllersAnalytic_Internal_Static_VRDeviceActiveControllersAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr, 100663312);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407655, XrefRangeEnd = 1407663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVRDeviceActiveControllersAnalytic_Internal_Static_VRDeviceActiveControllersAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VRDeviceActiveControllersAnalytic>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VRDeviceActiveControllersAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRDeviceActiveControllersAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VRDeviceActiveControllersAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
