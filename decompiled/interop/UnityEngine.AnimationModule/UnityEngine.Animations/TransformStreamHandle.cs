using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct TransformStreamHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_skeletonIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSkeletonIndex_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Public_Quaternion_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotation_Public_Void_AnimationStream_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPosition_Public_Vector3_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPosition_Public_Void_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalRotation_Public_Quaternion_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalRotation_Public_Void_AnimationStream_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScale_Public_Vector3_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalScale_Public_Void_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToParentMatrix_Public_Matrix4x4_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionReadMask_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationReadMask_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleReadMask_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTRS_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalTRS_Public_Void_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalTR_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrix_Public_Matrix4x4_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTR_Public_Void_AnimationStream_Vector3_Quaternion_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionInternal_Private_Vector3_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionInternal_Private_Void_byref_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationInternal_Private_Quaternion_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPositionInternal_Private_Vector3_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPositionInternal_Private_Void_byref_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalRotationInternal_Private_Quaternion_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScaleInternal_Private_Vector3_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalScaleInternal_Private_Void_byref_AnimationStream_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionReadMaskInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationReadMaskInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleReadMaskInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTRSInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalTRSInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalTRInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTRInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalTRSInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTRInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_Boolean_0;

	[FieldOffset(0)]
	public uint m_AnimatorBindingsVersion;

	[FieldOffset(4)]
	public int handleIndex;

	[FieldOffset(8)]
	public int skeletonIndex;

	public unsafe bool createdByNative
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159749, RefRangeEnd = 1159750, XrefRangeStart = 1159749, XrefRangeEnd = 1159749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasHandleIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasSkeletonIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasSkeletonIndex_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint animatorBindingsVersion
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TransformStreamHandle()
	{
		Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "TransformStreamHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr);
		NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, "m_AnimatorBindingsVersion");
		NativeFieldInfoPtr_handleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, "handleIndex");
		NativeFieldInfoPtr_skeletonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, "skeletonIndex");
		NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664655);
		NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664656);
		NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664657);
		NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664658);
		NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664659);
		NativeMethodInfoPtr_get_hasSkeletonIndex_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664660);
		NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664661);
		NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664662);
		NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664663);
		NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664664);
		NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664665);
		NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664666);
		NativeMethodInfoPtr_GetPosition_Public_Vector3_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664667);
		NativeMethodInfoPtr_SetPosition_Public_Void_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664668);
		NativeMethodInfoPtr_GetRotation_Public_Quaternion_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664669);
		NativeMethodInfoPtr_SetRotation_Public_Void_AnimationStream_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664670);
		NativeMethodInfoPtr_GetLocalPosition_Public_Vector3_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664671);
		NativeMethodInfoPtr_SetLocalPosition_Public_Void_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664672);
		NativeMethodInfoPtr_GetLocalRotation_Public_Quaternion_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664673);
		NativeMethodInfoPtr_SetLocalRotation_Public_Void_AnimationStream_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664674);
		NativeMethodInfoPtr_GetLocalScale_Public_Vector3_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_SetLocalScale_Public_Void_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_GetLocalToParentMatrix_Public_Matrix4x4_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_GetPositionReadMask_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr_GetRotationReadMask_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664679);
		NativeMethodInfoPtr_GetScaleReadMask_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664680);
		NativeMethodInfoPtr_GetLocalTRS_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664681);
		NativeMethodInfoPtr_SetLocalTRS_Public_Void_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_GetGlobalTR_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_GetLocalToWorldMatrix_Public_Matrix4x4_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr_SetGlobalTR_Public_Void_AnimationStream_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_GetPositionInternal_Private_Vector3_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_SetPositionInternal_Private_Void_byref_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_GetRotationInternal_Private_Quaternion_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_SetRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_GetLocalPositionInternal_Private_Vector3_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_SetLocalPositionInternal_Private_Void_byref_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_GetLocalRotationInternal_Private_Quaternion_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_SetLocalRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_GetLocalScaleInternal_Private_Vector3_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_SetLocalScaleInternal_Private_Void_byref_AnimationStream_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr_GetPositionReadMaskInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_GetRotationReadMaskInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_GetScaleReadMaskInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_GetLocalTRSInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_SetLocalTRSInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_GetGlobalTRInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_SetGlobalTRInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr_GetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr_SetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr_GetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr_SetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr_GetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664714);
		NativeMethodInfoPtr_SetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_SetLocalTRSInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664718);
		NativeMethodInfoPtr_SetGlobalTRInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, 100664719);
	}

	[CallerCount(0)]
	public unsafe bool IsValid(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsValidInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsSameVersionAsStream(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159750, XrefRangeEnd = 1159751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resolve(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsResolved(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsResolvedInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1159754, RefRangeEnd = 1159774, XrefRangeStart = 1159751, XrefRangeEnd = 1159754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsValidAndResolve(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159774, XrefRangeEnd = 1159777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPosition(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Public_Vector3_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159777, XrefRangeEnd = 1159780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(AnimationStream stream, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Public_Void_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159780, XrefRangeEnd = 1159783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRotation(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotation_Public_Quaternion_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159783, XrefRangeEnd = 1159786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotation(AnimationStream stream, Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotation_Public_Void_AnimationStream_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159786, XrefRangeEnd = 1159789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLocalPosition(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalPosition_Public_Vector3_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159789, XrefRangeEnd = 1159792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalPosition(AnimationStream stream, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPosition_Public_Void_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159792, XrefRangeEnd = 1159795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetLocalRotation(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalRotation_Public_Quaternion_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159795, XrefRangeEnd = 1159798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalRotation(AnimationStream stream, Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalRotation_Public_Void_AnimationStream_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159798, XrefRangeEnd = 1159801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLocalScale(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalScale_Public_Vector3_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159801, XrefRangeEnd = 1159804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalScale(AnimationStream stream, Vector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalScale_Public_Void_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159804, XrefRangeEnd = 1159807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetLocalToParentMatrix(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToParentMatrix_Public_Matrix4x4_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159807, XrefRangeEnd = 1159810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPositionReadMask(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionReadMask_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159810, XrefRangeEnd = 1159813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetRotationReadMask(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationReadMask_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159813, XrefRangeEnd = 1159816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetScaleReadMask(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleReadMask_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159816, XrefRangeEnd = 1159819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTRS_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159819, XrefRangeEnd = 1159822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalTRS_Public_Void_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159822, XrefRangeEnd = 1159825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalTR_Public_Void_AnimationStream_byref_Vector3_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159825, XrefRangeEnd = 1159828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetLocalToWorldMatrix(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToWorldMatrix_Public_Matrix4x4_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159828, XrefRangeEnd = 1159831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTR_Public_Void_AnimationStream_Vector3_Quaternion_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159831, XrefRangeEnd = 1159833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResolveInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159833, XrefRangeEnd = 1159835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionInternal_Private_Vector3_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159835, XrefRangeEnd = 1159837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPositionInternal(ref AnimationStream stream, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionInternal_Private_Void_byref_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159837, XrefRangeEnd = 1159839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRotationInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationInternal_Private_Quaternion_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159839, XrefRangeEnd = 1159841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotationInternal(ref AnimationStream stream, Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159841, XrefRangeEnd = 1159843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLocalPositionInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalPositionInternal_Private_Vector3_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159843, XrefRangeEnd = 1159845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPositionInternal_Private_Void_byref_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159845, XrefRangeEnd = 1159847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetLocalRotationInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalRotationInternal_Private_Quaternion_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159847, XrefRangeEnd = 1159849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalRotationInternal_Private_Void_byref_AnimationStream_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159849, XrefRangeEnd = 1159851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLocalScaleInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalScaleInternal_Private_Vector3_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159851, XrefRangeEnd = 1159853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalScaleInternal_Private_Void_byref_AnimationStream_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159853, XrefRangeEnd = 1159855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetLocalToParentMatrixInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159855, XrefRangeEnd = 1159857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPositionReadMaskInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionReadMaskInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159857, XrefRangeEnd = 1159859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetRotationReadMaskInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationReadMaskInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159859, XrefRangeEnd = 1159861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetScaleReadMaskInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleReadMaskInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159861, XrefRangeEnd = 1159863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalTRSInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159863, XrefRangeEnd = 1159865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalTRSInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Vector3_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159865, XrefRangeEnd = 1159867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalTRInternal_Private_Void_byref_AnimationStream_byref_Vector3_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159867, XrefRangeEnd = 1159869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Matrix4x4 GetLocalToWorldMatrixInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Private_Matrix4x4_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159869, XrefRangeEnd = 1159871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTRInternal_Private_Void_byref_AnimationStream_Vector3_Quaternion_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159871, XrefRangeEnd = 1159873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159873, XrefRangeEnd = 1159875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159875, XrefRangeEnd = 1159877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159877, XrefRangeEnd = 1159879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159879, XrefRangeEnd = 1159881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159881, XrefRangeEnd = 1159883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPositionInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159883, XrefRangeEnd = 1159885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159885, XrefRangeEnd = 1159887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalRotationInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159887, XrefRangeEnd = 1159889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159889, XrefRangeEnd = 1159891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalScaleInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159891, XrefRangeEnd = 1159893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalToParentMatrixInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToParentMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159893, XrefRangeEnd = 1159895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref Vector3 scale, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalTRSInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_byref_Vector3_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159895, XrefRangeEnd = 1159897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalToWorldMatrixInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalToWorldMatrixInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159897, XrefRangeEnd = 1159899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position, [In] ref Quaternion rotation, bool useMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTRInternal_Injected_Private_Static_Void_byref_TransformStreamHandle_byref_AnimationStream_byref_Vector3_byref_Quaternion_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformStreamHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
