using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
public class ActivationTrack : TrackAsset
{
	[OriginalName("Unity.Timeline.dll", "", "PostPlaybackState")]
	public enum PostPlaybackState
	{
		Active,
		Inactive,
		Revert,
		LeaveAsIs
	}

	private static readonly IntPtr NativeFieldInfoPtr_m_PostPlaybackState;

	private static readonly IntPtr NativeFieldInfoPtr_m_ActivationMixer;

	private static readonly IntPtr NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PostPlaybackState m_PostPlaybackState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostPlaybackState);
			return *(PostPlaybackState*)num;
		}
		set
		{
			*(PostPlaybackState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostPlaybackState)) = value;
		}
	}

	public unsafe ActivationMixerPlayable m_ActivationMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActivationMixer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActivationMixerPlayable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActivationMixer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PostPlaybackState postPlaybackState
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PostPlaybackState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ActivationTrack()
	{
		Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ActivationTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr);
		NativeFieldInfoPtr_m_PostPlaybackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, "m_PostPlaybackState");
		NativeFieldInfoPtr_m_ActivationMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, "m_ActivationMixer");
		NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_get_postPlaybackState_Public_get_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_set_postPlaybackState_Public_set_Void_PostPlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr, 100663315);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135199, XrefRangeEnd = 1135202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CanCompileClips()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanCompileClips_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135202, XrefRangeEnd = 1135218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&graph);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void UpdateTrackMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTrackMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135218, XrefRangeEnd = 1135228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)driver);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GatherProperties_Public_Virtual_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135228, XrefRangeEnd = 1135232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCreateClip(TimelineClip clip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCreateClip_Protected_Virtual_Void_TimelineClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135232, XrefRangeEnd = 1135236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActivationTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivationTrack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ActivationTrack(IntPtr pointer)
		: base(pointer)
	{
	}
}
