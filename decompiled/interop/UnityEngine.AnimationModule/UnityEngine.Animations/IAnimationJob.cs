using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Animations;

public class IAnimationJob : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ProcessAnimation_Public_Abstract_Virtual_New_Void_AnimationStream_0;

	private static readonly IntPtr NativeMethodInfoPtr_ProcessRootMotion_Public_Abstract_Virtual_New_Void_AnimationStream_0;

	static IAnimationJob()
	{
		Il2CppClassPointerStore<IAnimationJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "IAnimationJob");
		NativeMethodInfoPtr_ProcessAnimation_Public_Abstract_Virtual_New_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationJob>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_ProcessRootMotion_Public_Abstract_Virtual_New_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationJob>.NativeClassPtr, 100664242);
	}

	[CallerCount(0)]
	public unsafe virtual void ProcessAnimation(AnimationStream stream)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessAnimation_Public_Abstract_Virtual_New_Void_AnimationStream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ProcessRootMotion(AnimationStream stream)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessRootMotion_Public_Abstract_Virtual_New_Void_AnimationStream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IAnimationJob(IntPtr pointer)
		: base(pointer)
	{
	}
}
