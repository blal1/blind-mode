using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class RelativeJoint2D : Joint2D
{
	private delegate float get_maxForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxForce_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxTorque_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxTorque_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_correctionScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_correctionScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_autoConfigureOffset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureOffset_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void get_linearOffset_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_linearOffset_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_angularOffset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularOffset_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_target_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private static readonly get_maxForce_InjectedDelegate get_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<get_maxForce_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_maxForce_Injected");

	private static readonly set_maxForce_InjectedDelegate set_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<set_maxForce_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_maxForce_Injected");

	private static readonly get_maxTorque_InjectedDelegate get_maxTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_maxTorque_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_maxTorque_Injected");

	private static readonly set_maxTorque_InjectedDelegate set_maxTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_maxTorque_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_maxTorque_Injected");

	private static readonly get_correctionScale_InjectedDelegate get_correctionScale_InjectedDelegateField = IL2CPP.ResolveICall<get_correctionScale_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_correctionScale_Injected");

	private static readonly set_correctionScale_InjectedDelegate set_correctionScale_InjectedDelegateField = IL2CPP.ResolveICall<set_correctionScale_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_correctionScale_Injected");

	private static readonly get_autoConfigureOffset_InjectedDelegate get_autoConfigureOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_autoConfigureOffset_Injected");

	private static readonly set_autoConfigureOffset_InjectedDelegate set_autoConfigureOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_autoConfigureOffset_Injected");

	private static readonly get_linearOffset_InjectedDelegate get_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_linearOffset_Injected");

	private static readonly set_linearOffset_InjectedDelegate set_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_linearOffset_Injected");

	private static readonly get_angularOffset_InjectedDelegate get_angularOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_angularOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_angularOffset_Injected");

	private static readonly set_angularOffset_InjectedDelegate set_angularOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_angularOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_angularOffset_Injected");

	private static readonly get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<get_target_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_target_Injected");

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

	public float maxTorque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxTorque_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxTorque_Injected(intPtr, value);
		}
	}

	public float correctionScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_correctionScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_correctionScale_Injected(intPtr, value);
		}
	}

	public bool autoConfigureOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureOffset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureOffset_Injected(intPtr, value);
		}
	}

	public Vector2 linearOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_linearOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearOffset_Injected(intPtr, ref value);
		}
	}

	public float angularOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularOffset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularOffset_Injected(intPtr, value);
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
	}

	public static float get_maxForce_Injected(IntPtr _unity_self)
	{
		return get_maxForce_InjectedDelegateField(_unity_self);
	}

	public static void set_maxForce_Injected(IntPtr _unity_self, float value)
	{
		set_maxForce_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxTorque_Injected(IntPtr _unity_self)
	{
		return get_maxTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_maxTorque_Injected(IntPtr _unity_self, float value)
	{
		set_maxTorque_InjectedDelegateField(_unity_self, value);
	}

	public static float get_correctionScale_Injected(IntPtr _unity_self)
	{
		return get_correctionScale_InjectedDelegateField(_unity_self);
	}

	public static void set_correctionScale_Injected(IntPtr _unity_self, float value)
	{
		set_correctionScale_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoConfigureOffset_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureOffset_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureOffset_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_linearOffset_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_linearOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_linearOffset_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_linearOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_angularOffset_Injected(IntPtr _unity_self)
	{
		return get_angularOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_angularOffset_Injected(IntPtr _unity_self, float value)
	{
		set_angularOffset_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_target_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_target_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
