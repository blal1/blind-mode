using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenRendererGroupDataNative
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_localBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapScaleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionVecGenMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedRendererData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupIDCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevLocalToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshID;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDesc;

	private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialIndexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialData;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialFilterFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialCount;

	[FieldOffset(0)]
	public System.IntPtr rendererGroupID;

	[FieldOffset(8)]
	public System.IntPtr localBounds;

	[FieldOffset(16)]
	public System.IntPtr lightmapScaleOffset;

	[FieldOffset(24)]
	public System.IntPtr gameObjectLayer;

	[FieldOffset(32)]
	public System.IntPtr renderingLayerMask;

	[FieldOffset(40)]
	public System.IntPtr lodGroupID;

	[FieldOffset(48)]
	public System.IntPtr motionVecGenMode;

	[FieldOffset(56)]
	public System.IntPtr packedRendererData;

	[FieldOffset(64)]
	public System.IntPtr rendererPriority;

	[FieldOffset(72)]
	public System.IntPtr meshIndex;

	[FieldOffset(80)]
	public System.IntPtr subMeshStartIndex;

	[FieldOffset(88)]
	public System.IntPtr materialsOffset;

	[FieldOffset(96)]
	public System.IntPtr materialsCount;

	[FieldOffset(104)]
	public System.IntPtr instancesOffset;

	[FieldOffset(112)]
	public System.IntPtr instancesCount;

	[FieldOffset(120)]
	public System.IntPtr editorData;

	[FieldOffset(128)]
	public int rendererGroupCount;

	[FieldOffset(136)]
	public System.IntPtr invalidRendererGroupID;

	[FieldOffset(144)]
	public int invalidRendererGroupIDCount;

	[FieldOffset(152)]
	public System.IntPtr localToWorldMatrix;

	[FieldOffset(160)]
	public System.IntPtr prevLocalToWorldMatrix;

	[FieldOffset(168)]
	public System.IntPtr rendererGroupIndex;

	[FieldOffset(176)]
	public int instanceCount;

	[FieldOffset(184)]
	public System.IntPtr meshID;

	[FieldOffset(192)]
	public System.IntPtr subMeshCount;

	[FieldOffset(200)]
	public System.IntPtr subMeshDescOffset;

	[FieldOffset(208)]
	public int meshCount;

	[FieldOffset(216)]
	public System.IntPtr subMeshDesc;

	[FieldOffset(224)]
	public int subMeshDescCount;

	[FieldOffset(232)]
	public System.IntPtr materialIndex;

	[FieldOffset(240)]
	public int materialIndexCount;

	[FieldOffset(248)]
	public System.IntPtr materialID;

	[FieldOffset(256)]
	public System.IntPtr packedMaterialData;

	[FieldOffset(264)]
	public System.IntPtr materialFilterFlags;

	[FieldOffset(272)]
	public int materialCount;

	static GPUDrivenRendererGroupDataNative()
	{
		Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenRendererGroupDataNative");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr);
		NativeFieldInfoPtr_rendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "rendererGroupID");
		NativeFieldInfoPtr_localBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "localBounds");
		NativeFieldInfoPtr_lightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "lightmapScaleOffset");
		NativeFieldInfoPtr_gameObjectLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "gameObjectLayer");
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "lodGroupID");
		NativeFieldInfoPtr_motionVecGenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "motionVecGenMode");
		NativeFieldInfoPtr_packedRendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "packedRendererData");
		NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "rendererPriority");
		NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "meshIndex");
		NativeFieldInfoPtr_subMeshStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "subMeshStartIndex");
		NativeFieldInfoPtr_materialsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialsOffset");
		NativeFieldInfoPtr_materialsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialsCount");
		NativeFieldInfoPtr_instancesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "instancesOffset");
		NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "instancesCount");
		NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "editorData");
		NativeFieldInfoPtr_rendererGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "rendererGroupCount");
		NativeFieldInfoPtr_invalidRendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "invalidRendererGroupID");
		NativeFieldInfoPtr_invalidRendererGroupIDCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "invalidRendererGroupIDCount");
		NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "localToWorldMatrix");
		NativeFieldInfoPtr_prevLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "prevLocalToWorldMatrix");
		NativeFieldInfoPtr_rendererGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "rendererGroupIndex");
		NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "instanceCount");
		NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "meshID");
		NativeFieldInfoPtr_subMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "subMeshCount");
		NativeFieldInfoPtr_subMeshDescOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "subMeshDescOffset");
		NativeFieldInfoPtr_meshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "meshCount");
		NativeFieldInfoPtr_subMeshDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "subMeshDesc");
		NativeFieldInfoPtr_subMeshDescCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "subMeshDescCount");
		NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialIndex");
		NativeFieldInfoPtr_materialIndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialIndexCount");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_packedMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "packedMaterialData");
		NativeFieldInfoPtr_materialFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialFilterFlags");
		NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, "materialCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
