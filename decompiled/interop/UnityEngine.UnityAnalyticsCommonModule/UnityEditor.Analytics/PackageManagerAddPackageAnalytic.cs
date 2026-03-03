using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerAddPackageAnalytic : PackageManagerBaseAnalytic
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreatePackageManagerAddPackageAnalytic_Internal_Static_PackageManagerAddPackageAnalytic_0;

	static PackageManagerAddPackageAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerAddPackageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerAddPackageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerAddPackageAnalytic>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerAddPackageAnalytic>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_CreatePackageManagerAddPackageAnalytic_Internal_Static_PackageManagerAddPackageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerAddPackageAnalytic>.NativeClassPtr, 100663333);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407783, XrefRangeEnd = 1407788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerAddPackageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerAddPackageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407788, XrefRangeEnd = 1407796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePackageManagerAddPackageAnalytic_Internal_Static_PackageManagerAddPackageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PackageManagerAddPackageAnalytic>(intPtr2) : null;
	}

	public PackageManagerAddPackageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
