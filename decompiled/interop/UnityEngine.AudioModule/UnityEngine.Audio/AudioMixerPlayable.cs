using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

[StructLayout(LayoutKind.Explicit)]
public struct AudioMixerPlayable
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioMixerPlayable_PlayableGraph_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioMixerPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAudioMixerPlayableInternal_Private_Static_Boolean_byref_PlayableGraph_Boolean_byref_PlayableHandle_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	static AudioMixerPlayable()
	{
		Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_Create_Public_Static_AudioMixerPlayable_PlayableGraph_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_CreateAudioMixerPlayableInternal_Private_Static_Boolean_byref_PlayableGraph_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663446);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163588, RefRangeEnd = 1163589, XrefRangeStart = 1163567, XrefRangeEnd = 1163588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalizeInputVolumes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AudioMixerPlayable_PlayableGraph_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioMixerPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163589, XrefRangeEnd = 1163601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalizeInputVolumes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163601, XrefRangeEnd = 1163610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioMixerPlayable(PlayableHandle handle)
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
	public unsafe static implicit operator Playable(AudioMixerPlayable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AudioMixerPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163610, XrefRangeEnd = 1163614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AudioMixerPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163614, XrefRangeEnd = 1163616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalizeInputVolumes;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAudioMixerPlayableInternal_Private_Static_Boolean_byref_PlayableGraph_Boolean_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static explicit operator AudioMixerPlayable(Playable playable)
	{
		return new AudioMixerPlayable(playable.GetHandle());
	}
}
