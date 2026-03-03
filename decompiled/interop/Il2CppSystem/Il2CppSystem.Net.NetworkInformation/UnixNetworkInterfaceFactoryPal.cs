using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public static class UnixNetworkInterfaceFactoryPal : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0;

	static UnixNetworkInterfaceFactoryPal()
	{
		Il2CppClassPointerStore<UnixNetworkInterfaceFactoryPal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixNetworkInterfaceFactoryPal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixNetworkInterfaceFactoryPal>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixNetworkInterfaceFactoryPal>.NativeClassPtr, 100667144);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NetworkInterfaceFactory Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkInterfaceFactory>(intPtr2) : null;
	}

	public UnixNetworkInterfaceFactoryPal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
