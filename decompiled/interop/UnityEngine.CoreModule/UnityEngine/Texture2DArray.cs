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

public sealed class Texture2DArray : Texture
{
	private delegate int get_depth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TextureFormat get_format_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IgnoreMipmapLimit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetIgnoreMipmapLimitAndReload_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_mipmapLimitGroup_InjectedDelegate(System.IntPtr _unity_self, [System.Runtime.InteropServices.Out] System.IntPtr ret);

	private delegate int get_activeMipmapLimit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ApplyImpl_InjectedDelegate(System.IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable);

	private delegate System.IntPtr GetPixels_InjectedDelegate(System.IntPtr _unity_self, int arrayElement, int miplevel);

	private delegate bool SetPixelDataImplArray_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate bool SetPixelDataImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

	private delegate System.IntPtr GetPixels32_InjectedDelegate(System.IntPtr _unity_self, int arrayElement, int miplevel);

	private delegate void SetPixels_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colors, int arrayElement, int miplevel);

	private delegate void SetPixels32_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr colors, int arrayElement, int miplevel);

	private delegate void CopyPixels_Full_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src);

	private delegate void CopyPixels_Slice_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int dstElement, int dstMip);

	private delegate void CopyPixels_Region_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstElement, int dstMip, int dstX, int dstY);

	private delegate System.IntPtr GetImageData_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly get_depth_InjectedDelegate get_depth_InjectedDelegateField;

	private static readonly get_format_InjectedDelegate get_format_InjectedDelegateField;

	private static readonly IgnoreMipmapLimit_InjectedDelegate IgnoreMipmapLimit_InjectedDelegateField;

	private static readonly SetIgnoreMipmapLimitAndReload_InjectedDelegate SetIgnoreMipmapLimitAndReload_InjectedDelegateField;

	private static readonly get_mipmapLimitGroup_InjectedDelegate get_mipmapLimitGroup_InjectedDelegateField;

	private static readonly get_activeMipmapLimit_InjectedDelegate get_activeMipmapLimit_InjectedDelegateField;

	private static readonly ApplyImpl_InjectedDelegate ApplyImpl_InjectedDelegateField;

	private static readonly GetPixels_InjectedDelegate GetPixels_InjectedDelegateField;

	private static readonly SetPixelDataImplArray_InjectedDelegate SetPixelDataImplArray_InjectedDelegateField;

	private static readonly SetPixelDataImpl_InjectedDelegate SetPixelDataImpl_InjectedDelegateField;

	private static readonly GetPixels32_InjectedDelegate GetPixels32_InjectedDelegateField;

	private static readonly SetPixels_InjectedDelegate SetPixels_InjectedDelegateField;

	private static readonly SetPixels32_InjectedDelegate SetPixels32_InjectedDelegateField;

	private static readonly CopyPixels_Full_InjectedDelegate CopyPixels_Full_InjectedDelegateField;

	private static readonly CopyPixels_Slice_InjectedDelegate CopyPixels_Slice_InjectedDelegateField;

	private static readonly CopyPixels_Region_InjectedDelegate CopyPixels_Region_InjectedDelegateField;

	private static readonly GetImageData_InjectedDelegate GetImageData_InjectedDelegateField;

	public unsafe static int allSlices
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1180642, RefRangeEnd = 1180644, XrefRangeStart = 1180640, XrefRangeEnd = 1180642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override bool isReadable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180644, XrefRangeEnd = 1180649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static Texture2DArray()
	{
		Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2DArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr);
		NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665293);
		NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665294);
		NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665295);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665296);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665297);
		NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665304);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665305);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665306);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665308);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665309);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665310);
		NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665311);
		NativeMethodInfoPtr_get_isReadable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665312);
		NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100665313);
		get_depth_InjectedDelegateField = IL2CPP.ResolveICall<get_depth_InjectedDelegate>("UnityEngine.Texture2DArray::get_depth_Injected");
		get_format_InjectedDelegateField = IL2CPP.ResolveICall<get_format_InjectedDelegate>("UnityEngine.Texture2DArray::get_format_Injected");
		IgnoreMipmapLimit_InjectedDelegateField = IL2CPP.ResolveICall<IgnoreMipmapLimit_InjectedDelegate>("UnityEngine.Texture2DArray::IgnoreMipmapLimit_Injected");
		SetIgnoreMipmapLimitAndReload_InjectedDelegateField = IL2CPP.ResolveICall<SetIgnoreMipmapLimitAndReload_InjectedDelegate>("UnityEngine.Texture2DArray::SetIgnoreMipmapLimitAndReload_Injected");
		get_mipmapLimitGroup_InjectedDelegateField = IL2CPP.ResolveICall<get_mipmapLimitGroup_InjectedDelegate>("UnityEngine.Texture2DArray::get_mipmapLimitGroup_Injected");
		get_activeMipmapLimit_InjectedDelegateField = IL2CPP.ResolveICall<get_activeMipmapLimit_InjectedDelegate>("UnityEngine.Texture2DArray::get_activeMipmapLimit_Injected");
		ApplyImpl_InjectedDelegateField = IL2CPP.ResolveICall<ApplyImpl_InjectedDelegate>("UnityEngine.Texture2DArray::ApplyImpl_Injected");
		GetPixels_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels_InjectedDelegate>("UnityEngine.Texture2DArray::GetPixels_Injected");
		SetPixelDataImplArray_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImplArray_InjectedDelegate>("UnityEngine.Texture2DArray::SetPixelDataImplArray_Injected");
		SetPixelDataImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetPixelDataImpl_InjectedDelegate>("UnityEngine.Texture2DArray::SetPixelDataImpl_Injected");
		GetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<GetPixels32_InjectedDelegate>("UnityEngine.Texture2DArray::GetPixels32_Injected");
		SetPixels_InjectedDelegateField = IL2CPP.ResolveICall<SetPixels_InjectedDelegate>("UnityEngine.Texture2DArray::SetPixels_Injected");
		SetPixels32_InjectedDelegateField = IL2CPP.ResolveICall<SetPixels32_InjectedDelegate>("UnityEngine.Texture2DArray::SetPixels32_Injected");
		CopyPixels_Full_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Full_InjectedDelegate>("UnityEngine.Texture2DArray::CopyPixels_Full_Injected");
		CopyPixels_Slice_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Slice_InjectedDelegate>("UnityEngine.Texture2DArray::CopyPixels_Slice_Injected");
		CopyPixels_Region_InjectedDelegateField = IL2CPP.ResolveICall<CopyPixels_Region_InjectedDelegate>("UnityEngine.Texture2DArray::CopyPixels_Region_Injected");
		GetImageData_InjectedDelegateField = IL2CPP.ResolveICall<GetImageData_InjectedDelegate>("UnityEngine.Texture2DArray::GetImageData_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180663, RefRangeEnd = 1180664, XrefRangeStart = 1180649, XrefRangeEnd = 1180663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1180665, RefRangeEnd = 1180667, XrefRangeStart = 1180664, XrefRangeEnd = 1180665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180667, XrefRangeEnd = 1180668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180668, XrefRangeEnd = 1180673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180673, XrefRangeEnd = 1180679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180679, XrefRangeEnd = 1180681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180681, XrefRangeEnd = 1180683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(DefaultFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mipmapLimitDescriptor));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180683, XrefRangeEnd = 1180688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180688, XrefRangeEnd = 1180689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1180708, RefRangeEnd = 1180713, XrefRangeStart = 1180689, XrefRangeEnd = 1180708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mipmapLimitDescriptor));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1180731, RefRangeEnd = 1180736, XrefRangeStart = 1180713, XrefRangeEnd = 1180731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mipmapLimitDescriptor));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_MipmapLimitDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180736, XrefRangeEnd = 1180737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180737, XrefRangeEnd = 1180738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180738, XrefRangeEnd = 1180744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &createUninitialized;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180744, XrefRangeEnd = 1180750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1180756, RefRangeEnd = 1180757, XrefRangeStart = 1180750, XrefRangeEnd = 1180756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(TextureFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipChain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180757, XrefRangeEnd = 1180759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180759, XrefRangeEnd = 1180761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mono);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipCount;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(TextureColorSpace**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorSpace;
		*(TextureCreationFlags**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreMipmapLimit;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mipmapLimitGroupName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CreateImpl_Injected_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Texture2DArray(System.IntPtr pointer)
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

	public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ApplyImpl_Injected(intPtr, updateMipmaps, makeNoLongerReadable);
	}

	public Il2CppStructArray<Color> GetPixels(int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels_Injected(intPtr, arrayElement, miplevel);
	}

	public Il2CppStructArray<Color> GetPixels(int arrayElement)
	{
		return GetPixels(arrayElement, 0);
	}

	public bool SetPixelDataImplArray(Il2CppSystem.Array data, int mipLevel, int element, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImplArray_Injected(intPtr, data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public bool SetPixelDataImpl(System.IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetPixelDataImpl_Injected(intPtr, data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public Il2CppStructArray<Color32> GetPixels32(int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPixels32_Injected(intPtr, arrayElement, miplevel);
	}

	public Il2CppStructArray<Color32> GetPixels32(int arrayElement)
	{
		return GetPixels32(arrayElement, 0);
	}

	public unsafe void SetPixels(Il2CppStructArray<Color> colors, int arrayElement, int miplevel)
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
			SetPixels_Injected(intPtr, ref colors2, arrayElement, miplevel);
		}
	}

	public void SetPixels(Il2CppStructArray<Color> colors, int arrayElement)
	{
		SetPixels(colors, arrayElement, 0);
	}

	public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement, int miplevel)
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
			SetPixels32_Injected(intPtr, ref colors2, arrayElement, miplevel);
		}
	}

	public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement)
	{
		SetPixels32(colors, arrayElement, 0);
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

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		ApplyImpl(updateMipmaps, makeNoLongerReadable);
	}

	public void Apply(bool updateMipmaps)
	{
		Apply(updateMipmaps, makeNoLongerReadable: false);
	}

	public void Apply()
	{
		Apply(updateMipmaps: true, makeNoLongerReadable: false);
	}

	public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, int element, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex)
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
		SetPixelDataImplArray((Il2CppSystem.Array)(object)data, mipLevel, element, Il2CppSystem.Runtime.InteropServices.Marshal.SizeOf<T>(data[0]), ((Il2CppArrayBase)data).Length, sourceDataStartIndex);
	}

	public unsafe void SetPixelData<T>(NativeArray<T> data, int mipLevel, int element, [System.Runtime.InteropServices.Optional] int sourceDataStartIndex) where T : struct
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
		SetPixelDataImpl((System.IntPtr)data.GetUnsafeReadOnlyPtr(), mipLevel, element, UnsafeUtility.SizeOf<T>(), ((NativeArray<T>)(&data)).Length, sourceDataStartIndex);
	}

	public unsafe NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : struct
	{
		if (!isReadable)
		{
			throw CreateNonReadableException(this);
		}
		if (mipLevel < 0 || mipLevel >= base.mipmapCount)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (base.mipmapCount - 1).ToString()));
		}
		if (element < 0 || element >= depth)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (depth - 1).ToString()));
		}
		ulong pixelDataOffset = GetPixelDataOffset(base.mipmapCount, element);
		ulong pixelDataOffset2 = GetPixelDataOffset(mipLevel, element);
		ulong pixelDataSize = GetPixelDataSize(mipLevel, element);
		int num = UnsafeUtility.SizeOf<T>();
		ulong num2 = pixelDataSize / (ulong)num;
		if (num2 > int.MaxValue)
		{
			throw CreateNativeArrayLengthOverflowException();
		}
		System.IntPtr intPtr = new System.IntPtr((long)GetImageData() + ((long)pixelDataOffset * (long)element + (long)pixelDataOffset2));
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Allocator.None);
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

	public static int get_depth_Injected(System.IntPtr _unity_self)
	{
		return get_depth_InjectedDelegateField(_unity_self);
	}

	public static TextureFormat get_format_Injected(System.IntPtr _unity_self)
	{
		return get_format_InjectedDelegateField(_unity_self);
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

	public static void ApplyImpl_Injected(System.IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable)
	{
		ApplyImpl_InjectedDelegateField(_unity_self, updateMipmaps, makeNoLongerReadable);
	}

	public static Il2CppStructArray<Color> GetPixels_Injected(System.IntPtr _unity_self, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = GetPixels_InjectedDelegateField(_unity_self, arrayElement, miplevel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	public static bool SetPixelDataImplArray_Injected(System.IntPtr _unity_self, Il2CppSystem.Array data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImplArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static bool SetPixelDataImpl_Injected(System.IntPtr _unity_self, System.IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex)
	{
		return SetPixelDataImpl_InjectedDelegateField(_unity_self, data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
	}

	public static Il2CppStructArray<Color32> GetPixels32_Injected(System.IntPtr _unity_self, int arrayElement, int miplevel)
	{
		System.IntPtr intPtr = GetPixels32_InjectedDelegateField(_unity_self, arrayElement, miplevel);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr) : null;
	}

	public unsafe static void SetPixels_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, int arrayElement, int miplevel)
	{
		SetPixels_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref colors), arrayElement, miplevel);
	}

	public unsafe static void SetPixels32_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper colors, int arrayElement, int miplevel)
	{
		SetPixels32_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref colors), arrayElement, miplevel);
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
