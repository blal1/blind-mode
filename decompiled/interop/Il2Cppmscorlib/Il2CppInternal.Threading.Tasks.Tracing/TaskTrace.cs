using System;
using System.Runtime.CompilerServices;
using Il2CppInternal.Runtime.Augments;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppInternal.Threading.Tasks.Tracing;

public static class TaskTrace : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_callbacks;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0;

	public unsafe static TaskTraceCallbacks s_callbacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_callbacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskTraceCallbacks>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_callbacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool Enabled
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 701180, RefRangeEnd = 701189, XrefRangeStart = 701178, XrefRangeEnd = 701180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TaskTrace()
	{
		Il2CppClassPointerStore<TaskTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Threading.Tasks.Tracing", "TaskTrace");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr);
		NativeFieldInfoPtr_s_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, "s_callbacks");
		NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskTrace>.NativeClassPtr, 100663856);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701191, RefRangeEnd = 701192, XrefRangeStart = 701189, XrefRangeEnd = 701191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&OriginatingTaskSchedulerID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &OriginatingTaskID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &TaskID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TaskWaitBegin_Asynchronous_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701194, RefRangeEnd = 701195, XrefRangeStart = 701192, XrefRangeEnd = 701194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&OriginatingTaskSchedulerID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &OriginatingTaskID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &TaskID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TaskWaitBegin_Synchronous_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 701197, RefRangeEnd = 701200, XrefRangeStart = 701195, XrefRangeEnd = 701197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&OriginatingTaskSchedulerID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &OriginatingTaskID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &TaskID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TaskWaitEnd_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701202, RefRangeEnd = 701203, XrefRangeStart = 701200, XrefRangeEnd = 701202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&OriginatingTaskSchedulerID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &OriginatingTaskID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &TaskID;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &CreatingTaskID;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &TaskCreationOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TaskScheduled_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TaskTrace(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
