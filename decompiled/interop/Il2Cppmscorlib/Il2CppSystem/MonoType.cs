using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public sealed class MonoType : RuntimeType
{
	static MonoType()
	{
		Il2CppClassPointerStore<MonoType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoType>.NativeClassPtr);
	}

	public MonoType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
