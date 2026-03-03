using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public sealed class CameraData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalCameraData_Internal_get_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_camera_Public_get_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_historyManager_Public_get_byref_UniversalCameraHistory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderType_Public_get_byref_CameraRenderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_byref_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraTargetDescriptor_Public_get_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelRect_Internal_get_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useScreenCoordOverride_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenSizeOverride_Internal_get_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenCoordScaleBias_Internal_get_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelWidth_Internal_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelHeight_Internal_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aspectRatio_Internal_get_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderScale_Public_get_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imageScalingMode_Internal_get_byref_ImageScalingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upscalingFilter_Internal_get_byref_ImageUpscalingFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fsrOverrideSharpness_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fsrSharpness_Internal_get_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrColorBufferPrecision_Internal_get_byref_HDRColorBufferPrecision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearDepth_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraType_Public_get_byref_CameraType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDefaultViewport_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHdrEnabled_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowHDROutput_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isAlphaOutputEnabled_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requiresOpaqueTexture_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postProcessingRequiresDepthTexture_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xrRendering_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultOpaqueSortFlags_Public_get_byref_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xr_Public_get_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxShadowDistance_Public_get_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postProcessEnabled_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_captureActions_Public_get_byref_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeLayerMask_Public_get_byref_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeTrigger_Public_get_byref_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isStopNaNEnabled_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDitheringEnabled_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_antialiasing_Public_get_byref_AntialiasingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_antialiasingQuality_Public_get_byref_AntialiasingQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderer_Public_get_byref_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resolveFinalTarget_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldSpaceCameraPos_Public_get_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_taaHistory_Internal_get_byref_TaaHistory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_taaSettings_Internal_get_byref_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseCamera_Public_get_byref_Camera_0;

	public unsafe ContextContainer frameData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalCameraData universalCameraData
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1106987, RefRangeEnd = 1106995, XrefRangeStart = 1106983, XrefRangeEnd = 1106987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalCameraData_Internal_get_UniversalCameraData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr2) : null;
		}
	}

	public unsafe ref Camera camera
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1107035, RefRangeEnd = 1107045, XrefRangeStart = 1107032, XrefRangeEnd = 1107035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_camera_Public_get_byref_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Camera*)intPtr2;
		}
	}

	public unsafe ref UniversalCameraHistory historyManager
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107045, XrefRangeEnd = 1107048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_historyManager_Public_get_byref_UniversalCameraHistory_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(UniversalCameraHistory*)intPtr2;
		}
	}

	public unsafe ref CameraRenderType renderType
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107051, RefRangeEnd = 1107053, XrefRangeStart = 1107048, XrefRangeEnd = 1107051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderType_Public_get_byref_CameraRenderType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(CameraRenderType*)intPtr2;
		}
	}

	public unsafe ref RenderTexture targetTexture
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107056, RefRangeEnd = 1107058, XrefRangeStart = 1107053, XrefRangeEnd = 1107056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetTexture_Public_get_byref_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(RenderTexture*)intPtr2;
		}
	}

	public unsafe ref RenderTextureDescriptor cameraTargetDescriptor
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1107061, RefRangeEnd = 1107073, XrefRangeStart = 1107058, XrefRangeEnd = 1107061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraTargetDescriptor_Public_get_byref_RenderTextureDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(RenderTextureDescriptor*)intPtr2;
		}
	}

	public unsafe ref Rect pixelRect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107073, XrefRangeEnd = 1107076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelRect_Internal_get_byref_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Rect*)intPtr2;
		}
	}

	public unsafe ref bool useScreenCoordOverride
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107076, XrefRangeEnd = 1107079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useScreenCoordOverride_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref Vector4 screenSizeOverride
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107079, XrefRangeEnd = 1107082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenSizeOverride_Internal_get_byref_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Vector4*)intPtr2;
		}
	}

	public unsafe ref Vector4 screenCoordScaleBias
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107082, XrefRangeEnd = 1107085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenCoordScaleBias_Internal_get_byref_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Vector4*)intPtr2;
		}
	}

	public unsafe ref int pixelWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107085, XrefRangeEnd = 1107088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelWidth_Internal_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int pixelHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107088, XrefRangeEnd = 1107091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelHeight_Internal_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref float aspectRatio
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107091, XrefRangeEnd = 1107094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aspectRatio_Internal_get_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(float*)intPtr2;
		}
	}

	public unsafe ref float renderScale
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107094, XrefRangeEnd = 1107097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderScale_Public_get_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(float*)intPtr2;
		}
	}

	public unsafe ref ImageScalingMode imageScalingMode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107097, XrefRangeEnd = 1107100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imageScalingMode_Internal_get_byref_ImageScalingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(ImageScalingMode*)intPtr2;
		}
	}

	public unsafe ref ImageUpscalingFilter upscalingFilter
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107100, XrefRangeEnd = 1107103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upscalingFilter_Internal_get_byref_ImageUpscalingFilter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(ImageUpscalingFilter*)intPtr2;
		}
	}

	public unsafe ref bool fsrOverrideSharpness
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107103, XrefRangeEnd = 1107106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fsrOverrideSharpness_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref float fsrSharpness
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107106, XrefRangeEnd = 1107109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fsrSharpness_Internal_get_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(float*)intPtr2;
		}
	}

	public unsafe ref HDRColorBufferPrecision hdrColorBufferPrecision
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107109, XrefRangeEnd = 1107112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrColorBufferPrecision_Internal_get_byref_HDRColorBufferPrecision_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HDRColorBufferPrecision*)intPtr2;
		}
	}

	public unsafe ref bool clearDepth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107115, RefRangeEnd = 1107117, XrefRangeStart = 1107112, XrefRangeEnd = 1107115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearDepth_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref CameraType cameraType
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1107120, RefRangeEnd = 1107126, XrefRangeStart = 1107117, XrefRangeEnd = 1107120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraType_Public_get_byref_CameraType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(CameraType*)intPtr2;
		}
	}

	public unsafe ref bool isDefaultViewport
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107126, XrefRangeEnd = 1107129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDefaultViewport_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool isHdrEnabled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107132, RefRangeEnd = 1107133, XrefRangeStart = 1107129, XrefRangeEnd = 1107132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHdrEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool allowHDROutput
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107133, XrefRangeEnd = 1107136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowHDROutput_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool isAlphaOutputEnabled
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1107139, RefRangeEnd = 1107144, XrefRangeStart = 1107136, XrefRangeEnd = 1107139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAlphaOutputEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool requiresDepthTexture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107144, XrefRangeEnd = 1107147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool requiresOpaqueTexture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107147, XrefRangeEnd = 1107150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requiresOpaqueTexture_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool postProcessingRequiresDepthTexture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107150, XrefRangeEnd = 1107153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postProcessingRequiresDepthTexture_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool xrRendering
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107153, XrefRangeEnd = 1107156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xrRendering_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe bool requireSrgbConversion
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107161, RefRangeEnd = 1107162, XrefRangeStart = 1107156, XrefRangeEnd = 1107161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isSceneViewCamera
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107167, RefRangeEnd = 1107168, XrefRangeStart = 1107162, XrefRangeEnd = 1107167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPreviewCamera
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107173, RefRangeEnd = 1107174, XrefRangeStart = 1107168, XrefRangeEnd = 1107173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isRenderPassSupportedCamera
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107174, XrefRangeEnd = 1107179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool resolveToScreen
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107179, XrefRangeEnd = 1107184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isHDROutputActive
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107189, RefRangeEnd = 1107190, XrefRangeStart = 1107184, XrefRangeEnd = 1107189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HDROutputUtils.HDRDisplayInformation hdrDisplayInformation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107190, XrefRangeEnd = 1107194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HDROutputUtils.HDRDisplayInformation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ColorGamut hdrDisplayColorGamut
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107194, XrefRangeEnd = 1107199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool rendersOverlayUI
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107199, XrefRangeEnd = 1107204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ref SortingCriteria defaultOpaqueSortFlags
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107229, RefRangeEnd = 1107230, XrefRangeStart = 1107226, XrefRangeEnd = 1107229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultOpaqueSortFlags_Public_get_byref_SortingCriteria_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(SortingCriteria*)intPtr2;
		}
	}

	public unsafe XRPass xr
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1107233, RefRangeEnd = 1107254, XrefRangeStart = 1107230, XrefRangeEnd = 1107233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xr_Public_get_XRPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107254, XrefRangeEnd = 1107259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XRPassUniversal xrUniversal
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107264, RefRangeEnd = 1107266, XrefRangeStart = 1107259, XrefRangeEnd = 1107264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPassUniversal>(intPtr2) : null;
		}
	}

	public unsafe ref float maxShadowDistance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1107269, RefRangeEnd = 1107271, XrefRangeStart = 1107266, XrefRangeEnd = 1107269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxShadowDistance_Public_get_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(float*)intPtr2;
		}
	}

	public unsafe ref bool postProcessEnabled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107274, RefRangeEnd = 1107275, XrefRangeStart = 1107271, XrefRangeEnd = 1107274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postProcessEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>> captureActions
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107278, RefRangeEnd = 1107279, XrefRangeStart = 1107275, XrefRangeEnd = 1107278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_captureActions_Public_get_byref_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>>*)intPtr2;
		}
	}

	public unsafe ref LayerMask volumeLayerMask
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107279, XrefRangeEnd = 1107282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeLayerMask_Public_get_byref_LayerMask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(LayerMask*)intPtr2;
		}
	}

	public unsafe ref Transform volumeTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107282, XrefRangeEnd = 1107285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeTrigger_Public_get_byref_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Transform*)intPtr2;
		}
	}

	public unsafe ref bool isStopNaNEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107285, XrefRangeEnd = 1107288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isStopNaNEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool isDitheringEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107288, XrefRangeEnd = 1107291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDitheringEnabled_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref AntialiasingMode antialiasing
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107291, XrefRangeEnd = 1107294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_antialiasing_Public_get_byref_AntialiasingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(AntialiasingMode*)intPtr2;
		}
	}

	public unsafe ref AntialiasingQuality antialiasingQuality
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107297, RefRangeEnd = 1107298, XrefRangeStart = 1107294, XrefRangeEnd = 1107297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_antialiasingQuality_Public_get_byref_AntialiasingQuality_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(AntialiasingQuality*)intPtr2;
		}
	}

	public unsafe ref ScriptableRenderer renderer
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1107301, RefRangeEnd = 1107320, XrefRangeStart = 1107298, XrefRangeEnd = 1107301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderer_Public_get_byref_ScriptableRenderer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(ScriptableRenderer*)intPtr2;
		}
	}

	public unsafe ref bool resolveFinalTarget
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107320, XrefRangeEnd = 1107323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolveFinalTarget_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref Vector3 worldSpaceCameraPos
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107323, XrefRangeEnd = 1107326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldSpaceCameraPos_Public_get_byref_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Vector3*)intPtr2;
		}
	}

	public unsafe ref Color backgroundColor
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107326, XrefRangeEnd = 1107329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backgroundColor_Public_get_byref_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Color*)intPtr2;
		}
	}

	public unsafe ref TaaHistory taaHistory
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1107332, RefRangeEnd = 1107335, XrefRangeStart = 1107329, XrefRangeEnd = 1107332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_taaHistory_Internal_get_byref_TaaHistory_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(TaaHistory*)intPtr2;
		}
	}

	public unsafe ref TemporalAA.Settings taaSettings
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107338, RefRangeEnd = 1107339, XrefRangeStart = 1107335, XrefRangeEnd = 1107338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_taaSettings_Internal_get_byref_Settings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(TemporalAA.Settings*)intPtr2;
		}
	}

	public unsafe bool resetHistory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107339, XrefRangeEnd = 1107344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ref Camera baseCamera
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107344, XrefRangeEnd = 1107347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseCamera_Public_get_byref_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Camera*)intPtr2;
		}
	}

	static CameraData()
	{
		Il2CppClassPointerStore<CameraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraData>.NativeClassPtr);
		NativeFieldInfoPtr_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraData>.NativeClassPtr, "frameData");
		NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666011);
		NativeMethodInfoPtr_get_universalCameraData_Internal_get_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666012);
		NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666013);
		NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666014);
		NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666015);
		NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666016);
		NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666017);
		NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666018);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666019);
		NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666020);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666021);
		NativeMethodInfoPtr_get_camera_Public_get_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666022);
		NativeMethodInfoPtr_get_historyManager_Public_get_byref_UniversalCameraHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666023);
		NativeMethodInfoPtr_get_renderType_Public_get_byref_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666024);
		NativeMethodInfoPtr_get_targetTexture_Public_get_byref_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666025);
		NativeMethodInfoPtr_get_cameraTargetDescriptor_Public_get_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666026);
		NativeMethodInfoPtr_get_pixelRect_Internal_get_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666027);
		NativeMethodInfoPtr_get_useScreenCoordOverride_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666028);
		NativeMethodInfoPtr_get_screenSizeOverride_Internal_get_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666029);
		NativeMethodInfoPtr_get_screenCoordScaleBias_Internal_get_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666030);
		NativeMethodInfoPtr_get_pixelWidth_Internal_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666031);
		NativeMethodInfoPtr_get_pixelHeight_Internal_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666032);
		NativeMethodInfoPtr_get_aspectRatio_Internal_get_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666033);
		NativeMethodInfoPtr_get_renderScale_Public_get_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666034);
		NativeMethodInfoPtr_get_imageScalingMode_Internal_get_byref_ImageScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666035);
		NativeMethodInfoPtr_get_upscalingFilter_Internal_get_byref_ImageUpscalingFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666036);
		NativeMethodInfoPtr_get_fsrOverrideSharpness_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666037);
		NativeMethodInfoPtr_get_fsrSharpness_Internal_get_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666038);
		NativeMethodInfoPtr_get_hdrColorBufferPrecision_Internal_get_byref_HDRColorBufferPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666039);
		NativeMethodInfoPtr_get_clearDepth_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666040);
		NativeMethodInfoPtr_get_cameraType_Public_get_byref_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666041);
		NativeMethodInfoPtr_get_isDefaultViewport_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666042);
		NativeMethodInfoPtr_get_isHdrEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666043);
		NativeMethodInfoPtr_get_allowHDROutput_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666044);
		NativeMethodInfoPtr_get_isAlphaOutputEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666045);
		NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666046);
		NativeMethodInfoPtr_get_requiresOpaqueTexture_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666047);
		NativeMethodInfoPtr_get_postProcessingRequiresDepthTexture_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666048);
		NativeMethodInfoPtr_get_xrRendering_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666049);
		NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666050);
		NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666051);
		NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666052);
		NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666053);
		NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666054);
		NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666055);
		NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666056);
		NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666057);
		NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666058);
		NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666059);
		NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666060);
		NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666061);
		NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666062);
		NativeMethodInfoPtr_get_defaultOpaqueSortFlags_Public_get_byref_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666063);
		NativeMethodInfoPtr_get_xr_Public_get_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666064);
		NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666065);
		NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666066);
		NativeMethodInfoPtr_get_maxShadowDistance_Public_get_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666067);
		NativeMethodInfoPtr_get_postProcessEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666068);
		NativeMethodInfoPtr_get_captureActions_Public_get_byref_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666069);
		NativeMethodInfoPtr_get_volumeLayerMask_Public_get_byref_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666070);
		NativeMethodInfoPtr_get_volumeTrigger_Public_get_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666071);
		NativeMethodInfoPtr_get_isStopNaNEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666072);
		NativeMethodInfoPtr_get_isDitheringEnabled_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_get_antialiasing_Public_get_byref_AntialiasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666074);
		NativeMethodInfoPtr_get_antialiasingQuality_Public_get_byref_AntialiasingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666075);
		NativeMethodInfoPtr_get_renderer_Public_get_byref_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666076);
		NativeMethodInfoPtr_get_resolveFinalTarget_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666077);
		NativeMethodInfoPtr_get_worldSpaceCameraPos_Public_get_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666078);
		NativeMethodInfoPtr_get_backgroundColor_Public_get_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666079);
		NativeMethodInfoPtr_get_taaHistory_Internal_get_byref_TaaHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666080);
		NativeMethodInfoPtr_get_taaSettings_Internal_get_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666081);
		NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666082);
		NativeMethodInfoPtr_get_baseCamera_Public_get_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraData>.NativeClassPtr, 100666083);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraData(ContextContainer frameData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106995, XrefRangeEnd = 1106999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106999, XrefRangeEnd = 1107003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&viewMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &jitterMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107003, XrefRangeEnd = 1107008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107008, XrefRangeEnd = 1107012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetViewMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107012, XrefRangeEnd = 1107016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107016, XrefRangeEnd = 1107020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107020, XrefRangeEnd = 1107024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107024, XrefRangeEnd = 1107028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107028, XrefRangeEnd = 1107032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderIntoTexture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107204, XrefRangeEnd = 1107209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHandleYFlipped(RTHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1107214, RefRangeEnd = 1107216, XrefRangeStart = 1107209, XrefRangeEnd = 1107214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCameraProjectionMatrixFlipped()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107216, XrefRangeEnd = 1107221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)color);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107221, XrefRangeEnd = 1107226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTemporalAAEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CameraData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CameraData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraData>.NativeClassPtr))
	{
	}
}
