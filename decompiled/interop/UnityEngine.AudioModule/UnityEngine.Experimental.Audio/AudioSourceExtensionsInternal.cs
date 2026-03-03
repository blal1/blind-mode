using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Audio;

public static class AudioSourceExtensionsInternal
{
	private delegate void Internal_RegisterSampleProviderWithAudioSource_InjectedDelegate(IntPtr source, uint providerId);

	private delegate void Internal_UnregisterSampleProviderFromAudioSource_InjectedDelegate(IntPtr source, uint providerId);

	private static readonly Internal_RegisterSampleProviderWithAudioSource_InjectedDelegate Internal_RegisterSampleProviderWithAudioSource_InjectedDelegateField = IL2CPP.ResolveICall<Internal_RegisterSampleProviderWithAudioSource_InjectedDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_RegisterSampleProviderWithAudioSource_Injected");

	private static readonly Internal_UnregisterSampleProviderFromAudioSource_InjectedDelegate Internal_UnregisterSampleProviderFromAudioSource_InjectedDelegateField = IL2CPP.ResolveICall<Internal_UnregisterSampleProviderFromAudioSource_InjectedDelegate>("UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal::Internal_UnregisterSampleProviderFromAudioSource_Injected");

	public static void RegisterSampleProvider(AudioSource source, AudioSampleProvider provider)
	{
		Internal_RegisterSampleProviderWithAudioSource(source, provider.id);
	}

	public static void UnregisterSampleProvider(AudioSource source, AudioSampleProvider provider)
	{
		Internal_UnregisterSampleProviderFromAudioSource(source, provider.id);
	}

	public static void Internal_RegisterSampleProviderWithAudioSource(AudioSource source, uint providerId)
	{
		if ((object)source == null)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(source);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		Internal_RegisterSampleProviderWithAudioSource_Injected(intPtr, providerId);
	}

	public static void Internal_UnregisterSampleProviderFromAudioSource(AudioSource source, uint providerId)
	{
		if ((object)source == null)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(source);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		Internal_UnregisterSampleProviderFromAudioSource_Injected(intPtr, providerId);
	}

	public static void Internal_RegisterSampleProviderWithAudioSource_Injected(IntPtr source, uint providerId)
	{
		Internal_RegisterSampleProviderWithAudioSource_InjectedDelegateField(source, providerId);
	}

	public static void Internal_UnregisterSampleProviderFromAudioSource_Injected(IntPtr source, uint providerId)
	{
		Internal_UnregisterSampleProviderFromAudioSource_InjectedDelegateField(source, providerId);
	}
}
