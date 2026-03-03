using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings<UniversalRenderPipelineGlobalSettings, UniversalRenderPipeline>
{
	private static readonly IntPtr NativeFieldInfoPtr_m_ShaderStrippingSetting;

	private static readonly IntPtr NativeFieldInfoPtr_m_URPShaderStrippingSetting;

	private static readonly IntPtr NativeFieldInfoPtr_m_ShaderVariantLogLevel;

	private static readonly IntPtr NativeFieldInfoPtr_m_ExportShaderVariants;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripDebugVariants;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripUnusedVariants;

	private static readonly IntPtr NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants;

	private static readonly IntPtr NativeFieldInfoPtr_supportRuntimeDebugDisplay;

	private static readonly IntPtr NativeFieldInfoPtr_m_EnableRenderGraph;

	private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

	private static readonly IntPtr NativeFieldInfoPtr_k_LastVersion;

	private static readonly IntPtr NativeFieldInfoPtr_m_AssetVersion;

	private static readonly IntPtr NativeFieldInfoPtr_defaultAssetName;

	private static readonly IntPtr NativeFieldInfoPtr_m_ObsoleteDefaultVolumeProfile;

	private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayerNames;

	private static readonly IntPtr NativeFieldInfoPtr_m_ValidRenderingLayers;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName0;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName1;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName2;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName3;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName4;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName5;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName6;

	private static readonly IntPtr NativeFieldInfoPtr_lightLayerName7;

	private static readonly IntPtr NativeFieldInfoPtr_apvScenesData;

	private static readonly IntPtr NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_settingsList_Protected_Virtual_get_List_1_IRenderPipelineGraphicsSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateDefaultVolumeProfile_Internal_Static_VolumeProfile_VolumeProfile_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateAPVSceneData_Internal_ProbeVolumeSceneData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShaderStrippingSetting m_ShaderStrippingSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderStrippingSetting);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ShaderStrippingSetting>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderStrippingSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe URPShaderStrippingSetting m_URPShaderStrippingSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_URPShaderStrippingSetting);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<URPShaderStrippingSetting>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_URPShaderStrippingSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariantLogLevel);
			return *(UnityEngine.Rendering.ShaderVariantLogLevel*)num;
		}
		set
		{
			*(UnityEngine.Rendering.ShaderVariantLogLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariantLogLevel)) = value;
		}
	}

	public unsafe bool m_ExportShaderVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExportShaderVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExportShaderVariants)) = value;
		}
	}

	public unsafe bool m_StripDebugVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripDebugVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripDebugVariants)) = value;
		}
	}

	public unsafe bool m_StripUnusedPostProcessingVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants)) = value;
		}
	}

	public unsafe bool m_StripUnusedVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripUnusedVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripUnusedVariants)) = value;
		}
	}

	public unsafe bool m_StripScreenCoordOverrideVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants)) = value;
		}
	}

	public unsafe bool supportRuntimeDebugDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportRuntimeDebugDisplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportRuntimeDebugDisplay)) = value;
		}
	}

	public unsafe bool m_EnableRenderGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableRenderGraph);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableRenderGraph)) = value;
		}
	}

	public unsafe RenderPipelineGraphicsSettingsContainer m_Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineGraphicsSettingsContainer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_LastVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LastVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LastVersion, (void*)(&value));
		}
	}

	public unsafe int m_AssetVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AssetVersion)) = value;
		}
	}

	public unsafe static string defaultAssetName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultAssetName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultAssetName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe VolumeProfile m_ObsoleteDefaultVolumeProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObsoleteDefaultVolumeProfile);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObsoleteDefaultVolumeProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_RenderingLayerNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerNames);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint m_ValidRenderingLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidRenderingLayers);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidRenderingLayers)) = value;
		}
	}

	public unsafe string lightLayerName0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName0);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName0)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName1);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName1)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName2);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName2)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName3);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName3)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName4);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName4)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName5
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName5);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName5)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName6
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName6);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName6)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string lightLayerName7
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName7);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightLayerName7)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ProbeVolumeSceneData apvScenesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvScenesData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvScenesData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool stripUnusedLODCrossFadeVariants
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override List<IRenderPipelineGraphicsSettings> settingsList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086344, XrefRangeEnd = 1086346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_settingsList_Protected_Virtual_get_List_1_IRenderPipelineGraphicsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray prefixedLightLayerNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086350, XrefRangeEnd = 1086353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray lightLayerNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086353, XrefRangeEnd = 1086356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	static UniversalRenderPipelineGlobalSettings()
	{
		Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineGlobalSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_ShaderStrippingSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ShaderStrippingSetting");
		NativeFieldInfoPtr_m_URPShaderStrippingSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_URPShaderStrippingSetting");
		NativeFieldInfoPtr_m_ShaderVariantLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ShaderVariantLogLevel");
		NativeFieldInfoPtr_m_ExportShaderVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ExportShaderVariants");
		NativeFieldInfoPtr_m_StripDebugVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripDebugVariants");
		NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripUnusedPostProcessingVariants");
		NativeFieldInfoPtr_m_StripUnusedVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripUnusedVariants");
		NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripScreenCoordOverrideVariants");
		NativeFieldInfoPtr_supportRuntimeDebugDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "supportRuntimeDebugDisplay");
		NativeFieldInfoPtr_m_EnableRenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_EnableRenderGraph");
		NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_Settings");
		NativeFieldInfoPtr_k_LastVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "k_LastVersion");
		NativeFieldInfoPtr_m_AssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_AssetVersion");
		NativeFieldInfoPtr_defaultAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "defaultAssetName");
		NativeFieldInfoPtr_m_ObsoleteDefaultVolumeProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ObsoleteDefaultVolumeProfile");
		NativeFieldInfoPtr_m_RenderingLayerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_RenderingLayerNames");
		NativeFieldInfoPtr_m_ValidRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ValidRenderingLayers");
		NativeFieldInfoPtr_lightLayerName0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName0");
		NativeFieldInfoPtr_lightLayerName1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName1");
		NativeFieldInfoPtr_lightLayerName2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName2");
		NativeFieldInfoPtr_lightLayerName3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName3");
		NativeFieldInfoPtr_lightLayerName4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName4");
		NativeFieldInfoPtr_lightLayerName5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName5");
		NativeFieldInfoPtr_lightLayerName6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName6");
		NativeFieldInfoPtr_lightLayerName7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName7");
		NativeFieldInfoPtr_apvScenesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "apvScenesData");
		NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664470);
		NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664471);
		NativeMethodInfoPtr_get_settingsList_Protected_Virtual_get_List_1_IRenderPipelineGraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664472);
		NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664473);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664474);
		NativeMethodInfoPtr_GetOrCreateDefaultVolumeProfile_Internal_Static_VolumeProfile_VolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664475);
		NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_GetOrCreateAPVSceneData_Internal_ProbeVolumeSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100664480);
	}

	[CallerCount(0)]
	public unsafe bool IsAtLastVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAtLastVersion_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086346, XrefRangeEnd = 1086350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VolumeProfile GetOrCreateDefaultVolumeProfile(VolumeProfile defaultVolumeProfile)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultVolumeProfile);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateDefaultVolumeProfile_Internal_Static_VolumeProfile_VolumeProfile_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<VolumeProfile>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086356, XrefRangeEnd = 1086365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetRenderingLayerNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086371, RefRangeEnd = 1086372, XrefRangeStart = 1086365, XrefRangeEnd = 1086371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolumeSceneData GetOrCreateAPVSceneData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateAPVSceneData_Internal_ProbeVolumeSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086372, XrefRangeEnd = 1086402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRenderPipelineGlobalSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRenderPipelineGlobalSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
