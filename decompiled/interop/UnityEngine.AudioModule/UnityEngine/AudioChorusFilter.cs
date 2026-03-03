using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioChorusFilter : Behaviour
{
	private delegate float get_dryMix_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dryMix_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_wetMix1_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_wetMix1_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_wetMix2_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_wetMix2_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_wetMix3_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_wetMix3_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_delay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_delay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_rate_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_rate_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_depth_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_depth_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_dryMix_InjectedDelegate get_dryMix_InjectedDelegateField = IL2CPP.ResolveICall<get_dryMix_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_dryMix_Injected");

	private static readonly set_dryMix_InjectedDelegate set_dryMix_InjectedDelegateField = IL2CPP.ResolveICall<set_dryMix_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_dryMix_Injected");

	private static readonly get_wetMix1_InjectedDelegate get_wetMix1_InjectedDelegateField = IL2CPP.ResolveICall<get_wetMix1_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_wetMix1_Injected");

	private static readonly set_wetMix1_InjectedDelegate set_wetMix1_InjectedDelegateField = IL2CPP.ResolveICall<set_wetMix1_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_wetMix1_Injected");

	private static readonly get_wetMix2_InjectedDelegate get_wetMix2_InjectedDelegateField = IL2CPP.ResolveICall<get_wetMix2_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_wetMix2_Injected");

	private static readonly set_wetMix2_InjectedDelegate set_wetMix2_InjectedDelegateField = IL2CPP.ResolveICall<set_wetMix2_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_wetMix2_Injected");

	private static readonly get_wetMix3_InjectedDelegate get_wetMix3_InjectedDelegateField = IL2CPP.ResolveICall<get_wetMix3_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_wetMix3_Injected");

	private static readonly set_wetMix3_InjectedDelegate set_wetMix3_InjectedDelegateField = IL2CPP.ResolveICall<set_wetMix3_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_wetMix3_Injected");

	private static readonly get_delay_InjectedDelegate get_delay_InjectedDelegateField = IL2CPP.ResolveICall<get_delay_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_delay_Injected");

	private static readonly set_delay_InjectedDelegate set_delay_InjectedDelegateField = IL2CPP.ResolveICall<set_delay_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_delay_Injected");

	private static readonly get_rate_InjectedDelegate get_rate_InjectedDelegateField = IL2CPP.ResolveICall<get_rate_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_rate_Injected");

	private static readonly set_rate_InjectedDelegate set_rate_InjectedDelegateField = IL2CPP.ResolveICall<set_rate_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_rate_Injected");

	private static readonly get_depth_InjectedDelegate get_depth_InjectedDelegateField = IL2CPP.ResolveICall<get_depth_InjectedDelegate>("UnityEngine.AudioChorusFilter::get_depth_Injected");

	private static readonly set_depth_InjectedDelegate set_depth_InjectedDelegateField = IL2CPP.ResolveICall<set_depth_InjectedDelegate>("UnityEngine.AudioChorusFilter::set_depth_Injected");

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

	public float wetMix1
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wetMix1_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wetMix1_Injected(intPtr, value);
		}
	}

	public float wetMix2
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wetMix2_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wetMix2_Injected(intPtr, value);
		}
	}

	public float wetMix3
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wetMix3_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wetMix3_Injected(intPtr, value);
		}
	}

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

	public float rate
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rate_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_rate_Injected(intPtr, value);
		}
	}

	public float depth
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_depth_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_depth_Injected(intPtr, value);
		}
	}

	public float feedback
	{
		get
		{
			Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
			return 0f;
		}
		set
		{
			Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
		}
	}

	public static float get_dryMix_Injected(IntPtr _unity_self)
	{
		return get_dryMix_InjectedDelegateField(_unity_self);
	}

	public static void set_dryMix_Injected(IntPtr _unity_self, float value)
	{
		set_dryMix_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wetMix1_Injected(IntPtr _unity_self)
	{
		return get_wetMix1_InjectedDelegateField(_unity_self);
	}

	public static void set_wetMix1_Injected(IntPtr _unity_self, float value)
	{
		set_wetMix1_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wetMix2_Injected(IntPtr _unity_self)
	{
		return get_wetMix2_InjectedDelegateField(_unity_self);
	}

	public static void set_wetMix2_Injected(IntPtr _unity_self, float value)
	{
		set_wetMix2_InjectedDelegateField(_unity_self, value);
	}

	public static float get_wetMix3_Injected(IntPtr _unity_self)
	{
		return get_wetMix3_InjectedDelegateField(_unity_self);
	}

	public static void set_wetMix3_Injected(IntPtr _unity_self, float value)
	{
		set_wetMix3_InjectedDelegateField(_unity_self, value);
	}

	public static float get_delay_Injected(IntPtr _unity_self)
	{
		return get_delay_InjectedDelegateField(_unity_self);
	}

	public static void set_delay_Injected(IntPtr _unity_self, float value)
	{
		set_delay_InjectedDelegateField(_unity_self, value);
	}

	public static float get_rate_Injected(IntPtr _unity_self)
	{
		return get_rate_InjectedDelegateField(_unity_self);
	}

	public static void set_rate_Injected(IntPtr _unity_self, float value)
	{
		set_rate_InjectedDelegateField(_unity_self, value);
	}

	public static float get_depth_Injected(IntPtr _unity_self)
	{
		return get_depth_InjectedDelegateField(_unity_self);
	}

	public static void set_depth_Injected(IntPtr _unity_self, float value)
	{
		set_depth_InjectedDelegateField(_unity_self, value);
	}
}
