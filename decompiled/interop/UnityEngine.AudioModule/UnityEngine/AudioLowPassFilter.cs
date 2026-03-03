using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioLowPassFilter : Behaviour
{
	private delegate IntPtr GetCustomLowpassLevelCurveCopy_InjectedDelegate(IntPtr _unity_self);

	private delegate void SetCustomLowpassLevelCurveHelper_InjectedDelegate(IntPtr source, IntPtr curve);

	private delegate float get_cutoffFrequency_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_cutoffFrequency_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_lowpassResonanceQ_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_lowpassResonanceQ_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly GetCustomLowpassLevelCurveCopy_InjectedDelegate GetCustomLowpassLevelCurveCopy_InjectedDelegateField = IL2CPP.ResolveICall<GetCustomLowpassLevelCurveCopy_InjectedDelegate>("UnityEngine.AudioLowPassFilter::GetCustomLowpassLevelCurveCopy_Injected");

	private static readonly SetCustomLowpassLevelCurveHelper_InjectedDelegate SetCustomLowpassLevelCurveHelper_InjectedDelegateField = IL2CPP.ResolveICall<SetCustomLowpassLevelCurveHelper_InjectedDelegate>("UnityEngine.AudioLowPassFilter::SetCustomLowpassLevelCurveHelper_Injected");

	private static readonly get_cutoffFrequency_InjectedDelegate get_cutoffFrequency_InjectedDelegateField = IL2CPP.ResolveICall<get_cutoffFrequency_InjectedDelegate>("UnityEngine.AudioLowPassFilter::get_cutoffFrequency_Injected");

	private static readonly set_cutoffFrequency_InjectedDelegate set_cutoffFrequency_InjectedDelegateField = IL2CPP.ResolveICall<set_cutoffFrequency_InjectedDelegate>("UnityEngine.AudioLowPassFilter::set_cutoffFrequency_Injected");

	private static readonly get_lowpassResonanceQ_InjectedDelegate get_lowpassResonanceQ_InjectedDelegateField = IL2CPP.ResolveICall<get_lowpassResonanceQ_InjectedDelegate>("UnityEngine.AudioLowPassFilter::get_lowpassResonanceQ_Injected");

	private static readonly set_lowpassResonanceQ_InjectedDelegate set_lowpassResonanceQ_InjectedDelegateField = IL2CPP.ResolveICall<set_lowpassResonanceQ_InjectedDelegate>("UnityEngine.AudioLowPassFilter::set_lowpassResonanceQ_Injected");

	public AnimationCurve customCutoffCurve
	{
		get
		{
			return GetCustomLowpassLevelCurveCopy();
		}
		set
		{
			SetCustomLowpassLevelCurveHelper(this, value);
		}
	}

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

	public float lowpassResonanceQ
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lowpassResonanceQ_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lowpassResonanceQ_Injected(intPtr, value);
		}
	}

	public AnimationCurve GetCustomLowpassLevelCurveCopy()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		IntPtr customLowpassLevelCurveCopy_Injected = GetCustomLowpassLevelCurveCopy_Injected(intPtr);
		return (customLowpassLevelCurveCopy_Injected == (IntPtr)0) ? null : AnimationCurve.BindingsMarshaller.ConvertToManaged(customLowpassLevelCurveCopy_Injected);
	}

	public static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve)
	{
		if ((object)source == null)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(source);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowArgumentNullException(source, "source");
		}
		SetCustomLowpassLevelCurveHelper_Injected(intPtr, (curve == null) ? ((IntPtr)0) : AnimationCurve.BindingsMarshaller.ConvertToNative(curve));
	}

	public static IntPtr GetCustomLowpassLevelCurveCopy_Injected(IntPtr _unity_self)
	{
		return GetCustomLowpassLevelCurveCopy_InjectedDelegateField(_unity_self);
	}

	public static void SetCustomLowpassLevelCurveHelper_Injected(IntPtr source, IntPtr curve)
	{
		SetCustomLowpassLevelCurveHelper_InjectedDelegateField(source, curve);
	}

	public static float get_cutoffFrequency_Injected(IntPtr _unity_self)
	{
		return get_cutoffFrequency_InjectedDelegateField(_unity_self);
	}

	public static void set_cutoffFrequency_Injected(IntPtr _unity_self, float value)
	{
		set_cutoffFrequency_InjectedDelegateField(_unity_self, value);
	}

	public static float get_lowpassResonanceQ_Injected(IntPtr _unity_self)
	{
		return get_lowpassResonanceQ_InjectedDelegateField(_unity_self);
	}

	public static void set_lowpassResonanceQ_Injected(IntPtr _unity_self, float value)
	{
		set_lowpassResonanceQ_InjectedDelegateField(_unity_self, value);
	}
}
