using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class ScriptableRenderPass : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_CameraTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderPassEvent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorStoreActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__requiresIntermediateTexture_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverriddenColorStoreActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverriddenDepthStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfingSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__overrideCameraTarget_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isBlitRenderPass_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__useNativeRenderPass_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__breakGBufferAndDeferredRenderPass_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorAttachmentIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAttachmentIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderTargetFormat_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorAttachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAttachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InputAttachmentIsTransient;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Input;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorAttachment_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearColor_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_requiresIntermediateTexture_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_requiresIntermediateTexture_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passName_FamOrAssem_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_breakGBufferAndDeferredRenderPass_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_breakGBufferAndDeferredRenderPass_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_New_Void_RenderGraph_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0;

	public unsafe static RTHandle k_CameraTarget
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CameraTarget, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CameraTarget, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderPassEvent _renderPassEvent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderPassEvent_k__BackingField);
			return *(RenderPassEvent*)num;
		}
		set
		{
			*(RenderPassEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderPassEvent_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStructArray<RenderBufferStoreAction> m_ColorStoreActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStoreActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStoreActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderBufferStoreAction m_DepthStoreAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthStoreAction);
			return *(RenderBufferStoreAction*)num;
		}
		set
		{
			*(RenderBufferStoreAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthStoreAction)) = value;
		}
	}

	public unsafe bool _requiresIntermediateTexture_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__requiresIntermediateTexture_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__requiresIntermediateTexture_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStructArray<bool> m_OverriddenColorStoreActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OverriddenColorStoreActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OverriddenColorStoreActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_OverriddenDepthStoreAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OverriddenDepthStoreAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OverriddenDepthStoreAction)) = value;
		}
	}

	public unsafe ProfilingSampler m_ProfingSampler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfingSampler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfingSampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_PassName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe RenderGraphSettings m_RenderGraphSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _overrideCameraTarget_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overrideCameraTarget_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overrideCameraTarget_k__BackingField)) = value;
		}
	}

	public unsafe bool _isBlitRenderPass_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isBlitRenderPass_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isBlitRenderPass_k__BackingField)) = value;
		}
	}

	public unsafe bool _useNativeRenderPass_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useNativeRenderPass_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useNativeRenderPass_k__BackingField)) = value;
		}
	}

	public unsafe bool _breakGBufferAndDeferredRenderPass_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__breakGBufferAndDeferredRenderPass_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__breakGBufferAndDeferredRenderPass_k__BackingField)) = value;
		}
	}

	public unsafe int _renderPassQueueIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField)) = value;
		}
	}

	public unsafe NativeArray<int> m_ColorAttachmentIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAttachmentIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAttachmentIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_InputAttachmentIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachmentIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachmentIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<GraphicsFormat> _renderTargetFormat_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTargetFormat_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTargetFormat_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> m_ColorAttachments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAttachments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorAttachments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> m_InputAttachments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<bool> m_InputAttachmentIsTransient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachmentIsTransient);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InputAttachmentIsTransient)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DepthAttachment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthAttachment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthAttachment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ScriptableRenderPassInput m_Input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input);
			return *(ScriptableRenderPassInput*)num;
		}
		set
		{
			*(ScriptableRenderPassInput*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input)) = value;
		}
	}

	public unsafe ClearFlag m_ClearFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearFlag);
			return *(ClearFlag*)num;
		}
		set
		{
			*(ClearFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearFlag)) = value;
		}
	}

	public unsafe Color m_ClearColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearColor)) = value;
		}
	}

	public unsafe RenderPassEvent renderPassEvent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderPassEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<RenderTargetIdentifier> colorAttachments
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083346, XrefRangeEnd = 1083352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStructArray<RenderTargetIdentifier> colorAttachment
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083352, XrefRangeEnd = 1083358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorAttachment_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
		}
	}

	public unsafe RenderTargetIdentifier depthAttachment
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083358, XrefRangeEnd = 1083364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> colorAttachmentHandles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
		}
	}

	public unsafe RTHandle colorAttachmentHandle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe RTHandle depthAttachmentHandle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStructArray<RenderBufferStoreAction> colorStoreActions
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
		}
	}

	public unsafe RenderBufferStoreAction depthStoreAction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderBufferStoreAction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<bool> overriddenColorStoreActions
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
	}

	public unsafe bool overriddenDepthStoreAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ScriptableRenderPassInput input
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ScriptableRenderPassInput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ClearFlag clearFlag
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51672, RefRangeEnd = 51673, XrefRangeStart = 51672, XrefRangeEnd = 51673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClearFlag*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Color clearColor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool requiresIntermediateTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requiresIntermediateTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_requiresIntermediateTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProfilingSampler profilingSampler
	{
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1083372, RefRangeEnd = 1083426, XrefRangeStart = 1083364, XrefRangeEnd = 1083372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1083431, RefRangeEnd = 1083465, XrefRangeStart = 1083426, XrefRangeEnd = 1083431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string passName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passName_FamOrAssem_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool overrideCameraTarget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isBlitRenderPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool useNativeRenderPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool breakGBufferAndDeferredRenderPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_breakGBufferAndDeferredRenderPass_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_breakGBufferAndDeferredRenderPass_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int renderPassQueueIndex
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148973, RefRangeEnd = 148983, XrefRangeStart = 148973, XrefRangeEnd = 148983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<GraphicsFormat> renderTargetFormat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ScriptableRenderPass()
	{
		Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScriptableRenderPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr);
		NativeFieldInfoPtr_k_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "k_CameraTarget");
		NativeFieldInfoPtr__renderPassEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderPassEvent>k__BackingField");
		NativeFieldInfoPtr_m_ColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorStoreActions");
		NativeFieldInfoPtr_m_DepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_DepthStoreAction");
		NativeFieldInfoPtr__requiresIntermediateTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<requiresIntermediateTexture>k__BackingField");
		NativeFieldInfoPtr_m_OverriddenColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_OverriddenColorStoreActions");
		NativeFieldInfoPtr_m_OverriddenDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_OverriddenDepthStoreAction");
		NativeFieldInfoPtr_m_ProfingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ProfingSampler");
		NativeFieldInfoPtr_m_PassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_PassName");
		NativeFieldInfoPtr_m_RenderGraphSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_RenderGraphSettings");
		NativeFieldInfoPtr__overrideCameraTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<overrideCameraTarget>k__BackingField");
		NativeFieldInfoPtr__isBlitRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<isBlitRenderPass>k__BackingField");
		NativeFieldInfoPtr__useNativeRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<useNativeRenderPass>k__BackingField");
		NativeFieldInfoPtr__breakGBufferAndDeferredRenderPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<breakGBufferAndDeferredRenderPass>k__BackingField");
		NativeFieldInfoPtr__renderPassQueueIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderPassQueueIndex>k__BackingField");
		NativeFieldInfoPtr_m_ColorAttachmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorAttachmentIndices");
		NativeFieldInfoPtr_m_InputAttachmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachmentIndices");
		NativeFieldInfoPtr__renderTargetFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "<renderTargetFormat>k__BackingField");
		NativeFieldInfoPtr_m_ColorAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ColorAttachments");
		NativeFieldInfoPtr_m_InputAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachments");
		NativeFieldInfoPtr_m_InputAttachmentIsTransient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_InputAttachmentIsTransient");
		NativeFieldInfoPtr_m_DepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_DepthAttachment");
		NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_Input");
		NativeFieldInfoPtr_m_ClearFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ClearFlag");
		NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, "m_ClearColor");
		NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_get_renderPassEvent_Public_get_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_set_renderPassEvent_Public_set_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_get_colorAttachments_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr_get_colorAttachment_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr_get_depthAttachment_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_get_colorAttachmentHandles_Public_get_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_get_colorAttachmentHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_get_depthAttachmentHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_get_overriddenColorStoreActions_Internal_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_get_overriddenDepthStoreAction_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_get_input_Public_get_ScriptableRenderPassInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_get_clearFlag_Public_get_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_get_clearColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_get_requiresIntermediateTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_set_requiresIntermediateTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_get_profilingSampler_FamOrAssem_get_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_set_profilingSampler_FamOrAssem_set_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_get_passName_FamOrAssem_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_get_overrideCameraTarget_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_set_overrideCameraTarget_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_get_isBlitRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_set_isBlitRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_get_useNativeRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_set_useNativeRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_get_breakGBufferAndDeferredRenderPass_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_set_breakGBufferAndDeferredRenderPass_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_get_renderPassQueueIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_set_renderPassQueueIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_get_renderTargetFormat_Internal_get_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_set_renderTargetFormat_Internal_set_Void_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_ResetTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664237);
		NativeMethodInfoPtr_Execute_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_New_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr, 100664250);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 906993, RefRangeEnd = 906994, XrefRangeStart = 906993, XrefRangeEnd = 906994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FrameCleanup(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FrameCleanup_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1083467, RefRangeEnd = 1083486, XrefRangeStart = 1083465, XrefRangeEnd = 1083467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DebugHandler GetActiveDebugHandler(UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveDebugHandler_Internal_Static_DebugHandler_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 1083542, RefRangeEnd = 1083587, XrefRangeStart = 1083486, XrefRangeEnd = 1083542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableRenderPass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureInput(ScriptableRenderPassInput passInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&passInput);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureInput_Public_Void_ScriptableRenderPassInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&storeAction);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attachmentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureColorStoreAction_Public_Void_RenderBufferStoreAction_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083587, XrefRangeEnd = 1083591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureColorStoreActions(Il2CppStructArray<RenderBufferStoreAction> storeActions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storeActions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureColorStoreActions_Public_Void_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083591, RefRangeEnd = 1083592, XrefRangeStart = 1083591, XrefRangeEnd = 1083591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&storeAction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDepthStoreAction_Public_Void_RenderBufferStoreAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083592, XrefRangeEnd = 1083594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureInputAttachments(RTHandle input, bool isTransient = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTransient;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureInputAttachments(Il2CppReferenceArray<RTHandle> inputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083596, RefRangeEnd = 1083597, XrefRangeStart = 1083594, XrefRangeEnd = 1083596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureInputAttachments(Il2CppReferenceArray<RTHandle> inputs, Il2CppStructArray<bool> isTransient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isTransient);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureInputAttachments_Internal_Void_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetInputAttachmentTransient(int idx, bool isTransient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idx);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTransient;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputAttachmentTransient_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsInputAttachmentTransient(int idx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInputAttachmentTransient_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083601, RefRangeEnd = 1083602, XrefRangeStart = 1083597, XrefRangeEnd = 1083601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083602, XrefRangeEnd = 1083608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&colorAttachment);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthAttachment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1083613, RefRangeEnd = 1083618, XrefRangeStart = 1083608, XrefRangeEnd = 1083613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083618, XrefRangeEnd = 1083624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(Il2CppStructArray<RenderTargetIdentifier> colorAttachments, RenderTargetIdentifier depthAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthAttachment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1083656, RefRangeEnd = 1083662, XrefRangeStart = 1083624, XrefRangeEnd = 1083656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments, RTHandle depthAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083664, RefRangeEnd = 1083665, XrefRangeStart = 1083662, XrefRangeEnd = 1083664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments, RTHandle depthAttachment, Il2CppStructArray<GraphicsFormat> formats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Internal_Void_Il2CppReferenceArray_1_RTHandle_RTHandle_Il2CppStructArray_1_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083665, XrefRangeEnd = 1083671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(RenderTargetIdentifier colorAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&colorAttachment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1083680, RefRangeEnd = 1083690, XrefRangeStart = 1083671, XrefRangeEnd = 1083680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(RTHandle colorAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083690, XrefRangeEnd = 1083696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(Il2CppStructArray<RenderTargetIdentifier> colorAttachments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083696, XrefRangeEnd = 1083701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureTarget(Il2CppReferenceArray<RTHandle> colorAttachments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureTarget_Public_Void_Il2CppReferenceArray_1_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1083701, RefRangeEnd = 1083711, XrefRangeStart = 1083701, XrefRangeEnd = 1083701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureClear(ClearFlag clearFlag, Color clearColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clearFlag);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureClear_Public_Void_ClearFlag_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_New_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraTextureDescriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCameraCleanup(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnFinishCameraStackRendering_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083711, XrefRangeEnd = 1083720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083720, XrefRangeEnd = 1083729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_New_Void_RenderGraph_ContextContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083729, XrefRangeEnd = 1083735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1083743, RefRangeEnd = 1083745, XrefRangeStart = 1083735, XrefRangeEnd = 1083743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_RTHandle_RTHandle_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083745, XrefRangeEnd = 1083749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083749, XrefRangeEnd = 1083753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Void_CommandBuffer_byref_RenderingData_RTHandle_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083753, XrefRangeEnd = 1083766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&shaderTagId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083770, RefRangeEnd = 1083771, XrefRangeStart = 1083766, XrefRangeEnd = 1083770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&shaderTagId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083771, XrefRangeEnd = 1083784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shaderTagIdList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083784, XrefRangeEnd = 1083788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shaderTagIdList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(SortingCriteria**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingCriteria;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Public_DrawingSettings_List_1_ShaderTagId_UniversalRenderingData_UniversalCameraData_UniversalLightData_SortingCriteria_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1083800, RefRangeEnd = 1083804, XrefRangeStart = 1083788, XrefRangeEnd = 1083800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderPassEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderPassEventRange_Internal_Static_Int32_RenderPassEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ScriptableRenderPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
