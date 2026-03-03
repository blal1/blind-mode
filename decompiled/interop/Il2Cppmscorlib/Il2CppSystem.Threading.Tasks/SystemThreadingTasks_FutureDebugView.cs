using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks;

public class SystemThreadingTasks_FutureDebugView<TResult> : Object
{
	static SystemThreadingTasks_FutureDebugView()
	{
		Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SystemThreadingTasks_FutureDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr);
	}

	public SystemThreadingTasks_FutureDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
