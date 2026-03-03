using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class InstanceCullingBatcherBurst : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Rendering.InstanceCullingBatcherBurst+RemoveDrawInstanceIndices_00000180$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoObObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0;

		static MulticastDelegateNInternalSealedVoObObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, "RemoveDrawInstanceIndices_00000180$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObObUnique>.NativeClassPtr, 100663665);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObObUnique>.NativeClassPtr, 100663666);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071035, XrefRangeEnd = 1071039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoObObObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke([In] ref NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoObObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceCullingBatcherBurst+RemoveDrawInstanceIndices_00000180$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, "RemoveDrawInstanceIndices_00000180$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr, 100663667);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr, 100663668);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique>.NativeClassPtr, 100663669);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071039, XrefRangeEnd = 1071059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071059, XrefRangeEnd = 1071079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1071121, RefRangeEnd = 1071125, XrefRangeStart = 1071079, XrefRangeEnd = 1071121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke([In] ref NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObdrGeInVoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceCullingBatcherBurst+CreateDrawBatches_00000184$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0;

		static MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, "CreateDrawBatches_00000184$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr, 100663670);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr, 100663671);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071125, XrefRangeEnd = 1071128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(bool implicitInstanceIndices, [In] ref NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, [In] ref NativeParallelHashMap<int, BatchMeshID> batchMeshHash, [In] ref NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = (nint)(&implicitInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceCullingBatcherBurst+CreateDrawBatches_00000184$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, "CreateDrawBatches_00000184$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663672);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663673);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663674);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071128, XrefRangeEnd = 1071147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071147, XrefRangeEnd = 1071166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1071191, RefRangeEnd = 1071193, XrefRangeStart = 1071166, XrefRangeEnd = 1071191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke(bool implicitInstanceIndices, [In] ref NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, [In] ref NativeParallelHashMap<int, BatchMeshID> batchMeshHash, [In] ref NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = (nint)(&implicitInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDataHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawRange_Private_Static_Void_byref_RangeKey_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawBatch_Private_Static_Void_byref_DrawKey_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawInstanceIndices_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EditDrawRange_Private_Static_byref_DrawRange_byref_RangeKey_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EditDrawBatch_Private_Static_byref_DrawBatch_byref_DrawKey_byref_SubMeshDescriptor_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRenderer_Private_Static_Void_Int32_Boolean_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_BatchMeshID_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_NativeParallelHashMap_2_Int32_BatchMaterialID_NativeArray_1_InstanceHandle_NativeList_1_DrawInstance_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawBatches_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_PDM_0;

	static InstanceCullingBatcherBurst()
	{
		Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceCullingBatcherBurst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr);
		NativeMethodInfoPtr_RemoveDrawRange_Private_Static_Void_byref_RangeKey_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_RemoveDrawBatch_Private_Static_Void_byref_DrawKey_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_RemoveDrawInstanceIndices_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_EditDrawRange_Private_Static_byref_DrawRange_byref_RangeKey_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_EditDrawBatch_Private_Static_byref_DrawBatch_byref_DrawKey_byref_SubMeshDescriptor_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_ProcessRenderer_Private_Static_Void_Int32_Boolean_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_BatchMeshID_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_NativeParallelHashMap_2_Int32_BatchMaterialID_NativeArray_1_InstanceHandle_NativeList_1_DrawInstance_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_CreateDrawBatches_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceCullingBatcherBurst>.NativeClassPtr, 100663664);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071193, XrefRangeEnd = 1071211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDrawRange([In] ref RangeKey key, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawRange_Private_Static_Void_byref_RangeKey_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071253, RefRangeEnd = 1071255, XrefRangeStart = 1071211, XrefRangeEnd = 1071253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDrawBatch([In] ref DrawKey key, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawBatch_Private_Static_Void_byref_DrawKey_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071255, XrefRangeEnd = 1071256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveDrawInstanceIndices([In] ref NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawInstanceIndices_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071256, XrefRangeEnd = 1071271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref DrawRange EditDrawRange([In] ref RangeKey key, NativeParallelHashMap<RangeKey, int> rangeHash, NativeList<DrawRange> drawRanges)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EditDrawRange_Private_Static_byref_DrawRange_byref_RangeKey_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(DrawRange*)intPtr2;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071271, XrefRangeEnd = 1071286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref DrawBatch EditDrawBatch([In] ref DrawKey key, [In] ref SubMeshDescriptor subMeshDescriptor, NativeParallelHashMap<DrawKey, int> batchHash, NativeList<DrawBatch> drawBatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref subMeshDescriptor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EditDrawBatch_Private_Static_byref_DrawBatch_byref_DrawKey_byref_SubMeshDescriptor_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(DrawBatch*)intPtr2;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071298, RefRangeEnd = 1071300, XrefRangeStart = 1071286, XrefRangeEnd = 1071298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessRenderer(int i, bool implicitInstanceIndices, [In] ref GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<int, BatchMeshID> batchMeshHash, NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialDataHash, NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash, NativeArray<InstanceHandle> instances, NativeList<DrawInstance> drawInstances, NativeParallelHashMap<RangeKey, int> rangeHash, NativeList<DrawRange> drawRanges, NativeParallelHashMap<DrawKey, int> batchHash, NativeList<DrawBatch> drawBatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&i);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &implicitInstanceIndices;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDataHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRenderer_Private_Static_Void_Int32_Boolean_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_BatchMeshID_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_NativeParallelHashMap_2_Int32_BatchMaterialID_NativeArray_1_InstanceHandle_NativeList_1_DrawInstance_NativeParallelHashMap_2_RangeKey_Int32_NativeList_1_DrawRange_NativeParallelHashMap_2_DrawKey_Int32_NativeList_1_DrawBatch_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071300, XrefRangeEnd = 1071301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateDrawBatches(bool implicitInstanceIndices, [In] ref NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, [In] ref NativeParallelHashMap<int, BatchMeshID> batchMeshHash, [In] ref NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)(&implicitInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawBatches_Public_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071301, XrefRangeEnd = 1071319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_PDM_0([In] ref NativeArray<int> drawInstanceIndices, ref NativeList<DrawInstance> drawInstances, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawRange> drawRanges, ref NativeList<DrawBatch> drawBatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeList_1_DrawInstance_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawRange_byref_NativeList_1_DrawBatch_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071319, XrefRangeEnd = 1071320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_PDM_0(bool implicitInstanceIndices, [In] ref NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, [In] ref NativeParallelHashMap<int, BatchMeshID> batchMeshHash, [In] ref NativeParallelHashMap<int, BatchMaterialID> batchMaterialHash, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, int> rangeHash, ref NativeList<DrawRange> drawRanges, ref NativeParallelHashMap<DrawKey, int> batchHash, ref NativeList<DrawBatch> drawBatches, ref NativeList<DrawInstance> drawInstances)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)(&implicitInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMeshHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDataHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rangeHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawRanges);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawBatches);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)drawInstances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_byref_NativeParallelHashMap_2_Int32_BatchMeshID_byref_NativeParallelHashMap_2_Int32_BatchMaterialID_byref_NativeParallelHashMap_2_Int32_GPUDrivenPackedMaterialData_byref_NativeParallelHashMap_2_RangeKey_Int32_byref_NativeList_1_DrawRange_byref_NativeParallelHashMap_2_DrawKey_Int32_byref_NativeList_1_DrawBatch_byref_NativeList_1_DrawInstance_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceCullingBatcherBurst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
