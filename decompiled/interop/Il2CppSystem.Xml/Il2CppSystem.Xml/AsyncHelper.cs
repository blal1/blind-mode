using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml;

public static class AsyncHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DoneTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoneTaskTrue;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoneTaskFalse;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoneTaskZero;

	public unsafe static Task DoneTask
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoneTask, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoneTask, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Task<bool> DoneTaskTrue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoneTaskTrue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoneTaskTrue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Task<bool> DoneTaskFalse
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoneTaskFalse, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoneTaskFalse, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Task<int> DoneTaskZero
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoneTaskZero, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoneTaskZero, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AsyncHelper()
	{
		Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "AsyncHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr);
		NativeFieldInfoPtr_DoneTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTask");
		NativeFieldInfoPtr_DoneTaskTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskTrue");
		NativeFieldInfoPtr_DoneTaskFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskFalse");
		NativeFieldInfoPtr_DoneTaskZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskZero");
	}

	public AsyncHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
