using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class BuoyancyEffector2D : Effector2D
{
	private delegate float get_surfaceLevel_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_surfaceLevel_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_density_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_density_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_linearDrag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_linearDrag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_angularDrag_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularDrag_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_flowAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flowAngle_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_flowMagnitude_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flowMagnitude_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_flowVariation_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_flowVariation_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_surfaceLevel_InjectedDelegate get_surfaceLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_surfaceLevel_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_surfaceLevel_Injected");

	private static readonly set_surfaceLevel_InjectedDelegate set_surfaceLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_surfaceLevel_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_surfaceLevel_Injected");

	private static readonly get_density_InjectedDelegate get_density_InjectedDelegateField = IL2CPP.ResolveICall<get_density_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_density_Injected");

	private static readonly set_density_InjectedDelegate set_density_InjectedDelegateField = IL2CPP.ResolveICall<set_density_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_density_Injected");

	private static readonly get_linearDrag_InjectedDelegate get_linearDrag_InjectedDelegateField = IL2CPP.ResolveICall<get_linearDrag_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_linearDrag_Injected");

	private static readonly set_linearDrag_InjectedDelegate set_linearDrag_InjectedDelegateField = IL2CPP.ResolveICall<set_linearDrag_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_linearDrag_Injected");

	private static readonly get_angularDrag_InjectedDelegate get_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDrag_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_angularDrag_Injected");

	private static readonly set_angularDrag_InjectedDelegate set_angularDrag_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDrag_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_angularDrag_Injected");

	private static readonly get_flowAngle_InjectedDelegate get_flowAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_flowAngle_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_flowAngle_Injected");

	private static readonly set_flowAngle_InjectedDelegate set_flowAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_flowAngle_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_flowAngle_Injected");

	private static readonly get_flowMagnitude_InjectedDelegate get_flowMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<get_flowMagnitude_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_flowMagnitude_Injected");

	private static readonly set_flowMagnitude_InjectedDelegate set_flowMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<set_flowMagnitude_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_flowMagnitude_Injected");

	private static readonly get_flowVariation_InjectedDelegate get_flowVariation_InjectedDelegateField = IL2CPP.ResolveICall<get_flowVariation_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::get_flowVariation_Injected");

	private static readonly set_flowVariation_InjectedDelegate set_flowVariation_InjectedDelegateField = IL2CPP.ResolveICall<set_flowVariation_InjectedDelegate>("UnityEngine.BuoyancyEffector2D::set_flowVariation_Injected");

	public float surfaceLevel
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_surfaceLevel_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_surfaceLevel_Injected(intPtr, value);
		}
	}

	public float density
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_density_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_density_Injected(intPtr, value);
		}
	}

	public float linearDrag
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearDrag_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearDrag_Injected(intPtr, value);
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

	public float flowAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_flowAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flowAngle_Injected(intPtr, value);
		}
	}

	public float flowMagnitude
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_flowMagnitude_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flowMagnitude_Injected(intPtr, value);
		}
	}

	public float flowVariation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_flowVariation_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_flowVariation_Injected(intPtr, value);
		}
	}

	public static float get_surfaceLevel_Injected(IntPtr _unity_self)
	{
		return get_surfaceLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_surfaceLevel_Injected(IntPtr _unity_self, float value)
	{
		set_surfaceLevel_InjectedDelegateField(_unity_self, value);
	}

	public static float get_density_Injected(IntPtr _unity_self)
	{
		return get_density_InjectedDelegateField(_unity_self);
	}

	public static void set_density_Injected(IntPtr _unity_self, float value)
	{
		set_density_InjectedDelegateField(_unity_self, value);
	}

	public static float get_linearDrag_Injected(IntPtr _unity_self)
	{
		return get_linearDrag_InjectedDelegateField(_unity_self);
	}

	public static void set_linearDrag_Injected(IntPtr _unity_self, float value)
	{
		set_linearDrag_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularDrag_Injected(IntPtr _unity_self)
	{
		return get_angularDrag_InjectedDelegateField(_unity_self);
	}

	public static void set_angularDrag_Injected(IntPtr _unity_self, float value)
	{
		set_angularDrag_InjectedDelegateField(_unity_self, value);
	}

	public static float get_flowAngle_Injected(IntPtr _unity_self)
	{
		return get_flowAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_flowAngle_Injected(IntPtr _unity_self, float value)
	{
		set_flowAngle_InjectedDelegateField(_unity_self, value);
	}

	public static float get_flowMagnitude_Injected(IntPtr _unity_self)
	{
		return get_flowMagnitude_InjectedDelegateField(_unity_self);
	}

	public static void set_flowMagnitude_Injected(IntPtr _unity_self, float value)
	{
		set_flowMagnitude_InjectedDelegateField(_unity_self, value);
	}

	public static float get_flowVariation_Injected(IntPtr _unity_self)
	{
		return get_flowVariation_InjectedDelegateField(_unity_self);
	}

	public static void set_flowVariation_Injected(IntPtr _unity_self, float value)
	{
		set_flowVariation_InjectedDelegateField(_unity_self, value);
	}
}
