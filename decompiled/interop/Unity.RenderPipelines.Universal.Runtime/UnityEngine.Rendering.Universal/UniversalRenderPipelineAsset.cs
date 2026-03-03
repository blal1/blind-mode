using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineAsset : RenderPipelineAsset<UniversalRenderPipeline>
{
	public static class Strings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_notURPRenderer;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwardPlusMissing;

		public unsafe static string notURPRenderer
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notURPRenderer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notURPRenderer, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string forwardPlusMissing
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forwardPlusMissing, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forwardPlusMissing, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static Strings()
		{
			Il2CppClassPointerStore<Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "Strings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strings>.NativeClassPtr);
			NativeFieldInfoPtr_notURPRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "notURPRenderer");
			NativeFieldInfoPtr_forwardPlusMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "forwardPlusMissing");
		}

		public Strings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class TextureResources : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blueNoise64LTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_bayerMatrixTex;

		private static readonly System.IntPtr NativeMethodInfoPtr_NeedsReload_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Texture2D blueNoise64LTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueNoise64LTex);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueNoise64LTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture2D bayerMatrixTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bayerMatrixTex);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bayerMatrixTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static TextureResources()
		{
			Il2CppClassPointerStore<TextureResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "TextureResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureResources>.NativeClassPtr);
			NativeFieldInfoPtr_blueNoise64LTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResources>.NativeClassPtr, "blueNoise64LTex");
			NativeFieldInfoPtr_bayerMatrixTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResources>.NativeClassPtr, "bayerMatrixTex");
			NativeMethodInfoPtr_NeedsReload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResources>.NativeClassPtr, 100663507);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResources>.NativeClassPtr, 100663508);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076315, XrefRangeEnd = 1076319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedsReload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureResources>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TextureResources(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Renderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LastVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AssetVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AssetPreviousVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultRendererIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequireDepthTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequireOpaqueTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OpaqueDownsampling;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsTerrainHoles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsHDR;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HDRColorBufferPrecision;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MSAA;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpscalingFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FsrOverrideSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FsrSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableLODCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODCrossFadeDitheringType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShEvalMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightProbeSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeVolumeMemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeVolumeBlendingMemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportProbeVolumeGPUStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportProbeVolumeDiskStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportProbeVolumeScenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportProbeVolumeScenarioBlending;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeVolumeSHBands;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightRenderingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightShadowsSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightShadowmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsRenderingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsPerObjectLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowsSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReflectionProbeBlending;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReflectionProbeBoxProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCascadeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cascade2Split;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cascade3Split;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Cascade4Split;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CascadeBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowDepthBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowNormalBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SoftShadowsSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ConservativeEnclosingSphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NumIterationsEnclosingSphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SoftShadowQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsCookieFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseSRPBatcher;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsDynamicBatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MixedLightingSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsLightCookies;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsLightLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StoreActionsOptimization;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseAdaptivePerformance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradingLutSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowPostProcessAlphaOutput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseFastSRGBLinearConversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportDataDrivenLensFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GPUResidentDrawerMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SmallMeshScreenPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GPUResidentDrawerEnableOcclusionCullingInCameras;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalShadowsSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalShadowsAtlasResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxPixelLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowAtlasResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VolumeFrameworkUpdateMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VolumeProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MinLutSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxLutSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShadowCascadeMinCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShadowCascadeMaxCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierMedium;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Names;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Values;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LightCookieFormatList;

	private static readonly System.IntPtr NativeFieldInfoPtr_apvScenesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShaderVariantLogLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCascades;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Textures;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_IGPUResidentRenderPipeline_get_gpuResidentDrawerSettings_Private_Virtual_Final_New_get_GPUResidentDrawerSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rendererDataList_Public_get_ReadOnlySpan_1_ScriptableRendererData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderers_Public_get_ReadOnlySpan_1_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBuiltinRendererData_Public_ScriptableRendererData_RendererType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyRenderers_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyRenderer_Private_Void_byref_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderer_Public_ScriptableRenderer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scriptableRendererData_Internal_get_ScriptableRendererData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsCookieFormat_Internal_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsCookieResolution_Internal_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rendererIndexList_Internal_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsCameraDepthTexture_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsCameraDepthTexture_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsCameraOpaqueTexture_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsCameraOpaqueTexture_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_opaqueDownsampling_Public_get_Downsampling_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsTerrainHoles_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_storeActionsOptimization_Public_get_StoreActionsOptimization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_storeActionsOptimization_Public_set_Void_StoreActionsOptimization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsHDR_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrColorBufferPrecision_Public_get_HDRColorBufferPrecision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hdrColorBufferPrecision_Public_set_Void_HDRColorBufferPrecision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_msaaSampleCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_msaaSampleCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderScale_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableLODCrossFade_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodCrossFadeDitheringType_Public_get_LODCrossFadeDitheringType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upscalingFilter_Public_get_UpscalingFilterSelection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_upscalingFilter_Public_set_Void_UpscalingFilterSelection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fsrOverrideSharpness_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fsrOverrideSharpness_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fsrSharpness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fsrSharpness_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shEvalMode_Public_get_ShEvalMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shEvalMode_Internal_set_Void_ShEvalMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightProbeSystem_Public_get_LightProbeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightProbeSystem_Internal_set_Void_LightProbeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeVolumeMemoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_probeVolumeMemoryBudget_Internal_set_Void_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeVolumeBlendingMemoryBudget_Public_get_ProbeVolumeBlendingTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_probeVolumeBlendingMemoryBudget_Internal_set_Void_ProbeVolumeBlendingTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolumeStreaming_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportProbeVolumeStreaming_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolumeGPUStreaming_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportProbeVolumeGPUStreaming_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolumeDiskStreaming_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportProbeVolumeDiskStreaming_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolumeScenarios_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportProbeVolumeScenarios_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolumeScenarioBlending_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportProbeVolumeScenarioBlending_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeVolumeSHBands_Public_get_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_probeVolumeSHBands_Internal_set_Void_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightRenderingMode_Public_get_LightRenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mainLightRenderingMode_Internal_set_Void_LightRenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsMainLightShadows_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowmapResolution_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mainLightShadowmapResolution_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsRenderingMode_Public_get_LightRenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalLightsRenderingMode_Internal_set_Void_LightRenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxAdditionalLightsCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxAdditionalLightsCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsAdditionalLightShadows_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowmapResolution_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalLightsShadowmapResolution_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierLow_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierLow_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierMedium_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierMedium_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierHigh_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierHigh_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditionalLightsShadowResolution_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflectionProbeBlending_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldUseReflectionProbeBlending_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflectionProbeBoxProjection_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowDistance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowCascadeCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCascadeCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cascade2Split_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cascade2Split_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cascade3Split_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cascade3Split_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cascade4Split_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cascade4Split_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cascadeBorder_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cascadeBorder_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowDepthBias_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowDepthBias_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsSoftShadows_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_softShadowQuality_Internal_get_SoftShadowQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_softShadowQuality_Internal_set_Void_SoftShadowQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsDynamicBatching_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsLightCookies_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsLightLayers_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useRenderingLayers_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Public_get_VolumeFrameworkUpdateMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeProfile_Public_get_VolumeProfile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_volumeProfile_Public_set_Void_VolumeProfile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugLevel_Public_get_PipelineDebugLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useSRPBatcher_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useSRPBatcher_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableRenderGraph_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableRenderGraphChanged_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorGradingMode_Public_get_ColorGradingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_colorGradingMode_Public_set_Void_ColorGradingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorGradingLutSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_colorGradingLutSize_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowPostProcessAlphaOutput_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useAdaptivePerformance_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useAdaptivePerformance_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_conservativeEnclosingSphere_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numIterationsEnclosingSphere_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightLayerMaskNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuResidentDrawerMode_Public_Virtual_Final_New_get_GPUResidentDrawerMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gpuResidentDrawerMode_Public_Virtual_Final_New_set_Void_GPUResidentDrawerMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_Final_New_Boolean_byref_String_byref_LogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_smallMeshScreenPercentage_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateShadowBias_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePerObjectLights_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRenderScale_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRendererDataList_Internal_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRendererData_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportProbeVolume_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSHBands_Public_Virtual_Final_New_get_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Virtual_Final_New_get_ProbeVolumeSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isStpUsed_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_DefaultMaterialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_decalMaterial_Public_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_get_ShaderVariantLogLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_set_Void_ShaderVariantLogLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowCascadeOption_Public_get_ShadowCascadesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCascadeOption_Public_set_Void_ShadowCascadesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textures_Public_get_TextureResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<ScriptableRenderer> m_Renderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_LastVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LastVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LastVersion, (void*)(&value));
		}
	}

	public unsafe int k_AssetVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_AssetVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_AssetVersion)) = value;
		}
	}

	public unsafe int k_AssetPreviousVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_AssetPreviousVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_AssetPreviousVersion)) = value;
		}
	}

	public unsafe RendererType m_RendererType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererType);
			return *(RendererType*)num;
		}
		set
		{
			*(RendererType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererType)) = value;
		}
	}

	public unsafe ScriptableRendererData m_RendererData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRendererData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<ScriptableRendererData> m_RendererDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableRendererData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererDataList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_DefaultRendererIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultRendererIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultRendererIndex)) = value;
		}
	}

	public unsafe bool m_RequireDepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequireDepthTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequireDepthTexture)) = value;
		}
	}

	public unsafe bool m_RequireOpaqueTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequireOpaqueTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequireOpaqueTexture)) = value;
		}
	}

	public unsafe Downsampling m_OpaqueDownsampling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueDownsampling);
			return *(Downsampling*)num;
		}
		set
		{
			*(Downsampling*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueDownsampling)) = value;
		}
	}

	public unsafe bool m_SupportsTerrainHoles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsTerrainHoles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsTerrainHoles)) = value;
		}
	}

	public unsafe bool m_SupportsHDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsHDR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsHDR)) = value;
		}
	}

	public unsafe HDRColorBufferPrecision m_HDRColorBufferPrecision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRColorBufferPrecision);
			return *(HDRColorBufferPrecision*)num;
		}
		set
		{
			*(HDRColorBufferPrecision*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRColorBufferPrecision)) = value;
		}
	}

	public unsafe MsaaQuality m_MSAA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MSAA);
			return *(MsaaQuality*)num;
		}
		set
		{
			*(MsaaQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MSAA)) = value;
		}
	}

	public unsafe float m_RenderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderScale)) = value;
		}
	}

	public unsafe UpscalingFilterSelection m_UpscalingFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpscalingFilter);
			return *(UpscalingFilterSelection*)num;
		}
		set
		{
			*(UpscalingFilterSelection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpscalingFilter)) = value;
		}
	}

	public unsafe bool m_FsrOverrideSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FsrOverrideSharpness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FsrOverrideSharpness)) = value;
		}
	}

	public unsafe float m_FsrSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FsrSharpness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FsrSharpness)) = value;
		}
	}

	public unsafe bool m_EnableLODCrossFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableLODCrossFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableLODCrossFade)) = value;
		}
	}

	public unsafe LODCrossFadeDitheringType m_LODCrossFadeDitheringType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODCrossFadeDitheringType);
			return *(LODCrossFadeDitheringType*)num;
		}
		set
		{
			*(LODCrossFadeDitheringType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODCrossFadeDitheringType)) = value;
		}
	}

	public unsafe ShEvalMode m_ShEvalMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShEvalMode);
			return *(ShEvalMode*)num;
		}
		set
		{
			*(ShEvalMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShEvalMode)) = value;
		}
	}

	public unsafe LightProbeSystem m_LightProbeSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightProbeSystem);
			return *(LightProbeSystem*)num;
		}
		set
		{
			*(LightProbeSystem*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightProbeSystem)) = value;
		}
	}

	public unsafe ProbeVolumeTextureMemoryBudget m_ProbeVolumeMemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeMemoryBudget);
			return *(ProbeVolumeTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeMemoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeBlendingTextureMemoryBudget m_ProbeVolumeBlendingMemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeBlendingMemoryBudget);
			return *(ProbeVolumeBlendingTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeBlendingTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeBlendingMemoryBudget)) = value;
		}
	}

	public unsafe bool m_SupportProbeVolumeGPUStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeGPUStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeGPUStreaming)) = value;
		}
	}

	public unsafe bool m_SupportProbeVolumeDiskStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeDiskStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeDiskStreaming)) = value;
		}
	}

	public unsafe bool m_SupportProbeVolumeScenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeScenarios);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeScenarios)) = value;
		}
	}

	public unsafe bool m_SupportProbeVolumeScenarioBlending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeScenarioBlending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportProbeVolumeScenarioBlending)) = value;
		}
	}

	public unsafe ProbeVolumeSHBands m_ProbeVolumeSHBands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeSHBands);
			return *(ProbeVolumeSHBands*)num;
		}
		set
		{
			*(ProbeVolumeSHBands*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeVolumeSHBands)) = value;
		}
	}

	public unsafe LightRenderingMode m_MainLightRenderingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightRenderingMode);
			return *(LightRenderingMode*)num;
		}
		set
		{
			*(LightRenderingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightRenderingMode)) = value;
		}
	}

	public unsafe bool m_MainLightShadowsSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowsSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowsSupported)) = value;
		}
	}

	public unsafe ShadowResolution m_MainLightShadowmapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowmapResolution);
			return *(ShadowResolution*)num;
		}
		set
		{
			*(ShadowResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowmapResolution)) = value;
		}
	}

	public unsafe LightRenderingMode m_AdditionalLightsRenderingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsRenderingMode);
			return *(LightRenderingMode*)num;
		}
		set
		{
			*(LightRenderingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsRenderingMode)) = value;
		}
	}

	public unsafe int m_AdditionalLightsPerObjectLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsPerObjectLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsPerObjectLimit)) = value;
		}
	}

	public unsafe bool m_AdditionalLightShadowsSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowsSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowsSupported)) = value;
		}
	}

	public unsafe ShadowResolution m_AdditionalLightsShadowmapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowmapResolution);
			return *(ShadowResolution*)num;
		}
		set
		{
			*(ShadowResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowmapResolution)) = value;
		}
	}

	public unsafe int m_AdditionalLightsShadowResolutionTierLow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierLow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierLow)) = value;
		}
	}

	public unsafe int m_AdditionalLightsShadowResolutionTierMedium
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierMedium);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierMedium)) = value;
		}
	}

	public unsafe int m_AdditionalLightsShadowResolutionTierHigh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierHigh);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierHigh)) = value;
		}
	}

	public unsafe bool m_ReflectionProbeBlending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeBlending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeBlending)) = value;
		}
	}

	public unsafe bool m_ReflectionProbeBoxProjection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeBoxProjection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeBoxProjection)) = value;
		}
	}

	public unsafe float m_ShadowDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowDistance)) = value;
		}
	}

	public unsafe int m_ShadowCascadeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowCascadeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowCascadeCount)) = value;
		}
	}

	public unsafe float m_Cascade2Split
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade2Split);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade2Split)) = value;
		}
	}

	public unsafe Vector2 m_Cascade3Split
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade3Split);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade3Split)) = value;
		}
	}

	public unsafe Vector3 m_Cascade4Split
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade4Split);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cascade4Split)) = value;
		}
	}

	public unsafe float m_CascadeBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CascadeBorder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CascadeBorder)) = value;
		}
	}

	public unsafe float m_ShadowDepthBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowDepthBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowDepthBias)) = value;
		}
	}

	public unsafe float m_ShadowNormalBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowNormalBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowNormalBias)) = value;
		}
	}

	public unsafe bool m_SoftShadowsSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowsSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowsSupported)) = value;
		}
	}

	public unsafe bool m_ConservativeEnclosingSphere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConservativeEnclosingSphere);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConservativeEnclosingSphere)) = value;
		}
	}

	public unsafe int m_NumIterationsEnclosingSphere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumIterationsEnclosingSphere);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumIterationsEnclosingSphere)) = value;
		}
	}

	public unsafe SoftShadowQuality m_SoftShadowQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowQuality);
			return *(SoftShadowQuality*)num;
		}
		set
		{
			*(SoftShadowQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowQuality)) = value;
		}
	}

	public unsafe LightCookieResolution m_AdditionalLightsCookieResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieResolution);
			return *(LightCookieResolution*)num;
		}
		set
		{
			*(LightCookieResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieResolution)) = value;
		}
	}

	public unsafe LightCookieFormat m_AdditionalLightsCookieFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieFormat);
			return *(LightCookieFormat*)num;
		}
		set
		{
			*(LightCookieFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsCookieFormat)) = value;
		}
	}

	public unsafe bool m_UseSRPBatcher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseSRPBatcher);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseSRPBatcher)) = value;
		}
	}

	public unsafe bool m_SupportsDynamicBatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsDynamicBatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsDynamicBatching)) = value;
		}
	}

	public unsafe bool m_MixedLightingSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixedLightingSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixedLightingSupported)) = value;
		}
	}

	public unsafe bool m_SupportsLightCookies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsLightCookies);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsLightCookies)) = value;
		}
	}

	public unsafe bool m_SupportsLightLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsLightLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsLightLayers)) = value;
		}
	}

	public unsafe PipelineDebugLevel m_DebugLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugLevel);
			return *(PipelineDebugLevel*)num;
		}
		set
		{
			*(PipelineDebugLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugLevel)) = value;
		}
	}

	public unsafe StoreActionsOptimization m_StoreActionsOptimization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StoreActionsOptimization);
			return *(StoreActionsOptimization*)num;
		}
		set
		{
			*(StoreActionsOptimization*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StoreActionsOptimization)) = value;
		}
	}

	public unsafe bool m_UseAdaptivePerformance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseAdaptivePerformance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseAdaptivePerformance)) = value;
		}
	}

	public unsafe ColorGradingMode m_ColorGradingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradingMode);
			return *(ColorGradingMode*)num;
		}
		set
		{
			*(ColorGradingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradingMode)) = value;
		}
	}

	public unsafe int m_ColorGradingLutSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradingLutSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradingLutSize)) = value;
		}
	}

	public unsafe bool m_AllowPostProcessAlphaOutput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowPostProcessAlphaOutput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowPostProcessAlphaOutput)) = value;
		}
	}

	public unsafe bool m_UseFastSRGBLinearConversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFastSRGBLinearConversion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFastSRGBLinearConversion)) = value;
		}
	}

	public unsafe bool m_SupportDataDrivenLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDataDrivenLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDataDrivenLensFlare)) = value;
		}
	}

	public unsafe bool m_SupportScreenSpaceLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare)) = value;
		}
	}

	public unsafe GPUResidentDrawerMode m_GPUResidentDrawerMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUResidentDrawerMode);
			return *(GPUResidentDrawerMode*)num;
		}
		set
		{
			*(GPUResidentDrawerMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUResidentDrawerMode)) = value;
		}
	}

	public unsafe float m_SmallMeshScreenPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SmallMeshScreenPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SmallMeshScreenPercentage)) = value;
		}
	}

	public unsafe bool m_GPUResidentDrawerEnableOcclusionCullingInCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUResidentDrawerEnableOcclusionCullingInCameras);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUResidentDrawerEnableOcclusionCullingInCameras)) = value;
		}
	}

	public unsafe ShadowQuality m_ShadowType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowType);
			return *(ShadowQuality*)num;
		}
		set
		{
			*(ShadowQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowType)) = value;
		}
	}

	public unsafe bool m_LocalShadowsSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalShadowsSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalShadowsSupported)) = value;
		}
	}

	public unsafe ShadowResolution m_LocalShadowsAtlasResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalShadowsAtlasResolution);
			return *(ShadowResolution*)num;
		}
		set
		{
			*(ShadowResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalShadowsAtlasResolution)) = value;
		}
	}

	public unsafe int m_MaxPixelLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxPixelLights);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxPixelLights)) = value;
		}
	}

	public unsafe ShadowResolution m_ShadowAtlasResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowAtlasResolution);
			return *(ShadowResolution*)num;
		}
		set
		{
			*(ShadowResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowAtlasResolution)) = value;
		}
	}

	public unsafe VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VolumeFrameworkUpdateMode);
			return *(VolumeFrameworkUpdateMode*)num;
		}
		set
		{
			*(VolumeFrameworkUpdateMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VolumeFrameworkUpdateMode)) = value;
		}
	}

	public unsafe VolumeProfile m_VolumeProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VolumeProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VolumeProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_MinLutSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinLutSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinLutSize, (void*)(&value));
		}
	}

	public unsafe static int k_MaxLutSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxLutSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxLutSize, (void*)(&value));
		}
	}

	public unsafe static int k_ShadowCascadeMinCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShadowCascadeMinCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShadowCascadeMinCount, (void*)(&value));
		}
	}

	public unsafe static int k_ShadowCascadeMaxCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShadowCascadeMaxCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShadowCascadeMaxCount, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsDefaultShadowResolutionTierLow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierLow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierLow, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsDefaultShadowResolutionTierMedium
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierMedium, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierMedium, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsDefaultShadowResolutionTierHigh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierHigh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierHigh, (void*)(&value));
		}
	}

	public unsafe static Il2CppStringArray s_Names
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Names, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Names, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> s_Values
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Values, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Values, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<GraphicsFormat>> s_LightCookieFormatList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LightCookieFormatList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<GraphicsFormat>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LightCookieFormatList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeSceneData apvScenesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvScenesData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvScenesData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Shader m_DefaultShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_ShaderVariantLogLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariantLogLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariantLogLevel)) = value;
		}
	}

	public unsafe ShadowCascadesOption m_ShadowCascades
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowCascades);
			return *(ShadowCascadesOption*)num;
		}
		set
		{
			*(ShadowCascadesOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowCascades)) = value;
		}
	}

	public unsafe TextureResources m_Textures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Textures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureResources>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Textures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual GPUResidentDrawerSettings UnityEngine_002ERendering_002EIGPUResidentRenderPipeline_002EgpuResidentDrawerSettings
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076319, XrefRangeEnd = 1076327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Rendering_IGPUResidentRenderPipeline_get_gpuResidentDrawerSettings_Private_Virtual_Final_New_get_GPUResidentDrawerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GPUResidentDrawerSettings(pointer);
		}
	}

	public unsafe Il2CppSystem.ReadOnlySpan<ScriptableRendererData> rendererDataList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076327, XrefRangeEnd = 1076330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendererDataList_Public_get_ReadOnlySpan_1_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.ReadOnlySpan<ScriptableRendererData>(pointer);
		}
	}

	public unsafe Il2CppSystem.ReadOnlySpan<ScriptableRenderer> renderers
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1076333, RefRangeEnd = 1076335, XrefRangeStart = 1076330, XrefRangeEnd = 1076333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderers_Public_get_ReadOnlySpan_1_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.ReadOnlySpan<ScriptableRenderer>(pointer);
		}
	}

	public unsafe virtual bool isImmediateModeSupported
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ScriptableRenderer scriptableRenderer
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1076405, RefRangeEnd = 1076409, XrefRangeStart = 1076389, XrefRangeEnd = 1076405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
		}
	}

	public unsafe ScriptableRendererData scriptableRendererData
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076434, XrefRangeEnd = 1076438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scriptableRendererData_Internal_get_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRendererData>(intPtr2) : null;
		}
	}

	public unsafe GraphicsFormat additionalLightsCookieFormat
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1076465, RefRangeEnd = 1076468, XrefRangeStart = 1076438, XrefRangeEnd = 1076465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsCookieFormat_Internal_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector2Int additionalLightsCookieResolution
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1076468, RefRangeEnd = 1076471, XrefRangeStart = 1076468, XrefRangeEnd = 1076468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsCookieResolution_Internal_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<int> rendererIndexList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076471, XrefRangeEnd = 1076475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendererIndexList_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
	}

	public unsafe bool supportsCameraDepthTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsCameraDepthTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsCameraDepthTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsCameraOpaqueTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsCameraOpaqueTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsCameraOpaqueTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Downsampling opaqueDownsampling
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 174524, RefRangeEnd = 174528, XrefRangeStart = 174524, XrefRangeEnd = 174528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueDownsampling_Public_get_Downsampling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Downsampling*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsTerrainHoles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsTerrainHoles_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe StoreActionsOptimization storeActionsOptimization
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storeActionsOptimization_Public_get_StoreActionsOptimization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StoreActionsOptimization*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_storeActionsOptimization_Public_set_Void_StoreActionsOptimization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsHDR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe HDRColorBufferPrecision hdrColorBufferPrecision
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180373, RefRangeEnd = 180378, XrefRangeStart = 180373, XrefRangeEnd = 180378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrColorBufferPrecision_Public_get_HDRColorBufferPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HDRColorBufferPrecision*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hdrColorBufferPrecision_Public_set_Void_HDRColorBufferPrecision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int msaaSampleCount
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148973, RefRangeEnd = 148983, XrefRangeStart = 148973, XrefRangeEnd = 148983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_msaaSampleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_msaaSampleCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float renderScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076475, XrefRangeEnd = 1076480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enableLODCrossFade
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableLODCrossFade_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LODCrossFadeDitheringType lodCrossFadeDitheringType
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241445, RefRangeEnd = 241447, XrefRangeStart = 241445, XrefRangeEnd = 241447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lodCrossFadeDitheringType_Public_get_LODCrossFadeDitheringType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LODCrossFadeDitheringType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UpscalingFilterSelection upscalingFilter
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87098, RefRangeEnd = 87099, XrefRangeStart = 87098, XrefRangeEnd = 87099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upscalingFilter_Public_get_UpscalingFilterSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UpscalingFilterSelection*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upscalingFilter_Public_set_Void_UpscalingFilterSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool fsrOverrideSharpness
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fsrOverrideSharpness_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fsrOverrideSharpness_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float fsrSharpness
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fsrSharpness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fsrSharpness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ShEvalMode shEvalMode
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42195, RefRangeEnd = 42198, XrefRangeStart = 42195, XrefRangeEnd = 42198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shEvalMode_Public_get_ShEvalMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShEvalMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shEvalMode_Internal_set_Void_ShEvalMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightProbeSystem lightProbeSystem
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33830, RefRangeEnd = 33833, XrefRangeStart = 33830, XrefRangeEnd = 33833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightProbeSystem_Public_get_LightProbeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightProbeSystem*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33833, RefRangeEnd = 33834, XrefRangeStart = 33833, XrefRangeEnd = 33834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightProbeSystem_Internal_set_Void_LightProbeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeTextureMemoryBudget probeVolumeMemoryBudget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeVolumeMemoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeTextureMemoryBudget*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probeVolumeMemoryBudget_Internal_set_Void_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeBlendingTextureMemoryBudget probeVolumeBlendingMemoryBudget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeVolumeBlendingMemoryBudget_Public_get_ProbeVolumeBlendingTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeBlendingTextureMemoryBudget*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probeVolumeBlendingMemoryBudget_Internal_set_Void_ProbeVolumeBlendingTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportProbeVolumeStreaming
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolumeStreaming_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportProbeVolumeStreaming_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportProbeVolumeGPUStreaming
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolumeGPUStreaming_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportProbeVolumeGPUStreaming_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportProbeVolumeDiskStreaming
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolumeDiskStreaming_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportProbeVolumeDiskStreaming_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportProbeVolumeScenarios
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolumeScenarios_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportProbeVolumeScenarios_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportProbeVolumeScenarioBlending
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolumeScenarioBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportProbeVolumeScenarioBlending_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeSHBands probeVolumeSHBands
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeVolumeSHBands_Public_get_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeSHBands*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probeVolumeSHBands_Internal_set_Void_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightRenderingMode mainLightRenderingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightRenderingMode_Public_get_LightRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightRenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mainLightRenderingMode_Internal_set_Void_LightRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsMainLightShadows
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsMainLightShadows_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int mainLightShadowmapResolution
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 178480, RefRangeEnd = 178492, XrefRangeStart = 178480, XrefRangeEnd = 178492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowmapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mainLightShadowmapResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightRenderingMode additionalLightsRenderingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsRenderingMode_Public_get_LightRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightRenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalLightsRenderingMode_Internal_set_Void_LightRenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int maxAdditionalLightsCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxAdditionalLightsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076480, XrefRangeEnd = 1076489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxAdditionalLightsCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsAdditionalLightShadows
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317191, RefRangeEnd = 317192, XrefRangeStart = 317191, XrefRangeEnd = 317192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsAdditionalLightShadows_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int additionalLightsShadowmapResolution
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowmapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalLightsShadowmapResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int additionalLightsShadowResolutionTierLow
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51672, RefRangeEnd = 51673, XrefRangeStart = 51672, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierLow_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierLow_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int additionalLightsShadowResolutionTierMedium
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierMedium_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierMedium_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int additionalLightsShadowResolutionTierHigh
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierHigh_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596246, RefRangeEnd = 596247, XrefRangeStart = 596246, XrefRangeEnd = 596247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierHigh_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool reflectionProbeBlending
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflectionProbeBlending_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool reflectionProbeBoxProjection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflectionProbeBoxProjection_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float shadowDistance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int shadowCascadeCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowCascadeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1076503, RefRangeEnd = 1076506, XrefRangeStart = 1076503, XrefRangeEnd = 1076503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCascadeCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float cascade2Split
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cascade2Split_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cascade2Split_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 cascade3Split
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cascade3Split_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cascade3Split_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 cascade4Split
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cascade4Split_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cascade4Split_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float cascadeBorder
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cascadeBorder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cascadeBorder_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float shadowDepthBias
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowDepthBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076506, XrefRangeEnd = 1076510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowDepthBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float shadowNormalBias
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076510, XrefRangeEnd = 1076514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsSoftShadows
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsSoftShadows_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SoftShadowQuality softShadowQuality
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_softShadowQuality_Internal_get_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SoftShadowQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_softShadowQuality_Internal_set_Void_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsDynamicBatching
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsDynamicBatching_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsMixedLighting
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsLightCookies
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsLightCookies_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsLightLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsLightLayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool useRenderingLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useRenderingLayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Public_get_VolumeFrameworkUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(VolumeFrameworkUpdateMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe VolumeProfile volumeProfile
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeProfile_Public_get_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_volumeProfile_Public_set_Void_VolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe PipelineDebugLevel debugLevel
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugLevel_Public_get_PipelineDebugLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PipelineDebugLevel*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool useSRPBatcher
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useSRPBatcher_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useSRPBatcher_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enableRenderGraph
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076514, XrefRangeEnd = 1076527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableRenderGraph_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ColorGradingMode colorGradingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorGradingMode_Public_get_ColorGradingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorGradingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_colorGradingMode_Public_set_Void_ColorGradingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int colorGradingLutSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorGradingLutSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_colorGradingLutSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allowPostProcessAlphaOutput
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowPostProcessAlphaOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool useFastSRGBLinearConversion
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportScreenSpaceLensFlare
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportDataDrivenLensFlare
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool useAdaptivePerformance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useAdaptivePerformance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useAdaptivePerformance_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool conservativeEnclosingSphere
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_conservativeEnclosingSphere_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int numIterationsEnclosingSphere
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numIterationsEnclosingSphere_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override string renderPipelineShaderTag
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076527, XrefRangeEnd = 1076529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe override Il2CppStringArray renderingLayerMaskNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076529, XrefRangeEnd = 1076533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe override Il2CppStringArray prefixedRenderingLayerMaskNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076533, XrefRangeEnd = 1076536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray lightLayerMaskNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076536, XrefRangeEnd = 1076539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightLayerMaskNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe virtual GPUResidentDrawerMode gpuResidentDrawerMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuResidentDrawerMode_Public_Virtual_Final_New_get_GPUResidentDrawerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GPUResidentDrawerMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gpuResidentDrawerMode_Public_Virtual_Final_New_set_Void_GPUResidentDrawerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool gpuResidentDrawerEnableOcclusionCullingInCameras
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float smallMeshScreenPercentage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076549, XrefRangeEnd = 1076553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_smallMeshScreenPercentage_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool supportProbeVolume
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportProbeVolume_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual ProbeVolumeSHBands maxSHBands
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxSHBands_Public_Virtual_Final_New_get_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeSHBands*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual ProbeVolumeSceneData probeVolumeSceneData
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Virtual_Final_New_get_ProbeVolumeSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr2) : null;
		}
	}

	public unsafe virtual bool isStpUsed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isStpUsed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override Material defaultMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Material defaultParticleMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Material defaultLineMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Material defaultTerrainMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Material default2DMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Material default2DMaskMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe Material decalMaterial
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_decalMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe override Shader defaultShader
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076597, XrefRangeEnd = 1076607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	public unsafe override Shader terrainDetailLitShader
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076607, XrefRangeEnd = 1076613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	public unsafe override Shader terrainDetailGrassShader
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076613, XrefRangeEnd = 1076619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	public unsafe override Shader terrainDetailGrassBillboardShader
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076619, XrefRangeEnd = 1076625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
	}

	public unsafe ShaderVariantLogLevel shaderVariantLogLevel
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076625, XrefRangeEnd = 1076631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_get_ShaderVariantLogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShaderVariantLogLevel*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076631, XrefRangeEnd = 1076639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_set_Void_ShaderVariantLogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ShadowCascadesOption shadowCascadeOption
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowCascadeOption_Public_get_ShadowCascadesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShadowCascadesOption*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076639, XrefRangeEnd = 1076648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCascadeOption_Public_set_Void_ShadowCascadesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureResources textures
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076648, XrefRangeEnd = 1076653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textures_Public_get_TextureResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureResources>(intPtr2) : null;
		}
	}

	static UniversalRenderPipelineAsset()
	{
		Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr);
		NativeFieldInfoPtr_m_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_Renderers");
		NativeFieldInfoPtr_k_LastVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_LastVersion");
		NativeFieldInfoPtr_k_AssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_AssetVersion");
		NativeFieldInfoPtr_k_AssetPreviousVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_AssetPreviousVersion");
		NativeFieldInfoPtr_m_RendererType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RendererType");
		NativeFieldInfoPtr_m_RendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RendererData");
		NativeFieldInfoPtr_m_RendererDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RendererDataList");
		NativeFieldInfoPtr_m_DefaultRendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_DefaultRendererIndex");
		NativeFieldInfoPtr_m_RequireDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RequireDepthTexture");
		NativeFieldInfoPtr_m_RequireOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RequireOpaqueTexture");
		NativeFieldInfoPtr_m_OpaqueDownsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_OpaqueDownsampling");
		NativeFieldInfoPtr_m_SupportsTerrainHoles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportsTerrainHoles");
		NativeFieldInfoPtr_m_SupportsHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportsHDR");
		NativeFieldInfoPtr_m_HDRColorBufferPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_HDRColorBufferPrecision");
		NativeFieldInfoPtr_m_MSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MSAA");
		NativeFieldInfoPtr_m_RenderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_RenderScale");
		NativeFieldInfoPtr_m_UpscalingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_UpscalingFilter");
		NativeFieldInfoPtr_m_FsrOverrideSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_FsrOverrideSharpness");
		NativeFieldInfoPtr_m_FsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_FsrSharpness");
		NativeFieldInfoPtr_m_EnableLODCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_EnableLODCrossFade");
		NativeFieldInfoPtr_m_LODCrossFadeDitheringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_LODCrossFadeDitheringType");
		NativeFieldInfoPtr_m_ShEvalMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShEvalMode");
		NativeFieldInfoPtr_m_LightProbeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_LightProbeSystem");
		NativeFieldInfoPtr_m_ProbeVolumeMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ProbeVolumeMemoryBudget");
		NativeFieldInfoPtr_m_ProbeVolumeBlendingMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ProbeVolumeBlendingMemoryBudget");
		NativeFieldInfoPtr_m_SupportProbeVolumeGPUStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportProbeVolumeGPUStreaming");
		NativeFieldInfoPtr_m_SupportProbeVolumeDiskStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportProbeVolumeDiskStreaming");
		NativeFieldInfoPtr_m_SupportProbeVolumeScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportProbeVolumeScenarios");
		NativeFieldInfoPtr_m_SupportProbeVolumeScenarioBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportProbeVolumeScenarioBlending");
		NativeFieldInfoPtr_m_ProbeVolumeSHBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ProbeVolumeSHBands");
		NativeFieldInfoPtr_m_MainLightRenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MainLightRenderingMode");
		NativeFieldInfoPtr_m_MainLightShadowsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MainLightShadowsSupported");
		NativeFieldInfoPtr_m_MainLightShadowmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MainLightShadowmapResolution");
		NativeFieldInfoPtr_m_AdditionalLightsRenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsRenderingMode");
		NativeFieldInfoPtr_m_AdditionalLightsPerObjectLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsPerObjectLimit");
		NativeFieldInfoPtr_m_AdditionalLightShadowsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightShadowsSupported");
		NativeFieldInfoPtr_m_AdditionalLightsShadowmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsShadowmapResolution");
		NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsShadowResolutionTierLow");
		NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsShadowResolutionTierMedium");
		NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTierHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsShadowResolutionTierHigh");
		NativeFieldInfoPtr_m_ReflectionProbeBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ReflectionProbeBlending");
		NativeFieldInfoPtr_m_ReflectionProbeBoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ReflectionProbeBoxProjection");
		NativeFieldInfoPtr_m_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowDistance");
		NativeFieldInfoPtr_m_ShadowCascadeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowCascadeCount");
		NativeFieldInfoPtr_m_Cascade2Split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_Cascade2Split");
		NativeFieldInfoPtr_m_Cascade3Split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_Cascade3Split");
		NativeFieldInfoPtr_m_Cascade4Split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_Cascade4Split");
		NativeFieldInfoPtr_m_CascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_CascadeBorder");
		NativeFieldInfoPtr_m_ShadowDepthBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowDepthBias");
		NativeFieldInfoPtr_m_ShadowNormalBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowNormalBias");
		NativeFieldInfoPtr_m_SoftShadowsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SoftShadowsSupported");
		NativeFieldInfoPtr_m_ConservativeEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ConservativeEnclosingSphere");
		NativeFieldInfoPtr_m_NumIterationsEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_NumIterationsEnclosingSphere");
		NativeFieldInfoPtr_m_SoftShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SoftShadowQuality");
		NativeFieldInfoPtr_m_AdditionalLightsCookieResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsCookieResolution");
		NativeFieldInfoPtr_m_AdditionalLightsCookieFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AdditionalLightsCookieFormat");
		NativeFieldInfoPtr_m_UseSRPBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_UseSRPBatcher");
		NativeFieldInfoPtr_m_SupportsDynamicBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportsDynamicBatching");
		NativeFieldInfoPtr_m_MixedLightingSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MixedLightingSupported");
		NativeFieldInfoPtr_m_SupportsLightCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportsLightCookies");
		NativeFieldInfoPtr_m_SupportsLightLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportsLightLayers");
		NativeFieldInfoPtr_m_DebugLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_DebugLevel");
		NativeFieldInfoPtr_m_StoreActionsOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_StoreActionsOptimization");
		NativeFieldInfoPtr_m_UseAdaptivePerformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_UseAdaptivePerformance");
		NativeFieldInfoPtr_m_ColorGradingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ColorGradingMode");
		NativeFieldInfoPtr_m_ColorGradingLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ColorGradingLutSize");
		NativeFieldInfoPtr_m_AllowPostProcessAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_AllowPostProcessAlphaOutput");
		NativeFieldInfoPtr_m_UseFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_UseFastSRGBLinearConversion");
		NativeFieldInfoPtr_m_SupportDataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportDataDrivenLensFlare");
		NativeFieldInfoPtr_m_SupportScreenSpaceLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SupportScreenSpaceLensFlare");
		NativeFieldInfoPtr_m_GPUResidentDrawerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_GPUResidentDrawerMode");
		NativeFieldInfoPtr_m_SmallMeshScreenPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_SmallMeshScreenPercentage");
		NativeFieldInfoPtr_m_GPUResidentDrawerEnableOcclusionCullingInCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_GPUResidentDrawerEnableOcclusionCullingInCameras");
		NativeFieldInfoPtr_m_ShadowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowType");
		NativeFieldInfoPtr_m_LocalShadowsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_LocalShadowsSupported");
		NativeFieldInfoPtr_m_LocalShadowsAtlasResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_LocalShadowsAtlasResolution");
		NativeFieldInfoPtr_m_MaxPixelLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_MaxPixelLights");
		NativeFieldInfoPtr_m_ShadowAtlasResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowAtlasResolution");
		NativeFieldInfoPtr_m_VolumeFrameworkUpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_VolumeFrameworkUpdateMode");
		NativeFieldInfoPtr_m_VolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_VolumeProfile");
		NativeFieldInfoPtr_k_MinLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_MinLutSize");
		NativeFieldInfoPtr_k_MaxLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_MaxLutSize");
		NativeFieldInfoPtr_k_ShadowCascadeMinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_ShadowCascadeMinCount");
		NativeFieldInfoPtr_k_ShadowCascadeMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "k_ShadowCascadeMaxCount");
		NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "AdditionalLightsDefaultShadowResolutionTierLow");
		NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "AdditionalLightsDefaultShadowResolutionTierMedium");
		NativeFieldInfoPtr_AdditionalLightsDefaultShadowResolutionTierHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "AdditionalLightsDefaultShadowResolutionTierHigh");
		NativeFieldInfoPtr_s_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "s_Names");
		NativeFieldInfoPtr_s_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "s_Values");
		NativeFieldInfoPtr_s_LightCookieFormatList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "s_LightCookieFormatList");
		NativeFieldInfoPtr_apvScenesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "apvScenesData");
		NativeFieldInfoPtr_m_DefaultShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_DefaultShader");
		NativeFieldInfoPtr_m_ShaderVariantLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShaderVariantLogLevel");
		NativeFieldInfoPtr_m_ShadowCascades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_ShadowCascades");
		NativeFieldInfoPtr_m_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, "m_Textures");
		NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_UnityEngine_Rendering_IGPUResidentRenderPipeline_get_gpuResidentDrawerSettings_Private_Virtual_Final_New_get_GPUResidentDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_get_rendererDataList_Public_get_ReadOnlySpan_1_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_get_renderers_Public_get_ReadOnlySpan_1_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_LoadBuiltinRendererData_Public_ScriptableRendererData_RendererType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_DestroyRenderers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_DestroyRenderer_Private_Void_byref_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_CreateRenderers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_GetRenderer_Public_ScriptableRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_get_scriptableRendererData_Internal_get_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_get_additionalLightsCookieFormat_Internal_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_additionalLightsCookieResolution_Internal_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_rendererIndexList_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_get_supportsCameraDepthTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_set_supportsCameraDepthTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_get_supportsCameraOpaqueTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_supportsCameraOpaqueTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_opaqueDownsampling_Public_get_Downsampling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_get_supportsTerrainHoles_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_storeActionsOptimization_Public_get_StoreActionsOptimization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_set_storeActionsOptimization_Public_set_Void_StoreActionsOptimization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_supportsHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_get_hdrColorBufferPrecision_Public_get_HDRColorBufferPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_set_hdrColorBufferPrecision_Public_set_Void_HDRColorBufferPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_get_msaaSampleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_set_msaaSampleCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_get_renderScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_set_renderScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_get_enableLODCrossFade_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_get_lodCrossFadeDitheringType_Public_get_LODCrossFadeDitheringType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_get_upscalingFilter_Public_get_UpscalingFilterSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_set_upscalingFilter_Public_set_Void_UpscalingFilterSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_get_fsrOverrideSharpness_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_set_fsrOverrideSharpness_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_get_fsrSharpness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_set_fsrSharpness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_get_shEvalMode_Public_get_ShEvalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_shEvalMode_Internal_set_Void_ShEvalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_get_lightProbeSystem_Public_get_LightProbeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_set_lightProbeSystem_Internal_set_Void_LightProbeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_probeVolumeMemoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_set_probeVolumeMemoryBudget_Internal_set_Void_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_get_probeVolumeBlendingMemoryBudget_Public_get_ProbeVolumeBlendingTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_set_probeVolumeBlendingMemoryBudget_Internal_set_Void_ProbeVolumeBlendingTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_get_supportProbeVolumeStreaming_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_supportProbeVolumeStreaming_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_supportProbeVolumeGPUStreaming_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_set_supportProbeVolumeGPUStreaming_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_get_supportProbeVolumeDiskStreaming_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_set_supportProbeVolumeDiskStreaming_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_get_supportProbeVolumeScenarios_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_set_supportProbeVolumeScenarios_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_get_supportProbeVolumeScenarioBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_set_supportProbeVolumeScenarioBlending_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_probeVolumeSHBands_Public_get_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_set_probeVolumeSHBands_Internal_set_Void_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_mainLightRenderingMode_Public_get_LightRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_set_mainLightRenderingMode_Internal_set_Void_LightRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_set_supportsMainLightShadows_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_get_mainLightShadowmapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_set_mainLightShadowmapResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_get_additionalLightsRenderingMode_Public_get_LightRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_set_additionalLightsRenderingMode_Internal_set_Void_LightRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_get_maxAdditionalLightsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_set_maxAdditionalLightsCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_set_supportsAdditionalLightShadows_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_get_additionalLightsShadowmapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_set_additionalLightsShadowmapResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierLow_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierLow_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierMedium_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierMedium_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_additionalLightsShadowResolutionTierHigh_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_set_additionalLightsShadowResolutionTierHigh_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_GetAdditionalLightsShadowResolution_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_set_reflectionProbeBlending_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_ShouldUseReflectionProbeBlending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_set_reflectionProbeBoxProjection_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_get_shadowDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_get_shadowCascadeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_set_shadowCascadeCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_cascade2Split_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_set_cascade2Split_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_get_cascade3Split_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_set_cascade3Split_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_get_cascade4Split_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_set_cascade4Split_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_get_cascadeBorder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_set_cascadeBorder_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_get_shadowDepthBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_set_shadowDepthBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_set_shadowNormalBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_set_supportsSoftShadows_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_get_softShadowQuality_Internal_get_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_set_softShadowQuality_Internal_set_Void_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_get_supportsDynamicBatching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_set_supportsDynamicBatching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_get_supportsLightCookies_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_get_supportsLightLayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_get_useRenderingLayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Public_get_VolumeFrameworkUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_get_volumeProfile_Public_get_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_set_volumeProfile_Public_set_Void_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_get_debugLevel_Public_get_PipelineDebugLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_get_useSRPBatcher_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_set_useSRPBatcher_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_get_enableRenderGraph_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_OnEnableRenderGraphChanged_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_get_colorGradingMode_Public_get_ColorGradingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_set_colorGradingMode_Public_set_Void_ColorGradingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_get_colorGradingLutSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_set_colorGradingLutSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_get_allowPostProcessAlphaOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_get_useFastSRGBLinearConversion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_get_supportScreenSpaceLensFlare_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_get_supportDataDrivenLensFlare_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_get_useAdaptivePerformance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_set_useAdaptivePerformance_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_get_conservativeEnclosingSphere_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_get_numIterationsEnclosingSphere_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_get_lightLayerMaskNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_get_gpuResidentDrawerMode_Public_Virtual_Final_New_get_GPUResidentDrawerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_set_gpuResidentDrawerMode_Public_Virtual_Final_New_set_Void_GPUResidentDrawerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_get_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_set_gpuResidentDrawerEnableOcclusionCullingInCameras_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_Final_New_Boolean_byref_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_set_smallMeshScreenPercentage_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_ValidateShadowBias_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_ValidatePerObjectLights_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_ValidateRenderScale_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_ValidateRendererDataList_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_ValidateRendererData_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_get_supportProbeVolume_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_get_maxSHBands_Public_Virtual_Final_New_get_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_get_probeVolumeSceneData_Public_Virtual_Final_New_get_ProbeVolumeSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_get_isStpUsed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_GetMaterial_Private_Material_DefaultMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_get_decalMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_get_defaultShader_Public_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_get_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_set_Void_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_get_shadowCascadeOption_Public_get_ShadowCascadesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_set_shadowCascadeOption_Public_set_Void_ShadowCascadesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_get_textures_Public_get_TextureResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr, 100663504);
	}

	[CallerCount(0)]
	public unsafe bool IsAtLastVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076335, XrefRangeEnd = 1076336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableRendererData LoadBuiltinRendererData(RendererType type = RendererType.UniversalRenderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBuiltinRendererData_Public_ScriptableRendererData_RendererType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRendererData>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EnsureGlobalSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076336, XrefRangeEnd = 1076353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RenderPipeline CreatePipeline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1076356, RefRangeEnd = 1076360, XrefRangeStart = 1076353, XrefRangeEnd = 1076356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyRenderers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyRenderers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076360, XrefRangeEnd = 1076362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyRenderer(ref ScriptableRenderer renderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyRenderer_Private_Void_byref_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		renderer = ((intPtr4 == (System.IntPtr)0) ? null : new ScriptableRenderer(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076362, XrefRangeEnd = 1076364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1076387, RefRangeEnd = 1076389, XrefRangeStart = 1076364, XrefRangeEnd = 1076387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1076433, RefRangeEnd = 1076434, XrefRangeStart = 1076409, XrefRangeEnd = 1076433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableRenderer GetRenderer(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderer_Public_ScriptableRenderer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1076497, RefRangeEnd = 1076499, XrefRangeStart = 1076489, XrefRangeEnd = 1076497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&additionalLightsShadowResolutionTier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdditionalLightsShadowResolution_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1076499, RefRangeEnd = 1076503, XrefRangeStart = 1076499, XrefRangeEnd = 1076499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldUseReflectionProbeBlending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldUseReflectionProbeBlending_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnEnableRenderGraphChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnableRenderGraphChanged_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076539, XrefRangeEnd = 1076549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref severty);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Public_Virtual_Final_New_Boolean_byref_String_byref_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		message = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076553, XrefRangeEnd = 1076568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076568, XrefRangeEnd = 1076572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ValidateShadowBias(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateShadowBias_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076572, XrefRangeEnd = 1076581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ValidatePerObjectLights(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidatePerObjectLights_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076581, XrefRangeEnd = 1076586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ValidateRenderScale(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRenderScale_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076586, XrefRangeEnd = 1076592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateRendererDataList(bool partial = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&partial);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRendererDataList_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1076596, RefRangeEnd = 1076597, XrefRangeStart = 1076592, XrefRangeEnd = 1076596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateRendererData(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRendererData_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetMaterial(DefaultMaterialType materialType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&materialType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterial_Private_Material_DefaultMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076653, XrefRangeEnd = 1076670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRenderPipelineAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineAsset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRenderPipelineAsset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
