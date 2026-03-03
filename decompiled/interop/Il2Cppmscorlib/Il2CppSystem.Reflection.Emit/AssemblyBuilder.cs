using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit;

public class AssemblyBuilder : Assembly
{
	static AssemblyBuilder()
	{
		Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "AssemblyBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr);
	}

	public AssemblyBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
