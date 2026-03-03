using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioEchoFilter : Behaviour
{
	private delegate float get_delay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_delay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_decayRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_decayRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_dryMix_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dryMix_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_wetMix_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_wetMix_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_delay_InjectedDelegate get_delay_InjectedDelegateField = IL2CPP.ResolveICall<get_delay_InjectedDelegate>("UnityEngine.AudioEchoFilter::get_delay_Injected");

	private static readonly set_delay_InjectedDelegate set_delay_InjectedDelegateField = IL2CPP.ResolveICall<set_delay_InjectedDelegate>("UnityEngine.AudioEchoFilter::set_delay_Injected");

	private static readonly get_decayRatio_InjectedDelegate get_decayRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_decayRatio_InjectedDelegate>("UnityEngine.AudioEchoFilter::get_decayRatio_Injected");

	private static readonly set_decayRatio_InjectedDelegate set_decayRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_decayRatio_InjectedDelegate>("UnityEngine.AudioEchoFilter::set_decayRatio_Injected");

	private static readonly get_dryMix_InjectedDelegate get_dryMix_InjectedDelegateField = IL2CPP.ResolveICall<get_dryMix_InjectedDelegate>("UnityEngine.AudioEchoFilter::get_dryMix_Injected");

	private static readonly set_dryMix_InjectedDelegate set_dryMix_InjectedDelegateField = IL2CPP.ResolveICall<set_dryMix_InjectedDelegate>("UnityEngine.AudioEchoFilter::set_dryMix_Injected");

	private static readonly get_wetMix_InjectedDelegate get_wetMix_InjectedDelegateField = IL2CPP.ResolveICall<get_wetMix_InjectedDelegate>("UnityEngine.AudioEchoFilter::get_wetMix_Injected");

	private static readonly set_wetMix_InjectedDelegate set_wetMix_InjectedDelegateField = IL2CPP.ResolveICall<set_wetMix_InjectedDelegate>("UnityEngine.AudioEchoFilter::set_wetMix_Injected");

	public float delay
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_delay_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_delay_Injected(intPtr, value);
		}
	}

	public float decayRatio
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_decayRatio_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_decayRatio_Injected(intPtr, value);
		}
	}

	public float dryMix
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dryMix_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_dryMix_Injected(intPtr, value);
		}
	}

	public float wetMix
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wetMix_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wetMix_Injected(intPtr, value);
		}
	}

	public static float get_delay_Injected(IntPtr _unity_self)
	{
		return get_delay_InjectedDelegateField(_unity_self);
	}

	public static void set_delay_Injected(IntPtr _unity_self, float value)
	{
		set_delay_InjectedDelegateField(_unity_self, value);
	}

	public static float get_decayRatio_Injected(IntPtr _unity_self)
	{
		return get_decayRatio_InjectedDelegateField(_unity_self);
	}

	public static void set_decayRatio_Injected(IntPtr _unity_self, float value)
	{
		set_decayRatio_InjectedDelegateField(_unity_self, value);
	}

	public static float get_dryMix_Injected(IntPtr _unity_self)
	{
		return get_dryMix_InjectedDelegateField(_unity_self);
	}

	public static void set_dryMix_Injected(IntPtr _unity_self, float value)
	{
		set_dryMix_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wetMix_Injected(IntPtr _unity_self)
	{
		return get_wetMix_InjectedDelegateField(_unity_self);
	}

	public static void set_wetMix_Injected(IntPtr _unity_self, float value)
	{
		set_wetMix_InjectedDelegateField(_unity_self, value);
	}
}
