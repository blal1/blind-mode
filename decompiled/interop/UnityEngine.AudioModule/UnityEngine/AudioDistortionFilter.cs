using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioDistortionFilter : Behaviour
{
	private delegate float get_distortionLevel_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_distortionLevel_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_distortionLevel_InjectedDelegate get_distortionLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_distortionLevel_InjectedDelegate>("UnityEngine.AudioDistortionFilter::get_distortionLevel_Injected");

	private static readonly set_distortionLevel_InjectedDelegate set_distortionLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_distortionLevel_InjectedDelegate>("UnityEngine.AudioDistortionFilter::set_distortionLevel_Injected");

	public float distortionLevel
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_distortionLevel_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_distortionLevel_Injected(intPtr, value);
		}
	}

	public static float get_distortionLevel_Injected(IntPtr _unity_self)
	{
		return get_distortionLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_distortionLevel_Injected(IntPtr _unity_self, float value)
	{
		set_distortionLevel_InjectedDelegateField(_unity_self, value);
	}
}
