using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Audio;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video;

public static class VideoPlayerExtensions
{
	private delegate uint InternalGetAudioSampleProviderId_InjectedDelegate(System.IntPtr vp, ushort trackIndex);

	private static readonly InternalGetAudioSampleProviderId_InjectedDelegate InternalGetAudioSampleProviderId_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetAudioSampleProviderId_InjectedDelegate>("UnityEngine.Experimental.Video.VideoPlayerExtensions::InternalGetAudioSampleProviderId_Injected");

	public static AudioSampleProvider GetAudioSampleProvider(VideoPlayer vp, ushort trackIndex)
	{
		ushort controlledAudioTrackCount = vp.controlledAudioTrackCount;
		if (trackIndex >= controlledAudioTrackCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("trackIndex", (Il2CppSystem.Object)(object)trackIndex, Il2CppSystem.String.Concat("VideoPlayer is currently configured with ", controlledAudioTrackCount.ToString(), " tracks."));
		}
		VideoAudioOutputMode audioOutputMode = vp.audioOutputMode;
		if (audioOutputMode != VideoAudioOutputMode.APIOnly)
		{
			throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Concat("VideoPlayer.GetAudioSampleProvider requires audioOutputMode to be APIOnly. Current: ", ((Il2CppSystem.Object)audioOutputMode).ToString()));
		}
		AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(InternalGetAudioSampleProviderId(vp, trackIndex), vp, trackIndex);
		if (audioSampleProvider == null)
		{
			throw new Il2CppSystem.InvalidOperationException("VideoPlayer.GetAudioSampleProvider got null provider.");
		}
		if (audioSampleProvider.owner != vp)
		{
			throw new Il2CppSystem.InvalidOperationException("Internal error: VideoPlayer.GetAudioSampleProvider got provider used by another object.");
		}
		if (audioSampleProvider.trackIndex != trackIndex)
		{
			throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Concat("Internal error: VideoPlayer.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
		}
		return audioSampleProvider;
	}

	public static uint InternalGetAudioSampleProviderId(VideoPlayer vp, ushort trackIndex)
	{
		if ((object)vp == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(vp, "vp");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(vp);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(vp, "vp");
		}
		return InternalGetAudioSampleProviderId_Injected(intPtr, trackIndex);
	}

	public static uint InternalGetAudioSampleProviderId_Injected(System.IntPtr vp, ushort trackIndex)
	{
		return InternalGetAudioSampleProviderId_InjectedDelegateField(vp, trackIndex);
	}
}
