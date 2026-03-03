using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class AssetImportAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_package_name;

	private static readonly IntPtr NativeFieldInfoPtr_package_import_choice;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateAssetImportAnalytic_Public_Static_AssetImportAnalytic_0;

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

	public unsafe int package_import_choice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_import_choice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_import_choice)) = value;
		}
	}

	static AssetImportAnalytic()
	{
		Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "AssetImportAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_package_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr, "package_name");
		NativeFieldInfoPtr_package_import_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr, "package_import_choice");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_CreateAssetImportAnalytic_Public_Static_AssetImportAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr, 100663351);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407900, XrefRangeEnd = 1407905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetImportAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetImportAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407905, XrefRangeEnd = 1407913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetImportAnalytic CreateAssetImportAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAssetImportAnalytic_Public_Static_AssetImportAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AssetImportAnalytic>(intPtr2) : null;
	}

	public AssetImportAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
