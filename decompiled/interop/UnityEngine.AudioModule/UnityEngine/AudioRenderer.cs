using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Audio;

namespace UnityEngine;

public class AudioRenderer
{
	private delegate bool Internal_AudioRenderer_StartDelegate();

	private delegate bool Internal_AudioRenderer_StopDelegate();

	private delegate int Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate();

	private delegate bool Internal_AudioRenderer_RenderDelegate(IntPtr ptr, int length);

	private delegate bool Internal_AudioRenderer_AddMixerGroupSink_InjectedDelegate(IntPtr mixerGroup, IntPtr ptr, int length, bool excludeFromMix);

	private static readonly Internal_AudioRenderer_StartDelegate Internal_AudioRenderer_StartDelegateField = IL2CPP.ResolveICall<Internal_AudioRenderer_StartDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Start");

	private static readonly Internal_AudioRenderer_StopDelegate Internal_AudioRenderer_StopDelegateField = IL2CPP.ResolveICall<Internal_AudioRenderer_StopDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Stop");

	private static readonly Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField = IL2CPP.ResolveICall<Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_GetSampleCountForCaptureFrame");

	private static readonly Internal_AudioRenderer_RenderDelegate Internal_AudioRenderer_RenderDelegateField = IL2CPP.ResolveICall<Internal_AudioRenderer_RenderDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Render");

	private static readonly Internal_AudioRenderer_AddMixerGroupSink_InjectedDelegate Internal_AudioRenderer_AddMixerGroupSink_InjectedDelegateField = IL2CPP.ResolveICall<Internal_AudioRenderer_AddMixerGroupSink_InjectedDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_AddMixerGroupSink_Injected");

	public static bool Start()
	{
		return Internal_AudioRenderer_Start();
	}

	public static bool Stop()
	{
		return Internal_AudioRenderer_Stop();
	}

	public static int GetSampleCountForCaptureFrame()
	{
		return Internal_AudioRenderer_GetSampleCountForCaptureFrame();
	}

	public unsafe static bool AddMixerGroupSink(AudioMixerGroup mixerGroup, NativeArray<float> buffer, bool excludeFromMix)
	{
		//IL_000f: Expected O, but got Ref
		return Internal_AudioRenderer_AddMixerGroupSink(mixerGroup, buffer.GetUnsafePtr(), ((NativeArray<float>)(&buffer)).Length, excludeFromMix);
	}

	public unsafe static bool Render(NativeArray<float> buffer)
	{
		//IL_000e: Expected O, but got Ref
		return Internal_AudioRenderer_Render(buffer.GetUnsafePtr(), ((NativeArray<float>)(&buffer)).Length);
	}

	public static bool Internal_AudioRenderer_Start()
	{
		return Internal_AudioRenderer_StartDelegateField();
	}

	public static bool Internal_AudioRenderer_Stop()
	{
		return Internal_AudioRenderer_StopDelegateField();
	}

	public static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
	{
		return Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField();
	}

	public unsafe static bool Internal_AudioRenderer_AddMixerGroupSink(AudioMixerGroup mixerGroup, void* ptr, int length, bool excludeFromMix)
	{
		return Internal_AudioRenderer_AddMixerGroupSink_Injected(Object.MarshalledUnityObject.Marshal(mixerGroup), ptr, length, excludeFromMix);
	}

	public unsafe static bool Internal_AudioRenderer_Render(void* ptr, int length)
	{
		return Internal_AudioRenderer_RenderDelegateField((nint)ptr, length);
	}

	public unsafe static bool Internal_AudioRenderer_AddMixerGroupSink_Injected(IntPtr mixerGroup, void* ptr, int length, bool excludeFromMix)
	{
		return Internal_AudioRenderer_AddMixerGroupSink_InjectedDelegateField(mixerGroup, (nint)ptr, length, excludeFromMix);
	}
}
