using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct InstanceOcclusionEventStats
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_culledInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_visiblePrimitives;

	private static readonly System.IntPtr NativeFieldInfoPtr_culledPrimitives;

	[FieldOffset(0)]
	public int viewInstanceID;

	[FieldOffset(4)]
	public InstanceOcclusionEventType eventType;

	[FieldOffset(8)]
	public int occluderVersion;

	[FieldOffset(12)]
	public int subviewMask;

	[FieldOffset(16)]
	public OcclusionTest occlusionTest;

	[FieldOffset(20)]
	public int visibleInstances;

	[FieldOffset(24)]
	public int culledInstances;

	[FieldOffset(28)]
	public int visiblePrimitives;

	[FieldOffset(32)]
	public int culledPrimitives;

	static InstanceOcclusionEventStats()
	{
		Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceOcclusionEventStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr);
		NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "viewInstanceID");
		NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "eventType");
		NativeFieldInfoPtr_occluderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "occluderVersion");
		NativeFieldInfoPtr_subviewMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "subviewMask");
		NativeFieldInfoPtr_occlusionTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "occlusionTest");
		NativeFieldInfoPtr_visibleInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "visibleInstances");
		NativeFieldInfoPtr_culledInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "culledInstances");
		NativeFieldInfoPtr_visiblePrimitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "visiblePrimitives");
		NativeFieldInfoPtr_culledPrimitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, "culledPrimitives");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceOcclusionEventStats>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
