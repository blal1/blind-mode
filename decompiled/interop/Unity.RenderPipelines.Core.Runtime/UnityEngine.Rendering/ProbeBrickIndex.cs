using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class ProbeBrickIndex : Il2CppSystem.Object
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct Brick
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_subdivisionLevel;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IntersectArea_Public_Boolean_Bounds_0;

		[FieldOffset(0)]
		public Vector3Int position;

		[FieldOffset(12)]
		public int subdivisionLevel;

		static Brick()
		{
			Il2CppClassPointerStore<Brick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "Brick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Brick>.NativeClassPtr);
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brick>.NativeClassPtr, "position");
			NativeFieldInfoPtr_subdivisionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brick>.NativeClassPtr, "subdivisionLevel");
			NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brick>.NativeClassPtr, 100665295);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brick>.NativeClassPtr, 100665296);
			NativeMethodInfoPtr_IntersectArea_Public_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brick>.NativeClassPtr, 100665297);
		}

		[CallerCount(0)]
		public unsafe Brick(Vector3Int position, int subdivisionLevel)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&position);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subdivisionLevel;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool Equals(Brick other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037630, XrefRangeEnd = 1037635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntersectArea(Bounds boundInBricksToCheck)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&boundInBricksToCheck);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntersectArea_Public_Boolean_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Brick>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct IndirectionEntryUpdateInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_firstChunkIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_numberOfChunks;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSubdivInCell;

		private static readonly System.IntPtr NativeFieldInfoPtr_minValidBrickIndexForCellAtMaxRes;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxValidBrickIndexForCellAtMaxResPlusOne;

		private static readonly System.IntPtr NativeFieldInfoPtr_entryPositionInBricksAtMaxRes;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasOnlyBiggerBricks;

		[FieldOffset(0)]
		public int firstChunkIndex;

		[FieldOffset(4)]
		public int numberOfChunks;

		[FieldOffset(8)]
		public int minSubdivInCell;

		[FieldOffset(12)]
		public Vector3Int minValidBrickIndexForCellAtMaxRes;

		[FieldOffset(24)]
		public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;

		[FieldOffset(36)]
		public Vector3Int entryPositionInBricksAtMaxRes;

		[FieldOffset(48)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasOnlyBiggerBricks;

		static IndirectionEntryUpdateInfo()
		{
			Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "IndirectionEntryUpdateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr);
			NativeFieldInfoPtr_firstChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "firstChunkIndex");
			NativeFieldInfoPtr_numberOfChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "numberOfChunks");
			NativeFieldInfoPtr_minSubdivInCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "minSubdivInCell");
			NativeFieldInfoPtr_minValidBrickIndexForCellAtMaxRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "minValidBrickIndexForCellAtMaxRes");
			NativeFieldInfoPtr_maxValidBrickIndexForCellAtMaxResPlusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "maxValidBrickIndexForCellAtMaxResPlusOne");
			NativeFieldInfoPtr_entryPositionInBricksAtMaxRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "entryPositionInBricksAtMaxRes");
			NativeFieldInfoPtr_hasOnlyBiggerBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, "hasOnlyBiggerBricks");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectionEntryUpdateInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class CellIndexUpdateInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_entriesInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfChunks_Public_Int32_0;

		public unsafe Il2CppStructArray<IndirectionEntryUpdateInfo> entriesInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entriesInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<IndirectionEntryUpdateInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entriesInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CellIndexUpdateInfo()
		{
			Il2CppClassPointerStore<CellIndexUpdateInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "CellIndexUpdateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellIndexUpdateInfo>.NativeClassPtr);
			NativeFieldInfoPtr_entriesInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexUpdateInfo>.NativeClassPtr, "entriesInfo");
			NativeMethodInfoPtr_GetNumberOfChunks_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellIndexUpdateInfo>.NativeClassPtr, 100665298);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1037636, RefRangeEnd = 1037640, XrefRangeStart = 1037635, XrefRangeEnd = 1037636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumberOfChunks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumberOfChunks_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public CellIndexUpdateInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CellIndexUpdateInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellIndexUpdateInfo>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxSubdivisionLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_kIndexChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFailChunkIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_kEmptyIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexChunksCopyForChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChunksCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableChunkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PhysicalIndexBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PhysicalIndexBufferData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugFragmentationBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugFragmentationData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateMinIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateMaxIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__fragmentationRate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CenterRS;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugFragmentationBuffer_Internal_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fragmentationRate_Internal_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fragmentationRate_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UploadIndexData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDebugData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFragmentationRate_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfChunks_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSlotsForEntries_Internal_Boolean_byref_Il2CppStructArray_1_IndirectionEntryUpdateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReserveChunks_Internal_Boolean_Il2CppStructArray_1_IndirectionEntryUpdateInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BrickOverlapEntry_Internal_Static_Boolean_Vector3Int_Vector3Int_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocationToIndex_Private_Static_Int32_Int32_Int32_Int32_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkBrickInPhysicalBuffer_Private_Void_byref_IndirectionEntryUpdateInfo_Vector3Int_Vector3Int_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBricks_Public_Void_CellIndexInfo_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBricks_Public_Void_CellIndexInfo_0;

	public unsafe static int kMaxSubdivisionLevels
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxSubdivisionLevels, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxSubdivisionLevels, (void*)(&value));
		}
	}

	public unsafe static int kIndexChunkSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kIndexChunkSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kIndexChunkSize, (void*)(&value));
		}
	}

	public unsafe static int kFailChunkIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFailChunkIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFailChunkIndex, (void*)(&value));
		}
	}

	public unsafe static int kEmptyIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kEmptyIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kEmptyIndex, (void*)(&value));
		}
	}

	public unsafe BitArray m_IndexChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexChunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexChunks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BitArray m_IndexChunksCopyForChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexChunksCopyForChecks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexChunksCopyForChecks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_ChunksCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChunksCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChunksCount)) = value;
		}
	}

	public unsafe int m_AvailableChunkCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvailableChunkCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvailableChunkCount)) = value;
		}
	}

	public unsafe ComputeBuffer m_PhysicalIndexBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PhysicalIndexBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PhysicalIndexBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<int> m_PhysicalIndexBufferData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PhysicalIndexBufferData);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PhysicalIndexBufferData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeBuffer m_DebugFragmentationBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> m_DebugFragmentationData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_NeedUpdateIndexComputeBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer)) = value;
		}
	}

	public unsafe int m_UpdateMinIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMinIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMinIndex)) = value;
		}
	}

	public unsafe int m_UpdateMaxIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMaxIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMaxIndex)) = value;
		}
	}

	public unsafe int _estimatedVMemCost_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__estimatedVMemCost_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__estimatedVMemCost_k__BackingField)) = value;
		}
	}

	public unsafe float _fragmentationRate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fragmentationRate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fragmentationRate_k__BackingField)) = value;
		}
	}

	public unsafe Vector3Int m_CenterRS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterRS);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterRS)) = value;
		}
	}

	public unsafe int estimatedVMemCost
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87098, RefRangeEnd = 87099, XrefRangeStart = 87098, XrefRangeEnd = 87099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float fragmentationRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fragmentationRate_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fragmentationRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ProbeBrickIndex()
	{
		Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickIndex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr);
		NativeFieldInfoPtr_kMaxSubdivisionLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kMaxSubdivisionLevels");
		NativeFieldInfoPtr_kIndexChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kIndexChunkSize");
		NativeFieldInfoPtr_kFailChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kFailChunkIndex");
		NativeFieldInfoPtr_kEmptyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kEmptyIndex");
		NativeFieldInfoPtr_m_IndexChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_IndexChunks");
		NativeFieldInfoPtr_m_IndexChunksCopyForChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_IndexChunksCopyForChecks");
		NativeFieldInfoPtr_m_ChunksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_ChunksCount");
		NativeFieldInfoPtr_m_AvailableChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_AvailableChunkCount");
		NativeFieldInfoPtr_m_PhysicalIndexBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_PhysicalIndexBuffer");
		NativeFieldInfoPtr_m_PhysicalIndexBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_PhysicalIndexBufferData");
		NativeFieldInfoPtr_m_DebugFragmentationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_DebugFragmentationBuffer");
		NativeFieldInfoPtr_m_DebugFragmentationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_DebugFragmentationData");
		NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_NeedUpdateIndexComputeBuffer");
		NativeFieldInfoPtr_m_UpdateMinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_UpdateMinIndex");
		NativeFieldInfoPtr_m_UpdateMaxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_UpdateMaxIndex");
		NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
		NativeFieldInfoPtr__fragmentationRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "<fragmentationRate>k__BackingField");
		NativeFieldInfoPtr_m_CenterRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_CenterRS");
		NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665272);
		NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665273);
		NativeMethodInfoPtr_GetDebugFragmentationBuffer_Internal_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665274);
		NativeMethodInfoPtr_get_fragmentationRate_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665275);
		NativeMethodInfoPtr_set_fragmentationRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665276);
		NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665277);
		NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665278);
		NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665279);
		NativeMethodInfoPtr_UploadIndexData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665280);
		NativeMethodInfoPtr_UpdateDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665281);
		NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665282);
		NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665283);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665284);
		NativeMethodInfoPtr_ComputeFragmentationRate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665285);
		NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665286);
		NativeMethodInfoPtr_GetNumberOfChunks_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665287);
		NativeMethodInfoPtr_FindSlotsForEntries_Internal_Boolean_byref_Il2CppStructArray_1_IndirectionEntryUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665288);
		NativeMethodInfoPtr_ReserveChunks_Internal_Boolean_Il2CppStructArray_1_IndirectionEntryUpdateInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665289);
		NativeMethodInfoPtr_BrickOverlapEntry_Internal_Static_Boolean_Vector3Int_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665290);
		NativeMethodInfoPtr_LocationToIndex_Private_Static_Int32_Int32_Int32_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665291);
		NativeMethodInfoPtr_MarkBrickInPhysicalBuffer_Private_Void_byref_IndirectionEntryUpdateInfo_Vector3Int_Vector3Int_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665292);
		NativeMethodInfoPtr_AddBricks_Public_Void_CellIndexInfo_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665293);
		NativeMethodInfoPtr_RemoveBricks_Public_Void_CellIndexInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100665294);
	}

	[CallerCount(0)]
	public unsafe ComputeBuffer GetDebugFragmentationBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebugFragmentationBuffer_Internal_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&memoryBudget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037669, RefRangeEnd = 1037671, XrefRangeStart = 1037640, XrefRangeEnd = 1037669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&memoryBudget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetRemainingChunkCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037671, XrefRangeEnd = 1037674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UploadIndexData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UploadIndexData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037693, RefRangeEnd = 1037695, XrefRangeStart = 1037674, XrefRangeEnd = 1037693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDebugData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037700, RefRangeEnd = 1037702, XrefRangeStart = 1037695, XrefRangeEnd = 1037700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037717, RefRangeEnd = 1037719, XrefRangeStart = 1037702, XrefRangeEnd = 1037717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037729, RefRangeEnd = 1037731, XrefRangeStart = 1037719, XrefRangeEnd = 1037729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037732, RefRangeEnd = 1037733, XrefRangeStart = 1037731, XrefRangeEnd = 1037732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeFragmentationRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFragmentationRate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int MergeIndex(int index, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037737, RefRangeEnd = 1037738, XrefRangeStart = 1037733, XrefRangeEnd = 1037737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNumberOfChunks(int brickCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&brickCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumberOfChunks_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037758, RefRangeEnd = 1037760, XrefRangeStart = 1037738, XrefRangeEnd = 1037758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindSlotsForEntries(ref Il2CppStructArray<IndirectionEntryUpdateInfo> entriesInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entriesInfo);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSlotsForEntries_Internal_Boolean_byref_Il2CppStructArray_1_IndirectionEntryUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		entriesInfo = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<IndirectionEntryUpdateInfo>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037763, RefRangeEnd = 1037764, XrefRangeStart = 1037760, XrefRangeEnd = 1037763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReserveChunks(Il2CppStructArray<IndirectionEntryUpdateInfo> entriesInfo, bool ignoreErrorLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entriesInfo);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreErrorLog;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReserveChunks_Internal_Boolean_Il2CppStructArray_1_IndirectionEntryUpdateInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037764, RefRangeEnd = 1037765, XrefRangeStart = 1037764, XrefRangeEnd = 1037764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BrickOverlapEntry(Vector3Int brickMin, Vector3Int brickMax, Vector3Int entryMin, Vector3Int entryMax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&brickMin);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &brickMax;
		*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &entryMin;
		*(Vector3Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &entryMax;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BrickOverlapEntry_Internal_Static_Boolean_Vector3Int_Vector3Int_Vector3Int_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int LocationToIndex(int x, int y, int z, Vector3Int sizeOfValid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(Vector3Int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeOfValid;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocationToIndex_Private_Static_Int32_Int32_Int32_Int32_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037780, RefRangeEnd = 1037781, XrefRangeStart = 1037765, XrefRangeEnd = 1037780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkBrickInPhysicalBuffer([In] ref IndirectionEntryUpdateInfo entry, Vector3Int brickMin, Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref entry);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &brickMin;
		*(Vector3Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &brickMax;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &brickSubdivLevel;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &entrySubdivLevel;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkBrickInPhysicalBuffer_Private_Void_byref_IndirectionEntryUpdateInfo_Vector3Int_Vector3Int_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1037801, RefRangeEnd = 1037803, XrefRangeStart = 1037781, XrefRangeEnd = 1037801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBricks(ProbeReferenceVolume.CellIndexInfo cellInfo, NativeArray<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bricks));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allocations);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocationSize;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBricks_Public_Void_CellIndexInfo_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1037805, RefRangeEnd = 1037811, XrefRangeStart = 1037803, XrefRangeEnd = 1037805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBricks(ProbeReferenceVolume.CellIndexInfo cellInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBricks_Public_Void_CellIndexInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeBrickIndex(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
