using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TargetJoint2D : Joint2D
{
	private delegate void get_anchor_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_anchor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_target_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_target_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_autoConfigureTarget_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureTarget_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_maxForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxForce_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_dampingRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dampingRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_frequency_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_frequency_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<get_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::get_anchor_Injected");

	private static readonly set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<set_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::set_anchor_Injected");

	private static readonly get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<get_target_InjectedDelegate>("UnityEngine.TargetJoint2D::get_target_Injected");

	private static readonly set_target_InjectedDelegate set_target_InjectedDelegateField = IL2CPP.ResolveICall<set_target_InjectedDelegate>("UnityEngine.TargetJoint2D::set_target_Injected");

	private static readonly get_autoConfigureTarget_InjectedDelegate get_autoConfigureTarget_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureTarget_InjectedDelegate>("UnityEngine.TargetJoint2D::get_autoConfigureTarget_Injected");

	private static readonly set_autoConfigureTarget_InjectedDelegate set_autoConfigureTarget_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureTarget_InjectedDelegate>("UnityEngine.TargetJoint2D::set_autoConfigureTarget_Injected");

	private static readonly get_maxForce_InjectedDelegate get_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<get_maxForce_InjectedDelegate>("UnityEngine.TargetJoint2D::get_maxForce_Injected");

	private static readonly set_maxForce_InjectedDelegate set_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<set_maxForce_InjectedDelegate>("UnityEngine.TargetJoint2D::set_maxForce_Injected");

	private static readonly get_dampingRatio_InjectedDelegate get_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_dampingRatio_InjectedDelegate>("UnityEngine.TargetJoint2D::get_dampingRatio_Injected");

	private static readonly set_dampingRatio_InjectedDelegate set_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_dampingRatio_InjectedDelegate>("UnityEngine.TargetJoint2D::set_dampingRatio_Injected");

	private static readonly get_frequency_InjectedDelegate get_frequency_InjectedDelegateField = IL2CPP.ResolveICall<get_frequency_InjectedDelegate>("UnityEngine.TargetJoint2D::get_frequency_Injected");

	private static readonly set_frequency_InjectedDelegate set_frequency_InjectedDelegateField = IL2CPP.ResolveICall<set_frequency_InjectedDelegate>("UnityEngine.TargetJoint2D::set_frequency_Injected");

	public Vector2 anchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_anchor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchor_Injected(intPtr, ref value);
		}
	}

	public Vector2 target
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_target_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_target_Injected(intPtr, ref value);
		}
	}

	public bool autoConfigureTarget
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureTarget_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureTarget_Injected(intPtr, value);
		}
	}

	public float maxForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxForce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxForce_Injected(intPtr, value);
		}
	}

	public float dampingRatio
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dampingRatio_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_dampingRatio_Injected(intPtr, value);
		}
	}

	public float frequency
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frequency_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_frequency_Injected(intPtr, value);
		}
	}

	public unsafe static void get_anchor_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_anchor_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_target_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_target_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_target_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_target_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_autoConfigureTarget_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureTarget_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureTarget_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureTarget_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxForce_Injected(IntPtr _unity_self)
	{
		return get_maxForce_InjectedDelegateField(_unity_self);
	}

	public static void set_maxForce_Injected(IntPtr _unity_self, float value)
	{
		set_maxForce_InjectedDelegateField(_unity_self, value);
	}

	public static float get_dampingRatio_Injected(IntPtr _unity_self)
	{
		return get_dampingRatio_InjectedDelegateField(_unity_self);
	}

	public static void set_dampingRatio_Injected(IntPtr _unity_self, float value)
	{
		set_dampingRatio_InjectedDelegateField(_unity_self, value);
	}

	public static float get_frequency_Injected(IntPtr _unity_self)
	{
		return get_frequency_InjectedDelegateField(_unity_self);
	}

	public static void set_frequency_Injected(IntPtr _unity_self, float value)
	{
		set_frequency_InjectedDelegateField(_unity_self, value);
	}
}
