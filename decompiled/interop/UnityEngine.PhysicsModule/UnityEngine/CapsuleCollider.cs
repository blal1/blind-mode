using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class CapsuleCollider : Collider
{
	private delegate void get_center_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_center_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_radius_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_height_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_height_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_direction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_direction_InjectedDelegate(IntPtr _unity_self, int value);

	private static readonly get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<get_center_InjectedDelegate>("UnityEngine.CapsuleCollider::get_center_Injected");

	private static readonly set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<set_center_InjectedDelegate>("UnityEngine.CapsuleCollider::set_center_Injected");

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.CapsuleCollider::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.CapsuleCollider::set_radius_Injected");

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.CapsuleCollider::get_height_Injected");

	private static readonly set_height_InjectedDelegate set_height_InjectedDelegateField = IL2CPP.ResolveICall<set_height_InjectedDelegate>("UnityEngine.CapsuleCollider::set_height_Injected");

	private static readonly get_direction_InjectedDelegate get_direction_InjectedDelegateField = IL2CPP.ResolveICall<get_direction_InjectedDelegate>("UnityEngine.CapsuleCollider::get_direction_Injected");

	private static readonly set_direction_InjectedDelegate set_direction_InjectedDelegateField = IL2CPP.ResolveICall<set_direction_InjectedDelegate>("UnityEngine.CapsuleCollider::set_direction_Injected");

	public Vector3 center
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_center_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_center_Injected(intPtr, ref value);
		}
	}

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

	public float height
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_height_Injected(intPtr, value);
		}
	}

	public int direction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_direction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_direction_Injected(intPtr, value);
		}
	}

	public unsafe static void get_center_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_center_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_radius_Injected(IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_height_Injected(IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static void set_height_Injected(IntPtr _unity_self, float value)
	{
		set_height_InjectedDelegateField(_unity_self, value);
	}

	public static int get_direction_Injected(IntPtr _unity_self)
	{
		return get_direction_InjectedDelegateField(_unity_self);
	}

	public static void set_direction_Injected(IntPtr _unity_self, int value)
	{
		set_direction_InjectedDelegateField(_unity_self, value);
	}
}
