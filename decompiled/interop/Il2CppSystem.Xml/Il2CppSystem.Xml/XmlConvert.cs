using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Xml;

public class XmlConvert : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xmlCharType;

	private static readonly System.IntPtr NativeFieldInfoPtr_crt;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_EncodedCharLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_EncodeCharPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_DecodeCharPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_allDateTimeFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_WhitespaceChars;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0;

	public unsafe static XmlCharType xmlCharType
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xmlCharType, (void*)intPtr);
			return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xmlCharType, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static Il2CppStructArray<char> crt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_crt, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_crt, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int c_EncodedCharLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&value));
		}
	}

	public unsafe static Regex c_EncodeCharPattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_EncodeCharPattern, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_EncodeCharPattern, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Regex c_DecodeCharPattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_DecodeCharPattern, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_DecodeCharPattern, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray s_allDateTimeFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_allDateTimeFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_allDateTimeFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> WhitespaceChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WhitespaceChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WhitespaceChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray AllDateTimeFormats
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911871, XrefRangeEnd = 911883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	static XmlConvert()
	{
		Il2CppClassPointerStore<XmlConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlConvert");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr);
		NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "xmlCharType");
		NativeFieldInfoPtr_crt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "crt");
		NativeFieldInfoPtr_c_EncodedCharLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodedCharLength");
		NativeFieldInfoPtr_c_EncodeCharPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodeCharPattern");
		NativeFieldInfoPtr_c_DecodeCharPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_DecodeCharPattern");
		NativeFieldInfoPtr_s_allDateTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "s_allDateTimeFormats");
		NativeFieldInfoPtr_WhitespaceChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "WhitespaceChars");
		NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664962);
		NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664963);
		NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664964);
		NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664966);
		NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_ToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_ToString_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665036);
		NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665037);
		NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665038);
		NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665039);
		NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665040);
		NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665041);
		NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665043);
		NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665044);
		NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665046);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911139, RefRangeEnd = 911140, XrefRangeStart = 911135, XrefRangeEnd = 911139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 911144, RefRangeEnd = 911152, XrefRangeStart = 911140, XrefRangeEnd = 911144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeLocalName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911244, RefRangeEnd = 911245, XrefRangeStart = 911152, XrefRangeEnd = 911244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecodeName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 911358, RefRangeEnd = 911362, XrefRangeStart = 911245, XrefRangeEnd = 911358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncodeName(string name, bool first, bool local)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &first;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &local;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int FromHex(char digit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&digit);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911362, XrefRangeEnd = 911373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> FromBinHexString(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 911381, RefRangeEnd = 911383, XrefRangeStart = 911373, XrefRangeEnd = 911381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> FromBinHexString(string s, bool allowOddCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOddCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911390, RefRangeEnd = 911391, XrefRangeStart = 911383, XrefRangeEnd = 911390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToBinHexString(Il2CppStructArray<byte> inArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911395, RefRangeEnd = 911396, XrefRangeStart = 911391, XrefRangeEnd = 911395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string VerifyName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911404, RefRangeEnd = 911405, XrefRangeStart = 911396, XrefRangeEnd = 911404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryVerifyName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 911412, RefRangeEnd = 911416, XrefRangeStart = 911405, XrefRangeEnd = 911412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string VerifyNCName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911416, XrefRangeEnd = 911420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string VerifyNCName(string name, ExceptionType exceptionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(ExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911427, RefRangeEnd = 911428, XrefRangeStart = 911420, XrefRangeEnd = 911427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryVerifyNCName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 911438, RefRangeEnd = 911440, XrefRangeStart = 911428, XrefRangeEnd = 911438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string VerifyTOKEN(string token)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911456, RefRangeEnd = 911457, XrefRangeStart = 911440, XrefRangeEnd = 911456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryVerifyTOKEN(string token)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911470, RefRangeEnd = 911471, XrefRangeStart = 911457, XrefRangeEnd = 911470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryVerifyNMTOKEN(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911478, RefRangeEnd = 911479, XrefRangeStart = 911471, XrefRangeEnd = 911478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryVerifyNormalizedString(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 911483, RefRangeEnd = 911485, XrefRangeStart = 911479, XrefRangeEnd = 911483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 911490, RefRangeEnd = 911492, XrefRangeStart = 911485, XrefRangeEnd = 911490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911492, XrefRangeEnd = 911494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911494, XrefRangeEnd = 911496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 911498, RefRangeEnd = 911507, XrefRangeStart = 911496, XrefRangeEnd = 911498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911509, RefRangeEnd = 911512, XrefRangeStart = 911507, XrefRangeEnd = 911509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911512, XrefRangeEnd = 911514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911514, XrefRangeEnd = 911516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911516, XrefRangeEnd = 911518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911518, XrefRangeEnd = 911520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911526, RefRangeEnd = 911529, XrefRangeStart = 911520, XrefRangeEnd = 911526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911535, RefRangeEnd = 911538, XrefRangeStart = 911529, XrefRangeEnd = 911535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911538, XrefRangeEnd = 911558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(XmlDateTimeSerializationMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTimeOption;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911558, XrefRangeEnd = 911559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(Guid value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 911579, RefRangeEnd = 911585, XrefRangeStart = 911559, XrefRangeEnd = 911579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToBoolean(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911622, RefRangeEnd = 911623, XrefRangeStart = 911585, XrefRangeEnd = 911622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToBoolean(string s, out bool result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911637, RefRangeEnd = 911638, XrefRangeStart = 911623, XrefRangeEnd = 911637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToChar(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911645, RefRangeEnd = 911646, XrefRangeStart = 911638, XrefRangeEnd = 911645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToChar(string s, out char result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 911651, RefRangeEnd = 911658, XrefRangeStart = 911646, XrefRangeEnd = 911651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToDecimal(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 911667, RefRangeEnd = 911669, XrefRangeStart = 911658, XrefRangeEnd = 911667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToDecimal(string s, out Decimal result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911674, RefRangeEnd = 911677, XrefRangeStart = 911669, XrefRangeEnd = 911674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ToInteger(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911686, RefRangeEnd = 911687, XrefRangeStart = 911677, XrefRangeEnd = 911686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToInteger(string s, out Decimal result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911687, XrefRangeEnd = 911689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911695, RefRangeEnd = 911696, XrefRangeStart = 911689, XrefRangeEnd = 911695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToSByte(string s, out sbyte result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911696, XrefRangeEnd = 911698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911704, RefRangeEnd = 911705, XrefRangeStart = 911698, XrefRangeEnd = 911704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToInt16(string s, out short result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 911707, RefRangeEnd = 911714, XrefRangeStart = 911705, XrefRangeEnd = 911707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911720, RefRangeEnd = 911721, XrefRangeStart = 911714, XrefRangeEnd = 911720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToInt32(string s, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 911723, RefRangeEnd = 911728, XrefRangeStart = 911721, XrefRangeEnd = 911723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911734, RefRangeEnd = 911735, XrefRangeStart = 911728, XrefRangeEnd = 911734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToInt64(string s, out long result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911735, XrefRangeEnd = 911737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911743, RefRangeEnd = 911744, XrefRangeStart = 911737, XrefRangeEnd = 911743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToByte(string s, out byte result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911744, XrefRangeEnd = 911746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911752, RefRangeEnd = 911753, XrefRangeStart = 911746, XrefRangeEnd = 911752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToUInt16(string s, out ushort result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911753, XrefRangeEnd = 911755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911761, RefRangeEnd = 911762, XrefRangeStart = 911755, XrefRangeEnd = 911761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToUInt32(string s, out uint result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911762, XrefRangeEnd = 911764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911770, RefRangeEnd = 911771, XrefRangeStart = 911764, XrefRangeEnd = 911770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToUInt64(string s, out ulong result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 911788, RefRangeEnd = 911792, XrefRangeStart = 911771, XrefRangeEnd = 911788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911813, RefRangeEnd = 911814, XrefRangeStart = 911792, XrefRangeEnd = 911813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToSingle(string s, out float result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 911831, RefRangeEnd = 911836, XrefRangeStart = 911814, XrefRangeEnd = 911831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911857, RefRangeEnd = 911858, XrefRangeStart = 911836, XrefRangeEnd = 911857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToDouble(string s, out double result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911864, RefRangeEnd = 911867, XrefRangeStart = 911858, XrefRangeEnd = 911864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToXPathDouble(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 911870, RefRangeEnd = 911871, XrefRangeStart = 911867, XrefRangeEnd = 911870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToTimeSpan(string s, out TimeSpan result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 911969, RefRangeEnd = 911972, XrefRangeStart = 911883, XrefRangeEnd = 911969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateAllDateTimeFormats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911972, XrefRangeEnd = 911995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ToDateTime(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911995, XrefRangeEnd = 912003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ToDateTime(string s, Il2CppStringArray formats)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912003, XrefRangeEnd = 912015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(XmlDateTimeSerializationMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTimeOption;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 912016, RefRangeEnd = 912017, XrefRangeStart = 912015, XrefRangeEnd = 912016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Guid ToGuid(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Guid*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 912041, RefRangeEnd = 912042, XrefRangeStart = 912017, XrefRangeEnd = 912041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToGuid(string s, out Guid result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 912046, RefRangeEnd = 912047, XrefRangeStart = 912042, XrefRangeEnd = 912046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime SwitchToLocalTime(DateTime value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 912054, RefRangeEnd = 912055, XrefRangeStart = 912047, XrefRangeEnd = 912054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime SwitchToUtcTime(DateTime value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 912070, RefRangeEnd = 912083, XrefRangeStart = 912055, XrefRangeEnd = 912070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Uri ToUri(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 912113, RefRangeEnd = 912115, XrefRangeStart = 912083, XrefRangeEnd = 912113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryToUri(string s, out Uri result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		result = ((num3 == 0) ? null : new Uri(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 912116, RefRangeEnd = 912132, XrefRangeStart = 912115, XrefRangeEnd = 912116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StrEqual(Il2CppStructArray<char> chars, int strPos1, int strLen1, string str2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strPos1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strLen1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 912138, RefRangeEnd = 912141, XrefRangeStart = 912132, XrefRangeEnd = 912138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TrimString(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 912147, RefRangeEnd = 912154, XrefRangeStart = 912141, XrefRangeEnd = 912147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray SplitString(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912154, XrefRangeEnd = 912157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNegativeZero(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long DoubleToInt64Bits(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912157, XrefRangeEnd = 912168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg);
		*(ExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNo;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linePos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 912178, RefRangeEnd = 912181, XrefRangeStart = 912168, XrefRangeEnd = 912178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType, int lineNo, int linePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(ExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNo;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linePos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 912213, RefRangeEnd = 912214, XrefRangeStart = 912181, XrefRangeEnd = 912213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&low);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912214, XrefRangeEnd = 912238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&low);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(ExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912238, XrefRangeEnd = 912259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&low);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(ExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNo;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linePos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912259, XrefRangeEnd = 912266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912266, XrefRangeEnd = 912270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hi);
		*(ExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 912301, RefRangeEnd = 912303, XrefRangeStart = 912270, XrefRangeEnd = 912301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&hi);
		*(ExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNo;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &linePos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912303, XrefRangeEnd = 912315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(ExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912315, XrefRangeEnd = 912321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(argumentName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr2) : null;
	}

	public XmlConvert(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
