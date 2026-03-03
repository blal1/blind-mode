using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public class GPUResidentBatcher : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchersContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GPUDrivenProcessor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateRendererInstancesAndBatchesCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateRendererBatchesCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceCullingBatcher;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessedThisFrameTreeBits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_batchersContext_Internal_get_RenderersBatchersContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_occlusionCullingCommon_Internal_get_OcclusionCullingCommon_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceCullingBatcher_Internal_get_InstanceCullingBatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_GPUDrivenProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginContextRendering_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeRendererGroupInstances_Internal_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRenderers_Public_Void_NativeArray_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SchedulePackedMaterialCacheUpdate_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRendererInstancesAndBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRendererBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishedCulling_Private_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTrees_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeedTreeWindAndUploadWindParamsToGPU_Private_Void_NativeArray_1_Int32_NativeArray_1_InstanceHandle_Boolean_0;

	public unsafe RenderersBatchersContext m_BatchersContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchersContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderersBatchersContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchersContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUDrivenProcessor m_GPUDrivenProcessor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUDrivenProcessor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenProcessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUDrivenProcessor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUDrivenRendererDataCallback m_UpdateRendererInstancesAndBatchesCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRendererInstancesAndBatchesCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenRendererDataCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRendererInstancesAndBatchesCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUDrivenRendererDataCallback m_UpdateRendererBatchesCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRendererBatchesCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenRendererDataCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRendererBatchesCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InstanceCullingBatcher m_InstanceCullingBatcher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCullingBatcher);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InstanceCullingBatcher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCullingBatcher)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ParallelBitArray m_ProcessedThisFrameTreeBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessedThisFrameTreeBits);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProcessedThisFrameTreeBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe RenderersBatchersContext batchersContext
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_batchersContext_Internal_get_RenderersBatchersContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderersBatchersContext>(intPtr2) : null;
		}
	}

	public unsafe OcclusionCullingCommon occlusionCullingCommon
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067989, RefRangeEnd = 1067991, XrefRangeStart = 1067989, XrefRangeEnd = 1067989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_occlusionCullingCommon_Internal_get_OcclusionCullingCommon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OcclusionCullingCommon>(intPtr2) : null;
		}
	}

	public unsafe InstanceCullingBatcher instanceCullingBatcher
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceCullingBatcher_Internal_get_InstanceCullingBatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InstanceCullingBatcher>(intPtr2) : null;
		}
	}

	static GPUResidentBatcher()
	{
		Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUResidentBatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr);
		NativeFieldInfoPtr_m_BatchersContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_BatchersContext");
		NativeFieldInfoPtr_m_GPUDrivenProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_GPUDrivenProcessor");
		NativeFieldInfoPtr_m_UpdateRendererInstancesAndBatchesCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_UpdateRendererInstancesAndBatchesCallback");
		NativeFieldInfoPtr_m_UpdateRendererBatchesCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_UpdateRendererBatchesCallback");
		NativeFieldInfoPtr_m_InstanceCullingBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_InstanceCullingBatcher");
		NativeFieldInfoPtr_m_ProcessedThisFrameTreeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, "m_ProcessedThisFrameTreeBits");
		NativeMethodInfoPtr_get_batchersContext_Internal_get_RenderersBatchersContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_get_occlusionCullingCommon_Internal_get_OcclusionCullingCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_get_instanceCullingBatcher_Internal_get_InstanceCullingBatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_GPUDrivenProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_OnBeginContextRendering_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_UpdateFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_FreeRendererGroupInstances_Internal_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_UpdateRenderers_Public_Void_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_SchedulePackedMaterialCacheUpdate_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_UpdateRendererInstancesAndBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_UpdateRendererBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_OnFinishedCulling_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_ProcessTrees_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_UpdateSpeedTreeWindAndUploadWindParamsToGPU_Private_Void_NativeArray_1_Int32_NativeArray_1_InstanceHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr, 100663450);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067991, XrefRangeEnd = 1068018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUResidentBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc instanceCullerBatcherDesc, GPUDrivenProcessor gpuDrivenProcessor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUResidentBatcher>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batcherContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceCullerBatcherDesc));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gpuDrivenProcessor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_GPUDrivenProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068018, XrefRangeEnd = 1068022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068022, XrefRangeEnd = 1068024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginContextRendering()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginContextRendering_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068024, XrefRangeEnd = 1068025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndContextRendering()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068025, XrefRangeEnd = 1068026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068026, XrefRangeEnd = 1068029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068029, XrefRangeEnd = 1068030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyMaterials(NativeArray<int> destroyedMaterials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedMaterials));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068030, XrefRangeEnd = 1068031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyDrawInstances(NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068031, XrefRangeEnd = 1068032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyMeshes(NativeArray<int> destroyedMeshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedMeshes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1068046, RefRangeEnd = 1068051, XrefRangeStart = 1068032, XrefRangeEnd = 1068046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeRendererGroupInstances(NativeArray<int> rendererGroupIDs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeRendererGroupInstances_Internal_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068051, XrefRangeEnd = 1068054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstanceOcclusionTest(RenderGraph renderGraph, [In] ref OcclusionCullingSettings settings, Il2CppSystem.ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)subviewOcclusionTests));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068054, XrefRangeEnd = 1068056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceOccluders(RenderGraph renderGraph, [In] ref OccluderParameters occluderParams, Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068062, RefRangeEnd = 1068063, XrefRangeStart = 1068056, XrefRangeEnd = 1068062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRenderers(NativeArray<int> renderersID, bool materialUpdateOnly = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersID));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialUpdateOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRenderers_Public_Void_NativeArray_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068063, XrefRangeEnd = 1068064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<int> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SchedulePackedMaterialCacheUpdate_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068064, XrefRangeEnd = 1068066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068066, XrefRangeEnd = 1068086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRendererInstancesAndBatches([In] ref GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRendererInstancesAndBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068086, XrefRangeEnd = 1068099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRendererBatches([In] ref GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRendererBatches_Private_Void_byref_GPUDrivenRendererGroupData_IList_1_Mesh_IList_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068099, XrefRangeEnd = 1068102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFinishedCulling(System.IntPtr customCullingResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&customCullingResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFinishedCulling_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068150, RefRangeEnd = 1068151, XrefRangeStart = 1068102, XrefRangeEnd = 1068150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessTrees()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTrees_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068171, RefRangeEnd = 1068173, XrefRangeStart = 1068151, XrefRangeEnd = 1068171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpeedTreeWindAndUploadWindParamsToGPU(NativeArray<int> treeRendererIDs, NativeArray<InstanceHandle> treeInstances, bool history)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)treeRendererIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)treeInstances));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &history;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpeedTreeWindAndUploadWindParamsToGPU_Private_Void_NativeArray_1_Int32_NativeArray_1_InstanceHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUResidentBatcher(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
