using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class BuildAssetBundleAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_success;

	private static readonly IntPtr NativeFieldInfoPtr_error;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateBuildAssetBundleAnalytic_Internal_Static_BuildAssetBundleAnalytic_0;

	public unsafe bool success
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_success)) = value;
		}
	}

	public unsafe string error
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static BuildAssetBundleAnalytic()
	{
		Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "BuildAssetBundleAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr, "success");
		NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr, "error");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_CreateBuildAssetBundleAnalytic_Internal_Static_BuildAssetBundleAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr, 100663316);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407676, XrefRangeEnd = 1407681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuildAssetBundleAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildAssetBundleAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407681, XrefRangeEnd = 1407689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBuildAssetBundleAnalytic_Internal_Static_BuildAssetBundleAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BuildAssetBundleAnalytic>(intPtr2) : null;
	}

	public BuildAssetBundleAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
