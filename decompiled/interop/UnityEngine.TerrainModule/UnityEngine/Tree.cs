using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Tree : Component
{
	private delegate IntPtr get_data_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_data_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate bool get_hasSpeedTreeWind_InjectedDelegate(IntPtr _unity_self);

	private delegate IntPtr get_windAsset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_windAsset_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly get_data_InjectedDelegate get_data_InjectedDelegateField = IL2CPP.ResolveICall<get_data_InjectedDelegate>("UnityEngine.Tree::get_data_Injected");

	private static readonly set_data_InjectedDelegate set_data_InjectedDelegateField = IL2CPP.ResolveICall<set_data_InjectedDelegate>("UnityEngine.Tree::set_data_Injected");

	private static readonly get_hasSpeedTreeWind_InjectedDelegate get_hasSpeedTreeWind_InjectedDelegateField = IL2CPP.ResolveICall<get_hasSpeedTreeWind_InjectedDelegate>("UnityEngine.Tree::get_hasSpeedTreeWind_Injected");

	private static readonly get_windAsset_InjectedDelegate get_windAsset_InjectedDelegateField = IL2CPP.ResolveICall<get_windAsset_InjectedDelegate>("UnityEngine.Tree::get_windAsset_Injected");

	private static readonly set_windAsset_InjectedDelegate set_windAsset_InjectedDelegateField = IL2CPP.ResolveICall<set_windAsset_InjectedDelegate>("UnityEngine.Tree::set_windAsset_Injected");

	public ScriptableObject data
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<ScriptableObject>(get_data_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_data_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public bool hasSpeedTreeWind
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasSpeedTreeWind_Injected(intPtr);
		}
	}

	public SpeedTreeWindAsset windAsset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<SpeedTreeWindAsset>(get_windAsset_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_windAsset_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public static IntPtr get_data_Injected(IntPtr _unity_self)
	{
		return get_data_InjectedDelegateField(_unity_self);
	}

	public static void set_data_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_data_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_hasSpeedTreeWind_Injected(IntPtr _unity_self)
	{
		return get_hasSpeedTreeWind_InjectedDelegateField(_unity_self);
	}

	public static IntPtr get_windAsset_Injected(IntPtr _unity_self)
	{
		return get_windAsset_InjectedDelegateField(_unity_self);
	}

	public static void set_windAsset_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_windAsset_InjectedDelegateField(_unity_self, value);
	}
}
