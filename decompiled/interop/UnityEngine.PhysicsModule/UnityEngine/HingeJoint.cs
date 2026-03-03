using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class HingeJoint : Joint
{
	private delegate bool get_useMotor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useMotor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useLimits_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useLimits_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_extendedLimits_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_extendedLimits_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useSpring_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useSpring_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_velocity_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_angle_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_useAcceleration_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useAcceleration_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_useMotor_InjectedDelegate get_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<get_useMotor_InjectedDelegate>("UnityEngine.HingeJoint::get_useMotor_Injected");

	private static readonly set_useMotor_InjectedDelegate set_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<set_useMotor_InjectedDelegate>("UnityEngine.HingeJoint::set_useMotor_Injected");

	private static readonly get_useLimits_InjectedDelegate get_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<get_useLimits_InjectedDelegate>("UnityEngine.HingeJoint::get_useLimits_Injected");

	private static readonly set_useLimits_InjectedDelegate set_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<set_useLimits_InjectedDelegate>("UnityEngine.HingeJoint::set_useLimits_Injected");

	private static readonly get_extendedLimits_InjectedDelegate get_extendedLimits_InjectedDelegateField = IL2CPP.ResolveICall<get_extendedLimits_InjectedDelegate>("UnityEngine.HingeJoint::get_extendedLimits_Injected");

	private static readonly set_extendedLimits_InjectedDelegate set_extendedLimits_InjectedDelegateField = IL2CPP.ResolveICall<set_extendedLimits_InjectedDelegate>("UnityEngine.HingeJoint::set_extendedLimits_Injected");

	private static readonly get_useSpring_InjectedDelegate get_useSpring_InjectedDelegateField = IL2CPP.ResolveICall<get_useSpring_InjectedDelegate>("UnityEngine.HingeJoint::get_useSpring_Injected");

	private static readonly set_useSpring_InjectedDelegate set_useSpring_InjectedDelegateField = IL2CPP.ResolveICall<set_useSpring_InjectedDelegate>("UnityEngine.HingeJoint::set_useSpring_Injected");

	private static readonly get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<get_velocity_InjectedDelegate>("UnityEngine.HingeJoint::get_velocity_Injected");

	private static readonly get_angle_InjectedDelegate get_angle_InjectedDelegateField = IL2CPP.ResolveICall<get_angle_InjectedDelegate>("UnityEngine.HingeJoint::get_angle_Injected");

	private static readonly get_useAcceleration_InjectedDelegate get_useAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<get_useAcceleration_InjectedDelegate>("UnityEngine.HingeJoint::get_useAcceleration_Injected");

	private static readonly set_useAcceleration_InjectedDelegate set_useAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<set_useAcceleration_InjectedDelegate>("UnityEngine.HingeJoint::set_useAcceleration_Injected");

	public bool useMotor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useMotor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useMotor_Injected(intPtr, value);
		}
	}

	public bool useLimits
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useLimits_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useLimits_Injected(intPtr, value);
		}
	}

	public bool extendedLimits
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_extendedLimits_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_extendedLimits_Injected(intPtr, value);
		}
	}

	public bool useSpring
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useSpring_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useSpring_Injected(intPtr, value);
		}
	}

	public float velocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_velocity_Injected(intPtr);
		}
	}

	public float angle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angle_Injected(intPtr);
		}
	}

	public bool useAcceleration
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useAcceleration_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useAcceleration_Injected(intPtr, value);
		}
	}

	public static bool get_useMotor_Injected(IntPtr _unity_self)
	{
		return get_useMotor_InjectedDelegateField(_unity_self);
	}

	public static void set_useMotor_Injected(IntPtr _unity_self, bool value)
	{
		set_useMotor_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useLimits_Injected(IntPtr _unity_self)
	{
		return get_useLimits_InjectedDelegateField(_unity_self);
	}

	public static void set_useLimits_Injected(IntPtr _unity_self, bool value)
	{
		set_useLimits_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_extendedLimits_Injected(IntPtr _unity_self)
	{
		return get_extendedLimits_InjectedDelegateField(_unity_self);
	}

	public static void set_extendedLimits_Injected(IntPtr _unity_self, bool value)
	{
		set_extendedLimits_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useSpring_Injected(IntPtr _unity_self)
	{
		return get_useSpring_InjectedDelegateField(_unity_self);
	}

	public static void set_useSpring_Injected(IntPtr _unity_self, bool value)
	{
		set_useSpring_InjectedDelegateField(_unity_self, value);
	}

	public static float get_velocity_Injected(IntPtr _unity_self)
	{
		return get_velocity_InjectedDelegateField(_unity_self);
	}

	public static float get_angle_Injected(IntPtr _unity_self)
	{
		return get_angle_InjectedDelegateField(_unity_self);
	}

	public static bool get_useAcceleration_Injected(IntPtr _unity_self)
	{
		return get_useAcceleration_InjectedDelegateField(_unity_self);
	}

	public static void set_useAcceleration_Injected(IntPtr _unity_self, bool value)
	{
		set_useAcceleration_InjectedDelegateField(_unity_self, value);
	}
}
