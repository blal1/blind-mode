using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawBatch
{
	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_procInfo;

	[FieldOffset(0)]
	public DrawKey key;

	[FieldOffset(56)]
	public int instanceCount;

	[FieldOffset(60)]
	public int instanceOffset;

	[FieldOffset(64)]
	public MeshProceduralInfo procInfo;

	static DrawBatch()
	{
		Il2CppClassPointerStore<DrawBatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DrawBatch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr);
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr, "key");
		NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr, "instanceCount");
		NativeFieldInfoPtr_instanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr, "instanceOffset");
		NativeFieldInfoPtr_procInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr, "procInfo");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawBatch>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
