using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Accessibility;

public class IAccessibilityNotificationDispatcher : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SendScreenChanged_Public_Abstract_Virtual_New_Void_AccessibilityNode_0;

	static IAccessibilityNotificationDispatcher()
	{
		Il2CppClassPointerStore<IAccessibilityNotificationDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "IAccessibilityNotificationDispatcher");
		NativeMethodInfoPtr_SendScreenChanged_Public_Abstract_Virtual_New_Void_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAccessibilityNotificationDispatcher>.NativeClassPtr, 100663426);
	}

	[CallerCount(0)]
	public unsafe virtual void SendScreenChanged(AccessibilityNode nodeToFocus = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeToFocus);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SendScreenChanged_Public_Abstract_Virtual_New_Void_AccessibilityNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IAccessibilityNotificationDispatcher(IntPtr pointer)
		: base(pointer)
	{
	}
}
