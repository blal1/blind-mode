using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct AudioConfiguration
{
	private static readonly System.IntPtr NativeFieldInfoPtr_speakerMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_dspBufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_numRealVoices;

	private static readonly System.IntPtr NativeFieldInfoPtr_numVirtualVoices;

	[FieldOffset(0)]
	public AudioSpeakerMode speakerMode;

	[FieldOffset(4)]
	public int dspBufferSize;

	[FieldOffset(8)]
	public int sampleRate;

	[FieldOffset(12)]
	public int numRealVoices;

	[FieldOffset(16)]
	public int numVirtualVoices;

	static AudioConfiguration()
	{
		Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr_speakerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, "speakerMode");
		NativeFieldInfoPtr_dspBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, "dspBufferSize");
		NativeFieldInfoPtr_sampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, "sampleRate");
		NativeFieldInfoPtr_numRealVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, "numRealVoices");
		NativeFieldInfoPtr_numVirtualVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, "numVirtualVoices");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioConfiguration>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
