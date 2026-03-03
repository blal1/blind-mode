using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct PunctualLightData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wsPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_attenuation;

	private static readonly System.IntPtr NativeFieldInfoPtr_spotDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionProbeInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;

	[FieldOffset(0)]
	public Vector3 wsPos;

	[FieldOffset(12)]
	public float radius;

	[FieldOffset(16)]
	public Vector4 color;

	[FieldOffset(32)]
	public Vector4 attenuation;

	[FieldOffset(48)]
	public Vector3 spotDirection;

	[FieldOffset(60)]
	public int flags;

	[FieldOffset(64)]
	public Vector4 occlusionProbeInfo;

	[FieldOffset(80)]
	public uint layerMask;

	static PunctualLightData()
	{
		Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PunctualLightData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr);
		NativeFieldInfoPtr_wsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "wsPos");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "color");
		NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "attenuation");
		NativeFieldInfoPtr_spotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "spotDirection");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_occlusionProbeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "occlusionProbeInfo");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, "layerMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PunctualLightData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
