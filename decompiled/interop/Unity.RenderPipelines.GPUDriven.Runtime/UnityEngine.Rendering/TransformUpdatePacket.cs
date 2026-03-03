using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct TransformUpdatePacket
{
	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorld0;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorld1;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorld2;

	[FieldOffset(0)]
	public float4 localToWorld0;

	[FieldOffset(16)]
	public float4 localToWorld1;

	[FieldOffset(32)]
	public float4 localToWorld2;

	static TransformUpdatePacket()
	{
		Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "TransformUpdatePacket");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr);
		NativeFieldInfoPtr_localToWorld0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr, "localToWorld0");
		NativeFieldInfoPtr_localToWorld1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr, "localToWorld1");
		NativeFieldInfoPtr_localToWorld2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr, "localToWorld2");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformUpdatePacket>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
