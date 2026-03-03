using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine;

public class RenderTexture : Texture
{
	private delegate VRTextureUsage get_vrUsage_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_vrUsage_InjectedDelegate(System.IntPtr _unity_self, VRTextureUsage value);

	private delegate RenderTextureMemoryless get_memorylessMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_memorylessMode_InjectedDelegate(System.IntPtr _unity_self, RenderTextureMemoryless value);

	private delegate GraphicsFormat get_stencilFormat_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stencilFormat_InjectedDelegate(System.IntPtr _unity_self, GraphicsFormat value);

	private delegate bool get_autoGenerateMips_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bindTextureMS_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_enableRandomWrite_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useDynamicScaleExplicit_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool GetIsPowerOfTwo_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetNativeDepthBufferPtr_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void DiscardContents_InjectedDelegate(System.IntPtr _unity_self, bool discardColor, bool discardDepth);

	private delegate void MarkRestoreExpected_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResolveAA_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResolveAATo_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr rt);

	private delegate void SetGlobalShaderProperty_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr propertyName);

	private delegate bool IsCreated_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GenerateMips_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ConvertToEquirect_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr equirect, Camera.MonoOrStereoscopicEye eye);

	private delegate bool SupportsStencil_InjectedDelegate(System.IntPtr rt);

	private delegate int get_depth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_depth_InjectedDelegate(System.IntPtr _unity_self, int value);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bindTextureMS_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDynamicScale_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShadowSamplingMode_Internal_Void_ShadowSamplingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_ShadowSamplingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_DefaultFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WarnAboutFallbackTo16BitsDepth_Internal_Static_Void_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_ShadowSamplingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Injected_Private_Static_TextureDimension_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Injected_Private_Static_Void_IntPtr_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorFormat_Injected_Private_Static_GraphicsFormat_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useMipMap_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useMipMap_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sRGB_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeDepth_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_volumeDepth_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_antiAliasing_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_antiAliasing_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bindTextureMS_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScale_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useDynamicScale_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScaleExplicit_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDynamicScale_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMipMapCount_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShadowSamplingMode_Injected_Private_Static_Void_IntPtr_ShadowSamplingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_IntPtr_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseTemporary_Injected_Private_Static_Void_IntPtr_0;

	private static readonly get_vrUsage_InjectedDelegate get_vrUsage_InjectedDelegateField;

	private static readonly set_vrUsage_InjectedDelegate set_vrUsage_InjectedDelegateField;

	private static readonly get_memorylessMode_InjectedDelegate get_memorylessMode_InjectedDelegateField;

	private static readonly set_memorylessMode_InjectedDelegate set_memorylessMode_InjectedDelegateField;

	private static readonly get_stencilFormat_InjectedDelegate get_stencilFormat_InjectedDelegateField;

	private static readonly set_stencilFormat_InjectedDelegate set_stencilFormat_InjectedDelegateField;

	private static readonly get_autoGenerateMips_InjectedDelegate get_autoGenerateMips_InjectedDelegateField;

	private static readonly set_bindTextureMS_InjectedDelegate set_bindTextureMS_InjectedDelegateField;

	private static readonly get_enableRandomWrite_InjectedDelegate get_enableRandomWrite_InjectedDelegateField;

	private static readonly set_useDynamicScaleExplicit_InjectedDelegate set_useDynamicScaleExplicit_InjectedDelegateField;

	private static readonly GetIsPowerOfTwo_InjectedDelegate GetIsPowerOfTwo_InjectedDelegateField;

	private static readonly GetNativeDepthBufferPtr_InjectedDelegate GetNativeDepthBufferPtr_InjectedDelegateField;

	private static readonly DiscardContents_InjectedDelegate DiscardContents_InjectedDelegateField;

	private static readonly MarkRestoreExpected_InjectedDelegate MarkRestoreExpected_InjectedDelegateField;

	private static readonly ResolveAA_InjectedDelegate ResolveAA_InjectedDelegateField;

	private static readonly ResolveAATo_InjectedDelegate ResolveAATo_InjectedDelegateField;

	private static readonly SetGlobalShaderProperty_InjectedDelegate SetGlobalShaderProperty_InjectedDelegateField;

	private static readonly IsCreated_InjectedDelegate IsCreated_InjectedDelegateField;

	private static readonly GenerateMips_InjectedDelegate GenerateMips_InjectedDelegateField;

	private static readonly ConvertToEquirect_InjectedDelegate ConvertToEquirect_InjectedDelegateField;

	private static readonly SupportsStencil_InjectedDelegate SupportsStencil_InjectedDelegateField;

	private static readonly get_depth_InjectedDelegate get_depth_InjectedDelegateField;

	private static readonly set_depth_InjectedDelegate set_depth_InjectedDelegateField;

	public unsafe override int width
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180894, XrefRangeEnd = 1180899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180899, XrefRangeEnd = 1180904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override int height
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180904, XrefRangeEnd = 1180909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180909, XrefRangeEnd = 1180914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override TextureDimension dimension
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180914, XrefRangeEnd = 1180919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180919, XrefRangeEnd = 1180924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public new unsafe GraphicsFormat graphicsFormat
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1180939, RefRangeEnd = 1180955, XrefRangeStart = 1180934, XrefRangeEnd = 1180939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool useMipMap
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1180960, RefRangeEnd = 1180963, XrefRangeStart = 1180955, XrefRangeEnd = 1180960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1180968, RefRangeEnd = 1180971, XrefRangeStart = 1180963, XrefRangeEnd = 1180968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool sRGB
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1180976, RefRangeEnd = 1180977, XrefRangeStart = 1180971, XrefRangeEnd = 1180976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderTextureFormat format
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1180986, RefRangeEnd = 1180995, XrefRangeStart = 1180977, XrefRangeEnd = 1180986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTextureFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value == RenderTextureFormat.Depth || value == RenderTextureFormat.Shadowmap)
			{
				if (depthStencilFormat == GraphicsFormat.None)
				{
					WarnAboutFallbackTo16BitsDepth(value);
					depthStencilFormat = GraphicsFormat.D16_UNorm;
				}
				if (value == RenderTextureFormat.Shadowmap)
				{
					SetShadowSamplingMode(ShadowSamplingMode.CompareDepths);
				}
			}
			graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(value, sRGB);
		}
	}

	public unsafe GraphicsFormat depthStencilFormat
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1181000, RefRangeEnd = 1181006, XrefRangeStart = 1180995, XrefRangeEnd = 1181000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1181011, RefRangeEnd = 1181012, XrefRangeStart = 1181006, XrefRangeEnd = 1181011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool autoGenerateMips
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoGenerateMips_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1181017, RefRangeEnd = 1181020, XrefRangeStart = 1181012, XrefRangeEnd = 1181017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int volumeDepth
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1181025, RefRangeEnd = 1181029, XrefRangeStart = 1181020, XrefRangeEnd = 1181025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1181034, RefRangeEnd = 1181037, XrefRangeStart = 1181029, XrefRangeEnd = 1181034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int antiAliasing
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1181042, RefRangeEnd = 1181047, XrefRangeStart = 1181037, XrefRangeEnd = 1181042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1181052, RefRangeEnd = 1181053, XrefRangeStart = 1181047, XrefRangeEnd = 1181052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool bindTextureMS
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181053, XrefRangeEnd = 1181058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindTextureMS_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			set_bindTextureMS_Injected(intPtr, value);
		}
	}

	public unsafe bool enableRandomWrite
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableRandomWrite_Injected(intPtr);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1181063, RefRangeEnd = 1181067, XrefRangeStart = 1181058, XrefRangeEnd = 1181063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool useDynamicScale
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1181072, RefRangeEnd = 1181075, XrefRangeStart = 1181067, XrefRangeEnd = 1181072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181080, RefRangeEnd = 1181082, XrefRangeStart = 1181075, XrefRangeEnd = 1181080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool useDynamicScaleExplicit
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181087, RefRangeEnd = 1181089, XrefRangeStart = 1181082, XrefRangeEnd = 1181087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			set_useDynamicScaleExplicit_Injected(intPtr, value);
		}
	}

	public unsafe static RenderTexture active
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1181102, RefRangeEnd = 1181117, XrefRangeStart = 1181102, XrefRangeEnd = 1181117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1181122, RefRangeEnd = 1181145, XrefRangeStart = 1181122, XrefRangeEnd = 1181145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderBuffer colorBuffer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181163, XrefRangeEnd = 1181167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderBuffer*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderBuffer depthBuffer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1181171, RefRangeEnd = 1181172, XrefRangeStart = 1181167, XrefRangeEnd = 1181171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderBuffer*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderTextureDescriptor descriptor
	{
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1181504, RefRangeEnd = 1181537, XrefRangeStart = 1181500, XrefRangeEnd = 1181504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			ValidateRenderTextureDesc(ref value);
			SetRenderTextureDescriptor(value);
		}
	}

	public VRTextureUsage vrUsage
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vrUsage_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_vrUsage_Injected(intPtr, value);
		}
	}

	public RenderTextureMemoryless memorylessMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_memorylessMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_memorylessMode_Injected(intPtr, value);
		}
	}

	public GraphicsFormat stencilFormat
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stencilFormat_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stencilFormat_Injected(intPtr, value);
		}
	}

	public bool isPowerOfTwo
	{
		get
		{
			return GetIsPowerOfTwo();
		}
		set
		{
		}
	}

	public int depth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_depth_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_depth_Injected(intPtr, value);
		}
	}

	public bool isCubemap
	{
		get
		{
			return dimension == TextureDimension.Cube;
		}
		set
		{
			dimension = (value ? TextureDimension.Cube : TextureDimension.Tex2D);
		}
	}

	public bool isVolume
	{
		get
		{
			return dimension == TextureDimension.Tex3D;
		}
		set
		{
			dimension = (value ? TextureDimension.Tex3D : TextureDimension.Tex2D);
		}
	}

	public static bool enabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	static RenderTexture()
	{
		Il2CppClassPointerStore<RenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTexture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr);
		NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665335);
		NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665336);
		NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665337);
		NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665338);
		NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665339);
		NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665340);
		NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665341);
		NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665342);
		NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665343);
		NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665344);
		NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665345);
		NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665346);
		NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665347);
		NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665348);
		NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665350);
		NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665351);
		NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665352);
		NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665353);
		NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665354);
		NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665355);
		NativeMethodInfoPtr_get_bindTextureMS_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665356);
		NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665357);
		NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665358);
		NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665359);
		NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665360);
		NativeMethodInfoPtr_ApplyDynamicScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665361);
		NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665362);
		NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665363);
		NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665364);
		NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665365);
		NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665366);
		NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665367);
		NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665368);
		NativeMethodInfoPtr_SetShadowSamplingMode_Internal_Void_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665369);
		NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665370);
		NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665371);
		NativeMethodInfoPtr_Create_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665372);
		NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665373);
		NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665374);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665375);
		NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665376);
		NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665377);
		NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665378);
		NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665379);
		NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665380);
		NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665381);
		NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665382);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665383);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665384);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665385);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665386);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665387);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665388);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665389);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665390);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665391);
		NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665392);
		NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665393);
		NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665394);
		NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665395);
		NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665396);
		NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665397);
		NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665398);
		NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665399);
		NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665400);
		NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665401);
		NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665402);
		NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665403);
		NativeMethodInfoPtr_WarnAboutFallbackTo16BitsDepth_Internal_Static_Void_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665404);
		NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665405);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665406);
		NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665407);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665408);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665409);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665410);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665411);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665412);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665413);
		NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665414);
		NativeMethodInfoPtr_get_width_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665415);
		NativeMethodInfoPtr_set_width_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665416);
		NativeMethodInfoPtr_get_height_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665417);
		NativeMethodInfoPtr_set_height_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665418);
		NativeMethodInfoPtr_get_dimension_Injected_Private_Static_TextureDimension_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665419);
		NativeMethodInfoPtr_set_dimension_Injected_Private_Static_Void_IntPtr_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665420);
		NativeMethodInfoPtr_GetColorFormat_Injected_Private_Static_GraphicsFormat_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665421);
		NativeMethodInfoPtr_SetColorFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665422);
		NativeMethodInfoPtr_get_useMipMap_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665423);
		NativeMethodInfoPtr_set_useMipMap_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665424);
		NativeMethodInfoPtr_get_sRGB_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665425);
		NativeMethodInfoPtr_get_depthStencilFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665426);
		NativeMethodInfoPtr_set_depthStencilFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665427);
		NativeMethodInfoPtr_set_autoGenerateMips_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665428);
		NativeMethodInfoPtr_get_volumeDepth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665429);
		NativeMethodInfoPtr_set_volumeDepth_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665430);
		NativeMethodInfoPtr_get_antiAliasing_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665431);
		NativeMethodInfoPtr_set_antiAliasing_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665432);
		NativeMethodInfoPtr_get_bindTextureMS_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665433);
		NativeMethodInfoPtr_set_enableRandomWrite_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665434);
		NativeMethodInfoPtr_get_useDynamicScale_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665435);
		NativeMethodInfoPtr_set_useDynamicScale_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665436);
		NativeMethodInfoPtr_get_useDynamicScaleExplicit_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665437);
		NativeMethodInfoPtr_ApplyDynamicScale_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665438);
		NativeMethodInfoPtr_GetActive_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665439);
		NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665440);
		NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665441);
		NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665442);
		NativeMethodInfoPtr_SetMipMapCount_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665443);
		NativeMethodInfoPtr_SetShadowSamplingMode_Injected_Private_Static_Void_IntPtr_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665444);
		NativeMethodInfoPtr_Create_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665445);
		NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665446);
		NativeMethodInfoPtr_SetSRGBReadWrite_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665447);
		NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665448);
		NativeMethodInfoPtr_GetDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665449);
		NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_IntPtr_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665450);
		NativeMethodInfoPtr_ReleaseTemporary_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665451);
		get_vrUsage_InjectedDelegateField = IL2CPP.ResolveICall<get_vrUsage_InjectedDelegate>("UnityEngine.RenderTexture::get_vrUsage_Injected");
		set_vrUsage_InjectedDelegateField = IL2CPP.ResolveICall<set_vrUsage_InjectedDelegate>("UnityEngine.RenderTexture::set_vrUsage_Injected");
		get_memorylessMode_InjectedDelegateField = IL2CPP.ResolveICall<get_memorylessMode_InjectedDelegate>("UnityEngine.RenderTexture::get_memorylessMode_Injected");
		set_memorylessMode_InjectedDelegateField = IL2CPP.ResolveICall<set_memorylessMode_InjectedDelegate>("UnityEngine.RenderTexture::set_memorylessMode_Injected");
		get_stencilFormat_InjectedDelegateField = IL2CPP.ResolveICall<get_stencilFormat_InjectedDelegate>("UnityEngine.RenderTexture::get_stencilFormat_Injected");
		set_stencilFormat_InjectedDelegateField = IL2CPP.ResolveICall<set_stencilFormat_InjectedDelegate>("UnityEngine.RenderTexture::set_stencilFormat_Injected");
		get_autoGenerateMips_InjectedDelegateField = IL2CPP.ResolveICall<get_autoGenerateMips_InjectedDelegate>("UnityEngine.RenderTexture::get_autoGenerateMips_Injected");
		set_bindTextureMS_InjectedDelegateField = IL2CPP.ResolveICall<set_bindTextureMS_InjectedDelegate>("UnityEngine.RenderTexture::set_bindTextureMS_Injected");
		get_enableRandomWrite_InjectedDelegateField = IL2CPP.ResolveICall<get_enableRandomWrite_InjectedDelegate>("UnityEngine.RenderTexture::get_enableRandomWrite_Injected");
		set_useDynamicScaleExplicit_InjectedDelegateField = IL2CPP.ResolveICall<set_useDynamicScaleExplicit_InjectedDelegate>("UnityEngine.RenderTexture::set_useDynamicScaleExplicit_Injected");
		GetIsPowerOfTwo_InjectedDelegateField = IL2CPP.ResolveICall<GetIsPowerOfTwo_InjectedDelegate>("UnityEngine.RenderTexture::GetIsPowerOfTwo_Injected");
		GetNativeDepthBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<GetNativeDepthBufferPtr_InjectedDelegate>("UnityEngine.RenderTexture::GetNativeDepthBufferPtr_Injected");
		DiscardContents_InjectedDelegateField = IL2CPP.ResolveICall<DiscardContents_InjectedDelegate>("UnityEngine.RenderTexture::DiscardContents_Injected");
		MarkRestoreExpected_InjectedDelegateField = IL2CPP.ResolveICall<MarkRestoreExpected_InjectedDelegate>("UnityEngine.RenderTexture::MarkRestoreExpected_Injected");
		ResolveAA_InjectedDelegateField = IL2CPP.ResolveICall<ResolveAA_InjectedDelegate>("UnityEngine.RenderTexture::ResolveAA_Injected");
		ResolveAATo_InjectedDelegateField = IL2CPP.ResolveICall<ResolveAATo_InjectedDelegate>("UnityEngine.RenderTexture::ResolveAATo_Injected");
		SetGlobalShaderProperty_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalShaderProperty_InjectedDelegate>("UnityEngine.RenderTexture::SetGlobalShaderProperty_Injected");
		IsCreated_InjectedDelegateField = IL2CPP.ResolveICall<IsCreated_InjectedDelegate>("UnityEngine.RenderTexture::IsCreated_Injected");
		GenerateMips_InjectedDelegateField = IL2CPP.ResolveICall<GenerateMips_InjectedDelegate>("UnityEngine.RenderTexture::GenerateMips_Injected");
		ConvertToEquirect_InjectedDelegateField = IL2CPP.ResolveICall<ConvertToEquirect_InjectedDelegate>("UnityEngine.RenderTexture::ConvertToEquirect_Injected");
		SupportsStencil_InjectedDelegateField = IL2CPP.ResolveICall<SupportsStencil_InjectedDelegate>("UnityEngine.RenderTexture::SupportsStencil_Injected");
		get_depth_InjectedDelegateField = IL2CPP.ResolveICall<get_depth_InjectedDelegate>("UnityEngine.RenderTexture::get_depth_Injected");
		set_depth_InjectedDelegateField = IL2CPP.ResolveICall<set_depth_InjectedDelegate>("UnityEngine.RenderTexture::set_depth_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180924, XrefRangeEnd = 1180929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GraphicsFormat GetColorFormat(bool suppressWarnings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&suppressWarnings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180929, XrefRangeEnd = 1180934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColorFormat(GraphicsFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1181094, RefRangeEnd = 1181097, XrefRangeStart = 1181089, XrefRangeEnd = 1181094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyDynamicScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyDynamicScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1181102, RefRangeEnd = 1181117, XrefRangeStart = 1181097, XrefRangeEnd = 1181102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetActive()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 1181122, RefRangeEnd = 1181145, XrefRangeStart = 1181117, XrefRangeEnd = 1181122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActive(RenderTexture rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181145, XrefRangeEnd = 1181149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderBuffer GetColorBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderBuffer*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181149, XrefRangeEnd = 1181153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderBuffer GetDepthBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderBuffer*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181153, XrefRangeEnd = 1181158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMipMapCount(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181158, XrefRangeEnd = 1181163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShadowSamplingMode(ShadowSamplingMode samplingMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&samplingMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShadowSamplingMode_Internal_Void_ShadowSamplingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1181177, RefRangeEnd = 1181190, XrefRangeStart = 1181172, XrefRangeEnd = 1181177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1181195, RefRangeEnd = 1181202, XrefRangeStart = 1181190, XrefRangeEnd = 1181195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181202, XrefRangeEnd = 1181207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSRGBReadWrite(bool srgb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&srgb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181207, XrefRangeEnd = 1181209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(RenderTexture rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181209, XrefRangeEnd = 1181213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181213, XrefRangeEnd = 1181217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTextureDescriptor GetDescriptor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181217, XrefRangeEnd = 1181222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1181227, RefRangeEnd = 1181230, XrefRangeStart = 1181222, XrefRangeEnd = 1181227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseTemporary(RenderTexture temp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)temp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181230, XrefRangeEnd = 1181237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1181251, RefRangeEnd = 1181258, XrefRangeStart = 1181237, XrefRangeEnd = 1181251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(RenderTextureDescriptor desc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181258, XrefRangeEnd = 1181280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(RenderTexture textureToCopy)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureToCopy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181280, XrefRangeEnd = 1181297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, DefaultFormat format)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1181302, RefRangeEnd = 1181305, XrefRangeStart = 1181297, XrefRangeEnd = 1181302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, GraphicsFormat format)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1181340, RefRangeEnd = 1181341, XrefRangeStart = 1181305, XrefRangeEnd = 1181340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1181375, RefRangeEnd = 1181377, XrefRangeStart = 1181341, XrefRangeEnd = 1181375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181377, XrefRangeEnd = 1181382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181382, XrefRangeEnd = 1181391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1181403, RefRangeEnd = 1181406, XrefRangeStart = 1181391, XrefRangeEnd = 1181403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1181418, RefRangeEnd = 1181424, XrefRangeStart = 1181406, XrefRangeEnd = 1181418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181424, XrefRangeEnd = 1181432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1181462, RefRangeEnd = 1181466, XrefRangeStart = 1181432, XrefRangeEnd = 1181462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181466, XrefRangeEnd = 1181467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&depthBits);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181467, XrefRangeEnd = 1181469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&depthBits);
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableFallback;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181469, XrefRangeEnd = 1181470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&depthBits);
		*(DefaultFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181470, XrefRangeEnd = 1181471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&depthBits);
		*(ShadowSamplingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowSamplingMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_ShadowSamplingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1181481, RefRangeEnd = 1181500, XrefRangeStart = 1181471, XrefRangeEnd = 1181481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&depthBits);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestedShadowMap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1181551, RefRangeEnd = 1181562, XrefRangeStart = 1181537, XrefRangeEnd = 1181551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181562, XrefRangeEnd = 1181564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShadowSamplingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowSamplingModeForFormat_Internal_Static_ShadowSamplingMode_DefaultFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShadowSamplingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1181574, RefRangeEnd = 1181584, XrefRangeStart = 1181564, XrefRangeEnd = 1181574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WarnAboutFallbackTo16BitsDepth_Internal_Static_Void_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1181601, RefRangeEnd = 1181610, XrefRangeStart = 1181584, XrefRangeEnd = 1181601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderTextureFormat);
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1181616, RefRangeEnd = 1181618, XrefRangeStart = 1181610, XrefRangeEnd = 1181616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181618, XrefRangeEnd = 1181633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false, ShadowSamplingMode shadowSamplingMode = ShadowSamplingMode.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorFormat;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &memorylessMode;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		*(ShadowSamplingMode**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowSamplingMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_ShadowSamplingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181633, XrefRangeEnd = 1181651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &memorylessMode;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDynamicScale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181651, XrefRangeEnd = 1181668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &memorylessMode;
		*(VRTextureUsage**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &vrUsage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181668, XrefRangeEnd = 1181685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		*(RenderTextureMemoryless**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &memorylessMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181685, XrefRangeEnd = 1181702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181702, XrefRangeEnd = 1181719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(RenderTextureReadWrite**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &readWrite;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1181736, RefRangeEnd = 1181740, XrefRangeStart = 1181719, XrefRangeEnd = 1181736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1181756, RefRangeEnd = 1181757, XrefRangeStart = 1181740, XrefRangeEnd = 1181756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181757, XrefRangeEnd = 1181759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_width_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_width_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181759, XrefRangeEnd = 1181761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_width_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_width_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181761, XrefRangeEnd = 1181763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_height_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_height_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181763, XrefRangeEnd = 1181765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_height_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_height_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181765, XrefRangeEnd = 1181767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureDimension get_dimension_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dimension_Injected_Private_Static_TextureDimension_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181767, XrefRangeEnd = 1181769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_dimension_Injected(System.IntPtr _unity_self, TextureDimension value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureDimension**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dimension_Injected_Private_Static_Void_IntPtr_TextureDimension_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181769, XrefRangeEnd = 1181771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetColorFormat_Injected(System.IntPtr _unity_self, bool suppressWarnings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &suppressWarnings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorFormat_Injected_Private_Static_GraphicsFormat_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181771, XrefRangeEnd = 1181773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColorFormat_Injected(System.IntPtr _unity_self, GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181773, XrefRangeEnd = 1181775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_useMipMap_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useMipMap_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181775, XrefRangeEnd = 1181777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_useMipMap_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useMipMap_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181777, XrefRangeEnd = 1181779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_sRGB_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sRGB_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181779, XrefRangeEnd = 1181781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat get_depthStencilFormat_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthStencilFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181781, XrefRangeEnd = 1181783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_depthStencilFormat_Injected(System.IntPtr _unity_self, GraphicsFormat value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthStencilFormat_Injected_Private_Static_Void_IntPtr_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181783, XrefRangeEnd = 1181785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_autoGenerateMips_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autoGenerateMips_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181785, XrefRangeEnd = 1181787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_volumeDepth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volumeDepth_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181787, XrefRangeEnd = 1181789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_volumeDepth_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_volumeDepth_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181789, XrefRangeEnd = 1181791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_antiAliasing_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_antiAliasing_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181791, XrefRangeEnd = 1181793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_antiAliasing_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_antiAliasing_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181793, XrefRangeEnd = 1181795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_bindTextureMS_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindTextureMS_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181795, XrefRangeEnd = 1181797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_enableRandomWrite_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableRandomWrite_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181797, XrefRangeEnd = 1181799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_useDynamicScale_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDynamicScale_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181799, XrefRangeEnd = 1181801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_useDynamicScale_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useDynamicScale_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181801, XrefRangeEnd = 1181803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_useDynamicScaleExplicit_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDynamicScaleExplicit_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181803, XrefRangeEnd = 1181805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyDynamicScale_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyDynamicScale_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181805, XrefRangeEnd = 1181807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetActive_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActive_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181807, XrefRangeEnd = 1181809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActive_Injected(System.IntPtr rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181809, XrefRangeEnd = 1181811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetColorBuffer_Injected(System.IntPtr _unity_self, out RenderBuffer ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181811, XrefRangeEnd = 1181813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDepthBuffer_Injected(System.IntPtr _unity_self, out RenderBuffer ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Static_Void_IntPtr_byref_RenderBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181813, XrefRangeEnd = 1181815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMipMapCount_Injected(System.IntPtr _unity_self, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMipMapCount_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181815, XrefRangeEnd = 1181817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShadowSamplingMode_Injected(System.IntPtr _unity_self, ShadowSamplingMode samplingMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(ShadowSamplingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplingMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShadowSamplingMode_Injected_Private_Static_Void_IntPtr_ShadowSamplingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181817, XrefRangeEnd = 1181819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Create_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181819, XrefRangeEnd = 1181821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181821, XrefRangeEnd = 1181823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSRGBReadWrite_Injected(System.IntPtr _unity_self, bool srgb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srgb;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSRGBReadWrite_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181823, XrefRangeEnd = 1181825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTextureDescriptor_Injected(System.IntPtr _unity_self, [In] ref RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181825, XrefRangeEnd = 1181827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDescriptor_Injected(System.IntPtr _unity_self, out RenderTextureDescriptor ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptor_Injected_Private_Static_Void_IntPtr_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181827, XrefRangeEnd = 1181829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetTemporary_Internal_Injected([In] ref RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_IntPtr_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181829, XrefRangeEnd = 1181831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseTemporary_Injected(System.IntPtr temp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&temp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseTemporary_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderTexture(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool GetIsPowerOfTwo()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetIsPowerOfTwo_Injected(intPtr);
	}

	public System.IntPtr GetNativeDepthBufferPtr()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetNativeDepthBufferPtr_Injected(intPtr);
	}

	public void DiscardContents(bool discardColor, bool discardDepth)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		DiscardContents_Injected(intPtr, discardColor, discardDepth);
	}

	public void MarkRestoreExpected()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MarkRestoreExpected_Injected(intPtr);
	}

	public void DiscardContents()
	{
		DiscardContents(discardColor: true, discardDepth: true);
	}

	public void ResolveAA()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResolveAA_Injected(intPtr);
	}

	public void ResolveAATo(RenderTexture rt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResolveAATo_Injected(intPtr, MarshalledUnityObject.Marshal(rt));
	}

	public void ResolveAntiAliasedSurface()
	{
		ResolveAA();
	}

	public void ResolveAntiAliasedSurface(RenderTexture target)
	{
		ResolveAATo(target);
	}

	public unsafe void SetGlobalShaderProperty(string propertyName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(propertyName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetGlobalShaderProperty_Injected(intPtr, ref managedSpanWrapper);
					return;
				}
			}
			SetGlobalShaderProperty_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public bool IsCreated()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsCreated_Injected(intPtr);
	}

	public void GenerateMips()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GenerateMips_Injected(intPtr);
	}

	public void ConvertToEquirect(RenderTexture equirect, [Optional] Camera.MonoOrStereoscopicEye eye)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ConvertToEquirect_Injected(intPtr, MarshalledUnityObject.Marshal(equirect), eye);
	}

	public static bool SupportsStencil(RenderTexture rt)
	{
		return SupportsStencil_Injected(MarshalledUnityObject.Marshal(rt));
	}

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
	{
		ShadowSamplingMode shadowSamplingMode = ShadowSamplingMode.None;
		return GetTemporaryImpl(width, height, GetDepthStencilFormatLegacy(depthBuffer, shadowSamplingMode), format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
	}

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
	{
		return GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, useDynamicScale: false);
	}

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
	{
		return GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None);
	}

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing)
	{
		return GetTemporary(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None);
	}

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format)
	{
		return GetTemporary(width, height, depthBuffer, format, 1);
	}

	public static RenderTexture GetTemporary(int width, int height)
	{
		return GetTemporary(width, height, 0);
	}

	public Vector2 GetTexelOffset()
	{
		return Vector2.zero;
	}

	public static VRTextureUsage get_vrUsage_Injected(System.IntPtr _unity_self)
	{
		return get_vrUsage_InjectedDelegateField(_unity_self);
	}

	public static void set_vrUsage_Injected(System.IntPtr _unity_self, VRTextureUsage value)
	{
		set_vrUsage_InjectedDelegateField(_unity_self, value);
	}

	public static RenderTextureMemoryless get_memorylessMode_Injected(System.IntPtr _unity_self)
	{
		return get_memorylessMode_InjectedDelegateField(_unity_self);
	}

	public static void set_memorylessMode_Injected(System.IntPtr _unity_self, RenderTextureMemoryless value)
	{
		set_memorylessMode_InjectedDelegateField(_unity_self, value);
	}

	public static GraphicsFormat get_stencilFormat_Injected(System.IntPtr _unity_self)
	{
		return get_stencilFormat_InjectedDelegateField(_unity_self);
	}

	public static void set_stencilFormat_Injected(System.IntPtr _unity_self, GraphicsFormat value)
	{
		set_stencilFormat_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoGenerateMips_Injected(System.IntPtr _unity_self)
	{
		return get_autoGenerateMips_InjectedDelegateField(_unity_self);
	}

	public static void set_bindTextureMS_Injected(System.IntPtr _unity_self, bool value)
	{
		set_bindTextureMS_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableRandomWrite_Injected(System.IntPtr _unity_self)
	{
		return get_enableRandomWrite_InjectedDelegateField(_unity_self);
	}

	public static void set_useDynamicScaleExplicit_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useDynamicScaleExplicit_InjectedDelegateField(_unity_self, value);
	}

	public static bool GetIsPowerOfTwo_Injected(System.IntPtr _unity_self)
	{
		return GetIsPowerOfTwo_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetNativeDepthBufferPtr_Injected(System.IntPtr _unity_self)
	{
		return GetNativeDepthBufferPtr_InjectedDelegateField(_unity_self);
	}

	public static void DiscardContents_Injected(System.IntPtr _unity_self, bool discardColor, bool discardDepth)
	{
		DiscardContents_InjectedDelegateField(_unity_self, discardColor, discardDepth);
	}

	public static void MarkRestoreExpected_Injected(System.IntPtr _unity_self)
	{
		MarkRestoreExpected_InjectedDelegateField(_unity_self);
	}

	public static void ResolveAA_Injected(System.IntPtr _unity_self)
	{
		ResolveAA_InjectedDelegateField(_unity_self);
	}

	public static void ResolveAATo_Injected(System.IntPtr _unity_self, System.IntPtr rt)
	{
		ResolveAATo_InjectedDelegateField(_unity_self, rt);
	}

	public unsafe static void SetGlobalShaderProperty_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper propertyName)
	{
		SetGlobalShaderProperty_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref propertyName));
	}

	public static bool IsCreated_Injected(System.IntPtr _unity_self)
	{
		return IsCreated_InjectedDelegateField(_unity_self);
	}

	public static void GenerateMips_Injected(System.IntPtr _unity_self)
	{
		GenerateMips_InjectedDelegateField(_unity_self);
	}

	public static void ConvertToEquirect_Injected(System.IntPtr _unity_self, System.IntPtr equirect, Camera.MonoOrStereoscopicEye eye)
	{
		ConvertToEquirect_InjectedDelegateField(_unity_self, equirect, eye);
	}

	public static bool SupportsStencil_Injected(System.IntPtr rt)
	{
		return SupportsStencil_InjectedDelegateField(rt);
	}

	public static int get_depth_Injected(System.IntPtr _unity_self)
	{
		return get_depth_InjectedDelegateField(_unity_self);
	}

	public static void set_depth_Injected(System.IntPtr _unity_self, int value)
	{
		set_depth_InjectedDelegateField(_unity_self, value);
	}
}
