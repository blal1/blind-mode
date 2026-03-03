using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct SmallRect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_Top;

	private static readonly System.IntPtr NativeFieldInfoPtr_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bottom;

	[FieldOffset(0)]
	public short Left;

	[FieldOffset(2)]
	public short Top;

	[FieldOffset(4)]
	public short Right;

	[FieldOffset(6)]
	public short Bottom;

	static SmallRect()
	{
		Il2CppClassPointerStore<SmallRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SmallRect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallRect>.NativeClassPtr);
		NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Left");
		NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Top");
		NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Right");
		NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Bottom");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
