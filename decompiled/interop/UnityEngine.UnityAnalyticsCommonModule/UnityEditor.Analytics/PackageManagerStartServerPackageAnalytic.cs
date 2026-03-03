using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEditor.Analytics;

[Serializable]
public class PackageManagerStartServerPackageAnalytic : PackageManagerBaseAnalytic
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreatePackageManagerStartServerPackageAnalytic_Internal_Static_PackageManagerStartServerPackageAnalytic_0;

	static PackageManagerStartServerPackageAnalytic()
	{
		Il2CppClassPointerStore<PackageManagerStartServerPackageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "PackageManagerStartServerPackageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageManagerStartServerPackageAnalytic>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerStartServerPackageAnalytic>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_CreatePackageManagerStartServerPackageAnalytic_Internal_Static_PackageManagerStartServerPackageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageManagerStartServerPackageAnalytic>.NativeClassPtr, 100663347);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407874, XrefRangeEnd = 1407879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageManagerStartServerPackageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageManagerStartServerPackageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407879, XrefRangeEnd = 1407887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePackageManagerStartServerPackageAnalytic_Internal_Static_PackageManagerStartServerPackageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PackageManagerStartServerPackageAnalytic>(intPtr2) : null;
	}

	public PackageManagerStartServerPackageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
