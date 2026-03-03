using System;

namespace UnityEngine.Android;

public class AndroidAssetPackInfo
{
	public string name
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public AndroidAssetPackStatus status
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public ulong size
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public ulong bytesDownloaded
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float transferProgress
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public AndroidAssetPackError error
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool downloadInProgress => DownloadInProgress(status);

	public static bool DownloadInProgress(AndroidAssetPackStatus status)
	{
		return status != AndroidAssetPackStatus.Canceled && status != AndroidAssetPackStatus.Completed && status != AndroidAssetPackStatus.Failed && status != AndroidAssetPackStatus.Unknown;
	}
}
