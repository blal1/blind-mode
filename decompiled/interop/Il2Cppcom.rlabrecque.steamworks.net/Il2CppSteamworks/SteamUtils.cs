using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public static class SteamUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Public_Static_Boolean_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0;

	static SteamUtils()
	{
		Il2CppClassPointerStore<SteamUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "SteamUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr);
		NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Public_Static_Boolean_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100663338);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686700, XrefRangeEnd = 686706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetIPCountry()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 686711, RefRangeEnd = 686714, XrefRangeStart = 686706, XrefRangeEnd = 686711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOverlayEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686740, RefRangeEnd = 686741, XrefRangeStart = 686714, XrefRangeEnd = 686740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&eInputMode);
		*(EGamepadTextInputLineMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eLineInputMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &unCharMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pchExistingText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686756, RefRangeEnd = 686757, XrefRangeStart = 686741, XrefRangeEnd = 686756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cchText;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		pchText = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686762, RefRangeEnd = 686763, XrefRangeStart = 686757, XrefRangeEnd = 686762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSteamRunningOnSteamDeck()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSteamRunningOnSteamDeck_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686768, RefRangeEnd = 686769, XrefRangeStart = 686763, XrefRangeEnd = 686768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&eKeyboardMode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldXPosition;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldYPosition;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldWidth;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nTextFieldHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowFloatingGamepadTextInput_Public_Static_Boolean_EFloatingGamepadTextInputMode_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SteamUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
