using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Int32_UInt32_UInt32_IntPtr_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Il2CppReferenceArray_1_Win32_IP_ADAPTER_ADDRESSES_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Virtual_Il2CppReferenceArray_1_NetworkInterface_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Win32NetworkInterfaceAPI()
	{
		Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterfaceAPI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr);
		NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Int32_UInt32_UInt32_IntPtr_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr, 100667132);
		NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Il2CppReferenceArray_1_Win32_IP_ADAPTER_ADDRESSES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr, 100667133);
		NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Virtual_Il2CppReferenceArray_1_NetworkInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr, 100667134);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr, 100667135);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897223, XrefRangeEnd = 897226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAdaptersAddresses(uint family, uint flags, System.IntPtr reserved, System.IntPtr info, ref int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&family);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &reserved;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Int32_UInt32_UInt32_IntPtr_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 897264, RefRangeEnd = 897265, XrefRangeStart = 897226, XrefRangeEnd = 897264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Win32_IP_ADAPTER_ADDRESSES> GetAdaptersAddresses()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdaptersAddresses_Private_Static_Il2CppReferenceArray_1_Win32_IP_ADAPTER_ADDRESSES_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Win32_IP_ADAPTER_ADDRESSES>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897265, XrefRangeEnd = 897276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppReferenceArray<NetworkInterface> GetAllNetworkInterfaces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Virtual_Il2CppReferenceArray_1_NetworkInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkInterface>>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Win32NetworkInterfaceAPI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32NetworkInterfaceAPI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Win32NetworkInterfaceAPI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
