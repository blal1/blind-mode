using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public static class NotificationUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_TimelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_IPlayableAsset_PlayableDirector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0;

	static NotificationUtilities()
	{
		Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "NotificationUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_IPlayableAsset_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationUtilities>.NativeClassPtr, 100664151);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141960, RefRangeEnd = 1141961, XrefRangeStart = 1141959, XrefRangeEnd = 1141960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)markers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_PlayableDirector_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<TimeNotificationBehaviour>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1141962, RefRangeEnd = 1141963, XrefRangeStart = 1141961, XrefRangeEnd = 1141962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)markers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timelineAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNotificationsPlayable_Public_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_TimelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<TimeNotificationBehaviour>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1142054, RefRangeEnd = 1142056, XrefRangeStart = 1141963, XrefRangeEnd = 1142054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)markers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNotificationsPlayable_Private_Static_ScriptPlayable_1_TimeNotificationBehaviour_PlayableGraph_IEnumerable_1_IMarker_IPlayableAsset_PlayableDirector_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ScriptPlayable<TimeNotificationBehaviour>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1142070, RefRangeEnd = 1142071, XrefRangeStart = 1142056, XrefRangeEnd = 1142070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TrackTypeSupportsNotifications(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrackTypeSupportsNotifications_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NotificationUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
