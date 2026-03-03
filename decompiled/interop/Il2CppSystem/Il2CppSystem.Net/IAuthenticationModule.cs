using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class IAuthenticationModule : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;

	public unsafe virtual string AuthenticationType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static IAuthenticationModule()
	{
		Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IAuthenticationModule");
		NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100666125);
		NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100666126);
		NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAuthenticationModule>.NativeClassPtr, 100666127);
	}

	[CallerCount(0)]
	public unsafe virtual Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Authenticate_Public_Abstract_Virtual_New_Authorization_String_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Authorization>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PreAuthenticate_Public_Abstract_Virtual_New_Authorization_WebRequest_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Authorization>(intPtr2) : null;
	}

	public IAuthenticationModule(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
