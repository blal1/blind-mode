using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class PlatformEffector2D : Effector2D
{
	private delegate bool get_useOneWay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useOneWay_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useOneWayGrouping_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useOneWayGrouping_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useSideFriction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useSideFriction_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useSideBounce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useSideBounce_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_surfaceArc_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_surfaceArc_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_sideArc_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_sideArc_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_rotationalOffset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_rotationalOffset_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_useOneWay_InjectedDelegate get_useOneWay_InjectedDelegateField = IL2CPP.ResolveICall<get_useOneWay_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_useOneWay_Injected");

	private static readonly set_useOneWay_InjectedDelegate set_useOneWay_InjectedDelegateField = IL2CPP.ResolveICall<set_useOneWay_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_useOneWay_Injected");

	private static readonly get_useOneWayGrouping_InjectedDelegate get_useOneWayGrouping_InjectedDelegateField = IL2CPP.ResolveICall<get_useOneWayGrouping_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_useOneWayGrouping_Injected");

	private static readonly set_useOneWayGrouping_InjectedDelegate set_useOneWayGrouping_InjectedDelegateField = IL2CPP.ResolveICall<set_useOneWayGrouping_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_useOneWayGrouping_Injected");

	private static readonly get_useSideFriction_InjectedDelegate get_useSideFriction_InjectedDelegateField = IL2CPP.ResolveICall<get_useSideFriction_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_useSideFriction_Injected");

	private static readonly set_useSideFriction_InjectedDelegate set_useSideFriction_InjectedDelegateField = IL2CPP.ResolveICall<set_useSideFriction_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_useSideFriction_Injected");

	private static readonly get_useSideBounce_InjectedDelegate get_useSideBounce_InjectedDelegateField = IL2CPP.ResolveICall<get_useSideBounce_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_useSideBounce_Injected");

	private static readonly set_useSideBounce_InjectedDelegate set_useSideBounce_InjectedDelegateField = IL2CPP.ResolveICall<set_useSideBounce_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_useSideBounce_Injected");

	private static readonly get_surfaceArc_InjectedDelegate get_surfaceArc_InjectedDelegateField = IL2CPP.ResolveICall<get_surfaceArc_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_surfaceArc_Injected");

	private static readonly set_surfaceArc_InjectedDelegate set_surfaceArc_InjectedDelegateField = IL2CPP.ResolveICall<set_surfaceArc_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_surfaceArc_Injected");

	private static readonly get_sideArc_InjectedDelegate get_sideArc_InjectedDelegateField = IL2CPP.ResolveICall<get_sideArc_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_sideArc_Injected");

	private static readonly set_sideArc_InjectedDelegate set_sideArc_InjectedDelegateField = IL2CPP.ResolveICall<set_sideArc_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_sideArc_Injected");

	private static readonly get_rotationalOffset_InjectedDelegate get_rotationalOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_rotationalOffset_InjectedDelegate>("UnityEngine.PlatformEffector2D::get_rotationalOffset_Injected");

	private static readonly set_rotationalOffset_InjectedDelegate set_rotationalOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_rotationalOffset_InjectedDelegate>("UnityEngine.PlatformEffector2D::set_rotationalOffset_Injected");

	public bool useOneWay
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useOneWay_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useOneWay_Injected(intPtr, value);
		}
	}

	public bool useOneWayGrouping
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useOneWayGrouping_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useOneWayGrouping_Injected(intPtr, value);
		}
	}

	public bool useSideFriction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useSideFriction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useSideFriction_Injected(intPtr, value);
		}
	}

	public bool useSideBounce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useSideBounce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useSideBounce_Injected(intPtr, value);
		}
	}

	public float surfaceArc
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_surfaceArc_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_surfaceArc_Injected(intPtr, value);
		}
	}

	public float sideArc
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sideArc_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sideArc_Injected(intPtr, value);
		}
	}

	public float rotationalOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rotationalOffset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rotationalOffset_Injected(intPtr, value);
		}
	}

	public bool oneWay
	{
		get
		{
			return useOneWay;
		}
		set
		{
			useOneWay = value;
		}
	}

	public bool sideFriction
	{
		get
		{
			return useSideFriction;
		}
		set
		{
			useSideFriction = value;
		}
	}

	public bool sideBounce
	{
		get
		{
			return useSideBounce;
		}
		set
		{
			useSideBounce = value;
		}
	}

	public float sideAngleVariance
	{
		get
		{
			return sideArc;
		}
		set
		{
			sideArc = value;
		}
	}

	public static bool get_useOneWay_Injected(IntPtr _unity_self)
	{
		return get_useOneWay_InjectedDelegateField(_unity_self);
	}

	public static void set_useOneWay_Injected(IntPtr _unity_self, bool value)
	{
		set_useOneWay_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useOneWayGrouping_Injected(IntPtr _unity_self)
	{
		return get_useOneWayGrouping_InjectedDelegateField(_unity_self);
	}

	public static void set_useOneWayGrouping_Injected(IntPtr _unity_self, bool value)
	{
		set_useOneWayGrouping_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useSideFriction_Injected(IntPtr _unity_self)
	{
		return get_useSideFriction_InjectedDelegateField(_unity_self);
	}

	public static void set_useSideFriction_Injected(IntPtr _unity_self, bool value)
	{
		set_useSideFriction_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useSideBounce_Injected(IntPtr _unity_self)
	{
		return get_useSideBounce_InjectedDelegateField(_unity_self);
	}

	public static void set_useSideBounce_Injected(IntPtr _unity_self, bool value)
	{
		set_useSideBounce_InjectedDelegateField(_unity_self, value);
	}

	public static float get_surfaceArc_Injected(IntPtr _unity_self)
	{
		return get_surfaceArc_InjectedDelegateField(_unity_self);
	}

	public static void set_surfaceArc_Injected(IntPtr _unity_self, float value)
	{
		set_surfaceArc_InjectedDelegateField(_unity_self, value);
	}

	public static float get_sideArc_Injected(IntPtr _unity_self)
	{
		return get_sideArc_InjectedDelegateField(_unity_self);
	}

	public static void set_sideArc_Injected(IntPtr _unity_self, float value)
	{
		set_sideArc_InjectedDelegateField(_unity_self, value);
	}

	public static float get_rotationalOffset_Injected(IntPtr _unity_self)
	{
		return get_rotationalOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_rotationalOffset_Injected(IntPtr _unity_self, float value)
	{
		set_rotationalOffset_InjectedDelegateField(_unity_self, value);
	}
}
