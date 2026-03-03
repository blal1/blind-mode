using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public static class MonoCustomAttrs : Object
{
	public class AttributeInfo : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__usage;

		private static readonly System.IntPtr NativeFieldInfoPtr__inheritanceLevel;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0;

		public unsafe AttributeUsageAttribute _usage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__usage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__usage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _inheritanceLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inheritanceLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inheritanceLevel)) = value;
			}
		}

		public unsafe AttributeUsageAttribute Usage
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
		}

		public unsafe int InheritanceLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static AttributeInfo()
		{
			Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "AttributeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr);
			NativeFieldInfoPtr__usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr, "_usage");
			NativeFieldInfoPtr__inheritanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr, "_inheritanceLevel");
			NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr, 100667181);
			NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr, 100667182);
			NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr, 100667183);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 762714, RefRangeEnd = 762719, XrefRangeStart = 762713, XrefRangeEnd = 762714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usage);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inheritanceLevel;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AttributeInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_corlib;

	private static readonly System.IntPtr NativeFieldInfoPtr_usage_cache;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAttributeUsage;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0;

	public unsafe static Assembly corlib
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_corlib, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_corlib, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<Type, AttributeUsageAttribute> usage_cache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_usage_cache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Type, AttributeUsageAttribute>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_usage_cache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AttributeUsageAttribute DefaultAttributeUsage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultAttributeUsage, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultAttributeUsage, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MonoCustomAttrs()
	{
		Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoCustomAttrs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr);
		NativeFieldInfoPtr_corlib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "corlib");
		NativeFieldInfoPtr_usage_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "usage_cache");
		NativeFieldInfoPtr_DefaultAttributeUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "DefaultAttributeUsage");
		NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667162);
		NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667164);
		NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667165);
		NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667166);
		NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667167);
		NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667168);
		NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667169);
		NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667170);
		NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667171);
		NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667172);
		NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667173);
		NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667178);
		NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667179);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 762723, RefRangeEnd = 762726, XrefRangeStart = 762719, XrefRangeEnd = 762723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUserCattrProvider(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762726, XrefRangeEnd = 762727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pseudoAttrs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 762759, RefRangeEnd = 762761, XrefRangeStart = 762727, XrefRangeEnd = 762759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 762777, RefRangeEnd = 762778, XrefRangeStart = 762761, XrefRangeEnd = 762777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 762797, RefRangeEnd = 762799, XrefRangeStart = 762778, XrefRangeEnd = 762797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inheritedOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 762905, RefRangeEnd = 762919, XrefRangeStart = 762799, XrefRangeEnd = 762905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inherit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 762929, RefRangeEnd = 762937, XrefRangeStart = 762919, XrefRangeEnd = 762929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inherit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762937, XrefRangeEnd = 762938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<CustomAttributeData> GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 762956, RefRangeEnd = 762961, XrefRangeStart = 762938, XrefRangeEnd = 762956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inherit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763005, RefRangeEnd = 763006, XrefRangeStart = 762961, XrefRangeEnd = 763005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inherit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 763031, RefRangeEnd = 763033, XrefRangeStart = 763006, XrefRangeEnd = 763031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inheritedOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763065, RefRangeEnd = 763066, XrefRangeStart = 763033, XrefRangeEnd = 763065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763095, RefRangeEnd = 763096, XrefRangeStart = 763066, XrefRangeEnd = 763095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr2) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 763118, RefRangeEnd = 763129, XrefRangeStart = 763096, XrefRangeEnd = 763118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inherit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763129, XrefRangeEnd = 763130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)AttributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763146, RefRangeEnd = 763147, XrefRangeStart = 763130, XrefRangeEnd = 763146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)property);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763147, XrefRangeEnd = 763160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventInfo>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 763180, RefRangeEnd = 763183, XrefRangeStart = 763160, XrefRangeEnd = 763180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICustomAttributeProvider>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 763209, RefRangeEnd = 763210, XrefRangeStart = 763183, XrefRangeEnd = 763209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 763243, RefRangeEnd = 763247, XrefRangeStart = 763210, XrefRangeEnd = 763243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributeType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
	}

	public MonoCustomAttrs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
