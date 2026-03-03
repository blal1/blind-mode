using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerResetPackageAnalytic : PackageManagerBaseAnalytic
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreatePackageManagerResetPackageAnalytic_Internal_Static_PackageManagerResetPackageAnalytic_0;

	static PackageManagerResetPackageAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerResetPackageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerResetPackageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerResetPackageAnalytic>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerResetPackageAnalytic>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_CreatePackageManagerResetPackageAnalytic_Internal_Static_PackageManagerResetPackageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerResetPackageAnalytic>.NativeClassPtr, 100663343);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407848, XrefRangeEnd = 1407853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerResetPackageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerResetPackageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407853, XrefRangeEnd = 1407861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePackageManagerResetPackageAnalytic_Internal_Static_PackageManagerResetPackageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PackageManagerResetPackageAnalytic>(intPtr2) : null;
	}

	public PackageManagerResetPackageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
