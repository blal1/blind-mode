using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;

namespace Il2CppSystem;

public class ITupleInternal : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0;

	static ITupleInternal()
	{
		Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ITupleInternal");
		NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr, 100665859);
	}

	[CallerCount(0)]
	public unsafe virtual string ToString(StringBuilder sb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public ITupleInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
