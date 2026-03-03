using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioReverbZone : Behaviour
{
	private delegate float get_minDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_minDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate AudioReverbPreset get_reverbPreset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverbPreset_InjectedDelegate(IntPtr _unity_self, AudioReverbPreset value);

	private delegate int get_room_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_room_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_roomHF_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_roomHF_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_roomLF_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_roomLF_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate float get_decayTime_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_decayTime_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_decayHFRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_decayHFRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_reflections_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reflections_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate float get_reflectionsDelay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reflectionsDelay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_reverb_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverb_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate float get_reverbDelay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverbDelay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_HFReference_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_HFReference_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_LFReference_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_LFReference_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_diffusion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_diffusion_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_density_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_density_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_minDistance_InjectedDelegate get_minDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_minDistance_InjectedDelegate>("UnityEngine.AudioReverbZone::get_minDistance_Injected");

	private static readonly set_minDistance_InjectedDelegate set_minDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_minDistance_InjectedDelegate>("UnityEngine.AudioReverbZone::set_minDistance_Injected");

	private static readonly get_maxDistance_InjectedDelegate get_maxDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDistance_InjectedDelegate>("UnityEngine.AudioReverbZone::get_maxDistance_Injected");

	private static readonly set_maxDistance_InjectedDelegate set_maxDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_maxDistance_InjectedDelegate>("UnityEngine.AudioReverbZone::set_maxDistance_Injected");

	private static readonly get_reverbPreset_InjectedDelegate get_reverbPreset_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbPreset_InjectedDelegate>("UnityEngine.AudioReverbZone::get_reverbPreset_Injected");

	private static readonly set_reverbPreset_InjectedDelegate set_reverbPreset_InjectedDelegateField = IL2CPP.ResolveICall<set_reverbPreset_InjectedDelegate>("UnityEngine.AudioReverbZone::set_reverbPreset_Injected");

	private static readonly get_room_InjectedDelegate get_room_InjectedDelegateField = IL2CPP.ResolveICall<get_room_InjectedDelegate>("UnityEngine.AudioReverbZone::get_room_Injected");

	private static readonly set_room_InjectedDelegate set_room_InjectedDelegateField = IL2CPP.ResolveICall<set_room_InjectedDelegate>("UnityEngine.AudioReverbZone::set_room_Injected");

	private static readonly get_roomHF_InjectedDelegate get_roomHF_InjectedDelegateField = IL2CPP.ResolveICall<get_roomHF_InjectedDelegate>("UnityEngine.AudioReverbZone::get_roomHF_Injected");

	private static readonly set_roomHF_InjectedDelegate set_roomHF_InjectedDelegateField = IL2CPP.ResolveICall<set_roomHF_InjectedDelegate>("UnityEngine.AudioReverbZone::set_roomHF_Injected");

	private static readonly get_roomLF_InjectedDelegate get_roomLF_InjectedDelegateField = IL2CPP.ResolveICall<get_roomLF_InjectedDelegate>("UnityEngine.AudioReverbZone::get_roomLF_Injected");

	private static readonly set_roomLF_InjectedDelegate set_roomLF_InjectedDelegateField = IL2CPP.ResolveICall<set_roomLF_InjectedDelegate>("UnityEngine.AudioReverbZone::set_roomLF_Injected");

	private static readonly get_decayTime_InjectedDelegate get_decayTime_InjectedDelegateField = IL2CPP.ResolveICall<get_decayTime_InjectedDelegate>("UnityEngine.AudioReverbZone::get_decayTime_Injected");

	private static readonly set_decayTime_InjectedDelegate set_decayTime_InjectedDelegateField = IL2CPP.ResolveICall<set_decayTime_InjectedDelegate>("UnityEngine.AudioReverbZone::set_decayTime_Injected");

	private static readonly get_decayHFRatio_InjectedDelegate get_decayHFRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_decayHFRatio_InjectedDelegate>("UnityEngine.AudioReverbZone::get_decayHFRatio_Injected");

	private static readonly set_decayHFRatio_InjectedDelegate set_decayHFRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_decayHFRatio_InjectedDelegate>("UnityEngine.AudioReverbZone::set_decayHFRatio_Injected");

	private static readonly get_reflections_InjectedDelegate get_reflections_InjectedDelegateField = IL2CPP.ResolveICall<get_reflections_InjectedDelegate>("UnityEngine.AudioReverbZone::get_reflections_Injected");

	private static readonly set_reflections_InjectedDelegate set_reflections_InjectedDelegateField = IL2CPP.ResolveICall<set_reflections_InjectedDelegate>("UnityEngine.AudioReverbZone::set_reflections_Injected");

	private static readonly get_reflectionsDelay_InjectedDelegate get_reflectionsDelay_InjectedDelegateField = IL2CPP.ResolveICall<get_reflectionsDelay_InjectedDelegate>("UnityEngine.AudioReverbZone::get_reflectionsDelay_Injected");

	private static readonly set_reflectionsDelay_InjectedDelegate set_reflectionsDelay_InjectedDelegateField = IL2CPP.ResolveICall<set_reflectionsDelay_InjectedDelegate>("UnityEngine.AudioReverbZone::set_reflectionsDelay_Injected");

	private static readonly get_reverb_InjectedDelegate get_reverb_InjectedDelegateField = IL2CPP.ResolveICall<get_reverb_InjectedDelegate>("UnityEngine.AudioReverbZone::get_reverb_Injected");

	private static readonly set_reverb_InjectedDelegate set_reverb_InjectedDelegateField = IL2CPP.ResolveICall<set_reverb_InjectedDelegate>("UnityEngine.AudioReverbZone::set_reverb_Injected");

	private static readonly get_reverbDelay_InjectedDelegate get_reverbDelay_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbDelay_InjectedDelegate>("UnityEngine.AudioReverbZone::get_reverbDelay_Injected");

	private static readonly set_reverbDelay_InjectedDelegate set_reverbDelay_InjectedDelegateField = IL2CPP.ResolveICall<set_reverbDelay_InjectedDelegate>("UnityEngine.AudioReverbZone::set_reverbDelay_Injected");

	private static readonly get_HFReference_InjectedDelegate get_HFReference_InjectedDelegateField = IL2CPP.ResolveICall<get_HFReference_InjectedDelegate>("UnityEngine.AudioReverbZone::get_HFReference_Injected");

	private static readonly set_HFReference_InjectedDelegate set_HFReference_InjectedDelegateField = IL2CPP.ResolveICall<set_HFReference_InjectedDelegate>("UnityEngine.AudioReverbZone::set_HFReference_Injected");

	private static readonly get_LFReference_InjectedDelegate get_LFReference_InjectedDelegateField = IL2CPP.ResolveICall<get_LFReference_InjectedDelegate>("UnityEngine.AudioReverbZone::get_LFReference_Injected");

	private static readonly set_LFReference_InjectedDelegate set_LFReference_InjectedDelegateField = IL2CPP.ResolveICall<set_LFReference_InjectedDelegate>("UnityEngine.AudioReverbZone::set_LFReference_Injected");

	private static readonly get_diffusion_InjectedDelegate get_diffusion_InjectedDelegateField = IL2CPP.ResolveICall<get_diffusion_InjectedDelegate>("UnityEngine.AudioReverbZone::get_diffusion_Injected");

	private static readonly set_diffusion_InjectedDelegate set_diffusion_InjectedDelegateField = IL2CPP.ResolveICall<set_diffusion_InjectedDelegate>("UnityEngine.AudioReverbZone::set_diffusion_Injected");

	private static readonly get_density_InjectedDelegate get_density_InjectedDelegateField = IL2CPP.ResolveICall<get_density_InjectedDelegate>("UnityEngine.AudioReverbZone::get_density_Injected");

	private static readonly set_density_InjectedDelegate set_density_InjectedDelegateField = IL2CPP.ResolveICall<set_density_InjectedDelegate>("UnityEngine.AudioReverbZone::set_density_Injected");

	public float minDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_minDistance_Injected(intPtr, value);
		}
	}

	public float maxDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxDistance_Injected(intPtr, value);
		}
	}

	public AudioReverbPreset reverbPreset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reverbPreset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reverbPreset_Injected(intPtr, value);
		}
	}

	public int room
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_room_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_room_Injected(intPtr, value);
		}
	}

	public int roomHF
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_roomHF_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_roomHF_Injected(intPtr, value);
		}
	}

	public int roomLF
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_roomLF_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_roomLF_Injected(intPtr, value);
		}
	}

	public float decayTime
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_decayTime_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_decayTime_Injected(intPtr, value);
		}
	}

	public float decayHFRatio
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_decayHFRatio_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_decayHFRatio_Injected(intPtr, value);
		}
	}

	public int reflections
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reflections_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reflections_Injected(intPtr, value);
		}
	}

	public float reflectionsDelay
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reflectionsDelay_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reflectionsDelay_Injected(intPtr, value);
		}
	}

	public int reverb
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reverb_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reverb_Injected(intPtr, value);
		}
	}

	public float reverbDelay
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reverbDelay_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reverbDelay_Injected(intPtr, value);
		}
	}

	public float HFReference
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_HFReference_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_HFReference_Injected(intPtr, value);
		}
	}

	public float LFReference
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_LFReference_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_LFReference_Injected(intPtr, value);
		}
	}

	public float roomRolloffFactor
	{
		get
		{
			Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
			return 10f;
		}
		set
		{
			Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
		}
	}

	public float diffusion
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_diffusion_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_diffusion_Injected(intPtr, value);
		}
	}

	public float density
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_density_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_density_Injected(intPtr, value);
		}
	}

	public static float get_minDistance_Injected(IntPtr _unity_self)
	{
		return get_minDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_minDistance_Injected(IntPtr _unity_self, float value)
	{
		set_minDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxDistance_Injected(IntPtr _unity_self)
	{
		return get_maxDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_maxDistance_Injected(IntPtr _unity_self, float value)
	{
		set_maxDistance_InjectedDelegateField(_unity_self, value);
	}

	public static AudioReverbPreset get_reverbPreset_Injected(IntPtr _unity_self)
	{
		return get_reverbPreset_InjectedDelegateField(_unity_self);
	}

	public static void set_reverbPreset_Injected(IntPtr _unity_self, AudioReverbPreset value)
	{
		set_reverbPreset_InjectedDelegateField(_unity_self, value);
	}

	public static int get_room_Injected(IntPtr _unity_self)
	{
		return get_room_InjectedDelegateField(_unity_self);
	}

	public static void set_room_Injected(IntPtr _unity_self, int value)
	{
		set_room_InjectedDelegateField(_unity_self, value);
	}

	public static int get_roomHF_Injected(IntPtr _unity_self)
	{
		return get_roomHF_InjectedDelegateField(_unity_self);
	}

	public static void set_roomHF_Injected(IntPtr _unity_self, int value)
	{
		set_roomHF_InjectedDelegateField(_unity_self, value);
	}

	public static int get_roomLF_Injected(IntPtr _unity_self)
	{
		return get_roomLF_InjectedDelegateField(_unity_self);
	}

	public static void set_roomLF_Injected(IntPtr _unity_self, int value)
	{
		set_roomLF_InjectedDelegateField(_unity_self, value);
	}

	public static float get_decayTime_Injected(IntPtr _unity_self)
	{
		return get_decayTime_InjectedDelegateField(_unity_self);
	}

	public static void set_decayTime_Injected(IntPtr _unity_self, float value)
	{
		set_decayTime_InjectedDelegateField(_unity_self, value);
	}

	public static float get_decayHFRatio_Injected(IntPtr _unity_self)
	{
		return get_decayHFRatio_InjectedDelegateField(_unity_self);
	}

	public static void set_decayHFRatio_Injected(IntPtr _unity_self, float value)
	{
		set_decayHFRatio_InjectedDelegateField(_unity_self, value);
	}

	public static int get_reflections_Injected(IntPtr _unity_self)
	{
		return get_reflections_InjectedDelegateField(_unity_self);
	}

	public static void set_reflections_Injected(IntPtr _unity_self, int value)
	{
		set_reflections_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reflectionsDelay_Injected(IntPtr _unity_self)
	{
		return get_reflectionsDelay_InjectedDelegateField(_unity_self);
	}

	public static void set_reflectionsDelay_Injected(IntPtr _unity_self, float value)
	{
		set_reflectionsDelay_InjectedDelegateField(_unity_self, value);
	}

	public static int get_reverb_Injected(IntPtr _unity_self)
	{
		return get_reverb_InjectedDelegateField(_unity_self);
	}

	public static void set_reverb_Injected(IntPtr _unity_self, int value)
	{
		set_reverb_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reverbDelay_Injected(IntPtr _unity_self)
	{
		return get_reverbDelay_InjectedDelegateField(_unity_self);
	}

	public static void set_reverbDelay_Injected(IntPtr _unity_self, float value)
	{
		set_reverbDelay_InjectedDelegateField(_unity_self, value);
	}

	public static float get_HFReference_Injected(IntPtr _unity_self)
	{
		return get_HFReference_InjectedDelegateField(_unity_self);
	}

	public static void set_HFReference_Injected(IntPtr _unity_self, float value)
	{
		set_HFReference_InjectedDelegateField(_unity_self, value);
	}

	public static float get_LFReference_Injected(IntPtr _unity_self)
	{
		return get_LFReference_InjectedDelegateField(_unity_self);
	}

	public static void set_LFReference_Injected(IntPtr _unity_self, float value)
	{
		set_LFReference_InjectedDelegateField(_unity_self, value);
	}

	public static float get_diffusion_Injected(IntPtr _unity_self)
	{
		return get_diffusion_InjectedDelegateField(_unity_self);
	}

	public static void set_diffusion_Injected(IntPtr _unity_self, float value)
	{
		set_diffusion_InjectedDelegateField(_unity_self, value);
	}

	public static float get_density_Injected(IntPtr _unity_self)
	{
		return get_density_InjectedDelegateField(_unity_self);
	}

	public static void set_density_Injected(IntPtr _unity_self, float value)
	{
		set_density_InjectedDelegateField(_unity_self, value);
	}
}
