using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections;

public sealed class NativeArrayDebugView<T> : Il2CppSystem.Object where T : new()
{
	public Il2CppArrayBase<T> Items
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static NativeArrayDebugView()
	{
		Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr);
	}

	public NativeArrayDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
