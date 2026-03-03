using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

public static class AudioPlayableGraphExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAudioOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0;

	static AudioPlayableGraphExtensions()
	{
		Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableGraphExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_InternalCreateAudioOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableGraphExtensions>.NativeClassPtr, 100663453);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163669, RefRangeEnd = 1163670, XrefRangeStart = 1163655, XrefRangeEnd = 1163669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAudioOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163670, XrefRangeEnd = 1163672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAudioOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAudioOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AudioPlayableGraphExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
