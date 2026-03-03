using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class TerrainData : Object
{
	[OriginalName("UnityEngine.TerrainModule.dll", "", "BoundaryValueType")]
	public enum BoundaryValueType
	{
		MaxHeightmapRes,
		MinDetailResPerPatch,
		MaxDetailResPerPatch,
		MaxDetailPatchCount,
		MaxCoveragePerRes,
		MinAlphamapRes,
		MaxAlphamapRes,
		MinBaseMapRes,
		MaxBaseMapRes
	}

	private delegate void Internal_CreateDelegate(System.IntPtr terrainData);

	private delegate int get_internalHeightmapResolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_internalHeightmapResolution_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_enableHolesTextureCompression_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enableHolesTextureCompression_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool IsHolesTextureCompressed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetHolesTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetCompressedHolesTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float GetHeight_InjectedDelegate(System.IntPtr _unity_self, int x, int y);

	private delegate float GetInterpolatedHeight_InjectedDelegate(System.IntPtr _unity_self, float x, float y);

	private delegate void Internal_GetInterpolatedHeights_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr results, int resultXDimension, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval);

	private delegate void Internal_SetHeights_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, System.IntPtr heights);

	private delegate void GetPatchMinMaxHeights_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void OverrideMinMaxPatchHeights_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr minMaxHeights);

	private delegate void GetMaximumHeightError_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void OverrideMaximumHeightError_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr maxError);

	private delegate void Internal_SetHeightsDelayLOD_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, System.IntPtr heights);

	private delegate void Internal_SetHoles_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, System.IntPtr holes);

	private delegate bool Internal_IsHole_InjectedDelegate(System.IntPtr _unity_self, int x, int y);

	private delegate void Internal_SetHolesDelayLOD_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, System.IntPtr holes);

	private delegate float GetSteepness_InjectedDelegate(System.IntPtr _unity_self, float x, float y);

	private delegate void GetInterpolatedNormal_InjectedDelegate(System.IntPtr _unity_self, float x, float y, [Out] System.IntPtr ret);

	private delegate int GetAdjustedSize_InjectedDelegate(System.IntPtr _unity_self, int size);

	private delegate float get_wavingGrassStrength_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_wavingGrassStrength_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_wavingGrassAmount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_wavingGrassAmount_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_wavingGrassSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_wavingGrassSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_wavingGrassTint_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_wavingGrassTint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate int get_detailWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_detailHeight_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_maxDetailScatterPerRes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Internal_SetDetailResolution_InjectedDelegate(System.IntPtr _unity_self, int patchCount, int resolutionPerPatch);

	private delegate void Internal_SetDetailScatterMode_InjectedDelegate(System.IntPtr _unity_self, DetailScatterMode scatterMode);

	private delegate int get_detailPatchCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_detailResolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_detailResolutionPerPatch_InjectedDelegate(System.IntPtr _unity_self);

	private delegate DetailScatterMode get_detailScatterMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetDirtyDetails_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void RefreshPrototypes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_detailPrototypes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_detailPrototypes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void GetSupportedLayers_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int totalWidth, int totalHeight, [Out] System.IntPtr ret);

	private delegate void ComputeDetailInstanceTransforms_InjectedDelegate(System.IntPtr _unity_self, int patchX, int patchY, int layer, float density, [Out] System.IntPtr bounds, [Out] System.IntPtr ret);

	private delegate float ComputeDetailCoverage_InjectedDelegate(System.IntPtr _unity_self, int detailPrototypeIndex);

	private delegate void Internal_SetDetailLayer_InjectedDelegate(System.IntPtr _unity_self, int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, System.IntPtr data);

	private delegate void Internal_GetTreeInstances_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void SetTreeInstances_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr instances, bool snapToHeightmap);

	private delegate int get_treeInstanceCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_treePrototypes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_treePrototypes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void RemoveTreePrototype_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate void RemoveDetailPrototype_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate bool NeedUpgradeScaledTreePrototypes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void UpgradeScaledTreePrototype_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_alphamapLayers_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_Internal_alphamapResolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_Internal_alphamapResolution_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_Internal_baseMapResolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_Internal_baseMapResolution_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void Internal_SetAlphamaps_InjectedDelegate(System.IntPtr _unity_self, int x, int y, int width, int height, System.IntPtr map);

	private delegate void SetBaseMapDirty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetAlphamapTexture_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate int get_alphamapTextureCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_splatPrototypes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_splatPrototypes_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_terrainLayers_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_terrainLayers_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int RemoveTrees_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float radius, int prototypeIndex);

	private delegate void Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr rect, int destX, int destY, TerrainHeightmapSyncControl syncControl);

	private delegate void Internal_DirtyHeightmapRegion_InjectedDelegate(System.IntPtr _unity_self, int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl);

	private delegate void SyncHeightmap_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Internal_CopyActiveRenderTextureToHoles_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr rect, int destX, int destY, bool allowDelayedCPUSync);

	private delegate void Internal_DirtyHolesRegion_InjectedDelegate(System.IntPtr _unity_self, int x, int y, int width, int height, bool allowDelayedCPUSync);

	private delegate void Internal_SyncHoles_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Internal_MarkAlphamapDirtyRegion_InjectedDelegate(System.IntPtr _unity_self, int alphamapIndex, int x, int y, int width, int height);

	private delegate void Internal_ClearAlphamapDirtyRegion_InjectedDelegate(System.IntPtr _unity_self, int alphamapIndex);

	private delegate void Internal_SyncAlphamaps_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TextureFormat get_atlasFormat_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumDetailPatchCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MinimumAlphamapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumAlphamapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MinimumBaseMapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumBaseMapResolution;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_heightmapTexture_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_heightmapScale_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_heightmapTexture_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_heightmapScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlphamapResolutionInternal_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_users_Injected_Private_Static_Il2CppReferenceArray_1_Terrain_IntPtr_0;

	public const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";

	public const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";

	public const string k_HeightmapPrefix = "GetHeightmap().";

	public const string k_DetailDatabasePrefix = "GetDetailDatabase().";

	public const string k_TreeDatabasePrefix = "GetTreeDatabase().";

	public const string k_SplatDatabasePrefix = "GetSplatDatabase().";

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField;

	private static readonly get_internalHeightmapResolution_InjectedDelegate get_internalHeightmapResolution_InjectedDelegateField;

	private static readonly set_internalHeightmapResolution_InjectedDelegate set_internalHeightmapResolution_InjectedDelegateField;

	private static readonly get_enableHolesTextureCompression_InjectedDelegate get_enableHolesTextureCompression_InjectedDelegateField;

	private static readonly set_enableHolesTextureCompression_InjectedDelegate set_enableHolesTextureCompression_InjectedDelegateField;

	private static readonly IsHolesTextureCompressed_InjectedDelegate IsHolesTextureCompressed_InjectedDelegateField;

	private static readonly GetHolesTexture_InjectedDelegate GetHolesTexture_InjectedDelegateField;

	private static readonly GetCompressedHolesTexture_InjectedDelegate GetCompressedHolesTexture_InjectedDelegateField;

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField;

	private static readonly GetHeight_InjectedDelegate GetHeight_InjectedDelegateField;

	private static readonly GetInterpolatedHeight_InjectedDelegate GetInterpolatedHeight_InjectedDelegateField;

	private static readonly Internal_GetInterpolatedHeights_InjectedDelegate Internal_GetInterpolatedHeights_InjectedDelegateField;

	private static readonly Internal_SetHeights_InjectedDelegate Internal_SetHeights_InjectedDelegateField;

	private static readonly GetPatchMinMaxHeights_InjectedDelegate GetPatchMinMaxHeights_InjectedDelegateField;

	private static readonly OverrideMinMaxPatchHeights_InjectedDelegate OverrideMinMaxPatchHeights_InjectedDelegateField;

	private static readonly GetMaximumHeightError_InjectedDelegate GetMaximumHeightError_InjectedDelegateField;

	private static readonly OverrideMaximumHeightError_InjectedDelegate OverrideMaximumHeightError_InjectedDelegateField;

	private static readonly Internal_SetHeightsDelayLOD_InjectedDelegate Internal_SetHeightsDelayLOD_InjectedDelegateField;

	private static readonly Internal_SetHoles_InjectedDelegate Internal_SetHoles_InjectedDelegateField;

	private static readonly Internal_IsHole_InjectedDelegate Internal_IsHole_InjectedDelegateField;

	private static readonly Internal_SetHolesDelayLOD_InjectedDelegate Internal_SetHolesDelayLOD_InjectedDelegateField;

	private static readonly GetSteepness_InjectedDelegate GetSteepness_InjectedDelegateField;

	private static readonly GetInterpolatedNormal_InjectedDelegate GetInterpolatedNormal_InjectedDelegateField;

	private static readonly GetAdjustedSize_InjectedDelegate GetAdjustedSize_InjectedDelegateField;

	private static readonly get_wavingGrassStrength_InjectedDelegate get_wavingGrassStrength_InjectedDelegateField;

	private static readonly set_wavingGrassStrength_InjectedDelegate set_wavingGrassStrength_InjectedDelegateField;

	private static readonly get_wavingGrassAmount_InjectedDelegate get_wavingGrassAmount_InjectedDelegateField;

	private static readonly set_wavingGrassAmount_InjectedDelegate set_wavingGrassAmount_InjectedDelegateField;

	private static readonly get_wavingGrassSpeed_InjectedDelegate get_wavingGrassSpeed_InjectedDelegateField;

	private static readonly set_wavingGrassSpeed_InjectedDelegate set_wavingGrassSpeed_InjectedDelegateField;

	private static readonly get_wavingGrassTint_InjectedDelegate get_wavingGrassTint_InjectedDelegateField;

	private static readonly set_wavingGrassTint_InjectedDelegate set_wavingGrassTint_InjectedDelegateField;

	private static readonly get_detailWidth_InjectedDelegate get_detailWidth_InjectedDelegateField;

	private static readonly get_detailHeight_InjectedDelegate get_detailHeight_InjectedDelegateField;

	private static readonly get_maxDetailScatterPerRes_InjectedDelegate get_maxDetailScatterPerRes_InjectedDelegateField;

	private static readonly Internal_SetDetailResolution_InjectedDelegate Internal_SetDetailResolution_InjectedDelegateField;

	private static readonly Internal_SetDetailScatterMode_InjectedDelegate Internal_SetDetailScatterMode_InjectedDelegateField;

	private static readonly get_detailPatchCount_InjectedDelegate get_detailPatchCount_InjectedDelegateField;

	private static readonly get_detailResolution_InjectedDelegate get_detailResolution_InjectedDelegateField;

	private static readonly get_detailResolutionPerPatch_InjectedDelegate get_detailResolutionPerPatch_InjectedDelegateField;

	private static readonly get_detailScatterMode_InjectedDelegate get_detailScatterMode_InjectedDelegateField;

	private static readonly ResetDirtyDetails_InjectedDelegate ResetDirtyDetails_InjectedDelegateField;

	private static readonly RefreshPrototypes_InjectedDelegate RefreshPrototypes_InjectedDelegateField;

	private static readonly get_detailPrototypes_InjectedDelegate get_detailPrototypes_InjectedDelegateField;

	private static readonly set_detailPrototypes_InjectedDelegate set_detailPrototypes_InjectedDelegateField;

	private static readonly GetSupportedLayers_InjectedDelegate GetSupportedLayers_InjectedDelegateField;

	private static readonly ComputeDetailInstanceTransforms_InjectedDelegate ComputeDetailInstanceTransforms_InjectedDelegateField;

	private static readonly ComputeDetailCoverage_InjectedDelegate ComputeDetailCoverage_InjectedDelegateField;

	private static readonly Internal_SetDetailLayer_InjectedDelegate Internal_SetDetailLayer_InjectedDelegateField;

	private static readonly Internal_GetTreeInstances_InjectedDelegate Internal_GetTreeInstances_InjectedDelegateField;

	private static readonly SetTreeInstances_InjectedDelegate SetTreeInstances_InjectedDelegateField;

	private static readonly get_treeInstanceCount_InjectedDelegate get_treeInstanceCount_InjectedDelegateField;

	private static readonly get_treePrototypes_InjectedDelegate get_treePrototypes_InjectedDelegateField;

	private static readonly set_treePrototypes_InjectedDelegate set_treePrototypes_InjectedDelegateField;

	private static readonly RemoveTreePrototype_InjectedDelegate RemoveTreePrototype_InjectedDelegateField;

	private static readonly RemoveDetailPrototype_InjectedDelegate RemoveDetailPrototype_InjectedDelegateField;

	private static readonly NeedUpgradeScaledTreePrototypes_InjectedDelegate NeedUpgradeScaledTreePrototypes_InjectedDelegateField;

	private static readonly UpgradeScaledTreePrototype_InjectedDelegate UpgradeScaledTreePrototype_InjectedDelegateField;

	private static readonly get_alphamapLayers_InjectedDelegate get_alphamapLayers_InjectedDelegateField;

	private static readonly get_Internal_alphamapResolution_InjectedDelegate get_Internal_alphamapResolution_InjectedDelegateField;

	private static readonly set_Internal_alphamapResolution_InjectedDelegate set_Internal_alphamapResolution_InjectedDelegateField;

	private static readonly get_Internal_baseMapResolution_InjectedDelegate get_Internal_baseMapResolution_InjectedDelegateField;

	private static readonly set_Internal_baseMapResolution_InjectedDelegate set_Internal_baseMapResolution_InjectedDelegateField;

	private static readonly Internal_SetAlphamaps_InjectedDelegate Internal_SetAlphamaps_InjectedDelegateField;

	private static readonly SetBaseMapDirty_InjectedDelegate SetBaseMapDirty_InjectedDelegateField;

	private static readonly GetAlphamapTexture_InjectedDelegate GetAlphamapTexture_InjectedDelegateField;

	private static readonly get_alphamapTextureCount_InjectedDelegate get_alphamapTextureCount_InjectedDelegateField;

	private static readonly get_splatPrototypes_InjectedDelegate get_splatPrototypes_InjectedDelegateField;

	private static readonly set_splatPrototypes_InjectedDelegate set_splatPrototypes_InjectedDelegateField;

	private static readonly get_terrainLayers_InjectedDelegate get_terrainLayers_InjectedDelegateField;

	private static readonly set_terrainLayers_InjectedDelegate set_terrainLayers_InjectedDelegateField;

	private static readonly RemoveTrees_InjectedDelegate RemoveTrees_InjectedDelegateField;

	private static readonly Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField;

	private static readonly Internal_DirtyHeightmapRegion_InjectedDelegate Internal_DirtyHeightmapRegion_InjectedDelegateField;

	private static readonly SyncHeightmap_InjectedDelegate SyncHeightmap_InjectedDelegateField;

	private static readonly Internal_CopyActiveRenderTextureToHoles_InjectedDelegate Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField;

	private static readonly Internal_DirtyHolesRegion_InjectedDelegate Internal_DirtyHolesRegion_InjectedDelegateField;

	private static readonly Internal_SyncHoles_InjectedDelegate Internal_SyncHoles_InjectedDelegateField;

	private static readonly Internal_MarkAlphamapDirtyRegion_InjectedDelegate Internal_MarkAlphamapDirtyRegion_InjectedDelegateField;

	private static readonly Internal_ClearAlphamapDirtyRegion_InjectedDelegate Internal_ClearAlphamapDirtyRegion_InjectedDelegateField;

	private static readonly Internal_SyncAlphamaps_InjectedDelegate Internal_SyncAlphamaps_InjectedDelegateField;

	private static readonly get_atlasFormat_InjectedDelegate get_atlasFormat_InjectedDelegateField;

	public unsafe static int k_MaximumResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumResolution, (void*)(&value));
		}
	}

	public unsafe static int k_MinimumDetailResolutionPerPatch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&value));
		}
	}

	public unsafe static int k_MaximumDetailResolutionPerPatch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&value));
		}
	}

	public unsafe static int k_MaximumDetailPatchCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&value));
		}
	}

	public unsafe static int k_MinimumAlphamapResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&value));
		}
	}

	public unsafe static int k_MaximumAlphamapResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&value));
		}
	}

	public unsafe static int k_MinimumBaseMapResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&value));
		}
	}

	public unsafe static int k_MaximumBaseMapResolution
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&value));
		}
	}

	public unsafe RenderTexture heightmapTexture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272093, RefRangeEnd = 1272094, XrefRangeStart = 1272082, XrefRangeEnd = 1272093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_heightmapTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
	}

	public unsafe Vector3 heightmapScale
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272101, RefRangeEnd = 1272102, XrefRangeStart = 1272094, XrefRangeEnd = 1272101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_heightmapScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 size
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272102, XrefRangeEnd = 1272109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, ref value);
		}
	}

	public unsafe Bounds bounds
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272116, RefRangeEnd = 1272117, XrefRangeStart = 1272109, XrefRangeEnd = 1272116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppReferenceArray<Terrain> users
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272125, XrefRangeEnd = 1272133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr2) : null;
		}
	}

	public static bool SupportsCopyTextureBetweenRTAndTexture => (SystemInfo.copyTextureSupport & (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture)) == (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture);

	public static string AlphamapTextureName => "alphamap";

	public static string HolesTextureName => "holes";

	public int heightmapWidth => heightmapResolution;

	public int heightmapHeight => heightmapResolution;

	public int heightmapResolution
	{
		get
		{
			return internalHeightmapResolution;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int internalHeightmapResolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_internalHeightmapResolution_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_internalHeightmapResolution_Injected(intPtr, value);
		}
	}

	public Texture holesTexture
	{
		get
		{
			if (IsHolesTextureCompressed())
			{
				return GetCompressedHolesTexture();
			}
			return GetHolesTexture();
		}
	}

	public bool enableHolesTextureCompression
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableHolesTextureCompression_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableHolesTextureCompression_Injected(intPtr, value);
		}
	}

	public RenderTexture holesRenderTexture => GetHolesTexture();

	public int holesResolution => heightmapResolution - 1;

	public float thickness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float wavingGrassStrength
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wavingGrassStrength_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wavingGrassStrength_Injected(intPtr, value);
		}
	}

	public float wavingGrassAmount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wavingGrassAmount_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wavingGrassAmount_Injected(intPtr, value);
		}
	}

	public float wavingGrassSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wavingGrassSpeed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wavingGrassSpeed_Injected(intPtr, value);
		}
	}

	public Color wavingGrassTint
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_wavingGrassTint_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wavingGrassTint_Injected(intPtr, ref value);
		}
	}

	public int detailWidth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailWidth_Injected(intPtr);
		}
	}

	public int detailHeight
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailHeight_Injected(intPtr);
		}
	}

	public int maxDetailScatterPerRes
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDetailScatterPerRes_Injected(intPtr);
		}
	}

	public int detailPatchCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailPatchCount_Injected(intPtr);
		}
	}

	public int detailResolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailResolution_Injected(intPtr);
		}
	}

	public int detailResolutionPerPatch
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailResolutionPerPatch_Injected(intPtr);
		}
	}

	public DetailScatterMode detailScatterMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailScatterMode_Injected(intPtr);
		}
	}

	public Il2CppReferenceArray<DetailPrototype> detailPrototypes
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detailPrototypes_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detailPrototypes_Injected(intPtr, value);
		}
	}

	public int treeInstanceCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treeInstanceCount_Injected(intPtr);
		}
	}

	public Il2CppReferenceArray<TreePrototype> treePrototypes
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_treePrototypes_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_treePrototypes_Injected(intPtr, value);
		}
	}

	public int alphamapLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_alphamapLayers_Injected(intPtr);
		}
	}

	public int alphamapResolution
	{
		get
		{
			return Internal_alphamapResolution;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int Internal_alphamapResolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Internal_alphamapResolution_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_Internal_alphamapResolution_Injected(intPtr, value);
		}
	}

	public int alphamapWidth => alphamapResolution;

	public int alphamapHeight => alphamapResolution;

	public int baseMapResolution
	{
		get
		{
			return Internal_baseMapResolution;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int Internal_baseMapResolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Internal_baseMapResolution_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_Internal_baseMapResolution_Injected(intPtr, value);
		}
	}

	public int alphamapTextureCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_alphamapTextureCount_Injected(intPtr);
		}
	}

	public Il2CppReferenceArray<Texture2D> alphamapTextures
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppReferenceArray<SplatPrototype> splatPrototypes
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_splatPrototypes_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_splatPrototypes_Injected(intPtr, value);
		}
	}

	public Il2CppReferenceArray<TerrainLayer> terrainLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_terrainLayers_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_terrainLayers_Injected(intPtr, value);
		}
	}

	public TextureFormat atlasFormat
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_atlasFormat_Injected(intPtr);
		}
	}

	static TerrainData()
	{
		Il2CppClassPointerStore<TerrainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "TerrainData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainData>.NativeClassPtr);
		NativeFieldInfoPtr_k_MaximumResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumResolution");
		NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumDetailResolutionPerPatch");
		NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailResolutionPerPatch");
		NativeFieldInfoPtr_k_MaximumDetailPatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailPatchCount");
		NativeFieldInfoPtr_k_MinimumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumAlphamapResolution");
		NativeFieldInfoPtr_k_MaximumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumAlphamapResolution");
		NativeFieldInfoPtr_k_MinimumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumBaseMapResolution");
		NativeFieldInfoPtr_k_MaximumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumBaseMapResolution");
		NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_get_heightmapTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_get_heightmapScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_get_heightmapTexture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_get_heightmapScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_GetAlphamapResolutionInternal_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_get_users_Injected_Private_Static_Il2CppReferenceArray_1_Terrain_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663326);
		Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.TerrainData::Internal_Create");
		get_internalHeightmapResolution_InjectedDelegateField = IL2CPP.ResolveICall<get_internalHeightmapResolution_InjectedDelegate>("UnityEngine.TerrainData::get_internalHeightmapResolution_Injected");
		set_internalHeightmapResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_internalHeightmapResolution_InjectedDelegate>("UnityEngine.TerrainData::set_internalHeightmapResolution_Injected");
		get_enableHolesTextureCompression_InjectedDelegateField = IL2CPP.ResolveICall<get_enableHolesTextureCompression_InjectedDelegate>("UnityEngine.TerrainData::get_enableHolesTextureCompression_Injected");
		set_enableHolesTextureCompression_InjectedDelegateField = IL2CPP.ResolveICall<set_enableHolesTextureCompression_InjectedDelegate>("UnityEngine.TerrainData::set_enableHolesTextureCompression_Injected");
		IsHolesTextureCompressed_InjectedDelegateField = IL2CPP.ResolveICall<IsHolesTextureCompressed_InjectedDelegate>("UnityEngine.TerrainData::IsHolesTextureCompressed_Injected");
		GetHolesTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetHolesTexture_InjectedDelegate>("UnityEngine.TerrainData::GetHolesTexture_Injected");
		GetCompressedHolesTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetCompressedHolesTexture_InjectedDelegate>("UnityEngine.TerrainData::GetCompressedHolesTexture_Injected");
		set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.TerrainData::set_size_Injected");
		GetHeight_InjectedDelegateField = IL2CPP.ResolveICall<GetHeight_InjectedDelegate>("UnityEngine.TerrainData::GetHeight_Injected");
		GetInterpolatedHeight_InjectedDelegateField = IL2CPP.ResolveICall<GetInterpolatedHeight_InjectedDelegate>("UnityEngine.TerrainData::GetInterpolatedHeight_Injected");
		Internal_GetInterpolatedHeights_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetInterpolatedHeights_InjectedDelegate>("UnityEngine.TerrainData::Internal_GetInterpolatedHeights_Injected");
		Internal_SetHeights_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetHeights_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetHeights_Injected");
		GetPatchMinMaxHeights_InjectedDelegateField = IL2CPP.ResolveICall<GetPatchMinMaxHeights_InjectedDelegate>("UnityEngine.TerrainData::GetPatchMinMaxHeights_Injected");
		OverrideMinMaxPatchHeights_InjectedDelegateField = IL2CPP.ResolveICall<OverrideMinMaxPatchHeights_InjectedDelegate>("UnityEngine.TerrainData::OverrideMinMaxPatchHeights_Injected");
		GetMaximumHeightError_InjectedDelegateField = IL2CPP.ResolveICall<GetMaximumHeightError_InjectedDelegate>("UnityEngine.TerrainData::GetMaximumHeightError_Injected");
		OverrideMaximumHeightError_InjectedDelegateField = IL2CPP.ResolveICall<OverrideMaximumHeightError_InjectedDelegate>("UnityEngine.TerrainData::OverrideMaximumHeightError_Injected");
		Internal_SetHeightsDelayLOD_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetHeightsDelayLOD_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetHeightsDelayLOD_Injected");
		Internal_SetHoles_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetHoles_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetHoles_Injected");
		Internal_IsHole_InjectedDelegateField = IL2CPP.ResolveICall<Internal_IsHole_InjectedDelegate>("UnityEngine.TerrainData::Internal_IsHole_Injected");
		Internal_SetHolesDelayLOD_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetHolesDelayLOD_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetHolesDelayLOD_Injected");
		GetSteepness_InjectedDelegateField = IL2CPP.ResolveICall<GetSteepness_InjectedDelegate>("UnityEngine.TerrainData::GetSteepness_Injected");
		GetInterpolatedNormal_InjectedDelegateField = IL2CPP.ResolveICall<GetInterpolatedNormal_InjectedDelegate>("UnityEngine.TerrainData::GetInterpolatedNormal_Injected");
		GetAdjustedSize_InjectedDelegateField = IL2CPP.ResolveICall<GetAdjustedSize_InjectedDelegate>("UnityEngine.TerrainData::GetAdjustedSize_Injected");
		get_wavingGrassStrength_InjectedDelegateField = IL2CPP.ResolveICall<get_wavingGrassStrength_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassStrength_Injected");
		set_wavingGrassStrength_InjectedDelegateField = IL2CPP.ResolveICall<set_wavingGrassStrength_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassStrength_Injected");
		get_wavingGrassAmount_InjectedDelegateField = IL2CPP.ResolveICall<get_wavingGrassAmount_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassAmount_Injected");
		set_wavingGrassAmount_InjectedDelegateField = IL2CPP.ResolveICall<set_wavingGrassAmount_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassAmount_Injected");
		get_wavingGrassSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_wavingGrassSpeed_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassSpeed_Injected");
		set_wavingGrassSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_wavingGrassSpeed_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassSpeed_Injected");
		get_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<get_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassTint_Injected");
		set_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<set_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassTint_Injected");
		get_detailWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_detailWidth_InjectedDelegate>("UnityEngine.TerrainData::get_detailWidth_Injected");
		get_detailHeight_InjectedDelegateField = IL2CPP.ResolveICall<get_detailHeight_InjectedDelegate>("UnityEngine.TerrainData::get_detailHeight_Injected");
		get_maxDetailScatterPerRes_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDetailScatterPerRes_InjectedDelegate>("UnityEngine.TerrainData::get_maxDetailScatterPerRes_Injected");
		Internal_SetDetailResolution_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetDetailResolution_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetDetailResolution_Injected");
		Internal_SetDetailScatterMode_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetDetailScatterMode_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetDetailScatterMode_Injected");
		get_detailPatchCount_InjectedDelegateField = IL2CPP.ResolveICall<get_detailPatchCount_InjectedDelegate>("UnityEngine.TerrainData::get_detailPatchCount_Injected");
		get_detailResolution_InjectedDelegateField = IL2CPP.ResolveICall<get_detailResolution_InjectedDelegate>("UnityEngine.TerrainData::get_detailResolution_Injected");
		get_detailResolutionPerPatch_InjectedDelegateField = IL2CPP.ResolveICall<get_detailResolutionPerPatch_InjectedDelegate>("UnityEngine.TerrainData::get_detailResolutionPerPatch_Injected");
		get_detailScatterMode_InjectedDelegateField = IL2CPP.ResolveICall<get_detailScatterMode_InjectedDelegate>("UnityEngine.TerrainData::get_detailScatterMode_Injected");
		ResetDirtyDetails_InjectedDelegateField = IL2CPP.ResolveICall<ResetDirtyDetails_InjectedDelegate>("UnityEngine.TerrainData::ResetDirtyDetails_Injected");
		RefreshPrototypes_InjectedDelegateField = IL2CPP.ResolveICall<RefreshPrototypes_InjectedDelegate>("UnityEngine.TerrainData::RefreshPrototypes_Injected");
		get_detailPrototypes_InjectedDelegateField = IL2CPP.ResolveICall<get_detailPrototypes_InjectedDelegate>("UnityEngine.TerrainData::get_detailPrototypes_Injected");
		set_detailPrototypes_InjectedDelegateField = IL2CPP.ResolveICall<set_detailPrototypes_InjectedDelegate>("UnityEngine.TerrainData::set_detailPrototypes_Injected");
		GetSupportedLayers_InjectedDelegateField = IL2CPP.ResolveICall<GetSupportedLayers_InjectedDelegate>("UnityEngine.TerrainData::GetSupportedLayers_Injected");
		ComputeDetailInstanceTransforms_InjectedDelegateField = IL2CPP.ResolveICall<ComputeDetailInstanceTransforms_InjectedDelegate>("UnityEngine.TerrainData::ComputeDetailInstanceTransforms_Injected");
		ComputeDetailCoverage_InjectedDelegateField = IL2CPP.ResolveICall<ComputeDetailCoverage_InjectedDelegate>("UnityEngine.TerrainData::ComputeDetailCoverage_Injected");
		Internal_SetDetailLayer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetDetailLayer_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetDetailLayer_Injected");
		Internal_GetTreeInstances_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetTreeInstances_InjectedDelegate>("UnityEngine.TerrainData::Internal_GetTreeInstances_Injected");
		SetTreeInstances_InjectedDelegateField = IL2CPP.ResolveICall<SetTreeInstances_InjectedDelegate>("UnityEngine.TerrainData::SetTreeInstances_Injected");
		get_treeInstanceCount_InjectedDelegateField = IL2CPP.ResolveICall<get_treeInstanceCount_InjectedDelegate>("UnityEngine.TerrainData::get_treeInstanceCount_Injected");
		get_treePrototypes_InjectedDelegateField = IL2CPP.ResolveICall<get_treePrototypes_InjectedDelegate>("UnityEngine.TerrainData::get_treePrototypes_Injected");
		set_treePrototypes_InjectedDelegateField = IL2CPP.ResolveICall<set_treePrototypes_InjectedDelegate>("UnityEngine.TerrainData::set_treePrototypes_Injected");
		RemoveTreePrototype_InjectedDelegateField = IL2CPP.ResolveICall<RemoveTreePrototype_InjectedDelegate>("UnityEngine.TerrainData::RemoveTreePrototype_Injected");
		RemoveDetailPrototype_InjectedDelegateField = IL2CPP.ResolveICall<RemoveDetailPrototype_InjectedDelegate>("UnityEngine.TerrainData::RemoveDetailPrototype_Injected");
		NeedUpgradeScaledTreePrototypes_InjectedDelegateField = IL2CPP.ResolveICall<NeedUpgradeScaledTreePrototypes_InjectedDelegate>("UnityEngine.TerrainData::NeedUpgradeScaledTreePrototypes_Injected");
		UpgradeScaledTreePrototype_InjectedDelegateField = IL2CPP.ResolveICall<UpgradeScaledTreePrototype_InjectedDelegate>("UnityEngine.TerrainData::UpgradeScaledTreePrototype_Injected");
		get_alphamapLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_alphamapLayers_InjectedDelegate>("UnityEngine.TerrainData::get_alphamapLayers_Injected");
		get_Internal_alphamapResolution_InjectedDelegateField = IL2CPP.ResolveICall<get_Internal_alphamapResolution_InjectedDelegate>("UnityEngine.TerrainData::get_Internal_alphamapResolution_Injected");
		set_Internal_alphamapResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_Internal_alphamapResolution_InjectedDelegate>("UnityEngine.TerrainData::set_Internal_alphamapResolution_Injected");
		get_Internal_baseMapResolution_InjectedDelegateField = IL2CPP.ResolveICall<get_Internal_baseMapResolution_InjectedDelegate>("UnityEngine.TerrainData::get_Internal_baseMapResolution_Injected");
		set_Internal_baseMapResolution_InjectedDelegateField = IL2CPP.ResolveICall<set_Internal_baseMapResolution_InjectedDelegate>("UnityEngine.TerrainData::set_Internal_baseMapResolution_Injected");
		Internal_SetAlphamaps_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetAlphamaps_InjectedDelegate>("UnityEngine.TerrainData::Internal_SetAlphamaps_Injected");
		SetBaseMapDirty_InjectedDelegateField = IL2CPP.ResolveICall<SetBaseMapDirty_InjectedDelegate>("UnityEngine.TerrainData::SetBaseMapDirty_Injected");
		GetAlphamapTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetAlphamapTexture_InjectedDelegate>("UnityEngine.TerrainData::GetAlphamapTexture_Injected");
		get_alphamapTextureCount_InjectedDelegateField = IL2CPP.ResolveICall<get_alphamapTextureCount_InjectedDelegate>("UnityEngine.TerrainData::get_alphamapTextureCount_Injected");
		get_splatPrototypes_InjectedDelegateField = IL2CPP.ResolveICall<get_splatPrototypes_InjectedDelegate>("UnityEngine.TerrainData::get_splatPrototypes_Injected");
		set_splatPrototypes_InjectedDelegateField = IL2CPP.ResolveICall<set_splatPrototypes_InjectedDelegate>("UnityEngine.TerrainData::set_splatPrototypes_Injected");
		get_terrainLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_terrainLayers_InjectedDelegate>("UnityEngine.TerrainData::get_terrainLayers_Injected");
		set_terrainLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_terrainLayers_InjectedDelegate>("UnityEngine.TerrainData::set_terrainLayers_Injected");
		RemoveTrees_InjectedDelegateField = IL2CPP.ResolveICall<RemoveTrees_InjectedDelegate>("UnityEngine.TerrainData::RemoveTrees_Injected");
		Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHeightmap_Injected");
		Internal_DirtyHeightmapRegion_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DirtyHeightmapRegion_InjectedDelegate>("UnityEngine.TerrainData::Internal_DirtyHeightmapRegion_Injected");
		SyncHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<SyncHeightmap_InjectedDelegate>("UnityEngine.TerrainData::SyncHeightmap_Injected");
		Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CopyActiveRenderTextureToHoles_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHoles_Injected");
		Internal_DirtyHolesRegion_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DirtyHolesRegion_InjectedDelegate>("UnityEngine.TerrainData::Internal_DirtyHolesRegion_Injected");
		Internal_SyncHoles_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SyncHoles_InjectedDelegate>("UnityEngine.TerrainData::Internal_SyncHoles_Injected");
		Internal_MarkAlphamapDirtyRegion_InjectedDelegateField = IL2CPP.ResolveICall<Internal_MarkAlphamapDirtyRegion_InjectedDelegate>("UnityEngine.TerrainData::Internal_MarkAlphamapDirtyRegion_Injected");
		Internal_ClearAlphamapDirtyRegion_InjectedDelegateField = IL2CPP.ResolveICall<Internal_ClearAlphamapDirtyRegion_InjectedDelegate>("UnityEngine.TerrainData::Internal_ClearAlphamapDirtyRegion_Injected");
		Internal_SyncAlphamaps_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SyncAlphamaps_InjectedDelegate>("UnityEngine.TerrainData::Internal_SyncAlphamaps_Injected");
		get_atlasFormat_InjectedDelegateField = IL2CPP.ResolveICall<get_atlasFormat_InjectedDelegate>("UnityEngine.TerrainData::get_atlasFormat_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272055, XrefRangeEnd = 1272082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetBoundaryValue(BoundaryValueType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272117, XrefRangeEnd = 1272125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAlphamapResolutionInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272133, XrefRangeEnd = 1272135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_heightmapTexture_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_heightmapTexture_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272135, XrefRangeEnd = 1272137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_heightmapScale_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_heightmapScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272137, XrefRangeEnd = 1272139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_size_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272139, XrefRangeEnd = 1272141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272141, XrefRangeEnd = 1272143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAlphamapResolutionInternal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAlphamapResolutionInternal_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272143, XrefRangeEnd = 1272145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Terrain> get_users_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_users_Injected_Private_Static_Il2CppReferenceArray_1_Terrain_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr2) : null;
	}

	public TerrainData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void CopyActiveRenderTextureToHeightmap(RectInt sourceRect, Vector2Int dest, TerrainHeightmapSyncControl syncControl)
	{
		RenderTexture active = RenderTexture.active;
		if (active == null)
		{
			throw new Il2CppSystem.InvalidOperationException("Active RenderTexture is null.");
		}
		if (sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceRect");
		}
		if (dest.x < 0 || dest.x + sourceRect.width > heightmapResolution)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("dest.x");
		}
		if (dest.y < 0 || dest.y + sourceRect.height > heightmapResolution)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("dest.y");
		}
		Internal_CopyActiveRenderTextureToHeightmap(sourceRect, dest.x, dest.y, syncControl);
		TerrainCallbacks.InvokeHeightmapChangedCallback(this, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), syncControl == TerrainHeightmapSyncControl.HeightAndLod);
	}

	public void DirtyHeightmapRegion(RectInt region, TerrainHeightmapSyncControl syncControl)
	{
		int num = heightmapResolution;
		if (region.x < 0 || region.x >= num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.x");
		}
		if (region.width <= 0 || region.xMax > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.width");
		}
		if (region.y < 0 || region.y >= num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.y");
		}
		if (region.height <= 0 || region.yMax > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.height");
		}
		Internal_DirtyHeightmapRegion(region.x, region.y, region.width, region.height, syncControl);
		TerrainCallbacks.InvokeHeightmapChangedCallback(this, region, syncControl == TerrainHeightmapSyncControl.HeightAndLod);
	}

	public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, RectInt sourceRect, Vector2Int dest, bool allowDelayedCPUSync)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(textureName))
		{
			throw new Il2CppSystem.ArgumentNullException("textureName");
		}
		RenderTexture active = RenderTexture.active;
		if (active == null)
		{
			throw new Il2CppSystem.InvalidOperationException("Active RenderTexture is null.");
		}
		int num = 0;
		int num2 = 0;
		if (textureName == HolesTextureName)
		{
			if (textureIndex != 0)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException("textureIndex");
			}
			if (active == holesTexture)
			{
				throw new Il2CppSystem.ArgumentException("source", "Active RenderTexture cannot be holesTexture.");
			}
			num = (num2 = holesResolution);
		}
		else
		{
			if (!(textureName == AlphamapTextureName))
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
			}
			if (textureIndex < 0 || textureIndex >= alphamapTextureCount)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException("textureIndex");
			}
			num = (num2 = alphamapResolution);
		}
		if (sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceRect");
		}
		if (dest.x < 0 || dest.x + sourceRect.width > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("dest.x");
		}
		if (dest.y < 0 || dest.y + sourceRect.height > num2)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("dest.y");
		}
		if (textureName == HolesTextureName)
		{
			Internal_CopyActiveRenderTextureToHoles(sourceRect, dest.x, dest.y, allowDelayedCPUSync);
			return;
		}
		Texture2D alphamapTexture = GetAlphamapTexture(textureIndex);
		allowDelayedCPUSync = allowDelayedCPUSync && SupportsCopyTextureBetweenRTAndTexture && QualitySettings.globalTextureMipmapLimit == 0;
		if (allowDelayedCPUSync)
		{
			if (alphamapTexture.mipmapCount > 1)
			{
				RenderTextureDescriptor desc = new RenderTextureDescriptor(alphamapTexture.width, alphamapTexture.height, active.graphicsFormat, active.depthStencilFormat);
				desc.sRGB = false;
				desc.useMipMap = true;
				desc.autoGenerateMips = false;
				RenderTexture temporary = RenderTexture.GetTemporary(desc);
				if (!temporary.IsCreated())
				{
					temporary.Create();
				}
				Graphics.CopyTexture(alphamapTexture, 0, 0, temporary, 0, 0);
				Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, temporary, 0, 0, dest.x, dest.y);
				temporary.GenerateMips();
				Graphics.CopyTexture(temporary, alphamapTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, alphamapTexture, 0, 0, dest.x, dest.y);
			}
			Internal_MarkAlphamapDirtyRegion(textureIndex, dest.x, dest.y, sourceRect.width, sourceRect.height);
		}
		else
		{
			alphamapTexture.ReadPixels(new Rect(sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height), dest.x, dest.y);
			alphamapTexture.Apply(updateMipmaps: true);
			Internal_ClearAlphamapDirtyRegion(textureIndex);
		}
		TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), !allowDelayedCPUSync);
	}

	public void DirtyTextureRegion(string textureName, RectInt region, bool allowDelayedCPUSync)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(textureName))
		{
			throw new Il2CppSystem.ArgumentNullException("textureName");
		}
		int num = 0;
		if (textureName == AlphamapTextureName)
		{
			num = alphamapResolution;
		}
		else
		{
			if (!(textureName == HolesTextureName))
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
			}
			num = holesResolution;
		}
		if (region.x < 0 || region.x >= num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.x");
		}
		if (region.width <= 0 || region.xMax > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.width");
		}
		if (region.y < 0 || region.y >= num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.y");
		}
		if (region.height <= 0 || region.yMax > num)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("region.height");
		}
		if (textureName == HolesTextureName)
		{
			Internal_DirtyHolesRegion(region.x, region.y, region.width, region.height, allowDelayedCPUSync);
			return;
		}
		Internal_MarkAlphamapDirtyRegion(-1, region.x, region.y, region.width, region.height);
		if (!allowDelayedCPUSync)
		{
			SyncTexture(textureName);
		}
		else
		{
			TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, region, synched: false);
		}
	}

	public void SyncTexture(string textureName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(textureName))
		{
			throw new Il2CppSystem.ArgumentNullException("textureName");
		}
		if (textureName == AlphamapTextureName)
		{
			Internal_SyncAlphamaps();
			return;
		}
		if (textureName == HolesTextureName)
		{
			if (IsHolesTextureCompressed())
			{
				throw new Il2CppSystem.InvalidOperationException("Holes texture is compressed. Compressed holes texture can not be read back from GPU. Use TerrainData.enableHolesTextureCompression to disable holes texture compression.");
			}
			Internal_SyncHoles();
			return;
		}
		throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
	}

	public static void Internal_Create(TerrainData terrainData)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainData));
	}

	public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately)
	{
		DirtyHeightmapRegion(new RectInt(x, y, width, height), syncHeightmapTextureImmediately ? TerrainHeightmapSyncControl.HeightOnly : TerrainHeightmapSyncControl.None);
	}

	public bool IsHolesTextureCompressed()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsHolesTextureCompressed_Injected(intPtr);
	}

	public RenderTexture GetHolesTexture()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(GetHolesTexture_Injected(intPtr));
	}

	public Texture2D GetCompressedHolesTexture()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Texture2D>(GetCompressedHolesTexture_Injected(intPtr));
	}

	public float GetHeight(int x, int y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetHeight_Injected(intPtr, x, y);
	}

	public float GetInterpolatedHeight(float x, float y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetInterpolatedHeight_Injected(intPtr, x, y);
	}

	public unsafe Il2CppStructArray<float> GetMaximumHeightError()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<float> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetMaximumHeightError_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<float> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<float>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe void OverrideMaximumHeightError(Il2CppStructArray<float> maxError)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)maxError);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper maxError2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			OverrideMaximumHeightError_Injected(intPtr, ref maxError2);
		}
	}

	public bool IsHole(int x, int y)
	{
		if (x < 0 || x >= holesResolution || y < 0 || y >= holesResolution)
		{
			throw new Il2CppSystem.ArgumentException("Trying to access out-of-bounds terrain holes information.");
		}
		return Internal_IsHole(x, y);
	}

	public bool Internal_IsHole(int x, int y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_IsHole_Injected(intPtr, x, y);
	}

	public float GetSteepness(float x, float y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSteepness_Injected(intPtr, x, y);
	}

	public Vector3 GetInterpolatedNormal(float x, float y)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetInterpolatedNormal_Injected(intPtr, x, y, out var ret);
		return ret;
	}

	public int GetAdjustedSize(int size)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAdjustedSize_Injected(intPtr, size);
	}

	public void SetDetailResolution(int detailResolution, int resolutionPerPatch)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_SetDetailResolution_Injected(intPtr, patchCount, resolutionPerPatch);
	}

	public void SetDetailScatterMode(DetailScatterMode scatterMode)
	{
		Internal_SetDetailScatterMode(scatterMode);
	}

	public void Internal_SetDetailScatterMode(DetailScatterMode scatterMode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_SetDetailScatterMode_Injected(intPtr, scatterMode);
	}

	public void ResetDirtyDetails()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetDirtyDetails_Injected(intPtr);
	}

	public void RefreshPrototypes()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RefreshPrototypes_Injected(intPtr);
	}

	public unsafe Il2CppStructArray<int> GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetSupportedLayers_Injected(intPtr, xBase, yBase, totalWidth, totalHeight, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public Il2CppStructArray<int> GetSupportedLayers(Vector2Int positionBase, Vector2Int size)
	{
		return GetSupportedLayers(positionBase.x, positionBase.y, size.x, size.y);
	}

	public float ComputeDetailCoverage(int detailPrototypeIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ComputeDetailCoverage_Injected(intPtr, detailPrototypeIndex);
	}

	public void RemoveTreePrototype(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveTreePrototype_Injected(intPtr, index);
	}

	public void RemoveDetailPrototype(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveDetailPrototype_Injected(intPtr, index);
	}

	public bool NeedUpgradeScaledTreePrototypes()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return NeedUpgradeScaledTreePrototypes_Injected(intPtr);
	}

	public void UpgradeScaledTreePrototype()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UpgradeScaledTreePrototype_Injected(intPtr);
	}

	public void SetBaseMapDirty()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetBaseMapDirty_Injected(intPtr);
	}

	public Texture2D GetAlphamapTexture(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Texture2D>(GetAlphamapTexture_Injected(intPtr, index));
	}

	public int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return RemoveTrees_Injected(intPtr, ref position, radius, prototypeIndex);
	}

	public void Internal_CopyActiveRenderTextureToHeightmap(RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_CopyActiveRenderTextureToHeightmap_Injected(intPtr, ref rect, destX, destY, syncControl);
	}

	public void Internal_DirtyHeightmapRegion(int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_DirtyHeightmapRegion_Injected(intPtr, x, y, width, height, syncControl);
	}

	public void SyncHeightmap()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SyncHeightmap_Injected(intPtr);
	}

	public void Internal_CopyActiveRenderTextureToHoles(RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_CopyActiveRenderTextureToHoles_Injected(intPtr, ref rect, destX, destY, allowDelayedCPUSync);
	}

	public void Internal_DirtyHolesRegion(int x, int y, int width, int height, bool allowDelayedCPUSync)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_DirtyHolesRegion_Injected(intPtr, x, y, width, height, allowDelayedCPUSync);
	}

	public void Internal_SyncHoles()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_SyncHoles_Injected(intPtr);
	}

	public void Internal_MarkAlphamapDirtyRegion(int alphamapIndex, int x, int y, int width, int height)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_MarkAlphamapDirtyRegion_Injected(intPtr, alphamapIndex, x, y, width, height);
	}

	public void Internal_ClearAlphamapDirtyRegion(int alphamapIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_ClearAlphamapDirtyRegion_Injected(intPtr, alphamapIndex);
	}

	public void Internal_SyncAlphamaps()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_SyncAlphamaps_Injected(intPtr);
	}

	public static int get_internalHeightmapResolution_Injected(System.IntPtr _unity_self)
	{
		return get_internalHeightmapResolution_InjectedDelegateField(_unity_self);
	}

	public static void set_internalHeightmapResolution_Injected(System.IntPtr _unity_self, int value)
	{
		set_internalHeightmapResolution_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableHolesTextureCompression_Injected(System.IntPtr _unity_self)
	{
		return get_enableHolesTextureCompression_InjectedDelegateField(_unity_self);
	}

	public static void set_enableHolesTextureCompression_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enableHolesTextureCompression_InjectedDelegateField(_unity_self, value);
	}

	public static bool IsHolesTextureCompressed_Injected(System.IntPtr _unity_self)
	{
		return IsHolesTextureCompressed_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetHolesTexture_Injected(System.IntPtr _unity_self)
	{
		return GetHolesTexture_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetCompressedHolesTexture_Injected(System.IntPtr _unity_self)
	{
		return GetCompressedHolesTexture_InjectedDelegateField(_unity_self);
	}

	public unsafe static void set_size_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float GetHeight_Injected(System.IntPtr _unity_self, int x, int y)
	{
		return GetHeight_InjectedDelegateField(_unity_self, x, y);
	}

	public static float GetInterpolatedHeight_Injected(System.IntPtr _unity_self, float x, float y)
	{
		return GetInterpolatedHeight_InjectedDelegateField(_unity_self, x, y);
	}

	public unsafe static void Internal_GetInterpolatedHeights_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper results, int resultXDimension, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval)
	{
		Internal_GetInterpolatedHeights_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref results), resultXDimension, resultXOffset, resultYOffset, xBase, yBase, xCount, yCount, xInterval, yInterval);
	}

	public unsafe static void Internal_SetHeights_Injected(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, ref ManagedSpanWrapper heights)
	{
		Internal_SetHeights_InjectedDelegateField(_unity_self, xBase, yBase, width, height, (nint)Unsafe.AsPointer(ref heights));
	}

	public unsafe static void GetPatchMinMaxHeights_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetPatchMinMaxHeights_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void OverrideMinMaxPatchHeights_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper minMaxHeights)
	{
		OverrideMinMaxPatchHeights_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref minMaxHeights));
	}

	public unsafe static void GetMaximumHeightError_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetMaximumHeightError_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void OverrideMaximumHeightError_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper maxError)
	{
		OverrideMaximumHeightError_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref maxError));
	}

	public unsafe static void Internal_SetHeightsDelayLOD_Injected(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, ref ManagedSpanWrapper heights)
	{
		Internal_SetHeightsDelayLOD_InjectedDelegateField(_unity_self, xBase, yBase, width, height, (nint)Unsafe.AsPointer(ref heights));
	}

	public unsafe static void Internal_SetHoles_Injected(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, ref ManagedSpanWrapper holes)
	{
		Internal_SetHoles_InjectedDelegateField(_unity_self, xBase, yBase, width, height, (nint)Unsafe.AsPointer(ref holes));
	}

	public static bool Internal_IsHole_Injected(System.IntPtr _unity_self, int x, int y)
	{
		return Internal_IsHole_InjectedDelegateField(_unity_self, x, y);
	}

	public unsafe static void Internal_SetHolesDelayLOD_Injected(System.IntPtr _unity_self, int xBase, int yBase, int width, int height, ref ManagedSpanWrapper holes)
	{
		Internal_SetHolesDelayLOD_InjectedDelegateField(_unity_self, xBase, yBase, width, height, (nint)Unsafe.AsPointer(ref holes));
	}

	public static float GetSteepness_Injected(System.IntPtr _unity_self, float x, float y)
	{
		return GetSteepness_InjectedDelegateField(_unity_self, x, y);
	}

	public unsafe static void GetInterpolatedNormal_Injected(System.IntPtr _unity_self, float x, float y, out Vector3 ret)
	{
		GetInterpolatedNormal_InjectedDelegateField(_unity_self, x, y, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int GetAdjustedSize_Injected(System.IntPtr _unity_self, int size)
	{
		return GetAdjustedSize_InjectedDelegateField(_unity_self, size);
	}

	public static float get_wavingGrassStrength_Injected(System.IntPtr _unity_self)
	{
		return get_wavingGrassStrength_InjectedDelegateField(_unity_self);
	}

	public static void set_wavingGrassStrength_Injected(System.IntPtr _unity_self, float value)
	{
		set_wavingGrassStrength_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wavingGrassAmount_Injected(System.IntPtr _unity_self)
	{
		return get_wavingGrassAmount_InjectedDelegateField(_unity_self);
	}

	public static void set_wavingGrassAmount_Injected(System.IntPtr _unity_self, float value)
	{
		set_wavingGrassAmount_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wavingGrassSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_wavingGrassSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_wavingGrassSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		set_wavingGrassSpeed_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_wavingGrassTint_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_wavingGrassTint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_wavingGrassTint_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_wavingGrassTint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_detailWidth_Injected(System.IntPtr _unity_self)
	{
		return get_detailWidth_InjectedDelegateField(_unity_self);
	}

	public static int get_detailHeight_Injected(System.IntPtr _unity_self)
	{
		return get_detailHeight_InjectedDelegateField(_unity_self);
	}

	public static int get_maxDetailScatterPerRes_Injected(System.IntPtr _unity_self)
	{
		return get_maxDetailScatterPerRes_InjectedDelegateField(_unity_self);
	}

	public static void Internal_SetDetailResolution_Injected(System.IntPtr _unity_self, int patchCount, int resolutionPerPatch)
	{
		Internal_SetDetailResolution_InjectedDelegateField(_unity_self, patchCount, resolutionPerPatch);
	}

	public static void Internal_SetDetailScatterMode_Injected(System.IntPtr _unity_self, DetailScatterMode scatterMode)
	{
		Internal_SetDetailScatterMode_InjectedDelegateField(_unity_self, scatterMode);
	}

	public static int get_detailPatchCount_Injected(System.IntPtr _unity_self)
	{
		return get_detailPatchCount_InjectedDelegateField(_unity_self);
	}

	public static int get_detailResolution_Injected(System.IntPtr _unity_self)
	{
		return get_detailResolution_InjectedDelegateField(_unity_self);
	}

	public static int get_detailResolutionPerPatch_Injected(System.IntPtr _unity_self)
	{
		return get_detailResolutionPerPatch_InjectedDelegateField(_unity_self);
	}

	public static DetailScatterMode get_detailScatterMode_Injected(System.IntPtr _unity_self)
	{
		return get_detailScatterMode_InjectedDelegateField(_unity_self);
	}

	public static void ResetDirtyDetails_Injected(System.IntPtr _unity_self)
	{
		ResetDirtyDetails_InjectedDelegateField(_unity_self);
	}

	public static void RefreshPrototypes_Injected(System.IntPtr _unity_self)
	{
		RefreshPrototypes_InjectedDelegateField(_unity_self);
	}

	public static Il2CppReferenceArray<DetailPrototype> get_detailPrototypes_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_detailPrototypes_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetailPrototype>>(intPtr) : null;
	}

	public static void set_detailPrototypes_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<DetailPrototype> value)
	{
		set_detailPrototypes_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public unsafe static void GetSupportedLayers_Injected(System.IntPtr _unity_self, int xBase, int yBase, int totalWidth, int totalHeight, out BlittableArrayWrapper ret)
	{
		GetSupportedLayers_InjectedDelegateField(_unity_self, xBase, yBase, totalWidth, totalHeight, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ComputeDetailInstanceTransforms_Injected(System.IntPtr _unity_self, int patchX, int patchY, int layer, float density, out Bounds bounds, out BlittableArrayWrapper ret)
	{
		ComputeDetailInstanceTransforms_InjectedDelegateField(_unity_self, patchX, patchY, layer, density, (nint)Unsafe.AsPointer(ref bounds), (nint)Unsafe.AsPointer(ref ret));
	}

	public static float ComputeDetailCoverage_Injected(System.IntPtr _unity_self, int detailPrototypeIndex)
	{
		return ComputeDetailCoverage_InjectedDelegateField(_unity_self, detailPrototypeIndex);
	}

	public unsafe static void Internal_SetDetailLayer_Injected(System.IntPtr _unity_self, int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, ref ManagedSpanWrapper data)
	{
		Internal_SetDetailLayer_InjectedDelegateField(_unity_self, xBase, yBase, totalWidth, totalHeight, detailIndex, (nint)Unsafe.AsPointer(ref data));
	}

	public unsafe static void Internal_GetTreeInstances_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		Internal_GetTreeInstances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetTreeInstances_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper instances, bool snapToHeightmap)
	{
		SetTreeInstances_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref instances), snapToHeightmap);
	}

	public static int get_treeInstanceCount_Injected(System.IntPtr _unity_self)
	{
		return get_treeInstanceCount_InjectedDelegateField(_unity_self);
	}

	public static Il2CppReferenceArray<TreePrototype> get_treePrototypes_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_treePrototypes_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TreePrototype>>(intPtr) : null;
	}

	public static void set_treePrototypes_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<TreePrototype> value)
	{
		set_treePrototypes_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static void RemoveTreePrototype_Injected(System.IntPtr _unity_self, int index)
	{
		RemoveTreePrototype_InjectedDelegateField(_unity_self, index);
	}

	public static void RemoveDetailPrototype_Injected(System.IntPtr _unity_self, int index)
	{
		RemoveDetailPrototype_InjectedDelegateField(_unity_self, index);
	}

	public static bool NeedUpgradeScaledTreePrototypes_Injected(System.IntPtr _unity_self)
	{
		return NeedUpgradeScaledTreePrototypes_InjectedDelegateField(_unity_self);
	}

	public static void UpgradeScaledTreePrototype_Injected(System.IntPtr _unity_self)
	{
		UpgradeScaledTreePrototype_InjectedDelegateField(_unity_self);
	}

	public static int get_alphamapLayers_Injected(System.IntPtr _unity_self)
	{
		return get_alphamapLayers_InjectedDelegateField(_unity_self);
	}

	public static int get_Internal_alphamapResolution_Injected(System.IntPtr _unity_self)
	{
		return get_Internal_alphamapResolution_InjectedDelegateField(_unity_self);
	}

	public static void set_Internal_alphamapResolution_Injected(System.IntPtr _unity_self, int value)
	{
		set_Internal_alphamapResolution_InjectedDelegateField(_unity_self, value);
	}

	public static int get_Internal_baseMapResolution_Injected(System.IntPtr _unity_self)
	{
		return get_Internal_baseMapResolution_InjectedDelegateField(_unity_self);
	}

	public static void set_Internal_baseMapResolution_Injected(System.IntPtr _unity_self, int value)
	{
		set_Internal_baseMapResolution_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Internal_SetAlphamaps_Injected(System.IntPtr _unity_self, int x, int y, int width, int height, ref ManagedSpanWrapper map)
	{
		Internal_SetAlphamaps_InjectedDelegateField(_unity_self, x, y, width, height, (nint)Unsafe.AsPointer(ref map));
	}

	public static void SetBaseMapDirty_Injected(System.IntPtr _unity_self)
	{
		SetBaseMapDirty_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetAlphamapTexture_Injected(System.IntPtr _unity_self, int index)
	{
		return GetAlphamapTexture_InjectedDelegateField(_unity_self, index);
	}

	public static int get_alphamapTextureCount_Injected(System.IntPtr _unity_self)
	{
		return get_alphamapTextureCount_InjectedDelegateField(_unity_self);
	}

	public static Il2CppReferenceArray<SplatPrototype> get_splatPrototypes_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_splatPrototypes_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SplatPrototype>>(intPtr) : null;
	}

	public static void set_splatPrototypes_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<SplatPrototype> value)
	{
		set_splatPrototypes_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static Il2CppReferenceArray<TerrainLayer> get_terrainLayers_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_terrainLayers_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TerrainLayer>>(intPtr) : null;
	}

	public static void set_terrainLayers_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<TerrainLayer> value)
	{
		set_terrainLayers_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public unsafe static int RemoveTrees_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float radius, int prototypeIndex)
	{
		return RemoveTrees_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), radius, prototypeIndex);
	}

	public unsafe static void Internal_CopyActiveRenderTextureToHeightmap_Injected(System.IntPtr _unity_self, [In] ref RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
	{
		Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rect), destX, destY, syncControl);
	}

	public static void Internal_DirtyHeightmapRegion_Injected(System.IntPtr _unity_self, int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl)
	{
		Internal_DirtyHeightmapRegion_InjectedDelegateField(_unity_self, x, y, width, height, syncControl);
	}

	public static void SyncHeightmap_Injected(System.IntPtr _unity_self)
	{
		SyncHeightmap_InjectedDelegateField(_unity_self);
	}

	public unsafe static void Internal_CopyActiveRenderTextureToHoles_Injected(System.IntPtr _unity_self, [In] ref RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
	{
		Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rect), destX, destY, allowDelayedCPUSync);
	}

	public static void Internal_DirtyHolesRegion_Injected(System.IntPtr _unity_self, int x, int y, int width, int height, bool allowDelayedCPUSync)
	{
		Internal_DirtyHolesRegion_InjectedDelegateField(_unity_self, x, y, width, height, allowDelayedCPUSync);
	}

	public static void Internal_SyncHoles_Injected(System.IntPtr _unity_self)
	{
		Internal_SyncHoles_InjectedDelegateField(_unity_self);
	}

	public static void Internal_MarkAlphamapDirtyRegion_Injected(System.IntPtr _unity_self, int alphamapIndex, int x, int y, int width, int height)
	{
		Internal_MarkAlphamapDirtyRegion_InjectedDelegateField(_unity_self, alphamapIndex, x, y, width, height);
	}

	public static void Internal_ClearAlphamapDirtyRegion_Injected(System.IntPtr _unity_self, int alphamapIndex)
	{
		Internal_ClearAlphamapDirtyRegion_InjectedDelegateField(_unity_self, alphamapIndex);
	}

	public static void Internal_SyncAlphamaps_Injected(System.IntPtr _unity_self)
	{
		Internal_SyncAlphamaps_InjectedDelegateField(_unity_self);
	}

	public static TextureFormat get_atlasFormat_Injected(System.IntPtr _unity_self)
	{
		return get_atlasFormat_InjectedDelegateField(_unity_self);
	}
}
