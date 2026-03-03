using System;
using System.Runtime.CompilerServices;
using Il2CppInternal.Runtime.Augments;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Threading.Tasks;

public static class DebuggerSupport : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_activeTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_activeTasksLock;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0;

	public unsafe static LowLevelDictionary<int, Task> s_activeTasks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_activeTasks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LowLevelDictionary<int, Task>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_activeTasks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object s_activeTasksLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_activeTasksLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_activeTasksLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool LoggingOn
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DebuggerSupport()
	{
		Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "DebuggerSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr);
		NativeFieldInfoPtr_s_activeTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, "s_activeTasks");
		NativeFieldInfoPtr_s_activeTasksLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, "s_activeTasksLock");
		NativeMethodInfoPtr_get_LoggingOn_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668159);
		NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668160);
		NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668161);
		NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668162);
		NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668163);
		NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668164);
		NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668165);
		NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668166);
		NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668167);
		NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerSupport>.NativeClassPtr, 100668168);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&traceLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(operationName);
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &relatedContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceOperationCreation_Public_Static_Void_CausalityTraceLevel_Task_String_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&traceLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(AsyncStatus**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &status;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceOperationCompletion_Public_Static_Void_CausalityTraceLevel_Task_AsyncStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&traceLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(CausalityRelation**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &relation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceOperationRelation_Public_Static_Void_CausalityTraceLevel_Task_CausalityRelation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&traceLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(CausalitySynchronousWork**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &work;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceSynchronousWorkStart_Public_Static_Void_CausalityTraceLevel_Task_CausalitySynchronousWork_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&traceLevel);
		*(CausalitySynchronousWork**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &work;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Public_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773035, XrefRangeEnd = 773043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddToActiveTasks(Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToActiveTasks_Public_Static_Void_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773058, RefRangeEnd = 773059, XrefRangeStart = 773043, XrefRangeEnd = 773058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddToActiveTasksNonInlined(Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToActiveTasksNonInlined_Private_Static_Void_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773059, XrefRangeEnd = 773067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveFromActiveTasks(Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromActiveTasks_Public_Static_Void_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 773082, RefRangeEnd = 773083, XrefRangeStart = 773067, XrefRangeEnd = 773082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveFromActiveTasksNonInlined(Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromActiveTasksNonInlined_Private_Static_Void_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebuggerSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
