using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems;

public class IInitializePotentialDragHandler : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;

	static IInitializePotentialDragHandler()
	{
		Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IInitializePotentialDragHandler");
		NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr, 100664904);
	}

	[CallerCount(0)]
	public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IInitializePotentialDragHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
