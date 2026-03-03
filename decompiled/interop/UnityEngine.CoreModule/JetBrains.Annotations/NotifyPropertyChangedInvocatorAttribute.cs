using System;

namespace JetBrains.Annotations;

public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
{
	public string ParameterName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
