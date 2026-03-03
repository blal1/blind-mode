using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchID;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshID;

	private static readonly System.IntPtr NativeFieldInfoPtr_submeshIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_unusedPadding2;

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
	public BatchMeshID meshID;

	[FieldOffset(32)]
	public ushort submeshIndex;

	[FieldOffset(34)]
	public ushort unusedPadding2;

	static BatchDrawCommand()
	{
		Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr);
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "batchID");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "splitVisibilityMask");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "lightmapIndex");
		NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "sortingPosition");
		NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleOffset");
		NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleCount");
		NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "meshID");
		NativeFieldInfoPtr_submeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "submeshIndex");
		NativeFieldInfoPtr_unusedPadding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "unusedPadding2");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
