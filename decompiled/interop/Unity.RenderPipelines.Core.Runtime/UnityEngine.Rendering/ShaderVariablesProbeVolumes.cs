using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShaderVariablesProbeVolumes
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Offset_LayerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__MinLoadedCellInEntries_IndirectionEntryDim;

	private static readonly System.IntPtr NativeFieldInfoPtr__MaxLoadedCellInEntries_RcpIndirectionEntryDim;

	private static readonly System.IntPtr NativeFieldInfoPtr__PoolDim_MinBrickSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__RcpPoolDim_XY;

	private static readonly System.IntPtr NativeFieldInfoPtr__MinEntryPos_Noise;

	private static readonly System.IntPtr NativeFieldInfoPtr__EntryCount_X_XY_LeakReduction;

	private static readonly System.IntPtr NativeFieldInfoPtr__Biases_NormalizationClamp;

	private static readonly System.IntPtr NativeFieldInfoPtr__FrameIndex_Weights;

	private static readonly System.IntPtr NativeFieldInfoPtr__ProbeVolumeLayerMask;

	[FieldOffset(0)]
	public Vector4 _Offset_LayerCount;

	[FieldOffset(16)]
	public Vector4 _MinLoadedCellInEntries_IndirectionEntryDim;

	[FieldOffset(32)]
	public Vector4 _MaxLoadedCellInEntries_RcpIndirectionEntryDim;

	[FieldOffset(48)]
	public Vector4 _PoolDim_MinBrickSize;

	[FieldOffset(64)]
	public Vector4 _RcpPoolDim_XY;

	[FieldOffset(80)]
	public Vector4 _MinEntryPos_Noise;

	[FieldOffset(96)]
	public uint4 _EntryCount_X_XY_LeakReduction;

	[FieldOffset(112)]
	public Vector4 _Biases_NormalizationClamp;

	[FieldOffset(128)]
	public Vector4 _FrameIndex_Weights;

	[FieldOffset(144)]
	public uint4 _ProbeVolumeLayerMask;

	static ShaderVariablesProbeVolumes()
	{
		Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderVariablesProbeVolumes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr);
		NativeFieldInfoPtr__Offset_LayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_Offset_LayerCount");
		NativeFieldInfoPtr__MinLoadedCellInEntries_IndirectionEntryDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_MinLoadedCellInEntries_IndirectionEntryDim");
		NativeFieldInfoPtr__MaxLoadedCellInEntries_RcpIndirectionEntryDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_MaxLoadedCellInEntries_RcpIndirectionEntryDim");
		NativeFieldInfoPtr__PoolDim_MinBrickSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_PoolDim_MinBrickSize");
		NativeFieldInfoPtr__RcpPoolDim_XY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_RcpPoolDim_XY");
		NativeFieldInfoPtr__MinEntryPos_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_MinEntryPos_Noise");
		NativeFieldInfoPtr__EntryCount_X_XY_LeakReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_EntryCount_X_XY_LeakReduction");
		NativeFieldInfoPtr__Biases_NormalizationClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_Biases_NormalizationClamp");
		NativeFieldInfoPtr__FrameIndex_Weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_FrameIndex_Weights");
		NativeFieldInfoPtr__ProbeVolumeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, "_ProbeVolumeLayerMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderVariablesProbeVolumes>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
