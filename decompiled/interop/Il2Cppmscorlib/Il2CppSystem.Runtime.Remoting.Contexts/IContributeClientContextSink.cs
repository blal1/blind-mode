using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts;

public class IContributeClientContextSink : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;

	static IContributeClientContextSink()
	{
		Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeClientContextSink");
		NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr, 100670134);
	}

	[CallerCount(0)]
	public unsafe virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nextSink);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
	}

	public IContributeClientContextSink(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
