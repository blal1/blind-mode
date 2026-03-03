using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net;

[System.Serializable]
public class EndPoint : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual AddressFamily AddressFamily
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887631, XrefRangeEnd = 887634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AddressFamily*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EndPoint()
	{
		Il2CppClassPointerStore<EndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPoint>.NativeClassPtr);
		NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100666121);
		NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100666122);
		NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100666123);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100666124);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887634, XrefRangeEnd = 887637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SocketAddress Serialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887637, XrefRangeEnd = 887640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual EndPoint Create(SocketAddress socketAddress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socketAddress);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EndPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPoint>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EndPoint(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
