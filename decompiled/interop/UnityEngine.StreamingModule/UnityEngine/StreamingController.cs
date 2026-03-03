using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class StreamingController : Behaviour
{
	private delegate float get_streamingMipmapBias_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_streamingMipmapBias_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void SetPreloading_InjectedDelegate(System.IntPtr _unity_self, float timeoutSeconds, bool activateCameraOnTimeout, System.IntPtr disableCameraCuttingFrom);

	private delegate void CancelPreloading_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsPreloading_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly get_streamingMipmapBias_InjectedDelegate get_streamingMipmapBias_InjectedDelegateField = IL2CPP.ResolveICall<get_streamingMipmapBias_InjectedDelegate>("UnityEngine.StreamingController::get_streamingMipmapBias_Injected");

	private static readonly set_streamingMipmapBias_InjectedDelegate set_streamingMipmapBias_InjectedDelegateField = IL2CPP.ResolveICall<set_streamingMipmapBias_InjectedDelegate>("UnityEngine.StreamingController::set_streamingMipmapBias_Injected");

	private static readonly SetPreloading_InjectedDelegate SetPreloading_InjectedDelegateField = IL2CPP.ResolveICall<SetPreloading_InjectedDelegate>("UnityEngine.StreamingController::SetPreloading_Injected");

	private static readonly CancelPreloading_InjectedDelegate CancelPreloading_InjectedDelegateField = IL2CPP.ResolveICall<CancelPreloading_InjectedDelegate>("UnityEngine.StreamingController::CancelPreloading_Injected");

	private static readonly IsPreloading_InjectedDelegate IsPreloading_InjectedDelegateField = IL2CPP.ResolveICall<IsPreloading_InjectedDelegate>("UnityEngine.StreamingController::IsPreloading_Injected");

	public float streamingMipmapBias
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_streamingMipmapBias_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_streamingMipmapBias_Injected(intPtr, value);
		}
	}

	public void SetPreloading([Optional] float timeoutSeconds, [Optional] bool activateCameraOnTimeout, [Optional] Camera disableCameraCuttingFrom)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetPreloading_Injected(intPtr, timeoutSeconds, activateCameraOnTimeout, MarshalledUnityObject.Marshal(disableCameraCuttingFrom));
	}

	public void CancelPreloading()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		CancelPreloading_Injected(intPtr);
	}

	public bool IsPreloading()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsPreloading_Injected(intPtr);
	}

	public static float get_streamingMipmapBias_Injected(System.IntPtr _unity_self)
	{
		return get_streamingMipmapBias_InjectedDelegateField(_unity_self);
	}

	public static void set_streamingMipmapBias_Injected(System.IntPtr _unity_self, float value)
	{
		set_streamingMipmapBias_InjectedDelegateField(_unity_self, value);
	}

	public static void SetPreloading_Injected(System.IntPtr _unity_self, float timeoutSeconds, bool activateCameraOnTimeout, System.IntPtr disableCameraCuttingFrom)
	{
		SetPreloading_InjectedDelegateField(_unity_self, timeoutSeconds, activateCameraOnTimeout, disableCameraCuttingFrom);
	}

	public static void CancelPreloading_Injected(System.IntPtr _unity_self)
	{
		CancelPreloading_InjectedDelegateField(_unity_self);
	}

	public static bool IsPreloading_Injected(System.IntPtr _unity_self)
	{
		return IsPreloading_InjectedDelegateField(_unity_self);
	}
}
