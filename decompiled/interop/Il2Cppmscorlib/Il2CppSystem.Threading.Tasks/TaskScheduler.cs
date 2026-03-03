using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks;

public class TaskScheduler : Object
{
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView : Object
	{
		static SystemThreadingTasks_TaskSchedulerDebugView()
		{
			Il2CppClassPointerStore<SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "SystemThreadingTasks_TaskSchedulerDebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr);
		}

		public SystemThreadingTasks_TaskSchedulerDebugView(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultTaskScheduler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_taskSchedulerIdCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_taskSchedulerId;

	private static readonly System.IntPtr NativeFieldInfoPtr__unobservedTaskException;

	private static readonly System.IntPtr NativeFieldInfoPtr__unobservedTaskExceptionLockObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0;

	public unsafe static TaskScheduler s_defaultTaskScheduler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_defaultTaskScheduler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_defaultTaskScheduler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_taskSchedulerIdCounter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&value));
		}
	}

	public unsafe int m_taskSchedulerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_taskSchedulerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_taskSchedulerId)) = value;
		}
	}

	public unsafe static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__unobservedTaskException, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler<UnobservedTaskExceptionEventArgs>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__unobservedTaskException, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Lock _unobservedTaskExceptionLockObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__unobservedTaskExceptionLockObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Lock>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__unobservedTaskExceptionLockObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual bool RequiresAtomicStartTransition
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static TaskScheduler Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 776145, XrefRangeEnd = 776149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
		}
	}

	public unsafe static TaskScheduler Current
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 776159, RefRangeEnd = 776161, XrefRangeStart = 776149, XrefRangeEnd = 776159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
		}
	}

	public unsafe static TaskScheduler InternalCurrent
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 776173, RefRangeEnd = 776177, XrefRangeStart = 776161, XrefRangeEnd = 776173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
		}
	}

	public unsafe int Id
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 776186, RefRangeEnd = 776195, XrefRangeStart = 776177, XrefRangeEnd = 776186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TaskScheduler()
	{
		Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskScheduler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr);
		NativeFieldInfoPtr_s_defaultTaskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_defaultTaskScheduler");
		NativeFieldInfoPtr_s_taskSchedulerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_taskSchedulerIdCounter");
		NativeFieldInfoPtr_m_taskSchedulerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "m_taskSchedulerId");
		NativeFieldInfoPtr__unobservedTaskException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskException");
		NativeFieldInfoPtr__unobservedTaskExceptionLockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskExceptionLockObject");
		NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668437);
		NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668438);
		NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668439);
		NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668440);
		NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668441);
		NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668442);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668443);
		NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668444);
		NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668445);
		NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668446);
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668447);
		NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100668448);
	}

	[CallerCount(0)]
	public unsafe virtual void QueueTask(Task task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskWasPreviouslyQueued;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 776142, RefRangeEnd = 776145, XrefRangeStart = 776140, XrefRangeEnd = 776142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskWasPreviouslyQueued;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool TryDequeue(Task task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NotifyWorkItemProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskScheduler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 776207, RefRangeEnd = 776208, XrefRangeStart = 776195, XrefRangeEnd = 776207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PublishUnobservedTaskException(Object sender, UnobservedTaskExceptionEventArgs ueea)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ueea);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TaskScheduler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
