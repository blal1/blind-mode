using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

[Serializable]
public class UniversalRendererData : ScriptableRendererData
{
	private static readonly IntPtr NativeFieldInfoPtr_xrSystemData;

	private static readonly IntPtr NativeFieldInfoPtr_postProcessData;

	private static readonly IntPtr NativeFieldInfoPtr_k_LatestAssetVersion;

	private static readonly IntPtr NativeFieldInfoPtr_m_AssetVersion;

	private static readonly IntPtr NativeFieldInfoPtr_m_OpaqueLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_m_TransparentLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

	private static readonly IntPtr NativeFieldInfoPtr_m_ShadowTransparentReceive;

	private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

	private static readonly IntPtr NativeFieldInfoPtr_m_DepthPrimingMode;

	private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthMode;

	private static readonly IntPtr NativeFieldInfoPtr_m_DepthAttachmentFormat;

	private static readonly IntPtr NativeFieldInfoPtr_m_DepthTextureFormat;

	private static readonly IntPtr NativeFieldInfoPtr_m_AccurateGbufferNormals;

	private static readonly IntPtr NativeFieldInfoPtr_m_IntermediateTextureMode;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripShadowsOffVariants;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripAdditionalLightOffVariants;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_depthAttachmentFormat_Public_get_DepthFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_depthAttachmentFormat_Public_set_Void_DepthFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_depthTextureFormat_Public_get_DepthFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_depthTextureFormat_Public_set_Void_DepthFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_Virtual_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_Virtual_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe XRSystemData xrSystemData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrSystemData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<XRSystemData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrSystemData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PostProcessData postProcessData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_LatestAssetVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LatestAssetVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LatestAssetVersion, (void*)(&value));
		}
	}

	public unsafe int m_AssetVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetVersion)) = value;
		}
	}

	public unsafe LayerMask m_OpaqueLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueLayerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueLayerMask)) = value;
		}
	}

	public unsafe LayerMask m_TransparentLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransparentLayerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransparentLayerMask)) = value;
		}
	}

	public unsafe StencilStateData m_DefaultStencilState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultStencilState);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultStencilState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_ShadowTransparentReceive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowTransparentReceive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowTransparentReceive)) = value;
		}
	}

	public unsafe RenderingMode m_RenderingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingMode);
			return *(RenderingMode*)num;
		}
		set
		{
			*(RenderingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingMode)) = value;
		}
	}

	public unsafe DepthPrimingMode m_DepthPrimingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingMode);
			return *(DepthPrimingMode*)num;
		}
		set
		{
			*(DepthPrimingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingMode)) = value;
		}
	}

	public unsafe CopyDepthMode m_CopyDepthMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthMode);
			return *(CopyDepthMode*)num;
		}
		set
		{
			*(CopyDepthMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthMode)) = value;
		}
	}

	public unsafe DepthFormat m_DepthAttachmentFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthAttachmentFormat);
			return *(DepthFormat*)num;
		}
		set
		{
			*(DepthFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthAttachmentFormat)) = value;
		}
	}

	public unsafe DepthFormat m_DepthTextureFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthTextureFormat);
			return *(DepthFormat*)num;
		}
		set
		{
			*(DepthFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthTextureFormat)) = value;
		}
	}

	public unsafe bool m_AccurateGbufferNormals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccurateGbufferNormals);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AccurateGbufferNormals)) = value;
		}
	}

	public unsafe IntermediateTextureMode m_IntermediateTextureMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntermediateTextureMode);
			return *(IntermediateTextureMode*)num;
		}
		set
		{
			*(IntermediateTextureMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntermediateTextureMode)) = value;
		}
	}

	public new unsafe bool m_StripShadowsOffVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripShadowsOffVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripShadowsOffVariants)) = value;
		}
	}

	public new unsafe bool m_StripAdditionalLightOffVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripAdditionalLightOffVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripAdditionalLightOffVariants)) = value;
		}
	}

	public unsafe LayerMask opaqueLayerMask
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87098, RefRangeEnd = 87099, XrefRangeStart = 87098, XrefRangeEnd = 87099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LayerMask transparentLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilStateData defaultStencilState
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<StencilStateData>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086302, XrefRangeEnd = 1086303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool shadowTransparentReceive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderingMode renderingMode
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33830, RefRangeEnd = 33833, XrefRangeStart = 33830, XrefRangeEnd = 33833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DepthPrimingMode depthPrimingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthPrimingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CopyDepthMode copyDepthMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CopyDepthMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DepthFormat depthAttachmentFormat
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086310, RefRangeEnd = 1086311, XrefRangeStart = 1086303, XrefRangeEnd = 1086310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthAttachmentFormat_Public_get_DepthFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086311, XrefRangeEnd = 1086321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthAttachmentFormat_Public_set_Void_DepthFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DepthFormat depthTextureFormat
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086334, RefRangeEnd = 1086335, XrefRangeStart = 1086321, XrefRangeEnd = 1086334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthTextureFormat_Public_get_DepthFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthTextureFormat_Public_set_Void_DepthFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool accurateGbufferNormals
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51101, RefRangeEnd = 51102, XrefRangeStart = 51101, XrefRangeEnd = 51102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe IntermediateTextureMode intermediateTextureMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(IntermediateTextureMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override bool stripShadowsOffVariants
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override bool stripAdditionalLightOffVariants
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static UniversalRendererData()
	{
		Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRendererData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr);
		NativeFieldInfoPtr_xrSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "xrSystemData");
		NativeFieldInfoPtr_postProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "postProcessData");
		NativeFieldInfoPtr_k_LatestAssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "k_LatestAssetVersion");
		NativeFieldInfoPtr_m_AssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_AssetVersion");
		NativeFieldInfoPtr_m_OpaqueLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_OpaqueLayerMask");
		NativeFieldInfoPtr_m_TransparentLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_TransparentLayerMask");
		NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DefaultStencilState");
		NativeFieldInfoPtr_m_ShadowTransparentReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_ShadowTransparentReceive");
		NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_RenderingMode");
		NativeFieldInfoPtr_m_DepthPrimingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DepthPrimingMode");
		NativeFieldInfoPtr_m_CopyDepthMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_CopyDepthMode");
		NativeFieldInfoPtr_m_DepthAttachmentFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DepthAttachmentFormat");
		NativeFieldInfoPtr_m_DepthTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_DepthTextureFormat");
		NativeFieldInfoPtr_m_AccurateGbufferNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_AccurateGbufferNormals");
		NativeFieldInfoPtr_m_IntermediateTextureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_IntermediateTextureMode");
		NativeFieldInfoPtr_m_StripShadowsOffVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_StripShadowsOffVariants");
		NativeFieldInfoPtr_m_StripAdditionalLightOffVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, "m_StripAdditionalLightOffVariants");
		NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_get_opaqueLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_set_opaqueLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_get_transparentLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_set_transparentLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_get_defaultStencilState_Public_get_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_set_defaultStencilState_Public_set_Void_StencilStateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_get_shadowTransparentReceive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_set_shadowTransparentReceive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_get_copyDepthMode_Public_get_CopyDepthMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_set_copyDepthMode_Public_set_Void_CopyDepthMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664448);
		NativeMethodInfoPtr_get_depthAttachmentFormat_Public_get_DepthFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_set_depthAttachmentFormat_Public_set_Void_DepthFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_get_depthTextureFormat_Public_get_DepthFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_set_depthTextureFormat_Public_set_Void_DepthFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_get_accurateGbufferNormals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_set_accurateGbufferNormals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_get_intermediateTextureMode_Public_get_IntermediateTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_set_intermediateTextureMode_Public_set_Void_IntermediateTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664462);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664464);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr, 100664465);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086294, XrefRangeEnd = 1086302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ScriptableRenderer Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Create_Protected_Virtual_ScriptableRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 883425, RefRangeEnd = 883431, XrefRangeStart = 883425, XrefRangeEnd = 883431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReloadAllNullProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadAllNullProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086335, XrefRangeEnd = 1086344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRendererData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRendererData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRendererData(IntPtr pointer)
		: base(pointer)
	{
	}
}
