using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio;

public class AudioMixerSnapshot : Object
{
	private static readonly IntPtr NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransitionTo_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_audioMixer_Injected_Private_Static_IntPtr_IntPtr_0;

	public unsafe AudioMixer audioMixer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163616, XrefRangeEnd = 1163624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr2) : null;
		}
	}

	static AudioMixerSnapshot()
	{
		Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerSnapshot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr);
		NativeMethodInfoPtr_get_audioMixer_Public_get_AudioMixer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_TransitionTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_get_audioMixer_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerSnapshot>.NativeClassPtr, 100663449);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163633, RefRangeEnd = 1163634, XrefRangeStart = 1163624, XrefRangeEnd = 1163633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransitionTo(float timeToReach)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&timeToReach);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransitionTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163634, XrefRangeEnd = 1163636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_audioMixer_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_audioMixer_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AudioMixerSnapshot(IntPtr pointer)
		: base(pointer)
	{
	}
}
