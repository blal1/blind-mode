using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine.Unity;

public class ISkeletonAnimation : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAnimationRebuild_Public_Abstract_Virtual_New_add_Void_ISkeletonAnimationDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAnimationRebuild_Public_Abstract_Virtual_New_rem_Void_ISkeletonAnimationDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_add_UpdateLocal_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_UpdateLocal_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_add_UpdateWorld_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_UpdateWorld_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_add_UpdateComplete_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_UpdateComplete_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTiming_Public_Abstract_Virtual_New_get_UpdateTiming_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTiming_Public_Abstract_Virtual_New_set_Void_UpdateTiming_0;

	public unsafe virtual Skeleton Skeleton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Skeleton>(intPtr2) : null;
		}
	}

	public unsafe virtual UpdateTiming UpdateTiming
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_UpdateTiming_Public_Abstract_Virtual_New_get_UpdateTiming_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UpdateTiming*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_UpdateTiming_Public_Abstract_Virtual_New_set_Void_UpdateTiming_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ISkeletonAnimation()
	{
		Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "ISkeletonAnimation");
		NativeMethodInfoPtr_add_OnAnimationRebuild_Public_Abstract_Virtual_New_add_Void_ISkeletonAnimationDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_remove_OnAnimationRebuild_Public_Abstract_Virtual_New_rem_Void_ISkeletonAnimationDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_add_UpdateLocal_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_remove_UpdateLocal_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_add_UpdateWorld_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_remove_UpdateWorld_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_add_UpdateComplete_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_remove_UpdateComplete_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_get_UpdateTiming_Public_Abstract_Virtual_New_get_UpdateTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_set_UpdateTiming_Public_Abstract_Virtual_New_set_Void_UpdateTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkeletonAnimation>.NativeClassPtr, 100664039);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_OnAnimationRebuild(ISkeletonAnimationDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_OnAnimationRebuild_Public_Abstract_Virtual_New_add_Void_ISkeletonAnimationDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_OnAnimationRebuild(ISkeletonAnimationDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_OnAnimationRebuild_Public_Abstract_Virtual_New_rem_Void_ISkeletonAnimationDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_UpdateLocal(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_UpdateLocal_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_UpdateLocal(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_UpdateLocal_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_UpdateWorld(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_UpdateWorld_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_UpdateWorld(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_UpdateWorld_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_UpdateComplete(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_UpdateComplete_Public_Abstract_Virtual_New_add_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_UpdateComplete(UpdateBonesDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_UpdateComplete_Public_Abstract_Virtual_New_rem_Void_UpdateBonesDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ISkeletonAnimation(IntPtr pointer)
		: base(pointer)
	{
	}
}
