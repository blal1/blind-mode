using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct MeshProceduralInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_topology;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseVertex;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexCount;

	[FieldOffset(0)]
	public MeshTopology topology;

	[FieldOffset(4)]
	public uint baseVertex;

	[FieldOffset(8)]
	public uint firstIndex;

	[FieldOffset(12)]
	public uint indexCount;

	static MeshProceduralInfo()
	{
		Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "MeshProceduralInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr);
		NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr, "topology");
		NativeFieldInfoPtr_baseVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr, "baseVertex");
		NativeFieldInfoPtr_firstIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr, "firstIndex");
		NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr, "indexCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshProceduralInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
