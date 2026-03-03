using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public sealed class SchemaCollectionCompiler : BaseProcessor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_compileContentModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_examplars;

	private static readonly System.IntPtr NativeFieldInfoPtr_complexTypeStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_schema;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0;

	public unsafe bool compileContentModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compileContentModel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compileContentModel)) = value;
		}
	}

	public unsafe XmlSchemaObjectTable examplars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examplars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examplars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Stack complexTypeStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexTypeStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexTypeStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchema schema
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schema);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schema)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SchemaCollectionCompiler()
	{
		Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaCollectionCompiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr);
		NativeFieldInfoPtr_compileContentModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "compileContentModel");
		NativeFieldInfoPtr_examplars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "examplars");
		NativeFieldInfoPtr_complexTypeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "complexTypeStack");
		NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, "schema");
		NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666799);
		NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666800);
		NativeMethodInfoPtr_Prepare_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666801);
		NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666802);
		NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666803);
		NativeMethodInfoPtr_Compile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666804);
		NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666805);
		NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666806);
		NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666807);
		NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666813);
		NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666814);
		NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666815);
		NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666816);
		NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666818);
		NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666819);
		NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666820);
		NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666821);
		NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666822);
		NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666823);
		NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666824);
		NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666825);
		NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666826);
		NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666827);
		NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666828);
		NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666829);
		NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666830);
		NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666831);
		NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666832);
		NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666833);
		NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666834);
		NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666835);
		NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666836);
		NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666837);
		NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666838);
		NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666839);
		NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666840);
		NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666841);
		NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666842);
		NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666843);
		NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666844);
		NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666845);
		NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666846);
		NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666847);
		NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666848);
		NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666849);
		NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666850);
		NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666851);
		NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666852);
		NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666853);
		NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666854);
		NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666855);
		NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666856);
		NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666857);
		NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666858);
		NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666859);
		NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666860);
		NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666861);
		NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666862);
		NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr, 100666863);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927724, RefRangeEnd = 927725, XrefRangeStart = 927713, XrefRangeEnd = 927724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SchemaCollectionCompiler(XmlNameTable nameTable, ValidationEventHandler eventHandler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaCollectionCompiler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927732, RefRangeEnd = 927733, XrefRangeStart = 927725, XrefRangeEnd = 927732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaInfo);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compileContentModel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Boolean_XmlSchema_SchemaInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927766, RefRangeEnd = 927767, XrefRangeStart = 927733, XrefRangeEnd = 927766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 927884, RefRangeEnd = 927885, XrefRangeStart = 927767, XrefRangeEnd = 927884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 927962, RefRangeEnd = 927964, XrefRangeStart = 927885, XrefRangeEnd = 927962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Cleanup(XmlSchema schema)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Static_Void_XmlSchema_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928212, RefRangeEnd = 928213, XrefRangeStart = 927964, XrefRangeEnd = 928212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Compile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928334, RefRangeEnd = 928335, XrefRangeStart = 928213, XrefRangeEnd = 928334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Output(SchemaInfo schemaInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Output_Private_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928335, XrefRangeEnd = 928338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupAttribute(XmlSchemaAttribute attribute)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupAttribute_Private_Static_Void_XmlSchemaAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928338, XrefRangeEnd = 928343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupAttributeGroup_Private_Static_Void_XmlSchemaAttributeGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 928383, RefRangeEnd = 928387, XrefRangeStart = 928343, XrefRangeEnd = 928383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupComplexType(XmlSchemaComplexType complexType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupComplexType_Private_Static_Void_XmlSchemaComplexType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928387, XrefRangeEnd = 928389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupSimpleType(XmlSchemaSimpleType simpleType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupSimpleType_Private_Static_Void_XmlSchemaSimpleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 928407, RefRangeEnd = 928411, XrefRangeStart = 928389, XrefRangeEnd = 928407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupElement(XmlSchemaElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupElement_Private_Static_Void_XmlSchemaElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 928417, RefRangeEnd = 928422, XrefRangeStart = 928411, XrefRangeEnd = 928417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupAttributes(XmlSchemaObjectCollection attributes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupAttributes_Private_Static_Void_XmlSchemaObjectCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928422, XrefRangeEnd = 928425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupGroup(XmlSchemaGroup group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupGroup_Private_Static_Void_XmlSchemaGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 928437, RefRangeEnd = 928445, XrefRangeStart = 928425, XrefRangeEnd = 928437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupParticle(XmlSchemaParticle particle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupParticle_Private_Static_Void_XmlSchemaParticle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928453, RefRangeEnd = 928454, XrefRangeStart = 928445, XrefRangeEnd = 928453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substitutionGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroupV1Compat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928464, RefRangeEnd = 928465, XrefRangeStart = 928454, XrefRangeEnd = 928464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substitutionGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSubstitutionGroup_Private_Void_XmlSchemaSubstitutionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 928469, RefRangeEnd = 928471, XrefRangeStart = 928465, XrefRangeEnd = 928469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileGroup(XmlSchemaGroup group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileGroup_Private_Void_XmlSchemaGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 928538, RefRangeEnd = 928546, XrefRangeStart = 928471, XrefRangeEnd = 928538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileSimpleType(XmlSchemaSimpleType simpleType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileSimpleType_Private_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928575, RefRangeEnd = 928576, XrefRangeStart = 928546, XrefRangeEnd = 928575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> CompileBaseMemberTypes(XmlSchemaSimpleType simpleType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileBaseMemberTypes_Private_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 928580, RefRangeEnd = 928582, XrefRangeStart = 928576, XrefRangeEnd = 928580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unionMember);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)memberTypeDefinitions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckUnionType_Private_Void_XmlSchemaSimpleType_ArrayList_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 928700, RefRangeEnd = 928708, XrefRangeStart = 928582, XrefRangeEnd = 928700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileComplexType(XmlSchemaComplexType complexType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 928736, RefRangeEnd = 928738, XrefRangeStart = 928708, XrefRangeEnd = 928736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleExtension);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileSimpleContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 928764, RefRangeEnd = 928766, XrefRangeStart = 928738, XrefRangeEnd = 928764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleRestriction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileSimpleContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928784, RefRangeEnd = 928785, XrefRangeStart = 928766, XrefRangeEnd = 928784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexContent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexExtension);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileComplexContentExtension_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928801, RefRangeEnd = 928802, XrefRangeStart = 928785, XrefRangeEnd = 928801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexContent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexRestriction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileComplexContentRestriction_Private_Void_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaComplexContentRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 928814, RefRangeEnd = 928816, XrefRangeStart = 928802, XrefRangeEnd = 928814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckParticleDerivation(XmlSchemaComplexType complexType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckParticleDerivation_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928832, RefRangeEnd = 928833, XrefRangeStart = 928816, XrefRangeEnd = 928832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileContentTypeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 928866, RefRangeEnd = 928871, XrefRangeStart = 928833, XrefRangeEnd = 928866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeParticle_Private_XmlSchemaParticle_XmlSchemaParticle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928871, XrefRangeEnd = 928879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeElement_Private_XmlSchemaParticle_XmlSchemaElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928946, RefRangeEnd = 928947, XrefRangeStart = 928879, XrefRangeEnd = 928946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)groupRef);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeGroupRef_Private_XmlSchemaParticle_XmlSchemaGroupRef_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 928979, RefRangeEnd = 928980, XrefRangeStart = 928947, XrefRangeEnd = 928979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)all);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeAll_Private_XmlSchemaParticle_XmlSchemaAll_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929022, RefRangeEnd = 929023, XrefRangeStart = 928980, XrefRangeEnd = 929022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)choice);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeChoice_Private_XmlSchemaParticle_XmlSchemaChoice_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929065, RefRangeEnd = 929066, XrefRangeStart = 929023, XrefRangeEnd = 929065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &substitution;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CannonicalizeSequence_Private_XmlSchemaParticle_XmlSchemaSequence_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 929096, RefRangeEnd = 929100, XrefRangeStart = 929066, XrefRangeEnd = 929096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedParticle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseParticle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929100, XrefRangeEnd = 929107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedElement);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseElement);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsElementFromElement_Private_Boolean_XmlSchemaElement_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929107, XrefRangeEnd = 929108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedElement);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseAny);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsElementFromAny_Private_Boolean_XmlSchemaElement_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929108, XrefRangeEnd = 929109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedAny);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseAny);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyFromAny_Private_Boolean_XmlSchemaAny_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929129, RefRangeEnd = 929130, XrefRangeStart = 929109, XrefRangeEnd = 929129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedGroupBase);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseAny);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGroupBaseFromAny_Private_Boolean_XmlSchemaGroupBase_XmlSchemaAny_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929135, RefRangeEnd = 929136, XrefRangeStart = 929130, XrefRangeEnd = 929135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedElement);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseGroupBase);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipEmptableOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsElementFromGroupBase_Private_Boolean_XmlSchemaElement_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929136, XrefRangeEnd = 929150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedGroupBase);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseGroupBase);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipEmptableOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGroupBaseFromGroupBase_Private_Boolean_XmlSchemaGroupBase_XmlSchemaGroupBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929150, XrefRangeEnd = 929171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedSequence);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseAll);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSequenceFromAll_Private_Boolean_XmlSchemaSequence_XmlSchemaAll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929171, XrefRangeEnd = 929186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedSequence);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseChoice);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSequenceFromChoice_Private_Boolean_XmlSchemaSequence_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929217, RefRangeEnd = 929218, XrefRangeStart = 929186, XrefRangeEnd = 929217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref minOccurs);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxOccurs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSequenceRange_Private_Void_XmlSchemaSequence_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 929222, RefRangeEnd = 929229, XrefRangeStart = 929218, XrefRangeEnd = 929222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedParticle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseParticle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_XmlSchemaParticle_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929229, XrefRangeEnd = 929233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minOccurs);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOccurs;
		*(Decimal**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseMinOccurs;
		*(Decimal**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseMaxOccurs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidOccurrenceRangeRestriction_Private_Boolean_Decimal_Decimal_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 929238, RefRangeEnd = 929240, XrefRangeStart = 929233, XrefRangeEnd = 929238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMappingParticle_Private_Int32_XmlSchemaParticle_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 929246, RefRangeEnd = 929249, XrefRangeStart = 929240, XrefRangeEnd = 929246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsParticleEmptiable(XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsParticleEmptiable_Private_Boolean_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 929285, RefRangeEnd = 929288, XrefRangeStart = 929249, XrefRangeEnd = 929285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref minOccurs);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxOccurs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateEffectiveTotalRange_Private_Void_XmlSchemaParticle_byref_Decimal_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929288, XrefRangeEnd = 929289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushComplexType(XmlSchemaComplexType complexType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushComplexType_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929289, XrefRangeEnd = 929290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexContent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSchemaContentType_Private_XmlSchemaContentType_XmlSchemaComplexType_XmlSchemaComplexContent_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(XmlSchemaContentType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 929356, RefRangeEnd = 929359, XrefRangeStart = 929290, XrefRangeEnd = 929356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAttributeGroup_Private_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 929526, RefRangeEnd = 929529, XrefRangeStart = 929359, XrefRangeEnd = 929526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyAttribute);
		*(XmlSchemaDerivationMethod**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &derivedBy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileLocalAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaComplexType_XmlSchemaObjectCollection_XmlSchemaAnyAttribute_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929529, XrefRangeEnd = 929533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAnyAttributeUnion_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929533, XrefRangeEnd = 929537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAnyAttributeIntersection_Private_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 929617, RefRangeEnd = 929621, XrefRangeStart = 929537, XrefRangeEnd = 929617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileAttribute(XmlSchemaAttribute xa)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xa);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAttribute_Private_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 929654, RefRangeEnd = 929657, XrefRangeStart = 929621, XrefRangeEnd = 929654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileIdentityConstraint_Private_Void_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 929753, RefRangeEnd = 929757, XrefRangeStart = 929657, XrefRangeEnd = 929753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileElement(XmlSchemaElement xe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xe);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileElement_Private_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 929790, RefRangeEnd = 929791, XrefRangeStart = 929757, XrefRangeEnd = 929790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContentValidator CompileComplexContent(XmlSchemaComplexType complexType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileComplexContent_Private_ContentValidator_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929791, XrefRangeEnd = 929816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contentValidator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildParticleContentModel_Private_Void_ParticleContentValidator_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 929829, RefRangeEnd = 929831, XrefRangeStart = 929816, XrefRangeEnd = 929829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileParticleElements_Private_Void_XmlSchemaComplexType_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929831, XrefRangeEnd = 929837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileCompexTypeElements(XmlSchemaComplexType complexType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)complexType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileCompexTypeElements_Private_Void_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 929843, RefRangeEnd = 929847, XrefRangeStart = 929837, XrefRangeEnd = 929843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimpleType_Private_XmlSchemaSimpleType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929847, XrefRangeEnd = 929852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaComplexType GetComplexType(XmlQualifiedName name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComplexType_Private_XmlSchemaComplexType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 929861, RefRangeEnd = 929863, XrefRangeStart = 929852, XrefRangeEnd = 929861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaType GetAnySchemaType(XmlQualifiedName name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnySchemaType_Private_XmlSchemaType_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
	}

	public SchemaCollectionCompiler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
