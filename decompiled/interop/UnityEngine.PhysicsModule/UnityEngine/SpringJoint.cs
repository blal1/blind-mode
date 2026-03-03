using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class SpringJoint : Joint
{
	private delegate float get_spring_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_spring_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_damper_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_damper_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_minDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_minDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_tolerance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_tolerance_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_spring_InjectedDelegate get_spring_InjectedDelegateField = IL2CPP.ResolveICall<get_spring_InjectedDelegate>("UnityEngine.SpringJoint::get_spring_Injected");

	private static readonly set_spring_InjectedDelegate set_spring_InjectedDelegateField = IL2CPP.ResolveICall<set_spring_InjectedDelegate>("UnityEngine.SpringJoint::set_spring_Injected");

	private static readonly get_damper_InjectedDelegate get_damper_InjectedDelegateField = IL2CPP.ResolveICall<get_damper_InjectedDelegate>("UnityEngine.SpringJoint::get_damper_Injected");

	private static readonly set_damper_InjectedDelegate set_damper_InjectedDelegateField = IL2CPP.ResolveICall<set_damper_InjectedDelegate>("UnityEngine.SpringJoint::set_damper_Injected");

	private static readonly get_minDistance_InjectedDelegate get_minDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_minDistance_InjectedDelegate>("UnityEngine.SpringJoint::get_minDistance_Injected");

	private static readonly set_minDistance_InjectedDelegate set_minDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_minDistance_InjectedDelegate>("UnityEngine.SpringJoint::set_minDistance_Injected");

	private static readonly get_maxDistance_InjectedDelegate get_maxDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDistance_InjectedDelegate>("UnityEngine.SpringJoint::get_maxDistance_Injected");

	private static readonly set_maxDistance_InjectedDelegate set_maxDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_maxDistance_InjectedDelegate>("UnityEngine.SpringJoint::set_maxDistance_Injected");

	private static readonly get_tolerance_InjectedDelegate get_tolerance_InjectedDelegateField = IL2CPP.ResolveICall<get_tolerance_InjectedDelegate>("UnityEngine.SpringJoint::get_tolerance_Injected");

	private static readonly set_tolerance_InjectedDelegate set_tolerance_InjectedDelegateField = IL2CPP.ResolveICall<set_tolerance_InjectedDelegate>("UnityEngine.SpringJoint::set_tolerance_Injected");

	public float spring
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spring_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_spring_Injected(intPtr, value);
		}
	}

	public float damper
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_damper_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_damper_Injected(intPtr, value);
		}
	}

	public float minDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_minDistance_Injected(intPtr, value);
		}
	}

	public float maxDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxDistance_Injected(intPtr, value);
		}
	}

	public float tolerance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_tolerance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tolerance_Injected(intPtr, value);
		}
	}

	public static float get_spring_Injected(IntPtr _unity_self)
	{
		return get_spring_InjectedDelegateField(_unity_self);
	}

	public static void set_spring_Injected(IntPtr _unity_self, float value)
	{
		set_spring_InjectedDelegateField(_unity_self, value);
	}

	public static float get_damper_Injected(IntPtr _unity_self)
	{
		return get_damper_InjectedDelegateField(_unity_self);
	}

	public static void set_damper_Injected(IntPtr _unity_self, float value)
	{
		set_damper_InjectedDelegateField(_unity_self, value);
	}

	public static float get_minDistance_Injected(IntPtr _unity_self)
	{
		return get_minDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_minDistance_Injected(IntPtr _unity_self, float value)
	{
		set_minDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxDistance_Injected(IntPtr _unity_self)
	{
		return get_maxDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_maxDistance_Injected(IntPtr _unity_self, float value)
	{
		set_maxDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_tolerance_Injected(IntPtr _unity_self)
	{
		return get_tolerance_InjectedDelegateField(_unity_self);
	}

	public static void set_tolerance_Injected(IntPtr _unity_self, float value)
	{
		set_tolerance_InjectedDelegateField(_unity_self, value);
	}
}
