using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct FastMemoryDesc
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inFastMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_residencyFraction;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool inFastMemory;

	[FieldOffset(4)]
	public FastMemoryFlags flags;

	[FieldOffset(8)]
	public float residencyFraction;

	static FastMemoryDesc()
	{
		Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "FastMemoryDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr);
		NativeFieldInfoPtr_inFastMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "inFastMemory");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_residencyFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, "residencyFraction");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FastMemoryDesc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
