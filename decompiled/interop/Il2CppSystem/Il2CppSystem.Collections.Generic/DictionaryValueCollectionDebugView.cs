using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic;

public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
{
	static DictionaryValueCollectionDebugView()
	{
		Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
	}

	public DictionaryValueCollectionDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
