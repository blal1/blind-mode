using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct AnimationMotionXToDeltaPlayable
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NullPlayable;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationMotionXToDeltaPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationMotionXToDeltaPlayable_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAbsoluteMotion_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAbsoluteMotionInternal_Private_Static_Boolean_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	public unsafe static AnimationMotionXToDeltaPlayable m_NullPlayable
	{
		get
		{
			Unsafe.SkipInit(out AnimationMotionXToDeltaPlayable result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_NullPlayable, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
		}
	}

	public unsafe static AnimationMotionXToDeltaPlayable Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158836, XrefRangeEnd = 1158840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationMotionXToDeltaPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AnimationMotionXToDeltaPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimationMotionXToDeltaPlayable()
	{
		Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationMotionXToDeltaPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, "m_NullPlayable");
		NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664497);
		NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664498);
		NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationMotionXToDeltaPlayable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_IsAbsoluteMotion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_IsAbsoluteMotionInternal_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, 100664511);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1158870, RefRangeEnd = 1158871, XrefRangeStart = 1158840, XrefRangeEnd = 1158870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AnimationMotionXToDeltaPlayable_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationMotionXToDeltaPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158871, XrefRangeEnd = 1158886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableHandle CreateHandle(PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158886, XrefRangeEnd = 1158895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationMotionXToDeltaPlayable(PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1158899, RefRangeEnd = 1158900, XrefRangeStart = 1158895, XrefRangeEnd = 1158899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationMotionXToDeltaPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158900, XrefRangeEnd = 1158913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator AnimationMotionXToDeltaPlayable(Playable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationMotionXToDeltaPlayable_Playable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationMotionXToDeltaPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158913, XrefRangeEnd = 1158920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AnimationMotionXToDeltaPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationMotionXToDeltaPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158920, XrefRangeEnd = 1158925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAbsoluteMotion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAbsoluteMotion_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1158945, RefRangeEnd = 1158946, XrefRangeStart = 1158925, XrefRangeEnd = 1158945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAbsoluteMotion(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAbsoluteMotion_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158946, XrefRangeEnd = 1158951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158951, XrefRangeEnd = 1158953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAbsoluteMotionInternal(ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAbsoluteMotionInternal_Private_Static_Boolean_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158953, XrefRangeEnd = 1158955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAbsoluteMotionInternal_Private_Static_Void_byref_PlayableHandle_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158955, XrefRangeEnd = 1158957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateHandleInternal_Injected([In] ref PlayableGraph graph, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationMotionXToDeltaPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
