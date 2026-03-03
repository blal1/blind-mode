using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public class XRPass : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Views;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OcclusionMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr__copyDepth_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__hasMotionVectorPass_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__spaceWarpRightHandedNDC_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__multipassId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__cullingPassId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderTarget_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderTargetDesc_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__motionVectorRenderTarget_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__motionVectorRenderTargetDesc_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__cullingParams_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__occlusionMeshScale_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasMotionVectorPass_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasMotionVectorPass_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spaceWarpRightHandedNDC_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spaceWarpRightHandedNDC_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isFirstCameraPass_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isLastCameraPass_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionVectorRenderTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_motionVectorRenderTarget_Private_set_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionVectorRenderTargetDesc_Public_get_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_motionVectorRenderTargetDesc_Private_set_Void_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrevViewValid_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrevViewMatrix_Public_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartSinglePass_Public_Void_IRasterCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSinglePass_Public_Void_BaseCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_RasterCommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebugXRViewsFrustum_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddView_Internal_Void_XRView_0;

	public unsafe List<XRView> m_Views
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Views);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<XRView>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Views)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XROcclusionMesh m_OcclusionMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XROcclusionMesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _copyDepth_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__copyDepth_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__copyDepth_k__BackingField)) = value;
		}
	}

	public unsafe bool _hasMotionVectorPass_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasMotionVectorPass_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasMotionVectorPass_k__BackingField)) = value;
		}
	}

	public unsafe bool _spaceWarpRightHandedNDC_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spaceWarpRightHandedNDC_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spaceWarpRightHandedNDC_k__BackingField)) = value;
		}
	}

	public unsafe int _multipassId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__multipassId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__multipassId_k__BackingField)) = value;
		}
	}

	public unsafe int _cullingPassId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingPassId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingPassId_k__BackingField)) = value;
		}
	}

	public unsafe RenderTargetIdentifier _renderTarget_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTarget_k__BackingField);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTarget_k__BackingField)) = value;
		}
	}

	public unsafe RenderTextureDescriptor _renderTargetDesc_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTargetDesc_k__BackingField);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTargetDesc_k__BackingField)) = value;
		}
	}

	public unsafe RenderTargetIdentifier _motionVectorRenderTarget_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorRenderTarget_k__BackingField);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorRenderTarget_k__BackingField)) = value;
		}
	}

	public unsafe RenderTextureDescriptor _motionVectorRenderTargetDesc_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorRenderTargetDesc_k__BackingField);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorRenderTargetDesc_k__BackingField)) = value;
		}
	}

	public unsafe ScriptableCullingParameters _cullingParams_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingParams_k__BackingField);
			return *(ScriptableCullingParameters*)num;
		}
		set
		{
			*(ScriptableCullingParameters*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingParams_k__BackingField)) = value;
		}
	}

	public unsafe System.IntPtr _foveatedRenderingInfo_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField)) = value;
		}
	}

	public unsafe float _occlusionMeshScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__occlusionMeshScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__occlusionMeshScale_k__BackingField)) = value;
		}
	}

	public unsafe bool enabled
	{
		[CallerCount(134)]
		[CachedScanResults(RefRangeStart = 1025255, RefRangeEnd = 1025389, XrefRangeStart = 1025254, XrefRangeEnd = 1025255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsFoveatedRendering
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1025397, RefRangeEnd = 1025421, XrefRangeStart = 1025389, XrefRangeEnd = 1025397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool copyDepth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasMotionVectorPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasMotionVectorPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasMotionVectorPass_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool spaceWarpRightHandedNDC
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spaceWarpRightHandedNDC_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spaceWarpRightHandedNDC_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isFirstCameraPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFirstCameraPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isLastCameraPass
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025421, XrefRangeEnd = 1025423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isLastCameraPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int multipassId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int cullingPassId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTargetIdentifier renderTarget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTextureDescriptor renderTargetDesc
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTargetIdentifier motionVectorRenderTarget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorRenderTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorRenderTarget_Private_set_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTextureDescriptor motionVectorRenderTargetDesc
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorRenderTargetDesc_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorRenderTargetDesc_Private_set_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ScriptableCullingParameters cullingParams
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025423, XrefRangeEnd = 1025424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ScriptableCullingParameters*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025424, XrefRangeEnd = 1025425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int viewCount
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1025426, RefRangeEnd = 1025439, XrefRangeStart = 1025425, XrefRangeEnd = 1025426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool singlePassEnabled
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1025440, RefRangeEnd = 1025481, XrefRangeStart = 1025439, XrefRangeEnd = 1025440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe System.IntPtr foveatedRenderingInfo
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isHDRDisplayOutputActive
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025490, RefRangeEnd = 1025492, XrefRangeStart = 1025481, XrefRangeEnd = 1025490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ColorGamut hdrDisplayOutputColorGamut
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1025501, RefRangeEnd = 1025502, XrefRangeStart = 1025492, XrefRangeEnd = 1025501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1025539, RefRangeEnd = 1025540, XrefRangeStart = 1025502, XrefRangeEnd = 1025539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HDROutputUtils.HDRDisplayInformation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float occlusionMeshScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasValidOcclusionMesh
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1025636, RefRangeEnd = 1025640, XrefRangeStart = 1025634, XrefRangeEnd = 1025636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XRPass()
	{
		Il2CppClassPointerStore<XRPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_Views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "m_Views");
		NativeFieldInfoPtr_m_OcclusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "m_OcclusionMesh");
		NativeFieldInfoPtr__copyDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<copyDepth>k__BackingField");
		NativeFieldInfoPtr__hasMotionVectorPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<hasMotionVectorPass>k__BackingField");
		NativeFieldInfoPtr__spaceWarpRightHandedNDC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<spaceWarpRightHandedNDC>k__BackingField");
		NativeFieldInfoPtr__multipassId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<multipassId>k__BackingField");
		NativeFieldInfoPtr__cullingPassId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<cullingPassId>k__BackingField");
		NativeFieldInfoPtr__renderTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<renderTarget>k__BackingField");
		NativeFieldInfoPtr__renderTargetDesc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<renderTargetDesc>k__BackingField");
		NativeFieldInfoPtr__motionVectorRenderTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<motionVectorRenderTarget>k__BackingField");
		NativeFieldInfoPtr__motionVectorRenderTargetDesc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<motionVectorRenderTargetDesc>k__BackingField");
		NativeFieldInfoPtr__cullingParams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<cullingParams>k__BackingField");
		NativeFieldInfoPtr__foveatedRenderingInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<foveatedRenderingInfo>k__BackingField");
		NativeFieldInfoPtr__occlusionMeshScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPass>.NativeClassPtr, "<occlusionMeshScale>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_get_supportsFoveatedRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_get_copyDepth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_set_copyDepth_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_get_hasMotionVectorPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_set_hasMotionVectorPass_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_get_spaceWarpRightHandedNDC_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_spaceWarpRightHandedNDC_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_get_isFirstCameraPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_get_isLastCameraPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_multipassId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_set_multipassId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_get_cullingPassId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_set_cullingPassId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_get_renderTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_renderTarget_Private_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_renderTargetDesc_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_set_renderTargetDesc_Private_set_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_get_motionVectorRenderTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_set_motionVectorRenderTarget_Private_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_get_motionVectorRenderTargetDesc_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_set_motionVectorRenderTargetDesc_Private_set_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_get_cullingParams_Public_get_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_set_cullingParams_Private_set_Void_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_viewCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_get_singlePassEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_foveatedRenderingInfo_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_set_foveatedRenderingInfo_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_get_hdrDisplayOutputColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_get_hdrDisplayOutputInformation_Public_get_HDRDisplayInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_occlusionMeshScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_set_occlusionMeshScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_GetViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_GetPrevViewValid_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_GetPrevViewMatrix_Public_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_StartSinglePass_Public_Void_IRasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_StopSinglePass_Public_Void_BaseCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_hasValidOcclusionMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_RasterCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_RenderDebugXRViewsFrustum_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_AddView_Internal_Void_XRView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPass>.NativeClassPtr, 100663418);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025239, RefRangeEnd = 1025240, XrefRangeStart = 1025225, XrefRangeEnd = 1025239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRPass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025240, XrefRangeEnd = 1025248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRPass CreateDefault(XRPassCreateInfo createInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)createInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefault_Public_Static_XRPass_XRPassCreateInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025248, XrefRangeEnd = 1025254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1025543, RefRangeEnd = 1025549, XrefRangeStart = 1025540, XrefRangeEnd = 1025543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetProjMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1025552, RefRangeEnd = 1025561, XrefRangeStart = 1025549, XrefRangeEnd = 1025552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025561, XrefRangeEnd = 1025564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPrevViewValid(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrevViewValid_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025564, XrefRangeEnd = 1025567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetPrevViewMatrix(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrevViewMatrix_Public_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1025570, RefRangeEnd = 1025576, XrefRangeStart = 1025567, XrefRangeEnd = 1025570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rect GetViewport(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewport_Public_Rect_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025579, RefRangeEnd = 1025580, XrefRangeStart = 1025576, XrefRangeEnd = 1025579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mesh GetOcclusionMesh(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOcclusionMesh_Public_Mesh_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1025583, RefRangeEnd = 1025586, XrefRangeStart = 1025580, XrefRangeEnd = 1025583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTextureArraySlice(int viewIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureArraySlice_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1025602, RefRangeEnd = 1025608, XrefRangeStart = 1025586, XrefRangeEnd = 1025602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSinglePass(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSinglePass_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1025612, RefRangeEnd = 1025615, XrefRangeStart = 1025608, XrefRangeEnd = 1025612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSinglePass(IRasterCommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSinglePass_Public_Void_IRasterCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1025622, RefRangeEnd = 1025629, XrefRangeStart = 1025615, XrefRangeEnd = 1025622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSinglePass(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSinglePass_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1025631, RefRangeEnd = 1025634, XrefRangeStart = 1025629, XrefRangeEnd = 1025631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSinglePass(BaseCommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSinglePass_Public_Void_BaseCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025640, XrefRangeEnd = 1025641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1025642, RefRangeEnd = 1025645, XrefRangeStart = 1025641, XrefRangeEnd = 1025642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderOcclusionMesh(RasterCommandBuffer cmd, bool renderIntoTexture = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderIntoTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderOcclusionMesh_Public_Void_RasterCommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025645, XrefRangeEnd = 1025661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDebugXRViewsFrustum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebugXRViewsFrustum_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1025673, RefRangeEnd = 1025675, XrefRangeStart = 1025661, XrefRangeEnd = 1025673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 ApplyXRViewCenterOffset(Vector2 center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&center);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyXRViewCenterOffset_Public_Vector4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025679, RefRangeEnd = 1025680, XrefRangeStart = 1025675, XrefRangeEnd = 1025679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignView(int viewId, XRView xrView)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)xrView));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignView_Internal_Void_Int32_XRView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025686, RefRangeEnd = 1025687, XrefRangeStart = 1025680, XrefRangeEnd = 1025686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullingPassId);
		*(ScriptableCullingParameters**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignCullingParams_Internal_Void_Int32_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025687, XrefRangeEnd = 1025689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCombinedOcclusionMesh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCombinedOcclusionMesh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1025715, RefRangeEnd = 1025717, XrefRangeStart = 1025689, XrefRangeEnd = 1025715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitBase(XRPassCreateInfo createInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)createInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBase_Public_Void_XRPassCreateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025728, RefRangeEnd = 1025729, XrefRangeStart = 1025717, XrefRangeEnd = 1025728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddView(XRView xrView)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)xrView));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddView_Internal_Void_XRView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
