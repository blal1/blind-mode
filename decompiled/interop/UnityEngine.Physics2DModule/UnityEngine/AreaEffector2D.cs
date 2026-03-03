using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AreaEffector2D : Effector2D
{
	private delegate float get_forceAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceAngle_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_useGlobalAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useGlobalAngle_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_forceMagnitude_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceMagnitude_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_forceVariation_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceVariation_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_drag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_drag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_angularDrag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularDrag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate EffectorSelection2D get_forceTarget_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_forceTarget_InjectedDelegate(IntPtr _unity_self, EffectorSelection2D value);

	private static readonly get_forceAngle_InjectedDelegate get_forceAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_forceAngle_InjectedDelegate>("UnityEngine.AreaEffector2D::get_forceAngle_Injected");

	private static readonly set_forceAngle_InjectedDelegate set_forceAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_forceAngle_InjectedDelegate>("UnityEngine.AreaEffector2D::set_forceAngle_Injected");

	private static readonly get_useGlobalAngle_InjectedDelegate get_useGlobalAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_useGlobalAngle_InjectedDelegate>("UnityEngine.AreaEffector2D::get_useGlobalAngle_Injected");

	private static readonly set_useGlobalAngle_InjectedDelegate set_useGlobalAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_useGlobalAngle_InjectedDelegate>("UnityEngine.AreaEffector2D::set_useGlobalAngle_Injected");

	private static readonly get_forceMagnitude_InjectedDelegate get_forceMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<get_forceMagnitude_InjectedDelegate>("UnityEngine.AreaEffector2D::get_forceMagnitude_Injected");

	private static readonly set_forceMagnitude_InjectedDelegate set_forceMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<set_forceMagnitude_InjectedDelegate>("UnityEngine.AreaEffector2D::set_forceMagnitude_Injected");

	private static readonly get_forceVariation_InjectedDelegate get_forceVariation_InjectedDelegateField = IL2CPP.ResolveICall<get_forceVariation_InjectedDelegate>("UnityEngine.AreaEffector2D::get_forceVariation_Injected");

	private static readonly set_forceVariation_InjectedDelegate set_forceVariation_InjectedDelegateField = IL2CPP.ResolveICall<set_forceVariation_InjectedDelegate>("UnityEngine.AreaEffector2D::set_forceVariation_Injected");

	private static readonly get_drag_InjectedDelegate get_drag_InjectedDelegateField = IL2CPP.ResolveICall<get_drag_InjectedDelegate>("UnityEngine.AreaEffector2D::get_drag_Injected");

	private static readonly set_drag_InjectedDelegate set_drag_InjectedDelegateField = IL2CPP.ResolveICall<set_drag_InjectedDelegate>("UnityEngine.AreaEffector2D::set_drag_Injected");

	private static readonly get_angularDrag_InjectedDelegate get_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDrag_InjectedDelegate>("UnityEngine.AreaEffector2D::get_angularDrag_Injected");

	private static readonly set_angularDrag_InjectedDelegate set_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDrag_InjectedDelegate>("UnityEngine.AreaEffector2D::set_angularDrag_Injected");

	private static readonly get_forceTarget_InjectedDelegate get_forceTarget_InjectedDelegateField = IL2CPP.ResolveICall<get_forceTarget_InjectedDelegate>("UnityEngine.AreaEffector2D::get_forceTarget_Injected");

	private static readonly set_forceTarget_InjectedDelegate set_forceTarget_InjectedDelegateField = IL2CPP.ResolveICall<set_forceTarget_InjectedDelegate>("UnityEngine.AreaEffector2D::set_forceTarget_Injected");

	public float forceAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_forceAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceAngle_Injected(intPtr, value);
		}
	}

	public bool useGlobalAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useGlobalAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useGlobalAngle_Injected(intPtr, value);
		}
	}

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

	public float forceDirection
	{
		get
		{
			return forceAngle;
		}
		set
		{
			forceAngle = value;
		}
	}

	public static float get_forceAngle_Injected(IntPtr _unity_self)
	{
		return get_forceAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_forceAngle_Injected(IntPtr _unity_self, float value)
	{
		set_forceAngle_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useGlobalAngle_Injected(IntPtr _unity_self)
	{
		return get_useGlobalAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_useGlobalAngle_Injected(IntPtr _unity_self, bool value)
	{
		set_useGlobalAngle_InjectedDelegateField(_unity_self, value);
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

	public static EffectorSelection2D get_forceTarget_Injected(IntPtr _unity_self)
	{
		return get_forceTarget_InjectedDelegateField(_unity_self);
	}

	public static void set_forceTarget_Injected(IntPtr _unity_self, EffectorSelection2D value)
	{
		set_forceTarget_InjectedDelegateField(_unity_self, value);
	}
}
