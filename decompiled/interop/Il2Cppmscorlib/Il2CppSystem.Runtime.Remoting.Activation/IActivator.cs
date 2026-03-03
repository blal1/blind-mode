using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation;

public class IActivator : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0;

	public unsafe virtual IActivator NextActivator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
		}
	}

	static IActivator()
	{
		Il2CppClassPointerStore<IActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IActivator");
		NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100670209);
		NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100670210);
	}

	[CallerCount(0)]
	public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr2) : null;
	}

	public IActivator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
