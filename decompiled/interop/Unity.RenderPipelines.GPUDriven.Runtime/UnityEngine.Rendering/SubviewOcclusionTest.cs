using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SubviewOcclusionTest
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplitIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderSubviewIndex;

	[FieldOffset(0)]
	public int cullingSplitIndex;

	[FieldOffset(4)]
	public int occluderSubviewIndex;

	static SubviewOcclusionTest()
	{
		Il2CppClassPointerStore<SubviewOcclusionTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "SubviewOcclusionTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubviewOcclusionTest>.NativeClassPtr);
		NativeFieldInfoPtr_cullingSplitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubviewOcclusionTest>.NativeClassPtr, "cullingSplitIndex");
		NativeFieldInfoPtr_occluderSubviewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubviewOcclusionTest>.NativeClassPtr, "occluderSubviewIndex");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubviewOcclusionTest>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
