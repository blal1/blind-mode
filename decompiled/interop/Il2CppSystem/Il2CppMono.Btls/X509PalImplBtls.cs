using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppMono.Security.Interface;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Btls;

public class X509PalImplBtls : X509PalImpl
{
	private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0;

	public unsafe MonoBtlsProvider _Provider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Provider_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsProvider>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Provider_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MonoBtlsProvider Provider
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsProvider>(intPtr2) : null;
		}
	}

	static X509PalImplBtls()
	{
		Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "X509PalImplBtls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr);
		NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, "<Provider>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_get_Provider_Private_get_MonoBtlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr, 100664109);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868464, RefRangeEnd = 868465, XrefRangeStart = 868449, XrefRangeEnd = 868464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509PalImplBtls(MonoTlsProvider provider)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509PalImplBtls>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868465, XrefRangeEnd = 868466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override X509CertificateImpl Import(Il2CppStructArray<byte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Virtual_X509CertificateImpl_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868466, XrefRangeEnd = 868468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override X509Certificate2Impl Import(Il2CppStructArray<byte> data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		*(X509KeyStorageFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &keyStorageFlags;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_Il2CppStructArray_1_Byte_SafePasswordHandle_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868468, XrefRangeEnd = 868470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override X509Certificate2Impl Import(X509Certificate cert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cert);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Import_Public_Virtual_X509Certificate2Impl_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr2) : null;
	}

	public X509PalImplBtls(IntPtr pointer)
		: base(pointer)
	{
	}
}
