using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class CurveEditUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMatchingCurve_Public_Static_AnimationCurve_AnimationCurve_0;

	static CurveEditUtility()
	{
		Il2CppClassPointerStore<CurveEditUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "CurveEditUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveEditUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CreateMatchingCurve_Public_Static_AnimationCurve_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveEditUtility>.NativeClassPtr, 100663826);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1139744, RefRangeEnd = 1139745, XrefRangeStart = 1139730, XrefRangeEnd = 1139744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve CreateMatchingCurve(AnimationCurve curve)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMatchingCurve_Public_Static_AnimationCurve_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	public CurveEditUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
