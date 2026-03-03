using System;

namespace JetBrains.Annotations;

public sealed class StringFormatMethodAttribute : Attribute
{
	public string FormatParameterName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
