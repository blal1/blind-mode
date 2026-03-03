using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class QualitySettings : Object
{
	private delegate int get_pixelLightCountDelegate();

	private delegate void set_pixelLightCountDelegate(int value);

	private delegate ShadowQuality get_shadowsDelegate();

	private delegate void set_shadowsDelegate(ShadowQuality value);

	private delegate ShadowProjection get_shadowProjectionDelegate();

	private delegate void set_shadowProjectionDelegate(ShadowProjection value);

	private delegate int get_shadowCascadesDelegate();

	private delegate void set_shadowCascadesDelegate(int value);

	private delegate float get_shadowDistanceDelegate();

	private delegate void set_shadowDistanceDelegate(float value);

	private delegate ShadowResolution get_shadowResolutionDelegate();

	private delegate void set_shadowResolutionDelegate(ShadowResolution value);

	private delegate void set_shadowmaskModeDelegate(ShadowmaskMode value);

	private delegate float get_shadowNearPlaneOffsetDelegate();

	private delegate void set_shadowNearPlaneOffsetDelegate(float value);

	private delegate float get_shadowCascade2SplitDelegate();

	private delegate void set_shadowCascade2SplitDelegate(float value);

	private delegate void set_lodBiasDelegate(float value);

	private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

	private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

	private delegate int get_masterTextureLimitDelegate();

	private delegate void set_masterTextureLimitDelegate(int value);

	private delegate int get_globalTextureMipmapLimitDelegate();

	private delegate void set_globalTextureMipmapLimitDelegate(int value);

	private delegate void set_maximumLODLevelDelegate(int value);

	private delegate bool get_enableLODCrossFadeDelegate();

	private delegate int get_particleRaycastBudgetDelegate();

	private delegate void set_particleRaycastBudgetDelegate(int value);

	private delegate bool get_softParticlesDelegate();

	private delegate void set_softParticlesDelegate(bool value);

	private delegate bool get_softVegetationDelegate();

	private delegate void set_softVegetationDelegate(bool value);

	private delegate int get_vSyncCountDelegate();

	private delegate int get_realtimeGICPUUsageDelegate();

	private delegate void set_realtimeGICPUUsageDelegate(int value);

	private delegate int get_asyncUploadTimeSliceDelegate();

	private delegate void set_asyncUploadTimeSliceDelegate(int value);

	private delegate int get_asyncUploadBufferSizeDelegate();

	private delegate void set_asyncUploadBufferSizeDelegate(int value);

	private delegate bool get_asyncUploadPersistentBufferDelegate();

	private delegate void set_asyncUploadPersistentBufferDelegate(bool value);

	private delegate void SetLODSettingsDelegate(float lodBias, int maximumLODLevel, bool setDirty);

	private delegate bool get_realtimeReflectionProbesDelegate();

	private delegate void set_realtimeReflectionProbesDelegate(bool value);

	private delegate void set_billboardsFaceCameraPositionDelegate(bool value);

	private delegate bool get_useLegacyDetailDistributionDelegate();

	private delegate void set_useLegacyDetailDistributionDelegate(bool value);

	private delegate float get_resolutionScalingFixedDPIFactorDelegate();

	private delegate void set_resolutionScalingFixedDPIFactorDelegate(float value);

	private delegate TerrainQualityOverrides get_terrainQualityOverridesDelegate();

	private delegate void set_terrainQualityOverridesDelegate(TerrainQualityOverrides value);

	private delegate float get_terrainPixelErrorDelegate();

	private delegate void set_terrainPixelErrorDelegate(float value);

	private delegate float get_terrainDetailDensityScaleDelegate();

	private delegate void set_terrainDetailDensityScaleDelegate(float value);

	private delegate float get_terrainBasemapDistanceDelegate();

	private delegate void set_terrainBasemapDistanceDelegate(float value);

	private delegate float get_terrainDetailDistanceDelegate();

	private delegate void set_terrainDetailDistanceDelegate(float value);

	private delegate float get_terrainTreeDistanceDelegate();

	private delegate void set_terrainTreeDistanceDelegate(float value);

	private delegate float get_terrainBillboardStartDelegate();

	private delegate void set_terrainBillboardStartDelegate(float value);

	private delegate float get_terrainFadeLengthDelegate();

	private delegate void set_terrainFadeLengthDelegate(float value);

	private delegate float get_terrainMaxTreesDelegate();

	private delegate void set_terrainMaxTreesDelegate(float value);

	private delegate BlendWeights get_blendWeightsDelegate();

	private delegate void set_blendWeightsDelegate(BlendWeights value);

	private delegate SkinWeights get_skinWeightsDelegate();

	private delegate void set_skinWeightsDelegate(SkinWeights value);

	private delegate int get_countDelegate();

	private delegate int GetStrippedMaximumLODLevelDelegate();

	private delegate void SetStrippedMaximumLODLevelDelegate(int maximumLODLevel);

	private delegate bool get_streamingMipmapsActiveDelegate();

	private delegate void set_streamingMipmapsActiveDelegate(bool value);

	private delegate float get_streamingMipmapsMemoryBudgetDelegate();

	private delegate void set_streamingMipmapsMemoryBudgetDelegate(float value);

	private delegate int get_streamingMipmapsRenderersPerFrameDelegate();

	private delegate void set_streamingMipmapsRenderersPerFrameDelegate(int value);

	private delegate int get_streamingMipmapsMaxLevelReductionDelegate();

	private delegate void set_streamingMipmapsMaxLevelReductionDelegate(int value);

	private delegate bool get_streamingMipmapsAddAllCamerasDelegate();

	private delegate void set_streamingMipmapsAddAllCamerasDelegate(bool value);

	private delegate int get_streamingMipmapsMaxFileIORequestsDelegate();

	private delegate void set_streamingMipmapsMaxFileIORequestsDelegate(int value);

	private delegate int get_maxQueuedFramesDelegate();

	private delegate void set_maxQueuedFramesDelegate(int value);

	private delegate System.IntPtr get_namesDelegate();

	private delegate ColorSpace get_desiredColorSpaceDelegate();

	private delegate void get_shadowCascade4Split_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_shadowCascade4Split_InjectedDelegate([In] System.IntPtr value);

	private delegate System.IntPtr get_INTERNAL_renderPipeline_InjectedDelegate();

	private delegate void set_INTERNAL_renderPipeline_InjectedDelegate(System.IntPtr value);

	private delegate System.IntPtr InternalGetRenderPipelineAssetAt_InjectedDelegate(int index);

	private delegate System.IntPtr GetQualitySettings_InjectedDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_activeQualityLevelChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0;

	private static readonly get_pixelLightCountDelegate get_pixelLightCountDelegateField;

	private static readonly set_pixelLightCountDelegate set_pixelLightCountDelegateField;

	private static readonly get_shadowsDelegate get_shadowsDelegateField;

	private static readonly set_shadowsDelegate set_shadowsDelegateField;

	private static readonly get_shadowProjectionDelegate get_shadowProjectionDelegateField;

	private static readonly set_shadowProjectionDelegate set_shadowProjectionDelegateField;

	private static readonly get_shadowCascadesDelegate get_shadowCascadesDelegateField;

	private static readonly set_shadowCascadesDelegate set_shadowCascadesDelegateField;

	private static readonly get_shadowDistanceDelegate get_shadowDistanceDelegateField;

	private static readonly set_shadowDistanceDelegate set_shadowDistanceDelegateField;

	private static readonly get_shadowResolutionDelegate get_shadowResolutionDelegateField;

	private static readonly set_shadowResolutionDelegate set_shadowResolutionDelegateField;

	private static readonly set_shadowmaskModeDelegate set_shadowmaskModeDelegateField;

	private static readonly get_shadowNearPlaneOffsetDelegate get_shadowNearPlaneOffsetDelegateField;

	private static readonly set_shadowNearPlaneOffsetDelegate set_shadowNearPlaneOffsetDelegateField;

	private static readonly get_shadowCascade2SplitDelegate get_shadowCascade2SplitDelegateField;

	private static readonly set_shadowCascade2SplitDelegate set_shadowCascade2SplitDelegateField;

	private static readonly set_lodBiasDelegate set_lodBiasDelegateField;

	private static readonly get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

	private static readonly set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

	private static readonly get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

	private static readonly set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

	private static readonly get_globalTextureMipmapLimitDelegate get_globalTextureMipmapLimitDelegateField;

	private static readonly set_globalTextureMipmapLimitDelegate set_globalTextureMipmapLimitDelegateField;

	private static readonly set_maximumLODLevelDelegate set_maximumLODLevelDelegateField;

	private static readonly get_enableLODCrossFadeDelegate get_enableLODCrossFadeDelegateField;

	private static readonly get_particleRaycastBudgetDelegate get_particleRaycastBudgetDelegateField;

	private static readonly set_particleRaycastBudgetDelegate set_particleRaycastBudgetDelegateField;

	private static readonly get_softParticlesDelegate get_softParticlesDelegateField;

	private static readonly set_softParticlesDelegate set_softParticlesDelegateField;

	private static readonly get_softVegetationDelegate get_softVegetationDelegateField;

	private static readonly set_softVegetationDelegate set_softVegetationDelegateField;

	private static readonly get_vSyncCountDelegate get_vSyncCountDelegateField;

	private static readonly get_realtimeGICPUUsageDelegate get_realtimeGICPUUsageDelegateField;

	private static readonly set_realtimeGICPUUsageDelegate set_realtimeGICPUUsageDelegateField;

	private static readonly get_asyncUploadTimeSliceDelegate get_asyncUploadTimeSliceDelegateField;

	private static readonly set_asyncUploadTimeSliceDelegate set_asyncUploadTimeSliceDelegateField;

	private static readonly get_asyncUploadBufferSizeDelegate get_asyncUploadBufferSizeDelegateField;

	private static readonly set_asyncUploadBufferSizeDelegate set_asyncUploadBufferSizeDelegateField;

	private static readonly get_asyncUploadPersistentBufferDelegate get_asyncUploadPersistentBufferDelegateField;

	private static readonly set_asyncUploadPersistentBufferDelegate set_asyncUploadPersistentBufferDelegateField;

	private static readonly SetLODSettingsDelegate SetLODSettingsDelegateField;

	private static readonly get_realtimeReflectionProbesDelegate get_realtimeReflectionProbesDelegateField;

	private static readonly set_realtimeReflectionProbesDelegate set_realtimeReflectionProbesDelegateField;

	private static readonly set_billboardsFaceCameraPositionDelegate set_billboardsFaceCameraPositionDelegateField;

	private static readonly get_useLegacyDetailDistributionDelegate get_useLegacyDetailDistributionDelegateField;

	private static readonly set_useLegacyDetailDistributionDelegate set_useLegacyDetailDistributionDelegateField;

	private static readonly get_resolutionScalingFixedDPIFactorDelegate get_resolutionScalingFixedDPIFactorDelegateField;

	private static readonly set_resolutionScalingFixedDPIFactorDelegate set_resolutionScalingFixedDPIFactorDelegateField;

	private static readonly get_terrainQualityOverridesDelegate get_terrainQualityOverridesDelegateField;

	private static readonly set_terrainQualityOverridesDelegate set_terrainQualityOverridesDelegateField;

	private static readonly get_terrainPixelErrorDelegate get_terrainPixelErrorDelegateField;

	private static readonly set_terrainPixelErrorDelegate set_terrainPixelErrorDelegateField;

	private static readonly get_terrainDetailDensityScaleDelegate get_terrainDetailDensityScaleDelegateField;

	private static readonly set_terrainDetailDensityScaleDelegate set_terrainDetailDensityScaleDelegateField;

	private static readonly get_terrainBasemapDistanceDelegate get_terrainBasemapDistanceDelegateField;

	private static readonly set_terrainBasemapDistanceDelegate set_terrainBasemapDistanceDelegateField;

	private static readonly get_terrainDetailDistanceDelegate get_terrainDetailDistanceDelegateField;

	private static readonly set_terrainDetailDistanceDelegate set_terrainDetailDistanceDelegateField;

	private static readonly get_terrainTreeDistanceDelegate get_terrainTreeDistanceDelegateField;

	private static readonly set_terrainTreeDistanceDelegate set_terrainTreeDistanceDelegateField;

	private static readonly get_terrainBillboardStartDelegate get_terrainBillboardStartDelegateField;

	private static readonly set_terrainBillboardStartDelegate set_terrainBillboardStartDelegateField;

	private static readonly get_terrainFadeLengthDelegate get_terrainFadeLengthDelegateField;

	private static readonly set_terrainFadeLengthDelegate set_terrainFadeLengthDelegateField;

	private static readonly get_terrainMaxTreesDelegate get_terrainMaxTreesDelegateField;

	private static readonly set_terrainMaxTreesDelegate set_terrainMaxTreesDelegateField;

	private static readonly get_blendWeightsDelegate get_blendWeightsDelegateField;

	private static readonly set_blendWeightsDelegate set_blendWeightsDelegateField;

	private static readonly get_skinWeightsDelegate get_skinWeightsDelegateField;

	private static readonly set_skinWeightsDelegate set_skinWeightsDelegateField;

	private static readonly get_countDelegate get_countDelegateField;

	private static readonly GetStrippedMaximumLODLevelDelegate GetStrippedMaximumLODLevelDelegateField;

	private static readonly SetStrippedMaximumLODLevelDelegate SetStrippedMaximumLODLevelDelegateField;

	private static readonly get_streamingMipmapsActiveDelegate get_streamingMipmapsActiveDelegateField;

	private static readonly set_streamingMipmapsActiveDelegate set_streamingMipmapsActiveDelegateField;

	private static readonly get_streamingMipmapsMemoryBudgetDelegate get_streamingMipmapsMemoryBudgetDelegateField;

	private static readonly set_streamingMipmapsMemoryBudgetDelegate set_streamingMipmapsMemoryBudgetDelegateField;

	private static readonly get_streamingMipmapsRenderersPerFrameDelegate get_streamingMipmapsRenderersPerFrameDelegateField;

	private static readonly set_streamingMipmapsRenderersPerFrameDelegate set_streamingMipmapsRenderersPerFrameDelegateField;

	private static readonly get_streamingMipmapsMaxLevelReductionDelegate get_streamingMipmapsMaxLevelReductionDelegateField;

	private static readonly set_streamingMipmapsMaxLevelReductionDelegate set_streamingMipmapsMaxLevelReductionDelegateField;

	private static readonly get_streamingMipmapsAddAllCamerasDelegate get_streamingMipmapsAddAllCamerasDelegateField;

	private static readonly set_streamingMipmapsAddAllCamerasDelegate set_streamingMipmapsAddAllCamerasDelegateField;

	private static readonly get_streamingMipmapsMaxFileIORequestsDelegate get_streamingMipmapsMaxFileIORequestsDelegateField;

	private static readonly set_streamingMipmapsMaxFileIORequestsDelegate set_streamingMipmapsMaxFileIORequestsDelegateField;

	private static readonly get_maxQueuedFramesDelegate get_maxQueuedFramesDelegateField;

	private static readonly set_maxQueuedFramesDelegate set_maxQueuedFramesDelegateField;

	private static readonly get_namesDelegate get_namesDelegateField;

	private static readonly get_desiredColorSpaceDelegate get_desiredColorSpaceDelegateField;

	private static readonly get_shadowCascade4Split_InjectedDelegate get_shadowCascade4Split_InjectedDelegateField;

	private static readonly set_shadowCascade4Split_InjectedDelegate set_shadowCascade4Split_InjectedDelegateField;

	private static readonly get_INTERNAL_renderPipeline_InjectedDelegate get_INTERNAL_renderPipeline_InjectedDelegateField;

	private static readonly set_INTERNAL_renderPipeline_InjectedDelegate set_INTERNAL_renderPipeline_InjectedDelegateField;

	private static readonly InternalGetRenderPipelineAssetAt_InjectedDelegate InternalGetRenderPipelineAssetAt_InjectedDelegateField;

	private static readonly GetQualitySettings_InjectedDelegate GetQualitySettings_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<int, int> activeQualityLevelChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeQualityLevelChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeQualityLevelChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ShadowmaskMode shadowmaskMode
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173521, RefRangeEnd = 1173523, XrefRangeStart = 1173519, XrefRangeEnd = 1173521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShadowmaskMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_shadowmaskModeDelegateField(value);
		}
	}

	public unsafe static float lodBias
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173525, RefRangeEnd = 1173526, XrefRangeStart = 1173523, XrefRangeEnd = 1173525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_lodBiasDelegateField(value);
		}
	}

	public unsafe static int maximumLODLevel
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173528, RefRangeEnd = 1173529, XrefRangeStart = 1173526, XrefRangeEnd = 1173528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_maximumLODLevelDelegateField(value);
		}
	}

	public unsafe static bool enableLODCrossFade
	{
		get
		{
			return get_enableLODCrossFadeDelegateField();
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173531, RefRangeEnd = 1173532, XrefRangeStart = 1173529, XrefRangeEnd = 1173531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int vSyncCount
	{
		get
		{
			return get_vSyncCountDelegateField();
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173534, RefRangeEnd = 1173537, XrefRangeStart = 1173532, XrefRangeEnd = 1173534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int antiAliasing
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173539, RefRangeEnd = 1173542, XrefRangeStart = 1173537, XrefRangeEnd = 1173539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173544, RefRangeEnd = 1173545, XrefRangeStart = 1173542, XrefRangeEnd = 1173544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool billboardsFaceCameraPosition
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173547, RefRangeEnd = 1173549, XrefRangeStart = 1173545, XrefRangeEnd = 1173547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_billboardsFaceCameraPositionDelegateField(value);
		}
	}

	public unsafe static ColorSpace activeColorSpace
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1173557, RefRangeEnd = 1173578, XrefRangeStart = 1173555, XrefRangeEnd = 1173557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static QualityLevel currentLevel
	{
		get
		{
			return (QualityLevel)GetQualityLevel();
		}
		set
		{
			SetQualityLevel((int)value, applyExpensiveChanges: true);
		}
	}

	public static int pixelLightCount
	{
		get
		{
			return get_pixelLightCountDelegateField();
		}
		set
		{
			set_pixelLightCountDelegateField(value);
		}
	}

	public static ShadowQuality shadows
	{
		get
		{
			return get_shadowsDelegateField();
		}
		set
		{
			set_shadowsDelegateField(value);
		}
	}

	public static ShadowProjection shadowProjection
	{
		get
		{
			return get_shadowProjectionDelegateField();
		}
		set
		{
			set_shadowProjectionDelegateField(value);
		}
	}

	public static int shadowCascades
	{
		get
		{
			return get_shadowCascadesDelegateField();
		}
		set
		{
			set_shadowCascadesDelegateField(value);
		}
	}

	public static float shadowDistance
	{
		get
		{
			return get_shadowDistanceDelegateField();
		}
		set
		{
			set_shadowDistanceDelegateField(value);
		}
	}

	public static ShadowResolution shadowResolution
	{
		get
		{
			return get_shadowResolutionDelegateField();
		}
		set
		{
			set_shadowResolutionDelegateField(value);
		}
	}

	public static float shadowNearPlaneOffset
	{
		get
		{
			return get_shadowNearPlaneOffsetDelegateField();
		}
		set
		{
			set_shadowNearPlaneOffsetDelegateField(value);
		}
	}

	public static float shadowCascade2Split
	{
		get
		{
			return get_shadowCascade2SplitDelegateField();
		}
		set
		{
			set_shadowCascade2SplitDelegateField(value);
		}
	}

	public static Vector3 shadowCascade4Split
	{
		get
		{
			get_shadowCascade4Split_Injected(out var ret);
			return ret;
		}
		set
		{
			set_shadowCascade4Split_Injected(ref value);
		}
	}

	public static AnisotropicFiltering anisotropicFiltering
	{
		get
		{
			return get_anisotropicFilteringDelegateField();
		}
		set
		{
			set_anisotropicFilteringDelegateField(value);
		}
	}

	public static int masterTextureLimit
	{
		get
		{
			return get_masterTextureLimitDelegateField();
		}
		set
		{
			set_masterTextureLimitDelegateField(value);
		}
	}

	public static int globalTextureMipmapLimit
	{
		get
		{
			return get_globalTextureMipmapLimitDelegateField();
		}
		set
		{
			set_globalTextureMipmapLimitDelegateField(value);
		}
	}

	public static int particleRaycastBudget
	{
		get
		{
			return get_particleRaycastBudgetDelegateField();
		}
		set
		{
			set_particleRaycastBudgetDelegateField(value);
		}
	}

	public static bool softParticles
	{
		get
		{
			return get_softParticlesDelegateField();
		}
		set
		{
			set_softParticlesDelegateField(value);
		}
	}

	public static bool softVegetation
	{
		get
		{
			return get_softVegetationDelegateField();
		}
		set
		{
			set_softVegetationDelegateField(value);
		}
	}

	public static int realtimeGICPUUsage
	{
		get
		{
			return get_realtimeGICPUUsageDelegateField();
		}
		set
		{
			set_realtimeGICPUUsageDelegateField(value);
		}
	}

	public static int asyncUploadTimeSlice
	{
		get
		{
			return get_asyncUploadTimeSliceDelegateField();
		}
		set
		{
			set_asyncUploadTimeSliceDelegateField(value);
		}
	}

	public static int asyncUploadBufferSize
	{
		get
		{
			return get_asyncUploadBufferSizeDelegateField();
		}
		set
		{
			set_asyncUploadBufferSizeDelegateField(value);
		}
	}

	public static bool asyncUploadPersistentBuffer
	{
		get
		{
			return get_asyncUploadPersistentBufferDelegateField();
		}
		set
		{
			set_asyncUploadPersistentBufferDelegateField(value);
		}
	}

	public static bool realtimeReflectionProbes
	{
		get
		{
			return get_realtimeReflectionProbesDelegateField();
		}
		set
		{
			set_realtimeReflectionProbesDelegateField(value);
		}
	}

	public static bool useLegacyDetailDistribution
	{
		get
		{
			return get_useLegacyDetailDistributionDelegateField();
		}
		set
		{
			set_useLegacyDetailDistributionDelegateField(value);
		}
	}

	public static float resolutionScalingFixedDPIFactor
	{
		get
		{
			return get_resolutionScalingFixedDPIFactorDelegateField();
		}
		set
		{
			set_resolutionScalingFixedDPIFactorDelegateField(value);
		}
	}

	public static TerrainQualityOverrides terrainQualityOverrides
	{
		get
		{
			return get_terrainQualityOverridesDelegateField();
		}
		set
		{
			set_terrainQualityOverridesDelegateField(value);
		}
	}

	public static float terrainPixelError
	{
		get
		{
			return get_terrainPixelErrorDelegateField();
		}
		set
		{
			set_terrainPixelErrorDelegateField(value);
		}
	}

	public static float terrainDetailDensityScale
	{
		get
		{
			return get_terrainDetailDensityScaleDelegateField();
		}
		set
		{
			set_terrainDetailDensityScaleDelegateField(value);
		}
	}

	public static float terrainBasemapDistance
	{
		get
		{
			return get_terrainBasemapDistanceDelegateField();
		}
		set
		{
			set_terrainBasemapDistanceDelegateField(value);
		}
	}

	public static float terrainDetailDistance
	{
		get
		{
			return get_terrainDetailDistanceDelegateField();
		}
		set
		{
			set_terrainDetailDistanceDelegateField(value);
		}
	}

	public static float terrainTreeDistance
	{
		get
		{
			return get_terrainTreeDistanceDelegateField();
		}
		set
		{
			set_terrainTreeDistanceDelegateField(value);
		}
	}

	public static float terrainBillboardStart
	{
		get
		{
			return get_terrainBillboardStartDelegateField();
		}
		set
		{
			set_terrainBillboardStartDelegateField(value);
		}
	}

	public static float terrainFadeLength
	{
		get
		{
			return get_terrainFadeLengthDelegateField();
		}
		set
		{
			set_terrainFadeLengthDelegateField(value);
		}
	}

	public static float terrainMaxTrees
	{
		get
		{
			return get_terrainMaxTreesDelegateField();
		}
		set
		{
			set_terrainMaxTreesDelegateField(value);
		}
	}

	public static ScriptableObject INTERNAL_renderPipeline
	{
		get
		{
			return Unmarshal.UnmarshalUnityObject<ScriptableObject>(get_INTERNAL_renderPipeline_Injected());
		}
		set
		{
			set_INTERNAL_renderPipeline_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public static RenderPipelineAsset renderPipeline
	{
		get
		{
			return ((Il2CppObjectBase)INTERNAL_renderPipeline).TryCast<RenderPipelineAsset>();
		}
		set
		{
			INTERNAL_renderPipeline = value;
		}
	}

	public static BlendWeights blendWeights
	{
		get
		{
			return get_blendWeightsDelegateField();
		}
		set
		{
			set_blendWeightsDelegateField(value);
		}
	}

	public static SkinWeights skinWeights
	{
		get
		{
			return get_skinWeightsDelegateField();
		}
		set
		{
			set_skinWeightsDelegateField(value);
		}
	}

	public static int count => get_countDelegateField();

	public static bool streamingMipmapsActive
	{
		get
		{
			return get_streamingMipmapsActiveDelegateField();
		}
		set
		{
			set_streamingMipmapsActiveDelegateField(value);
		}
	}

	public static float streamingMipmapsMemoryBudget
	{
		get
		{
			return get_streamingMipmapsMemoryBudgetDelegateField();
		}
		set
		{
			set_streamingMipmapsMemoryBudgetDelegateField(value);
		}
	}

	public static int streamingMipmapsRenderersPerFrame
	{
		get
		{
			return get_streamingMipmapsRenderersPerFrameDelegateField();
		}
		set
		{
			set_streamingMipmapsRenderersPerFrameDelegateField(value);
		}
	}

	public static int streamingMipmapsMaxLevelReduction
	{
		get
		{
			return get_streamingMipmapsMaxLevelReductionDelegateField();
		}
		set
		{
			set_streamingMipmapsMaxLevelReductionDelegateField(value);
		}
	}

	public static bool streamingMipmapsAddAllCameras
	{
		get
		{
			return get_streamingMipmapsAddAllCamerasDelegateField();
		}
		set
		{
			set_streamingMipmapsAddAllCamerasDelegateField(value);
		}
	}

	public static int streamingMipmapsMaxFileIORequests
	{
		get
		{
			return get_streamingMipmapsMaxFileIORequestsDelegateField();
		}
		set
		{
			set_streamingMipmapsMaxFileIORequestsDelegateField(value);
		}
	}

	public static int maxQueuedFrames
	{
		get
		{
			return get_maxQueuedFramesDelegateField();
		}
		set
		{
			set_maxQueuedFramesDelegateField(value);
		}
	}

	public static Il2CppStringArray names
	{
		get
		{
			System.IntPtr intPtr = get_namesDelegateField();
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
	}

	public static ColorSpace desiredColorSpace => get_desiredColorSpaceDelegateField();

	static QualitySettings()
	{
		Il2CppClassPointerStore<QualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "QualitySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr);
		NativeFieldInfoPtr_activeQualityLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, "activeQualityLevelChanged");
		NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664468);
		NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664469);
		NativeMethodInfoPtr_get_shadowmaskMode_Public_Static_get_ShadowmaskMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664470);
		NativeMethodInfoPtr_get_lodBias_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664471);
		NativeMethodInfoPtr_get_maximumLODLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664472);
		NativeMethodInfoPtr_set_enableLODCrossFade_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664473);
		NativeMethodInfoPtr_set_vSyncCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664474);
		NativeMethodInfoPtr_get_antiAliasing_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664475);
		NativeMethodInfoPtr_set_antiAliasing_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_get_billboardsFaceCameraPosition_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr_get_activeColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySettings>.NativeClassPtr, 100664480);
		get_pixelLightCountDelegateField = IL2CPP.ResolveICall<get_pixelLightCountDelegate>("UnityEngine.QualitySettings::get_pixelLightCount");
		set_pixelLightCountDelegateField = IL2CPP.ResolveICall<set_pixelLightCountDelegate>("UnityEngine.QualitySettings::set_pixelLightCount");
		get_shadowsDelegateField = IL2CPP.ResolveICall<get_shadowsDelegate>("UnityEngine.QualitySettings::get_shadows");
		set_shadowsDelegateField = IL2CPP.ResolveICall<set_shadowsDelegate>("UnityEngine.QualitySettings::set_shadows");
		get_shadowProjectionDelegateField = IL2CPP.ResolveICall<get_shadowProjectionDelegate>("UnityEngine.QualitySettings::get_shadowProjection");
		set_shadowProjectionDelegateField = IL2CPP.ResolveICall<set_shadowProjectionDelegate>("UnityEngine.QualitySettings::set_shadowProjection");
		get_shadowCascadesDelegateField = IL2CPP.ResolveICall<get_shadowCascadesDelegate>("UnityEngine.QualitySettings::get_shadowCascades");
		set_shadowCascadesDelegateField = IL2CPP.ResolveICall<set_shadowCascadesDelegate>("UnityEngine.QualitySettings::set_shadowCascades");
		get_shadowDistanceDelegateField = IL2CPP.ResolveICall<get_shadowDistanceDelegate>("UnityEngine.QualitySettings::get_shadowDistance");
		set_shadowDistanceDelegateField = IL2CPP.ResolveICall<set_shadowDistanceDelegate>("UnityEngine.QualitySettings::set_shadowDistance");
		get_shadowResolutionDelegateField = IL2CPP.ResolveICall<get_shadowResolutionDelegate>("UnityEngine.QualitySettings::get_shadowResolution");
		set_shadowResolutionDelegateField = IL2CPP.ResolveICall<set_shadowResolutionDelegate>("UnityEngine.QualitySettings::set_shadowResolution");
		set_shadowmaskModeDelegateField = IL2CPP.ResolveICall<set_shadowmaskModeDelegate>("UnityEngine.QualitySettings::set_shadowmaskMode");
		get_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<get_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::get_shadowNearPlaneOffset");
		set_shadowNearPlaneOffsetDelegateField = IL2CPP.ResolveICall<set_shadowNearPlaneOffsetDelegate>("UnityEngine.QualitySettings::set_shadowNearPlaneOffset");
		get_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<get_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::get_shadowCascade2Split");
		set_shadowCascade2SplitDelegateField = IL2CPP.ResolveICall<set_shadowCascade2SplitDelegate>("UnityEngine.QualitySettings::set_shadowCascade2Split");
		set_lodBiasDelegateField = IL2CPP.ResolveICall<set_lodBiasDelegate>("UnityEngine.QualitySettings::set_lodBias");
		get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<get_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::get_anisotropicFiltering");
		set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<set_anisotropicFilteringDelegate>("UnityEngine.QualitySettings::set_anisotropicFiltering");
		get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<get_masterTextureLimitDelegate>("UnityEngine.QualitySettings::get_masterTextureLimit");
		set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<set_masterTextureLimitDelegate>("UnityEngine.QualitySettings::set_masterTextureLimit");
		get_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<get_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::get_globalTextureMipmapLimit");
		set_globalTextureMipmapLimitDelegateField = IL2CPP.ResolveICall<set_globalTextureMipmapLimitDelegate>("UnityEngine.QualitySettings::set_globalTextureMipmapLimit");
		set_maximumLODLevelDelegateField = IL2CPP.ResolveICall<set_maximumLODLevelDelegate>("UnityEngine.QualitySettings::set_maximumLODLevel");
		get_enableLODCrossFadeDelegateField = IL2CPP.ResolveICall<get_enableLODCrossFadeDelegate>("UnityEngine.QualitySettings::get_enableLODCrossFade");
		get_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<get_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::get_particleRaycastBudget");
		set_particleRaycastBudgetDelegateField = IL2CPP.ResolveICall<set_particleRaycastBudgetDelegate>("UnityEngine.QualitySettings::set_particleRaycastBudget");
		get_softParticlesDelegateField = IL2CPP.ResolveICall<get_softParticlesDelegate>("UnityEngine.QualitySettings::get_softParticles");
		set_softParticlesDelegateField = IL2CPP.ResolveICall<set_softParticlesDelegate>("UnityEngine.QualitySettings::set_softParticles");
		get_softVegetationDelegateField = IL2CPP.ResolveICall<get_softVegetationDelegate>("UnityEngine.QualitySettings::get_softVegetation");
		set_softVegetationDelegateField = IL2CPP.ResolveICall<set_softVegetationDelegate>("UnityEngine.QualitySettings::set_softVegetation");
		get_vSyncCountDelegateField = IL2CPP.ResolveICall<get_vSyncCountDelegate>("UnityEngine.QualitySettings::get_vSyncCount");
		get_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<get_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::get_realtimeGICPUUsage");
		set_realtimeGICPUUsageDelegateField = IL2CPP.ResolveICall<set_realtimeGICPUUsageDelegate>("UnityEngine.QualitySettings::set_realtimeGICPUUsage");
		get_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<get_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::get_asyncUploadTimeSlice");
		set_asyncUploadTimeSliceDelegateField = IL2CPP.ResolveICall<set_asyncUploadTimeSliceDelegate>("UnityEngine.QualitySettings::set_asyncUploadTimeSlice");
		get_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<get_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::get_asyncUploadBufferSize");
		set_asyncUploadBufferSizeDelegateField = IL2CPP.ResolveICall<set_asyncUploadBufferSizeDelegate>("UnityEngine.QualitySettings::set_asyncUploadBufferSize");
		get_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<get_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::get_asyncUploadPersistentBuffer");
		set_asyncUploadPersistentBufferDelegateField = IL2CPP.ResolveICall<set_asyncUploadPersistentBufferDelegate>("UnityEngine.QualitySettings::set_asyncUploadPersistentBuffer");
		SetLODSettingsDelegateField = IL2CPP.ResolveICall<SetLODSettingsDelegate>("UnityEngine.QualitySettings::SetLODSettings");
		get_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<get_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::get_realtimeReflectionProbes");
		set_realtimeReflectionProbesDelegateField = IL2CPP.ResolveICall<set_realtimeReflectionProbesDelegate>("UnityEngine.QualitySettings::set_realtimeReflectionProbes");
		set_billboardsFaceCameraPositionDelegateField = IL2CPP.ResolveICall<set_billboardsFaceCameraPositionDelegate>("UnityEngine.QualitySettings::set_billboardsFaceCameraPosition");
		get_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<get_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::get_useLegacyDetailDistribution");
		set_useLegacyDetailDistributionDelegateField = IL2CPP.ResolveICall<set_useLegacyDetailDistributionDelegate>("UnityEngine.QualitySettings::set_useLegacyDetailDistribution");
		get_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<get_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::get_resolutionScalingFixedDPIFactor");
		set_resolutionScalingFixedDPIFactorDelegateField = IL2CPP.ResolveICall<set_resolutionScalingFixedDPIFactorDelegate>("UnityEngine.QualitySettings::set_resolutionScalingFixedDPIFactor");
		get_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<get_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::get_terrainQualityOverrides");
		set_terrainQualityOverridesDelegateField = IL2CPP.ResolveICall<set_terrainQualityOverridesDelegate>("UnityEngine.QualitySettings::set_terrainQualityOverrides");
		get_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<get_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::get_terrainPixelError");
		set_terrainPixelErrorDelegateField = IL2CPP.ResolveICall<set_terrainPixelErrorDelegate>("UnityEngine.QualitySettings::set_terrainPixelError");
		get_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<get_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::get_terrainDetailDensityScale");
		set_terrainDetailDensityScaleDelegateField = IL2CPP.ResolveICall<set_terrainDetailDensityScaleDelegate>("UnityEngine.QualitySettings::set_terrainDetailDensityScale");
		get_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<get_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::get_terrainBasemapDistance");
		set_terrainBasemapDistanceDelegateField = IL2CPP.ResolveICall<set_terrainBasemapDistanceDelegate>("UnityEngine.QualitySettings::set_terrainBasemapDistance");
		get_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<get_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::get_terrainDetailDistance");
		set_terrainDetailDistanceDelegateField = IL2CPP.ResolveICall<set_terrainDetailDistanceDelegate>("UnityEngine.QualitySettings::set_terrainDetailDistance");
		get_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<get_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::get_terrainTreeDistance");
		set_terrainTreeDistanceDelegateField = IL2CPP.ResolveICall<set_terrainTreeDistanceDelegate>("UnityEngine.QualitySettings::set_terrainTreeDistance");
		get_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<get_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::get_terrainBillboardStart");
		set_terrainBillboardStartDelegateField = IL2CPP.ResolveICall<set_terrainBillboardStartDelegate>("UnityEngine.QualitySettings::set_terrainBillboardStart");
		get_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<get_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::get_terrainFadeLength");
		set_terrainFadeLengthDelegateField = IL2CPP.ResolveICall<set_terrainFadeLengthDelegate>("UnityEngine.QualitySettings::set_terrainFadeLength");
		get_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<get_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::get_terrainMaxTrees");
		set_terrainMaxTreesDelegateField = IL2CPP.ResolveICall<set_terrainMaxTreesDelegate>("UnityEngine.QualitySettings::set_terrainMaxTrees");
		get_blendWeightsDelegateField = IL2CPP.ResolveICall<get_blendWeightsDelegate>("UnityEngine.QualitySettings::get_blendWeights");
		set_blendWeightsDelegateField = IL2CPP.ResolveICall<set_blendWeightsDelegate>("UnityEngine.QualitySettings::set_blendWeights");
		get_skinWeightsDelegateField = IL2CPP.ResolveICall<get_skinWeightsDelegate>("UnityEngine.QualitySettings::get_skinWeights");
		set_skinWeightsDelegateField = IL2CPP.ResolveICall<set_skinWeightsDelegate>("UnityEngine.QualitySettings::set_skinWeights");
		get_countDelegateField = IL2CPP.ResolveICall<get_countDelegate>("UnityEngine.QualitySettings::get_count");
		GetStrippedMaximumLODLevelDelegateField = IL2CPP.ResolveICall<GetStrippedMaximumLODLevelDelegate>("UnityEngine.QualitySettings::GetStrippedMaximumLODLevel");
		SetStrippedMaximumLODLevelDelegateField = IL2CPP.ResolveICall<SetStrippedMaximumLODLevelDelegate>("UnityEngine.QualitySettings::SetStrippedMaximumLODLevel");
		get_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsActive");
		set_streamingMipmapsActiveDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsActiveDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsActive");
		get_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMemoryBudget");
		set_streamingMipmapsMemoryBudgetDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsMemoryBudgetDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMemoryBudget");
		get_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsRenderersPerFrame");
		set_streamingMipmapsRenderersPerFrameDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsRenderersPerFrameDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsRenderersPerFrame");
		get_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxLevelReduction");
		set_streamingMipmapsMaxLevelReductionDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsMaxLevelReductionDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxLevelReduction");
		get_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsAddAllCameras");
		set_streamingMipmapsAddAllCamerasDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsAddAllCamerasDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsAddAllCameras");
		get_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::get_streamingMipmapsMaxFileIORequests");
		set_streamingMipmapsMaxFileIORequestsDelegateField = IL2CPP.ResolveICall<set_streamingMipmapsMaxFileIORequestsDelegate>("UnityEngine.QualitySettings::set_streamingMipmapsMaxFileIORequests");
		get_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<get_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::get_maxQueuedFrames");
		set_maxQueuedFramesDelegateField = IL2CPP.ResolveICall<set_maxQueuedFramesDelegate>("UnityEngine.QualitySettings::set_maxQueuedFrames");
		get_namesDelegateField = IL2CPP.ResolveICall<get_namesDelegate>("UnityEngine.QualitySettings::get_names");
		get_desiredColorSpaceDelegateField = IL2CPP.ResolveICall<get_desiredColorSpaceDelegate>("UnityEngine.QualitySettings::get_desiredColorSpace");
		get_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::get_shadowCascade4Split_Injected");
		set_shadowCascade4Split_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowCascade4Split_InjectedDelegate>("UnityEngine.QualitySettings::set_shadowCascade4Split_Injected");
		get_INTERNAL_renderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<get_INTERNAL_renderPipeline_InjectedDelegate>("UnityEngine.QualitySettings::get_INTERNAL_renderPipeline_Injected");
		set_INTERNAL_renderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<set_INTERNAL_renderPipeline_InjectedDelegate>("UnityEngine.QualitySettings::set_INTERNAL_renderPipeline_Injected");
		InternalGetRenderPipelineAssetAt_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetRenderPipelineAssetAt_InjectedDelegate>("UnityEngine.QualitySettings::InternalGetRenderPipelineAssetAt_Injected");
		GetQualitySettings_InjectedDelegateField = IL2CPP.ResolveICall<GetQualitySettings_InjectedDelegate>("UnityEngine.QualitySettings::GetQualitySettings_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173514, XrefRangeEnd = 1173516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&previousQualityLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentQualityLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveQualityLevelChanged_Internal_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173518, RefRangeEnd = 1173519, XrefRangeStart = 1173516, XrefRangeEnd = 1173518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetQualityLevel(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173551, RefRangeEnd = 1173553, XrefRangeStart = 1173549, XrefRangeEnd = 1173551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetQualityLevel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityLevel_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173553, XrefRangeEnd = 1173555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetQualityLevel(int index, bool applyExpensiveChanges)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyExpensiveChanges;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQualityLevel_Public_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public QualitySettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_activeQualityLevelChanged(Il2CppSystem.Action<int, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeQualityLevelChanged(Il2CppSystem.Action<int, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void IncreaseLevel(bool applyExpensiveChanges)
	{
		SetQualityLevel(GetQualityLevel() + 1, applyExpensiveChanges);
	}

	public static void DecreaseLevel(bool applyExpensiveChanges)
	{
		SetQualityLevel(GetQualityLevel() - 1, applyExpensiveChanges);
	}

	public static void IncreaseLevel()
	{
		IncreaseLevel(applyExpensiveChanges: false);
	}

	public static void DecreaseLevel()
	{
		DecreaseLevel(applyExpensiveChanges: false);
	}

	public static void ForEach(Il2CppSystem.Action callback)
	{
		if ((object)callback == null)
		{
			return;
		}
		int qualityLevel = GetQualityLevel();
		try
		{
			for (int i = 0; i < count; i++)
			{
				SetQualityLevel(i, applyExpensiveChanges: false);
				callback.Invoke();
			}
		}
		finally
		{
			SetQualityLevel(qualityLevel, applyExpensiveChanges: false);
		}
	}

	public static void ForEach(Il2CppSystem.Action<int, string> callback)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetLODSettings(float lodBias, int maximumLODLevel, [Optional] bool setDirty)
	{
		SetLODSettingsDelegateField(lodBias, maximumLODLevel, setDirty);
	}

	public static ScriptableObject InternalGetRenderPipelineAssetAt(int index)
	{
		return Unmarshal.UnmarshalUnityObject<ScriptableObject>(InternalGetRenderPipelineAssetAt_Injected(index));
	}

	public static RenderPipelineAsset GetRenderPipelineAssetAt(int index)
	{
		if (index < 0 || index >= ((Il2CppArrayBase)names).Length)
		{
			throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("{0} is out of range [0..{1}[", "index", (Il2CppSystem.Object)(object)((Il2CppArrayBase)names).Length));
		}
		return ((Il2CppObjectBase)InternalGetRenderPipelineAssetAt(index)).TryCast<RenderPipelineAsset>();
	}

	public static int GetStrippedMaximumLODLevel()
	{
		return GetStrippedMaximumLODLevelDelegateField();
	}

	public static void SetStrippedMaximumLODLevel(int maximumLODLevel)
	{
		SetStrippedMaximumLODLevelDelegateField(maximumLODLevel);
	}

	public static Object GetQualitySettings()
	{
		return Unmarshal.UnmarshalUnityObject<Object>(GetQualitySettings_Injected());
	}

	public unsafe static void get_shadowCascade4Split_Injected(out Vector3 ret)
	{
		get_shadowCascade4Split_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_shadowCascade4Split_Injected([In] ref Vector3 value)
	{
		set_shadowCascade4Split_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public static System.IntPtr get_INTERNAL_renderPipeline_Injected()
	{
		return get_INTERNAL_renderPipeline_InjectedDelegateField();
	}

	public static void set_INTERNAL_renderPipeline_Injected(System.IntPtr value)
	{
		set_INTERNAL_renderPipeline_InjectedDelegateField(value);
	}

	public static System.IntPtr InternalGetRenderPipelineAssetAt_Injected(int index)
	{
		return InternalGetRenderPipelineAssetAt_InjectedDelegateField(index);
	}

	public static System.IntPtr GetQualitySettings_Injected()
	{
		return GetQualitySettings_InjectedDelegateField();
	}
}
