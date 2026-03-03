using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OccluderMipBounds
{
	private static readonly System.IntPtr NativeFieldInfoPtr_offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	[FieldOffset(0)]
	public Vector2Int offset;

	[FieldOffset(8)]
	public Vector2Int size;

	static OccluderMipBounds()
	{
		Il2CppClassPointerStore<OccluderMipBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderMipBounds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderMipBounds>.NativeClassPtr);
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderMipBounds>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderMipBounds>.NativeClassPtr, "size");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderMipBounds>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
