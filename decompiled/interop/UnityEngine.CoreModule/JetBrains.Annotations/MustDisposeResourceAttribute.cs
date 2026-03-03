using System;

namespace JetBrains.Annotations;

public sealed class MustDisposeResourceAttribute : Attribute
{
	public bool Value
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
