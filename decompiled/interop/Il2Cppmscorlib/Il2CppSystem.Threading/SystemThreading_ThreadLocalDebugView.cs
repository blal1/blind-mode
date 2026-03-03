using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading;

public sealed class SystemThreading_ThreadLocalDebugView<T> : Object
{
	static SystemThreading_ThreadLocalDebugView()
	{
		Il2CppClassPointerStore<SystemThreading_ThreadLocalDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SystemThreading_ThreadLocalDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreading_ThreadLocalDebugView<T>>.NativeClassPtr);
	}

	public SystemThreading_ThreadLocalDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
