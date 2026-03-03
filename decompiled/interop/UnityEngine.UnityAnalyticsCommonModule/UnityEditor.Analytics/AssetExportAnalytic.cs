using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class AssetExportAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_package_name;

	private static readonly IntPtr NativeFieldInfoPtr_error_message;

	private static readonly IntPtr NativeFieldInfoPtr_items_count;

	private static readonly IntPtr NativeFieldInfoPtr_asset_extensions;

	private static readonly IntPtr NativeFieldInfoPtr_include_upm_dependencies;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateAssetExportAnalytic_Public_Static_AssetExportAnalytic_0;

	public unsafe string package_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string error_message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_message);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_message)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int items_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items_count)) = value;
		}
	}

	public unsafe Il2CppStringArray asset_extensions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asset_extensions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asset_extensions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool include_upm_dependencies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_include_upm_dependencies);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_include_upm_dependencies)) = value;
		}
	}

	static AssetExportAnalytic()
	{
		Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "AssetExportAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_package_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, "package_name");
		NativeFieldInfoPtr_error_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, "error_message");
		NativeFieldInfoPtr_items_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, "items_count");
		NativeFieldInfoPtr_asset_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, "asset_extensions");
		NativeFieldInfoPtr_include_upm_dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, "include_upm_dependencies");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_CreateAssetExportAnalytic_Public_Static_AssetExportAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr, 100663353);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407913, XrefRangeEnd = 1407918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetExportAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetExportAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407918, XrefRangeEnd = 1407926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetExportAnalytic CreateAssetExportAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAssetExportAnalytic_Public_Static_AssetExportAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AssetExportAnalytic>(intPtr2) : null;
	}

	public AssetExportAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
