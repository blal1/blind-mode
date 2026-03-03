using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public class IFormatProvider : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0;

	static IFormatProvider()
	{
		Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IFormatProvider");
		NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr, 100665199);
	}

	[CallerCount(0)]
	public unsafe virtual Object GetFormat(Type formatType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public IFormatProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
