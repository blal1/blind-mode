using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamClient : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

	static SteamClient()
	{
		Il2CppClassPointerStore<SteamClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamClient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClient>.NativeClassPtr);
		NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100663322);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686178, RefRangeEnd = 686179, XrefRangeStart = 686161, XrefRangeEnd = 686178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686196, RefRangeEnd = 686197, XrefRangeStart = 686179, XrefRangeEnd = 686196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686214, RefRangeEnd = 686215, XrefRangeStart = 686197, XrefRangeEnd = 686214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSteamPipe);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686232, RefRangeEnd = 686233, XrefRangeStart = 686215, XrefRangeEnd = 686232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686250, RefRangeEnd = 686251, XrefRangeStart = 686233, XrefRangeEnd = 686250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686268, RefRangeEnd = 686269, XrefRangeStart = 686251, XrefRangeEnd = 686268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686286, RefRangeEnd = 686287, XrefRangeStart = 686269, XrefRangeEnd = 686286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686304, RefRangeEnd = 686305, XrefRangeStart = 686287, XrefRangeEnd = 686304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686322, RefRangeEnd = 686323, XrefRangeStart = 686305, XrefRangeEnd = 686322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686340, RefRangeEnd = 686341, XrefRangeStart = 686323, XrefRangeEnd = 686340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686358, RefRangeEnd = 686359, XrefRangeStart = 686341, XrefRangeEnd = 686358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686364, RefRangeEnd = 686365, XrefRangeStart = 686359, XrefRangeEnd = 686364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pFunction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686382, RefRangeEnd = 686383, XrefRangeStart = 686365, XrefRangeEnd = 686382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686400, RefRangeEnd = 686401, XrefRangeStart = 686383, XrefRangeEnd = 686400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686418, RefRangeEnd = 686419, XrefRangeStart = 686401, XrefRangeEnd = 686418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686436, RefRangeEnd = 686437, XrefRangeStart = 686419, XrefRangeEnd = 686436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686454, RefRangeEnd = 686455, XrefRangeStart = 686437, XrefRangeEnd = 686454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686472, RefRangeEnd = 686473, XrefRangeStart = 686455, XrefRangeEnd = 686472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686490, RefRangeEnd = 686491, XrefRangeStart = 686473, XrefRangeEnd = 686490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686508, RefRangeEnd = 686509, XrefRangeStart = 686491, XrefRangeEnd = 686508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686526, RefRangeEnd = 686527, XrefRangeStart = 686509, XrefRangeEnd = 686526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamuser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686544, RefRangeEnd = 686545, XrefRangeStart = 686527, XrefRangeEnd = 686544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686562, RefRangeEnd = 686563, XrefRangeStart = 686545, XrefRangeEnd = 686562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686580, RefRangeEnd = 686581, XrefRangeStart = 686563, XrefRangeEnd = 686580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hSteamUser);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SteamClient(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
