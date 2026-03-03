using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct DateTimeToken
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dtt;

	private static readonly System.IntPtr NativeFieldInfoPtr_suffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_num;

	[FieldOffset(0)]
	public DateTimeParse.DTT dtt;

	[FieldOffset(4)]
	public TokenType suffix;

	[FieldOffset(8)]
	public int num;

	static DateTimeToken()
	{
		Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeToken");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr);
		NativeFieldInfoPtr_dtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "dtt");
		NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "suffix");
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "num");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
