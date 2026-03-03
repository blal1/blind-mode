using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public class IAsyncLocal : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0;

	static IAsyncLocal()
	{
		Il2CppClassPointerStore<IAsyncLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "IAsyncLocal");
		NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncLocal>.NativeClassPtr, 100667551);
	}

	[CallerCount(0)]
	public unsafe virtual void OnValueChanged(Object previousValue, Object currentValue, bool contextChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentValue);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &contextChanged;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnValueChanged_Public_Abstract_Virtual_New_Void_Object_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IAsyncLocal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
