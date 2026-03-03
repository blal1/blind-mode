using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls;

public class MonoBtlsX509 : MonoBtlsObject
{
	public class BoringX509Handle : MonoBtlsHandle
	{
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		private static readonly IntPtr NativeMethodInfoPtr_StealHandle_Public_IntPtr_0;

		static BoringX509Handle()
		{
			Il2CppClassPointerStore<BoringX509Handle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, "BoringX509Handle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringX509Handle>.NativeClassPtr);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509Handle>.NativeClassPtr, 100663944);
			NativeMethodInfoPtr_StealHandle_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509Handle>.NativeClassPtr, 100663945);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866980, XrefRangeEnd = 866982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866982, XrefRangeEnd = 866983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr StealHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StealHandle_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringX509Handle(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0;

	private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0;

	private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0;

	public new unsafe BoringX509Handle Handle
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 866986, RefRangeEnd = 867001, XrefRangeStart = 866983, XrefRangeEnd = 866986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringX509Handle>(intPtr2) : null;
		}
	}

	static MonoBtlsX509()
	{
		Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr);
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr, 100663942);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 628864, RefRangeEnd = 628865, XrefRangeStart = 628864, XrefRangeEnd = 628865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509(BoringX509Handle handle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BoringX509Handle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867001, XrefRangeEnd = 867003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_up_ref(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_up_ref_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867003, XrefRangeEnd = 867005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &len;
		*(MonoBtlsX509Format**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &format;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_from_data_Private_Static_IntPtr_IntPtr_Int32_MonoBtlsX509Format_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867005, XrefRangeEnd = 867007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_get_subject_name(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_get_subject_name_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867007, XrefRangeEnd = 867009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&handle);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &bio;
		*(MonoBtlsX509Format**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &format;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_get_raw_data_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509Format_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867009, XrefRangeEnd = 867011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_cmp(IntPtr a, IntPtr b)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&a);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_cmp_Private_Static_Int32_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867011, XrefRangeEnd = 867013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_x509_free(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_free_Private_Static_Void_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867013, XrefRangeEnd = 867015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&handle);
		*(MonoBtlsX509TrustKind**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &kind;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_add_explicit_trust_Private_Static_Int32_IntPtr_MonoBtlsX509TrustKind_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 867029, RefRangeEnd = 867039, XrefRangeStart = 867015, XrefRangeEnd = 867029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509 Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr2) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 867063, RefRangeEnd = 867074, XrefRangeStart = 867039, XrefRangeEnd = 867063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoBtlsX509 LoadFromData(Il2CppStructArray<byte> buffer, MonoBtlsX509Format format)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(MonoBtlsX509Format**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &format;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromData_Public_Static_MonoBtlsX509_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867074, XrefRangeEnd = 867088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Name GetSubjectName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubjectName_Public_MonoBtlsX509Name_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Name>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867110, RefRangeEnd = 867111, XrefRangeStart = 867088, XrefRangeEnd = 867110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetSubjectNameHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubjectNameHash_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867129, RefRangeEnd = 867131, XrefRangeStart = 867111, XrefRangeEnd = 867129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> GetRawData(MonoBtlsX509Format format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRawData_Public_Il2CppStructArray_1_Byte_MonoBtlsX509Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867135, RefRangeEnd = 867136, XrefRangeStart = 867131, XrefRangeEnd = 867135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(MonoBtlsX509 a, MonoBtlsX509 b)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_MonoBtlsX509_MonoBtlsX509_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867136, XrefRangeEnd = 867144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddExplicitTrust(MonoBtlsX509TrustKind kind)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&kind);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddExplicitTrust_Public_Void_MonoBtlsX509TrustKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MonoBtlsX509(IntPtr pointer)
		: base(pointer)
	{
	}
}
