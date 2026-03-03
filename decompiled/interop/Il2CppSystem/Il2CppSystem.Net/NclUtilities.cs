using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public static class NclUtilities : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__LocalAddresses;

	private static readonly System.IntPtr NativeFieldInfoPtr__LocalAddressesLock;

	private static readonly System.IntPtr NativeFieldInfoPtr__LocalDomainName;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0;

	public unsafe static Il2CppReferenceArray<IPAddress> _LocalAddresses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LocalAddresses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LocalAddresses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object _LocalAddressesLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LocalAddressesLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LocalAddressesLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string _LocalDomainName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LocalDomainName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LocalDomainName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Il2CppReferenceArray<IPAddress> LocalAddresses
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887716, RefRangeEnd = 887717, XrefRangeStart = 887651, XrefRangeEnd = 887716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
		}
	}

	public unsafe static Object LocalAddressesLock
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887717, XrefRangeEnd = 887726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	static NclUtilities()
	{
		Il2CppClassPointerStore<NclUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NclUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr);
		NativeFieldInfoPtr__LocalAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddresses");
		NativeFieldInfoPtr__LocalAddressesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddressesLock");
		NativeFieldInfoPtr__LocalDomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalDomainName");
		NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100666138);
		NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100666139);
		NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100666140);
		NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100666142);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 887643, RefRangeEnd = 887645, XrefRangeStart = 887640, XrefRangeEnd = 887643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFatal(Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFatal_Internal_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 887648, RefRangeEnd = 887649, XrefRangeStart = 887645, XrefRangeEnd = 887648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAddressLocal(IPAddress ipAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ipAddress);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887649, XrefRangeEnd = 887651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry GetLocalHost()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	public NclUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
