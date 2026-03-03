using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.Audio;

public class AudioMixerGroup : Object
{
	private delegate IntPtr get_audioMixer_InjectedDelegate(IntPtr _unity_self);

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly get_audioMixer_InjectedDelegate get_audioMixer_InjectedDelegateField;

	public AudioMixer audioMixer
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AudioMixer>(get_audioMixer_Injected(intPtr));
		}
	}

	static AudioMixerGroup()
	{
		Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr, 100663439);
		get_audioMixer_InjectedDelegateField = IL2CPP.ResolveICall<get_audioMixer_InjectedDelegate>("UnityEngine.Audio.AudioMixerGroup::get_audioMixer_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163563, XrefRangeEnd = 1163567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioMixerGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioMixerGroup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioMixerGroup(IntPtr pointer)
		: base(pointer)
	{
	}

	public static IntPtr get_audioMixer_Injected(IntPtr _unity_self)
	{
		return get_audioMixer_InjectedDelegateField(_unity_self);
	}
}
