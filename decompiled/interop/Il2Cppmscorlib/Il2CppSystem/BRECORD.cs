using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct BRECORD
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pvRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_pRecInfo;

	[FieldOffset(0)]
	public System.IntPtr pvRecord;

	[FieldOffset(8)]
	public System.IntPtr pRecInfo;

	static BRECORD()
	{
		Il2CppClassPointerStore<BRECORD>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BRECORD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BRECORD>.NativeClassPtr);
		NativeFieldInfoPtr_pvRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pvRecord");
		NativeFieldInfoPtr_pRecInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pRecInfo");
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
