using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class LODGroupDataPool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODGroupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODGroupDataHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODGroupCullingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeLODGroupDataHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CrossfadedRendererCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportDitheringCrossFade;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodGroupDataHash_Public_get_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lodGroupCullingData_Public_get_NativeList_1_LODGroupCullingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_crossfadedRendererCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GPUResidentDrawerResources_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLODGroupTransformData_Public_Void_byref_GPUDrivenLODGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLODGroupData_Public_Void_byref_GPUDrivenLODGroupData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeLODGroupData_Public_Void_NativeArray_1_Int32_0;

	public unsafe NativeList<LODGroupData> m_LODGroupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupData);
			return new NativeList<LODGroupData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<LODGroupData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LODGroupData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, GPUInstanceIndex> m_LODGroupDataHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupDataHash);
			return new NativeParallelHashMap<int, GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupDataHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<LODGroupCullingData> m_LODGroupCullingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupCullingData);
			return new NativeList<LODGroupCullingData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<LODGroupCullingData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LODGroupCullingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LODGroupCullingData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<GPUInstanceIndex> m_FreeLODGroupDataHandles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeLODGroupDataHandles);
			return new NativeList<GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeLODGroupDataHandles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_CrossfadedRendererCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CrossfadedRendererCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CrossfadedRendererCount)) = value;
		}
	}

	public unsafe bool m_SupportDitheringCrossFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDitheringCrossFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDitheringCrossFade)) = value;
		}
	}

	public unsafe NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lodGroupDataHash_Public_get_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeParallelHashMap<int, GPUInstanceIndex>(pointer);
		}
	}

	public unsafe NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe int crossfadedRendererCount
	{
		[CallerCount(0)]
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

	static LODGroupDataPool()
	{
		Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "LODGroupDataPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr);
		NativeFieldInfoPtr_m_LODGroupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_LODGroupData");
		NativeFieldInfoPtr_m_LODGroupDataHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_LODGroupDataHash");
		NativeFieldInfoPtr_m_LODGroupCullingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_LODGroupCullingData");
		NativeFieldInfoPtr_m_FreeLODGroupDataHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_FreeLODGroupDataHandles");
		NativeFieldInfoPtr_m_CrossfadedRendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_CrossfadedRendererCount");
		NativeFieldInfoPtr_m_SupportDitheringCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, "m_SupportDitheringCrossFade");
		NativeMethodInfoPtr_get_lodGroupDataHash_Public_get_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_get_lodGroupCullingData_Public_get_NativeList_1_LODGroupCullingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_get_crossfadedRendererCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr__ctor_Public_Void_GPUResidentDrawerResources_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_UpdateLODGroupTransformData_Public_Void_byref_GPUDrivenLODGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_UpdateLODGroupData_Public_Void_byref_GPUDrivenLODGroupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_FreeLODGroupData_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr, 100663950);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074056, XrefRangeEnd = 1074073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LODGroupDataPool(GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODGroupDataPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialInstanceCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportDitheringCrossFade;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GPUResidentDrawerResources_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074073, XrefRangeEnd = 1074085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074085, XrefRangeEnd = 1074093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLODGroupTransformData([In] ref GPUDrivenLODGroupData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inputData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLODGroupTransformData_Public_Void_byref_GPUDrivenLODGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074116, RefRangeEnd = 1074117, XrefRangeStart = 1074093, XrefRangeEnd = 1074116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLODGroupData([In] ref GPUDrivenLODGroupData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inputData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLODGroupData_Public_Void_byref_GPUDrivenLODGroupData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074117, XrefRangeEnd = 1074118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeLODGroupData(NativeArray<int> destroyedLODGroupsID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedLODGroupsID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeLODGroupData_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LODGroupDataPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
