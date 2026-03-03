using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public static class X509Helper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

	public unsafe static ISystemCertificateProvider CertificateProvider
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 788874, RefRangeEnd = 788880, XrefRangeStart = 788863, XrefRangeEnd = 788874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr2) : null;
		}
	}

	static X509Helper()
	{
		Il2CppClassPointerStore<X509Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Helper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper>.NativeClassPtr);
		NativeMethodInfoPtr_get_CertificateProvider_Private_Static_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669695);
		NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669696);
		NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669697);
		NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669698);
		NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669699);
		NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669700);
		NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669701);
		NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100669702);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788880, XrefRangeEnd = 788886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static X509CertificateImpl InitFromCertificate(X509Certificate cert)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cert);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509Certificate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsValid(X509CertificateImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 788886, RefRangeEnd = 788887, XrefRangeStart = 788886, XrefRangeEnd = 788886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 788894, RefRangeEnd = 788903, XrefRangeStart = 788887, XrefRangeEnd = 788894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetInvalidContextException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 788903, XrefRangeEnd = 788909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 788913, RefRangeEnd = 788914, XrefRangeStart = 788909, XrefRangeEnd = 788913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		*(X509KeyStorageFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyStorageFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	public X509Helper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
