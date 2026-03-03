using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Il2CppSpine.Unity.Playables;

public class SpineAnimationStateGraphicTrack : TrackAsset
{
	private static readonly IntPtr NativeFieldInfoPtr_trackIndex;

	private static readonly IntPtr NativeFieldInfoPtr_unscaledTime;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int trackIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackIndex)) = value;
		}
	}

	public unsafe bool unscaledTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unscaledTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unscaledTime)) = value;
		}
	}

	static SpineAnimationStateGraphicTrack()
	{
		Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-timeline.dll", "Spine.Unity.Playables", "SpineAnimationStateGraphicTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr);
		NativeFieldInfoPtr_trackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr, "trackIndex");
		NativeFieldInfoPtr_unscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr, "unscaledTime");
		NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr, 100663329);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849683, XrefRangeEnd = 849721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849721, XrefRangeEnd = 849725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineAnimationStateGraphicTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineAnimationStateGraphicTrack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineAnimationStateGraphicTrack(IntPtr pointer)
		: base(pointer)
	{
	}
}
