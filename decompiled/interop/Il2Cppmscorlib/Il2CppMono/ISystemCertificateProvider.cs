using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono;

public class ISystemCertificateProvider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0;

	static ISystemCertificateProvider()
	{
		Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "ISystemCertificateProvider");
		NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISystemCertificateProvider>.NativeClassPtr, 100663368);
	}

	[CallerCount(0)]
	public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual X509CertificateImpl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		*(X509KeyStorageFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &keyStorageFlags;
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cert);
		*(CertificateImportFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &importFlags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_X509CertificateImpl_X509Certificate_CertificateImportFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	public ISystemCertificateProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
