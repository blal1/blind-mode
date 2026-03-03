using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngineInternal.Video;

public class VideoPlaybackMgr
{
	public static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Internal_CreateDelegate();

	private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

	private delegate void ProcessOSMainLoopMessagesForTestingDelegate();

	private delegate void ReleaseVideoPlayback_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr playback);

	private delegate ulong get_videoPlaybackCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Update_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Create");

	private static readonly Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Internal_DestroyDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Destroy");

	private static readonly ProcessOSMainLoopMessagesForTestingDelegate ProcessOSMainLoopMessagesForTestingDelegateField = IL2CPP.ResolveICall<ProcessOSMainLoopMessagesForTestingDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ProcessOSMainLoopMessagesForTesting");

	private static readonly ReleaseVideoPlayback_InjectedDelegate ReleaseVideoPlayback_InjectedDelegateField = IL2CPP.ResolveICall<ReleaseVideoPlayback_InjectedDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ReleaseVideoPlayback_Injected");

	private static readonly get_videoPlaybackCount_InjectedDelegate get_videoPlaybackCount_InjectedDelegateField = IL2CPP.ResolveICall<get_videoPlaybackCount_InjectedDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::get_videoPlaybackCount_Injected");

	private static readonly Update_InjectedDelegate Update_InjectedDelegateField = IL2CPP.ResolveICall<Update_InjectedDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Update_Injected");

	public ulong videoPlaybackCount
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_videoPlaybackCount_Injected(intPtr);
		}
	}

	public void Dispose()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static System.IntPtr Internal_Create()
	{
		return Internal_CreateDelegateField();
	}

	public static void Internal_Destroy(System.IntPtr ptr)
	{
		Internal_DestroyDelegateField(ptr);
	}

	public void ReleaseVideoPlayback(VideoPlayback playback)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		ReleaseVideoPlayback_Injected(intPtr, (playback == null) ? ((System.IntPtr)0) : VideoPlayback.BindingsMarshaller.ConvertToNative(playback));
	}

	public void Update()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		Update_Injected(intPtr);
	}

	public static void ProcessOSMainLoopMessagesForTesting()
	{
		ProcessOSMainLoopMessagesForTestingDelegateField();
	}

	public static void ReleaseVideoPlayback_Injected(System.IntPtr _unity_self, System.IntPtr playback)
	{
		ReleaseVideoPlayback_InjectedDelegateField(_unity_self, playback);
	}

	public static ulong get_videoPlaybackCount_Injected(System.IntPtr _unity_self)
	{
		return get_videoPlaybackCount_InjectedDelegateField(_unity_self);
	}

	public static void Update_Injected(System.IntPtr _unity_self)
	{
		Update_InjectedDelegateField(_unity_self);
	}
}
