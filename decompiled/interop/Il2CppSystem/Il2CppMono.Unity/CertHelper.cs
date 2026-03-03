using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity;

public static class CertHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0;

	static CertHelper()
	{
		Il2CppClassPointerStore<CertHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "CertHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertHelper>.NativeClassPtr);
		NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertHelper>.NativeClassPtr, 100663332);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 862492, RefRangeEnd = 862494, XrefRangeStart = 862480, XrefRangeEnd = 862492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)nativeCertificateChain;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificates);
		*(UnityTls.unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCertificatesToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509CertificateCollection_ptr_unitytls_errorstate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 862508, RefRangeEnd = 862511, XrefRangeStart = 862494, XrefRangeEnd = 862508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)nativeCertificateChain;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		*(UnityTls.unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCertificateToNativeChain_Public_Static_Void_ptr_unitytls_x509list_X509Certificate_ptr_unitytls_errorstate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CertHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
