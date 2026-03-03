using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class CPUSharedInstanceData : Il2CppSystem.ValueType
{
	public sealed class ReadOnly : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialIDArrays;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_localAABBs;

		private static readonly System.IntPtr NativeFieldInfoPtr_flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupAndMasks;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayers;

		private static readonly System.IntPtr NativeFieldInfoPtr_refCounts;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CPUSharedInstanceData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_ReadOnly_InstanceHandle_0;

		public unsafe NativeArray<int>.ReadOnly instanceIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIndices);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<SharedInstanceHandle>.ReadOnly instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<SharedInstanceHandle>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly rendererGroupIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays);
				return new NativeArray<SmallIntegerArray>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly meshIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<AABB>.ReadOnly localAABBs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localAABBs);
				return new NativeArray<AABB>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<AABB>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localAABBs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<AABB>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<CPUSharedInstanceFlags>.ReadOnly flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
				return new NativeArray<CPUSharedInstanceFlags>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CPUSharedInstanceFlags>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CPUSharedInstanceFlags>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<uint>.ReadOnly lodGroupAndMasks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks);
				return new NativeArray<uint>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly gameObjectLayers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayers);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly refCounts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCounts);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ReadOnly()
		{
			Il2CppClassPointerStore<ReadOnly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "ReadOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr);
			NativeFieldInfoPtr_instanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "instanceIndices");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "rendererGroupIDs");
			NativeFieldInfoPtr_materialIDArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "materialIDArrays");
			NativeFieldInfoPtr_meshIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "meshIDs");
			NativeFieldInfoPtr_localAABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "localAABBs");
			NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "flags");
			NativeFieldInfoPtr_lodGroupAndMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "lodGroupAndMasks");
			NativeFieldInfoPtr_gameObjectLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "gameObjectLayers");
			NativeFieldInfoPtr_refCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "refCounts");
			NativeMethodInfoPtr__ctor_Public_Void_byref_CPUSharedInstanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663797);
			NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663798);
			NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_ReadOnly_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663799);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072291, RefRangeEnd = 1072293, XrefRangeStart = 1072238, XrefRangeEnd = 1072291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnly([In] ref CPUSharedInstanceData instanceData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_CPUSharedInstanceData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072299, RefRangeEnd = 1072300, XrefRangeStart = 1072293, XrefRangeEnd = 1072299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SharedInstanceToIndex(SharedInstanceHandle instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&instance);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072305, RefRangeEnd = 1072307, XrefRangeStart = 1072300, XrefRangeEnd = 1072305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InstanceToIndex([In] ref CPUInstanceData.ReadOnly instanceData, InstanceHandle instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			*(InstanceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instance;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_ReadOnly_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ReadOnly(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ReadOnly()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StructData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_instances;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialIDArrays;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_localAABBs;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupAndMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_refCounts;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instancesLength_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instancesCapacity_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instancesCapacity_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Grow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUnsafe_Private_Void_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_CPUInstanceData_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeInstancesCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNoGrow_Public_Void_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_RendererGroupID_Public_Int32_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_MeshID_Public_Int32_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_RefCount_Public_Int32_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_RefCount_Public_Void_SharedInstanceHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SharedInstanceHandle_Int32_byref_SmallIntegerArray_Int32_byref_AABB_TransformUpdateFlags_InstanceFlags_UInt32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0;

	public unsafe NativeArray<int> m_StructData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StructData);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StructData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_InstanceIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceIndices);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SharedInstanceHandle> instances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
			return new NativeArray<SharedInstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> rendererGroupIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SmallIntegerArray> materialIDArrays
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays);
			return new NativeArray<SmallIntegerArray>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> meshIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<AABB> localAABBs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localAABBs);
			return new NativeArray<AABB>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<AABB>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localAABBs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<AABB>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<CPUSharedInstanceFlags> flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
			return new NativeArray<CPUSharedInstanceFlags>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CPUSharedInstanceFlags>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CPUSharedInstanceFlags>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<uint> lodGroupAndMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> gameObjectLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayers);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObjectLayers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> refCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCounts);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int instancesLength
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instancesLength_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int instancesCapacity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instancesCapacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instancesCapacity_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static CPUSharedInstanceData()
	{
		Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CPUSharedInstanceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr);
		NativeFieldInfoPtr_m_StructData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "m_StructData");
		NativeFieldInfoPtr_m_InstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "m_InstanceIndices");
		NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "instances");
		NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "rendererGroupIDs");
		NativeFieldInfoPtr_materialIDArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "materialIDArrays");
		NativeFieldInfoPtr_meshIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "meshIDs");
		NativeFieldInfoPtr_localAABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "localAABBs");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_lodGroupAndMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "lodGroupAndMasks");
		NativeFieldInfoPtr_gameObjectLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "gameObjectLayers");
		NativeFieldInfoPtr_refCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, "refCounts");
		NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr_set_instancesLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr_get_instancesCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr_set_instancesCapacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_Grow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_AddUnsafe_Private_Void_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663783);
		NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_CPUInstanceData_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663785);
		NativeMethodInfoPtr_GetFreeInstancesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663786);
		NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr_AddNoGrow_Public_Void_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_Remove_Public_Void_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663789);
		NativeMethodInfoPtr_Get_RendererGroupID_Public_Int32_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663790);
		NativeMethodInfoPtr_Get_MeshID_Public_Int32_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663791);
		NativeMethodInfoPtr_Get_RefCount_Public_Int32_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663792);
		NativeMethodInfoPtr_Set_RefCount_Public_Void_SharedInstanceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663793);
		NativeMethodInfoPtr_Set_Public_Void_SharedInstanceHandle_Int32_byref_SmallIntegerArray_Int32_byref_AABB_TransformUpdateFlags_InstanceFlags_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663794);
		NativeMethodInfoPtr_SetDefault_Public_Void_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663795);
		NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, 100663796);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072347, RefRangeEnd = 1072348, XrefRangeStart = 1072307, XrefRangeEnd = 1072347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(int initCapacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initCapacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072394, RefRangeEnd = 1072395, XrefRangeStart = 1072348, XrefRangeEnd = 1072394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072432, RefRangeEnd = 1072434, XrefRangeStart = 1072395, XrefRangeEnd = 1072432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Grow(int newCapacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newCapacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Grow_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072457, RefRangeEnd = 1072458, XrefRangeStart = 1072434, XrefRangeEnd = 1072457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUnsafe(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUnsafe_Private_Void_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1072464, RefRangeEnd = 1072477, XrefRangeStart = 1072458, XrefRangeEnd = 1072464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SharedInstanceToIndex(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SharedInstanceToIndex_Public_Int32_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072484, RefRangeEnd = 1072487, XrefRangeStart = 1072477, XrefRangeEnd = 1072484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InstanceToIndex([In] ref CPUInstanceData instanceData, InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(InstanceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceToIndex_Public_Int32_byref_CPUInstanceData_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetFreeInstancesCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreeInstancesCount_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072487, XrefRangeEnd = 1072488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureFreeInstances(int instancesCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancesCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072490, RefRangeEnd = 1072491, XrefRangeStart = 1072488, XrefRangeEnd = 1072490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNoGrow(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNoGrow_Public_Void_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072503, RefRangeEnd = 1072506, XrefRangeStart = 1072491, XrefRangeEnd = 1072503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072506, XrefRangeEnd = 1072507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Get_RendererGroupID(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_RendererGroupID_Public_Int32_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072507, XrefRangeEnd = 1072508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Get_MeshID(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_MeshID_Public_Int32_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072509, RefRangeEnd = 1072510, XrefRangeStart = 1072508, XrefRangeEnd = 1072509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Get_RefCount(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_RefCount_Public_Int32_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072511, RefRangeEnd = 1072512, XrefRangeStart = 1072510, XrefRangeEnd = 1072511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set_RefCount(SharedInstanceHandle instance, int refCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &refCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_RefCount_Public_Void_SharedInstanceHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072516, RefRangeEnd = 1072519, XrefRangeStart = 1072512, XrefRangeEnd = 1072516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(SharedInstanceHandle instance, int rendererGroupID, [In] ref SmallIntegerArray materialIDs, int meshID, [In] ref AABB localAABB, TransformUpdateFlags transformUpdateFlags, InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&instance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rendererGroupID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshID;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref localAABB);
		*(TransformUpdateFlags**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &transformUpdateFlags;
		*(InstanceFlags**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceFlags;
		*(uint**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &lodGroupAndMask;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &gameObjectLayer;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &refCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_SharedInstanceHandle_Int32_byref_SmallIntegerArray_Int32_byref_AABB_TransformUpdateFlags_InstanceFlags_UInt32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072519, XrefRangeEnd = 1072520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefault(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefault_Public_Void_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072520, XrefRangeEnd = 1072522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnly AsReadOnly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReadOnly(pointer);
	}

	public CPUSharedInstanceData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CPUSharedInstanceData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr))
	{
	}
}
