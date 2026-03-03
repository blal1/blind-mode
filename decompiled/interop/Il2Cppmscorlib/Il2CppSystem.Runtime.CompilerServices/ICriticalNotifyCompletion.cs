using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

public class ICriticalNotifyCompletion : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0;

	static ICriticalNotifyCompletion()
	{
		Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ICriticalNotifyCompletion");
		NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr, 100671393);
	}

	[CallerCount(0)]
	public unsafe virtual void UnsafeOnCompleted(Action continuation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ICriticalNotifyCompletion(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
