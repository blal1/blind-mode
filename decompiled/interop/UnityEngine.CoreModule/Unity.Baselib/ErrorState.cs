using System;
using System.Runtime.InteropServices;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib;

public struct ErrorState
{
	public Binding.Baselib_ErrorCode ErrorCode
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void ThrowIfFailed()
	{
		if (ErrorCode != 0)
		{
			throw new BaselibException(this);
		}
	}

	public string Explain([Optional] Binding.Baselib_ErrorState_ExplainVerbosity verbosity)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
