using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ProbeGlobalIndirection : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct IndexMetaData
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s_PackedValues;

		private static readonly System.IntPtr NativeFieldInfoPtr_minLocalIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxLocalIdxPlusOne;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstChunkIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSubdiv;

		private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0;

		[FieldOffset(0)]
		public Vector3Int minLocalIdx;

		[FieldOffset(12)]
		public Vector3Int maxLocalIdxPlusOne;

		[FieldOffset(24)]
		public int firstChunkIndex;

		[FieldOffset(28)]
		public int minSubdiv;

		public unsafe static Il2CppStructArray<uint> s_PackedValues
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PackedValues, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PackedValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static IndexMetaData()
		{
			Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "IndexMetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr);
			NativeFieldInfoPtr_s_PackedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, "s_PackedValues");
			NativeFieldInfoPtr_minLocalIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, "minLocalIdx");
			NativeFieldInfoPtr_maxLocalIdxPlusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, "maxLocalIdxPlusOne");
			NativeFieldInfoPtr_firstChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, "firstChunkIndex");
			NativeFieldInfoPtr_minSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, "minSubdiv");
			NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, 100665369);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038596, XrefRangeEnd = 1038601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pack(out Il2CppStructArray<uint> vals)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			nint num = 0;
			*ptr = (nint)(&num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num2 = num;
			vals = ((num2 == 0) ? null : new Il2CppStructArray<uint>((System.IntPtr)num2));
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndexMetaData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kUintPerEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_kEntryMaxSubdivLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexOfIndicesBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexOfIndicesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CellSizeInMinBricks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EntriesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EntryMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EntryMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedUpdateComputeBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinMaxEntry_Internal_Void_byref_Vector3Int_byref_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalIndirectionDimension_Internal_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalIndirectionMinEntry_Internal_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entrySizeInBricks_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entriesPerCellDimension_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFlatIdxForEntry_Internal_Int32_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFlatIndicesForCell_Internal_Il2CppStructArray_1_Int32_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCell_Internal_Void_CellIndexInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkEntriesAsUnloaded_Internal_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushComputeData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	public unsafe static int kUintPerEntry
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kUintPerEntry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kUintPerEntry, (void*)(&value));
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

	public unsafe static int kEntryMaxSubdivLevel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kEntryMaxSubdivLevel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kEntryMaxSubdivLevel, (void*)(&value));
		}
	}

	public unsafe ComputeBuffer m_IndexOfIndicesBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexOfIndicesBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexOfIndicesBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<uint> m_IndexOfIndicesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexOfIndicesData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexOfIndicesData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CellSizeInMinBricks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellSizeInMinBricks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellSizeInMinBricks)) = value;
		}
	}

	public unsafe Vector3Int m_EntriesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntriesCount);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntriesCount)) = value;
		}
	}

	public unsafe Vector3Int m_EntryMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntryMin);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntryMin)) = value;
		}
	}

	public unsafe Vector3Int m_EntryMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntryMax);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntryMax)) = value;
		}
	}

	public unsafe bool m_NeedUpdateComputeBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedUpdateComputeBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedUpdateComputeBuffer)) = value;
		}
	}

	public unsafe int estimatedVMemCost
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe int entrySizeInBricks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038602, XrefRangeEnd = 1038603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entrySizeInBricks_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int entriesPerCellDimension
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038604, RefRangeEnd = 1038605, XrefRangeStart = 1038603, XrefRangeEnd = 1038604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entriesPerCellDimension_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProbeGlobalIndirection()
	{
		Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeGlobalIndirection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr);
		NativeFieldInfoPtr_kUintPerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "kUintPerEntry");
		NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
		NativeFieldInfoPtr_kEntryMaxSubdivLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "kEntryMaxSubdivLevel");
		NativeFieldInfoPtr_m_IndexOfIndicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_IndexOfIndicesBuffer");
		NativeFieldInfoPtr_m_IndexOfIndicesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_IndexOfIndicesData");
		NativeFieldInfoPtr_m_CellSizeInMinBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_CellSizeInMinBricks");
		NativeFieldInfoPtr_m_EntriesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_EntriesCount");
		NativeFieldInfoPtr_m_EntryMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_EntryMin");
		NativeFieldInfoPtr_m_EntryMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_EntryMax");
		NativeFieldInfoPtr_m_NeedUpdateComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, "m_NeedUpdateComputeBuffer");
		NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665353);
		NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665354);
		NativeMethodInfoPtr_GetMinMaxEntry_Internal_Void_byref_Vector3Int_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665355);
		NativeMethodInfoPtr_GetGlobalIndirectionDimension_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665356);
		NativeMethodInfoPtr_GetGlobalIndirectionMinEntry_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665357);
		NativeMethodInfoPtr_get_entrySizeInBricks_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665358);
		NativeMethodInfoPtr_get_entriesPerCellDimension_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665359);
		NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665360);
		NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665361);
		NativeMethodInfoPtr_GetFlatIdxForEntry_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665362);
		NativeMethodInfoPtr_GetFlatIndicesForCell_Internal_Il2CppStructArray_1_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665363);
		NativeMethodInfoPtr_UpdateCell_Internal_Void_CellIndexInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665364);
		NativeMethodInfoPtr_MarkEntriesAsUnloaded_Internal_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665365);
		NativeMethodInfoPtr_PushComputeData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665366);
		NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665367);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr, 100665368);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038601, RefRangeEnd = 1038602, XrefRangeStart = 1038601, XrefRangeEnd = 1038601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMinMaxEntry(out Vector3Int minEntry, out Vector3Int maxEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref minEntry);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxEntry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinMaxEntry_Internal_Void_byref_Vector3Int_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3Int GetGlobalIndirectionDimension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalIndirectionDimension_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3Int GetGlobalIndirectionMinEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalIndirectionMinEntry_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetFlatIndex(Vector3Int normalizedPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalizedPos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038624, RefRangeEnd = 1038626, XrefRangeStart = 1038605, XrefRangeEnd = 1038624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeGlobalIndirection(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeGlobalIndirection>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cellMin);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellMax;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellSizeInMinBricks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetFlatIdxForEntry(Vector3Int entryPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&entryPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFlatIdxForEntry_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038626, XrefRangeEnd = 1038635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetFlatIndicesForCell(Vector3Int cellPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFlatIndicesForCell_Internal_Il2CppStructArray_1_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038654, RefRangeEnd = 1038656, XrefRangeStart = 1038635, XrefRangeEnd = 1038654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCell(ProbeReferenceVolume.CellIndexInfo cellInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCell_Internal_Void_CellIndexInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038657, RefRangeEnd = 1038659, XrefRangeStart = 1038656, XrefRangeEnd = 1038657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkEntriesAsUnloaded(Il2CppStructArray<int> entriesFlatIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entriesFlatIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkEntriesAsUnloaded_Internal_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038659, XrefRangeEnd = 1038660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushComputeData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushComputeData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038663, RefRangeEnd = 1038665, XrefRangeStart = 1038660, XrefRangeEnd = 1038663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1038670, RefRangeEnd = 1038682, XrefRangeStart = 1038665, XrefRangeEnd = 1038670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeGlobalIndirection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
