using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamAPI : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0;

	static SteamAPI()
	{
		Il2CppClassPointerStore<SteamAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamAPI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr);
		NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663439);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687562, RefRangeEnd = 687563, XrefRangeStart = 687555, XrefRangeEnd = 687562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687599, RefRangeEnd = 687600, XrefRangeStart = 687563, XrefRangeEnd = 687599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686775, RefRangeEnd = 686776, XrefRangeStart = 686775, XrefRangeEnd = 686776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RestartAppIfNecessary(AppId_t unOwnAppID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unOwnAppID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687604, RefRangeEnd = 687605, XrefRangeStart = 687600, XrefRangeEnd = 687604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunCallbacks()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687605, XrefRangeEnd = 687606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HSteamPipe GetHSteamPipe()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HSteamPipe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HSteamUser GetHSteamUser()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HSteamUser*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SteamAPI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
