using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

public sealed class Mutex : WaitHandle
{
	static Mutex()
	{
		Il2CppClassPointerStore<Mutex>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Mutex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mutex>.NativeClassPtr);
	}

	public Mutex(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
