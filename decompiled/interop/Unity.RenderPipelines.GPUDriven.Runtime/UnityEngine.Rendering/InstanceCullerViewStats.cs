using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct InstanceCullerViewStats
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewType;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesOnCPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesOnGPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_visiblePrimitivesOnCPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_visiblePrimitivesOnGPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;

	[FieldOffset(0)]
	public BatchCullingViewType viewType;

	[FieldOffset(4)]
	public int viewInstanceID;

	[FieldOffset(8)]
	public int splitIndex;

	[FieldOffset(12)]
	public int visibleInstancesOnCPU;

	[FieldOffset(16)]
	public int visibleInstancesOnGPU;

	[FieldOffset(20)]
	public int visiblePrimitivesOnCPU;

	[FieldOffset(24)]
	public int visiblePrimitivesOnGPU;

	[FieldOffset(28)]
	public int drawCommands;

	static InstanceCullerViewStats()
	{
		Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullerViewStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr);
		NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "viewType");
		NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "viewInstanceID");
		NativeFieldInfoPtr_splitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "splitIndex");
		NativeFieldInfoPtr_visibleInstancesOnCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "visibleInstancesOnCPU");
		NativeFieldInfoPtr_visibleInstancesOnGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "visibleInstancesOnGPU");
		NativeFieldInfoPtr_visiblePrimitivesOnCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "visiblePrimitivesOnCPU");
		NativeFieldInfoPtr_visiblePrimitivesOnGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "visiblePrimitivesOnGPU");
		NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, "drawCommands");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceCullerViewStats>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
