using System;
using Il2CppSystem;

namespace UnityEngine;

public class SystemClock
{
	public static Il2CppSystem.DateTime now => Il2CppSystem.DateTime.Now;

	public static long ToUnixTimeMilliseconds(Il2CppSystem.DateTime date)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static long ToUnixTimeSeconds(Il2CppSystem.DateTime date)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
