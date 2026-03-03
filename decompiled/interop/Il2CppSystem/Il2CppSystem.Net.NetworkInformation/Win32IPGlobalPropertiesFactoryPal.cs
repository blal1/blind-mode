using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public static class Win32IPGlobalPropertiesFactoryPal : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0;

	static Win32IPGlobalPropertiesFactoryPal()
	{
		Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPGlobalPropertiesFactoryPal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalPropertiesFactoryPal>.NativeClassPtr, 100667129);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897213, XrefRangeEnd = 897217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPGlobalProperties Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_IPGlobalProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr2) : null;
	}

	public Win32IPGlobalPropertiesFactoryPal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
