using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine;

public class Texture : Object
{
	private delegate int get_masterTextureLimitDelegate();

	private delegate void set_masterTextureLimitDelegate(int value);

	private delegate int get_globalMipmapLimitDelegate();

	private delegate void set_globalMipmapLimitDelegate(int value);

	private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

	private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

	private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

	private delegate ulong get_totalTextureMemoryDelegate();

	private delegate ulong get_desiredTextureMemoryDelegate();

	private delegate ulong get_targetTextureMemoryDelegate();

	private delegate ulong get_currentTextureMemoryDelegate();

	private delegate ulong get_nonStreamingTextureMemoryDelegate();

	private delegate ulong get_streamingMipmapUploadCountDelegate();

	private delegate ulong get_streamingRendererCountDelegate();

	private delegate ulong get_streamingTextureCountDelegate();

	private delegate ulong get_nonStreamingTextureCountDelegate();

	private delegate ulong get_streamingTexturePendingLoadCountDelegate();

	private delegate ulong get_streamingTextureLoadingCountDelegate();

	private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

	private delegate bool get_streamingTextureForceLoadAllDelegate();

	private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

	private delegate bool get_allowThreadedTextureCreationDelegate();

	private delegate void set_allowThreadedTextureCreationDelegate(bool value);

	private delegate bool get_isNativeTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetNativeTexturePtr_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TextureColorSpace Internal_GetStoredColorSpace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_graphicsTexture_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_GenerateAllMips;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeU_Public_get_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeV_Public_get_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeW_Public_get_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStreamingTextureMaterialDebugPropertiesWithSlot_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStreamingTextureMaterialDebugProperties_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_streamingTextureDiscardUnusedMips_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_streamingTextureDiscardUnusedMips_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeU_Injected_Private_Static_TextureWrapMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeV_Injected_Private_Static_TextureWrapMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wrapModeW_Injected_Private_Static_TextureWrapMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0;

	private static readonly get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

	private static readonly set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

	private static readonly get_globalMipmapLimitDelegate get_globalMipmapLimitDelegateField;

	private static readonly set_globalMipmapLimitDelegate set_globalMipmapLimitDelegateField;

	private static readonly get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

	private static readonly set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

	private static readonly SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;

	private static readonly get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;

	private static readonly get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;

	private static readonly get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;

	private static readonly get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;

	private static readonly get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;

	private static readonly get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;

	private static readonly get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;

	private static readonly get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;

	private static readonly get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;

	private static readonly get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;

	private static readonly get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;

	private static readonly SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;

	private static readonly get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;

	private static readonly set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;

	private static readonly get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;

	private static readonly set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;

	private static readonly get_isNativeTexture_InjectedDelegate get_isNativeTexture_InjectedDelegateField;

	private static readonly GetNativeTexturePtr_InjectedDelegate GetNativeTexturePtr_InjectedDelegateField;

	private static readonly Internal_GetStoredColorSpace_InjectedDelegate Internal_GetStoredColorSpace_InjectedDelegateField;

	private static readonly get_graphicsTexture_InjectedDelegate get_graphicsTexture_InjectedDelegateField;

	public unsafe static int GenerateAllMips
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GenerateAllMips, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GenerateAllMips, (void*)(&value));
		}
	}

	public unsafe int mipmapCount
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1179357, RefRangeEnd = 1179359, XrefRangeStart = 1179349, XrefRangeEnd = 1179357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual GraphicsFormat graphicsFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179359, XrefRangeEnd = 1179363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual int width
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179387, XrefRangeEnd = 1179392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual int height
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179392, XrefRangeEnd = 1179397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual TextureDimension dimension
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179397, XrefRangeEnd = 1179402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool isReadable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179402, XrefRangeEnd = 1179410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TextureWrapMode wrapMode
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1179418, RefRangeEnd = 1179431, XrefRangeStart = 1179410, XrefRangeEnd = 1179418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1179439, RefRangeEnd = 1179446, XrefRangeStart = 1179431, XrefRangeEnd = 1179439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureWrapMode wrapModeU
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1179454, RefRangeEnd = 1179458, XrefRangeStart = 1179446, XrefRangeEnd = 1179454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeU_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179466, RefRangeEnd = 1179471, XrefRangeStart = 1179458, XrefRangeEnd = 1179466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureWrapMode wrapModeV
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1179479, RefRangeEnd = 1179483, XrefRangeStart = 1179471, XrefRangeEnd = 1179479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeV_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179491, RefRangeEnd = 1179496, XrefRangeStart = 1179483, XrefRangeEnd = 1179491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureWrapMode wrapModeW
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1179504, RefRangeEnd = 1179508, XrefRangeStart = 1179496, XrefRangeEnd = 1179504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeW_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179516, RefRangeEnd = 1179521, XrefRangeStart = 1179508, XrefRangeEnd = 1179516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe FilterMode filterMode
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1179529, RefRangeEnd = 1179551, XrefRangeStart = 1179521, XrefRangeEnd = 1179529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FilterMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1179559, RefRangeEnd = 1179576, XrefRangeStart = 1179551, XrefRangeEnd = 1179559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int anisoLevel
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1179584, RefRangeEnd = 1179598, XrefRangeStart = 1179576, XrefRangeEnd = 1179584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1179606, RefRangeEnd = 1179613, XrefRangeStart = 1179598, XrefRangeEnd = 1179606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float mipMapBias
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1179621, RefRangeEnd = 1179630, XrefRangeStart = 1179613, XrefRangeEnd = 1179621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1179638, RefRangeEnd = 1179641, XrefRangeStart = 1179630, XrefRangeEnd = 1179638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 texelSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179648, RefRangeEnd = 1179649, XrefRangeStart = 1179641, XrefRangeEnd = 1179648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint updateCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1179657, RefRangeEnd = 1179660, XrefRangeStart = 1179649, XrefRangeEnd = 1179657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ColorSpace activeTextureColorSpace
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179684, RefRangeEnd = 1179685, XrefRangeStart = 1179677, XrefRangeEnd = 1179684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool streamingTextureDiscardUnusedMips
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179695, RefRangeEnd = 1179696, XrefRangeStart = 1179693, XrefRangeEnd = 1179695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_streamingTextureDiscardUnusedMips_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1179698, RefRangeEnd = 1179700, XrefRangeStart = 1179696, XrefRangeEnd = 1179698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_streamingTextureDiscardUnusedMips_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static int masterTextureLimit
	{
		get
		{
			return get_masterTextureLimitDelegateField();
		}
		set
		{
			set_masterTextureLimitDelegateField(value);
		}
	}

	public static int globalMipmapLimit
	{
		get
		{
			return get_globalMipmapLimitDelegateField();
		}
		set
		{
			set_globalMipmapLimitDelegateField(value);
		}
	}

	public static AnisotropicFiltering anisotropicFiltering
	{
		get
		{
			return get_anisotropicFilteringDelegateField();
		}
		set
		{
			set_anisotropicFilteringDelegateField(value);
		}
	}

	public bool isNativeTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isNativeTexture_Injected(intPtr);
		}
	}

	public bool isDataSRGB => Internal_GetStoredColorSpace() == TextureColorSpace.sRGB;

	public static ulong totalTextureMemory => get_totalTextureMemoryDelegateField();

	public static ulong desiredTextureMemory => get_desiredTextureMemoryDelegateField();

	public static ulong targetTextureMemory => get_targetTextureMemoryDelegateField();

	public static ulong currentTextureMemory => get_currentTextureMemoryDelegateField();

	public static ulong nonStreamingTextureMemory => get_nonStreamingTextureMemoryDelegateField();

	public static ulong streamingMipmapUploadCount => get_streamingMipmapUploadCountDelegateField();

	public static ulong streamingRendererCount => get_streamingRendererCountDelegateField();

	public static ulong streamingTextureCount => get_streamingTextureCountDelegateField();

	public static ulong nonStreamingTextureCount => get_nonStreamingTextureCountDelegateField();

	public static ulong streamingTexturePendingLoadCount => get_streamingTexturePendingLoadCountDelegateField();

	public static ulong streamingTextureLoadingCount => get_streamingTextureLoadingCountDelegateField();

	public static bool streamingTextureForceLoadAll
	{
		get
		{
			return get_streamingTextureForceLoadAllDelegateField();
		}
		set
		{
			set_streamingTextureForceLoadAllDelegateField(value);
		}
	}

	public static bool allowThreadedTextureCreation
	{
		get
		{
			return get_allowThreadedTextureCreationDelegateField();
		}
		set
		{
			set_allowThreadedTextureCreationDelegateField(value);
		}
	}

	public GraphicsTexture graphicsTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			System.IntPtr intPtr2 = get_graphicsTexture_Injected(intPtr);
			return (intPtr2 == (System.IntPtr)0) ? null : GraphicsTexture.BindingsMarshaller.ConvertToManaged(intPtr2);
		}
	}

	static Texture()
	{
		Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
		NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, "GenerateAllMips");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665104);
		NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665105);
		NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665106);
		NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665107);
		NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665108);
		NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665111);
		NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665113);
		NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665114);
		NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665115);
		NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_get_wrapModeU_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_get_wrapModeV_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_get_wrapModeW_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_SetStreamingTextureMaterialDebugPropertiesWithSlot_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_SetStreamingTextureMaterialDebugProperties_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_get_streamingTextureDiscardUnusedMips_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_set_streamingTextureDiscardUnusedMips_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665139);
		NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665147);
		NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665149);
		NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665150);
		NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665151);
		NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665152);
		NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665155);
		NativeMethodInfoPtr_get_wrapModeU_Injected_Private_Static_TextureWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665156);
		NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665157);
		NativeMethodInfoPtr_get_wrapModeV_Injected_Private_Static_TextureWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665158);
		NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665159);
		NativeMethodInfoPtr_get_wrapModeW_Injected_Private_Static_TextureWrapMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665160);
		NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665170);
		NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665172);
		NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100665173);
		get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
		set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
		get_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<get_globalMipmapLimitDelegate>("UnityEngine.Texture::get_globalMipmapLimit");
		set_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<set_globalMipmapLimitDelegate>("UnityEngine.Texture::set_globalMipmapLimit");
		get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
		set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
		SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
		get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
		get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
		get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
		get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
		get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
		get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
		get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
		get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
		get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
		get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
		get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
		SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
		get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
		set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
		get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
		set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
		get_isNativeTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_isNativeTexture_InjectedDelegate>("UnityEngine.Texture::get_isNativeTexture_Injected");
		GetNativeTexturePtr_InjectedDelegateField = IL2CPP.ResolveICall<GetNativeTexturePtr_InjectedDelegate>("UnityEngine.Texture::GetNativeTexturePtr_Injected");
		Internal_GetStoredColorSpace_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetStoredColorSpace_InjectedDelegate>("UnityEngine.Texture::Internal_GetStoredColorSpace_Injected");
		get_graphicsTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_graphicsTexture_InjectedDelegate>("UnityEngine.Texture::get_graphicsTexture_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179348, RefRangeEnd = 1179349, XrefRangeStart = 1179344, XrefRangeEnd = 1179348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179363, XrefRangeEnd = 1179371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDataWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179371, XrefRangeEnd = 1179379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDataHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179379, XrefRangeEnd = 1179387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureDimension GetDimension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179668, RefRangeEnd = 1179669, XrefRangeStart = 1179660, XrefRangeEnd = 1179668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementUpdateCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementUpdateCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179669, XrefRangeEnd = 1179677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Internal_GetActiveTextureColorSpace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179685, XrefRangeEnd = 1179687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&materialTextureSlot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStreamingTextureMaterialDebugPropertiesWithSlot_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179692, RefRangeEnd = 1179693, XrefRangeStart = 1179687, XrefRangeEnd = 1179692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&materialTextureSlot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStreamingTextureMaterialDebugProperties_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179708, RefRangeEnd = 1179709, XrefRangeStart = 1179700, XrefRangeEnd = 1179708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong GetPixelDataSize(int mipLevel, int element = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mipLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179717, RefRangeEnd = 1179718, XrefRangeStart = 1179709, XrefRangeEnd = 1179717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong GetPixelDataOffset(int mipLevel, int element = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mipLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe TextureColorSpace GetTextureColorSpace(bool linear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&linear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureColorSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179718, XrefRangeEnd = 1179722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureColorSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1179742, RefRangeEnd = 1179749, XrefRangeStart = 1179722, XrefRangeEnd = 1179742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(TextureFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1179763, RefRangeEnd = 1179774, XrefRangeStart = 1179749, XrefRangeEnd = 1179763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(GraphicsFormatUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_GraphicsFormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1179782, RefRangeEnd = 1179790, XrefRangeStart = 1179774, XrefRangeEnd = 1179782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityException CreateNonReadableException(Texture t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179790, XrefRangeEnd = 1179796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityException CreateNativeArrayLengthOverflowException()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179796, XrefRangeEnd = 1179798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_mipmapCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mipmapCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179798, XrefRangeEnd = 1179800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDataWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataWidth_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179800, XrefRangeEnd = 1179802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDataHeight_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataHeight_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179802, XrefRangeEnd = 1179804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureDimension GetDimension_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDimension_Injected_Private_Static_TextureDimension_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureDimension*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179804, XrefRangeEnd = 1179806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isReadable_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179806, XrefRangeEnd = 1179808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureWrapMode get_wrapMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapMode_Injected_Private_Static_TextureWrapMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179808, XrefRangeEnd = 1179810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_wrapMode_Injected(System.IntPtr _unity_self, TextureWrapMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapMode_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179810, XrefRangeEnd = 1179812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureWrapMode get_wrapModeU_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeU_Injected_Private_Static_TextureWrapMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179812, XrefRangeEnd = 1179814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_wrapModeU_Injected(System.IntPtr _unity_self, TextureWrapMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeU_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179814, XrefRangeEnd = 1179816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureWrapMode get_wrapModeV_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeV_Injected_Private_Static_TextureWrapMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179816, XrefRangeEnd = 1179818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_wrapModeV_Injected(System.IntPtr _unity_self, TextureWrapMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeV_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179818, XrefRangeEnd = 1179820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureWrapMode get_wrapModeW_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wrapModeW_Injected_Private_Static_TextureWrapMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179820, XrefRangeEnd = 1179822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_wrapModeW_Injected(System.IntPtr _unity_self, TextureWrapMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wrapModeW_Injected_Private_Static_Void_IntPtr_TextureWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179822, XrefRangeEnd = 1179824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FilterMode get_filterMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_filterMode_Injected_Private_Static_FilterMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FilterMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179824, XrefRangeEnd = 1179826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_filterMode_Injected(System.IntPtr _unity_self, FilterMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(FilterMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_filterMode_Injected_Private_Static_Void_IntPtr_FilterMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179826, XrefRangeEnd = 1179828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_anisoLevel_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anisoLevel_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179828, XrefRangeEnd = 1179830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_anisoLevel_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anisoLevel_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179830, XrefRangeEnd = 1179832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_mipMapBias_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mipMapBias_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179832, XrefRangeEnd = 1179834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_mipMapBias_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mipMapBias_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179834, XrefRangeEnd = 1179836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_texelSize_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texelSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179836, XrefRangeEnd = 1179838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint get_updateCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateCount_Injected_Private_Static_UInt32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179838, XrefRangeEnd = 1179840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IncrementUpdateCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementUpdateCount_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179840, XrefRangeEnd = 1179842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetActiveTextureColorSpace_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179842, XrefRangeEnd = 1179844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong GetPixelDataSize_Injected(System.IntPtr _unity_self, int mipLevel, int element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelDataSize_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179844, XrefRangeEnd = 1179846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong GetPixelDataOffset_Injected(System.IntPtr _unity_self, int mipLevel, int element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelDataOffset_Injected_Private_Static_UInt64_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Texture(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
	{
		SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
	}

	public System.IntPtr GetNativeTexturePtr()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetNativeTexturePtr_Injected(intPtr);
	}

	public int GetNativeTextureID()
	{
		return (int)GetNativeTexturePtr();
	}

	public TextureColorSpace Internal_GetStoredColorSpace()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_GetStoredColorSpace_Injected(intPtr);
	}

	public static void SetStreamingTextureMaterialDebugProperties()
	{
		SetStreamingTextureMaterialDebugPropertiesDelegateField();
	}

	public bool ValidateFormat(RenderTextureFormat format)
	{
		if (SystemInfo.SupportsRenderTextureFormat(format))
		{
			return true;
		}
		Debug.LogError(Il2CppSystem.String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", (Il2CppSystem.Object)((Il2CppSystem.Object)format).ToString()), this);
		return false;
	}

	public UnityException IgnoreMipmapLimitCannotBeToggledException(Texture t)
	{
		return new UnityException(Il2CppSystem.String.Format("Failed to toggle ignoreMipmapLimit, Texture '{0}' is not readable. You can make the texture readable in the Texture Import Settings.", (Il2CppSystem.Object)t.name));
	}

	public static bool get_isNativeTexture_Injected(System.IntPtr _unity_self)
	{
		return get_isNativeTexture_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetNativeTexturePtr_Injected(System.IntPtr _unity_self)
	{
		return GetNativeTexturePtr_InjectedDelegateField(_unity_self);
	}

	public static TextureColorSpace Internal_GetStoredColorSpace_Injected(System.IntPtr _unity_self)
	{
		return Internal_GetStoredColorSpace_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_graphicsTexture_Injected(System.IntPtr _unity_self)
	{
		return get_graphicsTexture_InjectedDelegateField(_unity_self);
	}
}
