using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine.Unity;

public class IHasSkeletonRenderer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_SkeletonRenderer_Public_Abstract_Virtual_New_get_SkeletonRenderer_0;

	public unsafe virtual SkeletonRenderer SkeletonRenderer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_SkeletonRenderer_Public_Abstract_Virtual_New_get_SkeletonRenderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SkeletonRenderer>(intPtr2) : null;
		}
	}

	static IHasSkeletonRenderer()
	{
		Il2CppClassPointerStore<IHasSkeletonRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "IHasSkeletonRenderer");
		NativeMethodInfoPtr_get_SkeletonRenderer_Public_Abstract_Virtual_New_get_SkeletonRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasSkeletonRenderer>.NativeClassPtr, 100664046);
	}

	public IHasSkeletonRenderer(IntPtr pointer)
		: base(pointer)
	{
	}
}
