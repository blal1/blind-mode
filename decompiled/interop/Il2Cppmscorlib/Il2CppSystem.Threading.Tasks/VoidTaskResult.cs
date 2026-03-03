using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks;

[StructLayout(LayoutKind.Explicit)]
public struct VoidTaskResult
{
	static VoidTaskResult()
	{
		Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "VoidTaskResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoidTaskResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
