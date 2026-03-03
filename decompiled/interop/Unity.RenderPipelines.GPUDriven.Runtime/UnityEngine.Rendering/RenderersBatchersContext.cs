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

public class RenderersBatchersContext : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceDataSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Resources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GPUDrivenProcessor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODGroupDataPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceDataBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderersParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UploadResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GrowerResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CmdBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedAmbientProbe;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SmallMeshScreenPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateLODGroupCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformLODGroupCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OcclusionCullingCommon;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugStats;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderersParameters_Public_get_RenderersParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuInstanceDataBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultDescriptions_Public_get_ReadOnly_GPUInstanceComponentDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMetadata_Public_get_NativeArray_1_MetadataValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodGroupCullingData_Public_get_NativeList_1_LODGroupCullingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceDataBufferLayoutVersion_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_crossfadedRendererCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceDataBuffer_Public_get_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resources_Public_get_GPUResidentDrawerResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_occlusionCullingCommon_Internal_get_OcclusionCullingCommon_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugStats_Internal_get_DebugRendererBatcherStats_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RenderersBatchersContextDesc_GPUDrivenProcessor_GPUResidentDrawerResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowInstanceBuffer_Public_Void_byref_InstanceNumInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureInstanceBufferCapacity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyLODGroups_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLODGroups_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeInstanceBufferVersion_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDataBufferUploader_Public_GPUInstanceDataBufferUploader_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_InstanceHandle_byref_GPUInstanceDataBufferUploader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_GPUInstanceIndex_byref_GPUInstanceDataBufferUploader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAmbientProbeAndGpuBuffer_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformLODGroups_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame_Public_Void_0;

	public unsafe InstanceDataSystem m_InstanceDataSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InstanceDataSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUResidentDrawerResources m_Resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentDrawerResources>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe LODGroupDataPool m_LODGroupDataPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupDataPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LODGroupDataPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupDataPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUInstanceDataBuffer m_InstanceDataBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderersParameters m_RenderersParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderersParameters);
			return new RenderersParameters(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderersParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GPUInstanceDataBufferUploader.GPUResources m_UploadResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UploadResources);
			return new GPUInstanceDataBufferUploader.GPUResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUInstanceDataBufferUploader.GPUResources>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UploadResources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUInstanceDataBufferUploader.GPUResources>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GPUInstanceDataBufferGrower.GPUResources m_GrowerResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GrowerResources);
			return new GPUInstanceDataBufferGrower.GPUResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUInstanceDataBufferGrower.GPUResources>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GrowerResources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUInstanceDataBufferGrower.GPUResources>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CommandBuffer m_CmdBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CmdBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CmdBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SphericalHarmonicsL2 m_CachedAmbientProbe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedAmbientProbe);
			return *(SphericalHarmonicsL2*)num;
		}
		set
		{
			*(SphericalHarmonicsL2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedAmbientProbe)) = value;
		}
	}

	public unsafe float m_SmallMeshScreenPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SmallMeshScreenPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SmallMeshScreenPercentage)) = value;
		}
	}

	public unsafe GPUDrivenLODGroupDataCallback m_UpdateLODGroupCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateLODGroupCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenLODGroupDataCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateLODGroupCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUDrivenLODGroupDataCallback m_TransformLODGroupCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLODGroupCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenLODGroupDataCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLODGroupCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe OcclusionCullingCommon m_OcclusionCullingCommon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionCullingCommon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OcclusionCullingCommon>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionCullingCommon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugRendererBatcherStats m_DebugStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugStats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugRendererBatcherStats>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderersParameters renderersParameters
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderersParameters_Public_get_RenderersParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RenderersParameters(pointer);
		}
	}

	public unsafe GraphicsBuffer gpuInstanceDataBuffer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075105, RefRangeEnd = 1075107, XrefRangeStart = 1075105, XrefRangeEnd = 1075105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuInstanceDataBuffer_Public_get_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	public unsafe NativeArray<GPUInstanceComponentDesc>.ReadOnly defaultDescriptions
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075110, RefRangeEnd = 1075112, XrefRangeStart = 1075107, XrefRangeEnd = 1075110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultDescriptions_Public_get_ReadOnly_GPUInstanceComponentDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<GPUInstanceComponentDesc>.ReadOnly(pointer);
		}
	}

	public unsafe NativeArray<MetadataValue> defaultMetadata
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075112, RefRangeEnd = 1075114, XrefRangeStart = 1075112, XrefRangeEnd = 1075112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultMetadata_Public_get_NativeArray_1_MetadataValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<MetadataValue>(pointer);
		}
	}

	public unsafe NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075114, RefRangeEnd = 1075115, XrefRangeStart = 1075114, XrefRangeEnd = 1075114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lodGroupCullingData_Public_get_NativeList_1_LODGroupCullingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeList<LODGroupCullingData>(pointer);
		}
	}

	public unsafe int instanceDataBufferLayoutVersion
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1075115, RefRangeEnd = 1075118, XrefRangeStart = 1075115, XrefRangeEnd = 1075115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceDataBufferLayoutVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int crossfadedRendererCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075118, RefRangeEnd = 1075119, XrefRangeStart = 1075118, XrefRangeEnd = 1075118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_crossfadedRendererCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasBoundingSpheres
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1075119, RefRangeEnd = 1075124, XrefRangeStart = 1075119, XrefRangeEnd = 1075119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe CPUInstanceData.ReadOnly instanceData
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075125, RefRangeEnd = 1075126, XrefRangeStart = 1075124, XrefRangeEnd = 1075125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CPUInstanceData.ReadOnly(pointer);
		}
	}

	public unsafe CPUSharedInstanceData.ReadOnly sharedInstanceData
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1075127, RefRangeEnd = 1075133, XrefRangeStart = 1075126, XrefRangeEnd = 1075127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CPUSharedInstanceData.ReadOnly(pointer);
		}
	}

	public unsafe GPUInstanceDataBuffer.ReadOnly instanceDataBuffer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1075134, RefRangeEnd = 1075136, XrefRangeStart = 1075133, XrefRangeEnd = 1075134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceDataBuffer_Public_get_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GPUInstanceDataBuffer.ReadOnly(pointer);
		}
	}

	public unsafe NativeArray<InstanceHandle> aliveInstances
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075137, RefRangeEnd = 1075138, XrefRangeStart = 1075136, XrefRangeEnd = 1075137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<InstanceHandle>(pointer);
		}
	}

	public unsafe float smallMeshScreenPercentage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GPUResidentDrawerResources resources
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resources_Public_get_GPUResidentDrawerResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentDrawerResources>(intPtr2) : null;
		}
	}

	public unsafe OcclusionCullingCommon occlusionCullingCommon
	{
		[CallerCount(0)]
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

	public unsafe DebugRendererBatcherStats debugStats
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugStats_Internal_get_DebugRendererBatcherStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugRendererBatcherStats>(intPtr2) : null;
		}
	}

	static RenderersBatchersContext()
	{
		Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RenderersBatchersContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr);
		NativeFieldInfoPtr_m_InstanceDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_InstanceDataSystem");
		NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_Resources");
		NativeFieldInfoPtr_m_GPUDrivenProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_GPUDrivenProcessor");
		NativeFieldInfoPtr_m_LODGroupDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_LODGroupDataPool");
		NativeFieldInfoPtr_m_InstanceDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_InstanceDataBuffer");
		NativeFieldInfoPtr_m_RenderersParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_RenderersParameters");
		NativeFieldInfoPtr_m_UploadResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_UploadResources");
		NativeFieldInfoPtr_m_GrowerResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_GrowerResources");
		NativeFieldInfoPtr_m_CmdBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_CmdBuffer");
		NativeFieldInfoPtr_m_CachedAmbientProbe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_CachedAmbientProbe");
		NativeFieldInfoPtr_m_SmallMeshScreenPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_SmallMeshScreenPercentage");
		NativeFieldInfoPtr_m_UpdateLODGroupCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_UpdateLODGroupCallback");
		NativeFieldInfoPtr_m_TransformLODGroupCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_TransformLODGroupCallback");
		NativeFieldInfoPtr_m_OcclusionCullingCommon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_OcclusionCullingCommon");
		NativeFieldInfoPtr_m_DebugStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, "m_DebugStats");
		NativeMethodInfoPtr_get_renderersParameters_Public_get_RenderersParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_get_gpuInstanceDataBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_get_defaultDescriptions_Public_get_ReadOnly_GPUInstanceComponentDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_get_defaultMetadata_Public_get_NativeArray_1_MetadataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_get_lodGroupCullingData_Public_get_NativeList_1_LODGroupCullingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_get_instanceDataBufferLayoutVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_get_crossfadedRendererCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_get_instanceDataBuffer_Public_get_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_get_smallMeshScreenPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_get_resources_Public_get_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_get_occlusionCullingCommon_Internal_get_OcclusionCullingCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_get_debugStats_Internal_get_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr__ctor_Public_Void_byref_RenderersBatchersContextDesc_GPUDrivenProcessor_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_GrowInstanceBuffer_Public_Void_byref_InstanceNumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_EnsureInstanceBufferCapacity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_UpdateLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_TransformLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_DestroyLODGroups_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_UpdateLODGroups_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_ChangeInstanceBufferVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_CreateDataBufferUploader_Public_GPUInstanceDataBufferUploader_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_InstanceHandle_byref_GPUInstanceDataBufferUploader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_GPUInstanceIndex_byref_GPUInstanceDataBufferUploader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_UpdateAmbientProbeAndGpuBuffer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_TransformLODGroups_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_UpdateFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr, 100664054);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075210, RefRangeEnd = 1075211, XrefRangeStart = 1075138, XrefRangeEnd = 1075210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderersBatchersContext([In] ref RenderersBatchersContextDesc desc, GPUDrivenProcessor gpuDrivenProcessor, GPUResidentDrawerResources resources)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderersBatchersContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gpuDrivenProcessor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_RenderersBatchersContextDesc_GPUDrivenProcessor_GPUResidentDrawerResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075240, RefRangeEnd = 1075241, XrefRangeStart = 1075211, XrefRangeEnd = 1075240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075243, RefRangeEnd = 1075244, XrefRangeStart = 1075241, XrefRangeEnd = 1075243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAliveInstancesOfType(InstanceType instanceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075253, RefRangeEnd = 1075255, XrefRangeStart = 1075244, XrefRangeEnd = 1075253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GrowInstanceBuffer([In] ref InstanceNumInfo instanceNumInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref instanceNumInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrowInstanceBuffer_Public_Void_byref_InstanceNumInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075255, XrefRangeEnd = 1075258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureInstanceBufferCapacity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInstanceBufferCapacity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075258, XrefRangeEnd = 1075260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLODGroupData([In] ref GPUDrivenLODGroupData lodGroupData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075260, XrefRangeEnd = 1075264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransformLODGroupData([In] ref GPUDrivenLODGroupData lodGroupData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformLODGroupData_Private_Void_byref_GPUDrivenLODGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075265, RefRangeEnd = 1075267, XrefRangeStart = 1075264, XrefRangeEnd = 1075265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyLODGroups(NativeArray<int> destroyed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyed));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyLODGroups_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075271, RefRangeEnd = 1075273, XrefRangeStart = 1075267, XrefRangeEnd = 1075271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLODGroups(NativeArray<int> changedID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changedID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLODGroups_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075277, RefRangeEnd = 1075278, XrefRangeStart = 1075273, XrefRangeEnd = 1075277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReallocateAndGetInstances([In] ref GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075279, RefRangeEnd = 1075280, XrefRangeStart = 1075278, XrefRangeEnd = 1075279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075281, RefRangeEnd = 1075282, XrefRangeStart = 1075280, XrefRangeEnd = 1075281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeRendererGroupInstances(NativeArray<int> rendererGroupsID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1075283, RefRangeEnd = 1075286, XrefRangeStart = 1075282, XrefRangeEnd = 1075283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075287, RefRangeEnd = 1075289, XrefRangeStart = 1075286, XrefRangeEnd = 1075287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1075290, RefRangeEnd = 1075293, XrefRangeStart = 1075289, XrefRangeEnd = 1075290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryMeshInstancesJob(NativeArray<int> sortedMeshIDs, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sortedMeshIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075293, RefRangeEnd = 1075294, XrefRangeStart = 1075293, XrefRangeEnd = 1075293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeInstanceBufferVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeInstanceBufferVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075295, RefRangeEnd = 1075297, XrefRangeStart = 1075294, XrefRangeEnd = 1075295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, InstanceType instanceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&capacity);
		*(InstanceType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDataBufferUploader_Public_GPUInstanceDataBufferUploader_Int32_InstanceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GPUInstanceDataBufferUploader(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075298, RefRangeEnd = 1075299, XrefRangeStart = 1075297, XrefRangeEnd = 1075298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitToGpu(NativeArray<InstanceHandle> instances, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)uploader);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &submitOnlyWrittenParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_InstanceHandle_byref_GPUInstanceDataBufferUploader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075300, RefRangeEnd = 1075301, XrefRangeStart = 1075299, XrefRangeEnd = 1075300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitToGpu(NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)uploader);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &submitOnlyWrittenParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitToGpu_Public_Void_NativeArray_1_GPUInstanceIndex_byref_GPUInstanceDataBufferUploader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075302, RefRangeEnd = 1075303, XrefRangeStart = 1075301, XrefRangeEnd = 1075302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)prevLocalToWorldMatrices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075304, RefRangeEnd = 1075306, XrefRangeStart = 1075303, XrefRangeEnd = 1075304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075310, RefRangeEnd = 1075312, XrefRangeStart = 1075306, XrefRangeEnd = 1075310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceUpdate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientProbeAndGpuBuffer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075313, RefRangeEnd = 1075314, XrefRangeStart = 1075312, XrefRangeEnd = 1075313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075315, RefRangeEnd = 1075316, XrefRangeStart = 1075314, XrefRangeEnd = 1075315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceMotions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075320, RefRangeEnd = 1075322, XrefRangeStart = 1075316, XrefRangeEnd = 1075320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransformLODGroups(NativeArray<int> lodGroupsID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformLODGroups_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075324, RefRangeEnd = 1075325, XrefRangeStart = 1075322, XrefRangeEnd = 1075324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePerFrameInstanceVisibility([In] ref ParallelBitArray compactedVisibilityMasks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)compactedVisibilityMasks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075327, RefRangeEnd = 1075328, XrefRangeStart = 1075325, XrefRangeEnd = 1075327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVisibleTreeInstances([In] ref ParallelBitArray compactedVisibilityMasks, [In] ref ParallelBitArray processedBits, NativeList<int> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)compactedVisibilityMasks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)processedBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibeTreeRendererIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibeTreeInstances));
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &becomeVisibleOnly;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref becomeVisibeTreeInstancesCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075330, RefRangeEnd = 1075332, XrefRangeStart = 1075328, XrefRangeEnd = 1075330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderersBatchersContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
