using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ConstantForce : Behaviour
{
	private delegate void get_force_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_force_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_torque_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_torque_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_relativeForce_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_relativeForce_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_relativeTorque_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_relativeTorque_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private static readonly get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<get_force_InjectedDelegate>("UnityEngine.ConstantForce::get_force_Injected");

	private static readonly set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<set_force_InjectedDelegate>("UnityEngine.ConstantForce::set_force_Injected");

	private static readonly get_torque_InjectedDelegate get_torque_InjectedDelegateField = IL2CPP.ResolveICall<get_torque_InjectedDelegate>("UnityEngine.ConstantForce::get_torque_Injected");

	private static readonly set_torque_InjectedDelegate set_torque_InjectedDelegateField = IL2CPP.ResolveICall<set_torque_InjectedDelegate>("UnityEngine.ConstantForce::set_torque_Injected");

	private static readonly get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeForce_Injected");

	private static readonly set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeForce_Injected");

	private static readonly get_relativeTorque_InjectedDelegate get_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::get_relativeTorque_Injected");

	private static readonly set_relativeTorque_InjectedDelegate set_relativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_relativeTorque_InjectedDelegate>("UnityEngine.ConstantForce::set_relativeTorque_Injected");

	public Vector3 force
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_force_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_force_Injected(intPtr, ref value);
		}
	}

	public Vector3 torque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_torque_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_torque_Injected(intPtr, ref value);
		}
	}

	public Vector3 relativeForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_relativeForce_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_relativeForce_Injected(intPtr, ref value);
		}
	}

	public Vector3 relativeTorque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_relativeTorque_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_relativeTorque_Injected(intPtr, ref value);
		}
	}

	public unsafe static void get_force_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_force_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_force_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_force_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_torque_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_torque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_torque_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_torque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_relativeForce_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_relativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_relativeForce_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_relativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_relativeTorque_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_relativeTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_relativeTorque_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_relativeTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}
}
