using System;

namespace JetBrains.Annotations;

public sealed class LocalizationRequiredAttribute : Attribute
{
	public bool Required
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
