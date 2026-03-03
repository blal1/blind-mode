using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

public static class AnimationPlayableGraphExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SyncUpdateAndTimeMode_Internal_Static_Void_PlayableGraph_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyOutput_Internal_Static_Void_PlayableGraph_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Internal_Static_Void_byref_PlayableGraph_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDestroyOutput_Private_Static_Void_byref_PlayableGraph_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalAnimationOutputCount_Private_Static_Int32_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetAnimationOutput_Private_Static_Boolean_byref_PlayableGraph_Int32_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreateAnimationOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Injected_Private_Static_Void_byref_PlayableGraph_IntPtr_0;

	static AnimationPlayableGraphExtensions()
	{
		Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableGraphExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SyncUpdateAndTimeMode_Internal_Static_Void_PlayableGraph_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_DestroyOutput_Internal_Static_Void_PlayableGraph_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Internal_Static_Void_byref_PlayableGraph_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_InternalDestroyOutput_Private_Static_Void_byref_PlayableGraph_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_InternalAnimationOutputCount_Private_Static_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_InternalGetAnimationOutput_Private_Static_Boolean_byref_PlayableGraph_Int32_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_InternalCreateAnimationOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Injected_Private_Static_Void_byref_PlayableGraph_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100664546);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159132, XrefRangeEnd = 1159138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SyncUpdateAndTimeMode(this PlayableGraph graph, Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncUpdateAndTimeMode_Internal_Static_Void_PlayableGraph_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159138, XrefRangeEnd = 1159140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyOutput(this PlayableGraph graph, PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(PlayableOutputHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &handle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyOutput_Internal_Static_Void_PlayableGraph_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1159154, RefRangeEnd = 1159155, XrefRangeStart = 1159140, XrefRangeEnd = 1159154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159155, XrefRangeEnd = 1159164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Internal_Static_Void_byref_PlayableGraph_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159164, XrefRangeEnd = 1159166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDestroyOutput_Private_Static_Void_byref_PlayableGraph_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159166, XrefRangeEnd = 1159168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalAnimationOutputCount(ref PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalAnimationOutputCount_Private_Static_Int32_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159168, XrefRangeEnd = 1159170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalGetAnimationOutput(ref PlayableGraph graph, int index, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetAnimationOutput_Private_Static_Boolean_byref_PlayableGraph_Int32_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159170, XrefRangeEnd = 1159172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalCreateAnimationOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCreateAnimationOutput_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159172, XrefRangeEnd = 1159174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSyncUpdateAndTimeMode_Injected(ref PlayableGraph graph, System.IntPtr animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSyncUpdateAndTimeMode_Injected_Private_Static_Void_byref_PlayableGraph_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationPlayableGraphExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
