using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ReadCommandArray
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ReadCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommandCount;

	[FieldOffset(0)]
	public System.IntPtr ReadCommands;

	[FieldOffset(8)]
	public int CommandCount;

	static ReadCommandArray()
	{
		Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "ReadCommandArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr);
		NativeFieldInfoPtr_ReadCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, "ReadCommands");
		NativeFieldInfoPtr_CommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, "CommandCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadCommandArray>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
