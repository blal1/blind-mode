using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Animations;

public class IAnimationPreviewable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnPreviewUpdate_Public_Abstract_Virtual_New_Void_0;

	static IAnimationPreviewable()
	{
		Il2CppClassPointerStore<IAnimationPreviewable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "IAnimationPreviewable");
		NativeMethodInfoPtr_OnPreviewUpdate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationPreviewable>.NativeClassPtr, 100664245);
	}

	[CallerCount(0)]
	public unsafe virtual void OnPreviewUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnPreviewUpdate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IAnimationPreviewable(IntPtr pointer)
		: base(pointer)
	{
	}
}
