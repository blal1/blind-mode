using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Jobs;

[StructLayout(LayoutKind.Explicit)]
public struct JobHandle
{
	private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(System.IntPtr jobs, int count);

	private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate([In] System.IntPtr jobHandle, [In] System.IntPtr dependsOn);

	private static readonly System.IntPtr NativeFieldInfoPtr_jobGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternal3_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternal3_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0;

	[FieldOffset(0)]
	public ulong jobGroup;

	[FieldOffset(8)]
	public int version;

	private static readonly ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;

	private static readonly CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

	public unsafe bool IsCompleted
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1164242, RefRangeEnd = 1164246, XrefRangeStart = 1164240, XrefRangeEnd = 1164242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static JobHandle()
	{
		Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "JobHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
		NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "jobGroup");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "version");
		NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_CombineDependenciesInternal3_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_CombineDependenciesInternal3_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663349);
		ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
		CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
	}

	[CallerCount(108)]
	[CachedScanResults(RefRangeStart = 1164132, RefRangeEnd = 1164240, XrefRangeStart = 1164130, XrefRangeEnd = 1164132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Complete()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Complete_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1164248, RefRangeEnd = 1164255, XrefRangeStart = 1164246, XrefRangeEnd = 1164248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleBatchedJobs()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164255, XrefRangeEnd = 1164257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref job);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1164242, RefRangeEnd = 1164246, XrefRangeStart = 1164242, XrefRangeEnd = 1164246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref job);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1164259, RefRangeEnd = 1164264, XrefRangeStart = 1164257, XrefRangeEnd = 1164259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&job0);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &job1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164266, RefRangeEnd = 1164268, XrefRangeStart = 1164264, XrefRangeEnd = 1164266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&job0);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &job1;
		*(JobHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &job2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164273, RefRangeEnd = 1164279, XrefRangeStart = 1164268, XrefRangeEnd = 1164273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependencies(NativeArray<JobHandle> jobs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jobs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164287, RefRangeEnd = 1164293, XrefRangeStart = 1164279, XrefRangeEnd = 1164287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jobs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164293, XrefRangeEnd = 1164295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref job0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164295, XrefRangeEnd = 1164297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref job0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternal3_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164297, XrefRangeEnd = 1164299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)jobs;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(JobHandle other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164299, XrefRangeEnd = 1164301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref job0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164301, XrefRangeEnd = 1164303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref job0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref job2);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternal3_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164303, XrefRangeEnd = 1164305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)jobs;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1)
	{
		JobHandle* ptr = stackalloc JobHandle[2];
		*ptr = job0;
		ptr[1] = job1;
		ScheduleBatchedJobsAndCompleteAll(ptr, 2);
		job0 = default(JobHandle);
		job1 = default(JobHandle);
	}

	public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
	{
		JobHandle* ptr = stackalloc JobHandle[3];
		*ptr = job0;
		ptr[1] = job1;
		ptr[2] = job2;
		ScheduleBatchedJobsAndCompleteAll(ptr, 3);
		job0 = default(JobHandle);
		job1 = default(JobHandle);
		job2 = default(JobHandle);
	}

	public unsafe static void CompleteAll(NativeArray<JobHandle> jobs)
	{
		//IL_000e: Expected O, but got Ref
		ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr(), ((NativeArray<JobHandle>)(&jobs)).Length);
	}

	public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
	{
		ScheduleBatchedJobsAndCompleteAllDelegateField((nint)jobs, count);
	}

	public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
	{
		return CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
	}

	public unsafe static bool CheckFenceIsDependencyOrDidSyncFence_Injected([In] ref JobHandle jobHandle, [In] ref JobHandle dependsOn)
	{
		return CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField((nint)Unsafe.AsPointer(ref jobHandle), (nint)Unsafe.AsPointer(ref dependsOn));
	}
}
