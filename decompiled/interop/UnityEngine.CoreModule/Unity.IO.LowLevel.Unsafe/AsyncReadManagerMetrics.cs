using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe;

public static class AsyncReadManagerMetrics
{
	public enum Flags
	{
		None,
		ClearOnRead
	}

	private delegate bool IsEnabledDelegate();

	private delegate void ClearMetrics_InternalDelegate();

	private delegate IntPtr GetMetrics_InternalDelegate(bool clear);

	private delegate IntPtr GetMetrics_Filtered_InternalDelegate(IntPtr filters, bool clear);

	private delegate void StartCollectingMetricsDelegate();

	private delegate void StopCollectingMetricsDelegate();

	private delegate IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

	private delegate IntPtr GetSummaryMetricsWithFilters_InternalDelegate(IntPtr metricsFilters, bool clear);

	private delegate IntPtr GetSummaryOfMetrics_InternalDelegate(IntPtr metrics);

	private delegate IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(IntPtr metrics);

	private delegate IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

	private delegate IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

	private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);

	private delegate void GetMetrics_NoAlloc_Internal_InjectedDelegate(IntPtr metrics, bool clear);

	private delegate void GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate(IntPtr metrics, IntPtr filters, bool clear);

	private static readonly IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");

	private static readonly ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");

	private static readonly GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");

	private static readonly GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");

	private static readonly StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");

	private static readonly StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");

	private static readonly GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");

	private static readonly GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");

	private static readonly GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");

	private static readonly GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");

	private static readonly GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");

	private static readonly GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");

	private static readonly GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");

	private static readonly GetMetrics_NoAlloc_Internal_InjectedDelegate GetMetrics_NoAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetMetrics_NoAlloc_Internal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal_Injected");

	private static readonly GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal_Injected");

	public static bool IsEnabled()
	{
		return IsEnabledDelegateField();
	}

	public static void ClearMetrics_Internal()
	{
		ClearMetrics_InternalDelegateField();
	}

	public static void ClearCompletedMetrics()
	{
		ClearMetrics_Internal();
	}

	public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
	{
		IntPtr intPtr = GetMetrics_InternalDelegateField(clear);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr) : null;
	}

	public static void GetMetrics_NoAlloc_Internal(List<AsyncReadManagerRequestMetric> metrics, bool clear)
	{
		if (metrics == null)
		{
			ThrowHelper.ThrowArgumentNullException(metrics, "metrics");
		}
		GetMetrics_NoAlloc_Internal_Injected(metrics, clear);
	}

	public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(AsyncReadManagerMetricsFilters filters, bool clear)
	{
		IntPtr intPtr = GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filters), clear);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr) : null;
	}

	public static void GetMetrics_NoAlloc_Filtered_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
	{
		if (metrics == null)
		{
			ThrowHelper.ThrowArgumentNullException(metrics, "metrics");
		}
		GetMetrics_NoAlloc_Filtered_Internal_Injected(metrics, filters, clear);
	}

	public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetricsFilters filters, Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		return GetMetrics_Filtered_Internal(filters, clear);
	}

	public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, clear);
	}

	public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		return GetMetrics_Internal(clear);
	}

	public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		GetMetrics_NoAlloc_Internal(outMetrics, clear);
	}

	public static void StartCollectingMetrics()
	{
		StartCollectingMetricsDelegateField();
	}

	public static void StopCollectingMetrics()
	{
		StopCollectingMetricsDelegateField();
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
	{
		IntPtr intPtr = GetSummaryMetrics_InternalDelegateField(clear);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		return GetSummaryMetrics_Internal(clear);
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(AsyncReadManagerMetricsFilters metricsFilters, bool clear)
	{
		IntPtr intPtr = GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metricsFilters), clear);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, Flags flags)
	{
		bool clear = (flags & Flags.ClearOnRead) == Flags.ClearOnRead;
		return GetSummaryMetricsWithFilters_Internal(metricsFilters, clear);
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
	{
		IntPtr intPtr = GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics));
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
	{
		return GetSummaryOfMetrics_Internal(metrics);
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics)
	{
		IntPtr intPtr = GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics));
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics)
	{
		return GetSummaryOfMetrics_FromContainer_Internal(metrics);
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
	{
		IntPtr intPtr = GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metricsFilters));
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
	{
		return GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
	{
		IntPtr intPtr = GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metricsFilters));
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr) : null;
	}

	public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
	{
		return GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
	}

	public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
	{
		return GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
	}

	public static void GetMetrics_NoAlloc_Internal_Injected(List<AsyncReadManagerRequestMetric> metrics, bool clear)
	{
		GetMetrics_NoAlloc_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics), clear);
	}

	public static void GetMetrics_NoAlloc_Filtered_Internal_Injected(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
	{
		GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filters), clear);
	}
}
