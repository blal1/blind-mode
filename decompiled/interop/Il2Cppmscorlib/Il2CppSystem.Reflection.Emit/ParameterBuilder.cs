using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit;

public class ParameterBuilder : Object
{
	static ParameterBuilder()
	{
		Il2CppClassPointerStore<ParameterBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "ParameterBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterBuilder>.NativeClassPtr);
	}

	public ParameterBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
