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

public sealed class CubemapArray : Texture
{
	private delegate int get_cubemapCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetPixels_InjectedDelegate(System.IntPtr _unity_self, CubemapFace face, int arrayElement, int miplevel);

	private delegate System.IntPtr GetPixels32_InjectedDelegate(System.IntPtr _unity_self, CubemapFace face, int arrayElement, int miplevel);

	private delegate void SetPixels32_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colors, CubemapFace face, int arrayElement, int miplevel);

	private delegate bool SetPixelDataImplArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate bool SetPixelDataImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

	private delegate void CopyPixels_Slice_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstElement, int dstMip);

	private delegate void CopyPixels_Region_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstElement, int dstMip, int dstX, int dstY);

	private delegate System.IntPtr GetImageData_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0;

	private static readonly get_cubemapCount_InjectedDelegate get_cubemapCount_InjectedDelegateField;

	private static readonly get_format_InjectedDelegate get_format_InjectedDelegateField;

	private static readonly GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;

	private static readonly GetPixels32_InjectedDelegate GetPixels32_InjectedDelegateField;

	private static readonly SetPixels32_InjectedDelegate SetPixels32_InjectedDelegateField;

	private static readonly SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;

	private static readonly SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;

	private static readonly CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;

	private static readonly CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;

	private static readonly CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;

	private static readonly GetImageData_InjectedDelegate GetImageData_InjectedDelegateField;

	public unsafe override bool isReadable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180761, XrefRangeEnd = 1180766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public int cubemapCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cubemapCount_Injected(intPtr);
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

	static CubemapArray()
	{
		Il2CppClassPointerStore<CubemapArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CubemapArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr);
		NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665314);
		NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665315);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665316);
		NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665317);
		NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665318);
		NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665319);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665321);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665324);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665325);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665327);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665328);
		NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665329);
		NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665330);
		NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665331);
		NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665332);
		NativeMethodInfoPtr_ApplyImpl_Injected_Private_Static_Void_IntPtr_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665333);
		NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr, 100665334);
		get_cubemapCount_InjectedDelegateField = IL2CPP.ResolveICall<get_cubemapCount_InjectedDelegate>("UnityEngine.CubemapArray::get_cubemapCount_Injected");
		get_format_InjectedDelegateField = IL2CPP.ResolveICall<get_format_InjectedDelegate>("UnityEngine.CubemapArray::get_format_Injected");
		GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels_InjectedDelegate>("UnityEngine.CubemapArray::GetPixels_Injected");
		GetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels32_InjectedDelegate>("UnityEngine.CubemapArray::GetPixels32_Injected");
		SetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<SetPixels32_InjectedDelegate>("UnityEngine.CubemapArray::SetPixels32_Injected");
		SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImplArray_InjectedDelegate>("UnityEngine.CubemapArray::SetPixelDataImplArray_Injected");
		SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImpl_InjectedDelegate>("UnityEngine.CubemapArray::SetPixelDataImpl_Injected");
		CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Full_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Full_Injected");
		CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Slice_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Slice_Injected");
		CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Region_InjectedDelegate>("UnityEngine.CubemapArray::CopyPixels_Region_Injected");
		GetImageData_InjectedDelegateField = IL2CPP.ResolveICall<GetImageData_InjectedDelegate>("UnityEngine.CubemapArray::GetImageData_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180766, XrefRangeEnd = 1180768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180770, RefRangeEnd = 1180772, XrefRangeStart = 1180768, XrefRangeEnd = 1180770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ext;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_CubemapArray_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180772, XrefRangeEnd = 1180777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180777, XrefRangeEnd = 1180788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement, int miplevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(CubemapFace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayElement;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180799, RefRangeEnd = 1180800, XrefRangeStart = 1180788, XrefRangeEnd = 1180799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int arrayElement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(CubemapFace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayElement;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_CubemapFace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180800, XrefRangeEnd = 1180806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180806, XrefRangeEnd = 1180808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180813, RefRangeEnd = 1180814, XrefRangeStart = 1180808, XrefRangeEnd = 1180813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1180829, RefRangeEnd = 1180832, XrefRangeStart = 1180814, XrefRangeEnd = 1180829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1180850, RefRangeEnd = 1180854, XrefRangeStart = 1180832, XrefRangeEnd = 1180850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180854, XrefRangeEnd = 1180855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180855, XrefRangeEnd = 1180861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180861, XrefRangeEnd = 1180867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180867, XrefRangeEnd = 1180873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180873, XrefRangeEnd = 1180880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180887, RefRangeEnd = 1180888, XrefRangeStart = 1180880, XrefRangeEnd = 1180887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180888, XrefRangeEnd = 1180890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180890, XrefRangeEnd = 1180892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180892, XrefRangeEnd = 1180894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPixels_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int arrayElement, int miplevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref colors);
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayElement;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &miplevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPixels_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CubemapFace_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CubemapArray(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels_Injected(intPtr, face, arrayElement, miplevel);
	}

	public Il2CppStructArray<Color> GetPixels(CubemapFace face, int arrayElement)
	{
		return GetPixels(face, arrayElement, 0);
	}

	public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels32_Injected(intPtr, face, arrayElement, miplevel);
	}

	public Il2CppStructArray<Color32> GetPixels32(CubemapFace face, int arrayElement)
	{
		return GetPixels32(face, arrayElement, 0);
	}

	public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement, int miplevel)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
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
			SetPixels32_Injected(intPtr, ref colors2, face, arrayElement, miplevel);
		}
	}

	public void SetPixels32(Il2CppStructArray<Color32> colors, CubemapFace face, int arrayElement)
	{
		SetPixels32(colors, face, arrayElement, 0);
	}

	public bool SetPixelDataImplArray(Il2CppSystem.Array data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImplArray_Injected(intPtr, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public bool SetPixelDataImpl(System.IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImpl_Injected(intPtr, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
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

	public void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstElement, int dstMip)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Slice_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, dstElement, dstMip);
	}

	public void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstElement, int dstMip, int dstX, int dstY)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyPixels_Region_Injected(intPtr, MarshalledUnityObject.Marshal(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
	}

	public System.IntPtr GetImageData()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetImageData_Injected(intPtr);
	}

	public void Apply(bool updateMipmaps)
	{
		Apply(updateMipmaps, makeNoLongerReadable: false);
	}

	public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, int element, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
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
		SetPixelDataImplArray((Il2CppSystem.Array)(object)data, mipLevel, (int)face, element, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase)data).Length, sourceDataStartIndex);
	}

	public unsafe void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, int element, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex) where T : struct
	{
		//IL_0031: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//IL_006b: Expected O, but got Ref
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
		SetPixelDataImpl((System.IntPtr)data.GetUnsafeReadOnlyPtr(), mipLevel, (int)face, element, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>)(&data)).Length, sourceDataStartIndex);
	}

	public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element) where T : struct
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
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in face ", ((Il2CppSystem.Object)face).ToString(), " is invalid.  The valid range is 0 through 5"));
		}
		if (element < 0 || element >= cubemapCount)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (cubemapCount - 1).ToString()));
		}
		int num = (int)(element * 6 + face);
		ulong pixelDataOffset = GetPixelDataOffset(base.mipmapCount, num);
		ulong pixelDataOffset2 = GetPixelDataOffset(mipLevel, num);
		ulong pixelDataSize = GetPixelDataSize(mipLevel, num);
		int num2 = UnsafeUtility.SizeOf<T>();
		ulong num3 = pixelDataSize / (ulong)num2;
		if (num3 > int.MaxValue)
		{
			throw CreateNativeArrayLengthOverflowException();
		}
		System.IntPtr intPtr = new System.IntPtr((long)GetImageData() + ((long)pixelDataOffset * (long)num + (long)pixelDataOffset2));
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num3, Allocator.None);
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

	public void CopyPixels(Texture src, int srcElement, int srcMip, int dstElement, int dstMip)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Slice(src, srcElement, srcMip, dstElement, dstMip);
	}

	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstElement, int dstMip, int dstX, int dstY)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (!src.isReadable)
		{
			throw CreateNonReadableException(src);
		}
		CopyPixels_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
	}

	public static int get_cubemapCount_Injected(System.IntPtr _unity_self)
	{
		return get_cubemapCount_InjectedDelegateField(_unity_self);
	}

	public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
	{
		return get_format_InjectedDelegateField(_unity_self);
	}

	public static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, CubemapFace face, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = GetPixels_InjectedDelegateField(_unity_self, face, arrayElement, miplevel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	public static Il2CppStructArray<Color32> GetPixels32_Injected(System.IntPtr _unity_self, CubemapFace face, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = GetPixels32_InjectedDelegateField(_unity_self, face, arrayElement, miplevel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr) : null;
	}

	public unsafe static void SetPixels32_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int arrayElement, int miplevel)
	{
		SetPixels32_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref colors), face, arrayElement, miplevel);
	}

	public static bool SetPixelDataImplArray_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static bool SetPixelDataImpl_Injected(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int face, int element, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, face, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static void CopyPixels_Full_Injected(System.IntPtr _unity_self, System.IntPtr src)
	{
		CopyPixels_Full_InjectedDelegateField(_unity_self, src);
	}

	public static void CopyPixels_Slice_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstElement, int dstMip)
	{
		CopyPixels_Slice_InjectedDelegateField(_unity_self, src, srcElement, srcMip, dstElement, dstMip);
	}

	public static void CopyPixels_Region_Injected(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstElement, int dstMip, int dstX, int dstY)
	{
		CopyPixels_Region_InjectedDelegateField(_unity_self, src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dstElement, dstMip, dstX, dstY);
	}

	public static System.IntPtr GetImageData_Injected(System.IntPtr _unity_self)
	{
		return GetImageData_InjectedDelegateField(_unity_self);
	}
}
