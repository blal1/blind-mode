using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerRemovePackageAnalytic : PackageManagerBaseAnalytic
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreatePackageManagerRemovePackageAnalytic_Internal_Static_PackageManagerRemovePackageAnalytic_0;

	static PackageManagerRemovePackageAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerRemovePackageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerRemovePackageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerRemovePackageAnalytic>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerRemovePackageAnalytic>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_CreatePackageManagerRemovePackageAnalytic_Internal_Static_PackageManagerRemovePackageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerRemovePackageAnalytic>.NativeClassPtr, 100663337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407809, XrefRangeEnd = 1407814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerRemovePackageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerRemovePackageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407814, XrefRangeEnd = 1407822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePackageManagerRemovePackageAnalytic_Internal_Static_PackageManagerRemovePackageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PackageManagerRemovePackageAnalytic>(intPtr2) : null;
	}

	public PackageManagerRemovePackageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
