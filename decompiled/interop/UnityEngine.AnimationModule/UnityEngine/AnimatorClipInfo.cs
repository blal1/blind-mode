using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct AnimatorClipInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClipInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Private_Static_AnimationClip_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Injected_Private_Static_IntPtr_Int32_0;

	[FieldOffset(0)]
	public int m_ClipInstanceID;

	[FieldOffset(4)]
	public float m_Weight;

	public unsafe AnimationClip clip
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1153770, RefRangeEnd = 1153785, XrefRangeStart = 1153765, XrefRangeEnd = 1153770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}
	}

	public unsafe float weight
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimatorClipInfo()
	{
		Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorClipInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_ClipInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_ClipInstanceID");
		NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_Weight");
		NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_get_weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Private_Static_AnimationClip_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, 100663563);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153875, XrefRangeEnd = 1153880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Private_Static_AnimationClip_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153880, XrefRangeEnd = 1153882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InstanceIDToAnimationClipPPtr_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToAnimationClipPPtr_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
