using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices;

public class FirstChanceExceptionEventArgs : EventArgs
{
	static FirstChanceExceptionEventArgs()
	{
		Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "FirstChanceExceptionEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstChanceExceptionEventArgs>.NativeClassPtr);
	}

	public FirstChanceExceptionEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
