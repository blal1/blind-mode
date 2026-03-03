using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android;

public static class ApplicationExitInfoProvider
{
	public static Il2CppReferenceArray<IApplicationExitInfo> GetHistoricalProcessExitInfo([Optional] string packageName, [Optional] int pid, [Optional] int maxNum)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void SetProcessStateSummary(Il2CppStructArray<sbyte> buffer)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
