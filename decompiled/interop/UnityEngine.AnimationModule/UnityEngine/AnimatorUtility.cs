using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine;

public class AnimatorUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_OptimizeTransformHierarchy_Public_Static_Void_GameObject_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_0;

	static AnimatorUtility()
	{
		Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr);
		NativeMethodInfoPtr_OptimizeTransformHierarchy_Public_Static_Void_GameObject_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_OptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr, 100664053);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156875, XrefRangeEnd = 1156884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OptimizeTransformHierarchy(GameObject go, Il2CppStringArray exposedTransforms)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposedTransforms);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OptimizeTransformHierarchy_Public_Static_Void_GameObject_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156884, XrefRangeEnd = 1156893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeoptimizeTransformHierarchy(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimatorUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156893, XrefRangeEnd = 1156895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OptimizeTransformHierarchy_Injected(System.IntPtr go, Il2CppStringArray exposedTransforms)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposedTransforms);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156895, XrefRangeEnd = 1156897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeoptimizeTransformHierarchy_Injected(System.IntPtr go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&go);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeoptimizeTransformHierarchy_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimatorUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
