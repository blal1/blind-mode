using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class ColorGamutUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0;

	static ColorGamutUtility()
	{
		Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorGamutUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664462);
		NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664464);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1173486, RefRangeEnd = 1173489, XrefRangeStart = 1173484, XrefRangeEnd = 1173486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ColorPrimaries GetColorPrimaries(ColorGamut gamut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ColorPrimaries*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173491, RefRangeEnd = 1173492, XrefRangeStart = 1173489, XrefRangeEnd = 1173491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static WhitePoint GetWhitePoint(ColorGamut gamut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(WhitePoint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173494, RefRangeEnd = 1173495, XrefRangeStart = 1173492, XrefRangeEnd = 1173494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TransferFunction GetTransferFunction(ColorGamut gamut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TransferFunction*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ColorGamutUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
