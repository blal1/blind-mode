using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class DynamicResolutionHandler : Il2CppSystem.Object
{
	public sealed class ScalerContainer : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_method;

		public unsafe DynamicResScalePolicyType type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(DynamicResScalePolicyType*)num;
			}
			set
			{
				*(DynamicResScalePolicyType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = value;
			}
		}

		public unsafe PerformDynamicRes method
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PerformDynamicRes>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ScalerContainer()
		{
			Il2CppClassPointerStore<ScalerContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "ScalerContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalerContainer>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalerContainer>.NativeClassPtr, "type");
			NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalerContainer>.NativeClassPtr, "method");
		}

		public ScalerContainer(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ScalerContainer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScalerContainer>.NativeClassPtr))
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "UpsamplerScheduleType")]
	public enum UpsamplerScheduleType
	{
		BeforePost,
		AfterDepthOfField,
		AfterPost
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseMipBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MinScreenFraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxScreenFraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForcingRes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentCameraRequest;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevFraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceSoftwareFallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevHWScaleWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevHWScaleHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastScaledSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ActiveScalerSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ScalerContainers;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedOriginalSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__filter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraUpscaleFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr__finalViewport_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraDictionaryMaxcCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OwnerCameraWeakRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ActiveCameraId;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ActiveInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ActiveInstanceDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalHwFraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalHwUpresActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpsamplerSchedule;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_forcingResolution_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentScale_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0;

	public unsafe bool m_Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled)) = value;
		}
	}

	public unsafe bool m_UseMipBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseMipBias);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseMipBias)) = value;
		}
	}

	public unsafe float m_MinScreenFraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinScreenFraction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinScreenFraction)) = value;
		}
	}

	public unsafe float m_MaxScreenFraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxScreenFraction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxScreenFraction)) = value;
		}
	}

	public unsafe float m_CurrentFraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFraction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFraction)) = value;
		}
	}

	public unsafe bool m_ForcingRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcingRes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcingRes)) = value;
		}
	}

	public unsafe bool m_CurrentCameraRequest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentCameraRequest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentCameraRequest)) = value;
		}
	}

	public unsafe float m_PrevFraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevFraction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevFraction)) = value;
		}
	}

	public unsafe bool m_ForceSoftwareFallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceSoftwareFallback);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceSoftwareFallback)) = value;
		}
	}

	public unsafe bool m_RunUpscalerFilterOnFullResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution)) = value;
		}
	}

	public unsafe float m_PrevHWScaleWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevHWScaleWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevHWScaleWidth)) = value;
		}
	}

	public unsafe float m_PrevHWScaleHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevHWScaleHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevHWScaleHeight)) = value;
		}
	}

	public unsafe Vector2Int m_LastScaledSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastScaledSize);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastScaledSize)) = value;
		}
	}

	public unsafe static DynamicResScalerSlot s_ActiveScalerSlot
	{
		get
		{
			Unsafe.SkipInit(out DynamicResScalerSlot result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ActiveScalerSlot, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ActiveScalerSlot, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<ScalerContainer> s_ScalerContainers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ScalerContainers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScalerContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ScalerContainers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector2Int cachedOriginalSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedOriginalSize);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedOriginalSize)) = value;
		}
	}

	public unsafe DynamicResUpscaleFilter _filter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filter_k__BackingField);
			return *(DynamicResUpscaleFilter*)num;
		}
		set
		{
			*(DynamicResUpscaleFilter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filter_k__BackingField)) = value;
		}
	}

	public unsafe static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraUpscaleFilters, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, DynamicResUpscaleFilter>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraUpscaleFilters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector2Int _finalViewport_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__finalViewport_k__BackingField);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__finalViewport_k__BackingField)) = value;
		}
	}

	public unsafe DynamicResolutionType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(DynamicResolutionType*)num;
		}
		set
		{
			*(DynamicResolutionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = value;
		}
	}

	public unsafe GlobalDynamicResolutionSettings m_CachedSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedSettings);
			return new GlobalDynamicResolutionSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalDynamicResolutionSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static int CameraDictionaryMaxcCapacity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CameraDictionaryMaxcCapacity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CameraDictionaryMaxcCapacity, (void*)(&value));
		}
	}

	public unsafe Il2CppSystem.WeakReference m_OwnerCameraWeakRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OwnerCameraWeakRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OwnerCameraWeakRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, DynamicResolutionHandler> s_CameraInstances
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraInstances, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, DynamicResolutionHandler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraInstances, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DynamicResolutionHandler s_DefaultInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_ActiveCameraId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ActiveCameraId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ActiveCameraId, (void*)(&value));
		}
	}

	public unsafe static DynamicResolutionHandler s_ActiveInstance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ActiveInstance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ActiveInstance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool s_ActiveInstanceDirty
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ActiveInstanceDirty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ActiveInstanceDirty, (void*)(&value));
		}
	}

	public unsafe static float s_GlobalHwFraction
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalHwFraction, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalHwFraction, (void*)(&value));
		}
	}

	public unsafe static bool s_GlobalHwUpresActive
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalHwUpresActive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalHwUpresActive, (void*)(&value));
		}
	}

	public unsafe UpsamplerScheduleType m_UpsamplerSchedule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpsamplerSchedule);
			return *(UpsamplerScheduleType*)num;
		}
		set
		{
			*(UpsamplerScheduleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpsamplerSchedule)) = value;
		}
	}

	public unsafe DynamicResUpscaleFilter filter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DynamicResUpscaleFilter*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2Int finalViewport
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool runUpscalerFilterOnFullResolution
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool forcingResolution
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forcingResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UpsamplerScheduleType upsamplerSchedule
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UpsamplerScheduleType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static DynamicResolutionHandler instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029289, XrefRangeEnd = 1029293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
		}
	}

	static DynamicResolutionHandler()
	{
		Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DynamicResolutionHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr);
		NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_Enabled");
		NativeFieldInfoPtr_m_UseMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_UseMipBias");
		NativeFieldInfoPtr_m_MinScreenFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_MinScreenFraction");
		NativeFieldInfoPtr_m_MaxScreenFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_MaxScreenFraction");
		NativeFieldInfoPtr_m_CurrentFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CurrentFraction");
		NativeFieldInfoPtr_m_ForcingRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_ForcingRes");
		NativeFieldInfoPtr_m_CurrentCameraRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CurrentCameraRequest");
		NativeFieldInfoPtr_m_PrevFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevFraction");
		NativeFieldInfoPtr_m_ForceSoftwareFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_ForceSoftwareFallback");
		NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_RunUpscalerFilterOnFullResolution");
		NativeFieldInfoPtr_m_PrevHWScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevHWScaleWidth");
		NativeFieldInfoPtr_m_PrevHWScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevHWScaleHeight");
		NativeFieldInfoPtr_m_LastScaledSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_LastScaledSize");
		NativeFieldInfoPtr_s_ActiveScalerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveScalerSlot");
		NativeFieldInfoPtr_s_ScalerContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ScalerContainers");
		NativeFieldInfoPtr_cachedOriginalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "cachedOriginalSize");
		NativeFieldInfoPtr__filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "<filter>k__BackingField");
		NativeFieldInfoPtr_s_CameraUpscaleFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_CameraUpscaleFilters");
		NativeFieldInfoPtr__finalViewport_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "<finalViewport>k__BackingField");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "type");
		NativeFieldInfoPtr_m_CachedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CachedSettings");
		NativeFieldInfoPtr_CameraDictionaryMaxcCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "CameraDictionaryMaxcCapacity");
		NativeFieldInfoPtr_m_OwnerCameraWeakRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_OwnerCameraWeakRef");
		NativeFieldInfoPtr_s_CameraInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_CameraInstances");
		NativeFieldInfoPtr_s_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_DefaultInstance");
		NativeFieldInfoPtr_s_ActiveCameraId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveCameraId");
		NativeFieldInfoPtr_s_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveInstance");
		NativeFieldInfoPtr_s_ActiveInstanceDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveInstanceDirty");
		NativeFieldInfoPtr_s_GlobalHwFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_GlobalHwFraction");
		NativeFieldInfoPtr_s_GlobalHwUpresActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_GlobalHwUpresActive");
		NativeFieldInfoPtr_m_UpsamplerSchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_UpsamplerSchedule");
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_get_forcingResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664427);
		NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664428);
		NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664429);
		NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664430);
		NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_GetCurrentScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664448);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1029221, RefRangeEnd = 1029223, XrefRangeStart = 1029214, XrefRangeEnd = 1029221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FlushScalableBufferManagerState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029288, RefRangeEnd = 1029289, XrefRangeStart = 1029223, XrefRangeEnd = 1029288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029306, RefRangeEnd = 1029307, XrefRangeStart = 1029293, XrefRangeEnd = 1029306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicResolutionHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float DefaultDynamicResMethod()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029326, RefRangeEnd = 1029327, XrefRangeStart = 1029307, XrefRangeEnd = 1029326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessSettings(GlobalDynamicResolutionSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029327, XrefRangeEnd = 1029329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetResolvedScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029329, XrefRangeEnd = 1029334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&inputResolution);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputResolution;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceApply;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029334, XrefRangeEnd = 1029340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaler);
		*(DynamicResScalePolicyType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scalerType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029340, XrefRangeEnd = 1029346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaler);
		*(DynamicResScalePolicyType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scalerType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029346, XrefRangeEnd = 1029350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029350, XrefRangeEnd = 1029358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearSelectedCamera()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029358, XrefRangeEnd = 1029378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(DynamicResUpscaleFilter**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetCurrentCameraRequest(bool cameraRequest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraRequest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029378, XrefRangeEnd = 1029408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateAndUseCamera(Camera camera, Il2CppSystem.Nullable<GlobalDynamicResolutionSettings> settings = null, Il2CppSystem.Action OnResolutionChange = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnResolutionChange);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029434, RefRangeEnd = 1029435, XrefRangeStart = 1029408, XrefRangeEnd = 1029434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(GlobalDynamicResolutionSettings settings, Il2CppSystem.Action OnResolutionChange = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OnResolutionChange);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool SoftwareDynamicResIsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1029435, RefRangeEnd = 1029437, XrefRangeStart = 1029435, XrefRangeEnd = 1029435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HardwareDynamicResIsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029437, RefRangeEnd = 1029438, XrefRangeStart = 1029437, XrefRangeEnd = 1029437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequestsHardwareDynamicResolution()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool DynamicResolutionEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 883425, RefRangeEnd = 883431, XrefRangeStart = 883425, XrefRangeEnd = 883431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceSoftwareFallback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029438, XrefRangeEnd = 1029453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int GetScaledSize(Vector2Int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029453, XrefRangeEnd = 1029469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int ApplyScalesOnSize(Vector2Int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029482, RefRangeEnd = 1029483, XrefRangeStart = 1029469, XrefRangeEnd = 1029482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&size);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scales;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetCurrentScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector2Int GetLastScaledSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029483, XrefRangeEnd = 1029487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLowResMultiplier(float targetLowRes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetLowRes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029487, XrefRangeEnd = 1029491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLowResMultiplier(float targetLowRes, float minimumThreshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetLowRes);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minimumThreshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DynamicResolutionHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
