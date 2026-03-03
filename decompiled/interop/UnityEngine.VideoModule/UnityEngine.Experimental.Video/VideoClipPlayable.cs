using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video;

[StructLayout(LayoutKind.Explicit)]
public struct VideoClipPlayable
{
	private delegate bool GetLoopedInternalDelegate(System.IntPtr hdl);

	private delegate void SetLoopedInternalDelegate(System.IntPtr hdl, bool looped);

	private delegate bool GetIsPlayingInternalDelegate(System.IntPtr hdl);

	private delegate double GetStartDelayInternalDelegate(System.IntPtr hdl);

	private delegate void SetStartDelayInternalDelegate(System.IntPtr hdl, double delay);

	private delegate double GetPauseDelayInternalDelegate(System.IntPtr hdl);

	private delegate void SetPauseDelayInternalDelegate(System.IntPtr hdl, double delay);

	private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

	private delegate System.IntPtr GetClipInternal_InjectedDelegate(System.IntPtr hdl);

	private delegate void SetClipInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr clip);

	private delegate bool InternalCreateVideoClipPlayable_InjectedDelegate(System.IntPtr graph, System.IntPtr clip, bool looping, System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	private static readonly GetLoopedInternalDelegate GetLoopedInternalDelegateField;

	private static readonly SetLoopedInternalDelegate SetLoopedInternalDelegateField;

	private static readonly GetIsPlayingInternalDelegate GetIsPlayingInternalDelegateField;

	private static readonly GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

	private static readonly SetStartDelayInternalDelegate SetStartDelayInternalDelegateField;

	private static readonly GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

	private static readonly SetPauseDelayInternalDelegate SetPauseDelayInternalDelegateField;

	private static readonly ValidateTypeDelegate ValidateTypeDelegateField;

	private static readonly GetClipInternal_InjectedDelegate GetClipInternal_InjectedDelegateField;

	private static readonly SetClipInternal_InjectedDelegate SetClipInternal_InjectedDelegateField;

	private static readonly InternalCreateVideoClipPlayable_InjectedDelegate InternalCreateVideoClipPlayable_InjectedDelegateField;

	static VideoClipPlayable()
	{
		Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Experimental.Video", "VideoClipPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, 100663298);
		GetLoopedInternalDelegateField = IL2CPP.ResolveICall<GetLoopedInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetLoopedInternal");
		SetLoopedInternalDelegateField = IL2CPP.ResolveICall<SetLoopedInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetLoopedInternal");
		GetIsPlayingInternalDelegateField = IL2CPP.ResolveICall<GetIsPlayingInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetIsPlayingInternal");
		GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<GetStartDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetStartDelayInternal");
		SetStartDelayInternalDelegateField = IL2CPP.ResolveICall<SetStartDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetStartDelayInternal");
		GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<GetPauseDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetPauseDelayInternal");
		SetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<SetPauseDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetPauseDelayInternal");
		ValidateTypeDelegateField = IL2CPP.ResolveICall<ValidateTypeDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::ValidateType");
		GetClipInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetClipInternal_InjectedDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetClipInternal_Injected");
		SetClipInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetClipInternal_InjectedDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetClipInternal_Injected");
		InternalCreateVideoClipPlayable_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateVideoClipPlayable_InjectedDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::InternalCreateVideoClipPlayable_Injected");
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410718, XrefRangeEnd = 1410722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(VideoClipPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static VideoClipPlayable Create(PlayableGraph graph, VideoClip clip, bool looping)
	{
		PlayableHandle playableHandle = CreateHandle(graph, clip, looping);
		VideoClipPlayable videoClipPlayable = new VideoClipPlayable(playableHandle);
		if (clip != null)
		{
			videoClipPlayable.SetDuration(clip.length);
		}
		return videoClipPlayable;
	}

	public static PlayableHandle CreateHandle(PlayableGraph graph, VideoClip clip, bool looping)
	{
		PlayableHandle handle = PlayableHandle.Null;
		if (!InternalCreateVideoClipPlayable(ref graph, clip, looping, ref handle))
		{
			return PlayableHandle.Null;
		}
		return handle;
	}

	public static implicit operator Playable(VideoClipPlayable playable)
	{
		return new Playable(playable.GetHandle());
	}

	public static explicit operator VideoClipPlayable(Playable playable)
	{
		return new VideoClipPlayable(playable.GetHandle());
	}

	public VideoClip GetClip()
	{
		return GetClipInternal(ref m_Handle);
	}

	public void SetClip(VideoClip value)
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

	public bool IsPlaying()
	{
		return GetIsPlayingInternal(ref m_Handle);
	}

	public double GetStartDelay()
	{
		return GetStartDelayInternal(ref m_Handle);
	}

	public void SetStartDelay(double value)
	{
		ValidateStartDelayInternal(value);
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
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("VideoClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), Video system will not be able to change in time"));
		}
		SetPauseDelayInternal(ref m_Handle, value);
	}

	public void Seek(double startTime, double startDelay)
	{
		Seek(startTime, startDelay, 0.0);
	}

	public void Seek(double startTime, double startDelay, double duration)
	{
		ValidateStartDelayInternal(startDelay);
		SetStartDelayInternal(ref m_Handle, startDelay);
		if (duration > 0.0)
		{
			m_Handle.SetDuration(duration + startTime);
			SetPauseDelayInternal(ref m_Handle, startDelay + duration);
		}
		else
		{
			m_Handle.SetDuration(double.MaxValue);
			SetPauseDelayInternal(ref m_Handle, 0.0);
		}
		m_Handle.SetTime(startTime);
		m_Handle.Play();
	}

	public void ValidateStartDelayInternal(double startDelay)
	{
		double startDelayInternal = GetStartDelayInternal(ref m_Handle);
		if (IsPlaying() && (startDelay < 0.05 || (startDelayInternal >= 1E-05 && startDelayInternal < 0.05)))
		{
			Debug.LogWarning(Il2CppSystem.String.Concat("VideoClipPlayable.StartDelay: Setting new delay when existing delay is too small or 0.0 (", startDelayInternal.ToString(), "), Video system will not be able to change in time"));
		}
	}

	public static VideoClip GetClipInternal(ref PlayableHandle hdl)
	{
		return Unmarshal.UnmarshalUnityObject<VideoClip>(GetClipInternal_Injected(ref hdl));
	}

	public static void SetClipInternal(ref PlayableHandle hdl, VideoClip clip)
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

	public unsafe static bool GetIsPlayingInternal(ref PlayableHandle hdl)
	{
		return GetIsPlayingInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static double GetStartDelayInternal(ref PlayableHandle hdl)
	{
		return GetStartDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
	{
		SetStartDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl), delay);
	}

	public unsafe static double GetPauseDelayInternal(ref PlayableHandle hdl)
	{
		return GetPauseDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl));
	}

	public unsafe static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
	{
		SetPauseDelayInternalDelegateField((nint)Unsafe.AsPointer(ref hdl), delay);
	}

	public static bool InternalCreateVideoClipPlayable(ref PlayableGraph graph, VideoClip clip, bool looping, ref PlayableHandle handle)
	{
		return InternalCreateVideoClipPlayable_Injected(ref graph, Object.MarshalledUnityObject.Marshal(clip), looping, ref handle);
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

	public unsafe static bool InternalCreateVideoClipPlayable_Injected(ref PlayableGraph graph, System.IntPtr clip, bool looping, ref PlayableHandle handle)
	{
		return InternalCreateVideoClipPlayable_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), clip, looping, (nint)Unsafe.AsPointer(ref handle));
	}
}
