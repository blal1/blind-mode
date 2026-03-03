using System;

namespace JetBrains.Annotations;

public sealed class MacroAttribute : Attribute
{
	public string Expression
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int Editable
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string Target
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
