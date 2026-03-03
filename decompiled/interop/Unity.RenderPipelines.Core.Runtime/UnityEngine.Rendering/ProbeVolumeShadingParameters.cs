using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ProbeVolumeShadingParameters
{
	private static readonly System.IntPtr NativeFieldInfoPtr_normalBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleBiasByMinDistanceBetweenProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_samplingNoise;

	private static readonly System.IntPtr NativeFieldInfoPtr_weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_leakReductionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameIndexForNoise;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflNormalizationLowerClamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflNormalizationUpperClamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionShadingDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionLayerMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldOffset;

	[FieldOffset(0)]
	public float normalBias;

	[FieldOffset(4)]
	public float viewBias;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool scaleBiasByMinDistanceBetweenProbes;

	[FieldOffset(12)]
	public float samplingNoise;

	[FieldOffset(16)]
	public float weight;

	[FieldOffset(20)]
	public APVLeakReductionMode leakReductionMode;

	[FieldOffset(24)]
	public int frameIndexForNoise;

	[FieldOffset(28)]
	public float reflNormalizationLowerClamp;

	[FieldOffset(32)]
	public float reflNormalizationUpperClamp;

	[FieldOffset(36)]
	public float skyOcclusionIntensity;

	[FieldOffset(40)]
	[MarshalAs(UnmanagedType.U1)]
	public bool skyOcclusionShadingDirection;

	[FieldOffset(44)]
	public int regionCount;

	[FieldOffset(48)]
	public uint4 regionLayerMasks;

	[FieldOffset(64)]
	public Vector3 worldOffset;

	static ProbeVolumeShadingParameters()
	{
		Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeShadingParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr);
		NativeFieldInfoPtr_normalBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "normalBias");
		NativeFieldInfoPtr_viewBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "viewBias");
		NativeFieldInfoPtr_scaleBiasByMinDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "scaleBiasByMinDistanceBetweenProbes");
		NativeFieldInfoPtr_samplingNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "samplingNoise");
		NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "weight");
		NativeFieldInfoPtr_leakReductionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "leakReductionMode");
		NativeFieldInfoPtr_frameIndexForNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "frameIndexForNoise");
		NativeFieldInfoPtr_reflNormalizationLowerClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "reflNormalizationLowerClamp");
		NativeFieldInfoPtr_reflNormalizationUpperClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "reflNormalizationUpperClamp");
		NativeFieldInfoPtr_skyOcclusionIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "skyOcclusionIntensity");
		NativeFieldInfoPtr_skyOcclusionShadingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "skyOcclusionShadingDirection");
		NativeFieldInfoPtr_regionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "regionCount");
		NativeFieldInfoPtr_regionLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "regionLayerMasks");
		NativeFieldInfoPtr_worldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, "worldOffset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeShadingParameters>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
