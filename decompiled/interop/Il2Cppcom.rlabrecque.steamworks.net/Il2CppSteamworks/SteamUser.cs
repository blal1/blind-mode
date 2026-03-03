using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamUser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0;

	static SteamUser()
	{
		Il2CppClassPointerStore<SteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamUser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser>.NativeClassPtr);
		NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100663328);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686598, XrefRangeEnd = 686603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HSteamUser GetHSteamUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HSteamUser*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686608, RefRangeEnd = 686609, XrefRangeStart = 686603, XrefRangeEnd = 686608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BLoggedOn()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 686617, RefRangeEnd = 686619, XrefRangeStart = 686609, XrefRangeEnd = 686617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CSteamID GetSteamID()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CSteamID*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 686627, RefRangeEnd = 686631, XrefRangeStart = 686619, XrefRangeEnd = 686627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HAuthTicket GetAuthSessionTicket(Il2CppStructArray<byte> pTicket, int cbMaxTicket, out uint pcbTicket)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pTicket);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cbMaxTicket;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pcbTicket);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HAuthTicket*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686636, RefRangeEnd = 686637, XrefRangeStart = 686631, XrefRangeEnd = 686636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CancelAuthTicket(HAuthTicket hAuthTicket)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hAuthTicket);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SteamUser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
