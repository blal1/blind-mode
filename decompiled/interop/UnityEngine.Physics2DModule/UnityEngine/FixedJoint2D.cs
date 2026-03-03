using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class FixedJoint2D : AnchoredJoint2D
{
	private delegate float get_dampingRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dampingRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_frequency_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_frequency_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_referenceAngle_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_dampingRatio_InjectedDelegate get_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_dampingRatio_InjectedDelegate>("UnityEngine.FixedJoint2D::get_dampingRatio_Injected");

	private static readonly set_dampingRatio_InjectedDelegate set_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_dampingRatio_InjectedDelegate>("UnityEngine.FixedJoint2D::set_dampingRatio_Injected");

	private static readonly get_frequency_InjectedDelegate get_frequency_InjectedDelegateField = IL2CPP.ResolveICall<get_frequency_InjectedDelegate>("UnityEngine.FixedJoint2D::get_frequency_Injected");

	private static readonly set_frequency_InjectedDelegate set_frequency_InjectedDelegateField = IL2CPP.ResolveICall<set_frequency_InjectedDelegate>("UnityEngine.FixedJoint2D::set_frequency_Injected");

	private static readonly get_referenceAngle_InjectedDelegate get_referenceAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_referenceAngle_InjectedDelegate>("UnityEngine.FixedJoint2D::get_referenceAngle_Injected");

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

	public static float get_referenceAngle_Injected(IntPtr _unity_self)
	{
		return get_referenceAngle_InjectedDelegateField(_unity_self);
	}
}
