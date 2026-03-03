using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommandProcedural
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchID;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_topology;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseVertex;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexOffsetBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementCount;

	[FieldOffset(0)]
	public BatchDrawCommandFlags flags;

	[FieldOffset(4)]
	public BatchID batchID;

	[FieldOffset(8)]
	public BatchMaterialID materialID;

	[FieldOffset(12)]
	public ushort splitVisibilityMask;

	[FieldOffset(14)]
	public ushort lightmapIndex;

	[FieldOffset(16)]
	public int sortingPosition;

	[FieldOffset(20)]
	public uint visibleOffset;

	[FieldOffset(24)]
	public uint visibleCount;

	[FieldOffset(28)]
	public MeshTopology topology;

	[FieldOffset(32)]
	public GraphicsBufferHandle indexBufferHandle;

	[FieldOffset(36)]
	public uint baseVertex;

	[FieldOffset(40)]
	public uint indexOffsetBytes;

	[FieldOffset(44)]
	public uint elementCount;

	static BatchDrawCommandProcedural()
	{
		Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommandProcedural");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr);
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "batchID");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "splitVisibilityMask");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "lightmapIndex");
		NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "sortingPosition");
		NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "visibleOffset");
		NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "visibleCount");
		NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "topology");
		NativeFieldInfoPtr_indexBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "indexBufferHandle");
		NativeFieldInfoPtr_baseVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "baseVertex");
		NativeFieldInfoPtr_indexOffsetBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "indexOffsetBytes");
		NativeFieldInfoPtr_elementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, "elementCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
