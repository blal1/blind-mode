using System;

namespace UnityEngine;

public class CustomGridBrushAttribute : Attribute
{
	public bool hideAssetInstances
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool hideDefaultInstance
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool defaultBrush
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string defaultName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
