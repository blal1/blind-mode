using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppMono.Btls;

public class MonoBtlsPkcs12 : MonoBtlsObject
{
	public class BoringPkcs12Handle : MonoBtlsHandle
	{
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		static BoringPkcs12Handle()
		{
			Il2CppClassPointerStore<BoringPkcs12Handle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, "BoringPkcs12Handle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringPkcs12Handle>.NativeClassPtr);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringPkcs12Handle>.NativeClassPtr, 100663797);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865741, XrefRangeEnd = 865743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringPkcs12Handle(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeFieldInfoPtr_privateKey;

	private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0;

	public unsafe MonoBtlsKey privateKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateKey);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public new unsafe BoringPkcs12Handle Handle
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 865746, RefRangeEnd = 865753, XrefRangeStart = 865743, XrefRangeEnd = 865746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringPkcs12Handle>(intPtr2) : null;
		}
	}

	public unsafe int Count
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 865781, RefRangeEnd = 865783, XrefRangeStart = 865778, XrefRangeEnd = 865781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HasPrivateKey
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865821, RefRangeEnd = 865822, XrefRangeStart = 865818, XrefRangeEnd = 865821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MonoBtlsPkcs12()
	{
		Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsPkcs12");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr);
		NativeFieldInfoPtr_privateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, "privateKey");
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringPkcs12Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663783);
		NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663785);
		NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663786);
		NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663789);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663790);
		NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663791);
		NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663792);
		NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663793);
		NativeMethodInfoPtr_get_HasPrivateKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663794);
		NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr, 100663795);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865753, XrefRangeEnd = 865755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_pkcs12_free(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_free_Private_Static_Void_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865755, XrefRangeEnd = 865757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_pkcs12_new()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_new_Private_Static_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865757, XrefRangeEnd = 865759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_pkcs12_get_count(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_get_count_Private_Static_Int32_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865759, XrefRangeEnd = 865761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&Handle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_get_cert_Private_Static_IntPtr_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865761, XrefRangeEnd = 865765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&chain);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = data;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &len;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_import_Private_Static_Int32_IntPtr_ptr_Void_Int32_SafePasswordHandle_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865765, XrefRangeEnd = 865767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pkcs12);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_has_private_key_Private_Static_Int32_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865767, XrefRangeEnd = 865769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&pkcs12);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_pkcs12_get_private_key_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 865777, RefRangeEnd = 865778, XrefRangeStart = 865769, XrefRangeEnd = 865777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsPkcs12()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsPkcs12>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 865800, RefRangeEnd = 865802, XrefRangeStart = 865783, XrefRangeEnd = 865800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509 GetCertificate(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 865815, RefRangeEnd = 865818, XrefRangeStart = 865802, XrefRangeEnd = 865815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Import(Il2CppStructArray<byte> buffer, SafePasswordHandle password)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)password);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_Void_Il2CppStructArray_1_Byte_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 865841, RefRangeEnd = 865842, XrefRangeStart = 865822, XrefRangeEnd = 865841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsKey GetPrivateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrivateKey_Public_MonoBtlsKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsKey>(intPtr2) : null;
	}

	public MonoBtlsPkcs12(IntPtr pointer)
		: base(pointer)
	{
	}
}
