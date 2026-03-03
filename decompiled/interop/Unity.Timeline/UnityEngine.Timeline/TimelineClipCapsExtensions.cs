using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class TimelineClipCapsExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0;

	static TimelineClipCapsExtensions()
	{
		Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineClipCapsExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663783);
		NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663785);
		NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663786);
		NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineClipCapsExtensions>.NativeClassPtr, 100663789);
	}

	[CallerCount(0)]
	public unsafe static bool SupportsLooping(this TimelineClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsLooping_Public_Static_Boolean_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139002, RefRangeEnd = 1139003, XrefRangeStart = 1139002, XrefRangeEnd = 1139002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsExtrapolation(this TimelineClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsExtrapolation_Public_Static_Boolean_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool SupportsClipIn(this TimelineClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsClipIn_Public_Static_Boolean_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool SupportsSpeedMultiplier(this TimelineClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsSpeedMultiplier_Public_Static_Boolean_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1139003, RefRangeEnd = 1139006, XrefRangeStart = 1139003, XrefRangeEnd = 1139003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsBlending(this TimelineClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsBlending_Public_Static_Boolean_TimelineClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool HasAll(this ClipCaps caps, ClipCaps flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&caps);
		*(ClipCaps**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAll_Public_Static_Boolean_ClipCaps_ClipCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 629954, RefRangeEnd = 629965, XrefRangeStart = 629954, XrefRangeEnd = 629965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAny(this ClipCaps caps, ClipCaps flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&caps);
		*(ClipCaps**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAny_Public_Static_Boolean_ClipCaps_ClipCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TimelineClipCapsExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
