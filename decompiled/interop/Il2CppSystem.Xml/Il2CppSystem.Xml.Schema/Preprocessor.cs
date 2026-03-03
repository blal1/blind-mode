using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public sealed class Preprocessor : BaseProcessor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Xmlns;

	private static readonly System.IntPtr NativeFieldInfoPtr_NsXsi;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetNamespace;

	private static readonly System.IntPtr NativeFieldInfoPtr_rootSchema;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSchema;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementFormDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_attributeFormDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_schemaLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_chameleonSchemas;

	private static readonly System.IntPtr NativeFieldInfoPtr_referenceNamespaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_processedExternals;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockList;

	private static readonly System.IntPtr NativeFieldInfoPtr_readerSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_rootSchemaForRedefine;

	private static readonly System.IntPtr NativeFieldInfoPtr_redefinedList;

	private static readonly System.IntPtr NativeFieldInfoPtr_builtInSchemaForXmlNS;

	private static readonly System.IntPtr NativeFieldInfoPtr_xmlResolver;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0;

	public unsafe string Xmlns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Xmlns);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Xmlns)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string NsXsi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NsXsi);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NsXsi)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string targetNamespace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetNamespace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetNamespace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe XmlSchema rootSchema
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootSchema);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootSchema)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchema currentSchema
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSchema);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSchema)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaForm elementFormDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementFormDefault);
			return *(XmlSchemaForm*)num;
		}
		set
		{
			*(XmlSchemaForm*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementFormDefault)) = value;
		}
	}

	public unsafe XmlSchemaForm attributeFormDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeFormDefault);
			return *(XmlSchemaForm*)num;
		}
		set
		{
			*(XmlSchemaForm*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeFormDefault)) = value;
		}
	}

	public unsafe XmlSchemaDerivationMethod blockDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDefault);
			return *(XmlSchemaDerivationMethod*)num;
		}
		set
		{
			*(XmlSchemaDerivationMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDefault)) = value;
		}
	}

	public unsafe XmlSchemaDerivationMethod finalDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDefault);
			return *(XmlSchemaDerivationMethod*)num;
		}
		set
		{
			*(XmlSchemaDerivationMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDefault)) = value;
		}
	}

	public unsafe Hashtable schemaLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaLocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable chameleonSchemas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chameleonSchemas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chameleonSchemas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable referenceNamespaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceNamespaces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceNamespaces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable processedExternals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedExternals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedExternals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SortedList lockList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SortedList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlReaderSettings readerSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readerSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readerSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchema rootSchemaForRedefine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootSchemaForRedefine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootSchemaForRedefine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ArrayList redefinedList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redefinedList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redefinedList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XmlSchema builtInSchemaForXmlNS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_builtInSchemaForXmlNS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_builtInSchemaForXmlNS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlResolver xmlResolver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlResolver);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlResolver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlResolver XmlResolver
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XmlReaderSettings ReaderSettings
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Hashtable SchemaLocations
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Hashtable ChameleonSchemas
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XmlSchema RootSchema
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
		}
	}

	static Preprocessor()
	{
		Il2CppClassPointerStore<Preprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Preprocessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr);
		NativeFieldInfoPtr_Xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "Xmlns");
		NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "NsXsi");
		NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "targetNamespace");
		NativeFieldInfoPtr_rootSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchema");
		NativeFieldInfoPtr_currentSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "currentSchema");
		NativeFieldInfoPtr_elementFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "elementFormDefault");
		NativeFieldInfoPtr_attributeFormDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "attributeFormDefault");
		NativeFieldInfoPtr_blockDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "blockDefault");
		NativeFieldInfoPtr_finalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "finalDefault");
		NativeFieldInfoPtr_schemaLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "schemaLocations");
		NativeFieldInfoPtr_chameleonSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "chameleonSchemas");
		NativeFieldInfoPtr_referenceNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "referenceNamespaces");
		NativeFieldInfoPtr_processedExternals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "processedExternals");
		NativeFieldInfoPtr_lockList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "lockList");
		NativeFieldInfoPtr_readerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "readerSettings");
		NativeFieldInfoPtr_rootSchemaForRedefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "rootSchemaForRedefine");
		NativeFieldInfoPtr_redefinedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "redefinedList");
		NativeFieldInfoPtr_builtInSchemaForXmlNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "builtInSchemaForXmlNS");
		NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, "xmlResolver");
		NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666709);
		NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666710);
		NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666711);
		NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666712);
		NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666713);
		NativeMethodInfoPtr_set_ReaderSettings_Internal_set_Void_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666714);
		NativeMethodInfoPtr_set_SchemaLocations_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666715);
		NativeMethodInfoPtr_set_ChameleonSchemas_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666716);
		NativeMethodInfoPtr_get_RootSchema_Internal_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666717);
		NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666718);
		NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666719);
		NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666720);
		NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666721);
		NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666722);
		NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666723);
		NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666724);
		NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666725);
		NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666726);
		NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666727);
		NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666728);
		NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666729);
		NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666730);
		NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666731);
		NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666732);
		NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666733);
		NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666734);
		NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666735);
		NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666736);
		NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666737);
		NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666738);
		NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666739);
		NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666740);
		NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666741);
		NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666742);
		NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666743);
		NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666744);
		NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666745);
		NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666746);
		NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666747);
		NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666748);
		NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666749);
		NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666750);
		NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666751);
		NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666752);
		NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666753);
		NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666754);
		NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666755);
		NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr, 100666756);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 925855, RefRangeEnd = 925858, XrefRangeStart = 925840, XrefRangeEnd = 925855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preprocessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compilationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_SchemaNames_ValidationEventHandler_XmlSchemaCompilationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 925899, RefRangeEnd = 925902, XrefRangeStart = 925858, XrefRangeEnd = 925899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadExternals;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925902, XrefRangeEnd = 925914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup(XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 925920, RefRangeEnd = 925921, XrefRangeStart = 925914, XrefRangeEnd = 925920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupRedefine(XmlSchemaExternal include)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)include);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupRedefine_Private_Void_XmlSchemaExternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 925932, RefRangeEnd = 925934, XrefRangeStart = 925921, XrefRangeEnd = 925932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildSchemaList(XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchemaList_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 926045, RefRangeEnd = 926048, XrefRangeStart = 925934, XrefRangeEnd = 926045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadExternals(XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadExternals_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 926180, RefRangeEnd = 926187, XrefRangeStart = 926048, XrefRangeEnd = 926180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchema GetBuildInSchema()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuildInSchema_Internal_Static_XmlSchema_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926197, RefRangeEnd = 926198, XrefRangeStart = 926187, XrefRangeEnd = 926197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildRefNamespaces(XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildRefNamespaces_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 926207, RefRangeEnd = 926211, XrefRangeStart = 926198, XrefRangeEnd = 926207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(code);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceSchemaObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUri_Private_Void_String_String_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 926422, RefRangeEnd = 926425, XrefRangeStart = 926211, XrefRangeEnd = 926422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imports);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Preprocess_Private_Void_XmlSchema_String_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926556, RefRangeEnd = 926557, XrefRangeStart = 926425, XrefRangeEnd = 926556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)includedSchema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyIncludedComponents_Private_Void_XmlSchema_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926698, RefRangeEnd = 926699, XrefRangeStart = 926557, XrefRangeEnd = 926698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessRedefine(RedefineEntry redefineEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)redefineEntry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessRedefine_Private_Void_RedefineEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926704, RefRangeEnd = 926706, XrefRangeStart = 926699, XrefRangeEnd = 926704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetIncludedSet(XmlSchema schema, ArrayList includesList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)includesList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIncludedSet_Private_Void_XmlSchema_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926709, RefRangeEnd = 926710, XrefRangeStart = 926706, XrefRangeEnd = 926709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentSchemaObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParentSchema_Internal_Static_XmlSchema_XmlSchemaObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926719, RefRangeEnd = 926721, XrefRangeStart = 926710, XrefRangeEnd = 926719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSchemaDefaults(XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSchemaDefaults_Private_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926747, RefRangeEnd = 926749, XrefRangeStart = 926721, XrefRangeEnd = 926747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)redefined);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountGroupSelfReference_Private_Int32_XmlSchemaObjectCollection_XmlQualifiedName_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926753, RefRangeEnd = 926754, XrefRangeStart = 926749, XrefRangeEnd = 926753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRefinedGroup(XmlSchemaGroup group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRefinedGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926765, RefRangeEnd = 926766, XrefRangeStart = 926754, XrefRangeEnd = 926765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRefinedAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926776, RefRangeEnd = 926777, XrefRangeStart = 926766, XrefRangeEnd = 926776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRefinedSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926802, RefRangeEnd = 926803, XrefRangeStart = 926777, XrefRangeEnd = 926802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRefinedComplexType(XmlSchemaComplexType ctype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRefinedComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926827, RefRangeEnd = 926828, XrefRangeStart = 926803, XrefRangeEnd = 926827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAttribute(XmlSchemaAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 926854, RefRangeEnd = 926855, XrefRangeStart = 926828, XrefRangeEnd = 926854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessLocalAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926886, RefRangeEnd = 926888, XrefRangeStart = 926855, XrefRangeEnd = 926886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAttributeContent(XmlSchemaAttribute attribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAttributeContent_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926904, RefRangeEnd = 926906, XrefRangeStart = 926888, XrefRangeEnd = 926904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 926944, RefRangeEnd = 926946, XrefRangeStart = 926906, XrefRangeEnd = 926944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessElement(XmlSchemaElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 926999, RefRangeEnd = 927002, XrefRangeStart = 926946, XrefRangeEnd = 926999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessLocalElement(XmlSchemaElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessLocalElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 927042, RefRangeEnd = 927044, XrefRangeStart = 927002, XrefRangeEnd = 927042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessElementContent(XmlSchemaElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessElementContent_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927086, RefRangeEnd = 927087, XrefRangeStart = 927044, XrefRangeEnd = 927086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constraint);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 927177, RefRangeEnd = 927186, XrefRangeStart = 927087, XrefRangeEnd = 927177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &local;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessSimpleType_Private_Void_XmlSchemaSimpleType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 927311, RefRangeEnd = 927315, XrefRangeStart = 927186, XrefRangeEnd = 927311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessComplexType(XmlSchemaComplexType complexType, bool local)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &local;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessComplexType_Private_Void_XmlSchemaComplexType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 927345, RefRangeEnd = 927348, XrefRangeStart = 927315, XrefRangeEnd = 927345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessGroup(XmlSchemaGroup group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 927381, RefRangeEnd = 927383, XrefRangeStart = 927348, XrefRangeEnd = 927381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessNotation(XmlSchemaNotation notation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessNotation_Private_Void_XmlSchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 927497, RefRangeEnd = 927502, XrefRangeStart = 927383, XrefRangeEnd = 927497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessParticle(XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 927531, RefRangeEnd = 927535, XrefRangeStart = 927502, XrefRangeEnd = 927531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyAttribute);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAttributes_Private_Void_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 927542, RefRangeEnd = 927567, XrefRangeStart = 927535, XrefRangeEnd = 927542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateIdAttribute(XmlSchemaObject xso)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xso);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateIdAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 927596, RefRangeEnd = 927606, XrefRangeStart = 927567, XrefRangeEnd = 927596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateNameAttribute(XmlSchemaObject xso)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xso);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateNameAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 927619, RefRangeEnd = 927633, XrefRangeStart = 927606, XrefRangeEnd = 927619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xso);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attributeName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateQNameAttribute_Private_Void_XmlSchemaObject_String_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enclosingSchema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveSchemaLocationUri_Private_Uri_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927633, RefRangeEnd = 927634, XrefRangeStart = 927633, XrefRangeEnd = 927633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object GetSchemaEntity(Uri ruri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ruri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSchemaEntity_Private_Object_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 927644, RefRangeEnd = 927646, XrefRangeStart = 927634, XrefRangeEnd = 927644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChameleonSchema_Private_XmlSchema_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927646, XrefRangeEnd = 927648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParent(XmlSchemaObject child, XmlSchemaObject parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Private_Void_XmlSchemaObject_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 927652, RefRangeEnd = 927668, XrefRangeStart = 927648, XrefRangeEnd = 927652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAnnotation(XmlSchemaObject schemaObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 927672, RefRangeEnd = 927675, XrefRangeStart = 927668, XrefRangeEnd = 927672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreprocessAnnotation(XmlSchemaAnnotation annotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)annotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreprocessAnnotation_Private_Void_XmlSchemaAnnotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Preprocessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
