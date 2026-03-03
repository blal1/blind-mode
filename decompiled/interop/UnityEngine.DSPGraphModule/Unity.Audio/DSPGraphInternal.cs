using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace Unity.Audio;

public struct DSPGraphInternal
{
	private delegate void Internal_InitializeJobDelegate(System.IntPtr jobStructData, System.IntPtr jobReflectionData, System.IntPtr resourceContext);

	private delegate void Internal_ExecuteJobDelegate(System.IntPtr jobStructData, System.IntPtr jobReflectionData, System.IntPtr jobData, System.IntPtr resourceContext);

	private delegate void Internal_DisposeJobDelegate(System.IntPtr jobStructData, System.IntPtr jobReflectionData, System.IntPtr resourceContext);

	private delegate void Internal_ScheduleGraph_InjectedDelegate([In] System.IntPtr inputDeps, System.IntPtr nodes, int nodeCount, System.IntPtr childTable, System.IntPtr dependencies);

	private delegate void Internal_SyncFenceNoWorkSteal_InjectedDelegate([In] System.IntPtr handle);

	private static readonly Internal_InitializeJobDelegate Internal_InitializeJobDelegateField = IL2CPP.ResolveICall<Internal_InitializeJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_InitializeJob");

	private static readonly Internal_ExecuteJobDelegate Internal_ExecuteJobDelegateField = IL2CPP.ResolveICall<Internal_ExecuteJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_ExecuteJob");

	private static readonly Internal_DisposeJobDelegate Internal_DisposeJobDelegateField = IL2CPP.ResolveICall<Internal_DisposeJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_DisposeJob");

	private static readonly Internal_ScheduleGraph_InjectedDelegate Internal_ScheduleGraph_InjectedDelegateField = IL2CPP.ResolveICall<Internal_ScheduleGraph_InjectedDelegate>("Unity.Audio.DSPGraphInternal::Internal_ScheduleGraph_Injected");

	private static readonly Internal_SyncFenceNoWorkSteal_InjectedDelegate Internal_SyncFenceNoWorkSteal_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SyncFenceNoWorkSteal_InjectedDelegate>("Unity.Audio.DSPGraphInternal::Internal_SyncFenceNoWorkSteal_Injected");

	public unsafe static void Internal_InitializeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
	{
		Internal_InitializeJobDelegateField((nint)jobStructData, (nint)jobReflectionData, (nint)resourceContext);
	}

	public unsafe static void Internal_ExecuteJob(void* jobStructData, void* jobReflectionData, void* jobData, void* resourceContext)
	{
		Internal_ExecuteJobDelegateField((nint)jobStructData, (nint)jobReflectionData, (nint)jobData, (nint)resourceContext);
	}

	public unsafe static void Internal_DisposeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
	{
		Internal_DisposeJobDelegateField((nint)jobStructData, (nint)jobReflectionData, (nint)resourceContext);
	}

	public unsafe static void Internal_ScheduleGraph(JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
	{
		Internal_ScheduleGraph_Injected(ref inputDeps, nodes, nodeCount, childTable, dependencies);
	}

	public static void Internal_SyncFenceNoWorkSteal(JobHandle handle)
	{
		Internal_SyncFenceNoWorkSteal_Injected(ref handle);
	}

	public unsafe static void Internal_ScheduleGraph_Injected([In] ref JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
	{
		Internal_ScheduleGraph_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref inputDeps), (nint)nodes, nodeCount, (nint)childTable, (nint)dependencies);
	}

	public unsafe static void Internal_SyncFenceNoWorkSteal_Injected([In] ref JobHandle handle)
	{
		Internal_SyncFenceNoWorkSteal_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}
}
