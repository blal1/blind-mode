using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR;

[StructLayout(LayoutKind.Explicit)]
public struct Eyes
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeftEyePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeftEyeRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RightEyePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RightEyeRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FixationPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeftEyeOpenAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RightEyeOpenAmount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftEyePosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftEyePosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftEyeRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftEyeRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightEyePosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightEyePosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightEyeRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightEyeRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixationPoint_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fixationPoint_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftEyeOpenAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftEyeOpenAmount_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightEyeOpenAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightEyeOpenAmount_Public_set_Void_Single_0;

	[FieldOffset(0)]
	public Vector3 m_LeftEyePosition;

	[FieldOffset(12)]
	public Quaternion m_LeftEyeRotation;

	[FieldOffset(28)]
	public Vector3 m_RightEyePosition;

	[FieldOffset(40)]
	public Quaternion m_RightEyeRotation;

	[FieldOffset(56)]
	public Vector3 m_FixationPoint;

	[FieldOffset(68)]
	public float m_LeftEyeOpenAmount;

	[FieldOffset(72)]
	public float m_RightEyeOpenAmount;

	public unsafe Vector3 leftEyePosition
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyePosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyePosition_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion leftEyeRotation
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyeRotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyeRotation_Public_set_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 rightEyePosition
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyePosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyePosition_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion rightEyeRotation
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyeRotation_Public_get_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 591312, RefRangeEnd = 591315, XrefRangeStart = 591312, XrefRangeEnd = 591315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyeRotation_Public_set_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 fixationPoint
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixationPoint_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fixationPoint_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float leftEyeOpenAmount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101136, RefRangeEnd = 101137, XrefRangeStart = 101136, XrefRangeEnd = 101137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftEyeOpenAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftEyeOpenAmount_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float rightEyeOpenAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightEyeOpenAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightEyeOpenAmount_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Eyes()
	{
		Il2CppClassPointerStore<Eyes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "Eyes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyes>.NativeClassPtr);
		NativeFieldInfoPtr_m_LeftEyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_LeftEyePosition");
		NativeFieldInfoPtr_m_LeftEyeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_LeftEyeRotation");
		NativeFieldInfoPtr_m_RightEyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_RightEyePosition");
		NativeFieldInfoPtr_m_RightEyeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_RightEyeRotation");
		NativeFieldInfoPtr_m_FixationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_FixationPoint");
		NativeFieldInfoPtr_m_LeftEyeOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_LeftEyeOpenAmount");
		NativeFieldInfoPtr_m_RightEyeOpenAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_RightEyeOpenAmount");
		NativeMethodInfoPtr_get_leftEyePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666478);
		NativeMethodInfoPtr_set_leftEyePosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666479);
		NativeMethodInfoPtr_get_leftEyeRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666480);
		NativeMethodInfoPtr_set_leftEyeRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666481);
		NativeMethodInfoPtr_get_rightEyePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666482);
		NativeMethodInfoPtr_set_rightEyePosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666483);
		NativeMethodInfoPtr_get_rightEyeRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666484);
		NativeMethodInfoPtr_set_rightEyeRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666485);
		NativeMethodInfoPtr_get_fixationPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666486);
		NativeMethodInfoPtr_set_fixationPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666487);
		NativeMethodInfoPtr_get_leftEyeOpenAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666488);
		NativeMethodInfoPtr_set_leftEyeOpenAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666489);
		NativeMethodInfoPtr_get_rightEyeOpenAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666490);
		NativeMethodInfoPtr_set_rightEyeOpenAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100666491);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eyes>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
