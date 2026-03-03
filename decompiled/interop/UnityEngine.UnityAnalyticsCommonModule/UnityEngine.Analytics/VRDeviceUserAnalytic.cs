using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class VRDeviceUserAnalytic : VRDeviceAnalyticBase
{
	private static readonly IntPtr NativeFieldInfoPtr_vr_user_presence;

	private static readonly IntPtr NativeMethodInfoPtr_CreateVRDeviceUserAnalytic_Internal_Static_VRDeviceUserAnalytic_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int vr_user_presence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_user_presence);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vr_user_presence)) = value;
		}
	}

	static VRDeviceUserAnalytic()
	{
		Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEngine.Analytics", "VRDeviceUserAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_vr_user_presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr, "vr_user_presence");
		NativeMethodInfoPtr_CreateVRDeviceUserAnalytic_Internal_Static_VRDeviceUserAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr, 100663310);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407647, XrefRangeEnd = 1407655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVRDeviceUserAnalytic_Internal_Static_VRDeviceUserAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VRDeviceUserAnalytic>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VRDeviceUserAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRDeviceUserAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VRDeviceUserAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
