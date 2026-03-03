using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CPUSharedInstanceFlags
{
	private static readonly System.IntPtr NativeFieldInfoPtr_transformUpdateFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceFlags;

	[FieldOffset(0)]
	public TransformUpdateFlags transformUpdateFlags;

	[FieldOffset(1)]
	public InstanceFlags instanceFlags;

	static CPUSharedInstanceFlags()
	{
		Il2CppClassPointerStore<CPUSharedInstanceFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CPUSharedInstanceFlags");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CPUSharedInstanceFlags>.NativeClassPtr);
		NativeFieldInfoPtr_transformUpdateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceFlags>.NativeClassPtr, "transformUpdateFlags");
		NativeFieldInfoPtr_instanceFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceFlags>.NativeClassPtr, "instanceFlags");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceFlags>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
