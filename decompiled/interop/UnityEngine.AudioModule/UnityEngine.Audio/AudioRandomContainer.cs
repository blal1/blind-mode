using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Audio;

public sealed class AudioRandomContainer : AudioResource
{
	public enum ChangeEventType
	{
		Volume,
		Pitch,
		List
	}

	private delegate void Internal_CreateDelegate(IntPtr self);

	private delegate float get_volume_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_volume_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_volumeRandomizationRange_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_volumeRandomizationRange_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_volumeRandomizationEnabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_volumeRandomizationEnabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_pitch_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_pitch_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_pitchRandomizationRange_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_pitchRandomizationRange_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_pitchRandomizationEnabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_pitchRandomizationEnabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate IntPtr get_elements_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_elements_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate AudioRandomContainerTriggerMode get_triggerMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_triggerMode_InjectedDelegate(IntPtr _unity_self, AudioRandomContainerTriggerMode value);

	private delegate AudioRandomContainerPlaybackMode get_playbackMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_playbackMode_InjectedDelegate(IntPtr _unity_self, AudioRandomContainerPlaybackMode value);

	private delegate int get_avoidRepeatingLast_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_avoidRepeatingLast_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate AudioRandomContainerAutomaticTriggerMode get_automaticTriggerMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_automaticTriggerMode_InjectedDelegate(IntPtr _unity_self, AudioRandomContainerAutomaticTriggerMode value);

	private delegate float get_automaticTriggerTime_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_automaticTriggerTime_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_automaticTriggerTimeRandomizationRange_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_automaticTriggerTimeRandomizationRange_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_automaticTriggerTimeRandomizationEnabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_automaticTriggerTimeRandomizationEnabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate AudioRandomContainerLoopMode get_loopMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_loopMode_InjectedDelegate(IntPtr _unity_self, AudioRandomContainerLoopMode value);

	private delegate int get_loopCount_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_loopCount_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate void get_loopCountRandomizationRange_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_loopCountRandomizationRange_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_loopCountRandomizationEnabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_loopCountRandomizationEnabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void NotifyObservers_InjectedDelegate(IntPtr _unity_self, ChangeEventType eventType);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.Audio.AudioRandomContainer::Internal_Create");

	private static readonly get_volume_InjectedDelegate get_volume_InjectedDelegateField = IL2CPP.ResolveICall<get_volume_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_volume_Injected");

	private static readonly set_volume_InjectedDelegate set_volume_InjectedDelegateField = IL2CPP.ResolveICall<set_volume_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_volume_Injected");

	private static readonly get_volumeRandomizationRange_InjectedDelegate get_volumeRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<get_volumeRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_volumeRandomizationRange_Injected");

	private static readonly set_volumeRandomizationRange_InjectedDelegate set_volumeRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<set_volumeRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_volumeRandomizationRange_Injected");

	private static readonly get_volumeRandomizationEnabled_InjectedDelegate get_volumeRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<get_volumeRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_volumeRandomizationEnabled_Injected");

	private static readonly set_volumeRandomizationEnabled_InjectedDelegate set_volumeRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<set_volumeRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_volumeRandomizationEnabled_Injected");

	private static readonly get_pitch_InjectedDelegate get_pitch_InjectedDelegateField = IL2CPP.ResolveICall<get_pitch_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_pitch_Injected");

	private static readonly set_pitch_InjectedDelegate set_pitch_InjectedDelegateField = IL2CPP.ResolveICall<set_pitch_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_pitch_Injected");

	private static readonly get_pitchRandomizationRange_InjectedDelegate get_pitchRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<get_pitchRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_pitchRandomizationRange_Injected");

	private static readonly set_pitchRandomizationRange_InjectedDelegate set_pitchRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<set_pitchRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_pitchRandomizationRange_Injected");

	private static readonly get_pitchRandomizationEnabled_InjectedDelegate get_pitchRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<get_pitchRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_pitchRandomizationEnabled_Injected");

	private static readonly set_pitchRandomizationEnabled_InjectedDelegate set_pitchRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<set_pitchRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_pitchRandomizationEnabled_Injected");

	private static readonly get_elements_InjectedDelegate get_elements_InjectedDelegateField = IL2CPP.ResolveICall<get_elements_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_elements_Injected");

	private static readonly set_elements_InjectedDelegate set_elements_InjectedDelegateField = IL2CPP.ResolveICall<set_elements_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_elements_Injected");

	private static readonly get_triggerMode_InjectedDelegate get_triggerMode_InjectedDelegateField = IL2CPP.ResolveICall<get_triggerMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_triggerMode_Injected");

	private static readonly set_triggerMode_InjectedDelegate set_triggerMode_InjectedDelegateField = IL2CPP.ResolveICall<set_triggerMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_triggerMode_Injected");

	private static readonly get_playbackMode_InjectedDelegate get_playbackMode_InjectedDelegateField = IL2CPP.ResolveICall<get_playbackMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_playbackMode_Injected");

	private static readonly set_playbackMode_InjectedDelegate set_playbackMode_InjectedDelegateField = IL2CPP.ResolveICall<set_playbackMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_playbackMode_Injected");

	private static readonly get_avoidRepeatingLast_InjectedDelegate get_avoidRepeatingLast_InjectedDelegateField = IL2CPP.ResolveICall<get_avoidRepeatingLast_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_avoidRepeatingLast_Injected");

	private static readonly set_avoidRepeatingLast_InjectedDelegate set_avoidRepeatingLast_InjectedDelegateField = IL2CPP.ResolveICall<set_avoidRepeatingLast_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_avoidRepeatingLast_Injected");

	private static readonly get_automaticTriggerMode_InjectedDelegate get_automaticTriggerMode_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticTriggerMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_automaticTriggerMode_Injected");

	private static readonly set_automaticTriggerMode_InjectedDelegate set_automaticTriggerMode_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticTriggerMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_automaticTriggerMode_Injected");

	private static readonly get_automaticTriggerTime_InjectedDelegate get_automaticTriggerTime_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticTriggerTime_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_automaticTriggerTime_Injected");

	private static readonly set_automaticTriggerTime_InjectedDelegate set_automaticTriggerTime_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticTriggerTime_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_automaticTriggerTime_Injected");

	private static readonly get_automaticTriggerTimeRandomizationRange_InjectedDelegate get_automaticTriggerTimeRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticTriggerTimeRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_automaticTriggerTimeRandomizationRange_Injected");

	private static readonly set_automaticTriggerTimeRandomizationRange_InjectedDelegate set_automaticTriggerTimeRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticTriggerTimeRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_automaticTriggerTimeRandomizationRange_Injected");

	private static readonly get_automaticTriggerTimeRandomizationEnabled_InjectedDelegate get_automaticTriggerTimeRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticTriggerTimeRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_automaticTriggerTimeRandomizationEnabled_Injected");

	private static readonly set_automaticTriggerTimeRandomizationEnabled_InjectedDelegate set_automaticTriggerTimeRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticTriggerTimeRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_automaticTriggerTimeRandomizationEnabled_Injected");

	private static readonly get_loopMode_InjectedDelegate get_loopMode_InjectedDelegateField = IL2CPP.ResolveICall<get_loopMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_loopMode_Injected");

	private static readonly set_loopMode_InjectedDelegate set_loopMode_InjectedDelegateField = IL2CPP.ResolveICall<set_loopMode_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_loopMode_Injected");

	private static readonly get_loopCount_InjectedDelegate get_loopCount_InjectedDelegateField = IL2CPP.ResolveICall<get_loopCount_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_loopCount_Injected");

	private static readonly set_loopCount_InjectedDelegate set_loopCount_InjectedDelegateField = IL2CPP.ResolveICall<set_loopCount_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_loopCount_Injected");

	private static readonly get_loopCountRandomizationRange_InjectedDelegate get_loopCountRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<get_loopCountRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_loopCountRandomizationRange_Injected");

	private static readonly set_loopCountRandomizationRange_InjectedDelegate set_loopCountRandomizationRange_InjectedDelegateField = IL2CPP.ResolveICall<set_loopCountRandomizationRange_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_loopCountRandomizationRange_Injected");

	private static readonly get_loopCountRandomizationEnabled_InjectedDelegate get_loopCountRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<get_loopCountRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::get_loopCountRandomizationEnabled_Injected");

	private static readonly set_loopCountRandomizationEnabled_InjectedDelegate set_loopCountRandomizationEnabled_InjectedDelegateField = IL2CPP.ResolveICall<set_loopCountRandomizationEnabled_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::set_loopCountRandomizationEnabled_Injected");

	private static readonly NotifyObservers_InjectedDelegate NotifyObservers_InjectedDelegateField = IL2CPP.ResolveICall<NotifyObservers_InjectedDelegate>("UnityEngine.Audio.AudioRandomContainer::NotifyObservers_Injected");

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

	public Vector2 volumeRandomizationRange
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_volumeRandomizationRange_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_volumeRandomizationRange_Injected(intPtr, ref value);
		}
	}

	public bool volumeRandomizationEnabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_volumeRandomizationEnabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_volumeRandomizationEnabled_Injected(intPtr, value);
		}
	}

	public float pitch
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pitch_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pitch_Injected(intPtr, value);
		}
	}

	public Vector2 pitchRandomizationRange
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_pitchRandomizationRange_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pitchRandomizationRange_Injected(intPtr, ref value);
		}
	}

	public bool pitchRandomizationEnabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pitchRandomizationEnabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_pitchRandomizationEnabled_Injected(intPtr, value);
		}
	}

	public Il2CppReferenceArray<AudioContainerElement> elements
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_elements_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_elements_Injected(intPtr, value);
		}
	}

	public AudioRandomContainerTriggerMode triggerMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_triggerMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_triggerMode_Injected(intPtr, value);
		}
	}

	public AudioRandomContainerPlaybackMode playbackMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_playbackMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_playbackMode_Injected(intPtr, value);
		}
	}

	public int avoidRepeatingLast
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_avoidRepeatingLast_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_avoidRepeatingLast_Injected(intPtr, value);
		}
	}

	public AudioRandomContainerAutomaticTriggerMode automaticTriggerMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticTriggerMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticTriggerMode_Injected(intPtr, value);
		}
	}

	public float automaticTriggerTime
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticTriggerTime_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticTriggerTime_Injected(intPtr, value);
		}
	}

	public Vector2 automaticTriggerTimeRandomizationRange
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_automaticTriggerTimeRandomizationRange_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticTriggerTimeRandomizationRange_Injected(intPtr, ref value);
		}
	}

	public bool automaticTriggerTimeRandomizationEnabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticTriggerTimeRandomizationEnabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticTriggerTimeRandomizationEnabled_Injected(intPtr, value);
		}
	}

	public AudioRandomContainerLoopMode loopMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopMode_Injected(intPtr, value);
		}
	}

	public int loopCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopCount_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopCount_Injected(intPtr, value);
		}
	}

	public Vector2 loopCountRandomizationRange
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_loopCountRandomizationRange_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopCountRandomizationRange_Injected(intPtr, ref value);
		}
	}

	public bool loopCountRandomizationEnabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopCountRandomizationEnabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopCountRandomizationEnabled_Injected(intPtr, value);
		}
	}

	public void NotifyObservers(ChangeEventType eventType)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		NotifyObservers_Injected(intPtr, eventType);
	}

	public static void Internal_Create(AudioRandomContainer self)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self));
	}

	public static float get_volume_Injected(IntPtr _unity_self)
	{
		return get_volume_InjectedDelegateField(_unity_self);
	}

	public static void set_volume_Injected(IntPtr _unity_self, float value)
	{
		set_volume_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_volumeRandomizationRange_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_volumeRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_volumeRandomizationRange_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_volumeRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_volumeRandomizationEnabled_Injected(IntPtr _unity_self)
	{
		return get_volumeRandomizationEnabled_InjectedDelegateField(_unity_self);
	}

	public static void set_volumeRandomizationEnabled_Injected(IntPtr _unity_self, bool value)
	{
		set_volumeRandomizationEnabled_InjectedDelegateField(_unity_self, value);
	}

	public static float get_pitch_Injected(IntPtr _unity_self)
	{
		return get_pitch_InjectedDelegateField(_unity_self);
	}

	public static void set_pitch_Injected(IntPtr _unity_self, float value)
	{
		set_pitch_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_pitchRandomizationRange_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_pitchRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_pitchRandomizationRange_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_pitchRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_pitchRandomizationEnabled_Injected(IntPtr _unity_self)
	{
		return get_pitchRandomizationEnabled_InjectedDelegateField(_unity_self);
	}

	public static void set_pitchRandomizationEnabled_Injected(IntPtr _unity_self, bool value)
	{
		set_pitchRandomizationEnabled_InjectedDelegateField(_unity_self, value);
	}

	public static Il2CppReferenceArray<AudioContainerElement> get_elements_Injected(IntPtr _unity_self)
	{
		IntPtr intPtr = get_elements_InjectedDelegateField(_unity_self);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioContainerElement>>(intPtr) : null;
	}

	public static void set_elements_Injected(IntPtr _unity_self, Il2CppReferenceArray<AudioContainerElement> value)
	{
		set_elements_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static AudioRandomContainerTriggerMode get_triggerMode_Injected(IntPtr _unity_self)
	{
		return get_triggerMode_InjectedDelegateField(_unity_self);
	}

	public static void set_triggerMode_Injected(IntPtr _unity_self, AudioRandomContainerTriggerMode value)
	{
		set_triggerMode_InjectedDelegateField(_unity_self, value);
	}

	public static AudioRandomContainerPlaybackMode get_playbackMode_Injected(IntPtr _unity_self)
	{
		return get_playbackMode_InjectedDelegateField(_unity_self);
	}

	public static void set_playbackMode_Injected(IntPtr _unity_self, AudioRandomContainerPlaybackMode value)
	{
		set_playbackMode_InjectedDelegateField(_unity_self, value);
	}

	public static int get_avoidRepeatingLast_Injected(IntPtr _unity_self)
	{
		return get_avoidRepeatingLast_InjectedDelegateField(_unity_self);
	}

	public static void set_avoidRepeatingLast_Injected(IntPtr _unity_self, int value)
	{
		set_avoidRepeatingLast_InjectedDelegateField(_unity_self, value);
	}

	public static AudioRandomContainerAutomaticTriggerMode get_automaticTriggerMode_Injected(IntPtr _unity_self)
	{
		return get_automaticTriggerMode_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticTriggerMode_Injected(IntPtr _unity_self, AudioRandomContainerAutomaticTriggerMode value)
	{
		set_automaticTriggerMode_InjectedDelegateField(_unity_self, value);
	}

	public static float get_automaticTriggerTime_Injected(IntPtr _unity_self)
	{
		return get_automaticTriggerTime_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticTriggerTime_Injected(IntPtr _unity_self, float value)
	{
		set_automaticTriggerTime_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_automaticTriggerTimeRandomizationRange_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_automaticTriggerTimeRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_automaticTriggerTimeRandomizationRange_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_automaticTriggerTimeRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_automaticTriggerTimeRandomizationEnabled_Injected(IntPtr _unity_self)
	{
		return get_automaticTriggerTimeRandomizationEnabled_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticTriggerTimeRandomizationEnabled_Injected(IntPtr _unity_self, bool value)
	{
		set_automaticTriggerTimeRandomizationEnabled_InjectedDelegateField(_unity_self, value);
	}

	public static AudioRandomContainerLoopMode get_loopMode_Injected(IntPtr _unity_self)
	{
		return get_loopMode_InjectedDelegateField(_unity_self);
	}

	public static void set_loopMode_Injected(IntPtr _unity_self, AudioRandomContainerLoopMode value)
	{
		set_loopMode_InjectedDelegateField(_unity_self, value);
	}

	public static int get_loopCount_Injected(IntPtr _unity_self)
	{
		return get_loopCount_InjectedDelegateField(_unity_self);
	}

	public static void set_loopCount_Injected(IntPtr _unity_self, int value)
	{
		set_loopCount_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_loopCountRandomizationRange_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_loopCountRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_loopCountRandomizationRange_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_loopCountRandomizationRange_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_loopCountRandomizationEnabled_Injected(IntPtr _unity_self)
	{
		return get_loopCountRandomizationEnabled_InjectedDelegateField(_unity_self);
	}

	public static void set_loopCountRandomizationEnabled_Injected(IntPtr _unity_self, bool value)
	{
		set_loopCountRandomizationEnabled_InjectedDelegateField(_unity_self, value);
	}

	public static void NotifyObservers_Injected(IntPtr _unity_self, ChangeEventType eventType)
	{
		NotifyObservers_InjectedDelegateField(_unity_self, eventType);
	}
}
