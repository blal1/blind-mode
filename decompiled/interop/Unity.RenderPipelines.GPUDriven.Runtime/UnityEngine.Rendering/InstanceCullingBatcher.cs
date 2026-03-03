using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering;

public class InstanceCullingBatcher : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchersContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawInstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BRG;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlobalBatchIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Culler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchMaterialHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PackedMaterialHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchMeshHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedInstanceDataBufferLayoutVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnCompleteCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_batchMaterialHash_Public_get_NativeParallelHashMap_2_Int32_BatchMaterialID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_packedMaterialHash_Public_get_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_OnFinishedCulling_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_culler_Internal_get_byref_InstanceCuller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBatchID_Private_BatchID_InstanceComponentGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceDataBufferLayoutVersion_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPerformCulling_Public_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishedCulling_Public_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBatchMeshes_Private_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBatchMaterials_Private_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SchedulePackedMaterialCacheUpdate_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildBatch_Public_Void_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0;

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

	public unsafe CPUDrawInstanceData m_DrawInstanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstanceData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CPUDrawInstanceData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstanceData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BatchRendererGroup m_BRG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BRG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BatchRendererGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BRG)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeParallelHashMap<uint, BatchID> m_GlobalBatchIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalBatchIDs);
			return new NativeParallelHashMap<uint, BatchID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<uint, BatchID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalBatchIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<uint, BatchID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InstanceCuller m_Culler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Culler);
			return new InstanceCuller(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Culler), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, BatchMaterialID> m_BatchMaterialHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchMaterialHash);
			return new NativeParallelHashMap<int, BatchMaterialID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMaterialID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchMaterialHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMaterialID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, GPUDrivenPackedMaterialData> m_PackedMaterialHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PackedMaterialHash);
			return new NativeParallelHashMap<int, GPUDrivenPackedMaterialData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PackedMaterialHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, BatchMeshID> m_BatchMeshHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchMeshHash);
			return new NativeParallelHashMap<int, BatchMeshID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMeshID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchMeshHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMeshID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_CachedInstanceDataBufferLayoutVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedInstanceDataBufferLayoutVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedInstanceDataBufferLayoutVersion)) = value;
		}
	}

	public unsafe OnCullingCompleteCallback m_OnCompleteCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnCompleteCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnCullingCompleteCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnCompleteCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_batchMaterialHash_Public_get_NativeParallelHashMap_2_Int32_BatchMaterialID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeParallelHashMap<int, BatchMaterialID>(pointer);
		}
	}

	public unsafe NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialHash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_packedMaterialHash_Public_get_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeParallelHashMap<int, GPUDrivenPackedMaterialData>(pointer);
		}
	}

	public unsafe ref InstanceCuller culler
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1008112, RefRangeEnd = 1008120, XrefRangeStart = 1008112, XrefRangeEnd = 1008120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_culler_Internal_get_byref_InstanceCuller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(InstanceCuller*)intPtr2;
		}
	}

	static InstanceCullingBatcher()
	{
		Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullingBatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr);
		NativeFieldInfoPtr_m_BatchersContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_BatchersContext");
		NativeFieldInfoPtr_m_DrawInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_DrawInstanceData");
		NativeFieldInfoPtr_m_BRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_BRG");
		NativeFieldInfoPtr_m_GlobalBatchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_GlobalBatchIDs");
		NativeFieldInfoPtr_m_Culler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_Culler");
		NativeFieldInfoPtr_m_BatchMaterialHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_BatchMaterialHash");
		NativeFieldInfoPtr_m_PackedMaterialHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_PackedMaterialHash");
		NativeFieldInfoPtr_m_BatchMeshHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_BatchMeshHash");
		NativeFieldInfoPtr_m_CachedInstanceDataBufferLayoutVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_CachedInstanceDataBufferLayoutVersion");
		NativeFieldInfoPtr_m_OnCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, "m_OnCompleteCallback");
		NativeMethodInfoPtr_get_batchMaterialHash_Public_get_NativeParallelHashMap_2_Int32_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_get_packedMaterialHash_Public_get_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_OnFinishedCulling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_get_culler_Internal_get_byref_InstanceCuller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_GetBatchID_Private_BatchID_InstanceComponentGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_UpdateInstanceDataBufferLayoutVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_OnPerformCulling_Public_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_OnFinishedCulling_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_RegisterBatchMeshes_Private_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_RegisterBatchMaterials_Private_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_SchedulePackedMaterialCacheUpdate_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_BuildBatch_Public_Void_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_UpdateFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr, 100663655);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1070599, RefRangeEnd = 1070601, XrefRangeStart = 1070514, XrefRangeEnd = 1070599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceCullingBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc desc, BatchRendererGroup.OnFinishedCulling onFinishedCulling)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceCullingBatcher>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batcherContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onFinishedCulling);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderersBatchersContext_InstanceCullingBatcherDesc_OnFinishedCulling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1070674, RefRangeEnd = 1070676, XrefRangeStart = 1070601, XrefRangeEnd = 1070674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1070700, RefRangeEnd = 1070707, XrefRangeStart = 1070676, XrefRangeEnd = 1070700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchID GetBatchID(InstanceComponentGroup componentsOverriden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&componentsOverriden);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBatchID_Private_BatchID_InstanceComponentGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BatchID*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070740, RefRangeEnd = 1070741, XrefRangeStart = 1070707, XrefRangeEnd = 1070740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceDataBufferLayoutVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceDataBufferLayoutVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070741, XrefRangeEnd = 1070778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cc, BatchCullingOutput cullingOutput, System.IntPtr userContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cullingOutput));
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &userContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPerformCulling_Public_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070780, RefRangeEnd = 1070781, XrefRangeStart = 1070778, XrefRangeEnd = 1070780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFinishedCulling(System.IntPtr customCullingResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&customCullingResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFinishedCulling_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1070782, RefRangeEnd = 1070787, XrefRangeStart = 1070781, XrefRangeEnd = 1070782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyDrawInstances(NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1070825, RefRangeEnd = 1070830, XrefRangeStart = 1070787, XrefRangeEnd = 1070825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyMaterials(NativeArray<int> destroyedMaterials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedMaterials));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyMaterials_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1070851, RefRangeEnd = 1070854, XrefRangeStart = 1070830, XrefRangeEnd = 1070851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyMeshes(NativeArray<int> destroyedMeshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedMeshes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyMeshes_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Void_RenderRequestBatcherContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070915, RefRangeEnd = 1070916, XrefRangeStart = 1070854, XrefRangeEnd = 1070915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBatchMeshes(NativeArray<int> meshIDs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)meshIDs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBatchMeshes_Private_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071000, RefRangeEnd = 1071001, XrefRangeStart = 1070916, XrefRangeEnd = 1071000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBatchMaterials([In] ref NativeArray<int> usedMaterialIDs, [In] ref NativeArray<GPUDrivenPackedMaterialData> usedPackedMaterialDatas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usedMaterialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)usedPackedMaterialDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBatchMaterials_Private_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071010, RefRangeEnd = 1071012, XrefRangeStart = 1071001, XrefRangeEnd = 1071010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071016, RefRangeEnd = 1071018, XrefRangeStart = 1071012, XrefRangeEnd = 1071016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildBatch(NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, bool registerMaterialsAndMeshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &registerMaterialsAndMeshes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildBatch_Public_Void_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071019, RefRangeEnd = 1071020, XrefRangeStart = 1071018, XrefRangeEnd = 1071019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstanceOccludersUpdated(int viewInstanceID, int subviewMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewInstanceID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subviewMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071021, RefRangeEnd = 1071023, XrefRangeStart = 1071020, XrefRangeEnd = 1071021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071024, RefRangeEnd = 1071025, XrefRangeStart = 1071023, XrefRangeEnd = 1071024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&syncCullingJobs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ParallelBitArray(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071028, RefRangeEnd = 1071030, XrefRangeStart = 1071025, XrefRangeEnd = 1071028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndContextRendering()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndContextRendering_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1071031, RefRangeEnd = 1071035, XrefRangeStart = 1071030, XrefRangeEnd = 1071031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1071031, RefRangeEnd = 1071035, XrefRangeStart = 1071031, XrefRangeEnd = 1071035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceCullingBatcher(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
