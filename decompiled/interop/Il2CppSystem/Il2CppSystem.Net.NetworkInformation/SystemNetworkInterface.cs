using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public static class SystemNetworkInterface : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nif;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0;

	public unsafe static NetworkInterfaceFactory nif
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nif, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkInterfaceFactory>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nif, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SystemNetworkInterface()
	{
		Il2CppClassPointerStore<SystemNetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "SystemNetworkInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemNetworkInterface>.NativeClassPtr);
		NativeFieldInfoPtr_nif = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemNetworkInterface>.NativeClassPtr, "nif");
		NativeMethodInfoPtr_GetNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemNetworkInterface>.NativeClassPtr, 100667121);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 897201, RefRangeEnd = 897202, XrefRangeStart = 897194, XrefRangeEnd = 897201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<NetworkInterface> GetNetworkInterfaces()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkInterface>>(intPtr2) : null;
	}

	public SystemNetworkInterface(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
