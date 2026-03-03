using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs;

public static class JobValidationInternal
{
	public static void CheckReflectionDataCorrect<T>(System.IntPtr reflectionData)
	{
	}

	public static void CheckReflectionDataCorrectInternal<T>(System.IntPtr reflectionData, ref bool burstCompiled)
	{
		if (reflectionData == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.InvalidOperationException(Il2CppSystem.String.Format("Reflection data was not set up by an Initialize() call. Support for burst compiled calls to Schedule depends on the Collections package.\n\nFor generic job types, please include [assembly: RegisterGenericJobType(typeof({0}))] in your source file.", (Il2CppSystem.Object)Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}
		burstCompiled = false;
	}
}
