using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting;

public static class GarbageCollector
{
	public enum Mode
	{
		Disabled,
		Enabled,
		Manual
	}

	private delegate void SetModeDelegate(Mode mode);

	private delegate Mode GetModeDelegate();

	private delegate bool get_isIncrementalDelegate();

	private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

	private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

	private delegate bool CollectIncrementalDelegate(ulong nanoseconds);

	private static readonly SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");

	private static readonly GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");

	private static readonly get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");

	private static readonly get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");

	private static readonly set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");

	private static readonly CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

	public static Mode GCMode
	{
		get
		{
			return GetMode();
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool isIncremental => get_isIncrementalDelegateField();

	public static ulong incrementalTimeSliceNanoseconds
	{
		get
		{
			return get_incrementalTimeSliceNanosecondsDelegateField();
		}
		set
		{
			set_incrementalTimeSliceNanosecondsDelegateField(value);
		}
	}

	[SpecialName]
	public static void add_GCModeChanged(Il2CppSystem.Action<Mode> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_GCModeChanged(Il2CppSystem.Action<Mode> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetMode(Mode mode)
	{
		SetModeDelegateField(mode);
	}

	public static Mode GetMode()
	{
		return GetModeDelegateField();
	}

	public static bool CollectIncremental([Optional] ulong nanoseconds)
	{
		return CollectIncrementalDelegateField(nanoseconds);
	}
}
