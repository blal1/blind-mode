using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct RuntimeArgumentHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_args;

	[FieldOffset(0)]
	public System.IntPtr args;

	static RuntimeArgumentHandle()
	{
		Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeArgumentHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr);
		NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, "args");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
