using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit;

public class ILGenerator : Object
{
	static ILGenerator()
	{
		Il2CppClassPointerStore<ILGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "ILGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILGenerator>.NativeClassPtr);
	}

	public ILGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
