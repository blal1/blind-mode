using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class Convert : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_decodingMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConvertTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnumType;

	private static readonly System.IntPtr NativeFieldInfoPtr_base64Table;

	private static readonly System.IntPtr NativeFieldInfoPtr_DBNull;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0;

	public unsafe static Il2CppStructArray<sbyte> s_decodingMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_decodingMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_decodingMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Type> ConvertTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConvertTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConvertTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Type EnumType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnumType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> base64Table
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_base64Table, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_base64Table, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object DBNull
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DBNull, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DBNull, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Convert()
	{
		Il2CppClassPointerStore<Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Convert");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Convert>.NativeClassPtr);
		NativeFieldInfoPtr_s_decodingMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "s_decodingMap");
		NativeFieldInfoPtr_ConvertTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "ConvertTypes");
		NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "EnumType");
		NativeFieldInfoPtr_base64Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "base64Table");
		NativeFieldInfoPtr_DBNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "DBNull");
		NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664565);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664575);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664637);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664638);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664639);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664640);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664641);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664642);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664643);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664644);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664645);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664646);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664647);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664648);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664649);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664650);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664651);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664652);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664653);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664654);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664655);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664656);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664657);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664658);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664659);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664660);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664661);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664662);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664663);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664664);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664665);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664666);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664667);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664668);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664669);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664670);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664671);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664672);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664673);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664674);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664679);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664680);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664681);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664714);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664718);
		NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664719);
		NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664728);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664729);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664730);
		NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664731);
		NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664732);
		NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664733);
		NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664734);
		NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664735);
		NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664736);
		NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664737);
		NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664738);
		NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664739);
		NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664740);
		NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664741);
		NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664742);
		NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664744);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721478, RefRangeEnd = 721480, XrefRangeStart = 721457, XrefRangeEnd = 721478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)utf16));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bytes));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref consumed);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref written);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Decode(ref char encodedChars, ref sbyte decodingMap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref encodedChars);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref decodingMap);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void WriteThreeLowOrderBytes(ref byte destination, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref destination);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721483, RefRangeEnd = 721486, XrefRangeStart = 721480, XrefRangeEnd = 721483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeCode GetTypeCode(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721486, XrefRangeEnd = 721497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object ChangeType(Object value, TypeCode typeCode, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(TypeCode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeCode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 721556, RefRangeEnd = 721573, XrefRangeStart = 721497, XrefRangeEnd = 721556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721581, RefRangeEnd = 721584, XrefRangeStart = 721573, XrefRangeEnd = 721581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object ChangeType(Object value, Type conversionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conversionType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721634, RefRangeEnd = 721637, XrefRangeStart = 721584, XrefRangeEnd = 721634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object ChangeType(Object value, Type conversionType, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conversionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721637, XrefRangeEnd = 721643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowCharOverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721643, XrefRangeEnd = 721649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowByteOverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721649, XrefRangeEnd = 721655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowSByteOverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721655, XrefRangeEnd = 721661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInt16OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721661, XrefRangeEnd = 721667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowUInt16OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721667, XrefRangeEnd = 721673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInt32OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721673, XrefRangeEnd = 721679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowUInt32OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721679, XrefRangeEnd = 721685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInt64OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721685, XrefRangeEnd = 721691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowUInt64OverflowException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 721692, RefRangeEnd = 721746, XrefRangeStart = 721691, XrefRangeEnd = 721692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721747, RefRangeEnd = 721750, XrefRangeStart = 721746, XrefRangeEnd = 721747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 721750, RefRangeEnd = 721764, XrefRangeStart = 721750, XrefRangeEnd = 721750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 721750, RefRangeEnd = 721764, XrefRangeStart = 721750, XrefRangeEnd = 721764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721764, RefRangeEnd = 721766, XrefRangeStart = 721764, XrefRangeEnd = 721764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721764, RefRangeEnd = 721766, XrefRangeStart = 721764, XrefRangeEnd = 721766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 564182, RefRangeEnd = 564187, XrefRangeStart = 564182, XrefRangeEnd = 564187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 564182, RefRangeEnd = 564187, XrefRangeStart = 564182, XrefRangeEnd = 564187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 293244, RefRangeEnd = 293246, XrefRangeStart = 293244, XrefRangeEnd = 293246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 293244, RefRangeEnd = 293246, XrefRangeStart = 293244, XrefRangeEnd = 293246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 721769, RefRangeEnd = 721779, XrefRangeStart = 721766, XrefRangeEnd = 721769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 721769, RefRangeEnd = 721779, XrefRangeStart = 721769, XrefRangeEnd = 721779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721779, RefRangeEnd = 721780, XrefRangeStart = 721779, XrefRangeEnd = 721779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721780, RefRangeEnd = 721781, XrefRangeStart = 721780, XrefRangeEnd = 721780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721786, RefRangeEnd = 721787, XrefRangeStart = 721781, XrefRangeEnd = 721786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721787, XrefRangeEnd = 721788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721789, RefRangeEnd = 721791, XrefRangeStart = 721788, XrefRangeEnd = 721789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721792, RefRangeEnd = 721793, XrefRangeStart = 721791, XrefRangeEnd = 721792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721794, RefRangeEnd = 721795, XrefRangeStart = 721793, XrefRangeEnd = 721794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 721796, RefRangeEnd = 721815, XrefRangeStart = 721795, XrefRangeEnd = 721796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721816, RefRangeEnd = 721817, XrefRangeStart = 721815, XrefRangeEnd = 721816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721818, RefRangeEnd = 721819, XrefRangeStart = 721817, XrefRangeEnd = 721818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721820, RefRangeEnd = 721821, XrefRangeStart = 721819, XrefRangeEnd = 721820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721821, XrefRangeEnd = 721837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721850, RefRangeEnd = 721851, XrefRangeStart = 721837, XrefRangeEnd = 721850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721851, XrefRangeEnd = 721852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721853, RefRangeEnd = 721854, XrefRangeStart = 721852, XrefRangeEnd = 721853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 721750, RefRangeEnd = 721764, XrefRangeStart = 721750, XrefRangeEnd = 721764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721854, XrefRangeEnd = 721855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721855, XrefRangeEnd = 721856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721857, RefRangeEnd = 721858, XrefRangeStart = 721856, XrefRangeEnd = 721857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721859, RefRangeEnd = 721860, XrefRangeStart = 721858, XrefRangeEnd = 721859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721861, RefRangeEnd = 721862, XrefRangeStart = 721860, XrefRangeEnd = 721861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721863, RefRangeEnd = 721864, XrefRangeStart = 721862, XrefRangeEnd = 721863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721865, RefRangeEnd = 721866, XrefRangeStart = 721864, XrefRangeEnd = 721865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721867, RefRangeEnd = 721868, XrefRangeStart = 721866, XrefRangeEnd = 721867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721876, RefRangeEnd = 721877, XrefRangeStart = 721868, XrefRangeEnd = 721876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721882, RefRangeEnd = 721883, XrefRangeStart = 721877, XrefRangeEnd = 721882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721888, RefRangeEnd = 721889, XrefRangeStart = 721883, XrefRangeEnd = 721888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721890, RefRangeEnd = 721891, XrefRangeStart = 721889, XrefRangeEnd = 721890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721891, XrefRangeEnd = 721892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721893, RefRangeEnd = 721895, XrefRangeStart = 721892, XrefRangeEnd = 721893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 721750, RefRangeEnd = 721764, XrefRangeStart = 721750, XrefRangeEnd = 721764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721895, XrefRangeEnd = 721896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721897, RefRangeEnd = 721898, XrefRangeStart = 721896, XrefRangeEnd = 721897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721899, RefRangeEnd = 721900, XrefRangeStart = 721898, XrefRangeEnd = 721899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721901, RefRangeEnd = 721902, XrefRangeStart = 721900, XrefRangeEnd = 721901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721903, RefRangeEnd = 721906, XrefRangeStart = 721902, XrefRangeEnd = 721903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721907, RefRangeEnd = 721908, XrefRangeStart = 721906, XrefRangeEnd = 721907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721909, RefRangeEnd = 721912, XrefRangeStart = 721908, XrefRangeEnd = 721909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721913, RefRangeEnd = 721914, XrefRangeStart = 721912, XrefRangeEnd = 721913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721922, RefRangeEnd = 721923, XrefRangeStart = 721914, XrefRangeEnd = 721922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721928, RefRangeEnd = 721929, XrefRangeStart = 721923, XrefRangeEnd = 721928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721934, RefRangeEnd = 721935, XrefRangeStart = 721929, XrefRangeEnd = 721934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 721943, RefRangeEnd = 721945, XrefRangeStart = 721935, XrefRangeEnd = 721943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 721950, RefRangeEnd = 721953, XrefRangeStart = 721945, XrefRangeEnd = 721950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721953, XrefRangeEnd = 721954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721955, RefRangeEnd = 721956, XrefRangeStart = 721954, XrefRangeEnd = 721955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721972, XrefRangeEnd = 721973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721973, RefRangeEnd = 721974, XrefRangeStart = 721973, XrefRangeEnd = 721973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721975, RefRangeEnd = 721976, XrefRangeStart = 721974, XrefRangeEnd = 721975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721977, RefRangeEnd = 721978, XrefRangeStart = 721976, XrefRangeEnd = 721977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721979, RefRangeEnd = 721980, XrefRangeStart = 721978, XrefRangeEnd = 721979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721981, RefRangeEnd = 721982, XrefRangeStart = 721980, XrefRangeEnd = 721981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721983, RefRangeEnd = 721984, XrefRangeStart = 721982, XrefRangeEnd = 721983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721992, RefRangeEnd = 721993, XrefRangeStart = 721984, XrefRangeEnd = 721992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 721998, RefRangeEnd = 721999, XrefRangeStart = 721993, XrefRangeEnd = 721998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722004, RefRangeEnd = 722005, XrefRangeStart = 721999, XrefRangeEnd = 722004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 722006, RefRangeEnd = 722014, XrefRangeStart = 722005, XrefRangeEnd = 722006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722014, XrefRangeEnd = 722015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722016, RefRangeEnd = 722017, XrefRangeStart = 722015, XrefRangeEnd = 722016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722018, RefRangeEnd = 722019, XrefRangeStart = 722017, XrefRangeEnd = 722018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722020, RefRangeEnd = 722021, XrefRangeStart = 722019, XrefRangeEnd = 722020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722022, RefRangeEnd = 722023, XrefRangeStart = 722021, XrefRangeEnd = 722022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722024, RefRangeEnd = 722025, XrefRangeStart = 722023, XrefRangeEnd = 722024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722026, RefRangeEnd = 722027, XrefRangeStart = 722025, XrefRangeEnd = 722026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722028, RefRangeEnd = 722029, XrefRangeStart = 722027, XrefRangeEnd = 722028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722037, RefRangeEnd = 722038, XrefRangeStart = 722029, XrefRangeEnd = 722037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722043, RefRangeEnd = 722044, XrefRangeStart = 722038, XrefRangeEnd = 722043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722049, RefRangeEnd = 722050, XrefRangeStart = 722044, XrefRangeEnd = 722049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722051, RefRangeEnd = 722052, XrefRangeStart = 722050, XrefRangeEnd = 722051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(518)]
	[CachedScanResults(RefRangeStart = 722053, RefRangeEnd = 722571, XrefRangeStart = 722052, XrefRangeEnd = 722053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722572, RefRangeEnd = 722575, XrefRangeStart = 722571, XrefRangeEnd = 722572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722575, RefRangeEnd = 722576, XrefRangeStart = 722575, XrefRangeEnd = 722575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722577, RefRangeEnd = 722578, XrefRangeStart = 722576, XrefRangeEnd = 722577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 298567, RefRangeEnd = 298596, XrefRangeStart = 298567, XrefRangeEnd = 298596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722579, RefRangeEnd = 722582, XrefRangeStart = 722578, XrefRangeEnd = 722579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722583, RefRangeEnd = 722584, XrefRangeStart = 722582, XrefRangeEnd = 722583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722588, RefRangeEnd = 722591, XrefRangeStart = 722584, XrefRangeEnd = 722588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 722591, RefRangeEnd = 722602, XrefRangeStart = 722591, XrefRangeEnd = 722591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722607, RefRangeEnd = 722608, XrefRangeStart = 722602, XrefRangeEnd = 722607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(80)]
	[CachedScanResults(RefRangeStart = 722613, RefRangeEnd = 722693, XrefRangeStart = 722608, XrefRangeEnd = 722613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722694, RefRangeEnd = 722697, XrefRangeStart = 722693, XrefRangeEnd = 722694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 722698, RefRangeEnd = 722706, XrefRangeStart = 722697, XrefRangeEnd = 722698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722707, RefRangeEnd = 722708, XrefRangeStart = 722706, XrefRangeEnd = 722707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722709, RefRangeEnd = 722710, XrefRangeStart = 722708, XrefRangeEnd = 722709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722711, RefRangeEnd = 722712, XrefRangeStart = 722710, XrefRangeEnd = 722711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722713, RefRangeEnd = 722714, XrefRangeStart = 722712, XrefRangeEnd = 722713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722715, RefRangeEnd = 722716, XrefRangeStart = 722714, XrefRangeEnd = 722715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722717, RefRangeEnd = 722718, XrefRangeStart = 722716, XrefRangeEnd = 722717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722722, RefRangeEnd = 722723, XrefRangeStart = 722718, XrefRangeEnd = 722722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722724, RefRangeEnd = 722725, XrefRangeStart = 722723, XrefRangeEnd = 722724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722730, RefRangeEnd = 722731, XrefRangeStart = 722725, XrefRangeEnd = 722730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722732, RefRangeEnd = 722733, XrefRangeStart = 722731, XrefRangeEnd = 722732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 722734, RefRangeEnd = 722760, XrefRangeStart = 722733, XrefRangeEnd = 722734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 722761, RefRangeEnd = 722765, XrefRangeStart = 722760, XrefRangeEnd = 722761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long ToInt64(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722765, RefRangeEnd = 722766, XrefRangeStart = 722765, XrefRangeEnd = 722765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722766, RefRangeEnd = 722767, XrefRangeStart = 722766, XrefRangeEnd = 722766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 722767, RefRangeEnd = 722804, XrefRangeStart = 722767, XrefRangeEnd = 722767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 298567, RefRangeEnd = 298596, XrefRangeStart = 298567, XrefRangeEnd = 298596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722805, RefRangeEnd = 722806, XrefRangeStart = 722804, XrefRangeEnd = 722805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722814, RefRangeEnd = 722815, XrefRangeStart = 722806, XrefRangeEnd = 722814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722820, RefRangeEnd = 722821, XrefRangeStart = 722815, XrefRangeEnd = 722820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722826, RefRangeEnd = 722827, XrefRangeStart = 722821, XrefRangeEnd = 722826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722832, RefRangeEnd = 722834, XrefRangeStart = 722827, XrefRangeEnd = 722832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722835, RefRangeEnd = 722838, XrefRangeStart = 722834, XrefRangeEnd = 722835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722839, RefRangeEnd = 722841, XrefRangeStart = 722838, XrefRangeEnd = 722839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 722842, RefRangeEnd = 722845, XrefRangeStart = 722841, XrefRangeEnd = 722842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(char value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722846, RefRangeEnd = 722847, XrefRangeStart = 722845, XrefRangeEnd = 722846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 24426, RefRangeEnd = 24437, XrefRangeStart = 24426, XrefRangeEnd = 24437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722848, RefRangeEnd = 722849, XrefRangeStart = 722847, XrefRangeEnd = 722848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 24408, RefRangeEnd = 24423, XrefRangeStart = 24408, XrefRangeEnd = 24423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722850, RefRangeEnd = 722851, XrefRangeStart = 722849, XrefRangeEnd = 722850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 298567, RefRangeEnd = 298596, XrefRangeStart = 298567, XrefRangeEnd = 298596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722852, RefRangeEnd = 722853, XrefRangeStart = 722851, XrefRangeEnd = 722852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722861, RefRangeEnd = 722862, XrefRangeStart = 722853, XrefRangeEnd = 722861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722867, RefRangeEnd = 722868, XrefRangeStart = 722862, XrefRangeEnd = 722867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722873, RefRangeEnd = 722874, XrefRangeStart = 722868, XrefRangeEnd = 722873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722875, RefRangeEnd = 722876, XrefRangeStart = 722874, XrefRangeEnd = 722875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722877, RefRangeEnd = 722879, XrefRangeStart = 722876, XrefRangeEnd = 722877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722880, RefRangeEnd = 722882, XrefRangeStart = 722879, XrefRangeEnd = 722880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722882, RefRangeEnd = 722883, XrefRangeStart = 722882, XrefRangeEnd = 722882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ToSingle(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722883, RefRangeEnd = 722884, XrefRangeStart = 722883, XrefRangeEnd = 722883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722884, RefRangeEnd = 722885, XrefRangeStart = 722884, XrefRangeEnd = 722884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722885, RefRangeEnd = 722886, XrefRangeStart = 722885, XrefRangeEnd = 722885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722886, RefRangeEnd = 722887, XrefRangeStart = 722886, XrefRangeEnd = 722886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722887, RefRangeEnd = 722888, XrefRangeStart = 722887, XrefRangeEnd = 722887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722888, RefRangeEnd = 722889, XrefRangeStart = 722888, XrefRangeEnd = 722888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722889, RefRangeEnd = 722890, XrefRangeStart = 722889, XrefRangeEnd = 722889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722894, RefRangeEnd = 722895, XrefRangeStart = 722890, XrefRangeEnd = 722894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722895, XrefRangeEnd = 722900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722901, RefRangeEnd = 722902, XrefRangeStart = 722900, XrefRangeEnd = 722901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ToSingle(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722903, RefRangeEnd = 722905, XrefRangeStart = 722902, XrefRangeEnd = 722903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722906, RefRangeEnd = 722907, XrefRangeStart = 722905, XrefRangeEnd = 722906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722907, RefRangeEnd = 722908, XrefRangeStart = 722907, XrefRangeEnd = 722907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double ToDouble(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722908, RefRangeEnd = 722909, XrefRangeStart = 722908, XrefRangeEnd = 722908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722909, RefRangeEnd = 722910, XrefRangeStart = 722909, XrefRangeEnd = 722909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722910, RefRangeEnd = 722911, XrefRangeStart = 722910, XrefRangeEnd = 722910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722911, RefRangeEnd = 722912, XrefRangeStart = 722911, XrefRangeEnd = 722911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722912, RefRangeEnd = 722913, XrefRangeStart = 722912, XrefRangeEnd = 722912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722913, RefRangeEnd = 722914, XrefRangeStart = 722913, XrefRangeEnd = 722913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722914, RefRangeEnd = 722915, XrefRangeStart = 722914, XrefRangeEnd = 722914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722919, RefRangeEnd = 722920, XrefRangeStart = 722915, XrefRangeEnd = 722919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722921, RefRangeEnd = 722922, XrefRangeStart = 722920, XrefRangeEnd = 722921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double ToDouble(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 722927, RefRangeEnd = 722929, XrefRangeStart = 722922, XrefRangeEnd = 722927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722933, RefRangeEnd = 722934, XrefRangeStart = 722929, XrefRangeEnd = 722933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722934, XrefRangeEnd = 722938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722942, RefRangeEnd = 722943, XrefRangeStart = 722938, XrefRangeEnd = 722942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722947, RefRangeEnd = 722948, XrefRangeStart = 722943, XrefRangeEnd = 722947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722952, RefRangeEnd = 722953, XrefRangeStart = 722948, XrefRangeEnd = 722952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722957, RefRangeEnd = 722958, XrefRangeStart = 722953, XrefRangeEnd = 722957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722962, RefRangeEnd = 722963, XrefRangeStart = 722958, XrefRangeEnd = 722962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722967, RefRangeEnd = 722968, XrefRangeStart = 722963, XrefRangeEnd = 722967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722972, RefRangeEnd = 722973, XrefRangeStart = 722968, XrefRangeEnd = 722972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722977, RefRangeEnd = 722978, XrefRangeStart = 722973, XrefRangeEnd = 722977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 722986, RefRangeEnd = 722987, XrefRangeStart = 722978, XrefRangeEnd = 722986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722987, XrefRangeEnd = 722991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723004, RefRangeEnd = 723005, XrefRangeStart = 722991, XrefRangeEnd = 723004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ToDateTime(string value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 723015, RefRangeEnd = 723057, XrefRangeStart = 723005, XrefRangeEnd = 723015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723064, RefRangeEnd = 723065, XrefRangeStart = 723057, XrefRangeEnd = 723064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(Object value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723070, RefRangeEnd = 723071, XrefRangeStart = 723065, XrefRangeEnd = 723070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(char value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723076, RefRangeEnd = 723077, XrefRangeStart = 723071, XrefRangeEnd = 723076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723082, RefRangeEnd = 723084, XrefRangeStart = 723077, XrefRangeEnd = 723082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723085, RefRangeEnd = 723086, XrefRangeStart = 723084, XrefRangeEnd = 723085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(int value, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 723089, RefRangeEnd = 723097, XrefRangeStart = 723086, XrefRangeEnd = 723089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(string value, int fromBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723098, RefRangeEnd = 723099, XrefRangeStart = 723097, XrefRangeEnd = 723098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(byte value, int toBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 723100, RefRangeEnd = 723104, XrefRangeStart = 723099, XrefRangeEnd = 723100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(short value, int toBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723105, RefRangeEnd = 723106, XrefRangeStart = 723104, XrefRangeEnd = 723105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(int value, int toBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 723107, RefRangeEnd = 723117, XrefRangeStart = 723106, XrefRangeEnd = 723107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(long value, int toBase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toBase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 723122, RefRangeEnd = 723159, XrefRangeStart = 723117, XrefRangeEnd = 723122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 723163, RefRangeEnd = 723166, XrefRangeStart = 723159, XrefRangeEnd = 723163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723172, RefRangeEnd = 723173, XrefRangeStart = 723166, XrefRangeEnd = 723172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length, Base64FormattingOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(Base64FormattingOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723186, RefRangeEnd = 723188, XrefRangeStart = 723173, XrefRangeEnd = 723186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bytes));
		*(Base64FormattingOptions**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723192, RefRangeEnd = 723194, XrefRangeStart = 723188, XrefRangeEnd = 723192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetIn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outArray);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetOut;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723201, RefRangeEnd = 723202, XrefRangeStart = 723194, XrefRangeEnd = 723201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut, Base64FormattingOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetIn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outArray);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetOut;
		*(Base64FormattingOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723208, RefRangeEnd = 723210, XrefRangeStart = 723202, XrefRangeEnd = 723208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)outChars;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = inData;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &insertLineBreaks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 723210, RefRangeEnd = 723212, XrefRangeStart = 723210, XrefRangeEnd = 723210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputLength);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &insertLineBreaks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 723223, RefRangeEnd = 723258, XrefRangeStart = 723212, XrefRangeEnd = 723223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> FromBase64String(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723300, RefRangeEnd = 723301, XrefRangeStart = 723258, XrefRangeEnd = 723300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)chars));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bytes));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bytesWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723301, XrefRangeEnd = 723306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)chars));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tempBuffer));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref consumed);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsSpace(this char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 723320, RefRangeEnd = 723321, XrefRangeStart = 723306, XrefRangeEnd = 723320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> FromBase64CharPtr(char* inputPtr, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)inputPtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723321, XrefRangeEnd = 723323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)inputPtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Convert(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
