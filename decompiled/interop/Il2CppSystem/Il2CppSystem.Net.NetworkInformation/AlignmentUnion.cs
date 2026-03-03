using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation;

[StructLayout(LayoutKind.Explicit)]
public struct AlignmentUnion
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Alignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_IfIndex;

	[FieldOffset(0)]
	public ulong Alignment;

	[FieldOffset(0)]
	public int Length;

	[FieldOffset(4)]
	public int IfIndex;

	static AlignmentUnion()
	{
		Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "AlignmentUnion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr);
		NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr, "Alignment");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_IfIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr, "IfIndex");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlignmentUnion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
