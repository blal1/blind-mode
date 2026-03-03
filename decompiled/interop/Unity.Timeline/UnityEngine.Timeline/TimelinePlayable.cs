using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class TimelinePlayable : PlayableBehaviour
{
	public sealed class TrackCacheManager : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_trackCache;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_AnimationTrack_IReadOnlyList_1_RuntimeElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrackAssetsFromRuntimeElements_Private_Void_IReadOnlyList_1_RuntimeElement_0;

		public unsafe HashSet<AnimationTrack> trackCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackCache);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<AnimationTrack>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static TrackCacheManager()
		{
			Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "TrackCacheManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr);
			NativeFieldInfoPtr_trackCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr, "trackCache");
			NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_AnimationTrack_IReadOnlyList_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr, 100664111);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr, 100664112);
			NativeMethodInfoPtr_GetTrackAssetsFromRuntimeElements_Private_Void_IReadOnlyList_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr, 100664113);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141277, XrefRangeEnd = 1141279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackCacheManager(HashSet<AnimationTrack> cache, IReadOnlyList<RuntimeElement> activeRuntimeElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cache);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeRuntimeElements);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_AnimationTrack_IReadOnlyList_1_RuntimeElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141279, XrefRangeEnd = 1141283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1141299, RefRangeEnd = 1141301, XrefRangeStart = 1141283, XrefRangeEnd = 1141299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTrackAssetsFromRuntimeElements(IReadOnlyList<RuntimeElement> activeRuntimeElements)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeRuntimeElements);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTrackAssetsFromRuntimeElements_Private_Void_IReadOnlyList_1_RuntimeElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TrackCacheManager(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public TrackCacheManager()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackCacheManager>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CreateTimelineGraphMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CreateTimelineTrackMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CreateTimelineTrackOutputsMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_findActiveClipsMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SetClipsLocalTimeMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntervalTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveClips;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentListOfActiveClips;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveBit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayableCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_muteAudioScrubbing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EvaluateCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AlwaysEvaluateCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceEvaluateNextEvaluate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InvokedThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveTracksToEvaluateCache;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayableOutputCallbacks_Private_Void_AnimationTrack_PlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOutputWeightProcessor_Private_Void_AnimationTrack_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEvaluateCallback_Private_Void_AnimationTrack_ITimelineEvaluateCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOutputCallbacks_Private_Void_IReadOnlyList_1_RuntimeElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCallbackList_Private_Boolean_AnimationTrack_byref_List_1_ITimelineEvaluateCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ProfilerMarker k_CreateTimelineGraphMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CreateTimelineGraphMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CreateTimelineGraphMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_CreateTimelineTrackMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CreateTimelineTrackMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CreateTimelineTrackMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_CreateTimelineTrackOutputsMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CreateTimelineTrackOutputsMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CreateTimelineTrackOutputsMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker m_findActiveClipsMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_findActiveClipsMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_findActiveClipsMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker m_SetClipsLocalTimeMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_SetClipsLocalTimeMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_SetClipsLocalTimeMarker, (void*)(&value));
		}
	}

	public unsafe IntervalTree<RuntimeElement> m_IntervalTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntervalTree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IntervalTree<RuntimeElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntervalTree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<RuntimeElement> m_ActiveClips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveClips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RuntimeElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveClips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<RuntimeElement> m_CurrentListOfActiveClips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentListOfActiveClips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RuntimeElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentListOfActiveClips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_ActiveBit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveBit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveBit)) = value;
		}
	}

	public unsafe Dictionary<TrackAsset, Playable> m_PlayableCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayableCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TrackAsset, Playable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayableCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool muteAudioScrubbing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_muteAudioScrubbing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_muteAudioScrubbing, (void*)(&value));
		}
	}

	public unsafe Dictionary<AnimationTrack, List<ITimelineEvaluateCallback>> m_EvaluateCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EvaluateCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AnimationTrack, List<ITimelineEvaluateCallback>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EvaluateCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ITimelineEvaluateCallback> m_AlwaysEvaluateCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AlwaysEvaluateCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ITimelineEvaluateCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AlwaysEvaluateCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<ITimelineEvaluateCallback> m_ForceEvaluateNextEvaluate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceEvaluateNextEvaluate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ITimelineEvaluateCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceEvaluateNextEvaluate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<ITimelineEvaluateCallback> m_InvokedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InvokedThisFrame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ITimelineEvaluateCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InvokedThisFrame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<AnimationTrack> m_ActiveTracksToEvaluateCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveTracksToEvaluateCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<AnimationTrack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveTracksToEvaluateCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TimelinePlayable()
	{
		Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelinePlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr);
		NativeFieldInfoPtr_k_CreateTimelineGraphMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "k_CreateTimelineGraphMarker");
		NativeFieldInfoPtr_k_CreateTimelineTrackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "k_CreateTimelineTrackMarker");
		NativeFieldInfoPtr_k_CreateTimelineTrackOutputsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "k_CreateTimelineTrackOutputsMarker");
		NativeFieldInfoPtr_m_findActiveClipsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_findActiveClipsMarker");
		NativeFieldInfoPtr_m_SetClipsLocalTimeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_SetClipsLocalTimeMarker");
		NativeFieldInfoPtr_m_IntervalTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_IntervalTree");
		NativeFieldInfoPtr_m_ActiveClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ActiveClips");
		NativeFieldInfoPtr_m_CurrentListOfActiveClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_CurrentListOfActiveClips");
		NativeFieldInfoPtr_m_ActiveBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ActiveBit");
		NativeFieldInfoPtr_m_PlayableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_PlayableCache");
		NativeFieldInfoPtr_muteAudioScrubbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "muteAudioScrubbing");
		NativeFieldInfoPtr_m_EvaluateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_EvaluateCallbacks");
		NativeFieldInfoPtr_m_AlwaysEvaluateCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_AlwaysEvaluateCallbacks");
		NativeFieldInfoPtr_m_ForceEvaluateNextEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ForceEvaluateNextEvaluate");
		NativeFieldInfoPtr_m_InvokedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_InvokedThisFrame");
		NativeFieldInfoPtr_m_ActiveTracksToEvaluateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, "m_ActiveTracksToEvaluateCache");
		NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_AddPlayableOutputCallbacks_Private_Void_AnimationTrack_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_AddOutputWeightProcessor_Private_Void_AnimationTrack_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_AddEvaluateCallback_Private_Void_AnimationTrack_ITimelineEvaluateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_InvokeOutputCallbacks_Private_Void_IReadOnlyList_1_RuntimeElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_TryGetCallbackList_Private_Boolean_AnimationTrack_byref_List_1_ITimelineEvaluateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr, 100664109);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141321, RefRangeEnd = 1141322, XrefRangeStart = 1141301, XrefRangeEnd = 1141321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tracks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoRebalance;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &createOutputs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_TimelinePlayable_PlayableGraph_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<TimelinePlayable>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141354, RefRangeEnd = 1141355, XrefRangeStart = 1141322, XrefRangeEnd = 1141354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timelinePlayable;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tracks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoRebalance;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &createOutputs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Public_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141379, RefRangeEnd = 1141380, XrefRangeStart = 1141355, XrefRangeEnd = 1141379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timelinePlayable;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tracks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &createOutputs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileTrackList_Private_Void_PlayableGraph_Playable_IEnumerable_1_TrackAsset_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141447, RefRangeEnd = 1141448, XrefRangeStart = 1141380, XrefRangeEnd = 1141447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(Playable**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &playable;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTrackOutput_Private_Void_PlayableGraph_TrackAsset_GameObject_Playable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1141493, RefRangeEnd = 1141495, XrefRangeStart = 1141448, XrefRangeEnd = 1141493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timelinePlayable;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &createOutputs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTrackPlayable_Private_Playable_PlayableGraph_Playable_TrackAsset_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141495, XrefRangeEnd = 1141496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PrepareFrame(Playable playable, FrameData info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141553, RefRangeEnd = 1141554, XrefRangeStart = 1141496, XrefRangeEnd = 1141553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Evaluate(Playable playable, FrameData frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playable);
		*(FrameData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameData;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Private_Void_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141554, XrefRangeEnd = 1141557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheTrack(TrackAsset track, Playable playable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheTrack_Private_Void_TrackAsset_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141557, XrefRangeEnd = 1141563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForAOTCompilationOnly()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForAOTCompilationOnly_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141563, XrefRangeEnd = 1141565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPlayableOutputCallbacks(AnimationTrack track, PlayableOutput playableOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(PlayableOutput**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playableOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayableOutputCallbacks_Private_Void_AnimationTrack_PlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1141600, RefRangeEnd = 1141602, XrefRangeStart = 1141565, XrefRangeEnd = 1141600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOutputWeightProcessor(AnimationTrack track, AnimationPlayableOutput animOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(AnimationPlayableOutput**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animOutput;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOutputWeightProcessor_Private_Void_AnimationTrack_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141602, XrefRangeEnd = 1141617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEvaluateCallback(AnimationTrack track, ITimelineEvaluateCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEvaluateCallback_Private_Void_AnimationTrack_ITimelineEvaluateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141734, RefRangeEnd = 1141735, XrefRangeStart = 1141617, XrefRangeEnd = 1141734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeOutputCallbacks(IReadOnlyList<RuntimeElement> activeRuntimeElements)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeRuntimeElements);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOutputCallbacks_Private_Void_IReadOnlyList_1_RuntimeElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1141745, RefRangeEnd = 1141747, XrefRangeStart = 1141735, XrefRangeEnd = 1141745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetCallbackList(AnimationTrack track, out List<ITimelineEvaluateCallback> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)track);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCallbackList_Private_Boolean_AnimationTrack_byref_List_1_ITimelineEvaluateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		list = ((num3 == 0) ? null : new List<ITimelineEvaluateCallback>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141747, XrefRangeEnd = 1141802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimelinePlayable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelinePlayable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimelinePlayable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
