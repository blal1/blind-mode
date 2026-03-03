using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct AnimationHumanStream
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stream;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfInvalid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_humanScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftFootHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightFootHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bodyLocalPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyLocalPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bodyLocalRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyLocalRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bodyPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bodyRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMuscle_Public_Single_MuscleHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMuscle_Public_Void_MuscleHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftFootVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightFootVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetToStancePose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalPositionFromPose_Public_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalRotationFromPose_Public_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalLocalPosition_Public_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalLocalPosition_Public_Void_AvatarIKGoal_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalLocalRotation_Public_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalLocalRotation_Public_Void_AvatarIKGoal_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalPosition_Public_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalPosition_Public_Void_AvatarIKGoal_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalRotation_Public_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalRotation_Public_Void_AvatarIKGoal_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalWeightPosition_Public_Void_AvatarIKGoal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGoalWeightRotation_Public_Void_AvatarIKGoal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalWeightPosition_Public_Single_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGoalWeightRotation_Public_Single_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHintPosition_Public_Vector3_AvatarIKHint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHintPosition_Public_Void_AvatarIKHint_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHintWeightPosition_Public_Void_AvatarIKHint_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHintWeightPosition_Public_Single_AvatarIKHint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtPosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtClampWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtBodyWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtHeadWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtEyesWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SolveIK_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHumanScale_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFootHeight_Private_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResetToStancePose_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Private_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Private_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyLocalPosition_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyLocalPosition_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyLocalRotation_Private_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyLocalRotation_Private_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyPosition_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyPosition_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyRotation_Private_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyRotation_Private_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetMuscle_Private_Single_MuscleHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetMuscle_Private_Void_MuscleHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLeftFootVelocity_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRightFootVelocity_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalLocalPosition_Private_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalLocalPosition_Private_Void_AvatarIKGoal_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalLocalRotation_Private_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalLocalRotation_Private_Void_AvatarIKGoal_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalPosition_Private_Vector3_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalPosition_Private_Void_AvatarIKGoal_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalRotation_Private_Quaternion_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalRotation_Private_Void_AvatarIKGoal_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalWeightPosition_Private_Void_AvatarIKGoal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalWeightRotation_Private_Void_AvatarIKGoal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalWeightPosition_Private_Single_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalWeightRotation_Private_Single_AvatarIKGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetHintPosition_Private_Vector3_AvatarIKHint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetHintPosition_Private_Void_AvatarIKHint_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetHintWeightPosition_Private_Void_AvatarIKHint_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetHintWeightPosition_Private_Single_AvatarIKHint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtPosition_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtClampWeight_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtBodyWeight_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtHeadWeight_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtEyesWeight_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSolveIK_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetMuscle_Injected_Private_Static_Single_byref_AnimationHumanStream_byref_MuscleHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetMuscle_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_MuscleHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLeftFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRightFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetLookAtPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0;

	[FieldOffset(0)]
	public System.IntPtr stream;

	public unsafe bool isValid
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1158201, RefRangeEnd = 1158206, XrefRangeStart = 1158201, XrefRangeEnd = 1158201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float humanScale
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158206, XrefRangeEnd = 1158214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_humanScale_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float leftFootHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158214, XrefRangeEnd = 1158222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftFootHeight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float rightFootHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158222, XrefRangeEnd = 1158230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightFootHeight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 bodyLocalPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158230, XrefRangeEnd = 1158232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bodyLocalPosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158232, XrefRangeEnd = 1158234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyLocalPosition_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion bodyLocalRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158234, XrefRangeEnd = 1158236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bodyLocalRotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158236, XrefRangeEnd = 1158238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyLocalRotation_Public_set_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 bodyPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158238, XrefRangeEnd = 1158240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bodyPosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158240, XrefRangeEnd = 1158242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyPosition_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion bodyRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158242, XrefRangeEnd = 1158244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bodyRotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158244, XrefRangeEnd = 1158246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyRotation_Public_set_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 leftFootVelocity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158250, XrefRangeEnd = 1158252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftFootVelocity_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 rightFootVelocity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158252, XrefRangeEnd = 1158254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightFootVelocity_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimationHumanStream()
	{
		Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationHumanStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr);
		NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, "stream");
		NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr_ThrowIfInvalid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664360);
		NativeMethodInfoPtr_get_humanScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664361);
		NativeMethodInfoPtr_get_leftFootHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664362);
		NativeMethodInfoPtr_get_rightFootHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664363);
		NativeMethodInfoPtr_get_bodyLocalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664364);
		NativeMethodInfoPtr_set_bodyLocalPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664365);
		NativeMethodInfoPtr_get_bodyLocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664366);
		NativeMethodInfoPtr_set_bodyLocalRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664367);
		NativeMethodInfoPtr_get_bodyPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664368);
		NativeMethodInfoPtr_set_bodyPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664369);
		NativeMethodInfoPtr_get_bodyRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664370);
		NativeMethodInfoPtr_set_bodyRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664371);
		NativeMethodInfoPtr_GetMuscle_Public_Single_MuscleHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664372);
		NativeMethodInfoPtr_SetMuscle_Public_Void_MuscleHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664373);
		NativeMethodInfoPtr_get_leftFootVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664374);
		NativeMethodInfoPtr_get_rightFootVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664375);
		NativeMethodInfoPtr_ResetToStancePose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664376);
		NativeMethodInfoPtr_GetGoalPositionFromPose_Public_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664377);
		NativeMethodInfoPtr_GetGoalRotationFromPose_Public_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664378);
		NativeMethodInfoPtr_GetGoalLocalPosition_Public_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664379);
		NativeMethodInfoPtr_SetGoalLocalPosition_Public_Void_AvatarIKGoal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664380);
		NativeMethodInfoPtr_GetGoalLocalRotation_Public_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664381);
		NativeMethodInfoPtr_SetGoalLocalRotation_Public_Void_AvatarIKGoal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664382);
		NativeMethodInfoPtr_GetGoalPosition_Public_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664383);
		NativeMethodInfoPtr_SetGoalPosition_Public_Void_AvatarIKGoal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664384);
		NativeMethodInfoPtr_GetGoalRotation_Public_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664385);
		NativeMethodInfoPtr_SetGoalRotation_Public_Void_AvatarIKGoal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664386);
		NativeMethodInfoPtr_SetGoalWeightPosition_Public_Void_AvatarIKGoal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664387);
		NativeMethodInfoPtr_SetGoalWeightRotation_Public_Void_AvatarIKGoal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664388);
		NativeMethodInfoPtr_GetGoalWeightPosition_Public_Single_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664389);
		NativeMethodInfoPtr_GetGoalWeightRotation_Public_Single_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664390);
		NativeMethodInfoPtr_GetHintPosition_Public_Vector3_AvatarIKHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664391);
		NativeMethodInfoPtr_SetHintPosition_Public_Void_AvatarIKHint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664392);
		NativeMethodInfoPtr_SetHintWeightPosition_Public_Void_AvatarIKHint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664393);
		NativeMethodInfoPtr_GetHintWeightPosition_Public_Single_AvatarIKHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664394);
		NativeMethodInfoPtr_SetLookAtPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_SetLookAtClampWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664396);
		NativeMethodInfoPtr_SetLookAtBodyWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_SetLookAtHeadWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664398);
		NativeMethodInfoPtr_SetLookAtEyesWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_SolveIK_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_GetHumanScale_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664401);
		NativeMethodInfoPtr_GetFootHeight_Private_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664402);
		NativeMethodInfoPtr_InternalResetToStancePose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664403);
		NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Private_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664404);
		NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Private_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664405);
		NativeMethodInfoPtr_InternalGetBodyLocalPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664406);
		NativeMethodInfoPtr_InternalSetBodyLocalPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr_InternalGetBodyLocalRotation_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr_InternalSetBodyLocalRotation_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664409);
		NativeMethodInfoPtr_InternalGetBodyPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_InternalSetBodyPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_InternalGetBodyRotation_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_InternalSetBodyRotation_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_InternalGetMuscle_Private_Single_MuscleHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_InternalSetMuscle_Private_Void_MuscleHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_GetLeftFootVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_GetRightFootVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_InternalGetGoalLocalPosition_Private_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_InternalSetGoalLocalPosition_Private_Void_AvatarIKGoal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_InternalGetGoalLocalRotation_Private_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_InternalSetGoalLocalRotation_Private_Void_AvatarIKGoal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_InternalGetGoalPosition_Private_Vector3_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_InternalSetGoalPosition_Private_Void_AvatarIKGoal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_InternalGetGoalRotation_Private_Quaternion_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_InternalSetGoalRotation_Private_Void_AvatarIKGoal_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_InternalSetGoalWeightPosition_Private_Void_AvatarIKGoal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_InternalSetGoalWeightRotation_Private_Void_AvatarIKGoal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664427);
		NativeMethodInfoPtr_InternalGetGoalWeightPosition_Private_Single_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664428);
		NativeMethodInfoPtr_InternalGetGoalWeightRotation_Private_Single_AvatarIKGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664429);
		NativeMethodInfoPtr_InternalGetHintPosition_Private_Vector3_AvatarIKHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664430);
		NativeMethodInfoPtr_InternalSetHintPosition_Private_Void_AvatarIKHint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr_InternalSetHintWeightPosition_Private_Void_AvatarIKHint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_InternalGetHintWeightPosition_Private_Single_AvatarIKHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_InternalSetLookAtPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_InternalSetLookAtClampWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_InternalSetLookAtBodyWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_InternalSetLookAtHeadWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_InternalSetLookAtEyesWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_InternalSolveIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_InternalGetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_InternalSetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_InternalGetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_InternalSetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_InternalGetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_InternalSetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_InternalGetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664448);
		NativeMethodInfoPtr_InternalSetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_InternalGetMuscle_Injected_Private_Static_Single_byref_AnimationHumanStream_byref_MuscleHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_InternalSetMuscle_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_MuscleHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_GetLeftFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_GetRightFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_InternalGetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_InternalSetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_InternalGetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_InternalSetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_InternalGetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_InternalSetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr_InternalGetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_InternalSetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_InternalGetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664462);
		NativeMethodInfoPtr_InternalSetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_InternalSetLookAtPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, 100664464);
	}

	[CallerCount(0)]
	public unsafe void ThrowIfInvalid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfInvalid_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158246, XrefRangeEnd = 1158248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMuscle(MuscleHandle muscle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&muscle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMuscle_Public_Single_MuscleHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158248, XrefRangeEnd = 1158250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMuscle(MuscleHandle muscle, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&muscle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMuscle_Public_Void_MuscleHandle_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158254, XrefRangeEnd = 1158262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetToStancePose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetToStancePose_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158262, XrefRangeEnd = 1158264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetGoalPositionFromPose(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalPositionFromPose_Public_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158264, XrefRangeEnd = 1158266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetGoalRotationFromPose(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalRotationFromPose_Public_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158266, XrefRangeEnd = 1158268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetGoalLocalPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalLocalPosition_Public_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158268, XrefRangeEnd = 1158270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalLocalPosition_Public_Void_AvatarIKGoal_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158270, XrefRangeEnd = 1158272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetGoalLocalRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalLocalRotation_Public_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158272, XrefRangeEnd = 1158274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalLocalRotation_Public_Void_AvatarIKGoal_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158274, XrefRangeEnd = 1158276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetGoalPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalPosition_Public_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158276, XrefRangeEnd = 1158278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalPosition(AvatarIKGoal index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalPosition_Public_Void_AvatarIKGoal_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158278, XrefRangeEnd = 1158280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetGoalRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalRotation_Public_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158280, XrefRangeEnd = 1158282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalRotation(AvatarIKGoal index, Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalRotation_Public_Void_AvatarIKGoal_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158282, XrefRangeEnd = 1158290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalWeightPosition(AvatarIKGoal index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalWeightPosition_Public_Void_AvatarIKGoal_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158290, XrefRangeEnd = 1158298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGoalWeightRotation(AvatarIKGoal index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGoalWeightRotation_Public_Void_AvatarIKGoal_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158298, XrefRangeEnd = 1158306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGoalWeightPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalWeightPosition_Public_Single_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158306, XrefRangeEnd = 1158314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGoalWeightRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGoalWeightRotation_Public_Single_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158314, XrefRangeEnd = 1158316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetHintPosition(AvatarIKHint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHintPosition_Public_Vector3_AvatarIKHint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158316, XrefRangeEnd = 1158318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHintPosition(AvatarIKHint index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHintPosition_Public_Void_AvatarIKHint_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158318, XrefRangeEnd = 1158326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHintWeightPosition(AvatarIKHint index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHintWeightPosition_Public_Void_AvatarIKHint_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158326, XrefRangeEnd = 1158334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHintWeightPosition(AvatarIKHint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHintWeightPosition_Public_Single_AvatarIKHint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158334, XrefRangeEnd = 1158336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtPosition(Vector3 lookAtPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lookAtPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtPosition_Public_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158336, XrefRangeEnd = 1158344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtClampWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtClampWeight_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158344, XrefRangeEnd = 1158352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtBodyWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtBodyWeight_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158352, XrefRangeEnd = 1158360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtHeadWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtHeadWeight_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158360, XrefRangeEnd = 1158368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtEyesWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtEyesWeight_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158368, XrefRangeEnd = 1158376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SolveIK()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SolveIK_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158376, XrefRangeEnd = 1158378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHumanScale()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHumanScale_Private_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158378, XrefRangeEnd = 1158380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFootHeight(bool left)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&left);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFootHeight_Private_Single_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158380, XrefRangeEnd = 1158382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalResetToStancePose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResetToStancePose_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158382, XrefRangeEnd = 1158384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetGoalPositionFromPose(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Private_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158384, XrefRangeEnd = 1158386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion InternalGetGoalRotationFromPose(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Private_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158386, XrefRangeEnd = 1158388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetBodyLocalPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyLocalPosition_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158388, XrefRangeEnd = 1158390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetBodyLocalPosition(Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyLocalPosition_Private_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158390, XrefRangeEnd = 1158392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion InternalGetBodyLocalRotation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyLocalRotation_Private_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158392, XrefRangeEnd = 1158394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetBodyLocalRotation(Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyLocalRotation_Private_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158394, XrefRangeEnd = 1158396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetBodyPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyPosition_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158396, XrefRangeEnd = 1158398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetBodyPosition(Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyPosition_Private_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158398, XrefRangeEnd = 1158400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion InternalGetBodyRotation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyRotation_Private_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158400, XrefRangeEnd = 1158402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetBodyRotation(Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyRotation_Private_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158402, XrefRangeEnd = 1158404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InternalGetMuscle(MuscleHandle muscle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&muscle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetMuscle_Private_Single_MuscleHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158404, XrefRangeEnd = 1158406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetMuscle(MuscleHandle muscle, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&muscle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetMuscle_Private_Void_MuscleHandle_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158406, XrefRangeEnd = 1158408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLeftFootVelocity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLeftFootVelocity_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158408, XrefRangeEnd = 1158410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRightFootVelocity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRightFootVelocity_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158410, XrefRangeEnd = 1158412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetGoalLocalPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalLocalPosition_Private_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158412, XrefRangeEnd = 1158414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalLocalPosition_Private_Void_AvatarIKGoal_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158414, XrefRangeEnd = 1158416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion InternalGetGoalLocalRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalLocalRotation_Private_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158416, XrefRangeEnd = 1158418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalLocalRotation_Private_Void_AvatarIKGoal_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158418, XrefRangeEnd = 1158420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetGoalPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalPosition_Private_Vector3_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158420, XrefRangeEnd = 1158422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalPosition(AvatarIKGoal index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalPosition_Private_Void_AvatarIKGoal_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158422, XrefRangeEnd = 1158424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion InternalGetGoalRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalRotation_Private_Quaternion_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158424, XrefRangeEnd = 1158426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalRotation(AvatarIKGoal index, Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalRotation_Private_Void_AvatarIKGoal_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158426, XrefRangeEnd = 1158428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalWeightPosition(AvatarIKGoal index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalWeightPosition_Private_Void_AvatarIKGoal_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158428, XrefRangeEnd = 1158430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetGoalWeightRotation(AvatarIKGoal index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalWeightRotation_Private_Void_AvatarIKGoal_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158430, XrefRangeEnd = 1158432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InternalGetGoalWeightPosition(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalWeightPosition_Private_Single_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158432, XrefRangeEnd = 1158434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InternalGetGoalWeightRotation(AvatarIKGoal index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalWeightRotation_Private_Single_AvatarIKGoal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158434, XrefRangeEnd = 1158436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InternalGetHintPosition(AvatarIKHint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetHintPosition_Private_Vector3_AvatarIKHint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158436, XrefRangeEnd = 1158438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetHintPosition(AvatarIKHint index, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetHintPosition_Private_Void_AvatarIKHint_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158438, XrefRangeEnd = 1158440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetHintWeightPosition(AvatarIKHint index, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetHintWeightPosition_Private_Void_AvatarIKHint_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158440, XrefRangeEnd = 1158442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InternalGetHintWeightPosition(AvatarIKHint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetHintWeightPosition_Private_Single_AvatarIKHint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158442, XrefRangeEnd = 1158444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetLookAtPosition(Vector3 lookAtPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lookAtPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtPosition_Private_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158444, XrefRangeEnd = 1158446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetLookAtClampWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtClampWeight_Private_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158446, XrefRangeEnd = 1158448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetLookAtBodyWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtBodyWeight_Private_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158448, XrefRangeEnd = 1158450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetLookAtHeadWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtHeadWeight_Private_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158450, XrefRangeEnd = 1158452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetLookAtEyesWeight(float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtEyesWeight_Private_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158452, XrefRangeEnd = 1158454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSolveIK()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSolveIK_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158454, XrefRangeEnd = 1158456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalPositionFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalPositionFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158456, XrefRangeEnd = 1158458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalRotationFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalRotationFromPose_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158458, XrefRangeEnd = 1158460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158460, XrefRangeEnd = 1158462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158462, XrefRangeEnd = 1158464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158464, XrefRangeEnd = 1158466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, [In] ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158466, XrefRangeEnd = 1158468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetBodyPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158468, XrefRangeEnd = 1158470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetBodyPosition_Injected(ref AnimationHumanStream _unity_self, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158470, XrefRangeEnd = 1158472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetBodyRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158472, XrefRangeEnd = 1158474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetBodyRotation_Injected(ref AnimationHumanStream _unity_self, [In] ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetBodyRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158474, XrefRangeEnd = 1158476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float InternalGetMuscle_Injected(ref AnimationHumanStream _unity_self, [In] ref MuscleHandle muscle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref muscle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetMuscle_Injected_Private_Static_Single_byref_AnimationHumanStream_byref_MuscleHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158476, XrefRangeEnd = 1158478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetMuscle_Injected(ref AnimationHumanStream _unity_self, [In] ref MuscleHandle muscle, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref muscle);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetMuscle_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_MuscleHandle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158478, XrefRangeEnd = 1158480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLeftFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLeftFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158480, XrefRangeEnd = 1158482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRightFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRightFootVelocity_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158482, XrefRangeEnd = 1158484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158484, XrefRangeEnd = 1158486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, [In] ref Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalLocalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158486, XrefRangeEnd = 1158488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158488, XrefRangeEnd = 1158490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, [In] ref Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalLocalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158490, XrefRangeEnd = 1158492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158492, XrefRangeEnd = 1158494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, [In] ref Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158494, XrefRangeEnd = 1158496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158496, XrefRangeEnd = 1158498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, [In] ref Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKGoal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetGoalRotation_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKGoal_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158498, XrefRangeEnd = 1158500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKHint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158500, XrefRangeEnd = 1158502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, [In] ref Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(AvatarIKHint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetHintPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_AvatarIKHint_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158502, XrefRangeEnd = 1158504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetLookAtPosition_Injected(ref AnimationHumanStream _unity_self, [In] ref Vector3 lookAtPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lookAtPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetLookAtPosition_Injected_Private_Static_Void_byref_AnimationHumanStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
