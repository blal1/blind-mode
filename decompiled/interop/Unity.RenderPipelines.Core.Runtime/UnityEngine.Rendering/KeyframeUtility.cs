using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class KeyframeUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static KeyframeUtility()
	{
		Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "KeyframeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr);
		NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666841);
		NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666842);
		NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666843);
		NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666844);
		NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666845);
		NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666846);
		NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666847);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr, 100666848);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053790, XrefRangeEnd = 1053792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAnimationCurve(AnimationCurve curve)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curve);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAnimationCurve_Public_Static_Void_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053823, RefRangeEnd = 1053824, XrefRangeStart = 1053792, XrefRangeEnd = 1053823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&lhs);
		*(Keyframe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LerpSingleKeyframe_Private_Static_Keyframe_Keyframe_Keyframe_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1053833, RefRangeEnd = 1053838, XrefRangeStart = 1053824, XrefRangeEnd = 1053833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keys));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyframeAndClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1053846, RefRangeEnd = 1053848, XrefRangeStart = 1053838, XrefRangeEnd = 1053846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keys));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &segmentStartTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &segmentEndTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchKeyFromIndexClampEdge_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053860, RefRangeEnd = 1053861, XrefRangeStart = 1053848, XrefRangeEnd = 1053860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref dstValue);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dstDeriv);
		*(Keyframe**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lhsKey;
		*(Keyframe**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhsKey;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &desiredTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvalCurveSegmentAndDeriv_Private_Static_Void_byref_Single_byref_Single_Keyframe_Keyframe_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1053865, RefRangeEnd = 1053867, XrefRangeStart = 1053861, XrefRangeEnd = 1053865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keys));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lhsIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhsIndex;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startTime;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &endTime;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &currTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvalKeyAtTime_Private_Static_Keyframe_NativeArray_1_Keyframe_Int32_Int32_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053914, RefRangeEnd = 1053915, XrefRangeStart = 1053867, XrefRangeEnd = 1053914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhsAndResultCurve);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhsCurve);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpAnimationCurve_Public_Static_Void_byref_AnimationCurve_AnimationCurve_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		lhsAndResultCurve = ((intPtr4 == (System.IntPtr)0) ? null : new AnimationCurve(intPtr4));
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyframeUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public KeyframeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
