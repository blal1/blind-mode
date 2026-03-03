using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Timeline;

[System.Serializable]
public class TimelineClip : Il2CppSystem.Object
{
	[OriginalName("Unity.Timeline.dll", "", "Versions")]
	public enum Versions
	{
		Initial,
		ClipInFromGlobalToLocal
	}

	public static class TimelineClipUpgrade : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0;

		static TimelineClipUpgrade()
		{
			Il2CppClassPointerStore<TimelineClipUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "TimelineClipUpgrade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClipUpgrade>.NativeClassPtr);
			NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipUpgrade>.NativeClassPtr, 100663561);
		}

		[CallerCount(0)]
		public unsafe static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeClipInFromGlobalToLocal_Public_Static_Void_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TimelineClipUpgrade(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.Timeline.dll", "", "ClipExtrapolation")]
	public enum ClipExtrapolation
	{
		None,
		Hold,
		Loop,
		PingPong,
		Continue
	}

	[OriginalName("Unity.Timeline.dll", "", "BlendCurveMode")]
	public enum BlendCurveMode
	{
		Auto,
		Manual
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LatestVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultClipCaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultClipDurationInSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_kTimeScaleMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_kTimeScaleMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultCurvesName;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMinDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxTimeValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Start;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClipIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Asset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentTrack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EaseInDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EaseOutDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendInDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendOutDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MixInCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MixOutCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendInCurveMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendOutCurveMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExposedParameterNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimationCurves;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Recordable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PostExtrapolationMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreExtrapolationMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PostExtrapolationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreExtrapolationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeScale_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_start_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_start_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_end_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipIn_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParentTrack_Public_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParentTrack_Internal_Internal_Void_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConformEaseValues_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0;

	public unsafe static int k_LatestVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LatestVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LatestVersion, (void*)(&value));
		}
	}

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

	public unsafe static ClipCaps kDefaultClipCaps
	{
		get
		{
			Unsafe.SkipInit(out ClipCaps result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultClipCaps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultClipCaps, (void*)(&value));
		}
	}

	public unsafe static float kDefaultClipDurationInSeconds
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultClipDurationInSeconds, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultClipDurationInSeconds, (void*)(&value));
		}
	}

	public unsafe static double kTimeScaleMin
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kTimeScaleMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kTimeScaleMin, (void*)(&value));
		}
	}

	public unsafe static double kTimeScaleMax
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kTimeScaleMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kTimeScaleMax, (void*)(&value));
		}
	}

	public unsafe static string kDefaultCurvesName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultCurvesName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultCurvesName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static double kMinDuration
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMinDuration, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMinDuration, (void*)(&value));
		}
	}

	public unsafe static double kMaxTimeValue
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxTimeValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxTimeValue, (void*)(&value));
		}
	}

	public unsafe double m_Start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Start);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Start)) = value;
		}
	}

	public unsafe double m_ClipIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClipIn);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClipIn)) = value;
		}
	}

	public unsafe Object m_Asset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe double m_Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Duration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Duration)) = value;
		}
	}

	public unsafe double m_TimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeScale);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeScale)) = value;
		}
	}

	public unsafe TrackAsset m_ParentTrack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentTrack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentTrack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe double m_EaseInDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EaseInDuration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EaseInDuration)) = value;
		}
	}

	public unsafe double m_EaseOutDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EaseOutDuration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EaseOutDuration)) = value;
		}
	}

	public unsafe double m_BlendInDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendInDuration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendInDuration)) = value;
		}
	}

	public unsafe double m_BlendOutDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendOutDuration);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendOutDuration)) = value;
		}
	}

	public unsafe AnimationCurve m_MixInCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixInCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixInCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AnimationCurve m_MixOutCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixOutCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixOutCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BlendCurveMode m_BlendInCurveMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendInCurveMode);
			return *(BlendCurveMode*)num;
		}
		set
		{
			*(BlendCurveMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendInCurveMode)) = value;
		}
	}

	public unsafe BlendCurveMode m_BlendOutCurveMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendOutCurveMode);
			return *(BlendCurveMode*)num;
		}
		set
		{
			*(BlendCurveMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendOutCurveMode)) = value;
		}
	}

	public unsafe List<string> m_ExposedParameterNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExposedParameterNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExposedParameterNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AnimationClip m_AnimationCurves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationCurves);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationCurves)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_Recordable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Recordable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Recordable)) = value;
		}
	}

	public unsafe ClipExtrapolation m_PostExtrapolationMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostExtrapolationMode);
			return *(ClipExtrapolation*)num;
		}
		set
		{
			*(ClipExtrapolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostExtrapolationMode)) = value;
		}
	}

	public unsafe ClipExtrapolation m_PreExtrapolationMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreExtrapolationMode);
			return *(ClipExtrapolation*)num;
		}
		set
		{
			*(ClipExtrapolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreExtrapolationMode)) = value;
		}
	}

	public unsafe double m_PostExtrapolationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostExtrapolationTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostExtrapolationTime)) = value;
		}
	}

	public unsafe double m_PreExtrapolationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreExtrapolationTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreExtrapolationTime)) = value;
		}
	}

	public unsafe string m_DisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool hasPreExtrapolation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasPostExtrapolation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double timeScale
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1136230, RefRangeEnd = 1136237, XrefRangeStart = 1136220, XrefRangeEnd = 1136230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeScale_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136237, XrefRangeEnd = 1136248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double start
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_start_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136266, RefRangeEnd = 1136268, XrefRangeStart = 1136248, XrefRangeEnd = 1136266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_start_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual double duration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1136281, RefRangeEnd = 1136294, XrefRangeStart = 1136268, XrefRangeEnd = 1136281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double end
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1136294, RefRangeEnd = 1136319, XrefRangeStart = 1136294, XrefRangeEnd = 1136294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_end_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double clipIn
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136319, XrefRangeEnd = 1136320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipIn_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136320, XrefRangeEnd = 1136332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string displayName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double clipAssetDuration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136332, XrefRangeEnd = 1136337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual AnimationClip curves
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual string UnityEngine_002ETimeline_002EICurvesOwner_002EdefaultCurvesName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136337, XrefRangeEnd = 1136341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe virtual bool hasCurves
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136341, XrefRangeEnd = 1136345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual Object asset
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual Object UnityEngine_002ETimeline_002EICurvesOwner_002EassetOwner
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	public unsafe virtual TrackAsset UnityEngine_002ETimeline_002EICurvesOwner_002EtargetTrack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
		}
	}

	public unsafe Object underlyingAsset
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TrackAsset parentTrack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136345, XrefRangeEnd = 1136346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double easeInDuration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136367, XrefRangeEnd = 1136374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136374, XrefRangeEnd = 1136385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double easeOutDuration
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1136392, RefRangeEnd = 1136397, XrefRangeStart = 1136385, XrefRangeEnd = 1136392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136397, XrefRangeEnd = 1136408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double eastOutTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136408, XrefRangeEnd = 1136409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double easeOutTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double blendInDuration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136409, XrefRangeEnd = 1136410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136416, RefRangeEnd = 1136418, XrefRangeStart = 1136410, XrefRangeEnd = 1136416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double blendOutDuration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136418, XrefRangeEnd = 1136419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136425, RefRangeEnd = 1136427, XrefRangeStart = 1136419, XrefRangeEnd = 1136425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe BlendCurveMode blendInCurveMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlendCurveMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe BlendCurveMode blendOutCurveMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlendCurveMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasBlendIn
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136427, XrefRangeEnd = 1136428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasBlendOut
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136428, XrefRangeEnd = 1136429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AnimationCurve mixInCurve
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136435, RefRangeEnd = 1136436, XrefRangeStart = 1136429, XrefRangeEnd = 1136435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float mixInPercentage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136436, XrefRangeEnd = 1136437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double mixInDuration
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1136439, RefRangeEnd = 1136441, XrefRangeStart = 1136437, XrefRangeEnd = 1136439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AnimationCurve mixOutCurve
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136441, XrefRangeEnd = 1136447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double mixOutTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136447, XrefRangeEnd = 1136451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double mixOutDuration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136451, XrefRangeEnd = 1136453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float mixOutPercentage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136453, XrefRangeEnd = 1136457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool recordable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<string> exposedParameters
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136457, XrefRangeEnd = 1136464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
	}

	public unsafe ClipCaps clipCaps
	{
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1136473, RefRangeEnd = 1136527, XrefRangeStart = 1136464, XrefRangeEnd = 1136473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClipCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AnimationClip animationClip
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136572, XrefRangeEnd = 1136581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}
	}

	public unsafe ClipExtrapolation postExtrapolationMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1136604, RefRangeEnd = 1136605, XrefRangeStart = 1136603, XrefRangeEnd = 1136604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136605, XrefRangeEnd = 1136606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ClipExtrapolation preExtrapolationMode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136606, XrefRangeEnd = 1136607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClipExtrapolation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136607, XrefRangeEnd = 1136608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double extrapolatedStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double extrapolatedDuration
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1136620, RefRangeEnd = 1136623, XrefRangeStart = 1136612, XrefRangeEnd = 1136620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TimelineClip()
	{
		Il2CppClassPointerStore<TimelineClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr);
		NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "k_LatestVersion");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_kDefaultClipCaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultClipCaps");
		NativeFieldInfoPtr_kDefaultClipDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultClipDurationInSeconds");
		NativeFieldInfoPtr_kTimeScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kTimeScaleMin");
		NativeFieldInfoPtr_kTimeScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kTimeScaleMax");
		NativeFieldInfoPtr_kDefaultCurvesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kDefaultCurvesName");
		NativeFieldInfoPtr_kMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kMinDuration");
		NativeFieldInfoPtr_kMaxTimeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "kMaxTimeValue");
		NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Start");
		NativeFieldInfoPtr_m_ClipIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ClipIn");
		NativeFieldInfoPtr_m_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Asset");
		NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Duration");
		NativeFieldInfoPtr_m_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_TimeScale");
		NativeFieldInfoPtr_m_ParentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ParentTrack");
		NativeFieldInfoPtr_m_EaseInDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_EaseInDuration");
		NativeFieldInfoPtr_m_EaseOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_EaseOutDuration");
		NativeFieldInfoPtr_m_BlendInDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendInDuration");
		NativeFieldInfoPtr_m_BlendOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendOutDuration");
		NativeFieldInfoPtr_m_MixInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_MixInCurve");
		NativeFieldInfoPtr_m_MixOutCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_MixOutCurve");
		NativeFieldInfoPtr_m_BlendInCurveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendInCurveMode");
		NativeFieldInfoPtr_m_BlendOutCurveMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_BlendOutCurveMode");
		NativeFieldInfoPtr_m_ExposedParameterNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_ExposedParameterNames");
		NativeFieldInfoPtr_m_AnimationCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_AnimationCurves");
		NativeFieldInfoPtr_m_Recordable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_Recordable");
		NativeFieldInfoPtr_m_PostExtrapolationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PostExtrapolationMode");
		NativeFieldInfoPtr_m_PreExtrapolationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PreExtrapolationMode");
		NativeFieldInfoPtr_m_PostExtrapolationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PostExtrapolationTime");
		NativeFieldInfoPtr_m_PreExtrapolationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_PreExtrapolationTime");
		NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, "m_DisplayName");
		NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_get_hasPreExtrapolation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_get_hasPostExtrapolation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_get_timeScale_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_set_timeScale_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_get_start_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_set_start_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_set_duration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_get_end_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_get_clipIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_set_clipIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_get_clipAssetDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_get_curves_Public_Virtual_Final_New_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_set_curves_Internal_set_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_defaultCurvesName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_get_hasCurves_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_get_asset_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_set_asset_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_assetOwner_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_UnityEngine_Timeline_ICurvesOwner_get_targetTrack_Private_Virtual_Final_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_get_underlyingAsset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_set_underlyingAsset_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_get_parentTrack_Public_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_set_parentTrack_Public_set_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_GetParentTrack_Public_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_SetParentTrack_Internal_Internal_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_get_easeInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_set_easeInDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_get_easeOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_set_easeOutDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_get_eastOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_get_easeOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_get_blendInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_set_blendInDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_get_blendOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_set_blendOutDuration_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_get_blendInCurveMode_Public_get_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_set_blendInCurveMode_Public_set_Void_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_get_blendOutCurveMode_Public_get_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_set_blendOutCurveMode_Public_set_Void_BlendCurveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_get_hasBlendIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_get_hasBlendOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_get_mixInCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_set_mixInCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_get_mixInPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_get_mixInDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_get_mixOutCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_set_mixOutCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_get_mixOutTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_get_mixOutDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_get_mixOutPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_get_recordable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_set_recordable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_get_exposedParameters_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_get_clipCaps_Public_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_Hash_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_get_animationClip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_get_postExtrapolationMode_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_set_postExtrapolationMode_Internal_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_get_preExtrapolationMode_Public_get_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_set_preExtrapolationMode_Internal_set_Void_ClipExtrapolation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_get_extrapolatedStart_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_get_extrapolatedDuration_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_ConformEaseValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr, 100663559);
	}

	[CallerCount(0)]
	public unsafe void UpgradeToLatestVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeToLatestVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136218, XrefRangeEnd = 1136220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimelineClip(TrackAsset parent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineClip>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe TrackAsset GetParentTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParentTrack_Public_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1136363, RefRangeEnd = 1136367, XrefRangeStart = 1136346, XrefRangeEnd = 1136363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParentTrack_Internal(TrackAsset newParentTrack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newParentTrack);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParentTrack_Internal_Internal_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136527, XrefRangeEnd = 1136530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Hash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hash_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1136538, RefRangeEnd = 1136541, XrefRangeStart = 1136530, XrefRangeEnd = 1136538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvaluateMixOut(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateMixOut_Public_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1136545, RefRangeEnd = 1136548, XrefRangeStart = 1136541, XrefRangeEnd = 1136545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvaluateMixIn(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateMixIn_Public_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136548, XrefRangeEnd = 1136549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve GetDefaultMixInCurve()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultMixInCurve_Private_Static_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136549, XrefRangeEnd = 1136550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve GetDefaultMixOutCurve()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultMixOutCurve_Private_Static_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1136563, RefRangeEnd = 1136566, XrefRangeStart = 1136550, XrefRangeEnd = 1136563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ToLocalTime(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLocalTime_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136566, XrefRangeEnd = 1136569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ToLocalTimeUnbound(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLocalTimeUnbound_Public_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136569, XrefRangeEnd = 1136572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double FromLocalTimeUnbound(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromLocalTimeUnbound_Internal_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1136596, RefRangeEnd = 1136603, XrefRangeStart = 1136581, XrefRangeEnd = 1136596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double SanitizeTimeValue(double value, double defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SanitizeTimeValue_Private_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetPostExtrapolationTime(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPostExtrapolationTime_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetPreExtrapolationTime(double time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreExtrapolationTime_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136608, XrefRangeEnd = 1136609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsExtrapolatedTime(double sequenceTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sequenceTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136609, XrefRangeEnd = 1136610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPreExtrapolatedTime(double sequenceTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sequenceTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPreExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1136611, RefRangeEnd = 1136612, XrefRangeStart = 1136610, XrefRangeEnd = 1136611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPostExtrapolatedTime(double sequenceTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sequenceTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPostExtrapolatedTime_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1136627, RefRangeEnd = 1136629, XrefRangeStart = 1136623, XrefRangeEnd = 1136627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(ClipExtrapolation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtrapolatedTime_Private_Static_Double_Double_ClipExtrapolation_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136629, XrefRangeEnd = 1136640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void CreateCurves(string curvesClipName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(curvesClipName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCurves_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136640, XrefRangeEnd = 1136664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136664, XrefRangeEnd = 1136676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConformEaseValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConformEaseValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136676, XrefRangeEnd = 1136685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CalculateEasingRatio(double easeIn, double easeOut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&easeIn);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeOut;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateEasingRatio_Private_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDirty(double oldValue, double newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&oldValue);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDirty_Private_Void_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimelineClip(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
