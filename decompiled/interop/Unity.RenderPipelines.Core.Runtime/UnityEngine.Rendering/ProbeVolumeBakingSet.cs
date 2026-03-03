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
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

public sealed class ProbeVolumeBakingSet : ScriptableObject
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Version")]
	public enum Version
	{
		Initial,
		RemoveProbeVolumeSceneData,
		AssetsAlwaysReferenced
	}

	[System.Serializable]
	public class PerScenarioDataInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sceneHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellDataAsset;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellOptionalDataAsset;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellProbeOcclusionDataAsset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_HasValidData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ProbeVolumeSHBands_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HasValidData_Public_Boolean_ProbeVolumeSHBands_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHasValidData_Public_Boolean_ProbeVolumeSHBands_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int sceneHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneHash);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneHash)) = value;
			}
		}

		public unsafe ProbeVolumeStreamableAsset cellDataAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ProbeVolumeStreamableAsset cellOptionalDataAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellOptionalDataAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellOptionalDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellProbeOcclusionDataAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellProbeOcclusionDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool m_HasValidData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasValidData);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasValidData)) = value;
			}
		}

		static PerScenarioDataInfo()
		{
			Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "PerScenarioDataInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr);
			NativeFieldInfoPtr_sceneHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, "sceneHash");
			NativeFieldInfoPtr_cellDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, "cellDataAsset");
			NativeFieldInfoPtr_cellOptionalDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, "cellOptionalDataAsset");
			NativeFieldInfoPtr_cellProbeOcclusionDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, "cellProbeOcclusionDataAsset");
			NativeFieldInfoPtr_m_HasValidData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, "m_HasValidData");
			NativeMethodInfoPtr_Initialize_Public_Void_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, 100665812);
			NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, 100665813);
			NativeMethodInfoPtr_HasValidData_Public_Boolean_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, 100665814);
			NativeMethodInfoPtr_ComputeHasValidData_Public_Boolean_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, 100665815);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr, 100665816);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043872, XrefRangeEnd = 1043873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ProbeVolumeSHBands shBands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&shBands);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool HasValidData(ProbeVolumeSHBands shBands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&shBands);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValidData_Public_Boolean_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043873, XrefRangeEnd = 1043874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeHasValidData(ProbeVolumeSHBands shBands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&shBands);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHasValidData_Public_Boolean_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerScenarioDataInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerScenarioDataInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PerScenarioDataInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct CellCounts
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bricksCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_chunksCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_CellCounts_0;

		[FieldOffset(0)]
		public int bricksCount;

		[FieldOffset(4)]
		public int chunksCount;

		static CellCounts()
		{
			Il2CppClassPointerStore<CellCounts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "CellCounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellCounts>.NativeClassPtr);
			NativeFieldInfoPtr_bricksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellCounts>.NativeClassPtr, "bricksCount");
			NativeFieldInfoPtr_chunksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellCounts>.NativeClassPtr, "chunksCount");
			NativeMethodInfoPtr_Add_Public_Void_CellCounts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellCounts>.NativeClassPtr, 100665817);
		}

		[CallerCount(0)]
		public unsafe void Add(CellCounts o)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&o);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_CellCounts_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellCounts>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public sealed class SerializedPerSceneCellList : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sceneGUID;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellList;

		public unsafe string sceneGUID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneGUID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe List<int> cellList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SerializedPerSceneCellList()
		{
			Il2CppClassPointerStore<SerializedPerSceneCellList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "SerializedPerSceneCellList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPerSceneCellList>.NativeClassPtr);
			NativeFieldInfoPtr_sceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPerSceneCellList>.NativeClassPtr, "sceneGUID");
			NativeFieldInfoPtr_cellList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPerSceneCellList>.NativeClassPtr, "cellList");
		}

		public SerializedPerSceneCellList(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SerializedPerSceneCellList()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPerSceneCellList>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class ProbeLayerMask : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mask;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		public unsafe RenderingLayerMask mask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
				return *(RenderingLayerMask*)num;
			}
			set
			{
				*(RenderingLayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)) = value;
			}
		}

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static ProbeLayerMask()
		{
			Il2CppClassPointerStore<ProbeLayerMask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "ProbeLayerMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeLayerMask>.NativeClassPtr);
			NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeLayerMask>.NativeClassPtr, "mask");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeLayerMask>.NativeClassPtr, "name");
		}

		public ProbeLayerMask(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ProbeLayerMask()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeLayerMask>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0, Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadStreambleAssetData_Private_NativeArray_1_T_ProbeVolumeStreamableAsset_List_1_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadStreambleAssetData_Private_NativeArray_1_T_ProbeVolumeStreamableAsset_List_1_Int32_0, Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReleaseStreamableAssetData_Private_Void_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReleaseStreamableAssetData_Private_Void_NativeArray_1_T_0, Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_singleSceneMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogNoProbeVolumeInSetShown;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SceneGUIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_obsoleteScenesToNotBake;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightingScenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellDescs;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellDataMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalIndexList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SerializedPerSceneCellList;

	private static readonly System.IntPtr NativeFieldInfoPtr_perSceneCellLists;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellSharedDataAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_scenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellBricksDataAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellSupportDataAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkSizeInBricks;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCellPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_minCellPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedSimplificationLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedMinDistanceBetweenProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedSkyOcclusionValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedSkyShadingDirectionValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedProbeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedMaskCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakedLayerMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSHChunkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_L0ChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_L1ChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_L2TextureChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProbeOcclusionChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedValidityMaskChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedSkyOcclusionL0L1ChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedSkyShadingDirectionIndicesChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedDataChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportPositionChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportValidityChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportTouchupChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportLayerMaskChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportOffsetsChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDataChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightingScenario;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherScenario;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScenarioBlendingFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadCommandArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadCommandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadOperationScratchBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrunedIndexList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrunedScenarioIndexList;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxSkyOcclusionBakingSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_freezePlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_simplificationLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistanceBetweenProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderersLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_minRendererVolumeSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionBakingSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionBakingBounces;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionAverageAlbedo;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionBackFaceCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyOcclusionShadingDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRenderingLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasSupportData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SharedDataIsValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseStreamingAsset;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasDilation_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneGUIDs_Public_get_IReadOnlyList_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightingScenarios_Public_get_IReadOnlyList_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bakedSkyOcclusion_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bakedSkyOcclusion_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bakedSkyShadingDirection_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bakedSkyShadingDirection_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeRegionMasks_Internal_uint4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellSizeInBricks_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSubdivision_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinBrickSize_Internal_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Migrate_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHasValidSharedData_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValidSharedData_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCompatibleCellLayout_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHasSupportData_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSupportData_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBakedData_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBakingHashCode_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestScratchBuffer_Private_NativeArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadStreambleAssetData_Private_NativeArray_1_T_ProbeVolumeStreamableAsset_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseStreamableAssetData_Private_Void_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PruneCellIndexList_Private_Void_List_1_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PruneCellIndexListForScenario_Private_Void_List_1_Int32_PerScenarioDataInfo_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneCellIndexList_Internal_List_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAllCellData_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveCellData_Internal_Boolean_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveSharedCellData_Private_Void_List_1_Int32_NativeArray_1_Brick_NativeArray_1_Byte_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_NativeArray_1_Byte_NativeArray_1_Byte_NativeArray_1_Byte_String_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseCell_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellDesc_Internal_CellDesc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellData_Internal_CellData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkGPUMemory_Internal_Int32_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSameSceneGUIDs_Internal_Boolean_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool singleSceneMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleSceneMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleSceneMode)) = value;
		}
	}

	public unsafe bool dialogNoProbeVolumeInSetShown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogNoProbeVolumeInSetShown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogNoProbeVolumeInSetShown)) = value;
		}
	}

	public unsafe ProbeVolumeBakingProcessSettings settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
			return *(ProbeVolumeBakingProcessSettings*)num;
		}
		set
		{
			*(ProbeVolumeBakingProcessSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings)) = value;
		}
	}

	public unsafe List<string> m_SceneGUIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SceneGUIDs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SceneGUIDs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> obsoleteScenesToNotBake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obsoleteScenesToNotBake);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obsoleteScenesToNotBake)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> m_LightingScenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightingScenarios);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightingScenarios)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SerializedDictionary<int, ProbeReferenceVolume.CellDesc> cellDescs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDescs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializedDictionary<int, ProbeReferenceVolume.CellDesc>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDescs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, ProbeReferenceVolume.CellData> cellDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ProbeReferenceVolume.CellData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_TotalIndexList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalIndexList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalIndexList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<SerializedPerSceneCellList> m_SerializedPerSceneCellList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SerializedPerSceneCellList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SerializedPerSceneCellList>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SerializedPerSceneCellList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, List<int>> perSceneCellLists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSceneCellLists);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSceneCellLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeStreamableAsset cellSharedDataAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSharedDataAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSharedDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SerializedDictionary<string, PerScenarioDataInfo> scenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarios);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializedDictionary<string, PerScenarioDataInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarios)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeStreamableAsset cellBricksDataAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellBricksDataAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellBricksDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeStreamableAsset cellSupportDataAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSupportDataAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeStreamableAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSupportDataAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int chunkSizeInBricks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSizeInBricks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSizeInBricks)) = value;
		}
	}

	public unsafe Vector3Int maxCellPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCellPosition);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCellPosition)) = value;
		}
	}

	public unsafe Vector3Int minCellPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCellPosition);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCellPosition)) = value;
		}
	}

	public unsafe Bounds globalBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalBounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalBounds)) = value;
		}
	}

	public unsafe int bakedSimplificationLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSimplificationLevels);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSimplificationLevels)) = value;
		}
	}

	public unsafe float bakedMinDistanceBetweenProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedMinDistanceBetweenProbes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedMinDistanceBetweenProbes)) = value;
		}
	}

	public unsafe bool bakedProbeOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedProbeOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedProbeOcclusion)) = value;
		}
	}

	public unsafe int bakedSkyOcclusionValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSkyOcclusionValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSkyOcclusionValue)) = value;
		}
	}

	public unsafe int bakedSkyShadingDirectionValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSkyShadingDirectionValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedSkyShadingDirectionValue)) = value;
		}
	}

	public unsafe Vector3 bakedProbeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedProbeOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedProbeOffset)) = value;
		}
	}

	public unsafe int bakedMaskCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedMaskCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedMaskCount)) = value;
		}
	}

	public unsafe uint4 bakedLayerMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedLayerMasks);
			return *(uint4*)num;
		}
		set
		{
			*(uint4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakedLayerMasks)) = value;
		}
	}

	public unsafe int maxSHChunkCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSHChunkCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSHChunkCount)) = value;
		}
	}

	public unsafe int L0ChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L0ChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L0ChunkSize)) = value;
		}
	}

	public unsafe int L1ChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1ChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1ChunkSize)) = value;
		}
	}

	public unsafe int L2TextureChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2TextureChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2TextureChunkSize)) = value;
		}
	}

	public unsafe int ProbeOcclusionChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProbeOcclusionChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProbeOcclusionChunkSize)) = value;
		}
	}

	public unsafe int sharedValidityMaskChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedValidityMaskChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedValidityMaskChunkSize)) = value;
		}
	}

	public unsafe int sharedSkyOcclusionL0L1ChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedSkyOcclusionL0L1ChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedSkyOcclusionL0L1ChunkSize)) = value;
		}
	}

	public unsafe int sharedSkyShadingDirectionIndicesChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedSkyShadingDirectionIndicesChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedSkyShadingDirectionIndicesChunkSize)) = value;
		}
	}

	public unsafe int sharedDataChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedDataChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedDataChunkSize)) = value;
		}
	}

	public unsafe int supportPositionChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportPositionChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportPositionChunkSize)) = value;
		}
	}

	public unsafe int supportValidityChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportValidityChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportValidityChunkSize)) = value;
		}
	}

	public unsafe int supportTouchupChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportTouchupChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportTouchupChunkSize)) = value;
		}
	}

	public unsafe int supportLayerMaskChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportLayerMaskChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportLayerMaskChunkSize)) = value;
		}
	}

	public unsafe int supportOffsetsChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportOffsetsChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportOffsetsChunkSize)) = value;
		}
	}

	public unsafe int supportDataChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDataChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDataChunkSize)) = value;
		}
	}

	public unsafe string lightingScenario
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingScenario);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingScenario)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_OtherScenario
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherScenario);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherScenario)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float m_ScenarioBlendingFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScenarioBlendingFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScenarioBlendingFactor)) = value;
		}
	}

	public unsafe ReadCommandArray m_ReadCommandArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandArray);
			return *(ReadCommandArray*)num;
		}
		set
		{
			*(ReadCommandArray*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandArray)) = value;
		}
	}

	public unsafe NativeArray<ReadCommand> m_ReadCommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandBuffer);
			return new NativeArray<ReadCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ReadCommand>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReadCommand>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Stack<NativeArray<byte>> m_ReadOperationScratchBuffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadOperationScratchBuffers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<NativeArray<byte>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadOperationScratchBuffers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_PrunedIndexList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrunedIndexList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrunedIndexList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_PrunedScenarioIndexList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrunedScenarioIndexList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrunedScenarioIndexList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_MaxSkyOcclusionBakingSamples
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxSkyOcclusionBakingSamples, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxSkyOcclusionBakingSamples, (void*)(&value));
		}
	}

	public unsafe Version version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return *(Version*)num;
		}
		set
		{
			*(Version*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)) = value;
		}
	}

	public unsafe bool freezePlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezePlacement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezePlacement)) = value;
		}
	}

	public unsafe Vector3 probeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeOffset)) = value;
		}
	}

	public unsafe int simplificationLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simplificationLevels);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simplificationLevels)) = value;
		}
	}

	public unsafe float minDistanceBetweenProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceBetweenProbes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceBetweenProbes)) = value;
		}
	}

	public unsafe LayerMask renderersLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderersLayerMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderersLayerMask)) = value;
		}
	}

	public unsafe float minRendererVolumeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRendererVolumeSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRendererVolumeSize)) = value;
		}
	}

	public unsafe bool skyOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusion)) = value;
		}
	}

	public unsafe int skyOcclusionBakingSamples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBakingSamples);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBakingSamples)) = value;
		}
	}

	public unsafe int skyOcclusionBakingBounces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBakingBounces);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBakingBounces)) = value;
		}
	}

	public unsafe float skyOcclusionAverageAlbedo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionAverageAlbedo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionAverageAlbedo)) = value;
		}
	}

	public unsafe bool skyOcclusionBackFaceCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBackFaceCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionBackFaceCulling)) = value;
		}
	}

	public unsafe bool skyOcclusionShadingDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionShadingDirection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionShadingDirection)) = value;
		}
	}

	public unsafe bool useRenderingLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRenderingLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRenderingLayers)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<ProbeLayerMask> renderingLayerMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProbeLayerMask>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_HasSupportData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasSupportData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasSupportData)) = value;
		}
	}

	public unsafe bool m_SharedDataIsValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedDataIsValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedDataIsValid)) = value;
		}
	}

	public unsafe bool m_UseStreamingAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStreamingAsset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStreamingAsset)) = value;
		}
	}

	public unsafe bool hasDilation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasDilation_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe IReadOnlyList<string> sceneGUIDs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sceneGUIDs_Public_get_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
		}
	}

	public unsafe IReadOnlyList<string> lightingScenarios
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightingScenarios_Public_get_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
		}
	}

	public unsafe bool bakedSkyOcclusion
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043874, RefRangeEnd = 1043875, XrefRangeStart = 1043874, XrefRangeEnd = 1043874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bakedSkyOcclusion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bakedSkyOcclusion_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool bakedSkyShadingDirection
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043875, RefRangeEnd = 1043876, XrefRangeStart = 1043875, XrefRangeEnd = 1043875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bakedSkyShadingDirection_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bakedSkyShadingDirection_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string otherScenario
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe float scenarioBlendingFactor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int cellSizeInBricks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043876, XrefRangeEnd = 1043877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int maxSubdivision
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043877, RefRangeEnd = 1043878, XrefRangeStart = 1043877, XrefRangeEnd = 1043877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float minBrickSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043878, RefRangeEnd = 1043879, XrefRangeStart = 1043878, XrefRangeEnd = 1043878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float cellSizeInMeters
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043879, XrefRangeEnd = 1043880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProbeVolumeBakingSet()
	{
		Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeBakingSet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr);
		NativeFieldInfoPtr_singleSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "singleSceneMode");
		NativeFieldInfoPtr_dialogNoProbeVolumeInSetShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "dialogNoProbeVolumeInSetShown");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_m_SceneGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_SceneGUIDs");
		NativeFieldInfoPtr_obsoleteScenesToNotBake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "obsoleteScenesToNotBake");
		NativeFieldInfoPtr_m_LightingScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_LightingScenarios");
		NativeFieldInfoPtr_cellDescs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "cellDescs");
		NativeFieldInfoPtr_cellDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "cellDataMap");
		NativeFieldInfoPtr_m_TotalIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_TotalIndexList");
		NativeFieldInfoPtr_m_SerializedPerSceneCellList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_SerializedPerSceneCellList");
		NativeFieldInfoPtr_perSceneCellLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "perSceneCellLists");
		NativeFieldInfoPtr_cellSharedDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "cellSharedDataAsset");
		NativeFieldInfoPtr_scenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "scenarios");
		NativeFieldInfoPtr_cellBricksDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "cellBricksDataAsset");
		NativeFieldInfoPtr_cellSupportDataAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "cellSupportDataAsset");
		NativeFieldInfoPtr_chunkSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "chunkSizeInBricks");
		NativeFieldInfoPtr_maxCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "maxCellPosition");
		NativeFieldInfoPtr_minCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "minCellPosition");
		NativeFieldInfoPtr_globalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "globalBounds");
		NativeFieldInfoPtr_bakedSimplificationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedSimplificationLevels");
		NativeFieldInfoPtr_bakedMinDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedMinDistanceBetweenProbes");
		NativeFieldInfoPtr_bakedProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedProbeOcclusion");
		NativeFieldInfoPtr_bakedSkyOcclusionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedSkyOcclusionValue");
		NativeFieldInfoPtr_bakedSkyShadingDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedSkyShadingDirectionValue");
		NativeFieldInfoPtr_bakedProbeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedProbeOffset");
		NativeFieldInfoPtr_bakedMaskCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedMaskCount");
		NativeFieldInfoPtr_bakedLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "bakedLayerMasks");
		NativeFieldInfoPtr_maxSHChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "maxSHChunkCount");
		NativeFieldInfoPtr_L0ChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "L0ChunkSize");
		NativeFieldInfoPtr_L1ChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "L1ChunkSize");
		NativeFieldInfoPtr_L2TextureChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "L2TextureChunkSize");
		NativeFieldInfoPtr_ProbeOcclusionChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "ProbeOcclusionChunkSize");
		NativeFieldInfoPtr_sharedValidityMaskChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "sharedValidityMaskChunkSize");
		NativeFieldInfoPtr_sharedSkyOcclusionL0L1ChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "sharedSkyOcclusionL0L1ChunkSize");
		NativeFieldInfoPtr_sharedSkyShadingDirectionIndicesChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "sharedSkyShadingDirectionIndicesChunkSize");
		NativeFieldInfoPtr_sharedDataChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "sharedDataChunkSize");
		NativeFieldInfoPtr_supportPositionChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportPositionChunkSize");
		NativeFieldInfoPtr_supportValidityChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportValidityChunkSize");
		NativeFieldInfoPtr_supportTouchupChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportTouchupChunkSize");
		NativeFieldInfoPtr_supportLayerMaskChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportLayerMaskChunkSize");
		NativeFieldInfoPtr_supportOffsetsChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportOffsetsChunkSize");
		NativeFieldInfoPtr_supportDataChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "supportDataChunkSize");
		NativeFieldInfoPtr_lightingScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "lightingScenario");
		NativeFieldInfoPtr_m_OtherScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_OtherScenario");
		NativeFieldInfoPtr_m_ScenarioBlendingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_ScenarioBlendingFactor");
		NativeFieldInfoPtr_m_ReadCommandArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_ReadCommandArray");
		NativeFieldInfoPtr_m_ReadCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_ReadCommandBuffer");
		NativeFieldInfoPtr_m_ReadOperationScratchBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_ReadOperationScratchBuffers");
		NativeFieldInfoPtr_m_PrunedIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_PrunedIndexList");
		NativeFieldInfoPtr_m_PrunedScenarioIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_PrunedScenarioIndexList");
		NativeFieldInfoPtr_k_MaxSkyOcclusionBakingSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "k_MaxSkyOcclusionBakingSamples");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "version");
		NativeFieldInfoPtr_freezePlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "freezePlacement");
		NativeFieldInfoPtr_probeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "probeOffset");
		NativeFieldInfoPtr_simplificationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "simplificationLevels");
		NativeFieldInfoPtr_minDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "minDistanceBetweenProbes");
		NativeFieldInfoPtr_renderersLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "renderersLayerMask");
		NativeFieldInfoPtr_minRendererVolumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "minRendererVolumeSize");
		NativeFieldInfoPtr_skyOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusion");
		NativeFieldInfoPtr_skyOcclusionBakingSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusionBakingSamples");
		NativeFieldInfoPtr_skyOcclusionBakingBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusionBakingBounces");
		NativeFieldInfoPtr_skyOcclusionAverageAlbedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusionAverageAlbedo");
		NativeFieldInfoPtr_skyOcclusionBackFaceCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusionBackFaceCulling");
		NativeFieldInfoPtr_skyOcclusionShadingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "skyOcclusionShadingDirection");
		NativeFieldInfoPtr_useRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "useRenderingLayers");
		NativeFieldInfoPtr_renderingLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "renderingLayerMasks");
		NativeFieldInfoPtr_m_HasSupportData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_HasSupportData");
		NativeFieldInfoPtr_m_SharedDataIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_SharedDataIsValid");
		NativeFieldInfoPtr_m_UseStreamingAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, "m_UseStreamingAsset");
		NativeMethodInfoPtr_get_hasDilation_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665758);
		NativeMethodInfoPtr_get_sceneGUIDs_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665759);
		NativeMethodInfoPtr_get_lightingScenarios_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665760);
		NativeMethodInfoPtr_get_bakedSkyOcclusion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665761);
		NativeMethodInfoPtr_set_bakedSkyOcclusion_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665762);
		NativeMethodInfoPtr_get_bakedSkyShadingDirection_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665763);
		NativeMethodInfoPtr_set_bakedSkyShadingDirection_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665764);
		NativeMethodInfoPtr_get_otherScenario_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665765);
		NativeMethodInfoPtr_get_scenarioBlendingFactor_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665766);
		NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665768);
		NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_ComputeRegionMasks_Internal_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_GetCellSizeInBricks_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_GetMaxSubdivision_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665773);
		NativeMethodInfoPtr_GetMinBrickSize_Internal_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665774);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665775);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665776);
		NativeMethodInfoPtr_Migrate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665777);
		NativeMethodInfoPtr_ComputeHasValidSharedData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665778);
		NativeMethodInfoPtr_HasValidSharedData_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665779);
		NativeMethodInfoPtr_CheckCompatibleCellLayout_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665780);
		NativeMethodInfoPtr_ComputeHasSupportData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665781);
		NativeMethodInfoPtr_HasSupportData_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665782);
		NativeMethodInfoPtr_HasBakedData_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665783);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665784);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665785);
		NativeMethodInfoPtr_Initialize_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665786);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665787);
		NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665788);
		NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665789);
		NativeMethodInfoPtr_GetBakingHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665790);
		NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665792);
		NativeMethodInfoPtr_RequestScratchBuffer_Private_NativeArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665793);
		NativeMethodInfoPtr_FileExists_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_LoadStreambleAssetData_Private_NativeArray_1_T_ProbeVolumeStreamableAsset_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_ReleaseStreamableAssetData_Private_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_PruneCellIndexList_Private_Void_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_PruneCellIndexListForScenario_Private_Void_List_1_Int32_PerScenarioDataInfo_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr_GetSceneCellIndexList_Internal_List_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665799);
		NativeMethodInfoPtr_ResolveAllCellData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_ResolveCellData_Internal_Boolean_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr_ResolveSharedCellData_Private_Void_List_1_Int32_NativeArray_1_Brick_NativeArray_1_Byte_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665802);
		NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665803);
		NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_NativeArray_1_Byte_NativeArray_1_Byte_NativeArray_1_Byte_String_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_ReleaseCell_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_GetCellDesc_Internal_CellDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_GetCellData_Internal_CellData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_GetChunkGPUMemory_Internal_Int32_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_HasSameSceneGUIDs_Internal_Boolean_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr, 100665811);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043880, XrefRangeEnd = 1043886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint4 ComputeRegionMasks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeRegionMasks_Internal_uint4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1040646, RefRangeEnd = 1040651, XrefRangeStart = 1040646, XrefRangeEnd = 1040651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCellSizeInBricks(int simplificationLevels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&simplificationLevels);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellSizeInBricks_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetMaxSubdivision(int simplificationLevels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&simplificationLevels);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxSubdivision_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetMinBrickSize(float minDistanceBetweenProbes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&minDistanceBetweenProbes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinBrickSize_Internal_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043886, XrefRangeEnd = 1043904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043904, XrefRangeEnd = 1043925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043925, XrefRangeEnd = 1043941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Migrate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Migrate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043941, XrefRangeEnd = 1043943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputeHasValidSharedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHasValidSharedData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasValidSharedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValidSharedData_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool CheckCompatibleCellLayout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCompatibleCellLayout_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043943, XrefRangeEnd = 1043945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputeHasSupportData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHasSupportData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasSupportData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSupportData_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043945, XrefRangeEnd = 1043957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasBakedData(string scenario = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBakedData_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043957, XrefRangeEnd = 1044020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044020, XrefRangeEnd = 1044050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044107, RefRangeEnd = 1044108, XrefRangeStart = 1044050, XrefRangeEnd = 1044107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(bool useStreamingAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useStreamingAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1044156, RefRangeEnd = 1044158, XrefRangeStart = 1044108, XrefRangeEnd = 1044156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1044187, RefRangeEnd = 1044189, XrefRangeStart = 1044158, XrefRangeEnd = 1044187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveScenario(string scenario, bool verbose = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &verbose;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1044215, RefRangeEnd = 1044219, XrefRangeStart = 1044189, XrefRangeEnd = 1044215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlendLightingScenario(string otherScenario, float blendingFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(otherScenario);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blendingFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendLightingScenario_Internal_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044219, XrefRangeEnd = 1044231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBakingHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBakingHashCode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044231, RefRangeEnd = 1044232, XrefRangeStart = 1044231, XrefRangeEnd = 1044231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AlignUp16(int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044232, XrefRangeEnd = 1044238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044238, XrefRangeEnd = 1044244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<byte> RequestScratchBuffer(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestScratchBuffer_Private_NativeArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1044247, RefRangeEnd = 1044249, XrefRangeStart = 1044244, XrefRangeEnd = 1044247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FileExists(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileExists_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1044269, RefRangeEnd = 1044274, XrefRangeStart = 1044249, XrefRangeEnd = 1044269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> LoadStreambleAssetData<T>(ProbeVolumeStreamableAsset asset, List<int> cellIndices) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadStreambleAssetData_Private_NativeArray_1_T_ProbeVolumeStreamableAsset_List_1_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1044279, RefRangeEnd = 1044284, XrefRangeStart = 1044274, XrefRangeEnd = 1044279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseStreamableAssetData<T>(NativeArray<T> buffer) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReleaseStreamableAssetData_Private_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044305, RefRangeEnd = 1044306, XrefRangeStart = 1044284, XrefRangeEnd = 1044305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PruneCellIndexList(List<int> cellIndices, List<int> prunedIndexList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prunedIndexList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PruneCellIndexList_Private_Void_List_1_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044327, RefRangeEnd = 1044328, XrefRangeStart = 1044306, XrefRangeEnd = 1044327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PruneCellIndexListForScenario(List<int> cellIndices, PerScenarioDataInfo scenarioData, List<int> prunedIndexList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scenarioData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prunedIndexList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PruneCellIndexListForScenario_Private_Void_List_1_Int32_PerScenarioDataInfo_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1044331, RefRangeEnd = 1044335, XrefRangeStart = 1044328, XrefRangeEnd = 1044331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetSceneCellIndexList(string sceneGUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneGUID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSceneCellIndexList_Internal_List_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044335, XrefRangeEnd = 1044336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResolveAllCellData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveAllCellData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044387, RefRangeEnd = 1044388, XrefRangeStart = 1044336, XrefRangeEnd = 1044387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResolveCellData(List<int> cellIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveCellData_Internal_Boolean_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044488, RefRangeEnd = 1044489, XrefRangeStart = 1044388, XrefRangeEnd = 1044488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResolveSharedCellData(List<int> cellIndices, NativeArray<ProbeBrickIndex.Brick> bricksData, NativeArray<byte> cellSharedData, NativeArray<byte> cellSupportData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bricksData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cellSharedData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cellSupportData));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveSharedCellData_Private_Void_List_1_Int32_NativeArray_1_Brick_NativeArray_1_Byte_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1044511, RefRangeEnd = 1044514, XrefRangeStart = 1044489, XrefRangeEnd = 1044511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResolveSharedCellData(List<int> cellIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1044588, RefRangeEnd = 1044590, XrefRangeStart = 1044514, XrefRangeEnd = 1044588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResolvePerScenarioCellData(List<int> cellIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044652, RefRangeEnd = 1044653, XrefRangeStart = 1044590, XrefRangeEnd = 1044652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResolvePerScenarioCellData(NativeArray<byte> cellData, NativeArray<byte> cellOptionalData, NativeArray<byte> cellProbeOcclusionData, string scenario, List<int> cellIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cellData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cellOptionalData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cellProbeOcclusionData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(scenario);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_NativeArray_1_Byte_NativeArray_1_Byte_NativeArray_1_Byte_String_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044661, RefRangeEnd = 1044662, XrefRangeStart = 1044653, XrefRangeEnd = 1044661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseCell(int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseCell_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044662, XrefRangeEnd = 1044665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeReferenceVolume.CellDesc GetCellDesc(int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellDesc_Internal_CellDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellDesc>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044665, XrefRangeEnd = 1044668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeReferenceVolume.CellData GetCellData(int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellData_Internal_CellData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellData>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1044668, RefRangeEnd = 1044670, XrefRangeStart = 1044668, XrefRangeEnd = 1044668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetChunkGPUMemory(ProbeVolumeSHBands shBands)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shBands);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkGPUMemory_Internal_Int32_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1044684, RefRangeEnd = 1044685, XrefRangeStart = 1044670, XrefRangeEnd = 1044684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSameSceneGUIDs(ProbeVolumeBakingSet other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSameSceneGUIDs_Internal_Boolean_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044685, XrefRangeEnd = 1044771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolumeBakingSet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeBakingSet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeVolumeBakingSet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
