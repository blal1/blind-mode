using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct PreTile
{
	private static readonly System.IntPtr NativeFieldInfoPtr_planeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_planeRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_planeBottom;

	private static readonly System.IntPtr NativeFieldInfoPtr_planeTop;

	[FieldOffset(0)]
	public float4 planeLeft;

	[FieldOffset(16)]
	public float4 planeRight;

	[FieldOffset(32)]
	public float4 planeBottom;

	[FieldOffset(48)]
	public float4 planeTop;

	static PreTile()
	{
		Il2CppClassPointerStore<PreTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PreTile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreTile>.NativeClassPtr);
		NativeFieldInfoPtr_planeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeLeft");
		NativeFieldInfoPtr_planeRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeRight");
		NativeFieldInfoPtr_planeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeBottom");
		NativeFieldInfoPtr_planeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTile>.NativeClassPtr, "planeTop");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreTile>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
