using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal;

public class UniversalAdditionalLightData : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly IntPtr NativeFieldInfoPtr_m_UsePipelineSettings;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution;

	private static readonly IntPtr NativeFieldInfoPtr_m_Light;

	private static readonly IntPtr NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution;

	private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier;

	private static readonly IntPtr NativeFieldInfoPtr_m_LightLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayers;

	private static readonly IntPtr NativeFieldInfoPtr_m_CustomShadowLayers;

	private static readonly IntPtr NativeFieldInfoPtr_m_ShadowLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_m_ShadowRenderingLayers;

	private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_LightCookieOffset;

	private static readonly IntPtr NativeFieldInfoPtr_m_SoftShadowQuality;

	private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_light_Internal_get_Light_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int m_Version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version)) = value;
		}
	}

	public unsafe bool m_UsePipelineSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsePipelineSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsePipelineSettings)) = value;
		}
	}

	public unsafe static int AdditionalLightsShadowResolutionTierCustom
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsShadowResolutionTierLow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsShadowResolutionTierMedium
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsShadowResolutionTierHigh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsShadowDefaultResolutionTier
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier, (void*)(&value));
		}
	}

	public unsafe static int AdditionalLightsShadowDefaultCustomResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution, (void*)(&value));
		}
	}

	public unsafe Light m_Light
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Light);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Light)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int AdditionalLightsShadowMinimumResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution, (void*)(&value));
		}
	}

	public unsafe int m_AdditionalLightsShadowResolutionTier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier)) = value;
		}
	}

	public unsafe LightLayerEnum m_LightLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightLayerMask);
			return *(LightLayerEnum*)num;
		}
		set
		{
			*(LightLayerEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightLayerMask)) = value;
		}
	}

	public unsafe uint m_RenderingLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayers);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayers)) = value;
		}
	}

	public unsafe bool m_CustomShadowLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CustomShadowLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CustomShadowLayers)) = value;
		}
	}

	public unsafe LightLayerEnum m_ShadowLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowLayerMask);
			return *(LightLayerEnum*)num;
		}
		set
		{
			*(LightLayerEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowLayerMask)) = value;
		}
	}

	public unsafe uint m_ShadowRenderingLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowRenderingLayers);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowRenderingLayers)) = value;
		}
	}

	public unsafe Vector2 m_LightCookieSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieSize)) = value;
		}
	}

	public unsafe Vector2 m_LightCookieOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieOffset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieOffset)) = value;
		}
	}

	public unsafe SoftShadowQuality m_SoftShadowQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowQuality);
			return *(SoftShadowQuality*)num;
		}
		set
		{
			*(SoftShadowQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SoftShadowQuality)) = value;
		}
	}

	public unsafe int version
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool usePipelineSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Light light
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1101857, RefRangeEnd = 1101859, XrefRangeStart = 1101850, XrefRangeEnd = 1101857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_light_Internal_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
	}

	public unsafe int additionalLightsShadowResolutionTier
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LightLayerEnum lightLayerMask
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightLayerEnum*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint renderingLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101859, XrefRangeEnd = 1101860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool customShadowLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101860, XrefRangeEnd = 1101861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightLayerEnum shadowLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightLayerEnum*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint shadowRenderingLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101861, XrefRangeEnd = 1101862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 lightCookieSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 lightCookieOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SoftShadowQuality softShadowQuality
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41565, RefRangeEnd = 41568, XrefRangeStart = 41565, XrefRangeEnd = 41568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SoftShadowQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293993, RefRangeEnd = 293998, XrefRangeStart = 293993, XrefRangeEnd = 293998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static UniversalAdditionalLightData()
	{
		Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalAdditionalLightData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr);
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_m_UsePipelineSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_UsePipelineSettings");
		NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierCustom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierCustom");
		NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierLow");
		NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierMedium");
		NativeFieldInfoPtr_AdditionalLightsShadowResolutionTierHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowResolutionTierHigh");
		NativeFieldInfoPtr_AdditionalLightsShadowDefaultResolutionTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowDefaultResolutionTier");
		NativeFieldInfoPtr_AdditionalLightsShadowDefaultCustomResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowDefaultCustomResolution");
		NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_Light");
		NativeFieldInfoPtr_AdditionalLightsShadowMinimumResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "AdditionalLightsShadowMinimumResolution");
		NativeFieldInfoPtr_m_AdditionalLightsShadowResolutionTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_AdditionalLightsShadowResolutionTier");
		NativeFieldInfoPtr_m_LightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightLayerMask");
		NativeFieldInfoPtr_m_RenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_RenderingLayers");
		NativeFieldInfoPtr_m_CustomShadowLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_CustomShadowLayers");
		NativeFieldInfoPtr_m_ShadowLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_ShadowLayerMask");
		NativeFieldInfoPtr_m_ShadowRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_ShadowRenderingLayers");
		NativeFieldInfoPtr_m_LightCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightCookieSize");
		NativeFieldInfoPtr_m_LightCookieOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_LightCookieOffset");
		NativeFieldInfoPtr_m_SoftShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, "m_SoftShadowQuality");
		NativeMethodInfoPtr_get_version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665724);
		NativeMethodInfoPtr_get_usePipelineSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665725);
		NativeMethodInfoPtr_set_usePipelineSettings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665726);
		NativeMethodInfoPtr_get_light_Internal_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665727);
		NativeMethodInfoPtr_get_additionalLightsShadowResolutionTier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665728);
		NativeMethodInfoPtr_get_lightLayerMask_Public_get_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665729);
		NativeMethodInfoPtr_set_lightLayerMask_Public_set_Void_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665730);
		NativeMethodInfoPtr_get_renderingLayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665731);
		NativeMethodInfoPtr_set_renderingLayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665732);
		NativeMethodInfoPtr_get_customShadowLayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665733);
		NativeMethodInfoPtr_set_customShadowLayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665734);
		NativeMethodInfoPtr_get_shadowLayerMask_Public_get_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665735);
		NativeMethodInfoPtr_set_shadowLayerMask_Public_set_Void_LightLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665736);
		NativeMethodInfoPtr_get_shadowRenderingLayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665737);
		NativeMethodInfoPtr_set_shadowRenderingLayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665738);
		NativeMethodInfoPtr_get_lightCookieSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665739);
		NativeMethodInfoPtr_set_lightCookieSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665740);
		NativeMethodInfoPtr_get_lightCookieOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665741);
		NativeMethodInfoPtr_set_lightCookieOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665742);
		NativeMethodInfoPtr_get_softShadowQuality_Public_get_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665743);
		NativeMethodInfoPtr_set_softShadowQuality_Public_set_Void_SoftShadowQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665744);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665745);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665746);
		NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665747);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr, 100665748);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101862, XrefRangeEnd = 1101868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1101875, RefRangeEnd = 1101878, XrefRangeStart = 1101868, XrefRangeEnd = 1101875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncLightAndShadowLayers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncLightAndShadowLayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101878, XrefRangeEnd = 1101887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalAdditionalLightData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalAdditionalLightData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalAdditionalLightData(IntPtr pointer)
		: base(pointer)
	{
	}
}
