using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingResults
{
	private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CullingResults>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate int GetReflectionProbeIndexMapSizeDelegate(System.IntPtr cullingResultsPtr);

	private delegate void FillReflectionProbeIndexMapDelegate(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize);

	private delegate void SetReflectionProbeIndexMapDelegate(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize);

	private delegate void FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate(System.IntPtr cullingResultsPtr, System.IntPtr buffer);

	private static readonly System.IntPtr NativeFieldInfoPtr_ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocationInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

	[FieldOffset(0)]
	public System.IntPtr ptr;

	[FieldOffset(8)]
	public System.IntPtr m_AllocationInfo;

	private static readonly GetReflectionProbeIndexMapSizeDelegate GetReflectionProbeIndexMapSizeDelegateField;

	private static readonly FillReflectionProbeIndexMapDelegate FillReflectionProbeIndexMapDelegateField;

	private static readonly SetReflectionProbeIndexMapDelegate SetReflectionProbeIndexMapDelegateField;

	private static readonly FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField;

	public unsafe NativeArray<VisibleLight> visibleLights
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238136, RefRangeEnd = 1238139, XrefRangeStart = 1238133, XrefRangeEnd = 1238136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<VisibleLight>(pointer);
		}
	}

	public unsafe NativeArray<VisibleReflectionProbe> visibleReflectionProbes
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238142, RefRangeEnd = 1238144, XrefRangeStart = 1238139, XrefRangeEnd = 1238142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<VisibleReflectionProbe>(pointer);
		}
	}

	public unsafe int lightAndReflectionProbeIndexCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238164, RefRangeEnd = 1238165, XrefRangeStart = 1238160, XrefRangeEnd = 1238164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe NativeArray<VisibleLight> visibleOffscreenVertexLights => GetNativeArray<VisibleLight>((void*)((CullingAllocationInfo*)m_AllocationInfo)->visibleOffscreenVertexLightsPtr, ((CullingAllocationInfo*)m_AllocationInfo)->visibleOffscreenVertexLightCount);

	public int lightIndexCount => GetLightIndexCount(ptr);

	public int reflectionProbeIndexCount => GetReflectionProbeIndexCount(ptr);

	static CullingResults()
	{
		Il2CppClassPointerStore<CullingResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingResults");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingResults>.NativeClassPtr);
		NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "ptr");
		NativeFieldInfoPtr_m_AllocationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "m_AllocationInfo");
		NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668461);
		NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668462);
		NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668463);
		NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668464);
		NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668465);
		NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668466);
		NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668467);
		NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668468);
		NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668469);
		NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668470);
		NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668471);
		NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668472);
		NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668473);
		NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668474);
		NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668475);
		NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668476);
		NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668477);
		NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668478);
		NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668479);
		NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668480);
		NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668481);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668482);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668483);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668484);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668485);
		NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668486);
		NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668487);
		GetReflectionProbeIndexMapSizeDelegateField = IL2CPP.ResolveICall<GetReflectionProbeIndexMapSizeDelegate>("UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexMapSize");
		FillReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<FillReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::FillReflectionProbeIndexMap");
		SetReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<SetReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::SetReflectionProbeIndexMap");
		FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238112, XrefRangeEnd = 1238114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLightIndexCount(System.IntPtr cullingResultsPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cullingResultsPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238114, XrefRangeEnd = 1238116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetReflectionProbeIndexCount(System.IntPtr cullingResultsPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cullingResultsPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238116, XrefRangeEnd = 1238119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillLightAndReflectionProbeIndices(System.IntPtr cullingResultsPtr, ComputeBuffer computeBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullingResultsPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238119, XrefRangeEnd = 1238121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLightIndexMapSize(System.IntPtr cullingResultsPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cullingResultsPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238121, XrefRangeEnd = 1238123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillLightIndexMap(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cullingResultsPtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexMapPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexMapSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238123, XrefRangeEnd = 1238125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLightIndexMap(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cullingResultsPtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexMapPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexMapSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238125, XrefRangeEnd = 1238127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetShadowCasterBounds(System.IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cullingResultsPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238127, XrefRangeEnd = 1238129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ComputeSpotShadowMatricesAndCullingPrimitives(System.IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&cullingResultsPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeLightIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238129, XrefRangeEnd = 1238131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ComputePointShadowMatricesAndCullingPrimitives(System.IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&cullingResultsPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeLightIndex;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapFace;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fovBias;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238131, XrefRangeEnd = 1238133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(System.IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&cullingResultsPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeLightIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitCount;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitRatio;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlaneOffset;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1238146, RefRangeEnd = 1238160, XrefRangeStart = 1238144, XrefRangeEnd = 1238146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dataPointer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238168, RefRangeEnd = 1238169, XrefRangeStart = 1238165, XrefRangeEnd = 1238168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238180, RefRangeEnd = 1238181, XrefRangeStart = 1238169, XrefRangeEnd = 1238180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<int> GetLightIndexMap(Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allocator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238187, RefRangeEnd = 1238188, XrefRangeStart = 1238181, XrefRangeEnd = 1238187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLightIndexMap(NativeArray<int> lightIndexMap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lightIndexMap));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238190, RefRangeEnd = 1238192, XrefRangeStart = 1238188, XrefRangeEnd = 1238190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lightIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outBounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238194, RefRangeEnd = 1238195, XrefRangeStart = 1238192, XrefRangeEnd = 1238194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&activeLightIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238197, RefRangeEnd = 1238198, XrefRangeStart = 1238195, XrefRangeEnd = 1238197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&activeLightIndex);
		*(CubemapFace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubemapFace;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fovBias;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238200, RefRangeEnd = 1238201, XrefRangeStart = 1238198, XrefRangeEnd = 1238200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&activeLightIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitCount;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitRatio;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlaneOffset;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238201, XrefRangeEnd = 1238204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(CullingResults other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238204, XrefRangeEnd = 1238210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238210, XrefRangeEnd = 1238211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238211, XrefRangeEnd = 1238214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(CullingResults left, CullingResults right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(CullingResults**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238214, XrefRangeEnd = 1238216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillLightAndReflectionProbeIndices_Injected(System.IntPtr cullingResultsPtr, System.IntPtr computeBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullingResultsPtr);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238216, XrefRangeEnd = 1238218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(System.IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, [In] ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&cullingResultsPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeLightIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitRatio);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowResolution;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowNearPlaneOffset;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewMatrix);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projMatrix);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shadowSplitData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static void FillLightAndReflectionProbeIndicesGraphicsBuffer(System.IntPtr cullingResultsPtr, GraphicsBuffer buffer)
	{
		FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected(cullingResultsPtr, (buffer == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer));
	}

	public static int GetReflectionProbeIndexMapSize(System.IntPtr cullingResultsPtr)
	{
		return GetReflectionProbeIndexMapSizeDelegateField(cullingResultsPtr);
	}

	public static void FillReflectionProbeIndexMap(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize)
	{
		FillReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
	}

	public static void SetReflectionProbeIndexMap(System.IntPtr cullingResultsPtr, System.IntPtr indexMapPtr, int indexMapSize)
	{
		SetReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
	}

	public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer)
	{
		FillLightAndReflectionProbeIndicesGraphicsBuffer(ptr, buffer);
	}

	public unsafe NativeArray<int> GetReflectionProbeIndexMap(Allocator allocator)
	{
		//IL_0017: Expected O, but got Ref
		int reflectionProbeIndexMapSize = GetReflectionProbeIndexMapSize(ptr);
		Unsafe.SkipInit(out NativeArray<int> nativeArray);
		((NativeArray<int>)(&nativeArray))._002Ector(reflectionProbeIndexMapSize, allocator, NativeArrayOptions.UninitializedMemory);
		FillReflectionProbeIndexMap(ptr, (System.IntPtr)nativeArray.GetUnsafePtr(), reflectionProbeIndexMapSize);
		return nativeArray;
	}

	public unsafe void SetReflectionProbeIndexMap(NativeArray<int> lightIndexMap)
	{
		//IL_0019: Expected O, but got Ref
		SetReflectionProbeIndexMap(ptr, (System.IntPtr)lightIndexMap.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&lightIndexMap)).Length);
	}

	public void Validate()
	{
	}

	public static bool operator !=(CullingResults left, CullingResults right)
	{
		return !left.Equals(right);
	}

	public static void FillLightAndReflectionProbeIndicesGraphicsBuffer_Injected(System.IntPtr cullingResultsPtr, System.IntPtr buffer)
	{
		FillLightAndReflectionProbeIndicesGraphicsBuffer_InjectedDelegateField(cullingResultsPtr, buffer);
	}
}
