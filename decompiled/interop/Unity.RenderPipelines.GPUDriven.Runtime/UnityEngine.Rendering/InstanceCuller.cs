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
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public sealed class InstanceCuller : Il2CppSystem.ValueType
{
	public static class ShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_InstanceOcclusionCullerShaderVariables;

		private static readonly System.IntPtr NativeFieldInfoPtr__DrawInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr__InstanceInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr__DrawArgs;

		private static readonly System.IntPtr NativeFieldInfoPtr__InstanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr__InstanceDataBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__OccluderDepthPyramid;

		private static readonly System.IntPtr NativeFieldInfoPtr__OcclusionDebugCounters;

		public unsafe static int InstanceOcclusionCullerShaderVariables
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InstanceOcclusionCullerShaderVariables, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InstanceOcclusionCullerShaderVariables, (void*)(&value));
			}
		}

		public unsafe static int _DrawInfo
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DrawInfo, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DrawInfo, (void*)(&value));
			}
		}

		public unsafe static int _InstanceInfo
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InstanceInfo, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InstanceInfo, (void*)(&value));
			}
		}

		public unsafe static int _DrawArgs
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DrawArgs, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DrawArgs, (void*)(&value));
			}
		}

		public unsafe static int _InstanceIndices
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InstanceIndices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InstanceIndices, (void*)(&value));
			}
		}

		public unsafe static int _InstanceDataBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InstanceDataBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InstanceDataBuffer, (void*)(&value));
			}
		}

		public unsafe static int _OccluderDepthPyramid
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OccluderDepthPyramid, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OccluderDepthPyramid, (void*)(&value));
			}
		}

		public unsafe static int _OcclusionDebugCounters
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OcclusionDebugCounters, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OcclusionDebugCounters, (void*)(&value));
			}
		}

		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr_InstanceOcclusionCullerShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "InstanceOcclusionCullerShaderVariables");
			NativeFieldInfoPtr__DrawInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_DrawInfo");
			NativeFieldInfoPtr__InstanceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_InstanceInfo");
			NativeFieldInfoPtr__DrawArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_DrawArgs");
			NativeFieldInfoPtr__InstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_InstanceIndices");
			NativeFieldInfoPtr__InstanceDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_InstanceDataBuffer");
			NativeFieldInfoPtr__OccluderDepthPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OccluderDepthPyramid");
			NativeFieldInfoPtr__OcclusionDebugCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OcclusionDebugCounters");
		}

		public ShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class InstanceOcclusionTestPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_settings;

		private static readonly System.IntPtr NativeFieldInfoPtr_subviewSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_occluderHandles;

		private static readonly System.IntPtr NativeFieldInfoPtr_bufferHandles;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe OcclusionCullingSettings settings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
				return *(OcclusionCullingSettings*)num;
			}
			set
			{
				*(OcclusionCullingSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings)) = value;
			}
		}

		public unsafe InstanceOcclusionTestSubviewSettings subviewSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewSettings);
				return *(InstanceOcclusionTestSubviewSettings*)num;
			}
			set
			{
				*(InstanceOcclusionTestSubviewSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewSettings)) = value;
			}
		}

		public unsafe OccluderHandles occluderHandles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderHandles);
				return *(OccluderHandles*)num;
			}
			set
			{
				*(OccluderHandles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderHandles)) = value;
			}
		}

		public unsafe IndirectBufferContextHandles bufferHandles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferHandles);
				return *(IndirectBufferContextHandles*)num;
			}
			set
			{
				*(IndirectBufferContextHandles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferHandles)) = value;
			}
		}

		static InstanceOcclusionTestPassData()
		{
			Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "InstanceOcclusionTestPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr);
			NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr, "settings");
			NativeFieldInfoPtr_subviewSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr, "subviewSettings");
			NativeFieldInfoPtr_occluderHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr, "occluderHandles");
			NativeFieldInfoPtr_bufferHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr, "bufferHandles");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr, 100663590);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceOcclusionTestPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceOcclusionTestPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public InstanceOcclusionTestPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.InstanceCuller+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InstanceOcclusionTest_b__25_0_Internal_Void_InstanceOcclusionTestPassData_ComputeGraphContext_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<InstanceOcclusionTestPassData, ComputeGraphContext> __9__25_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<InstanceOcclusionTestPassData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663592);
			NativeMethodInfoPtr__InstanceOcclusionTest_b__25_0_Internal_Void_InstanceOcclusionTestPassData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663593);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069636, XrefRangeEnd = 1069639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InstanceOcclusionTest_b__25_0(InstanceOcclusionTestPassData data, ComputeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InstanceOcclusionTest_b__25_0_Internal_Void_InstanceOcclusionTestPassData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompactedVisibilityMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompactedVisibilityMasksJobsHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndirectStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OcclusionTestShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ResetDrawArgsKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CopyInstancesKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullInstancesKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitDebugArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OcclusionEventDebugArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSampleInstanceOcclusionTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShaderVariables;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ConstantBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CommandBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_DebugRendererBatcherStats_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFrustumCullingJob_Private_JobHandle_byref_BatchCullingContext_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_byref_BinningConfig_Single_OcclusionCullingCommon_NativeArray_1_Byte_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeWorstCaseDrawCommandCount_Private_Int32_byref_BatchCullingContext_BinningConfig_CPUDrawInstanceData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCullJobTree_Public_JobHandle_byref_BatchCullingContext_BatchCullingOutput_byref_ReadOnly_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_CPUDrawInstanceData_NativeParallelHashMap_2_UInt32_BatchID_Int32_Single_OcclusionCullingCommon_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCompactedVisibilityMaskJob_Private_JobHandle_byref_ReadOnly_NativeArray_1_Byte_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_RenderersBatchersContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeCompactVisibilityMasks_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeSceneViewHiddenBits_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_RenderersBatchersContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureValidOcclusionTestResults_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOcclusionCullingDispatch_Private_Void_ComputeCommandBuffer_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_IndirectBufferContextHandles_byref_OccluderHandles_RenderersBatchersContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushDebugCounters_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginSceneViewCameraRendering_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndSceneViewCameraRendering_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe ParallelBitArray m_CompactedVisibilityMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompactedVisibilityMasks);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompactedVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe JobHandle m_CompactedVisibilityMasksJobsHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompactedVisibilityMasksJobsHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompactedVisibilityMasksJobsHandle)) = value;
		}
	}

	public unsafe IndirectBufferContextStorage m_IndirectStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndirectStorage);
			return new IndirectBufferContextStorage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndirectStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe OcclusionTestComputeShader m_OcclusionTestShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionTestShader);
			return new OcclusionTestComputeShader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionTestShader), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OcclusionTestComputeShader>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_ResetDrawArgsKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResetDrawArgsKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResetDrawArgsKernel)) = value;
		}
	}

	public unsafe int m_CopyInstancesKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyInstancesKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyInstancesKernel)) = value;
		}
	}

	public unsafe int m_CullInstancesKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullInstancesKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullInstancesKernel)) = value;
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

	public unsafe InstanceCullerSplitDebugArray m_SplitDebugArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitDebugArray);
			return new InstanceCullerSplitDebugArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SplitDebugArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceCullerSplitDebugArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InstanceOcclusionEventDebugArray m_OcclusionEventDebugArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionEventDebugArray);
			return new InstanceOcclusionEventDebugArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionEventDebugArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceOcclusionEventDebugArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSampleInstanceOcclusionTest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSampleInstanceOcclusionTest);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSampleInstanceOcclusionTest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<InstanceOcclusionCullerShaderVariables> m_ShaderVariables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariables);
			return new NativeArray<InstanceOcclusionCullerShaderVariables>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceOcclusionCullerShaderVariables>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShaderVariables), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceOcclusionCullerShaderVariables>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeBuffer m_ConstantBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConstantBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ConstantBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CommandBuffer m_CommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InstanceCuller()
	{
		Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCuller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr);
		NativeFieldInfoPtr_m_CompactedVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_CompactedVisibilityMasks");
		NativeFieldInfoPtr_m_CompactedVisibilityMasksJobsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_CompactedVisibilityMasksJobsHandle");
		NativeFieldInfoPtr_m_IndirectStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_IndirectStorage");
		NativeFieldInfoPtr_m_OcclusionTestShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_OcclusionTestShader");
		NativeFieldInfoPtr_m_ResetDrawArgsKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_ResetDrawArgsKernel");
		NativeFieldInfoPtr_m_CopyInstancesKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_CopyInstancesKernel");
		NativeFieldInfoPtr_m_CullInstancesKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_CullInstancesKernel");
		NativeFieldInfoPtr_m_DebugStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_DebugStats");
		NativeFieldInfoPtr_m_SplitDebugArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_SplitDebugArray");
		NativeFieldInfoPtr_m_OcclusionEventDebugArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_OcclusionEventDebugArray");
		NativeFieldInfoPtr_m_ProfilingSampleInstanceOcclusionTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_ProfilingSampleInstanceOcclusionTest");
		NativeFieldInfoPtr_m_ShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_ShaderVariables");
		NativeFieldInfoPtr_m_ConstantBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_ConstantBuffer");
		NativeFieldInfoPtr_m_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, "m_CommandBuffer");
		NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_CreateFrustumCullingJob_Private_JobHandle_byref_BatchCullingContext_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_byref_BinningConfig_Single_OcclusionCullingCommon_NativeArray_1_Byte_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_ComputeWorstCaseDrawCommandCount_Private_Int32_byref_BatchCullingContext_BinningConfig_CPUDrawInstanceData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_CreateCullJobTree_Public_JobHandle_byref_BatchCullingContext_BatchCullingOutput_byref_ReadOnly_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_CPUDrawInstanceData_NativeParallelHashMap_2_UInt32_BatchID_Int32_Single_OcclusionCullingCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_CreateCompactedVisibilityMaskJob_Private_JobHandle_byref_ReadOnly_NativeArray_1_Byte_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_RenderersBatchersContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_DisposeCompactVisibilityMasks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_DisposeSceneViewHiddenBits_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_RenderersBatchersContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_EnsureValidOcclusionTestResults_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_AddOcclusionCullingDispatch_Private_Void_ComputeCommandBuffer_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_IndirectBufferContextHandles_byref_OccluderHandles_RenderersBatchersContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_FlushDebugCounters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_OnBeginSceneViewCameraRendering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_OnEndSceneViewCameraRendering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_UpdateFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr, 100663588);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069677, RefRangeEnd = 1069678, XrefRangeStart = 1069639, XrefRangeEnd = 1069677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(GPUResidentDrawerResources resources, DebugRendererBatcherStats debugStats = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugStats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_DebugRendererBatcherStats_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069727, RefRangeEnd = 1069728, XrefRangeStart = 1069678, XrefRangeEnd = 1069727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle CreateFrustumCullingJob([In] ref BatchCullingContext cc, [In] ref CPUInstanceData.ReadOnly instanceData, [In] ref CPUSharedInstanceData.ReadOnly sharedInstanceData, NativeList<LODGroupCullingData> lodGroupCullingData, [In] ref BinningConfig binningConfig, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon, NativeArray<byte> rendererVisibilityMasks, NativeArray<byte> rendererCrossFadeValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref binningConfig);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallMeshScreenPercentage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occlusionCullingCommon);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererVisibilityMasks));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererCrossFadeValues));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFrustumCullingJob_Private_JobHandle_byref_BatchCullingContext_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_byref_BinningConfig_Single_OcclusionCullingCommon_NativeArray_1_Byte_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069728, XrefRangeEnd = 1069734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ComputeWorstCaseDrawCommandCount([In] ref BatchCullingContext cc, BinningConfig binningConfig, CPUDrawInstanceData drawInstanceData, int crossFadedRendererCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(BinningConfig**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &binningConfig;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)drawInstanceData);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &crossFadedRendererCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeWorstCaseDrawCommandCount_Private_Int32_byref_BatchCullingContext_BinningConfig_CPUDrawInstanceData_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069815, RefRangeEnd = 1069816, XrefRangeStart = 1069734, XrefRangeEnd = 1069815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle CreateCullJobTree([In] ref BatchCullingContext cc, BatchCullingOutput cullingOutput, [In] ref CPUInstanceData.ReadOnly instanceData, [In] ref CPUSharedInstanceData.ReadOnly sharedInstanceData, [In] ref GPUInstanceDataBuffer.ReadOnly instanceDataBuffer, NativeList<LODGroupCullingData> lodGroupCullingData, CPUDrawInstanceData drawInstanceData, NativeParallelHashMap<uint, BatchID> batchIDs, int crossFadedRendererCount, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cullingOutput));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceDataBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)drawInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchIDs));
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &crossFadedRendererCount;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallMeshScreenPercentage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occlusionCullingCommon);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCullJobTree_Public_JobHandle_byref_BatchCullingContext_BatchCullingOutput_byref_ReadOnly_byref_ReadOnly_byref_ReadOnly_NativeList_1_LODGroupCullingData_CPUDrawInstanceData_NativeParallelHashMap_2_UInt32_BatchID_Int32_Single_OcclusionCullingCommon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069816, XrefRangeEnd = 1069823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle CreateCompactedVisibilityMaskJob([In] ref CPUInstanceData.ReadOnly instanceData, NativeArray<byte> rendererVisibilityMasks, JobHandle cullingJobHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererVisibilityMasks));
		*(JobHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingJobHandle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCompactedVisibilityMaskJob_Private_JobHandle_byref_ReadOnly_NativeArray_1_Byte_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069825, RefRangeEnd = 1069826, XrefRangeStart = 1069823, XrefRangeEnd = 1069825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, RenderersBatchersContext batchersContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&viewInstanceID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subviewMask;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batchersContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOccludersUpdated_Public_Void_Int32_Int32_RenderersBatchersContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069826, XrefRangeEnd = 1069828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeCompactVisibilityMasks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeCompactVisibilityMasks_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeSceneViewHiddenBits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeSceneViewHiddenBits_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069829, RefRangeEnd = 1069831, XrefRangeStart = 1069828, XrefRangeEnd = 1069829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&syncCullingJobs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompactedVisibilityMasks_Public_ParallelBitArray_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ParallelBitArray(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069873, RefRangeEnd = 1069875, XrefRangeStart = 1069831, XrefRangeEnd = 1069873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstanceOcclusionTest(RenderGraph renderGraph, [In] ref OcclusionCullingSettings settings, Il2CppSystem.ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests, RenderersBatchersContext batchersContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)subviewOcclusionTests));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batchersContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOcclusionTest_Public_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_RenderersBatchersContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069905, RefRangeEnd = 1069906, XrefRangeStart = 1069875, XrefRangeEnd = 1069905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureValidOcclusionTestResults(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureValidOcclusionTestResults_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070017, RefRangeEnd = 1070018, XrefRangeStart = 1069906, XrefRangeEnd = 1070017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOcclusionCullingDispatch(ComputeCommandBuffer cmd, [In] ref OcclusionCullingSettings settings, [In] ref InstanceOcclusionTestSubviewSettings subviewSettings, [In] ref IndirectBufferContextHandles bufferHandles, [In] ref OccluderHandles occluderHandles, RenderersBatchersContext batchersContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref subviewSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bufferHandles);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderHandles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)batchersContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOcclusionCullingDispatch_Private_Void_ComputeCommandBuffer_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_IndirectBufferContextHandles_byref_OccluderHandles_RenderersBatchersContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070018, XrefRangeEnd = 1070021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlushDebugCounters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushDebugCounters_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginSceneViewCameraRendering()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginSceneViewCameraRendering_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndSceneViewCameraRendering()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndSceneViewCameraRendering_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070028, RefRangeEnd = 1070029, XrefRangeStart = 1070021, XrefRangeEnd = 1070028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrame_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1070030, RefRangeEnd = 1070032, XrefRangeStart = 1070029, XrefRangeEnd = 1070030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginCameraRendering_Public_Void_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1070030, RefRangeEnd = 1070032, XrefRangeStart = 1070030, XrefRangeEnd = 1070032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndCameraRendering(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndCameraRendering_Public_Void_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070044, RefRangeEnd = 1070045, XrefRangeStart = 1070032, XrefRangeEnd = 1070044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceCuller(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InstanceCuller()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceCuller>.NativeClassPtr))
	{
	}
}
