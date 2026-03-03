using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioHighPassFilter : Behaviour
{
	private delegate float get_cutoffFrequency_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_cutoffFrequency_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_highpassResonanceQ_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_highpassResonanceQ_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_cutoffFrequency_InjectedDelegate get_cutoffFrequency_InjectedDelegateField = IL2CPP.ResolveICall<get_cutoffFrequency_InjectedDelegate>("UnityEngine.AudioHighPassFilter::get_cutoffFrequency_Injected");

	private static readonly set_cutoffFrequency_InjectedDelegate set_cutoffFrequency_InjectedDelegateField = IL2CPP.ResolveICall<set_cutoffFrequency_InjectedDelegate>("UnityEngine.AudioHighPassFilter::set_cutoffFrequency_Injected");

	private static readonly get_highpassResonanceQ_InjectedDelegate get_highpassResonanceQ_InjectedDelegateField = IL2CPP.ResolveICall<get_highpassResonanceQ_InjectedDelegate>("UnityEngine.AudioHighPassFilter::get_highpassResonanceQ_Injected");

	private static readonly set_highpassResonanceQ_InjectedDelegate set_highpassResonanceQ_InjectedDelegateField = IL2CPP.ResolveICall<set_highpassResonanceQ_InjectedDelegate>("UnityEngine.AudioHighPassFilter::set_highpassResonanceQ_Injected");

	public float cutoffFrequency
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cutoffFrequency_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cutoffFrequency_Injected(intPtr, value);
		}
	}

	public float highpassResonanceQ
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_highpassResonanceQ_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_highpassResonanceQ_Injected(intPtr, value);
		}
	}

	public static float get_cutoffFrequency_Injected(IntPtr _unity_self)
	{
		return get_cutoffFrequency_InjectedDelegateField(_unity_self);
	}

	public static void set_cutoffFrequency_Injected(IntPtr _unity_self, float value)
	{
		set_cutoffFrequency_InjectedDelegateField(_unity_self, value);
	}

	public static float get_highpassResonanceQ_Injected(IntPtr _unity_self)
	{
		return get_highpassResonanceQ_InjectedDelegateField(_unity_self);
	}

	public static void set_highpassResonanceQ_Injected(IntPtr _unity_self, float value)
	{
		set_highpassResonanceQ_InjectedDelegateField(_unity_self, value);
	}
}
