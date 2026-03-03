using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Audio;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioSource : AudioBehaviour
{
	private delegate void PlayOneShotHelper_InjectedDelegate(System.IntPtr source, System.IntPtr clip, float volumeScale);

	private delegate System.IntPtr GetCustomCurveHelper_InjectedDelegate(System.IntPtr source, AudioSourceCurveType type);

	private delegate void GetOutputDataHelper_InjectedDelegate(System.IntPtr source, [Out] System.IntPtr samples, int channel);

	private delegate System.IntPtr get_outputAudioMixerGroup_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetScheduledStartTime_InjectedDelegate(System.IntPtr _unity_self, double time);

	private delegate void SetScheduledEndTime_InjectedDelegate(System.IntPtr _unity_self, double time);

	private delegate void UnPause_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SkipToNextElementIfHasContainer_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isContainerPlaying_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_containerActivePlayables_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isVirtual_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_ignoreListenerVolume_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_ignoreListenerVolume_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_playOnAwake_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_ignoreListenerPause_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_ignoreListenerPause_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate AudioVelocityUpdateMode get_velocityUpdateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_velocityUpdateMode_InjectedDelegate(System.IntPtr _unity_self, AudioVelocityUpdateMode value);

	private delegate float get_spatialBlend_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_spatialize_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_spatialize_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_spatializePostEffects_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_spatializePostEffects_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_reverbZoneMix_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_bypassEffects_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bypassEffects_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_bypassListenerEffects_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bypassListenerEffects_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_bypassReverbZones_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bypassReverbZones_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_dopplerLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_spread_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_priority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_priority_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_mute_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mute_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_minDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_maxDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate AudioRolloffMode get_rolloffMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool SetSpatializerFloat_InjectedDelegate(System.IntPtr _unity_self, int index, float value);

	private delegate bool GetSpatializerFloat_InjectedDelegate(System.IntPtr _unity_self, int index, [Out] System.IntPtr value);

	private delegate bool GetAmbisonicDecoderFloat_InjectedDelegate(System.IntPtr _unity_self, int index, [Out] System.IntPtr value);

	private delegate bool SetAmbisonicDecoderFloat_InjectedDelegate(System.IntPtr _unity_self, int index, float value);

	private delegate float GetAudioRandomContainerRuntimeMeterValue_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Private_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volume_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resource_Public_get_AudioResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_resource_Public_set_Void_AudioResource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_panStereo_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPitch_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPitch_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayHelper_Injected_Private_Static_Void_IntPtr_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomCurveHelper_Injected_Private_Static_Void_IntPtr_AudioSourceCurveType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_Int32_FFTWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_volume_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_volume_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeSamples_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeSamples_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resource_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_resource_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_outputAudioMixerGroup_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_panStereo_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_panStereo_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spatialBlend_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reverbZoneMix_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dopplerLevel_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spread_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_minDistance_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxDistance_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rolloffMode_Injected_Private_Static_Void_IntPtr_AudioRolloffMode_0;

	private static readonly PlayOneShotHelper_InjectedDelegate PlayOneShotHelper_InjectedDelegateField;

	private static readonly GetCustomCurveHelper_InjectedDelegate GetCustomCurveHelper_InjectedDelegateField;

	private static readonly GetOutputDataHelper_InjectedDelegate GetOutputDataHelper_InjectedDelegateField;

	private static readonly get_outputAudioMixerGroup_InjectedDelegate get_outputAudioMixerGroup_InjectedDelegateField;

	private static readonly SetScheduledStartTime_InjectedDelegate SetScheduledStartTime_InjectedDelegateField;

	private static readonly SetScheduledEndTime_InjectedDelegate SetScheduledEndTime_InjectedDelegateField;

	private static readonly UnPause_InjectedDelegate UnPause_InjectedDelegateField;

	private static readonly SkipToNextElementIfHasContainer_InjectedDelegate SkipToNextElementIfHasContainer_InjectedDelegateField;

	private static readonly get_isContainerPlaying_InjectedDelegate get_isContainerPlaying_InjectedDelegateField;

	private static readonly get_containerActivePlayables_InjectedDelegate get_containerActivePlayables_InjectedDelegateField;

	private static readonly get_isVirtual_InjectedDelegate get_isVirtual_InjectedDelegateField;

	private static readonly get_ignoreListenerVolume_InjectedDelegate get_ignoreListenerVolume_InjectedDelegateField;

	private static readonly set_ignoreListenerVolume_InjectedDelegate set_ignoreListenerVolume_InjectedDelegateField;

	private static readonly get_playOnAwake_InjectedDelegate get_playOnAwake_InjectedDelegateField;

	private static readonly get_ignoreListenerPause_InjectedDelegate get_ignoreListenerPause_InjectedDelegateField;

	private static readonly set_ignoreListenerPause_InjectedDelegate set_ignoreListenerPause_InjectedDelegateField;

	private static readonly get_velocityUpdateMode_InjectedDelegate get_velocityUpdateMode_InjectedDelegateField;

	private static readonly set_velocityUpdateMode_InjectedDelegate set_velocityUpdateMode_InjectedDelegateField;

	private static readonly get_spatialBlend_InjectedDelegate get_spatialBlend_InjectedDelegateField;

	private static readonly get_spatialize_InjectedDelegate get_spatialize_InjectedDelegateField;

	private static readonly set_spatialize_InjectedDelegate set_spatialize_InjectedDelegateField;

	private static readonly get_spatializePostEffects_InjectedDelegate get_spatializePostEffects_InjectedDelegateField;

	private static readonly set_spatializePostEffects_InjectedDelegate set_spatializePostEffects_InjectedDelegateField;

	private static readonly get_reverbZoneMix_InjectedDelegate get_reverbZoneMix_InjectedDelegateField;

	private static readonly get_bypassEffects_InjectedDelegate get_bypassEffects_InjectedDelegateField;

	private static readonly set_bypassEffects_InjectedDelegate set_bypassEffects_InjectedDelegateField;

	private static readonly get_bypassListenerEffects_InjectedDelegate get_bypassListenerEffects_InjectedDelegateField;

	private static readonly set_bypassListenerEffects_InjectedDelegate set_bypassListenerEffects_InjectedDelegateField;

	private static readonly get_bypassReverbZones_InjectedDelegate get_bypassReverbZones_InjectedDelegateField;

	private static readonly set_bypassReverbZones_InjectedDelegate set_bypassReverbZones_InjectedDelegateField;

	private static readonly get_dopplerLevel_InjectedDelegate get_dopplerLevel_InjectedDelegateField;

	private static readonly get_spread_InjectedDelegate get_spread_InjectedDelegateField;

	private static readonly get_priority_InjectedDelegate get_priority_InjectedDelegateField;

	private static readonly set_priority_InjectedDelegate set_priority_InjectedDelegateField;

	private static readonly get_mute_InjectedDelegate get_mute_InjectedDelegateField;

	private static readonly set_mute_InjectedDelegate set_mute_InjectedDelegateField;

	private static readonly get_minDistance_InjectedDelegate get_minDistance_InjectedDelegateField;

	private static readonly get_maxDistance_InjectedDelegate get_maxDistance_InjectedDelegateField;

	private static readonly get_rolloffMode_InjectedDelegate get_rolloffMode_InjectedDelegateField;

	private static readonly SetSpatializerFloat_InjectedDelegate SetSpatializerFloat_InjectedDelegateField;

	private static readonly GetSpatializerFloat_InjectedDelegate GetSpatializerFloat_InjectedDelegateField;

	private static readonly GetAmbisonicDecoderFloat_InjectedDelegate GetAmbisonicDecoderFloat_InjectedDelegateField;

	private static readonly SetAmbisonicDecoderFloat_InjectedDelegate SetAmbisonicDecoderFloat_InjectedDelegateField;

	private static readonly GetAudioRandomContainerRuntimeMeterValue_InjectedDelegate GetAudioRandomContainerRuntimeMeterValue_InjectedDelegateField;

	public unsafe float volume
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1162978, RefRangeEnd = 1162982, XrefRangeStart = 1162973, XrefRangeEnd = 1162978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1162987, RefRangeEnd = 1163000, XrefRangeStart = 1162982, XrefRangeEnd = 1162987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float pitch
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162911, RefRangeEnd = 1162912, XrefRangeStart = 1162911, XrefRangeEnd = 1162912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1162921, RefRangeEnd = 1162926, XrefRangeStart = 1162921, XrefRangeEnd = 1162926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float time
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163000, XrefRangeEnd = 1163005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163010, RefRangeEnd = 1163012, XrefRangeStart = 1163005, XrefRangeEnd = 1163010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int timeSamples
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1163017, RefRangeEnd = 1163026, XrefRangeStart = 1163012, XrefRangeEnd = 1163017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1163031, RefRangeEnd = 1163035, XrefRangeStart = 1163026, XrefRangeEnd = 1163031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AudioClip clip
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1163044, RefRangeEnd = 1163048, XrefRangeStart = 1163035, XrefRangeEnd = 1163044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163056, RefRangeEnd = 1163058, XrefRangeStart = 1163048, XrefRangeEnd = 1163056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AudioResource resource
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163058, XrefRangeEnd = 1163066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resource_Public_get_AudioResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioResource>(intPtr2) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163056, RefRangeEnd = 1163058, XrefRangeStart = 1163056, XrefRangeEnd = 1163058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_resource_Public_set_Void_AudioResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AudioMixerGroup outputAudioMixerGroup
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AudioMixerGroup>(get_outputAudioMixerGroup_Injected(intPtr));
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163066, XrefRangeEnd = 1163074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isPlaying
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1163115, RefRangeEnd = 1163125, XrefRangeStart = 1163110, XrefRangeEnd = 1163115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool loop
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163130, RefRangeEnd = 1163131, XrefRangeStart = 1163125, XrefRangeEnd = 1163130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163131, XrefRangeEnd = 1163136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool playOnAwake
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_playOnAwake_Injected(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163136, XrefRangeEnd = 1163141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float panStereo
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163146, RefRangeEnd = 1163148, XrefRangeStart = 1163141, XrefRangeEnd = 1163146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_panStereo_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1163153, RefRangeEnd = 1163160, XrefRangeStart = 1163148, XrefRangeEnd = 1163153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float spatialBlend
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spatialBlend_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163165, RefRangeEnd = 1163166, XrefRangeStart = 1163160, XrefRangeEnd = 1163165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float reverbZoneMix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reverbZoneMix_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163171, RefRangeEnd = 1163172, XrefRangeStart = 1163166, XrefRangeEnd = 1163171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float dopplerLevel
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dopplerLevel_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163177, RefRangeEnd = 1163178, XrefRangeStart = 1163172, XrefRangeEnd = 1163177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float spread
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spread_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163183, RefRangeEnd = 1163184, XrefRangeStart = 1163178, XrefRangeEnd = 1163183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float minDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minDistance_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163189, RefRangeEnd = 1163190, XrefRangeStart = 1163184, XrefRangeEnd = 1163189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float maxDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDistance_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163195, RefRangeEnd = 1163196, XrefRangeStart = 1163190, XrefRangeEnd = 1163195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AudioRolloffMode rolloffMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rolloffMode_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163201, RefRangeEnd = 1163202, XrefRangeStart = 1163196, XrefRangeEnd = 1163201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool isContainerPlaying
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isContainerPlaying_Injected(intPtr);
		}
	}

	public Il2CppStructArray<ActivePlayable> containerActivePlayables
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_containerActivePlayables_Injected(intPtr);
		}
	}

	public bool isVirtual
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isVirtual_Injected(intPtr);
		}
	}

	public bool ignoreListenerVolume
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ignoreListenerVolume_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_ignoreListenerVolume_Injected(intPtr, value);
		}
	}

	public bool ignoreListenerPause
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ignoreListenerPause_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_ignoreListenerPause_Injected(intPtr, value);
		}
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_velocityUpdateMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_velocityUpdateMode_Injected(intPtr, value);
		}
	}

	public bool spatialize
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spatialize_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_spatialize_Injected(intPtr, value);
		}
	}

	public bool spatializePostEffects
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spatializePostEffects_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_spatializePostEffects_Injected(intPtr, value);
		}
	}

	public bool bypassEffects
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bypassEffects_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bypassEffects_Injected(intPtr, value);
		}
	}

	public bool bypassListenerEffects
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bypassListenerEffects_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bypassListenerEffects_Injected(intPtr, value);
		}
	}

	public bool bypassReverbZones
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bypassReverbZones_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bypassReverbZones_Injected(intPtr, value);
		}
	}

	public int priority
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_priority_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_priority_Injected(intPtr, value);
		}
	}

	public bool mute
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mute_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mute_Injected(intPtr, value);
		}
	}

	public float minVolume
	{
		get
		{
			Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			return 0f;
		}
		set
		{
			Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
		}
	}

	public float maxVolume
	{
		get
		{
			Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			return 0f;
		}
		set
		{
			Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
		}
	}

	public float rolloffFactor
	{
		get
		{
			Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			return 0f;
		}
		set
		{
			Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
		}
	}

	static AudioSource()
	{
		Il2CppClassPointerStore<AudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSource>.NativeClassPtr);
		NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_Play_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_get_volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_get_resource_Public_get_AudioResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_set_resource_Public_set_Void_AudioResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_get_panStereo_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetPitch_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_SetPitch_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_PlayHelper_Injected_Private_Static_Void_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_SetCustomCurveHelper_Injected_Private_Static_Void_IntPtr_AudioSourceCurveType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_get_volume_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_set_volume_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_get_timeSamples_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_set_timeSamples_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_get_resource_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_set_resource_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_set_outputAudioMixerGroup_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_isPlaying_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_get_panStereo_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_set_panStereo_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_set_spatialBlend_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_set_reverbZoneMix_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_set_dopplerLevel_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_set_spread_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_set_minDistance_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_set_maxDistance_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_set_rolloffMode_Injected_Private_Static_Void_IntPtr_AudioRolloffMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663400);
		PlayOneShotHelper_InjectedDelegateField = IL2CPP.ResolveICall<PlayOneShotHelper_InjectedDelegate>("UnityEngine.AudioSource::PlayOneShotHelper_Injected");
		GetCustomCurveHelper_InjectedDelegateField = IL2CPP.ResolveICall<GetCustomCurveHelper_InjectedDelegate>("UnityEngine.AudioSource::GetCustomCurveHelper_Injected");
		GetOutputDataHelper_InjectedDelegateField = IL2CPP.ResolveICall<GetOutputDataHelper_InjectedDelegate>("UnityEngine.AudioSource::GetOutputDataHelper_Injected");
		get_outputAudioMixerGroup_InjectedDelegateField = IL2CPP.ResolveICall<get_outputAudioMixerGroup_InjectedDelegate>("UnityEngine.AudioSource::get_outputAudioMixerGroup_Injected");
		SetScheduledStartTime_InjectedDelegateField = IL2CPP.ResolveICall<SetScheduledStartTime_InjectedDelegate>("UnityEngine.AudioSource::SetScheduledStartTime_Injected");
		SetScheduledEndTime_InjectedDelegateField = IL2CPP.ResolveICall<SetScheduledEndTime_InjectedDelegate>("UnityEngine.AudioSource::SetScheduledEndTime_Injected");
		UnPause_InjectedDelegateField = IL2CPP.ResolveICall<UnPause_InjectedDelegate>("UnityEngine.AudioSource::UnPause_Injected");
		SkipToNextElementIfHasContainer_InjectedDelegateField = IL2CPP.ResolveICall<SkipToNextElementIfHasContainer_InjectedDelegate>("UnityEngine.AudioSource::SkipToNextElementIfHasContainer_Injected");
		get_isContainerPlaying_InjectedDelegateField = IL2CPP.ResolveICall<get_isContainerPlaying_InjectedDelegate>("UnityEngine.AudioSource::get_isContainerPlaying_Injected");
		get_containerActivePlayables_InjectedDelegateField = IL2CPP.ResolveICall<get_containerActivePlayables_InjectedDelegate>("UnityEngine.AudioSource::get_containerActivePlayables_Injected");
		get_isVirtual_InjectedDelegateField = IL2CPP.ResolveICall<get_isVirtual_InjectedDelegate>("UnityEngine.AudioSource::get_isVirtual_Injected");
		get_ignoreListenerVolume_InjectedDelegateField = IL2CPP.ResolveICall<get_ignoreListenerVolume_InjectedDelegate>("UnityEngine.AudioSource::get_ignoreListenerVolume_Injected");
		set_ignoreListenerVolume_InjectedDelegateField = IL2CPP.ResolveICall<set_ignoreListenerVolume_InjectedDelegate>("UnityEngine.AudioSource::set_ignoreListenerVolume_Injected");
		get_playOnAwake_InjectedDelegateField = IL2CPP.ResolveICall<get_playOnAwake_InjectedDelegate>("UnityEngine.AudioSource::get_playOnAwake_Injected");
		get_ignoreListenerPause_InjectedDelegateField = IL2CPP.ResolveICall<get_ignoreListenerPause_InjectedDelegate>("UnityEngine.AudioSource::get_ignoreListenerPause_Injected");
		set_ignoreListenerPause_InjectedDelegateField = IL2CPP.ResolveICall<set_ignoreListenerPause_InjectedDelegate>("UnityEngine.AudioSource::set_ignoreListenerPause_Injected");
		get_velocityUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_velocityUpdateMode_InjectedDelegate>("UnityEngine.AudioSource::get_velocityUpdateMode_Injected");
		set_velocityUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<set_velocityUpdateMode_InjectedDelegate>("UnityEngine.AudioSource::set_velocityUpdateMode_Injected");
		get_spatialBlend_InjectedDelegateField = IL2CPP.ResolveICall<get_spatialBlend_InjectedDelegate>("UnityEngine.AudioSource::get_spatialBlend_Injected");
		get_spatialize_InjectedDelegateField = IL2CPP.ResolveICall<get_spatialize_InjectedDelegate>("UnityEngine.AudioSource::get_spatialize_Injected");
		set_spatialize_InjectedDelegateField = IL2CPP.ResolveICall<set_spatialize_InjectedDelegate>("UnityEngine.AudioSource::set_spatialize_Injected");
		get_spatializePostEffects_InjectedDelegateField = IL2CPP.ResolveICall<get_spatializePostEffects_InjectedDelegate>("UnityEngine.AudioSource::get_spatializePostEffects_Injected");
		set_spatializePostEffects_InjectedDelegateField = IL2CPP.ResolveICall<set_spatializePostEffects_InjectedDelegate>("UnityEngine.AudioSource::set_spatializePostEffects_Injected");
		get_reverbZoneMix_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbZoneMix_InjectedDelegate>("UnityEngine.AudioSource::get_reverbZoneMix_Injected");
		get_bypassEffects_InjectedDelegateField = IL2CPP.ResolveICall<get_bypassEffects_InjectedDelegate>("UnityEngine.AudioSource::get_bypassEffects_Injected");
		set_bypassEffects_InjectedDelegateField = IL2CPP.ResolveICall<set_bypassEffects_InjectedDelegate>("UnityEngine.AudioSource::set_bypassEffects_Injected");
		get_bypassListenerEffects_InjectedDelegateField = IL2CPP.ResolveICall<get_bypassListenerEffects_InjectedDelegate>("UnityEngine.AudioSource::get_bypassListenerEffects_Injected");
		set_bypassListenerEffects_InjectedDelegateField = IL2CPP.ResolveICall<set_bypassListenerEffects_InjectedDelegate>("UnityEngine.AudioSource::set_bypassListenerEffects_Injected");
		get_bypassReverbZones_InjectedDelegateField = IL2CPP.ResolveICall<get_bypassReverbZones_InjectedDelegate>("UnityEngine.AudioSource::get_bypassReverbZones_Injected");
		set_bypassReverbZones_InjectedDelegateField = IL2CPP.ResolveICall<set_bypassReverbZones_InjectedDelegate>("UnityEngine.AudioSource::set_bypassReverbZones_Injected");
		get_dopplerLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_dopplerLevel_InjectedDelegate>("UnityEngine.AudioSource::get_dopplerLevel_Injected");
		get_spread_InjectedDelegateField = IL2CPP.ResolveICall<get_spread_InjectedDelegate>("UnityEngine.AudioSource::get_spread_Injected");
		get_priority_InjectedDelegateField = IL2CPP.ResolveICall<get_priority_InjectedDelegate>("UnityEngine.AudioSource::get_priority_Injected");
		set_priority_InjectedDelegateField = IL2CPP.ResolveICall<set_priority_InjectedDelegate>("UnityEngine.AudioSource::set_priority_Injected");
		get_mute_InjectedDelegateField = IL2CPP.ResolveICall<get_mute_InjectedDelegate>("UnityEngine.AudioSource::get_mute_Injected");
		set_mute_InjectedDelegateField = IL2CPP.ResolveICall<set_mute_InjectedDelegate>("UnityEngine.AudioSource::set_mute_Injected");
		get_minDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_minDistance_InjectedDelegate>("UnityEngine.AudioSource::get_minDistance_Injected");
		get_maxDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDistance_InjectedDelegate>("UnityEngine.AudioSource::get_maxDistance_Injected");
		get_rolloffMode_InjectedDelegateField = IL2CPP.ResolveICall<get_rolloffMode_InjectedDelegate>("UnityEngine.AudioSource::get_rolloffMode_Injected");
		SetSpatializerFloat_InjectedDelegateField = IL2CPP.ResolveICall<SetSpatializerFloat_InjectedDelegate>("UnityEngine.AudioSource::SetSpatializerFloat_Injected");
		GetSpatializerFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetSpatializerFloat_InjectedDelegate>("UnityEngine.AudioSource::GetSpatializerFloat_Injected");
		GetAmbisonicDecoderFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetAmbisonicDecoderFloat_InjectedDelegate>("UnityEngine.AudioSource::GetAmbisonicDecoderFloat_Injected");
		SetAmbisonicDecoderFloat_InjectedDelegateField = IL2CPP.ResolveICall<SetAmbisonicDecoderFloat_InjectedDelegate>("UnityEngine.AudioSource::SetAmbisonicDecoderFloat_Injected");
		GetAudioRandomContainerRuntimeMeterValue_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioRandomContainerRuntimeMeterValue_InjectedDelegate>("UnityEngine.AudioSource::GetAudioRandomContainerRuntimeMeterValue_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162911, RefRangeEnd = 1162912, XrefRangeStart = 1162902, XrefRangeEnd = 1162911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPitch(AudioSource source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1162921, RefRangeEnd = 1162926, XrefRangeStart = 1162912, XrefRangeEnd = 1162921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPitch(AudioSource source, float pitch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162926, XrefRangeEnd = 1162935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayHelper(AudioSource source, ulong delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162935, XrefRangeEnd = 1162940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(double delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162940, XrefRangeEnd = 1162945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop(bool stopOneShots)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stopOneShots);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1162954, RefRangeEnd = 1162958, XrefRangeStart = 1162945, XrefRangeEnd = 1162954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(AudioSourceCurveType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162972, RefRangeEnd = 1162973, XrefRangeStart = 1162958, XrefRangeEnd = 1162972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpectrumDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
	{
		//IL_0065: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &window;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		Unsafe.Write((void*)(nint)samples, (num3 == 0) ? null : new Il2CppStructArray<float>((System.IntPtr)num3));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1163083, RefRangeEnd = 1163086, XrefRangeStart = 1163074, XrefRangeEnd = 1163083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163091, RefRangeEnd = 1163092, XrefRangeStart = 1163086, XrefRangeEnd = 1163091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayDelayed(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1163097, RefRangeEnd = 1163102, XrefRangeStart = 1163092, XrefRangeEnd = 1163097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1163107, RefRangeEnd = 1163110, XrefRangeStart = 1163102, XrefRangeEnd = 1163107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1162954, RefRangeEnd = 1162958, XrefRangeStart = 1162954, XrefRangeEnd = 1162958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163203, RefRangeEnd = 1163204, XrefRangeStart = 1163202, XrefRangeEnd = 1163203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)samples);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &window;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioSource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSource>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163204, XrefRangeEnd = 1163206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPitch_Injected(System.IntPtr source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPitch_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163206, XrefRangeEnd = 1163208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPitch_Injected(System.IntPtr source, float pitch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&source);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPitch_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163208, XrefRangeEnd = 1163210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlayHelper_Injected(System.IntPtr source, ulong delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&source);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayHelper_Injected_Private_Static_Void_IntPtr_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163210, XrefRangeEnd = 1163212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Play_Injected(System.IntPtr _unity_self, double delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163212, XrefRangeEnd = 1163214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Stop_Injected(System.IntPtr _unity_self, bool stopOneShots)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stopOneShots;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163214, XrefRangeEnd = 1163216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomCurveHelper_Injected(System.IntPtr source, AudioSourceCurveType type, System.IntPtr curve)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&source);
		*(AudioSourceCurveType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &curve;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomCurveHelper_Injected_Private_Static_Void_IntPtr_AudioSourceCurveType_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163216, XrefRangeEnd = 1163218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpectrumDataHelper_Injected(System.IntPtr source, out BlittableArrayWrapper samples, int channel, FFTWindow window)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref samples);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		*(FFTWindow**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &window;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpectrumDataHelper_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_Int32_FFTWindow_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163218, XrefRangeEnd = 1163220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_volume_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_volume_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163220, XrefRangeEnd = 1163222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_volume_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_volume_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163222, XrefRangeEnd = 1163224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_time_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163224, XrefRangeEnd = 1163226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_time_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163226, XrefRangeEnd = 1163228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_timeSamples_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeSamples_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163228, XrefRangeEnd = 1163230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_timeSamples_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeSamples_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163230, XrefRangeEnd = 1163232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_resource_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resource_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163232, XrefRangeEnd = 1163234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_resource_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_resource_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163234, XrefRangeEnd = 1163236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_outputAudioMixerGroup_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_outputAudioMixerGroup_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163236, XrefRangeEnd = 1163238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Pause_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163238, XrefRangeEnd = 1163240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isPlaying_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPlaying_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163240, XrefRangeEnd = 1163242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_loop_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163242, XrefRangeEnd = 1163244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_loop_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163244, XrefRangeEnd = 1163246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_playOnAwake_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163246, XrefRangeEnd = 1163248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_panStereo_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_panStereo_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163248, XrefRangeEnd = 1163250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_panStereo_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_panStereo_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163250, XrefRangeEnd = 1163252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_spatialBlend_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spatialBlend_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163252, XrefRangeEnd = 1163254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_reverbZoneMix_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reverbZoneMix_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163254, XrefRangeEnd = 1163256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_dopplerLevel_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dopplerLevel_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163256, XrefRangeEnd = 1163258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_spread_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spread_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163258, XrefRangeEnd = 1163260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_minDistance_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_minDistance_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163260, XrefRangeEnd = 1163262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_maxDistance_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxDistance_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163262, XrefRangeEnd = 1163264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rolloffMode_Injected(System.IntPtr _unity_self, AudioRolloffMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(AudioRolloffMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rolloffMode_Injected_Private_Static_Void_IntPtr_AudioRolloffMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioSource(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale)
	{
		if ((object)source == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		if ((object)clip == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(source);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(clip);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		PlayOneShotHelper_Injected(intPtr, intPtr2, volumeScale);
	}

	public static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type)
	{
		if ((object)source == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(source);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		System.IntPtr customCurveHelper_Injected = GetCustomCurveHelper_Injected(intPtr, type);
		return (customCurveHelper_Injected == (System.IntPtr)0) ? null : AnimationCurve.BindingsMarshaller.ConvertToManaged(customCurveHelper_Injected);
	}

	public static void GetOutputDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Play(ulong delay)
	{
		PlayHelper(this, delay);
	}

	public void PlayScheduled(double time)
	{
		Play((time < 0.0) ? 0.0 : time);
	}

	public void PlayOneShot(AudioClip clip)
	{
		PlayOneShot(clip, 1f);
	}

	public void PlayOneShot(AudioClip clip, float volumeScale)
	{
		if (clip == null)
		{
			Debug.LogWarning("PlayOneShot was called with a null AudioClip.");
		}
		else
		{
			PlayOneShotHelper(this, clip, volumeScale);
		}
	}

	public void SetScheduledStartTime(double time)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetScheduledStartTime_Injected(intPtr, time);
	}

	public void SetScheduledEndTime(double time)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetScheduledEndTime_Injected(intPtr, time);
	}

	public void UnPause()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UnPause_Injected(intPtr);
	}

	public void SkipToNextElementIfHasContainer()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SkipToNextElementIfHasContainer_Injected(intPtr);
	}

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
	{
		PlayClipAtPoint(clip, position, 1f);
	}

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume)
	{
		GameObject gameObject = new GameObject("One shot audio");
		gameObject.transform.position = position;
		AudioSource audioSource = ((Il2CppObjectBase)gameObject.AddComponent(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AudioSource>()))).Cast<AudioSource>();
		audioSource.clip = clip;
		audioSource.spatialBlend = 1f;
		audioSource.volume = volume;
		audioSource.Play();
		Object.Destroy(gameObject, clip.length * ((Time.timeScale < 0.01f) ? 0.01f : Time.timeScale));
	}

	public AnimationCurve GetCustomCurve(AudioSourceCurveType type)
	{
		return GetCustomCurveHelper(this, type);
	}

	public Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void GetOutputData(Il2CppStructArray<float> samples, int channel)
	{
		GetOutputDataHelper(this, samples, channel);
	}

	public Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool SetSpatializerFloat(int index, float value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetSpatializerFloat_Injected(intPtr, index, value);
	}

	public bool GetSpatializerFloat(int index, out float value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSpatializerFloat_Injected(intPtr, index, out value);
	}

	public bool GetAmbisonicDecoderFloat(int index, out float value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAmbisonicDecoderFloat_Injected(intPtr, index, out value);
	}

	public bool SetAmbisonicDecoderFloat(int index, float value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetAmbisonicDecoderFloat_Injected(intPtr, index, value);
	}

	public float GetAudioRandomContainerRuntimeMeterValue()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAudioRandomContainerRuntimeMeterValue_Injected(intPtr);
	}

	public static void PlayOneShotHelper_Injected(System.IntPtr source, System.IntPtr clip, float volumeScale)
	{
		PlayOneShotHelper_InjectedDelegateField(source, clip, volumeScale);
	}

	public static System.IntPtr GetCustomCurveHelper_Injected(System.IntPtr source, AudioSourceCurveType type)
	{
		return GetCustomCurveHelper_InjectedDelegateField(source, type);
	}

	public unsafe static void GetOutputDataHelper_Injected(System.IntPtr source, out BlittableArrayWrapper samples, int channel)
	{
		GetOutputDataHelper_InjectedDelegateField(source, (nint)Unsafe.AsPointer(ref samples), channel);
	}

	public static System.IntPtr get_outputAudioMixerGroup_Injected(System.IntPtr _unity_self)
	{
		return get_outputAudioMixerGroup_InjectedDelegateField(_unity_self);
	}

	public static void SetScheduledStartTime_Injected(System.IntPtr _unity_self, double time)
	{
		SetScheduledStartTime_InjectedDelegateField(_unity_self, time);
	}

	public static void SetScheduledEndTime_Injected(System.IntPtr _unity_self, double time)
	{
		SetScheduledEndTime_InjectedDelegateField(_unity_self, time);
	}

	public static void UnPause_Injected(System.IntPtr _unity_self)
	{
		UnPause_InjectedDelegateField(_unity_self);
	}

	public static void SkipToNextElementIfHasContainer_Injected(System.IntPtr _unity_self)
	{
		SkipToNextElementIfHasContainer_InjectedDelegateField(_unity_self);
	}

	public static bool get_isContainerPlaying_Injected(System.IntPtr _unity_self)
	{
		return get_isContainerPlaying_InjectedDelegateField(_unity_self);
	}

	public static Il2CppStructArray<ActivePlayable> get_containerActivePlayables_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_containerActivePlayables_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ActivePlayable>>(intPtr) : null;
	}

	public static bool get_isVirtual_Injected(System.IntPtr _unity_self)
	{
		return get_isVirtual_InjectedDelegateField(_unity_self);
	}

	public static bool get_ignoreListenerVolume_Injected(System.IntPtr _unity_self)
	{
		return get_ignoreListenerVolume_InjectedDelegateField(_unity_self);
	}

	public static void set_ignoreListenerVolume_Injected(System.IntPtr _unity_self, bool value)
	{
		set_ignoreListenerVolume_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_playOnAwake_Injected(System.IntPtr _unity_self)
	{
		return get_playOnAwake_InjectedDelegateField(_unity_self);
	}

	public static bool get_ignoreListenerPause_Injected(System.IntPtr _unity_self)
	{
		return get_ignoreListenerPause_InjectedDelegateField(_unity_self);
	}

	public static void set_ignoreListenerPause_Injected(System.IntPtr _unity_self, bool value)
	{
		set_ignoreListenerPause_InjectedDelegateField(_unity_self, value);
	}

	public static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(System.IntPtr _unity_self)
	{
		return get_velocityUpdateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_velocityUpdateMode_Injected(System.IntPtr _unity_self, AudioVelocityUpdateMode value)
	{
		set_velocityUpdateMode_InjectedDelegateField(_unity_self, value);
	}

	public static float get_spatialBlend_Injected(System.IntPtr _unity_self)
	{
		return get_spatialBlend_InjectedDelegateField(_unity_self);
	}

	public static bool get_spatialize_Injected(System.IntPtr _unity_self)
	{
		return get_spatialize_InjectedDelegateField(_unity_self);
	}

	public static void set_spatialize_Injected(System.IntPtr _unity_self, bool value)
	{
		set_spatialize_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_spatializePostEffects_Injected(System.IntPtr _unity_self)
	{
		return get_spatializePostEffects_InjectedDelegateField(_unity_self);
	}

	public static void set_spatializePostEffects_Injected(System.IntPtr _unity_self, bool value)
	{
		set_spatializePostEffects_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reverbZoneMix_Injected(System.IntPtr _unity_self)
	{
		return get_reverbZoneMix_InjectedDelegateField(_unity_self);
	}

	public static bool get_bypassEffects_Injected(System.IntPtr _unity_self)
	{
		return get_bypassEffects_InjectedDelegateField(_unity_self);
	}

	public static void set_bypassEffects_Injected(System.IntPtr _unity_self, bool value)
	{
		set_bypassEffects_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_bypassListenerEffects_Injected(System.IntPtr _unity_self)
	{
		return get_bypassListenerEffects_InjectedDelegateField(_unity_self);
	}

	public static void set_bypassListenerEffects_Injected(System.IntPtr _unity_self, bool value)
	{
		set_bypassListenerEffects_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_bypassReverbZones_Injected(System.IntPtr _unity_self)
	{
		return get_bypassReverbZones_InjectedDelegateField(_unity_self);
	}

	public static void set_bypassReverbZones_Injected(System.IntPtr _unity_self, bool value)
	{
		set_bypassReverbZones_InjectedDelegateField(_unity_self, value);
	}

	public static float get_dopplerLevel_Injected(System.IntPtr _unity_self)
	{
		return get_dopplerLevel_InjectedDelegateField(_unity_self);
	}

	public static float get_spread_Injected(System.IntPtr _unity_self)
	{
		return get_spread_InjectedDelegateField(_unity_self);
	}

	public static int get_priority_Injected(System.IntPtr _unity_self)
	{
		return get_priority_InjectedDelegateField(_unity_self);
	}

	public static void set_priority_Injected(System.IntPtr _unity_self, int value)
	{
		set_priority_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_mute_Injected(System.IntPtr _unity_self)
	{
		return get_mute_InjectedDelegateField(_unity_self);
	}

	public static void set_mute_Injected(System.IntPtr _unity_self, bool value)
	{
		set_mute_InjectedDelegateField(_unity_self, value);
	}

	public static float get_minDistance_Injected(System.IntPtr _unity_self)
	{
		return get_minDistance_InjectedDelegateField(_unity_self);
	}

	public static float get_maxDistance_Injected(System.IntPtr _unity_self)
	{
		return get_maxDistance_InjectedDelegateField(_unity_self);
	}

	public static AudioRolloffMode get_rolloffMode_Injected(System.IntPtr _unity_self)
	{
		return get_rolloffMode_InjectedDelegateField(_unity_self);
	}

	public static bool SetSpatializerFloat_Injected(System.IntPtr _unity_self, int index, float value)
	{
		return SetSpatializerFloat_InjectedDelegateField(_unity_self, index, value);
	}

	public unsafe static bool GetSpatializerFloat_Injected(System.IntPtr _unity_self, int index, out float value)
	{
		return GetSpatializerFloat_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool GetAmbisonicDecoderFloat_Injected(System.IntPtr _unity_self, int index, out float value)
	{
		return GetAmbisonicDecoderFloat_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool SetAmbisonicDecoderFloat_Injected(System.IntPtr _unity_self, int index, float value)
	{
		return SetAmbisonicDecoderFloat_InjectedDelegateField(_unity_self, index, value);
	}

	public static float GetAudioRandomContainerRuntimeMeterValue_Injected(System.IntPtr _unity_self)
	{
		return GetAudioRandomContainerRuntimeMeterValue_InjectedDelegateField(_unity_self);
	}
}
