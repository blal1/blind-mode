using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit;

public class ModuleBuilder : Module
{
	static ModuleBuilder()
	{
		Il2CppClassPointerStore<ModuleBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "ModuleBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleBuilder>.NativeClassPtr);
	}

	public ModuleBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
