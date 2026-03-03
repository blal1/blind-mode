using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

public static class AnimationPlayableExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0<U>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0, Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Injected_Private_Static_Void_byref_PlayableHandle_IntPtr_0;

	static AnimationPlayableExtensions()
	{
		Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Injected_Private_Static_Void_byref_PlayableHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableExtensions>.NativeClassPtr, 100664537);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1159122, RefRangeEnd = 1159124, XrefRangeStart = 1159116, XrefRangeEnd = 1159122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref U reference;
		if (!typeof(U).IsValueType)
		{
			object obj = playable;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref playable;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetAnimatedProperties_Public_Static_Void_U_AnimationClip_0<U>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1159129, RefRangeEnd = 1159130, XrefRangeStart = 1159124, XrefRangeEnd = 1159129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref playable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animatedProperties);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Internal_Static_Void_byref_PlayableHandle_AnimationClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159130, XrefRangeEnd = 1159132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAnimatedPropertiesInternal_Injected(ref PlayableHandle playable, System.IntPtr animatedProperties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref playable);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animatedProperties;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimatedPropertiesInternal_Injected_Private_Static_Void_byref_PlayableHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationPlayableExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
