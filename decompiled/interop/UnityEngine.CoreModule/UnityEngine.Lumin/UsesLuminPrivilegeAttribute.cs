using System;

namespace UnityEngine.Lumin;

public sealed class UsesLuminPrivilegeAttribute : Attribute
{
	public string privilege
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
