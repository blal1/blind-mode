using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectDrawInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_indexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseVertex;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstInstanceGlobalIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxInstanceCountAndTopology;

	[FieldOffset(0)]
	public uint indexCount;

	[FieldOffset(4)]
	public uint firstIndex;

	[FieldOffset(8)]
	public uint baseVertex;

	[FieldOffset(12)]
	public uint firstInstanceGlobalIndex;

	[FieldOffset(16)]
	public uint maxInstanceCountAndTopology;

	static IndirectDrawInfo()
	{
		Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectDrawInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr);
		NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, "indexCount");
		NativeFieldInfoPtr_firstIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, "firstIndex");
		NativeFieldInfoPtr_baseVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, "baseVertex");
		NativeFieldInfoPtr_firstInstanceGlobalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, "firstInstanceGlobalIndex");
		NativeFieldInfoPtr_maxInstanceCountAndTopology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, "maxInstanceCountAndTopology");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectDrawInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
