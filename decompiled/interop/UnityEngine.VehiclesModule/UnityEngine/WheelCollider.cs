using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class WheelCollider : Collider
{
	private delegate void get_center_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_center_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_radius_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_suspensionDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_suspensionDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_suspensionExpansionLimited_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_suspensionExpansionLimited_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_forceAppPointDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_forceAppPointDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_mass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mass_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_wheelDampingRate_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_wheelDampingRate_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_motorTorque_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_motorTorque_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_brakeTorque_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_brakeTorque_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_steerAngle_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_steerAngle_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_isGrounded_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_rpm_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_sprungMass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sprungMass_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_rotationSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_rotationSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void ResetSprungMasses_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ConfigureVehicleSubsteps_InjectedDelegate(System.IntPtr _unity_self, float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);

	private delegate void GetWorldPose_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr pos, [Out] System.IntPtr quat);

	private delegate bool get_isSupported_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<get_center_InjectedDelegate>("UnityEngine.WheelCollider::get_center_Injected");

	private static readonly set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<set_center_InjectedDelegate>("UnityEngine.WheelCollider::set_center_Injected");

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.WheelCollider::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.WheelCollider::set_radius_Injected");

	private static readonly get_suspensionDistance_InjectedDelegate get_suspensionDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_suspensionDistance_InjectedDelegate>("UnityEngine.WheelCollider::get_suspensionDistance_Injected");

	private static readonly set_suspensionDistance_InjectedDelegate set_suspensionDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_suspensionDistance_InjectedDelegate>("UnityEngine.WheelCollider::set_suspensionDistance_Injected");

	private static readonly get_suspensionExpansionLimited_InjectedDelegate get_suspensionExpansionLimited_InjectedDelegateField = IL2CPP.ResolveICall<get_suspensionExpansionLimited_InjectedDelegate>("UnityEngine.WheelCollider::get_suspensionExpansionLimited_Injected");

	private static readonly set_suspensionExpansionLimited_InjectedDelegate set_suspensionExpansionLimited_InjectedDelegateField = IL2CPP.ResolveICall<set_suspensionExpansionLimited_InjectedDelegate>("UnityEngine.WheelCollider::set_suspensionExpansionLimited_Injected");

	private static readonly get_forceAppPointDistance_InjectedDelegate get_forceAppPointDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_forceAppPointDistance_InjectedDelegate>("UnityEngine.WheelCollider::get_forceAppPointDistance_Injected");

	private static readonly set_forceAppPointDistance_InjectedDelegate set_forceAppPointDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_forceAppPointDistance_InjectedDelegate>("UnityEngine.WheelCollider::set_forceAppPointDistance_Injected");

	private static readonly get_mass_InjectedDelegate get_mass_InjectedDelegateField = IL2CPP.ResolveICall<get_mass_InjectedDelegate>("UnityEngine.WheelCollider::get_mass_Injected");

	private static readonly set_mass_InjectedDelegate set_mass_InjectedDelegateField = IL2CPP.ResolveICall<set_mass_InjectedDelegate>("UnityEngine.WheelCollider::set_mass_Injected");

	private static readonly get_wheelDampingRate_InjectedDelegate get_wheelDampingRate_InjectedDelegateField = IL2CPP.ResolveICall<get_wheelDampingRate_InjectedDelegate>("UnityEngine.WheelCollider::get_wheelDampingRate_Injected");

	private static readonly set_wheelDampingRate_InjectedDelegate set_wheelDampingRate_InjectedDelegateField = IL2CPP.ResolveICall<set_wheelDampingRate_InjectedDelegate>("UnityEngine.WheelCollider::set_wheelDampingRate_Injected");

	private static readonly get_motorTorque_InjectedDelegate get_motorTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_motorTorque_InjectedDelegate>("UnityEngine.WheelCollider::get_motorTorque_Injected");

	private static readonly set_motorTorque_InjectedDelegate set_motorTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_motorTorque_InjectedDelegate>("UnityEngine.WheelCollider::set_motorTorque_Injected");

	private static readonly get_brakeTorque_InjectedDelegate get_brakeTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_brakeTorque_InjectedDelegate>("UnityEngine.WheelCollider::get_brakeTorque_Injected");

	private static readonly set_brakeTorque_InjectedDelegate set_brakeTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_brakeTorque_InjectedDelegate>("UnityEngine.WheelCollider::set_brakeTorque_Injected");

	private static readonly get_steerAngle_InjectedDelegate get_steerAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_steerAngle_InjectedDelegate>("UnityEngine.WheelCollider::get_steerAngle_Injected");

	private static readonly set_steerAngle_InjectedDelegate set_steerAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_steerAngle_InjectedDelegate>("UnityEngine.WheelCollider::set_steerAngle_Injected");

	private static readonly get_isGrounded_InjectedDelegate get_isGrounded_InjectedDelegateField = IL2CPP.ResolveICall<get_isGrounded_InjectedDelegate>("UnityEngine.WheelCollider::get_isGrounded_Injected");

	private static readonly get_rpm_InjectedDelegate get_rpm_InjectedDelegateField = IL2CPP.ResolveICall<get_rpm_InjectedDelegate>("UnityEngine.WheelCollider::get_rpm_Injected");

	private static readonly get_sprungMass_InjectedDelegate get_sprungMass_InjectedDelegateField = IL2CPP.ResolveICall<get_sprungMass_InjectedDelegate>("UnityEngine.WheelCollider::get_sprungMass_Injected");

	private static readonly set_sprungMass_InjectedDelegate set_sprungMass_InjectedDelegateField = IL2CPP.ResolveICall<set_sprungMass_InjectedDelegate>("UnityEngine.WheelCollider::set_sprungMass_Injected");

	private static readonly get_rotationSpeed_InjectedDelegate get_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_rotationSpeed_InjectedDelegate>("UnityEngine.WheelCollider::get_rotationSpeed_Injected");

	private static readonly set_rotationSpeed_InjectedDelegate set_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_rotationSpeed_InjectedDelegate>("UnityEngine.WheelCollider::set_rotationSpeed_Injected");

	private static readonly ResetSprungMasses_InjectedDelegate ResetSprungMasses_InjectedDelegateField = IL2CPP.ResolveICall<ResetSprungMasses_InjectedDelegate>("UnityEngine.WheelCollider::ResetSprungMasses_Injected");

	private static readonly ConfigureVehicleSubsteps_InjectedDelegate ConfigureVehicleSubsteps_InjectedDelegateField = IL2CPP.ResolveICall<ConfigureVehicleSubsteps_InjectedDelegate>("UnityEngine.WheelCollider::ConfigureVehicleSubsteps_Injected");

	private static readonly GetWorldPose_InjectedDelegate GetWorldPose_InjectedDelegateField = IL2CPP.ResolveICall<GetWorldPose_InjectedDelegate>("UnityEngine.WheelCollider::GetWorldPose_Injected");

	private static readonly get_isSupported_InjectedDelegate get_isSupported_InjectedDelegateField = IL2CPP.ResolveICall<get_isSupported_InjectedDelegate>("UnityEngine.WheelCollider::get_isSupported_Injected");

	public Vector3 center
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_center_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
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
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public float suspensionDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_suspensionDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_suspensionDistance_Injected(intPtr, value);
		}
	}

	public bool suspensionExpansionLimited
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_suspensionExpansionLimited_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_suspensionExpansionLimited_Injected(intPtr, value);
		}
	}

	public float forceAppPointDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceAppPointDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceAppPointDistance_Injected(intPtr, value);
		}
	}

	public float mass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mass_Injected(intPtr, value);
		}
	}

	public float wheelDampingRate
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wheelDampingRate_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wheelDampingRate_Injected(intPtr, value);
		}
	}

	public float motorTorque
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_motorTorque_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_motorTorque_Injected(intPtr, value);
		}
	}

	public float brakeTorque
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_brakeTorque_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_brakeTorque_Injected(intPtr, value);
		}
	}

	public float steerAngle
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_steerAngle_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_steerAngle_Injected(intPtr, value);
		}
	}

	public bool isGrounded
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isGrounded_Injected(intPtr);
		}
	}

	public float rpm
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rpm_Injected(intPtr);
		}
	}

	public float sprungMass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sprungMass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sprungMass_Injected(intPtr, value);
		}
	}

	public float rotationSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rotationSpeed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rotationSpeed_Injected(intPtr, value);
		}
	}

	public bool isSupported
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isSupported_Injected(intPtr);
		}
	}

	public void ResetSprungMasses()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetSprungMasses_Injected(intPtr);
	}

	public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ConfigureVehicleSubsteps_Injected(intPtr, speedThreshold, stepsBelowThreshold, stepsAboveThreshold);
	}

	public void GetWorldPose(out Vector3 pos, out Quaternion quat)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetWorldPose_Injected(intPtr, out pos, out quat);
	}

	public unsafe static void get_center_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_center_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_center_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_center_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public static float get_radius_Injected(System.IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(System.IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_suspensionDistance_Injected(System.IntPtr _unity_self)
	{
		return get_suspensionDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_suspensionDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_suspensionDistance_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_suspensionExpansionLimited_Injected(System.IntPtr _unity_self)
	{
		return get_suspensionExpansionLimited_InjectedDelegateField(_unity_self);
	}

	public static void set_suspensionExpansionLimited_Injected(System.IntPtr _unity_self, bool value)
	{
		set_suspensionExpansionLimited_InjectedDelegateField(_unity_self, value);
	}

	public static float get_forceAppPointDistance_Injected(System.IntPtr _unity_self)
	{
		return get_forceAppPointDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_forceAppPointDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_forceAppPointDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_mass_Injected(System.IntPtr _unity_self)
	{
		return get_mass_InjectedDelegateField(_unity_self);
	}

	public static void set_mass_Injected(System.IntPtr _unity_self, float value)
	{
		set_mass_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wheelDampingRate_Injected(System.IntPtr _unity_self)
	{
		return get_wheelDampingRate_InjectedDelegateField(_unity_self);
	}

	public static void set_wheelDampingRate_Injected(System.IntPtr _unity_self, float value)
	{
		set_wheelDampingRate_InjectedDelegateField(_unity_self, value);
	}

	public static float get_motorTorque_Injected(System.IntPtr _unity_self)
	{
		return get_motorTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_motorTorque_Injected(System.IntPtr _unity_self, float value)
	{
		set_motorTorque_InjectedDelegateField(_unity_self, value);
	}

	public static float get_brakeTorque_Injected(System.IntPtr _unity_self)
	{
		return get_brakeTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_brakeTorque_Injected(System.IntPtr _unity_self, float value)
	{
		set_brakeTorque_InjectedDelegateField(_unity_self, value);
	}

	public static float get_steerAngle_Injected(System.IntPtr _unity_self)
	{
		return get_steerAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_steerAngle_Injected(System.IntPtr _unity_self, float value)
	{
		set_steerAngle_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isGrounded_Injected(System.IntPtr _unity_self)
	{
		return get_isGrounded_InjectedDelegateField(_unity_self);
	}

	public static float get_rpm_Injected(System.IntPtr _unity_self)
	{
		return get_rpm_InjectedDelegateField(_unity_self);
	}

	public static float get_sprungMass_Injected(System.IntPtr _unity_self)
	{
		return get_sprungMass_InjectedDelegateField(_unity_self);
	}

	public static void set_sprungMass_Injected(System.IntPtr _unity_self, float value)
	{
		set_sprungMass_InjectedDelegateField(_unity_self, value);
	}

	public static float get_rotationSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_rotationSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_rotationSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		set_rotationSpeed_InjectedDelegateField(_unity_self, value);
	}

	public static void ResetSprungMasses_Injected(System.IntPtr _unity_self)
	{
		ResetSprungMasses_InjectedDelegateField(_unity_self);
	}

	public static void ConfigureVehicleSubsteps_Injected(System.IntPtr _unity_self, float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
	{
		ConfigureVehicleSubsteps_InjectedDelegateField(_unity_self, speedThreshold, stepsBelowThreshold, stepsAboveThreshold);
	}

	public unsafe static void GetWorldPose_Injected(System.IntPtr _unity_self, out Vector3 pos, out Quaternion quat)
	{
		GetWorldPose_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref pos), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref quat));
	}

	public static bool get_isSupported_Injected(System.IntPtr _unity_self)
	{
		return get_isSupported_InjectedDelegateField(_unity_self);
	}
}
