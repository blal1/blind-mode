using System;
using Il2CppSystem;

namespace UnityEngine.XR;

public static class TimeConverter
{
	public static Il2CppSystem.DateTime now => Il2CppSystem.DateTime.Now;

	public static long LocalDateTimeToUnixTimeMilliseconds(Il2CppSystem.DateTime date)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppSystem.DateTime UnixTimeMillisecondsToLocalDateTime(long unixTimeInMilliseconds)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
