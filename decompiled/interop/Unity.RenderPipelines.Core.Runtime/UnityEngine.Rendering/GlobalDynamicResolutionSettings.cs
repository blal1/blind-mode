using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

[System.Serializable]
public sealed class GlobalDynamicResolutionSettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMipBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedUpscalersByPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLSSPerfQualitySetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLSSInjectionPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_TAAUInjectionPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_STPInjectionPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultInjectionPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLSSUseOptimalSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLSSSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_FSR2EnableSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_FSR2Sharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_FSR2UseOptimalSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_FSR2QualitySetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_FSR2InjectionPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_fsrOverrideSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_fsrSharpness;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_minPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynResType;

	private static readonly System.IntPtr NativeFieldInfoPtr_upsampleFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowResTransparencyMinimumThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_rayTracingHalfResThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowResSSGIMinimumThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDLSS;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0;

	public unsafe bool enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = value;
		}
	}

	public unsafe bool useMipBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMipBias);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMipBias)) = value;
		}
	}

	public unsafe List<AdvancedUpscalers> advancedUpscalersByPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedUpscalersByPriority);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AdvancedUpscalers>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedUpscalersByPriority)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint DLSSPerfQualitySetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSPerfQualitySetting);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSPerfQualitySetting)) = value;
		}
	}

	public unsafe DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSInjectionPoint);
			return *(DynamicResolutionHandler.UpsamplerScheduleType*)num;
		}
		set
		{
			*(DynamicResolutionHandler.UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSInjectionPoint)) = value;
		}
	}

	public unsafe DynamicResolutionHandler.UpsamplerScheduleType TAAUInjectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TAAUInjectionPoint);
			return *(DynamicResolutionHandler.UpsamplerScheduleType*)num;
		}
		set
		{
			*(DynamicResolutionHandler.UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TAAUInjectionPoint)) = value;
		}
	}

	public unsafe DynamicResolutionHandler.UpsamplerScheduleType STPInjectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_STPInjectionPoint);
			return *(DynamicResolutionHandler.UpsamplerScheduleType*)num;
		}
		set
		{
			*(DynamicResolutionHandler.UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_STPInjectionPoint)) = value;
		}
	}

	public unsafe DynamicResolutionHandler.UpsamplerScheduleType defaultInjectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultInjectionPoint);
			return *(DynamicResolutionHandler.UpsamplerScheduleType*)num;
		}
		set
		{
			*(DynamicResolutionHandler.UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultInjectionPoint)) = value;
		}
	}

	public unsafe bool DLSSUseOptimalSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSUseOptimalSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSUseOptimalSettings)) = value;
		}
	}

	public unsafe float DLSSSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSSharpness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLSSSharpness)) = value;
		}
	}

	public unsafe bool FSR2EnableSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2EnableSharpness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2EnableSharpness)) = value;
		}
	}

	public unsafe float FSR2Sharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2Sharpness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2Sharpness)) = value;
		}
	}

	public unsafe bool FSR2UseOptimalSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2UseOptimalSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2UseOptimalSettings)) = value;
		}
	}

	public unsafe uint FSR2QualitySetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2QualitySetting);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2QualitySetting)) = value;
		}
	}

	public unsafe DynamicResolutionHandler.UpsamplerScheduleType FSR2InjectionPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2InjectionPoint);
			return *(DynamicResolutionHandler.UpsamplerScheduleType*)num;
		}
		set
		{
			*(DynamicResolutionHandler.UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FSR2InjectionPoint)) = value;
		}
	}

	public unsafe bool fsrOverrideSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrOverrideSharpness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrOverrideSharpness)) = value;
		}
	}

	public unsafe float fsrSharpness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrSharpness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsrSharpness)) = value;
		}
	}

	public unsafe float maxPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPercentage)) = value;
		}
	}

	public unsafe float minPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPercentage)) = value;
		}
	}

	public unsafe DynamicResolutionType dynResType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynResType);
			return *(DynamicResolutionType*)num;
		}
		set
		{
			*(DynamicResolutionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynResType)) = value;
		}
	}

	public unsafe DynamicResUpscaleFilter upsampleFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upsampleFilter);
			return *(DynamicResUpscaleFilter*)num;
		}
		set
		{
			*(DynamicResUpscaleFilter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upsampleFilter)) = value;
		}
	}

	public unsafe bool forceResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceResolution);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceResolution)) = value;
		}
	}

	public unsafe float forcedPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedPercentage)) = value;
		}
	}

	public unsafe float lowResTransparencyMinimumThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResTransparencyMinimumThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResTransparencyMinimumThreshold)) = value;
		}
	}

	public unsafe float rayTracingHalfResThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayTracingHalfResThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayTracingHalfResThreshold)) = value;
		}
	}

	public unsafe float lowResSSGIMinimumThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResSSGIMinimumThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResSSGIMinimumThreshold)) = value;
		}
	}

	public unsafe float lowResVolumetricCloudsMinimumThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold)) = value;
		}
	}

	public unsafe bool enableDLSS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDLSS);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDLSS)) = value;
		}
	}

	static GlobalDynamicResolutionSettings()
	{
		Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GlobalDynamicResolutionSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr);
		NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "enabled");
		NativeFieldInfoPtr_useMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "useMipBias");
		NativeFieldInfoPtr_advancedUpscalersByPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "advancedUpscalersByPriority");
		NativeFieldInfoPtr_DLSSPerfQualitySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSPerfQualitySetting");
		NativeFieldInfoPtr_DLSSInjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSInjectionPoint");
		NativeFieldInfoPtr_TAAUInjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "TAAUInjectionPoint");
		NativeFieldInfoPtr_STPInjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "STPInjectionPoint");
		NativeFieldInfoPtr_defaultInjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "defaultInjectionPoint");
		NativeFieldInfoPtr_DLSSUseOptimalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSUseOptimalSettings");
		NativeFieldInfoPtr_DLSSSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "DLSSSharpness");
		NativeFieldInfoPtr_FSR2EnableSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "FSR2EnableSharpness");
		NativeFieldInfoPtr_FSR2Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "FSR2Sharpness");
		NativeFieldInfoPtr_FSR2UseOptimalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "FSR2UseOptimalSettings");
		NativeFieldInfoPtr_FSR2QualitySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "FSR2QualitySetting");
		NativeFieldInfoPtr_FSR2InjectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "FSR2InjectionPoint");
		NativeFieldInfoPtr_fsrOverrideSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "fsrOverrideSharpness");
		NativeFieldInfoPtr_fsrSharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "fsrSharpness");
		NativeFieldInfoPtr_maxPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "maxPercentage");
		NativeFieldInfoPtr_minPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "minPercentage");
		NativeFieldInfoPtr_dynResType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "dynResType");
		NativeFieldInfoPtr_upsampleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "upsampleFilter");
		NativeFieldInfoPtr_forceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "forceResolution");
		NativeFieldInfoPtr_forcedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "forcedPercentage");
		NativeFieldInfoPtr_lowResTransparencyMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResTransparencyMinimumThreshold");
		NativeFieldInfoPtr_rayTracingHalfResThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "rayTracingHalfResThreshold");
		NativeFieldInfoPtr_lowResSSGIMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResSSGIMinimumThreshold");
		NativeFieldInfoPtr_lowResVolumetricCloudsMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "lowResVolumetricCloudsMinimumThreshold");
		NativeFieldInfoPtr_enableDLSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, "enableDLSS");
		NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, 100664456);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029519, XrefRangeEnd = 1029530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GlobalDynamicResolutionSettings NewDefault()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewDefault_Public_Static_GlobalDynamicResolutionSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GlobalDynamicResolutionSettings(pointer);
	}

	public GlobalDynamicResolutionSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GlobalDynamicResolutionSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr))
	{
	}
}
