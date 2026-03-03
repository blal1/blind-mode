using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct MatchTargetWeightMask
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionXYZWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RotationWeight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_positionXYZWeight_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_positionXYZWeight_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotationWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotationWeight_Public_set_Void_Single_0;

	[FieldOffset(0)]
	public Vector3 m_PositionXYZWeight;

	[FieldOffset(12)]
	public float m_RotationWeight;

	public unsafe Vector3 positionXYZWeight
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_positionXYZWeight_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_positionXYZWeight_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float rotationWeight
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1154246, RefRangeEnd = 1154286, XrefRangeStart = 1154246, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationWeight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1007802, RefRangeEnd = 1007805, XrefRangeStart = 1007802, XrefRangeEnd = 1007805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationWeight_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static MatchTargetWeightMask()
	{
		Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "MatchTargetWeightMask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr);
		NativeFieldInfoPtr_m_PositionXYZWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, "m_PositionXYZWeight");
		NativeFieldInfoPtr_m_RotationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, "m_RotationWeight");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_get_positionXYZWeight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_set_positionXYZWeight_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_get_rotationWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_set_rotationWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, 100663590);
	}

	[CallerCount(0)]
	public unsafe MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&positionXYZWeight);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
