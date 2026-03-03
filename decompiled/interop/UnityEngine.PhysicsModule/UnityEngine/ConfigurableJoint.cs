using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ConfigurableJoint : Joint
{
	private delegate void get_secondaryAxis_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_secondaryAxis_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate ConfigurableJointMotion get_xMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_xMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate ConfigurableJointMotion get_yMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_yMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate ConfigurableJointMotion get_zMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_zMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate ConfigurableJointMotion get_angularXMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularXMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate ConfigurableJointMotion get_angularYMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularYMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate ConfigurableJointMotion get_angularZMotion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularZMotion_InjectedDelegate(IntPtr _unity_self, ConfigurableJointMotion value);

	private delegate void get_targetPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_targetPosition_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_targetVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_targetVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_targetRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_targetRotation_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_targetAngularVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_targetAngularVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate RotationDriveMode get_rotationDriveMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_rotationDriveMode_InjectedDelegate(IntPtr _unity_self, RotationDriveMode value);

	private delegate JointProjectionMode get_projectionMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_projectionMode_InjectedDelegate(IntPtr _unity_self, JointProjectionMode value);

	private delegate float get_projectionDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_projectionDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_projectionAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_projectionAngle_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_configuredInWorldSpace_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_configuredInWorldSpace_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_swapBodies_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_swapBodies_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_secondaryAxis_InjectedDelegate get_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<get_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_secondaryAxis_Injected");

	private static readonly set_secondaryAxis_InjectedDelegate set_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<set_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_secondaryAxis_Injected");

	private static readonly get_xMotion_InjectedDelegate get_xMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_xMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_xMotion_Injected");

	private static readonly set_xMotion_InjectedDelegate set_xMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_xMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_xMotion_Injected");

	private static readonly get_yMotion_InjectedDelegate get_yMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_yMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_yMotion_Injected");

	private static readonly set_yMotion_InjectedDelegate set_yMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_yMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_yMotion_Injected");

	private static readonly get_zMotion_InjectedDelegate get_zMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_zMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_zMotion_Injected");

	private static readonly set_zMotion_InjectedDelegate set_zMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_zMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_zMotion_Injected");

	private static readonly get_angularXMotion_InjectedDelegate get_angularXMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_angularXMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_angularXMotion_Injected");

	private static readonly set_angularXMotion_InjectedDelegate set_angularXMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_angularXMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_angularXMotion_Injected");

	private static readonly get_angularYMotion_InjectedDelegate get_angularYMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_angularYMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_angularYMotion_Injected");

	private static readonly set_angularYMotion_InjectedDelegate set_angularYMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_angularYMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_angularYMotion_Injected");

	private static readonly get_angularZMotion_InjectedDelegate get_angularZMotion_InjectedDelegateField = IL2CPP.ResolveICall<get_angularZMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_angularZMotion_Injected");

	private static readonly set_angularZMotion_InjectedDelegate set_angularZMotion_InjectedDelegateField = IL2CPP.ResolveICall<set_angularZMotion_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_angularZMotion_Injected");

	private static readonly get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<get_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetPosition_Injected");

	private static readonly set_targetPosition_InjectedDelegate set_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<set_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetPosition_Injected");

	private static readonly get_targetVelocity_InjectedDelegate get_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetVelocity_Injected");

	private static readonly set_targetVelocity_InjectedDelegate set_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetVelocity_Injected");

	private static readonly get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetRotation_Injected");

	private static readonly set_targetRotation_InjectedDelegate set_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetRotation_Injected");

	private static readonly get_targetAngularVelocity_InjectedDelegate get_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetAngularVelocity_Injected");

	private static readonly set_targetAngularVelocity_InjectedDelegate set_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetAngularVelocity_Injected");

	private static readonly get_rotationDriveMode_InjectedDelegate get_rotationDriveMode_InjectedDelegateField = IL2CPP.ResolveICall<get_rotationDriveMode_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_rotationDriveMode_Injected");

	private static readonly set_rotationDriveMode_InjectedDelegate set_rotationDriveMode_InjectedDelegateField = IL2CPP.ResolveICall<set_rotationDriveMode_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_rotationDriveMode_Injected");

	private static readonly get_projectionMode_InjectedDelegate get_projectionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionMode_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_projectionMode_Injected");

	private static readonly set_projectionMode_InjectedDelegate set_projectionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionMode_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_projectionMode_Injected");

	private static readonly get_projectionDistance_InjectedDelegate get_projectionDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionDistance_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_projectionDistance_Injected");

	private static readonly set_projectionDistance_InjectedDelegate set_projectionDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionDistance_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_projectionDistance_Injected");

	private static readonly get_projectionAngle_InjectedDelegate get_projectionAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionAngle_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_projectionAngle_Injected");

	private static readonly set_projectionAngle_InjectedDelegate set_projectionAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionAngle_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_projectionAngle_Injected");

	private static readonly get_configuredInWorldSpace_InjectedDelegate get_configuredInWorldSpace_InjectedDelegateField = IL2CPP.ResolveICall<get_configuredInWorldSpace_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_configuredInWorldSpace_Injected");

	private static readonly set_configuredInWorldSpace_InjectedDelegate set_configuredInWorldSpace_InjectedDelegateField = IL2CPP.ResolveICall<set_configuredInWorldSpace_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_configuredInWorldSpace_Injected");

	private static readonly get_swapBodies_InjectedDelegate get_swapBodies_InjectedDelegateField = IL2CPP.ResolveICall<get_swapBodies_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_swapBodies_Injected");

	private static readonly set_swapBodies_InjectedDelegate set_swapBodies_InjectedDelegateField = IL2CPP.ResolveICall<set_swapBodies_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_swapBodies_Injected");

	public Vector3 secondaryAxis
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_secondaryAxis_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_secondaryAxis_Injected(intPtr, ref value);
		}
	}

	public ConfigurableJointMotion xMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_xMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_xMotion_Injected(intPtr, value);
		}
	}

	public ConfigurableJointMotion yMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_yMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_yMotion_Injected(intPtr, value);
		}
	}

	public ConfigurableJointMotion zMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_zMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_zMotion_Injected(intPtr, value);
		}
	}

	public ConfigurableJointMotion angularXMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularXMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularXMotion_Injected(intPtr, value);
		}
	}

	public ConfigurableJointMotion angularYMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularYMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularYMotion_Injected(intPtr, value);
		}
	}

	public ConfigurableJointMotion angularZMotion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularZMotion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularZMotion_Injected(intPtr, value);
		}
	}

	public Vector3 targetPosition
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_targetPosition_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetPosition_Injected(intPtr, ref value);
		}
	}

	public Vector3 targetVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_targetVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetVelocity_Injected(intPtr, ref value);
		}
	}

	public Quaternion targetRotation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_targetRotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetRotation_Injected(intPtr, ref value);
		}
	}

	public Vector3 targetAngularVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_targetAngularVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetAngularVelocity_Injected(intPtr, ref value);
		}
	}

	public RotationDriveMode rotationDriveMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rotationDriveMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rotationDriveMode_Injected(intPtr, value);
		}
	}

	public JointProjectionMode projectionMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionMode_Injected(intPtr, value);
		}
	}

	public float projectionDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionDistance_Injected(intPtr, value);
		}
	}

	public float projectionAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionAngle_Injected(intPtr, value);
		}
	}

	public bool configuredInWorldSpace
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_configuredInWorldSpace_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_configuredInWorldSpace_Injected(intPtr, value);
		}
	}

	public bool swapBodies
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_swapBodies_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_swapBodies_Injected(intPtr, value);
		}
	}

	public unsafe static void get_secondaryAxis_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_secondaryAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_secondaryAxis_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_secondaryAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static ConfigurableJointMotion get_xMotion_Injected(IntPtr _unity_self)
	{
		return get_xMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_xMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_xMotion_InjectedDelegateField(_unity_self, value);
	}

	public static ConfigurableJointMotion get_yMotion_Injected(IntPtr _unity_self)
	{
		return get_yMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_yMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_yMotion_InjectedDelegateField(_unity_self, value);
	}

	public static ConfigurableJointMotion get_zMotion_Injected(IntPtr _unity_self)
	{
		return get_zMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_zMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_zMotion_InjectedDelegateField(_unity_self, value);
	}

	public static ConfigurableJointMotion get_angularXMotion_Injected(IntPtr _unity_self)
	{
		return get_angularXMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_angularXMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_angularXMotion_InjectedDelegateField(_unity_self, value);
	}

	public static ConfigurableJointMotion get_angularYMotion_Injected(IntPtr _unity_self)
	{
		return get_angularYMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_angularYMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_angularYMotion_InjectedDelegateField(_unity_self, value);
	}

	public static ConfigurableJointMotion get_angularZMotion_Injected(IntPtr _unity_self)
	{
		return get_angularZMotion_InjectedDelegateField(_unity_self);
	}

	public static void set_angularZMotion_Injected(IntPtr _unity_self, ConfigurableJointMotion value)
	{
		set_angularZMotion_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_targetPosition_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_targetPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_targetPosition_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_targetPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_targetVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_targetVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_targetVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_targetVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_targetRotation_Injected(IntPtr _unity_self, out Quaternion ret)
	{
		get_targetRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_targetRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_targetRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_targetAngularVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_targetAngularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_targetAngularVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_targetAngularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static RotationDriveMode get_rotationDriveMode_Injected(IntPtr _unity_self)
	{
		return get_rotationDriveMode_InjectedDelegateField(_unity_self);
	}

	public static void set_rotationDriveMode_Injected(IntPtr _unity_self, RotationDriveMode value)
	{
		set_rotationDriveMode_InjectedDelegateField(_unity_self, value);
	}

	public static JointProjectionMode get_projectionMode_Injected(IntPtr _unity_self)
	{
		return get_projectionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_projectionMode_Injected(IntPtr _unity_self, JointProjectionMode value)
	{
		set_projectionMode_InjectedDelegateField(_unity_self, value);
	}

	public static float get_projectionDistance_Injected(IntPtr _unity_self)
	{
		return get_projectionDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_projectionDistance_Injected(IntPtr _unity_self, float value)
	{
		set_projectionDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_projectionAngle_Injected(IntPtr _unity_self)
	{
		return get_projectionAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_projectionAngle_Injected(IntPtr _unity_self, float value)
	{
		set_projectionAngle_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_configuredInWorldSpace_Injected(IntPtr _unity_self)
	{
		return get_configuredInWorldSpace_InjectedDelegateField(_unity_self);
	}

	public static void set_configuredInWorldSpace_Injected(IntPtr _unity_self, bool value)
	{
		set_configuredInWorldSpace_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_swapBodies_Injected(IntPtr _unity_self)
	{
		return get_swapBodies_InjectedDelegateField(_unity_self);
	}

	public static void set_swapBodies_Injected(IntPtr _unity_self, bool value)
	{
		set_swapBodies_InjectedDelegateField(_unity_self, value);
	}
}
