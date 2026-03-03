using System.Runtime.InteropServices;

namespace UnityEngine.Networking;

public static class UnityWebRequestAssetBundle
{
	public static UnityWebRequest GetAssetBundle(string uri)
	{
		return GetAssetBundle(uri, 0u);
	}

	public static UnityWebRequest GetAssetBundle(string uri, uint crc)
	{
		return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, crc), null);
	}

	public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
	{
		return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, version, crc), null);
	}

	public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, [Optional] uint crc)
	{
		return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, hash, crc), null);
	}
}
