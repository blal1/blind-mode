using System;

namespace UnityEngine;

public class IconAttribute : Attribute
{
	public string path
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
