using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamFriends : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0;

	static SteamFriends()
	{
		Il2CppClassPointerStore<SteamFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamFriends");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr);
		NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100663323);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686597, RefRangeEnd = 686598, XrefRangeStart = 686581, XrefRangeEnd = 686597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ActivateGameOverlay(string pchDialog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SteamFriends(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
