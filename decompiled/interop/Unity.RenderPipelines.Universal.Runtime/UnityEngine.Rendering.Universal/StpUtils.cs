using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public static class StpUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_JitterFunc;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateJitter_Private_Static_Void_Int32_byref_Vector2_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateStpConfig_Private_Static_Void_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_Int32_TextureHandle_TextureHandle_Texture2D_byref_Config_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Internal_Static_Void_RenderGraph_UniversalResourceData_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_TextureHandle_Texture2D_0;

	public unsafe static TemporalAA.JitterFunc s_JitterFunc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_JitterFunc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TemporalAA.JitterFunc>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_JitterFunc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static StpUtils()
	{
		Il2CppClassPointerStore<StpUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "StpUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StpUtils>.NativeClassPtr);
		NativeFieldInfoPtr_s_JitterFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpUtils>.NativeClassPtr, "s_JitterFunc");
		NativeMethodInfoPtr_CalculateJitter_Private_Static_Void_Int32_byref_Vector2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpUtils>.NativeClassPtr, 100665565);
		NativeMethodInfoPtr_PopulateStpConfig_Private_Static_Void_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_Int32_TextureHandle_TextureHandle_Texture2D_byref_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpUtils>.NativeClassPtr, 100665566);
		NativeMethodInfoPtr_Execute_Internal_Static_Void_RenderGraph_UniversalResourceData_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_TextureHandle_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StpUtils>.NativeClassPtr, 100665567);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100095, XrefRangeEnd = 1100099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&frameIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref jitter);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allowScaling);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateJitter_Private_Static_Void_Int32_byref_Vector2_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100146, RefRangeEnd = 1100147, XrefRangeStart = 1100099, XrefRangeEnd = 1100146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateStpConfig(UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, int debugViewIndex, TextureHandle debugView, TextureHandle destination, Texture2D noiseTexture, out STP.Config config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputColor;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputDepth;
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputMotion;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugViewIndex;
		*(TextureHandle**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		*(TextureHandle**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseTexture);
		byte* num = (byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateStpConfig_Private_Static_Void_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_Int32_TextureHandle_TextureHandle_Texture2D_byref_Config_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		config = ((num3 == 0) ? null : new STP.Config(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100178, RefRangeEnd = 1100179, XrefRangeStart = 1100147, XrefRangeEnd = 1100178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Execute(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, TextureHandle destination, Texture2D noiseTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputColor;
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputDepth;
		*(TextureHandle**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputMotion;
		*(TextureHandle**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Internal_Static_Void_RenderGraph_UniversalResourceData_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_TextureHandle_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public StpUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
