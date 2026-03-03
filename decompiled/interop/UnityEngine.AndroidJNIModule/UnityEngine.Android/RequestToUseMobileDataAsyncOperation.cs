using System;

namespace UnityEngine.Android;

public class RequestToUseMobileDataAsyncOperation : CustomYieldInstruction
{
	public override bool keepWaiting
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool isDone => !keepWaiting;

	public AndroidAssetPackUseMobileDataRequestResult result
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void OnResult(AndroidAssetPackUseMobileDataRequestResult result)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
