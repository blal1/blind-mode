using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace UnityEngine;

public sealed class Security
{
	public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData, string authorizationKey)
	{
		return null;
	}

	public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
	{
		return null;
	}

	public static bool PrefetchSocketPolicy(string ip, int atPort)
	{
		int timeout = 3000;
		return PrefetchSocketPolicy(ip, atPort, timeout);
	}

	public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout)
	{
		return false;
	}
}
