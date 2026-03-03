using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public class RuntimeAnimatorController : Object
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_animationClips_Injected_Private_Static_Il2CppReferenceArray_1_AnimationClip_IntPtr_0;

	public unsafe Il2CppReferenceArray<AnimationClip> animationClips
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1157591, RefRangeEnd = 1157592, XrefRangeStart = 1157586, XrefRangeEnd = 1157591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
		}
	}

	static RuntimeAnimatorController()
	{
		Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "RuntimeAnimatorController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_get_animationClips_Public_get_Il2CppReferenceArray_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_get_animationClips_Injected_Private_Static_Il2CppReferenceArray_1_AnimationClip_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr, 100664218);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157582, XrefRangeEnd = 1157586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeAnimatorController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157592, XrefRangeEnd = 1157594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<AnimationClip> get_animationClips_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animationClips_Injected_Private_Static_Il2CppReferenceArray_1_AnimationClip_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
	}

	public RuntimeAnimatorController(IntPtr pointer)
		: base(pointer)
	{
	}
}
