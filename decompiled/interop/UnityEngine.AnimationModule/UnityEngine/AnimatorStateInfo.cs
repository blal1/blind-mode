using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct AnimatorStateInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FullPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalizedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpeedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Loop;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsName_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shortNameHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_speed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_speedMultiplier_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tagHash_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTag_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

	[FieldOffset(0)]
	public int m_Name;

	[FieldOffset(4)]
	public int m_Path;

	[FieldOffset(8)]
	public int m_FullPath;

	[FieldOffset(12)]
	public float m_NormalizedTime;

	[FieldOffset(16)]
	public float m_Length;

	[FieldOffset(20)]
	public float m_Speed;

	[FieldOffset(24)]
	public float m_SpeedMultiplier;

	[FieldOffset(28)]
	public int m_Tag;

	[FieldOffset(32)]
	public int m_Loop;

	public unsafe int fullPathHash
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1153890, RefRangeEnd = 1153936, XrefRangeStart = 1153890, XrefRangeEnd = 1153890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1153936, RefRangeEnd = 1153990, XrefRangeStart = 1153936, XrefRangeEnd = 1153936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int shortNameHash
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1153990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shortNameHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float normalizedTime
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1154246, RefRangeEnd = 1154286, XrefRangeStart = 1154246, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float length
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1153382, RefRangeEnd = 1153405, XrefRangeStart = 1153382, XrefRangeEnd = 1153405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float speed
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154293, XrefRangeStart = 1154286, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_speed_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float speedMultiplier
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1154293, RefRangeEnd = 1154355, XrefRangeStart = 1154293, XrefRangeEnd = 1154293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_speedMultiplier_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int tagHash
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1154355, RefRangeEnd = 1154368, XrefRangeStart = 1154355, XrefRangeEnd = 1154355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tagHash_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool loop
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1154369, RefRangeEnd = 1154374, XrefRangeStart = 1154369, XrefRangeEnd = 1154369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimatorStateInfo()
	{
		Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorStateInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Path");
		NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_FullPath");
		NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_NormalizedTime");
		NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Length");
		NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Speed");
		NativeFieldInfoPtr_m_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_SpeedMultiplier");
		NativeFieldInfoPtr_m_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Tag");
		NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Loop");
		NativeMethodInfoPtr_IsName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_get_fullPathHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_get_shortNameHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_get_normalizedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_get_speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_get_speedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_get_tagHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_IsTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663574);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1153883, RefRangeEnd = 1153890, XrefRangeStart = 1153882, XrefRangeEnd = 1153883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154368, XrefRangeEnd = 1154369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTag(string tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTag_Public_Boolean_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
