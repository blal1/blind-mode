using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public class NetworkInterface : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_New_PhysicalAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static NetworkInterface()
	{
		Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "NetworkInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr);
		NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr, 100667111);
		NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_New_PhysicalAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr, 100667112);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr, 100667113);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 897157, RefRangeEnd = 897158, XrefRangeStart = 897153, XrefRangeEnd = 897157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<NetworkInterface> GetAllNetworkInterfaces()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Static_Il2CppReferenceArray_1_NetworkInterface_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkInterface>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897158, XrefRangeEnd = 897163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PhysicalAddress GetPhysicalAddress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPhysicalAddress_Public_Virtual_New_PhysicalAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicalAddress>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkInterface()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkInterface>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NetworkInterface(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
