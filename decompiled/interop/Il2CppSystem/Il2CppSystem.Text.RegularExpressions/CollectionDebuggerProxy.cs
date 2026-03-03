using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class CollectionDebuggerProxy<T> : Object
{
	static CollectionDebuggerProxy()
	{
		Il2CppClassPointerStore<CollectionDebuggerProxy<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CollectionDebuggerProxy`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionDebuggerProxy<T>>.NativeClassPtr);
	}

	public CollectionDebuggerProxy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
