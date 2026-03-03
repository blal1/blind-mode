using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net;

public class ICertificatePolicy : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0;

	static ICertificatePolicy()
	{
		Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICertificatePolicy");
		NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr, 100666128);
	}

	[CallerCount(0)]
	public unsafe virtual bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srvPoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &certificateProblem;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ICertificatePolicy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
