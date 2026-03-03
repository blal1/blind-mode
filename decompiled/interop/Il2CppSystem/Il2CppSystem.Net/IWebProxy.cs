using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class IWebProxy : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0;

	public unsafe virtual ICredentials Credentials
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
		}
	}

	static IWebProxy()
	{
		Il2CppClassPointerStore<IWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebProxy");
		NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100666518);
		NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100666519);
		NativeMethodInfoPtr_get_Credentials_Public_Abstract_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebProxy>.NativeClassPtr, 100666520);
	}

	[CallerCount(0)]
	public unsafe virtual Uri GetProxy(Uri destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProxy_Public_Abstract_Virtual_New_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool IsBypassed(Uri host)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)host);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsBypassed_Public_Abstract_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IWebProxy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
