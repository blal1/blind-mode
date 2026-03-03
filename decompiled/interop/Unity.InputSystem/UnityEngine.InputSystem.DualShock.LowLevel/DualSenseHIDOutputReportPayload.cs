using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DualSenseHIDOutputReportPayload
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableFlags1;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFlags2;

	private static readonly System.IntPtr NativeFieldInfoPtr_highFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_redColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueColor;

	[FieldOffset(0)]
	public byte enableFlags1;

	[FieldOffset(1)]
	public byte enableFlags2;

	[FieldOffset(2)]
	public byte highFrequencyMotorSpeed;

	[FieldOffset(3)]
	public byte lowFrequencyMotorSpeed;

	[FieldOffset(44)]
	public byte redColor;

	[FieldOffset(45)]
	public byte greenColor;

	[FieldOffset(46)]
	public byte blueColor;

	static DualSenseHIDOutputReportPayload()
	{
		Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualSenseHIDOutputReportPayload");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr);
		NativeFieldInfoPtr_enableFlags1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "enableFlags1");
		NativeFieldInfoPtr_enableFlags2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "enableFlags2");
		NativeFieldInfoPtr_highFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "highFrequencyMotorSpeed");
		NativeFieldInfoPtr_lowFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "lowFrequencyMotorSpeed");
		NativeFieldInfoPtr_redColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "redColor");
		NativeFieldInfoPtr_greenColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "greenColor");
		NativeFieldInfoPtr_blueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, "blueColor");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDOutputReportPayload>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
