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

namespace UnityEngine;

public sealed class Terrain : Behaviour
{
	public enum MaterialType
	{
		BuiltInStandard,
		BuiltInLegacyDiffuse,
		BuiltInLegacySpecular,
		Custom
	}

	private delegate GraphicsFormat get_heightmapFormatDelegate();

	private delegate GraphicsFormat get_normalmapFormatDelegate();

	private delegate GraphicsFormat get_holesFormatDelegate();

	private delegate GraphicsFormat get_compressedHolesFormatDelegate();

	private delegate void SetConnectivityDirtyDelegate();

	private delegate void set_terrainData_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate float get_treeDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_treeBillboardDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeBillboardDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_treeCrossFadeLength_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeCrossFadeLength_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_treeMaximumFullLODCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeMaximumFullLODCount_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_detailObjectDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_detailObjectDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_detailObjectDensity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_detailObjectDensity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_heightmapPixelError_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_heightmapPixelError_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_heightmapMaximumLOD_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_heightmapMaximumLOD_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_heightmapMinimumLODSimplification_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_heightmapMinimumLODSimplification_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_basemapDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_basemapDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_lightmapIndex_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_lightmapIndex_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_realtimeLightmapIndex_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_realtimeLightmapIndex_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void get_lightmapScaleOffset_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_lightmapScaleOffset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_realtimeLightmapScaleOffset_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_realtimeLightmapScaleOffset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate bool get_freeUnusedRenderingResources_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_freeUnusedRenderingResources_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_keepUnusedRenderingResources_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_keepUnusedRenderingResources_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool GetKeepUnusedCameraRenderingResources_InjectedDelegate(System.IntPtr _unity_self, int cameraInstanceID);

	private delegate void SetKeepUnusedCameraRenderingResources_InjectedDelegate(System.IntPtr _unity_self, int cameraInstanceID, bool keepUnused);

	private delegate ShadowCastingMode get_shadowCastingMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shadowCastingMode_InjectedDelegate(System.IntPtr _unity_self, ShadowCastingMode value);

	private delegate ReflectionProbeUsage get_reflectionProbeUsage_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_reflectionProbeUsage_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeUsage value);

	private delegate System.IntPtr get_materialTemplate_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_materialTemplate_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate bool get_drawHeightmap_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_drawHeightmap_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_allowAutoConnect_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_groupingID_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_drawInstanced_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_drawInstanced_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_enableHeightmapRayTracing_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enableHeightmapRayTracing_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate System.IntPtr get_normalmapTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_drawTreesAndFoliage_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_drawTreesAndFoliage_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_patchBoundsMultiplier_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_patchBoundsMultiplier_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float SampleHeight_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr worldPosition);

	private delegate float get_treeLODBiasMultiplier_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeLODBiasMultiplier_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_collectDetailPatches_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_collectDetailPatches_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_ignoreQualitySettings_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_ignoreQualitySettings_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate TerrainRenderFlags get_editorRenderFlags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_editorRenderFlags_InjectedDelegate(System.IntPtr _unity_self, TerrainRenderFlags value);

	private delegate void GetPosition_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void Flush_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void RemoveTrees_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float radius, int prototypeIndex);

	private delegate void SetSplatMaterialPropertyBlock_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr properties);

	private delegate void Internal_GetSplatMaterialPropertyBlock_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr dest);

	private delegate TreeMotionVectorModeOverride get_treeMotionVectorModeOverride_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treeMotionVectorModeOverride_InjectedDelegate(System.IntPtr _unity_self, TreeMotionVectorModeOverride value);

	private delegate bool get_preserveTreePrototypeLayers_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_preserveTreePrototypeLayers_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate System.IntPtr get_activeTerrain_InjectedDelegate();

	private delegate void Internal_FillActiveTerrainList_InjectedDelegate(System.IntPtr terrainList);

	private delegate System.IntPtr CreateTerrainGameObject_InjectedDelegate(System.IntPtr assignTerrain);

	private delegate System.IntPtr get_leftNeighbor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_rightNeighbor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_topNeighbor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_bottomNeighbor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint get_renderingLayerMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderingLayerMask_InjectedDelegate(System.IntPtr _unity_self, uint value);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainData_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowAutoConnect_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_groupingID_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNeighbors_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0;

	private static readonly get_heightmapFormatDelegate get_heightmapFormatDelegateField;

	private static readonly get_normalmapFormatDelegate get_normalmapFormatDelegateField;

	private static readonly get_holesFormatDelegate get_holesFormatDelegateField;

	private static readonly get_compressedHolesFormatDelegate get_compressedHolesFormatDelegateField;

	private static readonly SetConnectivityDirtyDelegate SetConnectivityDirtyDelegateField;

	private static readonly set_terrainData_InjectedDelegate set_terrainData_InjectedDelegateField;

	private static readonly get_treeDistance_InjectedDelegate get_treeDistance_InjectedDelegateField;

	private static readonly set_treeDistance_InjectedDelegate set_treeDistance_InjectedDelegateField;

	private static readonly get_treeBillboardDistance_InjectedDelegate get_treeBillboardDistance_InjectedDelegateField;

	private static readonly set_treeBillboardDistance_InjectedDelegate set_treeBillboardDistance_InjectedDelegateField;

	private static readonly get_treeCrossFadeLength_InjectedDelegate get_treeCrossFadeLength_InjectedDelegateField;

	private static readonly set_treeCrossFadeLength_InjectedDelegate set_treeCrossFadeLength_InjectedDelegateField;

	private static readonly get_treeMaximumFullLODCount_InjectedDelegate get_treeMaximumFullLODCount_InjectedDelegateField;

	private static readonly set_treeMaximumFullLODCount_InjectedDelegate set_treeMaximumFullLODCount_InjectedDelegateField;

	private static readonly get_detailObjectDistance_InjectedDelegate get_detailObjectDistance_InjectedDelegateField;

	private static readonly set_detailObjectDistance_InjectedDelegate set_detailObjectDistance_InjectedDelegateField;

	private static readonly get_detailObjectDensity_InjectedDelegate get_detailObjectDensity_InjectedDelegateField;

	private static readonly set_detailObjectDensity_InjectedDelegate set_detailObjectDensity_InjectedDelegateField;

	private static readonly get_heightmapPixelError_InjectedDelegate get_heightmapPixelError_InjectedDelegateField;

	private static readonly set_heightmapPixelError_InjectedDelegate set_heightmapPixelError_InjectedDelegateField;

	private static readonly get_heightmapMaximumLOD_InjectedDelegate get_heightmapMaximumLOD_InjectedDelegateField;

	private static readonly set_heightmapMaximumLOD_InjectedDelegate set_heightmapMaximumLOD_InjectedDelegateField;

	private static readonly get_heightmapMinimumLODSimplification_InjectedDelegate get_heightmapMinimumLODSimplification_InjectedDelegateField;

	private static readonly set_heightmapMinimumLODSimplification_InjectedDelegate set_heightmapMinimumLODSimplification_InjectedDelegateField;

	private static readonly get_basemapDistance_InjectedDelegate get_basemapDistance_InjectedDelegateField;

	private static readonly set_basemapDistance_InjectedDelegate set_basemapDistance_InjectedDelegateField;

	private static readonly get_lightmapIndex_InjectedDelegate get_lightmapIndex_InjectedDelegateField;

	private static readonly set_lightmapIndex_InjectedDelegate set_lightmapIndex_InjectedDelegateField;

	private static readonly get_realtimeLightmapIndex_InjectedDelegate get_realtimeLightmapIndex_InjectedDelegateField;

	private static readonly set_realtimeLightmapIndex_InjectedDelegate set_realtimeLightmapIndex_InjectedDelegateField;

	private static readonly get_lightmapScaleOffset_InjectedDelegate get_lightmapScaleOffset_InjectedDelegateField;

	private static readonly set_lightmapScaleOffset_InjectedDelegate set_lightmapScaleOffset_InjectedDelegateField;

	private static readonly get_realtimeLightmapScaleOffset_InjectedDelegate get_realtimeLightmapScaleOffset_InjectedDelegateField;

	private static readonly set_realtimeLightmapScaleOffset_InjectedDelegate set_realtimeLightmapScaleOffset_InjectedDelegateField;

	private static readonly get_freeUnusedRenderingResources_InjectedDelegate get_freeUnusedRenderingResources_InjectedDelegateField;

	private static readonly set_freeUnusedRenderingResources_InjectedDelegate set_freeUnusedRenderingResources_InjectedDelegateField;

	private static readonly get_keepUnusedRenderingResources_InjectedDelegate get_keepUnusedRenderingResources_InjectedDelegateField;

	private static readonly set_keepUnusedRenderingResources_InjectedDelegate set_keepUnusedRenderingResources_InjectedDelegateField;

	private static readonly GetKeepUnusedCameraRenderingResources_InjectedDelegate GetKeepUnusedCameraRenderingResources_InjectedDelegateField;

	private static readonly SetKeepUnusedCameraRenderingResources_InjectedDelegate SetKeepUnusedCameraRenderingResources_InjectedDelegateField;

	private static readonly get_shadowCastingMode_InjectedDelegate get_shadowCastingMode_InjectedDelegateField;

	private static readonly set_shadowCastingMode_InjectedDelegate set_shadowCastingMode_InjectedDelegateField;

	private static readonly get_reflectionProbeUsage_InjectedDelegate get_reflectionProbeUsage_InjectedDelegateField;

	private static readonly set_reflectionProbeUsage_InjectedDelegate set_reflectionProbeUsage_InjectedDelegateField;

	private static readonly get_materialTemplate_InjectedDelegate get_materialTemplate_InjectedDelegateField;

	private static readonly set_materialTemplate_InjectedDelegate set_materialTemplate_InjectedDelegateField;

	private static readonly get_drawHeightmap_InjectedDelegate get_drawHeightmap_InjectedDelegateField;

	private static readonly set_drawHeightmap_InjectedDelegate set_drawHeightmap_InjectedDelegateField;

	private static readonly set_allowAutoConnect_InjectedDelegate set_allowAutoConnect_InjectedDelegateField;

	private static readonly set_groupingID_InjectedDelegate set_groupingID_InjectedDelegateField;

	private static readonly get_drawInstanced_InjectedDelegate get_drawInstanced_InjectedDelegateField;

	private static readonly set_drawInstanced_InjectedDelegate set_drawInstanced_InjectedDelegateField;

	private static readonly get_enableHeightmapRayTracing_InjectedDelegate get_enableHeightmapRayTracing_InjectedDelegateField;

	private static readonly set_enableHeightmapRayTracing_InjectedDelegate set_enableHeightmapRayTracing_InjectedDelegateField;

	private static readonly get_normalmapTexture_InjectedDelegate get_normalmapTexture_InjectedDelegateField;

	private static readonly get_drawTreesAndFoliage_InjectedDelegate get_drawTreesAndFoliage_InjectedDelegateField;

	private static readonly set_drawTreesAndFoliage_InjectedDelegate set_drawTreesAndFoliage_InjectedDelegateField;

	private static readonly get_patchBoundsMultiplier_InjectedDelegate get_patchBoundsMultiplier_InjectedDelegateField;

	private static readonly set_patchBoundsMultiplier_InjectedDelegate set_patchBoundsMultiplier_InjectedDelegateField;

	private static readonly SampleHeight_InjectedDelegate SampleHeight_InjectedDelegateField;

	private static readonly get_treeLODBiasMultiplier_InjectedDelegate get_treeLODBiasMultiplier_InjectedDelegateField;

	private static readonly set_treeLODBiasMultiplier_InjectedDelegate set_treeLODBiasMultiplier_InjectedDelegateField;

	private static readonly get_collectDetailPatches_InjectedDelegate get_collectDetailPatches_InjectedDelegateField;

	private static readonly set_collectDetailPatches_InjectedDelegate set_collectDetailPatches_InjectedDelegateField;

	private static readonly get_ignoreQualitySettings_InjectedDelegate get_ignoreQualitySettings_InjectedDelegateField;

	private static readonly set_ignoreQualitySettings_InjectedDelegate set_ignoreQualitySettings_InjectedDelegateField;

	private static readonly get_editorRenderFlags_InjectedDelegate get_editorRenderFlags_InjectedDelegateField;

	private static readonly set_editorRenderFlags_InjectedDelegate set_editorRenderFlags_InjectedDelegateField;

	private static readonly GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

	private static readonly Flush_InjectedDelegate Flush_InjectedDelegateField;

	private static readonly RemoveTrees_InjectedDelegate RemoveTrees_InjectedDelegateField;

	private static readonly SetSplatMaterialPropertyBlock_InjectedDelegate SetSplatMaterialPropertyBlock_InjectedDelegateField;

	private static readonly Internal_GetSplatMaterialPropertyBlock_InjectedDelegate Internal_GetSplatMaterialPropertyBlock_InjectedDelegateField;

	private static readonly get_treeMotionVectorModeOverride_InjectedDelegate get_treeMotionVectorModeOverride_InjectedDelegateField;

	private static readonly set_treeMotionVectorModeOverride_InjectedDelegate set_treeMotionVectorModeOverride_InjectedDelegateField;

	private static readonly get_preserveTreePrototypeLayers_InjectedDelegate get_preserveTreePrototypeLayers_InjectedDelegateField;

	private static readonly set_preserveTreePrototypeLayers_InjectedDelegate set_preserveTreePrototypeLayers_InjectedDelegateField;

	private static readonly get_activeTerrain_InjectedDelegate get_activeTerrain_InjectedDelegateField;

	private static readonly Internal_FillActiveTerrainList_InjectedDelegate Internal_FillActiveTerrainList_InjectedDelegateField;

	private static readonly CreateTerrainGameObject_InjectedDelegate CreateTerrainGameObject_InjectedDelegateField;

	private static readonly get_leftNeighbor_InjectedDelegate get_leftNeighbor_InjectedDelegateField;

	private static readonly get_rightNeighbor_InjectedDelegate get_rightNeighbor_InjectedDelegateField;

	private static readonly get_topNeighbor_InjectedDelegate get_topNeighbor_InjectedDelegateField;

	private static readonly get_bottomNeighbor_InjectedDelegate get_bottomNeighbor_InjectedDelegateField;

	private static readonly get_renderingLayerMask_InjectedDelegate get_renderingLayerMask_InjectedDelegateField;

	private static readonly set_renderingLayerMask_InjectedDelegate set_renderingLayerMask_InjectedDelegateField;

	public unsafe TerrainData terrainData
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1271977, RefRangeEnd = 1271982, XrefRangeStart = 1271969, XrefRangeEnd = 1271977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainData>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_terrainData_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe bool allowAutoConnect
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271987, RefRangeEnd = 1271988, XrefRangeStart = 1271982, XrefRangeEnd = 1271987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_allowAutoConnect_Injected(intPtr, value);
		}
	}

	public unsafe int groupingID
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271993, RefRangeEnd = 1271995, XrefRangeStart = 1271988, XrefRangeEnd = 1271993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			set_groupingID_Injected(intPtr, value);
		}
	}

	public unsafe static Il2CppReferenceArray<Terrain> activeTerrains
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272012, XrefRangeEnd = 1272014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr2) : null;
		}
	}

	public float treeDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeDistance_Injected(intPtr, value);
		}
	}

	public float treeBillboardDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeBillboardDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeBillboardDistance_Injected(intPtr, value);
		}
	}

	public float treeCrossFadeLength
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeCrossFadeLength_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeCrossFadeLength_Injected(intPtr, value);
		}
	}

	public int treeMaximumFullLODCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeMaximumFullLODCount_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeMaximumFullLODCount_Injected(intPtr, value);
		}
	}

	public float detailObjectDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailObjectDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detailObjectDistance_Injected(intPtr, value);
		}
	}

	public float detailObjectDensity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailObjectDensity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detailObjectDensity_Injected(intPtr, value);
		}
	}

	public float heightmapPixelError
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_heightmapPixelError_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_heightmapPixelError_Injected(intPtr, value);
		}
	}

	public int heightmapMaximumLOD
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_heightmapMaximumLOD_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_heightmapMaximumLOD_Injected(intPtr, value);
		}
	}

	public int heightmapMinimumLODSimplification
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_heightmapMinimumLODSimplification_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_heightmapMinimumLODSimplification_Injected(intPtr, value);
		}
	}

	public float basemapDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_basemapDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_basemapDistance_Injected(intPtr, value);
		}
	}

	public int lightmapIndex
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lightmapIndex_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lightmapIndex_Injected(intPtr, value);
		}
	}

	public int realtimeLightmapIndex
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_realtimeLightmapIndex_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_realtimeLightmapIndex_Injected(intPtr, value);
		}
	}

	public Vector4 lightmapScaleOffset
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_lightmapScaleOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lightmapScaleOffset_Injected(intPtr, ref value);
		}
	}

	public Vector4 realtimeLightmapScaleOffset
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_realtimeLightmapScaleOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_realtimeLightmapScaleOffset_Injected(intPtr, ref value);
		}
	}

	public bool freeUnusedRenderingResources
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_freeUnusedRenderingResources_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_freeUnusedRenderingResources_Injected(intPtr, value);
		}
	}

	public bool keepUnusedRenderingResources
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_keepUnusedRenderingResources_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_keepUnusedRenderingResources_Injected(intPtr, value);
		}
	}

	public ShadowCastingMode shadowCastingMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shadowCastingMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowCastingMode_Injected(intPtr, value);
		}
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reflectionProbeUsage_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reflectionProbeUsage_Injected(intPtr, value);
		}
	}

	public Material materialTemplate
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_materialTemplate_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_materialTemplate_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public bool drawHeightmap
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drawHeightmap_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drawHeightmap_Injected(intPtr, value);
		}
	}

	public bool drawInstanced
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drawInstanced_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drawInstanced_Injected(intPtr, value);
		}
	}

	public bool enableHeightmapRayTracing
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableHeightmapRayTracing_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableHeightmapRayTracing_Injected(intPtr, value);
		}
	}

	public RenderTexture normalmapTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<RenderTexture>(get_normalmapTexture_Injected(intPtr));
		}
	}

	public bool drawTreesAndFoliage
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drawTreesAndFoliage_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drawTreesAndFoliage_Injected(intPtr, value);
		}
	}

	public Vector3 patchBoundsMultiplier
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_patchBoundsMultiplier_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_patchBoundsMultiplier_Injected(intPtr, ref value);
		}
	}

	public float treeLODBiasMultiplier
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeLODBiasMultiplier_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeLODBiasMultiplier_Injected(intPtr, value);
		}
	}

	public bool collectDetailPatches
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_collectDetailPatches_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_collectDetailPatches_Injected(intPtr, value);
		}
	}

	public bool ignoreQualitySettings
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ignoreQualitySettings_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_ignoreQualitySettings_Injected(intPtr, value);
		}
	}

	public TerrainRenderFlags editorRenderFlags
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_editorRenderFlags_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_editorRenderFlags_Injected(intPtr, value);
		}
	}

	public TreeMotionVectorModeOverride treeMotionVectorModeOverride
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeMotionVectorModeOverride_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treeMotionVectorModeOverride_Injected(intPtr, value);
		}
	}

	public bool preserveTreePrototypeLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_preserveTreePrototypeLayers_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_preserveTreePrototypeLayers_Injected(intPtr, value);
		}
	}

	public static GraphicsFormat heightmapFormat => get_heightmapFormatDelegateField();

	public static TextureFormat heightmapTextureFormat => GraphicsFormatUtility.GetTextureFormat(heightmapFormat);

	public static RenderTextureFormat heightmapRenderTextureFormat => GraphicsFormatUtility.GetRenderTextureFormat(heightmapFormat);

	public static GraphicsFormat normalmapFormat => get_normalmapFormatDelegateField();

	public static TextureFormat normalmapTextureFormat => GraphicsFormatUtility.GetTextureFormat(normalmapFormat);

	public static RenderTextureFormat normalmapRenderTextureFormat => GraphicsFormatUtility.GetRenderTextureFormat(normalmapFormat);

	public static GraphicsFormat holesFormat => get_holesFormatDelegateField();

	public static RenderTextureFormat holesRenderTextureFormat => GraphicsFormatUtility.GetRenderTextureFormat(holesFormat);

	public static GraphicsFormat compressedHolesFormat => get_compressedHolesFormatDelegateField();

	public static TextureFormat compressedHolesTextureFormat => GraphicsFormatUtility.GetTextureFormat(compressedHolesFormat);

	public static Terrain activeTerrain => Unmarshal.UnmarshalUnityObject<Terrain>(get_activeTerrain_Injected());

	public Terrain leftNeighbor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Terrain>(get_leftNeighbor_Injected(intPtr));
		}
	}

	public Terrain rightNeighbor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Terrain>(get_rightNeighbor_Injected(intPtr));
		}
	}

	public Terrain topNeighbor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Terrain>(get_topNeighbor_Injected(intPtr));
		}
	}

	public Terrain bottomNeighbor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Terrain>(get_bottomNeighbor_Injected(intPtr));
		}
	}

	public uint renderingLayerMask
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
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderingLayerMask_Injected(intPtr, value);
		}
	}

	public float splatmapDistance
	{
		get
		{
			return basemapDistance;
		}
		set
		{
			basemapDistance = value;
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
			shadowCastingMode = (value ? ShadowCastingMode.TwoSided : ShadowCastingMode.Off);
		}
	}

	public MaterialType materialType
	{
		get
		{
			return MaterialType.Custom;
		}
		set
		{
		}
	}

	public Color legacySpecular
	{
		get
		{
			return Color.gray;
		}
		set
		{
		}
	}

	public float legacyShininess
	{
		get
		{
			return 5f / 64f;
		}
		set
		{
		}
	}

	static Terrain()
	{
		Il2CppClassPointerStore<Terrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "Terrain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Terrain>.NativeClassPtr);
		NativeMethodInfoPtr_get_terrainData_Public_get_TerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_allowAutoConnect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_get_groupingID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_get_activeTerrains_Public_Static_get_Il2CppReferenceArray_1_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_get_terrainData_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_allowAutoConnect_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_groupingID_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_SetNeighbors_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Terrain>.NativeClassPtr, 100663306);
		get_heightmapFormatDelegateField = IL2CPP.ResolveICall<get_heightmapFormatDelegate>("UnityEngine.Terrain::get_heightmapFormat");
		get_normalmapFormatDelegateField = IL2CPP.ResolveICall<get_normalmapFormatDelegate>("UnityEngine.Terrain::get_normalmapFormat");
		get_holesFormatDelegateField = IL2CPP.ResolveICall<get_holesFormatDelegate>("UnityEngine.Terrain::get_holesFormat");
		get_compressedHolesFormatDelegateField = IL2CPP.ResolveICall<get_compressedHolesFormatDelegate>("UnityEngine.Terrain::get_compressedHolesFormat");
		SetConnectivityDirtyDelegateField = IL2CPP.ResolveICall<SetConnectivityDirtyDelegate>("UnityEngine.Terrain::SetConnectivityDirty");
		set_terrainData_InjectedDelegateField = IL2CPP.ResolveICall<set_terrainData_InjectedDelegate>("UnityEngine.Terrain::set_terrainData_Injected");
		get_treeDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_treeDistance_InjectedDelegate>("UnityEngine.Terrain::get_treeDistance_Injected");
		set_treeDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_treeDistance_InjectedDelegate>("UnityEngine.Terrain::set_treeDistance_Injected");
		get_treeBillboardDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_treeBillboardDistance_InjectedDelegate>("UnityEngine.Terrain::get_treeBillboardDistance_Injected");
		set_treeBillboardDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_treeBillboardDistance_InjectedDelegate>("UnityEngine.Terrain::set_treeBillboardDistance_Injected");
		get_treeCrossFadeLength_InjectedDelegateField = IL2CPP.ResolveICall<get_treeCrossFadeLength_InjectedDelegate>("UnityEngine.Terrain::get_treeCrossFadeLength_Injected");
		set_treeCrossFadeLength_InjectedDelegateField = IL2CPP.ResolveICall<set_treeCrossFadeLength_InjectedDelegate>("UnityEngine.Terrain::set_treeCrossFadeLength_Injected");
		get_treeMaximumFullLODCount_InjectedDelegateField = IL2CPP.ResolveICall<get_treeMaximumFullLODCount_InjectedDelegate>("UnityEngine.Terrain::get_treeMaximumFullLODCount_Injected");
		set_treeMaximumFullLODCount_InjectedDelegateField = IL2CPP.ResolveICall<set_treeMaximumFullLODCount_InjectedDelegate>("UnityEngine.Terrain::set_treeMaximumFullLODCount_Injected");
		get_detailObjectDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_detailObjectDistance_InjectedDelegate>("UnityEngine.Terrain::get_detailObjectDistance_Injected");
		set_detailObjectDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_detailObjectDistance_InjectedDelegate>("UnityEngine.Terrain::set_detailObjectDistance_Injected");
		get_detailObjectDensity_InjectedDelegateField = IL2CPP.ResolveICall<get_detailObjectDensity_InjectedDelegate>("UnityEngine.Terrain::get_detailObjectDensity_Injected");
		set_detailObjectDensity_InjectedDelegateField = IL2CPP.ResolveICall<set_detailObjectDensity_InjectedDelegate>("UnityEngine.Terrain::set_detailObjectDensity_Injected");
		get_heightmapPixelError_InjectedDelegateField = IL2CPP.ResolveICall<get_heightmapPixelError_InjectedDelegate>("UnityEngine.Terrain::get_heightmapPixelError_Injected");
		set_heightmapPixelError_InjectedDelegateField = IL2CPP.ResolveICall<set_heightmapPixelError_InjectedDelegate>("UnityEngine.Terrain::set_heightmapPixelError_Injected");
		get_heightmapMaximumLOD_InjectedDelegateField = IL2CPP.ResolveICall<get_heightmapMaximumLOD_InjectedDelegate>("UnityEngine.Terrain::get_heightmapMaximumLOD_Injected");
		set_heightmapMaximumLOD_InjectedDelegateField = IL2CPP.ResolveICall<set_heightmapMaximumLOD_InjectedDelegate>("UnityEngine.Terrain::set_heightmapMaximumLOD_Injected");
		get_heightmapMinimumLODSimplification_InjectedDelegateField = IL2CPP.ResolveICall<get_heightmapMinimumLODSimplification_InjectedDelegate>("UnityEngine.Terrain::get_heightmapMinimumLODSimplification_Injected");
		set_heightmapMinimumLODSimplification_InjectedDelegateField = IL2CPP.ResolveICall<set_heightmapMinimumLODSimplification_InjectedDelegate>("UnityEngine.Terrain::set_heightmapMinimumLODSimplification_Injected");
		get_basemapDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_basemapDistance_InjectedDelegate>("UnityEngine.Terrain::get_basemapDistance_Injected");
		set_basemapDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_basemapDistance_InjectedDelegate>("UnityEngine.Terrain::set_basemapDistance_Injected");
		get_lightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<get_lightmapIndex_InjectedDelegate>("UnityEngine.Terrain::get_lightmapIndex_Injected");
		set_lightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<set_lightmapIndex_InjectedDelegate>("UnityEngine.Terrain::set_lightmapIndex_Injected");
		get_realtimeLightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<get_realtimeLightmapIndex_InjectedDelegate>("UnityEngine.Terrain::get_realtimeLightmapIndex_Injected");
		set_realtimeLightmapIndex_InjectedDelegateField = IL2CPP.ResolveICall<set_realtimeLightmapIndex_InjectedDelegate>("UnityEngine.Terrain::set_realtimeLightmapIndex_Injected");
		get_lightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_lightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::get_lightmapScaleOffset_Injected");
		set_lightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_lightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::set_lightmapScaleOffset_Injected");
		get_realtimeLightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_realtimeLightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::get_realtimeLightmapScaleOffset_Injected");
		set_realtimeLightmapScaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_realtimeLightmapScaleOffset_InjectedDelegate>("UnityEngine.Terrain::set_realtimeLightmapScaleOffset_Injected");
		get_freeUnusedRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<get_freeUnusedRenderingResources_InjectedDelegate>("UnityEngine.Terrain::get_freeUnusedRenderingResources_Injected");
		set_freeUnusedRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<set_freeUnusedRenderingResources_InjectedDelegate>("UnityEngine.Terrain::set_freeUnusedRenderingResources_Injected");
		get_keepUnusedRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<get_keepUnusedRenderingResources_InjectedDelegate>("UnityEngine.Terrain::get_keepUnusedRenderingResources_Injected");
		set_keepUnusedRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<set_keepUnusedRenderingResources_InjectedDelegate>("UnityEngine.Terrain::set_keepUnusedRenderingResources_Injected");
		GetKeepUnusedCameraRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<GetKeepUnusedCameraRenderingResources_InjectedDelegate>("UnityEngine.Terrain::GetKeepUnusedCameraRenderingResources_Injected");
		SetKeepUnusedCameraRenderingResources_InjectedDelegateField = IL2CPP.ResolveICall<SetKeepUnusedCameraRenderingResources_InjectedDelegate>("UnityEngine.Terrain::SetKeepUnusedCameraRenderingResources_Injected");
		get_shadowCastingMode_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowCastingMode_InjectedDelegate>("UnityEngine.Terrain::get_shadowCastingMode_Injected");
		set_shadowCastingMode_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowCastingMode_InjectedDelegate>("UnityEngine.Terrain::set_shadowCastingMode_Injected");
		get_reflectionProbeUsage_InjectedDelegateField = IL2CPP.ResolveICall<get_reflectionProbeUsage_InjectedDelegate>("UnityEngine.Terrain::get_reflectionProbeUsage_Injected");
		set_reflectionProbeUsage_InjectedDelegateField = IL2CPP.ResolveICall<set_reflectionProbeUsage_InjectedDelegate>("UnityEngine.Terrain::set_reflectionProbeUsage_Injected");
		get_materialTemplate_InjectedDelegateField = IL2CPP.ResolveICall<get_materialTemplate_InjectedDelegate>("UnityEngine.Terrain::get_materialTemplate_Injected");
		set_materialTemplate_InjectedDelegateField = IL2CPP.ResolveICall<set_materialTemplate_InjectedDelegate>("UnityEngine.Terrain::set_materialTemplate_Injected");
		get_drawHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<get_drawHeightmap_InjectedDelegate>("UnityEngine.Terrain::get_drawHeightmap_Injected");
		set_drawHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<set_drawHeightmap_InjectedDelegate>("UnityEngine.Terrain::set_drawHeightmap_Injected");
		set_allowAutoConnect_InjectedDelegateField = IL2CPP.ResolveICall<set_allowAutoConnect_InjectedDelegate>("UnityEngine.Terrain::set_allowAutoConnect_Injected");
		set_groupingID_InjectedDelegateField = IL2CPP.ResolveICall<set_groupingID_InjectedDelegate>("UnityEngine.Terrain::set_groupingID_Injected");
		get_drawInstanced_InjectedDelegateField = IL2CPP.ResolveICall<get_drawInstanced_InjectedDelegate>("UnityEngine.Terrain::get_drawInstanced_Injected");
		set_drawInstanced_InjectedDelegateField = IL2CPP.ResolveICall<set_drawInstanced_InjectedDelegate>("UnityEngine.Terrain::set_drawInstanced_Injected");
		get_enableHeightmapRayTracing_InjectedDelegateField = IL2CPP.ResolveICall<get_enableHeightmapRayTracing_InjectedDelegate>("UnityEngine.Terrain::get_enableHeightmapRayTracing_Injected");
		set_enableHeightmapRayTracing_InjectedDelegateField = IL2CPP.ResolveICall<set_enableHeightmapRayTracing_InjectedDelegate>("UnityEngine.Terrain::set_enableHeightmapRayTracing_Injected");
		get_normalmapTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_normalmapTexture_InjectedDelegate>("UnityEngine.Terrain::get_normalmapTexture_Injected");
		get_drawTreesAndFoliage_InjectedDelegateField = IL2CPP.ResolveICall<get_drawTreesAndFoliage_InjectedDelegate>("UnityEngine.Terrain::get_drawTreesAndFoliage_Injected");
		set_drawTreesAndFoliage_InjectedDelegateField = IL2CPP.ResolveICall<set_drawTreesAndFoliage_InjectedDelegate>("UnityEngine.Terrain::set_drawTreesAndFoliage_Injected");
		get_patchBoundsMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<get_patchBoundsMultiplier_InjectedDelegate>("UnityEngine.Terrain::get_patchBoundsMultiplier_Injected");
		set_patchBoundsMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<set_patchBoundsMultiplier_InjectedDelegate>("UnityEngine.Terrain::set_patchBoundsMultiplier_Injected");
		SampleHeight_InjectedDelegateField = IL2CPP.ResolveICall<SampleHeight_InjectedDelegate>("UnityEngine.Terrain::SampleHeight_Injected");
		get_treeLODBiasMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<get_treeLODBiasMultiplier_InjectedDelegate>("UnityEngine.Terrain::get_treeLODBiasMultiplier_Injected");
		set_treeLODBiasMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<set_treeLODBiasMultiplier_InjectedDelegate>("UnityEngine.Terrain::set_treeLODBiasMultiplier_Injected");
		get_collectDetailPatches_InjectedDelegateField = IL2CPP.ResolveICall<get_collectDetailPatches_InjectedDelegate>("UnityEngine.Terrain::get_collectDetailPatches_Injected");
		set_collectDetailPatches_InjectedDelegateField = IL2CPP.ResolveICall<set_collectDetailPatches_InjectedDelegate>("UnityEngine.Terrain::set_collectDetailPatches_Injected");
		get_ignoreQualitySettings_InjectedDelegateField = IL2CPP.ResolveICall<get_ignoreQualitySettings_InjectedDelegate>("UnityEngine.Terrain::get_ignoreQualitySettings_Injected");
		set_ignoreQualitySettings_InjectedDelegateField = IL2CPP.ResolveICall<set_ignoreQualitySettings_InjectedDelegate>("UnityEngine.Terrain::set_ignoreQualitySettings_Injected");
		get_editorRenderFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_editorRenderFlags_InjectedDelegate>("UnityEngine.Terrain::get_editorRenderFlags_Injected");
		set_editorRenderFlags_InjectedDelegateField = IL2CPP.ResolveICall<set_editorRenderFlags_InjectedDelegate>("UnityEngine.Terrain::set_editorRenderFlags_Injected");
		GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<GetPosition_InjectedDelegate>("UnityEngine.Terrain::GetPosition_Injected");
		Flush_InjectedDelegateField = IL2CPP.ResolveICall<Flush_InjectedDelegate>("UnityEngine.Terrain::Flush_Injected");
		RemoveTrees_InjectedDelegateField = IL2CPP.ResolveICall<RemoveTrees_InjectedDelegate>("UnityEngine.Terrain::RemoveTrees_Injected");
		SetSplatMaterialPropertyBlock_InjectedDelegateField = IL2CPP.ResolveICall<SetSplatMaterialPropertyBlock_InjectedDelegate>("UnityEngine.Terrain::SetSplatMaterialPropertyBlock_Injected");
		Internal_GetSplatMaterialPropertyBlock_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetSplatMaterialPropertyBlock_InjectedDelegate>("UnityEngine.Terrain::Internal_GetSplatMaterialPropertyBlock_Injected");
		get_treeMotionVectorModeOverride_InjectedDelegateField = IL2CPP.ResolveICall<get_treeMotionVectorModeOverride_InjectedDelegate>("UnityEngine.Terrain::get_treeMotionVectorModeOverride_Injected");
		set_treeMotionVectorModeOverride_InjectedDelegateField = IL2CPP.ResolveICall<set_treeMotionVectorModeOverride_InjectedDelegate>("UnityEngine.Terrain::set_treeMotionVectorModeOverride_Injected");
		get_preserveTreePrototypeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_preserveTreePrototypeLayers_InjectedDelegate>("UnityEngine.Terrain::get_preserveTreePrototypeLayers_Injected");
		set_preserveTreePrototypeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_preserveTreePrototypeLayers_InjectedDelegate>("UnityEngine.Terrain::set_preserveTreePrototypeLayers_Injected");
		get_activeTerrain_InjectedDelegateField = IL2CPP.ResolveICall<get_activeTerrain_InjectedDelegate>("UnityEngine.Terrain::get_activeTerrain_Injected");
		Internal_FillActiveTerrainList_InjectedDelegateField = IL2CPP.ResolveICall<Internal_FillActiveTerrainList_InjectedDelegate>("UnityEngine.Terrain::Internal_FillActiveTerrainList_Injected");
		CreateTerrainGameObject_InjectedDelegateField = IL2CPP.ResolveICall<CreateTerrainGameObject_InjectedDelegate>("UnityEngine.Terrain::CreateTerrainGameObject_Injected");
		get_leftNeighbor_InjectedDelegateField = IL2CPP.ResolveICall<get_leftNeighbor_InjectedDelegate>("UnityEngine.Terrain::get_leftNeighbor_Injected");
		get_rightNeighbor_InjectedDelegateField = IL2CPP.ResolveICall<get_rightNeighbor_InjectedDelegate>("UnityEngine.Terrain::get_rightNeighbor_Injected");
		get_topNeighbor_InjectedDelegateField = IL2CPP.ResolveICall<get_topNeighbor_InjectedDelegate>("UnityEngine.Terrain::get_topNeighbor_Injected");
		get_bottomNeighbor_InjectedDelegateField = IL2CPP.ResolveICall<get_bottomNeighbor_InjectedDelegate>("UnityEngine.Terrain::get_bottomNeighbor_Injected");
		get_renderingLayerMask_InjectedDelegateField = IL2CPP.ResolveICall<get_renderingLayerMask_InjectedDelegate>("UnityEngine.Terrain::get_renderingLayerMask_Injected");
		set_renderingLayerMask_InjectedDelegateField = IL2CPP.ResolveICall<set_renderingLayerMask_InjectedDelegate>("UnityEngine.Terrain::set_renderingLayerMask_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271995, XrefRangeEnd = 1272012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)top);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottom);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNeighbors_Public_Void_Terrain_Terrain_Terrain_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Terrain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Terrain>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272014, XrefRangeEnd = 1272016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_terrainData_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_terrainData_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272016, XrefRangeEnd = 1272018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_allowAutoConnect_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowAutoConnect_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272018, XrefRangeEnd = 1272020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_groupingID_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_groupingID_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1272022, RefRangeEnd = 1272025, XrefRangeStart = 1272020, XrefRangeEnd = 1272022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetNeighbors_Injected(System.IntPtr _unity_self, System.IntPtr left, System.IntPtr top, System.IntPtr right, System.IntPtr bottom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNeighbors_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Terrain(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool GetKeepUnusedCameraRenderingResources(int cameraInstanceID)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetKeepUnusedCameraRenderingResources_Injected(intPtr, cameraInstanceID);
	}

	public void SetKeepUnusedCameraRenderingResources(int cameraInstanceID, bool keepUnused)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetKeepUnusedCameraRenderingResources_Injected(intPtr, cameraInstanceID, keepUnused);
	}

	public float SampleHeight(Vector3 worldPosition)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SampleHeight_Injected(intPtr, ref worldPosition);
	}

	public Vector3 GetPosition()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPosition_Injected(intPtr, out var ret);
		return ret;
	}

	public void Flush()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Flush_Injected(intPtr);
	}

	public void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveTrees_Injected(intPtr, ref position, radius, prototypeIndex);
	}

	public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetSplatMaterialPropertyBlock_Injected(intPtr, (properties == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties));
	}

	public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
	{
		if (dest == null)
		{
			throw new Il2CppSystem.ArgumentNullException("dest");
		}
		Internal_GetSplatMaterialPropertyBlock(dest);
	}

	public void Internal_GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_GetSplatMaterialPropertyBlock_Injected(intPtr, (dest == null) ? ((System.IntPtr)0) : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(dest));
	}

	public static void SetConnectivityDirty()
	{
		SetConnectivityDirtyDelegateField();
	}

	public static void GetActiveTerrains(List<Terrain> terrainList)
	{
		Internal_FillActiveTerrainList(terrainList);
	}

	public static void Internal_FillActiveTerrainList(Il2CppSystem.Object terrainList)
	{
		if (terrainList == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(terrainList, "terrainList");
		}
		Internal_FillActiveTerrainList_Injected(terrainList);
	}

	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain)
	{
		return Unmarshal.UnmarshalUnityObject<GameObject>(CreateTerrainGameObject_Injected(MarshalledUnityObject.Marshal(assignTerrain)));
	}

	public void ApplyDelayedHeightmapModification()
	{
		terrainData?.SyncHeightmap();
	}

	public static void set_terrainData_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_terrainData_InjectedDelegateField(_unity_self, value);
	}

	public static float get_treeDistance_Injected(System.IntPtr _unity_self)
	{
		return get_treeDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_treeDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_treeDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_treeBillboardDistance_Injected(System.IntPtr _unity_self)
	{
		return get_treeBillboardDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_treeBillboardDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_treeBillboardDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_treeCrossFadeLength_Injected(System.IntPtr _unity_self)
	{
		return get_treeCrossFadeLength_InjectedDelegateField(_unity_self);
	}

	public static void set_treeCrossFadeLength_Injected(System.IntPtr _unity_self, float value)
	{
		set_treeCrossFadeLength_InjectedDelegateField(_unity_self, value);
	}

	public static int get_treeMaximumFullLODCount_Injected(System.IntPtr _unity_self)
	{
		return get_treeMaximumFullLODCount_InjectedDelegateField(_unity_self);
	}

	public static void set_treeMaximumFullLODCount_Injected(System.IntPtr _unity_self, int value)
	{
		set_treeMaximumFullLODCount_InjectedDelegateField(_unity_self, value);
	}

	public static float get_detailObjectDistance_Injected(System.IntPtr _unity_self)
	{
		return get_detailObjectDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_detailObjectDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_detailObjectDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_detailObjectDensity_Injected(System.IntPtr _unity_self)
	{
		return get_detailObjectDensity_InjectedDelegateField(_unity_self);
	}

	public static void set_detailObjectDensity_Injected(System.IntPtr _unity_self, float value)
	{
		set_detailObjectDensity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_heightmapPixelError_Injected(System.IntPtr _unity_self)
	{
		return get_heightmapPixelError_InjectedDelegateField(_unity_self);
	}

	public static void set_heightmapPixelError_Injected(System.IntPtr _unity_self, float value)
	{
		set_heightmapPixelError_InjectedDelegateField(_unity_self, value);
	}

	public static int get_heightmapMaximumLOD_Injected(System.IntPtr _unity_self)
	{
		return get_heightmapMaximumLOD_InjectedDelegateField(_unity_self);
	}

	public static void set_heightmapMaximumLOD_Injected(System.IntPtr _unity_self, int value)
	{
		set_heightmapMaximumLOD_InjectedDelegateField(_unity_self, value);
	}

	public static int get_heightmapMinimumLODSimplification_Injected(System.IntPtr _unity_self)
	{
		return get_heightmapMinimumLODSimplification_InjectedDelegateField(_unity_self);
	}

	public static void set_heightmapMinimumLODSimplification_Injected(System.IntPtr _unity_self, int value)
	{
		set_heightmapMinimumLODSimplification_InjectedDelegateField(_unity_self, value);
	}

	public static float get_basemapDistance_Injected(System.IntPtr _unity_self)
	{
		return get_basemapDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_basemapDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_basemapDistance_InjectedDelegateField(_unity_self, value);
	}

	public static int get_lightmapIndex_Injected(System.IntPtr _unity_self)
	{
		return get_lightmapIndex_InjectedDelegateField(_unity_self);
	}

	public static void set_lightmapIndex_Injected(System.IntPtr _unity_self, int value)
	{
		set_lightmapIndex_InjectedDelegateField(_unity_self, value);
	}

	public static int get_realtimeLightmapIndex_Injected(System.IntPtr _unity_self)
	{
		return get_realtimeLightmapIndex_InjectedDelegateField(_unity_self);
	}

	public static void set_realtimeLightmapIndex_Injected(System.IntPtr _unity_self, int value)
	{
		set_realtimeLightmapIndex_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_lightmapScaleOffset_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		get_lightmapScaleOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_lightmapScaleOffset_Injected(System.IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_lightmapScaleOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_realtimeLightmapScaleOffset_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		get_realtimeLightmapScaleOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_realtimeLightmapScaleOffset_Injected(System.IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_realtimeLightmapScaleOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_freeUnusedRenderingResources_Injected(System.IntPtr _unity_self)
	{
		return get_freeUnusedRenderingResources_InjectedDelegateField(_unity_self);
	}

	public static void set_freeUnusedRenderingResources_Injected(System.IntPtr _unity_self, bool value)
	{
		set_freeUnusedRenderingResources_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_keepUnusedRenderingResources_Injected(System.IntPtr _unity_self)
	{
		return get_keepUnusedRenderingResources_InjectedDelegateField(_unity_self);
	}

	public static void set_keepUnusedRenderingResources_Injected(System.IntPtr _unity_self, bool value)
	{
		set_keepUnusedRenderingResources_InjectedDelegateField(_unity_self, value);
	}

	public static bool GetKeepUnusedCameraRenderingResources_Injected(System.IntPtr _unity_self, int cameraInstanceID)
	{
		return GetKeepUnusedCameraRenderingResources_InjectedDelegateField(_unity_self, cameraInstanceID);
	}

	public static void SetKeepUnusedCameraRenderingResources_Injected(System.IntPtr _unity_self, int cameraInstanceID, bool keepUnused)
	{
		SetKeepUnusedCameraRenderingResources_InjectedDelegateField(_unity_self, cameraInstanceID, keepUnused);
	}

	public static ShadowCastingMode get_shadowCastingMode_Injected(System.IntPtr _unity_self)
	{
		return get_shadowCastingMode_InjectedDelegateField(_unity_self);
	}

	public static void set_shadowCastingMode_Injected(System.IntPtr _unity_self, ShadowCastingMode value)
	{
		set_shadowCastingMode_InjectedDelegateField(_unity_self, value);
	}

	public static ReflectionProbeUsage get_reflectionProbeUsage_Injected(System.IntPtr _unity_self)
	{
		return get_reflectionProbeUsage_InjectedDelegateField(_unity_self);
	}

	public static void set_reflectionProbeUsage_Injected(System.IntPtr _unity_self, ReflectionProbeUsage value)
	{
		set_reflectionProbeUsage_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_materialTemplate_Injected(System.IntPtr _unity_self)
	{
		return get_materialTemplate_InjectedDelegateField(_unity_self);
	}

	public static void set_materialTemplate_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_materialTemplate_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_drawHeightmap_Injected(System.IntPtr _unity_self)
	{
		return get_drawHeightmap_InjectedDelegateField(_unity_self);
	}

	public static void set_drawHeightmap_Injected(System.IntPtr _unity_self, bool value)
	{
		set_drawHeightmap_InjectedDelegateField(_unity_self, value);
	}

	public static void set_allowAutoConnect_Injected(System.IntPtr _unity_self, bool value)
	{
		set_allowAutoConnect_InjectedDelegateField(_unity_self, value);
	}

	public static void set_groupingID_Injected(System.IntPtr _unity_self, int value)
	{
		set_groupingID_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_drawInstanced_Injected(System.IntPtr _unity_self)
	{
		return get_drawInstanced_InjectedDelegateField(_unity_self);
	}

	public static void set_drawInstanced_Injected(System.IntPtr _unity_self, bool value)
	{
		set_drawInstanced_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableHeightmapRayTracing_Injected(System.IntPtr _unity_self)
	{
		return get_enableHeightmapRayTracing_InjectedDelegateField(_unity_self);
	}

	public static void set_enableHeightmapRayTracing_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enableHeightmapRayTracing_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_normalmapTexture_Injected(System.IntPtr _unity_self)
	{
		return get_normalmapTexture_InjectedDelegateField(_unity_self);
	}

	public static bool get_drawTreesAndFoliage_Injected(System.IntPtr _unity_self)
	{
		return get_drawTreesAndFoliage_InjectedDelegateField(_unity_self);
	}

	public static void set_drawTreesAndFoliage_Injected(System.IntPtr _unity_self, bool value)
	{
		set_drawTreesAndFoliage_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_patchBoundsMultiplier_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_patchBoundsMultiplier_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_patchBoundsMultiplier_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_patchBoundsMultiplier_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static float SampleHeight_Injected(System.IntPtr _unity_self, [In] ref Vector3 worldPosition)
	{
		return SampleHeight_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref worldPosition));
	}

	public static float get_treeLODBiasMultiplier_Injected(System.IntPtr _unity_self)
	{
		return get_treeLODBiasMultiplier_InjectedDelegateField(_unity_self);
	}

	public static void set_treeLODBiasMultiplier_Injected(System.IntPtr _unity_self, float value)
	{
		set_treeLODBiasMultiplier_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_collectDetailPatches_Injected(System.IntPtr _unity_self)
	{
		return get_collectDetailPatches_InjectedDelegateField(_unity_self);
	}

	public static void set_collectDetailPatches_Injected(System.IntPtr _unity_self, bool value)
	{
		set_collectDetailPatches_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_ignoreQualitySettings_Injected(System.IntPtr _unity_self)
	{
		return get_ignoreQualitySettings_InjectedDelegateField(_unity_self);
	}

	public static void set_ignoreQualitySettings_Injected(System.IntPtr _unity_self, bool value)
	{
		set_ignoreQualitySettings_InjectedDelegateField(_unity_self, value);
	}

	public static TerrainRenderFlags get_editorRenderFlags_Injected(System.IntPtr _unity_self)
	{
		return get_editorRenderFlags_InjectedDelegateField(_unity_self);
	}

	public static void set_editorRenderFlags_Injected(System.IntPtr _unity_self, TerrainRenderFlags value)
	{
		set_editorRenderFlags_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetPosition_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		GetPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void Flush_Injected(System.IntPtr _unity_self)
	{
		Flush_InjectedDelegateField(_unity_self);
	}

	public unsafe static void RemoveTrees_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float radius, int prototypeIndex)
	{
		RemoveTrees_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), radius, prototypeIndex);
	}

	public static void SetSplatMaterialPropertyBlock_Injected(System.IntPtr _unity_self, System.IntPtr properties)
	{
		SetSplatMaterialPropertyBlock_InjectedDelegateField(_unity_self, properties);
	}

	public static void Internal_GetSplatMaterialPropertyBlock_Injected(System.IntPtr _unity_self, System.IntPtr dest)
	{
		Internal_GetSplatMaterialPropertyBlock_InjectedDelegateField(_unity_self, dest);
	}

	public static TreeMotionVectorModeOverride get_treeMotionVectorModeOverride_Injected(System.IntPtr _unity_self)
	{
		return get_treeMotionVectorModeOverride_InjectedDelegateField(_unity_self);
	}

	public static void set_treeMotionVectorModeOverride_Injected(System.IntPtr _unity_self, TreeMotionVectorModeOverride value)
	{
		set_treeMotionVectorModeOverride_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_preserveTreePrototypeLayers_Injected(System.IntPtr _unity_self)
	{
		return get_preserveTreePrototypeLayers_InjectedDelegateField(_unity_self);
	}

	public static void set_preserveTreePrototypeLayers_Injected(System.IntPtr _unity_self, bool value)
	{
		set_preserveTreePrototypeLayers_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_activeTerrain_Injected()
	{
		return get_activeTerrain_InjectedDelegateField();
	}

	public static void Internal_FillActiveTerrainList_Injected(Il2CppSystem.Object terrainList)
	{
		Internal_FillActiveTerrainList_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainList));
	}

	public static System.IntPtr CreateTerrainGameObject_Injected(System.IntPtr assignTerrain)
	{
		return CreateTerrainGameObject_InjectedDelegateField(assignTerrain);
	}

	public static System.IntPtr get_leftNeighbor_Injected(System.IntPtr _unity_self)
	{
		return get_leftNeighbor_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_rightNeighbor_Injected(System.IntPtr _unity_self)
	{
		return get_rightNeighbor_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_topNeighbor_Injected(System.IntPtr _unity_self)
	{
		return get_topNeighbor_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_bottomNeighbor_Injected(System.IntPtr _unity_self)
	{
		return get_bottomNeighbor_InjectedDelegateField(_unity_self);
	}

	public static uint get_renderingLayerMask_Injected(System.IntPtr _unity_self)
	{
		return get_renderingLayerMask_InjectedDelegateField(_unity_self);
	}

	public static void set_renderingLayerMask_Injected(System.IntPtr _unity_self, uint value)
	{
		set_renderingLayerMask_InjectedDelegateField(_unity_self, value);
	}
}
