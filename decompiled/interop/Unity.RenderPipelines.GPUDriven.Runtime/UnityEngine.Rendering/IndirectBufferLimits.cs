using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectBufferLimits
{
	private static readonly System.IntPtr NativeFieldInfoPtr_maxInstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDrawCount;

	[FieldOffset(0)]
	public int maxInstanceCount;

	[FieldOffset(4)]
	public int maxDrawCount;

	static IndirectBufferLimits()
	{
		Il2CppClassPointerStore<IndirectBufferLimits>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectBufferLimits");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectBufferLimits>.NativeClassPtr);
		NativeFieldInfoPtr_maxInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferLimits>.NativeClassPtr, "maxInstanceCount");
		NativeFieldInfoPtr_maxDrawCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferLimits>.NativeClassPtr, "maxDrawCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectBufferLimits>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
