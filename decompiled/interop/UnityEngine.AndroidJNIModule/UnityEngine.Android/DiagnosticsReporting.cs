using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Android;

public static class DiagnosticsReporting
{
	public static void CallReportFullyDrawn()
	{
		AndroidApplication.currentActivity.Call("reportFullyDrawn", (Il2CppReferenceArray<Il2CppSystem.Object>)(object)Array.Empty<Il2CppSystem.Object>());
	}
}
