using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Tilemaps;

public class ITilemap : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Tilemap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AddToList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshPos;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0;

	public unsafe static ITilemap s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITilemap>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tilemap m_Tilemap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tilemap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tilemap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Tilemap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_AddToList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddToList);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddToList)) = value;
		}
	}

	public unsafe int m_RefreshCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RefreshCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RefreshCount)) = value;
		}
	}

	public unsafe NativeArray<Vector3Int> m_RefreshPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RefreshPos);
			return new NativeArray<Vector3Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3Int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RefreshPos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3Int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public Vector3Int origin => m_Tilemap.origin;

	public Vector3Int size => m_Tilemap.size;

	public Bounds localBounds => m_Tilemap.localBounds;

	public BoundsInt cellBounds => m_Tilemap.cellBounds;

	static ITilemap()
	{
		Il2CppClassPointerStore<ITilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "ITilemap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITilemap>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_Tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_Tilemap");
		NativeFieldInfoPtr_m_AddToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_AddToList");
		NativeFieldInfoPtr_m_RefreshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_RefreshCount");
		NativeFieldInfoPtr_m_RefreshPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_RefreshPos");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663301);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ITilemap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITilemap>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285303, XrefRangeEnd = 1285311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285311, XrefRangeEnd = 1285319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ITilemap CreateInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITilemap>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285319, XrefRangeEnd = 1285352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FindAllRefreshPositions(ITilemap tilemap, int count, System.IntPtr oldTilesIntPtr, System.IntPtr newTilesIntPtr, System.IntPtr positionsIntPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldTilesIntPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTilesIntPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285352, XrefRangeEnd = 1285371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAllTileData(ITilemap tilemap, int count, System.IntPtr tilesIntPtr, System.IntPtr positionsIntPtr, System.IntPtr outTileDataIntPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tilemap);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tilesIntPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionsIntPtr;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outTileDataIntPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ITilemap(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator ITilemap(Tilemap tilemap)
	{
		return new ITilemap(tilemap);
	}

	public void SetTilemapInstance(Tilemap tilemap)
	{
		m_Tilemap = tilemap;
	}

	public virtual Sprite GetSprite(Vector3Int position)
	{
		return m_Tilemap.GetSprite(position);
	}

	public virtual Color GetColor(Vector3Int position)
	{
		return m_Tilemap.GetColor(position);
	}

	public virtual Matrix4x4 GetTransformMatrix(Vector3Int position)
	{
		return m_Tilemap.GetTransformMatrix(position);
	}

	public virtual TileFlags GetTileFlags(Vector3Int position)
	{
		return m_Tilemap.GetTileFlags(position);
	}

	public virtual TileBase GetTile(Vector3Int position)
	{
		return m_Tilemap.GetTile(position);
	}

	public virtual T GetTile<T>(Vector3Int position) where T : TileBase
	{
		return m_Tilemap.GetTile<T>(position);
	}

	public T GetComponent<T>()
	{
		if (Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Tilemap>()))
		{
			return ((Il2CppObjectBase)m_Tilemap).Cast<T>();
		}
		return m_Tilemap.GetComponent<T>();
	}
}
