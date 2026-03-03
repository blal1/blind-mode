using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class BoxCollider2D : Collider2D
{
	private delegate void get_size_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_size_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_edgeRadius_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_edgeRadius_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_autoTiling_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoTiling_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.BoxCollider2D::get_size_Injected");

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.BoxCollider2D::set_size_Injected");

	private static readonly get_edgeRadius_InjectedDelegate get_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<get_edgeRadius_InjectedDelegate>("UnityEngine.BoxCollider2D::get_edgeRadius_Injected");

	private static readonly set_edgeRadius_InjectedDelegate set_edgeRadius_InjectedDelegateField = IL2CPP.ResolveICall<set_edgeRadius_InjectedDelegate>("UnityEngine.BoxCollider2D::set_edgeRadius_Injected");

	private static readonly get_autoTiling_InjectedDelegate get_autoTiling_InjectedDelegateField = IL2CPP.ResolveICall<get_autoTiling_InjectedDelegate>("UnityEngine.BoxCollider2D::get_autoTiling_Injected");

	private static readonly set_autoTiling_InjectedDelegate set_autoTiling_InjectedDelegateField = IL2CPP.ResolveICall<set_autoTiling_InjectedDelegate>("UnityEngine.BoxCollider2D::set_autoTiling_Injected");

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

	public float edgeRadius
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_edgeRadius_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_edgeRadius_Injected(intPtr, value);
		}
	}

	public bool autoTiling
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoTiling_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoTiling_Injected(intPtr, value);
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

	public unsafe static void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_edgeRadius_Injected(IntPtr _unity_self)
	{
		return get_edgeRadius_InjectedDelegateField(_unity_self);
	}

	public static void set_edgeRadius_Injected(IntPtr _unity_self, float value)
	{
		set_edgeRadius_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoTiling_Injected(IntPtr _unity_self)
	{
		return get_autoTiling_InjectedDelegateField(_unity_self);
	}

	public static void set_autoTiling_Injected(IntPtr _unity_self, bool value)
	{
		set_autoTiling_InjectedDelegateField(_unity_self, value);
	}
}
