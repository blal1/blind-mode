using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

public static class AudioPlayableBinding : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;

	static AudioPlayableBinding()
	{
		Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableBinding>.NativeClassPtr, 100663451);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1163651, RefRangeEnd = 1163653, XrefRangeStart = 1163636, XrefRangeEnd = 1163651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableBinding Create(string name, Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayableBinding(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163653, XrefRangeEnd = 1163655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAudioOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AudioPlayableBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
