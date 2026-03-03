using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CircleCollider2D : Collider2D
{
	private delegate float get_radius_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.CircleCollider2D::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.CircleCollider2D::set_radius_Injected");

	public float radius
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public Vector2 center
	{
		get
		{
			return Vector2.zero;
		}
		set
		{
		}
	}

	public static float get_radius_Injected(IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}
}
