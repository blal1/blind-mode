using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AnimationEventBlittable
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FunctionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StringParameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectReferenceParameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FloatParameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntParameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MessageOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateSender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatorStateInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatorClipInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_handlePool;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAnimationEvent_Internal_Static_AnimationEventBlittable_AnimationEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromAnimationEvents_Internal_Static_Void_Il2CppReferenceArray_1_AnimationEvent_ptr_AnimationEventBlittable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointerToAnimationEvent_Internal_Static_AnimationEvent_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointerToAnimationEvents_Internal_Static_Il2CppReferenceArray_1_AnimationEvent_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeEvents_Internal_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeEventsInternal_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAnimationEvent_Internal_Static_AnimationEvent_AnimationEventBlittable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	[FieldOffset(0)]
	public float m_Time;

	[FieldOffset(8)]
	public System.IntPtr m_FunctionName;

	[FieldOffset(16)]
	public System.IntPtr m_StringParameter;

	[FieldOffset(24)]
	public System.IntPtr m_ObjectReferenceParameter;

	[FieldOffset(32)]
	public float m_FloatParameter;

	[FieldOffset(36)]
	public int m_IntParameter;

	[FieldOffset(40)]
	public int m_MessageOptions;

	[FieldOffset(44)]
	public AnimationEventSource m_Source;

	[FieldOffset(48)]
	public System.IntPtr m_StateSender;

	[FieldOffset(56)]
	public AnimatorStateInfo m_AnimatorStateInfo;

	[FieldOffset(92)]
	public AnimatorClipInfo m_AnimatorClipInfo;

	public unsafe static GCHandlePool s_handlePool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_handlePool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GCHandlePool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_handlePool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AnimationEventBlittable()
	{
		Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationEventBlittable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_Time");
		NativeFieldInfoPtr_m_FunctionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_FunctionName");
		NativeFieldInfoPtr_m_StringParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_StringParameter");
		NativeFieldInfoPtr_m_ObjectReferenceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_ObjectReferenceParameter");
		NativeFieldInfoPtr_m_FloatParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_FloatParameter");
		NativeFieldInfoPtr_m_IntParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_IntParameter");
		NativeFieldInfoPtr_m_MessageOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_MessageOptions");
		NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_Source");
		NativeFieldInfoPtr_m_StateSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_StateSender");
		NativeFieldInfoPtr_m_AnimatorStateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_AnimatorStateInfo");
		NativeFieldInfoPtr_m_AnimatorClipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "m_AnimatorClipInfo");
		NativeFieldInfoPtr_s_handlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, "s_handlePool");
		NativeMethodInfoPtr_FromAnimationEvent_Internal_Static_AnimationEventBlittable_AnimationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_FromAnimationEvents_Internal_Static_Void_Il2CppReferenceArray_1_AnimationEvent_ptr_AnimationEventBlittable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_PointerToAnimationEvent_Internal_Static_AnimationEvent_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_PointerToAnimationEvents_Internal_Static_Il2CppReferenceArray_1_AnimationEvent_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_DisposeEvents_Internal_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_FreeEventsInternal_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_ToAnimationEvent_Internal_Static_AnimationEvent_AnimationEventBlittable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, 100663475);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1153147, RefRangeEnd = 1153148, XrefRangeStart = 1153123, XrefRangeEnd = 1153147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationEventBlittable FromAnimationEvent(AnimationEvent animationEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromAnimationEvent_Internal_Static_AnimationEventBlittable_AnimationEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationEventBlittable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1153175, RefRangeEnd = 1153176, XrefRangeStart = 1153148, XrefRangeEnd = 1153175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FromAnimationEvents(Il2CppReferenceArray<AnimationEvent> animationEvents, AnimationEventBlittable* animationEventBlittables)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationEvents);
		*(AnimationEventBlittable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = animationEventBlittables;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromAnimationEvents_Internal_Static_Void_Il2CppReferenceArray_1_AnimationEvent_ptr_AnimationEventBlittable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153176, XrefRangeEnd = 1153178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationEvent PointerToAnimationEvent(System.IntPtr animationEventBlittable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationEventBlittable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointerToAnimationEvent_Internal_Static_AnimationEvent_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationEvent>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153178, XrefRangeEnd = 1153186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<AnimationEvent> PointerToAnimationEvents(System.IntPtr animationEventBlittableArray, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&animationEventBlittableArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointerToAnimationEvents_Internal_Static_Il2CppReferenceArray_1_AnimationEvent_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationEvent>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153186, XrefRangeEnd = 1153190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeEvents(System.IntPtr animationEventBlittableArray, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&animationEventBlittableArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeEvents_Internal_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153190, XrefRangeEnd = 1153192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeEventsInternal(System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeEventsInternal_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1153228, RefRangeEnd = 1153231, XrefRangeStart = 1153192, XrefRangeEnd = 1153228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animationEventBlittable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAnimationEvent_Internal_Static_AnimationEvent_AnimationEventBlittable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationEvent>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1153254, RefRangeEnd = 1153258, XrefRangeStart = 1153231, XrefRangeEnd = 1153254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationEventBlittable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
