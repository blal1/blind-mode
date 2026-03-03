using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public static class NetworkInterfaceFactoryPal : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0;

	static NetworkInterfaceFactoryPal()
	{
		Il2CppClassPointerStore<NetworkInterfaceFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "NetworkInterfaceFactoryPal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterfaceFactoryPal>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterfaceFactoryPal>.NativeClassPtr, 100667126);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NetworkInterfaceFactory Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkInterfaceFactory>(intPtr2) : null;
	}

	public NetworkInterfaceFactoryPal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
