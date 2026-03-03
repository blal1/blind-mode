using System;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib;

public class BaselibException : Exception
{
	public Binding.Baselib_ErrorCode ErrorCode
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
