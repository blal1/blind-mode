using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

[System.Serializable]
public class DefaultBinder : Binder
{
	public class BinderState : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_argsMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_originalSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_isParamArray;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		public unsafe Il2CppStructArray<int> m_argsMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_argsMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_argsMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_originalSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalSize)) = value;
			}
		}

		public unsafe bool m_isParamArray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isParamArray);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isParamArray)) = value;
			}
		}

		static BinderState()
		{
			Il2CppClassPointerStore<BinderState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "BinderState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinderState>.NativeClassPtr);
			NativeFieldInfoPtr_m_argsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinderState>.NativeClassPtr, "m_argsMap");
			NativeFieldInfoPtr_m_originalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinderState>.NativeClassPtr, "m_originalSize");
			NativeFieldInfoPtr_m_isParamArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinderState>.NativeClassPtr, "m_isParamArray");
			NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinderState>.NativeClassPtr, 100666676);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754208, XrefRangeEnd = 754210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinderState(Il2CppStructArray<int> argsMap, int originalSize, bool isParamArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinderState>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argsMap);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalSize;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isParamArray;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BinderState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("mscorlib.dll", "", "Primitives")]
	[System.Flags]
	public enum Primitives
	{
		Boolean = 8,
		Char = 0x10,
		SByte = 0x20,
		Byte = 0x40,
		Int16 = 0x80,
		UInt16 = 0x100,
		Int32 = 0x200,
		UInt32 = 0x400,
		Int64 = 0x800,
		UInt64 = 0x1000,
		Single = 0x2000,
		Double = 0x4000,
		Decimal = 0x8000,
		DateTime = 0x10000,
		String = 0x40000
	}

	[System.Serializable]
	[ObfuscatedName("System.DefaultBinder+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0;

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

		public unsafe static Predicate<Type> __9__2_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Predicate<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666678);
			NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666679);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754210, XrefRangeEnd = 754224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SelectProperty_b__2_0(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SelectProperty_b__2_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__primitiveConversions;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<Primitives> _primitiveConversions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__primitiveConversions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Primitives>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__primitiveConversions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DefaultBinder()
	{
		Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DefaultBinder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr);
		NativeFieldInfoPtr__primitiveConversions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "_primitiveConversions");
		NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666651);
		NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666652);
		NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666653);
		NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666654);
		NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666655);
		NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666656);
		NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666657);
		NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666658);
		NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666659);
		NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666660);
		NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666661);
		NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666662);
		NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666663);
		NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666664);
		NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666665);
		NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666666);
		NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666667);
		NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666668);
		NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666669);
		NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666670);
		NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666671);
		NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666672);
		NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666673);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100666674);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754224, XrefRangeEnd = 754373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override MethodBase BindToMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, ref Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo cultureInfo, Il2CppStringArray names, out Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&bindingAttr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifiers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		byte* num2 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
		nint num4 = num3;
		state = ((num4 == 0) ? null : new Object(num4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754373, XrefRangeEnd = 754410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FieldInfo BindToField(BindingFlags bindingAttr, Il2CppReferenceArray<FieldInfo> match, Object value, CultureInfo cultureInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bindingAttr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754410, XrefRangeEnd = 754478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override PropertyInfo SelectProperty(BindingFlags bindingAttr, Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> indexes, Il2CppReferenceArray<ParameterModifier> modifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&bindingAttr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)returnType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754478, XrefRangeEnd = 754485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Object ChangeType(Object value, Type type, CultureInfo cultureInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754485, XrefRangeEnd = 754496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReorderArgumentArray(ref Il2CppReferenceArray<Object> args, Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		args = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754507, RefRangeEnd = 754508, XrefRangeStart = 754496, XrefRangeEnd = 754507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MethodBase ExactBinding(Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754508, XrefRangeEnd = 754521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyInfo ExactPropertyBinding(Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)returnType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 754528, RefRangeEnd = 754530, XrefRangeStart = 754521, XrefRangeEnd = 754528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindMostSpecific(Il2CppReferenceArray<ParameterInfo> p1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, Il2CppReferenceArray<ParameterInfo> p2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramArrayType1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramArrayType2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754565, RefRangeEnd = 754566, XrefRangeStart = 754530, XrefRangeEnd = 754565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindMostSpecificType(Type c1, Type c2, Type t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 754579, RefRangeEnd = 754581, XrefRangeStart = 754566, XrefRangeEnd = 754579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindMostSpecificMethod(MethodBase m1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, MethodBase m2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramArrayType1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramArrayType2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754581, XrefRangeEnd = 754587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cur1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cur2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754593, RefRangeEnd = 754594, XrefRangeStart = 754587, XrefRangeEnd = 754593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cur1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cur2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754594, XrefRangeEnd = 754597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754600, RefRangeEnd = 754606, XrefRangeStart = 754597, XrefRangeEnd = 754600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHierarchyDepth(Type t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754612, RefRangeEnd = 754613, XrefRangeStart = 754606, XrefRangeEnd = 754612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MethodBase FindMostDerivedNewSlotMeth(Il2CppReferenceArray<MethodBase> match, int cMatches)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cMatches;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 754622, RefRangeEnd = 754624, XrefRangeStart = 754613, XrefRangeEnd = 754622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReorderParams(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<Object> vars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754632, RefRangeEnd = 754633, XrefRangeStart = 754624, XrefRangeEnd = 754632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateParamOrder(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<ParameterInfo> pars, Il2CppStringArray names)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paramOrder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754640, RefRangeEnd = 754646, XrefRangeStart = 754633, XrefRangeEnd = 754640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 754657, RefRangeEnd = 754660, XrefRangeStart = 754646, XrefRangeEnd = 754657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanConvertPrimitiveObjectToType(Object source, RuntimeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareMethodSig(MethodBase m1, MethodBase m2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareMethodSig_Internal_Static_Boolean_MethodBase_MethodBase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754660, XrefRangeEnd = 754707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override MethodBase SelectMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bindingAttr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectMethod_Public_Virtual_Final_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 754718, RefRangeEnd = 754719, XrefRangeStart = 754707, XrefRangeEnd = 754718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanChangePrimitive(Type source, Type target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanChangePrimitive_Private_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754719, XrefRangeEnd = 754727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanPrimitiveWiden(Type source, Type target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanPrimitiveWiden_Private_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultBinder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DefaultBinder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
