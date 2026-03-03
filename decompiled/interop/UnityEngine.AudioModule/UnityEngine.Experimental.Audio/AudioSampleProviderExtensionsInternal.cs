using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Audio;

public static class AudioSampleProviderExtensionsInternal
{
	private delegate float InternalGetAudioSampleProviderSpeedDelegate(uint providerId);

	private static readonly InternalGetAudioSampleProviderSpeedDelegate InternalGetAudioSampleProviderSpeedDelegateField = IL2CPP.ResolveICall<InternalGetAudioSampleProviderSpeedDelegate>("UnityEngine.Experimental.Audio.AudioSampleProviderExtensionsInternal::InternalGetAudioSampleProviderSpeed");

	public static float GetSpeed(AudioSampleProvider provider)
	{
		return InternalGetAudioSampleProviderSpeed(provider.id);
	}

	public static float InternalGetAudioSampleProviderSpeed(uint providerId)
	{
		return InternalGetAudioSampleProviderSpeedDelegateField(providerId);
	}
}
