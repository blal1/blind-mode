using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawRange
{
	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawOffset;

	[FieldOffset(0)]
	public RangeKey key;

	[FieldOffset(28)]
	public int drawCount;

	[FieldOffset(32)]
	public int drawOffset;

	static DrawRange()
	{
		Il2CppClassPointerStore<DrawRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DrawRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawRange>.NativeClassPtr);
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawRange>.NativeClassPtr, "key");
		NativeFieldInfoPtr_drawCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawRange>.NativeClassPtr, "drawCount");
		NativeFieldInfoPtr_drawOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawRange>.NativeClassPtr, "drawOffset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
