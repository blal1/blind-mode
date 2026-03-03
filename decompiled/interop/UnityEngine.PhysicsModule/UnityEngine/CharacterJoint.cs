using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class CharacterJoint : Joint
{
	private delegate void get_swingAxis_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_swingAxis_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_enableProjection_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enableProjection_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_projectionDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_projectionDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_projectionAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_projectionAngle_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_swingAxis_InjectedDelegate get_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<get_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::get_swingAxis_Injected");

	private static readonly set_swingAxis_InjectedDelegate set_swingAxis_InjectedDelegateField = IL2CPP.ResolveICall<set_swingAxis_InjectedDelegate>("UnityEngine.CharacterJoint::set_swingAxis_Injected");

	private static readonly get_enableProjection_InjectedDelegate get_enableProjection_InjectedDelegateField = IL2CPP.ResolveICall<get_enableProjection_InjectedDelegate>("UnityEngine.CharacterJoint::get_enableProjection_Injected");

	private static readonly set_enableProjection_InjectedDelegate set_enableProjection_InjectedDelegateField = IL2CPP.ResolveICall<set_enableProjection_InjectedDelegate>("UnityEngine.CharacterJoint::set_enableProjection_Injected");

	private static readonly get_projectionDistance_InjectedDelegate get_projectionDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionDistance_InjectedDelegate>("UnityEngine.CharacterJoint::get_projectionDistance_Injected");

	private static readonly set_projectionDistance_InjectedDelegate set_projectionDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionDistance_InjectedDelegate>("UnityEngine.CharacterJoint::set_projectionDistance_Injected");

	private static readonly get_projectionAngle_InjectedDelegate get_projectionAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_projectionAngle_InjectedDelegate>("UnityEngine.CharacterJoint::get_projectionAngle_Injected");

	private static readonly set_projectionAngle_InjectedDelegate set_projectionAngle_InjectedDelegateField = IL2CPP.ResolveICall<set_projectionAngle_InjectedDelegate>("UnityEngine.CharacterJoint::set_projectionAngle_Injected");

	public Vector3 swingAxis
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_swingAxis_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_swingAxis_Injected(intPtr, ref value);
		}
	}

	public bool enableProjection
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableProjection_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableProjection_Injected(intPtr, value);
		}
	}

	public float projectionDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionDistance_Injected(intPtr, value);
		}
	}

	public float projectionAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_projectionAngle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_projectionAngle_Injected(intPtr, value);
		}
	}

	public unsafe static void get_swingAxis_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_swingAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_swingAxis_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_swingAxis_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_enableProjection_Injected(IntPtr _unity_self)
	{
		return get_enableProjection_InjectedDelegateField(_unity_self);
	}

	public static void set_enableProjection_Injected(IntPtr _unity_self, bool value)
	{
		set_enableProjection_InjectedDelegateField(_unity_self, value);
	}

	public static float get_projectionDistance_Injected(IntPtr _unity_self)
	{
		return get_projectionDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_projectionDistance_Injected(IntPtr _unity_self, float value)
	{
		set_projectionDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_projectionAngle_Injected(IntPtr _unity_self)
	{
		return get_projectionAngle_InjectedDelegateField(_unity_self);
	}

	public static void set_projectionAngle_Injected(IntPtr _unity_self, float value)
	{
		set_projectionAngle_InjectedDelegateField(_unity_self, value);
	}
}
