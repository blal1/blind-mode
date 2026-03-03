using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class CSteamAPIContext : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamClient;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamFriends;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamUtils;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamMatchmaking;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamUserStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamApps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamMatchmakingServers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamNetworking;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamRemoteStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamScreenshots;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamGameSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamHTTP;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pController;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamUGC;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamAppList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamMusic;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamMusicRemote;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamHTMLSurface;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamVideo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamParentalSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamParties;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamRemotePlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamNetworkingUtils;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamNetworkingSockets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pSteamNetworkingMessages;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0;

	public unsafe static System.IntPtr m_pSteamClient
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamClient, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamClient, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamUser
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamUser, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamUser, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamFriends
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamFriends, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamFriends, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamUtils
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamUtils, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamUtils, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamMatchmaking
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamUserStats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamApps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamApps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamApps, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamMatchmakingServers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamNetworking
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamRemoteStorage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamScreenshots
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamGameSearch
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamGameSearch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamGameSearch, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamHTTP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pController
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pController, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pController, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamUGC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamUGC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamUGC, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamAppList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamAppList, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamAppList, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamMusic
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamMusic, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamMusic, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamMusicRemote
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamHTMLSurface
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamInventory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamInventory, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamInventory, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamVideo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamVideo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamVideo, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamParentalSettings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamInput
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamInput, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamInput, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamParties
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamParties, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamParties, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamRemotePlay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamRemotePlay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamRemotePlay, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamNetworkingUtils
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamNetworkingSockets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr m_pSteamNetworkingMessages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&value));
		}
	}

	static CSteamAPIContext()
	{
		Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CSteamAPIContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr);
		NativeFieldInfoPtr_m_pSteamClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamClient");
		NativeFieldInfoPtr_m_pSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUser");
		NativeFieldInfoPtr_m_pSteamFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamFriends");
		NativeFieldInfoPtr_m_pSteamUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUtils");
		NativeFieldInfoPtr_m_pSteamMatchmaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmaking");
		NativeFieldInfoPtr_m_pSteamUserStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUserStats");
		NativeFieldInfoPtr_m_pSteamApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamApps");
		NativeFieldInfoPtr_m_pSteamMatchmakingServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmakingServers");
		NativeFieldInfoPtr_m_pSteamNetworking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworking");
		NativeFieldInfoPtr_m_pSteamRemoteStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamRemoteStorage");
		NativeFieldInfoPtr_m_pSteamScreenshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamScreenshots");
		NativeFieldInfoPtr_m_pSteamGameSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamGameSearch");
		NativeFieldInfoPtr_m_pSteamHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTTP");
		NativeFieldInfoPtr_m_pController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pController");
		NativeFieldInfoPtr_m_pSteamUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUGC");
		NativeFieldInfoPtr_m_pSteamAppList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamAppList");
		NativeFieldInfoPtr_m_pSteamMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusic");
		NativeFieldInfoPtr_m_pSteamMusicRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusicRemote");
		NativeFieldInfoPtr_m_pSteamHTMLSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTMLSurface");
		NativeFieldInfoPtr_m_pSteamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamInventory");
		NativeFieldInfoPtr_m_pSteamVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamVideo");
		NativeFieldInfoPtr_m_pSteamParentalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamParentalSettings");
		NativeFieldInfoPtr_m_pSteamInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamInput");
		NativeFieldInfoPtr_m_pSteamParties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamParties");
		NativeFieldInfoPtr_m_pSteamRemotePlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamRemotePlay");
		NativeFieldInfoPtr_m_pSteamNetworkingUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingUtils");
		NativeFieldInfoPtr_m_pSteamNetworkingSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingSockets");
		NativeFieldInfoPtr_m_pSteamNetworkingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingMessages");
		NativeMethodInfoPtr_Clear_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100663447);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687606, XrefRangeEnd = 687636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 687818, RefRangeEnd = 687820, XrefRangeStart = 687636, XrefRangeEnd = 687818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687820, XrefRangeEnd = 687822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamClient()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687822, XrefRangeEnd = 687824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687824, XrefRangeEnd = 687826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamFriends()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687826, XrefRangeEnd = 687828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamUtils()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687828, XrefRangeEnd = 687830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamUserStats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687830, XrefRangeEnd = 687832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSteamApps()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CSteamAPIContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
