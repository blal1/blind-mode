using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android;

public class GetAssetPackStateAsyncOperation : CustomYieldInstruction
{
	public override bool keepWaiting
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool isDone => !keepWaiting;

	public ulong size
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppReferenceArray<AndroidAssetPackState> states
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void OnResult(ulong size, Il2CppReferenceArray<AndroidAssetPackState> states)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
