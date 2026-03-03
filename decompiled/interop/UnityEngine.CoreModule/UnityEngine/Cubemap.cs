using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

public sealed class Cubemap : Texture
{
	private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void UpdateExternalTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr nativeTexture);

	private delegate void GetPixelImpl_InjectedDelegate(System.IntPtr _unity_self, int image, int mip, int x, int y, [System.Runtime.InteropServices.Out] System.IntPtr ret);

	private delegate void SmoothEdges_InjectedDelegate(System.IntPtr _unity_self, int smoothRegionWidthInPixels);

	private delegate System.IntPtr GetPixels_InjectedDelegate(System.IntPtr _unity_self, CubemapFace face, int miplevel);

	private delegate void SetPixels_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colors, CubemapFace face, int miplevel);

	private delegate bool SetPixelDataImplArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate bool SetPixelDataImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

	private delegate void CopyPixels_Slice_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstFace, int dstMip);

	private delegate void CopyPixels_Region_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY);

	private delegate System.IntPtr GetWritableImageData_InjectedDelegate(System.IntPtr _unity_self, int frame);

	private delegate bool get_isPreProcessed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_streamingMipmaps_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_streamingMipmapsPriority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_requestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_loadAllMips_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loadAllMips_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_desiredMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_loadingMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_loadedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearRequestedMipmapLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsRequestedMipmapLevelLoaded_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0;

	private static readonly get_format_InjectedDelegate get_format_InjectedDelegateField;

	private static readonly UpdateExternalTexture_InjectedDelegate UpdateExternalTexture_InjectedDelegateField;

	private static readonly GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

	private static readonly SmoothEdges_InjectedDelegate SmoothEdges_InjectedDelegateField;

	private static readonly GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;

	private static readonly SetPixels_InjectedDelegate SetPixels_InjectedDelegateField;

	private static readonly SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;

	private static readonly SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;

	private static readonly CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;

	private static readonly CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;

	private static readonly CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;

	private static readonly GetWritableImageData_InjectedDelegate GetWritableImageData_InjectedDelegateField;

	private static readonly get_isPreProcessed_InjectedDelegate get_isPreProcessed_InjectedDelegateField;

	private static readonly get_streamingMipmaps_InjectedDelegate get_streamingMipmaps_InjectedDelegateField;

	private static readonly get_streamingMipmapsPriority_InjectedDelegate get_streamingMipmapsPriority_InjectedDelegateField;

	private static readonly get_requestedMipmapLevel_InjectedDelegate get_requestedMipmapLevel_InjectedDelegateField;

	private static readonly set_requestedMipmapLevel_InjectedDelegate set_requestedMipmapLevel_InjectedDelegateField;

	private static readonly get_loadAllMips_InjectedDelegate get_loadAllMips_InjectedDelegateField;

	private static readonly set_loadAllMips_InjectedDelegate set_loadAllMips_InjectedDelegateField;

	private static readonly get_desiredMipmapLevel_InjectedDelegate get_desiredMipmapLevel_InjectedDelegateField;

	private static readonly get_loadingMipmapLevel_InjectedDelegate get_loadingMipmapLevel_InjectedDelegateField;

	private static readonly get_loadedMipmapLevel_InjectedDelegate get_loadedMipmapLevel_InjectedDelegateField;

	private static readonly ClearRequestedMipmapLevel_InjectedDelegate ClearRequestedMipmapLevel_InjectedDelegateField;

	private static readonly IsRequestedMipmapLevelLoaded_InjectedDelegate IsRequestedMipmapLevelLoaded_InjectedDelegateField;

	public unsafe override bool isReadable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180353, XrefRangeEnd = 1180358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public TextureFormat format
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_format_Injected(intPtr);
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

	static Cubemap()
	{
		Il2CppClassPointerStore<Cubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cubemap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cubemap>.NativeClassPtr);
		NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665241);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665242);
		NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665243);
		NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665244);
		NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665245);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665246);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665247);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665248);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665249);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665250);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665251);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665252);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665253);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665254);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665255);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665256);
		NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665257);
		NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665258);
		NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665259);
		NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665260);
		NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665261);
		NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665262);
		NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665263);
		NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100665264);
		get_format_InjectedDelegateField = IL2CPP.ResolveICall<get_format_InjectedDelegate>("UnityEngine.Cubemap::get_format_Injected");
		UpdateExternalTexture_InjectedDelegateField = IL2CPP.ResolveICall<UpdateExternalTexture_InjectedDelegate>("UnityEngine.Cubemap::UpdateExternalTexture_Injected");
		GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::GetPixelImpl_Injected");
		SmoothEdges_InjectedDelegateField = IL2CPP.ResolveICall<SmoothEdges_InjectedDelegate>("UnityEngine.Cubemap::SmoothEdges_Injected");
		GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels_InjectedDelegate>("UnityEngine.Cubemap::GetPixels_Injected");
		SetPixels_InjectedDelegateField = IL2CPP.ResolveICall<SetPixels_InjectedDelegate>("UnityEngine.Cubemap::SetPixels_Injected");
		SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImplArray_InjectedDelegate>("UnityEngine.Cubemap::SetPixelDataImplArray_Injected");
		SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImpl_InjectedDelegate>("UnityEngine.Cubemap::SetPixelDataImpl_Injected");
		CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Full_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Full_Injected");
		CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Slice_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Slice_Injected");
		CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Region_InjectedDelegate>("UnityEngine.Cubemap::CopyPixels_Region_Injected");
		GetWritableImageData_InjectedDelegateField = IL2CPP.ResolveICall<GetWritableImageData_InjectedDelegate>("UnityEngine.Cubemap::GetWritableImageData_Injected");
		get_isPreProcessed_InjectedDelegateField = IL2CPP.ResolveICall<get_isPreProcessed_InjectedDelegate>("UnityEngine.Cubemap::get_isPreProcessed_Injected");
		get_streamingMipmaps_InjectedDelegateField = IL2CPP.ResolveICall<get_streamingMipmaps_InjectedDelegate>("UnityEngine.Cubemap::get_streamingMipmaps_Injected");
		get_streamingMipmapsPriority_InjectedDelegateField = IL2CPP.ResolveICall<get_streamingMipmapsPriority_InjectedDelegate>("UnityEngine.Cubemap::get_streamingMipmapsPriority_Injected");
		get_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_requestedMipmapLevel_Injected");
		set_requestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_requestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::set_requestedMipmapLevel_Injected");
		get_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<get_loadAllMips_InjectedDelegate>("UnityEngine.Cubemap::get_loadAllMips_Injected");
		set_loadAllMips_InjectedDelegateField = IL2CPP.ResolveICall<set_loadAllMips_InjectedDelegate>("UnityEngine.Cubemap::set_loadAllMips_Injected");
		get_desiredMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_desiredMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_desiredMipmapLevel_Injected");
		get_loadingMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_loadingMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_loadingMipmapLevel_Injected");
		get_loadedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_loadedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::get_loadedMipmapLevel_Injected");
		ClearRequestedMipmapLevel_InjectedDelegateField = IL2CPP.ResolveICall<ClearRequestedMipmapLevel_InjectedDelegate>("UnityEngine.Cubemap::ClearRequestedMipmapLevel_Injected");
		IsRequestedMipmapLevelLoaded_InjectedDelegateField = IL2CPP.ResolveICall<IsRequestedMipmapLevelLoaded_InjectedDelegate>("UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180342, XrefRangeEnd = 1180344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, System.IntPtr nativeTex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180346, RefRangeEnd = 1180348, XrefRangeStart = 1180344, XrefRangeEnd = 1180346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, System.IntPtr nativeTex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180348, XrefRangeEnd = 1180353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180358, XrefRangeEnd = 1180362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180362, XrefRangeEnd = 1180363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(TextureFormat format, int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180363, XrefRangeEnd = 1180368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateFormat(GraphicsFormat format, int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180368, XrefRangeEnd = 1180374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(DefaultFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180374, XrefRangeEnd = 1180376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(DefaultFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180381, RefRangeEnd = 1180384, XrefRangeStart = 1180376, XrefRangeEnd = 1180381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180403, RefRangeEnd = 1180406, XrefRangeStart = 1180384, XrefRangeEnd = 1180403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1180424, RefRangeEnd = 1180428, XrefRangeStart = 1180406, XrefRangeEnd = 1180424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, TextureFormat textureFormat, int mipCount, System.IntPtr nativeTex, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeTex;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180428, XrefRangeEnd = 1180434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180434, XrefRangeEnd = 1180440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180440, XrefRangeEnd = 1180441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, TextureFormat format, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180441, XrefRangeEnd = 1180442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180446, RefRangeEnd = 1180449, XrefRangeStart = 1180442, XrefRangeEnd = 1180446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixel(CubemapFace face, int x, int y, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&face);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180449, XrefRangeEnd = 1180453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixel(CubemapFace face, int x, int y, Color color, int mip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&face);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180453, XrefRangeEnd = 1180460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180467, RefRangeEnd = 1180470, XrefRangeStart = 1180460, XrefRangeEnd = 1180467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ValidateIsNotCrunched(TextureCreationFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180470, XrefRangeEnd = 1180472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180472, XrefRangeEnd = 1180474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180474, XrefRangeEnd = 1180476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public Cubemap(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void UpdateExternalTexture(System.IntPtr nativeTexture)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpdateExternalTexture_Injected(intPtr, nativeTexture);
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

	public void SmoothEdges(int smoothRegionWidthInPixels)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SmoothEdges_Injected(intPtr, smoothRegionWidthInPixels);
	}

	public void SmoothEdges()
	{
		SmoothEdges(1);
	}

	public Il2CppStructArray<Color> GetPixels(CubemapFace face, int miplevel)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels_Injected(intPtr, face, miplevel);
	}

	public Il2CppStructArray<Color> GetPixels(CubemapFace face)
	{
		return GetPixels(face, 0);
	}

	public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int miplevel)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Color> span);
		((Il2CppSystem.Span<Color>)(&span))._002Ector((Il2CppArrayBase<Color>)(object)colors);
		fixed (Color* begin = &((Il2CppSystem.Span<Color>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper colors2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Color>)(&span)).Length);
			SetPixels_Injected(intPtr, ref colors2, face, miplevel);
		}
	}

	public bool SetPixelDataImplArray(Il2CppSystem.Array data, int mipLevel, int face, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImplArray_Injected(intPtr, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public bool SetPixelDataImpl(System.IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImpl_Injected(intPtr, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face)
	{
		SetPixels(colors, face, 0);
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

	public void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstFace, int dstMip)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Slice_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, dstFace, dstMip);
	}

	public void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Region_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstFace, dstMip, dstX, dstY);
	}

	public System.IntPtr GetWritableImageData(int frame)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetWritableImageData_Injected(intPtr, frame);
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

	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, System.IntPtr nativeTex)
	{
		if (nativeTex == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ArgumentException("nativeTex can not be null");
		}
		return new Cubemap(width, format, (!mipmap) ? 1 : Texture.GenerateAllMips, nativeTex, createUninitialized: false);
	}

	public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
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
		SetPixelDataImplArray((Il2CppSystem.Array)(object)data, mipLevel, (int)face, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase)data).Length, sourceDataStartIndex);
	}

	public unsafe void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex) where T : struct
	{
		//IL_0031: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//IL_0069: Expected O, but got Ref
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
		SetPixelDataImpl((System.IntPtr)data.GetUnsafeReadOnlyPtr(), mipLevel, (int)face, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>)(&data)).Length, sourceDataStartIndex);
	}

	public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (mipLevel < 0 || mipLevel >= base.mipmapCount)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (base.mipmapCount - 1).ToString()));
		}
		if (face < CubemapFace.PositiveX || face >= (CubemapFace)6)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in face ", ((Il2CppSystem.Object)face).ToString(), " is invalid. The valid range is 0 through 5."));
		}
		if (GetWritableImageData(0).ToInt64() == 0)
		{
			throw new UnityException(Il2CppSystem.String.Concat("Texture '", base.name, "' has no data."));
		}
		ulong pixelDataOffset = GetPixelDataOffset(base.mipmapCount, (int)face);
		ulong pixelDataOffset2 = GetPixelDataOffset(mipLevel, (int)face);
		ulong pixelDataSize = GetPixelDataSize(mipLevel, (int)face);
		int num = UnsafeUtility.SizeOf<T>();
		ulong num2 = pixelDataSize / (ulong)num;
		if (num2 > int.MaxValue)
		{
			throw CreateNativeArrayLengthOverflowException();
		}
		System.IntPtr intPtr = new System.IntPtr((long)GetWritableImageData(0) + ((long)pixelDataOffset * (long)face + (long)pixelDataOffset2));
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Allocator.None);
	}

	public Color GetPixel(CubemapFace face, int x, int y)
	{
		return GetPixel(face, x, y, 0);
	}

	public Color GetPixel(CubemapFace face, int x, int y, int mip)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		return GetPixelImpl((int)face, mip, x, y);
	}

	public void Apply(bool updateMipmaps)
	{
		Apply(updateMipmaps, makeNoLongerReadable: false);
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

	public void CopyPixels(Texture src, int srcElement, int srcMip, CubemapFace dstFace, int dstMip)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Slice(src, srcElement, srcMip, (int)dstFace, dstMip);
	}

	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, CubemapFace dstFace, int dstMip, int dstX, int dstY)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, (int)dstFace, dstMip, dstX, dstY);
	}

	public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
	{
		return get_format_InjectedDelegateField(_unity_self);
	}

	public static void UpdateExternalTexture_Injected(System.IntPtr _unity_self, System.IntPtr nativeTexture)
	{
		UpdateExternalTexture_InjectedDelegateField(_unity_self, nativeTexture);
	}

	public unsafe static void GetPixelImpl_Injected(System.IntPtr _unity_self, int image, int mip, int x, int y, out Color ret)
	{
		GetPixelImpl_InjectedDelegateField(_unity_self, image, mip, x, y, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void SmoothEdges_Injected(System.IntPtr _unity_self, int smoothRegionWidthInPixels)
	{
		SmoothEdges_InjectedDelegateField(_unity_self, smoothRegionWidthInPixels);
	}

	public static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, CubemapFace face, int miplevel)
	{
		System.IntPtr intPtr = GetPixels_InjectedDelegateField(_unity_self, face, miplevel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	public unsafe static void SetPixels_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int miplevel)
	{
		SetPixels_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref colors), face, miplevel);
	}

	public static bool SetPixelDataImplArray_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static bool SetPixelDataImpl_Injected(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
	{
		CopyPixels_Full_InjectedDelegateField(_unity_self, src);
	}

	public static void CopyPixels_Slice_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstFace, int dstMip)
	{
		CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstFace, dstMip);
	}

	public static void CopyPixels_Region_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY)
	{
		CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstFace, dstMip, dstX, dstY);
	}

	public static System.IntPtr GetWritableImageData_Injected(System.IntPtr _unity_self, int frame)
	{
		return GetWritableImageData_InjectedDelegateField(_unity_self, frame);
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

	public static bool get_loadAllMips_Injected(System.IntPtr _unity_self)
	{
		return get_loadAllMips_InjectedDelegateField(_unity_self);
	}

	public static void set_loadAllMips_Injected(System.IntPtr _unity_self, bool value)
	{
		set_loadAllMips_InjectedDelegateField(_unity_self, value);
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
}
