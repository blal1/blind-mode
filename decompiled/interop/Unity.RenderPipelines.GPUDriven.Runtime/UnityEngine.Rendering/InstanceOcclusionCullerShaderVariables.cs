using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct InstanceOcclusionCullerShaderVariables
{
	private static readonly System.IntPtr NativeFieldInfoPtr__DrawInfoAllocIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__DrawInfoCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__InstanceInfoAllocIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__InstanceInfoCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__BoundingSphereInstanceDataAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr__DebugCounterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__InstanceMultiplierShift;

	private static readonly System.IntPtr NativeFieldInfoPtr__InstanceOcclusionCullerPad0;

	[FieldOffset(0)]
	public uint _DrawInfoAllocIndex;

	[FieldOffset(4)]
	public uint _DrawInfoCount;

	[FieldOffset(8)]
	public uint _InstanceInfoAllocIndex;

	[FieldOffset(12)]
	public uint _InstanceInfoCount;

	[FieldOffset(16)]
	public int _BoundingSphereInstanceDataAddress;

	[FieldOffset(20)]
	public int _DebugCounterIndex;

	[FieldOffset(24)]
	public int _InstanceMultiplierShift;

	[FieldOffset(28)]
	public int _InstanceOcclusionCullerPad0;

	static InstanceOcclusionCullerShaderVariables()
	{
		Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceOcclusionCullerShaderVariables");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr);
		NativeFieldInfoPtr__DrawInfoAllocIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_DrawInfoAllocIndex");
		NativeFieldInfoPtr__DrawInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_DrawInfoCount");
		NativeFieldInfoPtr__InstanceInfoAllocIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_InstanceInfoAllocIndex");
		NativeFieldInfoPtr__InstanceInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_InstanceInfoCount");
		NativeFieldInfoPtr__BoundingSphereInstanceDataAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_BoundingSphereInstanceDataAddress");
		NativeFieldInfoPtr__DebugCounterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_DebugCounterIndex");
		NativeFieldInfoPtr__InstanceMultiplierShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_InstanceMultiplierShift");
		NativeFieldInfoPtr__InstanceOcclusionCullerPad0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, "_InstanceOcclusionCullerPad0");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceOcclusionCullerShaderVariables>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
