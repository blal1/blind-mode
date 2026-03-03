using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DebugOccluderStats
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderMipLayoutSize;

	[FieldOffset(0)]
	public int viewInstanceID;

	[FieldOffset(4)]
	public int subviewCount;

	[FieldOffset(8)]
	public Vector2Int occluderMipLayoutSize;

	static DebugOccluderStats()
	{
		Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DebugOccluderStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr);
		NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr, "viewInstanceID");
		NativeFieldInfoPtr_subviewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr, "subviewCount");
		NativeFieldInfoPtr_occluderMipLayoutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr, "occluderMipLayoutSize");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugOccluderStats>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
