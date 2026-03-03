using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CapsuleCollider2D : Collider2D
{
	private delegate void get_size_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_size_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate CapsuleDirection2D get_direction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_direction_InjectedDelegate(IntPtr _unity_self, CapsuleDirection2D value);

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::get_size_Injected");

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.CapsuleCollider2D::set_size_Injected");

	private static readonly get_direction_InjectedDelegate get_direction_InjectedDelegateField = IL2CPP.ResolveICall<get_direction_InjectedDelegate>("UnityEngine.CapsuleCollider2D::get_direction_Injected");

	private static readonly set_direction_InjectedDelegate set_direction_InjectedDelegateField = IL2CPP.ResolveICall<set_direction_InjectedDelegate>("UnityEngine.CapsuleCollider2D::set_direction_Injected");

	public Vector2 size
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_size_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, ref value);
		}
	}

	public CapsuleDirection2D direction
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

	public unsafe static void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static CapsuleDirection2D get_direction_Injected(IntPtr _unity_self)
	{
		return get_direction_InjectedDelegateField(_unity_self);
	}

	public static void set_direction_Injected(IntPtr _unity_self, CapsuleDirection2D value)
	{
		set_direction_InjectedDelegateField(_unity_self, value);
	}
}
