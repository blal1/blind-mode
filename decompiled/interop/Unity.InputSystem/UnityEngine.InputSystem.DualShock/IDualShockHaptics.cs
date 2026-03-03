using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.InputSystem.DualShock;

public class IDualShockHaptics : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetLightBarColor_Public_Abstract_Virtual_New_Void_Color_0;

	static IDualShockHaptics()
	{
		Il2CppClassPointerStore<IDualShockHaptics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock", "IDualShockHaptics");
		NativeMethodInfoPtr_SetLightBarColor_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDualShockHaptics>.NativeClassPtr, 100667262);
	}

	[CallerCount(0)]
	public unsafe virtual void SetLightBarColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLightBarColor_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDualShockHaptics(IntPtr pointer)
		: base(pointer)
	{
	}
}
