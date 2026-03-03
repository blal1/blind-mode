using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class CPUDrawInstanceData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_RangeHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawBatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawInstanceIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawBatchIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedsRebuild;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawInstances_Public_get_NativeList_1_DrawInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_batchHash_Public_get_NativeParallelHashMap_2_DrawKey_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawBatches_Public_get_NativeList_1_DrawBatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rangeHash_Public_get_NativeParallelHashMap_2_RangeKey_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawRanges_Public_get_NativeList_1_DrawRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawBatchIndices_Public_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawInstanceIndices_Public_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildDrawListsIfNeeded_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDrawInstanceIndices_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyMaterialDrawInstances_Public_Void_NativeArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedsRebuild_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NativeParallelHashMap<RangeKey, int> m_RangeHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RangeHash);
			return new NativeParallelHashMap<RangeKey, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<RangeKey, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RangeHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<RangeKey, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawRange> m_DrawRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawRanges);
			return new NativeList<DrawRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawRange>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawRange>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<DrawKey, int> m_BatchHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchHash);
			return new NativeParallelHashMap<DrawKey, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawBatch> m_DrawBatches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawBatches);
			return new NativeList<DrawBatch>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawBatches), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawInstance> m_DrawInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstances);
			return new NativeList<DrawInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_DrawInstanceIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstanceIndices);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInstanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_DrawBatchIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawBatchIndices);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawBatchIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_NeedsRebuild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsRebuild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsRebuild)) = value;
		}
	}

	public unsafe NativeList<DrawInstance> drawInstances
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawInstances_Public_get_NativeList_1_DrawInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeList<DrawInstance>(pointer);
		}
	}

	public unsafe NativeParallelHashMap<DrawKey, int> batchHash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_batchHash_Public_get_NativeParallelHashMap_2_DrawKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeParallelHashMap<DrawKey, int>(pointer);
		}
	}

	public unsafe NativeList<DrawBatch> drawBatches
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawBatches_Public_get_NativeList_1_DrawBatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeList<DrawBatch>(pointer);
		}
	}

	public unsafe NativeParallelHashMap<RangeKey, int> rangeHash
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rangeHash_Public_get_NativeParallelHashMap_2_RangeKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeParallelHashMap<RangeKey, int>(pointer);
		}
	}

	public unsafe NativeList<DrawRange> drawRanges
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawRanges_Public_get_NativeList_1_DrawRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeList<DrawRange>(pointer);
		}
	}

	public unsafe NativeArray<int> drawBatchIndices
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1070334, RefRangeEnd = 1070335, XrefRangeStart = 1070331, XrefRangeEnd = 1070334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawBatchIndices_Public_get_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	public unsafe NativeArray<int> drawInstanceIndices
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1070338, RefRangeEnd = 1070340, XrefRangeStart = 1070335, XrefRangeEnd = 1070338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawInstanceIndices_Public_get_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	static CPUDrawInstanceData()
	{
		Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CPUDrawInstanceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr);
		NativeFieldInfoPtr_m_RangeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_RangeHash");
		NativeFieldInfoPtr_m_DrawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_DrawRanges");
		NativeFieldInfoPtr_m_BatchHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_BatchHash");
		NativeFieldInfoPtr_m_DrawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_DrawBatches");
		NativeFieldInfoPtr_m_DrawInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_DrawInstances");
		NativeFieldInfoPtr_m_DrawInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_DrawInstanceIndices");
		NativeFieldInfoPtr_m_DrawBatchIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_DrawBatchIndices");
		NativeFieldInfoPtr_m_NeedsRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, "m_NeedsRebuild");
		NativeMethodInfoPtr_get_drawInstances_Public_get_NativeList_1_DrawInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_get_batchHash_Public_get_NativeParallelHashMap_2_DrawKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_get_drawBatches_Public_get_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_get_rangeHash_Public_get_NativeParallelHashMap_2_RangeKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_get_drawRanges_Public_get_NativeList_1_DrawRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_get_drawBatchIndices_Public_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_get_drawInstanceIndices_Public_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_RebuildDrawListsIfNeeded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_DestroyDrawInstanceIndices_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_DestroyMaterialDrawInstances_Public_Void_NativeArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_NeedsRebuild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr, 100663632);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070340, XrefRangeEnd = 1070367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070367, XrefRangeEnd = 1070397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070430, RefRangeEnd = 1070431, XrefRangeStart = 1070397, XrefRangeEnd = 1070430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildDrawListsIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildDrawListsIfNeeded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070431, XrefRangeEnd = 1070434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyDrawInstanceIndices(NativeArray<int> drawInstanceIndicesToDestroy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstanceIndicesToDestroy));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDrawInstanceIndices_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070473, RefRangeEnd = 1070474, XrefRangeStart = 1070434, XrefRangeEnd = 1070473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyDrawInstances(NativeArray<InstanceHandle> destroyedInstances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedInstances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDrawInstances_Public_Void_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070513, RefRangeEnd = 1070514, XrefRangeStart = 1070474, XrefRangeEnd = 1070513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyMaterialDrawInstances(NativeArray<uint> destroyedBatchMaterials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedBatchMaterials));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyMaterialDrawInstances_Public_Void_NativeArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void NeedsRebuild()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedsRebuild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CPUDrawInstanceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CPUDrawInstanceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CPUDrawInstanceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
