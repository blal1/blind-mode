using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization;

[System.Serializable]
public sealed class DateTimeFormatInfo : Object
{
	public class TokenHashValue : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_tokenString;

		private static readonly System.IntPtr NativeFieldInfoPtr_tokenType;

		private static readonly System.IntPtr NativeFieldInfoPtr_tokenValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0;

		public unsafe string tokenString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenString)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe TokenType tokenType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenType);
				return *(TokenType*)num;
			}
			set
			{
				*(TokenType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenType)) = value;
			}
		}

		public unsafe int tokenValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenValue);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tokenValue)) = value;
			}
		}

		static TokenHashValue()
		{
			Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TokenHashValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr);
			NativeFieldInfoPtr_tokenString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenString");
			NativeFieldInfoPtr_tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenType");
			NativeFieldInfoPtr_tokenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenValue");
			NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, 100672777);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286867, RefRangeEnd = 286868, XrefRangeStart = 286867, XrefRangeEnd = 286868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
			*(TokenType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenType;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenValue;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TokenHashValue(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_invariantInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__cultureData;

	private static readonly System.IntPtr NativeFieldInfoPtr__name;

	private static readonly System.IntPtr NativeFieldInfoPtr__langName;

	private static readonly System.IntPtr NativeFieldInfoPtr__compareInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__cultureInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_amDesignator;

	private static readonly System.IntPtr NativeFieldInfoPtr_pmDesignator;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_generalShortTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_generalLongTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthDayPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateTimeOffsetPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_rfc1123Pattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortableDateTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_universalSortableDateTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_calendar;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstDayOfWeek;

	private static readonly System.IntPtr NativeFieldInfoPtr_calendarWeekRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_fullDateTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_abbreviatedDayNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_superShortDayNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_abbreviatedMonthNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_genitiveMonthNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_leapYearMonthNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_longDatePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortDatePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearMonthPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_longTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortTimePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_allYearMonthPatterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_allShortDatePatterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_allLongDatePatterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_allShortTimePatterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_allLongTimePatterns;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_eraNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_abbrevEraNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_abbrevEnglishEraNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_optionalCalendars;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr__isReadOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_formatFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_monthSpaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_RoundtripFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_RoundtripDateTimeUnfixed;

	private static readonly System.IntPtr NativeFieldInfoPtr__fullTimeSpanPositivePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr__fullTimeSpanNegativePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidDateTimeStyles;

	private static readonly System.IntPtr NativeFieldInfoPtr__dtfiTokenHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_HASH_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SECOND_PRIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_invariantDateSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_invariantTimeSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnorablePeriod;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnorableComma;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKYearSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKMonthSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKDaySuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanYearSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanMonthSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanDaySuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanHourSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanMinuteSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanSecondSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKHourSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChineseHourSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKMinuteSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_CJKSecondSuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_JapaneseEraStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalTimeMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_GMTName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZuluName;

	private static readonly System.IntPtr NativeFieldInfoPtr_KoreanLangName;

	private static readonly System.IntPtr NativeFieldInfoPtr_JapaneseLangName;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnglishLangName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_jajpDTFI;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_zhtwDTFI;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CultureName_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LanguageName_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEraName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0;

	public unsafe static DateTimeFormatInfo s_invariantInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invariantInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_invariantInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CultureData _cultureData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _langName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__langName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__langName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe CompareInfo _compareInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compareInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compareInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CultureInfo _cultureInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cultureInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string amDesignator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amDesignator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amDesignator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string pmDesignator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pmDesignator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pmDesignator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string dateSeparator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateSeparator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateSeparator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string generalShortTimePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalShortTimePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalShortTimePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string generalLongTimePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalLongTimePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalLongTimePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string timeSeparator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSeparator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSeparator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string monthDayPattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthDayPattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthDayPattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string dateTimeOffsetPattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTimeOffsetPattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTimeOffsetPattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string rfc1123Pattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rfc1123Pattern, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rfc1123Pattern, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string sortableDateTimePattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sortableDateTimePattern, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sortableDateTimePattern, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string universalSortableDateTimePattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_universalSortableDateTimePattern, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_universalSortableDateTimePattern, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Calendar calendar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int firstDayOfWeek
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDayOfWeek);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDayOfWeek)) = value;
		}
	}

	public unsafe int calendarWeekRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendarWeekRule);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendarWeekRule)) = value;
		}
	}

	public unsafe string fullDateTimePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullDateTimePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullDateTimePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray abbreviatedDayNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abbreviatedDayNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abbreviatedDayNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_superShortDayNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_superShortDayNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_superShortDayNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray dayNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray abbreviatedMonthNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abbreviatedMonthNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abbreviatedMonthNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray monthNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray genitiveMonthNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genitiveMonthNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genitiveMonthNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_genitiveAbbreviatedMonthNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray leapYearMonthNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapYearMonthNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapYearMonthNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string longDatePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longDatePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longDatePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string shortDatePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortDatePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortDatePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string yearMonthPattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearMonthPattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearMonthPattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string longTimePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longTimePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longTimePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string shortTimePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortTimePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortTimePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray allYearMonthPatterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allYearMonthPatterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allYearMonthPatterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray allShortDatePatterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allShortDatePatterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allShortDatePatterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray allLongDatePatterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLongDatePatterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLongDatePatterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray allShortTimePatterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allShortTimePatterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allShortTimePatterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray allLongTimePatterns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLongTimePatterns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLongTimePatterns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_eraNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_eraNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_eraNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_abbrevEraNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_abbrevEraNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_abbrevEraNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray m_abbrevEnglishEraNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_abbrevEnglishEraNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_abbrevEnglishEraNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<CalendarId> optionalCalendars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionalCalendars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionalCalendars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int DEFAULT_ALL_DATETIMES_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE, (void*)(&value));
		}
	}

	public unsafe bool _isReadOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isReadOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isReadOnly)) = value;
		}
	}

	public unsafe DateTimeFormatFlags formatFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_formatFlags);
			return *(DateTimeFormatFlags*)num;
		}
		set
		{
			*(DateTimeFormatFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_formatFlags)) = value;
		}
	}

	public unsafe static Il2CppStructArray<char> s_monthSpaces
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_monthSpaces, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_monthSpaces, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string RoundtripFormat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RoundtripFormat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RoundtripFormat, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string RoundtripDateTimeUnfixed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RoundtripDateTimeUnfixed, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RoundtripDateTimeUnfixed, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _fullTimeSpanPositivePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullTimeSpanPositivePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullTimeSpanPositivePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _fullTimeSpanNegativePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullTimeSpanNegativePattern);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullTimeSpanNegativePattern)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static DateTimeStyles InvalidDateTimeStyles
	{
		get
		{
			Unsafe.SkipInit(out DateTimeStyles result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidDateTimeStyles, (void*)(&value));
		}
	}

	public unsafe Il2CppReferenceArray<TokenHashValue> _dtfiTokenHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dtfiTokenHash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dtfiTokenHash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int TOKEN_HASH_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_HASH_SIZE, (void*)(&value));
		}
	}

	public unsafe static int SECOND_PRIME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SECOND_PRIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SECOND_PRIME, (void*)(&value));
		}
	}

	public unsafe static string dateSeparatorOrTimeZoneOffset
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string invariantDateSeparator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_invariantDateSeparator, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_invariantDateSeparator, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string invariantTimeSeparator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_invariantTimeSeparator, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_invariantTimeSeparator, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string IgnorablePeriod
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IgnorablePeriod, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IgnorablePeriod, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string IgnorableComma
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IgnorableComma, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IgnorableComma, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKYearSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKYearSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKYearSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKMonthSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKMonthSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKMonthSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKDaySuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKDaySuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKDaySuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanYearSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanYearSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanYearSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanMonthSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanMonthSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanMonthSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanDaySuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanDaySuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanDaySuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanHourSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanHourSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanHourSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanMinuteSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanMinuteSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanMinuteSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanSecondSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanSecondSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanSecondSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKHourSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKHourSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKHourSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ChineseHourSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChineseHourSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChineseHourSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKMinuteSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKMinuteSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKMinuteSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CJKSecondSuff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CJKSecondSuff, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CJKSecondSuff, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string JapaneseEraStart
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JapaneseEraStart, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JapaneseEraStart, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string LocalTimeMark
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LocalTimeMark, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LocalTimeMark, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string GMTName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GMTName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GMTName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ZuluName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZuluName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZuluName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KoreanLangName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KoreanLangName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KoreanLangName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string JapaneseLangName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JapaneseLangName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JapaneseLangName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string EnglishLangName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnglishLangName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnglishLangName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static DateTimeFormatInfo s_jajpDTFI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_jajpDTFI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_jajpDTFI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DateTimeFormatInfo s_zhtwDTFI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_zhtwDTFI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_zhtwDTFI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string CultureName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816063, XrefRangeEnd = 816064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CultureName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe CultureInfo Culture
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 816070, RefRangeEnd = 816074, XrefRangeStart = 816064, XrefRangeEnd = 816070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe string LanguageName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816075, RefRangeEnd = 816076, XrefRangeStart = 816074, XrefRangeEnd = 816075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LanguageName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static DateTimeFormatInfo InvariantInfo
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 816188, RefRangeEnd = 816203, XrefRangeStart = 816170, XrefRangeEnd = 816188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
	}

	public unsafe static DateTimeFormatInfo CurrentInfo
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816210, RefRangeEnd = 816212, XrefRangeStart = 816203, XrefRangeEnd = 816210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
		}
	}

	public unsafe string AMDesignator
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 816255, RefRangeEnd = 816270, XrefRangeStart = 816254, XrefRangeEnd = 816255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Calendar Calendar
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 816327, RefRangeEnd = 816334, XrefRangeStart = 816270, XrefRangeEnd = 816327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<CalendarId> OptionalCalendars
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816334, XrefRangeEnd = 816336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray EraNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816336, XrefRangeEnd = 816338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AbbreviatedEraNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816346, XrefRangeEnd = 816348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AbbreviatedEnglishEraNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816353, XrefRangeEnd = 816355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe string DateSeparator
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 816357, RefRangeEnd = 816361, XrefRangeStart = 816355, XrefRangeEnd = 816357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string FullDateTimePattern
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816361, XrefRangeEnd = 816368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string LongDatePattern
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816370, RefRangeEnd = 816371, XrefRangeStart = 816368, XrefRangeEnd = 816370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string LongTimePattern
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 816374, RefRangeEnd = 816379, XrefRangeStart = 816371, XrefRangeEnd = 816374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string MonthDayPattern
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 816381, RefRangeEnd = 816393, XrefRangeStart = 816379, XrefRangeEnd = 816381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string PMDesignator
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 816394, RefRangeEnd = 816408, XrefRangeStart = 816393, XrefRangeEnd = 816394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string RFC1123Pattern
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816408, XrefRangeEnd = 816410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string ShortDatePattern
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 816412, RefRangeEnd = 816423, XrefRangeStart = 816410, XrefRangeEnd = 816412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string ShortTimePattern
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 816426, RefRangeEnd = 816430, XrefRangeStart = 816423, XrefRangeEnd = 816426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string SortableDateTimePattern
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 816432, RefRangeEnd = 816435, XrefRangeStart = 816430, XrefRangeEnd = 816432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string GeneralShortTimePattern
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816442, RefRangeEnd = 816443, XrefRangeStart = 816435, XrefRangeEnd = 816442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string GeneralLongTimePattern
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816443, XrefRangeEnd = 816450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string DateTimeOffsetPattern
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816471, RefRangeEnd = 816472, XrefRangeStart = 816450, XrefRangeEnd = 816471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string TimeSeparator
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 816473, RefRangeEnd = 816476, XrefRangeStart = 816472, XrefRangeEnd = 816473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string UniversalSortableDateTimePattern
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816478, RefRangeEnd = 816479, XrefRangeStart = 816476, XrefRangeEnd = 816478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string YearMonthPattern
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 816481, RefRangeEnd = 816486, XrefRangeStart = 816479, XrefRangeEnd = 816481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppStringArray AbbreviatedDayNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816486, XrefRangeEnd = 816490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray DayNames
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816490, XrefRangeEnd = 816494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AbbreviatedMonthNames
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816498, RefRangeEnd = 816500, XrefRangeStart = 816494, XrefRangeEnd = 816498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray MonthNames
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816504, RefRangeEnd = 816506, XrefRangeStart = 816500, XrefRangeEnd = 816504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe bool HasSpacesInMonthNames
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816506, RefRangeEnd = 816508, XrefRangeStart = 816506, XrefRangeEnd = 816506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HasSpacesInDayNames
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816508, RefRangeEnd = 816510, XrefRangeStart = 816508, XrefRangeEnd = 816508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStringArray AllYearMonthPatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816607, XrefRangeEnd = 816616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AllShortDatePatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816616, XrefRangeEnd = 816625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AllShortTimePatterns
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816633, RefRangeEnd = 816634, XrefRangeStart = 816625, XrefRangeEnd = 816633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AllLongDatePatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816634, XrefRangeEnd = 816643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray AllLongTimePatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816643, XrefRangeEnd = 816651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray UnclonedYearMonthPatterns
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 816653, RefRangeEnd = 816656, XrefRangeStart = 816651, XrefRangeEnd = 816653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray UnclonedShortDatePatterns
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 816658, RefRangeEnd = 816664, XrefRangeStart = 816656, XrefRangeEnd = 816658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray UnclonedLongDatePatterns
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 816666, RefRangeEnd = 816670, XrefRangeStart = 816664, XrefRangeEnd = 816666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray UnclonedShortTimePatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816670, XrefRangeEnd = 816672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray UnclonedLongTimePatterns
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816672, XrefRangeEnd = 816674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe bool IsReadOnly
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816674, XrefRangeEnd = 816681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStringArray MonthGenitiveNames
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816686, RefRangeEnd = 816687, XrefRangeStart = 816681, XrefRangeEnd = 816686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe string FullTimeSpanPositivePattern
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 816698, RefRangeEnd = 816699, XrefRangeStart = 816687, XrefRangeEnd = 816698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string FullTimeSpanNegativePattern
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816699, XrefRangeEnd = 816704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe CompareInfo CompareInfo
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 816713, RefRangeEnd = 816717, XrefRangeStart = 816704, XrefRangeEnd = 816713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
		}
	}

	public unsafe DateTimeFormatFlags FormatFlags
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 816721, RefRangeEnd = 816731, XrefRangeStart = 816721, XrefRangeEnd = 816721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DateTimeFormatFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HasForceTwoDigitYears
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 816775, RefRangeEnd = 816777, XrefRangeStart = 816775, XrefRangeEnd = 816775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HasYearMonthAdjustment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DateTimeFormatInfo()
	{
		Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr);
		NativeFieldInfoPtr_s_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_invariantInfo");
		NativeFieldInfoPtr__cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_cultureData");
		NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_name");
		NativeFieldInfoPtr__langName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_langName");
		NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_compareInfo");
		NativeFieldInfoPtr__cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_cultureInfo");
		NativeFieldInfoPtr_amDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "amDesignator");
		NativeFieldInfoPtr_pmDesignator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "pmDesignator");
		NativeFieldInfoPtr_dateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparator");
		NativeFieldInfoPtr_generalShortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalShortTimePattern");
		NativeFieldInfoPtr_generalLongTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "generalLongTimePattern");
		NativeFieldInfoPtr_timeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "timeSeparator");
		NativeFieldInfoPtr_monthDayPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthDayPattern");
		NativeFieldInfoPtr_dateTimeOffsetPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateTimeOffsetPattern");
		NativeFieldInfoPtr_rfc1123Pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "rfc1123Pattern");
		NativeFieldInfoPtr_sortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "sortableDateTimePattern");
		NativeFieldInfoPtr_universalSortableDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "universalSortableDateTimePattern");
		NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendar");
		NativeFieldInfoPtr_firstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "firstDayOfWeek");
		NativeFieldInfoPtr_calendarWeekRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "calendarWeekRule");
		NativeFieldInfoPtr_fullDateTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "fullDateTimePattern");
		NativeFieldInfoPtr_abbreviatedDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedDayNames");
		NativeFieldInfoPtr_m_superShortDayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_superShortDayNames");
		NativeFieldInfoPtr_dayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dayNames");
		NativeFieldInfoPtr_abbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "abbreviatedMonthNames");
		NativeFieldInfoPtr_monthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "monthNames");
		NativeFieldInfoPtr_genitiveMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "genitiveMonthNames");
		NativeFieldInfoPtr_m_genitiveAbbreviatedMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_genitiveAbbreviatedMonthNames");
		NativeFieldInfoPtr_leapYearMonthNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "leapYearMonthNames");
		NativeFieldInfoPtr_longDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longDatePattern");
		NativeFieldInfoPtr_shortDatePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortDatePattern");
		NativeFieldInfoPtr_yearMonthPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "yearMonthPattern");
		NativeFieldInfoPtr_longTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "longTimePattern");
		NativeFieldInfoPtr_shortTimePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "shortTimePattern");
		NativeFieldInfoPtr_allYearMonthPatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allYearMonthPatterns");
		NativeFieldInfoPtr_allShortDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortDatePatterns");
		NativeFieldInfoPtr_allLongDatePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongDatePatterns");
		NativeFieldInfoPtr_allShortTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allShortTimePatterns");
		NativeFieldInfoPtr_allLongTimePatterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "allLongTimePatterns");
		NativeFieldInfoPtr_m_eraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_eraNames");
		NativeFieldInfoPtr_m_abbrevEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEraNames");
		NativeFieldInfoPtr_m_abbrevEnglishEraNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "m_abbrevEnglishEraNames");
		NativeFieldInfoPtr_optionalCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "optionalCalendars");
		NativeFieldInfoPtr_DEFAULT_ALL_DATETIMES_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "DEFAULT_ALL_DATETIMES_SIZE");
		NativeFieldInfoPtr__isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_isReadOnly");
		NativeFieldInfoPtr_formatFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "formatFlags");
		NativeFieldInfoPtr_s_monthSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_monthSpaces");
		NativeFieldInfoPtr_RoundtripFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "RoundtripFormat");
		NativeFieldInfoPtr_RoundtripDateTimeUnfixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "RoundtripDateTimeUnfixed");
		NativeFieldInfoPtr__fullTimeSpanPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_fullTimeSpanPositivePattern");
		NativeFieldInfoPtr__fullTimeSpanNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_fullTimeSpanNegativePattern");
		NativeFieldInfoPtr_InvalidDateTimeStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "InvalidDateTimeStyles");
		NativeFieldInfoPtr__dtfiTokenHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "_dtfiTokenHash");
		NativeFieldInfoPtr_TOKEN_HASH_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "TOKEN_HASH_SIZE");
		NativeFieldInfoPtr_SECOND_PRIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "SECOND_PRIME");
		NativeFieldInfoPtr_dateSeparatorOrTimeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "dateSeparatorOrTimeZoneOffset");
		NativeFieldInfoPtr_invariantDateSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantDateSeparator");
		NativeFieldInfoPtr_invariantTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "invariantTimeSeparator");
		NativeFieldInfoPtr_IgnorablePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorablePeriod");
		NativeFieldInfoPtr_IgnorableComma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "IgnorableComma");
		NativeFieldInfoPtr_CJKYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKYearSuff");
		NativeFieldInfoPtr_CJKMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMonthSuff");
		NativeFieldInfoPtr_CJKDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKDaySuff");
		NativeFieldInfoPtr_KoreanYearSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanYearSuff");
		NativeFieldInfoPtr_KoreanMonthSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMonthSuff");
		NativeFieldInfoPtr_KoreanDaySuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanDaySuff");
		NativeFieldInfoPtr_KoreanHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanHourSuff");
		NativeFieldInfoPtr_KoreanMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanMinuteSuff");
		NativeFieldInfoPtr_KoreanSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanSecondSuff");
		NativeFieldInfoPtr_CJKHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKHourSuff");
		NativeFieldInfoPtr_ChineseHourSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ChineseHourSuff");
		NativeFieldInfoPtr_CJKMinuteSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKMinuteSuff");
		NativeFieldInfoPtr_CJKSecondSuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "CJKSecondSuff");
		NativeFieldInfoPtr_JapaneseEraStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseEraStart");
		NativeFieldInfoPtr_LocalTimeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "LocalTimeMark");
		NativeFieldInfoPtr_GMTName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "GMTName");
		NativeFieldInfoPtr_ZuluName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "ZuluName");
		NativeFieldInfoPtr_KoreanLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "KoreanLangName");
		NativeFieldInfoPtr_JapaneseLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "JapaneseLangName");
		NativeFieldInfoPtr_EnglishLangName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "EnglishLangName");
		NativeFieldInfoPtr_s_jajpDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_jajpDTFI");
		NativeFieldInfoPtr_s_zhtwDTFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, "s_zhtwDTFI");
		NativeMethodInfoPtr_get_CultureName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672681);
		NativeMethodInfoPtr_get_Culture_Private_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672682);
		NativeMethodInfoPtr_get_LanguageName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672683);
		NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672684);
		NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672685);
		NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672686);
		NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672687);
		NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672688);
		NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672689);
		NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672690);
		NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672691);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672692);
		NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672693);
		NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672694);
		NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672695);
		NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672696);
		NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672697);
		NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672698);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672699);
		NativeMethodInfoPtr_get_AMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672700);
		NativeMethodInfoPtr_get_Calendar_Public_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672701);
		NativeMethodInfoPtr_set_Calendar_Public_set_Void_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672702);
		NativeMethodInfoPtr_get_OptionalCalendars_Private_get_Il2CppStructArray_1_CalendarId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672703);
		NativeMethodInfoPtr_get_EraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672704);
		NativeMethodInfoPtr_GetEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672705);
		NativeMethodInfoPtr_get_AbbreviatedEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672706);
		NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672707);
		NativeMethodInfoPtr_get_AbbreviatedEnglishEraNames_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672708);
		NativeMethodInfoPtr_get_DateSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672709);
		NativeMethodInfoPtr_get_FullDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672710);
		NativeMethodInfoPtr_get_LongDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672711);
		NativeMethodInfoPtr_get_LongTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672712);
		NativeMethodInfoPtr_get_MonthDayPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672713);
		NativeMethodInfoPtr_get_PMDesignator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672714);
		NativeMethodInfoPtr_get_RFC1123Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672715);
		NativeMethodInfoPtr_get_ShortDatePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672716);
		NativeMethodInfoPtr_get_ShortTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672717);
		NativeMethodInfoPtr_get_SortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672718);
		NativeMethodInfoPtr_get_GeneralShortTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672719);
		NativeMethodInfoPtr_get_GeneralLongTimePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672720);
		NativeMethodInfoPtr_get_DateTimeOffsetPattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672721);
		NativeMethodInfoPtr_get_TimeSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672722);
		NativeMethodInfoPtr_get_UniversalSortableDateTimePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672723);
		NativeMethodInfoPtr_get_YearMonthPattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672724);
		NativeMethodInfoPtr_get_AbbreviatedDayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672725);
		NativeMethodInfoPtr_get_DayNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672726);
		NativeMethodInfoPtr_get_AbbreviatedMonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672727);
		NativeMethodInfoPtr_get_MonthNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672728);
		NativeMethodInfoPtr_get_HasSpacesInMonthNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672729);
		NativeMethodInfoPtr_get_HasSpacesInDayNames_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672730);
		NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672731);
		NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672732);
		NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672733);
		NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672734);
		NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672735);
		NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672736);
		NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672737);
		NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672738);
		NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672739);
		NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672740);
		NativeMethodInfoPtr_get_AllYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672741);
		NativeMethodInfoPtr_get_AllShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672742);
		NativeMethodInfoPtr_get_AllShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672743);
		NativeMethodInfoPtr_get_AllLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672744);
		NativeMethodInfoPtr_get_AllLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672745);
		NativeMethodInfoPtr_get_UnclonedYearMonthPatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672746);
		NativeMethodInfoPtr_get_UnclonedShortDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672747);
		NativeMethodInfoPtr_get_UnclonedLongDatePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672748);
		NativeMethodInfoPtr_get_UnclonedShortTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672749);
		NativeMethodInfoPtr_get_UnclonedLongTimePatterns_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672750);
		NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672751);
		NativeMethodInfoPtr_get_MonthGenitiveNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672752);
		NativeMethodInfoPtr_get_FullTimeSpanPositivePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672753);
		NativeMethodInfoPtr_get_FullTimeSpanNegativePattern_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672754);
		NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672755);
		NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672756);
		NativeMethodInfoPtr_get_FormatFlags_Internal_get_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672757);
		NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672758);
		NativeMethodInfoPtr_get_HasForceTwoDigitYears_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672759);
		NativeMethodInfoPtr_get_HasYearMonthAdjustment_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672760);
		NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672761);
		NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672762);
		NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672763);
		NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672764);
		NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672765);
		NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672766);
		NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672767);
		NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672768);
		NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672769);
		NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672770);
		NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672771);
		NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672772);
		NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672773);
		NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672774);
		NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr, 100672775);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816076, XrefRangeEnd = 816077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816079, RefRangeEnd = 816083, XrefRangeStart = 816077, XrefRangeEnd = 816079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetAbbreviatedDayOfWeekNamesCore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetAbbreviatedDayOfWeekNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816083, XrefRangeEnd = 816084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetDayOfWeekNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetDayOfWeekNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816086, RefRangeEnd = 816090, XrefRangeStart = 816084, XrefRangeEnd = 816086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetDayOfWeekNamesCore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetDayOfWeekNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816090, XrefRangeEnd = 816091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetAbbreviatedMonthNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetAbbreviatedMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816093, RefRangeEnd = 816097, XrefRangeStart = 816091, XrefRangeEnd = 816093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetAbbreviatedMonthNamesCore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetAbbreviatedMonthNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816097, XrefRangeEnd = 816098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetMonthNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetMonthNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816100, RefRangeEnd = 816104, XrefRangeStart = 816098, XrefRangeEnd = 816100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetMonthNamesCore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetMonthNamesCore_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 816148, RefRangeEnd = 816150, XrefRangeStart = 816104, XrefRangeEnd = 816148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTimeFormatInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 816153, RefRangeEnd = 816154, XrefRangeStart = 816150, XrefRangeEnd = 816153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_CultureData_Calendar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816154, XrefRangeEnd = 816170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeOverridableProperties(CultureData cultureData, int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cultureData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &calendarId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeOverridableProperties_Private_Void_CultureData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 816227, RefRangeEnd = 816236, XrefRangeStart = 816212, XrefRangeEnd = 816227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTimeFormatInfo GetInstance(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstance_Public_Static_DateTimeFormatInfo_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816236, XrefRangeEnd = 816242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object GetFormat(Type formatType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816250, RefRangeEnd = 816254, XrefRangeStart = 816242, XrefRangeEnd = 816250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 816340, RefRangeEnd = 816346, XrefRangeStart = 816338, XrefRangeEnd = 816340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEraName(int era)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&era);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 816350, RefRangeEnd = 816353, XrefRangeStart = 816348, XrefRangeEnd = 816350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAbbreviatedEraName(int era)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&era);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbbreviatedEraName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 816518, RefRangeEnd = 816520, XrefRangeStart = 816510, XrefRangeEnd = 816518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&month);
		*(MonthNameStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &abbreviated;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetMonthName_Internal_String_Int32_MonthNameStyles_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 816522, RefRangeEnd = 816523, XrefRangeStart = 816520, XrefRangeEnd = 816522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetGenitiveMonthNames(bool abbreviated)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&abbreviated);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetGenitiveMonthNames_Private_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 816525, RefRangeEnd = 816527, XrefRangeStart = 816523, XrefRangeEnd = 816525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray internalGetLeapYearMonthNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetLeapYearMonthNames_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 816528, RefRangeEnd = 816534, XrefRangeStart = 816527, XrefRangeEnd = 816528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAbbreviatedDayName(DayOfWeek dayofweek)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dayofweek);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbbreviatedDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816534, XrefRangeEnd = 816541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetCombinedPatterns(Il2CppStringArray patterns1, Il2CppStringArray patterns2, string connectString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)patterns1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)patterns2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(connectString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCombinedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 816558, RefRangeEnd = 816563, XrefRangeStart = 816541, XrefRangeEnd = 816558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetAllDateTimePatterns(char format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllDateTimePatterns_Public_Il2CppStringArray_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 816564, RefRangeEnd = 816569, XrefRangeStart = 816563, XrefRangeEnd = 816564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDayName(DayOfWeek dayofweek)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dayofweek);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayName_Public_String_DayOfWeek_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 816570, RefRangeEnd = 816578, XrefRangeStart = 816569, XrefRangeEnd = 816570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAbbreviatedMonthName(int month)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&month);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbbreviatedMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 816579, RefRangeEnd = 816589, XrefRangeStart = 816578, XrefRangeEnd = 816579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMonthName(int month)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&month);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonthName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 816602, RefRangeEnd = 816607, XrefRangeStart = 816589, XrefRangeEnd = 816602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetMergedPatterns(Il2CppStringArray patterns, string defaultPattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)patterns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultPattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMergedPatterns_Private_Static_Il2CppStringArray_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816717, RefRangeEnd = 816721, XrefRangeStart = 816717, XrefRangeEnd = 816717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateStyles(DateTimeStyles style, string parameterName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateStyles_Internal_Static_Void_DateTimeStyles_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 816771, RefRangeEnd = 816775, XrefRangeStart = 816731, XrefRangeEnd = 816771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTimeFormatFlags InitializeFormatFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeFormatFlags_Private_DateTimeFormatFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTimeFormatFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 816779, RefRangeEnd = 816784, XrefRangeStart = 816777, XrefRangeEnd = 816779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref year);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref month);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parsedMonthName;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_YearMonthAdjustment_Internal_Boolean_byref_Int32_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816784, XrefRangeEnd = 816813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTimeFormatInfo GetJapaneseCalendarDTFI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJapaneseCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816813, XrefRangeEnd = 816842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTimeFormatInfo GetTaiwanCalendarDTFI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTaiwanCalendarDTFI_Internal_Static_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816842, XrefRangeEnd = 816843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTokenHashTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTokenHashTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816843, XrefRangeEnd = 816981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<TokenHashValue> CreateTokenHashTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTokenHashTable_Internal_Il2CppReferenceArray_1_TokenHashValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TokenHashValue>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817190, RefRangeEnd = 817191, XrefRangeStart = 816981, XrefRangeEnd = 817190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateSpecialTokenHashTable(Il2CppReferenceArray<TokenHashValue> temp, ref bool useDateSepAsIgnorableSymbol)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)temp);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref useDateSepAsIgnorableSymbol);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateSpecialTokenHashTable_Private_Void_Il2CppReferenceArray_1_TokenHashValue_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817191, XrefRangeEnd = 817211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsJapaneseCalendar(Calendar calendar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)calendar);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsJapaneseCalendar_Private_Static_Boolean_Calendar_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817211, XrefRangeEnd = 817216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMonthNames(Il2CppReferenceArray<TokenHashValue> temp, string monthPostfix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)temp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(monthPostfix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMonthNames_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817236, RefRangeEnd = 817237, XrefRangeStart = 817216, XrefRangeEnd = 817236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref badFormat);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseHebrewNumber_Private_Static_Boolean_byref___DTString_byref_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsHebrewChar(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHebrewChar_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817237, XrefRangeEnd = 817247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextCh;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllowedJapaneseTokenFollowedByNonSpaceLetter_Private_Boolean_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817266, RefRangeEnd = 817268, XrefRangeStart = 817247, XrefRangeEnd = 817266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&TokenMask);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tokenType);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref tokenValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tokenize_Internal_Boolean_TokenType_byref_TokenType_byref_Int32_byref___DTString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817268, XrefRangeEnd = 817280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertAtCurrentHashNode(Il2CppReferenceArray<TokenHashValue> hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		*(TokenType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenType;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenValue;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashcode;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashProbe;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertAtCurrentHashNode_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_Char_TokenType_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(58)]
	[CachedScanResults(RefRangeStart = 817296, RefRangeEnd = 817354, XrefRangeStart = 817280, XrefRangeEnd = 817296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertHash(Il2CppReferenceArray<TokenHashValue> hashTable, string str, TokenType tokenType, int tokenValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		*(TokenType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tokenValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertHash_Private_Void_Il2CppReferenceArray_1_TokenHashValue_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817354, XrefRangeEnd = 817356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(string2);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset2;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &length2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareStringIgnoreCaseOptimized_Private_Boolean_String_Int32_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DateTimeFormatInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
