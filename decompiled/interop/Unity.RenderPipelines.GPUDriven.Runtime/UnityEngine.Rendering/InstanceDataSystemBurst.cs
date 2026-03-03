using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class InstanceDataSystemBurst : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Rendering.InstanceDataSystemBurst+ReallocateInstances_0000027F$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

		static MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, "ReallocateInstances_0000027F$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr, 100663868);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique>.NativeClassPtr, 100663869);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073292, XrefRangeEnd = 1073295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		public unsafe virtual void Invoke(bool implicitInstanceIndices, [In] ref NativeArray<int> rendererGroupIDs, [In] ref NativeArray<GPUDrivenPackedRendererData> packedRendererData, [In] ref NativeArray<int> instanceOffsets, [In] ref NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[10];
			*ptr = (nint)(&implicitInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedRendererData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceOffsets);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceCounts);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoBoObObObObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceDataSystemBurst+ReallocateInstances_0000027F$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

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
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, "ReallocateInstances_0000027F$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663870);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663871);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique>.NativeClassPtr, 100663872);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073295, XrefRangeEnd = 1073314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073314, XrefRangeEnd = 1073333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073358, RefRangeEnd = 1073359, XrefRangeStart = 1073333, XrefRangeEnd = 1073358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke(bool implicitInstanceIndices, [In] ref NativeArray<int> rendererGroupIDs, [In] ref NativeArray<GPUDrivenPackedRendererData> packedRendererData, [In] ref NativeArray<int> instanceOffsets, [In] ref NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[10];
			*ptr = (nint)(&implicitInstanceIndices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedRendererData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceOffsets);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceCounts);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObimGeInVoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceDataSystemBurst+FreeRendererGroupInstances_00000280$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

		static MulticastDelegateNInternalSealedVoObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, "FreeRendererGroupInstances_00000280$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr, 100663873);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr, 100663874);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoObObObObObUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke([In] ref NativeArray<int>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceDataSystemBurst+FreeRendererGroupInstances_00000280$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, "FreeRendererGroupInstances_00000280$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr, 100663875);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr, 100663876);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique>.NativeClassPtr, 100663877);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073359, XrefRangeEnd = 1073379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073379, XrefRangeEnd = 1073399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073425, RefRangeEnd = 1073426, XrefRangeStart = 1073399, XrefRangeEnd = 1073425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke([In] ref NativeArray<int>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObreGeInVoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.InstanceDataSystemBurst+FreeInstances_00000281$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

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

		static ObjectNInternalAbstractSealedInPoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, "FreeInstances_00000281$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
		}

		public ObjectNInternalAbstractSealedInPoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ReallocateInstances_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0;

	static InstanceDataSystemBurst()
	{
		Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceDataSystemBurst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr);
		NativeMethodInfoPtr_ReallocateInstances_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystemBurst>.NativeClassPtr, 100663867);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073427, RefRangeEnd = 1073428, XrefRangeStart = 1073426, XrefRangeEnd = 1073427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReallocateInstances(bool implicitInstanceIndices, [In] ref NativeArray<int> rendererGroupIDs, [In] ref NativeArray<GPUDrivenPackedRendererData> packedRendererData, [In] ref NativeArray<int> instanceOffsets, [In] ref NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&implicitInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedRendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceOffsets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceCounts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReallocateInstances_Public_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073429, RefRangeEnd = 1073430, XrefRangeStart = 1073428, XrefRangeEnd = 1073429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeRendererGroupInstances([In] ref NativeArray<int>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073430, XrefRangeEnd = 1073480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0(bool implicitInstanceIndices, [In] ref NativeArray<int> rendererGroupIDs, [In] ref NativeArray<GPUDrivenPackedRendererData> packedRendererData, [In] ref NativeArray<int> instanceOffsets, [In] ref NativeArray<int> instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle> instances, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&implicitInstanceIndices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedRendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceOffsets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceCounts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_Boolean_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedRendererData_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeArray_1_InstanceHandle_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073480, XrefRangeEnd = 1073512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0([In] ref NativeArray<int>.ReadOnly rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceAllocators);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sharedInstanceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupInstanceMultiHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_ReadOnly_Int32_byref_InstanceAllocators_byref_CPUInstanceData_byref_CPUSharedInstanceData_byref_NativeParallelMultiHashMap_2_Int32_InstanceHandle_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceDataSystemBurst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
