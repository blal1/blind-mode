using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class IConsoleDriver : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0;

	static IConsoleDriver()
	{
		Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IConsoleDriver");
		NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr, 100667125);
	}

	[CallerCount(0)]
	public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intercept);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IConsoleDriver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
