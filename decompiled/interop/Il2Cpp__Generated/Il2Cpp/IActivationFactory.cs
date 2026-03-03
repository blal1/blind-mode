using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class IActivationFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0;

	static IActivationFactory()
	{
		Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("__Generated.dll", "", "IActivationFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr);
		NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivationFactory>.NativeClassPtr, 100663297);
	}

	[CallerCount(0)]
	public unsafe override Il2CppSystem.Object ActivateInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActivateInstance_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public IActivationFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
