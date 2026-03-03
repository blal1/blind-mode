using Il2CppInterop.Runtime;

namespace UnityEngine.Android;

public class AndroidDevice
{
	private delegate bool RunningOnChromeOSDelegate();

	private delegate void SetSustainedPerformanceModeDelegate(bool enabled);

	private static readonly RunningOnChromeOSDelegate RunningOnChromeOSDelegateField = IL2CPP.ResolveICall<RunningOnChromeOSDelegate>("UnityEngine.Android.AndroidDevice::RunningOnChromeOS");

	private static readonly SetSustainedPerformanceModeDelegate SetSustainedPerformanceModeDelegateField = IL2CPP.ResolveICall<SetSustainedPerformanceModeDelegate>("UnityEngine.Android.AndroidDevice::SetSustainedPerformanceMode");

	public static AndroidHardwareType hardwareType => RunningOnChromeOS() ? AndroidHardwareType.ChromeOS : AndroidHardwareType.Generic;

	public static bool RunningOnChromeOS()
	{
		return RunningOnChromeOSDelegateField();
	}

	public static void SetSustainedPerformanceMode(bool enabled)
	{
		SetSustainedPerformanceModeDelegateField(enabled);
	}
}
