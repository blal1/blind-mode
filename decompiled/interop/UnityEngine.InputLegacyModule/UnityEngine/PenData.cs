using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct PenData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilt;

	private static readonly System.IntPtr NativeFieldInfoPtr_penStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_twist;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_contactType;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaPos;

	[FieldOffset(0)]
	public Vector2 position;

	[FieldOffset(8)]
	public Vector2 tilt;

	[FieldOffset(16)]
	public PenStatus penStatus;

	[FieldOffset(20)]
	public float twist;

	[FieldOffset(24)]
	public float pressure;

	[FieldOffset(28)]
	public PenEventType contactType;

	[FieldOffset(32)]
	public Vector2 deltaPos;

	static PenData()
	{
		Il2CppClassPointerStore<PenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "PenData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenData>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "position");
		NativeFieldInfoPtr_tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "tilt");
		NativeFieldInfoPtr_penStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "penStatus");
		NativeFieldInfoPtr_twist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "twist");
		NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "pressure");
		NativeFieldInfoPtr_contactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "contactType");
		NativeFieldInfoPtr_deltaPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "deltaPos");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PenData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
