using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem;

public static class DateTimeParse : Object
{
	public sealed class MatchNumberDelegate : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0;

		static MatchNumberDelegate()
		{
			Il2CppClassPointerStore<MatchNumberDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "MatchNumberDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchNumberDelegate>.NativeClassPtr, 100665068);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchNumberDelegate>.NativeClassPtr, 100665069);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725825, XrefRangeEnd = 725829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchNumberDelegate(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchNumberDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool Invoke(ref __DTString str, int digitLen, out int result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digitLen;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref___DTString_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public MatchNumberDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("mscorlib.dll", "", "DTT")]
	public enum DTT
	{
		End,
		NumEnd,
		NumAmpm,
		NumSpace,
		NumDatesep,
		NumTimesep,
		MonthEnd,
		MonthSpace,
		MonthDatesep,
		NumDatesuff,
		NumTimesuff,
		DayOfWeek,
		YearSpace,
		YearDateSep,
		YearEnd,
		TimeZone,
		Era,
		NumUTCTimeMark,
		Unk,
		NumLocalTimeMark,
		Max
	}

	[OriginalName("mscorlib.dll", "", "TM")]
	public enum TM
	{
		NotSet = -1,
		AM,
		PM
	}

	[OriginalName("mscorlib.dll", "", "DS")]
	public enum DS
	{
		BEGIN,
		N,
		NN,
		D_Nd,
		D_NN,
		D_NNd,
		D_M,
		D_MN,
		D_NM,
		D_MNd,
		D_NDS,
		D_Y,
		D_YN,
		D_YNd,
		D_YM,
		D_YMd,
		D_S,
		T_S,
		T_Nt,
		T_NNt,
		ERROR,
		DX_NN,
		DX_NNN,
		DX_MN,
		DX_NM,
		DX_MNN,
		DX_DS,
		DX_DSN,
		DX_NDS,
		DX_NNDS,
		DX_YNN,
		DX_YMN,
		DX_YN,
		DX_YM,
		TX_N,
		TX_NN,
		TX_NNN,
		TX_TS,
		DX_NNY
	}

	[System.Serializable]
	[ObfuscatedName("System.DateTimeParse+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__98_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0;

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

		public unsafe static Func<MatchNumberDelegate> __9__98_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__98_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<MatchNumberDelegate>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__98_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__98_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__98_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665071);
			NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665072);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725829, XrefRangeEnd = 725838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchNumberDelegate _DoStrictParse_b__98_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoStrictParse_b__98_0_Internal_MatchNumberDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchNumberDelegate>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_hebrewNumberParser;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateParsingStates;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0;

	public unsafe static MatchNumberDelegate m_hebrewNumberParser
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_hebrewNumberParser, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchNumberDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_hebrewNumberParser, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<DS>> dateParsingStates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dateParsingStates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<DS>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dateParsingStates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DateTimeParse()
	{
		Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeParse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr);
		NativeFieldInfoPtr_m_hebrewNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "m_hebrewNumberParser");
		NativeFieldInfoPtr_dateParsingStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, "dateParsingStates");
		NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665036);
		NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665037);
		NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665038);
		NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665039);
		NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665040);
		NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665041);
		NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665043);
		NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665044);
		NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665046);
		NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665047);
		NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665048);
		NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665049);
		NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665050);
		NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665051);
		NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665052);
		NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665054);
		NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665056);
		NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665057);
		NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665058);
		NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665062);
		NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665063);
		NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665064);
		NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665065);
		NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeParse>.NativeClassPtr, 100665066);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725848, RefRangeEnd = 725849, XrefRangeStart = 725838, XrefRangeEnd = 725848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseExact_Internal_Static_DateTime_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725868, RefRangeEnd = 725869, XrefRangeStart = 725849, XrefRangeEnd = 725868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725869, XrefRangeEnd = 725880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseExact_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725885, RefRangeEnd = 725886, XrefRangeStart = 725880, XrefRangeEnd = 725885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime ParseExactMultiple(ReadOnlySpan<char> s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseExactMultiple_Internal_Static_DateTime_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 725910, RefRangeEnd = 725911, XrefRangeStart = 725886, XrefRangeEnd = 725910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseExactMultiple(ReadOnlySpan<char> s, Il2CppStringArray formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseExactMultiple_Internal_Static_Boolean_ReadOnlySpan_1_Char_Il2CppStringArray_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725926, RefRangeEnd = 725928, XrefRangeStart = 725911, XrefRangeEnd = 725926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchWord(ref __DTString str, string target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchWord_Private_Static_Boolean_byref___DTString_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725928, XrefRangeEnd = 725939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTimeZoneName(ref __DTString str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeZoneName_Private_Static_Boolean_byref___DTString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 725939, RefRangeEnd = 725949, XrefRangeStart = 725939, XrefRangeEnd = 725939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDigit(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725957, RefRangeEnd = 725959, XrefRangeStart = 725949, XrefRangeEnd = 725957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseFraction(ref __DTString str, out double result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFraction_Private_Static_Boolean_byref___DTString_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 725992, RefRangeEnd = 725994, XrefRangeStart = 725959, XrefRangeEnd = 725992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeZone_Private_Static_Boolean_byref___DTString_byref_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726011, RefRangeEnd = 726012, XrefRangeStart = 725994, XrefRangeEnd = 726011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleTimeZone_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726038, RefRangeEnd = 726039, XrefRangeStart = 726012, XrefRangeEnd = 726038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&dps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dtok);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(System.IntPtr**)num = &intPtr;
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lex_Private_Static_Boolean_DS_byref___DTString_byref_DateTimeToken_byref_DateTimeRawInfo_byref_DateTimeResult_byref_DateTimeFormatInfo_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dtfi = ((intPtr4 == (System.IntPtr)0) ? null : new DateTimeFormatInfo(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726039, XrefRangeEnd = 726055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Calendar GetJapaneseCalendarDefaultInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJapaneseCalendarDefaultInstance_Private_Static_Calendar_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726055, XrefRangeEnd = 726071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Calendar GetTaiwanCalendarDefaultInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTaiwanCalendarDefaultInstance_Internal_Static_Calendar_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726080, RefRangeEnd = 726082, XrefRangeStart = 726071, XrefRangeEnd = 726080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool VerifyValidPunctuation(ref __DTString str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyValidPunctuation_Private_Static_Boolean_byref___DTString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 726091, RefRangeEnd = 726097, XrefRangeStart = 726082, XrefRangeEnd = 726091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(datePattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref order);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetYearMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726103, RefRangeEnd = 726105, XrefRangeStart = 726097, XrefRangeEnd = 726103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref order);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetYearMonthOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 726112, RefRangeEnd = 726118, XrefRangeStart = 726105, XrefRangeEnd = 726112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref order);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonthDayOrder_Private_Static_Boolean_String_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 726119, RefRangeEnd = 726133, XrefRangeStart = 726118, XrefRangeEnd = 726119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref adjustedYear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAdjustYear_Private_Static_Boolean_byref_DateTimeResult_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 726133, RefRangeEnd = 726148, XrefRangeStart = 726133, XrefRangeEnd = 726133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDateYMD_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726148, XrefRangeEnd = 726152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDateMDY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726152, XrefRangeEnd = 726156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDateDMY_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726156, XrefRangeEnd = 726160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &day;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDateYDM_Private_Static_Boolean_byref_DateTimeResult_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 726164, RefRangeEnd = 726169, XrefRangeStart = 726160, XrefRangeEnd = 726164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultYear_Private_Static_Void_byref_DateTimeResult_byref_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726169, XrefRangeEnd = 726189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726237, RefRangeEnd = 726238, XrefRangeStart = 726189, XrefRangeEnd = 726237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726270, RefRangeEnd = 726271, XrefRangeStart = 726238, XrefRangeEnd = 726270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726271, XrefRangeEnd = 726279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHebrewDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726311, RefRangeEnd = 726312, XrefRangeStart = 726279, XrefRangeEnd = 726311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfNM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726344, RefRangeEnd = 726346, XrefRangeStart = 726312, XrefRangeEnd = 726344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfMNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726346, XrefRangeEnd = 726361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfYNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726380, RefRangeEnd = 726382, XrefRangeStart = 726361, XrefRangeEnd = 726380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfNNY_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726387, RefRangeEnd = 726389, XrefRangeStart = 726382, XrefRangeEnd = 726387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfYMN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726389, XrefRangeEnd = 726394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfYN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726398, RefRangeEnd = 726400, XrefRangeStart = 726394, XrefRangeEnd = 726398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayOfYM_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726400, XrefRangeEnd = 726406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustTimeMark_Private_Static_Void_DateTimeFormatInfo_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool AdjustHour(ref int hour, TM timeMark)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hour);
		*(TM**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeMark;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustHour_Private_Static_Boolean_byref_Int32_TM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726407, RefRangeEnd = 726409, XrefRangeStart = 726406, XrefRangeEnd = 726407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeOfN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726411, RefRangeEnd = 726413, XrefRangeStart = 726409, XrefRangeEnd = 726411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeOfNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726416, RefRangeEnd = 726418, XrefRangeStart = 726413, XrefRangeEnd = 726416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeOfNNN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726418, XrefRangeEnd = 726419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateOfDSN_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726419, XrefRangeEnd = 726424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateOfNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726444, RefRangeEnd = 726445, XrefRangeStart = 726424, XrefRangeEnd = 726444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateOfNNDS_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dtok);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessDateTimeSuffix_Private_Static_Boolean_byref_DateTimeResult_byref_DateTimeRawInfo_byref_DateTimeToken_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726507, RefRangeEnd = 726508, XrefRangeStart = 726445, XrefRangeEnd = 726507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProcessHebrewTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&dps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessHebrewTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726609, RefRangeEnd = 726610, XrefRangeStart = 726508, XrefRangeEnd = 726609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProcessTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&dps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTerminalState_Internal_Static_Boolean_DS_byref___DTString_byref_DateTimeResult_byref_DateTimeStyles_byref_DateTimeRawInfo_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726615, RefRangeEnd = 726617, XrefRangeStart = 726610, XrefRangeEnd = 726615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Internal_Static_DateTime_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726627, RefRangeEnd = 726629, XrefRangeStart = 726617, XrefRangeEnd = 726627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726733, RefRangeEnd = 726735, XrefRangeStart = 726629, XrefRangeEnd = 726733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_ReadOnlySpan_1_Char_DateTimeFormatInfo_DateTimeStyles_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726770, RefRangeEnd = 726772, XrefRangeStart = 726735, XrefRangeEnd = 726770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bTimeOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineTimeZoneAdjustments_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726796, RefRangeEnd = 726797, XrefRangeStart = 726772, XrefRangeEnd = 726796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateTimeOffsetTimeZonePostProcessing_Private_Static_Boolean_byref___DTString_byref_DateTimeResult_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 726806, RefRangeEnd = 726808, XrefRangeStart = 726797, XrefRangeEnd = 726806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustTimeZoneToUniversal_Private_Static_Boolean_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726841, RefRangeEnd = 726842, XrefRangeStart = 726808, XrefRangeEnd = 726841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bTimeOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustTimeZoneToLocal_Private_Static_Boolean_byref_DateTimeResult_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726941, RefRangeEnd = 726942, XrefRangeStart = 726842, XrefRangeEnd = 726941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref raw);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseISO8601_Private_Static_Boolean_byref_DateTimeRawInfo_byref___DTString_DateTimeStyles_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726942, XrefRangeEnd = 726957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digitLen;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchHebrewDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726963, RefRangeEnd = 726964, XrefRangeStart = 726957, XrefRangeEnd = 726963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseDigits(ref __DTString str, int digitLen, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digitLen;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 726972, RefRangeEnd = 726979, XrefRangeStart = 726964, XrefRangeEnd = 726972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDigitLen;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDigitLen;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDigits_Internal_Static_Boolean_byref___DTString_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726979, XrefRangeEnd = 726992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDigitLen;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFractionExact_Private_Static_Boolean_byref___DTString_Int32_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 726998, RefRangeEnd = 726999, XrefRangeStart = 726992, XrefRangeEnd = 726998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseSign(ref __DTString str, ref bool result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSign_Private_Static_Boolean_byref___DTString_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726999, XrefRangeEnd = 727022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeZoneOffset_Private_Static_Boolean_byref___DTString_Int32_byref_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727022, XrefRangeEnd = 727046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchAbbreviatedMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727046, XrefRangeEnd = 727080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchMonthName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727080, XrefRangeEnd = 727093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchAbbreviatedDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727093, XrefRangeEnd = 727106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchDayName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727106, XrefRangeEnd = 727120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchEraName_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727120, XrefRangeEnd = 727130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727130, XrefRangeEnd = 727144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchAbbreviatedTimeMark_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_byref_TM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727150, RefRangeEnd = 727151, XrefRangeStart = 727144, XrefRangeEnd = 727150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref currentValue);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &patternChar;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckNewValue_Private_Static_Boolean_byref_Int32_Int32_Char_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727156, RefRangeEnd = 727157, XrefRangeStart = 727151, XrefRangeEnd = 727156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateTimeNow_Private_Static_DateTime_byref_DateTimeResult_byref_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727162, RefRangeEnd = 727163, XrefRangeStart = 727157, XrefRangeEnd = 727162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cal);
		*(System.IntPtr**)num = &intPtr;
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDefaultDateTime_Private_Static_Boolean_byref_DateTimeResult_byref_Calendar_DateTimeStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cal = ((intPtr4 == (System.IntPtr)0) ? null : new Calendar(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727227, RefRangeEnd = 727228, XrefRangeStart = 727163, XrefRangeEnd = 727227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandPredefinedFormat_Private_Static_String_ReadOnlySpan_1_Char_byref_DateTimeFormatInfo_byref_ParsingInfo_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dtfi = ((intPtr4 == (System.IntPtr)0) ? null : new DateTimeFormatInfo(intPtr4));
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727228, XrefRangeEnd = 727237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseJapaneseEraStart_Private_Static_Boolean_byref___DTString_DateTimeFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727310, RefRangeEnd = 727311, XrefRangeStart = 727237, XrefRangeEnd = 727310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseByFormat_Private_Static_Boolean_byref___DTString_byref___DTString_byref_ParsingInfo_DateTimeFormatInfo_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727311, XrefRangeEnd = 727314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref returnValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseQuoteString_Internal_Static_Boolean_ReadOnlySpan_1_Char_Int32_StringBuilder_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 727413, RefRangeEnd = 727417, XrefRangeStart = 727314, XrefRangeEnd = 727413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)formatParam));
		*(DateTimeStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styles;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoStrictParse_Private_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_DateTimeStyles_DateTimeFormatInfo_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727417, XrefRangeEnd = 727423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetDateTimeParseException(ref DateTimeResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateTimeParseException_Private_Static_Exception_byref_DateTimeResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	public DateTimeParse(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
