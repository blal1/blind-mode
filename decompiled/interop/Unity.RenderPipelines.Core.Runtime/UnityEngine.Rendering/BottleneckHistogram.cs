using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BottleneckHistogram
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PresentLimited;

	private static readonly System.IntPtr NativeFieldInfoPtr_CPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_GPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_Balanced;

	[FieldOffset(0)]
	public float PresentLimited;

	[FieldOffset(4)]
	public float CPU;

	[FieldOffset(8)]
	public float GPU;

	[FieldOffset(12)]
	public float Balanced;

	static BottleneckHistogram()
	{
		Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BottleneckHistogram");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr);
		NativeFieldInfoPtr_PresentLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "PresentLimited");
		NativeFieldInfoPtr_CPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "CPU");
		NativeFieldInfoPtr_GPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "GPU");
		NativeFieldInfoPtr_Balanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, "Balanced");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BottleneckHistogram>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
