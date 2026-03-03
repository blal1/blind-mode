using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public static class Runtime : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dump;

	public unsafe static Il2CppSystem.Object dump
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dump, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dump, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Runtime()
	{
		Il2CppClassPointerStore<Runtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "Runtime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Runtime>.NativeClassPtr);
		NativeFieldInfoPtr_dump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Runtime>.NativeClassPtr, "dump");
	}

	public Runtime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
