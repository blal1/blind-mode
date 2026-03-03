using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic;

public sealed class DictionaryKeyCollectionDebugView<TKey, TValue> : Object
{
	static DictionaryKeyCollectionDebugView()
	{
		Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryKeyCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr);
	}

	public DictionaryKeyCollectionDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
