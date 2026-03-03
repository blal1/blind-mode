using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity;

public static class UnityTlsConversions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0;

	static UnityTlsConversions()
	{
		Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsConversions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr);
		NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663443);
	}

	[CallerCount(0)]
	public unsafe static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&protocols);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityTls.unitytls_protocol*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&protocols);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityTls.unitytls_protocol*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&protocol);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TlsProtocols*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&verifyResult);
		*(AlertDescription**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultAlert;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AlertDescription*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&verifyResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SslPolicyErrors*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&verifyResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(X509ChainStatusFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UnityTlsConversions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
