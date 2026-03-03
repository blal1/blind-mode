using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class SpringJoint2D : AnchoredJoint2D
{
	private delegate bool get_autoConfigureDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureDistance_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_distance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_distance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_dampingRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dampingRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_frequency_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_frequency_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_autoConfigureDistance_InjectedDelegate get_autoConfigureDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureDistance_InjectedDelegate>("UnityEngine.SpringJoint2D::get_autoConfigureDistance_Injected");

	private static readonly set_autoConfigureDistance_InjectedDelegate set_autoConfigureDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureDistance_InjectedDelegate>("UnityEngine.SpringJoint2D::set_autoConfigureDistance_Injected");

	private static readonly get_distance_InjectedDelegate get_distance_InjectedDelegateField = IL2CPP.ResolveICall<get_distance_InjectedDelegate>("UnityEngine.SpringJoint2D::get_distance_Injected");

	private static readonly set_distance_InjectedDelegate set_distance_InjectedDelegateField = IL2CPP.ResolveICall<set_distance_InjectedDelegate>("UnityEngine.SpringJoint2D::set_distance_Injected");

	private static readonly get_dampingRatio_InjectedDelegate get_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_dampingRatio_InjectedDelegate>("UnityEngine.SpringJoint2D::get_dampingRatio_Injected");

	private static readonly set_dampingRatio_InjectedDelegate set_dampingRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_dampingRatio_InjectedDelegate>("UnityEngine.SpringJoint2D::set_dampingRatio_Injected");

	private static readonly get_frequency_InjectedDelegate get_frequency_InjectedDelegateField = IL2CPP.ResolveICall<get_frequency_InjectedDelegate>("UnityEngine.SpringJoint2D::get_frequency_Injected");

	private static readonly set_frequency_InjectedDelegate set_frequency_InjectedDelegateField = IL2CPP.ResolveICall<set_frequency_InjectedDelegate>("UnityEngine.SpringJoint2D::set_frequency_Injected");

	public bool autoConfigureDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureDistance_Injected(intPtr, value);
		}
	}

	public float distance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_distance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_distance_Injected(intPtr, value);
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

	public static bool get_autoConfigureDistance_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureDistance_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_distance_Injected(IntPtr _unity_self)
	{
		return get_distance_InjectedDelegateField(_unity_self);
	}

	public static void set_distance_Injected(IntPtr _unity_self, float value)
	{
		set_distance_InjectedDelegateField(_unity_self, value);
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
