using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class OcclusionPortal : Component
{
	private delegate bool get_open_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_open_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly get_open_InjectedDelegate get_open_InjectedDelegateField = IL2CPP.ResolveICall<get_open_InjectedDelegate>("UnityEngine.OcclusionPortal::get_open_Injected");

	private static readonly set_open_InjectedDelegate set_open_InjectedDelegateField = IL2CPP.ResolveICall<set_open_InjectedDelegate>("UnityEngine.OcclusionPortal::set_open_Injected");

	public bool open
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_open_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_open_Injected(intPtr, value);
		}
	}

	public static bool get_open_Injected(IntPtr _unity_self)
	{
		return get_open_InjectedDelegateField(_unity_self);
	}

	public static void set_open_Injected(IntPtr _unity_self, bool value)
	{
		set_open_InjectedDelegateField(_unity_self, value);
	}
}
