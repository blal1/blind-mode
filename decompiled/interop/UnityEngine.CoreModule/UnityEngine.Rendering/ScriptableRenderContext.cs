using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ScriptableRenderContext
{
	[StructLayout(LayoutKind.Explicit)]
	public struct CullShadowCastersContext
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cullResults;

		private static readonly System.IntPtr NativeFieldInfoPtr_splitBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_splitBufferLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfos;

		private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfoCount;

		[FieldOffset(0)]
		public System.IntPtr cullResults;

		[FieldOffset(8)]
		public System.IntPtr splitBuffer;

		[FieldOffset(16)]
		public int splitBufferLength;

		[FieldOffset(24)]
		public System.IntPtr perLightInfos;

		[FieldOffset(32)]
		public int perLightInfoCount;

		static CullShadowCastersContext()
		{
			Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "CullShadowCastersContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr);
			NativeFieldInfoPtr_cullResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, "cullResults");
			NativeFieldInfoPtr_splitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, "splitBuffer");
			NativeFieldInfoPtr_splitBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, "splitBufferLength");
			NativeFieldInfoPtr_perLightInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, "perLightInfos");
			NativeFieldInfoPtr_perLightInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, "perLightInfoCount");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullShadowCastersContext>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public enum SkyboxXRMode
	{
		Off,
		Enabled,
		LegacySinglePass
	}

	private delegate void PushDisableApiRenderersDelegate();

	private delegate void PopDisableApiRenderersDelegate();

	private delegate void DrawShadows_InternalDelegate(System.IntPtr @this, System.IntPtr shadowDrawingSettings);

	private delegate void InvokeOnRenderObjectCallback_InternalDelegate(System.IntPtr @this);

	private delegate void DrawRenderers_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr cullResults, System.IntPtr drawingSettings, System.IntPtr filteringSettings, [In] System.IntPtr tagName, bool isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, int stateCount);

	private delegate void StereoEndRender_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera, int eye, bool isFinalPass);

	private delegate void StartMultiEye_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera, int eye);

	private delegate void StopMultiEye_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

	private delegate void DrawSkybox_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

	private delegate void DrawGizmos_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera, GizmoSubset gizmoSubset);

	private delegate void DrawUIOverlay_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr camera);

	private static readonly System.IntPtr NativeFieldInfoPtr_kRenderTypeTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Internal_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Internal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPtr_Internal_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSubPass_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRenderPass_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EmitGeometryForCamera_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0;

	[FieldOffset(0)]
	public System.IntPtr m_Ptr;

	public const bool deprecateDrawXmethods = false;

	private static readonly PushDisableApiRenderersDelegate PushDisableApiRenderersDelegateField;

	private static readonly PopDisableApiRenderersDelegate PopDisableApiRenderersDelegateField;

	private static readonly DrawShadows_InternalDelegate DrawShadows_InternalDelegateField;

	private static readonly InvokeOnRenderObjectCallback_InternalDelegate InvokeOnRenderObjectCallback_InternalDelegateField;

	private static readonly DrawRenderers_Internal_InjectedDelegate DrawRenderers_Internal_InjectedDelegateField;

	private static readonly StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;

	private static readonly StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;

	private static readonly StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;

	private static readonly DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;

	private static readonly DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;

	private static readonly DrawUIOverlay_Internal_InjectedDelegate DrawUIOverlay_Internal_InjectedDelegateField;

	public unsafe static ShaderTagId kRenderTypeTag
	{
		get
		{
			Unsafe.SkipInit(out ShaderTagId result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kRenderTypeTag, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kRenderTypeTag, (void*)(&value));
		}
	}

	static ScriptableRenderContext()
	{
		Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableRenderContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
		NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "kRenderTypeTag");
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668658);
		NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668659);
		NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668660);
		NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668661);
		NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Internal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668662);
		NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668663);
		NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668664);
		NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668665);
		NativeMethodInfoPtr_Submit_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668666);
		NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668667);
		NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668668);
		NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668669);
		NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668670);
		NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668671);
		NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668672);
		NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668673);
		NativeMethodInfoPtr_Internal_GetPtr_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668674);
		NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668675);
		NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668676);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668677);
		NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668678);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668679);
		NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668680);
		NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668681);
		NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668682);
		NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668684);
		NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668685);
		NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668686);
		NativeMethodInfoPtr_EndSubPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668687);
		NativeMethodInfoPtr_EndRenderPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668688);
		NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668689);
		NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668690);
		NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668691);
		NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668692);
		NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668693);
		NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668694);
		NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668695);
		NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668696);
		NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668697);
		NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668698);
		NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668699);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668700);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668701);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668702);
		NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668703);
		NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668704);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668705);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668706);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668707);
		NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668708);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668709);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668710);
		NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668711);
		NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668712);
		NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668713);
		NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668715);
		NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668716);
		NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668717);
		NativeMethodInfoPtr_EmitGeometryForCamera_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668718);
		NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668719);
		NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668720);
		NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668721);
		NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668722);
		NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668723);
		NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668724);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668725);
		NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668726);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668727);
		NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668728);
		NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100668729);
		PushDisableApiRenderersDelegateField = IL2CPP.ResolveICall<PushDisableApiRenderersDelegate>("UnityEngine.Rendering.ScriptableRenderContext::PushDisableApiRenderers");
		PopDisableApiRenderersDelegateField = IL2CPP.ResolveICall<PopDisableApiRenderersDelegate>("UnityEngine.Rendering.ScriptableRenderContext::PopDisableApiRenderers");
		DrawShadows_InternalDelegateField = IL2CPP.ResolveICall<DrawShadows_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal");
		InvokeOnRenderObjectCallback_InternalDelegateField = IL2CPP.ResolveICall<InvokeOnRenderObjectCallback_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal");
		DrawRenderers_Internal_InjectedDelegateField = IL2CPP.ResolveICall<DrawRenderers_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawRenderers_Internal_Injected");
		StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
		StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
		StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
		DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
		DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
		DrawUIOverlay_Internal_InjectedDelegateField = IL2CPP.ResolveICall<DrawUIOverlay_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawUIOverlay_Internal_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239180, XrefRangeEnd = 1239182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginRenderPass_Internal(System.IntPtr self, int width, int height, int volumeDepth, int samples, System.IntPtr colors, int colorCount, int depthAttachmentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeDepth;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &samples;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colors;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorCount;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthAttachmentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRenderPass_Internal_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239182, XrefRangeEnd = 1239184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginSubPass_Internal(System.IntPtr self, System.IntPtr colors, int colorCount, System.IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colors;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorCount;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputs;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDepthReadOnly;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &isStencilReadOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSubPass_Internal_Private_Static_Void_IntPtr_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239184, XrefRangeEnd = 1239186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndSubPass_Internal(System.IntPtr self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSubPass_Internal_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239186, XrefRangeEnd = 1239188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndRenderPass_Internal(System.IntPtr self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRenderPass_Internal_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239188, XrefRangeEnd = 1239190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasInvokeOnRenderObjectCallbacks_Internal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Internal_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239190, XrefRangeEnd = 1239195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, System.IntPtr results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref parameters);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderLoop;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &results;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Cull_Private_Static_Void_byref_ScriptableCullingParameters_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239195, XrefRangeEnd = 1239200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CullShadowCasters(ScriptableRenderContext renderLoop, System.IntPtr context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderLoop);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CullShadowCasters_Private_Static_Void_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239200, XrefRangeEnd = 1239208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sortingSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSortSettings_Internal_Static_Void_Camera_byref_SortingSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239208, XrefRangeEnd = 1239210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Submit_Internal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Submit_Internal_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239210, XrefRangeEnd = 1239212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SubmitForRenderPassValidation_Internal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitForRenderPassValidation_Internal_Private_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239212, XrefRangeEnd = 1239214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCameras_Internal(Il2CppSystem.Type listType, Il2CppSystem.Object resultList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameras_Internal_Private_Void_Type_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239222, RefRangeEnd = 1239223, XrefRangeStart = 1239214, XrefRangeEnd = 1239222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EmitGeometryForCamera(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EmitGeometryForCamera_Public_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239223, XrefRangeEnd = 1239229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Private_Void_CommandBuffer_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239229, XrefRangeEnd = 1239235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandBuffer);
		*(ComputeQueueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Private_Void_CommandBuffer_ComputeQueueType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239247, RefRangeEnd = 1239248, XrefRangeStart = 1239235, XrefRangeEnd = 1239247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoSetup;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCameraProperties_Internal_Private_Void_Camera_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239260, RefRangeEnd = 1239261, XrefRangeStart = 1239248, XrefRangeEnd = 1239260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWireOverlay_Impl(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireOverlay_Impl_Private_Void_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(255)]
	[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr Internal_GetPtr()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPtr_Internal_IntPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239266, RefRangeEnd = 1239267, XrefRangeStart = 1239261, XrefRangeEnd = 1239266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateRendererList_Internal(System.IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, int stateCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&cullResults);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(ShaderTagId**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tagName;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPassTagName;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &tagValues;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateBlocks;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_Private_RendererList_IntPtr_byref_DrawingSettings_byref_FilteringSettings_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239267, XrefRangeEnd = 1239272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateShadowRendererList_Internal(System.IntPtr shadowDrawinSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shadowDrawinSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowRendererList_Internal_Private_RendererList_IntPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239272, XrefRangeEnd = 1239281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateSkyboxRendererList_Internal(Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &proj;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &projR;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewR;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Private_RendererList_Camera_Int32_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239281, XrefRangeEnd = 1239290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateGizmoRendererList_Internal(Camera camera, GizmoSubset gizmoSubset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(GizmoSubset**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gizmoSubset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Private_RendererList_Camera_GizmoSubset_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239290, XrefRangeEnd = 1239299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateUIOverlayRendererList_Internal(Camera camera, UISubset uiSubset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(UISubset**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uiSubset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Private_RendererList_Camera_UISubset_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239299, XrefRangeEnd = 1239308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateWireOverlayRendererList_Internal(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Private_RendererList_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239308, XrefRangeEnd = 1239310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareRendererListsAsync_Internal(Il2CppSystem.Object rendererLists)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererLists);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareRendererListsAsync_Internal_Private_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239310, XrefRangeEnd = 1239315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryRendererListStatus_Internal_Private_RendererListStatus_RendererList_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239324, RefRangeEnd = 1239325, XrefRangeStart = 1239315, XrefRangeEnd = 1239324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &samples;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)attachments));
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthAttachmentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRenderPass_Public_Void_Int32_Int32_Int32_NativeArray_1_AttachmentDescriptor_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239337, RefRangeEnd = 1239339, XrefRangeStart = 1239325, XrefRangeEnd = 1239337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)colors));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inputs));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDepthStencilReadOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_NativeArray_1_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239348, RefRangeEnd = 1239350, XrefRangeStart = 1239339, XrefRangeEnd = 1239348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)colors));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDepthStencilReadOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSubPass_Public_Void_NativeArray_1_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239355, RefRangeEnd = 1239358, XrefRangeStart = 1239350, XrefRangeEnd = 1239355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndSubPass()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSubPass_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239363, RefRangeEnd = 1239364, XrefRangeStart = 1239358, XrefRangeEnd = 1239363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndRenderPass()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRenderPass_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239374, RefRangeEnd = 1239377, XrefRangeStart = 1239364, XrefRangeEnd = 1239374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Submit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Submit_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239382, RefRangeEnd = 1239383, XrefRangeStart = 1239377, XrefRangeEnd = 1239382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SubmitForRenderPassValidation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitForRenderPassValidation_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239388, RefRangeEnd = 1239389, XrefRangeStart = 1239383, XrefRangeEnd = 1239388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasInvokeOnRenderObjectCallbacks()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInvokeOnRenderObjectCallbacks_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239399, RefRangeEnd = 1239400, XrefRangeStart = 1239389, XrefRangeEnd = 1239399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCameras(List<Camera> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameras_Internal_Void_List_1_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1239420, RefRangeEnd = 1239444, XrefRangeStart = 1239400, XrefRangeEnd = 1239420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCommandBuffer(CommandBuffer commandBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Void_CommandBuffer_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239464, RefRangeEnd = 1239466, XrefRangeStart = 1239444, XrefRangeEnd = 1239464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandBuffer);
		*(ComputeQueueType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBufferAsync_Public_Void_CommandBuffer_ComputeQueueType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239466, XrefRangeEnd = 1239470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoSetup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239474, RefRangeEnd = 1239475, XrefRangeStart = 1239470, XrefRangeEnd = 1239474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoSetup;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCameraProperties_Public_Void_Camera_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239479, RefRangeEnd = 1239480, XrefRangeStart = 1239475, XrefRangeEnd = 1239479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWireOverlay(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireOverlay_Public_Void_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239489, RefRangeEnd = 1239490, XrefRangeStart = 1239480, XrefRangeEnd = 1239489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CullingResults Cull(ref ScriptableCullingParameters parameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cull_Public_CullingResults_byref_ScriptableCullingParameters_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CullingResults*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239505, RefRangeEnd = 1239506, XrefRangeStart = 1239490, XrefRangeEnd = 1239505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullShadowCasters(CullingResults cullingResults, ShadowCastersCullingInfos infos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullingResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)infos));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullShadowCasters_Public_Void_CullingResults_ShadowCastersCullingInfos_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239506, XrefRangeEnd = 1239509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(ScriptableRenderContext other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239509, XrefRangeEnd = 1239517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1239532, RefRangeEnd = 1239543, XrefRangeStart = 1239517, XrefRangeEnd = 1239532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateRendererList(ref RendererListParams param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Public_RendererList_byref_RendererListParams_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1239552, RefRangeEnd = 1239557, XrefRangeStart = 1239543, XrefRangeEnd = 1239552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateShadowRendererList(ref ShadowDrawingSettings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererList_byref_ShadowDrawingSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239569, RefRangeEnd = 1239571, XrefRangeStart = 1239557, XrefRangeEnd = 1239569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixR;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixR;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239587, RefRangeEnd = 1239589, XrefRangeStart = 1239571, XrefRangeEnd = 1239587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_Matrix4x4_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239609, RefRangeEnd = 1239611, XrefRangeStart = 1239589, XrefRangeEnd = 1239609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateSkyboxRendererList(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererList_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239623, RefRangeEnd = 1239624, XrefRangeStart = 1239611, XrefRangeEnd = 1239623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateGizmoRendererList(Camera camera, GizmoSubset gizmoSubset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(GizmoSubset**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gizmoSubset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererList_Camera_GizmoSubset_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239636, RefRangeEnd = 1239637, XrefRangeStart = 1239624, XrefRangeEnd = 1239636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateUIOverlayRendererList(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239649, RefRangeEnd = 1239650, XrefRangeStart = 1239637, XrefRangeEnd = 1239649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateUIOverlayRendererList(Camera camera, UISubset uiSubset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(UISubset**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uiSubset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererList_Camera_UISubset_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239662, RefRangeEnd = 1239663, XrefRangeStart = 1239650, XrefRangeEnd = 1239662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererList CreateWireOverlayRendererList(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererList_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererList*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239668, RefRangeEnd = 1239669, XrefRangeStart = 1239663, XrefRangeEnd = 1239668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareRendererListsAsync(List<RendererList> rendererLists)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererLists);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareRendererListsAsync_Public_Void_List_1_RendererList_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239677, RefRangeEnd = 1239678, XrefRangeStart = 1239669, XrefRangeEnd = 1239677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListStatus QueryRendererListStatus(RendererList rendererList)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rendererList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryRendererListStatus_Public_RendererListStatus_RendererList_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239678, XrefRangeEnd = 1239680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, [In] ref ScriptableRenderContext renderLoop, System.IntPtr results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref parameters);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderLoop);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &results;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Cull_Injected_Private_Static_Void_byref_ScriptableCullingParameters_byref_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239680, XrefRangeEnd = 1239682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CullShadowCasters_Injected([In] ref ScriptableRenderContext renderLoop, System.IntPtr context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref renderLoop);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CullShadowCasters_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239682, XrefRangeEnd = 1239684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeSortSettings_Injected(System.IntPtr camera, out SortingSettings sortingSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&camera);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sortingSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSortSettings_Injected_Private_Static_Void_IntPtr_byref_SortingSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239684, XrefRangeEnd = 1239686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EmitGeometryForCamera_Injected(System.IntPtr camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EmitGeometryForCamera_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239686, XrefRangeEnd = 1239688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr commandBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &commandBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBuffer_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239688, XrefRangeEnd = 1239690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr commandBuffer, ComputeQueueType queueType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &commandBuffer;
		*(ComputeQueueType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBufferAsync_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_ComputeQueueType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239690, XrefRangeEnd = 1239692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, bool stereoSetup, int eye)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoSetup;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &eye;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCameraProperties_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239692, XrefRangeEnd = 1239694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireOverlay_Impl_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239694, XrefRangeEnd = 1239696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, [In] ref ShaderTagId tagName, bool isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, int stateCount, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullResults;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tagName);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPassTagName;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &tagValues;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateBlocks;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateCount;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_DrawingSettings_byref_FilteringSettings_byref_ShaderTagId_Boolean_IntPtr_IntPtr_Int32_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239696, XrefRangeEnd = 1239698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateShadowRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr shadowDrawinSettings, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowDrawinSettings;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239698, XrefRangeEnd = 1239700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, int mode, [In] ref Matrix4x4 proj, [In] ref Matrix4x4 view, [In] ref Matrix4x4 projR, [In] ref Matrix4x4 viewR, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref proj);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref view);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projR);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewR);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239700, XrefRangeEnd = 1239702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateGizmoRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, GizmoSubset gizmoSubset, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(GizmoSubset**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gizmoSubset;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGizmoRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_GizmoSubset_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239702, XrefRangeEnd = 1239704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateUIOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, UISubset uiSubset, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(UISubset**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uiSubset;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_UISubset_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239704, XrefRangeEnd = 1239706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWireOverlayRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, out RendererList ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWireOverlayRendererList_Internal_Injected_Private_Static_Void_byref_ScriptableRenderContext_IntPtr_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239706, XrefRangeEnd = 1239708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, [In] ref RendererList handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryRendererListStatus_Internal_Injected_Private_Static_RendererListStatus_byref_ScriptableRenderContext_byref_RendererList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static void PushDisableApiRenderers()
	{
		PushDisableApiRenderersDelegateField();
	}

	public static void PopDisableApiRenderers()
	{
		PopDisableApiRenderersDelegateField();
	}

	public void DrawRenderers_Internal(System.IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, int stateCount)
	{
		DrawRenderers_Internal_Injected(ref this, cullResults, ref drawingSettings, ref filteringSettings, ref tagName, isPassTagName, tagValues, stateBlocks, stateCount);
	}

	public unsafe void DrawShadows_Internal(System.IntPtr shadowDrawingSettings)
	{
		//IL_000b: Expected O, but got Ref
		DrawShadows_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), shadowDrawingSettings);
	}

	public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		StereoEndRender_Internal_Injected(ref this, intPtr, eye, isFinalPass);
	}

	public void StartMultiEye_Internal(Camera camera, int eye)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		StartMultiEye_Internal_Injected(ref this, intPtr, eye);
	}

	public void StopMultiEye_Internal(Camera camera)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		StopMultiEye_Internal_Injected(ref this, intPtr);
	}

	public void DrawSkybox_Internal(Camera camera)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		DrawSkybox_Internal_Injected(ref this, intPtr);
	}

	public unsafe void InvokeOnRenderObjectCallback_Internal()
	{
		//IL_000b: Expected O, but got Ref
		InvokeOnRenderObjectCallback_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		DrawGizmos_Internal_Injected(ref this, intPtr, gizmoSubset);
	}

	public void DrawUIOverlay_Internal(Camera camera)
	{
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		DrawUIOverlay_Internal_Injected(ref this, intPtr);
	}

	public unsafe void BeginRenderPass(int width, int height, int volumeDepth, int samples, NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
	{
		//IL_001f: Expected O, but got Ref
		BeginRenderPass_Internal(m_Ptr, width, height, volumeDepth, samples, (System.IntPtr)attachments.GetUnsafeReadOnlyPtr(), ((NativeArray<AttachmentDescriptor>)(&attachments)).Length, depthAttachmentIndex);
	}

	public ScopedRenderPass BeginScopedRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, [Optional] int depthAttachmentIndex)
	{
		BeginRenderPass(width, height, samples, attachments, depthAttachmentIndex);
		return new ScopedRenderPass(this);
	}

	public unsafe void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
	{
		//IL_0019: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		BeginSubPass_Internal(m_Ptr, (System.IntPtr)colors.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&colors)).Length, (System.IntPtr)inputs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&inputs)).Length, isDepthReadOnly, isStencilReadOnly);
	}

	public unsafe void BeginSubPass(NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
	{
		//IL_0019: Expected O, but got Ref
		BeginSubPass_Internal(m_Ptr, (System.IntPtr)colors.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&colors)).Length, Il2CppSystem.IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
	}

	public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
	{
		BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
		return new ScopedSubPass(this);
	}

	public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
	{
		BeginSubPass(colors, inputs, isDepthStencilReadOnly);
		return new ScopedSubPass(this);
	}

	public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
	{
		BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
		return new ScopedSubPass(this);
	}

	public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
	{
		BeginSubPass(colors, isDepthStencilReadOnly);
		return new ScopedSubPass(this);
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings)
	{
		DrawRenderers_Internal(cullingResults.ptr, ref drawingSettings, ref filteringSettings, ShaderTagId.none, isPassTagName: false, Il2CppSystem.IntPtr.Zero, Il2CppSystem.IntPtr.Zero, 0);
	}

	public unsafe void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock)
	{
		ShaderTagId shaderTagId = default(ShaderTagId);
		fixed (RenderStateBlock* ptr = &stateBlock)
		{
			DrawRenderers_Internal(cullingResults.ptr, ref drawingSettings, ref filteringSettings, ShaderTagId.none, isPassTagName: false, (System.IntPtr)(void*)(&shaderTagId), (System.IntPtr)(void*)ptr, 1);
		}
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, NativeArray<ShaderTagId> renderTypes, NativeArray<RenderStateBlock> stateBlocks)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe void DrawShadows(ref ShadowDrawingSettings settings)
	{
		fixed (ShadowDrawingSettings* ptr = &settings)
		{
			DrawShadows_Internal((System.IntPtr)(void*)ptr);
		}
	}

	public void StereoEndRender(Camera camera)
	{
		StereoEndRender(camera, 0, isFinalPass: true);
	}

	public void StereoEndRender(Camera camera, int eye)
	{
		StereoEndRender(camera, eye, isFinalPass: true);
	}

	public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
	{
		StereoEndRender_Internal(camera, eye, isFinalPass);
	}

	public void StartMultiEye(Camera camera)
	{
		StartMultiEye(camera, 0);
	}

	public void StartMultiEye(Camera camera, int eye)
	{
		StartMultiEye_Internal(camera, eye);
	}

	public void StopMultiEye(Camera camera)
	{
		StopMultiEye_Internal(camera);
	}

	public void DrawSkybox(Camera camera)
	{
		DrawSkybox_Internal(camera);
	}

	public void InvokeOnRenderObjectCallback()
	{
		InvokeOnRenderObjectCallback_Internal();
	}

	public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
	{
		DrawGizmos_Internal(camera, gizmoSubset);
	}

	public void DrawUIOverlay(Camera camera)
	{
		DrawUIOverlay_Internal(camera);
	}

	public unsafe void ValidateCullShadowCastersParameters([In] ref CullingResults cullingResults, [In] ref ShadowCastersCullingInfos cullingInfos)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_004a: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//IL_00ae: Expected O, but got Ref
		//IL_007b: Expected O, but got Ref
		//IL_0086: Expected O, but got Ref
		//IL_008e: Expected O, but got Ref
		//IL_02a1: Expected O, but got Ref
		//IL_02a9: Expected O, but got Ref
		//IL_0111: Expected O, but got Ref
		//IL_011a: Expected O, but got Ref
		//IL_0144: Expected O, but got Ref
		//IL_014d: Expected O, but got Ref
		//IL_01ab: Expected O, but got Ref
		//IL_01b4: Expected O, but got Ref
		if (false)
		{
			throw new UnityException("CullingResults is null");
		}
		NativeArray<LightShadowCasterCullingInfo> perLightInfos = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).perLightInfos;
		if (((NativeArray<LightShadowCasterCullingInfo>)(&perLightInfos)).Length == 0)
		{
			return;
		}
		CullingResults cullingResults2 = cullingResults;
		NativeArray<VisibleLight> visibleLights = cullingResults2.visibleLights;
		int length = ((NativeArray<VisibleLight>)(&visibleLights)).Length;
		perLightInfos = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).perLightInfos;
		if (length != ((NativeArray<LightShadowCasterCullingInfo>)(&perLightInfos)).Length)
		{
			cullingResults2 = cullingResults;
			visibleLights = cullingResults2.visibleLights;
			object arg = ((NativeArray<VisibleLight>)(&visibleLights)).Length;
			perLightInfos = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).perLightInfos;
			throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("CullingResults.visibleLights.Length ({0}) != ShadowCastersCullingInfos.perLightInfos.Length ({1}). ", (Il2CppSystem.Object)arg, (Il2CppSystem.Object)(object)((NativeArray<LightShadowCasterCullingInfo>)(&perLightInfos)).Length), "ShadowCastersCullingInfos.perLightInfos must have one entry per visible light."));
		}
		LightShadowCasterCullingInfo* unsafeReadOnlyPtr = (LightShadowCasterCullingInfo*)((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).perLightInfos.GetUnsafeReadOnlyPtr();
		int num = 0;
		while (true)
		{
			int num2 = num;
			perLightInfos = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).perLightInfos;
			if (num2 >= ((NativeArray<LightShadowCasterCullingInfo>)(&perLightInfos)).Length)
			{
				break;
			}
			ref LightShadowCasterCullingInfo reference = ref unsafeReadOnlyPtr[num];
			RangeInt splitRange = reference.splitRange;
			int start = splitRange.start;
			int length2 = splitRange.length;
			int num3 = start + length2;
			if (start != 0 || length2 != 0)
			{
				NativeArray<ShadowSplitData> splitBuffer;
				int num4;
				if (start >= 0)
				{
					splitBuffer = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).splitBuffer;
					num4 = ((start <= ((NativeArray<ShadowSplitData>)(&splitBuffer)).Length) ? 1 : 0);
				}
				else
				{
					num4 = 0;
				}
				bool flag = (byte)num4 != 0;
				bool flag2 = length2 >= 0 && length2 <= 6;
				int num5;
				if (num3 >= start)
				{
					splitBuffer = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).splitBuffer;
					num5 = ((num3 <= ((NativeArray<ShadowSplitData>)(&splitBuffer)).Length) ? 1 : 0);
				}
				else
				{
					num5 = 0;
				}
				bool flag3 = (byte)num5 != 0;
				if (!(flag && flag2 && flag3))
				{
					string str = Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}] is referring to an invalid memory location. ", (Il2CppSystem.Object)(object)num);
					string str2 = Il2CppSystem.String.Format("splitRange.start ({0}) splitRange.length ({1}) ", (Il2CppSystem.Object)(object)splitRange.start, (Il2CppSystem.Object)(object)splitRange.length);
					splitBuffer = ((ShadowCastersCullingInfos)Unsafe.AsPointer(ref cullingInfos)).splitBuffer;
					throw new UnityException(Il2CppSystem.String.Concat(str, str2, Il2CppSystem.String.Format("ShadowCastersCullingInfos.splitBuffer.Length ({0}).", (Il2CppSystem.Object)(object)((NativeArray<ShadowSplitData>)(&splitBuffer)).Length)));
				}
				if (length2 > 0 && reference.projectionType == BatchCullingProjectionType.Unknown)
				{
					throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}].projectionType == {1}. ", (Il2CppSystem.Object)(object)num, (Il2CppSystem.Object)(object)reference.projectionType), Il2CppSystem.String.Format("The range however appears to be valid. splitRange.start ({0}) splitRange.length ({1}).", (Il2CppSystem.Object)(object)splitRange.start, (Il2CppSystem.Object)(object)splitRange.length)));
				}
				if (reference.splitExclusionMask >> length2 != 0)
				{
					string arg2 = Il2CppSystem.Convert.ToString(reference.splitExclusionMask, 2);
					throw new UnityException(Il2CppSystem.String.Concat(Il2CppSystem.String.Format("ShadowCastersCullingInfos.perLightInfos[{0}].splitExclusionMask == 0b{1}. ", (Il2CppSystem.Object)(object)num, arg2), Il2CppSystem.String.Format("The highest bit set must be less than the split count. splitRange.start ({0}) splitRange.length ({1}).", (Il2CppSystem.Object)(object)splitRange.start, (Il2CppSystem.Object)(object)splitRange.length)));
				}
			}
			num++;
		}
	}

	public void Validate()
	{
	}

	public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
	{
		return !left.Equals(right);
	}

	public unsafe RendererList CreateRendererList(RendererListDesc desc)
	{
		//IL_0019: Expected O, but got Ref
		RendererListParams param = RendererListDesc.ConvertToParameters(ref desc);
		RendererList result = CreateRendererList(ref param);
		((RendererListParams)(&param)).Dispose();
		return result;
	}

	public unsafe static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, [In] ref ShaderTagId tagName, bool isPassTagName, System.IntPtr tagValues, System.IntPtr stateBlocks, int stateCount)
	{
		DrawRenderers_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), cullResults, (nint)Unsafe.AsPointer(ref drawingSettings), (nint)Unsafe.AsPointer(ref filteringSettings), (nint)Unsafe.AsPointer(ref tagName), isPassTagName, tagValues, stateBlocks, stateCount);
	}

	public unsafe static void StereoEndRender_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, int eye, bool isFinalPass)
	{
		StereoEndRender_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera, eye, isFinalPass);
	}

	public unsafe static void StartMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, int eye)
	{
		StartMultiEye_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera, eye);
	}

	public unsafe static void StopMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera)
	{
		StopMultiEye_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera);
	}

	public unsafe static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera)
	{
		DrawSkybox_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera);
	}

	public unsafe static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera, GizmoSubset gizmoSubset)
	{
		DrawGizmos_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera, gizmoSubset);
	}

	public unsafe static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, System.IntPtr camera)
	{
		DrawUIOverlay_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), camera);
	}
}
