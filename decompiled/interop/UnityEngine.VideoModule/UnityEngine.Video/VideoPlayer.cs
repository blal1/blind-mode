using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Video;

public sealed class VideoPlayer : Behaviour
{
	public sealed class EventHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0;

		static EventHandler()
		{
			Il2CppClassPointerStore<EventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "EventHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100663357);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100663358);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoPlayer source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public EventHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator EventHandler(System.Action<VideoPlayer> P_0)
		{
			return DelegateSupport.ConvertDelegate<EventHandler>((System.Delegate)P_0);
		}

		public static EventHandler operator +(EventHandler P_0, EventHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<EventHandler>();
		}

		public static EventHandler operator -(EventHandler P_0, EventHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<EventHandler>();
			}
			return (EventHandler)obj;
		}
	}

	public sealed class ErrorEventHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0;

		static ErrorEventHandler()
		{
			Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "ErrorEventHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr, 100663359);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr, 100663360);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862581, XrefRangeEnd = 862587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoPlayer source, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ErrorEventHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ErrorEventHandler(System.Action<VideoPlayer, string> P_0)
		{
			return DelegateSupport.ConvertDelegate<ErrorEventHandler>((System.Delegate)P_0);
		}

		public static ErrorEventHandler operator +(ErrorEventHandler P_0, ErrorEventHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ErrorEventHandler>();
		}

		public static ErrorEventHandler operator -(ErrorEventHandler P_0, ErrorEventHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ErrorEventHandler>();
			}
			return (ErrorEventHandler)obj;
		}
	}

	public sealed class FrameReadyEventHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0;

		static FrameReadyEventHandler()
		{
			Il2CppClassPointerStore<FrameReadyEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "FrameReadyEventHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameReadyEventHandler>.NativeClassPtr, 100663361);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameReadyEventHandler>.NativeClassPtr, 100663362);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862581, XrefRangeEnd = 862587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameReadyEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameReadyEventHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoPlayer source, long frameIdx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
			*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIdx;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FrameReadyEventHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator FrameReadyEventHandler(System.Action<VideoPlayer, long> P_0)
		{
			return DelegateSupport.ConvertDelegate<FrameReadyEventHandler>((System.Delegate)P_0);
		}

		public static FrameReadyEventHandler operator +(FrameReadyEventHandler P_0, FrameReadyEventHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<FrameReadyEventHandler>();
		}

		public static FrameReadyEventHandler operator -(FrameReadyEventHandler P_0, FrameReadyEventHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<FrameReadyEventHandler>();
			}
			return (FrameReadyEventHandler)obj;
		}
	}

	public sealed class TimeEventHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0;

		static TimeEventHandler()
		{
			Il2CppClassPointerStore<TimeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "TimeEventHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeEventHandler>.NativeClassPtr, 100663363);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeEventHandler>.NativeClassPtr, 100663364);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410726, XrefRangeEnd = 1410730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeEventHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoPlayer source, double seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seconds;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoPlayer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TimeEventHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator TimeEventHandler(System.Action<VideoPlayer, double> P_0)
		{
			return DelegateSupport.ConvertDelegate<TimeEventHandler>((System.Delegate)P_0);
		}

		public static TimeEventHandler operator +(TimeEventHandler P_0, TimeEventHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<TimeEventHandler>();
		}

		public static TimeEventHandler operator -(TimeEventHandler P_0, TimeEventHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<TimeEventHandler>();
			}
			return (TimeEventHandler)obj;
		}
	}

	private delegate ushort get_controlledAudioTrackMaxCountDelegate();

	private delegate VideoTimeUpdateMode get_timeUpdateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_timeUpdateMode_InjectedDelegate(System.IntPtr _unity_self, VideoTimeUpdateMode value);

	private delegate VideoRenderMode get_renderMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderMode_InjectedDelegate(System.IntPtr _unity_self, VideoRenderMode value);

	private delegate bool get_canSetTimeUpdateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_targetCamera_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_targetCamera_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_targetMaterialRenderer_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_targetMaterialRenderer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void get_targetMaterialProperty_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_targetMaterialProperty_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate VideoAspectRatio get_aspectRatio_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_aspectRatio_InjectedDelegate(System.IntPtr _unity_self, VideoAspectRatio value);

	private delegate float get_targetCameraAlpha_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_targetCameraAlpha_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate Video3DLayout get_targetCamera3DLayout_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_targetCamera3DLayout_InjectedDelegate(System.IntPtr _unity_self, Video3DLayout value);

	private delegate System.IntPtr get_texture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_waitForFirstFrame_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_waitForFirstFrame_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_playOnAwake_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_playOnAwake_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_isPlaying_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_canSetTime_InjectedDelegate(System.IntPtr _unity_self);

	private delegate double get_time_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_time_InjectedDelegate(System.IntPtr _unity_self, double value);

	private delegate bool get_canStep_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void StepForward_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_canSetPlaybackSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_playbackSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_playbackSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_isLooping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isLooping_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_canSetTimeSource_InjectedDelegate(System.IntPtr _unity_self);

	private delegate VideoTimeSource get_timeSource_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_timeSource_InjectedDelegate(System.IntPtr _unity_self, VideoTimeSource value);

	private delegate VideoTimeReference get_timeReference_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_timeReference_InjectedDelegate(System.IntPtr _unity_self, VideoTimeReference value);

	private delegate double get_externalReferenceTime_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_externalReferenceTime_InjectedDelegate(System.IntPtr _unity_self, double value);

	private delegate bool get_canSetSkipOnDrop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_skipOnDrop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_skipOnDrop_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate uint get_width_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint get_height_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint get_pixelAspectRatioNumerator_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint get_pixelAspectRatioDenominator_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ushort get_audioTrackCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetAudioLanguageCode_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex, [Out] System.IntPtr ret);

	private delegate ushort GetAudioChannelCount_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate uint GetAudioSampleRate_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate ushort GetControlledAudioTrackCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetControlledAudioTrackCount_InjectedDelegate(System.IntPtr _unity_self, ushort value);

	private delegate void EnableAudioTrack_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex, bool enabled);

	private delegate bool IsAudioTrackEnabled_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate VideoAudioOutputMode get_audioOutputMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_audioOutputMode_InjectedDelegate(System.IntPtr _unity_self, VideoAudioOutputMode value);

	private delegate bool get_canSetDirectAudioVolume_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float GetDirectAudioVolume_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate void SetDirectAudioVolume_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex, float volume);

	private delegate bool GetDirectAudioMute_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate void SetDirectAudioMute_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex, bool mute);

	private delegate System.IntPtr GetTargetAudioSource_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex);

	private delegate void SetTargetAudioSource_InjectedDelegate(System.IntPtr _unity_self, ushort trackIndex, System.IntPtr source);

	private delegate bool get_sendFrameReadyEvents_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sendFrameReadyEvents_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private static readonly System.IntPtr NativeFieldInfoPtr_prepareCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopPointReached;

	private static readonly System.IntPtr NativeFieldInfoPtr_started;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameDropped;

	private static readonly System.IntPtr NativeFieldInfoPtr_errorReceived;

	private static readonly System.IntPtr NativeFieldInfoPtr_seekCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_clockResyncOccurred;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameReady;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_source_Public_get_VideoSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_source_Public_set_Void_VideoSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_url_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_url_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPrepared_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frame_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_frame_Public_set_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clockTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameCount_Public_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_prepareCompleted_Public_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_prepareCompleted_Public_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_loopPointReached_Public_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_loopPointReached_Public_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_started_Public_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_started_Public_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_errorReceived_Public_add_Void_ErrorEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_errorReceived_Public_rem_Void_ErrorEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_source_Injected_Private_Static_VideoSource_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_source_Injected_Private_Static_Void_IntPtr_VideoSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clip_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clip_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPrepared_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPaused_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frame_Injected_Private_Static_Int64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_frame_Injected_Private_Static_Void_IntPtr_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clockTime_Injected_Private_Static_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameCount_Injected_Private_Static_UInt64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameRate_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Injected_Private_Static_Double_IntPtr_0;

	private static readonly get_controlledAudioTrackMaxCountDelegate get_controlledAudioTrackMaxCountDelegateField;

	private static readonly get_timeUpdateMode_InjectedDelegate get_timeUpdateMode_InjectedDelegateField;

	private static readonly set_timeUpdateMode_InjectedDelegate set_timeUpdateMode_InjectedDelegateField;

	private static readonly get_renderMode_InjectedDelegate get_renderMode_InjectedDelegateField;

	private static readonly set_renderMode_InjectedDelegate set_renderMode_InjectedDelegateField;

	private static readonly get_canSetTimeUpdateMode_InjectedDelegate get_canSetTimeUpdateMode_InjectedDelegateField;

	private static readonly get_targetCamera_InjectedDelegate get_targetCamera_InjectedDelegateField;

	private static readonly set_targetCamera_InjectedDelegate set_targetCamera_InjectedDelegateField;

	private static readonly get_targetMaterialRenderer_InjectedDelegate get_targetMaterialRenderer_InjectedDelegateField;

	private static readonly set_targetMaterialRenderer_InjectedDelegate set_targetMaterialRenderer_InjectedDelegateField;

	private static readonly get_targetMaterialProperty_InjectedDelegate get_targetMaterialProperty_InjectedDelegateField;

	private static readonly set_targetMaterialProperty_InjectedDelegate set_targetMaterialProperty_InjectedDelegateField;

	private static readonly get_aspectRatio_InjectedDelegate get_aspectRatio_InjectedDelegateField;

	private static readonly set_aspectRatio_InjectedDelegate set_aspectRatio_InjectedDelegateField;

	private static readonly get_targetCameraAlpha_InjectedDelegate get_targetCameraAlpha_InjectedDelegateField;

	private static readonly set_targetCameraAlpha_InjectedDelegate set_targetCameraAlpha_InjectedDelegateField;

	private static readonly get_targetCamera3DLayout_InjectedDelegate get_targetCamera3DLayout_InjectedDelegateField;

	private static readonly set_targetCamera3DLayout_InjectedDelegate set_targetCamera3DLayout_InjectedDelegateField;

	private static readonly get_texture_InjectedDelegate get_texture_InjectedDelegateField;

	private static readonly get_waitForFirstFrame_InjectedDelegate get_waitForFirstFrame_InjectedDelegateField;

	private static readonly set_waitForFirstFrame_InjectedDelegate set_waitForFirstFrame_InjectedDelegateField;

	private static readonly get_playOnAwake_InjectedDelegate get_playOnAwake_InjectedDelegateField;

	private static readonly set_playOnAwake_InjectedDelegate set_playOnAwake_InjectedDelegateField;

	private static readonly get_isPlaying_InjectedDelegate get_isPlaying_InjectedDelegateField;

	private static readonly get_canSetTime_InjectedDelegate get_canSetTime_InjectedDelegateField;

	private static readonly get_time_InjectedDelegate get_time_InjectedDelegateField;

	private static readonly set_time_InjectedDelegate set_time_InjectedDelegateField;

	private static readonly get_canStep_InjectedDelegate get_canStep_InjectedDelegateField;

	private static readonly StepForward_InjectedDelegate StepForward_InjectedDelegateField;

	private static readonly get_canSetPlaybackSpeed_InjectedDelegate get_canSetPlaybackSpeed_InjectedDelegateField;

	private static readonly get_playbackSpeed_InjectedDelegate get_playbackSpeed_InjectedDelegateField;

	private static readonly set_playbackSpeed_InjectedDelegate set_playbackSpeed_InjectedDelegateField;

	private static readonly get_isLooping_InjectedDelegate get_isLooping_InjectedDelegateField;

	private static readonly set_isLooping_InjectedDelegate set_isLooping_InjectedDelegateField;

	private static readonly get_canSetTimeSource_InjectedDelegate get_canSetTimeSource_InjectedDelegateField;

	private static readonly get_timeSource_InjectedDelegate get_timeSource_InjectedDelegateField;

	private static readonly set_timeSource_InjectedDelegate set_timeSource_InjectedDelegateField;

	private static readonly get_timeReference_InjectedDelegate get_timeReference_InjectedDelegateField;

	private static readonly set_timeReference_InjectedDelegate set_timeReference_InjectedDelegateField;

	private static readonly get_externalReferenceTime_InjectedDelegate get_externalReferenceTime_InjectedDelegateField;

	private static readonly set_externalReferenceTime_InjectedDelegate set_externalReferenceTime_InjectedDelegateField;

	private static readonly get_canSetSkipOnDrop_InjectedDelegate get_canSetSkipOnDrop_InjectedDelegateField;

	private static readonly get_skipOnDrop_InjectedDelegate get_skipOnDrop_InjectedDelegateField;

	private static readonly set_skipOnDrop_InjectedDelegate set_skipOnDrop_InjectedDelegateField;

	private static readonly get_width_InjectedDelegate get_width_InjectedDelegateField;

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField;

	private static readonly get_pixelAspectRatioNumerator_InjectedDelegate get_pixelAspectRatioNumerator_InjectedDelegateField;

	private static readonly get_pixelAspectRatioDenominator_InjectedDelegate get_pixelAspectRatioDenominator_InjectedDelegateField;

	private static readonly get_audioTrackCount_InjectedDelegate get_audioTrackCount_InjectedDelegateField;

	private static readonly GetAudioLanguageCode_InjectedDelegate GetAudioLanguageCode_InjectedDelegateField;

	private static readonly GetAudioChannelCount_InjectedDelegate GetAudioChannelCount_InjectedDelegateField;

	private static readonly GetAudioSampleRate_InjectedDelegate GetAudioSampleRate_InjectedDelegateField;

	private static readonly GetControlledAudioTrackCount_InjectedDelegate GetControlledAudioTrackCount_InjectedDelegateField;

	private static readonly SetControlledAudioTrackCount_InjectedDelegate SetControlledAudioTrackCount_InjectedDelegateField;

	private static readonly EnableAudioTrack_InjectedDelegate EnableAudioTrack_InjectedDelegateField;

	private static readonly IsAudioTrackEnabled_InjectedDelegate IsAudioTrackEnabled_InjectedDelegateField;

	private static readonly get_audioOutputMode_InjectedDelegate get_audioOutputMode_InjectedDelegateField;

	private static readonly set_audioOutputMode_InjectedDelegate set_audioOutputMode_InjectedDelegateField;

	private static readonly get_canSetDirectAudioVolume_InjectedDelegate get_canSetDirectAudioVolume_InjectedDelegateField;

	private static readonly GetDirectAudioVolume_InjectedDelegate GetDirectAudioVolume_InjectedDelegateField;

	private static readonly SetDirectAudioVolume_InjectedDelegate SetDirectAudioVolume_InjectedDelegateField;

	private static readonly GetDirectAudioMute_InjectedDelegate GetDirectAudioMute_InjectedDelegateField;

	private static readonly SetDirectAudioMute_InjectedDelegate SetDirectAudioMute_InjectedDelegateField;

	private static readonly GetTargetAudioSource_InjectedDelegate GetTargetAudioSource_InjectedDelegateField;

	private static readonly SetTargetAudioSource_InjectedDelegate SetTargetAudioSource_InjectedDelegateField;

	private static readonly get_sendFrameReadyEvents_InjectedDelegate get_sendFrameReadyEvents_InjectedDelegateField;

	private static readonly set_sendFrameReadyEvents_InjectedDelegate set_sendFrameReadyEvents_InjectedDelegateField;

	public unsafe EventHandler prepareCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepareCompleted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepareCompleted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler loopPointReached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopPointReached);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopPointReached)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler started
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_started);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_started)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler frameDropped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameDropped);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameDropped)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ErrorEventHandler errorReceived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorReceived);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ErrorEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorReceived)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler seekCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seekCompleted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seekCompleted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TimeEventHandler clockResyncOccurred
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockResyncOccurred);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockResyncOccurred)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FrameReadyEventHandler frameReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameReady);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameReadyEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameReady)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe VideoSource source
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410735, RefRangeEnd = 1410736, XrefRangeStart = 1410730, XrefRangeEnd = 1410735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_source_Public_get_VideoSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(VideoSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1410741, RefRangeEnd = 1410743, XrefRangeStart = 1410736, XrefRangeEnd = 1410741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_source_Public_set_Void_VideoSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string url
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410750, RefRangeEnd = 1410751, XrefRangeStart = 1410743, XrefRangeEnd = 1410750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1410767, RefRangeEnd = 1410769, XrefRangeStart = 1410751, XrefRangeEnd = 1410767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe VideoClip clip
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410777, RefRangeEnd = 1410778, XrefRangeStart = 1410769, XrefRangeEnd = 1410777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VideoClip>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410786, RefRangeEnd = 1410787, XrefRangeStart = 1410778, XrefRangeEnd = 1410786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderTexture targetTexture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410795, RefRangeEnd = 1410796, XrefRangeStart = 1410787, XrefRangeEnd = 1410795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410804, RefRangeEnd = 1410805, XrefRangeStart = 1410796, XrefRangeEnd = 1410804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isPrepared
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410817, RefRangeEnd = 1410818, XrefRangeStart = 1410812, XrefRangeEnd = 1410817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPrepared_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isPaused
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410842, RefRangeEnd = 1410843, XrefRangeStart = 1410837, XrefRangeEnd = 1410842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe long frame
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410848, RefRangeEnd = 1410849, XrefRangeStart = 1410843, XrefRangeEnd = 1410848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frame_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410854, RefRangeEnd = 1410855, XrefRangeStart = 1410849, XrefRangeEnd = 1410854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frame_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double clockTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410860, RefRangeEnd = 1410861, XrefRangeStart = 1410855, XrefRangeEnd = 1410860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clockTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ulong frameCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410866, RefRangeEnd = 1410867, XrefRangeStart = 1410861, XrefRangeEnd = 1410866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameCount_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float frameRate
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410872, RefRangeEnd = 1410873, XrefRangeStart = 1410867, XrefRangeEnd = 1410872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double length
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410878, RefRangeEnd = 1410879, XrefRangeStart = 1410873, XrefRangeEnd = 1410878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public VideoTimeUpdateMode timeUpdateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_timeUpdateMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_timeUpdateMode_Injected(intPtr, value);
		}
	}

	public VideoRenderMode renderMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderMode_Injected(intPtr, value);
		}
	}

	public bool canSetTimeUpdateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetTimeUpdateMode_Injected(intPtr);
		}
	}

	public Camera targetCamera
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Camera>(get_targetCamera_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetCamera_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Renderer targetMaterialRenderer
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Renderer>(get_targetMaterialRenderer_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetMaterialRenderer_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe string targetMaterialProperty
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_targetMaterialProperty_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0028: Expected O, but got Ref
			//IL_0034: Expected O, but got Ref
			//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_targetMaterialProperty_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_targetMaterialProperty_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public VideoAspectRatio aspectRatio
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_aspectRatio_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_aspectRatio_Injected(intPtr, value);
		}
	}

	public float targetCameraAlpha
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_targetCameraAlpha_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetCameraAlpha_Injected(intPtr, value);
		}
	}

	public Video3DLayout targetCamera3DLayout
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_targetCamera3DLayout_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_targetCamera3DLayout_Injected(intPtr, value);
		}
	}

	public Texture texture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture>(get_texture_Injected(intPtr));
		}
	}

	public bool waitForFirstFrame
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_waitForFirstFrame_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_waitForFirstFrame_Injected(intPtr, value);
		}
	}

	public bool playOnAwake
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_playOnAwake_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_playOnAwake_Injected(intPtr, value);
		}
	}

	public bool isPlaying
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isPlaying_Injected(intPtr);
		}
	}

	public bool canSetTime
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetTime_Injected(intPtr);
		}
	}

	public double time
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_time_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_time_Injected(intPtr, value);
		}
	}

	public bool canStep
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canStep_Injected(intPtr);
		}
	}

	public bool canSetPlaybackSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetPlaybackSpeed_Injected(intPtr);
		}
	}

	public float playbackSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_playbackSpeed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_playbackSpeed_Injected(intPtr, value);
		}
	}

	public bool isLooping
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isLooping_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isLooping_Injected(intPtr, value);
		}
	}

	public bool canSetTimeSource
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetTimeSource_Injected(intPtr);
		}
	}

	public VideoTimeSource timeSource
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_timeSource_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_timeSource_Injected(intPtr, value);
		}
	}

	public VideoTimeReference timeReference
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_timeReference_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_timeReference_Injected(intPtr, value);
		}
	}

	public double externalReferenceTime
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_externalReferenceTime_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_externalReferenceTime_Injected(intPtr, value);
		}
	}

	public bool canSetSkipOnDrop
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetSkipOnDrop_Injected(intPtr);
		}
	}

	public bool skipOnDrop
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_skipOnDrop_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_skipOnDrop_Injected(intPtr, value);
		}
	}

	public uint width
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_width_Injected(intPtr);
		}
	}

	public uint height
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
	}

	public uint pixelAspectRatioNumerator
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pixelAspectRatioNumerator_Injected(intPtr);
		}
	}

	public uint pixelAspectRatioDenominator
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pixelAspectRatioDenominator_Injected(intPtr);
		}
	}

	public ushort audioTrackCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_audioTrackCount_Injected(intPtr);
		}
	}

	public static ushort controlledAudioTrackMaxCount => get_controlledAudioTrackMaxCountDelegateField();

	public ushort controlledAudioTrackCount
	{
		get
		{
			return GetControlledAudioTrackCount();
		}
		set
		{
			int num = controlledAudioTrackMaxCount;
			if (value > num)
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Cannot control more than {0} tracks.", (Il2CppSystem.Object)(object)num), "value");
			}
			SetControlledAudioTrackCount(value);
		}
	}

	public VideoAudioOutputMode audioOutputMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_audioOutputMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_audioOutputMode_Injected(intPtr, value);
		}
	}

	public bool canSetDirectAudioVolume
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_canSetDirectAudioVolume_Injected(intPtr);
		}
	}

	public bool sendFrameReadyEvents
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sendFrameReadyEvents_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sendFrameReadyEvents_Injected(intPtr, value);
		}
	}

	static VideoPlayer()
	{
		Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Video", "VideoPlayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr);
		NativeFieldInfoPtr_prepareCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "prepareCompleted");
		NativeFieldInfoPtr_loopPointReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "loopPointReached");
		NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "started");
		NativeFieldInfoPtr_frameDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "frameDropped");
		NativeFieldInfoPtr_errorReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "errorReceived");
		NativeFieldInfoPtr_seekCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "seekCompleted");
		NativeFieldInfoPtr_clockResyncOccurred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "clockResyncOccurred");
		NativeFieldInfoPtr_frameReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, "frameReady");
		NativeMethodInfoPtr_get_source_Public_get_VideoSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_set_source_Public_set_Void_VideoSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_get_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_set_url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_clip_Public_get_VideoClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_set_clip_Public_set_Void_VideoClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_get_isPrepared_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_get_frame_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_set_frame_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_clockTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_frameCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_frameRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_length_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_add_prepareCompleted_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_remove_prepareCompleted_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_add_loopPointReached_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_remove_loopPointReached_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_add_started_Public_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_remove_started_Public_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_add_errorReceived_Public_add_Void_ErrorEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_remove_errorReceived_Public_rem_Void_ErrorEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_get_source_Injected_Private_Static_VideoSource_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_set_source_Injected_Private_Static_Void_IntPtr_VideoSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_get_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_set_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_get_clip_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_set_clip_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_Prepare_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_isPrepared_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_get_isPaused_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_frame_Injected_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_set_frame_Injected_Private_Static_Void_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_clockTime_Injected_Private_Static_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_get_frameCount_Injected_Private_Static_UInt64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_frameRate_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_get_length_Injected_Private_Static_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr, 100663356);
		get_controlledAudioTrackMaxCountDelegateField = IL2CPP.ResolveICall<get_controlledAudioTrackMaxCountDelegate>("UnityEngine.Video.VideoPlayer::get_controlledAudioTrackMaxCount");
		get_timeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_timeUpdateMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_timeUpdateMode_Injected");
		set_timeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<set_timeUpdateMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_timeUpdateMode_Injected");
		get_renderMode_InjectedDelegateField = IL2CPP.ResolveICall<get_renderMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_renderMode_Injected");
		set_renderMode_InjectedDelegateField = IL2CPP.ResolveICall<set_renderMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_renderMode_Injected");
		get_canSetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetTimeUpdateMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetTimeUpdateMode_Injected");
		get_targetCamera_InjectedDelegateField = IL2CPP.ResolveICall<get_targetCamera_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_targetCamera_Injected");
		set_targetCamera_InjectedDelegateField = IL2CPP.ResolveICall<set_targetCamera_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_targetCamera_Injected");
		get_targetMaterialRenderer_InjectedDelegateField = IL2CPP.ResolveICall<get_targetMaterialRenderer_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_targetMaterialRenderer_Injected");
		set_targetMaterialRenderer_InjectedDelegateField = IL2CPP.ResolveICall<set_targetMaterialRenderer_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_targetMaterialRenderer_Injected");
		get_targetMaterialProperty_InjectedDelegateField = IL2CPP.ResolveICall<get_targetMaterialProperty_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_targetMaterialProperty_Injected");
		set_targetMaterialProperty_InjectedDelegateField = IL2CPP.ResolveICall<set_targetMaterialProperty_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_targetMaterialProperty_Injected");
		get_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<get_aspectRatio_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_aspectRatio_Injected");
		set_aspectRatio_InjectedDelegateField = IL2CPP.ResolveICall<set_aspectRatio_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_aspectRatio_Injected");
		get_targetCameraAlpha_InjectedDelegateField = IL2CPP.ResolveICall<get_targetCameraAlpha_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_targetCameraAlpha_Injected");
		set_targetCameraAlpha_InjectedDelegateField = IL2CPP.ResolveICall<set_targetCameraAlpha_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_targetCameraAlpha_Injected");
		get_targetCamera3DLayout_InjectedDelegateField = IL2CPP.ResolveICall<get_targetCamera3DLayout_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_targetCamera3DLayout_Injected");
		set_targetCamera3DLayout_InjectedDelegateField = IL2CPP.ResolveICall<set_targetCamera3DLayout_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_targetCamera3DLayout_Injected");
		get_texture_InjectedDelegateField = IL2CPP.ResolveICall<get_texture_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_texture_Injected");
		get_waitForFirstFrame_InjectedDelegateField = IL2CPP.ResolveICall<get_waitForFirstFrame_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_waitForFirstFrame_Injected");
		set_waitForFirstFrame_InjectedDelegateField = IL2CPP.ResolveICall<set_waitForFirstFrame_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_waitForFirstFrame_Injected");
		get_playOnAwake_InjectedDelegateField = IL2CPP.ResolveICall<get_playOnAwake_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_playOnAwake_Injected");
		set_playOnAwake_InjectedDelegateField = IL2CPP.ResolveICall<set_playOnAwake_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_playOnAwake_Injected");
		get_isPlaying_InjectedDelegateField = IL2CPP.ResolveICall<get_isPlaying_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_isPlaying_Injected");
		get_canSetTime_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetTime_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetTime_Injected");
		get_time_InjectedDelegateField = IL2CPP.ResolveICall<get_time_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_time_Injected");
		set_time_InjectedDelegateField = IL2CPP.ResolveICall<set_time_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_time_Injected");
		get_canStep_InjectedDelegateField = IL2CPP.ResolveICall<get_canStep_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canStep_Injected");
		StepForward_InjectedDelegateField = IL2CPP.ResolveICall<StepForward_InjectedDelegate>("UnityEngine.Video.VideoPlayer::StepForward_Injected");
		get_canSetPlaybackSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetPlaybackSpeed_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetPlaybackSpeed_Injected");
		get_playbackSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_playbackSpeed_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_playbackSpeed_Injected");
		set_playbackSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_playbackSpeed_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_playbackSpeed_Injected");
		get_isLooping_InjectedDelegateField = IL2CPP.ResolveICall<get_isLooping_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_isLooping_Injected");
		set_isLooping_InjectedDelegateField = IL2CPP.ResolveICall<set_isLooping_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_isLooping_Injected");
		get_canSetTimeSource_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetTimeSource_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetTimeSource_Injected");
		get_timeSource_InjectedDelegateField = IL2CPP.ResolveICall<get_timeSource_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_timeSource_Injected");
		set_timeSource_InjectedDelegateField = IL2CPP.ResolveICall<set_timeSource_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_timeSource_Injected");
		get_timeReference_InjectedDelegateField = IL2CPP.ResolveICall<get_timeReference_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_timeReference_Injected");
		set_timeReference_InjectedDelegateField = IL2CPP.ResolveICall<set_timeReference_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_timeReference_Injected");
		get_externalReferenceTime_InjectedDelegateField = IL2CPP.ResolveICall<get_externalReferenceTime_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_externalReferenceTime_Injected");
		set_externalReferenceTime_InjectedDelegateField = IL2CPP.ResolveICall<set_externalReferenceTime_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_externalReferenceTime_Injected");
		get_canSetSkipOnDrop_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetSkipOnDrop_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetSkipOnDrop_Injected");
		get_skipOnDrop_InjectedDelegateField = IL2CPP.ResolveICall<get_skipOnDrop_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_skipOnDrop_Injected");
		set_skipOnDrop_InjectedDelegateField = IL2CPP.ResolveICall<set_skipOnDrop_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_skipOnDrop_Injected");
		get_width_InjectedDelegateField = IL2CPP.ResolveICall<get_width_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_width_Injected");
		get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_height_Injected");
		get_pixelAspectRatioNumerator_InjectedDelegateField = IL2CPP.ResolveICall<get_pixelAspectRatioNumerator_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_pixelAspectRatioNumerator_Injected");
		get_pixelAspectRatioDenominator_InjectedDelegateField = IL2CPP.ResolveICall<get_pixelAspectRatioDenominator_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_pixelAspectRatioDenominator_Injected");
		get_audioTrackCount_InjectedDelegateField = IL2CPP.ResolveICall<get_audioTrackCount_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_audioTrackCount_Injected");
		GetAudioLanguageCode_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioLanguageCode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetAudioLanguageCode_Injected");
		GetAudioChannelCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioChannelCount_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetAudioChannelCount_Injected");
		GetAudioSampleRate_InjectedDelegateField = IL2CPP.ResolveICall<GetAudioSampleRate_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetAudioSampleRate_Injected");
		GetControlledAudioTrackCount_InjectedDelegateField = IL2CPP.ResolveICall<GetControlledAudioTrackCount_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetControlledAudioTrackCount_Injected");
		SetControlledAudioTrackCount_InjectedDelegateField = IL2CPP.ResolveICall<SetControlledAudioTrackCount_InjectedDelegate>("UnityEngine.Video.VideoPlayer::SetControlledAudioTrackCount_Injected");
		EnableAudioTrack_InjectedDelegateField = IL2CPP.ResolveICall<EnableAudioTrack_InjectedDelegate>("UnityEngine.Video.VideoPlayer::EnableAudioTrack_Injected");
		IsAudioTrackEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsAudioTrackEnabled_InjectedDelegate>("UnityEngine.Video.VideoPlayer::IsAudioTrackEnabled_Injected");
		get_audioOutputMode_InjectedDelegateField = IL2CPP.ResolveICall<get_audioOutputMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_audioOutputMode_Injected");
		set_audioOutputMode_InjectedDelegateField = IL2CPP.ResolveICall<set_audioOutputMode_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_audioOutputMode_Injected");
		get_canSetDirectAudioVolume_InjectedDelegateField = IL2CPP.ResolveICall<get_canSetDirectAudioVolume_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_canSetDirectAudioVolume_Injected");
		GetDirectAudioVolume_InjectedDelegateField = IL2CPP.ResolveICall<GetDirectAudioVolume_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetDirectAudioVolume_Injected");
		SetDirectAudioVolume_InjectedDelegateField = IL2CPP.ResolveICall<SetDirectAudioVolume_InjectedDelegate>("UnityEngine.Video.VideoPlayer::SetDirectAudioVolume_Injected");
		GetDirectAudioMute_InjectedDelegateField = IL2CPP.ResolveICall<GetDirectAudioMute_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetDirectAudioMute_Injected");
		SetDirectAudioMute_InjectedDelegateField = IL2CPP.ResolveICall<SetDirectAudioMute_InjectedDelegate>("UnityEngine.Video.VideoPlayer::SetDirectAudioMute_Injected");
		GetTargetAudioSource_InjectedDelegateField = IL2CPP.ResolveICall<GetTargetAudioSource_InjectedDelegate>("UnityEngine.Video.VideoPlayer::GetTargetAudioSource_Injected");
		SetTargetAudioSource_InjectedDelegateField = IL2CPP.ResolveICall<SetTargetAudioSource_InjectedDelegate>("UnityEngine.Video.VideoPlayer::SetTargetAudioSource_Injected");
		get_sendFrameReadyEvents_InjectedDelegateField = IL2CPP.ResolveICall<get_sendFrameReadyEvents_InjectedDelegate>("UnityEngine.Video.VideoPlayer::get_sendFrameReadyEvents_Injected");
		set_sendFrameReadyEvents_InjectedDelegateField = IL2CPP.ResolveICall<set_sendFrameReadyEvents_InjectedDelegate>("UnityEngine.Video.VideoPlayer::set_sendFrameReadyEvents_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1410810, RefRangeEnd = 1410812, XrefRangeStart = 1410805, XrefRangeEnd = 1410810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1410823, RefRangeEnd = 1410825, XrefRangeStart = 1410818, XrefRangeEnd = 1410823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1410830, RefRangeEnd = 1410831, XrefRangeStart = 1410825, XrefRangeEnd = 1410830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1410836, RefRangeEnd = 1410837, XrefRangeStart = 1410831, XrefRangeEnd = 1410836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1410883, RefRangeEnd = 1410886, XrefRangeStart = 1410879, XrefRangeEnd = 1410883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_prepareCompleted(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_prepareCompleted_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1410890, RefRangeEnd = 1410891, XrefRangeStart = 1410886, XrefRangeEnd = 1410890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_prepareCompleted(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_prepareCompleted_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1410895, RefRangeEnd = 1410897, XrefRangeStart = 1410891, XrefRangeEnd = 1410895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_loopPointReached(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_loopPointReached_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410897, XrefRangeEnd = 1410901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_loopPointReached(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_loopPointReached_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1410905, RefRangeEnd = 1410907, XrefRangeStart = 1410901, XrefRangeEnd = 1410905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_started(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_started_Public_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410907, XrefRangeEnd = 1410911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_started(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_started_Public_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1410915, RefRangeEnd = 1410917, XrefRangeStart = 1410911, XrefRangeEnd = 1410915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_errorReceived(ErrorEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_errorReceived_Public_add_Void_ErrorEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410917, XrefRangeEnd = 1410921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_errorReceived(ErrorEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_errorReceived_Public_rem_Void_ErrorEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokePrepareCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIdx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeFrameReadyCallback_Internal_Private_Static_Void_VideoPlayer_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeLoopPointReachedCallback_Internal_Private_Static_Void_VideoPlayer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeStartedCallback_Internal(VideoPlayer source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeStartedCallback_Internal_Private_Static_Void_VideoPlayer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeFrameDroppedCallback_Internal_Private_Static_Void_VideoPlayer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(errorStr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeErrorReceivedCallback_Internal_Private_Static_Void_VideoPlayer_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSeekCompletedCallback_Internal_Private_Static_Void_VideoPlayer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seconds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeClockResyncOccurredCallback_Internal_Private_Static_Void_VideoPlayer_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VideoPlayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoPlayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410921, XrefRangeEnd = 1410923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VideoSource get_source_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_source_Injected_Private_Static_VideoSource_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VideoSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410923, XrefRangeEnd = 1410925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_source_Injected(System.IntPtr _unity_self, VideoSource value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(VideoSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_source_Injected_Private_Static_Void_IntPtr_VideoSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410925, XrefRangeEnd = 1410927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_url_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410927, XrefRangeEnd = 1410929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_url_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_url_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410929, XrefRangeEnd = 1410931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_clip_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clip_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410931, XrefRangeEnd = 1410933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_clip_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clip_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410933, XrefRangeEnd = 1410935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_targetTexture_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetTexture_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410935, XrefRangeEnd = 1410937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_targetTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetTexture_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410937, XrefRangeEnd = 1410939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Prepare_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410939, XrefRangeEnd = 1410941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isPrepared_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPrepared_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410941, XrefRangeEnd = 1410943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Play_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410943, XrefRangeEnd = 1410945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Pause_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410945, XrefRangeEnd = 1410947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Stop_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410947, XrefRangeEnd = 1410949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isPaused_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPaused_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410949, XrefRangeEnd = 1410951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long get_frame_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frame_Injected_Private_Static_Int64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410951, XrefRangeEnd = 1410953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_frame_Injected(System.IntPtr _unity_self, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frame_Injected_Private_Static_Void_IntPtr_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410953, XrefRangeEnd = 1410955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double get_clockTime_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clockTime_Injected_Private_Static_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410955, XrefRangeEnd = 1410957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong get_frameCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameCount_Injected_Private_Static_UInt64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410957, XrefRangeEnd = 1410959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_frameRate_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameRate_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410959, XrefRangeEnd = 1410961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double get_length_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Injected_Private_Static_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public VideoPlayer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void StepForward()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		StepForward_Injected(intPtr);
	}

	public string GetAudioLanguageCode(ushort trackIndex)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetAudioLanguageCode_Injected(intPtr, trackIndex, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public ushort GetAudioChannelCount(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAudioChannelCount_Injected(intPtr, trackIndex);
	}

	public uint GetAudioSampleRate(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAudioSampleRate_Injected(intPtr, trackIndex);
	}

	public ushort GetControlledAudioTrackCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetControlledAudioTrackCount_Injected(intPtr);
	}

	public void SetControlledAudioTrackCount(ushort value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetControlledAudioTrackCount_Injected(intPtr, value);
	}

	public void EnableAudioTrack(ushort trackIndex, bool enabled)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EnableAudioTrack_Injected(intPtr, trackIndex, enabled);
	}

	public bool IsAudioTrackEnabled(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsAudioTrackEnabled_Injected(intPtr, trackIndex);
	}

	public float GetDirectAudioVolume(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDirectAudioVolume_Injected(intPtr, trackIndex);
	}

	public void SetDirectAudioVolume(ushort trackIndex, float volume)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDirectAudioVolume_Injected(intPtr, trackIndex, volume);
	}

	public bool GetDirectAudioMute(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDirectAudioMute_Injected(intPtr, trackIndex);
	}

	public void SetDirectAudioMute(ushort trackIndex, bool mute)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDirectAudioMute_Injected(intPtr, trackIndex, mute);
	}

	public AudioSource GetTargetAudioSource(ushort trackIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<AudioSource>(GetTargetAudioSource_Injected(intPtr, trackIndex));
	}

	public void SetTargetAudioSource(ushort trackIndex, AudioSource source)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTargetAudioSource_Injected(intPtr, trackIndex, MarshalledUnityObject.Marshal(source));
	}

	[SpecialName]
	public void add_frameDropped(EventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_frameDropped(EventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_seekCompleted(EventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_seekCompleted(EventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_clockResyncOccurred(TimeEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_clockResyncOccurred(TimeEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_frameReady(FrameReadyEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_frameReady(FrameReadyEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static VideoTimeUpdateMode get_timeUpdateMode_Injected(System.IntPtr _unity_self)
	{
		return get_timeUpdateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_timeUpdateMode_Injected(System.IntPtr _unity_self, VideoTimeUpdateMode value)
	{
		set_timeUpdateMode_InjectedDelegateField(_unity_self, value);
	}

	public static VideoRenderMode get_renderMode_Injected(System.IntPtr _unity_self)
	{
		return get_renderMode_InjectedDelegateField(_unity_self);
	}

	public static void set_renderMode_Injected(System.IntPtr _unity_self, VideoRenderMode value)
	{
		set_renderMode_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_canSetTimeUpdateMode_Injected(System.IntPtr _unity_self)
	{
		return get_canSetTimeUpdateMode_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_targetCamera_Injected(System.IntPtr _unity_self)
	{
		return get_targetCamera_InjectedDelegateField(_unity_self);
	}

	public static void set_targetCamera_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_targetCamera_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_targetMaterialRenderer_Injected(System.IntPtr _unity_self)
	{
		return get_targetMaterialRenderer_InjectedDelegateField(_unity_self);
	}

	public static void set_targetMaterialRenderer_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_targetMaterialRenderer_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_targetMaterialProperty_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_targetMaterialProperty_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_targetMaterialProperty_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_targetMaterialProperty_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static VideoAspectRatio get_aspectRatio_Injected(System.IntPtr _unity_self)
	{
		return get_aspectRatio_InjectedDelegateField(_unity_self);
	}

	public static void set_aspectRatio_Injected(System.IntPtr _unity_self, VideoAspectRatio value)
	{
		set_aspectRatio_InjectedDelegateField(_unity_self, value);
	}

	public static float get_targetCameraAlpha_Injected(System.IntPtr _unity_self)
	{
		return get_targetCameraAlpha_InjectedDelegateField(_unity_self);
	}

	public static void set_targetCameraAlpha_Injected(System.IntPtr _unity_self, float value)
	{
		set_targetCameraAlpha_InjectedDelegateField(_unity_self, value);
	}

	public static Video3DLayout get_targetCamera3DLayout_Injected(System.IntPtr _unity_self)
	{
		return get_targetCamera3DLayout_InjectedDelegateField(_unity_self);
	}

	public static void set_targetCamera3DLayout_Injected(System.IntPtr _unity_self, Video3DLayout value)
	{
		set_targetCamera3DLayout_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_texture_Injected(System.IntPtr _unity_self)
	{
		return get_texture_InjectedDelegateField(_unity_self);
	}

	public static bool get_waitForFirstFrame_Injected(System.IntPtr _unity_self)
	{
		return get_waitForFirstFrame_InjectedDelegateField(_unity_self);
	}

	public static void set_waitForFirstFrame_Injected(System.IntPtr _unity_self, bool value)
	{
		set_waitForFirstFrame_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_playOnAwake_Injected(System.IntPtr _unity_self)
	{
		return get_playOnAwake_InjectedDelegateField(_unity_self);
	}

	public static void set_playOnAwake_Injected(System.IntPtr _unity_self, bool value)
	{
		set_playOnAwake_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isPlaying_Injected(System.IntPtr _unity_self)
	{
		return get_isPlaying_InjectedDelegateField(_unity_self);
	}

	public static bool get_canSetTime_Injected(System.IntPtr _unity_self)
	{
		return get_canSetTime_InjectedDelegateField(_unity_self);
	}

	public static double get_time_Injected(System.IntPtr _unity_self)
	{
		return get_time_InjectedDelegateField(_unity_self);
	}

	public static void set_time_Injected(System.IntPtr _unity_self, double value)
	{
		set_time_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_canStep_Injected(System.IntPtr _unity_self)
	{
		return get_canStep_InjectedDelegateField(_unity_self);
	}

	public static void StepForward_Injected(System.IntPtr _unity_self)
	{
		StepForward_InjectedDelegateField(_unity_self);
	}

	public static bool get_canSetPlaybackSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_canSetPlaybackSpeed_InjectedDelegateField(_unity_self);
	}

	public static float get_playbackSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_playbackSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_playbackSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		set_playbackSpeed_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isLooping_Injected(System.IntPtr _unity_self)
	{
		return get_isLooping_InjectedDelegateField(_unity_self);
	}

	public static void set_isLooping_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isLooping_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_canSetTimeSource_Injected(System.IntPtr _unity_self)
	{
		return get_canSetTimeSource_InjectedDelegateField(_unity_self);
	}

	public static VideoTimeSource get_timeSource_Injected(System.IntPtr _unity_self)
	{
		return get_timeSource_InjectedDelegateField(_unity_self);
	}

	public static void set_timeSource_Injected(System.IntPtr _unity_self, VideoTimeSource value)
	{
		set_timeSource_InjectedDelegateField(_unity_self, value);
	}

	public static VideoTimeReference get_timeReference_Injected(System.IntPtr _unity_self)
	{
		return get_timeReference_InjectedDelegateField(_unity_self);
	}

	public static void set_timeReference_Injected(System.IntPtr _unity_self, VideoTimeReference value)
	{
		set_timeReference_InjectedDelegateField(_unity_self, value);
	}

	public static double get_externalReferenceTime_Injected(System.IntPtr _unity_self)
	{
		return get_externalReferenceTime_InjectedDelegateField(_unity_self);
	}

	public static void set_externalReferenceTime_Injected(System.IntPtr _unity_self, double value)
	{
		set_externalReferenceTime_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_canSetSkipOnDrop_Injected(System.IntPtr _unity_self)
	{
		return get_canSetSkipOnDrop_InjectedDelegateField(_unity_self);
	}

	public static bool get_skipOnDrop_Injected(System.IntPtr _unity_self)
	{
		return get_skipOnDrop_InjectedDelegateField(_unity_self);
	}

	public static void set_skipOnDrop_Injected(System.IntPtr _unity_self, bool value)
	{
		set_skipOnDrop_InjectedDelegateField(_unity_self, value);
	}

	public static uint get_width_Injected(System.IntPtr _unity_self)
	{
		return get_width_InjectedDelegateField(_unity_self);
	}

	public static uint get_height_Injected(System.IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static uint get_pixelAspectRatioNumerator_Injected(System.IntPtr _unity_self)
	{
		return get_pixelAspectRatioNumerator_InjectedDelegateField(_unity_self);
	}

	public static uint get_pixelAspectRatioDenominator_Injected(System.IntPtr _unity_self)
	{
		return get_pixelAspectRatioDenominator_InjectedDelegateField(_unity_self);
	}

	public static ushort get_audioTrackCount_Injected(System.IntPtr _unity_self)
	{
		return get_audioTrackCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetAudioLanguageCode_Injected(System.IntPtr _unity_self, ushort trackIndex, out ManagedSpanWrapper ret)
	{
		GetAudioLanguageCode_InjectedDelegateField(_unity_self, trackIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public static ushort GetAudioChannelCount_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetAudioChannelCount_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static uint GetAudioSampleRate_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetAudioSampleRate_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static ushort GetControlledAudioTrackCount_Injected(System.IntPtr _unity_self)
	{
		return GetControlledAudioTrackCount_InjectedDelegateField(_unity_self);
	}

	public static void SetControlledAudioTrackCount_Injected(System.IntPtr _unity_self, ushort value)
	{
		SetControlledAudioTrackCount_InjectedDelegateField(_unity_self, value);
	}

	public static void EnableAudioTrack_Injected(System.IntPtr _unity_self, ushort trackIndex, bool enabled)
	{
		EnableAudioTrack_InjectedDelegateField(_unity_self, trackIndex, enabled);
	}

	public static bool IsAudioTrackEnabled_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return IsAudioTrackEnabled_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static VideoAudioOutputMode get_audioOutputMode_Injected(System.IntPtr _unity_self)
	{
		return get_audioOutputMode_InjectedDelegateField(_unity_self);
	}

	public static void set_audioOutputMode_Injected(System.IntPtr _unity_self, VideoAudioOutputMode value)
	{
		set_audioOutputMode_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_canSetDirectAudioVolume_Injected(System.IntPtr _unity_self)
	{
		return get_canSetDirectAudioVolume_InjectedDelegateField(_unity_self);
	}

	public static float GetDirectAudioVolume_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetDirectAudioVolume_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static void SetDirectAudioVolume_Injected(System.IntPtr _unity_self, ushort trackIndex, float volume)
	{
		SetDirectAudioVolume_InjectedDelegateField(_unity_self, trackIndex, volume);
	}

	public static bool GetDirectAudioMute_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetDirectAudioMute_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static void SetDirectAudioMute_Injected(System.IntPtr _unity_self, ushort trackIndex, bool mute)
	{
		SetDirectAudioMute_InjectedDelegateField(_unity_self, trackIndex, mute);
	}

	public static System.IntPtr GetTargetAudioSource_Injected(System.IntPtr _unity_self, ushort trackIndex)
	{
		return GetTargetAudioSource_InjectedDelegateField(_unity_self, trackIndex);
	}

	public static void SetTargetAudioSource_Injected(System.IntPtr _unity_self, ushort trackIndex, System.IntPtr source)
	{
		SetTargetAudioSource_InjectedDelegateField(_unity_self, trackIndex, source);
	}

	public static bool get_sendFrameReadyEvents_Injected(System.IntPtr _unity_self)
	{
		return get_sendFrameReadyEvents_InjectedDelegateField(_unity_self);
	}

	public static void set_sendFrameReadyEvents_Injected(System.IntPtr _unity_self, bool value)
	{
		set_sendFrameReadyEvents_InjectedDelegateField(_unity_self, value);
	}
}
