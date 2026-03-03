using System;

namespace JetBrains.Annotations;

public sealed class AssertionConditionAttribute : Attribute
{
	public AssertionConditionType ConditionType
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
