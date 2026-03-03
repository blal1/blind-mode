using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.InputSystem.UI;

public class INavigationEventData : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_device_Public_Abstract_Virtual_New_get_InputDevice_0;

	public unsafe virtual InputDevice device
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_device_Public_Abstract_Virtual_New_get_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
		}
	}

	static INavigationEventData()
	{
		Il2CppClassPointerStore<INavigationEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "INavigationEventData");
		NativeMethodInfoPtr_get_device_Public_Abstract_Virtual_New_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavigationEventData>.NativeClassPtr, 100666710);
	}

	public INavigationEventData(IntPtr pointer)
		: base(pointer)
	{
	}
}
