using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

[StructLayout(LayoutKind.Explicit)]
public struct GamepadTextInputDismissed_t
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_bSubmitted;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_unSubmittedText;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_bSubmitted;

	[FieldOffset(4)]
	public uint m_unSubmittedText;

	static GamepadTextInputDismissed_t()
	{
		Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "GamepadTextInputDismissed_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_bSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_bSubmitted");
		NativeFieldInfoPtr_m_unSubmittedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_unSubmittedText");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
