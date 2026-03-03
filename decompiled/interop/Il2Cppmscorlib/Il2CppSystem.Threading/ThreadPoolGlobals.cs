using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public static class ThreadPoolGlobals : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_processorCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_vmTpInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableWorkerTracking;

	private static readonly System.IntPtr NativeFieldInfoPtr_workQueue;

	public unsafe static int processorCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_processorCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_processorCount, (void*)(&value));
		}
	}

	public unsafe static bool vmTpInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vmTpInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vmTpInitialized, (void*)(&value));
		}
	}

	public unsafe static bool enableWorkerTracking
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enableWorkerTracking, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enableWorkerTracking, (void*)(&value));
		}
	}

	public unsafe static ThreadPoolWorkQueue workQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_workQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_workQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ThreadPoolGlobals()
	{
		Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolGlobals");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr);
		NativeFieldInfoPtr_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "processorCount");
		NativeFieldInfoPtr_vmTpInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "vmTpInitialized");
		NativeFieldInfoPtr_enableWorkerTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "enableWorkerTracking");
		NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "workQueue");
	}

	public ThreadPoolGlobals(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
