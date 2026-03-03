using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct Void
{
	static Void()
	{
		Il2CppClassPointerStore<Void>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Void");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Void>.NativeClassPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Void>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
