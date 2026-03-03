using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct AnimationPlayableOutput
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTarget_Public_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetTarget_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0;

	[FieldOffset(0)]
	public PlayableOutputHandle m_Handle;

	public unsafe static AnimationPlayableOutput Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159205, XrefRangeEnd = 1159218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AnimationPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimationPlayableOutput()
	{
		Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_GetTarget_Public_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_InternalGetTarget_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100664558);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1159189, RefRangeEnd = 1159196, XrefRangeStart = 1159174, XrefRangeEnd = 1159189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159196, XrefRangeEnd = 1159205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationPlayableOutput(PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableOutputHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1158137, RefRangeEnd = 1158142, XrefRangeStart = 1158137, XrefRangeEnd = 1158142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PlayableOutput(AnimationPlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1159231, RefRangeEnd = 1159233, XrefRangeStart = 1159218, XrefRangeEnd = 1159231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator AnimationPlayableOutput(PlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1159238, RefRangeEnd = 1159240, XrefRangeStart = 1159233, XrefRangeEnd = 1159238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Animator GetTarget()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTarget_Public_Animator_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159240, XrefRangeEnd = 1159245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTarget(Animator value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1159238, RefRangeEnd = 1159240, XrefRangeStart = 1159238, XrefRangeEnd = 1159240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Animator InternalGetTarget(ref PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159245, XrefRangeEnd = 1159247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetTarget_Injected_Private_Static_IntPtr_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159247, XrefRangeEnd = 1159249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetTarget_Injected(ref PlayableOutputHandle handle, System.IntPtr target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
