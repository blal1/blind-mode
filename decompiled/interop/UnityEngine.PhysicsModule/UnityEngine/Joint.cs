using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Joint : Component
{
	private delegate IntPtr get_connectedBody_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_connectedBody_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_connectedArticulationBody_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_connectedArticulationBody_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate void get_axis_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_axis_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_anchor_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_anchor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_connectedAnchor_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_connectedAnchor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_autoConfigureConnectedAnchor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureConnectedAnchor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_breakForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_breakForce_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_breakTorque_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_breakTorque_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_enableCollision_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enableCollision_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_enablePreprocessing_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enablePreprocessing_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_massScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_massScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_connectedMassScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_connectedMassScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void GetCurrentForces_InjectedDelegate(IntPtr _unity_self, IntPtr linearForce, IntPtr angularForce);

	private static readonly get_connectedBody_InjectedDelegate get_connectedBody_InjectedDelegateField = IL2CPP.ResolveICall<get_connectedBody_InjectedDelegate>("UnityEngine.Joint::get_connectedBody_Injected");

	private static readonly set_connectedBody_InjectedDelegate set_connectedBody_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedBody_InjectedDelegate>("UnityEngine.Joint::set_connectedBody_Injected");

	private static readonly get_connectedArticulationBody_InjectedDelegate get_connectedArticulationBody_InjectedDelegateField = IL2CPP.ResolveICall<get_connectedArticulationBody_InjectedDelegate>("UnityEngine.Joint::get_connectedArticulationBody_Injected");

	private static readonly set_connectedArticulationBody_InjectedDelegate set_connectedArticulationBody_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedArticulationBody_InjectedDelegate>("UnityEngine.Joint::set_connectedArticulationBody_Injected");

	private static readonly get_axis_InjectedDelegate get_axis_InjectedDelegateField = IL2CPP.ResolveICall<get_axis_InjectedDelegate>("UnityEngine.Joint::get_axis_Injected");

	private static readonly set_axis_InjectedDelegate set_axis_InjectedDelegateField = IL2CPP.ResolveICall<set_axis_InjectedDelegate>("UnityEngine.Joint::set_axis_Injected");

	private static readonly get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<get_anchor_InjectedDelegate>("UnityEngine.Joint::get_anchor_Injected");

	private static readonly set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<set_anchor_InjectedDelegate>("UnityEngine.Joint::set_anchor_Injected");

	private static readonly get_connectedAnchor_InjectedDelegate get_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<get_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::get_connectedAnchor_Injected");

	private static readonly set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedAnchor_InjectedDelegate>("UnityEngine.Joint::set_connectedAnchor_Injected");

	private static readonly get_autoConfigureConnectedAnchor_InjectedDelegate get_autoConfigureConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureConnectedAnchor_InjectedDelegate>("UnityEngine.Joint::get_autoConfigureConnectedAnchor_Injected");

	private static readonly set_autoConfigureConnectedAnchor_InjectedDelegate set_autoConfigureConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureConnectedAnchor_InjectedDelegate>("UnityEngine.Joint::set_autoConfigureConnectedAnchor_Injected");

	private static readonly get_breakForce_InjectedDelegate get_breakForce_InjectedDelegateField = IL2CPP.ResolveICall<get_breakForce_InjectedDelegate>("UnityEngine.Joint::get_breakForce_Injected");

	private static readonly set_breakForce_InjectedDelegate set_breakForce_InjectedDelegateField = IL2CPP.ResolveICall<set_breakForce_InjectedDelegate>("UnityEngine.Joint::set_breakForce_Injected");

	private static readonly get_breakTorque_InjectedDelegate get_breakTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_breakTorque_InjectedDelegate>("UnityEngine.Joint::get_breakTorque_Injected");

	private static readonly set_breakTorque_InjectedDelegate set_breakTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_breakTorque_InjectedDelegate>("UnityEngine.Joint::set_breakTorque_Injected");

	private static readonly get_enableCollision_InjectedDelegate get_enableCollision_InjectedDelegateField = IL2CPP.ResolveICall<get_enableCollision_InjectedDelegate>("UnityEngine.Joint::get_enableCollision_Injected");

	private static readonly set_enableCollision_InjectedDelegate set_enableCollision_InjectedDelegateField = IL2CPP.ResolveICall<set_enableCollision_InjectedDelegate>("UnityEngine.Joint::set_enableCollision_Injected");

	private static readonly get_enablePreprocessing_InjectedDelegate get_enablePreprocessing_InjectedDelegateField = IL2CPP.ResolveICall<get_enablePreprocessing_InjectedDelegate>("UnityEngine.Joint::get_enablePreprocessing_Injected");

	private static readonly set_enablePreprocessing_InjectedDelegate set_enablePreprocessing_InjectedDelegateField = IL2CPP.ResolveICall<set_enablePreprocessing_InjectedDelegate>("UnityEngine.Joint::set_enablePreprocessing_Injected");

	private static readonly get_massScale_InjectedDelegate get_massScale_InjectedDelegateField = IL2CPP.ResolveICall<get_massScale_InjectedDelegate>("UnityEngine.Joint::get_massScale_Injected");

	private static readonly set_massScale_InjectedDelegate set_massScale_InjectedDelegateField = IL2CPP.ResolveICall<set_massScale_InjectedDelegate>("UnityEngine.Joint::set_massScale_Injected");

	private static readonly get_connectedMassScale_InjectedDelegate get_connectedMassScale_InjectedDelegateField = IL2CPP.ResolveICall<get_connectedMassScale_InjectedDelegate>("UnityEngine.Joint::get_connectedMassScale_Injected");

	private static readonly set_connectedMassScale_InjectedDelegate set_connectedMassScale_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedMassScale_InjectedDelegate>("UnityEngine.Joint::set_connectedMassScale_Injected");

	private static readonly GetCurrentForces_InjectedDelegate GetCurrentForces_InjectedDelegateField = IL2CPP.ResolveICall<GetCurrentForces_InjectedDelegate>("UnityEngine.Joint::GetCurrentForces_Injected");

	public Rigidbody connectedBody
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Rigidbody>(get_connectedBody_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedBody_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public ArticulationBody connectedArticulationBody
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<ArticulationBody>(get_connectedArticulationBody_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedArticulationBody_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Vector3 axis
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_axis_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_axis_Injected(intPtr, ref value);
		}
	}

	public Vector3 anchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_anchor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchor_Injected(intPtr, ref value);
		}
	}

	public Vector3 connectedAnchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_connectedAnchor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedAnchor_Injected(intPtr, ref value);
		}
	}

	public bool autoConfigureConnectedAnchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureConnectedAnchor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureConnectedAnchor_Injected(intPtr, value);
		}
	}

	public float breakForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_breakForce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_breakForce_Injected(intPtr, value);
		}
	}

	public float breakTorque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_breakTorque_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_breakTorque_Injected(intPtr, value);
		}
	}

	public bool enableCollision
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableCollision_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableCollision_Injected(intPtr, value);
		}
	}

	public bool enablePreprocessing
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enablePreprocessing_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enablePreprocessing_Injected(intPtr, value);
		}
	}

	public float massScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_massScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_massScale_Injected(intPtr, value);
		}
	}

	public float connectedMassScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_connectedMassScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedMassScale_Injected(intPtr, value);
		}
	}

	public Vector3 currentForce
	{
		get
		{
			Vector3 linearForce = Vector3.zero;
			Vector3 angularForce = Vector3.zero;
			GetCurrentForces(ref linearForce, ref angularForce);
			return linearForce;
		}
	}

	public Vector3 currentTorque
	{
		get
		{
			Vector3 linearForce = Vector3.zero;
			Vector3 angularForce = Vector3.zero;
			GetCurrentForces(ref linearForce, ref angularForce);
			return angularForce;
		}
	}

	public void GetCurrentForces(ref Vector3 linearForce, ref Vector3 angularForce)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetCurrentForces_Injected(intPtr, ref linearForce, ref angularForce);
	}

	public static IntPtr get_connectedBody_Injected(IntPtr _unity_self)
	{
		return get_connectedBody_InjectedDelegateField(_unity_self);
	}

	public static void set_connectedBody_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_connectedBody_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_connectedArticulationBody_Injected(IntPtr _unity_self)
	{
		return get_connectedArticulationBody_InjectedDelegateField(_unity_self);
	}

	public static void set_connectedArticulationBody_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_connectedArticulationBody_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_axis_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_axis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_axis_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_axis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_anchor_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_anchor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_connectedAnchor_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_connectedAnchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_connectedAnchor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_connectedAnchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureConnectedAnchor_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureConnectedAnchor_InjectedDelegateField(_unity_self, value);
	}

	public static float get_breakForce_Injected(IntPtr _unity_self)
	{
		return get_breakForce_InjectedDelegateField(_unity_self);
	}

	public static void set_breakForce_Injected(IntPtr _unity_self, float value)
	{
		set_breakForce_InjectedDelegateField(_unity_self, value);
	}

	public static float get_breakTorque_Injected(IntPtr _unity_self)
	{
		return get_breakTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_breakTorque_Injected(IntPtr _unity_self, float value)
	{
		set_breakTorque_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableCollision_Injected(IntPtr _unity_self)
	{
		return get_enableCollision_InjectedDelegateField(_unity_self);
	}

	public static void set_enableCollision_Injected(IntPtr _unity_self, bool value)
	{
		set_enableCollision_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enablePreprocessing_Injected(IntPtr _unity_self)
	{
		return get_enablePreprocessing_InjectedDelegateField(_unity_self);
	}

	public static void set_enablePreprocessing_Injected(IntPtr _unity_self, bool value)
	{
		set_enablePreprocessing_InjectedDelegateField(_unity_self, value);
	}

	public static float get_massScale_Injected(IntPtr _unity_self)
	{
		return get_massScale_InjectedDelegateField(_unity_self);
	}

	public static void set_massScale_Injected(IntPtr _unity_self, float value)
	{
		set_massScale_InjectedDelegateField(_unity_self, value);
	}

	public static float get_connectedMassScale_Injected(IntPtr _unity_self)
	{
		return get_connectedMassScale_InjectedDelegateField(_unity_self);
	}

	public static void set_connectedMassScale_Injected(IntPtr _unity_self, float value)
	{
		set_connectedMassScale_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetCurrentForces_Injected(IntPtr _unity_self, ref Vector3 linearForce, ref Vector3 angularForce)
	{
		GetCurrentForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref linearForce), (nint)Unsafe.AsPointer(ref angularForce));
	}
}
