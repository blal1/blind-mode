using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class ActivationMixerPlayable : PlayableBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_PostPlaybackState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundGameObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActivationTrack.PostPlaybackState m_PostPlaybackState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostPlaybackState);
			return *(ActivationTrack.PostPlaybackState*)num;
		}
		set
		{
			*(ActivationTrack.PostPlaybackState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostPlaybackState)) = value;
		}
	}

	public unsafe bool m_BoundGameObjectInitialStateIsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive)) = value;
		}
	}

	public unsafe GameObject m_BoundGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundGameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ActivationTrack.PostPlaybackState postPlaybackState
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ActivationTrack.PostPlaybackState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ActivationMixerPlayable()
	{
		Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ActivationMixerPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_PostPlaybackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_PostPlaybackState");
		NativeFieldInfoPtr_m_BoundGameObjectInitialStateIsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_BoundGameObjectInitialStateIsActive");
		NativeFieldInfoPtr_m_BoundGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, "m_BoundGameObject");
		NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr, 100663304);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135159, XrefRangeEnd = 1135165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_ActivationMixerPlayable_PlayableGraph_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<ActivationMixerPlayable>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135165, XrefRangeEnd = 1135170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPlayableDestroy(Playable playable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135170, XrefRangeEnd = 1135195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActivationMixerPlayable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivationMixerPlayable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ActivationMixerPlayable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
