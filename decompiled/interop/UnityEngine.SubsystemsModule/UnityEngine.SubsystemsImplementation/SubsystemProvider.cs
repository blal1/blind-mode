using System;

namespace UnityEngine.SubsystemsImplementation;

public abstract class SubsystemProvider
{
	public bool running
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
