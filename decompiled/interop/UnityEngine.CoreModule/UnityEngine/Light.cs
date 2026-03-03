using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class Light : Behaviour
{
	private delegate System.IntPtr GetLightsDelegate(LightType type, int layer);

	private delegate void set_type_InjectedDelegate(System.IntPtr _unity_self, LightType value);

	private delegate void set_spotAngle_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_innerSpotAngle_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_color_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_colorTemperature_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_useColorTemperature_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_intensity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_bounceIntensity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate LightUnit get_lightUnit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_lightUnit_InjectedDelegate(System.IntPtr _unity_self, LightUnit value);

	private delegate void set_luxAtDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_enableSpotReflector_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_useBoundingSphereOverride_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useBoundingSphereOverride_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_boundingSphereOverride_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_boundingSphereOverride_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate bool get_useViewFrustumForShadowCasterCull_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useViewFrustumForShadowCasterCull_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_forceVisible_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_forceVisible_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_shadowCustomResolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shadowCustomResolution_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void set_shadowBias_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_shadowNormalBias_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_shadowNearPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_useShadowMatrixOverride_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useShadowMatrixOverride_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_shadowMatrixOverride_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_shadowMatrixOverride_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_range_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate System.IntPtr get_flare_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_flare_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void set_bakingOutput_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate int get_cullingMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_renderingLayerMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate LightShadowCasterMode get_lightShadowCasterMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_lightShadowCasterMode_InjectedDelegate(System.IntPtr _unity_self, LightShadowCasterMode value);

	private delegate void Reset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shadows_InjectedDelegate(System.IntPtr _unity_self, LightShadows value);

	private delegate void set_shadowStrength_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_shadowResolution_InjectedDelegate(System.IntPtr _unity_self, LightShadowResolution value);

	private delegate void get_layerShadowCullDistances_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_layerShadowCullDistances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void set_cookieSize_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_cookie_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate LightRenderMode get_renderMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderMode_InjectedDelegate(System.IntPtr _unity_self, LightRenderMode value);

	private delegate void set_areaSize_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void AddCommandBufferInternal_InjectedDelegate(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer, ShadowMapPass shadowPassMask);

	private delegate void AddCommandBufferAsyncInternal_InjectedDelegate(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType);

	private delegate void RemoveCommandBufferInternal_InjectedDelegate(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer);

	private delegate void RemoveCommandBuffersInternal_InjectedDelegate(System.IntPtr _unity_self, LightEvent evt);

	private delegate void RemoveAllCommandBuffersInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetCommandBuffersInternal_InjectedDelegate(System.IntPtr _unity_self, LightEvent evt);

	private delegate int get_commandBufferCount_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr__shape_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BakedIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_LightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_luxAtDistance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableSpotReflector_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dilatedRange_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cookie_Public_get_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_areaSize_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Injected_Private_Static_LightType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spotAngle_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_innerSpotAngle_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorTemperature_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useColorTemperature_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_intensity_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounceIntensity_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_luxAtDistance_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableSpotReflector_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowNormalBias_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowNearPlane_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_range_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dilatedRange_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Static_Void_IntPtr_byref_LightBakingOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadows_Injected_Private_Static_LightShadows_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowStrength_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowResolution_Injected_Private_Static_LightShadowResolution_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cookieSize_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cookie_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_areaSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly GetLightsDelegate GetLightsDelegateField;

	private static readonly set_type_InjectedDelegate set_type_InjectedDelegateField;

	private static readonly set_spotAngle_InjectedDelegate set_spotAngle_InjectedDelegateField;

	private static readonly set_innerSpotAngle_InjectedDelegate set_innerSpotAngle_InjectedDelegateField;

	private static readonly set_color_InjectedDelegate set_color_InjectedDelegateField;

	private static readonly set_colorTemperature_InjectedDelegate set_colorTemperature_InjectedDelegateField;

	private static readonly set_useColorTemperature_InjectedDelegate set_useColorTemperature_InjectedDelegateField;

	private static readonly set_intensity_InjectedDelegate set_intensity_InjectedDelegateField;

	private static readonly set_bounceIntensity_InjectedDelegate set_bounceIntensity_InjectedDelegateField;

	private static readonly get_lightUnit_InjectedDelegate get_lightUnit_InjectedDelegateField;

	private static readonly set_lightUnit_InjectedDelegate set_lightUnit_InjectedDelegateField;

	private static readonly set_luxAtDistance_InjectedDelegate set_luxAtDistance_InjectedDelegateField;

	private static readonly set_enableSpotReflector_InjectedDelegate set_enableSpotReflector_InjectedDelegateField;

	private static readonly get_useBoundingSphereOverride_InjectedDelegate get_useBoundingSphereOverride_InjectedDelegateField;

	private static readonly set_useBoundingSphereOverride_InjectedDelegate set_useBoundingSphereOverride_InjectedDelegateField;

	private static readonly get_boundingSphereOverride_InjectedDelegate get_boundingSphereOverride_InjectedDelegateField;

	private static readonly set_boundingSphereOverride_InjectedDelegate set_boundingSphereOverride_InjectedDelegateField;

	private static readonly get_useViewFrustumForShadowCasterCull_InjectedDelegate get_useViewFrustumForShadowCasterCull_InjectedDelegateField;

	private static readonly set_useViewFrustumForShadowCasterCull_InjectedDelegate set_useViewFrustumForShadowCasterCull_InjectedDelegateField;

	private static readonly get_forceVisible_InjectedDelegate get_forceVisible_InjectedDelegateField;

	private static readonly set_forceVisible_InjectedDelegate set_forceVisible_InjectedDelegateField;

	private static readonly get_shadowCustomResolution_InjectedDelegate get_shadowCustomResolution_InjectedDelegateField;

	private static readonly set_shadowCustomResolution_InjectedDelegate set_shadowCustomResolution_InjectedDelegateField;

	private static readonly set_shadowBias_InjectedDelegate set_shadowBias_InjectedDelegateField;

	private static readonly set_shadowNormalBias_InjectedDelegate set_shadowNormalBias_InjectedDelegateField;

	private static readonly set_shadowNearPlane_InjectedDelegate set_shadowNearPlane_InjectedDelegateField;

	private static readonly get_useShadowMatrixOverride_InjectedDelegate get_useShadowMatrixOverride_InjectedDelegateField;

	private static readonly set_useShadowMatrixOverride_InjectedDelegate set_useShadowMatrixOverride_InjectedDelegateField;

	private static readonly get_shadowMatrixOverride_InjectedDelegate get_shadowMatrixOverride_InjectedDelegateField;

	private static readonly set_shadowMatrixOverride_InjectedDelegate set_shadowMatrixOverride_InjectedDelegateField;

	private static readonly set_range_InjectedDelegate set_range_InjectedDelegateField;

	private static readonly get_flare_InjectedDelegate get_flare_InjectedDelegateField;

	private static readonly set_flare_InjectedDelegate set_flare_InjectedDelegateField;

	private static readonly set_bakingOutput_InjectedDelegate set_bakingOutput_InjectedDelegateField;

	private static readonly get_cullingMask_InjectedDelegate get_cullingMask_InjectedDelegateField;

	private static readonly get_renderingLayerMask_InjectedDelegate get_renderingLayerMask_InjectedDelegateField;

	private static readonly get_lightShadowCasterMode_InjectedDelegate get_lightShadowCasterMode_InjectedDelegateField;

	private static readonly set_lightShadowCasterMode_InjectedDelegate set_lightShadowCasterMode_InjectedDelegateField;

	private static readonly Reset_InjectedDelegate Reset_InjectedDelegateField;

	private static readonly set_shadows_InjectedDelegate set_shadows_InjectedDelegateField;

	private static readonly set_shadowStrength_InjectedDelegate set_shadowStrength_InjectedDelegateField;

	private static readonly set_shadowResolution_InjectedDelegate set_shadowResolution_InjectedDelegateField;

	private static readonly get_layerShadowCullDistances_InjectedDelegate get_layerShadowCullDistances_InjectedDelegateField;

	private static readonly set_layerShadowCullDistances_InjectedDelegate set_layerShadowCullDistances_InjectedDelegateField;

	private static readonly set_cookieSize_InjectedDelegate set_cookieSize_InjectedDelegateField;

	private static readonly set_cookie_InjectedDelegate set_cookie_InjectedDelegateField;

	private static readonly get_renderMode_InjectedDelegate get_renderMode_InjectedDelegateField;

	private static readonly set_renderMode_InjectedDelegate set_renderMode_InjectedDelegateField;

	private static readonly set_areaSize_InjectedDelegate set_areaSize_InjectedDelegateField;

	private static readonly AddCommandBufferInternal_InjectedDelegate AddCommandBufferInternal_InjectedDelegateField;

	private static readonly AddCommandBufferAsyncInternal_InjectedDelegate AddCommandBufferAsyncInternal_InjectedDelegateField;

	private static readonly RemoveCommandBufferInternal_InjectedDelegate RemoveCommandBufferInternal_InjectedDelegateField;

	private static readonly RemoveCommandBuffersInternal_InjectedDelegate RemoveCommandBuffersInternal_InjectedDelegateField;

	private static readonly RemoveAllCommandBuffersInternal_InjectedDelegate RemoveAllCommandBuffersInternal_InjectedDelegateField;

	private static readonly GetCommandBuffersInternal_InjectedDelegate GetCommandBuffersInternal_InjectedDelegateField;

	private static readonly get_commandBufferCount_InjectedDelegate get_commandBufferCount_InjectedDelegateField;

	public unsafe LightShape _shape_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shape_k__BackingField);
			return *(LightShape*)num;
		}
		set
		{
			*(LightShape*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shape_k__BackingField)) = value;
		}
	}

	public unsafe int m_BakedIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BakedIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BakedIndex)) = value;
		}
	}

	public unsafe LightType type
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1177718, RefRangeEnd = 1177726, XrefRangeStart = 1177713, XrefRangeEnd = 1177718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_type_Injected(intPtr, value);
		}
	}

	public unsafe float spotAngle
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1177731, RefRangeEnd = 1177735, XrefRangeStart = 1177726, XrefRangeEnd = 1177731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_spotAngle_Injected(intPtr, value);
		}
	}

	public unsafe float innerSpotAngle
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1177740, RefRangeEnd = 1177742, XrefRangeStart = 1177735, XrefRangeEnd = 1177740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_innerSpotAngle_Injected(intPtr, value);
		}
	}

	public unsafe Color color
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1177746, RefRangeEnd = 1177758, XrefRangeStart = 1177742, XrefRangeEnd = 1177746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_color_Injected(intPtr, ref value);
		}
	}

	public unsafe float colorTemperature
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1177763, RefRangeEnd = 1177769, XrefRangeStart = 1177758, XrefRangeEnd = 1177763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_colorTemperature_Injected(intPtr, value);
		}
	}

	public unsafe bool useColorTemperature
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1177774, RefRangeEnd = 1177780, XrefRangeStart = 1177769, XrefRangeEnd = 1177774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			set_useColorTemperature_Injected(intPtr, value);
		}
	}

	public unsafe float intensity
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1177785, RefRangeEnd = 1177799, XrefRangeStart = 1177780, XrefRangeEnd = 1177785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_intensity_Injected(intPtr, value);
		}
	}

	public unsafe float bounceIntensity
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1177804, RefRangeEnd = 1177810, XrefRangeStart = 1177799, XrefRangeEnd = 1177804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bounceIntensity_Injected(intPtr, value);
		}
	}

	public unsafe float luxAtDistance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1177815, RefRangeEnd = 1177817, XrefRangeStart = 1177810, XrefRangeEnd = 1177815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_luxAtDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_luxAtDistance_Injected(intPtr, value);
		}
	}

	public unsafe bool enableSpotReflector
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177822, RefRangeEnd = 1177823, XrefRangeStart = 1177817, XrefRangeEnd = 1177822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableSpotReflector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			set_enableSpotReflector_Injected(intPtr, value);
		}
	}

	public unsafe float shadowBias
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177828, RefRangeEnd = 1177829, XrefRangeStart = 1177823, XrefRangeEnd = 1177828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowBias_Injected(intPtr, value);
		}
	}

	public unsafe float shadowNormalBias
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177834, RefRangeEnd = 1177835, XrefRangeStart = 1177829, XrefRangeEnd = 1177834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowNormalBias_Injected(intPtr, value);
		}
	}

	public unsafe float shadowNearPlane
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177840, RefRangeEnd = 1177841, XrefRangeStart = 1177835, XrefRangeEnd = 1177840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowNearPlane_Injected(intPtr, value);
		}
	}

	public unsafe float range
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1177846, RefRangeEnd = 1177849, XrefRangeStart = 1177841, XrefRangeEnd = 1177846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_range_Injected(intPtr, value);
		}
	}

	public unsafe float dilatedRange
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1177854, RefRangeEnd = 1177856, XrefRangeStart = 1177849, XrefRangeEnd = 1177854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dilatedRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LightBakingOutput bakingOutput
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1177860, RefRangeEnd = 1177888, XrefRangeStart = 1177856, XrefRangeEnd = 1177860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightBakingOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bakingOutput_Injected(intPtr, ref value);
		}
	}

	public unsafe int cullingMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cullingMask_Injected(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1177893, RefRangeEnd = 1177896, XrefRangeStart = 1177888, XrefRangeEnd = 1177893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int renderingLayerMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderingLayerMask_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177901, RefRangeEnd = 1177902, XrefRangeStart = 1177896, XrefRangeEnd = 1177901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightShadows shadows
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1177907, RefRangeEnd = 1177943, XrefRangeStart = 1177902, XrefRangeEnd = 1177907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightShadows*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadows_Injected(intPtr, value);
		}
	}

	public unsafe float shadowStrength
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1177948, RefRangeEnd = 1177959, XrefRangeStart = 1177943, XrefRangeEnd = 1177948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowStrength_Injected(intPtr, value);
		}
	}

	public unsafe LightShadowResolution shadowResolution
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1177964, RefRangeEnd = 1177965, XrefRangeStart = 1177959, XrefRangeEnd = 1177964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightShadowResolution*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowResolution_Injected(intPtr, value);
		}
	}

	public unsafe float cookieSize
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1177970, RefRangeEnd = 1177972, XrefRangeStart = 1177965, XrefRangeEnd = 1177970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cookieSize_Injected(intPtr, value);
		}
	}

	public unsafe Texture cookie
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1177980, RefRangeEnd = 1177990, XrefRangeStart = 1177972, XrefRangeEnd = 1177980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookie_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cookie_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe Vector2 areaSize
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1177994, RefRangeEnd = 1177998, XrefRangeStart = 1177990, XrefRangeEnd = 1177994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_areaSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_areaSize_Injected(intPtr, ref value);
		}
	}

	public LightShape shape
	{
		get
		{
			return _shape_k__BackingField;
		}
		set
		{
			_shape_k__BackingField = value;
		}
	}

	public LightUnit lightUnit
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lightUnit_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lightUnit_Injected(intPtr, value);
		}
	}

	public bool useBoundingSphereOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useBoundingSphereOverride_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useBoundingSphereOverride_Injected(intPtr, value);
		}
	}

	public Vector4 boundingSphereOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_boundingSphereOverride_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_boundingSphereOverride_Injected(intPtr, ref value);
		}
	}

	public bool useViewFrustumForShadowCasterCull
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useViewFrustumForShadowCasterCull_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useViewFrustumForShadowCasterCull_Injected(intPtr, value);
		}
	}

	public bool forceVisible
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceVisible_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceVisible_Injected(intPtr, value);
		}
	}

	public int shadowCustomResolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shadowCustomResolution_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowCustomResolution_Injected(intPtr, value);
		}
	}

	public bool useShadowMatrixOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useShadowMatrixOverride_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useShadowMatrixOverride_Injected(intPtr, value);
		}
	}

	public Matrix4x4 shadowMatrixOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_shadowMatrixOverride_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowMatrixOverride_Injected(intPtr, ref value);
		}
	}

	public Flare flare
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Flare>(get_flare_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flare_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public LightShadowCasterMode lightShadowCasterMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lightShadowCasterMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lightShadowCasterMode_Injected(intPtr, value);
		}
	}

	public float shadowSoftness
	{
		get
		{
			return 4f;
		}
		set
		{
		}
	}

	public float shadowSoftnessFade
	{
		get
		{
			return 1f;
		}
		set
		{
		}
	}

	public unsafe Il2CppStructArray<float> layerShadowCullDistances
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<float> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_layerShadowCullDistances_Injected(intPtr, out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<float> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<float>*)(&array));
				result = array;
			}
			return result;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_001f: Expected O, but got Ref
			//IL_002b: Expected O, but got Ref
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
			((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)value);
			fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper value2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
				set_layerShadowCullDistances_Injected(intPtr, ref value2);
			}
		}
	}

	public LightRenderMode renderMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderMode_Injected(intPtr, value);
		}
	}

	public int bakedIndex
	{
		get
		{
			return m_BakedIndex;
		}
		set
		{
			m_BakedIndex = value;
		}
	}

	public int commandBufferCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_commandBufferCount_Injected(intPtr);
		}
	}

	public static int pixelLightCount
	{
		get
		{
			return QualitySettings.pixelLightCount;
		}
		set
		{
			QualitySettings.pixelLightCount = value;
		}
	}

	public float shadowConstantBias
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float shadowObjectSizeBias
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool attenuate
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	static Light()
	{
		Il2CppClassPointerStore<Light>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Light");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light>.NativeClassPtr);
		NativeFieldInfoPtr__shape_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "<shape>k__BackingField");
		NativeFieldInfoPtr_m_BakedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "m_BakedIndex");
		NativeMethodInfoPtr_get_type_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664871);
		NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_get_innerSpotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664874);
		NativeMethodInfoPtr_get_colorTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664875);
		NativeMethodInfoPtr_get_useColorTemperature_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664876);
		NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664877);
		NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664878);
		NativeMethodInfoPtr_get_luxAtDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664879);
		NativeMethodInfoPtr_get_enableSpotReflector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664880);
		NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664881);
		NativeMethodInfoPtr_get_shadowNormalBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664882);
		NativeMethodInfoPtr_get_shadowNearPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664883);
		NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664884);
		NativeMethodInfoPtr_get_dilatedRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664885);
		NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664886);
		NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664887);
		NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664888);
		NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664889);
		NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664890);
		NativeMethodInfoPtr_get_shadowResolution_Public_get_LightShadowResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664891);
		NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664892);
		NativeMethodInfoPtr_get_cookie_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664893);
		NativeMethodInfoPtr_get_areaSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664894);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664895);
		NativeMethodInfoPtr_get_type_Injected_Private_Static_LightType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664896);
		NativeMethodInfoPtr_get_spotAngle_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664897);
		NativeMethodInfoPtr_get_innerSpotAngle_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664898);
		NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664899);
		NativeMethodInfoPtr_get_colorTemperature_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664900);
		NativeMethodInfoPtr_get_useColorTemperature_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664901);
		NativeMethodInfoPtr_get_intensity_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664902);
		NativeMethodInfoPtr_get_bounceIntensity_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664903);
		NativeMethodInfoPtr_get_luxAtDistance_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664904);
		NativeMethodInfoPtr_get_enableSpotReflector_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664905);
		NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664906);
		NativeMethodInfoPtr_get_shadowNormalBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664907);
		NativeMethodInfoPtr_get_shadowNearPlane_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664908);
		NativeMethodInfoPtr_get_range_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664909);
		NativeMethodInfoPtr_get_dilatedRange_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664910);
		NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Static_Void_IntPtr_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664911);
		NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664912);
		NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664913);
		NativeMethodInfoPtr_get_shadows_Injected_Private_Static_LightShadows_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664914);
		NativeMethodInfoPtr_get_shadowStrength_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664915);
		NativeMethodInfoPtr_get_shadowResolution_Injected_Private_Static_LightShadowResolution_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664916);
		NativeMethodInfoPtr_get_cookieSize_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664917);
		NativeMethodInfoPtr_get_cookie_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_get_areaSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664919);
		GetLightsDelegateField = IL2CPP.ResolveICall<GetLightsDelegate>("UnityEngine.Light::GetLights");
		set_type_InjectedDelegateField = IL2CPP.ResolveICall<set_type_InjectedDelegate>("UnityEngine.Light::set_type_Injected");
		set_spotAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_spotAngle_InjectedDelegate>("UnityEngine.Light::set_spotAngle_Injected");
		set_innerSpotAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_innerSpotAngle_InjectedDelegate>("UnityEngine.Light::set_innerSpotAngle_Injected");
		set_color_InjectedDelegateField = IL2CPP.ResolveICall<set_color_InjectedDelegate>("UnityEngine.Light::set_color_Injected");
		set_colorTemperature_InjectedDelegateField = IL2CPP.ResolveICall<set_colorTemperature_InjectedDelegate>("UnityEngine.Light::set_colorTemperature_Injected");
		set_useColorTemperature_InjectedDelegateField = IL2CPP.ResolveICall<set_useColorTemperature_InjectedDelegate>("UnityEngine.Light::set_useColorTemperature_Injected");
		set_intensity_InjectedDelegateField = IL2CPP.ResolveICall<set_intensity_InjectedDelegate>("UnityEngine.Light::set_intensity_Injected");
		set_bounceIntensity_InjectedDelegateField = IL2CPP.ResolveICall<set_bounceIntensity_InjectedDelegate>("UnityEngine.Light::set_bounceIntensity_Injected");
		get_lightUnit_InjectedDelegateField = IL2CPP.ResolveICall<get_lightUnit_InjectedDelegate>("UnityEngine.Light::get_lightUnit_Injected");
		set_lightUnit_InjectedDelegateField = IL2CPP.ResolveICall<set_lightUnit_InjectedDelegate>("UnityEngine.Light::set_lightUnit_Injected");
		set_luxAtDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_luxAtDistance_InjectedDelegate>("UnityEngine.Light::set_luxAtDistance_Injected");
		set_enableSpotReflector_InjectedDelegateField = IL2CPP.ResolveICall<set_enableSpotReflector_InjectedDelegate>("UnityEngine.Light::set_enableSpotReflector_Injected");
		get_useBoundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_useBoundingSphereOverride_InjectedDelegate>("UnityEngine.Light::get_useBoundingSphereOverride_Injected");
		set_useBoundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_useBoundingSphereOverride_InjectedDelegate>("UnityEngine.Light::set_useBoundingSphereOverride_Injected");
		get_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::get_boundingSphereOverride_Injected");
		set_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::set_boundingSphereOverride_Injected");
		get_useViewFrustumForShadowCasterCull_InjectedDelegateField = IL2CPP.ResolveICall<get_useViewFrustumForShadowCasterCull_InjectedDelegate>("UnityEngine.Light::get_useViewFrustumForShadowCasterCull_Injected");
		set_useViewFrustumForShadowCasterCull_InjectedDelegateField = IL2CPP.ResolveICall<set_useViewFrustumForShadowCasterCull_InjectedDelegate>("UnityEngine.Light::set_useViewFrustumForShadowCasterCull_Injected");
		get_forceVisible_InjectedDelegateField = IL2CPP.ResolveICall<get_forceVisible_InjectedDelegate>("UnityEngine.Light::get_forceVisible_Injected");
		set_forceVisible_InjectedDelegateField = IL2CPP.ResolveICall<set_forceVisible_InjectedDelegate>("UnityEngine.Light::set_forceVisible_Injected");
		get_shadowCustomResolution_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowCustomResolution_InjectedDelegate>("UnityEngine.Light::get_shadowCustomResolution_Injected");
		set_shadowCustomResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowCustomResolution_InjectedDelegate>("UnityEngine.Light::set_shadowCustomResolution_Injected");
		set_shadowBias_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowBias_InjectedDelegate>("UnityEngine.Light::set_shadowBias_Injected");
		set_shadowNormalBias_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowNormalBias_InjectedDelegate>("UnityEngine.Light::set_shadowNormalBias_Injected");
		set_shadowNearPlane_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowNearPlane_InjectedDelegate>("UnityEngine.Light::set_shadowNearPlane_Injected");
		get_useShadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_useShadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::get_useShadowMatrixOverride_Injected");
		set_useShadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_useShadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::set_useShadowMatrixOverride_Injected");
		get_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::get_shadowMatrixOverride_Injected");
		set_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::set_shadowMatrixOverride_Injected");
		set_range_InjectedDelegateField = IL2CPP.ResolveICall<set_range_InjectedDelegate>("UnityEngine.Light::set_range_Injected");
		get_flare_InjectedDelegateField = IL2CPP.ResolveICall<get_flare_InjectedDelegate>("UnityEngine.Light::get_flare_Injected");
		set_flare_InjectedDelegateField = IL2CPP.ResolveICall<set_flare_InjectedDelegate>("UnityEngine.Light::set_flare_Injected");
		set_bakingOutput_InjectedDelegateField = IL2CPP.ResolveICall<set_bakingOutput_InjectedDelegate>("UnityEngine.Light::set_bakingOutput_Injected");
		get_cullingMask_InjectedDelegateField = IL2CPP.ResolveICall<get_cullingMask_InjectedDelegate>("UnityEngine.Light::get_cullingMask_Injected");
		get_renderingLayerMask_InjectedDelegateField = IL2CPP.ResolveICall<get_renderingLayerMask_InjectedDelegate>("UnityEngine.Light::get_renderingLayerMask_Injected");
		get_lightShadowCasterMode_InjectedDelegateField = IL2CPP.ResolveICall<get_lightShadowCasterMode_InjectedDelegate>("UnityEngine.Light::get_lightShadowCasterMode_Injected");
		set_lightShadowCasterMode_InjectedDelegateField = IL2CPP.ResolveICall<set_lightShadowCasterMode_InjectedDelegate>("UnityEngine.Light::set_lightShadowCasterMode_Injected");
		Reset_InjectedDelegateField = IL2CPP.ResolveICall<Reset_InjectedDelegate>("UnityEngine.Light::Reset_Injected");
		set_shadows_InjectedDelegateField = IL2CPP.ResolveICall<set_shadows_InjectedDelegate>("UnityEngine.Light::set_shadows_Injected");
		set_shadowStrength_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowStrength_InjectedDelegate>("UnityEngine.Light::set_shadowStrength_Injected");
		set_shadowResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowResolution_InjectedDelegate>("UnityEngine.Light::set_shadowResolution_Injected");
		get_layerShadowCullDistances_InjectedDelegateField = IL2CPP.ResolveICall<get_layerShadowCullDistances_InjectedDelegate>("UnityEngine.Light::get_layerShadowCullDistances_Injected");
		set_layerShadowCullDistances_InjectedDelegateField = IL2CPP.ResolveICall<set_layerShadowCullDistances_InjectedDelegate>("UnityEngine.Light::set_layerShadowCullDistances_Injected");
		set_cookieSize_InjectedDelegateField = IL2CPP.ResolveICall<set_cookieSize_InjectedDelegate>("UnityEngine.Light::set_cookieSize_Injected");
		set_cookie_InjectedDelegateField = IL2CPP.ResolveICall<set_cookie_InjectedDelegate>("UnityEngine.Light::set_cookie_Injected");
		get_renderMode_InjectedDelegateField = IL2CPP.ResolveICall<get_renderMode_InjectedDelegate>("UnityEngine.Light::get_renderMode_Injected");
		set_renderMode_InjectedDelegateField = IL2CPP.ResolveICall<set_renderMode_InjectedDelegate>("UnityEngine.Light::set_renderMode_Injected");
		set_areaSize_InjectedDelegateField = IL2CPP.ResolveICall<set_areaSize_InjectedDelegate>("UnityEngine.Light::set_areaSize_Injected");
		AddCommandBufferInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddCommandBufferInternal_InjectedDelegate>("UnityEngine.Light::AddCommandBufferInternal_Injected");
		AddCommandBufferAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddCommandBufferAsyncInternal_InjectedDelegate>("UnityEngine.Light::AddCommandBufferAsyncInternal_Injected");
		RemoveCommandBufferInternal_InjectedDelegateField = IL2CPP.ResolveICall<RemoveCommandBufferInternal_InjectedDelegate>("UnityEngine.Light::RemoveCommandBufferInternal_Injected");
		RemoveCommandBuffersInternal_InjectedDelegateField = IL2CPP.ResolveICall<RemoveCommandBuffersInternal_InjectedDelegate>("UnityEngine.Light::RemoveCommandBuffersInternal_Injected");
		RemoveAllCommandBuffersInternal_InjectedDelegateField = IL2CPP.ResolveICall<RemoveAllCommandBuffersInternal_InjectedDelegate>("UnityEngine.Light::RemoveAllCommandBuffersInternal_Injected");
		GetCommandBuffersInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetCommandBuffersInternal_InjectedDelegate>("UnityEngine.Light::GetCommandBuffersInternal_Injected");
		get_commandBufferCount_InjectedDelegateField = IL2CPP.ResolveICall<get_commandBufferCount_InjectedDelegate>("UnityEngine.Light::get_commandBufferCount_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Light()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Light>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177998, XrefRangeEnd = 1178000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LightType get_type_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Injected_Private_Static_LightType_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178000, XrefRangeEnd = 1178002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_spotAngle_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spotAngle_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178002, XrefRangeEnd = 1178004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_innerSpotAngle_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_innerSpotAngle_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178004, XrefRangeEnd = 1178006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_color_Injected(System.IntPtr _unity_self, out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178006, XrefRangeEnd = 1178008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_colorTemperature_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorTemperature_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178008, XrefRangeEnd = 1178010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_useColorTemperature_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useColorTemperature_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178010, XrefRangeEnd = 1178012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_intensity_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intensity_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178012, XrefRangeEnd = 1178014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_bounceIntensity_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounceIntensity_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178014, XrefRangeEnd = 1178016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_luxAtDistance_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_luxAtDistance_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178016, XrefRangeEnd = 1178018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_enableSpotReflector_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableSpotReflector_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178018, XrefRangeEnd = 1178020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_shadowBias_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178020, XrefRangeEnd = 1178022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_shadowNormalBias_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowNormalBias_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178022, XrefRangeEnd = 1178024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_shadowNearPlane_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowNearPlane_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178024, XrefRangeEnd = 1178026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_range_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_range_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178026, XrefRangeEnd = 1178028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_dilatedRange_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dilatedRange_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178028, XrefRangeEnd = 1178030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_bakingOutput_Injected(System.IntPtr _unity_self, out LightBakingOutput ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Static_Void_IntPtr_byref_LightBakingOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178030, XrefRangeEnd = 1178032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_cullingMask_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingMask_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178032, XrefRangeEnd = 1178034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_renderingLayerMask_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178034, XrefRangeEnd = 1178036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LightShadows get_shadows_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadows_Injected_Private_Static_LightShadows_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightShadows*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178036, XrefRangeEnd = 1178038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_shadowStrength_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowStrength_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178038, XrefRangeEnd = 1178040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LightShadowResolution get_shadowResolution_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowResolution_Injected_Private_Static_LightShadowResolution_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightShadowResolution*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178040, XrefRangeEnd = 1178042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_cookieSize_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookieSize_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178042, XrefRangeEnd = 1178044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_cookie_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookie_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178044, XrefRangeEnd = 1178046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_areaSize_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_areaSize_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Light(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Reset()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Reset_Injected(intPtr);
	}

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer)
	{
		AddCommandBuffer(evt, buffer, ShadowMapPass.All);
	}

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.AddCommandBuffer only with the built-in renderer.");
		}
		AddCommandBufferInternal(evt, buffer, shadowPassMask);
	}

	public void AddCommandBufferInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddCommandBufferInternal_Injected(intPtr, evt, (buffer == null) ? ((System.IntPtr)0) : CommandBuffer.BindingsMarshaller.ConvertToNative(buffer), shadowPassMask);
	}

	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType)
	{
		AddCommandBufferAsync(evt, buffer, ShadowMapPass.All, queueType);
	}

	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.AddCommandBufferAsync only with the built-in renderer.");
		}
		AddCommandBufferAsyncInternal(evt, buffer, shadowPassMask, queueType);
	}

	public void AddCommandBufferAsyncInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddCommandBufferAsyncInternal_Injected(intPtr, evt, (buffer == null) ? ((System.IntPtr)0) : CommandBuffer.BindingsMarshaller.ConvertToNative(buffer), shadowPassMask, queueType);
	}

	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.RemoveCommandBuffer only with the built-in renderer.");
		}
		RemoveCommandBufferInternal(evt, buffer);
	}

	public void RemoveCommandBufferInternal(LightEvent evt, CommandBuffer buffer)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveCommandBufferInternal_Injected(intPtr, evt, (buffer == null) ? ((System.IntPtr)0) : CommandBuffer.BindingsMarshaller.ConvertToNative(buffer));
	}

	public void RemoveCommandBuffers(LightEvent evt)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.RemoveCommandBuffer only with the built-in renderer.");
		}
		RemoveCommandBuffersInternal(evt);
	}

	public void RemoveCommandBuffersInternal(LightEvent evt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveCommandBuffersInternal_Injected(intPtr, evt);
	}

	public void RemoveAllCommandBuffers()
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.RemoveAllCommandBuffers only with the built-in renderer.");
		}
		RemoveAllCommandBuffersInternal();
	}

	public void RemoveAllCommandBuffersInternal()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveAllCommandBuffersInternal_Injected(intPtr);
	}

	public Il2CppReferenceArray<CommandBuffer> GetCommandBuffers(LightEvent evt)
	{
		if (RenderPipelineManager.currentPipeline != null)
		{
			Debug.LogWarning("Your project uses a scriptable render pipeline. You can use Light.GetCommandBuffers only with the built-in renderer.");
		}
		return GetCommandBuffersInternal(evt);
	}

	public Il2CppReferenceArray<CommandBuffer> GetCommandBuffersInternal(LightEvent evt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCommandBuffersInternal_Injected(intPtr, evt);
	}

	public static Il2CppReferenceArray<Light> GetLights(LightType type, int layer)
	{
		System.IntPtr intPtr = GetLightsDelegateField(type, layer);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr) : null;
	}

	public static void set_type_Injected(System.IntPtr _unity_self, LightType value)
	{
		set_type_InjectedDelegateField(_unity_self, value);
	}

	public static void set_spotAngle_Injected(System.IntPtr _unity_self, float value)
	{
		set_spotAngle_InjectedDelegateField(_unity_self, value);
	}

	public static void set_innerSpotAngle_Injected(System.IntPtr _unity_self, float value)
	{
		set_innerSpotAngle_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void set_color_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void set_colorTemperature_Injected(System.IntPtr _unity_self, float value)
	{
		set_colorTemperature_InjectedDelegateField(_unity_self, value);
	}

	public static void set_useColorTemperature_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useColorTemperature_InjectedDelegateField(_unity_self, value);
	}

	public static void set_intensity_Injected(System.IntPtr _unity_self, float value)
	{
		set_intensity_InjectedDelegateField(_unity_self, value);
	}

	public static void set_bounceIntensity_Injected(System.IntPtr _unity_self, float value)
	{
		set_bounceIntensity_InjectedDelegateField(_unity_self, value);
	}

	public static LightUnit get_lightUnit_Injected(System.IntPtr _unity_self)
	{
		return get_lightUnit_InjectedDelegateField(_unity_self);
	}

	public static void set_lightUnit_Injected(System.IntPtr _unity_self, LightUnit value)
	{
		set_lightUnit_InjectedDelegateField(_unity_self, value);
	}

	public static void set_luxAtDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_luxAtDistance_InjectedDelegateField(_unity_self, value);
	}

	public static void set_enableSpotReflector_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enableSpotReflector_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useBoundingSphereOverride_Injected(System.IntPtr _unity_self)
	{
		return get_useBoundingSphereOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_useBoundingSphereOverride_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useBoundingSphereOverride_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_boundingSphereOverride_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		get_boundingSphereOverride_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_boundingSphereOverride_Injected(System.IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_boundingSphereOverride_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_useViewFrustumForShadowCasterCull_Injected(System.IntPtr _unity_self)
	{
		return get_useViewFrustumForShadowCasterCull_InjectedDelegateField(_unity_self);
	}

	public static void set_useViewFrustumForShadowCasterCull_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useViewFrustumForShadowCasterCull_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_forceVisible_Injected(System.IntPtr _unity_self)
	{
		return get_forceVisible_InjectedDelegateField(_unity_self);
	}

	public static void set_forceVisible_Injected(System.IntPtr _unity_self, bool value)
	{
		set_forceVisible_InjectedDelegateField(_unity_self, value);
	}

	public static int get_shadowCustomResolution_Injected(System.IntPtr _unity_self)
	{
		return get_shadowCustomResolution_InjectedDelegateField(_unity_self);
	}

	public static void set_shadowCustomResolution_Injected(System.IntPtr _unity_self, int value)
	{
		set_shadowCustomResolution_InjectedDelegateField(_unity_self, value);
	}

	public static void set_shadowBias_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowBias_InjectedDelegateField(_unity_self, value);
	}

	public static void set_shadowNormalBias_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowNormalBias_InjectedDelegateField(_unity_self, value);
	}

	public static void set_shadowNearPlane_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowNearPlane_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useShadowMatrixOverride_Injected(System.IntPtr _unity_self)
	{
		return get_useShadowMatrixOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_useShadowMatrixOverride_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useShadowMatrixOverride_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_shadowMatrixOverride_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_shadowMatrixOverride_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_shadowMatrixOverride_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_shadowMatrixOverride_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void set_range_Injected(System.IntPtr _unity_self, float value)
	{
		set_range_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_flare_Injected(System.IntPtr _unity_self)
	{
		return get_flare_InjectedDelegateField(_unity_self);
	}

	public static void set_flare_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_flare_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void set_bakingOutput_Injected(System.IntPtr _unity_self, [In] ref LightBakingOutput value)
	{
		set_bakingOutput_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_cullingMask_Injected(System.IntPtr _unity_self)
	{
		return get_cullingMask_InjectedDelegateField(_unity_self);
	}

	public static int get_renderingLayerMask_Injected(System.IntPtr _unity_self)
	{
		return get_renderingLayerMask_InjectedDelegateField(_unity_self);
	}

	public static LightShadowCasterMode get_lightShadowCasterMode_Injected(System.IntPtr _unity_self)
	{
		return get_lightShadowCasterMode_InjectedDelegateField(_unity_self);
	}

	public static void set_lightShadowCasterMode_Injected(System.IntPtr _unity_self, LightShadowCasterMode value)
	{
		set_lightShadowCasterMode_InjectedDelegateField(_unity_self, value);
	}

	public static void Reset_Injected(System.IntPtr _unity_self)
	{
		Reset_InjectedDelegateField(_unity_self);
	}

	public static void set_shadows_Injected(System.IntPtr _unity_self, LightShadows value)
	{
		set_shadows_InjectedDelegateField(_unity_self, value);
	}

	public static void set_shadowStrength_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowStrength_InjectedDelegateField(_unity_self, value);
	}

	public static void set_shadowResolution_Injected(System.IntPtr _unity_self, LightShadowResolution value)
	{
		set_shadowResolution_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_layerShadowCullDistances_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_layerShadowCullDistances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_layerShadowCullDistances_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_layerShadowCullDistances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void set_cookieSize_Injected(System.IntPtr _unity_self, float value)
	{
		set_cookieSize_InjectedDelegateField(_unity_self, value);
	}

	public static void set_cookie_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_cookie_InjectedDelegateField(_unity_self, value);
	}

	public static LightRenderMode get_renderMode_Injected(System.IntPtr _unity_self)
	{
		return get_renderMode_InjectedDelegateField(_unity_self);
	}

	public static void set_renderMode_Injected(System.IntPtr _unity_self, LightRenderMode value)
	{
		set_renderMode_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void set_areaSize_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_areaSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void AddCommandBufferInternal_Injected(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer, ShadowMapPass shadowPassMask)
	{
		AddCommandBufferInternal_InjectedDelegateField(_unity_self, evt, buffer, shadowPassMask);
	}

	public static void AddCommandBufferAsyncInternal_Injected(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType)
	{
		AddCommandBufferAsyncInternal_InjectedDelegateField(_unity_self, evt, buffer, shadowPassMask, queueType);
	}

	public static void RemoveCommandBufferInternal_Injected(System.IntPtr _unity_self, LightEvent evt, System.IntPtr buffer)
	{
		RemoveCommandBufferInternal_InjectedDelegateField(_unity_self, evt, buffer);
	}

	public static void RemoveCommandBuffersInternal_Injected(System.IntPtr _unity_self, LightEvent evt)
	{
		RemoveCommandBuffersInternal_InjectedDelegateField(_unity_self, evt);
	}

	public static void RemoveAllCommandBuffersInternal_Injected(System.IntPtr _unity_self)
	{
		RemoveAllCommandBuffersInternal_InjectedDelegateField(_unity_self);
	}

	public static Il2CppReferenceArray<CommandBuffer> GetCommandBuffersInternal_Injected(System.IntPtr _unity_self, LightEvent evt)
	{
		System.IntPtr intPtr = GetCommandBuffersInternal_InjectedDelegateField(_unity_self, evt);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CommandBuffer>>(intPtr) : null;
	}

	public static int get_commandBufferCount_Injected(System.IntPtr _unity_self)
	{
		return get_commandBufferCount_InjectedDelegateField(_unity_self);
	}
}
