using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls;

public class MonoBtlsX509Name : MonoBtlsObject
{
	public class BoringX509NameHandle : MonoBtlsHandle
	{
		private static readonly IntPtr NativeFieldInfoPtr_dontFree;

		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		public unsafe bool dontFree
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontFree);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontFree)) = value;
			}
		}

		static BoringX509NameHandle()
		{
			Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, "BoringX509NameHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr);
			NativeFieldInfoPtr_dontFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr, "dontFree");
			NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr, 100664011);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr, 100664012);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867462, XrefRangeEnd = 867463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoringX509NameHandle(IntPtr handle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoringX509NameHandle>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[2];
			*ptr = (nint)(&handle);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &ownsHandle;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867463, XrefRangeEnd = 867465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringX509NameHandle(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHash_Public_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEntryCount_Public_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0;

	public new unsafe BoringX509NameHandle Handle
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 867484, RefRangeEnd = 867492, XrefRangeStart = 867481, XrefRangeEnd = 867484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringX509NameHandle>(intPtr2) : null;
		}
	}

	static MonoBtlsX509Name()
	{
		Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Name");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr);
		NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509NameHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_GetHash_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_GetEntryCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr, 100664010);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867465, XrefRangeEnd = 867467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long mono_btls_x509_name_hash(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_hash_Private_Static_Int64_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867467, XrefRangeEnd = 867469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_name_get_entry_count(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_get_entry_count_Private_Static_Int32_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867469, XrefRangeEnd = 867471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_get_entry_type_Private_Static_MonoBtlsX509NameEntryType_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoBtlsX509NameEntryType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867471, XrefRangeEnd = 867473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		*(IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &size;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_Private_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867473, XrefRangeEnd = 867475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_get_entry_oid_data_Private_Static_Int32_IntPtr_Int32_byref_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867475, XrefRangeEnd = 867477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref tag);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref str);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_get_entry_value_Private_Static_Int32_IntPtr_Int32_byref_Int32_byref_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867477, XrefRangeEnd = 867479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &len;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &use_canon_enc;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_from_data_Private_Static_IntPtr_ptr_Void_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867479, XrefRangeEnd = 867481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_x509_name_free(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_name_free_Private_Static_Void_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 628864, RefRangeEnd = 628865, XrefRangeStart = 628864, XrefRangeEnd = 628865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Name(BoringX509NameHandle handle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Name>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BoringX509NameHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867495, RefRangeEnd = 867497, XrefRangeStart = 867492, XrefRangeEnd = 867495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHash_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 867500, RefRangeEnd = 867505, XrefRangeStart = 867497, XrefRangeEnd = 867500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetEntryCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867505, XrefRangeEnd = 867509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509NameEntryType GetEntryType(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryType_Public_MonoBtlsX509NameEntryType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoBtlsX509NameEntryType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867530, RefRangeEnd = 867531, XrefRangeStart = 867509, XrefRangeEnd = 867530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEntryOid(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryOid_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867531, XrefRangeEnd = 867544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> GetEntryOidData(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryOidData_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867557, RefRangeEnd = 867558, XrefRangeStart = 867544, XrefRangeEnd = 867557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEntryValue(int index, out int tag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref tag);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryValue_Public_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867558, XrefRangeEnd = 867569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoBtlsX509Name CreateFromData(Il2CppStructArray<byte> data, bool use_canon_enc)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &use_canon_enc;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromData_Public_Static_MonoBtlsX509Name_Il2CppStructArray_1_Byte_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Name>(intPtr2) : null;
	}

	public MonoBtlsX509Name(IntPtr pointer)
		: base(pointer)
	{
	}
}
