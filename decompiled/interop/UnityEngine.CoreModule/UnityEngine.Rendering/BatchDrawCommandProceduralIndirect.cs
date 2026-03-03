using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommandProceduralIndirect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchID;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_topology;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferWindowOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferWindowSizeBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectArgsBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectArgsBufferOffset;

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
	public MeshTopology topology;

	[FieldOffset(28)]
	public GraphicsBufferHandle indexBufferHandle;

	[FieldOffset(32)]
	public GraphicsBufferHandle visibleInstancesBufferHandle;

	[FieldOffset(36)]
	public uint visibleInstancesBufferWindowOffset;

	[FieldOffset(40)]
	public uint visibleInstancesBufferWindowSizeBytes;

	[FieldOffset(44)]
	public GraphicsBufferHandle indirectArgsBufferHandle;

	[FieldOffset(48)]
	public uint indirectArgsBufferOffset;

	static BatchDrawCommandProceduralIndirect()
	{
		Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommandProceduralIndirect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr);
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "batchID");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "splitVisibilityMask");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "lightmapIndex");
		NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "sortingPosition");
		NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "visibleOffset");
		NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "topology");
		NativeFieldInfoPtr_indexBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "indexBufferHandle");
		NativeFieldInfoPtr_visibleInstancesBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "visibleInstancesBufferHandle");
		NativeFieldInfoPtr_visibleInstancesBufferWindowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "visibleInstancesBufferWindowOffset");
		NativeFieldInfoPtr_visibleInstancesBufferWindowSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "visibleInstancesBufferWindowSizeBytes");
		NativeFieldInfoPtr_indirectArgsBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "indirectArgsBufferHandle");
		NativeFieldInfoPtr_indirectArgsBufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, "indirectArgsBufferOffset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommandProceduralIndirect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
