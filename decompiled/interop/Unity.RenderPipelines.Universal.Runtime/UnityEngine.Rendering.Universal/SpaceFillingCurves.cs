using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public static class SpaceFillingCurves : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0;

	static SpaceFillingCurves()
	{
		Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "SpaceFillingCurves");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr);
		NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665561);
		NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665562);
		NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665563);
		NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceFillingCurves>.NativeClassPtr, 100665564);
	}

	[CallerCount(0)]
	public unsafe static uint Part1By1(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Part1By1_Private_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint Compact1By1(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compact1By1_Private_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint EncodeMorton2D(uint2 coord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coord);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeMorton2D_Public_Static_UInt32_uint2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100093, RefRangeEnd = 1100095, XrefRangeStart = 1100093, XrefRangeEnd = 1100093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint2 DecodeMorton2D(uint code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeMorton2D_Public_Static_uint2_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpaceFillingCurves(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
