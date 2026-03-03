using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public static class WeightUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0;

	static WeightUtility()
	{
		Il2CppClassPointerStore<WeightUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "WeightUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightUtility>.NativeClassPtr);
		NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightUtility>.NativeClassPtr, 100664199);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1142726, RefRangeEnd = 1142727, XrefRangeStart = 1142709, XrefRangeEnd = 1142726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float NormalizeMixer(Playable mixer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mixer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public WeightUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
