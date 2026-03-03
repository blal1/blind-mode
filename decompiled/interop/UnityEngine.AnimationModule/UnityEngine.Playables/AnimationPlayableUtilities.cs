using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Animations;

namespace UnityEngine.Playables;

public static class AnimationPlayableUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_Animator_Playable_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayClip_Public_Static_AnimationClipPlayable_Animator_AnimationClip_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayMixer_Public_Static_AnimationMixerPlayable_Animator_Int32_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayLayerMixer_Public_Static_AnimationLayerMixerPlayable_Animator_Int32_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayAnimatorController_Public_Static_AnimatorControllerPlayable_Animator_RuntimeAnimatorController_byref_PlayableGraph_0;

	static AnimationPlayableUtilities()
	{
		Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Playables", "AnimationPlayableUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_Play_Public_Static_Void_Animator_Playable_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_PlayClip_Public_Static_AnimationClipPlayable_Animator_AnimationClip_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_PlayMixer_Public_Static_AnimationMixerPlayable_Animator_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_PlayLayerMixer_Public_Static_AnimationLayerMixerPlayable_Animator_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_PlayAnimatorController_Public_Static_AnimatorControllerPlayable_Animator_RuntimeAnimatorController_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableUtilities>.NativeClassPtr, 100664235);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157618, XrefRangeEnd = 1157631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Play(Animator animator, Playable playable, PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playable;
		*(PlayableGraph**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &graph;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_Void_Animator_Playable_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157631, XrefRangeEnd = 1157646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayClip_Public_Static_AnimationClipPlayable_Animator_AnimationClip_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationClipPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157646, XrefRangeEnd = 1157664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayMixer_Public_Static_AnimationMixerPlayable_Animator_Int32_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationMixerPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157664, XrefRangeEnd = 1157682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayLayerMixer_Public_Static_AnimationLayerMixerPlayable_Animator_Int32_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationLayerMixerPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157682, XrefRangeEnd = 1157700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayAnimatorController_Public_Static_AnimatorControllerPlayable_Animator_RuntimeAnimatorController_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimatorControllerPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AnimationPlayableUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
