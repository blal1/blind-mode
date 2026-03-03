using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class FrictionJoint2D : AnchoredJoint2D
{
	private delegate float get_maxForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxForce_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxTorque_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxTorque_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_maxForce_InjectedDelegate get_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<get_maxForce_InjectedDelegate>("UnityEngine.FrictionJoint2D::get_maxForce_Injected");

	private static readonly set_maxForce_InjectedDelegate set_maxForce_InjectedDelegateField = IL2CPP.ResolveICall<set_maxForce_InjectedDelegate>("UnityEngine.FrictionJoint2D::set_maxForce_Injected");

	private static readonly get_maxTorque_InjectedDelegate get_maxTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_maxTorque_InjectedDelegate>("UnityEngine.FrictionJoint2D::get_maxTorque_Injected");

	private static readonly set_maxTorque_InjectedDelegate set_maxTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_maxTorque_InjectedDelegate>("UnityEngine.FrictionJoint2D::set_maxTorque_Injected");

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
}
