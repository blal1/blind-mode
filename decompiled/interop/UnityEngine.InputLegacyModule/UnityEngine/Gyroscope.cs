using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public class Gyroscope
{
	private delegate bool getEnabled_InternalDelegate(int idx);

	private delegate void setEnabled_InternalDelegate(int idx, bool enabled);

	private delegate float getUpdateInterval_InternalDelegate(int idx);

	private delegate void setUpdateInterval_InternalDelegate(int idx, float interval);

	private delegate void rotationRate_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

	private delegate void rotationRateUnbiased_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

	private delegate void gravity_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

	private delegate void userAcceleration_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

	private delegate void attitude_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

	private static readonly getEnabled_InternalDelegate getEnabled_InternalDelegateField = IL2CPP.ResolveICall<getEnabled_InternalDelegate>("UnityEngine.Gyroscope::getEnabled_Internal");

	private static readonly setEnabled_InternalDelegate setEnabled_InternalDelegateField = IL2CPP.ResolveICall<setEnabled_InternalDelegate>("UnityEngine.Gyroscope::setEnabled_Internal");

	private static readonly getUpdateInterval_InternalDelegate getUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<getUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::getUpdateInterval_Internal");

	private static readonly setUpdateInterval_InternalDelegate setUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<setUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::setUpdateInterval_Internal");

	private static readonly rotationRate_Internal_InjectedDelegate rotationRate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<rotationRate_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRate_Internal_Injected");

	private static readonly rotationRateUnbiased_Internal_InjectedDelegate rotationRateUnbiased_Internal_InjectedDelegateField = IL2CPP.ResolveICall<rotationRateUnbiased_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRateUnbiased_Internal_Injected");

	private static readonly gravity_Internal_InjectedDelegate gravity_Internal_InjectedDelegateField = IL2CPP.ResolveICall<gravity_Internal_InjectedDelegate>("UnityEngine.Gyroscope::gravity_Internal_Injected");

	private static readonly userAcceleration_Internal_InjectedDelegate userAcceleration_Internal_InjectedDelegateField = IL2CPP.ResolveICall<userAcceleration_Internal_InjectedDelegate>("UnityEngine.Gyroscope::userAcceleration_Internal_Injected");

	private static readonly attitude_Internal_InjectedDelegate attitude_Internal_InjectedDelegateField = IL2CPP.ResolveICall<attitude_Internal_InjectedDelegate>("UnityEngine.Gyroscope::attitude_Internal_Injected");

	public Vector3 rotationRate
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 rotationRateUnbiased
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 gravity
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 userAcceleration
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Quaternion attitude
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool enabled
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float updateInterval
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public static Vector3 rotationRate_Internal(int idx)
	{
		rotationRate_Internal_Injected(idx, out var ret);
		return ret;
	}

	public static Vector3 rotationRateUnbiased_Internal(int idx)
	{
		rotationRateUnbiased_Internal_Injected(idx, out var ret);
		return ret;
	}

	public static Vector3 gravity_Internal(int idx)
	{
		gravity_Internal_Injected(idx, out var ret);
		return ret;
	}

	public static Vector3 userAcceleration_Internal(int idx)
	{
		userAcceleration_Internal_Injected(idx, out var ret);
		return ret;
	}

	public static Quaternion attitude_Internal(int idx)
	{
		attitude_Internal_Injected(idx, out var ret);
		return ret;
	}

	public static bool getEnabled_Internal(int idx)
	{
		return getEnabled_InternalDelegateField(idx);
	}

	public static void setEnabled_Internal(int idx, bool enabled)
	{
		setEnabled_InternalDelegateField(idx, enabled);
	}

	public static float getUpdateInterval_Internal(int idx)
	{
		return getUpdateInterval_InternalDelegateField(idx);
	}

	public static void setUpdateInterval_Internal(int idx, float interval)
	{
		setUpdateInterval_InternalDelegateField(idx, interval);
	}

	public unsafe static void rotationRate_Internal_Injected(int idx, out Vector3 ret)
	{
		rotationRate_Internal_InjectedDelegateField(idx, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret)
	{
		rotationRateUnbiased_Internal_InjectedDelegateField(idx, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void gravity_Internal_Injected(int idx, out Vector3 ret)
	{
		gravity_Internal_InjectedDelegateField(idx, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void userAcceleration_Internal_Injected(int idx, out Vector3 ret)
	{
		userAcceleration_Internal_InjectedDelegateField(idx, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void attitude_Internal_Injected(int idx, out Quaternion ret)
	{
		attitude_Internal_InjectedDelegateField(idx, (nint)Unsafe.AsPointer(ref ret));
	}
}
