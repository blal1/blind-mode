using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public class DatatypeImplementation : XmlSchemaDatatype
{
	public class SchemaDatatypeMap : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe DatatypeImplementation type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int parentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentIndex)) = value;
			}
		}

		public unsafe string Name
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe int ParentIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static SchemaDatatypeMap()
		{
			Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "SchemaDatatypeMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, "name");
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, "type");
			NativeFieldInfoPtr_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, "parentIndex");
			NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666194);
			NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666195);
			NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666196);
			NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666197);
			NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666198);
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr, 100666199);
		}

		[CallerCount(138)]
		[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141736, XrefRangeStart = 141598, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDatatypeMap>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 922492, RefRangeEnd = 922543, XrefRangeStart = 922492, XrefRangeEnd = 922492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DatatypeImplementation(SchemaDatatypeMap sdm)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sdm);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922543, XrefRangeEnd = 922546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public SchemaDatatypeMap(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_variety;

	private static readonly System.IntPtr NativeFieldInfoPtr_restriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueConverter;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentSchemaType;

	private static readonly System.IntPtr NativeFieldInfoPtr_builtinTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_enumToTypeCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_anySimpleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_anyAtomicType;

	private static readonly System.IntPtr NativeFieldInfoPtr_untypedAtomicType;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearMonthDurationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayTimeDurationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalizedStringTypeV1Compat;

	private static readonly System.IntPtr NativeFieldInfoPtr_tokenTypeV1Compat;

	private static readonly System.IntPtr NativeFieldInfoPtr_QnAnySimpleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_QnAnyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_stringFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_numeric2FacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_binaryFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateTimeFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_durationFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_listFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_qnameFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_unionFacetsChecker;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_anySimpleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_anyURI;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_base64Binary;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_boolean;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_byte;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_char;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_date;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_dateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_dateTimeNoTz;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_dateTimeTz;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_day;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_decimal;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_double;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_doubleXdr;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_ENTITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_ENTITIES;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_ENUMERATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_fixed;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_float;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_floatXdr;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_hexBinary;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_IDREF;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_IDREFS;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_int;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_integer;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_long;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_month;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_monthDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_NCName;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_negativeInteger;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_NMTOKEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_NMTOKENS;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_nonNegativeInteger;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_nonPositiveInteger;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_normalizedString;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_NOTATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_positiveInteger;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_QName;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_QNameXdr;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_short;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_string;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_timeNoTz;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_timeTz;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_token;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_unsignedByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_unsignedInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_unsignedLong;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_unsignedShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_uuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_year;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_yearMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_normalizedStringV1Compat;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_tokenV1Compat;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_anyAtomicType;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_dayTimeDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_untypedAtomicType;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_yearMonthDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_tokenizedTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_tokenizedTypesXsd;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_XdrTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_XsdTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeName_Internal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe XmlSchemaDatatypeVariety variety
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variety);
			return *(XmlSchemaDatatypeVariety*)num;
		}
		set
		{
			*(XmlSchemaDatatypeVariety*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variety)) = value;
		}
	}

	public unsafe RestrictionFacets restriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restriction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DatatypeImplementation baseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlValueConverter valueConverter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueConverter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueConverter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaType parentSchemaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentSchemaType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentSchemaType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable builtinTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_builtinTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_builtinTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> enumToTypeCode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enumToTypeCode, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enumToTypeCode, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType anySimpleType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_anySimpleType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_anySimpleType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType anyAtomicType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_anyAtomicType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_anyAtomicType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType untypedAtomicType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_untypedAtomicType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_untypedAtomicType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType yearMonthDurationType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yearMonthDurationType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yearMonthDurationType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType dayTimeDurationType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dayTimeDurationType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dayTimeDurationType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType normalizedStringTypeV1Compat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normalizedStringTypeV1Compat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normalizedStringTypeV1Compat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType tokenTypeV1Compat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tokenTypeV1Compat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tokenTypeV1Compat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlQualifiedName QnAnySimpleType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QnAnySimpleType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QnAnySimpleType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlQualifiedName QnAnyType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QnAnyType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QnAnyType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker stringFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stringFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stringFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker miscFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_miscFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_miscFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker numeric2FacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numeric2FacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numeric2FacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker binaryFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_binaryFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_binaryFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker dateTimeFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dateTimeFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dateTimeFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker durationFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_durationFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_durationFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker listFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker qnameFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_qnameFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_qnameFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static FacetsChecker unionFacetsChecker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unionFacetsChecker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unionFacetsChecker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_anySimpleType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_anySimpleType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_anySimpleType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_anyURI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_anyURI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_anyURI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_base64Binary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_base64Binary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_base64Binary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_boolean
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_boolean, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_boolean, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_byte
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_byte, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_byte, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_char
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_char, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_char, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_date
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_date, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_date, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_dateTime
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_dateTime, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_dateTime, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_dateTimeNoTz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_dateTimeNoTz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_dateTimeNoTz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_dateTimeTz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_dateTimeTz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_dateTimeTz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_day
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_day, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_day, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_decimal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_decimal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_decimal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_double
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_double, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_double, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_doubleXdr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_doubleXdr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_doubleXdr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_duration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_duration, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_duration, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_ENTITY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_ENTITY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_ENTITY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_ENTITIES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_ENTITIES, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_ENTITIES, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_ENUMERATION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_ENUMERATION, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_ENUMERATION, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_fixed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_fixed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_fixed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_float
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_float, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_float, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_floatXdr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_floatXdr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_floatXdr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_hexBinary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_hexBinary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_hexBinary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_ID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_ID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_ID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_IDREF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_IDREF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_IDREF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_IDREFS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_IDREFS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_IDREFS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_int
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_int, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_int, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_integer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_integer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_integer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_language
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_language, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_language, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_long
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_long, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_long, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_month
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_month, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_month, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_monthDay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_monthDay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_monthDay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_Name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_Name, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_Name, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_NCName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_NCName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_NCName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_negativeInteger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_negativeInteger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_negativeInteger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_NMTOKEN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_NMTOKEN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_NMTOKEN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_NMTOKENS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_NMTOKENS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_NMTOKENS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_nonNegativeInteger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_nonNegativeInteger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_nonNegativeInteger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_nonPositiveInteger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_nonPositiveInteger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_nonPositiveInteger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_normalizedString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_normalizedString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_normalizedString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_NOTATION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_NOTATION, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_NOTATION, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_positiveInteger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_positiveInteger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_positiveInteger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_QName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_QName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_QName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_QNameXdr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_QNameXdr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_QNameXdr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_short
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_short, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_short, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_string
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_string, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_string, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_time
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_time, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_time, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_timeNoTz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_timeNoTz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_timeNoTz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_timeTz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_timeTz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_timeTz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_token
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_token, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_token, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_unsignedByte
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_unsignedByte, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_unsignedByte, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_unsignedInt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_unsignedInt, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_unsignedInt, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_unsignedLong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_unsignedLong, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_unsignedLong, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_unsignedShort
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_unsignedShort, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_unsignedShort, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_uuid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_uuid, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_uuid, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_year
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_year, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_year, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_yearMonth
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_yearMonth, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_yearMonth, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_normalizedStringV1Compat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_normalizedStringV1Compat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_normalizedStringV1Compat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_tokenV1Compat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_tokenV1Compat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_tokenV1Compat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_anyAtomicType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_anyAtomicType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_anyAtomicType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_dayTimeDuration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_dayTimeDuration, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_dayTimeDuration, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_untypedAtomicType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_untypedAtomicType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_untypedAtomicType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DatatypeImplementation c_yearMonthDuration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_yearMonthDuration, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_yearMonthDuration, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_tokenizedTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_tokenizedTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypesXsd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_tokenizedTypesXsd, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_tokenizedTypesXsd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<SchemaDatatypeMap> c_XdrTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_XdrTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchemaDatatypeMap>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_XdrTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<SchemaDatatypeMap> c_XsdTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_XsdTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchemaDatatypeMap>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_XsdTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchemaSimpleType AnySimpleType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922546, XrefRangeEnd = 922550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
	}

	public unsafe static XmlSchemaSimpleType UntypedAtomicType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922550, XrefRangeEnd = 922554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
		}
	}

	public unsafe override FacetsChecker FacetsChecker
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922935, XrefRangeEnd = 922939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
		}
	}

	public unsafe override XmlValueConverter ValueConverter
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922939, XrefRangeEnd = 922940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
		}
	}

	public unsafe override XmlTokenizedType TokenizedType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlTokenizedType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override Type ValueType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922940, XrefRangeEnd = 922944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
	}

	public unsafe override XmlSchemaDatatypeVariety Variety
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlSchemaDatatypeVariety*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override XmlTypeCode TypeCode
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlTypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override RestrictionFacets Restriction
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
		}
	}

	public unsafe override bool HasLexicalFacets
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override bool HasValueFacets
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DatatypeImplementation Base
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
		}
	}

	public unsafe virtual Type ListValueType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
	}

	public unsafe virtual RestrictionFlags ValidRestrictionFlags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RestrictionFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlSchemaWhiteSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DatatypeImplementation()
	{
		Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DatatypeImplementation");
		NativeFieldInfoPtr_variety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "variety");
		NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "restriction");
		NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "baseType");
		NativeFieldInfoPtr_valueConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "valueConverter");
		NativeFieldInfoPtr_parentSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "parentSchemaType");
		NativeFieldInfoPtr_builtinTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "builtinTypes");
		NativeFieldInfoPtr_enumToTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "enumToTypeCode");
		NativeFieldInfoPtr_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anySimpleType");
		NativeFieldInfoPtr_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anyAtomicType");
		NativeFieldInfoPtr_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "untypedAtomicType");
		NativeFieldInfoPtr_yearMonthDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "yearMonthDurationType");
		NativeFieldInfoPtr_dayTimeDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dayTimeDurationType");
		NativeFieldInfoPtr_normalizedStringTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "normalizedStringTypeV1Compat");
		NativeFieldInfoPtr_tokenTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "tokenTypeV1Compat");
		NativeFieldInfoPtr_QnAnySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnySimpleType");
		NativeFieldInfoPtr_QnAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnyType");
		NativeFieldInfoPtr_stringFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "stringFacetsChecker");
		NativeFieldInfoPtr_miscFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "miscFacetsChecker");
		NativeFieldInfoPtr_numeric2FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "numeric2FacetsChecker");
		NativeFieldInfoPtr_binaryFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "binaryFacetsChecker");
		NativeFieldInfoPtr_dateTimeFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dateTimeFacetsChecker");
		NativeFieldInfoPtr_durationFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "durationFacetsChecker");
		NativeFieldInfoPtr_listFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "listFacetsChecker");
		NativeFieldInfoPtr_qnameFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "qnameFacetsChecker");
		NativeFieldInfoPtr_unionFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "unionFacetsChecker");
		NativeFieldInfoPtr_c_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anySimpleType");
		NativeFieldInfoPtr_c_anyURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyURI");
		NativeFieldInfoPtr_c_base64Binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_base64Binary");
		NativeFieldInfoPtr_c_boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_boolean");
		NativeFieldInfoPtr_c_byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_byte");
		NativeFieldInfoPtr_c_char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_char");
		NativeFieldInfoPtr_c_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_date");
		NativeFieldInfoPtr_c_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTime");
		NativeFieldInfoPtr_c_dateTimeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeNoTz");
		NativeFieldInfoPtr_c_dateTimeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeTz");
		NativeFieldInfoPtr_c_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_day");
		NativeFieldInfoPtr_c_decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_decimal");
		NativeFieldInfoPtr_c_double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_double");
		NativeFieldInfoPtr_c_doubleXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_doubleXdr");
		NativeFieldInfoPtr_c_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_duration");
		NativeFieldInfoPtr_c_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITY");
		NativeFieldInfoPtr_c_ENTITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITIES");
		NativeFieldInfoPtr_c_ENUMERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENUMERATION");
		NativeFieldInfoPtr_c_fixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_fixed");
		NativeFieldInfoPtr_c_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_float");
		NativeFieldInfoPtr_c_floatXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_floatXdr");
		NativeFieldInfoPtr_c_hexBinary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_hexBinary");
		NativeFieldInfoPtr_c_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ID");
		NativeFieldInfoPtr_c_IDREF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREF");
		NativeFieldInfoPtr_c_IDREFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREFS");
		NativeFieldInfoPtr_c_int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_int");
		NativeFieldInfoPtr_c_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_integer");
		NativeFieldInfoPtr_c_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_language");
		NativeFieldInfoPtr_c_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_long");
		NativeFieldInfoPtr_c_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_month");
		NativeFieldInfoPtr_c_monthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_monthDay");
		NativeFieldInfoPtr_c_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_Name");
		NativeFieldInfoPtr_c_NCName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NCName");
		NativeFieldInfoPtr_c_negativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_negativeInteger");
		NativeFieldInfoPtr_c_NMTOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKEN");
		NativeFieldInfoPtr_c_NMTOKENS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKENS");
		NativeFieldInfoPtr_c_nonNegativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonNegativeInteger");
		NativeFieldInfoPtr_c_nonPositiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonPositiveInteger");
		NativeFieldInfoPtr_c_normalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedString");
		NativeFieldInfoPtr_c_NOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NOTATION");
		NativeFieldInfoPtr_c_positiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_positiveInteger");
		NativeFieldInfoPtr_c_QName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QName");
		NativeFieldInfoPtr_c_QNameXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QNameXdr");
		NativeFieldInfoPtr_c_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_short");
		NativeFieldInfoPtr_c_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_string");
		NativeFieldInfoPtr_c_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_time");
		NativeFieldInfoPtr_c_timeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeNoTz");
		NativeFieldInfoPtr_c_timeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeTz");
		NativeFieldInfoPtr_c_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_token");
		NativeFieldInfoPtr_c_unsignedByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedByte");
		NativeFieldInfoPtr_c_unsignedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedInt");
		NativeFieldInfoPtr_c_unsignedLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedLong");
		NativeFieldInfoPtr_c_unsignedShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedShort");
		NativeFieldInfoPtr_c_uuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_uuid");
		NativeFieldInfoPtr_c_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_year");
		NativeFieldInfoPtr_c_yearMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonth");
		NativeFieldInfoPtr_c_normalizedStringV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedStringV1Compat");
		NativeFieldInfoPtr_c_tokenV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenV1Compat");
		NativeFieldInfoPtr_c_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyAtomicType");
		NativeFieldInfoPtr_c_dayTimeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dayTimeDuration");
		NativeFieldInfoPtr_c_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_untypedAtomicType");
		NativeFieldInfoPtr_c_yearMonthDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonthDuration");
		NativeFieldInfoPtr_c_tokenizedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypes");
		NativeFieldInfoPtr_c_tokenizedTypesXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypesXsd");
		NativeFieldInfoPtr_c_XdrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XdrTypes");
		NativeFieldInfoPtr_c_XsdTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XsdTypes");
		NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666151);
		NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666152);
		NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666153);
		NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666154);
		NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666155);
		NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666156);
		NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666157);
		NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666158);
		NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666159);
		NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666160);
		NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666161);
		NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666162);
		NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666163);
		NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666164);
		NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666165);
		NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666166);
		NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666167);
		NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666168);
		NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666169);
		NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666170);
		NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666171);
		NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666172);
		NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666173);
		NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666174);
		NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666175);
		NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666176);
		NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666177);
		NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666178);
		NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666179);
		NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666180);
		NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666181);
		NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666182);
		NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666183);
		NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666184);
		NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666185);
		NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666186);
		NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666187);
		NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666188);
		NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666189);
		NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666190);
		NativeMethodInfoPtr_GetTypeName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666191);
		NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666192);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100666193);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 922558, RefRangeEnd = 922561, XrefRangeStart = 922554, XrefRangeEnd = 922558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 922565, RefRangeEnd = 922566, XrefRangeStart = 922561, XrefRangeEnd = 922565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 922571, RefRangeEnd = 922576, XrefRangeStart = 922566, XrefRangeEnd = 922571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static DatatypeImplementation FromXdrName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 922581, RefRangeEnd = 922583, XrefRangeStart = 922576, XrefRangeEnd = 922581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DatatypeImplementation FromTypeName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 922596, RefRangeEnd = 922602, XrefRangeStart = 922583, XrefRangeEnd = 922596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 922629, RefRangeEnd = 922634, XrefRangeStart = 922602, XrefRangeEnd = 922629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922634, XrefRangeEnd = 922791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBuiltinTypes()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 922795, RefRangeEnd = 922804, XrefRangeStart = 922791, XrefRangeEnd = 922795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 922810, RefRangeEnd = 922812, XrefRangeStart = 922804, XrefRangeEnd = 922810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922812, XrefRangeEnd = 922840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922840, XrefRangeEnd = 922868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchemaSimpleType GetTokenTypeV1Compat()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922868, XrefRangeEnd = 922872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> GetBuiltInTypes()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 922889, RefRangeEnd = 922891, XrefRangeStart = 922872, XrefRangeEnd = 922889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(XmlTypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922891, XrefRangeEnd = 922898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922898, XrefRangeEnd = 922899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 922913, RefRangeEnd = 922914, XrefRangeStart = 922899, XrefRangeEnd = 922913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minSize);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 922924, RefRangeEnd = 922925, XrefRangeStart = 922914, XrefRangeEnd = 922924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe static DatatypeImplementation DeriveByUnion(Il2CppReferenceArray<XmlSchemaSimpleType> types, XmlSchemaType schemaType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notations);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caller);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922925, XrefRangeEnd = 922930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsDerivedFrom(XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override bool IsEqual(Object o1, Object o2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922930, XrefRangeEnd = 922935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsComparable(XmlSchemaDatatype dtype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922944, XrefRangeEnd = 922945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &createAtomicValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922945, XrefRangeEnd = 922970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Exception TryParseValue(Object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out Object typedValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)namespaceResolver);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		typedValue = ((num3 == 0) ? null : new Object(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922970, XrefRangeEnd = 922974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTypeName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 922974, RefRangeEnd = 922976, XrefRangeStart = 922974, XrefRangeEnd = 922974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Compare(Il2CppStructArray<byte> value1, Il2CppStructArray<byte> value2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DatatypeImplementation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DatatypeImplementation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
