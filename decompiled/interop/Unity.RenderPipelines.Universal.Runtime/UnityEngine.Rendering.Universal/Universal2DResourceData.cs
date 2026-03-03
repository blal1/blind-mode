using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class Universal2DResourceData : UniversalResourceDataBase
{
	private static readonly IntPtr NativeFieldInfoPtr__lightTextures;

	private static readonly IntPtr NativeFieldInfoPtr__cameraNormalsTexture;

	private static readonly IntPtr NativeFieldInfoPtr__normalsDepth;

	private static readonly IntPtr NativeFieldInfoPtr__shadowTextures;

	private static readonly IntPtr NativeFieldInfoPtr__shadowDepth;

	private static readonly IntPtr NativeFieldInfoPtr__upscaleTexture;

	private static readonly IntPtr NativeFieldInfoPtr__cameraSortingLayerTexture;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndGetTextureHandle_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckAndSetTextureHandle_Private_Void_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_lightTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_lightTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_normalsTexture_Internal_get_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_normalsTexture_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_normalsDepth_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_normalsDepth_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shadowTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_shadowTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shadowDepth_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_shadowDepth_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_upscaleTexture_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_upscaleTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraSortingLayerTexture_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraSortingLayerTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> _lightTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightTextures);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> _cameraNormalsTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraNormalsTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraNormalsTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextureHandle _normalsDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__normalsDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__normalsDepth)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> _shadowTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowTextures);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextureHandle _shadowDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowDepth)) = value;
		}
	}

	public unsafe TextureHandle _upscaleTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__upscaleTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__upscaleTexture)) = value;
		}
	}

	public unsafe TextureHandle _cameraSortingLayerTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraSortingLayerTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraSortingLayerTexture)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> lightTextures
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086517, XrefRangeEnd = 1086518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086518, XrefRangeEnd = 1086519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> normalsTexture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086519, XrefRangeEnd = 1086520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalsTexture_Internal_get_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086520, XrefRangeEnd = 1086521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_normalsTexture_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle normalsDepth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086521, XrefRangeEnd = 1086522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalsDepth_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086522, XrefRangeEnd = 1086528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_normalsDepth_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> shadowTextures
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086528, XrefRangeEnd = 1086529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086529, XrefRangeEnd = 1086530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle shadowDepth
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1086531, RefRangeEnd = 1086542, XrefRangeStart = 1086530, XrefRangeEnd = 1086531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowDepth_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086548, RefRangeEnd = 1086551, XrefRangeStart = 1086542, XrefRangeEnd = 1086548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowDepth_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle upscaleTexture
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1086552, RefRangeEnd = 1086558, XrefRangeStart = 1086551, XrefRangeEnd = 1086552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upscaleTexture_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086564, RefRangeEnd = 1086565, XrefRangeStart = 1086558, XrefRangeEnd = 1086564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upscaleTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraSortingLayerTexture
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1086566, RefRangeEnd = 1086572, XrefRangeStart = 1086565, XrefRangeEnd = 1086566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraSortingLayerTexture_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086578, RefRangeEnd = 1086579, XrefRangeStart = 1086572, XrefRangeEnd = 1086578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraSortingLayerTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Universal2DResourceData()
	{
		Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Universal2DResourceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr);
		NativeFieldInfoPtr__lightTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_lightTextures");
		NativeFieldInfoPtr__cameraNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_cameraNormalsTexture");
		NativeFieldInfoPtr__normalsDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_normalsDepth");
		NativeFieldInfoPtr__shadowTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_shadowTextures");
		NativeFieldInfoPtr__shadowDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_shadowDepth");
		NativeFieldInfoPtr__upscaleTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_upscaleTexture");
		NativeFieldInfoPtr__cameraSortingLayerTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, "_cameraSortingLayerTexture");
		NativeMethodInfoPtr_CheckAndGetTextureHandle_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr_CheckAndSetTextureHandle_Private_Void_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_get_lightTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_set_lightTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_get_normalsTexture_Internal_get_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_set_normalsTexture_Internal_set_Void_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_get_normalsDepth_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_set_normalsDepth_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_get_shadowTextures_Internal_get_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_set_shadowTextures_Internal_set_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_get_shadowDepth_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_set_shadowDepth_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_get_upscaleTexture_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_set_upscaleTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_get_cameraSortingLayerTexture_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_set_cameraSortingLayerTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr, 100664516);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086500, RefRangeEnd = 1086502, XrefRangeStart = 1086491, XrefRangeEnd = 1086500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> CheckAndGetTextureHandle(ref Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndGetTextureHandle_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (IntPtr)0) ? null : new Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>(intPtr4));
		return (intPtr3 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>>(intPtr3) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086515, RefRangeEnd = 1086517, XrefRangeStart = 1086502, XrefRangeEnd = 1086515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAndSetTextureHandle(ref Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> handle, Il2CppReferenceArray<Il2CppStructArray<TextureHandle>> newHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*ptr = (nint)(&intPtr);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHandle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndSetTextureHandle_Private_Void_byref_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_Il2CppReferenceArray_1_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		handle = ((intPtr4 == (IntPtr)0) ? null : new Il2CppReferenceArray<Il2CppStructArray<TextureHandle>>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086579, XrefRangeEnd = 1086623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086623, XrefRangeEnd = 1086635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Universal2DResourceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Universal2DResourceData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Universal2DResourceData(IntPtr pointer)
		: base(pointer)
	{
	}
}
