using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class ShaderKeywordStrings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MainLightShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainLightShadowCascades;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainLightShadowScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_CastingPunctualLightShadow;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightsVertex;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightsPixel;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForwardPlus;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionProbeBoxProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionProbeBlending;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoftShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoftShadowsLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoftShadowsMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoftShadowsHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_MixedLightingSubtractive;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightmapShadowMixing;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadowsShadowMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderPassEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_BillboardFaceCameraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightCookies;

	private static readonly System.IntPtr NativeFieldInfoPtr_DepthNoMsaa;

	private static readonly System.IntPtr NativeFieldInfoPtr_DepthMsaa2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DepthMsaa4;

	private static readonly System.IntPtr NativeFieldInfoPtr_DepthMsaa8;

	private static readonly System.IntPtr NativeFieldInfoPtr_LinearToSRGBConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseFastSRGBLinearConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT3;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_WriteRenderingLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmaaLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmaaMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmaaHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaniniGeneric;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaniniUnitDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomLQ;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomHQ;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomLQDirt;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomHQDirt;

	private static readonly System.IntPtr NativeFieldInfoPtr_Distortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChromaticAberration;

	private static readonly System.IntPtr NativeFieldInfoPtr_HDRGrading;

	private static readonly System.IntPtr NativeFieldInfoPtr_HDROverlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_TonemapACES;

	private static readonly System.IntPtr NativeFieldInfoPtr_TonemapNeutral;

	private static readonly System.IntPtr NativeFieldInfoPtr_FilmGrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_Fxaa;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dithering;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScreenSpaceOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_PointSampling;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rcas;

	private static readonly System.IntPtr NativeFieldInfoPtr_EasuRcasAndHDRInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_Gamma20;

	private static readonly System.IntPtr NativeFieldInfoPtr_Gamma20AndHDRInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighQualitySampling;

	private static readonly System.IntPtr NativeFieldInfoPtr__SPOT;

	private static readonly System.IntPtr NativeFieldInfoPtr__DIRECTIONAL;

	private static readonly System.IntPtr NativeFieldInfoPtr__POINT;

	private static readonly System.IntPtr NativeFieldInfoPtr__DEFERRED_STENCIL;

	private static readonly System.IntPtr NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr__GBUFFER_NORMALS_OCT;

	private static readonly System.IntPtr NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING;

	private static readonly System.IntPtr NativeFieldInfoPtr_LIGHTMAP_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr__ALPHATEST_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED;

	private static readonly System.IntPtr NativeFieldInfoPtr__DETAIL_MULX2;

	private static readonly System.IntPtr NativeFieldInfoPtr__DETAIL_SCALED;

	private static readonly System.IntPtr NativeFieldInfoPtr__CLEARCOAT;

	private static readonly System.IntPtr NativeFieldInfoPtr__CLEARCOATMAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_DISPLAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOD_FADE_CROSSFADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE_UNITY_CROSSFADE;

	private static readonly System.IntPtr NativeFieldInfoPtr__EMISSION;

	private static readonly System.IntPtr NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT;

	private static readonly System.IntPtr NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr__ALPHAMODULATE_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr__NORMALMAP;

	private static readonly System.IntPtr NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_EDITOR_VISUALIZATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableTexture2DXArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlitSingleSlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_XROcclusionMeshCombined;

	private static readonly System.IntPtr NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16;

	private static readonly System.IntPtr NativeFieldInfoPtr_EVALUATE_SH_MIXED;

	private static readonly System.IntPtr NativeFieldInfoPtr_EVALUATE_SH_VERTEX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProbeVolumeL1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProbeVolumeL2;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE_LEGACY_LIGHTMAPS;

	private static readonly System.IntPtr NativeFieldInfoPtr__OUTPUT_DEPTH;

	private static readonly System.IntPtr NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT;

	public unsafe static string MainLightShadows
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadows, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadows, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string MainLightShadowCascades
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadowCascades, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadowCascades, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string MainLightShadowScreen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadowScreen, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadowScreen, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CastingPunctualLightShadow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CastingPunctualLightShadow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CastingPunctualLightShadow, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string AdditionalLightsVertex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsVertex, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsVertex, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string AdditionalLightsPixel
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsPixel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsPixel, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ForwardPlus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForwardPlus, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForwardPlus, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string AdditionalLightShadows
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightShadows, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightShadows, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ReflectionProbeBoxProjection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReflectionProbeBoxProjection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReflectionProbeBoxProjection, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ReflectionProbeBlending
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReflectionProbeBlending, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReflectionProbeBlending, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SoftShadows
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadows, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadows, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SoftShadowsLow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsLow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsLow, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SoftShadowsMedium
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsMedium, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsMedium, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SoftShadowsHigh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsHigh, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsHigh, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string MixedLightingSubtractive
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MixedLightingSubtractive, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MixedLightingSubtractive, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LightmapShadowMixing
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightmapShadowMixing, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightmapShadowMixing, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ShadowsShadowMask
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShadowsShadowMask, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShadowsShadowMask, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LightLayers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightLayers, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightLayers, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string RenderPassEnabled
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RenderPassEnabled, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RenderPassEnabled, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BillboardFaceCameraPos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BillboardFaceCameraPos, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BillboardFaceCameraPos, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LightCookies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightCookies, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightCookies, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DepthNoMsaa
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthNoMsaa, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthNoMsaa, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DepthMsaa2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DepthMsaa4
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa4, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa4, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DepthMsaa8
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa8, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa8, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LinearToSRGBConversion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LinearToSRGBConversion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LinearToSRGBConversion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UseFastSRGBLinearConversion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UseFastSRGBLinearConversion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UseFastSRGBLinearConversion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DBufferMRT1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT1, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DBufferMRT2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DBufferMRT3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT3, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT3, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DecalNormalBlendLow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendLow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendLow, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DecalNormalBlendMedium
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendMedium, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendMedium, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DecalNormalBlendHigh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendHigh, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendHigh, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DecalLayers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalLayers, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalLayers, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string WriteRenderingLayers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WriteRenderingLayers, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WriteRenderingLayers, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SmaaLow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SmaaLow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SmaaLow, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SmaaMedium
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SmaaMedium, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SmaaMedium, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SmaaHigh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SmaaHigh, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SmaaHigh, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PaniniGeneric
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PaniniGeneric, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PaniniGeneric, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PaniniUnitDistance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PaniniUnitDistance, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PaniniUnitDistance, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BloomLQ
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BloomLQ, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BloomLQ, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BloomHQ
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BloomHQ, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BloomHQ, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BloomLQDirt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BloomLQDirt, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BloomLQDirt, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BloomHQDirt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BloomHQDirt, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BloomHQDirt, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Distortion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Distortion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Distortion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ChromaticAberration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChromaticAberration, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChromaticAberration, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string HDRGrading
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDRGrading, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDRGrading, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string HDROverlay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HDROverlay, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HDROverlay, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string TonemapACES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TonemapACES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TonemapACES, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string TonemapNeutral
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TonemapNeutral, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TonemapNeutral, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string FilmGrain
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FilmGrain, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FilmGrain, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Fxaa
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Fxaa, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Fxaa, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Dithering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Dithering, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Dithering, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ScreenSpaceOcclusion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ScreenSpaceOcclusion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ScreenSpaceOcclusion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string PointSampling
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PointSampling, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PointSampling, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Rcas
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rcas, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rcas, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string EasuRcasAndHDRInput
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EasuRcasAndHDRInput, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EasuRcasAndHDRInput, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Gamma20
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Gamma20, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Gamma20, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string Gamma20AndHDRInput
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Gamma20AndHDRInput, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Gamma20AndHDRInput, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string HighQualitySampling
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HighQualitySampling, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HighQualitySampling, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _SPOT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SPOT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SPOT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DIRECTIONAL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DIRECTIONAL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DIRECTIONAL, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _POINT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__POINT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__POINT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DEFERRED_STENCIL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_STENCIL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_STENCIL, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DEFERRED_FIRST_LIGHT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DEFERRED_MAIN_LIGHT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _GBUFFER_NORMALS_OCT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__GBUFFER_NORMALS_OCT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__GBUFFER_NORMALS_OCT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DEFERRED_MIXED_LIGHTING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LIGHTMAP_ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIGHTMAP_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIGHTMAP_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DYNAMICLIGHTMAP_ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _ALPHATEST_ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHATEST_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHATEST_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DIRLIGHTMAP_COMBINED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DETAIL_MULX2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DETAIL_MULX2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DETAIL_MULX2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _DETAIL_SCALED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DETAIL_SCALED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DETAIL_SCALED, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CLEARCOAT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CLEARCOAT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CLEARCOAT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CLEARCOATMAP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CLEARCOATMAP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CLEARCOATMAP, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DEBUG_DISPLAY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEBUG_DISPLAY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEBUG_DISPLAY, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LOD_FADE_CROSSFADE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOD_FADE_CROSSFADE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOD_FADE_CROSSFADE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string USE_UNITY_CROSSFADE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_UNITY_CROSSFADE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_UNITY_CROSSFADE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _EMISSION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__EMISSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__EMISSION, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _RECEIVE_SHADOWS_OFF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _SURFACE_TYPE_TRANSPARENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _ALPHAPREMULTIPLY_ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _ALPHAMODULATE_ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHAMODULATE_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHAMODULATE_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _NORMALMAP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__NORMALMAP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__NORMALMAP, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _ADD_PRECOMPUTED_VELOCITY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string EDITOR_VISUALIZATION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_VISUALIZATION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_VISUALIZATION, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string FoveatedRenderingNonUniformRaster
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DisableTexture2DXArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string BlitSingleSlice
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BlitSingleSlice, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BlitSingleSlice, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string XROcclusionMeshCombined
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XROcclusionMeshCombined, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XROcclusionMeshCombined, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SCREEN_COORD_OVERRIDE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DOWNSAMPLING_SIZE_2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DOWNSAMPLING_SIZE_4
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DOWNSAMPLING_SIZE_8
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string DOWNSAMPLING_SIZE_16
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string EVALUATE_SH_MIXED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVALUATE_SH_MIXED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVALUATE_SH_MIXED, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string EVALUATE_SH_VERTEX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVALUATE_SH_VERTEX, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVALUATE_SH_VERTEX, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ProbeVolumeL1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProbeVolumeL1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProbeVolumeL1, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ProbeVolumeL2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProbeVolumeL2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProbeVolumeL2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string USE_LEGACY_LIGHTMAPS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_LEGACY_LIGHTMAPS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_LEGACY_LIGHTMAPS, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _OUTPUT_DEPTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OUTPUT_DEPTH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OUTPUT_DEPTH, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _ENABLE_ALPHA_OUTPUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static ShaderKeywordStrings()
	{
		Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderKeywordStrings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr);
		NativeFieldInfoPtr_MainLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "MainLightShadows");
		NativeFieldInfoPtr_MainLightShadowCascades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "MainLightShadowCascades");
		NativeFieldInfoPtr_MainLightShadowScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "MainLightShadowScreen");
		NativeFieldInfoPtr_CastingPunctualLightShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "CastingPunctualLightShadow");
		NativeFieldInfoPtr_AdditionalLightsVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "AdditionalLightsVertex");
		NativeFieldInfoPtr_AdditionalLightsPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "AdditionalLightsPixel");
		NativeFieldInfoPtr_ForwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ForwardPlus");
		NativeFieldInfoPtr_AdditionalLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "AdditionalLightShadows");
		NativeFieldInfoPtr_ReflectionProbeBoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ReflectionProbeBoxProjection");
		NativeFieldInfoPtr_ReflectionProbeBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ReflectionProbeBlending");
		NativeFieldInfoPtr_SoftShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SoftShadows");
		NativeFieldInfoPtr_SoftShadowsLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SoftShadowsLow");
		NativeFieldInfoPtr_SoftShadowsMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SoftShadowsMedium");
		NativeFieldInfoPtr_SoftShadowsHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SoftShadowsHigh");
		NativeFieldInfoPtr_MixedLightingSubtractive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "MixedLightingSubtractive");
		NativeFieldInfoPtr_LightmapShadowMixing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LightmapShadowMixing");
		NativeFieldInfoPtr_ShadowsShadowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ShadowsShadowMask");
		NativeFieldInfoPtr_LightLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LightLayers");
		NativeFieldInfoPtr_RenderPassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "RenderPassEnabled");
		NativeFieldInfoPtr_BillboardFaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BillboardFaceCameraPos");
		NativeFieldInfoPtr_LightCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LightCookies");
		NativeFieldInfoPtr_DepthNoMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DepthNoMsaa");
		NativeFieldInfoPtr_DepthMsaa2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DepthMsaa2");
		NativeFieldInfoPtr_DepthMsaa4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DepthMsaa4");
		NativeFieldInfoPtr_DepthMsaa8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DepthMsaa8");
		NativeFieldInfoPtr_LinearToSRGBConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LinearToSRGBConversion");
		NativeFieldInfoPtr_UseFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "UseFastSRGBLinearConversion");
		NativeFieldInfoPtr_DBufferMRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DBufferMRT1");
		NativeFieldInfoPtr_DBufferMRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DBufferMRT2");
		NativeFieldInfoPtr_DBufferMRT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DBufferMRT3");
		NativeFieldInfoPtr_DecalNormalBlendLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DecalNormalBlendLow");
		NativeFieldInfoPtr_DecalNormalBlendMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DecalNormalBlendMedium");
		NativeFieldInfoPtr_DecalNormalBlendHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DecalNormalBlendHigh");
		NativeFieldInfoPtr_DecalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DecalLayers");
		NativeFieldInfoPtr_WriteRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "WriteRenderingLayers");
		NativeFieldInfoPtr_SmaaLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SmaaLow");
		NativeFieldInfoPtr_SmaaMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SmaaMedium");
		NativeFieldInfoPtr_SmaaHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SmaaHigh");
		NativeFieldInfoPtr_PaniniGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "PaniniGeneric");
		NativeFieldInfoPtr_PaniniUnitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "PaniniUnitDistance");
		NativeFieldInfoPtr_BloomLQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BloomLQ");
		NativeFieldInfoPtr_BloomHQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BloomHQ");
		NativeFieldInfoPtr_BloomLQDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BloomLQDirt");
		NativeFieldInfoPtr_BloomHQDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BloomHQDirt");
		NativeFieldInfoPtr_Distortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Distortion");
		NativeFieldInfoPtr_ChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ChromaticAberration");
		NativeFieldInfoPtr_HDRGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "HDRGrading");
		NativeFieldInfoPtr_HDROverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "HDROverlay");
		NativeFieldInfoPtr_TonemapACES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "TonemapACES");
		NativeFieldInfoPtr_TonemapNeutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "TonemapNeutral");
		NativeFieldInfoPtr_FilmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "FilmGrain");
		NativeFieldInfoPtr_Fxaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Fxaa");
		NativeFieldInfoPtr_Dithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Dithering");
		NativeFieldInfoPtr_ScreenSpaceOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ScreenSpaceOcclusion");
		NativeFieldInfoPtr_PointSampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "PointSampling");
		NativeFieldInfoPtr_Rcas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Rcas");
		NativeFieldInfoPtr_EasuRcasAndHDRInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "EasuRcasAndHDRInput");
		NativeFieldInfoPtr_Gamma20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Gamma20");
		NativeFieldInfoPtr_Gamma20AndHDRInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "Gamma20AndHDRInput");
		NativeFieldInfoPtr_HighQualitySampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "HighQualitySampling");
		NativeFieldInfoPtr__SPOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_SPOT");
		NativeFieldInfoPtr__DIRECTIONAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DIRECTIONAL");
		NativeFieldInfoPtr__POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_POINT");
		NativeFieldInfoPtr__DEFERRED_STENCIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DEFERRED_STENCIL");
		NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DEFERRED_FIRST_LIGHT");
		NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DEFERRED_MAIN_LIGHT");
		NativeFieldInfoPtr__GBUFFER_NORMALS_OCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_GBUFFER_NORMALS_OCT");
		NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DEFERRED_MIXED_LIGHTING");
		NativeFieldInfoPtr_LIGHTMAP_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LIGHTMAP_ON");
		NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DYNAMICLIGHTMAP_ON");
		NativeFieldInfoPtr__ALPHATEST_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_ALPHATEST_ON");
		NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DIRLIGHTMAP_COMBINED");
		NativeFieldInfoPtr__DETAIL_MULX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DETAIL_MULX2");
		NativeFieldInfoPtr__DETAIL_SCALED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_DETAIL_SCALED");
		NativeFieldInfoPtr__CLEARCOAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_CLEARCOAT");
		NativeFieldInfoPtr__CLEARCOATMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_CLEARCOATMAP");
		NativeFieldInfoPtr_DEBUG_DISPLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DEBUG_DISPLAY");
		NativeFieldInfoPtr_LOD_FADE_CROSSFADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "LOD_FADE_CROSSFADE");
		NativeFieldInfoPtr_USE_UNITY_CROSSFADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "USE_UNITY_CROSSFADE");
		NativeFieldInfoPtr__EMISSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_EMISSION");
		NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_RECEIVE_SHADOWS_OFF");
		NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_SURFACE_TYPE_TRANSPARENT");
		NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_ALPHAPREMULTIPLY_ON");
		NativeFieldInfoPtr__ALPHAMODULATE_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_ALPHAMODULATE_ON");
		NativeFieldInfoPtr__NORMALMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_NORMALMAP");
		NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_ADD_PRECOMPUTED_VELOCITY");
		NativeFieldInfoPtr_EDITOR_VISUALIZATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "EDITOR_VISUALIZATION");
		NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "FoveatedRenderingNonUniformRaster");
		NativeFieldInfoPtr_DisableTexture2DXArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DisableTexture2DXArray");
		NativeFieldInfoPtr_BlitSingleSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "BlitSingleSlice");
		NativeFieldInfoPtr_XROcclusionMeshCombined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "XROcclusionMeshCombined");
		NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "SCREEN_COORD_OVERRIDE");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DOWNSAMPLING_SIZE_2");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DOWNSAMPLING_SIZE_4");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DOWNSAMPLING_SIZE_8");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "DOWNSAMPLING_SIZE_16");
		NativeFieldInfoPtr_EVALUATE_SH_MIXED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "EVALUATE_SH_MIXED");
		NativeFieldInfoPtr_EVALUATE_SH_VERTEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "EVALUATE_SH_VERTEX");
		NativeFieldInfoPtr_ProbeVolumeL1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ProbeVolumeL1");
		NativeFieldInfoPtr_ProbeVolumeL2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "ProbeVolumeL2");
		NativeFieldInfoPtr_USE_LEGACY_LIGHTMAPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "USE_LEGACY_LIGHTMAPS");
		NativeFieldInfoPtr__OUTPUT_DEPTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_OUTPUT_DEPTH");
		NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordStrings>.NativeClassPtr, "_ENABLE_ALPHA_OUTPUT");
	}

	public ShaderKeywordStrings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
