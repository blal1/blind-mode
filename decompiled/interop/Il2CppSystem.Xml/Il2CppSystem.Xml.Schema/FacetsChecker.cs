using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema;

public class FacetsChecker : Object
{
	public sealed class FacetsCompiler : ValueType
	{
		public sealed class Map : ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_match;

			private static readonly System.IntPtr NativeFieldInfoPtr_replacement;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0;

			public unsafe char match
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match);
					return *(char*)num;
				}
				set
				{
					*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match)) = value;
				}
			}

			public unsafe string replacement
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacement);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacement)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			static Map()
			{
				Il2CppClassPointerStore<Map>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "Map");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map>.NativeClassPtr);
				NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "match");
				NativeFieldInfoPtr_replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "replacement");
				NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100666619);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924711, XrefRangeEnd = 924719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Map(char m, string r)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&m);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(r);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public Map(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public Map()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_datatype;

		private static readonly System.IntPtr NativeFieldInfoPtr_derivedRestriction;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseFixedFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_validRestrictionFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_nonNegativeInt;

		private static readonly System.IntPtr NativeFieldInfoPtr_builtInType;

		private static readonly System.IntPtr NativeFieldInfoPtr_builtInEnum;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstPattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_regStr;

		private static readonly System.IntPtr NativeFieldInfoPtr_pattern_facet;

		private static readonly System.IntPtr NativeFieldInfoPtr_c_map;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0;

		public unsafe DatatypeImplementation datatype
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_datatype);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_datatype)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RestrictionFacets derivedRestriction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_derivedRestriction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_derivedRestriction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RestrictionFlags baseFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFlags);
				return *(RestrictionFlags*)num;
			}
			set
			{
				*(RestrictionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFlags)) = value;
			}
		}

		public unsafe RestrictionFlags baseFixedFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFixedFlags);
				return *(RestrictionFlags*)num;
			}
			set
			{
				*(RestrictionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseFixedFlags)) = value;
			}
		}

		public unsafe RestrictionFlags validRestrictionFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validRestrictionFlags);
				return *(RestrictionFlags*)num;
			}
			set
			{
				*(RestrictionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validRestrictionFlags)) = value;
			}
		}

		public unsafe XmlSchemaDatatype nonNegativeInt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonNegativeInt);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonNegativeInt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XmlSchemaDatatype builtInType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XmlTypeCode builtInEnum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInEnum);
				return *(XmlTypeCode*)num;
			}
			set
			{
				*(XmlTypeCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builtInEnum)) = value;
			}
		}

		public unsafe bool firstPattern
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPattern);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPattern)) = value;
			}
		}

		public unsafe StringBuilder regStr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regStr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regStr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XmlSchemaPatternFacet pattern_facet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern_facet);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaPatternFacet>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern_facet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppReferenceArray<Map> c_map
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_map, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Map>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_map, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static FacetsCompiler()
		{
			Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, "FacetsCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr);
			NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "datatype");
			NativeFieldInfoPtr_derivedRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "derivedRestriction");
			NativeFieldInfoPtr_baseFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "baseFlags");
			NativeFieldInfoPtr_baseFixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "baseFixedFlags");
			NativeFieldInfoPtr_validRestrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "validRestrictionFlags");
			NativeFieldInfoPtr_nonNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "nonNegativeInt");
			NativeFieldInfoPtr_builtInType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "builtInType");
			NativeFieldInfoPtr_builtInEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "builtInEnum");
			NativeFieldInfoPtr_firstPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "firstPattern");
			NativeFieldInfoPtr_regStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "regStr");
			NativeFieldInfoPtr_pattern_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "pattern_facet");
			NativeFieldInfoPtr_c_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, "c_map");
			NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666595);
			NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666596);
			NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666597);
			NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666598);
			NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666599);
			NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666600);
			NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666601);
			NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666602);
			NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666603);
			NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666604);
			NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666605);
			NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666606);
			NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666607);
			NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666608);
			NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666609);
			NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666610);
			NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666611);
			NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666612);
			NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666613);
			NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666614);
			NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666615);
			NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666616);
			NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr, 100666617);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924740, RefRangeEnd = 924741, XrefRangeStart = 924719, XrefRangeEnd = 924740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseDatatype);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)restriction);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924765, RefRangeEnd = 924766, XrefRangeStart = 924741, XrefRangeEnd = 924765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLengthFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924790, RefRangeEnd = 924791, XrefRangeStart = 924766, XrefRangeEnd = 924790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMinLengthFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924815, RefRangeEnd = 924816, XrefRangeStart = 924791, XrefRangeEnd = 924815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMaxLengthFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924839, RefRangeEnd = 924840, XrefRangeStart = 924816, XrefRangeEnd = 924839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompilePatternFacet(XmlSchemaPatternFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924856, RefRangeEnd = 924857, XrefRangeStart = 924840, XrefRangeEnd = 924856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924885, RefRangeEnd = 924886, XrefRangeStart = 924857, XrefRangeEnd = 924885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileWhitespaceFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924901, RefRangeEnd = 924902, XrefRangeStart = 924886, XrefRangeEnd = 924901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMaxInclusiveFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924917, RefRangeEnd = 924918, XrefRangeStart = 924902, XrefRangeEnd = 924917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMaxExclusiveFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924933, RefRangeEnd = 924934, XrefRangeStart = 924918, XrefRangeEnd = 924933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMinInclusiveFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924949, RefRangeEnd = 924950, XrefRangeStart = 924934, XrefRangeEnd = 924949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMinExclusiveFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924978, RefRangeEnd = 924979, XrefRangeStart = 924950, XrefRangeEnd = 924978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTotalDigitsFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 924999, RefRangeEnd = 925000, XrefRangeStart = 924979, XrefRangeEnd = 924999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileFractionDigitsFacet(XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 925022, RefRangeEnd = 925023, XrefRangeStart = 925000, XrefRangeEnd = 925022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishFacetCompile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 925026, RefRangeEnd = 925030, XrefRangeStart = 925023, XrefRangeEnd = 925026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValue(Object value, XmlSchemaFacet facet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 925034, RefRangeEnd = 925035, XrefRangeStart = 925030, XrefRangeEnd = 925034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileFacetCombinations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 925067, RefRangeEnd = 925068, XrefRangeStart = 925035, XrefRangeEnd = 925067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFacetsFromBaseType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 925068, RefRangeEnd = 925078, XrefRangeStart = 925068, XrefRangeEnd = 925068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(code);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsmgr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 925107, RefRangeEnd = 925108, XrefRangeStart = 925078, XrefRangeEnd = 925107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Preprocess(string pattern)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 925108, RefRangeEnd = 925120, XrefRangeStart = 925108, XrefRangeEnd = 925108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			*(RestrictionFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(errorCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			*(RestrictionFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(errorCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facet);
			*(RestrictionFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void SetFlag(RestrictionFlags flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&flag);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FacetsCompiler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FacetsCompiler()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsCompiler>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static FacetsChecker()
	{
		Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "FacetsChecker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr);
		NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666576);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666577);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666578);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666579);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666580);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666581);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666582);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666583);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666584);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666585);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666586);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666587);
		NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666588);
		NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666589);
		NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666590);
		NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666591);
		NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666592);
		NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666593);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100666594);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925120, XrefRangeEnd = 925137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(parseString);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		parseString = IL2CPP.Il2CppStringToManaged(intPtr);
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(Il2CppStructArray<byte> value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925137, XrefRangeEnd = 925139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		s = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925139, XrefRangeEnd = 925151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Exception CheckPatternFacets(RestrictionFacets restriction, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)restriction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumeration);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925151, XrefRangeEnd = 925221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)datatype);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)facets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925221, XrefRangeEnd = 925231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Power(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FacetsChecker()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FacetsChecker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
