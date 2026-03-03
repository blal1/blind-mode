using System;

namespace JetBrains.Annotations;

public sealed class ValueProviderAttribute : Attribute
{
	public string Name
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
