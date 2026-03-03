using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class PointEffector2D : Effector2D
{
	private delegate float get_forceMagnitude_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceMagnitude_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_forceVariation_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceVariation_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_distanceScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_distanceScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_drag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_drag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_angularDrag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularDrag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate EffectorSelection2D get_forceSource_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceSource_InjectedDelegate(IntPtr _unity_self, EffectorSelection2D value);

	private delegate EffectorSelection2D get_forceTarget_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceTarget_InjectedDelegate(IntPtr _unity_self, EffectorSelection2D value);

	private delegate EffectorForceMode2D get_forceMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceMode_InjectedDelegate(IntPtr _unity_self, EffectorForceMode2D value);

	private static readonly get_forceMagnitude_InjectedDelegate get_forceMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<get_forceMagnitude_InjectedDelegate>("UnityEngine.PointEffector2D::get_forceMagnitude_Injected");

	private static readonly set_forceMagnitude_InjectedDelegate set_forceMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<set_forceMagnitude_InjectedDelegate>("UnityEngine.PointEffector2D::set_forceMagnitude_Injected");

	private static readonly get_forceVariation_InjectedDelegate get_forceVariation_InjectedDelegateField = IL2CPP.ResolveICall<get_forceVariation_InjectedDelegate>("UnityEngine.PointEffector2D::get_forceVariation_Injected");

	private static readonly set_forceVariation_InjectedDelegate set_forceVariation_InjectedDelegateField = IL2CPP.ResolveICall<set_forceVariation_InjectedDelegate>("UnityEngine.PointEffector2D::set_forceVariation_Injected");

	private static readonly get_distanceScale_InjectedDelegate get_distanceScale_InjectedDelegateField = IL2CPP.ResolveICall<get_distanceScale_InjectedDelegate>("UnityEngine.PointEffector2D::get_distanceScale_Injected");

	private static readonly set_distanceScale_InjectedDelegate set_distanceScale_InjectedDelegateField = IL2CPP.ResolveICall<set_distanceScale_InjectedDelegate>("UnityEngine.PointEffector2D::set_distanceScale_Injected");

	private static readonly get_drag_InjectedDelegate get_drag_InjectedDelegateField = IL2CPP.ResolveICall<get_drag_InjectedDelegate>("UnityEngine.PointEffector2D::get_drag_Injected");

	private static readonly set_drag_InjectedDelegate set_drag_InjectedDelegateField = IL2CPP.ResolveICall<set_drag_InjectedDelegate>("UnityEngine.PointEffector2D::set_drag_Injected");

	private static readonly get_angularDrag_InjectedDelegate get_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDrag_InjectedDelegate>("UnityEngine.PointEffector2D::get_angularDrag_Injected");

	private static readonly set_angularDrag_InjectedDelegate set_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDrag_InjectedDelegate>("UnityEngine.PointEffector2D::set_angularDrag_Injected");

	private static readonly get_forceSource_InjectedDelegate get_forceSource_InjectedDelegateField = IL2CPP.ResolveICall<get_forceSource_InjectedDelegate>("UnityEngine.PointEffector2D::get_forceSource_Injected");

	private static readonly set_forceSource_InjectedDelegate set_forceSource_InjectedDelegateField = IL2CPP.ResolveICall<set_forceSource_InjectedDelegate>("UnityEngine.PointEffector2D::set_forceSource_Injected");

	private static readonly get_forceTarget_InjectedDelegate get_forceTarget_InjectedDelegateField = IL2CPP.ResolveICall<get_forceTarget_InjectedDelegate>("UnityEngine.PointEffector2D::get_forceTarget_Injected");

	private static readonly set_forceTarget_InjectedDelegate set_forceTarget_InjectedDelegateField = IL2CPP.ResolveICall<set_forceTarget_InjectedDelegate>("UnityEngine.PointEffector2D::set_forceTarget_Injected");

	private static readonly get_forceMode_InjectedDelegate get_forceMode_InjectedDelegateField = IL2CPP.ResolveICall<get_forceMode_InjectedDelegate>("UnityEngine.PointEffector2D::get_forceMode_Injected");

	private static readonly set_forceMode_InjectedDelegate set_forceMode_InjectedDelegateField = IL2CPP.ResolveICall<set_forceMode_InjectedDelegate>("UnityEngine.PointEffector2D::set_forceMode_Injected");

	public float forceMagnitude
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceMagnitude_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceMagnitude_Injected(intPtr, value);
		}
	}

	public float forceVariation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceVariation_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceVariation_Injected(intPtr, value);
		}
	}

	public float distanceScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_distanceScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_distanceScale_Injected(intPtr, value);
		}
	}

	public float drag
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drag_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drag_Injected(intPtr, value);
		}
	}

	public float angularDrag
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularDrag_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularDrag_Injected(intPtr, value);
		}
	}

	public EffectorSelection2D forceSource
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceSource_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceSource_Injected(intPtr, value);
		}
	}

	public EffectorSelection2D forceTarget
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceTarget_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceTarget_Injected(intPtr, value);
		}
	}

	public EffectorForceMode2D forceMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceMode_Injected(intPtr, value);
		}
	}

	public static float get_forceMagnitude_Injected(IntPtr _unity_self)
	{
		return get_forceMagnitude_InjectedDelegateField(_unity_self);
	}

	public static void set_forceMagnitude_Injected(IntPtr _unity_self, float value)
	{
		set_forceMagnitude_InjectedDelegateField(_unity_self, value);
	}

	public static float get_forceVariation_Injected(IntPtr _unity_self)
	{
		return get_forceVariation_InjectedDelegateField(_unity_self);
	}

	public static void set_forceVariation_Injected(IntPtr _unity_self, float value)
	{
		set_forceVariation_InjectedDelegateField(_unity_self, value);
	}

	public static float get_distanceScale_Injected(IntPtr _unity_self)
	{
		return get_distanceScale_InjectedDelegateField(_unity_self);
	}

	public static void set_distanceScale_Injected(IntPtr _unity_self, float value)
	{
		set_distanceScale_InjectedDelegateField(_unity_self, value);
	}

	public static float get_drag_Injected(IntPtr _unity_self)
	{
		return get_drag_InjectedDelegateField(_unity_self);
	}

	public static void set_drag_Injected(IntPtr _unity_self, float value)
	{
		set_drag_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularDrag_Injected(IntPtr _unity_self)
	{
		return get_angularDrag_InjectedDelegateField(_unity_self);
	}

	public static void set_angularDrag_Injected(IntPtr _unity_self, float value)
	{
		set_angularDrag_InjectedDelegateField(_unity_self, value);
	}

	public static EffectorSelection2D get_forceSource_Injected(IntPtr _unity_self)
	{
		return get_forceSource_InjectedDelegateField(_unity_self);
	}

	public static void set_forceSource_Injected(IntPtr _unity_self, EffectorSelection2D value)
	{
		set_forceSource_InjectedDelegateField(_unity_self, value);
	}

	public static EffectorSelection2D get_forceTarget_Injected(IntPtr _unity_self)
	{
		return get_forceTarget_InjectedDelegateField(_unity_self);
	}

	public static void set_forceTarget_Injected(IntPtr _unity_self, EffectorSelection2D value)
	{
		set_forceTarget_InjectedDelegateField(_unity_self, value);
	}

	public static EffectorForceMode2D get_forceMode_Injected(IntPtr _unity_self)
	{
		return get_forceMode_InjectedDelegateField(_unity_self);
	}

	public static void set_forceMode_Injected(IntPtr _unity_self, EffectorForceMode2D value)
	{
		set_forceMode_InjectedDelegateField(_unity_self, value);
	}
}
