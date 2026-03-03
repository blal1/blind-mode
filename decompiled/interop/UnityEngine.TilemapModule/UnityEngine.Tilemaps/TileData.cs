using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Tilemaps;

[StructLayout(LayoutKind.Explicit)]
public struct TileData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Sprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColliderType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0;

	[FieldOffset(0)]
	public int m_Sprite;

	[FieldOffset(4)]
	public Color m_Color;

	[FieldOffset(20)]
	public Matrix4x4 m_Transform;

	[FieldOffset(84)]
	public int m_GameObject;

	[FieldOffset(88)]
	public TileFlags m_Flags;

	[FieldOffset(92)]
	public Tile.ColliderType m_ColliderType;

	public unsafe static TileData Default
	{
		get
		{
			Unsafe.SkipInit(out TileData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)(&value));
		}
	}

	public unsafe Sprite sprite
	{
		get
		{
			return ((Il2CppObjectBase)Object.ForceLoadFromInstanceID(m_Sprite)).TryCast<Sprite>();
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285484, XrefRangeEnd = 1285489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color color
	{
		get
		{
			return m_Color;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Matrix4x4 transform
	{
		get
		{
			return m_Transform;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GameObject gameObject
	{
		get
		{
			return ((Il2CppObjectBase)Object.ForceLoadFromInstanceID(m_GameObject)).TryCast<GameObject>();
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285489, XrefRangeEnd = 1285494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TileFlags flags
	{
		get
		{
			return m_Flags;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293993, RefRangeEnd = 293998, XrefRangeStart = 293993, XrefRangeEnd = 293998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Tile.ColliderType colliderType
	{
		get
		{
			return m_ColliderType;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TileData()
	{
		Il2CppClassPointerStore<TileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileData>.NativeClassPtr);
		NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Sprite");
		NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Color");
		NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Transform");
		NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_GameObject");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_ColliderType");
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "Default");
		NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663354);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285494, XrefRangeEnd = 1285499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TileData CreateDefault()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefault_Private_Static_TileData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TileData*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
