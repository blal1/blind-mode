using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509;

public class X520 : Il2CppSystem.Object
{
	public class AttributeTypeAndValue : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_oid;

		private static readonly System.IntPtr NativeFieldInfoPtr_attrValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_upperBound;

		private static readonly System.IntPtr NativeFieldInfoPtr_encoding;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0;

		public unsafe string oid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oid);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oid)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string attrValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attrValue);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attrValue)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int upperBound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperBound);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperBound)) = value;
			}
		}

		public unsafe byte encoding
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoding);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoding)) = value;
			}
		}

		public unsafe string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692649, XrefRangeEnd = 692660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static AttributeTypeAndValue()
		{
			Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "AttributeTypeAndValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr);
			NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, "oid");
			NativeFieldInfoPtr_attrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, "attrValue");
			NativeFieldInfoPtr_upperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, "upperBound");
			NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, "encoding");
			NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663528);
			NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663529);
			NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663530);
			NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663531);
			NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663532);
			NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr, 100663533);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692645, XrefRangeEnd = 692647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeTypeAndValue(string oid, int upperBound)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &upperBound;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692647, XrefRangeEnd = 692649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeTypeAndValue(string oid, int upperBound, byte encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeTypeAndValue>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &upperBound;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &encoding;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692697, RefRangeEnd = 692699, XrefRangeStart = 692660, XrefRangeEnd = 692697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 GetASN1(byte encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&encoding);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692699, XrefRangeEnd = 692700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 GetASN1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetASN1_Internal_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692700, XrefRangeEnd = 692702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte SelectBestEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public AttributeTypeAndValue(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CommonName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static CommonName()
		{
			Il2CppClassPointerStore<CommonName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "CommonName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonName>.NativeClassPtr, 100663534);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692702, XrefRangeEnd = 692706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CommonName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SerialNumber : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static SerialNumber()
		{
			Il2CppClassPointerStore<SerialNumber>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "SerialNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerialNumber>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerialNumber>.NativeClassPtr, 100663535);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692706, XrefRangeEnd = 692710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerialNumber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerialNumber>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SerialNumber(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class LocalityName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static LocalityName()
		{
			Il2CppClassPointerStore<LocalityName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "LocalityName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalityName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalityName>.NativeClassPtr, 100663536);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692710, XrefRangeEnd = 692714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalityName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalityName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LocalityName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class StateOrProvinceName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static StateOrProvinceName()
		{
			Il2CppClassPointerStore<StateOrProvinceName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "StateOrProvinceName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateOrProvinceName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOrProvinceName>.NativeClassPtr, 100663537);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692714, XrefRangeEnd = 692718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateOrProvinceName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateOrProvinceName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StateOrProvinceName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class OrganizationName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static OrganizationName()
		{
			Il2CppClassPointerStore<OrganizationName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "OrganizationName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganizationName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganizationName>.NativeClassPtr, 100663538);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692718, XrefRangeEnd = 692722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganizationName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganizationName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OrganizationName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class OrganizationalUnitName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static OrganizationalUnitName()
		{
			Il2CppClassPointerStore<OrganizationalUnitName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "OrganizationalUnitName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganizationalUnitName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganizationalUnitName>.NativeClassPtr, 100663539);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692722, XrefRangeEnd = 692726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganizationalUnitName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganizationalUnitName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OrganizationalUnitName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class EmailAddress : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static EmailAddress()
		{
			Il2CppClassPointerStore<EmailAddress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "EmailAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmailAddress>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmailAddress>.NativeClassPtr, 100663540);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692726, XrefRangeEnd = 692730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmailAddress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmailAddress>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public EmailAddress(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DomainComponent : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DomainComponent()
		{
			Il2CppClassPointerStore<DomainComponent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "DomainComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainComponent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainComponent>.NativeClassPtr, 100663541);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692730, XrefRangeEnd = 692734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DomainComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DomainComponent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DomainComponent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UserId : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static UserId()
		{
			Il2CppClassPointerStore<UserId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "UserId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserId>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserId>.NativeClassPtr, 100663542);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692734, XrefRangeEnd = 692738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserId()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserId>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UserId(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Oid : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		static Oid()
		{
			Il2CppClassPointerStore<Oid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Oid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Oid>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Oid>.NativeClassPtr, 100663543);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692738, XrefRangeEnd = 692740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Oid(string oid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Oid>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Oid(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Title : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static Title()
		{
			Il2CppClassPointerStore<Title>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Title");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Title>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Title>.NativeClassPtr, 100663544);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692740, XrefRangeEnd = 692744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Title()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Title>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Title(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CountryName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static CountryName()
		{
			Il2CppClassPointerStore<CountryName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "CountryName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountryName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountryName>.NativeClassPtr, 100663545);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692744, XrefRangeEnd = 692748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountryName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountryName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CountryName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DnQualifier : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DnQualifier()
		{
			Il2CppClassPointerStore<DnQualifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "DnQualifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DnQualifier>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DnQualifier>.NativeClassPtr, 100663546);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692748, XrefRangeEnd = 692752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DnQualifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DnQualifier>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DnQualifier(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Surname : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static Surname()
		{
			Il2CppClassPointerStore<Surname>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Surname");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Surname>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surname>.NativeClassPtr, 100663547);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692752, XrefRangeEnd = 692756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Surname()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Surname>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Surname(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GivenName : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static GivenName()
		{
			Il2CppClassPointerStore<GivenName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "GivenName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GivenName>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GivenName>.NativeClassPtr, 100663548);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692756, XrefRangeEnd = 692760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GivenName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GivenName>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public GivenName(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Initial : AttributeTypeAndValue
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static Initial()
		{
			Il2CppClassPointerStore<Initial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Initial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initial>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initial>.NativeClassPtr, 100663549);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692760, XrefRangeEnd = 692764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Initial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Initial>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Initial(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	static X520()
	{
		Il2CppClassPointerStore<X520>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X520");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520>.NativeClassPtr);
	}

	public X520(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
