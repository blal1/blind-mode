using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net;

public class ICloseEx : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0;

	static ICloseEx()
	{
		Il2CppClassPointerStore<ICloseEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICloseEx");
		NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloseEx>.NativeClassPtr, 100666297);
	}

	[CallerCount(0)]
	public unsafe virtual void CloseEx(CloseExState closeState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeState);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ICloseEx(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
