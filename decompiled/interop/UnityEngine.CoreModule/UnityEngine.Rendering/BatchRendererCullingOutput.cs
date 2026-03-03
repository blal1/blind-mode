using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchRendererCullingOutput
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cullingJobsFence;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplits;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplitCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewType;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_brgId;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCullingResult;

	[FieldOffset(0)]
	public JobHandle cullingJobsFence;

	[FieldOffset(16)]
	public Matrix4x4 localToWorldMatrix;

	[FieldOffset(80)]
	public System.IntPtr cullingPlanes;

	[FieldOffset(88)]
	public int cullingPlaneCount;

	[FieldOffset(92)]
	public int receiverPlaneOffset;

	[FieldOffset(96)]
	public int receiverPlaneCount;

	[FieldOffset(104)]
	public System.IntPtr cullingSplits;

	[FieldOffset(112)]
	public int cullingSplitCount;

	[FieldOffset(116)]
	public BatchCullingViewType viewType;

	[FieldOffset(120)]
	public BatchCullingProjectionType projectionType;

	[FieldOffset(124)]
	public BatchCullingFlags cullingFlags;

	[FieldOffset(128)]
	public ulong viewID;

	[FieldOffset(136)]
	public uint cullingLayerMask;

	[FieldOffset(140)]
	public byte splitExclusionMask;

	[FieldOffset(144)]
	public ulong sceneCullingMask;

	[FieldOffset(152)]
	public System.IntPtr drawCommands;

	[FieldOffset(160)]
	public uint brgId;

	[FieldOffset(168)]
	public System.IntPtr occlusionBuffer;

	[FieldOffset(176)]
	public System.IntPtr customCullingResult;

	static BatchRendererCullingOutput()
	{
		Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererCullingOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
		NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingJobsFence");
		NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "localToWorldMatrix");
		NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanes");
		NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlaneCount");
		NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneOffset");
		NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneCount");
		NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplits");
		NativeFieldInfoPtr_cullingSplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplitCount");
		NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewType");
		NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "projectionType");
		NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingFlags");
		NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewID");
		NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingLayerMask");
		NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "splitExclusionMask");
		NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "sceneCullingMask");
		NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "drawCommands");
		NativeFieldInfoPtr_brgId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "brgId");
		NativeFieldInfoPtr_occlusionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "occlusionBuffer");
		NativeFieldInfoPtr_customCullingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "customCullingResult");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
