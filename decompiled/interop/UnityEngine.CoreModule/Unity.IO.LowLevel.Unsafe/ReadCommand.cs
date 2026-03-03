using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ReadCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	[FieldOffset(0)]
	public System.IntPtr Buffer;

	[FieldOffset(8)]
	public long Offset;

	[FieldOffset(16)]
	public long Size;

	static ReadCommand()
	{
		Il2CppClassPointerStore<ReadCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "ReadCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr);
		NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, "Buffer");
		NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, "Offset");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, "Size");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadCommand>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
