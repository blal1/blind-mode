using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine;

public class UnityAPICompatibilityVersionAttribute : Attribute
{
	public string version
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStringArray configurationAssembliesHashes
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
