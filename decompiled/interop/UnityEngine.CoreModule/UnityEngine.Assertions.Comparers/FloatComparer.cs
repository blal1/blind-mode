using System;
using Il2CppSystem;

namespace UnityEngine.Assertions.Comparers;

public class FloatComparer
{
	public const float kEpsilon = 1E-05f;

	public bool Equals(float a, float b)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetHashCode(float obj)
	{
		return ((Il2CppSystem.Object)this).GetHashCode();
	}

	public static bool AreEqual(float expected, float actual, float error)
	{
		return Il2CppSystem.Math.Abs(actual - expected) <= error;
	}

	public static bool AreEqualRelative(float expected, float actual, float error)
	{
		if (expected == actual)
		{
			return true;
		}
		float num = Il2CppSystem.Math.Abs(expected);
		float num2 = Il2CppSystem.Math.Abs(actual);
		float num3 = Il2CppSystem.Math.Abs((actual - expected) / ((num > num2) ? num : num2));
		return num3 <= error;
	}
}
