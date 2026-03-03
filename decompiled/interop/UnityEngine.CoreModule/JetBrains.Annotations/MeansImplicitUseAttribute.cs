using System;

namespace JetBrains.Annotations;

public sealed class MeansImplicitUseAttribute : Attribute
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
