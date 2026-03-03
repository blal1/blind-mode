using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
{
	private delegate void get_force_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_force_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_relativeForce_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_relativeForce_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_torque_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_torque_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_force_InjectedDelegate get_force_InjectedDelegateField = IL2CPP.ResolveICall<get_force_InjectedDelegate>("UnityEngine.ConstantForce2D::get_force_Injected");

	private static readonly set_force_InjectedDelegate set_force_InjectedDelegateField = IL2CPP.ResolveICall<set_force_InjectedDelegate>("UnityEngine.ConstantForce2D::set_force_Injected");

	private static readonly get_relativeForce_InjectedDelegate get_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<get_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::get_relativeForce_Injected");

	private static readonly set_relativeForce_InjectedDelegate set_relativeForce_InjectedDelegateField = IL2CPP.ResolveICall<set_relativeForce_InjectedDelegate>("UnityEngine.ConstantForce2D::set_relativeForce_Injected");

	private static readonly get_torque_InjectedDelegate get_torque_InjectedDelegateField = IL2CPP.ResolveICall<get_torque_InjectedDelegate>("UnityEngine.ConstantForce2D::get_torque_Injected");

	private static readonly set_torque_InjectedDelegate set_torque_InjectedDelegateField = IL2CPP.ResolveICall<set_torque_InjectedDelegate>("UnityEngine.ConstantForce2D::set_torque_Injected");

	public Vector2 force
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

	public Vector2 relativeForce
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

	public float torque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_torque_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_torque_Injected(intPtr, value);
		}
	}

	public unsafe static void get_force_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_force_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_force_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_force_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_relativeForce_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_relativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_relativeForce_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_relativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_torque_Injected(IntPtr _unity_self)
	{
		return get_torque_InjectedDelegateField(_unity_self);
	}

	public static void set_torque_Injected(IntPtr _unity_self, float value)
	{
		set_torque_InjectedDelegateField(_unity_self, value);
	}
}
