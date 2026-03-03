using System;

namespace UnityEngine.Lumin;

public sealed class UsesLuminPlatformLevelAttribute : Attribute
{
	public uint platformLevel
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
