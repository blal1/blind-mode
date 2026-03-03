using System;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.Networking;

namespace UnityEngine;

public class WWW : CustomYieldInstruction
{
	public AssetBundle assetBundle
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Object audioClip => null;

	public Il2CppStructArray<byte> bytes
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int size => bytesDownloaded;

	public int bytesDownloaded
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string error
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool isDone
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float progress
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Dictionary<string, string> responseHeaders
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string data => text;

	public string text
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Texture2D texture => CreateTextureFromDownloadedData(markNonReadable: false);

	public Texture2D textureNonReadable => CreateTextureFromDownloadedData(markNonReadable: true);

	public ThreadPriority threadPriority
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float uploadProgress
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string url
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public override bool keepWaiting
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public static string EscapeURL(string s)
	{
		return EscapeURL(s, Encoding.UTF8);
	}

	public static string EscapeURL(string s, Encoding e)
	{
		return UnityWebRequest.EscapeURL(s, e);
	}

	public static string UnEscapeURL(string s)
	{
		return UnEscapeURL(s, Encoding.UTF8);
	}

	public static string UnEscapeURL(string s, Encoding e)
	{
		return UnityWebRequest.UnEscapeURL(s, e);
	}

	public static WWW LoadFromCacheOrDownload(string url, int version)
	{
		return LoadFromCacheOrDownload(url, version, 0u);
	}

	public static WWW LoadFromCacheOrDownload(string url, int version, uint crc)
	{
		Hash128 hash = new Hash128(0u, 0u, 0u, (uint)version);
		return LoadFromCacheOrDownload(url, hash, crc);
	}

	public static WWW LoadFromCacheOrDownload(string url, Hash128 hash)
	{
		return LoadFromCacheOrDownload(url, hash, 0u);
	}

	public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc)
	{
		return new WWW(url, "", hash, crc);
	}

	public Texture2D CreateTextureFromDownloadedData(bool markNonReadable)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void LoadImageIntoTexture(Texture2D texture)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void Dispose()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public AudioClip GetAudioClip()
	{
		return GetAudioClip(threeD: true, stream: false, AudioType.UNKNOWN);
	}

	public AudioClip GetAudioClip(bool threeD)
	{
		return GetAudioClip(threeD, stream: false, AudioType.UNKNOWN);
	}

	public AudioClip GetAudioClip(bool threeD, bool stream)
	{
		return GetAudioClip(threeD, stream, AudioType.UNKNOWN);
	}

	public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType)
	{
		return ((Il2CppObjectBase)GetAudioClipInternal(threeD, stream, compressed: false, audioType)).Cast<AudioClip>();
	}

	public AudioClip GetAudioClipCompressed()
	{
		return GetAudioClipCompressed(threeD: false, AudioType.UNKNOWN);
	}

	public AudioClip GetAudioClipCompressed(bool threeD)
	{
		return GetAudioClipCompressed(threeD, AudioType.UNKNOWN);
	}

	public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType)
	{
		return ((Il2CppObjectBase)GetAudioClipInternal(threeD, stream: false, compressed: true, audioType)).Cast<AudioClip>();
	}

	public bool WaitUntilDoneIfPossible()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}
}
