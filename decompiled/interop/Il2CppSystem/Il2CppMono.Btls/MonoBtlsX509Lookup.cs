using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Btls;

public class MonoBtlsX509Lookup : MonoBtlsObject
{
	public class BoringX509LookupHandle : MonoBtlsHandle
	{
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		static BoringX509LookupHandle()
		{
			Il2CppClassPointerStore<BoringX509LookupHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "BoringX509LookupHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringX509LookupHandle>.NativeClassPtr);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509LookupHandle>.NativeClassPtr, 100663975);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867219, XrefRangeEnd = 867221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringX509LookupHandle(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeFieldInfoPtr_store;

	private static readonly IntPtr NativeFieldInfoPtr_type;

	private static readonly IntPtr NativeFieldInfoPtr_monoLookups;

	private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0;

	private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

	public unsafe MonoBtlsX509Store store
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Store>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MonoBtlsX509LookupType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(MonoBtlsX509LookupType*)num;
		}
		set
		{
			*(MonoBtlsX509LookupType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = value;
		}
	}

	public unsafe List<MonoBtlsX509LookupMono> monoLookups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monoLookups);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MonoBtlsX509LookupMono>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monoLookups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public new unsafe BoringX509LookupHandle Handle
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 867224, RefRangeEnd = 867228, XrefRangeStart = 867221, XrefRangeEnd = 867224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringX509LookupHandle>(intPtr2) : null;
		}
	}

	static MonoBtlsX509Lookup()
	{
		Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Lookup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr);
		NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "store");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "type");
		NativeFieldInfoPtr_monoLookups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "monoLookups");
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663973);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867228, XrefRangeEnd = 867230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&store);
		*(MonoBtlsX509LookupType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867230, XrefRangeEnd = 867232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&handle);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dir;
		*(MonoBtlsX509FileType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867232, XrefRangeEnd = 867234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&handle);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &monoLookup;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867234, XrefRangeEnd = 867236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_x509_lookup_free(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867236, XrefRangeEnd = 867238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867238, XrefRangeEnd = 867245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)store);
		*(MonoBtlsX509LookupType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringX509LookupHandle>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867254, RefRangeEnd = 867256, XrefRangeStart = 867245, XrefRangeEnd = 867254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)store);
		*(MonoBtlsX509LookupType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867256, XrefRangeEnd = 867259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntPtr GetNativeLookup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867274, RefRangeEnd = 867275, XrefRangeStart = 867259, XrefRangeEnd = 867274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDirectory(string dir, MonoBtlsX509FileType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		*(MonoBtlsX509FileType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867306, RefRangeEnd = 867307, XrefRangeStart = 867275, XrefRangeEnd = 867306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMono(MonoBtlsX509LookupMono monoLookup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monoLookup);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867307, XrefRangeEnd = 867315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCertificate(MonoBtlsX509 certificate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867315, XrefRangeEnd = 867334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MonoBtlsX509Lookup(IntPtr pointer)
		: base(pointer)
	{
	}
}
