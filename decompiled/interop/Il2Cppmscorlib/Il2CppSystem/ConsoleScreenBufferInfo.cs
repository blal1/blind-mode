using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct ConsoleScreenBufferInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_CursorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Attribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_Window;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxWindowSize;

	[FieldOffset(0)]
	public Coord Size;

	[FieldOffset(4)]
	public Coord CursorPosition;

	[FieldOffset(8)]
	public short Attribute;

	[FieldOffset(10)]
	public SmallRect Window;

	[FieldOffset(18)]
	public Coord MaxWindowSize;

	static ConsoleScreenBufferInfo()
	{
		Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleScreenBufferInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_CursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "CursorPosition");
		NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Attribute");
		NativeFieldInfoPtr_Window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Window");
		NativeFieldInfoPtr_MaxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "MaxWindowSize");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
