using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class ShaderGlobalKeywords : Il2CppSystem.Object
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

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBufferMRT3;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalNormalBlendHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_DecalLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_WriteRenderingLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScreenSpaceOcclusion;

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

	private static readonly System.IntPtr NativeFieldInfoPtr__OUTPUT_DEPTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_LinearToSRGBConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeShaderGlobalKeywords_Public_Static_Void_0;

	public unsafe static GlobalKeyword MainLightShadows
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadows, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadows, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword MainLightShadowCascades
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadowCascades, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadowCascades, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword MainLightShadowScreen
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainLightShadowScreen, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainLightShadowScreen, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword CastingPunctualLightShadow
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CastingPunctualLightShadow, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CastingPunctualLightShadow, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword AdditionalLightsVertex
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsVertex, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsVertex, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword AdditionalLightsPixel
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsPixel, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsPixel, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ForwardPlus
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ForwardPlus, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ForwardPlus, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword AdditionalLightShadows
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightShadows, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightShadows, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ReflectionProbeBoxProjection
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReflectionProbeBoxProjection, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReflectionProbeBoxProjection, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ReflectionProbeBlending
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReflectionProbeBlending, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReflectionProbeBlending, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword SoftShadows
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadows, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadows, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword SoftShadowsLow
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsLow, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsLow, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword SoftShadowsMedium
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsMedium, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsMedium, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword SoftShadowsHigh
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoftShadowsHigh, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoftShadowsHigh, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword MixedLightingSubtractive
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MixedLightingSubtractive, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MixedLightingSubtractive, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LightmapShadowMixing
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightmapShadowMixing, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightmapShadowMixing, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ShadowsShadowMask
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShadowsShadowMask, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShadowsShadowMask, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LightLayers
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightLayers, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightLayers, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword RenderPassEnabled
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RenderPassEnabled, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RenderPassEnabled, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword BillboardFaceCameraPos
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BillboardFaceCameraPos, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BillboardFaceCameraPos, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LightCookies
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LightCookies, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LightCookies, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DepthNoMsaa
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthNoMsaa, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthNoMsaa, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DepthMsaa2
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa2, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa2, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DepthMsaa4
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa4, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa4, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DepthMsaa8
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DepthMsaa8, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DepthMsaa8, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DBufferMRT1
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT1, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT1, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DBufferMRT2
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT2, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT2, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DBufferMRT3
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBufferMRT3, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBufferMRT3, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DecalNormalBlendLow
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendLow, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendLow, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DecalNormalBlendMedium
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendMedium, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendMedium, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DecalNormalBlendHigh
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalNormalBlendHigh, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalNormalBlendHigh, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DecalLayers
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DecalLayers, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DecalLayers, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword WriteRenderingLayers
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WriteRenderingLayers, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WriteRenderingLayers, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ScreenSpaceOcclusion
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ScreenSpaceOcclusion, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ScreenSpaceOcclusion, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _SPOT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SPOT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SPOT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DIRECTIONAL
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DIRECTIONAL, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DIRECTIONAL, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _POINT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__POINT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__POINT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DEFERRED_STENCIL
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_STENCIL, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_STENCIL, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DEFERRED_FIRST_LIGHT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DEFERRED_MAIN_LIGHT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _GBUFFER_NORMALS_OCT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__GBUFFER_NORMALS_OCT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__GBUFFER_NORMALS_OCT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DEFERRED_MIXED_LIGHTING
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LIGHTMAP_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIGHTMAP_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIGHTMAP_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DYNAMICLIGHTMAP_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _ALPHATEST_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHATEST_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHATEST_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DIRLIGHTMAP_COMBINED
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DETAIL_MULX2
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DETAIL_MULX2, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DETAIL_MULX2, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _DETAIL_SCALED
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DETAIL_SCALED, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DETAIL_SCALED, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _CLEARCOAT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CLEARCOAT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CLEARCOAT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _CLEARCOATMAP
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CLEARCOATMAP, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CLEARCOATMAP, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DEBUG_DISPLAY
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEBUG_DISPLAY, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEBUG_DISPLAY, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LOD_FADE_CROSSFADE
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOD_FADE_CROSSFADE, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOD_FADE_CROSSFADE, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword USE_UNITY_CROSSFADE
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_UNITY_CROSSFADE, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_UNITY_CROSSFADE, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _EMISSION
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__EMISSION, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__EMISSION, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _RECEIVE_SHADOWS_OFF
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _SURFACE_TYPE_TRANSPARENT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _ALPHAPREMULTIPLY_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _ALPHAMODULATE_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ALPHAMODULATE_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ALPHAMODULATE_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _NORMALMAP
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__NORMALMAP, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__NORMALMAP, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _ADD_PRECOMPUTED_VELOCITY
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword EDITOR_VISUALIZATION
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EDITOR_VISUALIZATION, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EDITOR_VISUALIZATION, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword FoveatedRenderingNonUniformRaster
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DisableTexture2DXArray
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword BlitSingleSlice
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BlitSingleSlice, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BlitSingleSlice, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword XROcclusionMeshCombined
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XROcclusionMeshCombined, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XROcclusionMeshCombined, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword SCREEN_COORD_OVERRIDE
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DOWNSAMPLING_SIZE_2
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DOWNSAMPLING_SIZE_4
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DOWNSAMPLING_SIZE_8
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword DOWNSAMPLING_SIZE_16
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword EVALUATE_SH_MIXED
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVALUATE_SH_MIXED, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVALUATE_SH_MIXED, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword EVALUATE_SH_VERTEX
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVALUATE_SH_VERTEX, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVALUATE_SH_VERTEX, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ProbeVolumeL1
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProbeVolumeL1, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProbeVolumeL1, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword ProbeVolumeL2
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProbeVolumeL2, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProbeVolumeL2, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _OUTPUT_DEPTH
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OUTPUT_DEPTH, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OUTPUT_DEPTH, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword LinearToSRGBConversion
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LinearToSRGBConversion, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LinearToSRGBConversion, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword _ENABLE_ALPHA_OUTPUT
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	static ShaderGlobalKeywords()
	{
		Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderGlobalKeywords");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr);
		NativeFieldInfoPtr_MainLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "MainLightShadows");
		NativeFieldInfoPtr_MainLightShadowCascades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "MainLightShadowCascades");
		NativeFieldInfoPtr_MainLightShadowScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "MainLightShadowScreen");
		NativeFieldInfoPtr_CastingPunctualLightShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "CastingPunctualLightShadow");
		NativeFieldInfoPtr_AdditionalLightsVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "AdditionalLightsVertex");
		NativeFieldInfoPtr_AdditionalLightsPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "AdditionalLightsPixel");
		NativeFieldInfoPtr_ForwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ForwardPlus");
		NativeFieldInfoPtr_AdditionalLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "AdditionalLightShadows");
		NativeFieldInfoPtr_ReflectionProbeBoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ReflectionProbeBoxProjection");
		NativeFieldInfoPtr_ReflectionProbeBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ReflectionProbeBlending");
		NativeFieldInfoPtr_SoftShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "SoftShadows");
		NativeFieldInfoPtr_SoftShadowsLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "SoftShadowsLow");
		NativeFieldInfoPtr_SoftShadowsMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "SoftShadowsMedium");
		NativeFieldInfoPtr_SoftShadowsHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "SoftShadowsHigh");
		NativeFieldInfoPtr_MixedLightingSubtractive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "MixedLightingSubtractive");
		NativeFieldInfoPtr_LightmapShadowMixing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LightmapShadowMixing");
		NativeFieldInfoPtr_ShadowsShadowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ShadowsShadowMask");
		NativeFieldInfoPtr_LightLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LightLayers");
		NativeFieldInfoPtr_RenderPassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "RenderPassEnabled");
		NativeFieldInfoPtr_BillboardFaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "BillboardFaceCameraPos");
		NativeFieldInfoPtr_LightCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LightCookies");
		NativeFieldInfoPtr_DepthNoMsaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DepthNoMsaa");
		NativeFieldInfoPtr_DepthMsaa2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DepthMsaa2");
		NativeFieldInfoPtr_DepthMsaa4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DepthMsaa4");
		NativeFieldInfoPtr_DepthMsaa8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DepthMsaa8");
		NativeFieldInfoPtr_DBufferMRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DBufferMRT1");
		NativeFieldInfoPtr_DBufferMRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DBufferMRT2");
		NativeFieldInfoPtr_DBufferMRT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DBufferMRT3");
		NativeFieldInfoPtr_DecalNormalBlendLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DecalNormalBlendLow");
		NativeFieldInfoPtr_DecalNormalBlendMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DecalNormalBlendMedium");
		NativeFieldInfoPtr_DecalNormalBlendHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DecalNormalBlendHigh");
		NativeFieldInfoPtr_DecalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DecalLayers");
		NativeFieldInfoPtr_WriteRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "WriteRenderingLayers");
		NativeFieldInfoPtr_ScreenSpaceOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ScreenSpaceOcclusion");
		NativeFieldInfoPtr__SPOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_SPOT");
		NativeFieldInfoPtr__DIRECTIONAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DIRECTIONAL");
		NativeFieldInfoPtr__POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_POINT");
		NativeFieldInfoPtr__DEFERRED_STENCIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DEFERRED_STENCIL");
		NativeFieldInfoPtr__DEFERRED_FIRST_LIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DEFERRED_FIRST_LIGHT");
		NativeFieldInfoPtr__DEFERRED_MAIN_LIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DEFERRED_MAIN_LIGHT");
		NativeFieldInfoPtr__GBUFFER_NORMALS_OCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_GBUFFER_NORMALS_OCT");
		NativeFieldInfoPtr__DEFERRED_MIXED_LIGHTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DEFERRED_MIXED_LIGHTING");
		NativeFieldInfoPtr_LIGHTMAP_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LIGHTMAP_ON");
		NativeFieldInfoPtr_DYNAMICLIGHTMAP_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DYNAMICLIGHTMAP_ON");
		NativeFieldInfoPtr__ALPHATEST_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_ALPHATEST_ON");
		NativeFieldInfoPtr_DIRLIGHTMAP_COMBINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DIRLIGHTMAP_COMBINED");
		NativeFieldInfoPtr__DETAIL_MULX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DETAIL_MULX2");
		NativeFieldInfoPtr__DETAIL_SCALED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_DETAIL_SCALED");
		NativeFieldInfoPtr__CLEARCOAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_CLEARCOAT");
		NativeFieldInfoPtr__CLEARCOATMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_CLEARCOATMAP");
		NativeFieldInfoPtr_DEBUG_DISPLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DEBUG_DISPLAY");
		NativeFieldInfoPtr_LOD_FADE_CROSSFADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LOD_FADE_CROSSFADE");
		NativeFieldInfoPtr_USE_UNITY_CROSSFADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "USE_UNITY_CROSSFADE");
		NativeFieldInfoPtr__EMISSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_EMISSION");
		NativeFieldInfoPtr__RECEIVE_SHADOWS_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_RECEIVE_SHADOWS_OFF");
		NativeFieldInfoPtr__SURFACE_TYPE_TRANSPARENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_SURFACE_TYPE_TRANSPARENT");
		NativeFieldInfoPtr__ALPHAPREMULTIPLY_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_ALPHAPREMULTIPLY_ON");
		NativeFieldInfoPtr__ALPHAMODULATE_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_ALPHAMODULATE_ON");
		NativeFieldInfoPtr__NORMALMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_NORMALMAP");
		NativeFieldInfoPtr__ADD_PRECOMPUTED_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_ADD_PRECOMPUTED_VELOCITY");
		NativeFieldInfoPtr_EDITOR_VISUALIZATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "EDITOR_VISUALIZATION");
		NativeFieldInfoPtr_FoveatedRenderingNonUniformRaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "FoveatedRenderingNonUniformRaster");
		NativeFieldInfoPtr_DisableTexture2DXArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DisableTexture2DXArray");
		NativeFieldInfoPtr_BlitSingleSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "BlitSingleSlice");
		NativeFieldInfoPtr_XROcclusionMeshCombined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "XROcclusionMeshCombined");
		NativeFieldInfoPtr_SCREEN_COORD_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "SCREEN_COORD_OVERRIDE");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DOWNSAMPLING_SIZE_2");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DOWNSAMPLING_SIZE_4");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DOWNSAMPLING_SIZE_8");
		NativeFieldInfoPtr_DOWNSAMPLING_SIZE_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "DOWNSAMPLING_SIZE_16");
		NativeFieldInfoPtr_EVALUATE_SH_MIXED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "EVALUATE_SH_MIXED");
		NativeFieldInfoPtr_EVALUATE_SH_VERTEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "EVALUATE_SH_VERTEX");
		NativeFieldInfoPtr_ProbeVolumeL1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ProbeVolumeL1");
		NativeFieldInfoPtr_ProbeVolumeL2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "ProbeVolumeL2");
		NativeFieldInfoPtr__OUTPUT_DEPTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_OUTPUT_DEPTH");
		NativeFieldInfoPtr_LinearToSRGBConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "LinearToSRGBConversion");
		NativeFieldInfoPtr__ENABLE_ALPHA_OUTPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, "_ENABLE_ALPHA_OUTPUT");
		NativeMethodInfoPtr_InitializeShaderGlobalKeywords_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderGlobalKeywords>.NativeClassPtr, 100666116);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108149, RefRangeEnd = 1108150, XrefRangeStart = 1107449, XrefRangeEnd = 1108149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeShaderGlobalKeywords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeShaderGlobalKeywords_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ShaderGlobalKeywords(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
