using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TerrainUtils;

public class TerrainMap : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.TerrainUtils.TerrainMap+<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_groupID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0;

		public unsafe int groupID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupID)) = value;
			}
		}

		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr);
			NativeFieldInfoPtr_groupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "groupID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100663337);
			NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100663338);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272145, XrefRangeEnd = 1272149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CreateFromPlacement_b__0(Terrain x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass3_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class _003C_003Ec__DisplayClass3_0
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_patchSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_errorCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_terrainTiles;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0;

	public unsafe Vector3 m_patchSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_patchSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_patchSize)) = value;
		}
	}

	public unsafe TerrainMapStatusCode m_errorCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_errorCode);
			return *(TerrainMapStatusCode*)num;
		}
		set
		{
			*(TerrainMapStatusCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_errorCode)) = value;
		}
	}

	public unsafe Dictionary<TerrainTileCoord, Terrain> m_terrainTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_terrainTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TerrainTileCoord, Terrain>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_terrainTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<TerrainTileCoord, Terrain> terrainTiles
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TerrainTileCoord, Terrain>>(intPtr2) : null;
		}
	}

	static TerrainMap()
	{
		Il2CppClassPointerStore<TerrainMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.TerrainUtils", "TerrainMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr);
		NativeFieldInfoPtr_m_patchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_patchSize");
		NativeFieldInfoPtr_m_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_errorCode");
		NativeFieldInfoPtr_m_terrainTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_terrainTiles");
		NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663336);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1272152, RefRangeEnd = 1272163, XrefRangeStart = 1272149, XrefRangeEnd = 1272152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Terrain GetTerrain(int tileX, int tileZ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tileX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileZ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272229, RefRangeEnd = 1272230, XrefRangeStart = 1272163, XrefRangeEnd = 1272229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TerrainMap CreateFromPlacement(Terrain originTerrain, Il2CppSystem.Predicate<Terrain> filter = null, bool fullValidation = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originTerrain);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullValidation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainMap>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272269, RefRangeEnd = 1272270, XrefRangeStart = 1272230, XrefRangeEnd = 1272269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Il2CppSystem.Predicate<Terrain> filter = null, bool fullValidation = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&gridOrigin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gridSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullValidation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainMap>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272270, XrefRangeEnd = 1272278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272314, RefRangeEnd = 1272315, XrefRangeStart = 1272278, XrefRangeEnd = 1272314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTerrainInternal(int x, int z, Terrain terrain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272328, RefRangeEnd = 1272329, XrefRangeStart = 1272315, XrefRangeEnd = 1272328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tileX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileZ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272434, RefRangeEnd = 1272435, XrefRangeStart = 1272329, XrefRangeEnd = 1272434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateTerrain(int tileX, int tileZ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tileX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileZ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272453, RefRangeEnd = 1272454, XrefRangeStart = 1272435, XrefRangeEnd = 1272453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainMapStatusCode Validate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TerrainMapStatusCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TerrainMap(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static TerrainMap CreateFromConnectedNeighbors(Terrain originTerrain, [Optional] Il2CppSystem.Predicate<Terrain> filter, [Optional] bool fullValidation)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
