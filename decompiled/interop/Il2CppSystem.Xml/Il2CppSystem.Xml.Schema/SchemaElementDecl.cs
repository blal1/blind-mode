using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema;

public sealed class SchemaElementDecl : SchemaDeclBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_attdefs;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultAttdefs;

	private static readonly System.IntPtr NativeFieldInfoPtr_isIdDeclared;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasNonCDataAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAbstract;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNillable;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasRequiredAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNotationDeclared;

	private static readonly System.IntPtr NativeFieldInfoPtr_prohibitedAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentValidator;

	private static readonly System.IntPtr NativeFieldInfoPtr_anyAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_block;

	private static readonly System.IntPtr NativeFieldInfoPtr_constraints;

	private static readonly System.IntPtr NativeFieldInfoPtr_schemaElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_Empty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0;

	public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attdefs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attdefs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attdefs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<IDtdDefaultAttributeInfo> defaultAttdefs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAttdefs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IDtdDefaultAttributeInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAttdefs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isIdDeclared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIdDeclared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIdDeclared)) = value;
		}
	}

	public unsafe bool hasNonCDataAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasNonCDataAttribute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasNonCDataAttribute)) = value;
		}
	}

	public unsafe bool isAbstract
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAbstract);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAbstract)) = value;
		}
	}

	public unsafe bool isNillable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNillable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNillable)) = value;
		}
	}

	public unsafe bool hasRequiredAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasRequiredAttribute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasRequiredAttribute)) = value;
		}
	}

	public unsafe bool isNotationDeclared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNotationDeclared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNotationDeclared)) = value;
		}
	}

	public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prohibitedAttributes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prohibitedAttributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ContentValidator contentValidator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentValidator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentValidator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAnyAttribute anyAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyAttribute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyAttribute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaDerivationMethod block
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block);
			return *(XmlSchemaDerivationMethod*)num;
		}
		set
		{
			*(XmlSchemaDerivationMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> constraints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constraints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constraints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaElement schemaElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaElement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SchemaElementDecl Empty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Empty, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Empty, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual bool System_002EXml_002EIDtdAttributeListInfo_002EHasNonCDataAttributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsIdDeclared
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool HasNonCDataAttribute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IsAbstract
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IsNillable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XmlSchemaDerivationMethod Block
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 178480, RefRangeEnd = 178492, XrefRangeStart = 178480, XrefRangeEnd = 178492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XmlSchemaDerivationMethod*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IsNotationDeclared
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool HasDefaultAttribute
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 931573, RefRangeEnd = 931576, XrefRangeStart = 931573, XrefRangeEnd = 931573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HasRequiredAttribute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ContentValidator ContentValidator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XmlSchemaAnyAttribute AnyAttribute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> Constraints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XmlSchemaElement SchemaElement
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202046, RefRangeEnd = 202047, XrefRangeStart = 202046, XrefRangeEnd = 202047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<IDtdDefaultAttributeInfo>>(intPtr2) : null;
		}
	}

	public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
		}
	}

	public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr2) : null;
		}
	}

	static SchemaElementDecl()
	{
		Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaElementDecl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr);
		NativeFieldInfoPtr_attdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "attdefs");
		NativeFieldInfoPtr_defaultAttdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "defaultAttdefs");
		NativeFieldInfoPtr_isIdDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isIdDeclared");
		NativeFieldInfoPtr_hasNonCDataAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasNonCDataAttribute");
		NativeFieldInfoPtr_isAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isAbstract");
		NativeFieldInfoPtr_isNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNillable");
		NativeFieldInfoPtr_hasRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasRequiredAttribute");
		NativeFieldInfoPtr_isNotationDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNotationDeclared");
		NativeFieldInfoPtr_prohibitedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "prohibitedAttributes");
		NativeFieldInfoPtr_contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "contentValidator");
		NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "anyAttribute");
		NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "block");
		NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "constraints");
		NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "schemaElement");
		NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "Empty");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666926);
		NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666927);
		NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666936);
		NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666937);
		NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666938);
		NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666939);
		NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666940);
		NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666941);
		NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666942);
		NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666943);
		NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666944);
		NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666945);
		NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666946);
		NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666947);
		NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666948);
		NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666949);
		NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666950);
		NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666951);
		NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666952);
		NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666953);
		NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666954);
		NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666955);
		NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666956);
		NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666957);
		NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666958);
		NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666959);
		NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100666960);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 931481, RefRangeEnd = 931485, XrefRangeStart = 931461, XrefRangeEnd = 931481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaElementDecl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 931511, RefRangeEnd = 931514, XrefRangeStart = 931485, XrefRangeEnd = 931511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaElementDecl(XmlSchemaDatatype dtype)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 931536, RefRangeEnd = 931539, XrefRangeStart = 931514, XrefRangeEnd = 931536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaElementDecl(XmlQualifiedName name, string prefix)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 931551, RefRangeEnd = 931552, XrefRangeStart = 931539, XrefRangeEnd = 931551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SchemaElementDecl CreateAnyTypeElementDecl()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931552, XrefRangeEnd = 931559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IDtdAttributeInfo System_Xml_IDtdAttributeListInfo_LookupAttribute(string prefix, string localName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(localName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr2) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerable<IDtdDefaultAttributeInfo> System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr2) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 931562, RefRangeEnd = 931573, XrefRangeStart = 931559, XrefRangeEnd = 931562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaElementDecl Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 931589, RefRangeEnd = 931593, XrefRangeStart = 931576, XrefRangeEnd = 931589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAttDef(SchemaAttDef attdef)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attdef);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 931596, RefRangeEnd = 931600, XrefRangeStart = 931593, XrefRangeEnd = 931596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaAttDef GetAttDef(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 931617, RefRangeEnd = 931620, XrefRangeStart = 931600, XrefRangeEnd = 931617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAttributes(Hashtable presence, bool standalone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)presence);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &standalone;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SchemaElementDecl(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
