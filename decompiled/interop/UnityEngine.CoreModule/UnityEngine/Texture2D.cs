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
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

public sealed class Texture2D : Texture
{
	private sealed class MethodInfoStoreGeneric_GetRawTextureData_Public_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0, Il2CppClassPointerStore<Texture2D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	public enum EXRFlags
	{
		None = 0,
		OutputAsFloat = 1,
		CompressZIP = 2,
		CompressRLE = 4,
		CompressPIZ = 8
	}

	private delegate bool IgnoreMipmapLimit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetIgnoreMipmapLimitAndReload_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_mipmapLimitGroup_InjectedDelegate(System.IntPtr _unity_self, [System.Runtime.InteropServices.Out] System.IntPtr ret);

	private delegate int get_activeMipmapLimit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_redTexture_InjectedDelegate();

	private delegate System.IntPtr get_grayTexture_InjectedDelegate();

	private delegate System.IntPtr get_linearGrayTexture_InjectedDelegate();

	private delegate System.IntPtr get_normalTexture_InjectedDelegate();

	private delegate void Compress_InjectedDelegate(System.IntPtr _unity_self, bool highQuality);

	private delegate bool get_vtOnly_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetPixelImpl_InjectedDelegate(System.IntPtr _unity_self, int image, int mip, int x, int y, [System.Runtime.InteropServices.Out] System.IntPtr ret);

	private delegate bool ReinitializeWithFormatImpl_InjectedDelegate(System.IntPtr _unity_self, int width, int height, GraphicsFormat format, bool hasMipMap);

	private delegate bool LoadRawTextureDataImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, ulong size);

	private delegate bool LoadRawTextureDataImplArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data);

	private delegate bool SetPixelDataImplArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate bool SetPixelDataImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate void GenerateAtlasImpl_InjectedDelegate(System.IntPtr sizes, int padding, int atlasSize, [System.Runtime.InteropServices.Out] System.IntPtr rect);

	private delegate bool get_isPreProcessed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_streamingMipmaps_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_streamingMipmapsPriority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_minimumMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_minimumMipmapLevel_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_loadAllMips_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loadAllMips_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_calculatedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_desiredMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_loadingMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_loadedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearRequestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsRequestedMipmapLevelLoaded_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearMinimumMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void UpdateExternalTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nativeTex);

	private delegate void SetBlockOfPixels32_InjectedDelegate(System.IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, System.IntPtr colors, int miplevel);

	private delegate System.IntPtr GetRawTextureData_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

	private delegate void CopyPixels_Slice_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstMip);

	private delegate void CopyPixels_Region_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);

	private static readonly System.IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMax;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateEmptyImpl_Private_Static_Boolean_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetImageDataSize_Private_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_MipmapLimitDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_MipmapLimitDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_whiteTexture_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTexture_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitializeImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Single_Single_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Static_Void_IntPtr_byref_Rect_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelsImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_ManagedSpanWrapper_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWritableImageData_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetImageDataSize_Injected_Private_Static_UInt64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAllPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackTextures_Injected_Private_Static_Il2CppStructArray_1_Rect_IntPtr_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0;

	private static readonly IgnoreMipmapLimit_InjectedDelegate IgnoreMipmapLimit_InjectedDelegateField;

	private static readonly SetIgnoreMipmapLimitAndReload_InjectedDelegate SetIgnoreMipmapLimitAndReload_InjectedDelegateField;

	private static readonly get_mipmapLimitGroup_InjectedDelegate get_mipmapLimitGroup_InjectedDelegateField;

	private static readonly get_activeMipmapLimit_InjectedDelegate get_activeMipmapLimit_InjectedDelegateField;

	private static readonly get_redTexture_InjectedDelegate get_redTexture_InjectedDelegateField;

	private static readonly get_grayTexture_InjectedDelegate get_grayTexture_InjectedDelegateField;

	private static readonly get_linearGrayTexture_InjectedDelegate get_linearGrayTexture_InjectedDelegateField;

	private static readonly get_normalTexture_InjectedDelegate get_normalTexture_InjectedDelegateField;

	private static readonly Compress_InjectedDelegate Compress_InjectedDelegateField;

	private static readonly get_vtOnly_InjectedDelegate get_vtOnly_InjectedDelegateField;

	private static readonly GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

	private static readonly ReinitializeWithFormatImpl_InjectedDelegate ReinitializeWithFormatImpl_InjectedDelegateField;

	private static readonly LoadRawTextureDataImpl_InjectedDelegate LoadRawTextureDataImpl_InjectedDelegateField;

	private static readonly LoadRawTextureDataImplArray_InjectedDelegate LoadRawTextureDataImplArray_InjectedDelegateField;

	private static readonly SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;

	private static readonly SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;

	private static readonly GenerateAtlasImpl_InjectedDelegate GenerateAtlasImpl_InjectedDelegateField;

	private static readonly get_isPreProcessed_InjectedDelegate get_isPreProcessed_InjectedDelegateField;

	private static readonly get_streamingMipmaps_InjectedDelegate get_streamingMipmaps_InjectedDelegateField;

	private static readonly get_streamingMipmapsPriority_InjectedDelegate get_streamingMipmapsPriority_InjectedDelegateField;

	private static readonly get_requestedMipmapLevel_InjectedDelegate get_requestedMipmapLevel_InjectedDelegateField;

	private static readonly set_requestedMipmapLevel_InjectedDelegate set_requestedMipmapLevel_InjectedDelegateField;

	private static readonly get_minimumMipmapLevel_InjectedDelegate get_minimumMipmapLevel_InjectedDelegateField;

	private static readonly set_minimumMipmapLevel_InjectedDelegate set_minimumMipmapLevel_InjectedDelegateField;

	private static readonly get_loadAllMips_InjectedDelegate get_loadAllMips_InjectedDelegateField;

	private static readonly set_loadAllMips_InjectedDelegate set_loadAllMips_InjectedDelegateField;

	private static readonly get_calculatedMipmapLevel_InjectedDelegate get_calculatedMipmapLevel_InjectedDelegateField;

	private static readonly get_desiredMipmapLevel_InjectedDelegate get_desiredMipmapLevel_InjectedDelegateField;

	private static readonly get_loadingMipmapLevel_InjectedDelegate get_loadingMipmapLevel_InjectedDelegateField;

	private static readonly get_loadedMipmapLevel_InjectedDelegate get_loadedMipmapLevel_InjectedDelegateField;

	private static readonly ClearRequestedMipmapLevel_InjectedDelegate ClearRequestedMipmapLevel_InjectedDelegateField;

	private static readonly IsRequestedMipmapLevelLoaded_InjectedDelegate IsRequestedMipmapLevelLoaded_InjectedDelegateField;

	private static readonly ClearMinimumMipmapLevel_InjectedDelegate ClearMinimumMipmapLevel_InjectedDelegateField;

	private static readonly UpdateExternalTexture_InjectedDelegate UpdateExternalTexture_InjectedDelegateField;

	private static readonly SetBlockOfPixels32_InjectedDelegate SetBlockOfPixels32_InjectedDelegateField;

	private static readonly GetRawTextureData_InjectedDelegate GetRawTextureData_InjectedDelegateField;

	private static readonly CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;

	private static readonly CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;

	private static readonly CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;

	public unsafe static int streamingMipmapsPriorityMin
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&value));
		}
	}

	public unsafe static int streamingMipmapsPriorityMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&value));
		}
	}

	public unsafe TextureFormat format
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1179851, RefRangeEnd = 1179861, XrefRangeStart = 1179846, XrefRangeEnd = 1179851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Texture2D whiteTexture
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1179866, RefRangeEnd = 1179879, XrefRangeStart = 1179861, XrefRangeEnd = 1179866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
	}

	public unsafe static Texture2D blackTexture
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179884, RefRangeEnd = 1179889, XrefRangeStart = 1179879, XrefRangeEnd = 1179884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
	}

	public unsafe override bool isReadable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179910, XrefRangeEnd = 1179915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public string mipmapLimitGroup
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_mipmapLimitGroup_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public int activeMipmapLimit
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_activeMipmapLimit_Injected(intPtr);
		}
	}

	public static Texture2D redTexture => Unmarshal.UnmarshalUnityObject<Texture2D>(get_redTexture_Injected());

	public static Texture2D grayTexture => Unmarshal.UnmarshalUnityObject<Texture2D>(get_grayTexture_Injected());

	public static Texture2D linearGrayTexture => Unmarshal.UnmarshalUnityObject<Texture2D>(get_linearGrayTexture_Injected());

	public static Texture2D normalTexture => Unmarshal.UnmarshalUnityObject<Texture2D>(get_normalTexture_Injected());

	public bool vtOnly
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_vtOnly_Injected(intPtr);
		}
	}

	public bool isPreProcessed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isPreProcessed_Injected(intPtr);
		}
	}

	public bool streamingMipmaps
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_streamingMipmaps_Injected(intPtr);
		}
	}

	public int streamingMipmapsPriority
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_streamingMipmapsPriority_Injected(intPtr);
		}
	}

	public int requestedMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_requestedMipmapLevel_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_requestedMipmapLevel_Injected(intPtr, value);
		}
	}

	public int minimumMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minimumMipmapLevel_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_minimumMipmapLevel_Injected(intPtr, value);
		}
	}

	public bool loadAllMips
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadAllMips_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loadAllMips_Injected(intPtr, value);
		}
	}

	public int calculatedMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_calculatedMipmapLevel_Injected(intPtr);
		}
	}

	public int desiredMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_desiredMipmapLevel_Injected(intPtr);
		}
	}

	public int loadingMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadingMipmapLevel_Injected(intPtr);
		}
	}

	public int loadedMipmapLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadedMipmapLevel_Injected(intPtr);
		}
	}

	public bool ignoreMipmapLimit
	{
		get
		{
			return IgnoreMipmapLimit();
		}
		set
		{
			if (!isReadable)
			{
				throw IgnoreMipmapLimitCannotBeToggledException(this);
			}
			SetIgnoreMipmapLimitAndReload(value);
		}
	}

	static Texture2D()
	{
		Il2CppClassPointerStore<Texture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2D>.NativeClassPtr);
		NativeFieldInfoPtr_streamingMipmapsPriorityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMin");
		NativeFieldInfoPtr_streamingMipmapsPriorityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMax");
		NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665176);
		NativeMethodInfoPtr_Internal_CreateEmptyImpl_Private_Static_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665177);
		NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665178);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665179);
		NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665180);
		NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665181);
		NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665182);
		NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665183);
		NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665184);
		NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665185);
		NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665186);
		NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665187);
		NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665188);
		NativeMethodInfoPtr_GetImageDataSize_Private_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665189);
		NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665190);
		NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665191);
		NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665192);
		NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665193);
		NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665194);
		NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665195);
		NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665196);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665197);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665198);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665199);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665200);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665201);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665202);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665203);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665204);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665205);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665206);
		NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665207);
		NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665208);
		NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665209);
		NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665210);
		NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665211);
		NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665212);
		NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665213);
		NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665214);
		NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665215);
		NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665216);
		NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665217);
		NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665218);
		NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665219);
		NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665220);
		NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665221);
		NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665222);
		NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665223);
		NativeMethodInfoPtr_get_whiteTexture_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665224);
		NativeMethodInfoPtr_get_blackTexture_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665225);
		NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665226);
		NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665227);
		NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665228);
		NativeMethodInfoPtr_ReinitializeImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665229);
		NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665230);
		NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Single_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665231);
		NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665232);
		NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Static_Void_IntPtr_byref_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665233);
		NativeMethodInfoPtr_SetPixelsImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_ManagedSpanWrapper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665234);
		NativeMethodInfoPtr_GetWritableImageData_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665235);
		NativeMethodInfoPtr_GetImageDataSize_Injected_Private_Static_UInt64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665236);
		NativeMethodInfoPtr_SetAllPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665237);
		NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665238);
		NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665239);
		NativeMethodInfoPtr_PackTextures_Injected_Private_Static_Il2CppStructArray_1_Rect_IntPtr_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100665240);
		IgnoreMipmapLimit_InjectedDelegateField = IL2CPP.ResolveICall<IgnoreMipmapLimit_InjectedDelegate>("UnityEngine.Texture2D::IgnoreMipmapLimit_Injected");
		SetIgnoreMipmapLimitAndReload_InjectedDelegateField = IL2CPP.ResolveICall<SetIgnoreMipmapLimitAndReload_InjectedDelegate>("UnityEngine.Texture2D::SetIgnoreMipmapLimitAndReload_Injected");
		get_mipmapLimitGroup_InjectedDelegateField = IL2CPP.ResolveICall<get_mipmapLimitGroup_InjectedDelegate>("UnityEngine.Texture2D::get_mipmapLimitGroup_Injected");
		get_activeMipmapLimit_InjectedDelegateField = IL2CPP.ResolveICall<get_activeMipmapLimit_InjectedDelegate>("UnityEngine.Texture2D::get_activeMipmapLimit_Injected");
		get_redTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_redTexture_InjectedDelegate>("UnityEngine.Texture2D::get_redTexture_Injected");
		get_grayTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_grayTexture_InjectedDelegate>("UnityEngine.Texture2D::get_grayTexture_Injected");
		get_linearGrayTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_linearGrayTexture_InjectedDelegate>("UnityEngine.Texture2D::get_linearGrayTexture_Injected");
		get_normalTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_normalTexture_InjectedDelegate>("UnityEngine.Texture2D::get_normalTexture_Injected");
		Compress_InjectedDelegateField = IL2CPP.ResolveICall<Compress_InjectedDelegate>("UnityEngine.Texture2D::Compress_Injected");
		get_vtOnly_InjectedDelegateField = IL2CPP.ResolveICall<get_vtOnly_InjectedDelegate>("UnityEngine.Texture2D::get_vtOnly_Injected");
		GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetPixelImpl_InjectedDelegate>("UnityEngine.Texture2D::GetPixelImpl_Injected");
		ReinitializeWithFormatImpl_InjectedDelegateField = IL2CPP.ResolveICall<ReinitializeWithFormatImpl_InjectedDelegate>("UnityEngine.Texture2D::ReinitializeWithFormatImpl_Injected");
		LoadRawTextureDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<LoadRawTextureDataImpl_InjectedDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImpl_Injected");
		LoadRawTextureDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<LoadRawTextureDataImplArray_InjectedDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImplArray_Injected");
		SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImplArray_InjectedDelegate>("UnityEngine.Texture2D::SetPixelDataImplArray_Injected");
		SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImpl_InjectedDelegate>("UnityEngine.Texture2D::SetPixelDataImpl_Injected");
		GenerateAtlasImpl_InjectedDelegateField = IL2CPP.ResolveICall<GenerateAtlasImpl_InjectedDelegate>("UnityEngine.Texture2D::GenerateAtlasImpl_Injected");
		get_isPreProcessed_InjectedDelegateField = IL2CPP.ResolveICall<get_isPreProcessed_InjectedDelegate>("UnityEngine.Texture2D::get_isPreProcessed_Injected");
		get_streamingMipmaps_InjectedDelegateField = IL2CPP.ResolveICall<get_streamingMipmaps_InjectedDelegate>("UnityEngine.Texture2D::get_streamingMipmaps_Injected");
		get_streamingMipmapsPriority_InjectedDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsPriority_InjectedDelegate>("UnityEngine.Texture2D::get_streamingMipmapsPriority_Injected");
		get_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_requestedMipmapLevel_Injected");
		set_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::set_requestedMipmapLevel_Injected");
		get_minimumMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_minimumMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_minimumMipmapLevel_Injected");
		set_minimumMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_minimumMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::set_minimumMipmapLevel_Injected");
		get_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<get_loadAllMips_InjectedDelegate>("UnityEngine.Texture2D::get_loadAllMips_Injected");
		set_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<set_loadAllMips_InjectedDelegate>("UnityEngine.Texture2D::set_loadAllMips_Injected");
		get_calculatedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_calculatedMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_calculatedMipmapLevel_Injected");
		get_desiredMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_desiredMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_desiredMipmapLevel_Injected");
		get_loadingMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_loadingMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_loadingMipmapLevel_Injected");
		get_loadedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_loadedMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::get_loadedMipmapLevel_Injected");
		ClearRequestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<ClearRequestedMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::ClearRequestedMipmapLevel_Injected");
		IsRequestedMipmapLevelLoaded_InjectedDelegateField = IL2CPP.ResolveICall<IsRequestedMipmapLevelLoaded_InjectedDelegate>("UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded_Injected");
		ClearMinimumMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<ClearMinimumMipmapLevel_InjectedDelegate>("UnityEngine.Texture2D::ClearMinimumMipmapLevel_Injected");
		UpdateExternalTexture_InjectedDelegateField = IL2CPP.ResolveICall<UpdateExternalTexture_InjectedDelegate>("UnityEngine.Texture2D::UpdateExternalTexture_Injected");
		SetBlockOfPixels32_InjectedDelegateField = IL2CPP.ResolveICall<SetBlockOfPixels32_InjectedDelegate>("UnityEngine.Texture2D::SetBlockOfPixels32_Injected");
		GetRawTextureData_InjectedDelegateField = IL2CPP.ResolveICall<GetRawTextureData_InjectedDelegate>("UnityEngine.Texture2D::GetRawTextureData_Injected");
		CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Full_InjectedDelegate>("UnityEngine.Texture2D::CopyPixels_Full_Injected");
		CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Slice_InjectedDelegate>("UnityEngine.Texture2D::CopyPixels_Slice_Injected");
		CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Region_InjectedDelegate>("UnityEngine.Texture2D::CopyPixels_Region_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179889, XrefRangeEnd = 1179891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateEmptyImpl(Texture2D mono)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateEmptyImpl_Private_Static_Boolean_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179905, RefRangeEnd = 1179906, XrefRangeStart = 1179891, XrefRangeEnd = 1179905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, System.IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1179907, RefRangeEnd = 1179910, XrefRangeStart = 1179906, XrefRangeEnd = 1179907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, System.IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179915, XrefRangeEnd = 1179920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateMipmaps);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeNoLongerReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179920, XrefRangeEnd = 1179925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReinitializeImpl(int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179925, XrefRangeEnd = 1179929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixelImpl(int image, int mip, int x, int y, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179929, XrefRangeEnd = 1179933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetPixelBilinearImpl(int image, int mip, float u, float v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &u;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1179938, RefRangeEnd = 1179940, XrefRangeStart = 1179933, XrefRangeEnd = 1179938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasMipMap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179940, XrefRangeEnd = 1179944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destY;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalculateMipMaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179944, XrefRangeEnd = 1179955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixelsImpl(int x, int y, int w, int h, Il2CppStructArray<Color> pixel, int miplevel, int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pixel);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1179960, RefRangeEnd = 1179962, XrefRangeStart = 1179955, XrefRangeEnd = 1179960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetWritableImageData(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1179967, RefRangeEnd = 1179969, XrefRangeStart = 1179962, XrefRangeEnd = 1179967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong GetImageDataSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetImageDataSize_Private_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179969, XrefRangeEnd = 1179980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAllPixels32(Il2CppStructArray<Color32> colors, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179980, XrefRangeEnd = 1179985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockHeight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1179990, RefRangeEnd = 1179996, XrefRangeStart = 1179985, XrefRangeEnd = 1179990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179996, XrefRangeEnd = 1180001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color32> GetPixels32(int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&miplevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180006, RefRangeEnd = 1180007, XrefRangeStart = 1180001, XrefRangeEnd = 1180006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color32> GetPixels32()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180007, XrefRangeEnd = 1180012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textures);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximumAtlasSize;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeNoLongerReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180017, RefRangeEnd = 1180018, XrefRangeStart = 1180012, XrefRangeEnd = 1180017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textures);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximumAtlasSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackTextures_Public_Il2CppStructArray_1_Rect_Il2CppReferenceArray_1_Texture2D_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180019, RefRangeEnd = 1180021, XrefRangeStart = 1180018, XrefRangeEnd = 1180019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180021, XrefRangeEnd = 1180026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(GraphicsFormat format, int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180045, RefRangeEnd = 1180047, XrefRangeStart = 1180026, XrefRangeEnd = 1180045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, System.IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mipmapLimitDescriptor));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180053, RefRangeEnd = 1180054, XrefRangeStart = 1180047, XrefRangeEnd = 1180053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1180059, RefRangeEnd = 1180066, XrefRangeStart = 1180054, XrefRangeEnd = 1180059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180084, RefRangeEnd = 1180087, XrefRangeStart = 1180066, XrefRangeEnd = 1180084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, System.IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mipmapLimitDescriptor));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180088, RefRangeEnd = 1180090, XrefRangeStart = 1180087, XrefRangeEnd = 1180088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1180096, RefRangeEnd = 1180103, XrefRangeStart = 1180090, XrefRangeEnd = 1180096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1180109, RefRangeEnd = 1180123, XrefRangeStart = 1180103, XrefRangeEnd = 1180109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1180141, RefRangeEnd = 1180150, XrefRangeStart = 1180123, XrefRangeEnd = 1180141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D(int width, int height)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1180154, RefRangeEnd = 1180167, XrefRangeStart = 1180150, XrefRangeEnd = 1180154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixel(int x, int y, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180178, RefRangeEnd = 1180180, XrefRangeStart = 1180167, XrefRangeEnd = 1180178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180181, RefRangeEnd = 1180182, XrefRangeStart = 1180180, XrefRangeEnd = 1180181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1180183, RefRangeEnd = 1180196, XrefRangeStart = 1180182, XrefRangeEnd = 1180183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels(Il2CppStructArray<Color> colors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180200, RefRangeEnd = 1180201, XrefRangeStart = 1180196, XrefRangeEnd = 1180200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetPixelBilinear(float u, float v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180206, RefRangeEnd = 1180209, XrefRangeStart = 1180201, XrefRangeEnd = 1180206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> GetRawTextureData<T>() where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRawTextureData_Public_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1180216, RefRangeEnd = 1180225, XrefRangeStart = 1180209, XrefRangeEnd = 1180216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateMipmaps);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeNoLongerReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1180232, RefRangeEnd = 1180258, XrefRangeStart = 1180225, XrefRangeEnd = 1180232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1180265, RefRangeEnd = 1180271, XrefRangeStart = 1180258, XrefRangeEnd = 1180265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Reinitialize(int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1179938, RefRangeEnd = 1179940, XrefRangeStart = 1179938, XrefRangeEnd = 1179940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasMipMap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180271, XrefRangeEnd = 1180275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destY;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalculateMipMaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1180279, RefRangeEnd = 1180284, XrefRangeStart = 1180275, XrefRangeEnd = 1180279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadPixels(Rect source, int destX, int destY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destY;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180295, RefRangeEnd = 1180297, XrefRangeStart = 1180284, XrefRangeEnd = 1180295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels32(Il2CppStructArray<Color32> colors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180297, XrefRangeEnd = 1180301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color> GetPixels(int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&miplevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180305, RefRangeEnd = 1180306, XrefRangeStart = 1180301, XrefRangeEnd = 1180305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color> GetPixels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180306, XrefRangeEnd = 1180308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureFormat get_format_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Injected_Private_Static_TextureFormat_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180308, XrefRangeEnd = 1180310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_whiteTexture_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_whiteTexture_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180310, XrefRangeEnd = 1180312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_blackTexture_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTexture_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180312, XrefRangeEnd = 1180314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, System.IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180314, XrefRangeEnd = 1180316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static bool get_isReadable_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180316, XrefRangeEnd = 1180318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyImpl_Injected(System.IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateMipmaps;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeNoLongerReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180318, XrefRangeEnd = 1180320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReinitializeImpl_Injected(System.IntPtr _unity_self, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180320, XrefRangeEnd = 1180322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPixelImpl_Injected(System.IntPtr _unity_self, int image, int mip, int x, int y, [System.Runtime.InteropServices.In] ref Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &image;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180322, XrefRangeEnd = 1180324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPixelBilinearImpl_Injected(System.IntPtr _unity_self, int image, int mip, float u, float v, out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &image;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &u;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Single_Single_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180324, XrefRangeEnd = 1180326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReinitializeWithTextureFormatImpl_Injected(System.IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasMipMap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180326, XrefRangeEnd = 1180328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadPixelsImpl_Injected(System.IntPtr _unity_self, [System.Runtime.InteropServices.In] ref Rect source, int destX, int destY, bool recalculateMipMaps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destY;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalculateMipMaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Static_Void_IntPtr_byref_Rect_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180328, XrefRangeEnd = 1180330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPixelsImpl_Injected(System.IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pixel);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixelsImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_ManagedSpanWrapper_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180330, XrefRangeEnd = 1180332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetWritableImageData_Injected(System.IntPtr _unity_self, int frame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWritableImageData_Injected_Private_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180332, XrefRangeEnd = 1180334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong GetImageDataSize_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetImageDataSize_Injected_Private_Static_UInt64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180334, XrefRangeEnd = 1180336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAllPixels32_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref colors);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllPixels32_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180336, XrefRangeEnd = 1180338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockWidth;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockHeight;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels_Injected_Private_Static_Il2CppStructArray_1_Color_IntPtr_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180338, XrefRangeEnd = 1180340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Color32> GetPixels32_Injected(System.IntPtr _unity_self, int miplevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixels32_Injected_Private_Static_Il2CppStructArray_1_Color32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180340, XrefRangeEnd = 1180342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Rect> PackTextures_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textures);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximumAtlasSize;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeNoLongerReadable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackTextures_Injected_Private_Static_Il2CppStructArray_1_Rect_IntPtr_Il2CppReferenceArray_1_Texture2D_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
	}

	public Texture2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool IgnoreMipmapLimit()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IgnoreMipmapLimit_Injected(intPtr);
	}

	public void SetIgnoreMipmapLimitAndReload(bool value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetIgnoreMipmapLimitAndReload_Injected(intPtr, value);
	}

	public void Compress(bool highQuality)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Compress_Injected(intPtr, highQuality);
	}

	public Color GetPixelImpl(int image, int mip, int x, int y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPixelImpl_Injected(intPtr, image, mip, x, y, out var ret);
		return ret;
	}

	public bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ReinitializeWithFormatImpl_Injected(intPtr, width, height, format, hasMipMap);
	}

	public bool LoadRawTextureDataImpl(System.IntPtr data, ulong size)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return LoadRawTextureDataImpl_Injected(intPtr, data, size);
	}

	public unsafe bool LoadRawTextureDataImplArray(Il2CppStructArray<byte> data)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)data);
		bool result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = LoadRawTextureDataImplArray_Injected(intPtr, ref data2);
		}
		return result;
	}

	public bool SetPixelDataImplArray(Il2CppSystem.Array data, int mipLevel, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImplArray_Injected(intPtr, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public bool SetPixelDataImpl(System.IntPtr data, int mipLevel, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImpl_Injected(intPtr, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static void GenerateAtlasImpl(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, [System.Runtime.InteropServices.Out] Il2CppStructArray<Rect> rect)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ClearRequestedMipmapLevel()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearRequestedMipmapLevel_Injected(intPtr);
	}

	public bool IsRequestedMipmapLevelLoaded()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsRequestedMipmapLevelLoaded_Injected(intPtr);
	}

	public void ClearMinimumMipmapLevel()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearMinimumMipmapLevel_Injected(intPtr);
	}

	public void UpdateExternalTexture(System.IntPtr nativeTex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateExternalTexture_Injected(intPtr, nativeTex);
	}

	public unsafe void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
	{
		//IL_001e: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0031: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Color32> span);
		((Il2CppSystem.Span<Color32>)(&span))._002Ector((Il2CppArrayBase<Color32>)(object)colors);
		fixed (Color32* begin = &((Il2CppSystem.Span<Color32>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper colors2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Color32>)(&span)).Length);
			SetBlockOfPixels32_Injected(intPtr, x, y, blockWidth, blockHeight, ref colors2, miplevel);
		}
	}

	public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding)
	{
		return PackTextures(textures, padding, 2048);
	}

	public void CopyPixels_Full(Texture src)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Full_Injected(intPtr, MarshalledUnityObject.Marshal(src));
	}

	public void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstMip)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Slice_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, dstMip);
	}

	public void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Region_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstMip, dstX, dstY);
	}

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, System.IntPtr nativeTex)
	{
		if (nativeTex == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ArgumentException("nativeTex can not be null");
		}
		return new Texture2D(width, height, format, (!mipChain) ? 1 : (-1), linear, nativeTex, createUninitialized: false, null);
	}

	public void SetPixel(int x, int y, Color color, int mipLevel)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		SetPixelImpl(0, mipLevel, x, y, color);
	}

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors)
	{
		SetPixels(x, y, blockWidth, blockHeight, colors, 0);
	}

	public Color GetPixel(int x, int y)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		return GetPixelImpl(0, 0, x, y);
	}

	public Color GetPixel(int x, int y, int mipLevel)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		return GetPixelImpl(0, mipLevel, x, y);
	}

	public Color GetPixelBilinear(float u, float v, int mipLevel)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		return GetPixelBilinearImpl(0, mipLevel, u, v);
	}

	public void LoadRawTextureData(System.IntPtr data, int size)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (data == Il2CppSystem.IntPtr.Zero || size == 0)
		{
			Debug.LogError("No texture data provided to LoadRawTextureData", this);
		}
		else if (!LoadRawTextureDataImpl(data, (ulong)size))
		{
			throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
		}
	}

	public void LoadRawTextureData(Il2CppStructArray<byte> data)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (data == null || ((Il2CppArrayBase)data).Length == 0)
		{
			Debug.LogError("No texture data provided to LoadRawTextureData", this);
		}
		else if (!LoadRawTextureDataImplArray(data))
		{
			throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
		}
	}

	public unsafe void LoadRawTextureData<T>(NativeArray<T> data) where T : struct
	{
		//IL_001d: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_004e: Expected O, but got Ref
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!((NativeArray<T>)(&data)).IsCreated || ((NativeArray<T>)(&data)).Length == 0)
		{
			throw new UnityException("No texture data provided to LoadRawTextureData");
		}
		if (!LoadRawTextureDataImpl((System.IntPtr)data.GetUnsafeReadOnlyPtr(), (ulong)((NativeArray<T>)(&data)).Length * (ulong)UnsafeUtility.SizeOf<T>()))
		{
			throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
		}
	}

	public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		if (sourceDataStartIndex < 0)
		{
			throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
		}
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (data == null || ((Il2CppArrayBase)data).Length == 0)
		{
			throw new UnityException("No texture data provided to SetPixelData.");
		}
		SetPixelDataImplArray((Il2CppSystem.Array)(object)data, mipLevel, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase)data).Length, sourceDataStartIndex);
	}

	public unsafe void SetPixelData<T>(NativeArray<T> data, int mipLevel, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex) where T : struct
	{
		//IL_0030: Expected O, but got Ref
		//IL_0039: Expected O, but got Ref
		//IL_0067: Expected O, but got Ref
		if (sourceDataStartIndex < 0)
		{
			throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
		}
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!((NativeArray<T>)(&data)).IsCreated || ((NativeArray<T>)(&data)).Length == 0)
		{
			throw new UnityException("No texture data provided to SetPixelData.");
		}
		SetPixelDataImpl((System.IntPtr)data.GetUnsafeReadOnlyPtr(), mipLevel, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>)(&data)).Length, sourceDataStartIndex);
	}

	public unsafe NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (mipLevel < 0 || mipLevel >= base.mipmapCount)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. It needs to be in the range 0 and ", (base.mipmapCount - 1).ToString()));
		}
		if (GetWritableImageData(0).ToInt64() == 0)
		{
			throw new UnityException(Il2CppSystem.String.Concat("Texture '", base.name, "' has no data."));
		}
		ulong pixelDataOffset = GetPixelDataOffset(mipLevel);
		ulong pixelDataSize = GetPixelDataSize(mipLevel);
		int num = UnsafeUtility.SizeOf<T>();
		ulong num2 = pixelDataSize / (ulong)num;
		if (num2 > int.MaxValue)
		{
			throw CreateNativeArrayLengthOverflowException();
		}
		System.IntPtr intPtr = new System.IntPtr((long)GetWritableImageData(0) + (long)pixelDataOffset);
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Allocator.None);
	}

	public void Apply(bool updateMipmaps)
	{
		Apply(updateMipmaps, makeNoLongerReadable: false);
	}

	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		return ReinitializeWithFormatImpl(width, height, format, hasMipMap);
	}

	public bool Resize(int width, int height)
	{
		return Reinitialize(width, height);
	}

	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
	{
		return Reinitialize(width, height, format, hasMipMap);
	}

	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return Reinitialize(width, height, format, hasMipMap);
	}

	public static bool GenerateAtlas(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, List<Rect> results)
	{
		if (sizes == null)
		{
			throw new Il2CppSystem.ArgumentException("sizes array can not be null");
		}
		if (results == null)
		{
			throw new Il2CppSystem.ArgumentException("results list cannot be null");
		}
		if (padding < 0)
		{
			throw new Il2CppSystem.ArgumentException("padding can not be negative");
		}
		if (atlasSize <= 0)
		{
			throw new Il2CppSystem.ArgumentException("atlas size must be positive");
		}
		results.Clear();
		if (((Il2CppArrayBase)sizes).Length == 0)
		{
			return true;
		}
		NoAllocHelpers.EnsureListElemCount(results, ((Il2CppArrayBase)sizes).Length);
		GenerateAtlasImpl(sizes, padding, atlasSize, (Il2CppStructArray<Rect>)(object)NoAllocHelpers.ExtractArrayFromList(results));
		return results.Count != 0;
	}

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
	{
		SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
	}

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors)
	{
		SetPixels32(x, y, blockWidth, blockHeight, colors, 0);
	}

	public void CopyPixels(Texture src)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Full(src);
	}

	public void CopyPixels(Texture src, int srcElement, int srcMip, int dstMip)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Slice(src, srcElement, srcMip, dstMip);
	}

	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstMip, dstX, dstY);
	}

	public static bool IgnoreMipmapLimit_Injected(System.IntPtr _unity_self)
	{
		return IgnoreMipmapLimit_InjectedDelegateField(_unity_self);
	}

	public static void SetIgnoreMipmapLimitAndReload_Injected(System.IntPtr _unity_self, bool value)
	{
		SetIgnoreMipmapLimitAndReload_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_mipmapLimitGroup_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_mipmapLimitGroup_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int get_activeMipmapLimit_Injected(System.IntPtr _unity_self)
	{
		return get_activeMipmapLimit_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_redTexture_Injected()
	{
		return get_redTexture_InjectedDelegateField();
	}

	public static System.IntPtr get_grayTexture_Injected()
	{
		return get_grayTexture_InjectedDelegateField();
	}

	public static System.IntPtr get_linearGrayTexture_Injected()
	{
		return get_linearGrayTexture_InjectedDelegateField();
	}

	public static System.IntPtr get_normalTexture_Injected()
	{
		return get_normalTexture_InjectedDelegateField();
	}

	public static void Compress_Injected(System.IntPtr _unity_self, bool highQuality)
	{
		Compress_InjectedDelegateField(_unity_self, highQuality);
	}

	public static bool get_vtOnly_Injected(System.IntPtr _unity_self)
	{
		return get_vtOnly_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetPixelImpl_Injected(System.IntPtr _unity_self, int image, int mip, int x, int y, out Color ret)
	{
		GetPixelImpl_InjectedDelegateField(_unity_self, image, mip, x, y, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool ReinitializeWithFormatImpl_Injected(System.IntPtr _unity_self, int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return ReinitializeWithFormatImpl_InjectedDelegateField(_unity_self, width, height, format, hasMipMap);
	}

	public static bool LoadRawTextureDataImpl_Injected(System.IntPtr _unity_self, System.IntPtr data, ulong size)
	{
		return LoadRawTextureDataImpl_InjectedDelegateField(_unity_self, data, size);
	}

	public unsafe static bool LoadRawTextureDataImplArray_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper data)
	{
		return LoadRawTextureDataImplArray_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref data));
	}

	public static bool SetPixelDataImplArray_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static bool SetPixelDataImpl_Injected(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public unsafe static void GenerateAtlasImpl_Injected(ref ManagedSpanWrapper sizes, int padding, int atlasSize, out BlittableArrayWrapper rect)
	{
		GenerateAtlasImpl_InjectedDelegateField((nint)Unsafe.AsPointer(ref sizes), padding, atlasSize, (nint)Unsafe.AsPointer(ref rect));
	}

	public static bool get_isPreProcessed_Injected(System.IntPtr _unity_self)
	{
		return get_isPreProcessed_InjectedDelegateField(_unity_self);
	}

	public static bool get_streamingMipmaps_Injected(System.IntPtr _unity_self)
	{
		return get_streamingMipmaps_InjectedDelegateField(_unity_self);
	}

	public static int get_streamingMipmapsPriority_Injected(System.IntPtr _unity_self)
	{
		return get_streamingMipmapsPriority_InjectedDelegateField(_unity_self);
	}

	public static int get_requestedMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_requestedMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_requestedMipmapLevel_Injected(System.IntPtr _unity_self, int value)
	{
		set_requestedMipmapLevel_InjectedDelegateField(_unity_self, value);
	}

	public static int get_minimumMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_minimumMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_minimumMipmapLevel_Injected(System.IntPtr _unity_self, int value)
	{
		set_minimumMipmapLevel_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_loadAllMips_Injected(System.IntPtr _unity_self)
	{
		return get_loadAllMips_InjectedDelegateField(_unity_self);
	}

	public static void set_loadAllMips_Injected(System.IntPtr _unity_self, bool value)
	{
		set_loadAllMips_InjectedDelegateField(_unity_self, value);
	}

	public static int get_calculatedMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_calculatedMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static int get_desiredMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_desiredMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static int get_loadingMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_loadingMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static int get_loadedMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		return get_loadedMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static void ClearRequestedMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		ClearRequestedMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static bool IsRequestedMipmapLevelLoaded_Injected(System.IntPtr _unity_self)
	{
		return IsRequestedMipmapLevelLoaded_InjectedDelegateField(_unity_self);
	}

	public static void ClearMinimumMipmapLevel_Injected(System.IntPtr _unity_self)
	{
		ClearMinimumMipmapLevel_InjectedDelegateField(_unity_self);
	}

	public static void UpdateExternalTexture_Injected(System.IntPtr _unity_self, System.IntPtr nativeTex)
	{
		UpdateExternalTexture_InjectedDelegateField(_unity_self, nativeTex);
	}

	public unsafe static void SetBlockOfPixels32_Injected(System.IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, ref ManagedSpanWrapper colors, int miplevel)
	{
		SetBlockOfPixels32_InjectedDelegateField(_unity_self, x, y, blockWidth, blockHeight, (nint)Unsafe.AsPointer(ref colors), miplevel);
	}

	public static Il2CppStructArray<byte> GetRawTextureData_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetRawTextureData_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
	{
		CopyPixels_Full_InjectedDelegateField(_unity_self, src);
	}

	public static void CopyPixels_Slice_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstMip)
	{
		CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstMip);
	}

	public static void CopyPixels_Region_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY)
	{
		CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstMip, dstX, dstY);
	}
}
