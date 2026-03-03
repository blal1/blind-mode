using System;

namespace JetBrains.Annotations;

public sealed class PathReferenceAttribute : Attribute
{
	public string BasePath
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
