namespace UnityEngine;

public static class WWWAudioExtensions
{
	public static AudioClip GetAudioClip(WWW www)
	{
		return www.GetAudioClip();
	}

	public static AudioClip GetAudioClip(WWW www, bool threeD)
	{
		return www.GetAudioClip(threeD);
	}

	public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream)
	{
		return www.GetAudioClip(threeD, stream);
	}

	public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream, AudioType audioType)
	{
		return www.GetAudioClip(threeD, stream, audioType);
	}

	public static AudioClip GetAudioClipCompressed(WWW www)
	{
		return www.GetAudioClipCompressed();
	}

	public static AudioClip GetAudioClipCompressed(WWW www, bool threeD)
	{
		return www.GetAudioClipCompressed(threeD);
	}

	public static AudioClip GetAudioClipCompressed(WWW www, bool threeD, AudioType audioType)
	{
		return www.GetAudioClipCompressed(threeD, audioType);
	}
}
