using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks;

public class AwaitTaskContinuation : TaskContinuation
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_capturedContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_action;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invokeActionCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0;

	public unsafe ExecutionContext m_capturedContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capturedContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capturedContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Action m_action
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_action);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ContextCallback s_invokeActionCallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invokeActionCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invokeActionCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsValidLocationForInlining
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 775803, RefRangeEnd = 775806, XrefRangeStart = 775794, XrefRangeEnd = 775803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AwaitTaskContinuation()
	{
		Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AwaitTaskContinuation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr);
		NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_capturedContext");
		NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_action");
		NativeFieldInfoPtr_s_invokeActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "s_invokeActionCallback");
		NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668396);
		NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668397);
		NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668398);
		NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668399);
		NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668400);
		NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668401);
		NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668402);
		NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668403);
		NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668404);
		NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668405);
		NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668406);
		NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100668407);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 775778, RefRangeEnd = 775781, XrefRangeStart = 775771, XrefRangeEnd = 775778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flowExecutionContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775781, XrefRangeEnd = 775786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task CreateTask(Action<Object> action, Object state, TaskScheduler scheduler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheduler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775786, XrefRangeEnd = 775794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Run(Task ignored, bool canInlineContinuationTask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignored);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canInlineContinuationTask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775806, XrefRangeEnd = 775812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775812, XrefRangeEnd = 775816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAction(Object state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775816, XrefRangeEnd = 775827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ContextCallback GetInvokeActionCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 775836, RefRangeEnd = 775839, XrefRangeStart = 775827, XrefRangeEnd = 775836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunCallback(ContextCallback callback, Object state, ref Task currentTask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentTask);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		currentTask = ((intPtr4 == (System.IntPtr)0) ? null : new Task(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775839, XrefRangeEnd = 775849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowInlining;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentTask);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		currentTask = ((intPtr4 == (System.IntPtr)0) ? null : new Task(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 775856, RefRangeEnd = 775858, XrefRangeStart = 775849, XrefRangeEnd = 775856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnsafeScheduleAction(Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 775862, RefRangeEnd = 775865, XrefRangeStart = 775858, XrefRangeEnd = 775862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowAsyncIfNecessary(Exception exc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MarkAborted(ThreadAbortException e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAborted_Public_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AwaitTaskContinuation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
