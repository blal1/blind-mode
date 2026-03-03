using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts;

public class IContributeDynamicSink : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0;

	static IContributeDynamicSink()
	{
		Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeDynamicSink");
		NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeDynamicSink>.NativeClassPtr, 100670135);
	}

	[CallerCount(0)]
	public unsafe virtual IDynamicMessageSink GetDynamicSink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDynamicSink_Public_Abstract_Virtual_New_IDynamicMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr2) : null;
	}

	public IContributeDynamicSink(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
