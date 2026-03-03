using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class SliderJoint2D : AnchoredJoint2D
{
	private delegate bool get_autoConfigureAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureAngle_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_angle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angle_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_useMotor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useMotor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useLimits_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useLimits_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate JointLimitState2D get_limitState_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_referenceAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointTranslation_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointSpeed_InjectedDelegate(IntPtr _unity_self);

	private delegate float GetMotorForce_InjectedDelegate(IntPtr _unity_self, float timeStep);

	private static readonly get_autoConfigureAngle_InjectedDelegate get_autoConfigureAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureAngle_InjectedDelegate>("UnityEngine.SliderJoint2D::get_autoConfigureAngle_Injected");

	private static readonly set_autoConfigureAngle_InjectedDelegate set_autoConfigureAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureAngle_InjectedDelegate>("UnityEngine.SliderJoint2D::set_autoConfigureAngle_Injected");

	private static readonly get_angle_InjectedDelegate get_angle_InjectedDelegateField = IL2CPP.ResolveICall<get_angle_InjectedDelegate>("UnityEngine.SliderJoint2D::get_angle_Injected");

	private static readonly set_angle_InjectedDelegate set_angle_InjectedDelegateField = IL2CPP.ResolveICall<set_angle_InjectedDelegate>("UnityEngine.SliderJoint2D::set_angle_Injected");

	private static readonly get_useMotor_InjectedDelegate get_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<get_useMotor_InjectedDelegate>("UnityEngine.SliderJoint2D::get_useMotor_Injected");

	private static readonly set_useMotor_InjectedDelegate set_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<set_useMotor_InjectedDelegate>("UnityEngine.SliderJoint2D::set_useMotor_Injected");

	private static readonly get_useLimits_InjectedDelegate get_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<get_useLimits_InjectedDelegate>("UnityEngine.SliderJoint2D::get_useLimits_Injected");

	private static readonly set_useLimits_InjectedDelegate set_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<set_useLimits_InjectedDelegate>("UnityEngine.SliderJoint2D::set_useLimits_Injected");

	private static readonly get_limitState_InjectedDelegate get_limitState_InjectedDelegateField = IL2CPP.ResolveICall<get_limitState_InjectedDelegate>("UnityEngine.SliderJoint2D::get_limitState_Injected");

	private static readonly get_referenceAngle_InjectedDelegate get_referenceAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_referenceAngle_InjectedDelegate>("UnityEngine.SliderJoint2D::get_referenceAngle_Injected");

	private static readonly get_jointTranslation_InjectedDelegate get_jointTranslation_InjectedDelegateField = IL2CPP.ResolveICall<get_jointTranslation_InjectedDelegate>("UnityEngine.SliderJoint2D::get_jointTranslation_Injected");

	private static readonly get_jointSpeed_InjectedDelegate get_jointSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_jointSpeed_InjectedDelegate>("UnityEngine.SliderJoint2D::get_jointSpeed_Injected");

	private static readonly GetMotorForce_InjectedDelegate GetMotorForce_InjectedDelegateField = IL2CPP.ResolveICall<GetMotorForce_InjectedDelegate>("UnityEngine.SliderJoint2D::GetMotorForce_Injected");

	public bool autoConfigureAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureAngle_Injected(intPtr, value);
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
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angle_Injected(intPtr, value);
		}
	}

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

	public JointLimitState2D limitState
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_limitState_Injected(intPtr);
		}
	}

	public float referenceAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_referenceAngle_Injected(intPtr);
		}
	}

	public float jointTranslation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointTranslation_Injected(intPtr);
		}
	}

	public float jointSpeed
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointSpeed_Injected(intPtr);
		}
	}

	public float GetMotorForce(float timeStep)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMotorForce_Injected(intPtr, timeStep);
	}

	public static bool get_autoConfigureAngle_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureAngle_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureAngle_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angle_Injected(IntPtr _unity_self)
	{
		return get_angle_InjectedDelegateField(_unity_self);
	}

	public static void set_angle_Injected(IntPtr _unity_self, float value)
	{
		set_angle_InjectedDelegateField(_unity_self, value);
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

	public static JointLimitState2D get_limitState_Injected(IntPtr _unity_self)
	{
		return get_limitState_InjectedDelegateField(_unity_self);
	}

	public static float get_referenceAngle_Injected(IntPtr _unity_self)
	{
		return get_referenceAngle_InjectedDelegateField(_unity_self);
	}

	public static float get_jointTranslation_Injected(IntPtr _unity_self)
	{
		return get_jointTranslation_InjectedDelegateField(_unity_self);
	}

	public static float get_jointSpeed_Injected(IntPtr _unity_self)
	{
		return get_jointSpeed_InjectedDelegateField(_unity_self);
	}

	public static float GetMotorForce_Injected(IntPtr _unity_self, float timeStep)
	{
		return GetMotorForce_InjectedDelegateField(_unity_self, timeStep);
	}
}
