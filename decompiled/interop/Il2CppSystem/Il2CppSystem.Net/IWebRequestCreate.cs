using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class IWebRequestCreate : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0;

	static IWebRequestCreate()
	{
		Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebRequestCreate");
		NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr, 100666136);
	}

	[CallerCount(0)]
	public unsafe virtual WebRequest Create(Uri uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
	}

	public IWebRequestCreate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
