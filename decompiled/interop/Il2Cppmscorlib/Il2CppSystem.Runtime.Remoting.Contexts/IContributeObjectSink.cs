using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts;

public class IContributeObjectSink : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0;

	static IContributeObjectSink()
	{
		Il2CppClassPointerStore<IContributeObjectSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeObjectSink");
		NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeObjectSink>.NativeClassPtr, 100670137);
	}

	[CallerCount(0)]
	public unsafe virtual IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nextSink);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
	}

	public IContributeObjectSink(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
