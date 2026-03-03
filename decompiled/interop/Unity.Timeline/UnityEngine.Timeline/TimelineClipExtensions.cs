using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class TimelineClipExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_UndoSetParentTrackText;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToTrack_Public_Static_Void_TimelineClip_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveToTrack_Public_Static_Boolean_TimelineClip_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToTrack_Impl_Private_Static_Void_TimelineClip_TrackAsset_Object_TrackAsset_0;

	public unsafe static string k_UndoSetParentTrackText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UndoSetParentTrackText, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UndoSetParentTrackText, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static TimelineClipExtensions()
	{
		Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineClipExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr);
		NativeFieldInfoPtr_k_UndoSetParentTrackText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr, "k_UndoSetParentTrackText");
		NativeMethodInfoPtr_MoveToTrack_Public_Static_Void_TimelineClip_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_TryMoveToTrack_Public_Static_Boolean_TimelineClip_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_MoveToTrack_Impl_Private_Static_Void_TimelineClip_TrackAsset_Object_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipExtensions>.NativeClassPtr, 100664154);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142071, XrefRangeEnd = 1142087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTrack);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToTrack_Public_Static_Void_TimelineClip_TrackAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142087, XrefRangeEnd = 1142103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryMoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTrack);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMoveToTrack_Public_Static_Boolean_TimelineClip_TrackAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1142122, RefRangeEnd = 1142124, XrefRangeStart = 1142103, XrefRangeEnd = 1142122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, Object asset, TrackAsset parentTrack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationTrack);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTrack);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToTrack_Impl_Private_Static_Void_TimelineClip_TrackAsset_Object_TrackAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TimelineClipExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
