using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.Profiling;

public sealed class Profiler : Il2CppSystem.Object
{
	private delegate bool get_supportedDelegate();

	private delegate bool get_enableBinaryLogDelegate();

	private delegate void set_enableBinaryLogDelegate(bool value);

	private delegate int get_maxUsedMemoryDelegate();

	private delegate void set_maxUsedMemoryDelegate(int value);

	private delegate bool get_enabledDelegate();

	private delegate void set_enabledDelegate(bool value);

	private delegate bool get_enableAllocationCallstacksDelegate();

	private delegate void set_enableAllocationCallstacksDelegate(bool value);

	private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

	private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

	private delegate void EndSampleDelegate();

	private delegate long get_usedHeapSizeLongDelegate();

	private delegate long GetMonoHeapSizeLongDelegate();

	private delegate long GetMonoUsedSizeLongDelegate();

	private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

	private delegate uint GetTempAllocatorSizeDelegate();

	private delegate long GetTotalAllocatedMemoryLongDelegate();

	private delegate long GetTotalUnusedReservedMemoryLongDelegate();

	private delegate long GetTotalReservedMemoryLongDelegate();

	private delegate long InternalGetTotalFragmentationInfoDelegate(System.IntPtr pStats, int count);

	private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

	private delegate void Internal_EmitGlobalMetaData_ArrayDelegate(System.IntPtr id, int idLen, int tag, System.IntPtr data, int count, int elementSize, bool frameData);

	private delegate void Internal_EmitGlobalMetaData_NativeDelegate(System.IntPtr id, int idLen, int tag, System.IntPtr data, int count, int elementSize, bool frameData);

	private delegate uint GetCategoriesCountDelegate();

	private delegate void Internal_SetCategoryEnabledDelegate(ushort categoryId, bool enabled);

	private delegate bool Internal_IsCategoryEnabledDelegate(ushort categoryId);

	private delegate void get_logFile_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_logFile_InjectedDelegate(System.IntPtr value);

	private delegate void AddFramesFromFile_Internal_InjectedDelegate(System.IntPtr file, bool keepExistingFrames);

	private delegate void BeginThreadProfilingInternal_InjectedDelegate(System.IntPtr threadGroupName, System.IntPtr threadName);

	private delegate void BeginSampleImpl_InjectedDelegate(System.IntPtr name, System.IntPtr targetObject);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0;

	public const uint invalidProfilerArea = uint.MaxValue;

	private static readonly get_supportedDelegate get_supportedDelegateField;

	private static readonly get_enableBinaryLogDelegate get_enableBinaryLogDelegateField;

	private static readonly set_enableBinaryLogDelegate set_enableBinaryLogDelegateField;

	private static readonly get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField;

	private static readonly set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField;

	private static readonly get_enabledDelegate get_enabledDelegateField;

	private static readonly set_enabledDelegate set_enabledDelegateField;

	private static readonly get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField;

	private static readonly set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField;

	private static readonly SetAreaEnabledDelegate SetAreaEnabledDelegateField;

	private static readonly GetAreaEnabledDelegate GetAreaEnabledDelegateField;

	private static readonly EndSampleDelegate EndSampleDelegateField;

	private static readonly get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField;

	private static readonly GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField;

	private static readonly GetMonoUsedSizeLongDelegate GetMonoUsedSizeLongDelegateField;

	private static readonly SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField;

	private static readonly GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField;

	private static readonly GetTotalAllocatedMemoryLongDelegate GetTotalAllocatedMemoryLongDelegateField;

	private static readonly GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField;

	private static readonly GetTotalReservedMemoryLongDelegate GetTotalReservedMemoryLongDelegateField;

	private static readonly InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField;

	private static readonly GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField;

	private static readonly Internal_EmitGlobalMetaData_ArrayDelegate Internal_EmitGlobalMetaData_ArrayDelegateField;

	private static readonly Internal_EmitGlobalMetaData_NativeDelegate Internal_EmitGlobalMetaData_NativeDelegateField;

	private static readonly GetCategoriesCountDelegate GetCategoriesCountDelegateField;

	private static readonly Internal_SetCategoryEnabledDelegate Internal_SetCategoryEnabledDelegateField;

	private static readonly Internal_IsCategoryEnabledDelegate Internal_IsCategoryEnabledDelegateField;

	private static readonly get_logFile_InjectedDelegate get_logFile_InjectedDelegateField;

	private static readonly set_logFile_InjectedDelegate set_logFile_InjectedDelegateField;

	private static readonly AddFramesFromFile_Internal_InjectedDelegate AddFramesFromFile_Internal_InjectedDelegateField;

	private static readonly BeginThreadProfilingInternal_InjectedDelegate BeginThreadProfilingInternal_InjectedDelegateField;

	private static readonly BeginSampleImpl_InjectedDelegate BeginSampleImpl_InjectedDelegateField;

	public static bool supported => get_supportedDelegateField();

	public unsafe static string logFile
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_logFile_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_logFile_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_logFile_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public static bool enableBinaryLog
	{
		get
		{
			return get_enableBinaryLogDelegateField();
		}
		set
		{
			set_enableBinaryLogDelegateField(value);
		}
	}

	public static int maxUsedMemory
	{
		get
		{
			return get_maxUsedMemoryDelegateField();
		}
		set
		{
			set_maxUsedMemoryDelegateField(value);
		}
	}

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

	public static bool enableAllocationCallstacks
	{
		get
		{
			return get_enableAllocationCallstacksDelegateField();
		}
		set
		{
			set_enableAllocationCallstacksDelegateField(value);
		}
	}

	public static int areaCount => ((Il2CppArrayBase)Il2CppSystem.Enum.GetNames(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>()))).Length;

	public static int maxNumberOfSamplesPerFrame
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static uint usedHeapSize => (uint)usedHeapSizeLong;

	public static long usedHeapSizeLong => get_usedHeapSizeLongDelegateField();

	static Profiler()
	{
		Il2CppClassPointerStore<Profiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Profiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiler>.NativeClassPtr);
		NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100666950);
		NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100666951);
		get_supportedDelegateField = IL2CPP.ResolveICall<get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");
		get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");
		set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");
		get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");
		set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");
		get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.Profiling.Profiler::get_enabled");
		set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");
		get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");
		set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");
		SetAreaEnabledDelegateField = IL2CPP.ResolveICall<SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");
		GetAreaEnabledDelegateField = IL2CPP.ResolveICall<GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");
		EndSampleDelegateField = IL2CPP.ResolveICall<EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");
		get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");
		GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");
		GetMonoUsedSizeLongDelegateField = IL2CPP.ResolveICall<GetMonoUsedSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong");
		SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");
		GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");
		GetTotalAllocatedMemoryLongDelegateField = IL2CPP.ResolveICall<GetTotalAllocatedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong");
		GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");
		GetTotalReservedMemoryLongDelegateField = IL2CPP.ResolveICall<GetTotalReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong");
		InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");
		GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");
		Internal_EmitGlobalMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Internal_EmitGlobalMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array");
		Internal_EmitGlobalMetaData_NativeDelegateField = IL2CPP.ResolveICall<Internal_EmitGlobalMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native");
		GetCategoriesCountDelegateField = IL2CPP.ResolveICall<GetCategoriesCountDelegate>("UnityEngine.Profiling.Profiler::GetCategoriesCount");
		Internal_SetCategoryEnabledDelegateField = IL2CPP.ResolveICall<Internal_SetCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_SetCategoryEnabled");
		Internal_IsCategoryEnabledDelegateField = IL2CPP.ResolveICall<Internal_IsCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_IsCategoryEnabled");
		get_logFile_InjectedDelegateField = IL2CPP.ResolveICall<get_logFile_InjectedDelegate>("UnityEngine.Profiling.Profiler::get_logFile_Injected");
		set_logFile_InjectedDelegateField = IL2CPP.ResolveICall<set_logFile_InjectedDelegate>("UnityEngine.Profiling.Profiler::set_logFile_Injected");
		AddFramesFromFile_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AddFramesFromFile_Internal_InjectedDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal_Injected");
		BeginThreadProfilingInternal_InjectedDelegateField = IL2CPP.ResolveICall<BeginThreadProfilingInternal_InjectedDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal_Injected");
		BeginSampleImpl_InjectedDelegateField = IL2CPP.ResolveICall<BeginSampleImpl_InjectedDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221952, RefRangeEnd = 1221953, XrefRangeStart = 1221944, XrefRangeEnd = 1221952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetRuntimeMemorySizeLong(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221953, XrefRangeEnd = 1221955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetRuntimeMemorySizeLong_Injected(System.IntPtr o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Profiler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void SetAreaEnabled(ProfilerArea area, bool enabled)
	{
		SetAreaEnabledDelegateField(area, enabled);
	}

	public static bool GetAreaEnabled(ProfilerArea area)
	{
		return GetAreaEnabledDelegateField(area);
	}

	public static void AddFramesFromFile(string file)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(file))
		{
			Debug.LogError("AddFramesFromFile: Invalid or empty path");
		}
		else
		{
			AddFramesFromFile_Internal(file, keepExistingFrames: true);
		}
	}

	public unsafe static void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(file, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(file);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					AddFramesFromFile_Internal_Injected(ref managedSpanWrapper, keepExistingFrames);
					return;
				}
			}
			AddFramesFromFile_Internal_Injected(ref managedSpanWrapper, keepExistingFrames);
		}
		finally
		{
		}
	}

	public static void BeginThreadProfiling(string threadGroupName, string threadName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(threadGroupName))
		{
			throw new Il2CppSystem.ArgumentException("Argument should be a valid string", "threadGroupName");
		}
		if (Il2CppSystem.String.IsNullOrEmpty(threadName))
		{
			throw new Il2CppSystem.ArgumentException("Argument should be a valid string", "threadName");
		}
		BeginThreadProfilingInternal(threadGroupName, threadName);
	}

	public unsafe static void BeginThreadProfilingInternal(string threadGroupName, string threadName)
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
			ref ManagedSpanWrapper threadGroupName2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(threadGroupName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(threadGroupName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					threadGroupName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(threadName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(threadName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							BeginThreadProfilingInternal_Injected(ref threadGroupName2, ref managedSpanWrapper2);
							return;
						}
					}
					BeginThreadProfilingInternal_Injected(ref threadGroupName2, ref managedSpanWrapper2);
					return;
				}
			}
			threadGroupName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(threadName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(threadName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					BeginThreadProfilingInternal_Injected(ref threadGroupName2, ref managedSpanWrapper2);
					return;
				}
			}
			BeginThreadProfilingInternal_Injected(ref threadGroupName2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static void EndThreadProfiling()
	{
	}

	public static void BeginSample(string name)
	{
		ValidateArguments(name);
		BeginSampleImpl(name, null);
	}

	public static void BeginSample(string name, Object targetObject)
	{
		ValidateArguments(name);
		BeginSampleImpl(name, targetObject);
	}

	public static void ValidateArguments(string name)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(name))
		{
			throw new Il2CppSystem.ArgumentException("Argument should be a valid string.", "name");
		}
	}

	public unsafe static void BeginSampleImpl(string name, Object targetObject)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					BeginSampleImpl_Injected(ref managedSpanWrapper, Object.MarshalledUnityObject.Marshal(targetObject));
					return;
				}
			}
			BeginSampleImpl_Injected(ref managedSpanWrapper, Object.MarshalledUnityObject.Marshal(targetObject));
		}
		finally
		{
		}
	}

	public static void EndSample()
	{
		EndSampleDelegateField();
	}

	public static int GetRuntimeMemorySize(Object o)
	{
		return (int)GetRuntimeMemorySizeLong(o);
	}

	public static uint GetMonoHeapSize()
	{
		return (uint)GetMonoHeapSizeLong();
	}

	public static long GetMonoHeapSizeLong()
	{
		return GetMonoHeapSizeLongDelegateField();
	}

	public static uint GetMonoUsedSize()
	{
		return (uint)GetMonoUsedSizeLong();
	}

	public static long GetMonoUsedSizeLong()
	{
		return GetMonoUsedSizeLongDelegateField();
	}

	public static bool SetTempAllocatorRequestedSize(uint size)
	{
		return SetTempAllocatorRequestedSizeDelegateField(size);
	}

	public static uint GetTempAllocatorSize()
	{
		return GetTempAllocatorSizeDelegateField();
	}

	public static uint GetTotalAllocatedMemory()
	{
		return (uint)GetTotalAllocatedMemoryLong();
	}

	public static long GetTotalAllocatedMemoryLong()
	{
		return GetTotalAllocatedMemoryLongDelegateField();
	}

	public static uint GetTotalUnusedReservedMemory()
	{
		return (uint)GetTotalUnusedReservedMemoryLong();
	}

	public static long GetTotalUnusedReservedMemoryLong()
	{
		return GetTotalUnusedReservedMemoryLongDelegateField();
	}

	public static uint GetTotalReservedMemory()
	{
		return (uint)GetTotalReservedMemoryLong();
	}

	public static long GetTotalReservedMemoryLong()
	{
		return GetTotalReservedMemoryLongDelegateField();
	}

	public unsafe static long GetTotalFragmentationInfo(NativeArray<int> stats)
	{
		//IL_0013: Expected O, but got Ref
		return InternalGetTotalFragmentationInfo((System.IntPtr)stats.GetUnsafePtr(), ((NativeArray<int>)(&stats)).Length);
	}

	public static long InternalGetTotalFragmentationInfo(System.IntPtr pStats, int count)
	{
		return InternalGetTotalFragmentationInfoDelegateField(pStats, count);
	}

	public static long GetAllocatedMemoryForGraphicsDriver()
	{
		return GetAllocatedMemoryForGraphicsDriverDelegateField();
	}

	public unsafe static void EmitFrameMetaData(Il2CppSystem.Guid id, int tag, Il2CppSystem.Array data)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		Il2CppSystem.Type elementType = ((Il2CppSystem.Object)data).GetType().GetElementType();
		if (!UnsafeUtility.IsBlittable(elementType))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object)elementType));
		}
		Internal_EmitGlobalMetaData_Array(&id, 16, tag, data, data.Length, UnsafeUtility.SizeOf(elementType), frameData: true);
	}

	public unsafe static void EmitFrameMetaData<T>(Il2CppSystem.Guid id, int tag, List<T> data) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
		if (!UnsafeUtility.IsBlittable(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object)typeFromHandle));
		}
		Internal_EmitGlobalMetaData_Array(&id, 16, tag, (Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), data.Count, UnsafeUtility.SizeOf(typeFromHandle), frameData: true);
	}

	public unsafe static void EmitFrameMetaData<T>(Il2CppSystem.Guid id, int tag, NativeArray<T> data) where T : struct
	{
		//IL_0019: Expected O, but got Ref
		Internal_EmitGlobalMetaData_Native(&id, 16, tag, (System.IntPtr)data.GetUnsafeReadOnlyPtr(), ((NativeArray<T>)(&data)).Length, UnsafeUtility.SizeOf<T>(), frameData: true);
	}

	public unsafe static void EmitSessionMetaData(Il2CppSystem.Guid id, int tag, Il2CppSystem.Array data)
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		Il2CppSystem.Type elementType = ((Il2CppSystem.Object)data).GetType().GetElementType();
		if (!UnsafeUtility.IsBlittable(elementType))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object)elementType));
		}
		Internal_EmitGlobalMetaData_Array(&id, 16, tag, data, data.Length, UnsafeUtility.SizeOf(elementType), frameData: false);
	}

	public unsafe static void EmitSessionMetaData<T>(Il2CppSystem.Guid id, int tag, List<T> data) where T : struct
	{
		if (data == null)
		{
			throw new Il2CppSystem.ArgumentNullException("data");
		}
		Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
		if (!UnsafeUtility.IsBlittable(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object)typeFromHandle));
		}
		Internal_EmitGlobalMetaData_Array(&id, 16, tag, (Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), data.Count, UnsafeUtility.SizeOf(typeFromHandle), frameData: false);
	}

	public unsafe static void EmitSessionMetaData<T>(Il2CppSystem.Guid id, int tag, NativeArray<T> data) where T : struct
	{
		//IL_0019: Expected O, but got Ref
		Internal_EmitGlobalMetaData_Native(&id, 16, tag, (System.IntPtr)data.GetUnsafeReadOnlyPtr(), ((NativeArray<T>)(&data)).Length, UnsafeUtility.SizeOf<T>(), frameData: false);
	}

	public unsafe static void Internal_EmitGlobalMetaData_Array(void* id, int idLen, int tag, Il2CppSystem.Array data, int count, int elementSize, bool frameData)
	{
		Internal_EmitGlobalMetaData_ArrayDelegateField((nint)id, idLen, tag, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), count, elementSize, frameData);
	}

	public unsafe static void Internal_EmitGlobalMetaData_Native(void* id, int idLen, int tag, System.IntPtr data, int count, int elementSize, bool frameData)
	{
		Internal_EmitGlobalMetaData_NativeDelegateField((nint)id, idLen, tag, data, count, elementSize, frameData);
	}

	public static void SetCategoryEnabled(ProfilerCategory category, bool enabled)
	{
		if ((ushort)category == (ushort)ProfilerCategory.Any)
		{
			throw new Il2CppSystem.ArgumentException("Argument should be a valid category", "category");
		}
		Internal_SetCategoryEnabled(category, enabled);
	}

	public static bool IsCategoryEnabled(ProfilerCategory category)
	{
		if ((ushort)category == (ushort)ProfilerCategory.Any)
		{
			throw new Il2CppSystem.ArgumentException("Argument should be a valid category", "category");
		}
		return Internal_IsCategoryEnabled(category);
	}

	public static uint GetCategoriesCount()
	{
		return GetCategoriesCountDelegateField();
	}

	public static void GetAllCategories(Il2CppStructArray<ProfilerCategory> categories)
	{
		for (int i = 0; i < Il2CppSystem.Math.Min(GetCategoriesCount(), ((Il2CppArrayBase)categories).Length); i++)
		{
			((Il2CppArrayBase<ProfilerCategory>)(object)categories)[i] = new ProfilerCategory((ushort)i);
		}
	}

	public unsafe static void GetAllCategories(NativeArray<ProfilerCategory> categories)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0014: Expected O, but got Ref
		for (int i = 0; i < Il2CppSystem.Math.Min(GetCategoriesCount(), ((NativeArray<ProfilerCategory>)(&categories)).Length); i++)
		{
			((NativeArray<ProfilerCategory>)(&categories))[i] = new ProfilerCategory((ushort)i);
		}
	}

	public static void Internal_SetCategoryEnabled(ushort categoryId, bool enabled)
	{
		Internal_SetCategoryEnabledDelegateField(categoryId, enabled);
	}

	public static bool Internal_IsCategoryEnabled(ushort categoryId)
	{
		return Internal_IsCategoryEnabledDelegateField(categoryId);
	}

	public unsafe static void get_logFile_Injected(out ManagedSpanWrapper ret)
	{
		get_logFile_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_logFile_Injected(ref ManagedSpanWrapper value)
	{
		set_logFile_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void AddFramesFromFile_Internal_Injected(ref ManagedSpanWrapper file, bool keepExistingFrames)
	{
		AddFramesFromFile_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref file), keepExistingFrames);
	}

	public unsafe static void BeginThreadProfilingInternal_Injected(ref ManagedSpanWrapper threadGroupName, ref ManagedSpanWrapper threadName)
	{
		BeginThreadProfilingInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref threadGroupName), (nint)Unsafe.AsPointer(ref threadName));
	}

	public unsafe static void BeginSampleImpl_Injected(ref ManagedSpanWrapper name, System.IntPtr targetObject)
	{
		BeginSampleImpl_InjectedDelegateField((nint)Unsafe.AsPointer(ref name), targetObject);
	}
}
