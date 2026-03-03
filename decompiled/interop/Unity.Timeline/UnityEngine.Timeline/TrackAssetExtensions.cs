using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class TrackAssetExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeBlendsFromOverlaps_Internal_Static_Void_TrackAsset_Boolean_0;

	static TrackAssetExtensions()
	{
		Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackAssetExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_ComputeBlendsFromOverlaps_Internal_Static_Void_TrackAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackAssetExtensions>.NativeClassPtr, 100663994);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140538, XrefRangeEnd = 1140544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GroupTrack GetGroup(this TrackAsset asset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroup_Public_Static_GroupTrack_TrackAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GroupTrack>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140544, XrefRangeEnd = 1140584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGroup(this TrackAsset asset, GroupTrack group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGroup_Public_Static_Void_TrackAsset_GroupTrack_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1140589, RefRangeEnd = 1140590, XrefRangeStart = 1140584, XrefRangeEnd = 1140589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeBlendsFromOverlaps(this TrackAsset asset, bool force = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeBlendsFromOverlaps_Internal_Static_Void_TrackAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrackAssetExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
