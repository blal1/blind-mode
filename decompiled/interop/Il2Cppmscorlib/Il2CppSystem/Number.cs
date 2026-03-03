using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem;

public static class Number : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct NumberBuffer
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct DigitsAndNullTerminator
		{
			static DigitsAndNullTerminator()
			{
				Il2CppClassPointerStore<DigitsAndNullTerminator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "DigitsAndNullTerminator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitsAndNullTerminator>.NativeClassPtr);
			}

			public unsafe Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DigitsAndNullTerminator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_precision;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr__sign;

		private static readonly System.IntPtr NativeFieldInfoPtr__digits;

		private static readonly System.IntPtr NativeFieldInfoPtr__allDigits;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_sign_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0;

		[FieldOffset(0)]
		public int precision;

		[FieldOffset(4)]
		public int scale;

		[FieldOffset(8)]
		public int _sign;

		[FieldOffset(12)]
		public DigitsAndNullTerminator _digits;

		[FieldOffset(114)]
		public System.IntPtr _allDigits;

		public unsafe bool sign
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 734160, RefRangeEnd = 734177, XrefRangeStart = 734160, XrefRangeEnd = 734160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sign_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 734177, RefRangeEnd = 734191, XrefRangeStart = 734177, XrefRangeEnd = 734177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe char* digits
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 734191, RefRangeEnd = 734228, XrefRangeStart = 734191, XrefRangeEnd = 734191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (char*)result;
			}
		}

		static NumberBuffer()
		{
			Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number>.NativeClassPtr, "NumberBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "precision");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "scale");
			NativeFieldInfoPtr__sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "_sign");
			NativeFieldInfoPtr__digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "_digits");
			NativeFieldInfoPtr__allDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "_allDigits");
			NativeMethodInfoPtr_get_sign_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100665563);
			NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100665564);
			NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100665565);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_posCurrencyFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_negCurrencyFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_posPercentFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_negPercentFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_negNumberFormats;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_charToHexLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rgval64Power10;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rgexp64Power10;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rgval64Power10By16;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_rgexp64Power10By16;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0;

	public unsafe static Il2CppStringArray s_posCurrencyFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_posCurrencyFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_posCurrencyFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray s_negCurrencyFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negCurrencyFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negCurrencyFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray s_posPercentFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_posPercentFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_posPercentFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray s_negPercentFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negPercentFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negPercentFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray s_negNumberFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negNumberFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negNumberFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> s_charToHexLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_charToHexLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_charToHexLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ulong> s_rgval64Power10
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rgval64Power10, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rgval64Power10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> s_rgexp64Power10
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rgexp64Power10, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rgexp64Power10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ulong> s_rgval64Power10By16
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rgval64Power10By16, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rgval64Power10By16, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<short> s_rgexp64Power10By16
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_rgexp64Power10By16, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_rgexp64Power10By16, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Number()
	{
		Il2CppClassPointerStore<Number>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Number");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number>.NativeClassPtr);
		NativeFieldInfoPtr_s_posCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posCurrencyFormats");
		NativeFieldInfoPtr_s_negCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negCurrencyFormats");
		NativeFieldInfoPtr_s_posPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posPercentFormats");
		NativeFieldInfoPtr_s_negPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negPercentFormats");
		NativeFieldInfoPtr_s_negNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negNumberFormats");
		NativeFieldInfoPtr_s_charToHexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_charToHexLookup");
		NativeFieldInfoPtr_s_rgval64Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgval64Power10");
		NativeFieldInfoPtr_s_rgexp64Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgexp64Power10");
		NativeFieldInfoPtr_s_rgval64Power10By16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgval64Power10By16");
		NativeFieldInfoPtr_s_rgexp64Power10By16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgexp64Power10By16");
		NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665471);
		NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665472);
		NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665473);
		NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665474);
		NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665475);
		NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665476);
		NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665477);
		NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665478);
		NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665479);
		NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665480);
		NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665481);
		NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665482);
		NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665483);
		NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665484);
		NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665485);
		NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665486);
		NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665487);
		NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665488);
		NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665489);
		NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665490);
		NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665491);
		NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665492);
		NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665493);
		NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665494);
		NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665495);
		NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665496);
		NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665497);
		NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665498);
		NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665499);
		NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665500);
		NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665501);
		NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665502);
		NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665503);
		NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665504);
		NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665505);
		NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665506);
		NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665507);
		NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665508);
		NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665509);
		NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665510);
		NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665511);
		NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665512);
		NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665513);
		NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665514);
		NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665518);
		NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665519);
		NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665520);
		NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665521);
		NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665522);
		NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665523);
		NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665524);
		NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665525);
		NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665526);
		NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665527);
		NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665528);
		NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665529);
		NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665530);
		NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665531);
		NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665532);
		NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665533);
		NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665534);
		NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665535);
		NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665536);
		NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665537);
		NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665538);
		NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665539);
		NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665540);
		NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665541);
		NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665542);
		NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665543);
		NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665544);
		NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665545);
		NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665546);
		NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665547);
		NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665548);
		NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665549);
		NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665550);
		NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665551);
		NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665552);
		NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665553);
		NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665554);
		NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665555);
		NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665556);
		NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665557);
		NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665558);
		NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665559);
		NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665560);
		NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665561);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 734242, RefRangeEnd = 734245, XrefRangeStart = 734228, XrefRangeEnd = 734242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734259, RefRangeEnd = 734260, XrefRangeStart = 734245, XrefRangeEnd = 734259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734281, RefRangeEnd = 734283, XrefRangeStart = 734260, XrefRangeEnd = 734281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DecimalToNumber(Decimal value, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734293, RefRangeEnd = 734297, XrefRangeStart = 734283, XrefRangeEnd = 734293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatDouble(double value, string format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734312, RefRangeEnd = 734313, XrefRangeStart = 734297, XrefRangeEnd = 734312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734339, RefRangeEnd = 734341, XrefRangeStart = 734313, XrefRangeEnd = 734339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734351, RefRangeEnd = 734355, XrefRangeStart = 734341, XrefRangeEnd = 734351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSingle(float value, string format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734370, RefRangeEnd = 734371, XrefRangeStart = 734355, XrefRangeEnd = 734370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734397, RefRangeEnd = 734399, XrefRangeStart = 734371, XrefRangeEnd = 734397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734399, XrefRangeEnd = 734405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCopyTo(string source, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 734411, RefRangeEnd = 734423, XrefRangeStart = 734405, XrefRangeEnd = 734411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734429, RefRangeEnd = 734433, XrefRangeStart = 734423, XrefRangeEnd = 734429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 734462, RefRangeEnd = 734471, XrefRangeStart = 734433, XrefRangeEnd = 734462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734499, RefRangeEnd = 734503, XrefRangeStart = 734471, XrefRangeEnd = 734499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734509, RefRangeEnd = 734513, XrefRangeStart = 734503, XrefRangeEnd = 734509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734519, RefRangeEnd = 734520, XrefRangeStart = 734513, XrefRangeEnd = 734519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 734549, RefRangeEnd = 734553, XrefRangeStart = 734520, XrefRangeEnd = 734549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734581, RefRangeEnd = 734582, XrefRangeStart = 734553, XrefRangeEnd = 734581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734582, XrefRangeEnd = 734589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Int32ToNumber(int value, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734589, XrefRangeEnd = 734602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sNegative);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734602, XrefRangeEnd = 734617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sNegative);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734626, RefRangeEnd = 734627, XrefRangeStart = 734617, XrefRangeEnd = 734626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Int32ToHexStr(int value, char hexBase, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hexBase;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734639, RefRangeEnd = 734640, XrefRangeStart = 734627, XrefRangeEnd = 734639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hexBase;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734640, XrefRangeEnd = 734641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)buffer;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hexBase;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (char*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734641, XrefRangeEnd = 734648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UInt32ToNumber(uint value, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734648, XrefRangeEnd = 734649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)bufferEnd;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (char*)result;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734661, RefRangeEnd = 734663, XrefRangeStart = 734649, XrefRangeEnd = 734661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UInt32ToDecStr(uint value, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734678, RefRangeEnd = 734680, XrefRangeStart = 734663, XrefRangeEnd = 734678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734680, XrefRangeEnd = 734692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Int64ToNumber(long input, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&input);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734692, XrefRangeEnd = 734708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sNegative);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734708, XrefRangeEnd = 734726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sNegative);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734742, RefRangeEnd = 734743, XrefRangeStart = 734726, XrefRangeEnd = 734742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Int64ToHexStr(long value, char hexBase, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hexBase;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 734762, RefRangeEnd = 734763, XrefRangeStart = 734743, XrefRangeEnd = 734762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hexBase;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734774, RefRangeEnd = 734776, XrefRangeStart = 734763, XrefRangeEnd = 734774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UInt64ToNumber(ulong value, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734791, RefRangeEnd = 734793, XrefRangeStart = 734776, XrefRangeEnd = 734791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UInt64ToDecStr(ulong value, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 734811, RefRangeEnd = 734813, XrefRangeStart = 734793, XrefRangeEnd = 734811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 734818, RefRangeEnd = 734826, XrefRangeStart = 734813, XrefRangeEnd = 734818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref digits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 734852, RefRangeEnd = 734860, XrefRangeStart = 734826, XrefRangeEnd = 734852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDecimal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 734946, RefRangeEnd = 734954, XrefRangeStart = 734860, XrefRangeEnd = 734946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734954, XrefRangeEnd = 734973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 735007, RefRangeEnd = 735011, XrefRangeStart = 734973, XrefRangeEnd = 735007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Il2CppStructArray<int> groupDigits, string sDecimal, string sGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)groupDigits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sDecimal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735011, XrefRangeEnd = 735028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735028, XrefRangeEnd = 735044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735055, RefRangeEnd = 735058, XrefRangeStart = 735044, XrefRangeEnd = 735055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDigits;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &positiveSign;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735058, XrefRangeEnd = 735082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bSuppressScientific;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735101, RefRangeEnd = 735102, XrefRangeStart = 735082, XrefRangeEnd = 735101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735106, RefRangeEnd = 735109, XrefRangeStart = 735102, XrefRangeEnd = 735106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RoundNumber(ref NumberBuffer number, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735113, RefRangeEnd = 735115, XrefRangeStart = 735109, XrefRangeEnd = 735113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindSection(ReadOnlySpan<char> format, int section)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &section;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 298567, RefRangeEnd = 298596, XrefRangeStart = 298567, XrefRangeEnd = 298596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Low32(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint High32(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint Int64DivMod1E9(ref ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735117, RefRangeEnd = 735118, XrefRangeStart = 735115, XrefRangeEnd = 735117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberToInt32(ref NumberBuffer number, ref int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735120, RefRangeEnd = 735121, XrefRangeStart = 735118, XrefRangeEnd = 735120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberToInt64(ref NumberBuffer number, ref long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735123, RefRangeEnd = 735124, XrefRangeStart = 735121, XrefRangeEnd = 735123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberToUInt32(ref NumberBuffer number, ref uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735126, RefRangeEnd = 735127, XrefRangeStart = 735124, XrefRangeEnd = 735126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberToUInt64(ref NumberBuffer number, ref ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 735135, RefRangeEnd = 735143, XrefRangeStart = 735127, XrefRangeEnd = 735135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735151, RefRangeEnd = 735154, XrefRangeStart = 735143, XrefRangeEnd = 735151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 735161, RefRangeEnd = 735165, XrefRangeStart = 735154, XrefRangeEnd = 735161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735172, RefRangeEnd = 735174, XrefRangeStart = 735165, XrefRangeEnd = 735172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735265, RefRangeEnd = 735267, XrefRangeStart = 735174, XrefRangeEnd = 735265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		//IL_0086->IL0088: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<char*, object>(ref str));
		*ptr = (nint)(&intPtr);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = strEnd;
		*(NumberStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &parseDecimal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<char*, object>(ref str) = ((intPtr4 == (System.IntPtr)0) ? null : ((object)new char*(intPtr4)));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 735282, RefRangeEnd = 735290, XrefRangeStart = 735267, XrefRangeEnd = 735282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735340, RefRangeEnd = 735343, XrefRangeStart = 735290, XrefRangeEnd = 735340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735393, RefRangeEnd = 735395, XrefRangeStart = 735343, XrefRangeEnd = 735393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735410, RefRangeEnd = 735411, XrefRangeStart = 735395, XrefRangeEnd = 735410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 735427, RefRangeEnd = 735432, XrefRangeStart = 735411, XrefRangeEnd = 735427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735482, RefRangeEnd = 735483, XrefRangeStart = 735432, XrefRangeEnd = 735482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735499, RefRangeEnd = 735501, XrefRangeStart = 735483, XrefRangeEnd = 735499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735517, RefRangeEnd = 735519, XrefRangeStart = 735501, XrefRangeEnd = 735517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735569, RefRangeEnd = 735570, XrefRangeStart = 735519, XrefRangeEnd = 735569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735586, RefRangeEnd = 735588, XrefRangeStart = 735570, XrefRangeEnd = 735586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref failureIsOverflow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735594, RefRangeEnd = 735596, XrefRangeStart = 735588, XrefRangeEnd = 735594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735602, RefRangeEnd = 735604, XrefRangeStart = 735596, XrefRangeEnd = 735602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberBufferToDecimal(ref NumberBuffer number, ref Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735624, RefRangeEnd = 735627, XrefRangeStart = 735604, XrefRangeEnd = 735624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 735647, RefRangeEnd = 735650, XrefRangeStart = 735627, XrefRangeEnd = 735647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735658, RefRangeEnd = 735659, XrefRangeStart = 735650, XrefRangeEnd = 735658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out Decimal result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735670, RefRangeEnd = 735671, XrefRangeStart = 735659, XrefRangeEnd = 735670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 735682, RefRangeEnd = 735683, XrefRangeStart = 735671, XrefRangeEnd = 735682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 735694, RefRangeEnd = 735699, XrefRangeStart = 735683, XrefRangeEnd = 735694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &parseDecimal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 735711, RefRangeEnd = 735720, XrefRangeStart = 735699, XrefRangeEnd = 735711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &parseDecimal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 735721, RefRangeEnd = 735727, XrefRangeStart = 735720, XrefRangeEnd = 735721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TrailingZeros(ReadOnlySpan<char> value, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 735729, RefRangeEnd = 735731, XrefRangeStart = 735727, XrefRangeEnd = 735729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char* MatchChars(char* p, char* pEnd, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)p;
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = pEnd;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (char*)result;
	}

	[CallerCount(0)]
	public unsafe static bool IsWhite(int ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsDigit(int ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735731, XrefRangeEnd = 735742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&overflow);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overflowResourceKey);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735742, XrefRangeEnd = 735746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NumberBufferToDouble(ref NumberBuffer number, ref double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint DigitsToInt(char* p, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)p;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ulong Mul32x32To64(uint a, uint b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735746, XrefRangeEnd = 735749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong Mul64Lossy(ulong a, ulong b, ref int pexp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pexp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int abs(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 735789, RefRangeEnd = 735796, XrefRangeStart = 735749, XrefRangeEnd = 735789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double NumberToDouble(ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 735803, RefRangeEnd = 735809, XrefRangeStart = 735796, XrefRangeEnd = 735803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoubleToNumber(double value, int precision, ref NumberBuffer number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &precision;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Number(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
