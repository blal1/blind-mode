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

public class UniversalCameraData : ContextItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JitterMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedRenderIntoTextureXR;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InitBuiltinXRConstants;

	private static readonly System.IntPtr NativeFieldInfoPtr_camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HistoryManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderType;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraTargetDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_useScreenCoordOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenSizeOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenCoordScaleBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_aspectRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageScalingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_upscalingFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_fsrOverrideSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_fsrSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_hdrColorBufferPrecision;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDefaultViewport;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHdrEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowHDROutput;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAlphaOutputEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresDepthTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresOpaqueTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingRequiresDepthTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_xrRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_useGPUOcclusionCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_stackLastCameraOutputToHDR;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultOpaqueSortFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr__xr_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxShadowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_postProcessEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_stackAnyPostProcessingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStopNaNEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDitheringEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_antialiasing;

	private static readonly System.IntPtr NativeFieldInfoPtr_antialiasingQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolveFinalTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceCameraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_backgroundColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_taaHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_stpHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_taaSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLastBaseCamera;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_historyManager_Public_get_UniversalCameraHistory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_historyManager_Public_set_Void_UniversalCameraHistory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isGameCamera_Public_get_Boolean_0;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTemporalAARequested_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSTPRequested_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSTPEnabled_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xr_Public_get_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Matrix4x4 m_ViewMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewMatrix)) = value;
		}
	}

	public unsafe Matrix4x4 m_ProjectionMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProjectionMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProjectionMatrix)) = value;
		}
	}

	public unsafe Matrix4x4 m_JitterMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JitterMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JitterMatrix)) = value;
		}
	}

	public unsafe bool m_CachedRenderIntoTextureXR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedRenderIntoTextureXR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedRenderIntoTextureXR)) = value;
		}
	}

	public unsafe bool m_InitBuiltinXRConstants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitBuiltinXRConstants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitBuiltinXRConstants)) = value;
		}
	}

	public unsafe Camera camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalCameraHistory m_HistoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraHistory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CameraRenderType renderType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderType);
			return *(CameraRenderType*)num;
		}
		set
		{
			*(CameraRenderType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderType)) = value;
		}
	}

	public unsafe RenderTexture targetTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTextureDescriptor cameraTargetDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTargetDescriptor);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTargetDescriptor)) = value;
		}
	}

	public unsafe Rect pixelRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelRect)) = value;
		}
	}

	public unsafe bool useScreenCoordOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useScreenCoordOverride);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useScreenCoordOverride)) = value;
		}
	}

	public unsafe Vector4 screenSizeOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSizeOverride);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSizeOverride)) = value;
		}
	}

	public unsafe Vector4 screenCoordScaleBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCoordScaleBias);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCoordScaleBias)) = value;
		}
	}

	public unsafe int pixelWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelWidth)) = value;
		}
	}

	public unsafe int pixelHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelHeight)) = value;
		}
	}

	public unsafe float aspectRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aspectRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aspectRatio)) = value;
		}
	}

	public unsafe float renderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderScale)) = value;
		}
	}

	public unsafe ImageScalingMode imageScalingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScalingMode);
			return *(ImageScalingMode*)num;
		}
		set
		{
			*(ImageScalingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScalingMode)) = value;
		}
	}

	public unsafe ImageUpscalingFilter upscalingFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upscalingFilter);
			return *(ImageUpscalingFilter*)num;
		}
		set
		{
			*(ImageUpscalingFilter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upscalingFilter)) = value;
		}
	}

	public unsafe bool fsrOverrideSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrOverrideSharpness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrOverrideSharpness)) = value;
		}
	}

	public unsafe float fsrSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrSharpness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrSharpness)) = value;
		}
	}

	public unsafe HDRColorBufferPrecision hdrColorBufferPrecision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrColorBufferPrecision);
			return *(HDRColorBufferPrecision*)num;
		}
		set
		{
			*(HDRColorBufferPrecision*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrColorBufferPrecision)) = value;
		}
	}

	public unsafe bool clearDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearDepth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearDepth)) = value;
		}
	}

	public unsafe CameraType cameraType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraType);
			return *(CameraType*)num;
		}
		set
		{
			*(CameraType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraType)) = value;
		}
	}

	public unsafe bool isDefaultViewport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDefaultViewport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDefaultViewport)) = value;
		}
	}

	public unsafe bool isHdrEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHdrEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHdrEnabled)) = value;
		}
	}

	public unsafe bool allowHDROutput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHDROutput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHDROutput)) = value;
		}
	}

	public unsafe bool isAlphaOutputEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlphaOutputEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlphaOutputEnabled)) = value;
		}
	}

	public unsafe bool requiresDepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresDepthTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresDepthTexture)) = value;
		}
	}

	public unsafe bool requiresOpaqueTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresOpaqueTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresOpaqueTexture)) = value;
		}
	}

	public unsafe bool postProcessingRequiresDepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingRequiresDepthTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingRequiresDepthTexture)) = value;
		}
	}

	public unsafe bool xrRendering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrRendering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrRendering)) = value;
		}
	}

	public unsafe bool useGPUOcclusionCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGPUOcclusionCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGPUOcclusionCulling)) = value;
		}
	}

	public unsafe bool stackLastCameraOutputToHDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackLastCameraOutputToHDR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackLastCameraOutputToHDR)) = value;
		}
	}

	public unsafe SortingCriteria defaultOpaqueSortFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultOpaqueSortFlags);
			return *(SortingCriteria*)num;
		}
		set
		{
			*(SortingCriteria*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultOpaqueSortFlags)) = value;
		}
	}

	public unsafe XRPass _xr_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xr_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xr_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float maxShadowDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxShadowDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxShadowDistance)) = value;
		}
	}

	public unsafe bool postProcessEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessEnabled)) = value;
		}
	}

	public unsafe bool stackAnyPostProcessingEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackAnyPostProcessingEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackAnyPostProcessingEnabled)) = value;
		}
	}

	public unsafe IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>> captureActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppSystem.Action<RenderTargetIdentifier, CommandBuffer>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LayerMask volumeLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeLayerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeLayerMask)) = value;
		}
	}

	public unsafe Transform volumeTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeTrigger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeTrigger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isStopNaNEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStopNaNEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStopNaNEnabled)) = value;
		}
	}

	public unsafe bool isDitheringEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDitheringEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDitheringEnabled)) = value;
		}
	}

	public unsafe AntialiasingMode antialiasing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasing);
			return *(AntialiasingMode*)num;
		}
		set
		{
			*(AntialiasingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasing)) = value;
		}
	}

	public unsafe AntialiasingQuality antialiasingQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasingQuality);
			return *(AntialiasingQuality*)num;
		}
		set
		{
			*(AntialiasingQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antialiasingQuality)) = value;
		}
	}

	public unsafe ScriptableRenderer renderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool resolveFinalTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveFinalTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveFinalTarget)) = value;
		}
	}

	public unsafe Vector3 worldSpaceCameraPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceCameraPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceCameraPos)) = value;
		}
	}

	public unsafe Color backgroundColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundColor)) = value;
		}
	}

	public unsafe TaaHistory taaHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaaHistory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StpHistory stpHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stpHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StpHistory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stpHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TemporalAA.Settings taaSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaSettings);
			return *(TemporalAA.Settings*)num;
		}
		set
		{
			*(TemporalAA.Settings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaSettings)) = value;
		}
	}

	public unsafe Camera baseCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isLastBaseCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLastBaseCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLastBaseCamera)) = value;
		}
	}

	public unsafe int scaledWidth
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086768, RefRangeEnd = 1086771, XrefRangeStart = 1086767, XrefRangeEnd = 1086768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int scaledHeight
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086772, RefRangeEnd = 1086775, XrefRangeStart = 1086771, XrefRangeEnd = 1086772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UniversalCameraHistory historyManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_historyManager_Public_get_UniversalCameraHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraHistory>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_historyManager_Public_set_Void_UniversalCameraHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool requireSrgbConversion
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1086785, RefRangeEnd = 1086792, XrefRangeStart = 1086775, XrefRangeEnd = 1086785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isGameCamera
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isGameCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isSceneViewCamera
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1086792, RefRangeEnd = 1086808, XrefRangeStart = 1086792, XrefRangeEnd = 1086792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPreviewCamera
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1086808, RefRangeEnd = 1086826, XrefRangeStart = 1086808, XrefRangeEnd = 1086808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isRenderPassSupportedCamera
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086826, RefRangeEnd = 1086829, XrefRangeStart = 1086826, XrefRangeEnd = 1086826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool resolveToScreen
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1086833, RefRangeEnd = 1086837, XrefRangeStart = 1086829, XrefRangeEnd = 1086833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isHDROutputActive
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1086844, RefRangeEnd = 1086858, XrefRangeStart = 1086837, XrefRangeEnd = 1086844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HDROutputUtils.HDRDisplayInformation hdrDisplayInformation
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1086868, RefRangeEnd = 1086878, XrefRangeStart = 1086858, XrefRangeEnd = 1086868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HDROutputUtils.HDRDisplayInformation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ColorGamut hdrDisplayColorGamut
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1086886, RefRangeEnd = 1086901, XrefRangeStart = 1086878, XrefRangeEnd = 1086886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool rendersOverlayUI
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1086905, RefRangeEnd = 1086917, XrefRangeStart = 1086901, XrefRangeEnd = 1086905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe XRPass xr
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xr_Public_get_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XRPassUniversal xrUniversal
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1086998, RefRangeEnd = 1087014, XrefRangeStart = 1086996, XrefRangeEnd = 1086998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPassUniversal>(intPtr2) : null;
		}
	}

	public unsafe bool resetHistory
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087014, RefRangeEnd = 1087016, XrefRangeStart = 1087014, XrefRangeEnd = 1087014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UniversalCameraData()
	{
		Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalCameraData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr);
		NativeFieldInfoPtr_m_ViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_ViewMatrix");
		NativeFieldInfoPtr_m_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_ProjectionMatrix");
		NativeFieldInfoPtr_m_JitterMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_JitterMatrix");
		NativeFieldInfoPtr_m_CachedRenderIntoTextureXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_CachedRenderIntoTextureXR");
		NativeFieldInfoPtr_m_InitBuiltinXRConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_InitBuiltinXRConstants");
		NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "camera");
		NativeFieldInfoPtr_m_HistoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "m_HistoryManager");
		NativeFieldInfoPtr_renderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "renderType");
		NativeFieldInfoPtr_targetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "targetTexture");
		NativeFieldInfoPtr_cameraTargetDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "cameraTargetDescriptor");
		NativeFieldInfoPtr_pixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "pixelRect");
		NativeFieldInfoPtr_useScreenCoordOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "useScreenCoordOverride");
		NativeFieldInfoPtr_screenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "screenSizeOverride");
		NativeFieldInfoPtr_screenCoordScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "screenCoordScaleBias");
		NativeFieldInfoPtr_pixelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "pixelWidth");
		NativeFieldInfoPtr_pixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "pixelHeight");
		NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "aspectRatio");
		NativeFieldInfoPtr_renderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "renderScale");
		NativeFieldInfoPtr_imageScalingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "imageScalingMode");
		NativeFieldInfoPtr_upscalingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "upscalingFilter");
		NativeFieldInfoPtr_fsrOverrideSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "fsrOverrideSharpness");
		NativeFieldInfoPtr_fsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "fsrSharpness");
		NativeFieldInfoPtr_hdrColorBufferPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "hdrColorBufferPrecision");
		NativeFieldInfoPtr_clearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "clearDepth");
		NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "cameraType");
		NativeFieldInfoPtr_isDefaultViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isDefaultViewport");
		NativeFieldInfoPtr_isHdrEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isHdrEnabled");
		NativeFieldInfoPtr_allowHDROutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "allowHDROutput");
		NativeFieldInfoPtr_isAlphaOutputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isAlphaOutputEnabled");
		NativeFieldInfoPtr_requiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "requiresDepthTexture");
		NativeFieldInfoPtr_requiresOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "requiresOpaqueTexture");
		NativeFieldInfoPtr_postProcessingRequiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "postProcessingRequiresDepthTexture");
		NativeFieldInfoPtr_xrRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "xrRendering");
		NativeFieldInfoPtr_useGPUOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "useGPUOcclusionCulling");
		NativeFieldInfoPtr_stackLastCameraOutputToHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "stackLastCameraOutputToHDR");
		NativeFieldInfoPtr_defaultOpaqueSortFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "defaultOpaqueSortFlags");
		NativeFieldInfoPtr__xr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "<xr>k__BackingField");
		NativeFieldInfoPtr_maxShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "maxShadowDistance");
		NativeFieldInfoPtr_postProcessEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "postProcessEnabled");
		NativeFieldInfoPtr_stackAnyPostProcessingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "stackAnyPostProcessingEnabled");
		NativeFieldInfoPtr_captureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "captureActions");
		NativeFieldInfoPtr_volumeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "volumeLayerMask");
		NativeFieldInfoPtr_volumeTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "volumeTrigger");
		NativeFieldInfoPtr_isStopNaNEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isStopNaNEnabled");
		NativeFieldInfoPtr_isDitheringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isDitheringEnabled");
		NativeFieldInfoPtr_antialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "antialiasing");
		NativeFieldInfoPtr_antialiasingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "antialiasingQuality");
		NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "renderer");
		NativeFieldInfoPtr_resolveFinalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "resolveFinalTarget");
		NativeFieldInfoPtr_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "worldSpaceCameraPos");
		NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "backgroundColor");
		NativeFieldInfoPtr_taaHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "taaHistory");
		NativeFieldInfoPtr_stpHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "stpHistory");
		NativeFieldInfoPtr_taaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "taaSettings");
		NativeFieldInfoPtr_baseCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "baseCamera");
		NativeFieldInfoPtr_isLastBaseCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, "isLastBaseCamera");
		NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_get_scaledWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_get_scaledHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_get_historyManager_Public_get_UniversalCameraHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_set_historyManager_Public_set_Void_UniversalCameraHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_get_requireSrgbConversion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_get_isGameCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_get_isSceneViewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_get_isPreviewCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_get_isRenderPassSupportedCamera_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_get_resolveToScreen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_get_isHDROutputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_get_hdrDisplayInformation_Public_get_HDRDisplayInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_get_hdrDisplayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_get_rendersOverlayUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_IsTemporalAARequested_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_IsSTPRequested_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_IsSTPEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_get_xr_Public_get_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_set_xr_Internal_set_Void_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_get_xrUniversal_Internal_get_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_get_resetHistory_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr, 100664552);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086637, RefRangeEnd = 1086638, XrefRangeStart = 1086635, XrefRangeEnd = 1086637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewAndProjectionMatrix_Internal_Void_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086638, RefRangeEnd = 1086640, XrefRangeStart = 1086638, XrefRangeEnd = 1086638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&viewMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &jitterMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewProjectionAndJitterMatrix_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086683, RefRangeEnd = 1086685, XrefRangeStart = 1086640, XrefRangeEnd = 1086683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushBuiltinShaderConstantsXR_Internal_Void_RasterCommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1086686, RefRangeEnd = 1086714, XrefRangeStart = 1086685, XrefRangeEnd = 1086686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetViewMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1086718, RefRangeEnd = 1086736, XrefRangeStart = 1086714, XrefRangeEnd = 1086718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1086737, RefRangeEnd = 1086748, XrefRangeStart = 1086736, XrefRangeEnd = 1086737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectionMatrixNoJitter_Internal_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086754, RefRangeEnd = 1086755, XrefRangeStart = 1086748, XrefRangeEnd = 1086754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086760, RefRangeEnd = 1086761, XrefRangeStart = 1086755, XrefRangeEnd = 1086760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrixNoJitter_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1086763, RefRangeEnd = 1086767, XrefRangeStart = 1086761, XrefRangeEnd = 1086763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderIntoTexture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGPUProjectionMatrix_Internal_Matrix4x4_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1086927, RefRangeEnd = 1086931, XrefRangeStart = 1086917, XrefRangeEnd = 1086927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHandleYFlipped(RTHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHandleYFlipped_Public_Boolean_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1086939, RefRangeEnd = 1086948, XrefRangeStart = 1086931, XrefRangeEnd = 1086939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCameraProjectionMatrixFlipped()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCameraProjectionMatrixFlipped_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1086954, RefRangeEnd = 1086959, XrefRangeStart = 1086948, XrefRangeEnd = 1086954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)color);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderTargetProjectionMatrixFlipped_Public_Boolean_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086959, RefRangeEnd = 1086961, XrefRangeStart = 1086959, XrefRangeEnd = 1086959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTemporalAARequested()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTemporalAARequested_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1086967, RefRangeEnd = 1086981, XrefRangeStart = 1086961, XrefRangeEnd = 1086967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTemporalAAEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTemporalAAEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1086981, RefRangeEnd = 1086985, XrefRangeStart = 1086981, XrefRangeEnd = 1086981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSTPRequested()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSTPRequested_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1086991, RefRangeEnd = 1086996, XrefRangeStart = 1086985, XrefRangeEnd = 1086991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSTPEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSTPEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087016, XrefRangeEnd = 1087026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalCameraData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalCameraData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalCameraData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
