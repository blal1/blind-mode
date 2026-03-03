using System;

namespace JetBrains.Annotations;

public sealed class UsedImplicitlyAttribute : Attribute
{
	public ImplicitUseKindFlags UseKindFlags
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public ImplicitUseTargetFlags TargetFlags
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
