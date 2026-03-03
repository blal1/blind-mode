using Il2CppInterop.Runtime;

namespace UnityEngine.Analytics;

public static class AnalyticsCommon
{
	private delegate bool get_ugsAnalyticsEnabledInternalDelegate();

	private delegate void set_ugsAnalyticsEnabledInternalDelegate(bool value);

	private static readonly get_ugsAnalyticsEnabledInternalDelegate get_ugsAnalyticsEnabledInternalDelegateField = IL2CPP.ResolveICall<get_ugsAnalyticsEnabledInternalDelegate>("UnityEngine.Analytics.AnalyticsCommon::get_ugsAnalyticsEnabledInternal");

	private static readonly set_ugsAnalyticsEnabledInternalDelegate set_ugsAnalyticsEnabledInternalDelegateField = IL2CPP.ResolveICall<set_ugsAnalyticsEnabledInternalDelegate>("UnityEngine.Analytics.AnalyticsCommon::set_ugsAnalyticsEnabledInternal");

	public static bool ugsAnalyticsEnabledInternal
	{
		get
		{
			return get_ugsAnalyticsEnabledInternalDelegateField();
		}
		set
		{
			set_ugsAnalyticsEnabledInternalDelegateField(value);
		}
	}

	public static bool ugsAnalyticsEnabled
	{
		get
		{
			return ugsAnalyticsEnabledInternal;
		}
		set
		{
			ugsAnalyticsEnabledInternal = value;
		}
	}
}
