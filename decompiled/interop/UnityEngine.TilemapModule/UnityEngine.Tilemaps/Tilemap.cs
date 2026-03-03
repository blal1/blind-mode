using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps;

public sealed class Tilemap : GridLayout
{
	public sealed class SyncTile : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Tile;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TileData;

		public unsafe Vector3Int m_Position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		public unsafe TileBase m_Tile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tile);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TileBase>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TileData m_TileData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileData);
				return *(TileData*)num;
			}
			set
			{
				*(TileData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileData)) = value;
			}
		}

		static SyncTile()
		{
			Il2CppClassPointerStore<SyncTile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "SyncTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncTile>.NativeClassPtr);
			NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTile>.NativeClassPtr, "m_Position");
			NativeFieldInfoPtr_m_Tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTile>.NativeClassPtr, "m_Tile");
			NativeFieldInfoPtr_m_TileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTile>.NativeClassPtr, "m_TileData");
		}

		public SyncTile(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SyncTile()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncTile>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SyncTileCallbackSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hasSyncTileCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasPositionsChangedCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBufferSyncTile;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasSyncTileCallback;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasPositionsChangedCallback;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isBufferSyncTile;

		static SyncTileCallbackSettings()
		{
			Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "SyncTileCallbackSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr);
			NativeFieldInfoPtr_hasSyncTileCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr, "hasSyncTileCallback");
			NativeFieldInfoPtr_hasPositionsChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr, "hasPositionsChangedCallback");
			NativeFieldInfoPtr_isBufferSyncTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr, "isBufferSyncTile");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncTileCallbackSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public enum Orientation
	{
		XY,
		XZ,
		YX,
		YZ,
		ZX,
		ZY,
		Custom
	}

	private delegate System.IntPtr get_layoutGrid_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_localBounds_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_localFrameBounds_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate float get_animationFrameRate_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_animationFrameRate_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_color_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_color_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_origin_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_origin_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_size_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_tileAnchor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_tileAnchor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate Orientation get_orientation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_orientation_InjectedDelegate(System.IntPtr _unity_self, Orientation value);

	private delegate void get_orientationMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_orientationMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate System.IntPtr GetTileAsset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate System.IntPtr GetTileAssetsBlock_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr blockDimensions);

	private delegate int GetTileAssetsBlockNonAlloc_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr startPosition, [In] System.IntPtr endPosition, System.IntPtr tiles);

	private delegate int GetTilesRangeCount_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr startPosition, [In] System.IntPtr endPosition);

	private delegate int GetTileAssetsRangeNonAlloc_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr startPosition, [In] System.IntPtr endPosition, System.IntPtr positions, System.IntPtr tiles);

	private delegate void SetTileAsset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, System.IntPtr tile);

	private delegate void SetTileAssets_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positionArray, System.IntPtr tileArray);

	private delegate void INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr blockDimensions, System.IntPtr tileArray);

	private delegate void SetTile_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr tileChangeData, bool ignoreLockFlags);

	private delegate void SetTiles_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr tileChangeDataArray, bool ignoreLockFlags);

	private delegate void RefreshAllTiles_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SwapTileAsset_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr changeTile, System.IntPtr newTile);

	private delegate bool ContainsTileAsset_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr tileAsset);

	private delegate int GetUsedTilesCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetUsedSpritesCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int Internal_GetUsedTilesNonAlloc_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr usedTiles);

	private delegate int Internal_GetUsedSpritesNonAlloc_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr usedSprites);

	private delegate System.IntPtr GetSprite_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void GetTransformMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [Out] System.IntPtr ret);

	private delegate void SetTransformMatrix_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr transform);

	private delegate void GetColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [Out] System.IntPtr ret);

	private delegate void SetColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr color);

	private delegate TileFlags GetTileFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void SetTileFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileFlags flags);

	private delegate void AddTileFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileFlags flags);

	private delegate void RemoveTileFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileFlags flags);

	private delegate System.IntPtr GetInstantiatedObject_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate System.IntPtr GetObjectToInstantiate_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void SetColliderType_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, Tile.ColliderType colliderType);

	private delegate Tile.ColliderType GetColliderType_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate int GetAnimationFrameCount_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate int GetAnimationFrame_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void SetAnimationFrame_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, int frame);

	private delegate float GetAnimationTime_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void SetAnimationTime_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float time);

	private delegate TileAnimationFlags GetTileAnimationFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void SetTileAnimationFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileAnimationFlags flags);

	private delegate void AddTileAnimationFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileAnimationFlags flags);

	private delegate void RemoveTileAnimationFlags_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, TileAnimationFlags flags);

	private delegate void FloodFillTileAsset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, System.IntPtr tile);

	private delegate void BoxFillTileAsset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, System.IntPtr tile, int startX, int startY, int endX, int endY);

	private delegate void InsertCells_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, int numColumns, int numRows, int numLayers);

	private delegate void DeleteCells_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, int numColumns, int numRows, int numLayers);

	private delegate void ClearAllTiles_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResizeBounds_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void CompressTilemapBounds_InjectedDelegate(System.IntPtr _unity_self, bool keepEditorPreview);

	private delegate void SendAndClearSyncTileBuffer_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_tilemapTileChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilemapPositionsChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopEndedForTileAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferSyncTile;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasLoopEndedForTileAnimationCallback_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendLoopEndedForTileAnimationCallback_Private_Void_NativeArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoopEndedForTileAnimationCallbackSettings_Internal_Void_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTile_Injected_Private_Static_Void_IntPtr_byref_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTilesNative_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0;

	private static readonly get_layoutGrid_InjectedDelegate get_layoutGrid_InjectedDelegateField;

	private static readonly get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

	private static readonly get_localFrameBounds_InjectedDelegate get_localFrameBounds_InjectedDelegateField;

	private static readonly get_animationFrameRate_InjectedDelegate get_animationFrameRate_InjectedDelegateField;

	private static readonly set_animationFrameRate_InjectedDelegate set_animationFrameRate_InjectedDelegateField;

	private static readonly get_color_InjectedDelegate get_color_InjectedDelegateField;

	private static readonly set_color_InjectedDelegate set_color_InjectedDelegateField;

	private static readonly get_origin_InjectedDelegate get_origin_InjectedDelegateField;

	private static readonly set_origin_InjectedDelegate set_origin_InjectedDelegateField;

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField;

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField;

	private static readonly get_tileAnchor_InjectedDelegate get_tileAnchor_InjectedDelegateField;

	private static readonly set_tileAnchor_InjectedDelegate set_tileAnchor_InjectedDelegateField;

	private static readonly get_orientation_InjectedDelegate get_orientation_InjectedDelegateField;

	private static readonly set_orientation_InjectedDelegate set_orientation_InjectedDelegateField;

	private static readonly get_orientationMatrix_InjectedDelegate get_orientationMatrix_InjectedDelegateField;

	private static readonly set_orientationMatrix_InjectedDelegate set_orientationMatrix_InjectedDelegateField;

	private static readonly GetTileAsset_InjectedDelegate GetTileAsset_InjectedDelegateField;

	private static readonly GetTileAssetsBlock_InjectedDelegate GetTileAssetsBlock_InjectedDelegateField;

	private static readonly GetTileAssetsBlockNonAlloc_InjectedDelegate GetTileAssetsBlockNonAlloc_InjectedDelegateField;

	private static readonly GetTilesRangeCount_InjectedDelegate GetTilesRangeCount_InjectedDelegateField;

	private static readonly GetTileAssetsRangeNonAlloc_InjectedDelegate GetTileAssetsRangeNonAlloc_InjectedDelegateField;

	private static readonly SetTileAsset_InjectedDelegate SetTileAsset_InjectedDelegateField;

	private static readonly SetTileAssets_InjectedDelegate SetTileAssets_InjectedDelegateField;

	private static readonly INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField;

	private static readonly SetTile_InjectedDelegate SetTile_InjectedDelegateField;

	private static readonly SetTiles_InjectedDelegate SetTiles_InjectedDelegateField;

	private static readonly RefreshAllTiles_InjectedDelegate RefreshAllTiles_InjectedDelegateField;

	private static readonly SwapTileAsset_InjectedDelegate SwapTileAsset_InjectedDelegateField;

	private static readonly ContainsTileAsset_InjectedDelegate ContainsTileAsset_InjectedDelegateField;

	private static readonly GetUsedTilesCount_InjectedDelegate GetUsedTilesCount_InjectedDelegateField;

	private static readonly GetUsedSpritesCount_InjectedDelegate GetUsedSpritesCount_InjectedDelegateField;

	private static readonly Internal_GetUsedTilesNonAlloc_InjectedDelegate Internal_GetUsedTilesNonAlloc_InjectedDelegateField;

	private static readonly Internal_GetUsedSpritesNonAlloc_InjectedDelegate Internal_GetUsedSpritesNonAlloc_InjectedDelegateField;

	private static readonly GetSprite_InjectedDelegate GetSprite_InjectedDelegateField;

	private static readonly GetTransformMatrix_InjectedDelegate GetTransformMatrix_InjectedDelegateField;

	private static readonly SetTransformMatrix_InjectedDelegate SetTransformMatrix_InjectedDelegateField;

	private static readonly GetColor_InjectedDelegate GetColor_InjectedDelegateField;

	private static readonly SetColor_InjectedDelegate SetColor_InjectedDelegateField;

	private static readonly GetTileFlags_InjectedDelegate GetTileFlags_InjectedDelegateField;

	private static readonly SetTileFlags_InjectedDelegate SetTileFlags_InjectedDelegateField;

	private static readonly AddTileFlags_InjectedDelegate AddTileFlags_InjectedDelegateField;

	private static readonly RemoveTileFlags_InjectedDelegate RemoveTileFlags_InjectedDelegateField;

	private static readonly GetInstantiatedObject_InjectedDelegate GetInstantiatedObject_InjectedDelegateField;

	private static readonly GetObjectToInstantiate_InjectedDelegate GetObjectToInstantiate_InjectedDelegateField;

	private static readonly SetColliderType_InjectedDelegate SetColliderType_InjectedDelegateField;

	private static readonly GetColliderType_InjectedDelegate GetColliderType_InjectedDelegateField;

	private static readonly GetAnimationFrameCount_InjectedDelegate GetAnimationFrameCount_InjectedDelegateField;

	private static readonly GetAnimationFrame_InjectedDelegate GetAnimationFrame_InjectedDelegateField;

	private static readonly SetAnimationFrame_InjectedDelegate SetAnimationFrame_InjectedDelegateField;

	private static readonly GetAnimationTime_InjectedDelegate GetAnimationTime_InjectedDelegateField;

	private static readonly SetAnimationTime_InjectedDelegate SetAnimationTime_InjectedDelegateField;

	private static readonly GetTileAnimationFlags_InjectedDelegate GetTileAnimationFlags_InjectedDelegateField;

	private static readonly SetTileAnimationFlags_InjectedDelegate SetTileAnimationFlags_InjectedDelegateField;

	private static readonly AddTileAnimationFlags_InjectedDelegate AddTileAnimationFlags_InjectedDelegateField;

	private static readonly RemoveTileAnimationFlags_InjectedDelegate RemoveTileAnimationFlags_InjectedDelegateField;

	private static readonly FloodFillTileAsset_InjectedDelegate FloodFillTileAsset_InjectedDelegateField;

	private static readonly BoxFillTileAsset_InjectedDelegate BoxFillTileAsset_InjectedDelegateField;

	private static readonly InsertCells_InjectedDelegate InsertCells_InjectedDelegateField;

	private static readonly DeleteCells_InjectedDelegate DeleteCells_InjectedDelegateField;

	private static readonly ClearAllTiles_InjectedDelegate ClearAllTiles_InjectedDelegateField;

	private static readonly ResizeBounds_InjectedDelegate ResizeBounds_InjectedDelegateField;

	private static readonly CompressTilemapBounds_InjectedDelegate CompressTilemapBounds_InjectedDelegateField;

	private static readonly SendAndClearSyncTileBuffer_InjectedDelegate SendAndClearSyncTileBuffer_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>> tilemapTileChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tilemapTileChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tilemapTileChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tilemapPositionsChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tilemapPositionsChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> loopEndedForTileAnimation
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loopEndedForTileAnimation, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loopEndedForTileAnimation, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_BufferSyncTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferSyncTile);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferSyncTile)) = value;
		}
	}

	public unsafe bool bufferSyncTile
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (!value && m_BufferSyncTile != value && HasSyncTileCallback())
			{
				SendAndClearSyncTileBuffer();
			}
			m_BufferSyncTile = value;
		}
	}

	public Grid layoutGrid
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Grid>(get_layoutGrid_Injected(intPtr));
		}
	}

	public BoundsInt cellBounds => new BoundsInt(origin, size);

	public Bounds localBounds
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_localBounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Bounds localFrameBounds
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_localFrameBounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public float animationFrameRate
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_animationFrameRate_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_animationFrameRate_Injected(intPtr, value);
		}
	}

	public Color color
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_color_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_color_Injected(intPtr, ref value);
		}
	}

	public Vector3Int origin
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_origin_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_origin_Injected(intPtr, ref value);
		}
	}

	public Vector3Int size
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_size_Injected(intPtr, out var ret);
			return ret;
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

	public Vector3 tileAnchor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_tileAnchor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tileAnchor_Injected(intPtr, ref value);
		}
	}

	public Orientation orientation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_orientation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_orientation_Injected(intPtr, value);
		}
	}

	public Matrix4x4 orientationMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_orientationMatrix_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_orientationMatrix_Injected(intPtr, ref value);
		}
	}

	static Tilemap()
	{
		Il2CppClassPointerStore<Tilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "Tilemap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tilemap>.NativeClassPtr);
		NativeFieldInfoPtr_tilemapTileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "tilemapTileChanged");
		NativeFieldInfoPtr_tilemapPositionsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "tilemapPositionsChanged");
		NativeFieldInfoPtr_loopEndedForTileAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "loopEndedForTileAnimation");
		NativeFieldInfoPtr_m_BufferSyncTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "m_BufferSyncTile");
		NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_HasLoopEndedForTileAnimationCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_HandleLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_SendLoopEndedForTileAnimationCallback_Private_Void_NativeArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_GetLoopEndedForTileAnimationCallbackSettings_Internal_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_DoLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_RefreshTile_Injected_Private_Static_Void_IntPtr_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_RefreshTilesNative_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663343);
		get_layoutGrid_InjectedDelegateField = IL2CPP.ResolveICall<get_layoutGrid_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_layoutGrid_Injected");
		get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<get_localBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localBounds_Injected");
		get_localFrameBounds_InjectedDelegateField = IL2CPP.ResolveICall<get_localFrameBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localFrameBounds_Injected");
		get_animationFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<get_animationFrameRate_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_animationFrameRate_Injected");
		set_animationFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<set_animationFrameRate_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_animationFrameRate_Injected");
		get_color_InjectedDelegateField = IL2CPP.ResolveICall<get_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_color_Injected");
		set_color_InjectedDelegateField = IL2CPP.ResolveICall<set_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_color_Injected");
		get_origin_InjectedDelegateField = IL2CPP.ResolveICall<get_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_origin_Injected");
		set_origin_InjectedDelegateField = IL2CPP.ResolveICall<set_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_origin_Injected");
		get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_size_Injected");
		set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_size_Injected");
		get_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<get_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_tileAnchor_Injected");
		set_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_tileAnchor_Injected");
		get_orientation_InjectedDelegateField = IL2CPP.ResolveICall<get_orientation_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientation_Injected");
		set_orientation_InjectedDelegateField = IL2CPP.ResolveICall<set_orientation_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientation_Injected");
		get_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientationMatrix_Injected");
		set_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<set_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientationMatrix_Injected");
		GetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<GetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAsset_Injected");
		GetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<GetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsBlock_Injected");
		GetTileAssetsBlockNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<GetTileAssetsBlockNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsBlockNonAlloc_Injected");
		GetTilesRangeCount_InjectedDelegateField = IL2CPP.ResolveICall<GetTilesRangeCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTilesRangeCount_Injected");
		GetTileAssetsRangeNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<GetTileAssetsRangeNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsRangeNonAlloc_Injected");
		SetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<SetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAsset_Injected");
		SetTileAssets_InjectedDelegateField = IL2CPP.ResolveICall<SetTileAssets_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAssets_Injected");
		INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::INTERNAL_CALL_SetTileAssetsBlock_Injected");
		SetTile_InjectedDelegateField = IL2CPP.ResolveICall<SetTile_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTile_Injected");
		SetTiles_InjectedDelegateField = IL2CPP.ResolveICall<SetTiles_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTiles_Injected");
		RefreshAllTiles_InjectedDelegateField = IL2CPP.ResolveICall<RefreshAllTiles_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RefreshAllTiles_Injected");
		SwapTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<SwapTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SwapTileAsset_Injected");
		ContainsTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<ContainsTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::ContainsTileAsset_Injected");
		GetUsedTilesCount_InjectedDelegateField = IL2CPP.ResolveICall<GetUsedTilesCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetUsedTilesCount_Injected");
		GetUsedSpritesCount_InjectedDelegateField = IL2CPP.ResolveICall<GetUsedSpritesCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetUsedSpritesCount_Injected");
		Internal_GetUsedTilesNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetUsedTilesNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::Internal_GetUsedTilesNonAlloc_Injected");
		Internal_GetUsedSpritesNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetUsedSpritesNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::Internal_GetUsedSpritesNonAlloc_Injected");
		GetSprite_InjectedDelegateField = IL2CPP.ResolveICall<GetSprite_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetSprite_Injected");
		GetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTransformMatrix_Injected");
		SetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<SetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTransformMatrix_Injected");
		GetColor_InjectedDelegateField = IL2CPP.ResolveICall<GetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColor_Injected");
		SetColor_InjectedDelegateField = IL2CPP.ResolveICall<SetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColor_Injected");
		GetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<GetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileFlags_Injected");
		SetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<SetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileFlags_Injected");
		AddTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<AddTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::AddTileFlags_Injected");
		RemoveTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<RemoveTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RemoveTileFlags_Injected");
		GetInstantiatedObject_InjectedDelegateField = IL2CPP.ResolveICall<GetInstantiatedObject_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetInstantiatedObject_Injected");
		GetObjectToInstantiate_InjectedDelegateField = IL2CPP.ResolveICall<GetObjectToInstantiate_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetObjectToInstantiate_Injected");
		SetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<SetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColliderType_Injected");
		GetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColliderType_Injected");
		GetAnimationFrameCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAnimationFrameCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationFrameCount_Injected");
		GetAnimationFrame_InjectedDelegateField = IL2CPP.ResolveICall<GetAnimationFrame_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationFrame_Injected");
		SetAnimationFrame_InjectedDelegateField = IL2CPP.ResolveICall<SetAnimationFrame_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetAnimationFrame_Injected");
		GetAnimationTime_InjectedDelegateField = IL2CPP.ResolveICall<GetAnimationTime_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationTime_Injected");
		SetAnimationTime_InjectedDelegateField = IL2CPP.ResolveICall<SetAnimationTime_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetAnimationTime_Injected");
		GetTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<GetTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAnimationFlags_Injected");
		SetTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<SetTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAnimationFlags_Injected");
		AddTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<AddTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::AddTileAnimationFlags_Injected");
		RemoveTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<RemoveTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RemoveTileAnimationFlags_Injected");
		FloodFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<FloodFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::FloodFillTileAsset_Injected");
		BoxFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<BoxFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::BoxFillTileAsset_Injected");
		InsertCells_InjectedDelegateField = IL2CPP.ResolveICall<InsertCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::InsertCells_Injected");
		DeleteCells_InjectedDelegateField = IL2CPP.ResolveICall<DeleteCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::DeleteCells_Injected");
		ClearAllTiles_InjectedDelegateField = IL2CPP.ResolveICall<ClearAllTiles_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::ClearAllTiles_Injected");
		ResizeBounds_InjectedDelegateField = IL2CPP.ResolveICall<ResizeBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::ResizeBounds_Injected");
		CompressTilemapBounds_InjectedDelegateField = IL2CPP.ResolveICall<CompressTilemapBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::CompressTilemapBounds_Injected");
		SendAndClearSyncTileBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SendAndClearSyncTileBuffer_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SendAndClearSyncTileBuffer_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285396, XrefRangeEnd = 1285398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasLoopEndedForTileAnimationCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLoopEndedForTileAnimationCallback_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285398, XrefRangeEnd = 1285404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleLoopEndedForTileAnimationCallback(int count, System.IntPtr positionsIntPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285410, RefRangeEnd = 1285412, XrefRangeStart = 1285404, XrefRangeEnd = 1285410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)positions));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendLoopEndedForTileAnimationCallback_Private_Void_NativeArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285412, XrefRangeEnd = 1285414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasSyncTileCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285414, XrefRangeEnd = 1285416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasPositionsChangedCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285416, XrefRangeEnd = 1285419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSyncTileCallback(Il2CppReferenceArray<SyncTile> syncTiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syncTiles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285419, XrefRangeEnd = 1285425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandlePositionsChangedCallback(int count, System.IntPtr positionsIntPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285431, RefRangeEnd = 1285433, XrefRangeStart = 1285425, XrefRangeEnd = 1285431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTilemapTileChangedCallback(Il2CppReferenceArray<SyncTile> syncTiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syncTiles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285439, RefRangeEnd = 1285441, XrefRangeStart = 1285433, XrefRangeEnd = 1285439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)positions));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285441, XrefRangeEnd = 1285445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshTile(Vector3Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285445, XrefRangeEnd = 1285450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshTilesNative(void* positions, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)positions;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285450, XrefRangeEnd = 1285452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref hasEndLoopForTileAnimationCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoopEndedForTileAnimationCallbackSettings_Internal_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoLoopEndedForTileAnimationCallback(int count, System.IntPtr positionsIntPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLoopEndedForTileAnimationCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285452, XrefRangeEnd = 1285456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoSyncTileCallback(Il2CppReferenceArray<SyncTile> syncTiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syncTiles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoPositionsChangedCallback(int count, System.IntPtr positionsIntPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285456, XrefRangeEnd = 1285458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshTile_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshTile_Injected_Private_Static_Void_IntPtr_byref_Vector3Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285458, XrefRangeEnd = 1285460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshTilesNative_Injected(System.IntPtr _unity_self, void* positions, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = positions;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshTilesNative_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Tilemap(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_tilemapTileChanged(Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_tilemapTileChanged(Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_tilemapPositionsChanged(Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_tilemapPositionsChanged(Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_loopEndedForTileAnimation(Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_loopEndedForTileAnimation(Il2CppSystem.Action<Tilemap, NativeArray<Vector3Int>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetSyncTileCallback(Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>> callback)
	{
		add_tilemapTileChanged(callback);
	}

	public static void RemoveSyncTileCallback(Il2CppSystem.Action<Tilemap, Il2CppReferenceArray<SyncTile>> callback)
	{
		remove_tilemapTileChanged(callback);
	}

	public Vector3 GetCellCenterLocal(Vector3Int position)
	{
		return CellToLocalInterpolated(position) + CellToLocalInterpolated(tileAnchor);
	}

	public Vector3 GetCellCenterWorld(Vector3Int position)
	{
		return LocalToWorld(CellToLocalInterpolated(position) + CellToLocalInterpolated(tileAnchor));
	}

	public Object GetTileAsset(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Object>(GetTileAsset_Injected(intPtr, ref position));
	}

	public TileBase GetTile(Vector3Int position)
	{
		return ((Il2CppObjectBase)GetTileAsset(position)).TryCast<TileBase>();
	}

	public T GetTile<T>(Vector3Int position) where T : TileBase
	{
		return ((Il2CppObjectBase)((Il2CppObjectBase)GetTileAsset(position)).TryCast<T>()).Cast<T>();
	}

	public Il2CppReferenceArray<Object> GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTileAssetsBlock_Injected(intPtr, ref position, ref blockDimensions);
	}

	public Il2CppReferenceArray<TileBase> GetTilesBlock(BoundsInt bounds)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetTileAssetsBlockNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppReferenceArray<Object> tiles)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTileAssetsBlockNonAlloc_Injected(intPtr, ref startPosition, ref endPosition, tiles);
	}

	public int GetTilesBlockNonAlloc(BoundsInt bounds, Il2CppReferenceArray<TileBase> tiles)
	{
		return GetTileAssetsBlockNonAlloc(bounds.min, bounds.size, (Il2CppReferenceArray<Object>)(object)tiles);
	}

	public int GetTilesRangeCount(Vector3Int startPosition, Vector3Int endPosition)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTilesRangeCount_Injected(intPtr, ref startPosition, ref endPosition);
	}

	public unsafe int GetTileAssetsRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppStructArray<Vector3Int> positions, Il2CppReferenceArray<Object> tiles)
	{
		//IL_001c: Expected O, but got Ref
		//IL_0023: Expected O, but got Ref
		//IL_002f: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3Int> span);
		((Il2CppSystem.Span<Vector3Int>)(&span))._002Ector((Il2CppArrayBase<Vector3Int>)(object)positions);
		int tileAssetsRangeNonAlloc_Injected;
		fixed (Vector3Int* begin = &((Il2CppSystem.Span<Vector3Int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3Int>)(&span)).Length);
			tileAssetsRangeNonAlloc_Injected = GetTileAssetsRangeNonAlloc_Injected(intPtr, ref startPosition, ref endPosition, ref positions2, tiles);
		}
		return tileAssetsRangeNonAlloc_Injected;
	}

	public int GetTilesRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppStructArray<Vector3Int> positions, Il2CppReferenceArray<TileBase> tiles)
	{
		return GetTileAssetsRangeNonAlloc(startPosition, endPosition, positions, (Il2CppReferenceArray<Object>)(object)tiles);
	}

	public void SetTileAsset(Vector3Int position, Object tile)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTileAsset_Injected(intPtr, ref position, MarshalledUnityObject.Marshal(tile));
	}

	public void SetTile(Vector3Int position, TileBase tile)
	{
		SetTileAsset(position, tile);
	}

	public unsafe void SetTileAssets(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<Object> tileArray)
	{
		//IL_0018: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3Int> span);
		((Il2CppSystem.Span<Vector3Int>)(&span))._002Ector((Il2CppArrayBase<Vector3Int>)(object)positionArray);
		fixed (Vector3Int* begin = &((Il2CppSystem.Span<Vector3Int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper positionArray2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3Int>)(&span)).Length);
			SetTileAssets_Injected(intPtr, ref positionArray2, tileArray);
		}
	}

	public void SetTiles(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<TileBase> tileArray)
	{
		SetTileAssets(positionArray, (Il2CppReferenceArray<Object>)(object)tileArray);
	}

	public void INTERNAL_CALL_SetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		INTERNAL_CALL_SetTileAssetsBlock_Injected(intPtr, ref position, ref blockDimensions, tileArray);
	}

	public void SetTilesBlock(BoundsInt position, Il2CppReferenceArray<TileBase> tileArray)
	{
		INTERNAL_CALL_SetTileAssetsBlock(position.min, position.size, (Il2CppReferenceArray<Object>)(object)tileArray);
	}

	public void SetTile(TileChangeData tileChangeData, bool ignoreLockFlags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTile_Injected(intPtr, ref tileChangeData, ignoreLockFlags);
	}

	public void SetTiles(Il2CppReferenceArray<TileChangeData> tileChangeDataArray, bool ignoreLockFlags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTiles_Injected(intPtr, tileChangeDataArray, ignoreLockFlags);
	}

	public bool HasTile(Vector3Int position)
	{
		return GetTileAsset(position) != null;
	}

	public void RefreshAllTiles()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RefreshAllTiles_Injected(intPtr);
	}

	public void SwapTileAsset(Object changeTile, Object newTile)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SwapTileAsset_Injected(intPtr, MarshalledUnityObject.Marshal(changeTile), MarshalledUnityObject.Marshal(newTile));
	}

	public void SwapTile(TileBase changeTile, TileBase newTile)
	{
		SwapTileAsset(changeTile, newTile);
	}

	public bool ContainsTileAsset(Object tileAsset)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ContainsTileAsset_Injected(intPtr, MarshalledUnityObject.Marshal(tileAsset));
	}

	public bool ContainsTile(TileBase tileAsset)
	{
		return ContainsTileAsset(tileAsset);
	}

	public int GetUsedTilesCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetUsedTilesCount_Injected(intPtr);
	}

	public int GetUsedSpritesCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetUsedSpritesCount_Injected(intPtr);
	}

	public int GetUsedTilesNonAlloc(Il2CppReferenceArray<TileBase> usedTiles)
	{
		return Internal_GetUsedTilesNonAlloc((Il2CppReferenceArray<Object>)(object)usedTiles);
	}

	public int GetUsedSpritesNonAlloc(Il2CppReferenceArray<Sprite> usedSprites)
	{
		return Internal_GetUsedSpritesNonAlloc((Il2CppReferenceArray<Object>)(object)usedSprites);
	}

	public int Internal_GetUsedTilesNonAlloc(Il2CppReferenceArray<Object> usedTiles)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_GetUsedTilesNonAlloc_Injected(intPtr, usedTiles);
	}

	public int Internal_GetUsedSpritesNonAlloc(Il2CppReferenceArray<Object> usedSprites)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_GetUsedSpritesNonAlloc_Injected(intPtr, usedSprites);
	}

	public Sprite GetSprite(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Sprite>(GetSprite_Injected(intPtr, ref position));
	}

	public Matrix4x4 GetTransformMatrix(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetTransformMatrix_Injected(intPtr, ref position, out var ret);
		return ret;
	}

	public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTransformMatrix_Injected(intPtr, ref position, ref transform);
	}

	public Color GetColor(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetColor_Injected(intPtr, ref position, out var ret);
		return ret;
	}

	public void SetColor(Vector3Int position, Color color)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetColor_Injected(intPtr, ref position, ref color);
	}

	public TileFlags GetTileFlags(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTileFlags_Injected(intPtr, ref position);
	}

	public void SetTileFlags(Vector3Int position, TileFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTileFlags_Injected(intPtr, ref position, flags);
	}

	public void AddTileFlags(Vector3Int position, TileFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddTileFlags_Injected(intPtr, ref position, flags);
	}

	public void RemoveTileFlags(Vector3Int position, TileFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveTileFlags_Injected(intPtr, ref position, flags);
	}

	public GameObject GetInstantiatedObject(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<GameObject>(GetInstantiatedObject_Injected(intPtr, ref position));
	}

	public GameObject GetObjectToInstantiate(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<GameObject>(GetObjectToInstantiate_Injected(intPtr, ref position));
	}

	public void SetColliderType(Vector3Int position, Tile.ColliderType colliderType)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetColliderType_Injected(intPtr, ref position, colliderType);
	}

	public Tile.ColliderType GetColliderType(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetColliderType_Injected(intPtr, ref position);
	}

	public int GetAnimationFrameCount(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAnimationFrameCount_Injected(intPtr, ref position);
	}

	public int GetAnimationFrame(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAnimationFrame_Injected(intPtr, ref position);
	}

	public void SetAnimationFrame(Vector3Int position, int frame)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetAnimationFrame_Injected(intPtr, ref position, frame);
	}

	public float GetAnimationTime(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAnimationTime_Injected(intPtr, ref position);
	}

	public void SetAnimationTime(Vector3Int position, float time)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetAnimationTime_Injected(intPtr, ref position, time);
	}

	public TileAnimationFlags GetTileAnimationFlags(Vector3Int position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTileAnimationFlags_Injected(intPtr, ref position);
	}

	public void SetTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTileAnimationFlags_Injected(intPtr, ref position, flags);
	}

	public void AddTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddTileAnimationFlags_Injected(intPtr, ref position, flags);
	}

	public void RemoveTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RemoveTileAnimationFlags_Injected(intPtr, ref position, flags);
	}

	public void FloodFill(Vector3Int position, TileBase tile)
	{
		FloodFillTileAsset(position, tile);
	}

	public void FloodFillTileAsset(Vector3Int position, Object tile)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		FloodFillTileAsset_Injected(intPtr, ref position, MarshalledUnityObject.Marshal(tile));
	}

	public void BoxFill(Vector3Int position, TileBase tile, int startX, int startY, int endX, int endY)
	{
		BoxFillTileAsset(position, tile, startX, startY, endX, endY);
	}

	public void BoxFillTileAsset(Vector3Int position, Object tile, int startX, int startY, int endX, int endY)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		BoxFillTileAsset_Injected(intPtr, ref position, MarshalledUnityObject.Marshal(tile), startX, startY, endX, endY);
	}

	public void InsertCells(Vector3Int position, Vector3Int insertCells)
	{
		InsertCells(position, insertCells.x, insertCells.y, insertCells.z);
	}

	public void InsertCells(Vector3Int position, int numColumns, int numRows, int numLayers)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		InsertCells_Injected(intPtr, ref position, numColumns, numRows, numLayers);
	}

	public void DeleteCells(Vector3Int position, Vector3Int deleteCells)
	{
		DeleteCells(position, deleteCells.x, deleteCells.y, deleteCells.z);
	}

	public void DeleteCells(Vector3Int position, int numColumns, int numRows, int numLayers)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		DeleteCells_Injected(intPtr, ref position, numColumns, numRows, numLayers);
	}

	public void ClearAllTiles()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearAllTiles_Injected(intPtr);
	}

	public void ResizeBounds()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResizeBounds_Injected(intPtr);
	}

	public void CompressTilemapBounds(bool keepEditorPreview)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CompressTilemapBounds_Injected(intPtr, keepEditorPreview);
	}

	public void CompressBounds()
	{
		CompressTilemapBounds(keepEditorPreview: false);
	}

	public void SendAndClearSyncTileBuffer()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SendAndClearSyncTileBuffer_Injected(intPtr);
	}

	public static System.IntPtr get_layoutGrid_Injected(System.IntPtr _unity_self)
	{
		return get_layoutGrid_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_localBounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		get_localBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_localFrameBounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		get_localFrameBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float get_animationFrameRate_Injected(System.IntPtr _unity_self)
	{
		return get_animationFrameRate_InjectedDelegateField(_unity_self);
	}

	public static void set_animationFrameRate_Injected(System.IntPtr _unity_self, float value)
	{
		set_animationFrameRate_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_color_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_color_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_origin_Injected(System.IntPtr _unity_self, out Vector3Int ret)
	{
		get_origin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_origin_Injected(System.IntPtr _unity_self, [In] ref Vector3Int value)
	{
		set_origin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_size_Injected(System.IntPtr _unity_self, out Vector3Int ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(System.IntPtr _unity_self, [In] ref Vector3Int value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_tileAnchor_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_tileAnchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_tileAnchor_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_tileAnchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static Orientation get_orientation_Injected(System.IntPtr _unity_self)
	{
		return get_orientation_InjectedDelegateField(_unity_self);
	}

	public static void set_orientation_Injected(System.IntPtr _unity_self, Orientation value)
	{
		set_orientation_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_orientationMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_orientationMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_orientationMatrix_Injected(System.IntPtr _unity_self, [In] ref Matrix4x4 value)
	{
		set_orientationMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static System.IntPtr GetTileAsset_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetTileAsset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static Il2CppReferenceArray<Object> GetTileAssetsBlock_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, [In] ref Vector3Int blockDimensions)
	{
		System.IntPtr intPtr = GetTileAssetsBlock_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref blockDimensions));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr) : null;
	}

	public unsafe static int GetTileAssetsBlockNonAlloc_Injected(System.IntPtr _unity_self, [In] ref Vector3Int startPosition, [In] ref Vector3Int endPosition, Il2CppReferenceArray<Object> tiles)
	{
		return GetTileAssetsBlockNonAlloc_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref startPosition), (nint)Unsafe.AsPointer(ref endPosition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles));
	}

	public unsafe static int GetTilesRangeCount_Injected(System.IntPtr _unity_self, [In] ref Vector3Int startPosition, [In] ref Vector3Int endPosition)
	{
		return GetTilesRangeCount_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref startPosition), (nint)Unsafe.AsPointer(ref endPosition));
	}

	public unsafe static int GetTileAssetsRangeNonAlloc_Injected(System.IntPtr _unity_self, [In] ref Vector3Int startPosition, [In] ref Vector3Int endPosition, ref ManagedSpanWrapper positions, Il2CppReferenceArray<Object> tiles)
	{
		return GetTileAssetsRangeNonAlloc_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref startPosition), (nint)Unsafe.AsPointer(ref endPosition), (nint)Unsafe.AsPointer(ref positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles));
	}

	public unsafe static void SetTileAsset_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, System.IntPtr tile)
	{
		SetTileAsset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), tile);
	}

	public unsafe static void SetTileAssets_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positionArray, Il2CppReferenceArray<Object> tileArray)
	{
		SetTileAssets_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positionArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileArray));
	}

	public unsafe static void INTERNAL_CALL_SetTileAssetsBlock_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, [In] ref Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
	{
		INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref blockDimensions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileArray));
	}

	public unsafe static void SetTile_Injected(System.IntPtr _unity_self, [In] ref TileChangeData tileChangeData, bool ignoreLockFlags)
	{
		SetTile_InjectedDelegate setTile_InjectedDelegateField = SetTile_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileChangeData);
		setTile_InjectedDelegateField(_unity_self, (nint)(&intPtr), ignoreLockFlags);
	}

	public static void SetTiles_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<TileChangeData> tileChangeDataArray, bool ignoreLockFlags)
	{
		SetTiles_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tileChangeDataArray), ignoreLockFlags);
	}

	public static void RefreshAllTiles_Injected(System.IntPtr _unity_self)
	{
		RefreshAllTiles_InjectedDelegateField(_unity_self);
	}

	public static void SwapTileAsset_Injected(System.IntPtr _unity_self, System.IntPtr changeTile, System.IntPtr newTile)
	{
		SwapTileAsset_InjectedDelegateField(_unity_self, changeTile, newTile);
	}

	public static bool ContainsTileAsset_Injected(System.IntPtr _unity_self, System.IntPtr tileAsset)
	{
		return ContainsTileAsset_InjectedDelegateField(_unity_self, tileAsset);
	}

	public static int GetUsedTilesCount_Injected(System.IntPtr _unity_self)
	{
		return GetUsedTilesCount_InjectedDelegateField(_unity_self);
	}

	public static int GetUsedSpritesCount_Injected(System.IntPtr _unity_self)
	{
		return GetUsedSpritesCount_InjectedDelegateField(_unity_self);
	}

	public static int Internal_GetUsedTilesNonAlloc_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Object> usedTiles)
	{
		return Internal_GetUsedTilesNonAlloc_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usedTiles));
	}

	public static int Internal_GetUsedSpritesNonAlloc_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Object> usedSprites)
	{
		return Internal_GetUsedSpritesNonAlloc_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usedSprites));
	}

	public unsafe static System.IntPtr GetSprite_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetSprite_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void GetTransformMatrix_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, out Matrix4x4 ret)
	{
		GetTransformMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetTransformMatrix_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, [In] ref Matrix4x4 transform)
	{
		SetTransformMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref transform));
	}

	public unsafe static void GetColor_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, out Color ret)
	{
		GetColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetColor_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, [In] ref Color color)
	{
		SetColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref color));
	}

	public unsafe static TileFlags GetTileFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetTileFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void SetTileFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileFlags flags)
	{
		SetTileFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static void AddTileFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileFlags flags)
	{
		AddTileFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static void RemoveTileFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileFlags flags)
	{
		RemoveTileFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static System.IntPtr GetInstantiatedObject_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetInstantiatedObject_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static System.IntPtr GetObjectToInstantiate_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetObjectToInstantiate_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void SetColliderType_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, Tile.ColliderType colliderType)
	{
		SetColliderType_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), colliderType);
	}

	public unsafe static Tile.ColliderType GetColliderType_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetColliderType_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static int GetAnimationFrameCount_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetAnimationFrameCount_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static int GetAnimationFrame_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetAnimationFrame_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void SetAnimationFrame_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, int frame)
	{
		SetAnimationFrame_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), frame);
	}

	public unsafe static float GetAnimationTime_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetAnimationTime_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void SetAnimationTime_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, float time)
	{
		SetAnimationTime_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), time);
	}

	public unsafe static TileAnimationFlags GetTileAnimationFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position)
	{
		return GetTileAnimationFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void SetTileAnimationFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileAnimationFlags flags)
	{
		SetTileAnimationFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static void AddTileAnimationFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileAnimationFlags flags)
	{
		AddTileAnimationFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static void RemoveTileAnimationFlags_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, TileAnimationFlags flags)
	{
		RemoveTileAnimationFlags_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), flags);
	}

	public unsafe static void FloodFillTileAsset_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, System.IntPtr tile)
	{
		FloodFillTileAsset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), tile);
	}

	public unsafe static void BoxFillTileAsset_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, System.IntPtr tile, int startX, int startY, int endX, int endY)
	{
		BoxFillTileAsset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), tile, startX, startY, endX, endY);
	}

	public unsafe static void InsertCells_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, int numColumns, int numRows, int numLayers)
	{
		InsertCells_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), numColumns, numRows, numLayers);
	}

	public unsafe static void DeleteCells_Injected(System.IntPtr _unity_self, [In] ref Vector3Int position, int numColumns, int numRows, int numLayers)
	{
		DeleteCells_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), numColumns, numRows, numLayers);
	}

	public static void ClearAllTiles_Injected(System.IntPtr _unity_self)
	{
		ClearAllTiles_InjectedDelegateField(_unity_self);
	}

	public static void ResizeBounds_Injected(System.IntPtr _unity_self)
	{
		ResizeBounds_InjectedDelegateField(_unity_self);
	}

	public static void CompressTilemapBounds_Injected(System.IntPtr _unity_self, bool keepEditorPreview)
	{
		CompressTilemapBounds_InjectedDelegateField(_unity_self, keepEditorPreview);
	}

	public static void SendAndClearSyncTileBuffer_Injected(System.IntPtr _unity_self)
	{
		SendAndClearSyncTileBuffer_InjectedDelegateField(_unity_self);
	}
}
