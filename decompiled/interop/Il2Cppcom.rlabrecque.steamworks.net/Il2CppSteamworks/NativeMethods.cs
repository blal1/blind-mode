using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class NativeMethods : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_GetHSteamUser_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamInternal_CreateInterface_Public_Static_IntPtr_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamInternal_FindOrCreateUserInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamInternal_FindOrCreateGameServerInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Public_Static_Void_HSteamPipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Public_Static_Boolean_HSteamPipe_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Public_Static_Void_HSteamPipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetAPICallResult_Public_Static_Boolean_HSteamPipe_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamApps_GetCurrentGameLanguage_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamApps_GetAvailableGameLanguages_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamUser_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamFriends_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamUtils_Public_Static_IntPtr_IntPtr_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamMatchmaking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamMatchmakingServers_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamUserStats_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamApps_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamNetworking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamRemoteStorage_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamScreenshots_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamGameSearch_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_SetWarningMessageHook_Public_Static_Void_IntPtr_SteamAPIWarningMessageHook_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamHTTP_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamUGC_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamAppList_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamMusic_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamMusicRemote_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamHTMLSurface_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamInventory_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamVideo_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamParentalSettings_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamInput_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamParties_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamClient_GetISteamRemotePlay_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamFriends_ActivateGameOverlay_Public_Static_Void_IntPtr_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUser_GetHSteamUser_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUser_BLoggedOn_Public_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUser_GetSteamID_Public_Static_UInt64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUser_GetAuthSessionTicket_Public_Static_UInt32_IntPtr_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUser_CancelAuthTicket_Public_Static_Void_IntPtr_HAuthTicket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUserStats_SetStatInt32_Public_Static_Boolean_IntPtr_UTF8StringHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUserStats_SetAchievement_Public_Static_Boolean_IntPtr_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUserStats_StoreStats_Public_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUserStats_IndicateAchievementProgress_Public_Static_Boolean_IntPtr_UTF8StringHandle_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_GetIPCountry_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_IsOverlayEnabled_Public_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_ShowGamepadTextInput_Public_Static_Boolean_IntPtr_EGamepadTextInputMode_EGamepadTextInputLineMode_UTF8StringHandle_UInt32_UTF8StringHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_GetEnteredGamepadTextInput_Public_Static_Boolean_IntPtr_IntPtr_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_IsSteamRunningOnSteamDeck_Public_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ISteamUtils_ShowFloatingGamepadTextInput_Public_Static_Boolean_IntPtr_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0;

	static NativeMethods()
	{
		Il2CppClassPointerStore<NativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "NativeMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr);
		NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_SteamAPI_GetHSteamUser_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_SteamInternal_CreateInterface_Public_Static_IntPtr_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_SteamInternal_FindOrCreateUserInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_SteamInternal_FindOrCreateGameServerInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Public_Static_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Public_Static_Boolean_HSteamPipe_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Public_Static_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetAPICallResult_Public_Static_Boolean_HSteamPipe_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_ISteamApps_GetCurrentGameLanguage_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_ISteamApps_GetAvailableGameLanguages_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_ISteamClient_GetISteamUser_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_ISteamClient_GetISteamFriends_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_ISteamClient_GetISteamUtils_Public_Static_IntPtr_IntPtr_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_ISteamClient_GetISteamMatchmaking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_ISteamClient_GetISteamMatchmakingServers_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_ISteamClient_GetISteamUserStats_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_ISteamClient_GetISteamApps_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_ISteamClient_GetISteamNetworking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_ISteamClient_GetISteamRemoteStorage_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_ISteamClient_GetISteamScreenshots_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_ISteamClient_GetISteamGameSearch_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_ISteamClient_SetWarningMessageHook_Public_Static_Void_IntPtr_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_ISteamClient_GetISteamHTTP_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_ISteamClient_GetISteamUGC_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_ISteamClient_GetISteamAppList_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_ISteamClient_GetISteamMusic_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_ISteamClient_GetISteamMusicRemote_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_ISteamClient_GetISteamHTMLSurface_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_ISteamClient_GetISteamInventory_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_ISteamClient_GetISteamVideo_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_ISteamClient_GetISteamParentalSettings_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_ISteamClient_GetISteamInput_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_ISteamClient_GetISteamParties_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_ISteamClient_GetISteamRemotePlay_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_ISteamFriends_ActivateGameOverlay_Public_Static_Void_IntPtr_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_ISteamUser_GetHSteamUser_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_ISteamUser_BLoggedOn_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_ISteamUser_GetSteamID_Public_Static_UInt64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_ISteamUser_GetAuthSessionTicket_Public_Static_UInt32_IntPtr_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_ISteamUser_CancelAuthTicket_Public_Static_Void_IntPtr_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_ISteamUserStats_SetStatInt32_Public_Static_Boolean_IntPtr_UTF8StringHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_ISteamUserStats_SetAchievement_Public_Static_Boolean_IntPtr_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_ISteamUserStats_StoreStats_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_ISteamUserStats_IndicateAchievementProgress_Public_Static_Boolean_IntPtr_UTF8StringHandle_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_ISteamUtils_GetIPCountry_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_ISteamUtils_IsOverlayEnabled_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_ISteamUtils_ShowGamepadTextInput_Public_Static_Boolean_IntPtr_EGamepadTextInputMode_EGamepadTextInputLineMode_UTF8StringHandle_UInt32_UTF8StringHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_ISteamUtils_GetEnteredGamepadTextInput_Public_Static_Boolean_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_ISteamUtils_IsSteamRunningOnSteamDeck_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_ISteamUtils_ShowFloatingGamepadTextInput_Public_Static_Boolean_IntPtr_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethods>.NativeClassPtr, 100663394);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686769, XrefRangeEnd = 686771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SteamAPI_Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686771, XrefRangeEnd = 686773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPI_Shutdown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686775, RefRangeEnd = 686776, XrefRangeStart = 686773, XrefRangeEnd = 686775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unOwnAppID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 686778, RefRangeEnd = 686781, XrefRangeStart = 686776, XrefRangeEnd = 686778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SteamAPI_GetHSteamPipe()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686781, XrefRangeEnd = 686783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SteamAPI_GetHSteamUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_GetHSteamUser_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686783, XrefRangeEnd = 686787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ver);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamInternal_CreateInterface_Public_Static_IntPtr_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 686791, RefRangeEnd = 686795, XrefRangeStart = 686787, XrefRangeEnd = 686791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSteamUser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pszVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamInternal_FindOrCreateUserInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686795, XrefRangeEnd = 686799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSteamUser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pszVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamInternal_FindOrCreateGameServerInterface_Public_Static_IntPtr_HSteamUser_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686799, XrefRangeEnd = 686801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPI_ManualDispatch_Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686801, XrefRangeEnd = 686803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hSteamPipe);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Public_Static_Void_HSteamPipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686803, XrefRangeEnd = 686805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, System.IntPtr pCallbackMsg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSteamPipe);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pCallbackMsg;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Public_Static_Boolean_HSteamPipe_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686805, XrefRangeEnd = 686807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hSteamPipe);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Public_Static_Void_HSteamPipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686809, RefRangeEnd = 686810, XrefRangeStart = 686807, XrefRangeEnd = 686809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, System.IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&hSteamPipe);
		*(SteamAPICall_t**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamAPICall;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pCallback;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubCallback;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &iCallbackExpected;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pbFailed);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetAPICallResult_Public_Static_Boolean_HSteamPipe_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686810, XrefRangeEnd = 686812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SteamGameServer_GetHSteamPipe()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686812, XrefRangeEnd = 686814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamApps_GetCurrentGameLanguage(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamApps_GetCurrentGameLanguage_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686814, XrefRangeEnd = 686816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamApps_GetAvailableGameLanguages(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamApps_GetAvailableGameLanguages_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686816, XrefRangeEnd = 686820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamUser(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamUser_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686820, XrefRangeEnd = 686824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamFriends(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamFriends_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686824, XrefRangeEnd = 686828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamUtils(System.IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instancePtr);
		*(HSteamPipe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamUtils_Public_Static_IntPtr_IntPtr_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686828, XrefRangeEnd = 686832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamMatchmaking(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamMatchmaking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686832, XrefRangeEnd = 686836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamMatchmakingServers(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamMatchmakingServers_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686836, XrefRangeEnd = 686840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamUserStats(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamUserStats_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686840, XrefRangeEnd = 686844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamApps(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamApps_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686844, XrefRangeEnd = 686848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamNetworking(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamNetworking_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686848, XrefRangeEnd = 686852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamRemoteStorage(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamRemoteStorage_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686852, XrefRangeEnd = 686856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamScreenshots(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamScreenshots_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686856, XrefRangeEnd = 686860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamGameSearch(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamGameSearch_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686860, XrefRangeEnd = 686862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ISteamClient_SetWarningMessageHook(System.IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pFunction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_SetWarningMessageHook_Public_Static_Void_IntPtr_SteamAPIWarningMessageHook_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686862, XrefRangeEnd = 686866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamHTTP(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamHTTP_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686866, XrefRangeEnd = 686870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamUGC(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamUGC_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686870, XrefRangeEnd = 686874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamAppList(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamAppList_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686874, XrefRangeEnd = 686878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamMusic(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamMusic_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686878, XrefRangeEnd = 686882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamMusicRemote(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamMusicRemote_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686882, XrefRangeEnd = 686886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamHTMLSurface(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamHTMLSurface_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686886, XrefRangeEnd = 686890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamInventory(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamInventory_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686890, XrefRangeEnd = 686894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamVideo(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamVideo_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686894, XrefRangeEnd = 686898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamParentalSettings(System.IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamuser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamParentalSettings_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686898, XrefRangeEnd = 686902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamInput(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamInput_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686902, XrefRangeEnd = 686906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamParties(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamParties_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686906, XrefRangeEnd = 686910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamClient_GetISteamRemotePlay(System.IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(HSteamUser**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamUser;
		*(HSteamPipe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hSteamPipe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchVersion);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamClient_GetISteamRemotePlay_Public_Static_IntPtr_IntPtr_HSteamUser_HSteamPipe_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686910, XrefRangeEnd = 686913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ISteamFriends_ActivateGameOverlay(System.IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchDialog);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamFriends_ActivateGameOverlay_Public_Static_Void_IntPtr_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686913, XrefRangeEnd = 686915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ISteamUser_GetHSteamUser(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUser_GetHSteamUser_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686915, XrefRangeEnd = 686917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUser_BLoggedOn(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUser_BLoggedOn_Public_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686917, XrefRangeEnd = 686919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ISteamUser_GetSteamID(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUser_GetSteamID_Public_Static_UInt64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686919, XrefRangeEnd = 686921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ISteamUser_GetAuthSessionTicket(System.IntPtr instancePtr, Il2CppStructArray<byte> pTicket, int cbMaxTicket, out uint pcbTicket)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pTicket);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cbMaxTicket;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pcbTicket);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUser_GetAuthSessionTicket_Public_Static_UInt32_IntPtr_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686921, XrefRangeEnd = 686923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ISteamUser_CancelAuthTicket(System.IntPtr instancePtr, HAuthTicket hAuthTicket)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instancePtr);
		*(HAuthTicket**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hAuthTicket;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUser_CancelAuthTicket_Public_Static_Void_IntPtr_HAuthTicket_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686923, XrefRangeEnd = 686927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUserStats_SetStatInt32(System.IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nData;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUserStats_SetStatInt32_Public_Static_Boolean_IntPtr_UTF8StringHandle_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686927, XrefRangeEnd = 686931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUserStats_SetAchievement(System.IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUserStats_SetAchievement_Public_Static_Boolean_IntPtr_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686931, XrefRangeEnd = 686933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUserStats_StoreStats(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUserStats_StoreStats_Public_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686933, XrefRangeEnd = 686937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUserStats_IndicateAchievementProgress(System.IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchName);
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nCurProgress;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxProgress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUserStats_IndicateAchievementProgress_Public_Static_Boolean_IntPtr_UTF8StringHandle_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686937, XrefRangeEnd = 686939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ISteamUtils_GetIPCountry(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_GetIPCountry_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686939, XrefRangeEnd = 686941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUtils_IsOverlayEnabled(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_IsOverlayEnabled_Public_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686941, XrefRangeEnd = 686947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUtils_ShowGamepadTextInput(System.IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&instancePtr);
		*(EGamepadTextInputMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eInputMode;
		*(EGamepadTextInputLineMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eLineInputMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchDescription);
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &unCharMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pchExistingText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_ShowGamepadTextInput_Public_Static_Boolean_IntPtr_EGamepadTextInputMode_EGamepadTextInputLineMode_UTF8StringHandle_UInt32_UTF8StringHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686947, XrefRangeEnd = 686949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUtils_GetEnteredGamepadTextInput(System.IntPtr instancePtr, System.IntPtr pchText, uint cchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instancePtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pchText;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cchText;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_GetEnteredGamepadTextInput_Public_Static_Boolean_IntPtr_IntPtr_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686949, XrefRangeEnd = 686951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUtils_IsSteamRunningOnSteamDeck(System.IntPtr instancePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_IsSteamRunningOnSteamDeck_Public_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686951, XrefRangeEnd = 686953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ISteamUtils_ShowFloatingGamepadTextInput(System.IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&instancePtr);
		*(EFloatingGamepadTextInputMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eKeyboardMode;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldXPosition;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldYPosition;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ISteamUtils_ShowFloatingGamepadTextInput_Public_Static_Boolean_IntPtr_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NativeMethods(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
