using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

public static class AnimationPlayableBinding : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;

	static AnimationPlayableBinding()
	{
		Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableBinding>.NativeClassPtr, 100664237);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1157715, RefRangeEnd = 1157717, XrefRangeStart = 1157700, XrefRangeEnd = 1157715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableBinding Create(string name, Object key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayableBinding(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157717, XrefRangeEnd = 1157719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAnimationOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AnimationPlayableBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
