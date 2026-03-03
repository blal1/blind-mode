using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android;

public class DownloadAssetPackAsyncOperation : CustomYieldInstruction
{
	[Serializable]
	public sealed class _003C_003Ec
	{
	}

	public override bool keepWaiting
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool isDone => !keepWaiting;

	public float progress
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStringArray downloadedAssetPacks
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStringArray downloadFailedAssetPacks
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void OnUpdate(AndroidAssetPackInfo info)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
