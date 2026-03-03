using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems;

public class IUpdateSelectedHandler : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0;

	static IUpdateSelectedHandler()
	{
		Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IUpdateSelectedHandler");
		NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr, 100664909);
	}

	[CallerCount(0)]
	public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IUpdateSelectedHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
