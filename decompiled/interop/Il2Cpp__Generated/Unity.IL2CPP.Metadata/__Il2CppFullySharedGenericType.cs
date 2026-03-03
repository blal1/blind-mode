using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.Metadata;

[StructLayout(LayoutKind.Explicit)]
public struct __Il2CppFullySharedGenericType
{
	static __Il2CppFullySharedGenericType()
	{
		Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "Unity.IL2CPP.Metadata", "__Il2CppFullySharedGenericType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__Il2CppFullySharedGenericType>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
