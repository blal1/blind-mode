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
public class AssetImportStatusAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_package_name;

	private static readonly IntPtr NativeFieldInfoPtr_package_items_count;

	private static readonly IntPtr NativeFieldInfoPtr_package_import_status;

	private static readonly IntPtr NativeFieldInfoPtr_error_message;

	private static readonly IntPtr NativeFieldInfoPtr_project_assets_count;

	private static readonly IntPtr NativeFieldInfoPtr_unselected_assets_count;

	private static readonly IntPtr NativeFieldInfoPtr_selected_new_assets_count;

	private static readonly IntPtr NativeFieldInfoPtr_selected_changed_assets_count;

	private static readonly IntPtr NativeFieldInfoPtr_unchanged_assets_count;

	private static readonly IntPtr NativeFieldInfoPtr_selected_asset_extensions;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateAssetImportStatusAnalytic_Public_Static_AssetImportStatusAnalytic_0;

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

	public unsafe int package_items_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_items_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_items_count)) = value;
		}
	}

	public unsafe int package_import_status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_import_status);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_import_status)) = value;
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

	public unsafe int project_assets_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_project_assets_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_project_assets_count)) = value;
		}
	}

	public unsafe int unselected_assets_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unselected_assets_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unselected_assets_count)) = value;
		}
	}

	public unsafe int selected_new_assets_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_new_assets_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_new_assets_count)) = value;
		}
	}

	public unsafe int selected_changed_assets_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_changed_assets_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_changed_assets_count)) = value;
		}
	}

	public unsafe int unchanged_assets_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unchanged_assets_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unchanged_assets_count)) = value;
		}
	}

	public unsafe Il2CppStringArray selected_asset_extensions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_asset_extensions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected_asset_extensions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AssetImportStatusAnalytic()
	{
		Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "AssetImportStatusAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_package_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "package_name");
		NativeFieldInfoPtr_package_items_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "package_items_count");
		NativeFieldInfoPtr_package_import_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "package_import_status");
		NativeFieldInfoPtr_error_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "error_message");
		NativeFieldInfoPtr_project_assets_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "project_assets_count");
		NativeFieldInfoPtr_unselected_assets_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "unselected_assets_count");
		NativeFieldInfoPtr_selected_new_assets_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "selected_new_assets_count");
		NativeFieldInfoPtr_selected_changed_assets_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "selected_changed_assets_count");
		NativeFieldInfoPtr_unchanged_assets_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "unchanged_assets_count");
		NativeFieldInfoPtr_selected_asset_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, "selected_asset_extensions");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_CreateAssetImportStatusAnalytic_Public_Static_AssetImportStatusAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr, 100663349);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407887, XrefRangeEnd = 1407892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetImportStatusAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetImportStatusAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407892, XrefRangeEnd = 1407900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAssetImportStatusAnalytic_Public_Static_AssetImportStatusAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AssetImportStatusAnalytic>(intPtr2) : null;
	}

	public AssetImportStatusAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
