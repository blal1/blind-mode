using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.Audio;

public sealed class AudioContainerElement : Object
{
	private delegate void Internal_CreateDelegate(IntPtr self);

	private delegate IntPtr get_audioClip_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_audioClip_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate float get_volume_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_volume_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_enabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.Audio.AudioContainerElement::Internal_Create");

	private static readonly get_audioClip_InjectedDelegate get_audioClip_InjectedDelegateField = IL2CPP.ResolveICall<get_audioClip_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::get_audioClip_Injected");

	private static readonly set_audioClip_InjectedDelegate set_audioClip_InjectedDelegateField = IL2CPP.ResolveICall<set_audioClip_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::set_audioClip_Injected");

	private static readonly get_volume_InjectedDelegate get_volume_InjectedDelegateField = IL2CPP.ResolveICall<get_volume_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::get_volume_Injected");

	private static readonly set_volume_InjectedDelegate set_volume_InjectedDelegateField = IL2CPP.ResolveICall<set_volume_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::set_volume_Injected");

	private static readonly get_enabled_InjectedDelegate get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<get_enabled_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::get_enabled_Injected");

	private static readonly set_enabled_InjectedDelegate set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<set_enabled_InjectedDelegate>("UnityEngine.Audio.AudioContainerElement::set_enabled_Injected");

	public AudioClip audioClip
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AudioClip>(get_audioClip_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_audioClip_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public float volume
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_volume_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_volume_Injected(intPtr, value);
		}
	}

	public bool enabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enabled_Injected(intPtr, value);
		}
	}

	public static void Internal_Create(AudioContainerElement self)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self));
	}

	public static IntPtr get_audioClip_Injected(IntPtr _unity_self)
	{
		return get_audioClip_InjectedDelegateField(_unity_self);
	}

	public static void set_audioClip_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_audioClip_InjectedDelegateField(_unity_self, value);
	}

	public static float get_volume_Injected(IntPtr _unity_self)
	{
		return get_volume_InjectedDelegateField(_unity_self);
	}

	public static void set_volume_Injected(IntPtr _unity_self, float value)
	{
		set_volume_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enabled_Injected(IntPtr _unity_self)
	{
		return get_enabled_InjectedDelegateField(_unity_self);
	}

	public static void set_enabled_Injected(IntPtr _unity_self, bool value)
	{
		set_enabled_InjectedDelegateField(_unity_self, value);
	}
}
