using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct AnimationStream
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_constant;

	private static readonly System.IntPtr NativeFieldInfoPtr_input;

	private static readonly System.IntPtr NativeFieldInfoPtr_output;

	private static readonly System.IntPtr NativeFieldInfoPtr_workspace;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputStreamAccessor;

	private static readonly System.IntPtr NativeFieldInfoPtr_animationHandleBinder;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsValid_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_angularVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootMotionPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootMotionRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHumanStream_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsHuman_Public_AnimationHumanStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputStreamCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputStream_Public_AnimationStream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeight_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAnimationStreamMotion_Public_Void_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadSceneTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSceneTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Private_Void_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeltaTime_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsHumanStream_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVelocity_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAngularVelocity_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAngularVelocity_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootMotionPosition_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootMotionRotation_Private_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputStreamCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetInputStream_Private_AnimationStream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetInputWeight_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHumanStream_Private_AnimationHumanStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalReadSceneTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalWriteSceneTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootMotionPosition_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootMotionRotation_Injected_Private_Static_Void_byref_AnimationStream_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetInputStream_Injected_Private_Static_Void_byref_AnimationStream_Int32_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHumanStream_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationHumanStream_0;

	[FieldOffset(0)]
	public uint m_AnimatorBindingsVersion;

	[FieldOffset(8)]
	public System.IntPtr constant;

	[FieldOffset(16)]
	public System.IntPtr input;

	[FieldOffset(24)]
	public System.IntPtr output;

	[FieldOffset(32)]
	public System.IntPtr workspace;

	[FieldOffset(40)]
	public System.IntPtr inputStreamAccessor;

	[FieldOffset(48)]
	public System.IntPtr animationHandleBinder;

	public unsafe static int InvalidIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidIndex, (void*)(&value));
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
	}

	public unsafe bool isValid
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1159626, RefRangeEnd = 1159628, XrefRangeStart = 1159626, XrefRangeEnd = 1159626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float deltaTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159653, XrefRangeEnd = 1159656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 velocity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159656, XrefRangeEnd = 1159659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159659, XrefRangeEnd = 1159662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 angularVelocity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159662, XrefRangeEnd = 1159665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_angularVelocity_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159665, XrefRangeEnd = 1159668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 rootMotionPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159668, XrefRangeEnd = 1159671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootMotionPosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Quaternion rootMotionRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159671, XrefRangeEnd = 1159674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootMotionRotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isHumanStream
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159674, XrefRangeEnd = 1159677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHumanStream_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int inputStreamCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159682, XrefRangeEnd = 1159685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputStreamCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimationStream()
	{
		Il2CppClassPointerStore<AnimationStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr);
		NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "m_AnimatorBindingsVersion");
		NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "constant");
		NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "input");
		NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "output");
		NativeFieldInfoPtr_workspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "workspace");
		NativeFieldInfoPtr_inputStreamAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "inputStreamAccessor");
		NativeFieldInfoPtr_animationHandleBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "animationHandleBinder");
		NativeFieldInfoPtr_InvalidIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "InvalidIndex");
		NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_CheckIsValid_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_get_angularVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_get_rootMotionPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_get_rootMotionRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_get_isHumanStream_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_AsHuman_Public_AnimationHumanStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_get_inputStreamCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_GetInputStream_Public_AnimationStream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr_GetInputWeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_CopyAnimationStreamMotion_Public_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_ReadSceneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr_WriteSceneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Private_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_GetDeltaTime_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_GetIsHumanStream_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_GetVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_GetAngularVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_SetAngularVelocity_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_GetRootMotionPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664638);
		NativeMethodInfoPtr_GetRootMotionRotation_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr_GetInputStreamCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664640);
		NativeMethodInfoPtr_InternalGetInputStream_Private_AnimationStream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664641);
		NativeMethodInfoPtr_InternalGetInputWeight_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664642);
		NativeMethodInfoPtr_GetHumanStream_Private_AnimationHumanStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664643);
		NativeMethodInfoPtr_InternalReadSceneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664644);
		NativeMethodInfoPtr_InternalWriteSceneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664645);
		NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664646);
		NativeMethodInfoPtr_GetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664647);
		NativeMethodInfoPtr_SetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664648);
		NativeMethodInfoPtr_GetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664649);
		NativeMethodInfoPtr_SetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664650);
		NativeMethodInfoPtr_GetRootMotionPosition_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664651);
		NativeMethodInfoPtr_GetRootMotionRotation_Injected_Private_Static_Void_byref_AnimationStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664652);
		NativeMethodInfoPtr_InternalGetInputStream_Injected_Private_Static_Void_byref_AnimationStream_Int32_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664653);
		NativeMethodInfoPtr_GetHumanStream_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationHumanStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, 100664654);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1159628, RefRangeEnd = 1159653, XrefRangeStart = 1159628, XrefRangeEnd = 1159628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsValid_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159677, XrefRangeEnd = 1159682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationHumanStream AsHuman()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsHuman_Public_AnimationHumanStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationHumanStream*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159685, XrefRangeEnd = 1159688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationStream GetInputStream(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputStream_Public_AnimationStream_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationStream*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159688, XrefRangeEnd = 1159691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetInputWeight(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputWeight_Public_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159691, XrefRangeEnd = 1159695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyAnimationStreamMotion(AnimationStream animationStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationStream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAnimationStreamMotion_Public_Void_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159695, XrefRangeEnd = 1159698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadSceneTransforms()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadSceneTransforms_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159698, XrefRangeEnd = 1159701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteSceneTransforms()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSceneTransforms_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159701, XrefRangeEnd = 1159703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyAnimationStreamMotionInternal(AnimationStream animationStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationStream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Private_Void_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159703, XrefRangeEnd = 1159705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDeltaTime()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeltaTime_Private_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159705, XrefRangeEnd = 1159707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsHumanStream()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsHumanStream_Private_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159707, XrefRangeEnd = 1159709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVelocity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVelocity_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159709, XrefRangeEnd = 1159711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVelocity(Vector3 velocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159711, XrefRangeEnd = 1159713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetAngularVelocity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAngularVelocity_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159713, XrefRangeEnd = 1159715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAngularVelocity(Vector3 velocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAngularVelocity_Private_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159715, XrefRangeEnd = 1159717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRootMotionPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootMotionPosition_Private_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159717, XrefRangeEnd = 1159719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRootMotionRotation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootMotionRotation_Private_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159719, XrefRangeEnd = 1159721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInputStreamCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputStreamCount_Private_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159721, XrefRangeEnd = 1159723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationStream InternalGetInputStream(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetInputStream_Private_AnimationStream_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationStream*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159723, XrefRangeEnd = 1159725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float InternalGetInputWeight(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetInputWeight_Private_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159725, XrefRangeEnd = 1159727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationHumanStream GetHumanStream()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHumanStream_Private_AnimationHumanStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationHumanStream*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159727, XrefRangeEnd = 1159729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalReadSceneTransforms()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalReadSceneTransforms_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159729, XrefRangeEnd = 1159731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalWriteSceneTransforms()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalWriteSceneTransforms_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159731, XrefRangeEnd = 1159733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyAnimationStreamMotionInternal_Injected(ref AnimationStream _unity_self, [In] ref AnimationStream animationStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref animationStream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAnimationStreamMotionInternal_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159733, XrefRangeEnd = 1159735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159735, XrefRangeEnd = 1159737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVelocity_Injected(ref AnimationStream _unity_self, [In] ref Vector3 velocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref velocity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159737, XrefRangeEnd = 1159739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAngularVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159739, XrefRangeEnd = 1159741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAngularVelocity_Injected(ref AnimationStream _unity_self, [In] ref Vector3 velocity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref velocity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAngularVelocity_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159741, XrefRangeEnd = 1159743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRootMotionPosition_Injected(ref AnimationStream _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootMotionPosition_Injected_Private_Static_Void_byref_AnimationStream_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159743, XrefRangeEnd = 1159745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRootMotionRotation_Injected(ref AnimationStream _unity_self, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootMotionRotation_Injected_Private_Static_Void_byref_AnimationStream_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159745, XrefRangeEnd = 1159747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalGetInputStream_Injected(ref AnimationStream _unity_self, int index, out AnimationStream ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetInputStream_Injected_Private_Static_Void_byref_AnimationStream_Int32_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159747, XrefRangeEnd = 1159749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetHumanStream_Injected(ref AnimationStream _unity_self, out AnimationHumanStream ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHumanStream_Injected_Private_Static_Void_byref_AnimationStream_byref_AnimationHumanStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
