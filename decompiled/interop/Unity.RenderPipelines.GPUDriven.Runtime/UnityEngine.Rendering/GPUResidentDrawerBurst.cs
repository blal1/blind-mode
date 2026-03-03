using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class GPUResidentDrawerBurst : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+ClassifyMaterials_000000E6$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoObObObObObUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0;

		static MulticastDelegateNInternalSealedVoObObObObObUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "ClassifyMaterials_000000E6$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr, 100663504);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObObObObObUnique>.NativeClassPtr, 100663505);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068835, XrefRangeEnd = 1068839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		public unsafe virtual void Invoke([In] ref NativeArray<int> materialIDs, [In] ref NativeParallelHashMap<int, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<int> supportedMaterialIDs, ref NativeList<int> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoObObObObObUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+ClassifyMaterials_000000E6$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "ClassifyMaterials_000000E6$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr, 100663506);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr, 100663507);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0>.NativeClassPtr, 100663508);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068839, XrefRangeEnd = 1068859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068859, XrefRangeEnd = 1068879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068905, RefRangeEnd = 1068908, XrefRangeStart = 1068879, XrefRangeEnd = 1068905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke([In] ref NativeArray<int> materialIDs, [In] ref NativeParallelHashMap<int, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<int> supportedMaterialIDs, ref NativeList<int> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+FindUnsupportedRenderers_000000E7$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0;

		static MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "FindUnsupportedRenderers_000000E7$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique>.NativeClassPtr, 100663509);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique>.NativeClassPtr, 100663510);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068908, XrefRangeEnd = 1068912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke([In] ref NativeArray<int> unsupportedMaterials, [In] ref NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays, [In] ref NativeArray<int>.ReadOnly rendererGroups, ref NativeList<int> unsupportedRenderers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDArrays);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroups);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRenderers);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoObA_ObVoInA_unObInUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+FindUnsupportedRenderers_000000E7$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "FindUnsupportedRenderers_000000E7$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr, 100663511);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr, 100663512);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique>.NativeClassPtr, 100663513);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068912, XrefRangeEnd = 1068932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068932, XrefRangeEnd = 1068952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068992, RefRangeEnd = 1068995, XrefRangeStart = 1068952, XrefRangeEnd = 1068992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke([In] ref NativeArray<int> unsupportedMaterials, [In] ref NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays, [In] ref NativeArray<int>.ReadOnly rendererGroups, ref NativeList<int> unsupportedRenderers)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDArrays);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroups);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRenderers);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObunGeInVoUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+GetMaterialsWithChangedPackedMaterial_000000E8$PostfixBurstDelegate")]
	public sealed class MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0;

		static MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique()
		{
			Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "GetMaterialsWithChangedPackedMaterial_000000E8$PostfixBurstDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique>.NativeClassPtr, 100663514);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique>.NativeClassPtr, 100663515);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique(Il2CppSystem.Object A_1, System.IntPtr A_2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)A_1);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &A_2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke([In] ref NativeArray<int> materialIDs, [In] ref NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<int> filteredMaterials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)filteredMaterials);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MulticastDelegateNInternalSealedVoObA_ObVoInA_maObInUnique(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.GPUResidentDrawerBurst+GetMaterialsWithChangedPackedMaterial_000000E8$BurstDirectCall")]
	public static class ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0;

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

		static ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1()
		{
			Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, "GetMaterialsWithChangedPackedMaterial_000000E8$BurstDirectCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr);
			NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr, "Pointer");
			NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr, 100663516);
			NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr, 100663517);
			NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1>.NativeClassPtr, 100663518);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068995, XrefRangeEnd = 1069015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFunctionPointerDiscard(ref System.IntPtr A_0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref A_0);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069015, XrefRangeEnd = 1069035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr GetFunctionPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1069067, RefRangeEnd = 1069070, XrefRangeStart = 1069035, XrefRangeEnd = 1069067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke([In] ref NativeArray<int> materialIDs, [In] ref NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<int> filteredMaterials)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialHash);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)filteredMaterials);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObjectNInternalAbstractSealedInPoGeVoA_ObmaGeInVo1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUnsupportedRenderers_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_PDM_0;

	static GPUResidentDrawerBurst()
	{
		Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUResidentDrawerBurst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr);
		NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_FindUnsupportedRenderers_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawerBurst>.NativeClassPtr, 100663503);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069070, XrefRangeEnd = 1069071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClassifyMaterials([In] ref NativeArray<int> materialIDs, [In] ref NativeParallelHashMap<int, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<int> supportedMaterialIDs, ref NativeList<int> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyMaterials_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069071, XrefRangeEnd = 1069072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindUnsupportedRenderers([In] ref NativeArray<int> unsupportedMaterials, [In] ref NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays, [In] ref NativeArray<int>.ReadOnly rendererGroups, ref NativeList<int> unsupportedRenderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDArrays);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRenderers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUnsupportedRenderers_Public_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069072, XrefRangeEnd = 1069073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMaterialsWithChangedPackedMaterial([In] ref NativeArray<int> materialIDs, [In] ref NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<int> filteredMaterials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)filteredMaterials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Public_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069073, XrefRangeEnd = 1069142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_PDM_0([In] ref NativeArray<int> materialIDs, [In] ref NativeParallelHashMap<int, BatchMaterialID>.ReadOnly batchMaterialHash, ref NativeList<int> supportedMaterialIDs, ref NativeList<int> unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)batchMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedMaterialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)supportedPackedMaterialDatas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_Int32_BatchMaterialID_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069142, XrefRangeEnd = 1069157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_PDM_0([In] ref NativeArray<int> unsupportedMaterials, [In] ref NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays, [In] ref NativeArray<int>.ReadOnly rendererGroups, ref NativeList<int> unsupportedRenderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDArrays);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRenderers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_ReadOnly_SmallIntegerArray_byref_ReadOnly_Int32_byref_NativeList_1_Int32_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069157, XrefRangeEnd = 1069164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_PDM_0([In] ref NativeArray<int> materialIDs, [In] ref NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, [In] ref NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ReadOnly packedMaterialHash, ref NativeHashSet<int> filteredMaterials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materialIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialHash);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)filteredMaterials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_NativeArray_1_Int32_byref_NativeArray_1_GPUDrivenPackedMaterialData_byref_ReadOnly_Int32_GPUDrivenPackedMaterialData_byref_NativeHashSet_1_Int32_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUResidentDrawerBurst(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
