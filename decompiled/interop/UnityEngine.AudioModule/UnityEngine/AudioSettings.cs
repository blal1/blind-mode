using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioSettings : Il2CppSystem.Object
{
	public sealed class AudioConfigurationChangeHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

		static AudioConfigurationChangeHandler()
		{
			Il2CppClassPointerStore<AudioConfigurationChangeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AudioConfigurationChangeHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioConfigurationChangeHandler>.NativeClassPtr, 100663305);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioConfigurationChangeHandler>.NativeClassPtr, 100663306);
		}

		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 49391, RefRangeEnd = 49629, XrefRangeStart = 49391, XrefRangeEnd = 49629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioConfigurationChangeHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioConfigurationChangeHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(bool deviceWasChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&deviceWasChanged);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AudioConfigurationChangeHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator AudioConfigurationChangeHandler(System.Action<bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<AudioConfigurationChangeHandler>((System.Delegate)P_0);
		}

		public static AudioConfigurationChangeHandler operator +(AudioConfigurationChangeHandler P_0, AudioConfigurationChangeHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<AudioConfigurationChangeHandler>();
		}

		public static AudioConfigurationChangeHandler operator -(AudioConfigurationChangeHandler P_0, AudioConfigurationChangeHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<AudioConfigurationChangeHandler>();
			}
			return (AudioConfigurationChangeHandler)obj;
		}
	}

	public static class Mobile
	{
	}

	private delegate AudioSpeakerMode GetSpeakerModeDelegate();

	private delegate int GetSampleRateDelegate();

	private delegate AudioSpeakerMode get_driverCapabilitiesDelegate();

	private delegate int get_profilerCaptureFlagsDelegate();

	private delegate double get_dspTimeDelegate();

	private delegate void GetDSPBufferSizeDelegate([Out] System.IntPtr bufferLength, [Out] System.IntPtr numBuffers);

	private delegate bool get_unityAudioDisabledDelegate();

	private delegate void set_unityAudioDisabledDelegate(bool value);

	private delegate bool StartAudioOutputDelegate();

	private delegate bool StopAudioOutputDelegate();

	private delegate bool get_audioOutputStartedDelegate();

	private delegate void GetSpatializerPluginName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetAmbisonicDecoderPluginName_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_OnAudioConfigurationChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnAudioSystemShuttingDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnAudioSystemStartedUp;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConfiguration_Private_Static_Boolean_AudioConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfiguration_Public_Static_AudioConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Boolean_AudioConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConfiguration_Injected_Private_Static_Boolean_byref_AudioConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfiguration_Injected_Private_Static_Void_byref_AudioConfiguration_0;

	private static readonly GetSpeakerModeDelegate GetSpeakerModeDelegateField;

	private static readonly GetSampleRateDelegate GetSampleRateDelegateField;

	private static readonly get_driverCapabilitiesDelegate get_driverCapabilitiesDelegateField;

	private static readonly get_profilerCaptureFlagsDelegate get_profilerCaptureFlagsDelegateField;

	private static readonly get_dspTimeDelegate get_dspTimeDelegateField;

	private static readonly GetDSPBufferSizeDelegate GetDSPBufferSizeDelegateField;

	private static readonly get_unityAudioDisabledDelegate get_unityAudioDisabledDelegateField;

	private static readonly set_unityAudioDisabledDelegate set_unityAudioDisabledDelegateField;

	private static readonly StartAudioOutputDelegate StartAudioOutputDelegateField;

	private static readonly StopAudioOutputDelegate StopAudioOutputDelegateField;

	private static readonly get_audioOutputStartedDelegate get_audioOutputStartedDelegateField;

	private static readonly GetSpatializerPluginName_InjectedDelegate GetSpatializerPluginName_InjectedDelegateField;

	private static readonly GetAmbisonicDecoderPluginName_InjectedDelegate GetAmbisonicDecoderPluginName_InjectedDelegateField;

	public unsafe static AudioConfigurationChangeHandler OnAudioConfigurationChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnAudioConfigurationChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioConfigurationChangeHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnAudioConfigurationChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action OnAudioSystemShuttingDown
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnAudioSystemShuttingDown, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnAudioSystemShuttingDown, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action OnAudioSystemStartedUp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnAudioSystemStartedUp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnAudioSystemStartedUp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static AudioSpeakerMode driverCapabilities => get_driverCapabilitiesDelegateField();

	public static AudioSpeakerMode speakerMode
	{
		get
		{
			return GetSpeakerMode();
		}
		set
		{
			Debug.LogWarning("Setting AudioSettings.speakerMode is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.");
			AudioConfiguration configuration = GetConfiguration();
			configuration.speakerMode = value;
			if (!SetConfiguration(configuration))
			{
				Debug.LogWarning("Setting AudioSettings.speakerMode failed");
			}
		}
	}

	public static int profilerCaptureFlags => get_profilerCaptureFlagsDelegateField();

	public static double dspTime => get_dspTimeDelegateField();

	public static int outputSampleRate
	{
		get
		{
			return GetSampleRate();
		}
		set
		{
			Debug.LogWarning("Setting AudioSettings.outputSampleRate is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.");
			AudioConfiguration configuration = GetConfiguration();
			configuration.sampleRate = value;
			if (!SetConfiguration(configuration))
			{
				Debug.LogWarning("Setting AudioSettings.outputSampleRate failed");
			}
		}
	}

	public static bool unityAudioDisabled
	{
		get
		{
			return get_unityAudioDisabledDelegateField();
		}
		set
		{
			set_unityAudioDisabledDelegateField(value);
		}
	}

	public static AudioSpatialExperience audioSpatialExperience
	{
		get
		{
			return AudioSpatialExperience.Bypassed;
		}
		set
		{
			Debug.LogWarning("AudioSettings.audioSpatialExperience is not implemented on this platform.");
		}
	}

	public static bool audioOutputStarted => get_audioOutputStartedDelegateField();

	static AudioSettings()
	{
		Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
		NativeFieldInfoPtr_OnAudioConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioConfigurationChanged");
		NativeFieldInfoPtr_OnAudioSystemShuttingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemShuttingDown");
		NativeFieldInfoPtr_OnAudioSystemStartedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioSystemStartedUp");
		NativeMethodInfoPtr_SetConfiguration_Private_Static_Boolean_AudioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_GetConfiguration_Public_Static_AudioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_Reset_Public_Static_Boolean_AudioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_SetConfiguration_Injected_Private_Static_Boolean_byref_AudioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_GetConfiguration_Injected_Private_Static_Void_byref_AudioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663304);
		GetSpeakerModeDelegateField = IL2CPP.ResolveICall<GetSpeakerModeDelegate>("UnityEngine.AudioSettings::GetSpeakerMode");
		GetSampleRateDelegateField = IL2CPP.ResolveICall<GetSampleRateDelegate>("UnityEngine.AudioSettings::GetSampleRate");
		get_driverCapabilitiesDelegateField = IL2CPP.ResolveICall<get_driverCapabilitiesDelegate>("UnityEngine.AudioSettings::get_driverCapabilities");
		get_profilerCaptureFlagsDelegateField = IL2CPP.ResolveICall<get_profilerCaptureFlagsDelegate>("UnityEngine.AudioSettings::get_profilerCaptureFlags");
		get_dspTimeDelegateField = IL2CPP.ResolveICall<get_dspTimeDelegate>("UnityEngine.AudioSettings::get_dspTime");
		GetDSPBufferSizeDelegateField = IL2CPP.ResolveICall<GetDSPBufferSizeDelegate>("UnityEngine.AudioSettings::GetDSPBufferSize");
		get_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<get_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::get_unityAudioDisabled");
		set_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<set_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::set_unityAudioDisabled");
		StartAudioOutputDelegateField = IL2CPP.ResolveICall<StartAudioOutputDelegate>("UnityEngine.AudioSettings::StartAudioOutput");
		StopAudioOutputDelegateField = IL2CPP.ResolveICall<StopAudioOutputDelegate>("UnityEngine.AudioSettings::StopAudioOutput");
		get_audioOutputStartedDelegateField = IL2CPP.ResolveICall<get_audioOutputStartedDelegate>("UnityEngine.AudioSettings::get_audioOutputStarted");
		GetSpatializerPluginName_InjectedDelegateField = IL2CPP.ResolveICall<GetSpatializerPluginName_InjectedDelegate>("UnityEngine.AudioSettings::GetSpatializerPluginName_Injected");
		GetAmbisonicDecoderPluginName_InjectedDelegateField = IL2CPP.ResolveICall<GetAmbisonicDecoderPluginName_InjectedDelegate>("UnityEngine.AudioSettings::GetAmbisonicDecoderPluginName_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162812, XrefRangeEnd = 1162814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetConfiguration(AudioConfiguration config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&config);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConfiguration_Private_Static_Boolean_AudioConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162816, RefRangeEnd = 1162817, XrefRangeStart = 1162814, XrefRangeEnd = 1162816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioConfiguration GetConfiguration()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfiguration_Public_Static_AudioConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioConfiguration*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162819, RefRangeEnd = 1162820, XrefRangeStart = 1162817, XrefRangeEnd = 1162819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Reset(AudioConfiguration config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&config);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Static_Boolean_AudioConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162820, XrefRangeEnd = 1162822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deviceWasChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162822, XrefRangeEnd = 1162824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnAudioSystemShuttingDown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnAudioSystemShuttingDown_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162824, XrefRangeEnd = 1162826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnAudioSystemStartedUp()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnAudioSystemStartedUp_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162826, XrefRangeEnd = 1162828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetConfiguration_Injected([In] ref AudioConfiguration config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref config);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConfiguration_Injected_Private_Static_Boolean_byref_AudioConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162828, XrefRangeEnd = 1162830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetConfiguration_Injected(out AudioConfiguration ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfiguration_Injected_Private_Static_Void_byref_AudioConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static AudioSpeakerMode GetSpeakerMode()
	{
		return GetSpeakerModeDelegateField();
	}

	public static int GetSampleRate()
	{
		return GetSampleRateDelegateField();
	}

	public unsafe static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
	{
		GetDSPBufferSizeDelegateField((nint)Unsafe.AsPointer(ref bufferLength), (nint)Unsafe.AsPointer(ref numBuffers));
	}

	public static void SetDSPBufferSize(int bufferLength, int numBuffers)
	{
		Debug.LogWarning("AudioSettings.SetDSPBufferSize is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.");
		AudioConfiguration configuration = GetConfiguration();
		configuration.dspBufferSize = bufferLength;
		if (!SetConfiguration(configuration))
		{
			Debug.LogWarning("SetDSPBufferSize failed");
		}
	}

	public static string GetSpatializerPluginName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetSpatializerPluginName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	[SpecialName]
	public static void add_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_OnAudioSystemShuttingDown(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_OnAudioSystemShuttingDown(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_OnAudioSystemStartedUp(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_OnAudioSystemStartedUp(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string GetAmbisonicDecoderPluginName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetAmbisonicDecoderPluginName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool StartAudioOutput()
	{
		return StartAudioOutputDelegateField();
	}

	public static bool StopAudioOutput()
	{
		return StopAudioOutputDelegateField();
	}

	public unsafe static void GetSpatializerPluginName_Injected(out ManagedSpanWrapper ret)
	{
		GetSpatializerPluginName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetAmbisonicDecoderPluginName_Injected(out ManagedSpanWrapper ret)
	{
		GetAmbisonicDecoderPluginName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
