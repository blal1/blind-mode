using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeModes")]
	[System.Flags]
	public enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "LightmapMixedBakeModes")]
	[System.Flags]
	public enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Active;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__enlightenLightmapper_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__skyOcclusion_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ambientProbeBaking_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportsHDR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportsClouds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_skyOcclusion_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overridesLightProbeSystem_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SupportedRenderingFeatures s_Active
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Active, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Active, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReflectionProbeModes _reflectionProbeModes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbeModes_k__BackingField);
			return *(ReflectionProbeModes*)num;
		}
		set
		{
			*(ReflectionProbeModes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
		}
	}

	public unsafe LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField);
			return *(LightmapMixedBakeModes*)num;
		}
		set
		{
			*(LightmapMixedBakeModes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
		}
	}

	public unsafe LightmapMixedBakeModes _mixedLightingModes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mixedLightingModes_k__BackingField);
			return *(LightmapMixedBakeModes*)num;
		}
		set
		{
			*(LightmapMixedBakeModes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
		}
	}

	public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField);
			return *(LightmapBakeType*)num;
		}
		set
		{
			*(LightmapBakeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
		}
	}

	public unsafe LightmapsMode _lightmapsModes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightmapsModes_k__BackingField);
			return *(LightmapsMode*)num;
		}
		set
		{
			*(LightmapsMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
		}
	}

	public unsafe bool _enlightenLightmapper_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enlightenLightmapper_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enlightenLightmapper_k__BackingField)) = value;
		}
	}

	public unsafe bool _enlighten_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enlighten_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
		}
	}

	public unsafe bool _skyOcclusion_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyOcclusion_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyOcclusion_k__BackingField)) = value;
		}
	}

	public unsafe bool _lightProbeProxyVolumes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
		}
	}

	public unsafe bool _motionVectors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectors_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
		}
	}

	public unsafe bool _receiveShadows_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__receiveShadows_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
		}
	}

	public unsafe bool _reflectionProbes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbes_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
		}
	}

	public unsafe bool _reflectionProbesBlendDistance_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField)) = value;
		}
	}

	public unsafe bool _rendererPriority_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererPriority_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
		}
	}

	public unsafe bool _rendersUIOverlay_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendersUIOverlay_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesEnvironmentLighting_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesFog_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesFog_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesOtherLightingSettings_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
		}
	}

	public unsafe bool _editableMaterialRenderQueue_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesLODBias_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLODBias_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesMaximumLODLevel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesEnableLODCrossFade_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField)) = value;
		}
	}

	public unsafe bool _rendererProbes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererProbes_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
		}
	}

	public unsafe bool _particleSystemInstancing_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleSystemInstancing_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
		}
	}

	public unsafe bool _ambientProbeBaking_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ambientProbeBaking_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ambientProbeBaking_k__BackingField)) = value;
		}
	}

	public unsafe bool _defaultReflectionProbeBaking_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesShadowmask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesShadowmask_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
		}
	}

	public unsafe bool _overridesLightProbeSystem_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField)) = value;
		}
	}

	public unsafe bool _supportsHDR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsHDR_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsHDR_k__BackingField)) = value;
		}
	}

	public unsafe bool _supportsClouds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsClouds_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportsClouds_k__BackingField)) = value;
		}
	}

	public unsafe string _overridesLightProbeSystemWarningMessage_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static SupportedRenderingFeatures active
	{
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1239935, RefRangeEnd = 1239969, XrefRangeStart = 1239921, XrefRangeEnd = 1239935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239975, RefRangeEnd = 1239976, XrefRangeStart = 1239969, XrefRangeEnd = 1239975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightmapMixedBakeModes defaultMixedLightingModes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightmapMixedBakeModes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_defaultMixedLightingModes_k__BackingField = value;
		}
	}

	public unsafe LightmapMixedBakeModes mixedLightingModes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightmapMixedBakeModes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_mixedLightingModes_k__BackingField = value;
		}
	}

	public unsafe LightmapBakeType lightmapBakeTypes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightmapBakeType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_lightmapBakeTypes_k__BackingField = value;
		}
	}

	public unsafe LightmapsMode lightmapsModes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightmapsMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_lightmapsModes_k__BackingField = value;
		}
	}

	public unsafe bool enlighten
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_enlighten_k__BackingField = value;
		}
	}

	public unsafe bool skyOcclusion
	{
		get
		{
			return _skyOcclusion_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_skyOcclusion_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool rendersUIOverlay
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool ambientProbeBaking
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_ambientProbeBaking_k__BackingField = value;
		}
	}

	public unsafe bool defaultReflectionProbeBaking
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_defaultReflectionProbeBaking_k__BackingField = value;
		}
	}

	public unsafe bool overridesLightProbeSystem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overridesLightProbeSystem_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool supportsHDR
	{
		get
		{
			return _supportsHDR_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public ReflectionProbeModes reflectionProbeModes
	{
		get
		{
			return _reflectionProbeModes_k__BackingField;
		}
		set
		{
			_reflectionProbeModes_k__BackingField = value;
		}
	}

	public bool enlightenLightmapper
	{
		get
		{
			return _enlightenLightmapper_k__BackingField;
		}
		set
		{
			_enlightenLightmapper_k__BackingField = value;
		}
	}

	public bool lightProbeProxyVolumes
	{
		get
		{
			return _lightProbeProxyVolumes_k__BackingField;
		}
		set
		{
			_lightProbeProxyVolumes_k__BackingField = value;
		}
	}

	public bool motionVectors
	{
		get
		{
			return _motionVectors_k__BackingField;
		}
		set
		{
			_motionVectors_k__BackingField = value;
		}
	}

	public bool receiveShadows
	{
		get
		{
			return _receiveShadows_k__BackingField;
		}
		set
		{
			_receiveShadows_k__BackingField = value;
		}
	}

	public bool reflectionProbes
	{
		get
		{
			return _reflectionProbes_k__BackingField;
		}
		set
		{
			_reflectionProbes_k__BackingField = value;
		}
	}

	public bool reflectionProbesBlendDistance
	{
		get
		{
			return _reflectionProbesBlendDistance_k__BackingField;
		}
		set
		{
			_reflectionProbesBlendDistance_k__BackingField = value;
		}
	}

	public bool rendererPriority
	{
		get
		{
			return _rendererPriority_k__BackingField;
		}
		set
		{
			_rendererPriority_k__BackingField = value;
		}
	}

	public bool overridesEnvironmentLighting
	{
		get
		{
			return _overridesEnvironmentLighting_k__BackingField;
		}
		set
		{
			_overridesEnvironmentLighting_k__BackingField = value;
		}
	}

	public bool overridesFog
	{
		get
		{
			return _overridesFog_k__BackingField;
		}
		set
		{
			_overridesFog_k__BackingField = value;
		}
	}

	public bool overridesRealtimeReflectionProbes
	{
		get
		{
			return _overridesRealtimeReflectionProbes_k__BackingField;
		}
		set
		{
			_overridesRealtimeReflectionProbes_k__BackingField = value;
		}
	}

	public bool overridesOtherLightingSettings
	{
		get
		{
			return _overridesOtherLightingSettings_k__BackingField;
		}
		set
		{
			_overridesOtherLightingSettings_k__BackingField = value;
		}
	}

	public bool editableMaterialRenderQueue
	{
		get
		{
			return _editableMaterialRenderQueue_k__BackingField;
		}
		set
		{
			_editableMaterialRenderQueue_k__BackingField = value;
		}
	}

	public bool overridesLODBias
	{
		get
		{
			return _overridesLODBias_k__BackingField;
		}
		set
		{
			_overridesLODBias_k__BackingField = value;
		}
	}

	public bool overridesMaximumLODLevel
	{
		get
		{
			return _overridesMaximumLODLevel_k__BackingField;
		}
		set
		{
			_overridesMaximumLODLevel_k__BackingField = value;
		}
	}

	public bool overridesEnableLODCrossFade
	{
		get
		{
			return _overridesEnableLODCrossFade_k__BackingField;
		}
		set
		{
			_overridesEnableLODCrossFade_k__BackingField = value;
		}
	}

	public bool rendererProbes
	{
		get
		{
			return _rendererProbes_k__BackingField;
		}
		set
		{
			_rendererProbes_k__BackingField = value;
		}
	}

	public bool particleSystemInstancing
	{
		get
		{
			return _particleSystemInstancing_k__BackingField;
		}
		set
		{
			_particleSystemInstancing_k__BackingField = value;
		}
	}

	public bool autoAmbientProbeBaking
	{
		get
		{
			return ambientProbeBaking;
		}
		set
		{
			ambientProbeBaking = value;
		}
	}

	public bool autoDefaultReflectionProbeBaking
	{
		get
		{
			return defaultReflectionProbeBaking;
		}
		set
		{
			defaultReflectionProbeBaking = value;
		}
	}

	public bool overridesShadowmask
	{
		get
		{
			return _overridesShadowmask_k__BackingField;
		}
		set
		{
			_overridesShadowmask_k__BackingField = value;
		}
	}

	public bool supportsClouds
	{
		get
		{
			return _supportsClouds_k__BackingField;
		}
		set
		{
			_supportsClouds_k__BackingField = value;
		}
	}

	public string overridesLightProbeSystemWarningMessage
	{
		get
		{
			return _overridesLightProbeSystemWarningMessage_k__BackingField;
		}
		set
		{
			_overridesLightProbeSystemWarningMessage_k__BackingField = value;
		}
	}

	public bool terrainDetailUnsupported
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	static SupportedRenderingFeatures()
	{
		Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SupportedRenderingFeatures");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
		NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "s_Active");
		NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
		NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
		NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
		NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
		NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
		NativeFieldInfoPtr__enlightenLightmapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlightenLightmapper>k__BackingField");
		NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
		NativeFieldInfoPtr__skyOcclusion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<skyOcclusion>k__BackingField");
		NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
		NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
		NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
		NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
		NativeFieldInfoPtr__reflectionProbesBlendDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbesBlendDistance>k__BackingField");
		NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
		NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
		NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
		NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
		NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
		NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
		NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
		NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
		NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
		NativeFieldInfoPtr__overridesEnableLODCrossFade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnableLODCrossFade>k__BackingField");
		NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
		NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
		NativeFieldInfoPtr__ambientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<ambientProbeBaking>k__BackingField");
		NativeFieldInfoPtr__defaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultReflectionProbeBaking>k__BackingField");
		NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
		NativeFieldInfoPtr__overridesLightProbeSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystem>k__BackingField");
		NativeFieldInfoPtr__supportsHDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsHDR>k__BackingField");
		NativeFieldInfoPtr__supportsClouds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<supportsClouds>k__BackingField");
		NativeFieldInfoPtr__overridesLightProbeSystemWarningMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLightProbeSystemWarningMessage>k__BackingField");
		NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668793);
		NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668794);
		NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668795);
		NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668796);
		NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668797);
		NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668798);
		NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_set_skyOcclusion_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_set_rendersUIOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_get_ambientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_get_defaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr_get_overridesLightProbeSystem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668805);
		NativeMethodInfoPtr_set_overridesLightProbeSystem_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668806);
		NativeMethodInfoPtr_set_supportsHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668810);
		NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668816);
		NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668817);
		NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668818);
		NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668819);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100668820);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239976, XrefRangeEnd = 1239989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FallbackMixedLightingModeByRef(System.IntPtr fallbackModePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fallbackModePtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239989, XrefRangeEnd = 1240010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mixedMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240010, XrefRangeEnd = 1240018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mixedMode);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSupportedPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1240035, RefRangeEnd = 1240039, XrefRangeStart = 1240018, XrefRangeEnd = 1240035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bakeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240039, XrefRangeEnd = 1240053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bakeType);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSupportedPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240053, XrefRangeEnd = 1240058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSupportedPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240058, XrefRangeEnd = 1240059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsLightmapperSupportedByRef(int lightmapper, System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lightmapper);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSupportedPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240059, XrefRangeEnd = 1240064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsUIOverlayRenderedBySRP(System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSupportedPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240064, XrefRangeEnd = 1240069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsAmbientProbeBakingSupported(System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSupportedPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240069, XrefRangeEnd = 1240074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IsDefaultReflectionProbeBakingSupported(System.IntPtr isSupportedPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSupportedPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240074, XrefRangeEnd = 1240079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OverridesLightProbeSystem(System.IntPtr overridesPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&overridesPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverridesLightProbeSystem_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240079, XrefRangeEnd = 1240080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FallbackLightmapperByRef(System.IntPtr lightmapperPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightmapperPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240085, RefRangeEnd = 1240087, XrefRangeStart = 1240080, XrefRangeEnd = 1240085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SupportedRenderingFeatures()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SupportedRenderingFeatures(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static MixedLightingMode FallbackMixedLightingMode()
	{
		Unsafe.SkipInit(out MixedLightingMode result);
		FallbackMixedLightingModeByRef(new System.IntPtr(&result));
		return result;
	}

	public unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
	{
		Unsafe.SkipInit(out bool result);
		IsLightmapsModeSupportedByRef(mode, new System.IntPtr(&result));
		return result;
	}

	public unsafe static bool IsLightmapperSupported(int lightmapper)
	{
		Unsafe.SkipInit(out bool result);
		IsLightmapperSupportedByRef(lightmapper, new System.IntPtr(&result));
		return result;
	}

	public unsafe static int FallbackLightmapper()
	{
		Unsafe.SkipInit(out int result);
		FallbackLightmapperByRef(new System.IntPtr(&result));
		return result;
	}
}
