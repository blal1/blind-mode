using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks;

public class TaskContinuation : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static TaskContinuation()
	{
		Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskContinuation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr);
		NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668378);
		NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668379);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr, 100668380);
	}

	[CallerCount(0)]
	public unsafe virtual void Run(Task completedTask, bool bCanInlineContinuationTask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)completedTask);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bCanInlineContinuationTask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Run_Internal_Abstract_Virtual_New_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775610, RefRangeEnd = 775611, XrefRangeStart = 775599, XrefRangeEnd = 775610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needsProtection;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InlineIfPossibleOrElseQueue_Protected_Static_Void_Task_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TaskContinuation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskContinuation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TaskContinuation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
