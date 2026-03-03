using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class FrameTimingManager : Il2CppSystem.Object
{
	private delegate bool IsFeatureEnabledDelegate();

	private delegate float GetVSyncsPerSecondDelegate();

	private delegate ulong GetGpuTimerFrequencyDelegate();

	private delegate ulong GetCpuTimerFrequencyDelegate();

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0;

	private static readonly IsFeatureEnabledDelegate IsFeatureEnabledDelegateField;

	private static readonly GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField;

	private static readonly GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField;

	private static readonly GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField;

	static FrameTimingManager()
	{
		Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTimingManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr);
		NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664428);
		NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664429);
		NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664430);
		IsFeatureEnabledDelegateField = IL2CPP.ResolveICall<IsFeatureEnabledDelegate>("UnityEngine.FrameTimingManager::IsFeatureEnabled");
		GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");
		GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");
		GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173304, RefRangeEnd = 1173305, XrefRangeStart = 1173302, XrefRangeEnd = 1173304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CaptureFrameTimings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173314, RefRangeEnd = 1173315, XrefRangeStart = 1173305, XrefRangeEnd = 1173314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetLatestTimings(uint numFrames, Il2CppStructArray<FrameTiming> timings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numFrames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173315, XrefRangeEnd = 1173317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetLatestTimings_Injected(uint numFrames, ref ManagedSpanWrapper timings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numFrames);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref timings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestTimings_Injected_Private_Static_UInt32_UInt32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FrameTimingManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool IsFeatureEnabled()
	{
		return IsFeatureEnabledDelegateField();
	}

	public static float GetVSyncsPerSecond()
	{
		return GetVSyncsPerSecondDelegateField();
	}

	public static ulong GetGpuTimerFrequency()
	{
		return GetGpuTimerFrequencyDelegateField();
	}

	public static ulong GetCpuTimerFrequency()
	{
		return GetCpuTimerFrequencyDelegateField();
	}
}
