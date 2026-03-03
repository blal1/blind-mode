using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngineInternal;

namespace UnityEngine;

public class Renderer : Component
{
	private delegate void set_bounds_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void ResetBounds_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetLocalBounds_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool Internal_HasCustomBounds_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool Internal_HasCustomLocalBounds_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetStaticLightmapST_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr st);

	private delegate void CopySharedMaterialArray_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr m);

	private delegate void GetClosestReflectionProbesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr result);

	private delegate bool get_forceRenderingOff_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_allowGPUDrivenRendering_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_allowGPUDrivenRendering_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_smallMeshCulling_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_smallMeshCulling_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool GetIsStaticShadowCaster_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetIsStaticShadowCaster_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate uint get_renderingLayerMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_rendererPriority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_rendererPriority_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate RayTracingMode get_rayTracingMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_rayTracingMode_InjectedDelegate(System.IntPtr _unity_self, RayTracingMode value);

	private delegate RayTracingAccelerationStructureBuildFlags get_rayTracingAccelerationStructureBuildFlags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_rayTracingAccelerationStructureBuildFlags_InjectedDelegate(System.IntPtr _unity_self, RayTracingAccelerationStructureBuildFlags value);

	private delegate bool get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_sortingLayerName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate uint get_sortingKey_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sortingGroupID_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void set_sortingGroupOrder_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate uint get_sortingGroupKey_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isLOD0_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_allowOcclusionWhenDynamic_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_allowOcclusionWhenDynamic_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate System.IntPtr get_staticBatchRootTransform_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_staticBatchRootTransform_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_staticBatchIndex_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetStaticBatchInfo_InjectedDelegate(System.IntPtr _unity_self, int firstSubMesh, int subMeshCount);

	private delegate bool get_isPartOfStaticBatch_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_worldToLocalMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_localToWorldMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate System.IntPtr get_lightProbeProxyVolumeOverride_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_lightProbeProxyVolumeOverride_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int GetLightmapIndex_InjectedDelegate(System.IntPtr _unity_self, LightmapType lt);

	private delegate void SetLightmapIndex_InjectedDelegate(System.IntPtr _unity_self, int index, LightmapType lt);

	private delegate void GetLightmapST_InjectedDelegate(System.IntPtr _unity_self, LightmapType lt, [Out] System.IntPtr ret);

	private delegate void SetLightmapST_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr st, LightmapType lt);

	private delegate System.IntPtr get_LODGroup_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localBounds_Public_set_Void_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPropertyBlock_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_receiveShadows_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forceRenderingOff_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionVectorGenerationMode_Public_get_MotionVectorGenerationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_motionVectorGenerationMode_Public_set_Void_MotionVectorGenerationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeUsage_Public_get_ReflectionProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeAnchor_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterial_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedMaterial_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPropertyBlock_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isVisible_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowCastingMode_Injected_Private_Static_ShadowCastingMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Injected_Private_Static_Void_IntPtr_ShadowCastingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_receiveShadows_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_receiveShadows_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forceRenderingOff_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionVectorGenerationMode_Injected_Private_Static_MotionVectorGenerationMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_motionVectorGenerationMode_Injected_Private_Static_Void_IntPtr_MotionVectorGenerationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightProbeUsage_Injected_Private_Static_LightProbeUsage_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightProbeUsage_Injected_Private_Static_Void_IntPtr_LightProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeUsage_Injected_Private_Static_ReflectionProbeUsage_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflectionProbeUsage_Injected_Private_Static_Void_IntPtr_ReflectionProbeUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingGroupID_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeAnchor_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_probeAnchor_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0;

	private static readonly set_bounds_InjectedDelegate set_bounds_InjectedDelegateField;

	private static readonly ResetBounds_InjectedDelegate ResetBounds_InjectedDelegateField;

	private static readonly ResetLocalBounds_InjectedDelegate ResetLocalBounds_InjectedDelegateField;

	private static readonly Internal_HasCustomBounds_InjectedDelegate Internal_HasCustomBounds_InjectedDelegateField;

	private static readonly Internal_HasCustomLocalBounds_InjectedDelegate Internal_HasCustomLocalBounds_InjectedDelegateField;

	private static readonly SetStaticLightmapST_InjectedDelegate SetStaticLightmapST_InjectedDelegateField;

	private static readonly CopySharedMaterialArray_InjectedDelegate CopySharedMaterialArray_InjectedDelegateField;

	private static readonly GetClosestReflectionProbesInternal_InjectedDelegate GetClosestReflectionProbesInternal_InjectedDelegateField;

	private static readonly get_forceRenderingOff_InjectedDelegate get_forceRenderingOff_InjectedDelegateField;

	private static readonly get_allowGPUDrivenRendering_InjectedDelegate get_allowGPUDrivenRendering_InjectedDelegateField;

	private static readonly set_allowGPUDrivenRendering_InjectedDelegate set_allowGPUDrivenRendering_InjectedDelegateField;

	private static readonly get_smallMeshCulling_InjectedDelegate get_smallMeshCulling_InjectedDelegateField;

	private static readonly set_smallMeshCulling_InjectedDelegate set_smallMeshCulling_InjectedDelegateField;

	private static readonly GetIsStaticShadowCaster_InjectedDelegate GetIsStaticShadowCaster_InjectedDelegateField;

	private static readonly SetIsStaticShadowCaster_InjectedDelegate SetIsStaticShadowCaster_InjectedDelegateField;

	private static readonly get_renderingLayerMask_InjectedDelegate get_renderingLayerMask_InjectedDelegateField;

	private static readonly get_rendererPriority_InjectedDelegate get_rendererPriority_InjectedDelegateField;

	private static readonly set_rendererPriority_InjectedDelegate set_rendererPriority_InjectedDelegateField;

	private static readonly get_rayTracingMode_InjectedDelegate get_rayTracingMode_InjectedDelegateField;

	private static readonly set_rayTracingMode_InjectedDelegate set_rayTracingMode_InjectedDelegateField;

	private static readonly get_rayTracingAccelerationStructureBuildFlags_InjectedDelegate get_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField;

	private static readonly set_rayTracingAccelerationStructureBuildFlags_InjectedDelegate set_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField;

	private static readonly get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField;

	private static readonly set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField;

	private static readonly get_sortingLayerName_InjectedDelegate get_sortingLayerName_InjectedDelegateField;

	private static readonly set_sortingLayerName_InjectedDelegate set_sortingLayerName_InjectedDelegateField;

	private static readonly get_sortingKey_InjectedDelegate get_sortingKey_InjectedDelegateField;

	private static readonly set_sortingGroupID_InjectedDelegate set_sortingGroupID_InjectedDelegateField;

	private static readonly set_sortingGroupOrder_InjectedDelegate set_sortingGroupOrder_InjectedDelegateField;

	private static readonly get_sortingGroupKey_InjectedDelegate get_sortingGroupKey_InjectedDelegateField;

	private static readonly get_isLOD0_InjectedDelegate get_isLOD0_InjectedDelegateField;

	private static readonly get_allowOcclusionWhenDynamic_InjectedDelegate get_allowOcclusionWhenDynamic_InjectedDelegateField;

	private static readonly set_allowOcclusionWhenDynamic_InjectedDelegate set_allowOcclusionWhenDynamic_InjectedDelegateField;

	private static readonly get_staticBatchRootTransform_InjectedDelegate get_staticBatchRootTransform_InjectedDelegateField;

	private static readonly set_staticBatchRootTransform_InjectedDelegate set_staticBatchRootTransform_InjectedDelegateField;

	private static readonly get_staticBatchIndex_InjectedDelegate get_staticBatchIndex_InjectedDelegateField;

	private static readonly SetStaticBatchInfo_InjectedDelegate SetStaticBatchInfo_InjectedDelegateField;

	private static readonly get_isPartOfStaticBatch_InjectedDelegate get_isPartOfStaticBatch_InjectedDelegateField;

	private static readonly get_worldToLocalMatrix_InjectedDelegate get_worldToLocalMatrix_InjectedDelegateField;

	private static readonly get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

	private static readonly get_lightProbeProxyVolumeOverride_InjectedDelegate get_lightProbeProxyVolumeOverride_InjectedDelegateField;

	private static readonly set_lightProbeProxyVolumeOverride_InjectedDelegate set_lightProbeProxyVolumeOverride_InjectedDelegateField;

	private static readonly GetLightmapIndex_InjectedDelegate GetLightmapIndex_InjectedDelegateField;

	private static readonly SetLightmapIndex_InjectedDelegate SetLightmapIndex_InjectedDelegateField;

	private static readonly GetLightmapST_InjectedDelegate GetLightmapST_InjectedDelegateField;

	private static readonly SetLightmapST_InjectedDelegate SetLightmapST_InjectedDelegateField;

	private static readonly get_LODGroup_InjectedDelegate get_LODGroup_InjectedDelegateField;

	public unsafe Bounds bounds
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174070, RefRangeEnd = 1174072, XrefRangeStart = 1174066, XrefRangeEnd = 1174070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bounds_Injected(intPtr, ref value);
		}
	}

	public unsafe Bounds localBounds
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1174076, RefRangeEnd = 1174081, XrefRangeStart = 1174072, XrefRangeEnd = 1174076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174085, RefRangeEnd = 1174086, XrefRangeStart = 1174081, XrefRangeEnd = 1174085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localBounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enabled
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1174463, RefRangeEnd = 1174480, XrefRangeStart = 1174458, XrefRangeEnd = 1174463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 1174485, RefRangeEnd = 1174581, XrefRangeStart = 1174480, XrefRangeEnd = 1174485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isVisible
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1174586, RefRangeEnd = 1174592, XrefRangeStart = 1174581, XrefRangeEnd = 1174586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ShadowCastingMode shadowCastingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174597, RefRangeEnd = 1174598, XrefRangeStart = 1174592, XrefRangeEnd = 1174597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShadowCastingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1174603, RefRangeEnd = 1174607, XrefRangeStart = 1174598, XrefRangeEnd = 1174603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool receiveShadows
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174612, RefRangeEnd = 1174613, XrefRangeStart = 1174607, XrefRangeEnd = 1174612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_receiveShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174618, RefRangeEnd = 1174620, XrefRangeStart = 1174613, XrefRangeEnd = 1174618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool forceRenderingOff
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceRenderingOff_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174625, RefRangeEnd = 1174626, XrefRangeStart = 1174620, XrefRangeEnd = 1174625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forceRenderingOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MotionVectorGenerationMode motionVectorGenerationMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174631, RefRangeEnd = 1174632, XrefRangeStart = 1174626, XrefRangeEnd = 1174631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorGenerationMode_Public_get_MotionVectorGenerationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MotionVectorGenerationMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174637, RefRangeEnd = 1174638, XrefRangeStart = 1174632, XrefRangeEnd = 1174637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorGenerationMode_Public_set_Void_MotionVectorGenerationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LightProbeUsage lightProbeUsage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174643, RefRangeEnd = 1174644, XrefRangeStart = 1174638, XrefRangeEnd = 1174643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightProbeUsage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174649, RefRangeEnd = 1174650, XrefRangeStart = 1174644, XrefRangeEnd = 1174649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReflectionProbeUsage reflectionProbeUsage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174655, RefRangeEnd = 1174656, XrefRangeStart = 1174650, XrefRangeEnd = 1174655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeUsage_Public_get_ReflectionProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ReflectionProbeUsage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174661, RefRangeEnd = 1174662, XrefRangeStart = 1174656, XrefRangeEnd = 1174661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint renderingLayerMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderingLayerMask_Injected(intPtr);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1174667, RefRangeEnd = 1174672, XrefRangeStart = 1174662, XrefRangeEnd = 1174667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sortingLayerID
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1174677, RefRangeEnd = 1174681, XrefRangeStart = 1174672, XrefRangeEnd = 1174677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1174686, RefRangeEnd = 1174692, XrefRangeStart = 1174681, XrefRangeEnd = 1174686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sortingOrder
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1174697, RefRangeEnd = 1174701, XrefRangeStart = 1174692, XrefRangeEnd = 1174697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1174706, RefRangeEnd = 1174719, XrefRangeStart = 1174701, XrefRangeEnd = 1174706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int sortingGroupID
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1174724, RefRangeEnd = 1174726, XrefRangeStart = 1174719, XrefRangeEnd = 1174724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortingGroupID_Injected(intPtr, value);
		}
	}

	public unsafe int sortingGroupOrder
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174731, RefRangeEnd = 1174732, XrefRangeStart = 1174726, XrefRangeEnd = 1174731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sortingGroupOrder_Injected(intPtr, value);
		}
	}

	public unsafe Transform probeAnchor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174740, RefRangeEnd = 1174741, XrefRangeStart = 1174732, XrefRangeEnd = 1174740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeAnchor_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174749, RefRangeEnd = 1174750, XrefRangeStart = 1174741, XrefRangeEnd = 1174749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<Material> materials
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1174350, RefRangeEnd = 1174390, XrefRangeStart = 1174350, XrefRangeEnd = 1174390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1174781, RefRangeEnd = 1174790, XrefRangeStart = 1174780, XrefRangeEnd = 1174781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Material material
	{
		[CallerCount(187)]
		[CachedScanResults(RefRangeStart = 1174094, RefRangeEnd = 1174281, XrefRangeStart = 1174094, XrefRangeEnd = 1174281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1174307, RefRangeEnd = 1174345, XrefRangeStart = 1174307, XrefRangeEnd = 1174345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Material sharedMaterial
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1174289, RefRangeEnd = 1174299, XrefRangeStart = 1174289, XrefRangeEnd = 1174299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1174307, RefRangeEnd = 1174345, XrefRangeStart = 1174307, XrefRangeEnd = 1174345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<Material> sharedMaterials
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1174760, RefRangeEnd = 1174780, XrefRangeStart = 1174760, XrefRangeEnd = 1174780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1174781, RefRangeEnd = 1174790, XrefRangeStart = 1174781, XrefRangeEnd = 1174790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool castShadows
	{
		get
		{
			return shadowCastingMode != ShadowCastingMode.Off;
		}
		set
		{
			shadowCastingMode = (value ? ShadowCastingMode.On : ShadowCastingMode.Off);
		}
	}

	public bool motionVectors
	{
		get
		{
			return motionVectorGenerationMode == MotionVectorGenerationMode.Object;
		}
		set
		{
			motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
		}
	}

	public bool useLightProbes
	{
		get
		{
			return lightProbeUsage != LightProbeUsage.Off;
		}
		set
		{
			lightProbeUsage = (value ? LightProbeUsage.BlendProbes : LightProbeUsage.Off);
		}
	}

	public bool allowGPUDrivenRendering
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_allowGPUDrivenRendering_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_allowGPUDrivenRendering_Injected(intPtr, value);
		}
	}

	public bool smallMeshCulling
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_smallMeshCulling_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_smallMeshCulling_Injected(intPtr, value);
		}
	}

	public bool staticShadowCaster
	{
		get
		{
			return GetIsStaticShadowCaster();
		}
		set
		{
			SetIsStaticShadowCaster(value);
		}
	}

	public int rendererPriority
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rendererPriority_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rendererPriority_Injected(intPtr, value);
		}
	}

	public RayTracingMode rayTracingMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rayTracingMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rayTracingMode_Injected(intPtr, value);
		}
	}

	public RayTracingAccelerationStructureBuildFlags rayTracingAccelerationStructureBuildFlags
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rayTracingAccelerationStructureBuildFlags_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rayTracingAccelerationStructureBuildFlags_Injected(intPtr, value);
		}
	}

	public bool rayTracingAccelerationStructureBuildFlagsOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rayTracingAccelerationStructureBuildFlagsOverride_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rayTracingAccelerationStructureBuildFlagsOverride_Injected(intPtr, value);
		}
	}

	public unsafe string sortingLayerName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_sortingLayerName_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0028: Expected O, but got Ref
			//IL_0034: Expected O, but got Ref
			//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_sortingLayerName_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public uint sortingKey
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingKey_Injected(intPtr);
		}
	}

	public uint sortingGroupKey
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sortingGroupKey_Injected(intPtr);
		}
	}

	public bool isLOD0
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isLOD0_Injected(intPtr);
		}
	}

	public bool allowOcclusionWhenDynamic
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_allowOcclusionWhenDynamic_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_allowOcclusionWhenDynamic_Injected(intPtr, value);
		}
	}

	public Transform staticBatchRootTransform
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Transform>(get_staticBatchRootTransform_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_staticBatchRootTransform_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public int staticBatchIndex
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_staticBatchIndex_Injected(intPtr);
		}
	}

	public bool isPartOfStaticBatch
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isPartOfStaticBatch_Injected(intPtr);
		}
	}

	public Matrix4x4 worldToLocalMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldToLocalMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Matrix4x4 localToWorldMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_localToWorldMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public GameObject lightProbeProxyVolumeOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<GameObject>(get_lightProbeProxyVolumeOverride_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lightProbeProxyVolumeOverride_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public int lightmapIndex
	{
		get
		{
			return GetLightmapIndex(LightmapType.StaticLightmap);
		}
		set
		{
			SetLightmapIndex(value, LightmapType.StaticLightmap);
		}
	}

	public int realtimeLightmapIndex
	{
		get
		{
			return GetLightmapIndex(LightmapType.DynamicLightmap);
		}
		set
		{
			SetLightmapIndex(value, LightmapType.DynamicLightmap);
		}
	}

	public Vector4 lightmapScaleOffset
	{
		get
		{
			return GetLightmapST(LightmapType.StaticLightmap);
		}
		set
		{
			SetStaticLightmapST(value);
		}
	}

	public Vector4 realtimeLightmapScaleOffset
	{
		get
		{
			return GetLightmapST(LightmapType.DynamicLightmap);
		}
		set
		{
			SetLightmapST(value, LightmapType.DynamicLightmap);
		}
	}

	public LODGroup LODGroup
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<LODGroup>(get_LODGroup_Injected(intPtr));
		}
	}

	static Renderer()
	{
		Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Renderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
		NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_get_localBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_set_localBounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664565);
		NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr_HasPropertyBlock_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664575);
		NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_get_receiveShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_set_forceRenderingOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_get_motionVectorGenerationMode_Public_get_MotionVectorGenerationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_set_motionVectorGenerationMode_Public_set_Void_MotionVectorGenerationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_get_lightProbeUsage_Public_get_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_set_lightProbeUsage_Public_set_Void_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_get_reflectionProbeUsage_Public_get_ReflectionProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_set_reflectionProbeUsage_Public_set_Void_ReflectionProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_set_renderingLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_get_probeAnchor_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_set_probeAnchor_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_get_materials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_set_materials_Public_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_set_sharedMaterials_Public_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_get_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_set_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_GetMaterial_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_GetSharedMaterial_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_SetMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_GetMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_CopyMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_SetMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_Internal_SetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_Internal_GetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_HasPropertyBlock_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_get_isVisible_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_get_shadowCastingMode_Injected_Private_Static_ShadowCastingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_set_shadowCastingMode_Injected_Private_Static_Void_IntPtr_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_get_receiveShadows_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_set_receiveShadows_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_set_forceRenderingOff_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_get_motionVectorGenerationMode_Injected_Private_Static_MotionVectorGenerationMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_set_motionVectorGenerationMode_Injected_Private_Static_Void_IntPtr_MotionVectorGenerationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664638);
		NativeMethodInfoPtr_get_lightProbeUsage_Injected_Private_Static_LightProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr_set_lightProbeUsage_Injected_Private_Static_Void_IntPtr_LightProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664640);
		NativeMethodInfoPtr_get_reflectionProbeUsage_Injected_Private_Static_ReflectionProbeUsage_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664641);
		NativeMethodInfoPtr_set_reflectionProbeUsage_Injected_Private_Static_Void_IntPtr_ReflectionProbeUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664642);
		NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664643);
		NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664644);
		NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664645);
		NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664646);
		NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664647);
		NativeMethodInfoPtr_get_sortingGroupID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664648);
		NativeMethodInfoPtr_get_sortingGroupOrder_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664649);
		NativeMethodInfoPtr_get_probeAnchor_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664650);
		NativeMethodInfoPtr_set_probeAnchor_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664651);
		NativeMethodInfoPtr_GetMaterialCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664652);
		NativeMethodInfoPtr_GetSharedMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100664653);
		set_bounds_InjectedDelegateField = IL2CPP.ResolveICall<set_bounds_InjectedDelegate>("UnityEngine.Renderer::set_bounds_Injected");
		ResetBounds_InjectedDelegateField = IL2CPP.ResolveICall<ResetBounds_InjectedDelegate>("UnityEngine.Renderer::ResetBounds_Injected");
		ResetLocalBounds_InjectedDelegateField = IL2CPP.ResolveICall<ResetLocalBounds_InjectedDelegate>("UnityEngine.Renderer::ResetLocalBounds_Injected");
		Internal_HasCustomBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_HasCustomBounds_InjectedDelegate>("UnityEngine.Renderer::Internal_HasCustomBounds_Injected");
		Internal_HasCustomLocalBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_HasCustomLocalBounds_InjectedDelegate>("UnityEngine.Renderer::Internal_HasCustomLocalBounds_Injected");
		SetStaticLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<SetStaticLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetStaticLightmapST_Injected");
		CopySharedMaterialArray_InjectedDelegateField = IL2CPP.ResolveICall<CopySharedMaterialArray_InjectedDelegate>("UnityEngine.Renderer::CopySharedMaterialArray_Injected");
		GetClosestReflectionProbesInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetClosestReflectionProbesInternal_InjectedDelegate>("UnityEngine.Renderer::GetClosestReflectionProbesInternal_Injected");
		get_forceRenderingOff_InjectedDelegateField = IL2CPP.ResolveICall<get_forceRenderingOff_InjectedDelegate>("UnityEngine.Renderer::get_forceRenderingOff_Injected");
		get_allowGPUDrivenRendering_InjectedDelegateField = IL2CPP.ResolveICall<get_allowGPUDrivenRendering_InjectedDelegate>("UnityEngine.Renderer::get_allowGPUDrivenRendering_Injected");
		set_allowGPUDrivenRendering_InjectedDelegateField = IL2CPP.ResolveICall<set_allowGPUDrivenRendering_InjectedDelegate>("UnityEngine.Renderer::set_allowGPUDrivenRendering_Injected");
		get_smallMeshCulling_InjectedDelegateField = IL2CPP.ResolveICall<get_smallMeshCulling_InjectedDelegate>("UnityEngine.Renderer::get_smallMeshCulling_Injected");
		set_smallMeshCulling_InjectedDelegateField = IL2CPP.ResolveICall<set_smallMeshCulling_InjectedDelegate>("UnityEngine.Renderer::set_smallMeshCulling_Injected");
		GetIsStaticShadowCaster_InjectedDelegateField = IL2CPP.ResolveICall<GetIsStaticShadowCaster_InjectedDelegate>("UnityEngine.Renderer::GetIsStaticShadowCaster_Injected");
		SetIsStaticShadowCaster_InjectedDelegateField = IL2CPP.ResolveICall<SetIsStaticShadowCaster_InjectedDelegate>("UnityEngine.Renderer::SetIsStaticShadowCaster_Injected");
		get_renderingLayerMask_InjectedDelegateField = IL2CPP.ResolveICall<get_renderingLayerMask_InjectedDelegate>("UnityEngine.Renderer::get_renderingLayerMask_Injected");
		get_rendererPriority_InjectedDelegateField = IL2CPP.ResolveICall<get_rendererPriority_InjectedDelegate>("UnityEngine.Renderer::get_rendererPriority_Injected");
		set_rendererPriority_InjectedDelegateField = IL2CPP.ResolveICall<set_rendererPriority_InjectedDelegate>("UnityEngine.Renderer::set_rendererPriority_Injected");
		get_rayTracingMode_InjectedDelegateField = IL2CPP.ResolveICall<get_rayTracingMode_InjectedDelegate>("UnityEngine.Renderer::get_rayTracingMode_Injected");
		set_rayTracingMode_InjectedDelegateField = IL2CPP.ResolveICall<set_rayTracingMode_InjectedDelegate>("UnityEngine.Renderer::set_rayTracingMode_Injected");
		get_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_rayTracingAccelerationStructureBuildFlags_InjectedDelegate>("UnityEngine.Renderer::get_rayTracingAccelerationStructureBuildFlags_Injected");
		set_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField = IL2CPP.ResolveICall<set_rayTracingAccelerationStructureBuildFlags_InjectedDelegate>("UnityEngine.Renderer::set_rayTracingAccelerationStructureBuildFlags_Injected");
		get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate>("UnityEngine.Renderer::get_rayTracingAccelerationStructureBuildFlagsOverride_Injected");
		set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegate>("UnityEngine.Renderer::set_rayTracingAccelerationStructureBuildFlagsOverride_Injected");
		get_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingLayerName_InjectedDelegate>("UnityEngine.Renderer::get_sortingLayerName_Injected");
		set_sortingLayerName_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingLayerName_InjectedDelegate>("UnityEngine.Renderer::set_sortingLayerName_Injected");
		get_sortingKey_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingKey_InjectedDelegate>("UnityEngine.Renderer::get_sortingKey_Injected");
		set_sortingGroupID_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingGroupID_InjectedDelegate>("UnityEngine.Renderer::set_sortingGroupID_Injected");
		set_sortingGroupOrder_InjectedDelegateField = IL2CPP.ResolveICall<set_sortingGroupOrder_InjectedDelegate>("UnityEngine.Renderer::set_sortingGroupOrder_Injected");
		get_sortingGroupKey_InjectedDelegateField = IL2CPP.ResolveICall<get_sortingGroupKey_InjectedDelegate>("UnityEngine.Renderer::get_sortingGroupKey_Injected");
		get_isLOD0_InjectedDelegateField = IL2CPP.ResolveICall<get_isLOD0_InjectedDelegate>("UnityEngine.Renderer::get_isLOD0_Injected");
		get_allowOcclusionWhenDynamic_InjectedDelegateField = IL2CPP.ResolveICall<get_allowOcclusionWhenDynamic_InjectedDelegate>("UnityEngine.Renderer::get_allowOcclusionWhenDynamic_Injected");
		set_allowOcclusionWhenDynamic_InjectedDelegateField = IL2CPP.ResolveICall<set_allowOcclusionWhenDynamic_InjectedDelegate>("UnityEngine.Renderer::set_allowOcclusionWhenDynamic_Injected");
		get_staticBatchRootTransform_InjectedDelegateField = IL2CPP.ResolveICall<get_staticBatchRootTransform_InjectedDelegate>("UnityEngine.Renderer::get_staticBatchRootTransform_Injected");
		set_staticBatchRootTransform_InjectedDelegateField = IL2CPP.ResolveICall<set_staticBatchRootTransform_InjectedDelegate>("UnityEngine.Renderer::set_staticBatchRootTransform_Injected");
		get_staticBatchIndex_InjectedDelegateField = IL2CPP.ResolveICall<get_staticBatchIndex_InjectedDelegate>("UnityEngine.Renderer::get_staticBatchIndex_Injected");
		SetStaticBatchInfo_InjectedDelegateField = IL2CPP.ResolveICall<SetStaticBatchInfo_InjectedDelegate>("UnityEngine.Renderer::SetStaticBatchInfo_Injected");
		get_isPartOfStaticBatch_InjectedDelegateField = IL2CPP.ResolveICall<get_isPartOfStaticBatch_InjectedDelegate>("UnityEngine.Renderer::get_isPartOfStaticBatch_Injected");
		get_worldToLocalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_worldToLocalMatrix_InjectedDelegate>("UnityEngine.Renderer::get_worldToLocalMatrix_Injected");
		get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Renderer::get_localToWorldMatrix_Injected");
		get_lightProbeProxyVolumeOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_lightProbeProxyVolumeOverride_InjectedDelegate>("UnityEngine.Renderer::get_lightProbeProxyVolumeOverride_Injected");
		set_lightProbeProxyVolumeOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_lightProbeProxyVolumeOverride_InjectedDelegate>("UnityEngine.Renderer::set_lightProbeProxyVolumeOverride_Injected");
		GetLightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetLightmapIndex_InjectedDelegate>("UnityEngine.Renderer::GetLightmapIndex_Injected");
		SetLightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<SetLightmapIndex_InjectedDelegate>("UnityEngine.Renderer::SetLightmapIndex_Injected");
		GetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<GetLightmapST_InjectedDelegate>("UnityEngine.Renderer::GetLightmapST_Injected");
		SetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<SetLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetLightmapST_Injected");
		get_LODGroup_InjectedDelegateField = IL2CPP.ResolveICall<get_LODGroup_InjectedDelegate>("UnityEngine.Renderer::get_LODGroup_Injected");
	}

	[CallerCount(187)]
	[CachedScanResults(RefRangeStart = 1174094, RefRangeEnd = 1174281, XrefRangeStart = 1174086, XrefRangeEnd = 1174094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetMaterial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1174289, RefRangeEnd = 1174299, XrefRangeStart = 1174281, XrefRangeEnd = 1174289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetSharedMaterial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 1174307, RefRangeEnd = 1174345, XrefRangeStart = 1174299, XrefRangeEnd = 1174307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaterial(Material m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 1174350, RefRangeEnd = 1174390, XrefRangeStart = 1174345, XrefRangeEnd = 1174350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Material> GetMaterialArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174390, XrefRangeEnd = 1174395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyMaterialArray([Out] Il2CppReferenceArray<Material> m)
	{
		//IL_0043: Expected native int or pointer, but got O
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)m, (num2 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num2));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174395, XrefRangeEnd = 1174403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1174412, RefRangeEnd = 1174414, XrefRangeStart = 1174403, XrefRangeEnd = 1174412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaterialArray(Il2CppReferenceArray<Material> m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialArray_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174419, RefRangeEnd = 1174420, XrefRangeStart = 1174414, XrefRangeEnd = 1174419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetPropertyBlock_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1174430, RefRangeEnd = 1174434, XrefRangeStart = 1174420, XrefRangeEnd = 1174430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_GetPropertyBlock(MaterialPropertyBlock dest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPropertyBlock_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174439, RefRangeEnd = 1174440, XrefRangeStart = 1174434, XrefRangeEnd = 1174439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174450, RefRangeEnd = 1174451, XrefRangeStart = 1174440, XrefRangeEnd = 1174450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Internal_Void_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1174456, RefRangeEnd = 1174458, XrefRangeStart = 1174451, XrefRangeEnd = 1174456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPropertyBlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPropertyBlock_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174419, RefRangeEnd = 1174420, XrefRangeStart = 1174419, XrefRangeEnd = 1174420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPropertyBlock(MaterialPropertyBlock properties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174439, RefRangeEnd = 1174440, XrefRangeStart = 1174439, XrefRangeEnd = 1174440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1174430, RefRangeEnd = 1174434, XrefRangeStart = 1174430, XrefRangeEnd = 1174434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetPropertyBlock(MaterialPropertyBlock properties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174450, RefRangeEnd = 1174451, XrefRangeStart = 1174450, XrefRangeEnd = 1174451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropertyBlock_Public_Void_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174750, XrefRangeEnd = 1174755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaterialCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1174760, RefRangeEnd = 1174780, XrefRangeStart = 1174755, XrefRangeEnd = 1174760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Material> GetSharedMaterialArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174813, RefRangeEnd = 1174814, XrefRangeStart = 1174790, XrefRangeEnd = 1174813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMaterials(List<Material> m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterials_Public_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Renderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174814, XrefRangeEnd = 1174816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_bounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174816, XrefRangeEnd = 1174818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_localBounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174818, XrefRangeEnd = 1174820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_localBounds_Injected(System.IntPtr _unity_self, [In] ref Bounds value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localBounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174820, XrefRangeEnd = 1174822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMaterial_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterial_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174822, XrefRangeEnd = 1174824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSharedMaterial_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedMaterial_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174824, XrefRangeEnd = 1174826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMaterial_Injected(System.IntPtr _unity_self, System.IntPtr m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &m;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174826, XrefRangeEnd = 1174828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Material> GetMaterialArray_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174828, XrefRangeEnd = 1174830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyMaterialArray_Injected(System.IntPtr _unity_self, [Out] Il2CppReferenceArray<Material> m)
	{
		//IL_0045: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		Unsafe.Write((void*)(nint)m, (num3 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174830, XrefRangeEnd = 1174832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMaterialArray_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Material> m, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialArray_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Material_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174832, XrefRangeEnd = 1174834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetPropertyBlock_Injected(System.IntPtr _unity_self, System.IntPtr properties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &properties;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174834, XrefRangeEnd = 1174836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_GetPropertyBlock_Injected(System.IntPtr _unity_self, System.IntPtr dest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPropertyBlock_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174836, XrefRangeEnd = 1174838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetPropertyBlockMaterialIndex_Injected(System.IntPtr _unity_self, System.IntPtr properties, int materialIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &properties;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174838, XrefRangeEnd = 1174840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_GetPropertyBlockMaterialIndex_Injected(System.IntPtr _unity_self, System.IntPtr dest, int materialIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetPropertyBlockMaterialIndex_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174840, XrefRangeEnd = 1174842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasPropertyBlock_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPropertyBlock_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174842, XrefRangeEnd = 1174844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_enabled_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174844, XrefRangeEnd = 1174846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_enabled_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174846, XrefRangeEnd = 1174848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isVisible_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isVisible_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174848, XrefRangeEnd = 1174850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShadowCastingMode get_shadowCastingMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowCastingMode_Injected_Private_Static_ShadowCastingMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShadowCastingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174850, XrefRangeEnd = 1174852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_shadowCastingMode_Injected(System.IntPtr _unity_self, ShadowCastingMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCastingMode_Injected_Private_Static_Void_IntPtr_ShadowCastingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174852, XrefRangeEnd = 1174854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_receiveShadows_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_receiveShadows_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174854, XrefRangeEnd = 1174856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_receiveShadows_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_receiveShadows_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174856, XrefRangeEnd = 1174858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_forceRenderingOff_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forceRenderingOff_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174858, XrefRangeEnd = 1174860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MotionVectorGenerationMode get_motionVectorGenerationMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionVectorGenerationMode_Injected_Private_Static_MotionVectorGenerationMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MotionVectorGenerationMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174860, XrefRangeEnd = 1174862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_motionVectorGenerationMode_Injected(System.IntPtr _unity_self, MotionVectorGenerationMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(MotionVectorGenerationMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_motionVectorGenerationMode_Injected_Private_Static_Void_IntPtr_MotionVectorGenerationMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174862, XrefRangeEnd = 1174864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LightProbeUsage get_lightProbeUsage_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightProbeUsage_Injected_Private_Static_LightProbeUsage_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LightProbeUsage*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174864, XrefRangeEnd = 1174866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_lightProbeUsage_Injected(System.IntPtr _unity_self, LightProbeUsage value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(LightProbeUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightProbeUsage_Injected_Private_Static_Void_IntPtr_LightProbeUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174866, XrefRangeEnd = 1174868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReflectionProbeUsage get_reflectionProbeUsage_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeUsage_Injected_Private_Static_ReflectionProbeUsage_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReflectionProbeUsage*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174868, XrefRangeEnd = 1174870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_reflectionProbeUsage_Injected(System.IntPtr _unity_self, ReflectionProbeUsage value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(ReflectionProbeUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflectionProbeUsage_Injected_Private_Static_Void_IntPtr_ReflectionProbeUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174870, XrefRangeEnd = 1174872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_renderingLayerMask_Injected(System.IntPtr _unity_self, uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderingLayerMask_Injected_Private_Static_Void_IntPtr_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174872, XrefRangeEnd = 1174874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingLayerID_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingLayerID_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174874, XrefRangeEnd = 1174876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sortingLayerID_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingLayerID_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174876, XrefRangeEnd = 1174878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingOrder_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingOrder_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174878, XrefRangeEnd = 1174880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sortingOrder_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sortingOrder_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174880, XrefRangeEnd = 1174882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingGroupID_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingGroupID_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174882, XrefRangeEnd = 1174884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_sortingGroupOrder_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sortingGroupOrder_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174884, XrefRangeEnd = 1174886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_probeAnchor_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeAnchor_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174886, XrefRangeEnd = 1174888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_probeAnchor_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probeAnchor_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174888, XrefRangeEnd = 1174890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaterialCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174890, XrefRangeEnd = 1174892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Material> GetSharedMaterialArray_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSharedMaterialArray_Injected_Private_Static_Il2CppReferenceArray_1_Material_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
	}

	public Renderer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void ResetBounds()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetBounds_Injected(intPtr);
	}

	public void ResetLocalBounds()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetLocalBounds_Injected(intPtr);
	}

	public bool Internal_HasCustomBounds()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_HasCustomBounds_Injected(intPtr);
	}

	public bool Internal_HasCustomLocalBounds()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_HasCustomLocalBounds_Injected(intPtr);
	}

	public void SetStaticLightmapST(Vector4 st)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetStaticLightmapST_Injected(intPtr, ref st);
	}

	public void CopySharedMaterialArray([Out] Il2CppReferenceArray<Material> m)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopySharedMaterialArray_Injected(intPtr, m);
	}

	public void GetClosestReflectionProbesInternal(Il2CppSystem.Object result)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetClosestReflectionProbesInternal_Injected(intPtr, result);
	}

	public bool GetIsStaticShadowCaster()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetIsStaticShadowCaster_Injected(intPtr);
	}

	public void SetIsStaticShadowCaster(bool value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetIsStaticShadowCaster_Injected(intPtr, value);
	}

	public void SetStaticBatchInfo(int firstSubMesh, int subMeshCount)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetStaticBatchInfo_Injected(intPtr, firstSubMesh, subMeshCount);
	}

	public int GetLightmapIndex(LightmapType lt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetLightmapIndex_Injected(intPtr, lt);
	}

	public void SetLightmapIndex(int index, LightmapType lt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLightmapIndex_Injected(intPtr, index, lt);
	}

	public Vector4 GetLightmapST(LightmapType lt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetLightmapST_Injected(intPtr, lt, out var ret);
		return ret;
	}

	public void SetLightmapST(Vector4 st, LightmapType lt)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLightmapST_Injected(intPtr, ref st, lt);
	}

	public void SetSharedMaterials(List<Material> materials)
	{
		if (materials == null)
		{
			throw new Il2CppSystem.ArgumentNullException("The material list to set cannot be null.", "materials");
		}
		SetMaterialArray((Il2CppReferenceArray<Material>)(object)NoAllocHelpers.ExtractArrayFromList(materials), materials.Count);
	}

	public void SetMaterials(List<Material> materials)
	{
		if (materials == null)
		{
			throw new Il2CppSystem.ArgumentNullException("The material list to set cannot be null.", "materials");
		}
		SetMaterialArray((Il2CppReferenceArray<Material>)(object)NoAllocHelpers.ExtractArrayFromList(materials), materials.Count);
	}

	public void GetSharedMaterials(List<Material> m)
	{
		if (m == null)
		{
			throw new Il2CppSystem.ArgumentNullException("The result material list cannot be null.", "m");
		}
		NoAllocHelpers.EnsureListElemCount(m, GetMaterialCount());
		CopySharedMaterialArray((Il2CppReferenceArray<Material>)(object)NoAllocHelpers.ExtractArrayFromList(m));
	}

	public unsafe static void set_bounds_Injected(System.IntPtr _unity_self, [In] ref Bounds value)
	{
		set_bounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void ResetBounds_Injected(System.IntPtr _unity_self)
	{
		ResetBounds_InjectedDelegateField(_unity_self);
	}

	public static void ResetLocalBounds_Injected(System.IntPtr _unity_self)
	{
		ResetLocalBounds_InjectedDelegateField(_unity_self);
	}

	public static bool Internal_HasCustomBounds_Injected(System.IntPtr _unity_self)
	{
		return Internal_HasCustomBounds_InjectedDelegateField(_unity_self);
	}

	public static bool Internal_HasCustomLocalBounds_Injected(System.IntPtr _unity_self)
	{
		return Internal_HasCustomLocalBounds_InjectedDelegateField(_unity_self);
	}

	public unsafe static void SetStaticLightmapST_Injected(System.IntPtr _unity_self, [In] ref Vector4 st)
	{
		SetStaticLightmapST_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref st));
	}

	public static void CopySharedMaterialArray_Injected(System.IntPtr _unity_self, [Out] Il2CppReferenceArray<Material> m)
	{
		CopySharedMaterialArray_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m));
	}

	public static void GetClosestReflectionProbesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object result)
	{
		GetClosestReflectionProbesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result));
	}

	public static bool get_forceRenderingOff_Injected(System.IntPtr _unity_self)
	{
		return get_forceRenderingOff_InjectedDelegateField(_unity_self);
	}

	public static bool get_allowGPUDrivenRendering_Injected(System.IntPtr _unity_self)
	{
		return get_allowGPUDrivenRendering_InjectedDelegateField(_unity_self);
	}

	public static void set_allowGPUDrivenRendering_Injected(System.IntPtr _unity_self, bool value)
	{
		set_allowGPUDrivenRendering_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_smallMeshCulling_Injected(System.IntPtr _unity_self)
	{
		return get_smallMeshCulling_InjectedDelegateField(_unity_self);
	}

	public static void set_smallMeshCulling_Injected(System.IntPtr _unity_self, bool value)
	{
		set_smallMeshCulling_InjectedDelegateField(_unity_self, value);
	}

	public static bool GetIsStaticShadowCaster_Injected(System.IntPtr _unity_self)
	{
		return GetIsStaticShadowCaster_InjectedDelegateField(_unity_self);
	}

	public static void SetIsStaticShadowCaster_Injected(System.IntPtr _unity_self, bool value)
	{
		SetIsStaticShadowCaster_InjectedDelegateField(_unity_self, value);
	}

	public static uint get_renderingLayerMask_Injected(System.IntPtr _unity_self)
	{
		return get_renderingLayerMask_InjectedDelegateField(_unity_self);
	}

	public static int get_rendererPriority_Injected(System.IntPtr _unity_self)
	{
		return get_rendererPriority_InjectedDelegateField(_unity_self);
	}

	public static void set_rendererPriority_Injected(System.IntPtr _unity_self, int value)
	{
		set_rendererPriority_InjectedDelegateField(_unity_self, value);
	}

	public static RayTracingMode get_rayTracingMode_Injected(System.IntPtr _unity_self)
	{
		return get_rayTracingMode_InjectedDelegateField(_unity_self);
	}

	public static void set_rayTracingMode_Injected(System.IntPtr _unity_self, RayTracingMode value)
	{
		set_rayTracingMode_InjectedDelegateField(_unity_self, value);
	}

	public static RayTracingAccelerationStructureBuildFlags get_rayTracingAccelerationStructureBuildFlags_Injected(System.IntPtr _unity_self)
	{
		return get_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField(_unity_self);
	}

	public static void set_rayTracingAccelerationStructureBuildFlags_Injected(System.IntPtr _unity_self, RayTracingAccelerationStructureBuildFlags value)
	{
		set_rayTracingAccelerationStructureBuildFlags_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_rayTracingAccelerationStructureBuildFlagsOverride_Injected(System.IntPtr _unity_self)
	{
		return get_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_rayTracingAccelerationStructureBuildFlagsOverride_Injected(System.IntPtr _unity_self, bool value)
	{
		set_rayTracingAccelerationStructureBuildFlagsOverride_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_sortingLayerName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_sortingLayerName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_sortingLayerName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static uint get_sortingKey_Injected(System.IntPtr _unity_self)
	{
		return get_sortingKey_InjectedDelegateField(_unity_self);
	}

	public static void set_sortingGroupID_Injected(System.IntPtr _unity_self, int value)
	{
		set_sortingGroupID_InjectedDelegateField(_unity_self, value);
	}

	public static void set_sortingGroupOrder_Injected(System.IntPtr _unity_self, int value)
	{
		set_sortingGroupOrder_InjectedDelegateField(_unity_self, value);
	}

	public static uint get_sortingGroupKey_Injected(System.IntPtr _unity_self)
	{
		return get_sortingGroupKey_InjectedDelegateField(_unity_self);
	}

	public static bool get_isLOD0_Injected(System.IntPtr _unity_self)
	{
		return get_isLOD0_InjectedDelegateField(_unity_self);
	}

	public static bool get_allowOcclusionWhenDynamic_Injected(System.IntPtr _unity_self)
	{
		return get_allowOcclusionWhenDynamic_InjectedDelegateField(_unity_self);
	}

	public static void set_allowOcclusionWhenDynamic_Injected(System.IntPtr _unity_self, bool value)
	{
		set_allowOcclusionWhenDynamic_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_staticBatchRootTransform_Injected(System.IntPtr _unity_self)
	{
		return get_staticBatchRootTransform_InjectedDelegateField(_unity_self);
	}

	public static void set_staticBatchRootTransform_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_staticBatchRootTransform_InjectedDelegateField(_unity_self, value);
	}

	public static int get_staticBatchIndex_Injected(System.IntPtr _unity_self)
	{
		return get_staticBatchIndex_InjectedDelegateField(_unity_self);
	}

	public static void SetStaticBatchInfo_Injected(System.IntPtr _unity_self, int firstSubMesh, int subMeshCount)
	{
		SetStaticBatchInfo_InjectedDelegateField(_unity_self, firstSubMesh, subMeshCount);
	}

	public static bool get_isPartOfStaticBatch_Injected(System.IntPtr _unity_self)
	{
		return get_isPartOfStaticBatch_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_worldToLocalMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_worldToLocalMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_localToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_localToWorldMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr get_lightProbeProxyVolumeOverride_Injected(System.IntPtr _unity_self)
	{
		return get_lightProbeProxyVolumeOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_lightProbeProxyVolumeOverride_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_lightProbeProxyVolumeOverride_InjectedDelegateField(_unity_self, value);
	}

	public static int GetLightmapIndex_Injected(System.IntPtr _unity_self, LightmapType lt)
	{
		return GetLightmapIndex_InjectedDelegateField(_unity_self, lt);
	}

	public static void SetLightmapIndex_Injected(System.IntPtr _unity_self, int index, LightmapType lt)
	{
		SetLightmapIndex_InjectedDelegateField(_unity_self, index, lt);
	}

	public unsafe static void GetLightmapST_Injected(System.IntPtr _unity_self, LightmapType lt, out Vector4 ret)
	{
		GetLightmapST_InjectedDelegateField(_unity_self, lt, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetLightmapST_Injected(System.IntPtr _unity_self, [In] ref Vector4 st, LightmapType lt)
	{
		SetLightmapST_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref st), lt);
	}

	public static System.IntPtr get_LODGroup_Injected(System.IntPtr _unity_self)
	{
		return get_LODGroup_InjectedDelegateField(_unity_self);
	}
}
