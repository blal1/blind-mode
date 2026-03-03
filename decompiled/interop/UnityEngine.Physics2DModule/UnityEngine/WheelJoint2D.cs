using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class WheelJoint2D : AnchoredJoint2D
{
	private delegate bool get_useMotor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useMotor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_jointTranslation_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointLinearSpeed_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointSpeed_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate float GetMotorTorque_InjectedDelegate(IntPtr _unity_self, float timeStep);

	private static readonly get_useMotor_InjectedDelegate get_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<get_useMotor_InjectedDelegate>("UnityEngine.WheelJoint2D::get_useMotor_Injected");

	private static readonly set_useMotor_InjectedDelegate set_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<set_useMotor_InjectedDelegate>("UnityEngine.WheelJoint2D::set_useMotor_Injected");

	private static readonly get_jointTranslation_InjectedDelegate get_jointTranslation_InjectedDelegateField = IL2CPP.ResolveICall<get_jointTranslation_InjectedDelegate>("UnityEngine.WheelJoint2D::get_jointTranslation_Injected");

	private static readonly get_jointLinearSpeed_InjectedDelegate get_jointLinearSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_jointLinearSpeed_InjectedDelegate>("UnityEngine.WheelJoint2D::get_jointLinearSpeed_Injected");

	private static readonly get_jointSpeed_InjectedDelegate get_jointSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_jointSpeed_InjectedDelegate>("UnityEngine.WheelJoint2D::get_jointSpeed_Injected");

	private static readonly get_jointAngle_InjectedDelegate get_jointAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_jointAngle_InjectedDelegate>("UnityEngine.WheelJoint2D::get_jointAngle_Injected");

	private static readonly GetMotorTorque_InjectedDelegate GetMotorTorque_InjectedDelegateField = IL2CPP.ResolveICall<GetMotorTorque_InjectedDelegate>("UnityEngine.WheelJoint2D::GetMotorTorque_Injected");

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

	public float jointLinearSpeed
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointLinearSpeed_Injected(intPtr);
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

	public float jointAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointAngle_Injected(intPtr);
		}
	}

	public float GetMotorTorque(float timeStep)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMotorTorque_Injected(intPtr, timeStep);
	}

	public static bool get_useMotor_Injected(IntPtr _unity_self)
	{
		return get_useMotor_InjectedDelegateField(_unity_self);
	}

	public static void set_useMotor_Injected(IntPtr _unity_self, bool value)
	{
		set_useMotor_InjectedDelegateField(_unity_self, value);
	}

	public static float get_jointTranslation_Injected(IntPtr _unity_self)
	{
		return get_jointTranslation_InjectedDelegateField(_unity_self);
	}

	public static float get_jointLinearSpeed_Injected(IntPtr _unity_self)
	{
		return get_jointLinearSpeed_InjectedDelegateField(_unity_self);
	}

	public static float get_jointSpeed_Injected(IntPtr _unity_self)
	{
		return get_jointSpeed_InjectedDelegateField(_unity_self);
	}

	public static float get_jointAngle_Injected(IntPtr _unity_self)
	{
		return get_jointAngle_InjectedDelegateField(_unity_self);
	}

	public static float GetMotorTorque_Injected(IntPtr _unity_self, float timeStep)
	{
		return GetMotorTorque_InjectedDelegateField(_unity_self, timeStep);
	}
}
