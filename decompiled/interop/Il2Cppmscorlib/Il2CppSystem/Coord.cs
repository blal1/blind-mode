using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct Coord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_X;

	private static readonly System.IntPtr NativeFieldInfoPtr_Y;

	[FieldOffset(0)]
	public short X;

	[FieldOffset(2)]
	public short Y;

	static Coord()
	{
		Il2CppClassPointerStore<Coord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Coord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coord>.NativeClassPtr);
		NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "X");
		NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "Y");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Coord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
