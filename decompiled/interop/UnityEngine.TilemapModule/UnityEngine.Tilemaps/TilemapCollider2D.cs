using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps;

public sealed class TilemapCollider2D : Collider2D
{
	private delegate bool get_useDelaunayMesh_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useDelaunayMesh_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate uint get_maximumTileChangeCount_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maximumTileChangeCount_InjectedDelegate(IntPtr _unity_self, uint value);

	private delegate float get_extrusionFactor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_extrusionFactor_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_hasTilemapChanges_InjectedDelegate(IntPtr _unity_self);

	private delegate void ProcessTilemapChanges_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_useDelaunayMesh_InjectedDelegate get_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_useDelaunayMesh_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_useDelaunayMesh_Injected");

	private static readonly set_useDelaunayMesh_InjectedDelegate set_useDelaunayMesh_InjectedDelegateField = IL2CPP.ResolveICall<set_useDelaunayMesh_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_useDelaunayMesh_Injected");

	private static readonly get_maximumTileChangeCount_InjectedDelegate get_maximumTileChangeCount_InjectedDelegateField = IL2CPP.ResolveICall<get_maximumTileChangeCount_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_maximumTileChangeCount_Injected");

	private static readonly set_maximumTileChangeCount_InjectedDelegate set_maximumTileChangeCount_InjectedDelegateField = IL2CPP.ResolveICall<set_maximumTileChangeCount_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_maximumTileChangeCount_Injected");

	private static readonly get_extrusionFactor_InjectedDelegate get_extrusionFactor_InjectedDelegateField = IL2CPP.ResolveICall<get_extrusionFactor_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_extrusionFactor_Injected");

	private static readonly set_extrusionFactor_InjectedDelegate set_extrusionFactor_InjectedDelegateField = IL2CPP.ResolveICall<set_extrusionFactor_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::set_extrusionFactor_Injected");

	private static readonly get_hasTilemapChanges_InjectedDelegate get_hasTilemapChanges_InjectedDelegateField = IL2CPP.ResolveICall<get_hasTilemapChanges_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::get_hasTilemapChanges_Injected");

	private static readonly ProcessTilemapChanges_InjectedDelegate ProcessTilemapChanges_InjectedDelegateField = IL2CPP.ResolveICall<ProcessTilemapChanges_InjectedDelegate>("UnityEngine.Tilemaps.TilemapCollider2D::ProcessTilemapChanges_Injected");

	public bool useDelaunayMesh
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useDelaunayMesh_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useDelaunayMesh_Injected(intPtr, value);
		}
	}

	public uint maximumTileChangeCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maximumTileChangeCount_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maximumTileChangeCount_Injected(intPtr, value);
		}
	}

	public float extrusionFactor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_extrusionFactor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_extrusionFactor_Injected(intPtr, value);
		}
	}

	public bool hasTilemapChanges
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasTilemapChanges_Injected(intPtr);
		}
	}

	public void ProcessTilemapChanges()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ProcessTilemapChanges_Injected(intPtr);
	}

	public static bool get_useDelaunayMesh_Injected(IntPtr _unity_self)
	{
		return get_useDelaunayMesh_InjectedDelegateField(_unity_self);
	}

	public static void set_useDelaunayMesh_Injected(IntPtr _unity_self, bool value)
	{
		set_useDelaunayMesh_InjectedDelegateField(_unity_self, value);
	}

	public static uint get_maximumTileChangeCount_Injected(IntPtr _unity_self)
	{
		return get_maximumTileChangeCount_InjectedDelegateField(_unity_self);
	}

	public static void set_maximumTileChangeCount_Injected(IntPtr _unity_self, uint value)
	{
		set_maximumTileChangeCount_InjectedDelegateField(_unity_self, value);
	}

	public static float get_extrusionFactor_Injected(IntPtr _unity_self)
	{
		return get_extrusionFactor_InjectedDelegateField(_unity_self);
	}

	public static void set_extrusionFactor_Injected(IntPtr _unity_self, float value)
	{
		set_extrusionFactor_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_hasTilemapChanges_Injected(IntPtr _unity_self)
	{
		return get_hasTilemapChanges_InjectedDelegateField(_unity_self);
	}

	public static void ProcessTilemapChanges_Injected(IntPtr _unity_self)
	{
		ProcessTilemapChanges_InjectedDelegateField(_unity_self);
	}
}
