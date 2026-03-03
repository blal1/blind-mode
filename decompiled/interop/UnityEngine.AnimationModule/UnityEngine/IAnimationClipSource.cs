using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public class IAnimationClipSource : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimationClips_Public_Abstract_Virtual_New_Void_List_1_AnimationClip_0;

	static IAnimationClipSource()
	{
		Il2CppClassPointerStore<IAnimationClipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "IAnimationClipSource");
		NativeMethodInfoPtr_GetAnimationClips_Public_Abstract_Virtual_New_Void_List_1_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationClipSource>.NativeClassPtr, 100663299);
	}

	[CallerCount(0)]
	public unsafe virtual void GetAnimationClips(List<AnimationClip> results)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAnimationClips_Public_Abstract_Virtual_New_Void_List_1_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IAnimationClipSource(IntPtr pointer)
		: base(pointer)
	{
	}
}
