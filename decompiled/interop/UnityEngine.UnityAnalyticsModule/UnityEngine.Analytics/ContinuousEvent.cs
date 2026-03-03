using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics;

public class ContinuousEvent : Il2CppSystem.Object
{
	private delegate AnalyticsResult InternalRegisterCollector_InjectedDelegate(System.IntPtr type, System.IntPtr metricName, System.IntPtr collector);

	private delegate AnalyticsResult InternalSetEventHistogramThresholds_InjectedDelegate(System.IntPtr type, System.IntPtr eventName, int count, System.IntPtr data, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult InternalSetCustomEventHistogramThresholds_InjectedDelegate(System.IntPtr type, System.IntPtr eventName, int count, System.IntPtr data);

	private delegate AnalyticsResult InternalConfigureCustomEvent_InjectedDelegate(System.IntPtr customEventName, System.IntPtr metricName, float interval, float period, bool enabled);

	private delegate AnalyticsResult InternalConfigureEvent_InjectedDelegate(System.IntPtr eventName, System.IntPtr metricName, float interval, float period, bool enabled, int ver, System.IntPtr prefix);

	private static readonly InternalRegisterCollector_InjectedDelegate InternalRegisterCollector_InjectedDelegateField;

	private static readonly InternalSetEventHistogramThresholds_InjectedDelegate InternalSetEventHistogramThresholds_InjectedDelegateField;

	private static readonly InternalSetCustomEventHistogramThresholds_InjectedDelegate InternalSetCustomEventHistogramThresholds_InjectedDelegateField;

	private static readonly InternalConfigureCustomEvent_InjectedDelegate InternalConfigureCustomEvent_InjectedDelegateField;

	private static readonly InternalConfigureEvent_InjectedDelegate InternalConfigureEvent_InjectedDelegateField;

	static ContinuousEvent()
	{
		Il2CppClassPointerStore<ContinuousEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "ContinuousEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuousEvent>.NativeClassPtr);
		InternalRegisterCollector_InjectedDelegateField = IL2CPP.ResolveICall<InternalRegisterCollector_InjectedDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalRegisterCollector_Injected");
		InternalSetEventHistogramThresholds_InjectedDelegateField = IL2CPP.ResolveICall<InternalSetEventHistogramThresholds_InjectedDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalSetEventHistogramThresholds_Injected");
		InternalSetCustomEventHistogramThresholds_InjectedDelegateField = IL2CPP.ResolveICall<InternalSetCustomEventHistogramThresholds_InjectedDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalSetCustomEventHistogramThresholds_Injected");
		InternalConfigureCustomEvent_InjectedDelegateField = IL2CPP.ResolveICall<InternalConfigureCustomEvent_InjectedDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalConfigureCustomEvent_Injected");
		InternalConfigureEvent_InjectedDelegateField = IL2CPP.ResolveICall<InternalConfigureEvent_InjectedDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalConfigureEvent_Injected");
	}

	public ContinuousEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static AnalyticsResult RegisterCollector<T>(string metricName, Il2CppSystem.Func<T> del) where T : struct, Il2CppSystem.IComparable<T>, Il2CppSystem.IEquatable<T>
	{
		if (Il2CppSystem.String.IsNullOrEmpty(metricName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set metric name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return InternalRegisterCollector(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), metricName, del);
	}

	public static AnalyticsResult SetEventHistogramThresholds<T>(string eventName, int count, Il2CppArrayBase<T> data, [Optional] int ver, [Optional] string prefix) where T : struct, Il2CppSystem.IComparable<T>, Il2CppSystem.IEquatable<T>
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return InternalSetEventHistogramThresholds(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), eventName, count, (Il2CppSystem.Object)(object)data, ver, prefix);
	}

	public static AnalyticsResult SetCustomEventHistogramThresholds<T>(string eventName, int count, Il2CppArrayBase<T> data) where T : struct, Il2CppSystem.IComparable<T>, Il2CppSystem.IEquatable<T>
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return InternalSetCustomEventHistogramThresholds(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), eventName, count, (Il2CppSystem.Object)(object)data);
	}

	public static AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, [Optional] bool enabled)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return InternalConfigureCustomEvent(customEventName, metricName, interval, period, enabled);
	}

	public static AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, [Optional] bool enabled, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return InternalConfigureEvent(eventName, metricName, interval, period, enabled, ver, prefix);
	}

	public unsafe static AnalyticsResult InternalRegisterCollector(string type, string metricName, Il2CppSystem.Object collector)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper type2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(type, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(type);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					type2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return InternalRegisterCollector_Injected(ref type2, ref managedSpanWrapper2, collector);
						}
					}
					return InternalRegisterCollector_Injected(ref type2, ref managedSpanWrapper2, collector);
				}
			}
			type2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return InternalRegisterCollector_Injected(ref type2, ref managedSpanWrapper2, collector);
				}
			}
			return InternalRegisterCollector_Injected(ref type2, ref managedSpanWrapper2, collector);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult InternalSetEventHistogramThresholds(string type, string eventName, int count, Il2CppSystem.Object data, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//IL_0079: Expected O, but got Ref
		//IL_0087: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057, IL_0069, IL_0079, IL_0087, IL_008c are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_0069, IL_0079, IL_0087, IL_008c are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_0069, IL_0079, IL_0087, IL_008c are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper type2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper eventName2;
			int count2;
			Il2CppSystem.Object data2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(type, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(type);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					type2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							eventName2 = ref managedSpanWrapper2;
							count2 = count;
							data2 = data;
							ver2 = ver;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
								}
							}
							return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
						}
					}
					eventName2 = ref managedSpanWrapper2;
					count2 = count;
					data2 = data;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
						}
					}
					return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
				}
			}
			type2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					eventName2 = ref managedSpanWrapper2;
					count2 = count;
					data2 = data;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
						}
					}
					return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
				}
			}
			eventName2 = ref managedSpanWrapper2;
			count2 = count;
			data2 = data;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
				}
			}
			return InternalSetEventHistogramThresholds_Injected(ref type2, ref eventName2, count2, data2, ver2, ref managedSpanWrapper3);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult InternalSetCustomEventHistogramThresholds(string type, string eventName, int count, Il2CppSystem.Object data)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper type2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(type, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(type);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					type2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return InternalSetCustomEventHistogramThresholds_Injected(ref type2, ref managedSpanWrapper2, count, data);
						}
					}
					return InternalSetCustomEventHistogramThresholds_Injected(ref type2, ref managedSpanWrapper2, count, data);
				}
			}
			type2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return InternalSetCustomEventHistogramThresholds_Injected(ref type2, ref managedSpanWrapper2, count, data);
				}
			}
			return InternalSetCustomEventHistogramThresholds_Injected(ref type2, ref managedSpanWrapper2, count, data);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult InternalConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper customEventName2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(customEventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(customEventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					customEventName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return InternalConfigureCustomEvent_Injected(ref customEventName2, ref managedSpanWrapper2, interval, period, enabled);
						}
					}
					return InternalConfigureCustomEvent_Injected(ref customEventName2, ref managedSpanWrapper2, interval, period, enabled);
				}
			}
			customEventName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return InternalConfigureCustomEvent_Injected(ref customEventName2, ref managedSpanWrapper2, interval, period, enabled);
				}
			}
			return InternalConfigureCustomEvent_Injected(ref customEventName2, ref managedSpanWrapper2, interval, period, enabled);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult InternalConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//IL_007b: Expected O, but got Ref
		//IL_0089: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057, IL_006b, IL_007b, IL_0089, IL_008e are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_006b, IL_007b, IL_0089, IL_008e are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008e are reachable both inside and outside the pinned region starting at IL_007b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008e are reachable both inside and outside the pinned region starting at IL_007b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_006b, IL_007b, IL_0089, IL_008e are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008e are reachable both inside and outside the pinned region starting at IL_007b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008e are reachable both inside and outside the pinned region starting at IL_007b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper metricName2;
			float interval2;
			float period2;
			bool enabled2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							metricName2 = ref managedSpanWrapper2;
							interval2 = interval;
							period2 = period;
							enabled2 = enabled;
							ver2 = ver;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
								}
							}
							return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
						}
					}
					metricName2 = ref managedSpanWrapper2;
					interval2 = interval;
					period2 = period;
					enabled2 = enabled;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
						}
					}
					return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
				}
			}
			eventName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(metricName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(metricName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					metricName2 = ref managedSpanWrapper2;
					interval2 = interval;
					period2 = period;
					enabled2 = enabled;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
						}
					}
					return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
				}
			}
			metricName2 = ref managedSpanWrapper2;
			interval2 = interval;
			period2 = period;
			enabled2 = enabled;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
				}
			}
			return InternalConfigureEvent_Injected(ref eventName2, ref metricName2, interval2, period2, enabled2, ver2, ref managedSpanWrapper3);
		}
		finally
		{
		}
	}

	public static bool IsInitialized()
	{
		return Analytics.IsInitialized();
	}

	public unsafe static AnalyticsResult InternalRegisterCollector_Injected(ref ManagedSpanWrapper type, ref ManagedSpanWrapper metricName, Il2CppSystem.Object collector)
	{
		return InternalRegisterCollector_InjectedDelegateField((nint)Unsafe.AsPointer(ref type), (nint)Unsafe.AsPointer(ref metricName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collector));
	}

	public unsafe static AnalyticsResult InternalSetEventHistogramThresholds_Injected(ref ManagedSpanWrapper type, ref ManagedSpanWrapper eventName, int count, Il2CppSystem.Object data, int ver, ref ManagedSpanWrapper prefix)
	{
		return InternalSetEventHistogramThresholds_InjectedDelegateField((nint)Unsafe.AsPointer(ref type), (nint)Unsafe.AsPointer(ref eventName), count, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult InternalSetCustomEventHistogramThresholds_Injected(ref ManagedSpanWrapper type, ref ManagedSpanWrapper eventName, int count, Il2CppSystem.Object data)
	{
		return InternalSetCustomEventHistogramThresholds_InjectedDelegateField((nint)Unsafe.AsPointer(ref type), (nint)Unsafe.AsPointer(ref eventName), count, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data));
	}

	public unsafe static AnalyticsResult InternalConfigureCustomEvent_Injected(ref ManagedSpanWrapper customEventName, ref ManagedSpanWrapper metricName, float interval, float period, bool enabled)
	{
		return InternalConfigureCustomEvent_InjectedDelegateField((nint)Unsafe.AsPointer(ref customEventName), (nint)Unsafe.AsPointer(ref metricName), interval, period, enabled);
	}

	public unsafe static AnalyticsResult InternalConfigureEvent_Injected(ref ManagedSpanWrapper eventName, ref ManagedSpanWrapper metricName, float interval, float period, bool enabled, int ver, ref ManagedSpanWrapper prefix)
	{
		return InternalConfigureEvent_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), (nint)Unsafe.AsPointer(ref metricName), interval, period, enabled, ver, (nint)Unsafe.AsPointer(ref prefix));
	}
}
