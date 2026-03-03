using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.SearchService;

public class ObjectSelectorHandlerWithLabelsAttribute : Attribute
{
	public Il2CppStringArray labels
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool matchAll
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
