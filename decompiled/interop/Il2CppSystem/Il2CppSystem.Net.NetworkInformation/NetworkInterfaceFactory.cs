using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

public class NetworkInterfaceFactory : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_NetworkInterface_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static NetworkInterfaceFactory()
	{
		Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "NetworkInterfaceFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr);
		NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_NetworkInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr, 100667123);
		NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr, 100667124);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr, 100667125);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppReferenceArray<NetworkInterface> GetAllNetworkInterfaces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllNetworkInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_NetworkInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkInterface>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897202, XrefRangeEnd = 897212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NetworkInterfaceFactory Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_NetworkInterfaceFactory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkInterfaceFactory>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkInterfaceFactory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkInterfaceFactory>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NetworkInterfaceFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
