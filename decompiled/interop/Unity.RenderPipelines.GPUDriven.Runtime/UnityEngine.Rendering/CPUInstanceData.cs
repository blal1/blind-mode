using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class CPUInstanceData : Il2CppSystem.ValueType
{
	public sealed class ReadOnly : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstances;

		private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldIsFlippedBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldAABBs;

		private static readonly System.IntPtr NativeFieldInfoPtr_tetrahedronCacheIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_movedInCurrentFrameBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_movedInPreviousFrameBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_visibleInPreviousFrameBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_editorData;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_handlesLength_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CPUInstanceData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0;

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

		public unsafe NativeArray<InstanceHandle>.ReadOnly instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<SharedInstanceHandle>.ReadOnly sharedInstances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstances);
				return new NativeArray<SharedInstanceHandle>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ParallelBitArray localToWorldIsFlippedBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldIsFlippedBits);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldIsFlippedBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<AABB>.ReadOnly worldAABBs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldAABBs);
				return new NativeArray<AABB>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<AABB>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldAABBs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<AABB>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly tetrahedronCacheIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tetrahedronCacheIndices);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tetrahedronCacheIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ParallelBitArray movedInCurrentFrameBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInCurrentFrameBits);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInCurrentFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ParallelBitArray movedInPreviousFrameBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInPreviousFrameBits);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInPreviousFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ParallelBitArray visibleInPreviousFrameBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInPreviousFrameBits);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInPreviousFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe EditorInstanceDataArrays.ReadOnly editorData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData);
				return *(EditorInstanceDataArrays.ReadOnly*)num;
			}
			set
			{
				*(EditorInstanceDataArrays.ReadOnly*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData)) = value;
			}
		}

		public unsafe int handlesLength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1071998, RefRangeEnd = 1072001, XrefRangeStart = 1071997, XrefRangeEnd = 1071998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_handlesLength_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int instancesLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1072002, RefRangeEnd = 1072003, XrefRangeStart = 1072001, XrefRangeEnd = 1072002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ReadOnly()
		{
			Il2CppClassPointerStore<ReadOnly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "ReadOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr);
			NativeFieldInfoPtr_instanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "instanceIndices");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_sharedInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "sharedInstances");
			NativeFieldInfoPtr_localToWorldIsFlippedBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "localToWorldIsFlippedBits");
			NativeFieldInfoPtr_worldAABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "worldAABBs");
			NativeFieldInfoPtr_tetrahedronCacheIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "tetrahedronCacheIndices");
			NativeFieldInfoPtr_movedInCurrentFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "movedInCurrentFrameBits");
			NativeFieldInfoPtr_movedInPreviousFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "movedInPreviousFrameBits");
			NativeFieldInfoPtr_visibleInPreviousFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "visibleInPreviousFrameBits");
			NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "editorData");
			NativeMethodInfoPtr_get_handlesLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663772);
			NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663773);
			NativeMethodInfoPtr__ctor_Public_Void_byref_CPUInstanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663774);
			NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663775);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072036, RefRangeEnd = 1072038, XrefRangeStart = 1072003, XrefRangeEnd = 1072036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnly([In] ref CPUInstanceData instanceData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_CPUInstanceData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1072044, RefRangeEnd = 1072048, XrefRangeStart = 1072038, XrefRangeEnd = 1072044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InstanceToIndex(InstanceHandle instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&instance);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldIsFlippedBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldAABBs;

	private static readonly System.IntPtr NativeFieldInfoPtr_tetrahedronCacheIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_movedInCurrentFrameBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_movedInPreviousFrameBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInPreviousFrameBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instancesLength_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instancesCapacity_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instancesCapacity_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Grow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUnsafe_Private_Void_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexToInstance_Public_InstanceHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeInstancesCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNoGrow_Public_Void_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_InstanceHandle_SharedInstanceHandle_Boolean_byref_AABB_Int32_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_SharedInstance_Public_SharedInstanceHandle_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_TetrahedronCacheIndex_Public_Void_InstanceHandle_Int32_0;

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

	public unsafe NativeArray<InstanceHandle> instances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
			return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SharedInstanceHandle> sharedInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstances);
			return new NativeArray<SharedInstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SharedInstanceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParallelBitArray localToWorldIsFlippedBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldIsFlippedBits);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldIsFlippedBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<AABB> worldAABBs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldAABBs);
			return new NativeArray<AABB>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<AABB>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldAABBs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<AABB>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> tetrahedronCacheIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tetrahedronCacheIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tetrahedronCacheIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParallelBitArray movedInCurrentFrameBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInCurrentFrameBits);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInCurrentFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParallelBitArray movedInPreviousFrameBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInPreviousFrameBits);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movedInPreviousFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParallelBitArray visibleInPreviousFrameBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInPreviousFrameBits);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInPreviousFrameBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe EditorInstanceDataArrays editorData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData);
			return *(EditorInstanceDataArrays*)num;
		}
		set
		{
			*(EditorInstanceDataArrays*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorData)) = value;
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

	static CPUInstanceData()
	{
		Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CPUInstanceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr);
		NativeFieldInfoPtr_m_StructData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "m_StructData");
		NativeFieldInfoPtr_m_InstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "m_InstanceIndices");
		NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "instances");
		NativeFieldInfoPtr_sharedInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "sharedInstances");
		NativeFieldInfoPtr_localToWorldIsFlippedBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "localToWorldIsFlippedBits");
		NativeFieldInfoPtr_worldAABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "worldAABBs");
		NativeFieldInfoPtr_tetrahedronCacheIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "tetrahedronCacheIndices");
		NativeFieldInfoPtr_movedInCurrentFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "movedInCurrentFrameBits");
		NativeFieldInfoPtr_movedInPreviousFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "movedInPreviousFrameBits");
		NativeFieldInfoPtr_visibleInPreviousFrameBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "visibleInPreviousFrameBits");
		NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, "editorData");
		NativeMethodInfoPtr_get_instancesLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_set_instancesLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_get_instancesCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_set_instancesCapacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_Grow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr_AddUnsafe_Private_Void_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663760);
		NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663761);
		NativeMethodInfoPtr_IndexToInstance_Public_InstanceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663762);
		NativeMethodInfoPtr_GetFreeInstancesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663763);
		NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663764);
		NativeMethodInfoPtr_AddNoGrow_Public_Void_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663765);
		NativeMethodInfoPtr_Remove_Public_Void_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663766);
		NativeMethodInfoPtr_Set_Public_Void_InstanceHandle_SharedInstanceHandle_Boolean_byref_AABB_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr_SetDefault_Public_Void_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr_Get_SharedInstance_Public_SharedInstanceHandle_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr_Set_TetrahedronCacheIndex_Public_Void_InstanceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, 100663771);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072087, RefRangeEnd = 1072088, XrefRangeStart = 1072048, XrefRangeEnd = 1072087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1072109, RefRangeEnd = 1072110, XrefRangeStart = 1072088, XrefRangeEnd = 1072109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072143, RefRangeEnd = 1072145, XrefRangeStart = 1072110, XrefRangeEnd = 1072143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1072168, RefRangeEnd = 1072169, XrefRangeStart = 1072145, XrefRangeEnd = 1072168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUnsafe(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUnsafe_Private_Void_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1072175, RefRangeEnd = 1072190, XrefRangeStart = 1072169, XrefRangeEnd = 1072175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InstanceToIndex(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceToIndex_Public_Int32_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072190, RefRangeEnd = 1072191, XrefRangeStart = 1072190, XrefRangeEnd = 1072190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceHandle IndexToInstance(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexToInstance_Public_InstanceHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InstanceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072191, XrefRangeEnd = 1072192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureFreeInstances(int instancesCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instancesCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureFreeInstances_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072194, RefRangeEnd = 1072196, XrefRangeStart = 1072192, XrefRangeEnd = 1072194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNoGrow(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNoGrow_Public_Void_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072213, RefRangeEnd = 1072216, XrefRangeStart = 1072196, XrefRangeEnd = 1072213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072216, XrefRangeEnd = 1072221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(InstanceHandle instance, SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, [In] ref AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&instance);
		*(SharedInstanceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharedInstance;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldIsFlipped;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldAABB);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tetrahedronCacheIndex;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &movedInCurrentFrame;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &movedInPreviousFrame;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &visibleInPreviousFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_InstanceHandle_SharedInstanceHandle_Boolean_byref_AABB_Int32_Boolean_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072230, RefRangeEnd = 1072231, XrefRangeStart = 1072221, XrefRangeEnd = 1072230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefault(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefault_Public_Void_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1072232, RefRangeEnd = 1072235, XrefRangeStart = 1072231, XrefRangeEnd = 1072232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SharedInstanceHandle Get_SharedInstance(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_SharedInstance_Public_SharedInstanceHandle_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SharedInstanceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072235, XrefRangeEnd = 1072236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set_TetrahedronCacheIndex(InstanceHandle instance, int tetrahedronCacheIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instance);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tetrahedronCacheIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_TetrahedronCacheIndex_Public_Void_InstanceHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072236, XrefRangeEnd = 1072238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnly AsReadOnly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReadOnly(pointer);
	}

	public CPUInstanceData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CPUInstanceData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr))
	{
	}
}
