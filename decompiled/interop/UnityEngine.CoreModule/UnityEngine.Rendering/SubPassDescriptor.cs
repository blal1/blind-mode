using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SubPassDescriptor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorOutputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	[FieldOffset(0)]
	public AttachmentIndexArray inputs;

	[FieldOffset(36)]
	public AttachmentIndexArray colorOutputs;

	[FieldOffset(72)]
	public SubPassFlags flags;

	static SubPassDescriptor()
	{
		Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SubPassDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, "inputs");
		NativeFieldInfoPtr_colorOutputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, "colorOutputs");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, "flags");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubPassDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
