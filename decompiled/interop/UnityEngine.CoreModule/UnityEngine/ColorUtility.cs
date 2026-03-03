using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ColorUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0;

	static ColorUtility()
	{
		Il2CppClassPointerStore<ColorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr);
		NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665619);
		NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665620);
		NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665621);
		NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665622);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1182684, RefRangeEnd = 1182685, XrefRangeStart = 1182670, XrefRangeEnd = 1182684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1182686, RefRangeEnd = 1182697, XrefRangeStart = 1182685, XrefRangeEnd = 1182686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseHtmlString(string htmlString, out Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1182730, RefRangeEnd = 1182733, XrefRangeStart = 1182697, XrefRangeEnd = 1182730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToHtmlStringRGB(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182733, XrefRangeEnd = 1182735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DoTryParseHtmlColor_Injected(ref ManagedSpanWrapper htmlString, out Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref htmlString);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ColorUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static string ToHtmlStringRGBA(Color color)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
