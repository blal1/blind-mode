using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class UniversalResourceData : UniversalResourceDataBase
{
	private static readonly IntPtr NativeFieldInfoPtr__activeColorID_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__activeDepthID_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__backBufferColor;

	private static readonly IntPtr NativeFieldInfoPtr__backBufferDepth;

	private static readonly IntPtr NativeFieldInfoPtr__cameraColor;

	private static readonly IntPtr NativeFieldInfoPtr__cameraDepth;

	private static readonly IntPtr NativeFieldInfoPtr__mainShadowsTexture;

	private static readonly IntPtr NativeFieldInfoPtr__additionalShadowsTexture;

	private static readonly IntPtr NativeFieldInfoPtr__gBuffer;

	private static readonly IntPtr NativeFieldInfoPtr__cameraOpaqueTexture;

	private static readonly IntPtr NativeFieldInfoPtr__cameraDepthTexture;

	private static readonly IntPtr NativeFieldInfoPtr__cameraNormalsTexture;

	private static readonly IntPtr NativeFieldInfoPtr__motionVectorColor;

	private static readonly IntPtr NativeFieldInfoPtr__motionVectorDepth;

	private static readonly IntPtr NativeFieldInfoPtr__internalColorLut;

	private static readonly IntPtr NativeFieldInfoPtr__debugScreenColor;

	private static readonly IntPtr NativeFieldInfoPtr__debugScreenDepth;

	private static readonly IntPtr NativeFieldInfoPtr__afterPostProcessColor;

	private static readonly IntPtr NativeFieldInfoPtr__overlayUITexture;

	private static readonly IntPtr NativeFieldInfoPtr__renderingLayersTexture;

	private static readonly IntPtr NativeFieldInfoPtr__dBuffer;

	private static readonly IntPtr NativeFieldInfoPtr__dBufferDepth;

	private static readonly IntPtr NativeFieldInfoPtr__ssaoTexture;

	private static readonly IntPtr NativeFieldInfoPtr__stpDebugView;

	private static readonly IntPtr NativeMethodInfoPtr_get_activeColorID_Internal_get_ActiveID_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_activeColorID_Internal_set_Void_ActiveID_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_activeColorTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_activeDepthID_Internal_get_ActiveID_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_activeDepthID_Internal_set_Void_ActiveID_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_activeDepthTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isActiveTargetBackBuffer_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_backBufferColor_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backBufferColor_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_backBufferDepth_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backBufferDepth_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraColor_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraColor_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepth_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraDepth_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mainShadowsTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_mainShadowsTexture_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_additionalShadowsTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_additionalShadowsTexture_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_gBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_gBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraOpaqueTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraOpaqueTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraDepthTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraDepthTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_cameraNormalsTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_cameraNormalsTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_motionVectorColor_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_motionVectorColor_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_motionVectorDepth_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_motionVectorDepth_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_internalColorLut_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_internalColorLut_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_debugScreenColor_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_debugScreenColor_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_debugScreenDepth_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_debugScreenDepth_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_afterPostProcessColor_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_overlayUITexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_overlayUITexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayersTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayersTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_dBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_dBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_dBufferDepth_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_dBufferDepth_Public_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ssaoTexture_Public_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ssaoTexture_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_stpDebugView_Internal_get_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_stpDebugView_Internal_set_Void_TextureHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActiveID _activeColorID_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeColorID_k__BackingField);
			return *(ActiveID*)num;
		}
		set
		{
			*(ActiveID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeColorID_k__BackingField)) = value;
		}
	}

	public unsafe ActiveID _activeDepthID_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeDepthID_k__BackingField);
			return *(ActiveID*)num;
		}
		set
		{
			*(ActiveID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeDepthID_k__BackingField)) = value;
		}
	}

	public unsafe TextureHandle _backBufferColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backBufferColor);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backBufferColor)) = value;
		}
	}

	public unsafe TextureHandle _backBufferDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backBufferDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backBufferDepth)) = value;
		}
	}

	public unsafe TextureHandle _cameraColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraColor);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraColor)) = value;
		}
	}

	public unsafe TextureHandle _cameraDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraDepth)) = value;
		}
	}

	public unsafe TextureHandle _mainShadowsTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainShadowsTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainShadowsTexture)) = value;
		}
	}

	public unsafe TextureHandle _additionalShadowsTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionalShadowsTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__additionalShadowsTexture)) = value;
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> _gBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gBuffer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextureHandle _cameraOpaqueTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraOpaqueTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraOpaqueTexture)) = value;
		}
	}

	public unsafe TextureHandle _cameraDepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraDepthTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraDepthTexture)) = value;
		}
	}

	public unsafe TextureHandle _cameraNormalsTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraNormalsTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraNormalsTexture)) = value;
		}
	}

	public unsafe TextureHandle _motionVectorColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorColor);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorColor)) = value;
		}
	}

	public unsafe TextureHandle _motionVectorDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectorDepth)) = value;
		}
	}

	public unsafe TextureHandle _internalColorLut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__internalColorLut);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__internalColorLut)) = value;
		}
	}

	public unsafe TextureHandle _debugScreenColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debugScreenColor);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debugScreenColor)) = value;
		}
	}

	public unsafe TextureHandle _debugScreenDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debugScreenDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debugScreenDepth)) = value;
		}
	}

	public unsafe TextureHandle _afterPostProcessColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__afterPostProcessColor);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__afterPostProcessColor)) = value;
		}
	}

	public unsafe TextureHandle _overlayUITexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overlayUITexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overlayUITexture)) = value;
		}
	}

	public unsafe TextureHandle _renderingLayersTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingLayersTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderingLayersTexture)) = value;
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> _dBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dBuffer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextureHandle _dBufferDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dBufferDepth);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dBufferDepth)) = value;
		}
	}

	public unsafe TextureHandle _ssaoTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ssaoTexture);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ssaoTexture)) = value;
		}
	}

	public unsafe TextureHandle _stpDebugView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stpDebugView);
			return *(TextureHandle*)num;
		}
		set
		{
			*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stpDebugView)) = value;
		}
	}

	public unsafe ActiveID activeColorID
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeColorID_Internal_get_ActiveID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ActiveID*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_activeColorID_Internal_set_Void_ActiveID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle activeColorTexture
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1087131, RefRangeEnd = 1087158, XrefRangeStart = 1087123, XrefRangeEnd = 1087131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeColorTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ActiveID activeDepthID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeDepthID_Internal_get_ActiveID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ActiveID*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_activeDepthID_Internal_set_Void_ActiveID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle activeDepthTexture
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1087166, RefRangeEnd = 1087188, XrefRangeStart = 1087158, XrefRangeEnd = 1087166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeDepthTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isActiveTargetBackBuffer
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1087190, RefRangeEnd = 1087200, XrefRangeStart = 1087188, XrefRangeEnd = 1087190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActiveTargetBackBuffer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TextureHandle backBufferColor
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1087201, RefRangeEnd = 1087209, XrefRangeStart = 1087200, XrefRangeEnd = 1087201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backBufferColor_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087215, RefRangeEnd = 1087216, XrefRangeStart = 1087209, XrefRangeEnd = 1087215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backBufferColor_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle backBufferDepth
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1087217, RefRangeEnd = 1087222, XrefRangeStart = 1087216, XrefRangeEnd = 1087217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backBufferDepth_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087228, RefRangeEnd = 1087229, XrefRangeStart = 1087222, XrefRangeEnd = 1087228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backBufferDepth_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraColor
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1086531, RefRangeEnd = 1086542, XrefRangeStart = 1086531, XrefRangeEnd = 1086542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraColor_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086548, RefRangeEnd = 1086551, XrefRangeStart = 1086548, XrefRangeEnd = 1086551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraColor_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraDepth
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1086552, RefRangeEnd = 1086558, XrefRangeStart = 1086552, XrefRangeEnd = 1086558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepth_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086564, RefRangeEnd = 1086565, XrefRangeStart = 1086564, XrefRangeEnd = 1086565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraDepth_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle mainShadowsTexture
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1086566, RefRangeEnd = 1086572, XrefRangeStart = 1086566, XrefRangeEnd = 1086572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainShadowsTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086578, RefRangeEnd = 1086579, XrefRangeStart = 1086578, XrefRangeEnd = 1086579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mainShadowsTexture_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle additionalShadowsTexture
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1087230, RefRangeEnd = 1087236, XrefRangeStart = 1087229, XrefRangeEnd = 1087230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalShadowsTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087242, RefRangeEnd = 1087243, XrefRangeStart = 1087236, XrefRangeEnd = 1087242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_additionalShadowsTexture_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> gBuffer
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1087244, RefRangeEnd = 1087251, XrefRangeStart = 1087243, XrefRangeEnd = 1087244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087252, RefRangeEnd = 1087253, XrefRangeStart = 1087251, XrefRangeEnd = 1087252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraOpaqueTexture
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087254, RefRangeEnd = 1087256, XrefRangeStart = 1087253, XrefRangeEnd = 1087254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraOpaqueTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087262, RefRangeEnd = 1087263, XrefRangeStart = 1087256, XrefRangeEnd = 1087262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraOpaqueTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraDepthTexture
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1087264, RefRangeEnd = 1087282, XrefRangeStart = 1087263, XrefRangeEnd = 1087264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepthTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087288, RefRangeEnd = 1087289, XrefRangeStart = 1087282, XrefRangeEnd = 1087288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraDepthTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle cameraNormalsTexture
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1087290, RefRangeEnd = 1087296, XrefRangeStart = 1087289, XrefRangeEnd = 1087290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraNormalsTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087302, RefRangeEnd = 1087303, XrefRangeStart = 1087296, XrefRangeEnd = 1087302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraNormalsTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle motionVectorColor
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1087304, RefRangeEnd = 1087311, XrefRangeStart = 1087303, XrefRangeEnd = 1087304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorColor_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087317, RefRangeEnd = 1087318, XrefRangeStart = 1087311, XrefRangeEnd = 1087317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorColor_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle motionVectorDepth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087319, RefRangeEnd = 1087321, XrefRangeStart = 1087318, XrefRangeEnd = 1087319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorDepth_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087327, RefRangeEnd = 1087328, XrefRangeStart = 1087321, XrefRangeEnd = 1087327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorDepth_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle internalColorLut
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087329, RefRangeEnd = 1087330, XrefRangeStart = 1087328, XrefRangeEnd = 1087329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_internalColorLut_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087336, RefRangeEnd = 1087337, XrefRangeStart = 1087330, XrefRangeEnd = 1087336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_internalColorLut_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle debugScreenColor
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1087338, RefRangeEnd = 1087343, XrefRangeStart = 1087337, XrefRangeEnd = 1087338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugScreenColor_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087349, RefRangeEnd = 1087350, XrefRangeStart = 1087343, XrefRangeEnd = 1087349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_debugScreenColor_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle debugScreenDepth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087351, RefRangeEnd = 1087352, XrefRangeStart = 1087350, XrefRangeEnd = 1087351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugScreenDepth_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087358, RefRangeEnd = 1087359, XrefRangeStart = 1087352, XrefRangeEnd = 1087358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_debugScreenDepth_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle afterPostProcessColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087360, RefRangeEnd = 1087361, XrefRangeStart = 1087359, XrefRangeEnd = 1087360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087367, RefRangeEnd = 1087368, XrefRangeStart = 1087361, XrefRangeEnd = 1087367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_afterPostProcessColor_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle overlayUITexture
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087369, RefRangeEnd = 1087373, XrefRangeStart = 1087368, XrefRangeEnd = 1087369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overlayUITexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087379, RefRangeEnd = 1087380, XrefRangeStart = 1087373, XrefRangeEnd = 1087379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overlayUITexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle renderingLayersTexture
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1087381, RefRangeEnd = 1087390, XrefRangeStart = 1087380, XrefRangeEnd = 1087381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingLayersTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087396, RefRangeEnd = 1087397, XrefRangeStart = 1087390, XrefRangeEnd = 1087396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayersTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<TextureHandle> dBuffer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087398, RefRangeEnd = 1087400, XrefRangeStart = 1087397, XrefRangeEnd = 1087398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextureHandle>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087401, RefRangeEnd = 1087402, XrefRangeStart = 1087400, XrefRangeEnd = 1087401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle dBufferDepth
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1087403, RefRangeEnd = 1087406, XrefRangeStart = 1087402, XrefRangeEnd = 1087403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dBufferDepth_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087412, RefRangeEnd = 1087413, XrefRangeStart = 1087406, XrefRangeEnd = 1087412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dBufferDepth_Public_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle ssaoTexture
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087414, RefRangeEnd = 1087418, XrefRangeStart = 1087413, XrefRangeEnd = 1087414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ssaoTexture_Public_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087424, RefRangeEnd = 1087425, XrefRangeStart = 1087418, XrefRangeEnd = 1087424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ssaoTexture_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureHandle stpDebugView
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087426, RefRangeEnd = 1087427, XrefRangeStart = 1087425, XrefRangeEnd = 1087426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stpDebugView_Internal_get_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087433, RefRangeEnd = 1087434, XrefRangeStart = 1087427, XrefRangeEnd = 1087433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stpDebugView_Internal_set_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static UniversalResourceData()
	{
		Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalResourceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr);
		NativeFieldInfoPtr__activeColorID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "<activeColorID>k__BackingField");
		NativeFieldInfoPtr__activeDepthID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "<activeDepthID>k__BackingField");
		NativeFieldInfoPtr__backBufferColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_backBufferColor");
		NativeFieldInfoPtr__backBufferDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_backBufferDepth");
		NativeFieldInfoPtr__cameraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_cameraColor");
		NativeFieldInfoPtr__cameraDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_cameraDepth");
		NativeFieldInfoPtr__mainShadowsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_mainShadowsTexture");
		NativeFieldInfoPtr__additionalShadowsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_additionalShadowsTexture");
		NativeFieldInfoPtr__gBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_gBuffer");
		NativeFieldInfoPtr__cameraOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_cameraOpaqueTexture");
		NativeFieldInfoPtr__cameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_cameraDepthTexture");
		NativeFieldInfoPtr__cameraNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_cameraNormalsTexture");
		NativeFieldInfoPtr__motionVectorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_motionVectorColor");
		NativeFieldInfoPtr__motionVectorDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_motionVectorDepth");
		NativeFieldInfoPtr__internalColorLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_internalColorLut");
		NativeFieldInfoPtr__debugScreenColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_debugScreenColor");
		NativeFieldInfoPtr__debugScreenDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_debugScreenDepth");
		NativeFieldInfoPtr__afterPostProcessColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_afterPostProcessColor");
		NativeFieldInfoPtr__overlayUITexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_overlayUITexture");
		NativeFieldInfoPtr__renderingLayersTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_renderingLayersTexture");
		NativeFieldInfoPtr__dBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_dBuffer");
		NativeFieldInfoPtr__dBufferDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_dBufferDepth");
		NativeFieldInfoPtr__ssaoTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_ssaoTexture");
		NativeFieldInfoPtr__stpDebugView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, "_stpDebugView");
		NativeMethodInfoPtr_get_activeColorID_Internal_get_ActiveID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_set_activeColorID_Internal_set_Void_ActiveID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_get_activeColorTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_get_activeDepthID_Internal_get_ActiveID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_set_activeDepthID_Internal_set_Void_ActiveID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_get_activeDepthTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_get_isActiveTargetBackBuffer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_get_backBufferColor_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_set_backBufferColor_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_get_backBufferDepth_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_set_backBufferDepth_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_get_cameraColor_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_set_cameraColor_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_get_cameraDepth_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_set_cameraDepth_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_get_mainShadowsTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_set_mainShadowsTexture_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_get_additionalShadowsTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_set_additionalShadowsTexture_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_get_gBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_set_gBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_get_cameraOpaqueTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_set_cameraOpaqueTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_get_cameraDepthTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_set_cameraDepthTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_get_cameraNormalsTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_set_cameraNormalsTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_get_motionVectorColor_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_set_motionVectorColor_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_get_motionVectorDepth_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_set_motionVectorDepth_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_get_internalColorLut_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_set_internalColorLut_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_get_debugScreenColor_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_set_debugScreenColor_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_get_debugScreenDepth_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_set_debugScreenDepth_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_set_afterPostProcessColor_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_get_overlayUITexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_set_overlayUITexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_get_renderingLayersTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_set_renderingLayersTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_get_dBuffer_Public_get_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_set_dBuffer_Public_set_Void_Il2CppStructArray_1_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_get_dBufferDepth_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_set_dBufferDepth_Public_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_get_ssaoTexture_Public_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_set_ssaoTexture_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_get_stpDebugView_Internal_get_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_set_stpDebugView_Internal_set_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr, 100664628);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087434, XrefRangeEnd = 1087531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087531, XrefRangeEnd = 1087539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalResourceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalResourceData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalResourceData(IntPtr pointer)
		: base(pointer)
	{
	}
}
