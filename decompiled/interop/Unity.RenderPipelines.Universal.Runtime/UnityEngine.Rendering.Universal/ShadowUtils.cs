using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

public static class ShadowUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceShadowPointSampling;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderShadowSlice_Internal_Static_Void_RasterCommandBuffer_byref_ShadowSliceData_byref_RendererList_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_UniversalShadowData_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowBias_Private_Static_Vector4_byref_VisibleLight_Int32_List_1_Vector4_Boolean_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Internal_Static_Void_RasterCommandBuffer_byref_VisibleLight_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_RasterCommandBuffer_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_RasterCommandBuffer_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_RasterCommandBuffer_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_RasterCommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_RasterCommandBuffer_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_LightType_LightShadows_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Vector4_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0;

	public unsafe static bool m_ForceShadowPointSampling
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ForceShadowPointSampling, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ForceShadowPointSampling, (void*)(&value));
		}
	}

	public unsafe static int kMinimumPunctualLightHardShadowResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&value));
		}
	}

	public unsafe static int kMinimumPunctualLightSoftShadowResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&value));
		}
	}

	static ShadowUtils()
	{
		Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowUtils");
		NativeFieldInfoPtr_m_ForceShadowPointSampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "m_ForceShadowPointSampling");
		NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "kMinimumPunctualLightHardShadowResolution");
		NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "kMinimumPunctualLightSoftShadowResolution");
		NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665522);
		NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665523);
		NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665524);
		NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665525);
		NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665526);
		NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665527);
		NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665528);
		NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665529);
		NativeMethodInfoPtr_RenderShadowSlice_Internal_Static_Void_RasterCommandBuffer_byref_ShadowSliceData_byref_RendererList_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665530);
		NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665531);
		NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665532);
		NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665533);
		NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665534);
		NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_UniversalShadowData_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665535);
		NativeMethodInfoPtr_GetShadowBias_Private_Static_Vector4_byref_VisibleLight_Int32_List_1_Vector4_Boolean_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665536);
		NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665537);
		NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665538);
		NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Internal_Static_Void_RasterCommandBuffer_byref_VisibleLight_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665539);
		NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_RasterCommandBuffer_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665540);
		NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_RasterCommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665541);
		NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665542);
		NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665543);
		NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_RasterCommandBuffer_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665544);
		NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665545);
		NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665546);
		NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665547);
		NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665548);
		NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665549);
		NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665550);
		NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665551);
		NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665552);
		NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_RasterCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665553);
		NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_RasterCommandBuffer_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665554);
		NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665555);
		NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_LightType_LightShadows_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665556);
		NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665557);
		NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665558);
		NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665559);
		NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665560);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099663, XrefRangeEnd = 1099671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cascadeIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapHeight;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlane;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cascadeSplitDistance);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099671, XrefRangeEnd = 1099676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cascadeIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapHeight;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlane;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cascadeSplitDistance);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1099691, RefRangeEnd = 1099694, XrefRangeStart = 1099676, XrefRangeEnd = 1099691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cascadeIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowmapHeight;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlane;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cascadeSplitDistance);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099694, XrefRangeEnd = 1099699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowMatrix);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099704, RefRangeEnd = 1099706, XrefRangeStart = 1099699, XrefRangeEnd = 1099704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractSpotLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowMatrix);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099706, XrefRangeEnd = 1099711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(CubemapFace**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapFace;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fovBias;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowMatrix);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099716, RefRangeEnd = 1099718, XrefRangeStart = 1099711, XrefRangeEnd = 1099716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExtractPointLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(CubemapFace**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapFace;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fovBias;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowMatrix);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_UniversalShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099718, XrefRangeEnd = 1099731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref context);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &proj;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099742, RefRangeEnd = 1099744, XrefRangeStart = 1099731, XrefRangeEnd = 1099742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderShadowSlice(RasterCommandBuffer cmd, ref ShadowSliceData shadowSliceData, ref RendererList shadowRendererList, Matrix4x4 proj, Matrix4x4 view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowRendererList);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &proj;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderShadowSlice_Internal_Static_Void_RasterCommandBuffer_byref_ShadowSliceData_byref_RendererList_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099744, XrefRangeEnd = 1099760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref context);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSliceData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1099760, RefRangeEnd = 1099763, XrefRangeStart = 1099760, XrefRangeEnd = 1099760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&atlasWidth);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099763, XrefRangeEnd = 1099766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref shadowSliceData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099766, XrefRangeEnd = 1099772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref shadowLight);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowData);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProjectionMatrix;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099776, RefRangeEnd = 1099778, XrefRangeStart = 1099772, XrefRangeEnd = 1099776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, UniversalShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref shadowLight);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProjectionMatrix;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_UniversalShadowData_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099827, RefRangeEnd = 1099829, XrefRangeStart = 1099778, XrefRangeEnd = 1099827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, List<Vector4> bias, bool supportsSoftShadows, Matrix4x4 lightProjectionMatrix, float shadowResolution)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref shadowLight);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowLightIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bias);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportsSoftShadows;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProjectionMatrix;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowBias_Private_Static_Vector4_byref_VisibleLight_Int32_List_1_Vector4_Boolean_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1099829, RefRangeEnd = 1099833, XrefRangeStart = 1099829, XrefRangeEnd = 1099829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fadeDistance);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &border;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bias);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099833, XrefRangeEnd = 1099841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowLight);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowBias;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099863, RefRangeEnd = 1099865, XrefRangeStart = 1099841, XrefRangeEnd = 1099863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupShadowCasterConstantBuffer(RasterCommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowLight);
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowBias;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Internal_Static_Void_RasterCommandBuffer_byref_VisibleLight_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099870, RefRangeEnd = 1099871, XrefRangeStart = 1099865, XrefRangeEnd = 1099870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShadowBias(RasterCommandBuffer cmd, Vector4 shadowBias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowBias;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_RasterCommandBuffer_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099871, XrefRangeEnd = 1099876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLightDirection(RasterCommandBuffer cmd, Vector3 lightDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_RasterCommandBuffer_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099881, RefRangeEnd = 1099882, XrefRangeStart = 1099876, XrefRangeEnd = 1099881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLightPosition(RasterCommandBuffer cmd, Vector3 lightPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099887, RefRangeEnd = 1099888, XrefRangeStart = 1099882, XrefRangeEnd = 1099887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraPosition(RasterCommandBuffer cmd, Vector3 worldSpaceCameraPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldSpaceCameraPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_RasterCommandBuffer_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1099898, RefRangeEnd = 1099900, XrefRangeStart = 1099888, XrefRangeEnd = 1099898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWorldToCameraAndCameraToWorldMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_RasterCommandBuffer_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1099922, RefRangeEnd = 1099927, XrefRangeStart = 1099900, XrefRangeEnd = 1099922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099927, XrefRangeEnd = 1099935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099935, XrefRangeEnd = 1099959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099959, XrefRangeEnd = 1099968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1099996, RefRangeEnd = 1100000, XrefRangeStart = 1099968, XrefRangeEnd = 1099996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1100005, RefRangeEnd = 1100008, XrefRangeStart = 1100000, XrefRangeEnd = 1100005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&proj);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1100027, RefRangeEnd = 1100031, XrefRangeStart = 1100008, XrefRangeEnd = 1100027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &softShadowsEnabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsPerLightSoftShadowQuality()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1100037, RefRangeEnd = 1100041, XrefRangeStart = 1100031, XrefRangeEnd = 1100037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPerLightSoftShadowKeyword(RasterCommandBuffer cmd, bool hasSoftShadows)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasSoftShadows;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_RasterCommandBuffer_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1100054, RefRangeEnd = 1100057, XrefRangeStart = 1100041, XrefRangeEnd = 1100054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSoftShadowQualityShaderKeywords(RasterCommandBuffer cmd, UniversalShadowData shadowData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_RasterCommandBuffer_UniversalShadowData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100057, XrefRangeEnd = 1100072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidShadowCastingLight(UniversalLightData lightData, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1100072, RefRangeEnd = 1100075, XrefRangeStart = 1100072, XrefRangeEnd = 1100072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidShadowCastingLight(UniversalLightData lightData, int i, LightType lightType, LightShadows lightShadows, float shadowStrength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(LightType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightType;
		*(LightShadows**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightShadows;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowStrength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_UniversalLightData_Int32_LightType_LightShadows_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1100075, RefRangeEnd = 1100078, XrefRangeStart = 1100075, XrefRangeEnd = 1100075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPunctualLightShadowSlicesCount([In] ref LightType lightType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref lightType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100078, RefRangeEnd = 1100080, XrefRangeStart = 1100078, XrefRangeEnd = 1100078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FastApproximately(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100090, RefRangeEnd = 1100091, XrefRangeStart = 1100080, XrefRangeEnd = 1100090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FastApproximately(Vector4 a, Vector4 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastApproximately_Internal_Static_Boolean_Vector4_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100091, RefRangeEnd = 1100093, XrefRangeStart = 1100091, XrefRangeEnd = 1100091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MinimalPunctualLightShadowResolution(bool softShadow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&softShadow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ShadowUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
