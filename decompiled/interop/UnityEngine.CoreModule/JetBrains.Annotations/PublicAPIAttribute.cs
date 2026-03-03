using System;

namespace JetBrains.Annotations;

public sealed class PublicAPIAttribute : Attribute
{
	public string Comment
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
