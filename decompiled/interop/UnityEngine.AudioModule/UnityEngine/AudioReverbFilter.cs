using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioReverbFilter : Behaviour
{
	private delegate AudioReverbPreset get_reverbPreset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverbPreset_InjectedDelegate(IntPtr _unity_self, AudioReverbPreset value);

	private delegate float get_dryLevel_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dryLevel_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_room_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_room_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_roomHF_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_roomHF_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_decayTime_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_decayTime_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_decayHFRatio_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_decayHFRatio_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_reflectionsLevel_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reflectionsLevel_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_reflectionsDelay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reflectionsDelay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_reverbLevel_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverbLevel_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_reverbDelay_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_reverbDelay_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_diffusion_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_diffusion_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_density_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_density_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_hfReference_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_hfReference_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_roomLF_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_roomLF_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_lfReference_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_lfReference_InjectedDelegate(IntPtr _unity_self, float value);

	private static readonly get_reverbPreset_InjectedDelegate get_reverbPreset_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbPreset_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_reverbPreset_Injected");

	private static readonly set_reverbPreset_InjectedDelegate set_reverbPreset_InjectedDelegateField = IL2CPP.ResolveICall<set_reverbPreset_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_reverbPreset_Injected");

	private static readonly get_dryLevel_InjectedDelegate get_dryLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_dryLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_dryLevel_Injected");

	private static readonly set_dryLevel_InjectedDelegate set_dryLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_dryLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_dryLevel_Injected");

	private static readonly get_room_InjectedDelegate get_room_InjectedDelegateField = IL2CPP.ResolveICall<get_room_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_room_Injected");

	private static readonly set_room_InjectedDelegate set_room_InjectedDelegateField = IL2CPP.ResolveICall<set_room_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_room_Injected");

	private static readonly get_roomHF_InjectedDelegate get_roomHF_InjectedDelegateField = IL2CPP.ResolveICall<get_roomHF_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_roomHF_Injected");

	private static readonly set_roomHF_InjectedDelegate set_roomHF_InjectedDelegateField = IL2CPP.ResolveICall<set_roomHF_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_roomHF_Injected");

	private static readonly get_decayTime_InjectedDelegate get_decayTime_InjectedDelegateField = IL2CPP.ResolveICall<get_decayTime_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_decayTime_Injected");

	private static readonly set_decayTime_InjectedDelegate set_decayTime_InjectedDelegateField = IL2CPP.ResolveICall<set_decayTime_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_decayTime_Injected");

	private static readonly get_decayHFRatio_InjectedDelegate get_decayHFRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_decayHFRatio_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_decayHFRatio_Injected");

	private static readonly set_decayHFRatio_InjectedDelegate set_decayHFRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_decayHFRatio_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_decayHFRatio_Injected");

	private static readonly get_reflectionsLevel_InjectedDelegate get_reflectionsLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_reflectionsLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsLevel_Injected");

	private static readonly set_reflectionsLevel_InjectedDelegate set_reflectionsLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_reflectionsLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsLevel_Injected");

	private static readonly get_reflectionsDelay_InjectedDelegate get_reflectionsDelay_InjectedDelegateField = IL2CPP.ResolveICall<get_reflectionsDelay_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsDelay_Injected");

	private static readonly set_reflectionsDelay_InjectedDelegate set_reflectionsDelay_InjectedDelegateField = IL2CPP.ResolveICall<set_reflectionsDelay_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsDelay_Injected");

	private static readonly get_reverbLevel_InjectedDelegate get_reverbLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_reverbLevel_Injected");

	private static readonly set_reverbLevel_InjectedDelegate set_reverbLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_reverbLevel_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_reverbLevel_Injected");

	private static readonly get_reverbDelay_InjectedDelegate get_reverbDelay_InjectedDelegateField = IL2CPP.ResolveICall<get_reverbDelay_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_reverbDelay_Injected");

	private static readonly set_reverbDelay_InjectedDelegate set_reverbDelay_InjectedDelegateField = IL2CPP.ResolveICall<set_reverbDelay_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_reverbDelay_Injected");

	private static readonly get_diffusion_InjectedDelegate get_diffusion_InjectedDelegateField = IL2CPP.ResolveICall<get_diffusion_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_diffusion_Injected");

	private static readonly set_diffusion_InjectedDelegate set_diffusion_InjectedDelegateField = IL2CPP.ResolveICall<set_diffusion_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_diffusion_Injected");

	private static readonly get_density_InjectedDelegate get_density_InjectedDelegateField = IL2CPP.ResolveICall<get_density_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_density_Injected");

	private static readonly set_density_InjectedDelegate set_density_InjectedDelegateField = IL2CPP.ResolveICall<set_density_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_density_Injected");

	private static readonly get_hfReference_InjectedDelegate get_hfReference_InjectedDelegateField = IL2CPP.ResolveICall<get_hfReference_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_hfReference_Injected");

	private static readonly set_hfReference_InjectedDelegate set_hfReference_InjectedDelegateField = IL2CPP.ResolveICall<set_hfReference_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_hfReference_Injected");

	private static readonly get_roomLF_InjectedDelegate get_roomLF_InjectedDelegateField = IL2CPP.ResolveICall<get_roomLF_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_roomLF_Injected");

	private static readonly set_roomLF_InjectedDelegate set_roomLF_InjectedDelegateField = IL2CPP.ResolveICall<set_roomLF_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_roomLF_Injected");

	private static readonly get_lfReference_InjectedDelegate get_lfReference_InjectedDelegateField = IL2CPP.ResolveICall<get_lfReference_InjectedDelegate>("UnityEngine.AudioReverbFilter::get_lfReference_Injected");

	private static readonly set_lfReference_InjectedDelegate set_lfReference_InjectedDelegateField = IL2CPP.ResolveICall<set_lfReference_InjectedDelegate>("UnityEngine.AudioReverbFilter::set_lfReference_Injected");

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

	public float dryLevel
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dryLevel_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_dryLevel_Injected(intPtr, value);
		}
	}

	public float room
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

	public float roomHF
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

	public float reflectionsLevel
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reflectionsLevel_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reflectionsLevel_Injected(intPtr, value);
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

	public float reverbLevel
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reverbLevel_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reverbLevel_Injected(intPtr, value);
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

	public float hfReference
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hfReference_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_hfReference_Injected(intPtr, value);
		}
	}

	public float roomLF
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

	public float lfReference
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lfReference_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lfReference_Injected(intPtr, value);
		}
	}

	public static AudioReverbPreset get_reverbPreset_Injected(IntPtr _unity_self)
	{
		return get_reverbPreset_InjectedDelegateField(_unity_self);
	}

	public static void set_reverbPreset_Injected(IntPtr _unity_self, AudioReverbPreset value)
	{
		set_reverbPreset_InjectedDelegateField(_unity_self, value);
	}

	public static float get_dryLevel_Injected(IntPtr _unity_self)
	{
		return get_dryLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_dryLevel_Injected(IntPtr _unity_self, float value)
	{
		set_dryLevel_InjectedDelegateField(_unity_self, value);
	}

	public static float get_room_Injected(IntPtr _unity_self)
	{
		return get_room_InjectedDelegateField(_unity_self);
	}

	public static void set_room_Injected(IntPtr _unity_self, float value)
	{
		set_room_InjectedDelegateField(_unity_self, value);
	}

	public static float get_roomHF_Injected(IntPtr _unity_self)
	{
		return get_roomHF_InjectedDelegateField(_unity_self);
	}

	public static void set_roomHF_Injected(IntPtr _unity_self, float value)
	{
		set_roomHF_InjectedDelegateField(_unity_self, value);
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

	public static float get_reflectionsLevel_Injected(IntPtr _unity_self)
	{
		return get_reflectionsLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_reflectionsLevel_Injected(IntPtr _unity_self, float value)
	{
		set_reflectionsLevel_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reflectionsDelay_Injected(IntPtr _unity_self)
	{
		return get_reflectionsDelay_InjectedDelegateField(_unity_self);
	}

	public static void set_reflectionsDelay_Injected(IntPtr _unity_self, float value)
	{
		set_reflectionsDelay_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reverbLevel_Injected(IntPtr _unity_self)
	{
		return get_reverbLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_reverbLevel_Injected(IntPtr _unity_self, float value)
	{
		set_reverbLevel_InjectedDelegateField(_unity_self, value);
	}

	public static float get_reverbDelay_Injected(IntPtr _unity_self)
	{
		return get_reverbDelay_InjectedDelegateField(_unity_self);
	}

	public static void set_reverbDelay_Injected(IntPtr _unity_self, float value)
	{
		set_reverbDelay_InjectedDelegateField(_unity_self, value);
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

	public static float get_hfReference_Injected(IntPtr _unity_self)
	{
		return get_hfReference_InjectedDelegateField(_unity_self);
	}

	public static void set_hfReference_Injected(IntPtr _unity_self, float value)
	{
		set_hfReference_InjectedDelegateField(_unity_self, value);
	}

	public static float get_roomLF_Injected(IntPtr _unity_self)
	{
		return get_roomLF_InjectedDelegateField(_unity_self);
	}

	public static void set_roomLF_Injected(IntPtr _unity_self, float value)
	{
		set_roomLF_InjectedDelegateField(_unity_self, value);
	}

	public static float get_lfReference_Injected(IntPtr _unity_self)
	{
		return get_lfReference_InjectedDelegateField(_unity_self);
	}

	public static void set_lfReference_Injected(IntPtr _unity_self, float value)
	{
		set_lfReference_InjectedDelegateField(_unity_self, value);
	}
}
