using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommandIndirect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchID;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshID;

	private static readonly System.IntPtr NativeFieldInfoPtr_topology;

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
	public BatchMeshID meshID;

	[FieldOffset(28)]
	public MeshTopology topology;

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

	static BatchDrawCommandIndirect()
	{
		Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommandIndirect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr);
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "batchID");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "splitVisibilityMask");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "lightmapIndex");
		NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "sortingPosition");
		NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "visibleOffset");
		NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "meshID");
		NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "topology");
		NativeFieldInfoPtr_visibleInstancesBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "visibleInstancesBufferHandle");
		NativeFieldInfoPtr_visibleInstancesBufferWindowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "visibleInstancesBufferWindowOffset");
		NativeFieldInfoPtr_visibleInstancesBufferWindowSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "visibleInstancesBufferWindowSizeBytes");
		NativeFieldInfoPtr_indirectArgsBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "indirectArgsBufferHandle");
		NativeFieldInfoPtr_indirectArgsBufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, "indirectArgsBufferOffset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
