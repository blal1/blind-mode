using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Animations;

public static class AnimationPlayableOutputExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationStreamSource_Public_Static_AnimationStreamSource_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationStreamSource_Public_Static_Void_AnimationPlayableOutput_AnimationStreamSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Static_UInt16_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSortingOrder_Public_Static_Void_AnimationPlayableOutput_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetAnimationStreamSource_Private_Static_AnimationStreamSource_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetAnimationStreamSource_Private_Static_Void_PlayableOutputHandle_AnimationStreamSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetSortingOrder_Private_Static_Int32_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetSortingOrder_Private_Static_Void_PlayableOutputHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetAnimationStreamSource_Injected_Private_Static_AnimationStreamSource_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetAnimationStreamSource_Injected_Private_Static_Void_byref_PlayableOutputHandle_AnimationStreamSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetSortingOrder_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetSortingOrder_Injected_Private_Static_Void_byref_PlayableOutputHandle_Int32_0;

	static AnimationPlayableOutputExtensions()
	{
		Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Experimental.Animations", "AnimationPlayableOutputExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetAnimationStreamSource_Public_Static_AnimationStreamSource_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_SetAnimationStreamSource_Public_Static_Void_AnimationPlayableOutput_AnimationStreamSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_GetSortingOrder_Public_Static_UInt16_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_SetSortingOrder_Public_Static_Void_AnimationPlayableOutput_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_InternalGetAnimationStreamSource_Private_Static_AnimationStreamSource_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_InternalSetAnimationStreamSource_Private_Static_Void_PlayableOutputHandle_AnimationStreamSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_InternalGetSortingOrder_Private_Static_Int32_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_InternalSetSortingOrder_Private_Static_Void_PlayableOutputHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_InternalGetAnimationStreamSource_Injected_Private_Static_AnimationStreamSource_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_InternalSetAnimationStreamSource_Injected_Private_Static_Void_byref_PlayableOutputHandle_AnimationStreamSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_InternalGetSortingOrder_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_InternalSetSortingOrder_Injected_Private_Static_Void_byref_PlayableOutputHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutputExtensions>.NativeClassPtr, 100664230);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157594, XrefRangeEnd = 1157596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationStreamSource GetAnimationStreamSource(this AnimationPlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimationStreamSource_Public_Static_AnimationStreamSource_AnimationPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationStreamSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157596, XrefRangeEnd = 1157598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&output);
		*(AnimationStreamSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &streamSource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationStreamSource_Public_Static_Void_AnimationPlayableOutput_AnimationStreamSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157598, XrefRangeEnd = 1157600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort GetSortingOrder(this AnimationPlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortingOrder_Public_Static_UInt16_AnimationPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157600, XrefRangeEnd = 1157602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&output);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSortingOrder_Public_Static_Void_AnimationPlayableOutput_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157602, XrefRangeEnd = 1157604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationStreamSource InternalGetAnimationStreamSource(PlayableOutputHandle output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetAnimationStreamSource_Private_Static_AnimationStreamSource_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationStreamSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157604, XrefRangeEnd = 1157606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&output);
		*(AnimationStreamSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &streamSource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetAnimationStreamSource_Private_Static_Void_PlayableOutputHandle_AnimationStreamSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157606, XrefRangeEnd = 1157608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalGetSortingOrder(PlayableOutputHandle output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetSortingOrder_Private_Static_Int32_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157608, XrefRangeEnd = 1157610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&output);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetSortingOrder_Private_Static_Void_PlayableOutputHandle_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157610, XrefRangeEnd = 1157612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationStreamSource InternalGetAnimationStreamSource_Injected([In] ref PlayableOutputHandle output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetAnimationStreamSource_Injected_Private_Static_AnimationStreamSource_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationStreamSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157612, XrefRangeEnd = 1157614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetAnimationStreamSource_Injected([In] ref PlayableOutputHandle output, AnimationStreamSource streamSource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		*(AnimationStreamSource**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &streamSource;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetAnimationStreamSource_Injected_Private_Static_Void_byref_PlayableOutputHandle_AnimationStreamSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157614, XrefRangeEnd = 1157616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalGetSortingOrder_Injected([In] ref PlayableOutputHandle output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetSortingOrder_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157616, XrefRangeEnd = 1157618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetSortingOrder_Injected([In] ref PlayableOutputHandle output, int sortingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetSortingOrder_Injected_Private_Static_Void_byref_PlayableOutputHandle_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationPlayableOutputExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
