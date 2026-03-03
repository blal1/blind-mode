using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Serialization;

public class XmlReflectionImporter : Object
{
	[System.Serializable]
	[ObfuscatedName("System.Xml.Serialization.XmlReflectionImporter+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Comparison<XmlReflectionMember> __9__28_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Comparison<XmlReflectionMember>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__28_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__28_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665461);
			NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665462);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915786, XrefRangeEnd = 915798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _ImportClassMapping_b__28_0(XmlReflectionMember m1, XmlReflectionMember m2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_initialDefaultNamespace;

	private static readonly System.IntPtr NativeFieldInfoPtr_attributeOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_includedTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_helper;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrayChoiceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_relatedMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowPrivateTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_errSimple;

	private static readonly System.IntPtr NativeFieldInfoPtr_errSimple2;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncludeType_Public_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0;

	public unsafe string initialDefaultNamespace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialDefaultNamespace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialDefaultNamespace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe XmlAttributeOverrides attributeOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlAttributeOverrides>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ArrayList includedTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includedTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includedTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReflectionHelper helper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionHelper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int arrayChoiceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrayChoiceCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrayChoiceCount)) = value;
		}
	}

	public unsafe ArrayList relatedMaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedMaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedMaps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool allowPrivateTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPrivateTypes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPrivateTypes)) = value;
		}
	}

	public unsafe static string errSimple
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_errSimple, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_errSimple, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string errSimple2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_errSimple2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_errSimple2, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static XmlReflectionImporter()
	{
		Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlReflectionImporter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr);
		NativeFieldInfoPtr_initialDefaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "initialDefaultNamespace");
		NativeFieldInfoPtr_attributeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "attributeOverrides");
		NativeFieldInfoPtr_includedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "includedTypes");
		NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "helper");
		NativeFieldInfoPtr_arrayChoiceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "arrayChoiceCount");
		NativeFieldInfoPtr_relatedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "relatedMaps");
		NativeFieldInfoPtr_allowPrivateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "allowPrivateTypes");
		NativeFieldInfoPtr_errSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple");
		NativeFieldInfoPtr_errSimple2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple2");
		NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665434);
		NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665435);
		NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665436);
		NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665437);
		NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665438);
		NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665439);
		NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665440);
		NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665441);
		NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665442);
		NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665443);
		NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665444);
		NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665445);
		NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665446);
		NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665447);
		NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665448);
		NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665449);
		NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665450);
		NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665451);
		NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665452);
		NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665453);
		NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665454);
		NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665455);
		NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665456);
		NativeMethodInfoPtr_IncludeType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665457);
		NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100665458);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 915816, RefRangeEnd = 915818, XrefRangeStart = 915798, XrefRangeEnd = 915816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeOverrides);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915818, XrefRangeEnd = 915819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportTypeMapping(Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915819, XrefRangeEnd = 915820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 915849, RefRangeEnd = 915867, XrefRangeStart = 915820, XrefRangeEnd = 915849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915888, RefRangeEnd = 915889, XrefRangeStart = 915867, XrefRangeEnd = 915888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 915933, RefRangeEnd = 915939, XrefRangeStart = 915889, XrefRangeEnd = 915933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultXmlType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 915944, RefRangeEnd = 915946, XrefRangeStart = 915939, XrefRangeEnd = 915944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBaseType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 916128, RefRangeEnd = 916130, XrefRangeStart = 915946, XrefRangeEnd = 916128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBaseType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 916136, RefRangeEnd = 916139, XrefRangeStart = 916130, XrefRangeEnd = 916136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)derivedMap);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916139, XrefRangeEnd = 916146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 916151, RefRangeEnd = 916154, XrefRangeStart = 916146, XrefRangeEnd = 916151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atts);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nestingLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 916287, RefRangeEnd = 916289, XrefRangeStart = 916154, XrefRangeEnd = 916287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atts);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nestingLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916315, RefRangeEnd = 916316, XrefRangeStart = 916289, XrefRangeEnd = 916315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916331, RefRangeEnd = 916332, XrefRangeStart = 916316, XrefRangeEnd = 916331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916408, RefRangeEnd = 916409, XrefRangeStart = 916332, XrefRangeEnd = 916408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916428, RefRangeEnd = 916429, XrefRangeStart = 916409, XrefRangeEnd = 916428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916429, XrefRangeEnd = 916439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportIncludedTypes(Type type, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916539, RefRangeEnd = 916540, XrefRangeStart = 916439, XrefRangeEnd = 916539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<XmlReflectionMember> GetReflectionMembers(Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<XmlReflectionMember>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916692, RefRangeEnd = 916693, XrefRangeStart = 916540, XrefRangeEnd = 916692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)declaringType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rmember);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 916792, RefRangeEnd = 916794, XrefRangeStart = 916693, XrefRangeEnd = 916792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916842, RefRangeEnd = 916843, XrefRangeStart = 916794, XrefRangeEnd = 916842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rmember);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 916877, RefRangeEnd = 916879, XrefRangeStart = 916843, XrefRangeEnd = 916877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)member);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916879, XrefRangeEnd = 916880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanBeNull(TypeData type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 916912, RefRangeEnd = 916913, XrefRangeStart = 916880, XrefRangeEnd = 916912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncludeType(Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncludeType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916913, XrefRangeEnd = 916926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Object GetDefaultValue(TypeData typeData, Object defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public XmlReflectionImporter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
