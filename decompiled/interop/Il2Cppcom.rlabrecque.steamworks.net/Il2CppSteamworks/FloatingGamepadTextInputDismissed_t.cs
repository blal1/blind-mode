using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct FloatingGamepadTextInputDismissed_t
{
	static FloatingGamepadTextInputDismissed_t()
	{
		Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "FloatingGamepadTextInputDismissed_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatingGamepadTextInputDismissed_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
