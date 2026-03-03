using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class WindZone : Component
{
	private delegate WindZoneMode get_mode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mode_InjectedDelegate(System.IntPtr _unity_self, WindZoneMode value);

	private delegate float get_radius_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_windMain_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_windMain_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_windTurbulence_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_windTurbulence_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_windPulseMagnitude_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_windPulseMagnitude_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_windPulseFrequency_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_windPulseFrequency_InjectedDelegate(System.IntPtr _unity_self, float value);

	private static readonly get_mode_InjectedDelegate get_mode_InjectedDelegateField = IL2CPP.ResolveICall<get_mode_InjectedDelegate>("UnityEngine.WindZone::get_mode_Injected");

	private static readonly set_mode_InjectedDelegate set_mode_InjectedDelegateField = IL2CPP.ResolveICall<set_mode_InjectedDelegate>("UnityEngine.WindZone::set_mode_Injected");

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.WindZone::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.WindZone::set_radius_Injected");

	private static readonly get_windMain_InjectedDelegate get_windMain_InjectedDelegateField = IL2CPP.ResolveICall<get_windMain_InjectedDelegate>("UnityEngine.WindZone::get_windMain_Injected");

	private static readonly set_windMain_InjectedDelegate set_windMain_InjectedDelegateField = IL2CPP.ResolveICall<set_windMain_InjectedDelegate>("UnityEngine.WindZone::set_windMain_Injected");

	private static readonly get_windTurbulence_InjectedDelegate get_windTurbulence_InjectedDelegateField = IL2CPP.ResolveICall<get_windTurbulence_InjectedDelegate>("UnityEngine.WindZone::get_windTurbulence_Injected");

	private static readonly set_windTurbulence_InjectedDelegate set_windTurbulence_InjectedDelegateField = IL2CPP.ResolveICall<set_windTurbulence_InjectedDelegate>("UnityEngine.WindZone::set_windTurbulence_Injected");

	private static readonly get_windPulseMagnitude_InjectedDelegate get_windPulseMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<get_windPulseMagnitude_InjectedDelegate>("UnityEngine.WindZone::get_windPulseMagnitude_Injected");

	private static readonly set_windPulseMagnitude_InjectedDelegate set_windPulseMagnitude_InjectedDelegateField = IL2CPP.ResolveICall<set_windPulseMagnitude_InjectedDelegate>("UnityEngine.WindZone::set_windPulseMagnitude_Injected");

	private static readonly get_windPulseFrequency_InjectedDelegate get_windPulseFrequency_InjectedDelegateField = IL2CPP.ResolveICall<get_windPulseFrequency_InjectedDelegate>("UnityEngine.WindZone::get_windPulseFrequency_Injected");

	private static readonly set_windPulseFrequency_InjectedDelegate set_windPulseFrequency_InjectedDelegateField = IL2CPP.ResolveICall<set_windPulseFrequency_InjectedDelegate>("UnityEngine.WindZone::set_windPulseFrequency_Injected");

	public WindZoneMode mode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mode_Injected(intPtr, value);
		}
	}

	public float radius
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public float windMain
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_windMain_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_windMain_Injected(intPtr, value);
		}
	}

	public float windTurbulence
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_windTurbulence_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_windTurbulence_Injected(intPtr, value);
		}
	}

	public float windPulseMagnitude
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_windPulseMagnitude_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_windPulseMagnitude_Injected(intPtr, value);
		}
	}

	public float windPulseFrequency
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_windPulseFrequency_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_windPulseFrequency_Injected(intPtr, value);
		}
	}

	public static WindZoneMode get_mode_Injected(System.IntPtr _unity_self)
	{
		return get_mode_InjectedDelegateField(_unity_self);
	}

	public static void set_mode_Injected(System.IntPtr _unity_self, WindZoneMode value)
	{
		set_mode_InjectedDelegateField(_unity_self, value);
	}

	public static float get_radius_Injected(System.IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(System.IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_windMain_Injected(System.IntPtr _unity_self)
	{
		return get_windMain_InjectedDelegateField(_unity_self);
	}

	public static void set_windMain_Injected(System.IntPtr _unity_self, float value)
	{
		set_windMain_InjectedDelegateField(_unity_self, value);
	}

	public static float get_windTurbulence_Injected(System.IntPtr _unity_self)
	{
		return get_windTurbulence_InjectedDelegateField(_unity_self);
	}

	public static void set_windTurbulence_Injected(System.IntPtr _unity_self, float value)
	{
		set_windTurbulence_InjectedDelegateField(_unity_self, value);
	}

	public static float get_windPulseMagnitude_Injected(System.IntPtr _unity_self)
	{
		return get_windPulseMagnitude_InjectedDelegateField(_unity_self);
	}

	public static void set_windPulseMagnitude_Injected(System.IntPtr _unity_self, float value)
	{
		set_windPulseMagnitude_InjectedDelegateField(_unity_self, value);
	}

	public static float get_windPulseFrequency_Injected(System.IntPtr _unity_self)
	{
		return get_windPulseFrequency_InjectedDelegateField(_unity_self);
	}

	public static void set_windPulseFrequency_Injected(System.IntPtr _unity_self, float value)
	{
		set_windPulseFrequency_InjectedDelegateField(_unity_self, value);
	}
}
