using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

public static class LightmapperUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;

	static LightmapperUtils()
	{
		Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightmapperUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
		NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668910);
		NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668911);
		NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668912);
		NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668913);
		NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668914);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668915);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668916);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668917);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668918);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668919);
		NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100668920);
	}

	[CallerCount(0)]
	public unsafe static LightMode Extract(LightmapBakeType baketype)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&baketype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240793, XrefRangeEnd = 1240797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LinearColor ExtractIndirect(Light l)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LinearColor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240797, XrefRangeEnd = 1240800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ExtractInnerCone(Light l)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240800, XrefRangeEnd = 1240807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ExtractColorTemperature(Light l)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240807, XrefRangeEnd = 1240810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cct);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightColor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240837, RefRangeEnd = 1240839, XrefRangeStart = 1240810, XrefRangeEnd = 1240837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, ref DirectionalLight dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dir);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240867, RefRangeEnd = 1240869, XrefRangeStart = 1240839, XrefRangeEnd = 1240867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, ref PointLight point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240901, RefRangeEnd = 1240903, XrefRangeStart = 1240869, XrefRangeEnd = 1240901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, ref SpotLight spot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref spot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240931, RefRangeEnd = 1240932, XrefRangeStart = 1240903, XrefRangeEnd = 1240931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, ref RectangleLight rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240960, RefRangeEnd = 1240961, XrefRangeStart = 1240932, XrefRangeEnd = 1240960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, ref DiscLight disc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref disc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1240977, RefRangeEnd = 1240982, XrefRangeStart = 1240961, XrefRangeEnd = 1240977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Extract(Light l, out Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)l);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightmapperUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
