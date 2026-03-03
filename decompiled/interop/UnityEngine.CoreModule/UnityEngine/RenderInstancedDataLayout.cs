using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderInstancedDataLayout
{
	private static readonly System.IntPtr NativeFieldInfoPtr__size_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField;

	[FieldOffset(0)]
	public readonly int _size_k__BackingField;

	[FieldOffset(4)]
	public readonly int _offsetObjectToWorld_k__BackingField;

	[FieldOffset(8)]
	public readonly int _offsetPrevObjectToWorld_k__BackingField;

	[FieldOffset(12)]
	public readonly int _offsetRenderingLayerMask_k__BackingField;

	public int size => _size_k__BackingField;

	public int offsetObjectToWorld => _offsetObjectToWorld_k__BackingField;

	public int offsetPrevObjectToWorld => _offsetPrevObjectToWorld_k__BackingField;

	public int offsetRenderingLayerMask => _offsetRenderingLayerMask_k__BackingField;

	static RenderInstancedDataLayout()
	{
		Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderInstancedDataLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr);
		NativeFieldInfoPtr__size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<size>k__BackingField");
		NativeFieldInfoPtr__offsetObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetObjectToWorld>k__BackingField");
		NativeFieldInfoPtr__offsetPrevObjectToWorld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetPrevObjectToWorld>k__BackingField");
		NativeFieldInfoPtr__offsetRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, "<offsetRenderingLayerMask>k__BackingField");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderInstancedDataLayout>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
