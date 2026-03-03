using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamApps : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0;

	static SteamApps()
	{
		Il2CppClassPointerStore<SteamApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamApps");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps>.NativeClassPtr);
		NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100663298);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686149, XrefRangeEnd = 686155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCurrentGameLanguage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686155, XrefRangeEnd = 686161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetAvailableGameLanguages()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public SteamApps(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
