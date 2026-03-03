using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Audio;

namespace UnityEngineInternal.Video;

public class VideoPlayback
{
	public static class BindingsMarshaller
	{
	}

	private delegate bool PlatformSupportsH265Delegate();

	private delegate void StartPlayback_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void PausePlayback_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void StopPlayback_InjectedDelegate(System.IntPtr _unity_self);

	private delegate VideoError GetStatus_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsReady_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsPlaying_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Step_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool CanStep_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetHeight_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float GetFrameRate_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float GetDuration_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ulong GetFrameCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetPixelAspectRatioNumerator_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetPixelAspectRatioDenominator_InjectedDelegate(System.IntPtr _unity_self);

	private delegate VideoPixelFormat GetPixelFormat_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool CanNotSkipOnDrop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetSkipOnDrop_InjectedDelegate(System.IntPtr _unity_self, bool skipOnDrop);

	private delegate bool GetTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr texture, [Out] System.IntPtr outputFrameNum);

	private delegate float GetPlaybackSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetPlaybackSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool GetLoop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetLoop_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void SetAdjustToLinearSpace_InjectedDelegate(System.IntPtr _unity_self, bool enable);

	private delegate ushort GetAudioTrackCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ushort GetAudioChannelCount_InjectedDelegate(System.IntPtr _unity_self, ushort trackIdx);

	private delegate uint GetAudioSampleRate_InjectedDelegate(System.IntPtr _unity_self, ushort trackIdx);

	private delegate void GetAudioLanguageCode_InjectedDelegate(System.IntPtr _unity_self, ushort trackIdx, [Out] System.IntPtr ret);

	private delegate void SetAudioTarget_InjectedDelegate(System.IntPtr _unity_self, ushort trackIdx, bool enabled, bool softwareOutput, System.IntPtr audioSource);

	private delegate uint GetAudioSampleProviderId_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private static readonly PlatformSupportsH265Delegate PlatformSupportsH265DelegateField = IL2CPP.ResolveICall<PlatformSupportsH265Delegate>("UnityEngineInternal.Video.VideoPlayback::PlatformSupportsH265");

	private static readonly StartPlayback_InjectedDelegate StartPlayback_InjectedDelegateField = IL2CPP.ResolveICall<StartPlayback_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::StartPlayback_Injected");

	private static readonly PausePlayback_InjectedDelegate PausePlayback_InjectedDelegateField = IL2CPP.ResolveICall<PausePlayback_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::PausePlayback_Injected");

	private static readonly StopPlayback_InjectedDelegate StopPlayback_InjectedDelegateField = IL2CPP.ResolveICall<StopPlayback_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::StopPlayback_Injected");

	private static readonly GetStatus_InjectedDelegate GetStatus_InjectedDelegateField = IL2CPP.ResolveICall<GetStatus_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetStatus_Injected");

	private static readonly IsReady_InjectedDelegate IsReady_InjectedDelegateField = IL2CPP.ResolveICall<IsReady_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::IsReady_Injected");

	private static readonly IsPlaying_InjectedDelegate IsPlaying_InjectedDelegateField = IL2CPP.ResolveICall<IsPlaying_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::IsPlaying_Injected");

	private static readonly Step_InjectedDelegate Step_InjectedDelegateField = IL2CPP.ResolveICall<Step_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::Step_Injected");

	private static readonly CanStep_InjectedDelegate CanStep_InjectedDelegateField = IL2CPP.ResolveICall<CanStep_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::CanStep_Injected");

	private static readonly GetWidth_InjectedDelegate GetWidth_InjectedDelegateField = IL2CPP.ResolveICall<GetWidth_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetWidth_Injected");

	private static readonly GetHeight_InjectedDelegate GetHeight_InjectedDelegateField = IL2CPP.ResolveICall<GetHeight_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetHeight_Injected");

	private static readonly GetFrameRate_InjectedDelegate GetFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<GetFrameRate_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameRate_Injected");

	private static readonly GetDuration_InjectedDelegate GetDuration_InjectedDelegateField = IL2CPP.ResolveICall<GetDuration_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetDuration_Injected");

	private static readonly GetFrameCount_InjectedDelegate GetFrameCount_InjectedDelegateField = IL2CPP.ResolveICall<GetFrameCount_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetFrameCount_Injected");

	private static readonly GetPixelAspectRatioNumerator_InjectedDelegate GetPixelAspectRatioNumerator_InjectedDelegateField = IL2CPP.ResolveICall<GetPixelAspectRatioNumerator_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioNumerator_Injected");

	private static readonly GetPixelAspectRatioDenominator_InjectedDelegate GetPixelAspectRatioDenominator_InjectedDelegateField = IL2CPP.ResolveICall<GetPixelAspectRatioDenominator_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelAspectRatioDenominator_Injected");

	private static readonly GetPixelFormat_InjectedDelegate GetPixelFormat_InjectedDelegateField = IL2CPP.ResolveICall<GetPixelFormat_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPixelFormat_Injected");

	private static readonly CanNotSkipOnDrop_InjectedDelegate CanNotSkipOnDrop_InjectedDelegateField = IL2CPP.ResolveICall<CanNotSkipOnDrop_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::CanNotSkipOnDrop_Injected");

	private static readonly SetSkipOnDrop_InjectedDelegate SetSkipOnDrop_InjectedDelegateField = IL2CPP.ResolveICall<SetSkipOnDrop_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetSkipOnDrop_Injected");

	private static readonly GetTexture_InjectedDelegate GetTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetTexture_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetTexture_Injected");

	private static readonly GetPlaybackSpeed_InjectedDelegate GetPlaybackSpeed_InjectedDelegateField = IL2CPP.ResolveICall<GetPlaybackSpeed_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetPlaybackSpeed_Injected");

	private static readonly SetPlaybackSpeed_InjectedDelegate SetPlaybackSpeed_InjectedDelegateField = IL2CPP.ResolveICall<SetPlaybackSpeed_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetPlaybackSpeed_Injected");

	private static readonly GetLoop_InjectedDelegate GetLoop_InjectedDelegateField = IL2CPP.ResolveICall<GetLoop_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetLoop_Injected");

	private static readonly SetLoop_InjectedDelegate SetLoop_InjectedDelegateField = IL2CPP.ResolveICall<SetLoop_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetLoop_Injected");

	private static readonly SetAdjustToLinearSpace_InjectedDelegate SetAdjustToLinearSpace_InjectedDelegateField = IL2CPP.ResolveICall<SetAdjustToLinearSpace_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAdjustToLinearSpace_Injected");

	private static readonly GetAudioTrackCount_InjectedDelegate GetAudioTrackCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioTrackCount_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioTrackCount_Injected");

	private static readonly GetAudioChannelCount_InjectedDelegate GetAudioChannelCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioChannelCount_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioChannelCount_Injected");

	private static readonly GetAudioSampleRate_InjectedDelegate GetAudioSampleRate_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioSampleRate_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleRate_Injected");

	private static readonly GetAudioLanguageCode_InjectedDelegate GetAudioLanguageCode_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioLanguageCode_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioLanguageCode_Injected");

	private static readonly SetAudioTarget_InjectedDelegate SetAudioTarget_InjectedDelegateField = IL2CPP.ResolveICall<SetAudioTarget_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::SetAudioTarget_Injected");

	private static readonly GetAudioSampleProviderId_InjectedDelegate GetAudioSampleProviderId_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioSampleProviderId_InjectedDelegate>("UnityEngineInternal.Video.VideoPlayback::GetAudioSampleProviderId_Injected");

	public void StartPlayback()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		StartPlayback_Injected(intPtr);
	}

	public void PausePlayback()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		PausePlayback_Injected(intPtr);
	}

	public void StopPlayback()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		StopPlayback_Injected(intPtr);
	}

	public VideoError GetStatus()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetStatus_Injected(intPtr);
	}

	public bool IsReady()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return IsReady_Injected(intPtr);
	}

	public bool IsPlaying()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return IsPlaying_Injected(intPtr);
	}

	public void Step()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		Step_Injected(intPtr);
	}

	public bool CanStep()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return CanStep_Injected(intPtr);
	}

	public uint GetWidth()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetWidth_Injected(intPtr);
	}

	public uint GetHeight()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetHeight_Injected(intPtr);
	}

	public float GetFrameRate()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetFrameRate_Injected(intPtr);
	}

	public float GetDuration()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetDuration_Injected(intPtr);
	}

	public ulong GetFrameCount()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetFrameCount_Injected(intPtr);
	}

	public uint GetPixelAspectRatioNumerator()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetPixelAspectRatioNumerator_Injected(intPtr);
	}

	public uint GetPixelAspectRatioDenominator()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetPixelAspectRatioDenominator_Injected(intPtr);
	}

	public VideoPixelFormat GetPixelFormat()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetPixelFormat_Injected(intPtr);
	}

	public bool CanNotSkipOnDrop()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return CanNotSkipOnDrop_Injected(intPtr);
	}

	public void SetSkipOnDrop(bool skipOnDrop)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetSkipOnDrop_Injected(intPtr, skipOnDrop);
	}

	public bool GetTexture(Texture texture, out long outputFrameNum)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetTexture_Injected(intPtr, UnityEngine.Object.MarshalledUnityObject.Marshal(texture), out outputFrameNum);
	}

	public float GetPlaybackSpeed()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetPlaybackSpeed_Injected(intPtr);
	}

	public void SetPlaybackSpeed(float value)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetPlaybackSpeed_Injected(intPtr, value);
	}

	public bool GetLoop()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetLoop_Injected(intPtr);
	}

	public void SetLoop(bool value)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetLoop_Injected(intPtr, value);
	}

	public void SetAdjustToLinearSpace(bool enable)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetAdjustToLinearSpace_Injected(intPtr, enable);
	}

	public ushort GetAudioTrackCount()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetAudioTrackCount_Injected(intPtr);
	}

	public ushort GetAudioChannelCount(ushort trackIdx)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetAudioChannelCount_Injected(intPtr, trackIdx);
	}

	public uint GetAudioSampleRate(ushort trackIdx)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetAudioSampleRate_Injected(intPtr, trackIdx);
	}

	public string GetAudioLanguageCode(ushort trackIdx)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			GetAudioLanguageCode_Injected(intPtr, trackIdx, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public void SetAudioTarget(ushort trackIdx, bool enabled, bool softwareOutput, AudioSource audioSource)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetAudioTarget_Injected(intPtr, trackIdx, enabled, softwareOutput, UnityEngine.Object.MarshalledUnityObject.Marshal(audioSource));
	}

	public uint GetAudioSampleProviderId(ushort trackIndex)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetAudioSampleProviderId_Injected(intPtr, trackIndex);
	}

	public AudioSampleProvider GetAudioSampleProvider(ushort trackIndex)
	{
		if (trackIndex >= GetAudioTrackCount())
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("trackIndex", (Il2CppSystem.Object)(object)trackIndex, Il2CppSystem.String.Concat("VideoPlayback has ", GetAudioTrackCount().ToString(), " tracks."));
		}
		AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(GetAudioSampleProviderId(trackIndex), null, trackIndex);
		if (audioSampleProvider == null)
		{
			throw new Il2CppSystem.InvalidOperationException("VideoPlayback.GetAudioSampleProvider got null provider.");
		}
		if (audioSampleProvider.owner != null)
		{
			throw new Il2CppSystem.InvalidOperationException("Internal error: VideoPlayback.GetAudioSampleProvider got unexpected non-null provider owner.");
		}
		if (audioSampleProvider.trackIndex != trackIndex)
		{
			throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Concat("Internal error: VideoPlayback.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
		}
		return audioSampleProvider;
	}

	public static bool PlatformSupportsH265()
	{
		return PlatformSupportsH265DelegateField();
	}

	public static void StartPlayback_Injected(System.IntPtr _unity_self)
	{
		StartPlayback_InjectedDelegateField(_unity_self);
	}

	public static void PausePlayback_Injected(System.IntPtr _unity_self)
	{
		PausePlayback_InjectedDelegateField(_unity_self);
	}

	public static void StopPlayback_Injected(System.IntPtr _unity_self)
	{
		StopPlayback_InjectedDelegateField(_unity_self);
	}

	public static VideoError GetStatus_Injected(System.IntPtr _unity_self)
	{
		return GetStatus_InjectedDelegateField(_unity_self);
	}

	public static bool IsReady_Injected(System.IntPtr _unity_self)
	{
		return IsReady_InjectedDelegateField(_unity_self);
	}

	public static bool IsPlaying_Injected(System.IntPtr _unity_self)
	{
		return IsPlaying_InjectedDelegateField(_unity_self);
	}

	public static void Step_Injected(System.IntPtr _unity_self)
	{
		Step_InjectedDelegateField(_unity_self);
	}

	public static bool CanStep_Injected(System.IntPtr _unity_self)
	{
		return CanStep_InjectedDelegateField(_unity_self);
	}

	public static uint GetWidth_Injected(System.IntPtr _unity_self)
	{
		return GetWidth_InjectedDelegateField(_unity_self);
	}

	public static uint GetHeight_Injected(System.IntPtr _unity_self)
	{
		return GetHeight_InjectedDelegateField(_unity_self);
	}

	public static float GetFrameRate_Injected(System.IntPtr _unity_self)
	{
		return GetFrameRate_InjectedDelegateField(_unity_self);
	}

	public static float GetDuration_Injected(System.IntPtr _unity_self)
	{
		return GetDuration_InjectedDelegateField(_unity_self);
	}

	public static ulong GetFrameCount_Injected(System.IntPtr _unity_self)
	{
		return GetFrameCount_InjectedDelegateField(_unity_self);
	}

	public static uint GetPixelAspectRatioNumerator_Injected(System.IntPtr _unity_self)
	{
		return GetPixelAspectRatioNumerator_InjectedDelegateField(_unity_self);
	}

	public static uint GetPixelAspectRatioDenominator_Injected(System.IntPtr _unity_self)
	{
		return GetPixelAspectRatioDenominator_InjectedDelegateField(_unity_self);
	}

	public static VideoPixelFormat GetPixelFormat_Injected(System.IntPtr _unity_self)
	{
		return GetPixelFormat_InjectedDelegateField(_unity_self);
	}

	public static bool CanNotSkipOnDrop_Injected(System.IntPtr _unity_self)
	{
		return CanNotSkipOnDrop_InjectedDelegateField(_unity_self);
	}

	public static void SetSkipOnDrop_Injected(System.IntPtr _unity_self, bool skipOnDrop)
	{
		SetSkipOnDrop_InjectedDelegateField(_unity_self, skipOnDrop);
	}

	public unsafe static bool GetTexture_Injected(System.IntPtr _unity_self, System.IntPtr texture, out long outputFrameNum)
	{
		return GetTexture_InjectedDelegateField(_unity_self, texture, (nint)Unsafe.AsPointer(ref outputFrameNum));
	}

	public static float GetPlaybackSpeed_Injected(System.IntPtr _unity_self)
	{
		return GetPlaybackSpeed_InjectedDelegateField(_unity_self);
	}

	public static void SetPlaybackSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		SetPlaybackSpeed_InjectedDelegateField(_unity_self, value);
	}

	public static bool GetLoop_Injected(System.IntPtr _unity_self)
	{
		return GetLoop_InjectedDelegateField(_unity_self);
	}

	public static void SetLoop_Injected(System.IntPtr _unity_self, bool value)
	{
		SetLoop_InjectedDelegateField(_unity_self, value);
	}

	public static void SetAdjustToLinearSpace_Injected(System.IntPtr _unity_self, bool enable)
	{
		SetAdjustToLinearSpace_InjectedDelegateField(_unity_self, enable);
	}

	public static ushort GetAudioTrackCount_Injected(System.IntPtr _unity_self)
	{
		return GetAudioTrackCount_InjectedDelegateField(_unity_self);
	}

	public static ushort GetAudioChannelCount_Injected(System.IntPtr _unity_self, ushort trackIdx)
	{
		return GetAudioChannelCount_InjectedDelegateField(_unity_self, trackIdx);
	}

	public static uint GetAudioSampleRate_Injected(System.IntPtr _unity_self, ushort trackIdx)
	{
		return GetAudioSampleRate_InjectedDelegateField(_unity_self, trackIdx);
	}

	public unsafe static void GetAudioLanguageCode_Injected(System.IntPtr _unity_self, ushort trackIdx, out ManagedSpanWrapper ret)
	{
		GetAudioLanguageCode_InjectedDelegateField(_unity_self, trackIdx, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void SetAudioTarget_Injected(System.IntPtr _unity_self, ushort trackIdx, bool enabled, bool softwareOutput, System.IntPtr audioSource)
	{
		SetAudioTarget_InjectedDelegateField(_unity_self, trackIdx, enabled, softwareOutput, audioSource);
	}

	public static uint GetAudioSampleProviderId_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetAudioSampleProviderId_InjectedDelegateField(_unity_self, trackIndex);
	}
}
