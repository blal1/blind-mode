using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class ICredentials : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0;

	static ICredentials()
	{
		Il2CppClassPointerStore<ICredentials>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICredentials");
		NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICredentials>.NativeClassPtr, 100666129);
	}

	[CallerCount(0)]
	public unsafe virtual NetworkCredential GetCredential(Uri uri, string authType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(authType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCredential_Public_Abstract_Virtual_New_NetworkCredential_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
	}

	public ICredentials(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
