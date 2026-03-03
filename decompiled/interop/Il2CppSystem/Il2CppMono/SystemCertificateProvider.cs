using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono;

public class SystemCertificateProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_provider;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_x509pal;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncRoot;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MonoTlsProvider provider
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_provider, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_provider, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int initialized
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initialized, (void*)(&value));
		}
	}

	public unsafe static X509PalImpl x509pal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_x509pal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_x509pal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Object syncRoot
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_syncRoot, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_syncRoot, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe X509PalImpl X509Pal
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 862286, RefRangeEnd = 862296, XrefRangeStart = 862281, XrefRangeEnd = 862286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
		}
	}

	static SystemCertificateProvider()
	{
		Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "SystemCertificateProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr);
		NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "provider");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_x509pal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "x509pal");
		NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, "syncRoot");
		NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr, 100663305);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 862253, RefRangeEnd = 862254, XrefRangeStart = 862230, XrefRangeEnd = 862253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static X509PalImpl GetX509Pal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetX509Pal_Private_Static_X509PalImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 862278, RefRangeEnd = 862281, XrefRangeStart = 862254, XrefRangeEnd = 862278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureInitialized()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureInitialized_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862296, XrefRangeEnd = 862299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862299, XrefRangeEnd = 862303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual X509CertificateImpl Mono_ISystemCertificateProvider_Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		*(X509KeyStorageFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyStorageFlags;
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862303, XrefRangeEnd = 862307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509Certificate2Impl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		*(X509KeyStorageFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyStorageFlags;
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862307, XrefRangeEnd = 862314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual X509CertificateImpl Mono_ISystemCertificateProvider_Import(X509Certificate cert, CertificateImportFlags importFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cert);
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mono_ISystemCertificateProvider_Import_Private_Virtual_Final_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862314, XrefRangeEnd = 862321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cert);
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_X509Certificate2Impl_X509Certificate_CertificateImportFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SystemCertificateProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemCertificateProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SystemCertificateProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
