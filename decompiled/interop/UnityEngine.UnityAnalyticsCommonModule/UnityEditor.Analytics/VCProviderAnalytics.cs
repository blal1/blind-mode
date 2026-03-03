using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class VCProviderAnalytics : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Mode;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateVCProviderAnalytics_Internal_Static_VCProviderAnalytics_0;

	public unsafe string Mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mode)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static VCProviderAnalytics()
	{
		Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "VCProviderAnalytics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr);
		NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr, "Mode");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_CreateVCProviderAnalytics_Internal_Static_VCProviderAnalytics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr, 100663361);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407965, XrefRangeEnd = 1407970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VCProviderAnalytics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VCProviderAnalytics>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407970, XrefRangeEnd = 1407978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VCProviderAnalytics CreateVCProviderAnalytics()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVCProviderAnalytics_Internal_Static_VCProviderAnalytics_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VCProviderAnalytics>(intPtr2) : null;
	}

	public VCProviderAnalytics(IntPtr pointer)
		: base(pointer)
	{
	}
}
