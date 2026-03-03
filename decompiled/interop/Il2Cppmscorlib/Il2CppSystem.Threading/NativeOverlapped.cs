using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

[StructLayout(LayoutKind.Explicit)]
public struct NativeOverlapped
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InternalLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_InternalHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_OffsetLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_OffsetHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_EventHandle;

	[FieldOffset(0)]
	public System.IntPtr InternalLow;

	[FieldOffset(8)]
	public System.IntPtr InternalHigh;

	[FieldOffset(16)]
	public int OffsetLow;

	[FieldOffset(20)]
	public int OffsetHigh;

	[FieldOffset(24)]
	public System.IntPtr EventHandle;

	static NativeOverlapped()
	{
		Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeOverlapped");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr);
		NativeFieldInfoPtr_InternalLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalLow");
		NativeFieldInfoPtr_InternalHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalHigh");
		NativeFieldInfoPtr_OffsetLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetLow");
		NativeFieldInfoPtr_OffsetHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetHigh");
		NativeFieldInfoPtr_EventHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "EventHandle");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
