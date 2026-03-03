using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe;

public static class JobsUtility : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct JobScheduleParameters
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Dependency;

		private static readonly System.IntPtr NativeFieldInfoPtr_ScheduleMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionData;

		private static readonly System.IntPtr NativeFieldInfoPtr_JobDataPtr;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0;

		[FieldOffset(0)]
		public JobHandle Dependency;

		[FieldOffset(16)]
		public int ScheduleMode;

		[FieldOffset(24)]
		public System.IntPtr ReflectionData;

		[FieldOffset(32)]
		public System.IntPtr JobDataPtr;

		static JobScheduleParameters()
		{
			Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "JobScheduleParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr);
			NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, "Dependency");
			NativeFieldInfoPtr_ScheduleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, "ScheduleMode");
			NativeFieldInfoPtr_ReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, "ReflectionData");
			NativeFieldInfoPtr_JobDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, "JobDataPtr");
			NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, 100663370);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1164306, RefRangeEnd = 1164315, XrefRangeStart = 1164305, XrefRangeEnd = 1164306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobScheduleParameters(void* i_jobData, System.IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)i_jobData;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i_reflectionData;
			*(JobHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i_dependency;
			*(ScheduleMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &i_scheduleMode;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobScheduleParameters>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class PanicFunction_ : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static PanicFunction_()
		{
			Il2CppClassPointerStore<PanicFunction_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction_");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanicFunction_>.NativeClassPtr, 100663371);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanicFunction_>.NativeClassPtr, 100663372);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanicFunction_(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanicFunction_>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PanicFunction_(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PanicFunction_(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<PanicFunction_>((System.Delegate)P_0);
		}

		public static PanicFunction_ operator +(PanicFunction_ P_0, PanicFunction_ P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PanicFunction_>();
		}

		public static PanicFunction_ operator -(PanicFunction_ P_0, PanicFunction_ P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PanicFunction_>();
			}
			return (PanicFunction_)obj;
		}
	}

	private delegate void PatchBufferMinMaxRangesDelegate(System.IntPtr bufferRangePatchData, System.IntPtr jobdata, int startIndex, int rangeSize);

	private delegate bool get_JobDebuggerEnabledDelegate();

	private delegate void set_JobDebuggerEnabledDelegate(bool value);

	private delegate bool get_JobCompilerEnabledDelegate();

	private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

	private delegate int get_JobWorkerMaximumCountDelegate();

	private delegate void ResetJobWorkerCountDelegate();

	private delegate bool GetJobBatchingEnabledDelegate();

	private delegate System.IntPtr GetSystemIdCellPtrDelegate();

	private delegate void ClearSystemIdsDelegate();

	private delegate int GetSystemIdMappingsDelegate(System.IntPtr handles, System.IntPtr systemIds, int maxCount);

	private delegate void ScheduleParallelForTransformReadOnly_InjectedDelegate(System.IntPtr parameters, System.IntPtr transfromAccesssArray, int innerloopBatchCount, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_PanicFunction;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobQueueWorkerThreadCount_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JobWorkerCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0;

	public const int MaxJobThreadCount = 128;

	public const int CacheLineSize = 64;

	private static readonly PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField;

	private static readonly get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField;

	private static readonly set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField;

	private static readonly get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField;

	private static readonly SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField;

	private static readonly get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField;

	private static readonly ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField;

	private static readonly GetJobBatchingEnabledDelegate GetJobBatchingEnabledDelegateField;

	private static readonly GetSystemIdCellPtrDelegate GetSystemIdCellPtrDelegateField;

	private static readonly ClearSystemIdsDelegate ClearSystemIdsDelegateField;

	private static readonly GetSystemIdMappingsDelegate GetSystemIdMappingsDelegateField;

	private static readonly ScheduleParallelForTransformReadOnly_InjectedDelegate ScheduleParallelForTransformReadOnly_InjectedDelegateField;

	public unsafe static PanicFunction_ PanicFunction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PanicFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PanicFunction_>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PanicFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsExecutingJob
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1164375, RefRangeEnd = 1164381, XrefRangeStart = 1164373, XrefRangeEnd = 1164375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool JobCompilerEnabled
	{
		get
		{
			return get_JobCompilerEnabledDelegateField();
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1164383, RefRangeEnd = 1164385, XrefRangeStart = 1164381, XrefRangeEnd = 1164383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int JobWorkerCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JobWorkerCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value < 0 || value > JobWorkerMaximumCount)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException("JobWorkerCount", Il2CppSystem.String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", (Il2CppSystem.Object)(object)value, (Il2CppSystem.Object)(object)JobWorkerMaximumCount));
			}
			SetJobQueueMaximumActiveThreadCount(value);
		}
	}

	public unsafe static int ThreadIndex
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1164389, RefRangeEnd = 1164394, XrefRangeStart = 1164387, XrefRangeEnd = 1164389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int ThreadIndexCount
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1164396, RefRangeEnd = 1164414, XrefRangeStart = 1164394, XrefRangeEnd = 1164396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static bool JobDebuggerEnabled
	{
		get
		{
			return get_JobDebuggerEnabledDelegateField();
		}
		set
		{
			set_JobDebuggerEnabledDelegateField(value);
		}
	}

	public static int JobWorkerMaximumCount => get_JobWorkerMaximumCountDelegateField();

	public static bool JobBatchingEnabled => GetJobBatchingEnabled();

	static JobsUtility()
	{
		Il2CppClassPointerStore<JobsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobsUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr);
		NativeFieldInfoPtr_PanicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction");
		NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_GetJobQueueWorkerThreadCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_get_JobWorkerCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663369);
		PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");
		get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");
		set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");
		get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");
		SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");
		get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");
		ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");
		GetJobBatchingEnabledDelegateField = IL2CPP.ResolveICall<GetJobBatchingEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobBatchingEnabled");
		GetSystemIdCellPtrDelegateField = IL2CPP.ResolveICall<GetSystemIdCellPtrDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr");
		ClearSystemIdsDelegateField = IL2CPP.ResolveICall<ClearSystemIdsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds");
		GetSystemIdMappingsDelegateField = IL2CPP.ResolveICall<GetSystemIdMappingsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings");
		ScheduleParallelForTransformReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<ScheduleParallelForTransformReadOnly_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1164316, RefRangeEnd = 1164319, XrefRangeStart = 1164315, XrefRangeEnd = 1164316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ranges);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref beginIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref endIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1164321, RefRangeEnd = 1164341, XrefRangeStart = 1164319, XrefRangeEnd = 1164321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ranges);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref beginIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref endIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164343, RefRangeEnd = 1164345, XrefRangeStart = 1164341, XrefRangeEnd = 1164343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle Schedule(ref JobScheduleParameters parameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1164347, RefRangeEnd = 1164352, XrefRangeStart = 1164345, XrefRangeEnd = 1164347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerloopBatchCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164354, RefRangeEnd = 1164356, XrefRangeStart = 1164352, XrefRangeEnd = 1164354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerloopBatchCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = listData;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = listDataAtomicSafetyHandle;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1164358, RefRangeEnd = 1164359, XrefRangeStart = 1164356, XrefRangeEnd = 1164358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, System.IntPtr transfromAccesssArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transfromAccesssArray;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164359, XrefRangeEnd = 1164361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJobReflectionData(Il2CppSystem.Type wrapperJobType, Il2CppSystem.Type userJobType, Il2CppSystem.Object managedJobFunction0, Il2CppSystem.Object managedJobFunction1, Il2CppSystem.Object managedJobFunction2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wrapperJobType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userJobType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1164363, RefRangeEnd = 1164373, XrefRangeStart = 1164361, XrefRangeEnd = 1164363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateJobReflectionData(Il2CppSystem.Type type, Il2CppSystem.Object managedJobFunction0, Il2CppSystem.Object managedJobFunction1 = null, Il2CppSystem.Object managedJobFunction2 = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedJobFunction2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164385, XrefRangeEnd = 1164387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetJobQueueWorkerThreadCount()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobQueueWorkerThreadCount_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164414, XrefRangeEnd = 1164416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePanicFunction()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164416, XrefRangeEnd = 1164418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164418, XrefRangeEnd = 1164420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerloopBatchCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164420, XrefRangeEnd = 1164422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleParallelForDeferArraySize_Injected(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerloopBatchCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = listData;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = listDataAtomicSafetyHandle;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164422, XrefRangeEnd = 1164424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, System.IntPtr transfromAccesssArray, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transfromAccesssArray;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public JobsUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static JobHandle ScheduleParallelForTransformReadOnly(ref JobScheduleParameters parameters, System.IntPtr transfromAccesssArray, int innerloopBatchCount)
	{
		ScheduleParallelForTransformReadOnly_Injected(ref parameters, transfromAccesssArray, innerloopBatchCount, out var ret);
		return ret;
	}

	public unsafe static void PatchBufferMinMaxRanges(System.IntPtr bufferRangePatchData, void* jobdata, int startIndex, int rangeSize)
	{
		PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, (nint)jobdata, startIndex, rangeSize);
	}

	public static System.IntPtr CreateJobReflectionData(Il2CppSystem.Type type, JobType jobType, Il2CppSystem.Object managedJobFunction0, [Optional] Il2CppSystem.Object managedJobFunction1, [Optional] Il2CppSystem.Object managedJobFunction2)
	{
		return CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
	}

	public static System.IntPtr CreateJobReflectionData(Il2CppSystem.Type wrapperJobType, Il2CppSystem.Type userJobType, JobType jobType, Il2CppSystem.Object managedJobFunction0)
	{
		return CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
	}

	public static System.IntPtr CreateJobReflectionData(Il2CppSystem.Type wrapperJobType, Il2CppSystem.Type userJobType, Il2CppSystem.Object managedJobFunction0)
	{
		return CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
	}

	public static void SetJobQueueMaximumActiveThreadCount(int count)
	{
		SetJobQueueMaximumActiveThreadCountDelegateField(count);
	}

	public static void ResetJobWorkerCount()
	{
		ResetJobWorkerCountDelegateField();
	}

	public static bool GetJobBatchingEnabled()
	{
		return GetJobBatchingEnabledDelegateField();
	}

	public static System.IntPtr GetSystemIdCellPtr()
	{
		return GetSystemIdCellPtrDelegateField();
	}

	public static void ClearSystemIds()
	{
		ClearSystemIdsDelegateField();
	}

	public unsafe static int GetSystemIdMappings(JobHandle* handles, int* systemIds, int maxCount)
	{
		return GetSystemIdMappingsDelegateField((nint)handles, (nint)systemIds, maxCount);
	}

	public unsafe static void ScheduleParallelForTransformReadOnly_Injected(ref JobScheduleParameters parameters, System.IntPtr transfromAccesssArray, int innerloopBatchCount, out JobHandle ret)
	{
		ScheduleParallelForTransformReadOnly_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parameters), transfromAccesssArray, innerloopBatchCount, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
