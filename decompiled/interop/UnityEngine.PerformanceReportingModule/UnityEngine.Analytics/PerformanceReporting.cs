using Il2CppInterop.Runtime;

namespace UnityEngine.Analytics;

public static class PerformanceReporting
{
	private delegate bool get_enabledDelegate();

	private delegate void set_enabledDelegate(bool value);

	private delegate long get_graphicsInitializationFinishTimeDelegate();

	private static readonly get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.Analytics.PerformanceReporting::get_enabled");

	private static readonly set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.Analytics.PerformanceReporting::set_enabled");

	private static readonly get_graphicsInitializationFinishTimeDelegate get_graphicsInitializationFinishTimeDelegateField = IL2CPP.ResolveICall<get_graphicsInitializationFinishTimeDelegate>("UnityEngine.Analytics.PerformanceReporting::get_graphicsInitializationFinishTime");

	public static bool enabled
	{
		get
		{
			return get_enabledDelegateField();
		}
		set
		{
			set_enabledDelegateField(value);
		}
	}

	public static long graphicsInitializationFinishTime => get_graphicsInitializationFinishTimeDelegateField();
}
