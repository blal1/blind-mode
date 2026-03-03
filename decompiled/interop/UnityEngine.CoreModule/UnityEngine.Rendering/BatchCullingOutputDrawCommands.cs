using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchCullingOutputDrawCommands
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectDrawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_proceduralDrawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_proceduralIndirectDrawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceSortingPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandPickingInstanceIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectDrawCommandCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_proceduralDrawCommandCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_proceduralIndirectDrawCommandCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawRangeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceSortingPositionFloatCount;

	[FieldOffset(0)]
	public System.IntPtr drawCommands;

	[FieldOffset(8)]
	public System.IntPtr indirectDrawCommands;

	[FieldOffset(16)]
	public System.IntPtr proceduralDrawCommands;

	[FieldOffset(24)]
	public System.IntPtr proceduralIndirectDrawCommands;

	[FieldOffset(32)]
	public System.IntPtr visibleInstances;

	[FieldOffset(40)]
	public System.IntPtr drawRanges;

	[FieldOffset(48)]
	public System.IntPtr instanceSortingPositions;

	[FieldOffset(56)]
	public System.IntPtr drawCommandPickingInstanceIDs;

	[FieldOffset(64)]
	public int drawCommandCount;

	[FieldOffset(68)]
	public int indirectDrawCommandCount;

	[FieldOffset(72)]
	public int proceduralDrawCommandCount;

	[FieldOffset(76)]
	public int proceduralIndirectDrawCommandCount;

	[FieldOffset(80)]
	public int visibleInstanceCount;

	[FieldOffset(84)]
	public int drawRangeCount;

	[FieldOffset(88)]
	public int instanceSortingPositionFloatCount;

	static BatchCullingOutputDrawCommands()
	{
		Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutputDrawCommands");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr);
		NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommands");
		NativeFieldInfoPtr_indirectDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "indirectDrawCommands");
		NativeFieldInfoPtr_proceduralDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "proceduralDrawCommands");
		NativeFieldInfoPtr_proceduralIndirectDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "proceduralIndirectDrawCommands");
		NativeFieldInfoPtr_visibleInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstances");
		NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRanges");
		NativeFieldInfoPtr_instanceSortingPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositions");
		NativeFieldInfoPtr_drawCommandPickingInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandPickingInstanceIDs");
		NativeFieldInfoPtr_drawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandCount");
		NativeFieldInfoPtr_indirectDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "indirectDrawCommandCount");
		NativeFieldInfoPtr_proceduralDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "proceduralDrawCommandCount");
		NativeFieldInfoPtr_proceduralIndirectDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "proceduralIndirectDrawCommandCount");
		NativeFieldInfoPtr_visibleInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstanceCount");
		NativeFieldInfoPtr_drawRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRangeCount");
		NativeFieldInfoPtr_instanceSortingPositionFloatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositionFloatCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
