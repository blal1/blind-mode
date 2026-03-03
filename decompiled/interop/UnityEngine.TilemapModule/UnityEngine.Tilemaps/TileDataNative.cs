using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps;

[StructLayout(LayoutKind.Explicit)]
public struct TileDataNative
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Sprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColliderType;

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

	public int sprite
	{
		get
		{
			return m_Sprite;
		}
		set
		{
			m_Sprite = value;
		}
	}

	public Color color
	{
		get
		{
			return m_Color;
		}
		set
		{
			m_Color = value;
		}
	}

	public Matrix4x4 transform
	{
		get
		{
			return m_Transform;
		}
		set
		{
			m_Transform = value;
		}
	}

	public int gameObject
	{
		get
		{
			return m_GameObject;
		}
		set
		{
			m_GameObject = value;
		}
	}

	public TileFlags flags
	{
		get
		{
			return m_Flags;
		}
		set
		{
			m_Flags = value;
		}
	}

	public Tile.ColliderType colliderType
	{
		get
		{
			return m_ColliderType;
		}
		set
		{
			m_ColliderType = value;
		}
	}

	static TileDataNative()
	{
		Il2CppClassPointerStore<TileDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileDataNative");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr);
		NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Sprite");
		NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Color");
		NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Transform");
		NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_GameObject");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, "m_ColliderType");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDataNative>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static implicit operator TileDataNative(TileData td)
	{
		TileDataNative result = default(TileDataNative);
		result.sprite = ((td.sprite != null) ? td.sprite.GetInstanceID() : 0);
		result.color = td.color;
		result.transform = td.transform;
		result.gameObject = ((td.gameObject != null) ? td.gameObject.GetInstanceID() : 0);
		result.flags = td.flags;
		result.colliderType = td.colliderType;
		return result;
	}
}
