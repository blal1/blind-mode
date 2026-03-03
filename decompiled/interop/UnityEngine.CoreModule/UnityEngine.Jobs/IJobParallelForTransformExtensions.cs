using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Jobs;

public static class IJobParallelForTransformExtensions : Il2CppSystem.Object
{
	public sealed class TransformParallelForLoopStruct<T> : Il2CppSystem.ValueType where T : new()
	{
		public sealed class TransformJobData : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_TransformAccessArray;

			private static readonly System.IntPtr NativeFieldInfoPtr_IsReadOnly;

			public unsafe System.IntPtr TransformAccessArray
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransformAccessArray);
					return *(System.IntPtr*)num;
				}
				set
				{
					*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransformAccessArray)) = value;
				}
			}

			public unsafe int IsReadOnly
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReadOnly);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReadOnly)) = value;
				}
			}

			static TransformJobData()
			{
				Il2CppClassPointerStore<TransformJobData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr, "TransformJobData"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformJobData>.NativeClassPtr);
				NativeFieldInfoPtr_TransformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformJobData>.NativeClassPtr, "TransformAccessArray");
				NativeFieldInfoPtr_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformJobData>.NativeClassPtr, "IsReadOnly");
			}

			public TransformJobData(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public TransformJobData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformJobData>.NativeClassPtr))
			{
			}
		}

		public sealed class ExecuteJobFunction : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			static ExecuteJobFunction()
			{
				Il2CppClassPointerStore<ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteJobFunction>.NativeClassPtr, 100666980);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteJobFunction>.NativeClassPtr, 100666981);
			}

			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 959784, RefRangeEnd = 959790, XrefRangeStart = 959784, XrefRangeEnd = 959790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExecuteJobFunction(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteJobFunction>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(ref T jobData, System.IntPtr additionalPtr, System.IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[5];
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref jobData));
				*ptr = (nint)(&intPtr);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalPtr;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferRangePatchData;
				*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ranges);
				*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobIndex;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				System.IntPtr intPtr4 = intPtr;
				Unsafe.As<T, object>(ref jobData) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			public ExecuteJobFunction(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_jobReflectionData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

		public unsafe static BurstLike.SharedStatic<System.IntPtr> jobReflectionData
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_jobReflectionData, (void*)intPtr);
				return new BurstLike.SharedStatic<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_jobReflectionData, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		static TransformParallelForLoopStruct()
		{
			Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, "TransformParallelForLoopStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr);
			NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr, "jobReflectionData");
			NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr, 100666977);
			NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr, 100666978);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1222060, RefRangeEnd = 1222063, XrefRangeStart = 1222034, XrefRangeEnd = 1222060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222063, XrefRangeEnd = 1222079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ref T jobData, System.IntPtr jobData2, System.IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref jobData));
			*ptr = (nint)(&intPtr);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobData2;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferRangePatchData;
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ranges);
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			Unsafe.As<T, object>(ref jobData) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		public TransformParallelForLoopStruct(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public TransformParallelForLoopStruct()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformParallelForLoopStruct<T>>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0;

	static IJobParallelForTransformExtensions()
	{
		Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "IJobParallelForTransformExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666974);
		NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666975);
		NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666976);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1222087, RefRangeEnd = 1222088, XrefRangeStart = 1222079, XrefRangeEnd = 1222087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EarlyJobInit<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222088, XrefRangeEnd = 1222096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetReflectionData<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1222108, RefRangeEnd = 1222109, XrefRangeStart = 1222096, XrefRangeEnd = 1222108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle Schedule<T>(this T jobData, TransformAccessArray transforms, JobHandle dependsOn = default(JobHandle)) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = jobData;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref jobData;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(TransformAccessArray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transforms;
		*(JobHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dependsOn;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IJobParallelForTransformExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static JobHandle ScheduleReadOnly<T>(T jobData, TransformAccessArray transforms, int batchSize, [Optional] JobHandle dependsOn) where T : struct
	{
		JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf(ref jobData), GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
		return JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
	}

	public unsafe static void RunReadOnly<T>(T jobData, TransformAccessArray transforms) where T : struct
	{
		JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf(ref jobData), GetReflectionData<T>(), default(JobHandle), ScheduleMode.Run);
		JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
	}

	public unsafe static JobHandle ScheduleByRef<T>(ref T jobData, TransformAccessArray transforms, [Optional] JobHandle dependsOn) where T : struct
	{
		JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf(ref jobData), GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
		return JobsUtility.ScheduleParallelForTransform(ref parameters, transforms.GetTransformAccessArrayForSchedule());
	}

	public unsafe static JobHandle ScheduleReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms, int batchSize, [Optional] JobHandle dependsOn) where T : struct
	{
		JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf(ref jobData), GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
		return JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
	}

	public unsafe static void RunReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms) where T : struct
	{
		JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf(ref jobData), GetReflectionData<T>(), default(JobHandle), ScheduleMode.Run);
		JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
	}
}
