using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class SurfaceEffector2D : Effector2D
{
	private delegate float get_speed_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_speed_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_speedVariation_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_speedVariation_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_forceScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_useContactForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useContactForce_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useFriction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useFriction_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useBounce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useBounce_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_speed_InjectedDelegate get_speed_InjectedDelegateField = IL2CPP.ResolveICall<get_speed_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_speed_Injected");

	private static readonly set_speed_InjectedDelegate set_speed_InjectedDelegateField = IL2CPP.ResolveICall<set_speed_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_speed_Injected");

	private static readonly get_speedVariation_InjectedDelegate get_speedVariation_InjectedDelegateField = IL2CPP.ResolveICall<get_speedVariation_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_speedVariation_Injected");

	private static readonly set_speedVariation_InjectedDelegate set_speedVariation_InjectedDelegateField = IL2CPP.ResolveICall<set_speedVariation_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_speedVariation_Injected");

	private static readonly get_forceScale_InjectedDelegate get_forceScale_InjectedDelegateField = IL2CPP.ResolveICall<get_forceScale_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_forceScale_Injected");

	private static readonly set_forceScale_InjectedDelegate set_forceScale_InjectedDelegateField = IL2CPP.ResolveICall<set_forceScale_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_forceScale_Injected");

	private static readonly get_useContactForce_InjectedDelegate get_useContactForce_InjectedDelegateField = IL2CPP.ResolveICall<get_useContactForce_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_useContactForce_Injected");

	private static readonly set_useContactForce_InjectedDelegate set_useContactForce_InjectedDelegateField = IL2CPP.ResolveICall<set_useContactForce_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_useContactForce_Injected");

	private static readonly get_useFriction_InjectedDelegate get_useFriction_InjectedDelegateField = IL2CPP.ResolveICall<get_useFriction_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_useFriction_Injected");

	private static readonly set_useFriction_InjectedDelegate set_useFriction_InjectedDelegateField = IL2CPP.ResolveICall<set_useFriction_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_useFriction_Injected");

	private static readonly get_useBounce_InjectedDelegate get_useBounce_InjectedDelegateField = IL2CPP.ResolveICall<get_useBounce_InjectedDelegate>("UnityEngine.SurfaceEffector2D::get_useBounce_Injected");

	private static readonly set_useBounce_InjectedDelegate set_useBounce_InjectedDelegateField = IL2CPP.ResolveICall<set_useBounce_InjectedDelegate>("UnityEngine.SurfaceEffector2D::set_useBounce_Injected");

	public float speed
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_speed_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_speed_Injected(intPtr, value);
		}
	}

	public float speedVariation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_speedVariation_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_speedVariation_Injected(intPtr, value);
		}
	}

	public float forceScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceScale_Injected(intPtr, value);
		}
	}

	public bool useContactForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useContactForce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useContactForce_Injected(intPtr, value);
		}
	}

	public bool useFriction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useFriction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useFriction_Injected(intPtr, value);
		}
	}

	public bool useBounce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useBounce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useBounce_Injected(intPtr, value);
		}
	}

	public static float get_speed_Injected(IntPtr _unity_self)
	{
		return get_speed_InjectedDelegateField(_unity_self);
	}

	public static void set_speed_Injected(IntPtr _unity_self, float value)
	{
		set_speed_InjectedDelegateField(_unity_self, value);
	}

	public static float get_speedVariation_Injected(IntPtr _unity_self)
	{
		return get_speedVariation_InjectedDelegateField(_unity_self);
	}

	public static void set_speedVariation_Injected(IntPtr _unity_self, float value)
	{
		set_speedVariation_InjectedDelegateField(_unity_self, value);
	}

	public static float get_forceScale_Injected(IntPtr _unity_self)
	{
		return get_forceScale_InjectedDelegateField(_unity_self);
	}

	public static void set_forceScale_Injected(IntPtr _unity_self, float value)
	{
		set_forceScale_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useContactForce_Injected(IntPtr _unity_self)
	{
		return get_useContactForce_InjectedDelegateField(_unity_self);
	}

	public static void set_useContactForce_Injected(IntPtr _unity_self, bool value)
	{
		set_useContactForce_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useFriction_Injected(IntPtr _unity_self)
	{
		return get_useFriction_InjectedDelegateField(_unity_self);
	}

	public static void set_useFriction_Injected(IntPtr _unity_self, bool value)
	{
		set_useFriction_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useBounce_Injected(IntPtr _unity_self)
	{
		return get_useBounce_InjectedDelegateField(_unity_self);
	}

	public static void set_useBounce_Injected(IntPtr _unity_self, bool value)
	{
		set_useBounce_InjectedDelegateField(_unity_self, value);
	}
}
