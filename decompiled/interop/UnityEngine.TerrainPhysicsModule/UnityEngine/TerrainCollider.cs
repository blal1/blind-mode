using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class TerrainCollider : Collider
{
	private delegate System.IntPtr get_terrainData_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_terrainData_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void Raycast_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr ray, float maxDistance, bool hitHoles, System.IntPtr hasHit, [Out] System.IntPtr ret);

	private static readonly get_terrainData_InjectedDelegate get_terrainData_InjectedDelegateField = IL2CPP.ResolveICall<get_terrainData_InjectedDelegate>("UnityEngine.TerrainCollider::get_terrainData_Injected");

	private static readonly set_terrainData_InjectedDelegate set_terrainData_InjectedDelegateField = IL2CPP.ResolveICall<set_terrainData_InjectedDelegate>("UnityEngine.TerrainCollider::set_terrainData_Injected");

	private static readonly Raycast_InjectedDelegate Raycast_InjectedDelegateField = IL2CPP.ResolveICall<Raycast_InjectedDelegate>("UnityEngine.TerrainCollider::Raycast_Injected");

	public TerrainData terrainData
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<TerrainData>(get_terrainData_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_terrainData_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public RaycastHit Raycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Raycast_Injected(intPtr, ref ray, maxDistance, hitHoles, ref hasHit, out var ret);
		return ret;
	}

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, bool hitHoles)
	{
		bool hasHit = false;
		hitInfo = Raycast(ray, maxDistance, hitHoles, ref hasHit);
		return hasHit;
	}

	public static System.IntPtr get_terrainData_Injected(System.IntPtr _unity_self)
	{
		return get_terrainData_InjectedDelegateField(_unity_self);
	}

	public static void set_terrainData_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_terrainData_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Raycast_Injected(System.IntPtr _unity_self, [In] ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret)
	{
		Raycast_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ray), maxDistance, hitHoles, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hasHit), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
