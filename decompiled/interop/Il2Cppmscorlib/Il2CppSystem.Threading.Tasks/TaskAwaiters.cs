using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks;

public static class TaskAwaiters : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0;

	static TaskAwaiters()
	{
		Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskAwaiters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr);
		NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiters>.NativeClassPtr, 100668153);
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 772969, RefRangeEnd = 773029, XrefRangeStart = 772968, XrefRangeEnd = 772969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ForceAsyncAwaiter ForceAsync(this Task task)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceAsync_Public_Static_ForceAsyncAwaiter_Task_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ForceAsyncAwaiter(pointer);
	}

	public TaskAwaiters(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
