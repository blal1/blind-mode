using System;

namespace UnityEngine;

[Serializable]
public class MissingComponentException : Exception
{
	public const int Result = -2147467261;
}
