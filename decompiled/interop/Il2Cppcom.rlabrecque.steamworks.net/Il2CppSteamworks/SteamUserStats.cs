using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamUserStats : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0;

	static SteamUserStats()
	{
		Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamUserStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr);
		NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100663332);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686654, RefRangeEnd = 686655, XrefRangeStart = 686637, XrefRangeEnd = 686654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetStat(string pchName, int nData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nData;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 686672, RefRangeEnd = 686675, XrefRangeStart = 686655, XrefRangeEnd = 686672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetAchievement(string pchName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 686680, RefRangeEnd = 686682, XrefRangeStart = 686675, XrefRangeEnd = 686680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StoreStats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686699, RefRangeEnd = 686700, XrefRangeStart = 686682, XrefRangeEnd = 686699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nCurProgress;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxProgress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SteamUserStats(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
