using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawRange
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsType;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsBegin;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_filterSettings;

	[FieldOffset(0)]
	public BatchDrawCommandType drawCommandsType;

	[FieldOffset(4)]
	public uint drawCommandsBegin;

	[FieldOffset(8)]
	public uint drawCommandsCount;

	[FieldOffset(16)]
	public BatchFilterSettings filterSettings;

	static BatchDrawRange()
	{
		Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr);
		NativeFieldInfoPtr_drawCommandsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsType");
		NativeFieldInfoPtr_drawCommandsBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsBegin");
		NativeFieldInfoPtr_drawCommandsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsCount");
		NativeFieldInfoPtr_filterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "filterSettings");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
