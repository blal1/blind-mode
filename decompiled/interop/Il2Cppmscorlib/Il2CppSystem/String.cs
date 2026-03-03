using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Buffers;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem;

[System.Serializable]
public sealed class String : Object
{
	[OriginalName("mscorlib.dll", "", "TrimType")]
	public enum TrimType
	{
		Head,
		Tail,
		Both
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ProbabilisticMap
	{
		static ProbabilisticMap()
		{
			Il2CppClassPointerStore<ProbabilisticMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<string>.NativeClassPtr, "ProbabilisticMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbabilisticMap>.NativeClassPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbabilisticMap>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Join_Public_Static_String_String_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_StackallocIntBufferSizeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr__stringLength;

	private static readonly System.IntPtr NativeFieldInfoPtr__firstChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_Empty;

	private static readonly System.IntPtr NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLower_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpper_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimStart_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimStart_Public_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIntern_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Intern_Public_Static_String_String_0;

	public unsafe static int StackallocIntBufferSizeLimit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StackallocIntBufferSizeLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StackallocIntBufferSizeLimit, (void*)(&value));
		}
	}

	public unsafe static int PROBABILISTICMAP_BLOCK_INDEX_MASK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK, (void*)(&value));
		}
	}

	public unsafe static int PROBABILISTICMAP_BLOCK_INDEX_SHIFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT, (void*)(&value));
		}
	}

	public unsafe static int PROBABILISTICMAP_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROBABILISTICMAP_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROBABILISTICMAP_SIZE, (void*)(&value));
		}
	}

	public unsafe int _stringLength
	{
		get
		{
			nint num = (nint)IL2CPP.ManagedStringToIl2Cpp((string)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.ManagedStringToIl2Cpp((string)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringLength)) = value;
		}
	}

	public unsafe char _firstChar
	{
		get
		{
			nint num = (nint)IL2CPP.ManagedStringToIl2Cpp((string)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstChar);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.ManagedStringToIl2Cpp((string)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstChar)) = value;
		}
	}

	public unsafe static string Empty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Empty, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Empty, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int Length
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	[IndexerName("Chars")]
	public unsafe char this[int index]
	{
		[CallerCount(1502)]
		[CachedScanResults(RefRangeStart = 714076, RefRangeEnd = 715578, XrefRangeStart = 714075, XrefRangeEnd = 714076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static String()
	{
		Il2CppClassPointerStore<string>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "String");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<string>.NativeClassPtr);
		NativeFieldInfoPtr_StackallocIntBufferSizeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "StackallocIntBufferSizeLimit");
		NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_BLOCK_INDEX_MASK");
		NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_BLOCK_INDEX_SHIFT");
		NativeFieldInfoPtr_PROBABILISTICMAP_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_SIZE");
		NativeFieldInfoPtr__stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "_stringLength");
		NativeFieldInfoPtr__firstChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "_firstChar");
		NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "Empty");
		NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_Copy_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663955);
		NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663956);
		NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663958);
		NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663959);
		NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663960);
		NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_Insert_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_Remove_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_Replace_Public_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663991);
		NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_Substring_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_ToLower_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr_ToLowerInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_ToUpper_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_ToUpperInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_Trim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_Trim_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_TrimStart_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_TrimStart_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_TrimEnd_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_TrimEnd_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_Contains_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_Contains_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_InternalIntern_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_Intern_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664087);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701276, XrefRangeEnd = 701278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EqualsHelper(string strA, string strB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701278, XrefRangeEnd = 701280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexA;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &countA;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexB;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &countB;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701284, RefRangeEnd = 701285, XrefRangeStart = 701280, XrefRangeEnd = 701284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareOrdinalHelper(string strA, string strB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 701291, RefRangeEnd = 701329, XrefRangeStart = 701285, XrefRangeEnd = 701291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, string strB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 701330, RefRangeEnd = 701333, XrefRangeStart = 701329, XrefRangeEnd = 701330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, string strB, bool ignoreCase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 701339, RefRangeEnd = 701410, XrefRangeStart = 701333, XrefRangeEnd = 701339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, string strB, StringComparison comparisonType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(StringComparison**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701410, XrefRangeEnd = 701417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		*(CompareOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 701424, RefRangeEnd = 701428, XrefRangeStart = 701417, XrefRangeEnd = 701424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701439, RefRangeEnd = 701440, XrefRangeStart = 701428, XrefRangeEnd = 701439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexA;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexB;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701440, XrefRangeEnd = 701451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexA;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexB;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 701475, RefRangeEnd = 701502, XrefRangeStart = 701451, XrefRangeEnd = 701475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexA;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexB;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(StringComparison**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 701503, RefRangeEnd = 701560, XrefRangeStart = 701502, XrefRangeEnd = 701503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareOrdinal(string strA, string strB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701560, XrefRangeEnd = 701567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)strA));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)strB));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701573, RefRangeEnd = 701574, XrefRangeStart = 701567, XrefRangeEnd = 701573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexA;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strB);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexB;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701574, XrefRangeEnd = 701581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 701291, RefRangeEnd = 701329, XrefRangeStart = 701291, XrefRangeEnd = 701329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(string strB)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strB);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 701587, RefRangeEnd = 701605, XrefRangeStart = 701581, XrefRangeEnd = 701587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool EndsWith(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 701611, RefRangeEnd = 701624, XrefRangeStart = 701605, XrefRangeEnd = 701611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool EndsWith(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701624, XrefRangeEnd = 701626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(133)]
	[CachedScanResults(RefRangeStart = 701627, RefRangeEnd = 701760, XrefRangeStart = 701626, XrefRangeEnd = 701627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 701766, RefRangeEnd = 701780, XrefRangeStart = 701760, XrefRangeEnd = 701766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2037)]
	[CachedScanResults(RefRangeStart = 701781, RefRangeEnd = 703818, XrefRangeStart = 701780, XrefRangeEnd = 701781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equals(string a, string b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(132)]
	[CachedScanResults(RefRangeStart = 703824, RefRangeEnd = 703956, XrefRangeStart = 703818, XrefRangeEnd = 703824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equals(string a, string b, StringComparison comparisonType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(b);
		*(StringComparison**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2037)]
	[CachedScanResults(RefRangeStart = 701781, RefRangeEnd = 703818, XrefRangeStart = 701781, XrefRangeEnd = 703818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(string a, string b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(326)]
	[CachedScanResults(RefRangeStart = 703957, RefRangeEnd = 704283, XrefRangeStart = 703956, XrefRangeEnd = 703957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(string a, string b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetLegacyNonRandomizedHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(95)]
	[CachedScanResults(RefRangeStart = 704289, RefRangeEnd = 704384, XrefRangeStart = 704283, XrefRangeEnd = 704289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartsWith(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 704390, RefRangeEnd = 704405, XrefRangeStart = 704384, XrefRangeEnd = 704390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartsWith(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704405, XrefRangeEnd = 704406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckStringComparison(StringComparison comparisonType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&comparisonType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704406, XrefRangeEnd = 704407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(Il2CppStructArray<char> value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704407, XrefRangeEnd = 704410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(Il2CppStructArray<char> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(Il2CppStructArray<char> value, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 704413, RefRangeEnd = 704418, XrefRangeStart = 704410, XrefRangeEnd = 704413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(Il2CppStructArray<char> value, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(char* value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704418, XrefRangeEnd = 704422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(char* ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(char* value, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 704424, RefRangeEnd = 704425, XrefRangeStart = 704422, XrefRangeEnd = 704424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(char* ptr, int startIndex, int length)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(sbyte* value, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 704428, RefRangeEnd = 704430, XrefRangeStart = 704425, XrefRangeEnd = 704428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(sbyte* value, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704430, XrefRangeEnd = 704433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)pb;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 704439, RefRangeEnd = 704440, XrefRangeStart = 704433, XrefRangeEnd = 704439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(char c, int count)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704440, XrefRangeEnd = 704441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(char c, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704441, XrefRangeEnd = 704442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe String(ReadOnlySpan<char> value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704442, XrefRangeEnd = 704448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Ctor(ReadOnlySpan<char> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 704452, RefRangeEnd = 704453, XrefRangeStart = 704448, XrefRangeEnd = 704452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
	{
		//IL_0053->IL0056: Incompatible stack types: I vs Ref
		//IL_0046->IL0056: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&length);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TState reference;
		if (!typeof(TState).IsValueType)
		{
			object obj = state;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref state;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704453, XrefRangeEnd = 704454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator ReadOnlySpan<char>(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReadOnlySpan<char>(pointer);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 704456, RefRangeEnd = 704468, XrefRangeStart = 704454, XrefRangeEnd = 704456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Copy(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 704505, RefRangeEnd = 704518, XrefRangeStart = 704468, XrefRangeEnd = 704505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyTo(int sourceIndex, Il2CppStructArray<char> destination, int destinationIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&sourceIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 704523, RefRangeEnd = 704548, XrefRangeStart = 704518, XrefRangeEnd = 704523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<char> ToCharArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(1846)]
	[CachedScanResults(RefRangeStart = 704548, RefRangeEnd = 706394, XrefRangeStart = 704548, XrefRangeEnd = 704548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNullOrEmpty(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 706400, RefRangeEnd = 706406, XrefRangeStart = 706394, XrefRangeEnd = 706400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNullOrWhiteSpace(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(371)]
	[CachedScanResults(RefRangeStart = 706406, RefRangeEnd = 706777, XrefRangeStart = 706406, XrefRangeEnd = 706406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref char GetRawStringData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(char*)intPtr2;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 706778, RefRangeEnd = 706786, XrefRangeStart = 706777, XrefRangeEnd = 706778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)bytes;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 706787, RefRangeEnd = 706791, XrefRangeStart = 706786, XrefRangeEnd = 706787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateFromChar(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 706809, RefRangeEnd = 706816, XrefRangeStart = 706791, XrefRangeEnd = 706809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dmem;
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = smem;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &charCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706816, XrefRangeEnd = 706820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator<char> System_Collections_Generic_IEnumerable_System_Char__GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<char>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706820, XrefRangeEnd = 706824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 706826, RefRangeEnd = 706828, XrefRangeStart = 706824, XrefRangeEnd = 706826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int wcslen(char* ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual TypeCode GetTypeCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706828, XrefRangeEnd = 706832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_IConvertible_ToBoolean(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706832, XrefRangeEnd = 706836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual char System_IConvertible_ToChar(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706836, XrefRangeEnd = 706840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual sbyte System_IConvertible_ToSByte(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706840, XrefRangeEnd = 706844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual byte System_IConvertible_ToByte(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706844, XrefRangeEnd = 706848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual short System_IConvertible_ToInt16(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706848, XrefRangeEnd = 706852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ushort System_IConvertible_ToUInt16(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706852, XrefRangeEnd = 706856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int System_IConvertible_ToInt32(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706856, XrefRangeEnd = 706860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual uint System_IConvertible_ToUInt32(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706860, XrefRangeEnd = 706864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual long System_IConvertible_ToInt64(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706864, XrefRangeEnd = 706868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ulong System_IConvertible_ToUInt64(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706868, XrefRangeEnd = 706872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float System_IConvertible_ToSingle(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706872, XrefRangeEnd = 706876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual double System_IConvertible_ToDouble(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706876, XrefRangeEnd = 706880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706880, XrefRangeEnd = 706884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706884, XrefRangeEnd = 706888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object System_IConvertible_ToType(Type type, IFormatProvider provider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 706892, RefRangeEnd = 706899, XrefRangeStart = 706888, XrefRangeEnd = 706892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Normalize(NormalizationForm normalizationForm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalizationForm);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706899, XrefRangeEnd = 706906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillStringChecked(string dest, int destPos, string src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dest);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destPos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(src);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706906, XrefRangeEnd = 706909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat(Object arg0, Object arg1, Object arg2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 706944, RefRangeEnd = 706945, XrefRangeStart = 706909, XrefRangeEnd = 706944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat(IEnumerable<string> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1221)]
	[CachedScanResults(RefRangeStart = 706948, RefRangeEnd = 708169, XrefRangeStart = 706945, XrefRangeEnd = 706948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat(string str0, string str1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(711)]
	[CachedScanResults(RefRangeStart = 708173, RefRangeEnd = 708884, XrefRangeStart = 708169, XrefRangeEnd = 708173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat(string str0, string str1, string str2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(125)]
	[CachedScanResults(RefRangeStart = 708889, RefRangeEnd = 709014, XrefRangeStart = 708884, XrefRangeEnd = 708889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat(string str0, string str1, string str2, string str3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(157)]
	[CachedScanResults(RefRangeStart = 709019, RefRangeEnd = 709176, XrefRangeStart = 709014, XrefRangeEnd = 709019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Concat([Optional] Il2CppStringArray values)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (values == null)
		{
			values = new Il2CppStringArray(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1345)]
	[CachedScanResults(RefRangeStart = 709184, RefRangeEnd = 710529, XrefRangeStart = 709176, XrefRangeEnd = 709184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string format, Object arg0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(737)]
	[CachedScanResults(RefRangeStart = 710537, RefRangeEnd = 711274, XrefRangeStart = 710529, XrefRangeEnd = 710537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string format, Object arg0, Object arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 711282, RefRangeEnd = 711416, XrefRangeStart = 711274, XrefRangeEnd = 711282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string format, Object arg0, Object arg1, Object arg2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(155)]
	[CachedScanResults(RefRangeStart = 711424, RefRangeEnd = 711579, XrefRangeStart = 711416, XrefRangeEnd = 711424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 711587, RefRangeEnd = 711611, XrefRangeStart = 711579, XrefRangeEnd = 711587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(IFormatProvider provider, string format, Object arg0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 711619, RefRangeEnd = 711631, XrefRangeStart = 711611, XrefRangeEnd = 711619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 711639, RefRangeEnd = 711643, XrefRangeStart = 711631, XrefRangeEnd = 711639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1, Object arg2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 711651, RefRangeEnd = 711659, XrefRangeStart = 711643, XrefRangeEnd = 711651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711659, XrefRangeEnd = 711666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 711670, RefRangeEnd = 711691, XrefRangeStart = 711666, XrefRangeEnd = 711670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Insert(int startIndex, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Insert_Public_String_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 711692, RefRangeEnd = 711693, XrefRangeStart = 711691, XrefRangeEnd = 711692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join(char separator, [Optional] Il2CppStringArray value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (value == null)
		{
			value = new Il2CppStringArray(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711693, XrefRangeEnd = 711694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join(char separator, Il2CppStringArray value, int startIndex, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppStringArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 711696, RefRangeEnd = 711715, XrefRangeStart = 711694, XrefRangeEnd = 711696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join(string separator, [Optional] Il2CppStringArray value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (value == null)
		{
			value = new Il2CppStringArray(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 711732, RefRangeEnd = 711736, XrefRangeStart = 711715, XrefRangeEnd = 711732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join<T>(string separator, IEnumerable<T> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Join_Public_Static_String_String_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 711772, RefRangeEnd = 711781, XrefRangeStart = 711736, XrefRangeEnd = 711772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join(string separator, IEnumerable<string> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 711783, RefRangeEnd = 711786, XrefRangeStart = 711781, XrefRangeEnd = 711783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Join(string separator, Il2CppStringArray value, int startIndex, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 711828, RefRangeEnd = 711829, XrefRangeStart = 711786, XrefRangeEnd = 711828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)separator;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &separatorLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 711835, RefRangeEnd = 711839, XrefRangeStart = 711829, XrefRangeEnd = 711835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string JoinCore(char* separator, int separatorLength, Il2CppStringArray value, int startIndex, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)separator;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &separatorLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 711841, RefRangeEnd = 711848, XrefRangeStart = 711839, XrefRangeEnd = 711841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string PadLeft(int totalWidth, char paddingChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&totalWidth);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 711850, RefRangeEnd = 711851, XrefRangeStart = 711848, XrefRangeEnd = 711850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string PadRight(int totalWidth, char paddingChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&totalWidth);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 711854, RefRangeEnd = 711884, XrefRangeStart = 711851, XrefRangeEnd = 711854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Remove(int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 711899, RefRangeEnd = 711902, XrefRangeStart = 711884, XrefRangeEnd = 711899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Remove(int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 711904, RefRangeEnd = 711942, XrefRangeStart = 711902, XrefRangeEnd = 711904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(char oldChar, char newChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&oldChar);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(162)]
	[CachedScanResults(RefRangeStart = 711962, RefRangeEnd = 712124, XrefRangeStart = 711942, XrefRangeEnd = 711962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Replace(string oldValue, string newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 712149, RefRangeEnd = 712150, XrefRangeStart = 712124, XrefRangeEnd = 712149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&oldValueLength);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(78)]
	[CachedScanResults(RefRangeStart = 712152, RefRangeEnd = 712230, XrefRangeStart = 712150, XrefRangeEnd = 712152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(char separator, StringSplitOptions options = StringSplitOptions.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&separator);
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 712234, RefRangeEnd = 712252, XrefRangeStart = 712230, XrefRangeEnd = 712234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split([Optional] Il2CppStructArray<char> separator)
	{
		if (separator == null)
		{
			separator = new Il2CppStructArray<char>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)separator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 712256, RefRangeEnd = 712259, XrefRangeStart = 712252, XrefRangeEnd = 712256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(Il2CppStructArray<char> separator, StringSplitOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)separator);
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 712277, RefRangeEnd = 712281, XrefRangeStart = 712259, XrefRangeEnd = 712277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)separators));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 712283, RefRangeEnd = 712289, XrefRangeStart = 712281, XrefRangeEnd = 712283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(string separator, StringSplitOptions options = StringSplitOptions.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 712290, RefRangeEnd = 712297, XrefRangeStart = 712289, XrefRangeEnd = 712290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray Split(Il2CppStringArray separator, StringSplitOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)separator);
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 712329, RefRangeEnd = 712331, XrefRangeStart = 712297, XrefRangeEnd = 712329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray SplitInternal(string separator, Il2CppStringArray separators, int count, StringSplitOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)separators);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 712358, RefRangeEnd = 712359, XrefRangeStart = 712331, XrefRangeEnd = 712358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray SplitInternal(string separator, int count, StringSplitOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(StringSplitOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 712371, RefRangeEnd = 712374, XrefRangeStart = 712359, XrefRangeEnd = 712371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sepList));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lengthList));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 712393, RefRangeEnd = 712396, XrefRangeStart = 712374, XrefRangeEnd = 712393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sepList));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lengthList));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 712403, RefRangeEnd = 712404, XrefRangeStart = 712396, XrefRangeEnd = 712403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)separators));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sepListBuilder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712404, XrefRangeEnd = 712415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sepListBuilder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 712429, RefRangeEnd = 712430, XrefRangeStart = 712415, XrefRangeEnd = 712429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeSeparatorList(Il2CppStringArray separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)separators);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sepListBuilder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lengthListBuilder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(159)]
	[CachedScanResults(RefRangeStart = 712431, RefRangeEnd = 712590, XrefRangeStart = 712430, XrefRangeEnd = 712431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Substring(int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Substring_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(392)]
	[CachedScanResults(RefRangeStart = 712590, RefRangeEnd = 712982, XrefRangeStart = 712590, XrefRangeEnd = 712590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Substring(int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712982, XrefRangeEnd = 712984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InternalSubString(int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 712989, RefRangeEnd = 713038, XrefRangeStart = 712984, XrefRangeEnd = 712989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToLower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLower_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 713045, RefRangeEnd = 713063, XrefRangeStart = 713038, XrefRangeEnd = 713045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToLower(CultureInfo culture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 713068, RefRangeEnd = 713089, XrefRangeStart = 713063, XrefRangeEnd = 713068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToLowerInvariant()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLowerInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 713094, RefRangeEnd = 713104, XrefRangeStart = 713089, XrefRangeEnd = 713094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToUpper()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpper_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 713111, RefRangeEnd = 713118, XrefRangeStart = 713104, XrefRangeEnd = 713111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToUpper(CultureInfo culture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)culture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 713123, RefRangeEnd = 713144, XrefRangeStart = 713118, XrefRangeEnd = 713123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToUpperInvariant()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(80)]
	[CachedScanResults(RefRangeStart = 713145, RefRangeEnd = 713225, XrefRangeStart = 713144, XrefRangeEnd = 713145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Trim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713226, RefRangeEnd = 713228, XrefRangeStart = 713225, XrefRangeEnd = 713226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Trim(char trimChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trimChar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 713229, RefRangeEnd = 713244, XrefRangeStart = 713228, XrefRangeEnd = 713229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Trim([Optional] Il2CppStructArray<char> trimChars)
	{
		if (trimChars == null)
		{
			trimChars = new Il2CppStructArray<char>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trimChars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713245, RefRangeEnd = 713246, XrefRangeStart = 713244, XrefRangeEnd = 713245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimStart_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 713247, RefRangeEnd = 713254, XrefRangeStart = 713246, XrefRangeEnd = 713247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimStart(char trimChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trimChar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimStart_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713255, RefRangeEnd = 713256, XrefRangeStart = 713254, XrefRangeEnd = 713255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimStart([Optional] Il2CppStructArray<char> trimChars)
	{
		if (trimChars == null)
		{
			trimChars = new Il2CppStructArray<char>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trimChars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 713257, RefRangeEnd = 713262, XrefRangeStart = 713256, XrefRangeEnd = 713257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimEnd_Public_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 713263, RefRangeEnd = 713270, XrefRangeStart = 713262, XrefRangeEnd = 713263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimEnd(char trimChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trimChar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimEnd_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 713271, RefRangeEnd = 713278, XrefRangeStart = 713270, XrefRangeEnd = 713271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimEnd([Optional] Il2CppStructArray<char> trimChars)
	{
		if (trimChars == null)
		{
			trimChars = new Il2CppStructArray<char>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trimChars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713286, RefRangeEnd = 713289, XrefRangeStart = 713278, XrefRangeEnd = 713286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimWhiteSpaceHelper(TrimType trimType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trimType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 713291, RefRangeEnd = 713297, XrefRangeStart = 713289, XrefRangeEnd = 713291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)trimChars;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trimCharsLength;
		*(TrimType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &trimType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe string CreateTrimmedString(int start, int end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 713303, RefRangeEnd = 713393, XrefRangeStart = 713297, XrefRangeEnd = 713303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713394, RefRangeEnd = 713397, XrefRangeStart = 713393, XrefRangeEnd = 713394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 713398, RefRangeEnd = 713407, XrefRangeStart = 713397, XrefRangeEnd = 713398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(char value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(109)]
	[CachedScanResults(RefRangeStart = 713408, RefRangeEnd = 713517, XrefRangeStart = 713407, XrefRangeEnd = 713408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(char value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 713518, RefRangeEnd = 713540, XrefRangeStart = 713517, XrefRangeEnd = 713518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(char value, int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 713541, RefRangeEnd = 713546, XrefRangeStart = 713540, XrefRangeEnd = 713541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(char value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 713547, RefRangeEnd = 713578, XrefRangeStart = 713546, XrefRangeEnd = 713547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 713579, RefRangeEnd = 713584, XrefRangeStart = 713578, XrefRangeEnd = 713579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 713592, RefRangeEnd = 713596, XrefRangeStart = 713584, XrefRangeEnd = 713592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int IndexOfAny(char value1, char value2, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value1);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value1);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value3;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713596, XrefRangeEnd = 713601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfCharArray(Il2CppStructArray<char> anyOf, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 713603, RefRangeEnd = 713607, XrefRangeStart = 713601, XrefRangeEnd = 713603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)charMap;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)anyOf));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713607, XrefRangeEnd = 713608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ArrayContains(char searchChar, Il2CppStructArray<char> anyOf)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&searchChar);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsCharBitSet(uint* charMap, byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)charMap;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void SetCharBit(uint* charMap, byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)charMap;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(99)]
	[CachedScanResults(RefRangeStart = 713609, RefRangeEnd = 713708, XrefRangeStart = 713608, XrefRangeEnd = 713609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 713709, RefRangeEnd = 713752, XrefRangeStart = 713708, XrefRangeEnd = 713709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value, int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 713753, RefRangeEnd = 713760, XrefRangeStart = 713752, XrefRangeEnd = 713753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 713761, RefRangeEnd = 713778, XrefRangeStart = 713760, XrefRangeEnd = 713761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713779, RefRangeEnd = 713782, XrefRangeStart = 713778, XrefRangeEnd = 713779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(StringComparison**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 713788, RefRangeEnd = 713794, XrefRangeStart = 713782, XrefRangeEnd = 713788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(StringComparison**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 713795, RefRangeEnd = 713826, XrefRangeStart = 713794, XrefRangeEnd = 713795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(char value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713827, RefRangeEnd = 713830, XrefRangeStart = 713826, XrefRangeEnd = 713827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(char value, int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713831, RefRangeEnd = 713833, XrefRangeStart = 713830, XrefRangeEnd = 713831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(char value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713834, RefRangeEnd = 713837, XrefRangeStart = 713833, XrefRangeEnd = 713834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713838, RefRangeEnd = 713841, XrefRangeStart = 713837, XrefRangeEnd = 713838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713842, RefRangeEnd = 713844, XrefRangeStart = 713841, XrefRangeEnd = 713842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713844, XrefRangeEnd = 713849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfCharArray(Il2CppStructArray<char> anyOf, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)anyOf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 713850, RefRangeEnd = 713861, XrefRangeStart = 713849, XrefRangeEnd = 713850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 713862, RefRangeEnd = 713865, XrefRangeStart = 713861, XrefRangeEnd = 713862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(string value, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(StringComparison**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713867, RefRangeEnd = 713869, XrefRangeStart = 713865, XrefRangeEnd = 713867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(StringComparison**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparisonType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713871, RefRangeEnd = 713872, XrefRangeStart = 713869, XrefRangeEnd = 713871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfUnchecked(string value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713878, RefRangeEnd = 713880, XrefRangeStart = 713872, XrefRangeEnd = 713878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713881, RefRangeEnd = 713882, XrefRangeStart = 713880, XrefRangeEnd = 713881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfUnchecked(string value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713887, RefRangeEnd = 713889, XrefRangeStart = 713882, XrefRangeEnd = 713887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 713889, RefRangeEnd = 713891, XrefRangeStart = 713889, XrefRangeEnd = 713889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartsWithOrdinalUnchecked(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 713892, RefRangeEnd = 713910, XrefRangeStart = 713891, XrefRangeEnd = 713892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FastAllocateString(int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&length);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713910, XrefRangeEnd = 713911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalIntern(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIntern_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713911, XrefRangeEnd = 713912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void memset(byte* dest, int val, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713912, XrefRangeEnd = 713913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void memcpy(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713913, XrefRangeEnd = 713915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void bzero(byte* dest, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void bzero_aligned_1(byte* dest, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void bzero_aligned_2(byte* dest, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713915, RefRangeEnd = 713916, XrefRangeStart = 713915, XrefRangeEnd = 713915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void bzero_aligned_4(byte* dest, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void bzero_aligned_8(byte* dest, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713916, RefRangeEnd = 713917, XrefRangeStart = 713916, XrefRangeEnd = 713916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713917, XrefRangeEnd = 713918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(sbyte* value, int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 713922, RefRangeEnd = 713927, XrefRangeStart = 713918, XrefRangeEnd = 713922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(char* value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 713928, RefRangeEnd = 713952, XrefRangeStart = 713927, XrefRangeEnd = 713928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(char* value, int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 713953, RefRangeEnd = 713997, XrefRangeStart = 713952, XrefRangeEnd = 713953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(Il2CppStructArray<char> val, int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 713999, RefRangeEnd = 714031, XrefRangeStart = 713997, XrefRangeEnd = 713999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(Il2CppStructArray<char> val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 714032, RefRangeEnd = 714043, XrefRangeStart = 714031, XrefRangeEnd = 714032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(char c, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 714044, RefRangeEnd = 714047, XrefRangeStart = 714043, XrefRangeEnd = 714044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)value;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 714053, RefRangeEnd = 714075, XrefRangeStart = 714047, XrefRangeEnd = 714053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CreateString(ReadOnlySpan<char> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0, IL2CPP.ManagedStringToIl2Cpp((string)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 715585, RefRangeEnd = 715591, XrefRangeStart = 715578, XrefRangeEnd = 715585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Intern(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Intern_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public static string Concat(params string[] values)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return Concat(new Il2CppStringArray(values));
	}

	public static string Format(string format, params Object[] args)
	{
		return Format(format, new Il2CppReferenceArray<Object>(args));
	}

	public static string Format(IFormatProvider provider, string format, params Object[] args)
	{
		return Format(provider, format, new Il2CppReferenceArray<Object>(args));
	}

	public static string Join(char separator, params string[] value)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return Join(separator, new Il2CppStringArray(value));
	}

	public static string Join(string separator, params string[] value)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return Join(separator, new Il2CppStringArray(value));
	}

	public Il2CppStringArray Split(params char[] separator)
	{
		return Split(new Il2CppStructArray<char>(separator));
	}

	public string Trim(params char[] trimChars)
	{
		return Trim(new Il2CppStructArray<char>(trimChars));
	}

	public string TrimStart(params char[] trimChars)
	{
		return TrimStart(new Il2CppStructArray<char>(trimChars));
	}

	public string TrimEnd(params char[] trimChars)
	{
		return TrimEnd(new Il2CppStructArray<char>(trimChars));
	}

	public String(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator String(string P_0)
	{
		if (P_0 == null)
		{
			return P_0;
		}
		return new String(IL2CPP.ManagedStringToIl2Cpp(P_0));
	}

	public static implicit operator string(String P_0)
	{
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P_0);
		if (intPtr == (System.IntPtr)0)
		{
			return null;
		}
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}
}
