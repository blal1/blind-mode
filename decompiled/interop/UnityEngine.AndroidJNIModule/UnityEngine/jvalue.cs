using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct jvalue
{
	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_s;

	private static readonly System.IntPtr NativeFieldInfoPtr_i;

	private static readonly System.IntPtr NativeFieldInfoPtr_j;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_l;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool z;

	[FieldOffset(0)]
	public sbyte b;

	[FieldOffset(0)]
	public char c;

	[FieldOffset(0)]
	public short s;

	[FieldOffset(0)]
	public int i;

	[FieldOffset(0)]
	public long j;

	[FieldOffset(0)]
	public float f;

	[FieldOffset(0)]
	public double d;

	[FieldOffset(0)]
	public System.IntPtr l;

	static jvalue()
	{
		Il2CppClassPointerStore<jvalue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "jvalue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<jvalue>.NativeClassPtr);
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "z");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "b");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "c");
		NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "s");
		NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "i");
		NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "j");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "f");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "d");
		NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "l");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<jvalue>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
