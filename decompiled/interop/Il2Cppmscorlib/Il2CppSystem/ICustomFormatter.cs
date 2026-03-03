using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class ICustomFormatter : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0;

	static ICustomFormatter()
	{
		Il2CppClassPointerStore<ICustomFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ICustomFormatter");
		NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomFormatter>.NativeClassPtr, 100665196);
	}

	[CallerCount(0)]
	public unsafe virtual string Format(string format, Object arg, IFormatProvider formatProvider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public ICustomFormatter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
