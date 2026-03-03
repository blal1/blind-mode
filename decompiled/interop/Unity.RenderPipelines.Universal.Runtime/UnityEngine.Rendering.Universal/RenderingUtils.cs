using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public static class RenderingUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyShaderPassNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FullscreenMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ErrorMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ShaderTagValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RenderStateBlocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderTextureFormatSupport;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_RasterCommandBuffer_Matrix4x4_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_UniversalCameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererParamsObjectsWithError_Internal_Static_Void_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_RenderGraph_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawRendererListObjectsWithError_Internal_Static_Void_RasterCommandBuffer_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_RenderGraph_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalBlitScaleBias_Internal_Static_Vector4_RTHandle_RTHandle_UniversalCameraData_0;

	public unsafe static List<ShaderTagId> m_LegacyShaderPassNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_LegacyShaderPassNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_LegacyShaderPassNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AttachmentDescriptor s_EmptyAttachment
	{
		get
		{
			Unsafe.SkipInit(out AttachmentDescriptor result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EmptyAttachment, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EmptyAttachment, (void*)(&value));
		}
	}

	public unsafe static Mesh s_FullscreenMesh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FullscreenMesh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FullscreenMesh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_ErrorMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ErrorMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ErrorMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderTagId> s_ShaderTagValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ShaderTagValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ShaderTagValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<RenderStateBlock> s_RenderStateBlocks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RenderStateBlocks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderStateBlock>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RenderStateBlocks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RenderTextureFormatSupport, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<RenderTextureFormat, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RenderTextureFormatSupport, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AttachmentDescriptor emptyAttachment
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097876, XrefRangeEnd = 1097880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AttachmentDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Mesh fullscreenMesh
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097880, XrefRangeEnd = 1097949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
	}

	public unsafe static bool useStructuredBuffer
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Material errorMaterial
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1097973, RefRangeEnd = 1097976, XrefRangeStart = 1097949, XrefRangeEnd = 1097973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	static RenderingUtils()
	{
		Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr);
		NativeFieldInfoPtr_m_LegacyShaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "m_LegacyShaderPassNames");
		NativeFieldInfoPtr_s_EmptyAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_EmptyAttachment");
		NativeFieldInfoPtr_s_FullscreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_FullscreenMesh");
		NativeFieldInfoPtr_s_ErrorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_ErrorMaterial");
		NativeFieldInfoPtr_s_ShaderTagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_ShaderTagValues");
		NativeFieldInfoPtr_s_RenderStateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_RenderStateBlocks");
		NativeFieldInfoPtr_m_RenderTextureFormatSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "m_RenderTextureFormatSupport");
		NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665306);
		NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665308);
		NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665309);
		NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665310);
		NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665311);
		NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_RasterCommandBuffer_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665312);
		NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665313);
		NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665314);
		NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665315);
		NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665316);
		NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_UniversalCameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665317);
		NativeMethodInfoPtr_CreateRendererParamsObjectsWithError_Internal_Static_Void_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665318);
		NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665319);
		NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_RenderGraph_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr_DrawRendererListObjectsWithError_Internal_Static_Void_RasterCommandBuffer_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665321);
		NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_RenderGraph_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665324);
		NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665325);
		NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665327);
		NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665328);
		NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665329);
		NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665330);
		NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665331);
		NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665332);
		NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665333);
		NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665334);
		NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665335);
		NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665336);
		NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665337);
		NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665338);
		NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665339);
		NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665340);
		NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665341);
		NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665342);
		NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665343);
		NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665344);
		NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665345);
		NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665346);
		NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665347);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665348);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665350);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665351);
		NativeMethodInfoPtr_GetFinalBlitScaleBias_Internal_Static_Vector4_RTHandle_RTHandle_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665352);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsLightLayers(GraphicsDeviceType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097976, XrefRangeEnd = 1097984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInverseMatrices;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1098005, RefRangeEnd = 1098008, XrefRangeStart = 1097984, XrefRangeEnd = 1098005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetViewAndProjectionMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInverseMatrices;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_RasterCommandBuffer_Matrix4x4_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098020, RefRangeEnd = 1098021, XrefRangeStart = 1098008, XrefRangeEnd = 1098020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetScaleBiasRt(RasterCommandBuffer cmd, [In] ref UniversalCameraData cameraData, RTHandle rTHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rTHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_UniversalCameraData_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098037, RefRangeEnd = 1098038, XrefRangeStart = 1098021, XrefRangeEnd = 1098037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetScaleBiasRt(RasterCommandBuffer cmd, [In] ref RenderingData renderingData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_RasterCommandBuffer_byref_RenderingData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098038, XrefRangeEnd = 1098052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &storeAction;
		*(ClearFlag**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlag;
		*(Color**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1098066, RefRangeEnd = 1098068, XrefRangeStart = 1098052, XrefRangeEnd = 1098066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationColor);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorLoadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorStoreAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationDepthStencil);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilLoadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilStoreAction;
		*(ClearFlag**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlag;
		*(Color**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1098098, RefRangeEnd = 1098100, XrefRangeStart = 1098068, XrefRangeEnd = 1098098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FinalBlit(CommandBuffer cmd, UniversalCameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &storeAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_UniversalCameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098100, XrefRangeEnd = 1098132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererParamsObjectsWithError(ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListParams param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(FilteringSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterSettings;
		*(SortingCriteria**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortFlags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererParamsObjectsWithError_Internal_Static_Void_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098132, XrefRangeEnd = 1098150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererListObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererList rl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(FilteringSettings**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterSettings;
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortFlags;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098150, XrefRangeEnd = 1098160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererListObjectsWithError(RenderGraph renderGraph, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListHandle rl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(FilteringSettings**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterSettings;
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortFlags;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListObjectsWithError_Internal_Static_Void_RenderGraph_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_byref_RendererListHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098160, XrefRangeEnd = 1098161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawRendererListObjectsWithError(RasterCommandBuffer cmd, ref RendererList rl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawRendererListObjectsWithError_Internal_Static_Void_RasterCommandBuffer_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1098184, RefRangeEnd = 1098189, XrefRangeStart = 1098161, XrefRangeEnd = 1098184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererListWithRenderStateBlock(ScriptableRenderContext context, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererList rl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(DrawingSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ds;
		*(FilteringSettings**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fs;
		*(RenderStateBlock**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsb;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1098216, RefRangeEnd = 1098220, XrefRangeStart = 1098189, XrefRangeEnd = 1098216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererListWithRenderStateBlock(RenderGraph renderGraph, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererListHandle rl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(DrawingSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ds;
		*(FilteringSettings**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fs;
		*(RenderStateBlock**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsb;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListWithRenderStateBlock_Internal_Static_Void_RenderGraph_byref_CullingResults_DrawingSettings_FilteringSettings_RenderStateBlock_byref_RendererListHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098228, RefRangeEnd = 1098229, XrefRangeStart = 1098220, XrefRangeEnd = 1098228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearSystemInfoCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098243, RefRangeEnd = 1098244, XrefRangeStart = 1098229, XrefRangeEnd = 1098243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098244, XrefRangeEnd = 1098245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(FormatUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098245, XrefRangeEnd = 1098247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastValidColorBufferIndex(Il2CppStructArray<RenderTargetIdentifier> colorBuffers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorBuffers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1098250, RefRangeEnd = 1098253, XrefRangeStart = 1098247, XrefRangeEnd = 1098250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetValidColorBufferCount(Il2CppReferenceArray<RTHandle> colorBuffers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorBuffers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098259, RefRangeEnd = 1098260, XrefRangeStart = 1098253, XrefRangeEnd = 1098259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMRT(Il2CppReferenceArray<RTHandle> colorBuffers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorBuffers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098260, XrefRangeEnd = 1098262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Contains(Il2CppStructArray<RenderTargetIdentifier> source, RenderTargetIdentifier value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098262, XrefRangeEnd = 1098265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf(Il2CppReferenceArray<RTHandle> source, RenderTargetIdentifier value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098265, XrefRangeEnd = 1098271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf(Il2CppReferenceArray<RTHandle> source, RTHandle value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098271, XrefRangeEnd = 1098275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint CountDistinct(Il2CppReferenceArray<RTHandle> source, RTHandle value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098275, XrefRangeEnd = 1098277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LastValid(Il2CppReferenceArray<RTHandle> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppReferenceArray_1_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool Contains(ClearFlag a, ClearFlag b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(ClearFlag**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098277, XrefRangeEnd = 1098279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SequenceEqual(Il2CppReferenceArray<RTHandle> left, Il2CppReferenceArray<RTHandle> right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_Il2CppReferenceArray_1_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1098288, RefRangeEnd = 1098293, XrefRangeStart = 1098279, XrefRangeEnd = 1098288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MultisampleDepthResolveSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1098321, RefRangeEnd = 1098328, XrefRangeStart = 1098293, XrefRangeEnd = 1098321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RTHandleNeedsReAlloc(RTHandle handle, [In] ref TextureDesc descriptor, bool scaled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)descriptor);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1098345, RefRangeEnd = 1098349, XrefRangeStart = 1098328, XrefRangeEnd = 1098345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098349, XrefRangeEnd = 1098383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098383, XrefRangeEnd = 1098421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleFactor;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098421, XrefRangeEnd = 1098461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShadowMap;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1098504, RefRangeEnd = 1098551, XrefRangeStart = 1098461, XrefRangeEnd = 1098504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateHandleIfNeeded(ref RTHandle handle, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098551, XrefRangeEnd = 1098598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateHandleIfNeeded(ref RTHandle handle, Vector2 scaleFactor, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleFactor;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098598, XrefRangeEnd = 1098647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReAllocateHandleIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaleFunc);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(FilterMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisoLevel;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMapBias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReAllocateHandleIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Int32_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098647, XrefRangeEnd = 1098660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetMaxRTHandlePoolCapacity(int capacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1098670, RefRangeEnd = 1098676, XrefRangeStart = 1098660, XrefRangeEnd = 1098670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098676, XrefRangeEnd = 1098689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&shaderTagId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1098703, RefRangeEnd = 1098711, XrefRangeStart = 1098689, XrefRangeEnd = 1098703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&shaderTagId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1098752, RefRangeEnd = 1098753, XrefRangeStart = 1098711, XrefRangeEnd = 1098752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shaderTagIdList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1098782, RefRangeEnd = 1098793, XrefRangeStart = 1098753, XrefRangeEnd = 1098782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shaderTagIdList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1098799, RefRangeEnd = 1098802, XrefRangeStart = 1098793, XrefRangeEnd = 1098799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetFinalBlitScaleBias(RTHandle source, RTHandle destination, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalBlitScaleBias_Internal_Static_Vector4_RTHandle_RTHandle_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RenderingUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
