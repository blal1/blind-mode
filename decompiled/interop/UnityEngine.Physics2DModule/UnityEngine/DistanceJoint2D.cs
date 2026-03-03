using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class DistanceJoint2D : AnchoredJoint2D
{
	private delegate bool get_autoConfigureDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureDistance_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_distance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_distance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_maxDistanceOnly_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxDistanceOnly_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_autoConfigureDistance_InjectedDelegate get_autoConfigureDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureDistance_InjectedDelegate>("UnityEngine.DistanceJoint2D::get_autoConfigureDistance_Injected");

	private static readonly set_autoConfigureDistance_InjectedDelegate set_autoConfigureDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureDistance_InjectedDelegate>("UnityEngine.DistanceJoint2D::set_autoConfigureDistance_Injected");

	private static readonly get_distance_InjectedDelegate get_distance_InjectedDelegateField = IL2CPP.ResolveICall<get_distance_InjectedDelegate>("UnityEngine.DistanceJoint2D::get_distance_Injected");

	private static readonly set_distance_InjectedDelegate set_distance_InjectedDelegateField = IL2CPP.ResolveICall<set_distance_InjectedDelegate>("UnityEngine.DistanceJoint2D::set_distance_Injected");

	private static readonly get_maxDistanceOnly_InjectedDelegate get_maxDistanceOnly_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDistanceOnly_InjectedDelegate>("UnityEngine.DistanceJoint2D::get_maxDistanceOnly_Injected");

	private static readonly set_maxDistanceOnly_InjectedDelegate set_maxDistanceOnly_InjectedDelegateField = IL2CPP.ResolveICall<set_maxDistanceOnly_InjectedDelegate>("UnityEngine.DistanceJoint2D::set_maxDistanceOnly_Injected");

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

	public bool maxDistanceOnly
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDistanceOnly_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxDistanceOnly_Injected(intPtr, value);
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

	public static bool get_maxDistanceOnly_Injected(IntPtr _unity_self)
	{
		return get_maxDistanceOnly_InjectedDelegateField(_unity_self);
	}

	public static void set_maxDistanceOnly_Injected(IntPtr _unity_self, bool value)
	{
		set_maxDistanceOnly_InjectedDelegateField(_unity_self, value);
	}
}
