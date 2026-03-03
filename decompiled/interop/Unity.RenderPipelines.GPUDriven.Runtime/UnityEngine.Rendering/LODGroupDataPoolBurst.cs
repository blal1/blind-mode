using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class LODGroupDataPoolBurst : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Rendering.LODGroupDataPoolBurst+FreeLODGroupData_000002D0$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedInObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0;

		static MulticastDelegateNInternalSealedInObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, "FreeLODGroupData_000002D0$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObUnique>.NativeClassPtr, 100663955);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObUnique>.NativeClassPtr, 100663956);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074118, XrefRangeEnd = 1074122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedInObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual int Invoke([In] ref NativeArray<int> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedLODGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public MulticastDelegateNInternalSealedInObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LODGroupDataPoolBurst+FreeLODGroupData_000002D0$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0;

		public unsafe static System.IntPtr Pointer
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pointer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pointer, (void*)(&value));
			}
		}

		static ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, "FreeLODGroupData_000002D0$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr, 100663957);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr, 100663958);
			NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique>.NativeClassPtr, 100663959);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074122, XrefRangeEnd = 1074142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074142, XrefRangeEnd = 1074162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1074188, RefRangeEnd = 1074192, XrefRangeStart = 1074162, XrefRangeEnd = 1074188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Invoke([In] ref NativeArray<int> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedLODGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObdeGeInloUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LODGroupDataPoolBurst+AllocateOrGetLODGroupDataInstances_000002D1$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedInObObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0;

		static MulticastDelegateNInternalSealedInObObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, "AllocateOrGetLODGroupDataInstances_000002D1$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObObObUnique>.NativeClassPtr, 100663960);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObObObUnique>.NativeClassPtr, 100663961);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074192, XrefRangeEnd = 1074196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedInObObObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedInObObObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual int Invoke([In] ref NativeArray<int> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupInstances);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public MulticastDelegateNInternalSealedInObObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LODGroupDataPoolBurst+AllocateOrGetLODGroupDataInstances_000002D1$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0;

		public unsafe static System.IntPtr Pointer
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pointer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pointer, (void*)(&value));
			}
		}

		static ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, "AllocateOrGetLODGroupDataInstances_000002D1$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr, 100663962);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr, 100663963);
			NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique>.NativeClassPtr, 100663964);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074196, XrefRangeEnd = 1074216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074216, XrefRangeEnd = 1074236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074262, RefRangeEnd = 1074264, XrefRangeStart = 1074236, XrefRangeEnd = 1074262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Invoke([In] ref NativeArray<int> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupInstances);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObloGeInfrUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeLODGroupData_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateOrGetLODGroupDataInstances_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_PDM_0;

	static LODGroupDataPoolBurst()
	{
		Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "LODGroupDataPoolBurst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr);
		NativeMethodInfoPtr_FreeLODGroupData_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_AllocateOrGetLODGroupDataInstances_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroupDataPoolBurst>.NativeClassPtr, 100663954);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074264, XrefRangeEnd = 1074265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FreeLODGroupData([In] ref NativeArray<int> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedLODGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeLODGroupData_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074265, XrefRangeEnd = 1074266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AllocateOrGetLODGroupDataInstances([In] ref NativeArray<int> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupInstances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateOrGetLODGroupDataInstances_Public_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074266, XrefRangeEnd = 1074295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_PDM_0([In] ref NativeArray<int> destroyedLODGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedLODGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074295, XrefRangeEnd = 1074329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_PDM_0([In] ref NativeArray<int> lodGroupsID, ref NativeList<LODGroupData> lodGroupsData, ref NativeList<LODGroupCullingData> lodGroupCullingData, ref NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash, ref NativeList<GPUInstanceIndex> freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex> lodGroupInstances)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupsData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupCullingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)freeLODGroupDataHandles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupInstances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Int32_byref_NativeArray_1_Int32_byref_NativeList_1_LODGroupData_byref_NativeList_1_LODGroupCullingData_byref_NativeParallelHashMap_2_Int32_GPUInstanceIndex_byref_NativeList_1_GPUInstanceIndex_byref_NativeArray_1_GPUInstanceIndex_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LODGroupDataPoolBurst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
