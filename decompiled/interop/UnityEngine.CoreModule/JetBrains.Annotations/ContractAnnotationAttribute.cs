using System;

namespace JetBrains.Annotations;

public sealed class ContractAnnotationAttribute : Attribute
{
	public string Contract
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool ForceFullStates
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
