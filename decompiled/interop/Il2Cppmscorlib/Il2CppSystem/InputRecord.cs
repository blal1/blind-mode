using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct InputRecord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepeatCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirtualKeyCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_VirtualScanCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_Character;

	private static readonly System.IntPtr NativeFieldInfoPtr_ControlKeyState;

	private static readonly System.IntPtr NativeFieldInfoPtr_pad1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pad2;

	[FieldOffset(0)]
	public short EventType;

	[FieldOffset(2)]
	[MarshalAs(UnmanagedType.U1)]
	public bool KeyDown;

	[FieldOffset(4)]
	public short RepeatCount;

	[FieldOffset(6)]
	public short VirtualKeyCode;

	[FieldOffset(8)]
	public short VirtualScanCode;

	[FieldOffset(10)]
	public char Character;

	[FieldOffset(12)]
	public int ControlKeyState;

	[FieldOffset(16)]
	public int pad1;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool pad2;

	static InputRecord()
	{
		Il2CppClassPointerStore<InputRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InputRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRecord>.NativeClassPtr);
		NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "EventType");
		NativeFieldInfoPtr_KeyDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "KeyDown");
		NativeFieldInfoPtr_RepeatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "RepeatCount");
		NativeFieldInfoPtr_VirtualKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualKeyCode");
		NativeFieldInfoPtr_VirtualScanCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualScanCode");
		NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "Character");
		NativeFieldInfoPtr_ControlKeyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "ControlKeyState");
		NativeFieldInfoPtr_pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad1");
		NativeFieldInfoPtr_pad2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad2");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
