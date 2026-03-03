using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Audio;

public static class AudioClipExtensionsInternal
{
	private delegate uint Internal_CreateAudioClipSampleProvider_InjectedDelegate(IntPtr audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart);

	private static readonly Internal_CreateAudioClipSampleProvider_InjectedDelegate Internal_CreateAudioClipSampleProvider_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CreateAudioClipSampleProvider_InjectedDelegate>("UnityEngine.Experimental.Audio.AudioClipExtensionsInternal::Internal_CreateAudioClipSampleProvider_Injected");

	public static uint Internal_CreateAudioClipSampleProvider(AudioClip audioClip, ulong start, long end, bool loop, bool allowDrop, [Optional] bool loopPointIsStart)
	{
		if ((object)audioClip == null)
		{
			ThrowHelper.ThrowArgumentNullException(audioClip, "audioClip");
		}
		IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(audioClip);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowArgumentNullException(audioClip, "audioClip");
		}
		return Internal_CreateAudioClipSampleProvider_Injected(intPtr, start, end, loop, allowDrop, loopPointIsStart);
	}

	public static uint Internal_CreateAudioClipSampleProvider_Injected(IntPtr audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart)
	{
		return Internal_CreateAudioClipSampleProvider_InjectedDelegateField(audioClip, start, end, loop, allowDrop, loopPointIsStart);
	}
}
