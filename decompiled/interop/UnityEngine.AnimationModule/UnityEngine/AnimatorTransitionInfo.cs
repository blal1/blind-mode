using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct AnimatorTransitionInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FullPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UserName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasFixedDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalizedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnyState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransitionType;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsName_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUserName_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_userNameHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_durationUnit_Public_get_DurationUnit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anyState_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entry_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_exit_Internal_get_Boolean_0;

	[FieldOffset(0)]
	public int m_FullPath;

	[FieldOffset(4)]
	public int m_UserName;

	[FieldOffset(8)]
	public int m_Name;

	[FieldOffset(12)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_HasFixedDuration;

	[FieldOffset(16)]
	public float m_Duration;

	[FieldOffset(20)]
	public float m_NormalizedTime;

	[FieldOffset(24)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_AnyState;

	[FieldOffset(28)]
	public int m_TransitionType;

	public unsafe int fullPathHash
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int nameHash
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1153890, RefRangeEnd = 1153936, XrefRangeStart = 1153890, XrefRangeEnd = 1153936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int userNameHash
	{
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1153936, RefRangeEnd = 1153990, XrefRangeStart = 1153936, XrefRangeEnd = 1153990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_userNameHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DurationUnit durationUnit
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_durationUnit_Public_get_DurationUnit_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DurationUnit*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float duration
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1153382, RefRangeEnd = 1153405, XrefRangeStart = 1153382, XrefRangeEnd = 1153405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_duration_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float normalizedTime
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154293, XrefRangeStart = 1154286, XrefRangeEnd = 1154293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool anyState
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anyState_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool entry
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entry_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool exit
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_exit_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimatorTransitionInfo()
	{
		Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorTransitionInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_FullPath");
		NativeFieldInfoPtr_m_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_UserName");
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_HasFixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_HasFixedDuration");
		NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Duration");
		NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_NormalizedTime");
		NativeFieldInfoPtr_m_AnyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_AnyState");
		NativeFieldInfoPtr_m_TransitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_TransitionType");
		NativeMethodInfoPtr_IsName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_IsUserName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_get_userNameHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_get_durationUnit_Public_get_DurationUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_get_anyState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_get_entry_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_get_exit_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, 100663585);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154374, XrefRangeEnd = 1154375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsName_Public_Boolean_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154375, XrefRangeEnd = 1154376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUserName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUserName_Public_Boolean_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
