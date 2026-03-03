using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public class Graphics : Il2CppSystem.Object
{
	private delegate ColorGamut GetActiveColorGamutDelegate();

	private delegate void set_activeTierDelegate(GraphicsTier value);

	private delegate void Internal_DrawProceduralNowDelegate(MeshTopology topology, int vertexCount, int instanceCount);

	private delegate System.IntPtr CreateGPUFenceImplDelegate(GraphicsFenceType fenceType, SynchronisationStageFlags stage);

	private delegate void WaitOnGPUFenceImplDelegate(System.IntPtr fencePtr, SynchronisationStageFlags stage);

	private delegate void GetActiveColorBuffer_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetActiveDepthBuffer_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void Internal_SetGfxRT_InjectedDelegate(System.IntPtr gfxTex, int mip, CubemapFace face, int depthSlice);

	private delegate void Internal_SetMRTSimple_InjectedDelegate(System.IntPtr color, [In] System.IntPtr depth, int mip, CubemapFace face, int depthSlice);

	private delegate void Internal_SetMRTFullSetup_InjectedDelegate(System.IntPtr color, [In] System.IntPtr depth, int mip, CubemapFace face, int depthSlice, System.IntPtr colorLA, System.IntPtr colorSA, RenderBufferLoadAction depthLA, RenderBufferStoreAction depthSA);

	private delegate void Internal_SetRandomWriteTargetRT_InjectedDelegate(int index, System.IntPtr uav);

	private delegate void Internal_SetRandomWriteTargetBuffer_InjectedDelegate(int index, System.IntPtr uav, bool preserveCounterValue);

	private delegate void Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate(int index, System.IntPtr uav, bool preserveCounterValue);

	private delegate void CopyTexture_Slice_AllMips_InjectedDelegate(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement);

	private delegate void CopyTexture_Full_Gfx_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

	private delegate void CopyTexture_Slice_AllMips_Gfx_InjectedDelegate(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement);

	private delegate void CopyTexture_Slice_Gfx_InjectedDelegate(System.IntPtr src, int srcElement, int srcMip, System.IntPtr dst, int dstElement, int dstMip);

	private delegate void CopyTexture_Region_Gfx_InjectedDelegate(System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, System.IntPtr dst, int dstElement, int dstMip, int dstX, int dstY);

	private delegate bool ConvertTexture_Slice_InjectedDelegate(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement);

	private delegate bool ConvertTexture_Full_Gfx_InjectedDelegate(System.IntPtr src, System.IntPtr dst);

	private delegate bool ConvertTexture_Slice_Gfx_InjectedDelegate(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement);

	private delegate void CopyBufferImpl_InjectedDelegate(System.IntPtr source, System.IntPtr dest);

	private delegate void Internal_DrawMeshNow1_InjectedDelegate(System.IntPtr mesh, int subsetIndex, [In] System.IntPtr position, [In] System.IntPtr rotation);

	private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] System.IntPtr bounds, int count, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume);

	private delegate void Internal_DrawMeshInstancedIndirect_InjectedDelegate(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] System.IntPtr bounds, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume);

	private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] System.IntPtr bounds, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume);

	private delegate void Internal_DrawProceduralIndexedNow_InjectedDelegate(MeshTopology topology, System.IntPtr indexBuffer, int indexCount, int instanceCount);

	private delegate void Internal_DrawProceduralIndirectNow_InjectedDelegate(MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset);

	private delegate void Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate(MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset);

	private delegate void Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate(MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset);

	private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate(MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset);

	private delegate void Internal_DrawProcedural_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, int vertexCount, int instanceCount, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, System.IntPtr indexBuffer, int indexCount, int instanceCount, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate(System.IntPtr material, [In] System.IntPtr bounds, MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer);

	private delegate void Internal_BlitMaterial6_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT, int destDepthSlice);

	private delegate void Internal_BlitMultiTap4_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, System.IntPtr offsets);

	private delegate void Internal_BlitMultiTap5_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, System.IntPtr offsets, int destDepthSlice);

	private delegate void Blit3_InjectedDelegate(System.IntPtr source, System.IntPtr dest, int sourceDepthSlice, int destDepthSlice);

	private delegate void Blit5_InjectedDelegate(System.IntPtr source, System.IntPtr dest, [In] System.IntPtr scale, [In] System.IntPtr offset, int sourceDepthSlice, int destDepthSlice);

	private delegate void Internal_BlitMaterialGfx5_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT);

	private delegate void Internal_BlitMaterialGfx6_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT, int destDepthSlice);

	private delegate void Internal_BlitMultiTapGfx4_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, System.IntPtr offsets);

	private delegate void Internal_BlitMultiTapGfx5_InjectedDelegate(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, System.IntPtr offsets, int destDepthSlice);

	private delegate void BlitGfx2_InjectedDelegate(System.IntPtr source, System.IntPtr dest);

	private delegate void BlitGfx3_InjectedDelegate(System.IntPtr source, System.IntPtr dest, int sourceDepthSlice, int destDepthSlice);

	private delegate void BlitGfx4_InjectedDelegate(System.IntPtr source, System.IntPtr dest, [In] System.IntPtr scale, [In] System.IntPtr offset);

	private delegate void BlitGfx5_InjectedDelegate(System.IntPtr source, System.IntPtr dest, [In] System.IntPtr scale, [In] System.IntPtr offset, int sourceDepthSlice, int destDepthSlice);

	private delegate void ExecuteCommandBufferAsync_InjectedDelegate(System.IntPtr buffer, ComputeQueueType queueType);

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RenderInstancedDataLayouts;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Full_Private_Static_Void_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTexture_Full_Private_Static_Boolean_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTexture_Public_Static_Boolean_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTexture_Full_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Vector2_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0;

	private static readonly GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;

	private static readonly set_activeTierDelegate set_activeTierDelegateField;

	private static readonly Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;

	private static readonly CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;

	private static readonly WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;

	private static readonly GetActiveColorBuffer_InjectedDelegate GetActiveColorBuffer_InjectedDelegateField;

	private static readonly GetActiveDepthBuffer_InjectedDelegate GetActiveDepthBuffer_InjectedDelegateField;

	private static readonly Internal_SetGfxRT_InjectedDelegate Internal_SetGfxRT_InjectedDelegateField;

	private static readonly Internal_SetMRTSimple_InjectedDelegate Internal_SetMRTSimple_InjectedDelegateField;

	private static readonly Internal_SetMRTFullSetup_InjectedDelegate Internal_SetMRTFullSetup_InjectedDelegateField;

	private static readonly Internal_SetRandomWriteTargetRT_InjectedDelegate Internal_SetRandomWriteTargetRT_InjectedDelegateField;

	private static readonly Internal_SetRandomWriteTargetBuffer_InjectedDelegate Internal_SetRandomWriteTargetBuffer_InjectedDelegateField;

	private static readonly Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField;

	private static readonly CopyTexture_Slice_AllMips_InjectedDelegate CopyTexture_Slice_AllMips_InjectedDelegateField;

	private static readonly CopyTexture_Full_Gfx_InjectedDelegate CopyTexture_Full_Gfx_InjectedDelegateField;

	private static readonly CopyTexture_Slice_AllMips_Gfx_InjectedDelegate CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField;

	private static readonly CopyTexture_Slice_Gfx_InjectedDelegate CopyTexture_Slice_Gfx_InjectedDelegateField;

	private static readonly CopyTexture_Region_Gfx_InjectedDelegate CopyTexture_Region_Gfx_InjectedDelegateField;

	private static readonly ConvertTexture_Slice_InjectedDelegate ConvertTexture_Slice_InjectedDelegateField;

	private static readonly ConvertTexture_Full_Gfx_InjectedDelegate ConvertTexture_Full_Gfx_InjectedDelegateField;

	private static readonly ConvertTexture_Slice_Gfx_InjectedDelegate ConvertTexture_Slice_Gfx_InjectedDelegateField;

	private static readonly CopyBufferImpl_InjectedDelegate CopyBufferImpl_InjectedDelegateField;

	private static readonly Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;

	private static readonly Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;

	private static readonly Internal_DrawMeshInstancedIndirect_InjectedDelegate Internal_DrawMeshInstancedIndirect_InjectedDelegateField;

	private static readonly Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexedNow_InjectedDelegate Internal_DrawProceduralIndexedNow_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndirectNow_InjectedDelegate Internal_DrawProceduralIndirectNow_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField;

	private static readonly Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

	private static readonly Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField;

	private static readonly Internal_BlitMaterial6_InjectedDelegate Internal_BlitMaterial6_InjectedDelegateField;

	private static readonly Internal_BlitMultiTap4_InjectedDelegate Internal_BlitMultiTap4_InjectedDelegateField;

	private static readonly Internal_BlitMultiTap5_InjectedDelegate Internal_BlitMultiTap5_InjectedDelegateField;

	private static readonly Blit3_InjectedDelegate Blit3_InjectedDelegateField;

	private static readonly Blit5_InjectedDelegate Blit5_InjectedDelegateField;

	private static readonly Internal_BlitMaterialGfx5_InjectedDelegate Internal_BlitMaterialGfx5_InjectedDelegateField;

	private static readonly Internal_BlitMaterialGfx6_InjectedDelegate Internal_BlitMaterialGfx6_InjectedDelegateField;

	private static readonly Internal_BlitMultiTapGfx4_InjectedDelegate Internal_BlitMultiTapGfx4_InjectedDelegateField;

	private static readonly Internal_BlitMultiTapGfx5_InjectedDelegate Internal_BlitMultiTapGfx5_InjectedDelegateField;

	private static readonly BlitGfx2_InjectedDelegate BlitGfx2_InjectedDelegateField;

	private static readonly BlitGfx3_InjectedDelegate BlitGfx3_InjectedDelegateField;

	private static readonly BlitGfx4_InjectedDelegate BlitGfx4_InjectedDelegateField;

	private static readonly BlitGfx5_InjectedDelegate BlitGfx5_InjectedDelegateField;

	private static readonly ExecuteCommandBufferAsync_InjectedDelegate ExecuteCommandBufferAsync_InjectedDelegateField;

	public unsafe static int kMaxDrawMeshInstanceCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&value));
		}
	}

	public unsafe static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RenderInstancedDataLayout>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RenderInstancedDataLayouts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static GraphicsTier activeTier
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172589, RefRangeEnd = 1172590, XrefRangeStart = 1172587, XrefRangeEnd = 1172589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsTier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_activeTierDelegateField(value);
		}
	}

	public unsafe static bool preserveFramebufferAlpha
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1172597, RefRangeEnd = 1172600, XrefRangeStart = 1172592, XrefRangeEnd = 1172597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static OpenGLESVersion minOpenGLESVersion
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1172607, RefRangeEnd = 1172609, XrefRangeStart = 1172602, XrefRangeEnd = 1172607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(OpenGLESVersion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static ColorGamut activeColorGamut => GetActiveColorGamut();

	public static RenderBuffer activeColorBuffer => GetActiveColorBuffer();

	public static RenderBuffer activeDepthBuffer => GetActiveDepthBuffer();

	static Graphics()
	{
		Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Graphics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
		NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "kMaxDrawMeshInstanceCount");
		NativeFieldInfoPtr_s_RenderInstancedDataLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "s_RenderInstancedDataLayouts");
		NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664347);
		NativeMethodInfoPtr_get_activeTier_Public_Static_get_GraphicsTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664348);
		NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664349);
		NativeMethodInfoPtr_get_preserveFramebufferAlpha_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664350);
		NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664351);
		NativeMethodInfoPtr_get_minOpenGLESVersion_Public_Static_get_OpenGLESVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664352);
		NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664353);
		NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664355);
		NativeMethodInfoPtr_CopyTexture_Full_Private_Static_Void_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664356);
		NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664357);
		NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664358);
		NativeMethodInfoPtr_ConvertTexture_Full_Private_Static_Boolean_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664360);
		NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664361);
		NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664362);
		NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664363);
		NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664364);
		NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664365);
		NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664366);
		NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664367);
		NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664368);
		NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664369);
		NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664370);
		NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664371);
		NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664372);
		NativeMethodInfoPtr_ConvertTexture_Public_Static_Boolean_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664373);
		NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664374);
		NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664375);
		NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664376);
		NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664377);
		NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664378);
		NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664379);
		NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664380);
		NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664381);
		NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664382);
		NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664383);
		NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664384);
		NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664385);
		NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664387);
		NativeMethodInfoPtr_CopyTexture_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664388);
		NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664389);
		NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664390);
		NativeMethodInfoPtr_ConvertTexture_Full_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664391);
		NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664392);
		NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664393);
		NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664394);
		NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664396);
		NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100664398);
		GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
		set_activeTierDelegateField = IL2CPP.ResolveICall<set_activeTierDelegate>("UnityEngine.Graphics::set_activeTier");
		Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
		CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
		WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
		GetActiveColorBuffer_InjectedDelegateField = IL2CPP.ResolveICall<GetActiveColorBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveColorBuffer_Injected");
		GetActiveDepthBuffer_InjectedDelegateField = IL2CPP.ResolveICall<GetActiveDepthBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveDepthBuffer_Injected");
		Internal_SetGfxRT_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetGfxRT_InjectedDelegate>("UnityEngine.Graphics::Internal_SetGfxRT_Injected");
		Internal_SetMRTSimple_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetMRTSimple_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTSimple_Injected");
		Internal_SetMRTFullSetup_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetMRTFullSetup_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTFullSetup_Injected");
		Internal_SetRandomWriteTargetRT_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetRandomWriteTargetRT_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT_Injected");
		Internal_SetRandomWriteTargetBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetRandomWriteTargetBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer_Injected");
		Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer_Injected");
		CopyTexture_Slice_AllMips_InjectedDelegateField = IL2CPP.ResolveICall<CopyTexture_Slice_AllMips_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips_Injected");
		CopyTexture_Full_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<CopyTexture_Full_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Full_Gfx_Injected");
		CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<CopyTexture_Slice_AllMips_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_AllMips_Gfx_Injected");
		CopyTexture_Slice_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<CopyTexture_Slice_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Slice_Gfx_Injected");
		CopyTexture_Region_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<CopyTexture_Region_Gfx_InjectedDelegate>("UnityEngine.Graphics::CopyTexture_Region_Gfx_Injected");
		ConvertTexture_Slice_InjectedDelegateField = IL2CPP.ResolveICall<ConvertTexture_Slice_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Slice_Injected");
		ConvertTexture_Full_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<ConvertTexture_Full_Gfx_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Full_Gfx_Injected");
		ConvertTexture_Slice_Gfx_InjectedDelegateField = IL2CPP.ResolveICall<ConvertTexture_Slice_Gfx_InjectedDelegate>("UnityEngine.Graphics::ConvertTexture_Slice_Gfx_Injected");
		CopyBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<CopyBufferImpl_InjectedDelegate>("UnityEngine.Graphics::CopyBufferImpl_Injected");
		Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
		Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
		Internal_DrawMeshInstancedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawMeshInstancedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirect_Injected");
		Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
		Internal_DrawProceduralIndexedNow_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexedNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow_Injected");
		Internal_DrawProceduralIndirectNow_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndirectNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow_Injected");
		Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexedIndirectNow_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow_Injected");
		Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected");
		Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected");
		Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
		Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
		Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
		Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectGraphicsBuffer_Injected");
		Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
		Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected");
		Internal_BlitMaterial6_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMaterial6_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterial6_Injected");
		Internal_BlitMultiTap4_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMultiTap4_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTap4_Injected");
		Internal_BlitMultiTap5_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMultiTap5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTap5_Injected");
		Blit3_InjectedDelegateField = IL2CPP.ResolveICall<Blit3_InjectedDelegate>("UnityEngine.Graphics::Blit3_Injected");
		Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
		Internal_BlitMaterialGfx5_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMaterialGfx5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterialGfx5_Injected");
		Internal_BlitMaterialGfx6_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMaterialGfx6_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMaterialGfx6_Injected");
		Internal_BlitMultiTapGfx4_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMultiTapGfx4_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTapGfx4_Injected");
		Internal_BlitMultiTapGfx5_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BlitMultiTapGfx5_InjectedDelegate>("UnityEngine.Graphics::Internal_BlitMultiTapGfx5_Injected");
		BlitGfx2_InjectedDelegateField = IL2CPP.ResolveICall<BlitGfx2_InjectedDelegate>("UnityEngine.Graphics::BlitGfx2_Injected");
		BlitGfx3_InjectedDelegateField = IL2CPP.ResolveICall<BlitGfx3_InjectedDelegate>("UnityEngine.Graphics::BlitGfx3_Injected");
		BlitGfx4_InjectedDelegateField = IL2CPP.ResolveICall<BlitGfx4_InjectedDelegate>("UnityEngine.Graphics::BlitGfx4_Injected");
		BlitGfx5_InjectedDelegateField = IL2CPP.ResolveICall<BlitGfx5_InjectedDelegate>("UnityEngine.Graphics::BlitGfx5_Injected");
		ExecuteCommandBufferAsync_InjectedDelegateField = IL2CPP.ResolveICall<ExecuteCommandBufferAsync_InjectedDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172585, XrefRangeEnd = 1172587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetMaxDrawMeshInstanceCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172590, XrefRangeEnd = 1172592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetPreserveFramebufferAlpha()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreserveFramebufferAlpha_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172600, XrefRangeEnd = 1172602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OpenGLESVersion GetMinOpenGLESVersion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinOpenGLESVersion_Internal_Static_OpenGLESVersion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OpenGLESVersion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172609, XrefRangeEnd = 1172611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetNullRT()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172611, XrefRangeEnd = 1172616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&color);
		*(RenderBuffer**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(CubemapFace**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172618, RefRangeEnd = 1172619, XrefRangeStart = 1172616, XrefRangeEnd = 1172618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearRandomWriteTargets()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearRandomWriteTargets_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172619, XrefRangeEnd = 1172630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Full(Texture src, Texture dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Full_Private_Static_Void_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172630, XrefRangeEnd = 1172641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Slice_Private_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172641, XrefRangeEnd = 1172652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcX;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcY;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstX;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstY;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Region_Private_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172652, XrefRangeEnd = 1172663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ConvertTexture_Full(Texture src, Texture dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTexture_Full_Private_Static_Boolean_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172663, XrefRangeEnd = 1172672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subsetIndex;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMeshNow2_Private_Static_Void_Mesh_Int32_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172672, XrefRangeEnd = 1172696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)probeAnchor);
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightProbeProxyVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172727, RefRangeEnd = 1172728, XrefRangeStart = 1172696, XrefRangeEnd = 1172727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrices);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightProbeProxyVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMeshInstanced_Private_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172728, XrefRangeEnd = 1172747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &setRT;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172747, XrefRangeEnd = 1172759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit2(Texture source, RenderTexture dest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172759, XrefRangeEnd = 1172771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit4_Private_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1172782, RefRangeEnd = 1172786, XrefRangeStart = 1172771, XrefRangeEnd = 1172782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteCommandBuffer(CommandBuffer buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBuffer_Public_Static_Void_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172786, XrefRangeEnd = 1172794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&colorBuffer);
		*(RenderBuffer**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172794, XrefRangeEnd = 1172803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1172815, RefRangeEnd = 1172817, XrefRangeStart = 1172803, XrefRangeEnd = 1172815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172831, RefRangeEnd = 1172832, XrefRangeStart = 1172817, XrefRangeEnd = 1172831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture(Texture src, Texture dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1172846, RefRangeEnd = 1172848, XrefRangeStart = 1172832, XrefRangeEnd = 1172846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Texture_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1172862, RefRangeEnd = 1172876, XrefRangeStart = 1172848, XrefRangeEnd = 1172862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcX;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcY;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcHeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstX;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstY;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Texture_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1172890, RefRangeEnd = 1172894, XrefRangeStart = 1172876, XrefRangeEnd = 1172890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ConvertTexture(Texture src, Texture dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTexture_Public_Static_Boolean_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1172910, RefRangeEnd = 1172912, XrefRangeStart = 1172894, XrefRangeEnd = 1172910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMeshNow_Public_Static_Void_Mesh_Matrix4x4_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172912, XrefRangeEnd = 1172943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)probeAnchor);
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightProbeProxyVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1172963, RefRangeEnd = 1172967, XrefRangeStart = 1172943, XrefRangeEnd = 1172963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrices);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightProbeProxyVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_LightProbeUsage_LightProbeProxyVolume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1172982, RefRangeEnd = 1172989, XrefRangeStart = 1172967, XrefRangeEnd = 1172982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(Texture source, RenderTexture dest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173004, RefRangeEnd = 1173005, XrefRangeStart = 1172989, XrefRangeEnd = 1173004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173005, XrefRangeEnd = 1173027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(Texture source, RenderTexture dest, Material mat, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173050, RefRangeEnd = 1173051, XrefRangeStart = 1173027, XrefRangeEnd = 1173050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit(Texture source, RenderTexture dest, Material mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173084, RefRangeEnd = 1173085, XrefRangeStart = 1173051, XrefRangeEnd = 1173084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Vector3_Quaternion_Material_Int32_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173115, RefRangeEnd = 1173116, XrefRangeStart = 1173085, XrefRangeEnd = 1173115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173120, RefRangeEnd = 1173121, XrefRangeStart = 1173116, XrefRangeEnd = 1173120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrices);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMeshInstanced_Public_Static_Void_Mesh_Int32_Material_Il2CppStructArray_1_Matrix4x4_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Int32_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1173125, RefRangeEnd = 1173130, XrefRangeStart = 1173121, XrefRangeEnd = 1173125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(RenderTexture rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173134, RefRangeEnd = 1173135, XrefRangeStart = 1173130, XrefRangeEnd = 1173134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173135, XrefRangeEnd = 1173137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetRTSimple_Injected([In] ref RenderBuffer color, [In] ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref color);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref depth);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mip;
		*(CubemapFace**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &face;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173137, XrefRangeEnd = 1173139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Full_Injected(System.IntPtr src, System.IntPtr dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&src);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Full_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173139, XrefRangeEnd = 1173141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Slice_Injected(System.IntPtr src, int srcElement, int srcMip, System.IntPtr dst, int dstElement, int dstMip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Slice_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173141, XrefRangeEnd = 1173143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture_Region_Injected(System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, System.IntPtr dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcElement;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcMip;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcX;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcY;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcHeight;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstElement;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstMip;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstX;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstY;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Region_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_Int32_Int32_IntPtr_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173143, XrefRangeEnd = 1173145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ConvertTexture_Full_Injected(System.IntPtr src, System.IntPtr dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&src);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTexture_Full_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173145, XrefRangeEnd = 1173147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMeshNow2_Injected(System.IntPtr mesh, int subsetIndex, [In] ref Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subsetIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMeshNow2_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173147, XrefRangeEnd = 1173149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMesh_Injected(System.IntPtr mesh, int submeshIndex, [In] ref Matrix4x4 matrix, System.IntPtr material, int layer, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, System.IntPtr probeAnchor, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matrix);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &material;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &properties;
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeAnchor;
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeProxyVolume;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_IntPtr_Int32_IntPtr_IntPtr_ShadowCastingMode_Boolean_IntPtr_LightProbeUsage_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173149, XrefRangeEnd = 1173151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DrawMeshInstanced_Injected(System.IntPtr mesh, int submeshIndex, System.IntPtr material, ref ManagedSpanWrapper matrices, int count, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &material;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matrices);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &properties;
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &castShadows;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiveShadows;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeUsage;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbeProxyVolume;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DrawMeshInstanced_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_byref_ManagedSpanWrapper_Int32_IntPtr_ShadowCastingMode_Boolean_Int32_IntPtr_LightProbeUsage_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173151, XrefRangeEnd = 1173153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_BlitMaterial5_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&source);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mat;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &setRT;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_BlitMaterial5_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173153, XrefRangeEnd = 1173155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit2_Injected(System.IntPtr source, System.IntPtr dest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&source);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit2_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173155, XrefRangeEnd = 1173157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Blit4_Injected(System.IntPtr source, System.IntPtr dest, [In] ref Vector2 scale, [In] ref Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit4_Injected_Private_Static_Void_IntPtr_IntPtr_byref_Vector2_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173157, XrefRangeEnd = 1173159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteCommandBuffer_Injected(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCommandBuffer_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Graphics(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static ColorGamut GetActiveColorGamut()
	{
		return GetActiveColorGamutDelegateField();
	}

	public static RenderBuffer GetActiveColorBuffer()
	{
		GetActiveColorBuffer_Injected(out var ret);
		return ret;
	}

	public static RenderBuffer GetActiveDepthBuffer()
	{
		GetActiveDepthBuffer_Injected(out var ret);
		return ret;
	}

	public static void Internal_SetGfxRT(GraphicsTexture gfxTex, int mip, CubemapFace face, int depthSlice)
	{
		Internal_SetGfxRT_Injected((gfxTex == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(gfxTex), mip, face, depthSlice);
	}

	public unsafe static void Internal_SetMRTSimple(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
		//IL_0017: Expected O, but got Ref
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		if (color == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)color, "color");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RenderBuffer> span);
		((Il2CppSystem.Span<RenderBuffer>)(&span))._002Ector((Il2CppArrayBase<RenderBuffer>)(object)color);
		fixed (RenderBuffer* begin = &((Il2CppSystem.Span<RenderBuffer>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper color2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RenderBuffer>)(&span)).Length);
			Internal_SetMRTSimple_Injected(ref color2, ref depth, mip, face, depthSlice);
		}
	}

	public unsafe static void Internal_SetMRTFullSetup(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<RenderBufferLoadAction> colorLA, Il2CppStructArray<RenderBufferStoreAction> colorSA, RenderBufferLoadAction depthLA, RenderBufferStoreAction depthSA)
	{
		//IL_0039: Expected O, but got Ref
		//IL_0040: Expected O, but got Ref
		//IL_004c: Expected O, but got Ref
		//IL_0063: Expected O, but got Ref
		//IL_006a: Expected O, but got Ref
		//IL_0078: Expected O, but got Ref
		//IL_0089: Expected O, but got Ref
		//IL_0090: Expected O, but got Ref
		//IL_009e: Expected O, but got Ref
		if (color == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)color, "color");
		}
		if (colorLA == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)colorLA, "colorLA");
		}
		if (colorSA == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)colorSA, "colorSA");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RenderBuffer> span);
		((Il2CppSystem.Span<RenderBuffer>)(&span))._002Ector((Il2CppArrayBase<RenderBuffer>)(object)color);
		fixed (RenderBuffer* begin = &((Il2CppSystem.Span<RenderBuffer>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper color2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RenderBuffer>)(&span)).Length);
			Unsafe.SkipInit(out Il2CppSystem.Span<RenderBufferLoadAction> span2);
			((Il2CppSystem.Span<RenderBufferLoadAction>)(&span2))._002Ector((Il2CppArrayBase<RenderBufferLoadAction>)(object)colorLA);
			fixed (RenderBufferLoadAction* begin2 = &((Il2CppSystem.Span<RenderBufferLoadAction>)(&span2)).GetPinnableReference())
			{
				ManagedSpanWrapper colorLA2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<RenderBufferLoadAction>)(&span2)).Length);
				Unsafe.SkipInit(out Il2CppSystem.Span<RenderBufferStoreAction> span3);
				((Il2CppSystem.Span<RenderBufferStoreAction>)(&span3))._002Ector((Il2CppArrayBase<RenderBufferStoreAction>)(object)colorSA);
				fixed (RenderBufferStoreAction* begin3 = &((Il2CppSystem.Span<RenderBufferStoreAction>)(&span3)).GetPinnableReference())
				{
					ManagedSpanWrapper colorSA2 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.Span<RenderBufferStoreAction>)(&span3)).Length);
					Internal_SetMRTFullSetup_Injected(ref color2, ref depth, mip, face, depthSlice, ref colorLA2, ref colorSA2, depthLA, depthSA);
				}
			}
		}
	}

	public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
	{
		Internal_SetRandomWriteTargetRT_Injected(index, Object.MarshalledUnityObject.Marshal(uav));
	}

	public static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue)
	{
		Internal_SetRandomWriteTargetBuffer_Injected(index, (uav == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(uav), preserveCounterValue);
	}

	public static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
	{
		Internal_SetRandomWriteTargetGraphicsBuffer_Injected(index, (uav == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(uav), preserveCounterValue);
	}

	public static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement)
	{
		CopyTexture_Slice_AllMips_Injected(Object.MarshalledUnityObject.Marshal(src), srcElement, Object.MarshalledUnityObject.Marshal(dst), dstElement);
	}

	public static void CopyTexture_Full_Gfx(GraphicsTexture src, GraphicsTexture dst)
	{
		CopyTexture_Full_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst));
	}

	public static void CopyTexture_Slice_AllMips_Gfx(GraphicsTexture src, int srcElement, GraphicsTexture dst, int dstElement)
	{
		CopyTexture_Slice_AllMips_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement);
	}

	public static void CopyTexture_Slice_Gfx(GraphicsTexture src, int srcElement, int srcMip, GraphicsTexture dst, int dstElement, int dstMip)
	{
		CopyTexture_Slice_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, srcMip, (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement, dstMip);
	}

	public static void CopyTexture_Region_Gfx(GraphicsTexture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsTexture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		CopyTexture_Region_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement, dstMip, dstX, dstY);
	}

	public static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement)
	{
		return ConvertTexture_Slice_Injected(Object.MarshalledUnityObject.Marshal(src), srcElement, Object.MarshalledUnityObject.Marshal(dst), dstElement);
	}

	public static bool ConvertTexture_Full_Gfx(GraphicsTexture src, GraphicsTexture dst)
	{
		return ConvertTexture_Full_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst));
	}

	public static bool ConvertTexture_Slice_Gfx(GraphicsTexture src, int srcElement, GraphicsTexture dst, int dstElement)
	{
		return ConvertTexture_Slice_Gfx_Injected((src == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(src), srcElement, (dst == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dst), dstElement);
	}

	public static void CopyBufferImpl(GraphicsBuffer source, GraphicsBuffer dest)
	{
		if (source == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		if (dest == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(dest, "dest");
		}
		System.IntPtr intPtr = GraphicsBuffer.BindingsMarshaller.ConvertToNative(source);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		System.IntPtr intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(dest);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(dest, "dest");
		}
		CopyBufferImpl_Injected(intPtr, intPtr2);
	}

	public static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		Internal_DrawMeshNow1_Injected(intPtr, subsetIndex, ref position, ref rotation);
	}

	public static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		if ((object)material == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(material);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		Internal_DrawMeshInstancedProcedural_Injected(intPtr, submeshIndex, intPtr2, ref bounds, count, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer, Object.MarshalledUnityObject.Marshal(camera), lightProbeUsage, Object.MarshalledUnityObject.Marshal(lightProbeProxyVolume));
	}

	public static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		if ((object)material == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(material);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		Internal_DrawMeshInstancedIndirect_Injected(intPtr, submeshIndex, intPtr2, ref bounds, (bufferWithArgs == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer, Object.MarshalledUnityObject.Marshal(camera), lightProbeUsage, Object.MarshalledUnityObject.Marshal(lightProbeProxyVolume));
	}

	public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		if ((object)material == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(material);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(material, "material");
		}
		Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(intPtr, submeshIndex, intPtr2, ref bounds, (bufferWithArgs == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer, Object.MarshalledUnityObject.Marshal(camera), lightProbeUsage, Object.MarshalledUnityObject.Marshal(lightProbeProxyVolume));
	}

	public static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount)
	{
		Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
	}

	public static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
	{
		Internal_DrawProceduralIndexedNow_Injected(topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), indexCount, instanceCount);
	}

	public static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndirectNow_Injected(topology, (bufferWithArgs == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
	}

	public static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndexedIndirectNow_Injected(topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), (bufferWithArgs == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
	}

	public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected(topology, (bufferWithArgs == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
	}

	public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected(topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), (bufferWithArgs == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset);
	}

	public static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProcedural_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, vertexCount, instanceCount, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexed_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), indexCount, instanceCount, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndirect_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, (bufferWithArgs == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_DrawProceduralIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndirectGraphicsBuffer_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, (bufferWithArgs == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexedIndirect_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), (bufferWithArgs == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(Object.MarshalledUnityObject.Marshal(material), ref bounds, topology, (indexBuffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(indexBuffer), (bufferWithArgs == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(bufferWithArgs), argsOffset, Object.MarshalledUnityObject.Marshal(camera), (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties), castShadows, receiveShadows, layer);
	}

	public static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
	{
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = Object.MarshalledUnityObject.Marshal(dest);
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Internal_BlitMaterial6_Injected(source2, dest2, intPtr, pass, setRT, destDepthSlice);
	}

	public unsafe static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
	{
		//IL_0047: Expected O, but got Ref
		//IL_004e: Expected O, but got Ref
		//IL_005a: Expected O, but got Ref
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		if (offsets == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)offsets, "offsets");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = Object.MarshalledUnityObject.Marshal(dest);
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)offsets);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper offsets2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			Internal_BlitMultiTap4_Injected(source2, dest2, intPtr, ref offsets2);
		}
	}

	public unsafe static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
	{
		//IL_0047: Expected O, but got Ref
		//IL_004e: Expected O, but got Ref
		//IL_005a: Expected O, but got Ref
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		if (offsets == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)offsets, "offsets");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = Object.MarshalledUnityObject.Marshal(dest);
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)offsets);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper offsets2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			Internal_BlitMultiTap5_Injected(source2, dest2, intPtr, ref offsets2, destDepthSlice);
		}
	}

	public static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
	{
		Blit3_Injected(Object.MarshalledUnityObject.Marshal(source), Object.MarshalledUnityObject.Marshal(dest), sourceDepthSlice, destDepthSlice);
	}

	public static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		Blit5_Injected(Object.MarshalledUnityObject.Marshal(source), Object.MarshalledUnityObject.Marshal(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
	}

	public static void Internal_BlitMaterialGfx5(Texture source, GraphicsTexture dest, Material mat, int pass, bool setRT)
	{
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = ((dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Internal_BlitMaterialGfx5_Injected(source2, dest2, intPtr, pass, setRT);
	}

	public static void Internal_BlitMaterialGfx6(Texture source, GraphicsTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
	{
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = ((dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Internal_BlitMaterialGfx6_Injected(source2, dest2, intPtr, pass, setRT, destDepthSlice);
	}

	public unsafe static void Internal_BlitMultiTapGfx4(Texture source, GraphicsTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
	{
		//IL_0050: Expected O, but got Ref
		//IL_0057: Expected O, but got Ref
		//IL_0063: Expected O, but got Ref
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		if (offsets == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)offsets, "offsets");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = ((dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)offsets);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper offsets2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			Internal_BlitMultiTapGfx4_Injected(source2, dest2, intPtr, ref offsets2);
		}
	}

	public unsafe static void Internal_BlitMultiTapGfx5(Texture source, GraphicsTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
	{
		//IL_0050: Expected O, but got Ref
		//IL_0057: Expected O, but got Ref
		//IL_0063: Expected O, but got Ref
		if ((object)mat == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		if (offsets == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)offsets, "offsets");
		}
		System.IntPtr source2 = Object.MarshalledUnityObject.Marshal(source);
		System.IntPtr dest2 = ((dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mat, "mat");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)offsets);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper offsets2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			Internal_BlitMultiTapGfx5_Injected(source2, dest2, intPtr, ref offsets2, destDepthSlice);
		}
	}

	public static void BlitGfx2(Texture source, GraphicsTexture dest)
	{
		BlitGfx2_Injected(Object.MarshalledUnityObject.Marshal(source), (dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest));
	}

	public static void BlitGfx3(Texture source, GraphicsTexture dest, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx3_Injected(Object.MarshalledUnityObject.Marshal(source), (dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), sourceDepthSlice, destDepthSlice);
	}

	public static void BlitGfx4(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset)
	{
		BlitGfx4_Injected(Object.MarshalledUnityObject.Marshal(source), (dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), ref scale, ref offset);
	}

	public static void BlitGfx5(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx5_Injected(Object.MarshalledUnityObject.Marshal(source), (dest == null) ? ((System.IntPtr)0) : GraphicsTexture.BindingsMarshaller.ConvertToNative(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
	}

	public static System.IntPtr CreateGPUFenceImpl(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
	{
		return CreateGPUFenceImplDelegateField(fenceType, stage);
	}

	public static void WaitOnGPUFenceImpl(System.IntPtr fencePtr, SynchronisationStageFlags stage)
	{
		WaitOnGPUFenceImplDelegateField(fencePtr, stage);
	}

	public static void ExecuteCommandBufferAsync(CommandBuffer buffer, ComputeQueueType queueType)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = CommandBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		ExecuteCommandBufferAsync_Injected(intPtr, queueType);
	}

	public static void CheckLoadActionValid(RenderBufferLoadAction load, string bufferType)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void CheckStoreActionValid(RenderBufferStoreAction store, string bufferType)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetRenderTargetImpl(GraphicsTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
		if (rt != null)
		{
			Internal_SetGfxRT(rt, mipLevel, face, depthSlice);
		}
		else
		{
			Internal_SetNullRT();
		}
	}

	public static void SetRenderTargetImpl(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
		Internal_SetMRTSimple(colorBuffers, depthBuffer, mipLevel, face, depthSlice);
	}

	public static void SetRenderTarget(GraphicsTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
		SetRenderTargetImpl(rt, mipLevel, face, depthSlice);
	}

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
		SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
	}

	public static void SetRenderTarget(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer)
	{
		SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
	}

	public static void SetRandomWriteTarget(int index, RenderTexture uav)
	{
		if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object)(object)SystemInfo.supportedRandomWriteTargetCount));
		}
		Internal_SetRandomWriteTargetRT(index, uav);
	}

	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
	{
		if (uav == null)
		{
			throw new Il2CppSystem.ArgumentNullException("uav");
		}
		if (uav.m_Ptr == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ObjectDisposedException("uav");
		}
		if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object)(object)SystemInfo.supportedRandomWriteTargetCount));
		}
		Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
	}

	public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
	{
		if (uav == null)
		{
			throw new Il2CppSystem.ArgumentNullException("uav");
		}
		if (uav.m_Ptr == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ObjectDisposedException("uav");
		}
		if (index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("index", Il2CppSystem.String.Format("must be non-negative less than {0}.", (Il2CppSystem.Object)(object)SystemInfo.supportedRandomWriteTargetCount));
		}
		Internal_SetRandomWriteTargetGraphicsBuffer(index, uav, preserveCounterValue);
	}

	public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
	{
		CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
	}

	public static void CopyTexture(GraphicsTexture src, GraphicsTexture dst)
	{
		CopyTexture_Full_Gfx(src, dst);
	}

	public static void CopyTexture(GraphicsTexture src, int srcElement, GraphicsTexture dst, int dstElement)
	{
		CopyTexture_Slice_AllMips_Gfx(src, srcElement, dst, dstElement);
	}

	public static void CopyTexture(GraphicsTexture src, int srcElement, int srcMip, GraphicsTexture dst, int dstElement, int dstMip)
	{
		CopyTexture_Slice_Gfx(src, srcElement, srcMip, dst, dstElement, dstMip);
	}

	public static void CopyTexture(GraphicsTexture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsTexture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		CopyTexture_Region_Gfx(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
	}

	public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
	{
		return ConvertTexture_Slice(src, srcElement, dst, dstElement);
	}

	public static bool ConvertTexture(GraphicsTexture src, GraphicsTexture dst)
	{
		return ConvertTexture_Full_Gfx(src, dst);
	}

	public static bool ConvertTexture(GraphicsTexture src, int srcElement, GraphicsTexture dst, int dstElement)
	{
		return ConvertTexture_Slice_Gfx(src, srcElement, dst, dstElement);
	}

	public static GraphicsFence CreateAsyncGraphicsFence(SynchronisationStage stage)
	{
		return CreateGraphicsFence(GraphicsFenceType.AsyncQueueSynchronisation, GraphicsFence.TranslateSynchronizationStageToFlags(stage));
	}

	public static GraphicsFence CreateAsyncGraphicsFence()
	{
		return CreateGraphicsFence(GraphicsFenceType.AsyncQueueSynchronisation, SynchronisationStageFlags.PixelProcessing);
	}

	public static GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
	{
		GraphicsFence result = default(GraphicsFence);
		result.m_FenceType = fenceType;
		result.m_Ptr = CreateGPUFenceImpl(fenceType, stage);
		result.InitPostAllocation();
		result.Validate();
		return result;
	}

	public static void WaitOnAsyncGraphicsFence(GraphicsFence fence)
	{
		WaitOnAsyncGraphicsFence(fence, SynchronisationStage.PixelProcessing);
	}

	public static void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage)
	{
		if (fence.m_FenceType != 0)
		{
			throw new Il2CppSystem.ArgumentException("Graphics.WaitOnGraphicsFence can only be called with fences created with GraphicsFenceType.AsyncQueueSynchronization.");
		}
		fence.Validate();
		if (fence.IsFencePending())
		{
			WaitOnGPUFenceImpl(fence.m_Ptr, GraphicsFence.TranslateSynchronizationStageToFlags(stage));
		}
	}

	public static void ValidateCopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
	{
		if (source == null)
		{
			throw new Il2CppSystem.ArgumentNullException("source");
		}
		if (dest == null)
		{
			throw new Il2CppSystem.ArgumentNullException("dest");
		}
		long num = (long)source.count * (long)source.stride;
		long num2 = (long)dest.count * (long)dest.stride;
		if (num != num2)
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("CopyBuffer source and destination buffers must be the same size, source was {0} bytes, dest was {1} bytes", (Il2CppSystem.Object)(object)num, (Il2CppSystem.Object)(object)num2));
		}
		if ((source.target & GraphicsBuffer.Target.CopySource) == 0)
		{
			throw new Il2CppSystem.ArgumentException("CopyBuffer source must have CopySource target", "source");
		}
		if ((dest.target & GraphicsBuffer.Target.CopyDestination) == 0)
		{
			throw new Il2CppSystem.ArgumentException("CopyBuffer destination must have CopyDestination target", "dest");
		}
	}

	public static void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest)
	{
		ValidateCopyBuffer(source, dest);
		CopyBufferImpl(source, dest);
	}

	public static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
	{
		DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
	{
		Color32 color = new Color32(128, 128, 128, 128);
		DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
	{
		DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
	{
		DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
	}

	public static RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(Il2CppSystem.Type type)
	{
		int hashCode = type.GetHashCode();
		if (!s_RenderInstancedDataLayouts.TryGetValue(hashCode, out var value))
		{
			value = new RenderInstancedDataLayout(type);
			s_RenderInstancedDataLayouts.Add(hashCode, value);
		}
		return value;
	}

	public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
	{
		if (mesh == null)
		{
			throw new Il2CppSystem.ArgumentNullException("mesh");
		}
		Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
	}

	public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
	{
		DrawMeshNow(mesh, position, rotation, -1);
	}

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
	{
		DrawMeshNow(mesh, matrix, -1);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if (matrices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("matrices");
		}
		DrawMeshInstanced(mesh, submeshIndex, material, (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] LightProbeUsage lightProbeUsage, [Optional] LightProbeProxyVolume lightProbeProxyVolume)
	{
		if (!SystemInfo.supportsInstancing)
		{
			throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
		}
		if (mesh == null)
		{
			throw new Il2CppSystem.ArgumentNullException("mesh");
		}
		if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
		}
		if (material == null)
		{
			throw new Il2CppSystem.ArgumentNullException("material");
		}
		if (count <= 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("count");
		}
		if (lightProbeUsage == LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null)
		{
			throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
		}
		if (count > 0)
		{
			Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}
	}

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if (!SystemInfo.supportsInstancing)
		{
			throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
		}
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (mesh == null)
		{
			throw new Il2CppSystem.ArgumentNullException("mesh");
		}
		if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
		}
		if (material == null)
		{
			throw new Il2CppSystem.ArgumentNullException("material");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		if (lightProbeUsage == LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null)
		{
			throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
		}
		Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
		if (!SystemInfo.supportsInstancing)
		{
			throw new Il2CppSystem.InvalidOperationException("Instancing is not supported.");
		}
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (mesh == null)
		{
			throw new Il2CppSystem.ArgumentNullException("mesh");
		}
		if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
		}
		if (material == null)
		{
			throw new Il2CppSystem.ArgumentNullException("material");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		if (lightProbeUsage == LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null)
		{
			throw new Il2CppSystem.ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
		}
		Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public static void DrawProceduralNow(MeshTopology topology, int vertexCount, [Optional] int instanceCount)
	{
		Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
	}

	public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount)
	{
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
	}

	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
	}

	public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
	}

	public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
	}

	public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
	}

	public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndirectGraphicsBuffer(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
	{
		if (!SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		if (indexBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("indexBuffer");
		}
		if (bufferWithArgs == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bufferWithArgs");
		}
		Internal_DrawProceduralIndexedIndirectGraphicsBuffer(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
	{
		Blit3(source, dest, sourceDepthSlice, destDepthSlice);
	}

	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
	}

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice)
	{
		Internal_BlitMaterial6(source, dest, mat, pass, setRT: true, destDepthSlice);
	}

	public static void Blit(Texture source, Material mat, int pass)
	{
		Internal_BlitMaterial5(source, null, mat, pass, setRT: false);
	}

	public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
	{
		Internal_BlitMaterial6(source, null, mat, pass, setRT: false, destDepthSlice);
	}

	public static void Blit(Texture source, Material mat)
	{
		Blit(source, mat, -1);
	}

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
	{
		if (((Il2CppArrayBase)offsets).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("empty offsets list passed.", "offsets");
		}
		Internal_BlitMultiTap4(source, dest, mat, offsets);
	}

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
	{
		BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
	}

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
	{
		if (((Il2CppArrayBase)offsets).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("empty offsets list passed.", "offsets");
		}
		Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
	}

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
	{
		BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
	}

	public static void Blit(Texture source, GraphicsTexture dest)
	{
		BlitGfx2(source, dest);
	}

	public static void Blit(Texture source, GraphicsTexture dest, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx3(source, dest, sourceDepthSlice, destDepthSlice);
	}

	public static void Blit(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset)
	{
		BlitGfx4(source, dest, scale, offset);
	}

	public static void Blit(Texture source, GraphicsTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
	}

	public static void Blit(Texture source, GraphicsTexture dest, Material mat, int pass)
	{
		Internal_BlitMaterialGfx5(source, dest, mat, pass, setRT: true);
	}

	public static void Blit(Texture source, GraphicsTexture dest, Material mat, int pass, int destDepthSlice)
	{
		Internal_BlitMaterialGfx6(source, dest, mat, pass, setRT: true, destDepthSlice);
	}

	public static void Blit(Texture source, GraphicsTexture dest, Material mat)
	{
		Blit(source, dest, mat, -1);
	}

	public static void BlitMultiTap(Texture source, GraphicsTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
	{
		if (((Il2CppArrayBase)offsets).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("empty offsets list passed.", "offsets");
		}
		Internal_BlitMultiTapGfx4(source, dest, mat, offsets);
	}

	public static void BlitMultiTap(Texture source, GraphicsTexture dest, Material mat, params Vector2[] offsets)
	{
		BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
	}

	public static void BlitMultiTap(Texture source, GraphicsTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
	{
		if (((Il2CppArrayBase)offsets).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("empty offsets list passed.", "offsets");
		}
		Internal_BlitMultiTapGfx5(source, dest, mat, offsets, destDepthSlice);
	}

	public static void BlitMultiTap(Texture source, GraphicsTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
	{
		BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, null, 0, null, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, null, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
	{
		DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
	{
		DrawMesh(mesh, matrix, material, layer, null, 0, null, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
	{
		DrawMesh(mesh, matrix, material, layer, camera, 0, null, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, null, ShadowCastingMode.On, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? ShadowCastingMode.On : ShadowCastingMode.Off, receiveShadows, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows: true, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
	{
		DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? LightProbeUsage.BlendProbes : LightProbeUsage.Off, null);
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage)
	{
		Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, ((Il2CppArrayBase)matrices).Length, null, ShadowCastingMode.On, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, null, ShadowCastingMode.On, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, ShadowCastingMode.On, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, null, ShadowCastingMode.On, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, ShadowCastingMode.On, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows: true, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, null, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, LightProbeUsage.BlendProbes, null);
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage)
	{
		DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
	}

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] LightProbeUsage lightProbeUsage)
	{
		DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
	}

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] LightProbeUsage lightProbeUsage)
	{
		DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
	{
		DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
	{
		DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, null, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
	{
		DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
	{
		DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
	{
		DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
	{
		DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
	{
		DrawTexture(screenRect, texture, mat, -1);
	}

	public static void DrawTexture(Rect screenRect, Texture texture)
	{
		DrawTexture(screenRect, texture, null, -1);
	}

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
	{
		SetRenderTarget(rt, mipLevel, face, 0);
	}

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
	{
		SetRenderTarget(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
	}

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
	{
		SetRenderTarget(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
	}

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
	{
		SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, 0);
	}

	public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
	{
		SetRandomWriteTarget(index, uav, preserveCounterValue: false);
	}

	public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
	{
		SetRandomWriteTarget(index, uav, preserveCounterValue: false);
	}

	public unsafe static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
	{
		GetActiveColorBuffer_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
	{
		GetActiveDepthBuffer_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public static void Internal_SetGfxRT_Injected(System.IntPtr gfxTex, int mip, CubemapFace face, int depthSlice)
	{
		Internal_SetGfxRT_InjectedDelegateField(gfxTex, mip, face, depthSlice);
	}

	public unsafe static void Internal_SetMRTSimple_Injected(ref ManagedSpanWrapper color, [In] ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
		Internal_SetMRTSimple_InjectedDelegateField((nint)Unsafe.AsPointer(ref color), (nint)Unsafe.AsPointer(ref depth), mip, face, depthSlice);
	}

	public unsafe static void Internal_SetMRTFullSetup_Injected(ref ManagedSpanWrapper color, [In] ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice, ref ManagedSpanWrapper colorLA, ref ManagedSpanWrapper colorSA, RenderBufferLoadAction depthLA, RenderBufferStoreAction depthSA)
	{
		Internal_SetMRTFullSetup_InjectedDelegateField((nint)Unsafe.AsPointer(ref color), (nint)Unsafe.AsPointer(ref depth), mip, face, depthSlice, (nint)Unsafe.AsPointer(ref colorLA), (nint)Unsafe.AsPointer(ref colorSA), depthLA, depthSA);
	}

	public static void Internal_SetRandomWriteTargetRT_Injected(int index, System.IntPtr uav)
	{
		Internal_SetRandomWriteTargetRT_InjectedDelegateField(index, uav);
	}

	public static void Internal_SetRandomWriteTargetBuffer_Injected(int index, System.IntPtr uav, bool preserveCounterValue)
	{
		Internal_SetRandomWriteTargetBuffer_InjectedDelegateField(index, uav, preserveCounterValue);
	}

	public static void Internal_SetRandomWriteTargetGraphicsBuffer_Injected(int index, System.IntPtr uav, bool preserveCounterValue)
	{
		Internal_SetRandomWriteTargetGraphicsBuffer_InjectedDelegateField(index, uav, preserveCounterValue);
	}

	public static void CopyTexture_Slice_AllMips_Injected(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement)
	{
		CopyTexture_Slice_AllMips_InjectedDelegateField(src, srcElement, dst, dstElement);
	}

	public static void CopyTexture_Full_Gfx_Injected(System.IntPtr src, System.IntPtr dst)
	{
		CopyTexture_Full_Gfx_InjectedDelegateField(src, dst);
	}

	public static void CopyTexture_Slice_AllMips_Gfx_Injected(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement)
	{
		CopyTexture_Slice_AllMips_Gfx_InjectedDelegateField(src, srcElement, dst, dstElement);
	}

	public static void CopyTexture_Slice_Gfx_Injected(System.IntPtr src, int srcElement, int srcMip, System.IntPtr dst, int dstElement, int dstMip)
	{
		CopyTexture_Slice_Gfx_InjectedDelegateField(src, srcElement, srcMip, dst, dstElement, dstMip);
	}

	public static void CopyTexture_Region_Gfx_Injected(System.IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, System.IntPtr dst, int dstElement, int dstMip, int dstX, int dstY)
	{
		CopyTexture_Region_Gfx_InjectedDelegateField(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
	}

	public static bool ConvertTexture_Slice_Injected(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement)
	{
		return ConvertTexture_Slice_InjectedDelegateField(src, srcElement, dst, dstElement);
	}

	public static bool ConvertTexture_Full_Gfx_Injected(System.IntPtr src, System.IntPtr dst)
	{
		return ConvertTexture_Full_Gfx_InjectedDelegateField(src, dst);
	}

	public static bool ConvertTexture_Slice_Gfx_Injected(System.IntPtr src, int srcElement, System.IntPtr dst, int dstElement)
	{
		return ConvertTexture_Slice_Gfx_InjectedDelegateField(src, srcElement, dst, dstElement);
	}

	public static void CopyBufferImpl_Injected(System.IntPtr source, System.IntPtr dest)
	{
		CopyBufferImpl_InjectedDelegateField(source, dest);
	}

	public unsafe static void Internal_DrawMeshNow1_Injected(System.IntPtr mesh, int subsetIndex, [In] ref Vector3 position, [In] ref Quaternion rotation)
	{
		Internal_DrawMeshNow1_InjectedDelegateField(mesh, subsetIndex, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void Internal_DrawMeshInstancedProcedural_Injected(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] ref Bounds bounds, int count, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume)
	{
		Internal_DrawMeshInstancedProcedural_InjectedDelegateField(mesh, submeshIndex, material, (nint)Unsafe.AsPointer(ref bounds), count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public unsafe static void Internal_DrawMeshInstancedIndirect_Injected(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] ref Bounds bounds, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume)
	{
		Internal_DrawMeshInstancedIndirect_InjectedDelegateField(mesh, submeshIndex, material, (nint)Unsafe.AsPointer(ref bounds), bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public unsafe static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(System.IntPtr mesh, int submeshIndex, System.IntPtr material, [In] ref Bounds bounds, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, System.IntPtr camera, LightProbeUsage lightProbeUsage, System.IntPtr lightProbeProxyVolume)
	{
		Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(mesh, submeshIndex, material, (nint)Unsafe.AsPointer(ref bounds), bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
	}

	public static void Internal_DrawProceduralIndexedNow_Injected(MeshTopology topology, System.IntPtr indexBuffer, int indexCount, int instanceCount)
	{
		Internal_DrawProceduralIndexedNow_InjectedDelegateField(topology, indexBuffer, indexCount, instanceCount);
	}

	public static void Internal_DrawProceduralIndirectNow_Injected(MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndirectNow_InjectedDelegateField(topology, bufferWithArgs, argsOffset);
	}

	public static void Internal_DrawProceduralIndexedIndirectNow_Injected(MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndexedIndirectNow_InjectedDelegateField(topology, indexBuffer, bufferWithArgs, argsOffset);
	}

	public static void Internal_DrawProceduralIndirectNowGraphicsBuffer_Injected(MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndirectNowGraphicsBuffer_InjectedDelegateField(topology, bufferWithArgs, argsOffset);
	}

	public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_Injected(MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset)
	{
		Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer_InjectedDelegateField(topology, indexBuffer, bufferWithArgs, argsOffset);
	}

	public unsafe static void Internal_DrawProcedural_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProcedural_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
	}

	public unsafe static void Internal_DrawProceduralIndexed_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, System.IntPtr indexBuffer, int indexCount, int instanceCount, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexed_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
	}

	public unsafe static void Internal_DrawProceduralIndirect_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndirect_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public unsafe static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndirectGraphicsBuffer_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public unsafe static void Internal_DrawProceduralIndexedIndirect_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public unsafe static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(System.IntPtr material, [In] ref Bounds bounds, MeshTopology topology, System.IntPtr indexBuffer, System.IntPtr bufferWithArgs, int argsOffset, System.IntPtr camera, System.IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
		Internal_DrawProceduralIndexedIndirectGraphicsBuffer_InjectedDelegateField(material, (nint)Unsafe.AsPointer(ref bounds), topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
	}

	public static void Internal_BlitMaterial6_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT, int destDepthSlice)
	{
		Internal_BlitMaterial6_InjectedDelegateField(source, dest, mat, pass, setRT, destDepthSlice);
	}

	public unsafe static void Internal_BlitMultiTap4_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, ref ManagedSpanWrapper offsets)
	{
		Internal_BlitMultiTap4_InjectedDelegateField(source, dest, mat, (nint)Unsafe.AsPointer(ref offsets));
	}

	public unsafe static void Internal_BlitMultiTap5_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, ref ManagedSpanWrapper offsets, int destDepthSlice)
	{
		Internal_BlitMultiTap5_InjectedDelegateField(source, dest, mat, (nint)Unsafe.AsPointer(ref offsets), destDepthSlice);
	}

	public static void Blit3_Injected(System.IntPtr source, System.IntPtr dest, int sourceDepthSlice, int destDepthSlice)
	{
		Blit3_InjectedDelegateField(source, dest, sourceDepthSlice, destDepthSlice);
	}

	public unsafe static void Blit5_Injected(System.IntPtr source, System.IntPtr dest, [In] ref Vector2 scale, [In] ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		Blit5_InjectedDelegateField(source, dest, (nint)Unsafe.AsPointer(ref scale), (nint)Unsafe.AsPointer(ref offset), sourceDepthSlice, destDepthSlice);
	}

	public static void Internal_BlitMaterialGfx5_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT)
	{
		Internal_BlitMaterialGfx5_InjectedDelegateField(source, dest, mat, pass, setRT);
	}

	public static void Internal_BlitMaterialGfx6_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, int pass, bool setRT, int destDepthSlice)
	{
		Internal_BlitMaterialGfx6_InjectedDelegateField(source, dest, mat, pass, setRT, destDepthSlice);
	}

	public unsafe static void Internal_BlitMultiTapGfx4_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, ref ManagedSpanWrapper offsets)
	{
		Internal_BlitMultiTapGfx4_InjectedDelegateField(source, dest, mat, (nint)Unsafe.AsPointer(ref offsets));
	}

	public unsafe static void Internal_BlitMultiTapGfx5_Injected(System.IntPtr source, System.IntPtr dest, System.IntPtr mat, ref ManagedSpanWrapper offsets, int destDepthSlice)
	{
		Internal_BlitMultiTapGfx5_InjectedDelegateField(source, dest, mat, (nint)Unsafe.AsPointer(ref offsets), destDepthSlice);
	}

	public static void BlitGfx2_Injected(System.IntPtr source, System.IntPtr dest)
	{
		BlitGfx2_InjectedDelegateField(source, dest);
	}

	public static void BlitGfx3_Injected(System.IntPtr source, System.IntPtr dest, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx3_InjectedDelegateField(source, dest, sourceDepthSlice, destDepthSlice);
	}

	public unsafe static void BlitGfx4_Injected(System.IntPtr source, System.IntPtr dest, [In] ref Vector2 scale, [In] ref Vector2 offset)
	{
		BlitGfx4_InjectedDelegateField(source, dest, (nint)Unsafe.AsPointer(ref scale), (nint)Unsafe.AsPointer(ref offset));
	}

	public unsafe static void BlitGfx5_Injected(System.IntPtr source, System.IntPtr dest, [In] ref Vector2 scale, [In] ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
		BlitGfx5_InjectedDelegateField(source, dest, (nint)Unsafe.AsPointer(ref scale), (nint)Unsafe.AsPointer(ref offset), sourceDepthSlice, destDepthSlice);
	}

	public static void ExecuteCommandBufferAsync_Injected(System.IntPtr buffer, ComputeQueueType queueType)
	{
		ExecuteCommandBufferAsync_InjectedDelegateField(buffer, queueType);
	}
}
