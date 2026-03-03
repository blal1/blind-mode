using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic
{
	private static readonly IntPtr NativeFieldInfoPtr_packages;

	private static readonly IntPtr NativeFieldInfoPtr_package_registries;

	private static readonly IntPtr NativeFieldInfoPtr_package_signatures;

	private static readonly IntPtr NativeFieldInfoPtr_package_sources;

	private static readonly IntPtr NativeFieldInfoPtr_package_types;

	private static readonly IntPtr NativeFieldInfoPtr_package_compliance_statuses;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreatePackageManagerResolvePackageAnalytic_Internal_Static_PackageManagerResolvePackageAnalytic_0;

	public unsafe Il2CppStringArray packages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packages);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray package_registries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_registries);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_registries)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray package_signatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_signatures);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_signatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray package_sources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_sources);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_sources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray package_types
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_types);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_types)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray package_compliance_statuses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_compliance_statuses);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_package_compliance_statuses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PackageManagerResolvePackageAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerResolvePackageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_packages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "packages");
		NativeFieldInfoPtr_package_registries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "package_registries");
		NativeFieldInfoPtr_package_signatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "package_signatures");
		NativeFieldInfoPtr_package_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "package_sources");
		NativeFieldInfoPtr_package_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "package_types");
		NativeFieldInfoPtr_package_compliance_statuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, "package_compliance_statuses");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_CreatePackageManagerResolvePackageAnalytic_Internal_Static_PackageManagerResolvePackageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr, 100663339);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407822, XrefRangeEnd = 1407827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerResolvePackageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerResolvePackageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407827, XrefRangeEnd = 1407835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePackageManagerResolvePackageAnalytic_Internal_Static_PackageManagerResolvePackageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PackageManagerResolvePackageAnalytic>(intPtr2) : null;
	}

	public PackageManagerResolvePackageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
