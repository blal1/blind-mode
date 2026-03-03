using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppSpine.Unity.AnimationTools;

public static class TimelineExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_FindTimelineForBone_Public_Static_T_Animation_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_FindTimelineForBone_Public_Static_T_Animation_Int32_0, Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateTimeline_Single_SkeletonData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateXTimeline_TranslateYTimeline_Single_SkeletonData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_RotateTimeline_Single_SkeletonData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTranslateXYMix_Public_Static_Vector2_TransformConstraintTimeline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateRotateMix_Public_Static_Single_TransformConstraintTimeline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTranslateTimelineForBone_Public_Static_TranslateTimeline_Animation_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTimelineForBone_Public_Static_T_Animation_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTransformConstraintTimeline_Public_Static_TransformConstraintTimeline_Animation_Int32_0;

	static TimelineExtensions()
	{
		Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity.AnimationTools", "TimelineExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateTimeline_Single_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateXTimeline_TranslateYTimeline_Single_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_Evaluate_Public_Static_Single_RotateTimeline_Single_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_EvaluateTranslateXYMix_Public_Static_Vector2_TransformConstraintTimeline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_EvaluateRotateMix_Public_Static_Single_TransformConstraintTimeline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_FindTranslateTimelineForBone_Public_Static_TranslateTimeline_Animation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_FindTimelineForBone_Public_Static_T_Animation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_FindTransformConstraintTimeline_Public_Static_TransformConstraintTimeline_Animation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineExtensions>.NativeClassPtr, 100664213);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858169, XrefRangeEnd = 858170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Evaluate(this TranslateTimeline timeline, float time, SkeletonData skeletonData = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeline);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateTimeline_Single_SkeletonData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 858173, RefRangeEnd = 858183, XrefRangeStart = 858170, XrefRangeEnd = 858173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Evaluate(TranslateXTimeline xTimeline, TranslateYTimeline yTimeline, float time, SkeletonData skeletonData = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xTimeline);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)yTimeline);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Static_Vector2_TranslateXTimeline_TranslateYTimeline_Single_SkeletonData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858183, XrefRangeEnd = 858184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Evaluate(this RotateTimeline timeline, float time, SkeletonData skeletonData = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeline);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Static_Single_RotateTimeline_Single_SkeletonData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858185, RefRangeEnd = 858187, XrefRangeStart = 858184, XrefRangeEnd = 858185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 EvaluateTranslateXYMix(this TransformConstraintTimeline timeline, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeline);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateTranslateXYMix_Public_Static_Vector2_TransformConstraintTimeline_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858188, RefRangeEnd = 858190, XrefRangeStart = 858187, XrefRangeEnd = 858188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float EvaluateRotateMix(this TransformConstraintTimeline timeline, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeline);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateRotateMix_Public_Static_Single_TransformConstraintTimeline_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858208, RefRangeEnd = 858209, XrefRangeStart = 858190, XrefRangeEnd = 858208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TranslateTimeline FindTranslateTimelineForBone(this Animation a, int boneIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTranslateTimelineForBone_Public_Static_TranslateTimeline_Animation_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TranslateTimeline>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858225, RefRangeEnd = 858227, XrefRangeStart = 858209, XrefRangeEnd = 858225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindTimelineForBone<T>(this Animation a, int boneIndex) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_FindTimelineForBone_Public_Static_T_Animation_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858245, RefRangeEnd = 858247, XrefRangeStart = 858227, XrefRangeEnd = 858245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TransformConstraintTimeline FindTransformConstraintTimeline(this Animation a, int transformConstraintIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transformConstraintIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTransformConstraintTimeline_Public_Static_TransformConstraintTimeline_Animation_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TransformConstraintTimeline>(intPtr2) : null;
	}

	public TimelineExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
