using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

[StructLayout(LayoutKind.Explicit)]
public struct IntervalTreeNode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_center;

	private static readonly System.IntPtr NativeFieldInfoPtr_first;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_left;

	private static readonly System.IntPtr NativeFieldInfoPtr_right;

	[FieldOffset(0)]
	public long center;

	[FieldOffset(8)]
	public int first;

	[FieldOffset(12)]
	public int last;

	[FieldOffset(16)]
	public int left;

	[FieldOffset(20)]
	public int right;

	static IntervalTreeNode()
	{
		Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IntervalTreeNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr);
		NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "center");
		NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "first");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "last");
		NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "left");
		NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, "right");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntervalTreeNode>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
