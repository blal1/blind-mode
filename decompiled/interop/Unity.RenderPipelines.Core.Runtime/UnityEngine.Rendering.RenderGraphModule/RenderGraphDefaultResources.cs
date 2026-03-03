using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public class RenderGraphDefaultResources : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlackTexture2D;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WhiteTexture2D;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowTexture2D;

	private static readonly System.IntPtr NativeFieldInfoPtr__blackTexture_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__whiteTexture_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__clearTextureXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__magentaTextureXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__blackTextureXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__blackTexture3DXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__whiteTextureXR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultShadowTexture_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDefaultResourcesIfNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0;

	public unsafe RTHandle m_BlackTexture2D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlackTexture2D);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlackTexture2D)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_WhiteTexture2D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WhiteTexture2D);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WhiteTexture2D)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_ShadowTexture2D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowTexture2D);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowTexture2D)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextureHandle _blackTexture_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTexture_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTexture_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _whiteTexture_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__whiteTexture_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__whiteTexture_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _clearTextureXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clearTextureXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clearTextureXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _magentaTextureXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magentaTextureXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magentaTextureXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _blackTextureXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTextureXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTextureXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _blackTextureArrayXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _blackUIntTextureXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _blackTexture3DXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTexture3DXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blackTexture3DXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _whiteTextureXR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__whiteTextureXR_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__whiteTextureXR_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _defaultShadowTexture_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultShadowTexture_k__BackingField);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultShadowTexture_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle blackTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 591312, RefRangeEnd = 591315, XrefRangeStart = 591312, XrefRangeEnd = 591315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle whiteTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle clearTextureXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle magentaTextureXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle blackTextureXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle blackTextureArrayXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle blackUIntTextureXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle blackTexture3DXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle whiteTextureXR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle defaultShadowTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RenderGraphDefaultResources()
	{
		Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraphDefaultResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr);
		NativeFieldInfoPtr_m_BlackTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_BlackTexture2D");
		NativeFieldInfoPtr_m_WhiteTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_WhiteTexture2D");
		NativeFieldInfoPtr_m_ShadowTexture2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "m_ShadowTexture2D");
		NativeFieldInfoPtr__blackTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTexture>k__BackingField");
		NativeFieldInfoPtr__whiteTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<whiteTexture>k__BackingField");
		NativeFieldInfoPtr__clearTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<clearTextureXR>k__BackingField");
		NativeFieldInfoPtr__magentaTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<magentaTextureXR>k__BackingField");
		NativeFieldInfoPtr__blackTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTextureXR>k__BackingField");
		NativeFieldInfoPtr__blackTextureArrayXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTextureArrayXR>k__BackingField");
		NativeFieldInfoPtr__blackUIntTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackUIntTextureXR>k__BackingField");
		NativeFieldInfoPtr__blackTexture3DXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<blackTexture3DXR>k__BackingField");
		NativeFieldInfoPtr__whiteTextureXR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<whiteTextureXR>k__BackingField");
		NativeFieldInfoPtr__defaultShadowTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, "<defaultShadowTexture>k__BackingField");
		NativeMethodInfoPtr_get_blackTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667374);
		NativeMethodInfoPtr_set_blackTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667375);
		NativeMethodInfoPtr_get_whiteTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667376);
		NativeMethodInfoPtr_set_whiteTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_get_clearTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr_set_clearTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr_get_magentaTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667380);
		NativeMethodInfoPtr_set_magentaTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667381);
		NativeMethodInfoPtr_get_blackTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667382);
		NativeMethodInfoPtr_set_blackTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667383);
		NativeMethodInfoPtr_get_blackTextureArrayXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667384);
		NativeMethodInfoPtr_set_blackTextureArrayXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667385);
		NativeMethodInfoPtr_get_blackUIntTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667386);
		NativeMethodInfoPtr_set_blackUIntTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667387);
		NativeMethodInfoPtr_get_blackTexture3DXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667388);
		NativeMethodInfoPtr_set_blackTexture3DXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667389);
		NativeMethodInfoPtr_get_whiteTextureXR_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667390);
		NativeMethodInfoPtr_set_whiteTextureXR_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667391);
		NativeMethodInfoPtr_get_defaultShadowTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667392);
		NativeMethodInfoPtr_set_defaultShadowTexture_Private_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667393);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667394);
		NativeMethodInfoPtr_InitDefaultResourcesIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667395);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667396);
		NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr, 100667397);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1058368, RefRangeEnd = 1058369, XrefRangeStart = 1058366, XrefRangeEnd = 1058368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphDefaultResources()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDefaultResources>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1058389, RefRangeEnd = 1058391, XrefRangeStart = 1058369, XrefRangeEnd = 1058389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitDefaultResourcesIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDefaultResourcesIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1058397, RefRangeEnd = 1058398, XrefRangeStart = 1058391, XrefRangeEnd = 1058397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1058425, RefRangeEnd = 1058426, XrefRangeStart = 1058398, XrefRangeEnd = 1058425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeForRendering(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeForRendering_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraphDefaultResources(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
