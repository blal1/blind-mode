using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

[StructLayout(LayoutKind.Explicit)]
public struct AudioClipPlayable
{
	private delegate bool GetLoopedInternalDelegate(System.IntPtr hdl);

	private delegate void SetLoopedInternalDelegate(System.IntPtr hdl, bool looped);

	private delegate float GetVolumeInternalDelegate(System.IntPtr hdl);

	private delegate float GetClipPositionSecInternalDelegate(System.IntPtr hdl);

	private delegate float GetStereoPanInternalDelegate(System.IntPtr hdl);

	private delegate float GetSpatialBlendInternalDelegate(System.IntPtr hdl);

	private delegate bool GetIsChannelPlayingInternalDelegate(System.IntPtr hdl);

	private delegate double GetStartDelayInternalDelegate(System.IntPtr hdl);

	private delegate double GetPauseDelayInternalDelegate(System.IntPtr hdl);

	private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

	private delegate System.IntPtr GetClipInternal_InjectedDelegate(System.IntPtr hdl);

	private delegate void SetClipInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr clip);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Injected_Private_Static_Boolean_byref_PlayableGraph_IntPtr_Boolean_byref_PlayableHandle_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	private static readonly GetLoopedInternalDelegate GetLoopedInternalDelegateField;

	private static readonly SetLoopedInternalDelegate SetLoopedInternalDelegateField;

	private static readonly GetVolumeInternalDelegate GetVolumeInternalDelegateField;

	private static readonly GetClipPositionSecInternalDelegate GetClipPositionSecInternalDelegateField;

	private static readonly GetStereoPanInternalDelegate GetStereoPanInternalDelegateField;

	private static readonly GetSpatialBlendInternalDelegate GetSpatialBlendInternalDelegateField;

	private static readonly GetIsChannelPlayingInternalDelegate GetIsChannelPlayingInternalDelegateField;

	private static readonly GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

	private static readonly GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

	private static readonly ValidateTypeDelegate ValidateTypeDelegateField;

	private static readonly GetClipInternal_InjectedDelegate GetClipInternal_InjectedDelegateField;

	private static readonly SetClipInternal_InjectedDelegate SetClipInternal_InjectedDelegateField;

	static AudioClipPlayable()
	{
		Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioClipPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Injected_Private_Static_Boolean_byref_PlayableGraph_IntPtr_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663428);
		GetLoopedInternalDelegateField = IL2CPP.ResolveICall<GetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetLoopedInternal");
		SetLoopedInternalDelegateField = IL2CPP.ResolveICall<SetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetLoopedInternal");
		GetVolumeInternalDelegateField = IL2CPP.ResolveICall<GetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetVolumeInternal");
		GetClipPositionSecInternalDelegateField = IL2CPP.ResolveICall<GetClipPositionSecInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetClipPositionSecInternal");
		GetStereoPanInternalDelegateField = IL2CPP.ResolveICall<GetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStereoPanInternal");
		GetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<GetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetSpatialBlendInternal");
		GetIsChannelPlayingInternalDelegateField = IL2CPP.ResolveICall<GetIsChannelPlayingInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetIsChannelPlayingInternal");
		GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<GetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStartDelayInternal");
		GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<GetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetPauseDelayInternal");
		ValidateTypeDelegateField = IL2CPP.ResolveICall<ValidateTypeDelegate>("UnityEngine.Audio.AudioClipPlayable::ValidateType");
		GetClipInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetClipInternal_InjectedDelegate>("UnityEngine.Audio.AudioClipPlayable::GetClipInternal_Injected");
		SetClipInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetClipInternal_InjectedDelegate>("UnityEngine.Audio.AudioClipPlayable::SetClipInternal_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163335, RefRangeEnd = 1163336, XrefRangeStart = 1163301, XrefRangeEnd = 1163335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &looping;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AudioClipPlayable_PlayableGraph_AudioClip_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioClipPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163336, XrefRangeEnd = 1163349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &looping;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_AudioClip_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163349, XrefRangeEnd = 1163358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClipPlayable(PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1158137, RefRangeEnd = 1158142, XrefRangeStart = 1158137, XrefRangeEnd = 1158142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Playable(AudioClipPlayable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioClipPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1163371, RefRangeEnd = 1163374, XrefRangeStart = 1163358, XrefRangeEnd = 1163371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator AudioClipPlayable(Playable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_AudioClipPlayable_Playable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioClipPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163374, XrefRangeEnd = 1163378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AudioClipPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1163380, RefRangeEnd = 1163382, XrefRangeStart = 1163378, XrefRangeEnd = 1163380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVolume(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1163384, RefRangeEnd = 1163386, XrefRangeStart = 1163382, XrefRangeEnd = 1163384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStereoPan(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoPan_Internal_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1163388, RefRangeEnd = 1163390, XrefRangeStart = 1163386, XrefRangeEnd = 1163388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSpatialBlend(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpatialBlend_Internal_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163414, RefRangeEnd = 1163415, XrefRangeStart = 1163390, XrefRangeEnd = 1163414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Seek(double startTime, double startDelay, double duration)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&startTime);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDelay;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Seek_Public_Void_Double_Double_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163415, XrefRangeEnd = 1163417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVolumeInternal(ref PlayableHandle hdl, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hdl);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVolumeInternal_Private_Static_Void_byref_PlayableHandle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163417, XrefRangeEnd = 1163419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hdl);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoPan;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStereoPanInternal_Private_Static_Void_byref_PlayableHandle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163419, XrefRangeEnd = 1163421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hdl);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &spatialBlend;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpatialBlendInternal_Private_Static_Void_byref_PlayableHandle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163421, XrefRangeEnd = 1163423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hdl);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStartDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163423, XrefRangeEnd = 1163425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hdl);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPauseDelayInternal_Private_Static_Void_byref_PlayableHandle_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163425, XrefRangeEnd = 1163430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &looping;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Private_Static_Boolean_byref_PlayableGraph_AudioClip_Boolean_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163430, XrefRangeEnd = 1163432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAudioClipPlayable_Injected(ref PlayableGraph graph, System.IntPtr clip, bool looping, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clip;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &looping;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAudioClipPlayable_Injected_Private_Static_Boolean_byref_PlayableGraph_IntPtr_Boolean_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public AudioClip GetClip()
	{
		return GetClipInternal(ref m_Handle);
	}

	public void SetClip(AudioClip value)
	{
		SetClipInternal(ref m_Handle, value);
	}

	public bool GetLooped()
	{
		return GetLoopedInternal(ref m_Handle);
	}

	public void SetLooped(bool value)
	{
		SetLoopedInternal(ref m_Handle, value);
	}

	public float GetVolume()
	{
		return GetVolumeInternal(ref m_Handle);
	}

	public float GetClipPositionSec()
	{
		return GetClipPositionSecInternal(ref m_Handle);
	}

	public float GetStereoPan()
	{
		return GetStereoPanInternal(ref m_Handle);
	}

	public float GetSpatialBlend()
	{
		return GetSpatialBlendInternal(ref m_Handle);
	}

	public bool IsPlaying()
	{
		return IsChannelPlaying();
	}

	public bool IsChannelPlaying()
	{
		return GetIsChannelPlayingInternal(ref m_Handle);
	}

	public double GetStartDelay()
	{
		return GetStartDelayInternal(ref m_Handle);
	}

	public void SetStartDelay(double value)
	{
		SetStartDelayInternal(ref m_Handle, value);
	}

	public double GetPauseDelay()
	{
		return GetPauseDelayInternal(ref m_Handle);
	}

	public void GetPauseDelay(double value)
	{
		double pauseDelayInternal = GetPauseDelayInternal(ref m_Handle);
		if (m_Handle.GetPlayState() == PlayState.Playing && (value < 0.05 || (pauseDelayInternal != 0.0 && pauseDelayInternal < 0.05)))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("AudioClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), audio system will not be able to change in time"));
		}
		SetPauseDelayInternal(ref m_Handle, value);
	}

	public void Seek(double startTime, double startDelay)
	{
		Seek(startTime, startDelay, 0.0);
	}

	public static AudioClip GetClipInternal(ref PlayableHandle hdl)
	{
		return Unmarshal.UnmarshalUnityObject<AudioClip>(GetClipInternal_Injected(ref hdl));
	}

	public static void SetClipInternal(ref PlayableHandle hdl, AudioClip clip)
	{
		SetClipInternal_Injected(ref hdl, Object.MarshalledUnityObject.Marshal(clip));
	}

	public unsafe static bool GetLoopedInternal(ref PlayableHandle hdl)
	{
		return GetLoopedInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetLoopedInternal(ref PlayableHandle hdl, bool looped)
	{
		SetLoopedInternalDelegateField((nint)Unsafe.AsPointer(ref hdl), looped);
	}

	public unsafe static float GetVolumeInternal(ref PlayableHandle hdl)
	{
		return GetVolumeInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static float GetClipPositionSecInternal(ref PlayableHandle hdl)
	{
		return GetClipPositionSecInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static float GetStereoPanInternal(ref PlayableHandle hdl)
	{
		return GetStereoPanInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static float GetSpatialBlendInternal(ref PlayableHandle hdl)
	{
		return GetSpatialBlendInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static bool GetIsChannelPlayingInternal(ref PlayableHandle hdl)
	{
		return GetIsChannelPlayingInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static double GetStartDelayInternal(ref PlayableHandle hdl)
	{
		return GetStartDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static double GetPauseDelayInternal(ref PlayableHandle hdl)
	{
		return GetPauseDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static bool ValidateType(ref PlayableHandle hdl)
	{
		return ValidateTypeDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static System.IntPtr GetClipInternal_Injected(ref PlayableHandle hdl)
	{
		return GetClipInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetClipInternal_Injected(ref PlayableHandle hdl, System.IntPtr clip)
	{
		SetClipInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref hdl), clip);
	}
}
