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
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public sealed class Camera : Behaviour
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "StereoscopicEye")]
	public enum StereoscopicEye
	{
		Left,
		Right
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "MonoOrStereoscopicEye")]
	public enum MonoOrStereoscopicEye
	{
		Left,
		Right,
		Mono
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "SceneViewFilterMode")]
	public enum SceneViewFilterMode
	{
		Off,
		ShowFiltered
	}

	public sealed class CameraCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

		static CameraCallback()
		{
			Il2CppClassPointerStore<CameraCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "CameraCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCallback>.NativeClassPtr, 100664019);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCallback>.NativeClassPtr, 100664020);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CameraCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator CameraCallback(System.Action<Camera> P_0)
		{
			return DelegateSupport.ConvertDelegate<CameraCallback>((System.Delegate)P_0);
		}

		public static CameraCallback operator +(CameraCallback P_0, CameraCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<CameraCallback>();
		}

		public static CameraCallback operator -(CameraCallback P_0, CameraCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<CameraCallback>();
			}
			return (CameraCallback)obj;
		}
	}

	public enum ProjectionMatrixMode
	{
		Explicit,
		Implicit,
		PhysicalPropertiesBased
	}

	public enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0
	}

	public enum FieldOfViewAxis
	{
		Vertical,
		Horizontal
	}

	public enum RenderRequestMode
	{
		None,
		ObjectId,
		Depth,
		VertexNormal,
		WorldPosition,
		EntityId,
		BaseColor,
		SpecularColor,
		Metallic,
		Emission,
		Normal,
		Smoothness,
		Occlusion,
		DiffuseColor
	}

	public enum RenderRequestOutputSpace
	{
		ScreenSpace = -1,
		UV0,
		UV1,
		UV2,
		UV3,
		UV4,
		UV5,
		UV6,
		UV7,
		UV8
	}

	private delegate float FocalLengthToFieldOfViewDelegate(float focalLength, float sensorSize);

	private delegate float FieldOfViewToFocalLengthDelegate(float fieldOfView, float sensorSize);

	private delegate float HorizontalToVerticalFieldOfViewDelegate(float horizontalFieldOfView, float aspectRatio);

	private delegate float VerticalToHorizontalFieldOfViewDelegate(float verticalFieldOfView, float aspectRatio);

	private delegate RenderingPath get_renderingPath_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderingPath_InjectedDelegate(System.IntPtr _unity_self, RenderingPath value);

	private delegate RenderingPath get_actualRenderingPath_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Reset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_allowDynamicResolution_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_forceIntoRenderTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_forceIntoRenderTexture_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate TransparencySortMode get_transparencySortMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_transparencySortMode_InjectedDelegate(System.IntPtr _unity_self, TransparencySortMode value);

	private delegate void get_transparencySortAxis_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_transparencySortAxis_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void ResetTransparencySortSettings_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_velocity_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_eventMask_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_layerCullSphericalInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_layerCullSphericalInternal_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_cameraType_InjectedDelegate(System.IntPtr _unity_self, CameraType value);

	private delegate System.IntPtr get_skyboxMaterial_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ulong get_overrideSceneCullingMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_overrideSceneCullingMask_InjectedDelegate(System.IntPtr _unity_self, ulong value);

	private delegate ulong get_sceneCullingMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_useInteractiveLightBakingData_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useInteractiveLightBakingData_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void GetLayerCullDistances_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void SetLayerCullDistances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr d);

	private delegate bool get_useOcclusionCulling_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_cullingMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_cullingMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void ResetCullingMatrix_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_clearStencilAfterLightingPass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_clearStencilAfterLightingPass_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void SetReplacementShader_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr shader, System.IntPtr replacementTag);

	private delegate void ResetReplacementShader_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ProjectionMatrixMode get_projectionMatrixMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_usePhysicalProperties_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_iso_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_iso_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_shutterSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shutterSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_aperture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_aperture_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_focusDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_focusDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_focalLength_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_focalLength_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_bladeCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bladeCount_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void get_curvature_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_curvature_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_barrelClipping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_barrelClipping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_anamorphism_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_anamorphism_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_sensorSize_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_sensorSize_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_lensShift_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate GateFitMode get_gateFit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_gateFit_InjectedDelegate(System.IntPtr _unity_self, GateFitMode value);

	private delegate float GetGateFittedFieldOfView_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetGateFittedLensShift_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetLocalSpaceAim_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_pixelRect_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate System.IntPtr get_activeTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_targetDisplay_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void SetTargetBuffersImpl_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr color, [In] System.IntPtr depth);

	private delegate void SetTargetBuffersMRTImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr color, [In] System.IntPtr depth);

	private delegate System.IntPtr GetCameraBufferWarnings_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_worldToCameraMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_projectionMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_nonJitteredProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_nonJitteredProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate bool get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_previousViewProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void ResetWorldToCameraMatrix_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void CalculateObliqueMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr clipPlane, [Out] System.IntPtr ret);

	private delegate void GetFrustumPlaneSizeAt_InjectedDelegate(System.IntPtr _unity_self, float distance, [Out] System.IntPtr ret);

	private delegate void ViewportPointToRay_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr pos, MonoOrStereoscopicEye eye, [Out] System.IntPtr ret);

	private delegate void CalculateFrustumCornersInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr viewport, float z, MonoOrStereoscopicEye eye, [Out] System.IntPtr outCorners);

	private delegate void CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate([Out] System.IntPtr output, float focalLength, [In] System.IntPtr sensorSize, [In] System.IntPtr lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode);

	private delegate void get_scene_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_scene_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_stereoSeparation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stereoSeparation_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_stereoConvergence_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stereoConvergence_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate StereoTargetEyeMask get_stereoTargetEyeInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stereoTargetEyeInternal_InjectedDelegate(System.IntPtr _unity_self, StereoTargetEyeMask value);

	private delegate MonoOrStereoscopicEye get_stereoActiveEye_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetStereoNonJitteredProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self, StereoscopicEye eye, [Out] System.IntPtr ret);

	private delegate void GetStereoViewMatrix_InjectedDelegate(System.IntPtr _unity_self, StereoscopicEye eye, [Out] System.IntPtr ret);

	private delegate void CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegate(System.IntPtr _unity_self, StereoscopicEye eye);

	private delegate void GetStereoProjectionMatrix_InjectedDelegate(System.IntPtr _unity_self, StereoscopicEye eye, [Out] System.IntPtr ret);

	private delegate void ResetStereoProjectionMatrices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetStereoViewMatrices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool RenderToCubemapImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr tex, int faceMask);

	private delegate bool get_renderCloudsInSceneView_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderCloudsInSceneView_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool RenderToCubemapEyeImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr cubemap, int faceMask, MonoOrStereoscopicEye stereoEye);

	private delegate void RenderWithShader_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr shader, System.IntPtr replacementTag);

	private delegate void RenderDontRestore_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SubmitRenderRequestsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr requests);

	private delegate System.IntPtr SubmitBuiltInObjectIDRenderRequest_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice);

	private delegate void CopyFrom_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr other);

	private delegate int get_commandBufferCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void RemoveCommandBuffersImpl_InjectedDelegate(System.IntPtr _unity_self, CameraEvent evt);

	private delegate void RemoveAllCommandBuffersImpl_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void AddCommandBufferImpl_InjectedDelegate(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer);

	private delegate void AddCommandBufferAsyncImpl_InjectedDelegate(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer, ComputeQueueType queueType);

	private delegate void RemoveCommandBufferImpl_InjectedDelegate(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer);

	private delegate System.IntPtr GetCommandBuffersImpl_InjectedDelegate(System.IntPtr _unity_self, CameraEvent evt);

	private static readonly System.IntPtr NativeFieldInfoPtr_kMinAperture;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxAperture;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMinBladeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxBladeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NonSerializedVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPreCull;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPreRender;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPostRender;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depth_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aspect_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAspect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentInternal_Private_Static_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilterMode_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BumpNonSerializedVersion_Private_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nearClipPlane_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_nearClipPlane_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_farClipPlane_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_farClipPlane_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fieldOfView_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fieldOfView_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowHDR_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowHDR_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowMSAA_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowMSAA_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowDynamicResolution_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orthographicSize_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_orthographicSize_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orthographic_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_orthographic_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_opaqueSortMode_Injected_Private_Static_OpaqueSortMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_opaqueSortMode_Injected_Private_Static_Void_IntPtr_OpaqueSortMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depth_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depth_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aspect_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_aspect_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAspect_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingMask_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventMask_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraType_Injected_Private_Static_CameraType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearFlags_Injected_Private_Static_CameraClearFlags_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearFlags_Injected_Private_Static_Void_IntPtr_CameraClearFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthTextureMode_Injected_Private_Static_DepthTextureMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthTextureMode_Injected_Private_Static_Void_IntPtr_DepthTextureMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usePhysicalProperties_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lensShift_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelWidth_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelHeight_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledPixelWidth_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaledPixelHeight_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Static_Void_IntPtr_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentInternal_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stereoEnabled_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Injected_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilterMode_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCurrent_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingParameters_Internal_Injected_Private_Static_Boolean_IntPtr_Boolean_byref_ScriptableCullingParameters_Int32_0;

	private static readonly FocalLengthToFieldOfViewDelegate FocalLengthToFieldOfViewDelegateField;

	private static readonly FieldOfViewToFocalLengthDelegate FieldOfViewToFocalLengthDelegateField;

	private static readonly HorizontalToVerticalFieldOfViewDelegate HorizontalToVerticalFieldOfViewDelegateField;

	private static readonly VerticalToHorizontalFieldOfViewDelegate VerticalToHorizontalFieldOfViewDelegateField;

	private static readonly get_renderingPath_InjectedDelegate get_renderingPath_InjectedDelegateField;

	private static readonly set_renderingPath_InjectedDelegate set_renderingPath_InjectedDelegateField;

	private static readonly get_actualRenderingPath_InjectedDelegate get_actualRenderingPath_InjectedDelegateField;

	private static readonly Reset_InjectedDelegate Reset_InjectedDelegateField;

	private static readonly set_allowDynamicResolution_InjectedDelegate set_allowDynamicResolution_InjectedDelegateField;

	private static readonly get_forceIntoRenderTexture_InjectedDelegate get_forceIntoRenderTexture_InjectedDelegateField;

	private static readonly set_forceIntoRenderTexture_InjectedDelegate set_forceIntoRenderTexture_InjectedDelegateField;

	private static readonly get_transparencySortMode_InjectedDelegate get_transparencySortMode_InjectedDelegateField;

	private static readonly set_transparencySortMode_InjectedDelegate set_transparencySortMode_InjectedDelegateField;

	private static readonly get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

	private static readonly set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

	private static readonly ResetTransparencySortSettings_InjectedDelegate ResetTransparencySortSettings_InjectedDelegateField;

	private static readonly get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

	private static readonly set_eventMask_InjectedDelegate set_eventMask_InjectedDelegateField;

	private static readonly get_layerCullSphericalInternal_InjectedDelegate get_layerCullSphericalInternal_InjectedDelegateField;

	private static readonly set_layerCullSphericalInternal_InjectedDelegate set_layerCullSphericalInternal_InjectedDelegateField;

	private static readonly set_cameraType_InjectedDelegate set_cameraType_InjectedDelegateField;

	private static readonly get_skyboxMaterial_InjectedDelegate get_skyboxMaterial_InjectedDelegateField;

	private static readonly get_overrideSceneCullingMask_InjectedDelegate get_overrideSceneCullingMask_InjectedDelegateField;

	private static readonly set_overrideSceneCullingMask_InjectedDelegate set_overrideSceneCullingMask_InjectedDelegateField;

	private static readonly get_sceneCullingMask_InjectedDelegate get_sceneCullingMask_InjectedDelegateField;

	private static readonly get_useInteractiveLightBakingData_InjectedDelegate get_useInteractiveLightBakingData_InjectedDelegateField;

	private static readonly set_useInteractiveLightBakingData_InjectedDelegate set_useInteractiveLightBakingData_InjectedDelegateField;

	private static readonly GetLayerCullDistances_InjectedDelegate GetLayerCullDistances_InjectedDelegateField;

	private static readonly SetLayerCullDistances_InjectedDelegate SetLayerCullDistances_InjectedDelegateField;

	private static readonly get_useOcclusionCulling_InjectedDelegate get_useOcclusionCulling_InjectedDelegateField;

	private static readonly get_cullingMatrix_InjectedDelegate get_cullingMatrix_InjectedDelegateField;

	private static readonly set_cullingMatrix_InjectedDelegate set_cullingMatrix_InjectedDelegateField;

	private static readonly ResetCullingMatrix_InjectedDelegate ResetCullingMatrix_InjectedDelegateField;

	private static readonly get_clearStencilAfterLightingPass_InjectedDelegate get_clearStencilAfterLightingPass_InjectedDelegateField;

	private static readonly set_clearStencilAfterLightingPass_InjectedDelegate set_clearStencilAfterLightingPass_InjectedDelegateField;

	private static readonly SetReplacementShader_InjectedDelegate SetReplacementShader_InjectedDelegateField;

	private static readonly ResetReplacementShader_InjectedDelegate ResetReplacementShader_InjectedDelegateField;

	private static readonly get_projectionMatrixMode_InjectedDelegate get_projectionMatrixMode_InjectedDelegateField;

	private static readonly set_usePhysicalProperties_InjectedDelegate set_usePhysicalProperties_InjectedDelegateField;

	private static readonly get_iso_InjectedDelegate get_iso_InjectedDelegateField;

	private static readonly set_iso_InjectedDelegate set_iso_InjectedDelegateField;

	private static readonly get_shutterSpeed_InjectedDelegate get_shutterSpeed_InjectedDelegateField;

	private static readonly set_shutterSpeed_InjectedDelegate set_shutterSpeed_InjectedDelegateField;

	private static readonly get_aperture_InjectedDelegate get_aperture_InjectedDelegateField;

	private static readonly set_aperture_InjectedDelegate set_aperture_InjectedDelegateField;

	private static readonly get_focusDistance_InjectedDelegate get_focusDistance_InjectedDelegateField;

	private static readonly set_focusDistance_InjectedDelegate set_focusDistance_InjectedDelegateField;

	private static readonly get_focalLength_InjectedDelegate get_focalLength_InjectedDelegateField;

	private static readonly set_focalLength_InjectedDelegate set_focalLength_InjectedDelegateField;

	private static readonly get_bladeCount_InjectedDelegate get_bladeCount_InjectedDelegateField;

	private static readonly set_bladeCount_InjectedDelegate set_bladeCount_InjectedDelegateField;

	private static readonly get_curvature_InjectedDelegate get_curvature_InjectedDelegateField;

	private static readonly set_curvature_InjectedDelegate set_curvature_InjectedDelegateField;

	private static readonly get_barrelClipping_InjectedDelegate get_barrelClipping_InjectedDelegateField;

	private static readonly set_barrelClipping_InjectedDelegate set_barrelClipping_InjectedDelegateField;

	private static readonly get_anamorphism_InjectedDelegate get_anamorphism_InjectedDelegateField;

	private static readonly set_anamorphism_InjectedDelegate set_anamorphism_InjectedDelegateField;

	private static readonly get_sensorSize_InjectedDelegate get_sensorSize_InjectedDelegateField;

	private static readonly set_sensorSize_InjectedDelegate set_sensorSize_InjectedDelegateField;

	private static readonly set_lensShift_InjectedDelegate set_lensShift_InjectedDelegateField;

	private static readonly get_gateFit_InjectedDelegate get_gateFit_InjectedDelegateField;

	private static readonly set_gateFit_InjectedDelegate set_gateFit_InjectedDelegateField;

	private static readonly GetGateFittedFieldOfView_InjectedDelegate GetGateFittedFieldOfView_InjectedDelegateField;

	private static readonly GetGateFittedLensShift_InjectedDelegate GetGateFittedLensShift_InjectedDelegateField;

	private static readonly GetLocalSpaceAim_InjectedDelegate GetLocalSpaceAim_InjectedDelegateField;

	private static readonly set_pixelRect_InjectedDelegate set_pixelRect_InjectedDelegateField;

	private static readonly get_activeTexture_InjectedDelegate get_activeTexture_InjectedDelegateField;

	private static readonly set_targetDisplay_InjectedDelegate set_targetDisplay_InjectedDelegateField;

	private static readonly SetTargetBuffersImpl_InjectedDelegate SetTargetBuffersImpl_InjectedDelegateField;

	private static readonly SetTargetBuffersMRTImpl_InjectedDelegate SetTargetBuffersMRTImpl_InjectedDelegateField;

	private static readonly GetCameraBufferWarnings_InjectedDelegate GetCameraBufferWarnings_InjectedDelegateField;

	private static readonly set_worldToCameraMatrix_InjectedDelegate set_worldToCameraMatrix_InjectedDelegateField;

	private static readonly set_projectionMatrix_InjectedDelegate set_projectionMatrix_InjectedDelegateField;

	private static readonly get_nonJitteredProjectionMatrix_InjectedDelegate get_nonJitteredProjectionMatrix_InjectedDelegateField;

	private static readonly set_nonJitteredProjectionMatrix_InjectedDelegate set_nonJitteredProjectionMatrix_InjectedDelegateField;

	private static readonly get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField;

	private static readonly set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField;

	private static readonly get_previousViewProjectionMatrix_InjectedDelegate get_previousViewProjectionMatrix_InjectedDelegateField;

	private static readonly ResetWorldToCameraMatrix_InjectedDelegate ResetWorldToCameraMatrix_InjectedDelegateField;

	private static readonly ResetProjectionMatrix_InjectedDelegate ResetProjectionMatrix_InjectedDelegateField;

	private static readonly CalculateObliqueMatrix_InjectedDelegate CalculateObliqueMatrix_InjectedDelegateField;

	private static readonly GetFrustumPlaneSizeAt_InjectedDelegate GetFrustumPlaneSizeAt_InjectedDelegateField;

	private static readonly ViewportPointToRay_InjectedDelegate ViewportPointToRay_InjectedDelegateField;

	private static readonly CalculateFrustumCornersInternal_InjectedDelegate CalculateFrustumCornersInternal_InjectedDelegateField;

	private static readonly CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField;

	private static readonly get_scene_InjectedDelegate get_scene_InjectedDelegateField;

	private static readonly set_scene_InjectedDelegate set_scene_InjectedDelegateField;

	private static readonly get_stereoSeparation_InjectedDelegate get_stereoSeparation_InjectedDelegateField;

	private static readonly set_stereoSeparation_InjectedDelegate set_stereoSeparation_InjectedDelegateField;

	private static readonly get_stereoConvergence_InjectedDelegate get_stereoConvergence_InjectedDelegateField;

	private static readonly set_stereoConvergence_InjectedDelegate set_stereoConvergence_InjectedDelegateField;

	private static readonly get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegate get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegateField;

	private static readonly get_stereoTargetEyeInternal_InjectedDelegate get_stereoTargetEyeInternal_InjectedDelegateField;

	private static readonly set_stereoTargetEyeInternal_InjectedDelegate set_stereoTargetEyeInternal_InjectedDelegateField;

	private static readonly get_stereoActiveEye_InjectedDelegate get_stereoActiveEye_InjectedDelegateField;

	private static readonly GetStereoNonJitteredProjectionMatrix_InjectedDelegate GetStereoNonJitteredProjectionMatrix_InjectedDelegateField;

	private static readonly GetStereoViewMatrix_InjectedDelegate GetStereoViewMatrix_InjectedDelegateField;

	private static readonly CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegate CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegateField;

	private static readonly GetStereoProjectionMatrix_InjectedDelegate GetStereoProjectionMatrix_InjectedDelegateField;

	private static readonly ResetStereoProjectionMatrices_InjectedDelegate ResetStereoProjectionMatrices_InjectedDelegateField;

	private static readonly ResetStereoViewMatrices_InjectedDelegate ResetStereoViewMatrices_InjectedDelegateField;

	private static readonly RenderToCubemapImpl_InjectedDelegate RenderToCubemapImpl_InjectedDelegateField;

	private static readonly get_renderCloudsInSceneView_InjectedDelegate get_renderCloudsInSceneView_InjectedDelegateField;

	private static readonly set_renderCloudsInSceneView_InjectedDelegate set_renderCloudsInSceneView_InjectedDelegateField;

	private static readonly RenderToCubemapEyeImpl_InjectedDelegate RenderToCubemapEyeImpl_InjectedDelegateField;

	private static readonly RenderWithShader_InjectedDelegate RenderWithShader_InjectedDelegateField;

	private static readonly RenderDontRestore_InjectedDelegate RenderDontRestore_InjectedDelegateField;

	private static readonly SubmitRenderRequestsInternal_InjectedDelegate SubmitRenderRequestsInternal_InjectedDelegateField;

	private static readonly SubmitBuiltInObjectIDRenderRequest_InjectedDelegate SubmitBuiltInObjectIDRenderRequest_InjectedDelegateField;

	private static readonly CopyFrom_InjectedDelegate CopyFrom_InjectedDelegateField;

	private static readonly get_commandBufferCount_InjectedDelegate get_commandBufferCount_InjectedDelegateField;

	private static readonly RemoveCommandBuffersImpl_InjectedDelegate RemoveCommandBuffersImpl_InjectedDelegateField;

	private static readonly RemoveAllCommandBuffersImpl_InjectedDelegate RemoveAllCommandBuffersImpl_InjectedDelegateField;

	private static readonly AddCommandBufferImpl_InjectedDelegate AddCommandBufferImpl_InjectedDelegateField;

	private static readonly AddCommandBufferAsyncImpl_InjectedDelegate AddCommandBufferAsyncImpl_InjectedDelegateField;

	private static readonly RemoveCommandBufferImpl_InjectedDelegate RemoveCommandBufferImpl_InjectedDelegateField;

	private static readonly GetCommandBuffersImpl_InjectedDelegate GetCommandBuffersImpl_InjectedDelegateField;

	public unsafe static float kMinAperture
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinAperture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinAperture, (void*)(&value));
		}
	}

	public unsafe static float kMaxAperture
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxAperture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxAperture, (void*)(&value));
		}
	}

	public unsafe static int kMinBladeCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinBladeCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinBladeCount, (void*)(&value));
		}
	}

	public unsafe static int kMaxBladeCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxBladeCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxBladeCount, (void*)(&value));
		}
	}

	public unsafe uint m_NonSerializedVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NonSerializedVersion);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NonSerializedVersion)) = value;
		}
	}

	public unsafe static CameraCallback onPreCull
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPreCull, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPreCull, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CameraCallback onPreRender
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPreRender, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPreRender, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CameraCallback onPostRender
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPostRender, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPostRender, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float nearClipPlane
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1168104, RefRangeEnd = 1168126, XrefRangeStart = 1168099, XrefRangeEnd = 1168104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1168131, RefRangeEnd = 1168147, XrefRangeStart = 1168126, XrefRangeEnd = 1168131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float farClipPlane
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1168152, RefRangeEnd = 1168172, XrefRangeStart = 1168147, XrefRangeEnd = 1168152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1168177, RefRangeEnd = 1168193, XrefRangeStart = 1168172, XrefRangeEnd = 1168177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float fieldOfView
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1168198, RefRangeEnd = 1168216, XrefRangeStart = 1168193, XrefRangeEnd = 1168198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1168221, RefRangeEnd = 1168247, XrefRangeStart = 1168216, XrefRangeEnd = 1168221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allowHDR
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168252, RefRangeEnd = 1168253, XrefRangeStart = 1168247, XrefRangeEnd = 1168252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168258, RefRangeEnd = 1168261, XrefRangeStart = 1168253, XrefRangeEnd = 1168258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allowMSAA
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168266, RefRangeEnd = 1168268, XrefRangeStart = 1168261, XrefRangeEnd = 1168266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168273, RefRangeEnd = 1168276, XrefRangeStart = 1168268, XrefRangeEnd = 1168273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allowDynamicResolution
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1168281, RefRangeEnd = 1168288, XrefRangeStart = 1168276, XrefRangeEnd = 1168281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_allowDynamicResolution_Injected(intPtr, value);
		}
	}

	public unsafe float orthographicSize
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168293, RefRangeEnd = 1168296, XrefRangeStart = 1168288, XrefRangeEnd = 1168293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168301, RefRangeEnd = 1168302, XrefRangeStart = 1168296, XrefRangeEnd = 1168301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool orthographic
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1168307, RefRangeEnd = 1168320, XrefRangeStart = 1168302, XrefRangeEnd = 1168307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168325, RefRangeEnd = 1168326, XrefRangeStart = 1168320, XrefRangeEnd = 1168325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe OpaqueSortMode opaqueSortMode
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168331, RefRangeEnd = 1168333, XrefRangeStart = 1168326, XrefRangeEnd = 1168331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(OpaqueSortMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168338, RefRangeEnd = 1168339, XrefRangeStart = 1168333, XrefRangeEnd = 1168338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float depth
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1168344, RefRangeEnd = 1168357, XrefRangeStart = 1168339, XrefRangeEnd = 1168344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168362, RefRangeEnd = 1168365, XrefRangeStart = 1168357, XrefRangeEnd = 1168362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float aspect
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1168370, RefRangeEnd = 1168374, XrefRangeStart = 1168365, XrefRangeEnd = 1168370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aspect_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168379, RefRangeEnd = 1168380, XrefRangeStart = 1168374, XrefRangeEnd = 1168379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int cullingMask
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1168392, RefRangeEnd = 1168410, XrefRangeStart = 1168387, XrefRangeEnd = 1168392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1168415, RefRangeEnd = 1168428, XrefRangeStart = 1168410, XrefRangeEnd = 1168415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int eventMask
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168433, RefRangeEnd = 1168436, XrefRangeStart = 1168428, XrefRangeEnd = 1168433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_eventMask_Injected(intPtr, value);
		}
	}

	public unsafe CameraType cameraType
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1168441, RefRangeEnd = 1168476, XrefRangeStart = 1168436, XrefRangeEnd = 1168441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CameraType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cameraType_Injected(intPtr, value);
		}
	}

	public unsafe bool useOcclusionCulling
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useOcclusionCulling_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168481, RefRangeEnd = 1168482, XrefRangeStart = 1168476, XrefRangeEnd = 1168481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color backgroundColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168486, RefRangeEnd = 1168487, XrefRangeStart = 1168482, XrefRangeEnd = 1168486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168491, RefRangeEnd = 1168493, XrefRangeStart = 1168487, XrefRangeEnd = 1168491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CameraClearFlags clearFlags
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1168498, RefRangeEnd = 1168505, XrefRangeStart = 1168493, XrefRangeEnd = 1168498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CameraClearFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168510, RefRangeEnd = 1168513, XrefRangeStart = 1168505, XrefRangeEnd = 1168510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DepthTextureMode depthTextureMode
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168518, RefRangeEnd = 1168520, XrefRangeStart = 1168513, XrefRangeEnd = 1168518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthTextureMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168525, RefRangeEnd = 1168528, XrefRangeStart = 1168520, XrefRangeEnd = 1168525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool usePhysicalProperties
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168533, RefRangeEnd = 1168535, XrefRangeStart = 1168528, XrefRangeEnd = 1168533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_usePhysicalProperties_Injected(intPtr, value);
		}
	}

	public unsafe Vector2 lensShift
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168539, RefRangeEnd = 1168540, XrefRangeStart = 1168535, XrefRangeEnd = 1168539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lensShift_Injected(intPtr, ref value);
		}
	}

	public unsafe Rect rect
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1168544, RefRangeEnd = 1168548, XrefRangeStart = 1168540, XrefRangeEnd = 1168544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168552, RefRangeEnd = 1168554, XrefRangeStart = 1168548, XrefRangeEnd = 1168552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Rect pixelRect
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1168558, RefRangeEnd = 1168562, XrefRangeStart = 1168554, XrefRangeEnd = 1168558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pixelRect_Injected(intPtr, ref value);
		}
	}

	public unsafe int pixelWidth
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1168567, RefRangeEnd = 1168586, XrefRangeStart = 1168562, XrefRangeEnd = 1168567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int pixelHeight
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1168591, RefRangeEnd = 1168610, XrefRangeStart = 1168586, XrefRangeEnd = 1168591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int scaledPixelWidth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168615, RefRangeEnd = 1168616, XrefRangeStart = 1168610, XrefRangeEnd = 1168615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int scaledPixelHeight
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1168621, RefRangeEnd = 1168622, XrefRangeStart = 1168616, XrefRangeEnd = 1168621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderTexture targetTexture
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1168630, RefRangeEnd = 1168660, XrefRangeStart = 1168622, XrefRangeEnd = 1168630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1168668, RefRangeEnd = 1168683, XrefRangeStart = 1168660, XrefRangeEnd = 1168668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int targetDisplay
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1168688, RefRangeEnd = 1168691, XrefRangeStart = 1168683, XrefRangeEnd = 1168688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetDisplay_Injected(intPtr, value);
		}
	}

	public unsafe Matrix4x4 cameraToWorldMatrix
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1168695, RefRangeEnd = 1168700, XrefRangeStart = 1168691, XrefRangeEnd = 1168695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Matrix4x4 worldToCameraMatrix
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1168704, RefRangeEnd = 1168712, XrefRangeStart = 1168700, XrefRangeEnd = 1168704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_worldToCameraMatrix_Injected(intPtr, ref value);
		}
	}

	public unsafe Matrix4x4 projectionMatrix
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1168716, RefRangeEnd = 1168725, XrefRangeStart = 1168712, XrefRangeEnd = 1168716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionMatrix_Injected(intPtr, ref value);
		}
	}

	public unsafe static Camera main
	{
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 1168876, RefRangeEnd = 1168959, XrefRangeStart = 1168871, XrefRangeEnd = 1168876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
	}

	public unsafe static Camera current
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1168964, RefRangeEnd = 1168971, XrefRangeStart = 1168959, XrefRangeEnd = 1168964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
	}

	public unsafe static Camera currentInternal
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1168964, RefRangeEnd = 1168971, XrefRangeStart = 1168964, XrefRangeEnd = 1168971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentInternal_Private_Static_get_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
	}

	public unsafe bool stereoEnabled
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1168976, RefRangeEnd = 1168978, XrefRangeStart = 1168971, XrefRangeEnd = 1168976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int allCamerasCount
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1168990, RefRangeEnd = 1168994, XrefRangeStart = 1168990, XrefRangeEnd = 1168994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Il2CppReferenceArray<Camera> allCameras
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1169009, RefRangeEnd = 1169012, XrefRangeStart = 1168999, XrefRangeEnd = 1169009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
		}
	}

	public unsafe SceneViewFilterMode sceneViewFilterMode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SceneViewFilterMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public RenderingPath renderingPath
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderingPath_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderingPath_Injected(intPtr, value);
		}
	}

	public RenderingPath actualRenderingPath
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_actualRenderingPath_Injected(intPtr);
		}
	}

	public bool forceIntoRenderTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceIntoRenderTexture_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceIntoRenderTexture_Injected(intPtr, value);
		}
	}

	public TransparencySortMode transparencySortMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_transparencySortMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_transparencySortMode_Injected(intPtr, value);
		}
	}

	public Vector3 transparencySortAxis
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_transparencySortAxis_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_transparencySortAxis_Injected(intPtr, ref value);
		}
	}

	public Vector3 velocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_velocity_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool layerCullSpherical
	{
		get
		{
			return layerCullSphericalInternal;
		}
		set
		{
			if (GraphicsSettings.currentRenderPipeline != null)
			{
				Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.layerCullSpherical only with the built-in renderer.");
			}
			layerCullSphericalInternal = value;
		}
	}

	public bool layerCullSphericalInternal
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_layerCullSphericalInternal_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_layerCullSphericalInternal_Injected(intPtr, value);
		}
	}

	public Material skyboxMaterial
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_skyboxMaterial_Injected(intPtr));
		}
	}

	public ulong overrideSceneCullingMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_overrideSceneCullingMask_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_overrideSceneCullingMask_Injected(intPtr, value);
		}
	}

	public ulong sceneCullingMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sceneCullingMask_Injected(intPtr);
		}
	}

	public bool useInteractiveLightBakingData
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useInteractiveLightBakingData_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useInteractiveLightBakingData_Injected(intPtr, value);
		}
	}

	public Il2CppStructArray<float> layerCullDistances
	{
		get
		{
			return GetLayerCullDistances();
		}
		set
		{
			if (((Il2CppArrayBase)value).Length != 32)
			{
				throw new UnityException("Array needs to contain exactly 32 floats for layerCullDistances.");
			}
			SetLayerCullDistances(value);
		}
	}

	public static int PreviewCullingLayer => 31;

	public Matrix4x4 cullingMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_cullingMatrix_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cullingMatrix_Injected(intPtr, ref value);
		}
	}

	public bool clearStencilAfterLightingPass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_clearStencilAfterLightingPass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_clearStencilAfterLightingPass_Injected(intPtr, value);
		}
	}

	public ProjectionMatrixMode projectionMatrixMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionMatrixMode_Injected(intPtr);
		}
	}

	public int iso
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_iso_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_iso_Injected(intPtr, value);
		}
	}

	public float shutterSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shutterSpeed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shutterSpeed_Injected(intPtr, value);
		}
	}

	public float aperture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_aperture_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_aperture_Injected(intPtr, value);
		}
	}

	public float focusDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_focusDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_focusDistance_Injected(intPtr, value);
		}
	}

	public float focalLength
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_focalLength_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_focalLength_Injected(intPtr, value);
		}
	}

	public int bladeCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bladeCount_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bladeCount_Injected(intPtr, value);
		}
	}

	public Vector2 curvature
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_curvature_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_curvature_Injected(intPtr, ref value);
		}
	}

	public float barrelClipping
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_barrelClipping_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_barrelClipping_Injected(intPtr, value);
		}
	}

	public float anamorphism
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_anamorphism_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anamorphism_Injected(intPtr, value);
		}
	}

	public Vector2 sensorSize
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_sensorSize_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sensorSize_Injected(intPtr, ref value);
		}
	}

	public GateFitMode gateFit
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_gateFit_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_gateFit_Injected(intPtr, value);
		}
	}

	public RenderTexture activeTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<RenderTexture>(get_activeTexture_Injected(intPtr));
		}
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_nonJitteredProjectionMatrix_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_nonJitteredProjectionMatrix_Injected(intPtr, ref value);
		}
	}

	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useJitteredProjectionMatrixForTransparentRendering_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useJitteredProjectionMatrixForTransparentRendering_Injected(intPtr, value);
		}
	}

	public Matrix4x4 previousViewProjectionMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_previousViewProjectionMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Scene scene
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_scene_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_scene_Injected(intPtr, ref value);
		}
	}

	public float stereoSeparation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stereoSeparation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stereoSeparation_Injected(intPtr, value);
		}
	}

	public float stereoConvergence
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stereoConvergence_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stereoConvergence_Injected(intPtr, value);
		}
	}

	public bool areVRStereoViewMatricesWithinSingleCullTolerance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(intPtr);
		}
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		get
		{
			return stereoTargetEyeInternal;
		}
		set
		{
			if (GraphicsSettings.currentRenderPipeline != null)
			{
				Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.stereoTargetEye only with the built-in renderer.");
			}
			stereoTargetEyeInternal = value;
		}
	}

	public StereoTargetEyeMask stereoTargetEyeInternal
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stereoTargetEyeInternal_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stereoTargetEyeInternal_Injected(intPtr, value);
		}
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stereoActiveEye_Injected(intPtr);
		}
	}

	public bool renderCloudsInSceneView
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderCloudsInSceneView_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderCloudsInSceneView_Injected(intPtr, value);
		}
	}

	public int commandBufferCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_commandBufferCount_Injected(intPtr);
		}
	}

	static Camera()
	{
		Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Camera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
		NativeFieldInfoPtr_kMinAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinAperture");
		NativeFieldInfoPtr_kMaxAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxAperture");
		NativeFieldInfoPtr_kMinBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinBladeCount");
		NativeFieldInfoPtr_kMaxBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxBladeCount");
		NativeFieldInfoPtr_m_NonSerializedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "m_NonSerializedVersion");
		NativeFieldInfoPtr_onPreCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreCull");
		NativeFieldInfoPtr_onPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreRender");
		NativeFieldInfoPtr_onPostRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPostRender");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_get_depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_get_aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_ResetAspect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_get_currentInternal_Private_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_GetFilterMode_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_BumpNonSerializedVersion_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_get_nearClipPlane_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_set_nearClipPlane_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663955);
		NativeMethodInfoPtr_get_farClipPlane_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663956);
		NativeMethodInfoPtr_set_farClipPlane_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_get_fieldOfView_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663958);
		NativeMethodInfoPtr_set_fieldOfView_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663959);
		NativeMethodInfoPtr_get_allowHDR_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663960);
		NativeMethodInfoPtr_set_allowHDR_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_get_allowMSAA_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_set_allowMSAA_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_get_allowDynamicResolution_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_get_orthographicSize_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_set_orthographicSize_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_get_orthographic_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_set_orthographic_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_get_opaqueSortMode_Injected_Private_Static_OpaqueSortMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_set_opaqueSortMode_Injected_Private_Static_Void_IntPtr_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_get_depth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_set_depth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_get_aspect_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_set_aspect_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_ResetAspect_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_get_cullingMask_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_get_eventMask_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_get_cameraType_Injected_Private_Static_CameraType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_set_useOcclusionCulling_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_get_clearFlags_Injected_Private_Static_CameraClearFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_set_clearFlags_Injected_Private_Static_Void_IntPtr_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_get_depthTextureMode_Injected_Private_Static_DepthTextureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_set_depthTextureMode_Injected_Private_Static_Void_IntPtr_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr_get_usePhysicalProperties_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_get_lensShift_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_set_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663991);
		NativeMethodInfoPtr_get_pixelWidth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_get_pixelHeight_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_get_scaledPixelWidth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_get_scaledPixelHeight_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Static_Void_IntPtr_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_get_main_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_get_currentInternal_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr_get_stereoEnabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_GetAllCamerasImpl_Injected_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_GetFilterMode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_Render_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_SetupCurrent_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_GetCullingParameters_Internal_Injected_Private_Static_Boolean_IntPtr_Boolean_byref_ScriptableCullingParameters_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100664018);
		FocalLengthToFieldOfViewDelegateField = IL2CPP.ResolveICall<FocalLengthToFieldOfViewDelegate>("UnityEngine.Camera::FocalLengthToFieldOfView");
		FieldOfViewToFocalLengthDelegateField = IL2CPP.ResolveICall<FieldOfViewToFocalLengthDelegate>("UnityEngine.Camera::FieldOfViewToFocalLength");
		HorizontalToVerticalFieldOfViewDelegateField = IL2CPP.ResolveICall<HorizontalToVerticalFieldOfViewDelegate>("UnityEngine.Camera::HorizontalToVerticalFieldOfView");
		VerticalToHorizontalFieldOfViewDelegateField = IL2CPP.ResolveICall<VerticalToHorizontalFieldOfViewDelegate>("UnityEngine.Camera::VerticalToHorizontalFieldOfView");
		get_renderingPath_InjectedDelegateField = IL2CPP.ResolveICall<get_renderingPath_InjectedDelegate>("UnityEngine.Camera::get_renderingPath_Injected");
		set_renderingPath_InjectedDelegateField = IL2CPP.ResolveICall<set_renderingPath_InjectedDelegate>("UnityEngine.Camera::set_renderingPath_Injected");
		get_actualRenderingPath_InjectedDelegateField = IL2CPP.ResolveICall<get_actualRenderingPath_InjectedDelegate>("UnityEngine.Camera::get_actualRenderingPath_Injected");
		Reset_InjectedDelegateField = IL2CPP.ResolveICall<Reset_InjectedDelegate>("UnityEngine.Camera::Reset_Injected");
		set_allowDynamicResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_allowDynamicResolution_InjectedDelegate>("UnityEngine.Camera::set_allowDynamicResolution_Injected");
		get_forceIntoRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_forceIntoRenderTexture_InjectedDelegate>("UnityEngine.Camera::get_forceIntoRenderTexture_Injected");
		set_forceIntoRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_forceIntoRenderTexture_InjectedDelegate>("UnityEngine.Camera::set_forceIntoRenderTexture_Injected");
		get_transparencySortMode_InjectedDelegateField = IL2CPP.ResolveICall<get_transparencySortMode_InjectedDelegate>("UnityEngine.Camera::get_transparencySortMode_Injected");
		set_transparencySortMode_InjectedDelegateField = IL2CPP.ResolveICall<set_transparencySortMode_InjectedDelegate>("UnityEngine.Camera::set_transparencySortMode_Injected");
		get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<get_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::get_transparencySortAxis_Injected");
		set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<set_transparencySortAxis_InjectedDelegate>("UnityEngine.Camera::set_transparencySortAxis_Injected");
		ResetTransparencySortSettings_InjectedDelegateField = IL2CPP.ResolveICall<ResetTransparencySortSettings_InjectedDelegate>("UnityEngine.Camera::ResetTransparencySortSettings_Injected");
		get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<get_velocity_InjectedDelegate>("UnityEngine.Camera::get_velocity_Injected");
		set_eventMask_InjectedDelegateField = IL2CPP.ResolveICall<set_eventMask_InjectedDelegate>("UnityEngine.Camera::set_eventMask_Injected");
		get_layerCullSphericalInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_layerCullSphericalInternal_InjectedDelegate>("UnityEngine.Camera::get_layerCullSphericalInternal_Injected");
		set_layerCullSphericalInternal_InjectedDelegateField = IL2CPP.ResolveICall<set_layerCullSphericalInternal_InjectedDelegate>("UnityEngine.Camera::set_layerCullSphericalInternal_Injected");
		set_cameraType_InjectedDelegateField = IL2CPP.ResolveICall<set_cameraType_InjectedDelegate>("UnityEngine.Camera::set_cameraType_Injected");
		get_skyboxMaterial_InjectedDelegateField = IL2CPP.ResolveICall<get_skyboxMaterial_InjectedDelegate>("UnityEngine.Camera::get_skyboxMaterial_Injected");
		get_overrideSceneCullingMask_InjectedDelegateField = IL2CPP.ResolveICall<get_overrideSceneCullingMask_InjectedDelegate>("UnityEngine.Camera::get_overrideSceneCullingMask_Injected");
		set_overrideSceneCullingMask_InjectedDelegateField = IL2CPP.ResolveICall<set_overrideSceneCullingMask_InjectedDelegate>("UnityEngine.Camera::set_overrideSceneCullingMask_Injected");
		get_sceneCullingMask_InjectedDelegateField = IL2CPP.ResolveICall<get_sceneCullingMask_InjectedDelegate>("UnityEngine.Camera::get_sceneCullingMask_Injected");
		get_useInteractiveLightBakingData_InjectedDelegateField = IL2CPP.ResolveICall<get_useInteractiveLightBakingData_InjectedDelegate>("UnityEngine.Camera::get_useInteractiveLightBakingData_Injected");
		set_useInteractiveLightBakingData_InjectedDelegateField = IL2CPP.ResolveICall<set_useInteractiveLightBakingData_InjectedDelegate>("UnityEngine.Camera::set_useInteractiveLightBakingData_Injected");
		GetLayerCullDistances_InjectedDelegateField = IL2CPP.ResolveICall<GetLayerCullDistances_InjectedDelegate>("UnityEngine.Camera::GetLayerCullDistances_Injected");
		SetLayerCullDistances_InjectedDelegateField = IL2CPP.ResolveICall<SetLayerCullDistances_InjectedDelegate>("UnityEngine.Camera::SetLayerCullDistances_Injected");
		get_useOcclusionCulling_InjectedDelegateField = IL2CPP.ResolveICall<get_useOcclusionCulling_InjectedDelegate>("UnityEngine.Camera::get_useOcclusionCulling_Injected");
		get_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::get_cullingMatrix_Injected");
		set_cullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<set_cullingMatrix_InjectedDelegate>("UnityEngine.Camera::set_cullingMatrix_Injected");
		ResetCullingMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ResetCullingMatrix_InjectedDelegate>("UnityEngine.Camera::ResetCullingMatrix_Injected");
		get_clearStencilAfterLightingPass_InjectedDelegateField = IL2CPP.ResolveICall<get_clearStencilAfterLightingPass_InjectedDelegate>("UnityEngine.Camera::get_clearStencilAfterLightingPass_Injected");
		set_clearStencilAfterLightingPass_InjectedDelegateField = IL2CPP.ResolveICall<set_clearStencilAfterLightingPass_InjectedDelegate>("UnityEngine.Camera::set_clearStencilAfterLightingPass_Injected");
		SetReplacementShader_InjectedDelegateField = IL2CPP.ResolveICall<SetReplacementShader_InjectedDelegate>("UnityEngine.Camera::SetReplacementShader_Injected");
		ResetReplacementShader_InjectedDelegateField = IL2CPP.ResolveICall<ResetReplacementShader_InjectedDelegate>("UnityEngine.Camera::ResetReplacementShader_Injected");
		get_projectionMatrixMode_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionMatrixMode_InjectedDelegate>("UnityEngine.Camera::get_projectionMatrixMode_Injected");
		set_usePhysicalProperties_InjectedDelegateField = IL2CPP.ResolveICall<set_usePhysicalProperties_InjectedDelegate>("UnityEngine.Camera::set_usePhysicalProperties_Injected");
		get_iso_InjectedDelegateField = IL2CPP.ResolveICall<get_iso_InjectedDelegate>("UnityEngine.Camera::get_iso_Injected");
		set_iso_InjectedDelegateField = IL2CPP.ResolveICall<set_iso_InjectedDelegate>("UnityEngine.Camera::set_iso_Injected");
		get_shutterSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_shutterSpeed_InjectedDelegate>("UnityEngine.Camera::get_shutterSpeed_Injected");
		set_shutterSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_shutterSpeed_InjectedDelegate>("UnityEngine.Camera::set_shutterSpeed_Injected");
		get_aperture_InjectedDelegateField = IL2CPP.ResolveICall<get_aperture_InjectedDelegate>("UnityEngine.Camera::get_aperture_Injected");
		set_aperture_InjectedDelegateField = IL2CPP.ResolveICall<set_aperture_InjectedDelegate>("UnityEngine.Camera::set_aperture_Injected");
		get_focusDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_focusDistance_InjectedDelegate>("UnityEngine.Camera::get_focusDistance_Injected");
		set_focusDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_focusDistance_InjectedDelegate>("UnityEngine.Camera::set_focusDistance_Injected");
		get_focalLength_InjectedDelegateField = IL2CPP.ResolveICall<get_focalLength_InjectedDelegate>("UnityEngine.Camera::get_focalLength_Injected");
		set_focalLength_InjectedDelegateField = IL2CPP.ResolveICall<set_focalLength_InjectedDelegate>("UnityEngine.Camera::set_focalLength_Injected");
		get_bladeCount_InjectedDelegateField = IL2CPP.ResolveICall<get_bladeCount_InjectedDelegate>("UnityEngine.Camera::get_bladeCount_Injected");
		set_bladeCount_InjectedDelegateField = IL2CPP.ResolveICall<set_bladeCount_InjectedDelegate>("UnityEngine.Camera::set_bladeCount_Injected");
		get_curvature_InjectedDelegateField = IL2CPP.ResolveICall<get_curvature_InjectedDelegate>("UnityEngine.Camera::get_curvature_Injected");
		set_curvature_InjectedDelegateField = IL2CPP.ResolveICall<set_curvature_InjectedDelegate>("UnityEngine.Camera::set_curvature_Injected");
		get_barrelClipping_InjectedDelegateField = IL2CPP.ResolveICall<get_barrelClipping_InjectedDelegate>("UnityEngine.Camera::get_barrelClipping_Injected");
		set_barrelClipping_InjectedDelegateField = IL2CPP.ResolveICall<set_barrelClipping_InjectedDelegate>("UnityEngine.Camera::set_barrelClipping_Injected");
		get_anamorphism_InjectedDelegateField = IL2CPP.ResolveICall<get_anamorphism_InjectedDelegate>("UnityEngine.Camera::get_anamorphism_Injected");
		set_anamorphism_InjectedDelegateField = IL2CPP.ResolveICall<set_anamorphism_InjectedDelegate>("UnityEngine.Camera::set_anamorphism_Injected");
		get_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<get_sensorSize_InjectedDelegate>("UnityEngine.Camera::get_sensorSize_Injected");
		set_sensorSize_InjectedDelegateField = IL2CPP.ResolveICall<set_sensorSize_InjectedDelegate>("UnityEngine.Camera::set_sensorSize_Injected");
		set_lensShift_InjectedDelegateField = IL2CPP.ResolveICall<set_lensShift_InjectedDelegate>("UnityEngine.Camera::set_lensShift_Injected");
		get_gateFit_InjectedDelegateField = IL2CPP.ResolveICall<get_gateFit_InjectedDelegate>("UnityEngine.Camera::get_gateFit_Injected");
		set_gateFit_InjectedDelegateField = IL2CPP.ResolveICall<set_gateFit_InjectedDelegate>("UnityEngine.Camera::set_gateFit_Injected");
		GetGateFittedFieldOfView_InjectedDelegateField = IL2CPP.ResolveICall<GetGateFittedFieldOfView_InjectedDelegate>("UnityEngine.Camera::GetGateFittedFieldOfView_Injected");
		GetGateFittedLensShift_InjectedDelegateField = IL2CPP.ResolveICall<GetGateFittedLensShift_InjectedDelegate>("UnityEngine.Camera::GetGateFittedLensShift_Injected");
		GetLocalSpaceAim_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalSpaceAim_InjectedDelegate>("UnityEngine.Camera::GetLocalSpaceAim_Injected");
		set_pixelRect_InjectedDelegateField = IL2CPP.ResolveICall<set_pixelRect_InjectedDelegate>("UnityEngine.Camera::set_pixelRect_Injected");
		get_activeTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_activeTexture_InjectedDelegate>("UnityEngine.Camera::get_activeTexture_Injected");
		set_targetDisplay_InjectedDelegateField = IL2CPP.ResolveICall<set_targetDisplay_InjectedDelegate>("UnityEngine.Camera::set_targetDisplay_Injected");
		SetTargetBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetTargetBuffersImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersImpl_Injected");
		SetTargetBuffersMRTImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetTargetBuffersMRTImpl_InjectedDelegate>("UnityEngine.Camera::SetTargetBuffersMRTImpl_Injected");
		GetCameraBufferWarnings_InjectedDelegateField = IL2CPP.ResolveICall<GetCameraBufferWarnings_InjectedDelegate>("UnityEngine.Camera::GetCameraBufferWarnings_Injected");
		set_worldToCameraMatrix_InjectedDelegateField = IL2CPP.ResolveICall<set_worldToCameraMatrix_InjectedDelegate>("UnityEngine.Camera::set_worldToCameraMatrix_Injected");
		set_projectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionMatrix_InjectedDelegate>("UnityEngine.Camera::set_projectionMatrix_Injected");
		get_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_nonJitteredProjectionMatrix_Injected");
		set_nonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<set_nonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::set_nonJitteredProjectionMatrix_Injected");
		get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField = IL2CPP.ResolveICall<get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate>("UnityEngine.Camera::get_useJitteredProjectionMatrixForTransparentRendering_Injected");
		set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField = IL2CPP.ResolveICall<set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegate>("UnityEngine.Camera::set_useJitteredProjectionMatrixForTransparentRendering_Injected");
		get_previousViewProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_previousViewProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::get_previousViewProjectionMatrix_Injected");
		ResetWorldToCameraMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ResetWorldToCameraMatrix_InjectedDelegate>("UnityEngine.Camera::ResetWorldToCameraMatrix_Injected");
		ResetProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ResetProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::ResetProjectionMatrix_Injected");
		CalculateObliqueMatrix_InjectedDelegateField = IL2CPP.ResolveICall<CalculateObliqueMatrix_InjectedDelegate>("UnityEngine.Camera::CalculateObliqueMatrix_Injected");
		GetFrustumPlaneSizeAt_InjectedDelegateField = IL2CPP.ResolveICall<GetFrustumPlaneSizeAt_InjectedDelegate>("UnityEngine.Camera::GetFrustumPlaneSizeAt_Injected");
		ViewportPointToRay_InjectedDelegateField = IL2CPP.ResolveICall<ViewportPointToRay_InjectedDelegate>("UnityEngine.Camera::ViewportPointToRay_Injected");
		CalculateFrustumCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculateFrustumCornersInternal_InjectedDelegate>("UnityEngine.Camera::CalculateFrustumCornersInternal_Injected");
		CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegate>("UnityEngine.Camera::CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected");
		get_scene_InjectedDelegateField = IL2CPP.ResolveICall<get_scene_InjectedDelegate>("UnityEngine.Camera::get_scene_Injected");
		set_scene_InjectedDelegateField = IL2CPP.ResolveICall<set_scene_InjectedDelegate>("UnityEngine.Camera::set_scene_Injected");
		get_stereoSeparation_InjectedDelegateField = IL2CPP.ResolveICall<get_stereoSeparation_InjectedDelegate>("UnityEngine.Camera::get_stereoSeparation_Injected");
		set_stereoSeparation_InjectedDelegateField = IL2CPP.ResolveICall<set_stereoSeparation_InjectedDelegate>("UnityEngine.Camera::set_stereoSeparation_Injected");
		get_stereoConvergence_InjectedDelegateField = IL2CPP.ResolveICall<get_stereoConvergence_InjectedDelegate>("UnityEngine.Camera::get_stereoConvergence_Injected");
		set_stereoConvergence_InjectedDelegateField = IL2CPP.ResolveICall<set_stereoConvergence_InjectedDelegate>("UnityEngine.Camera::set_stereoConvergence_Injected");
		get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegateField = IL2CPP.ResolveICall<get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegate>("UnityEngine.Camera::get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected");
		get_stereoTargetEyeInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_stereoTargetEyeInternal_InjectedDelegate>("UnityEngine.Camera::get_stereoTargetEyeInternal_Injected");
		set_stereoTargetEyeInternal_InjectedDelegateField = IL2CPP.ResolveICall<set_stereoTargetEyeInternal_InjectedDelegate>("UnityEngine.Camera::set_stereoTargetEyeInternal_Injected");
		get_stereoActiveEye_InjectedDelegateField = IL2CPP.ResolveICall<get_stereoActiveEye_InjectedDelegate>("UnityEngine.Camera::get_stereoActiveEye_Injected");
		GetStereoNonJitteredProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetStereoNonJitteredProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoNonJitteredProjectionMatrix_Injected");
		GetStereoViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetStereoViewMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoViewMatrix_Injected");
		CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegateField = IL2CPP.ResolveICall<CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegate>("UnityEngine.Camera::CopyStereoDeviceProjectionMatrixToNonJittered_Injected");
		GetStereoProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetStereoProjectionMatrix_InjectedDelegate>("UnityEngine.Camera::GetStereoProjectionMatrix_Injected");
		ResetStereoProjectionMatrices_InjectedDelegateField = IL2CPP.ResolveICall<ResetStereoProjectionMatrices_InjectedDelegate>("UnityEngine.Camera::ResetStereoProjectionMatrices_Injected");
		ResetStereoViewMatrices_InjectedDelegateField = IL2CPP.ResolveICall<ResetStereoViewMatrices_InjectedDelegate>("UnityEngine.Camera::ResetStereoViewMatrices_Injected");
		RenderToCubemapImpl_InjectedDelegateField = IL2CPP.ResolveICall<RenderToCubemapImpl_InjectedDelegate>("UnityEngine.Camera::RenderToCubemapImpl_Injected");
		get_renderCloudsInSceneView_InjectedDelegateField = IL2CPP.ResolveICall<get_renderCloudsInSceneView_InjectedDelegate>("UnityEngine.Camera::get_renderCloudsInSceneView_Injected");
		set_renderCloudsInSceneView_InjectedDelegateField = IL2CPP.ResolveICall<set_renderCloudsInSceneView_InjectedDelegate>("UnityEngine.Camera::set_renderCloudsInSceneView_Injected");
		RenderToCubemapEyeImpl_InjectedDelegateField = IL2CPP.ResolveICall<RenderToCubemapEyeImpl_InjectedDelegate>("UnityEngine.Camera::RenderToCubemapEyeImpl_Injected");
		RenderWithShader_InjectedDelegateField = IL2CPP.ResolveICall<RenderWithShader_InjectedDelegate>("UnityEngine.Camera::RenderWithShader_Injected");
		RenderDontRestore_InjectedDelegateField = IL2CPP.ResolveICall<RenderDontRestore_InjectedDelegate>("UnityEngine.Camera::RenderDontRestore_Injected");
		SubmitRenderRequestsInternal_InjectedDelegateField = IL2CPP.ResolveICall<SubmitRenderRequestsInternal_InjectedDelegate>("UnityEngine.Camera::SubmitRenderRequestsInternal_Injected");
		SubmitBuiltInObjectIDRenderRequest_InjectedDelegateField = IL2CPP.ResolveICall<SubmitBuiltInObjectIDRenderRequest_InjectedDelegate>("UnityEngine.Camera::SubmitBuiltInObjectIDRenderRequest_Injected");
		CopyFrom_InjectedDelegateField = IL2CPP.ResolveICall<CopyFrom_InjectedDelegate>("UnityEngine.Camera::CopyFrom_Injected");
		get_commandBufferCount_InjectedDelegateField = IL2CPP.ResolveICall<get_commandBufferCount_InjectedDelegate>("UnityEngine.Camera::get_commandBufferCount_Injected");
		RemoveCommandBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<RemoveCommandBuffersImpl_InjectedDelegate>("UnityEngine.Camera::RemoveCommandBuffersImpl_Injected");
		RemoveAllCommandBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<RemoveAllCommandBuffersImpl_InjectedDelegate>("UnityEngine.Camera::RemoveAllCommandBuffersImpl_Injected");
		AddCommandBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<AddCommandBufferImpl_InjectedDelegate>("UnityEngine.Camera::AddCommandBufferImpl_Injected");
		AddCommandBufferAsyncImpl_InjectedDelegateField = IL2CPP.ResolveICall<AddCommandBufferAsyncImpl_InjectedDelegate>("UnityEngine.Camera::AddCommandBufferAsyncImpl_Injected");
		RemoveCommandBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<RemoveCommandBufferImpl_InjectedDelegate>("UnityEngine.Camera::RemoveCommandBufferImpl_Injected");
		GetCommandBuffersImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetCommandBuffersImpl_InjectedDelegate>("UnityEngine.Camera::GetCommandBuffersImpl_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1168385, RefRangeEnd = 1168387, XrefRangeStart = 1168380, XrefRangeEnd = 1168385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAspect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAspect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168725, XrefRangeEnd = 1168729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168729, XrefRangeEnd = 1168733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168733, XrefRangeEnd = 1168737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168737, XrefRangeEnd = 1168741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 1168745, RefRangeEnd = 1168793, XrefRangeStart = 1168741, XrefRangeEnd = 1168745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 WorldToScreenPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1168797, RefRangeEnd = 1168799, XrefRangeStart = 1168793, XrefRangeEnd = 1168797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 WorldToViewportPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1168803, RefRangeEnd = 1168807, XrefRangeStart = 1168799, XrefRangeEnd = 1168803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ViewportToWorldPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1168811, RefRangeEnd = 1168833, XrefRangeStart = 1168807, XrefRangeEnd = 1168811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ScreenToWorldPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1168837, RefRangeEnd = 1168838, XrefRangeStart = 1168833, XrefRangeEnd = 1168837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ScreenToViewportPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1168842, RefRangeEnd = 1168847, XrefRangeStart = 1168838, XrefRangeEnd = 1168842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ViewportToScreenPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168847, XrefRangeEnd = 1168851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Ray*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168851, XrefRangeEnd = 1168855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Ray*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1168859, RefRangeEnd = 1168871, XrefRangeStart = 1168855, XrefRangeEnd = 1168859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Ray ScreenPointToRay(Vector3 pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Ray*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1168982, RefRangeEnd = 1168983, XrefRangeStart = 1168978, XrefRangeEnd = 1168982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eye);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1168987, RefRangeEnd = 1168988, XrefRangeStart = 1168983, XrefRangeEnd = 1168987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eye);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1168990, RefRangeEnd = 1168994, XrefRangeStart = 1168988, XrefRangeEnd = 1168990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAllCamerasCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168994, XrefRangeEnd = 1168999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAllCamerasImpl([Out] Il2CppReferenceArray<Camera> cam)
	{
		//IL_0039: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)cam, (num2 == 0) ? null : new Il2CppReferenceArray<Camera>((System.IntPtr)num2));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169028, RefRangeEnd = 1169030, XrefRangeStart = 1169012, XrefRangeEnd = 1169028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAllCameras(Il2CppReferenceArray<Camera> cameras)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169030, XrefRangeEnd = 1169035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFilterMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilterMode_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169040, RefRangeEnd = 1169042, XrefRangeStart = 1169035, XrefRangeEnd = 1169040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1169047, RefRangeEnd = 1169055, XrefRangeStart = 1169042, XrefRangeEnd = 1169047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCurrent(Camera cur)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cur);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169055, XrefRangeEnd = 1169057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FireOnPreCull(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169057, XrefRangeEnd = 1169059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FireOnPreRender(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169059, XrefRangeEnd = 1169061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FireOnPostRender(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BumpNonSerializedVersion(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BumpNonSerializedVersion_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1169066, RefRangeEnd = 1169069, XrefRangeStart = 1169061, XrefRangeEnd = 1169066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stereoAware);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullingParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169069, XrefRangeEnd = 1169074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoAware;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullingParameters);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedCullingParametersSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169074, XrefRangeEnd = 1169076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_nearClipPlane_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nearClipPlane_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169076, XrefRangeEnd = 1169078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_nearClipPlane_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nearClipPlane_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169078, XrefRangeEnd = 1169080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_farClipPlane_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_farClipPlane_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169080, XrefRangeEnd = 1169082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_farClipPlane_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_farClipPlane_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169082, XrefRangeEnd = 1169084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_fieldOfView_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fieldOfView_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169084, XrefRangeEnd = 1169086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_fieldOfView_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fieldOfView_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169086, XrefRangeEnd = 1169088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_allowHDR_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowHDR_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169088, XrefRangeEnd = 1169090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_allowHDR_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowHDR_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169090, XrefRangeEnd = 1169092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_allowMSAA_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowMSAA_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169092, XrefRangeEnd = 1169094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_allowMSAA_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowMSAA_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169094, XrefRangeEnd = 1169096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_allowDynamicResolution_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowDynamicResolution_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169096, XrefRangeEnd = 1169098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_orthographicSize_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orthographicSize_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169098, XrefRangeEnd = 1169100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_orthographicSize_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_orthographicSize_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169100, XrefRangeEnd = 1169102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_orthographic_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orthographic_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169102, XrefRangeEnd = 1169104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_orthographic_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_orthographic_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169104, XrefRangeEnd = 1169106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OpaqueSortMode get_opaqueSortMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueSortMode_Injected_Private_Static_OpaqueSortMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OpaqueSortMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169106, XrefRangeEnd = 1169108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_opaqueSortMode_Injected(System.IntPtr _unity_self, OpaqueSortMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(OpaqueSortMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_opaqueSortMode_Injected_Private_Static_Void_IntPtr_OpaqueSortMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169108, XrefRangeEnd = 1169110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_depth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depth_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169110, XrefRangeEnd = 1169112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_depth_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depth_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169112, XrefRangeEnd = 1169114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_aspect_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aspect_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169114, XrefRangeEnd = 1169116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_aspect_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aspect_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169116, XrefRangeEnd = 1169118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAspect_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAspect_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169118, XrefRangeEnd = 1169120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_cullingMask_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingMask_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169120, XrefRangeEnd = 1169122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_cullingMask_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169122, XrefRangeEnd = 1169124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_eventMask_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventMask_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169124, XrefRangeEnd = 1169126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CameraType get_cameraType_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraType_Injected_Private_Static_CameraType_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CameraType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169126, XrefRangeEnd = 1169128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_useOcclusionCulling_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useOcclusionCulling_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169128, XrefRangeEnd = 1169130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_backgroundColor_Injected(System.IntPtr _unity_self, out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169130, XrefRangeEnd = 1169132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_backgroundColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169132, XrefRangeEnd = 1169134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CameraClearFlags get_clearFlags_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearFlags_Injected_Private_Static_CameraClearFlags_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CameraClearFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169134, XrefRangeEnd = 1169136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_clearFlags_Injected(System.IntPtr _unity_self, CameraClearFlags value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(CameraClearFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearFlags_Injected_Private_Static_Void_IntPtr_CameraClearFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169136, XrefRangeEnd = 1169138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DepthTextureMode get_depthTextureMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthTextureMode_Injected_Private_Static_DepthTextureMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DepthTextureMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169138, XrefRangeEnd = 1169140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_depthTextureMode_Injected(System.IntPtr _unity_self, DepthTextureMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(DepthTextureMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthTextureMode_Injected_Private_Static_Void_IntPtr_DepthTextureMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169140, XrefRangeEnd = 1169142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_usePhysicalProperties_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usePhysicalProperties_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169142, XrefRangeEnd = 1169144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_lensShift_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lensShift_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169144, XrefRangeEnd = 1169146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169146, XrefRangeEnd = 1169148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rect_Injected(System.IntPtr _unity_self, [In] ref Rect value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169148, XrefRangeEnd = 1169150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_pixelRect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169150, XrefRangeEnd = 1169152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_pixelWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelWidth_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169152, XrefRangeEnd = 1169154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_pixelHeight_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelHeight_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169154, XrefRangeEnd = 1169156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_scaledPixelWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledPixelWidth_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169156, XrefRangeEnd = 1169158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_scaledPixelHeight_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaledPixelHeight_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169158, XrefRangeEnd = 1169160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_targetTexture_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169160, XrefRangeEnd = 1169162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_targetTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169162, XrefRangeEnd = 1169164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_targetDisplay_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetDisplay_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169164, XrefRangeEnd = 1169166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_cameraToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169166, XrefRangeEnd = 1169168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_worldToCameraMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169168, XrefRangeEnd = 1169170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_projectionMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169170, XrefRangeEnd = 1169172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WorldToScreenPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169172, XrefRangeEnd = 1169174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WorldToViewportPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169174, XrefRangeEnd = 1169176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ViewportToWorldPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169176, XrefRangeEnd = 1169178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenToWorldPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169178, XrefRangeEnd = 1169180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenToViewportPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169180, XrefRangeEnd = 1169182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ViewportToScreenPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169182, XrefRangeEnd = 1169184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenPointToRay_Injected(System.IntPtr _unity_self, [In] ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(MonoOrStereoscopicEye**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Static_Void_IntPtr_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169184, XrefRangeEnd = 1169186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_main_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_main_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169186, XrefRangeEnd = 1169188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_currentInternal_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentInternal_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169188, XrefRangeEnd = 1169190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_stereoEnabled_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stereoEnabled_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169190, XrefRangeEnd = 1169192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStereoProjectionMatrix_Injected(System.IntPtr _unity_self, StereoscopicEye eye, [In] ref Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(StereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169192, XrefRangeEnd = 1169194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStereoViewMatrix_Injected(System.IntPtr _unity_self, StereoscopicEye eye, [In] ref Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(StereoscopicEye**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Static_Void_IntPtr_StereoscopicEye_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169194, XrefRangeEnd = 1169196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAllCamerasImpl_Injected([Out] Il2CppReferenceArray<Camera> cam)
	{
		//IL_0039: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllCamerasImpl_Injected_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)cam, (num2 == 0) ? null : new Il2CppReferenceArray<Camera>((System.IntPtr)num2));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169196, XrefRangeEnd = 1169198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFilterMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilterMode_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169198, XrefRangeEnd = 1169200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Render_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169200, XrefRangeEnd = 1169202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCurrent_Injected(System.IntPtr cur)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cur);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCurrent_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169202, XrefRangeEnd = 1169204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetCullingParameters_Internal_Injected(System.IntPtr camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoAware;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullingParameters);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &managedCullingParametersSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingParameters_Internal_Injected_Private_Static_Boolean_IntPtr_Boolean_byref_ScriptableCullingParameters_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Camera(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Reset()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Reset_Injected(intPtr);
	}

	public void ResetTransparencySortSettings()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetTransparencySortSettings_Injected(intPtr);
	}

	public unsafe Il2CppStructArray<float> GetLayerCullDistances()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<float> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetLayerCullDistances_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<float> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<float>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe void SetLayerCullDistances(Il2CppStructArray<float> d)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (d == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)d, "d");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)d);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper d2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			SetLayerCullDistances_Injected(intPtr, ref d2);
		}
	}

	public void ResetCullingMatrix()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetCullingMatrix_Injected(intPtr);
	}

	public unsafe void SetReplacementShader(Shader shader, string replacementTag)
	{
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//The blocks IL_003f are reachable both inside and outside the pinned region starting at IL_002e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			System.IntPtr shader2 = MarshalledUnityObject.Marshal(shader);
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(replacementTag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(replacementTag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetReplacementShader_Injected(intPtr, shader2, ref managedSpanWrapper);
					return;
				}
			}
			SetReplacementShader_Injected(intPtr, shader2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void ResetReplacementShader()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetReplacementShader_Injected(intPtr);
	}

	public float GetGateFittedFieldOfView()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetGateFittedFieldOfView_Injected(intPtr);
	}

	public Vector2 GetGateFittedLensShift()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetGateFittedLensShift_Injected(intPtr, out var ret);
		return ret;
	}

	public Vector3 GetLocalSpaceAim()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetLocalSpaceAim_Injected(intPtr, out var ret);
		return ret;
	}

	public void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTargetBuffersImpl_Injected(intPtr, ref color, ref depth);
	}

	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
	{
		SetTargetBuffersImpl(colorBuffer, depthBuffer);
	}

	public unsafe void SetTargetBuffersMRTImpl(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RenderBuffer> span);
		((Il2CppSystem.Span<RenderBuffer>)(&span))._002Ector((Il2CppArrayBase<RenderBuffer>)(object)color);
		fixed (RenderBuffer* begin = &((Il2CppSystem.Span<RenderBuffer>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper color2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RenderBuffer>)(&span)).Length);
			SetTargetBuffersMRTImpl_Injected(intPtr, ref color2, ref depth);
		}
	}

	public void SetTargetBuffers(Il2CppStructArray<RenderBuffer> colorBuffer, RenderBuffer depthBuffer)
	{
		SetTargetBuffersMRTImpl(colorBuffer, depthBuffer);
	}

	public Il2CppStringArray GetCameraBufferWarnings()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCameraBufferWarnings_Injected(intPtr);
	}

	public void ResetWorldToCameraMatrix()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetWorldToCameraMatrix_Injected(intPtr);
	}

	public void ResetProjectionMatrix()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetProjectionMatrix_Injected(intPtr);
	}

	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CalculateObliqueMatrix_Injected(intPtr, ref clipPlane, out var ret);
		return ret;
	}

	public Vector2 GetFrustumPlaneSizeAt(float distance)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetFrustumPlaneSizeAt_Injected(intPtr, distance, out var ret);
		return ret;
	}

	public Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ViewportPointToRay_Injected(intPtr, ref pos, eye, out var ret);
		return ret;
	}

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		return ViewportPointToRay((Vector2)pos, eye);
	}

	public Ray ViewportPointToRay(Vector3 pos)
	{
		return ViewportPointToRay(pos, MonoOrStereoscopicEye.Mono);
	}

	public void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Il2CppStructArray<Vector3> outCorners)
	{
		if (outCorners == null)
		{
			throw new Il2CppSystem.ArgumentNullException("outCorners");
		}
		if (((Il2CppArrayBase)outCorners).Length < 4)
		{
			throw new Il2CppSystem.ArgumentException("outCorners minimum size is 4", "outCorners");
		}
		CalculateFrustumCornersInternal(viewport, z, eye, outCorners);
	}

	public static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode)
	{
		CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out output, focalLength, ref sensorSize, ref lensShift, nearClip, farClip, gateAspect, gateFitMode);
	}

	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
	{
		return FocalLengthToFieldOfViewDelegateField(focalLength, sensorSize);
	}

	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
	{
		return FieldOfViewToFocalLengthDelegateField(fieldOfView, sensorSize);
	}

	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
	{
		return HorizontalToVerticalFieldOfViewDelegateField(horizontalFieldOfView, aspectRatio);
	}

	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
	{
		return VerticalToHorizontalFieldOfViewDelegateField(verticalFieldOfView, aspectRatio);
	}

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetStereoNonJitteredProjectionMatrix_Injected(intPtr, eye, out var ret);
		return ret;
	}

	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetStereoViewMatrix_Injected(intPtr, eye, out var ret);
		return ret;
	}

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyStereoDeviceProjectionMatrixToNonJittered_Injected(intPtr, eye);
	}

	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetStereoProjectionMatrix_Injected(intPtr, eye, out var ret);
		return ret;
	}

	public void ResetStereoProjectionMatrices()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetStereoProjectionMatrices_Injected(intPtr);
	}

	public void ResetStereoViewMatrices()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetStereoViewMatrices_Injected(intPtr);
	}

	public bool RenderToCubemapImpl(Texture tex, int faceMask)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return RenderToCubemapImpl_Injected(intPtr, MarshalledUnityObject.Marshal(tex), faceMask);
	}

	public bool RenderToCubemap(Cubemap cubemap, int faceMask)
	{
		return RenderToCubemapImpl(cubemap, faceMask);
	}

	public bool RenderToCubemap(Cubemap cubemap)
	{
		return RenderToCubemapImpl(cubemap, 63);
	}

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask)
	{
		return RenderToCubemapImpl(cubemap, faceMask);
	}

	public bool RenderToCubemap(RenderTexture cubemap)
	{
		return RenderToCubemapImpl(cubemap, 63);
	}

	public bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return RenderToCubemapEyeImpl_Injected(intPtr, MarshalledUnityObject.Marshal(cubemap), faceMask, stereoEye);
	}

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye)
	{
		return RenderToCubemapEyeImpl(cubemap, faceMask, stereoEye);
	}

	public unsafe void RenderWithShader(Shader shader, string replacementTag)
	{
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//The blocks IL_003f are reachable both inside and outside the pinned region starting at IL_002e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			System.IntPtr shader2 = MarshalledUnityObject.Marshal(shader);
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(replacementTag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(replacementTag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					RenderWithShader_Injected(intPtr, shader2, ref managedSpanWrapper);
					return;
				}
			}
			RenderWithShader_Injected(intPtr, shader2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void RenderDontRestore()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RenderDontRestore_Injected(intPtr);
	}

	public void SubmitRenderRequest<RequestData>(RequestData renderRequest)
	{
		if (renderRequest == null)
		{
			throw new Il2CppSystem.ArgumentException("SubmitRenderRequests is invoked with invalid renderRequests");
		}
		ObjectIdRequest objectIdRequest = ((Il2CppObjectBase)(object)renderRequest).TryCast<ObjectIdRequest>();
		if (objectIdRequest != null)
		{
			if (objectIdRequest.destination.depthStencilFormat == GraphicsFormat.None)
			{
				Debug.LogWarning("ObjectId Render Request submitted without a depth stencil, which can produce results that are not depth tested correctly");
			}
			if (GraphicsSettings.currentRenderPipeline == null || !RenderPipelineManager.currentPipeline.IsRenderRequestSupported(this, objectIdRequest))
			{
				throw new Il2CppSystem.ArgumentException((GraphicsSettings.currentRenderPipeline == null) ? "The Built-In Render Pipeline does not support ObjectIdRequest outside of the editor." : "The current render pipeline does not support ObjectIdRequest, and the fallback implementation of the Built-In Render Pipeline is not available outside of the editor.");
			}
		}
		if (GraphicsSettings.currentRenderPipeline == null)
		{
			Debug.LogWarning("Trying to invoke 'SubmitRenderRequest' when no SRP is set. A scriptable render pipeline is needed for this function call");
		}
		else
		{
			SubmitRenderRequestsInternal((Il2CppSystem.Object)(object)renderRequest);
		}
	}

	public void SubmitRenderRequestsInternal(Il2CppSystem.Object requests)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SubmitRenderRequestsInternal_Injected(intPtr, requests);
	}

	public Il2CppReferenceArray<Object> SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SubmitBuiltInObjectIDRenderRequest_Injected(intPtr, MarshalledUnityObject.Marshal(target), mipLevel, cubemapFace, depthSlice);
	}

	public void CopyFrom(Camera other)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyFrom_Injected(intPtr, MarshalledUnityObject.Marshal(other));
	}

	public void RemoveCommandBuffersImpl(CameraEvent evt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveCommandBuffersImpl_Injected(intPtr, evt);
	}

	public void RemoveAllCommandBuffersImpl()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveAllCommandBuffersImpl_Injected(intPtr);
	}

	public void RemoveCommandBuffers(CameraEvent evt)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.RemoveCommandBuffers only with the built-in renderer.");
			return;
		}
		m_NonSerializedVersion++;
		RemoveCommandBuffersImpl(evt);
	}

	public void RemoveAllCommandBuffers()
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.RemoveAllCommandBuffers only with the built-in renderer.");
			return;
		}
		m_NonSerializedVersion++;
		RemoveAllCommandBuffersImpl();
	}

	public void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = CommandBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		AddCommandBufferImpl_Injected(intPtr, evt, intPtr2);
	}

	public void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = CommandBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		AddCommandBufferAsyncImpl_Injected(intPtr, evt, intPtr2, queueType);
	}

	public void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = CommandBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		RemoveCommandBufferImpl_Injected(intPtr, evt, intPtr2);
	}

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
		if (!CameraEventUtils.IsValid(evt))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Invalid CameraEvent value \"{0}\".", (Il2CppSystem.Object)(object)(int)evt), "evt");
		}
		if (buffer == null)
		{
			throw new Il2CppSystem.NullReferenceException("buffer is null");
		}
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.AddCommandBuffer only with the built-in renderer.");
			return;
		}
		AddCommandBufferImpl(evt, buffer);
		m_NonSerializedVersion++;
	}

	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType)
	{
		if (!CameraEventUtils.IsValid(evt))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Invalid CameraEvent value \"{0}\".", (Il2CppSystem.Object)(object)(int)evt), "evt");
		}
		if (buffer == null)
		{
			throw new Il2CppSystem.NullReferenceException("buffer is null");
		}
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.AddCommandBufferAsync only with the built-in renderer.");
			return;
		}
		AddCommandBufferAsyncImpl(evt, buffer, queueType);
		m_NonSerializedVersion++;
	}

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
		if (!CameraEventUtils.IsValid(evt))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Invalid CameraEvent value \"{0}\".", (Il2CppSystem.Object)(object)(int)evt), "evt");
		}
		if (buffer == null)
		{
			throw new Il2CppSystem.NullReferenceException("buffer is null");
		}
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.RemoveCommandBuffer only with the built-in renderer.");
			return;
		}
		RemoveCommandBufferImpl(evt, buffer);
		m_NonSerializedVersion++;
	}

	public Il2CppReferenceArray<CommandBuffer> GetCommandBuffers(CameraEvent evt)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Camera.GetCommandBuffers only with the built-in renderer.");
		}
		return GetCommandBuffersImpl(evt);
	}

	public Il2CppReferenceArray<CommandBuffer> GetCommandBuffersImpl(CameraEvent evt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCommandBuffersImpl_Injected(intPtr, evt);
	}

	public void OnlyUsedForTesting1()
	{
	}

	public void OnlyUsedForTesting2()
	{
	}

	public unsafe bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters)
	{
		return GetCullingParameters_Internal(this, stereoAware: false, out cullingParameters, sizeof(ScriptableCullingParameters));
	}

	public static RenderingPath get_renderingPath_Injected(System.IntPtr _unity_self)
	{
		return get_renderingPath_InjectedDelegateField(_unity_self);
	}

	public static void set_renderingPath_Injected(System.IntPtr _unity_self, RenderingPath value)
	{
		set_renderingPath_InjectedDelegateField(_unity_self, value);
	}

	public static RenderingPath get_actualRenderingPath_Injected(System.IntPtr _unity_self)
	{
		return get_actualRenderingPath_InjectedDelegateField(_unity_self);
	}

	public static void Reset_Injected(System.IntPtr _unity_self)
	{
		Reset_InjectedDelegateField(_unity_self);
	}

	public static void set_allowDynamicResolution_Injected(System.IntPtr _unity_self, bool value)
	{
		set_allowDynamicResolution_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_forceIntoRenderTexture_Injected(System.IntPtr _unity_self)
	{
		return get_forceIntoRenderTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_forceIntoRenderTexture_Injected(System.IntPtr _unity_self, bool value)
	{
		set_forceIntoRenderTexture_InjectedDelegateField(_unity_self, value);
	}

	public static TransparencySortMode get_transparencySortMode_Injected(System.IntPtr _unity_self)
	{
		return get_transparencySortMode_InjectedDelegateField(_unity_self);
	}

	public static void set_transparencySortMode_Injected(System.IntPtr _unity_self, TransparencySortMode value)
	{
		set_transparencySortMode_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_transparencySortAxis_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_transparencySortAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_transparencySortAxis_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_transparencySortAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void ResetTransparencySortSettings_Injected(System.IntPtr _unity_self)
	{
		ResetTransparencySortSettings_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_velocity_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void set_eventMask_Injected(System.IntPtr _unity_self, int value)
	{
		set_eventMask_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_layerCullSphericalInternal_Injected(System.IntPtr _unity_self)
	{
		return get_layerCullSphericalInternal_InjectedDelegateField(_unity_self);
	}

	public static void set_layerCullSphericalInternal_Injected(System.IntPtr _unity_self, bool value)
	{
		set_layerCullSphericalInternal_InjectedDelegateField(_unity_self, value);
	}

	public static void set_cameraType_Injected(System.IntPtr _unity_self, CameraType value)
	{
		set_cameraType_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_skyboxMaterial_Injected(System.IntPtr _unity_self)
	{
		return get_skyboxMaterial_InjectedDelegateField(_unity_self);
	}

	public static ulong get_overrideSceneCullingMask_Injected(System.IntPtr _unity_self)
	{
		return get_overrideSceneCullingMask_InjectedDelegateField(_unity_self);
	}

	public static void set_overrideSceneCullingMask_Injected(System.IntPtr _unity_self, ulong value)
	{
		set_overrideSceneCullingMask_InjectedDelegateField(_unity_self, value);
	}

	public static ulong get_sceneCullingMask_Injected(System.IntPtr _unity_self)
	{
		return get_sceneCullingMask_InjectedDelegateField(_unity_self);
	}

	public static bool get_useInteractiveLightBakingData_Injected(System.IntPtr _unity_self)
	{
		return get_useInteractiveLightBakingData_InjectedDelegateField(_unity_self);
	}

	public static void set_useInteractiveLightBakingData_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useInteractiveLightBakingData_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetLayerCullDistances_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetLayerCullDistances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetLayerCullDistances_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper d)
	{
		SetLayerCullDistances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref d));
	}

	public static bool get_useOcclusionCulling_Injected(System.IntPtr _unity_self)
	{
		return get_useOcclusionCulling_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_cullingMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_cullingMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_cullingMatrix_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_cullingMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void ResetCullingMatrix_Injected(System.IntPtr _unity_self)
	{
		ResetCullingMatrix_InjectedDelegateField(_unity_self);
	}

	public static bool get_clearStencilAfterLightingPass_Injected(System.IntPtr _unity_self)
	{
		return get_clearStencilAfterLightingPass_InjectedDelegateField(_unity_self);
	}

	public static void set_clearStencilAfterLightingPass_Injected(System.IntPtr _unity_self, bool value)
	{
		set_clearStencilAfterLightingPass_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void SetReplacementShader_Injected(System.IntPtr _unity_self, System.IntPtr shader, ref ManagedSpanWrapper replacementTag)
	{
		SetReplacementShader_InjectedDelegateField(_unity_self, shader, (nint)Unsafe.AsPointer(ref replacementTag));
	}

	public static void ResetReplacementShader_Injected(System.IntPtr _unity_self)
	{
		ResetReplacementShader_InjectedDelegateField(_unity_self);
	}

	public static ProjectionMatrixMode get_projectionMatrixMode_Injected(System.IntPtr _unity_self)
	{
		return get_projectionMatrixMode_InjectedDelegateField(_unity_self);
	}

	public static void set_usePhysicalProperties_Injected(System.IntPtr _unity_self, bool value)
	{
		set_usePhysicalProperties_InjectedDelegateField(_unity_self, value);
	}

	public static int get_iso_Injected(System.IntPtr _unity_self)
	{
		return get_iso_InjectedDelegateField(_unity_self);
	}

	public static void set_iso_Injected(System.IntPtr _unity_self, int value)
	{
		set_iso_InjectedDelegateField(_unity_self, value);
	}

	public static float get_shutterSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_shutterSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_shutterSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		set_shutterSpeed_InjectedDelegateField(_unity_self, value);
	}

	public static float get_aperture_Injected(System.IntPtr _unity_self)
	{
		return get_aperture_InjectedDelegateField(_unity_self);
	}

	public static void set_aperture_Injected(System.IntPtr _unity_self, float value)
	{
		set_aperture_InjectedDelegateField(_unity_self, value);
	}

	public static float get_focusDistance_Injected(System.IntPtr _unity_self)
	{
		return get_focusDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_focusDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_focusDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_focalLength_Injected(System.IntPtr _unity_self)
	{
		return get_focalLength_InjectedDelegateField(_unity_self);
	}

	public static void set_focalLength_Injected(System.IntPtr _unity_self, float value)
	{
		set_focalLength_InjectedDelegateField(_unity_self, value);
	}

	public static int get_bladeCount_Injected(System.IntPtr _unity_self)
	{
		return get_bladeCount_InjectedDelegateField(_unity_self);
	}

	public static void set_bladeCount_Injected(System.IntPtr _unity_self, int value)
	{
		set_bladeCount_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_curvature_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_curvature_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_curvature_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_curvature_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_barrelClipping_Injected(System.IntPtr _unity_self)
	{
		return get_barrelClipping_InjectedDelegateField(_unity_self);
	}

	public static void set_barrelClipping_Injected(System.IntPtr _unity_self, float value)
	{
		set_barrelClipping_InjectedDelegateField(_unity_self, value);
	}

	public static float get_anamorphism_Injected(System.IntPtr _unity_self)
	{
		return get_anamorphism_InjectedDelegateField(_unity_self);
	}

	public static void set_anamorphism_Injected(System.IntPtr _unity_self, float value)
	{
		set_anamorphism_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_sensorSize_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_sensorSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_sensorSize_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_sensorSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_lensShift_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_lensShift_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static GateFitMode get_gateFit_Injected(System.IntPtr _unity_self)
	{
		return get_gateFit_InjectedDelegateField(_unity_self);
	}

	public static void set_gateFit_Injected(System.IntPtr _unity_self, GateFitMode value)
	{
		set_gateFit_InjectedDelegateField(_unity_self, value);
	}

	public static float GetGateFittedFieldOfView_Injected(System.IntPtr _unity_self)
	{
		return GetGateFittedFieldOfView_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetGateFittedLensShift_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		GetGateFittedLensShift_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetLocalSpaceAim_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		GetLocalSpaceAim_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_pixelRect_Injected(System.IntPtr _unity_self, [In] ref Rect value)
	{
		set_pixelRect_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static System.IntPtr get_activeTexture_Injected(System.IntPtr _unity_self)
	{
		return get_activeTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_targetDisplay_Injected(System.IntPtr _unity_self, int value)
	{
		set_targetDisplay_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void SetTargetBuffersImpl_Injected(System.IntPtr _unity_self, [In] ref RenderBuffer color, [In] ref RenderBuffer depth)
	{
		SetTargetBuffersImpl_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref color), (nint)Unsafe.AsPointer(ref depth));
	}

	public unsafe static void SetTargetBuffersMRTImpl_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper color, [In] ref RenderBuffer depth)
	{
		SetTargetBuffersMRTImpl_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref color), (nint)Unsafe.AsPointer(ref depth));
	}

	public static Il2CppStringArray GetCameraBufferWarnings_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetCameraBufferWarnings_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static void set_worldToCameraMatrix_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_worldToCameraMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_projectionMatrix_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_projectionMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_nonJitteredProjectionMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_nonJitteredProjectionMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_nonJitteredProjectionMatrix_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_nonJitteredProjectionMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(System.IntPtr _unity_self)
	{
		return get_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField(_unity_self);
	}

	public static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useJitteredProjectionMatrixForTransparentRendering_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_previousViewProjectionMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_previousViewProjectionMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void ResetWorldToCameraMatrix_Injected(System.IntPtr _unity_self)
	{
		ResetWorldToCameraMatrix_InjectedDelegateField(_unity_self);
	}

	public static void ResetProjectionMatrix_Injected(System.IntPtr _unity_self)
	{
		ResetProjectionMatrix_InjectedDelegateField(_unity_self);
	}

	public unsafe static void CalculateObliqueMatrix_Injected(System.IntPtr _unity_self, [In] ref Vector4 clipPlane, out Matrix4x4 ret)
	{
		CalculateObliqueMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref clipPlane), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetFrustumPlaneSizeAt_Injected(System.IntPtr _unity_self, float distance, out Vector2 ret)
	{
		GetFrustumPlaneSizeAt_InjectedDelegateField(_unity_self, distance, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ViewportPointToRay_Injected(System.IntPtr _unity_self, [In] ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		ViewportPointToRay_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref pos), eye, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CalculateFrustumCornersInternal_Injected(System.IntPtr _unity_self, [In] ref Rect viewport, float z, MonoOrStereoscopicEye eye, out BlittableArrayWrapper outCorners)
	{
		CalculateFrustumCornersInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref viewport), z, eye, (nint)Unsafe.AsPointer(ref outCorners));
	}

	public unsafe static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, [In] ref Vector2 sensorSize, [In] ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode)
	{
		CalculateProjectionMatrixFromPhysicalPropertiesInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref output), focalLength, (nint)Unsafe.AsPointer(ref sensorSize), (nint)Unsafe.AsPointer(ref lensShift), nearClip, farClip, gateAspect, gateFitMode);
	}

	public unsafe static void get_scene_Injected(System.IntPtr _unity_self, out Scene ret)
	{
		get_scene_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_scene_Injected(System.IntPtr _unity_self, [In] ref Scene value)
	{
		set_scene_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_stereoSeparation_Injected(System.IntPtr _unity_self)
	{
		return get_stereoSeparation_InjectedDelegateField(_unity_self);
	}

	public static void set_stereoSeparation_Injected(System.IntPtr _unity_self, float value)
	{
		set_stereoSeparation_InjectedDelegateField(_unity_self, value);
	}

	public static float get_stereoConvergence_Injected(System.IntPtr _unity_self)
	{
		return get_stereoConvergence_InjectedDelegateField(_unity_self);
	}

	public static void set_stereoConvergence_Injected(System.IntPtr _unity_self, float value)
	{
		set_stereoConvergence_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(System.IntPtr _unity_self)
	{
		return get_areVRStereoViewMatricesWithinSingleCullTolerance_InjectedDelegateField(_unity_self);
	}

	public static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(System.IntPtr _unity_self)
	{
		return get_stereoTargetEyeInternal_InjectedDelegateField(_unity_self);
	}

	public static void set_stereoTargetEyeInternal_Injected(System.IntPtr _unity_self, StereoTargetEyeMask value)
	{
		set_stereoTargetEyeInternal_InjectedDelegateField(_unity_self, value);
	}

	public static MonoOrStereoscopicEye get_stereoActiveEye_Injected(System.IntPtr _unity_self)
	{
		return get_stereoActiveEye_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetStereoNonJitteredProjectionMatrix_Injected(System.IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret)
	{
		GetStereoNonJitteredProjectionMatrix_InjectedDelegateField(_unity_self, eye, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetStereoViewMatrix_Injected(System.IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret)
	{
		GetStereoViewMatrix_InjectedDelegateField(_unity_self, eye, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(System.IntPtr _unity_self, StereoscopicEye eye)
	{
		CopyStereoDeviceProjectionMatrixToNonJittered_InjectedDelegateField(_unity_self, eye);
	}

	public unsafe static void GetStereoProjectionMatrix_Injected(System.IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret)
	{
		GetStereoProjectionMatrix_InjectedDelegateField(_unity_self, eye, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void ResetStereoProjectionMatrices_Injected(System.IntPtr _unity_self)
	{
		ResetStereoProjectionMatrices_InjectedDelegateField(_unity_self);
	}

	public static void ResetStereoViewMatrices_Injected(System.IntPtr _unity_self)
	{
		ResetStereoViewMatrices_InjectedDelegateField(_unity_self);
	}

	public static bool RenderToCubemapImpl_Injected(System.IntPtr _unity_self, System.IntPtr tex, int faceMask)
	{
		return RenderToCubemapImpl_InjectedDelegateField(_unity_self, tex, faceMask);
	}

	public static bool get_renderCloudsInSceneView_Injected(System.IntPtr _unity_self)
	{
		return get_renderCloudsInSceneView_InjectedDelegateField(_unity_self);
	}

	public static void set_renderCloudsInSceneView_Injected(System.IntPtr _unity_self, bool value)
	{
		set_renderCloudsInSceneView_InjectedDelegateField(_unity_self, value);
	}

	public static bool RenderToCubemapEyeImpl_Injected(System.IntPtr _unity_self, System.IntPtr cubemap, int faceMask, MonoOrStereoscopicEye stereoEye)
	{
		return RenderToCubemapEyeImpl_InjectedDelegateField(_unity_self, cubemap, faceMask, stereoEye);
	}

	public unsafe static void RenderWithShader_Injected(System.IntPtr _unity_self, System.IntPtr shader, ref ManagedSpanWrapper replacementTag)
	{
		RenderWithShader_InjectedDelegateField(_unity_self, shader, (nint)Unsafe.AsPointer(ref replacementTag));
	}

	public static void RenderDontRestore_Injected(System.IntPtr _unity_self)
	{
		RenderDontRestore_InjectedDelegateField(_unity_self);
	}

	public static void SubmitRenderRequestsInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object requests)
	{
		SubmitRenderRequestsInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requests));
	}

	public static Il2CppReferenceArray<Object> SubmitBuiltInObjectIDRenderRequest_Injected(System.IntPtr _unity_self, System.IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
		System.IntPtr intPtr = SubmitBuiltInObjectIDRenderRequest_InjectedDelegateField(_unity_self, target, mipLevel, cubemapFace, depthSlice);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
	}

	public static void CopyFrom_Injected(System.IntPtr _unity_self, System.IntPtr other)
	{
		CopyFrom_InjectedDelegateField(_unity_self, other);
	}

	public static int get_commandBufferCount_Injected(System.IntPtr _unity_self)
	{
		return get_commandBufferCount_InjectedDelegateField(_unity_self);
	}

	public static void RemoveCommandBuffersImpl_Injected(System.IntPtr _unity_self, CameraEvent evt)
	{
		RemoveCommandBuffersImpl_InjectedDelegateField(_unity_self, evt);
	}

	public static void RemoveAllCommandBuffersImpl_Injected(System.IntPtr _unity_self)
	{
		RemoveAllCommandBuffersImpl_InjectedDelegateField(_unity_self);
	}

	public static void AddCommandBufferImpl_Injected(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer)
	{
		AddCommandBufferImpl_InjectedDelegateField(_unity_self, evt, buffer);
	}

	public static void AddCommandBufferAsyncImpl_Injected(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer, ComputeQueueType queueType)
	{
		AddCommandBufferAsyncImpl_InjectedDelegateField(_unity_self, evt, buffer, queueType);
	}

	public static void RemoveCommandBufferImpl_Injected(System.IntPtr _unity_self, CameraEvent evt, System.IntPtr buffer)
	{
		RemoveCommandBufferImpl_InjectedDelegateField(_unity_self, evt, buffer);
	}

	public static Il2CppReferenceArray<CommandBuffer> GetCommandBuffersImpl_Injected(System.IntPtr _unity_self, CameraEvent evt)
	{
		System.IntPtr intPtr = GetCommandBuffersImpl_InjectedDelegateField(_unity_self, evt);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CommandBuffer>>(intPtr) : null;
	}
}
