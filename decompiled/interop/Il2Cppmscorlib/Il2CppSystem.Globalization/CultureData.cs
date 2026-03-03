using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization;

public class CultureData : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct NumberFormatEntryManaged
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_currency_decimal_digits;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_decimal_separator;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_group_separator;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_group_sizes0;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_group_sizes1;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_negative_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_positive_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_currency_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_nan_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_negative_infinity_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_negative_sign;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_decimal_digits;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_decimal_separator;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_group_separator;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_group_sizes0;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_group_sizes1;

		private static readonly System.IntPtr NativeFieldInfoPtr_number_negative_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_per_mille_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_percent_negative_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_percent_positive_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr_percent_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_positive_infinity_symbol;

		private static readonly System.IntPtr NativeFieldInfoPtr_positive_sign;

		[FieldOffset(0)]
		public int currency_decimal_digits;

		[FieldOffset(4)]
		public int currency_decimal_separator;

		[FieldOffset(8)]
		public int currency_group_separator;

		[FieldOffset(12)]
		public int currency_group_sizes0;

		[FieldOffset(16)]
		public int currency_group_sizes1;

		[FieldOffset(20)]
		public int currency_negative_pattern;

		[FieldOffset(24)]
		public int currency_positive_pattern;

		[FieldOffset(28)]
		public int currency_symbol;

		[FieldOffset(32)]
		public int nan_symbol;

		[FieldOffset(36)]
		public int negative_infinity_symbol;

		[FieldOffset(40)]
		public int negative_sign;

		[FieldOffset(44)]
		public int number_decimal_digits;

		[FieldOffset(48)]
		public int number_decimal_separator;

		[FieldOffset(52)]
		public int number_group_separator;

		[FieldOffset(56)]
		public int number_group_sizes0;

		[FieldOffset(60)]
		public int number_group_sizes1;

		[FieldOffset(64)]
		public int number_negative_pattern;

		[FieldOffset(68)]
		public int per_mille_symbol;

		[FieldOffset(72)]
		public int percent_negative_pattern;

		[FieldOffset(76)]
		public int percent_positive_pattern;

		[FieldOffset(80)]
		public int percent_symbol;

		[FieldOffset(84)]
		public int positive_infinity_symbol;

		[FieldOffset(88)]
		public int positive_sign;

		static NumberFormatEntryManaged()
		{
			Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "NumberFormatEntryManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr);
			NativeFieldInfoPtr_currency_decimal_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_decimal_digits");
			NativeFieldInfoPtr_currency_decimal_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_decimal_separator");
			NativeFieldInfoPtr_currency_group_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_group_separator");
			NativeFieldInfoPtr_currency_group_sizes0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_group_sizes0");
			NativeFieldInfoPtr_currency_group_sizes1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_group_sizes1");
			NativeFieldInfoPtr_currency_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_negative_pattern");
			NativeFieldInfoPtr_currency_positive_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_positive_pattern");
			NativeFieldInfoPtr_currency_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "currency_symbol");
			NativeFieldInfoPtr_nan_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "nan_symbol");
			NativeFieldInfoPtr_negative_infinity_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "negative_infinity_symbol");
			NativeFieldInfoPtr_negative_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "negative_sign");
			NativeFieldInfoPtr_number_decimal_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_decimal_digits");
			NativeFieldInfoPtr_number_decimal_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_decimal_separator");
			NativeFieldInfoPtr_number_group_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_group_separator");
			NativeFieldInfoPtr_number_group_sizes0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_group_sizes0");
			NativeFieldInfoPtr_number_group_sizes1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_group_sizes1");
			NativeFieldInfoPtr_number_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "number_negative_pattern");
			NativeFieldInfoPtr_per_mille_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "per_mille_symbol");
			NativeFieldInfoPtr_percent_negative_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "percent_negative_pattern");
			NativeFieldInfoPtr_percent_positive_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "percent_positive_pattern");
			NativeFieldInfoPtr_percent_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "percent_symbol");
			NativeFieldInfoPtr_positive_infinity_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "positive_infinity_symbol");
			NativeFieldInfoPtr_positive_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, "positive_sign");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberFormatEntryManaged>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_sAM1159;

	private static readonly System.IntPtr NativeFieldInfoPtr_sPM2359;

	private static readonly System.IntPtr NativeFieldInfoPtr_sTimeSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_saLongTimes;

	private static readonly System.IntPtr NativeFieldInfoPtr_saShortTimes;

	private static readonly System.IntPtr NativeFieldInfoPtr_iFirstDayOfWeek;

	private static readonly System.IntPtr NativeFieldInfoPtr_iFirstWeekOfYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_waCalendars;

	private static readonly System.IntPtr NativeFieldInfoPtr_calendars;

	private static readonly System.IntPtr NativeFieldInfoPtr_sISO639Language;

	private static readonly System.IntPtr NativeFieldInfoPtr_sRealName;

	private static readonly System.IntPtr NativeFieldInfoPtr_bUseOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_calendarId;

	private static readonly System.IntPtr NativeFieldInfoPtr_numberIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_iDefaultAnsiCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_iDefaultOemCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_iDefaultMacCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_iDefaultEbcdicCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRightToLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_sListSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Invariant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CultureName_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0;

	public unsafe string sAM1159
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sAM1159);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sAM1159)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string sPM2359
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sPM2359);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sPM2359)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string sTimeSeparator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sTimeSeparator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sTimeSeparator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray saLongTimes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saLongTimes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saLongTimes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray saShortTimes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saShortTimes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saShortTimes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int iFirstDayOfWeek
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iFirstDayOfWeek);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iFirstDayOfWeek)) = value;
		}
	}

	public unsafe int iFirstWeekOfYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iFirstWeekOfYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iFirstWeekOfYear)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> waCalendars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waCalendars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waCalendars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<CalendarData> calendars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CalendarData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string sISO639Language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sISO639Language);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sISO639Language)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string sRealName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sRealName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sRealName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool bUseOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bUseOverrides);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bUseOverrides)) = value;
		}
	}

	public unsafe int calendarId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendarId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calendarId)) = value;
		}
	}

	public unsafe int numberIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberIndex)) = value;
		}
	}

	public unsafe int iDefaultAnsiCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultAnsiCodePage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultAnsiCodePage)) = value;
		}
	}

	public unsafe int iDefaultOemCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultOemCodePage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultOemCodePage)) = value;
		}
	}

	public unsafe int iDefaultMacCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultMacCodePage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultMacCodePage)) = value;
		}
	}

	public unsafe int iDefaultEbcdicCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultEbcdicCodePage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDefaultEbcdicCodePage)) = value;
		}
	}

	public unsafe bool isRightToLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightToLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightToLeft)) = value;
		}
	}

	public unsafe string sListSeparator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sListSeparator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sListSeparator)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static CultureData s_Invariant
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Invariant, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureData Invariant
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 819884, RefRangeEnd = 819887, XrefRangeStart = 819815, XrefRangeEnd = 819884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray LongTimes
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 767935, RefRangeEnd = 767943, XrefRangeStart = 767935, XrefRangeEnd = 767943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStringArray ShortTimes
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 767541, RefRangeEnd = 767547, XrefRangeStart = 767541, XrefRangeEnd = 767547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe string SISO639LANGNAME
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe int IFIRSTDAYOFWEEK
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int IFIRSTWEEKOFYEAR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string SAM1159
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string SPM2359
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string TimeSeparator
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<int> CalendarIds
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 819947, RefRangeEnd = 819950, XrefRangeStart = 819935, XrefRangeEnd = 819947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
	}

	public unsafe bool IsInvariantCulture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819983, XrefRangeEnd = 819984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string CultureName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CultureName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string SCOMPAREINFO
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 819986, RefRangeEnd = 819987, XrefRangeStart = 819984, XrefRangeEnd = 819986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string STEXTINFO
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool UseUserOverride
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static CultureData()
	{
		Il2CppClassPointerStore<CultureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureData>.NativeClassPtr);
		NativeFieldInfoPtr_sAM1159 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sAM1159");
		NativeFieldInfoPtr_sPM2359 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sPM2359");
		NativeFieldInfoPtr_sTimeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sTimeSeparator");
		NativeFieldInfoPtr_saLongTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saLongTimes");
		NativeFieldInfoPtr_saShortTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "saShortTimes");
		NativeFieldInfoPtr_iFirstDayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstDayOfWeek");
		NativeFieldInfoPtr_iFirstWeekOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iFirstWeekOfYear");
		NativeFieldInfoPtr_waCalendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "waCalendars");
		NativeFieldInfoPtr_calendars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendars");
		NativeFieldInfoPtr_sISO639Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sISO639Language");
		NativeFieldInfoPtr_sRealName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sRealName");
		NativeFieldInfoPtr_bUseOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "bUseOverrides");
		NativeFieldInfoPtr_calendarId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "calendarId");
		NativeFieldInfoPtr_numberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "numberIndex");
		NativeFieldInfoPtr_iDefaultAnsiCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultAnsiCodePage");
		NativeFieldInfoPtr_iDefaultOemCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultOemCodePage");
		NativeFieldInfoPtr_iDefaultMacCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultMacCodePage");
		NativeFieldInfoPtr_iDefaultEbcdicCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "iDefaultEbcdicCodePage");
		NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "isRightToLeft");
		NativeFieldInfoPtr_sListSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "sListSeparator");
		NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureData>.NativeClassPtr, "s_Invariant");
		NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673148);
		NativeMethodInfoPtr_get_Invariant_Public_Static_get_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673149);
		NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673150);
		NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673151);
		NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673152);
		NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673153);
		NativeMethodInfoPtr_get_LongTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673154);
		NativeMethodInfoPtr_get_ShortTimes_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673155);
		NativeMethodInfoPtr_get_SISO639LANGNAME_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673156);
		NativeMethodInfoPtr_get_IFIRSTDAYOFWEEK_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673157);
		NativeMethodInfoPtr_get_IFIRSTWEEKOFYEAR_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673158);
		NativeMethodInfoPtr_get_SAM1159_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673159);
		NativeMethodInfoPtr_get_SPM2359_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673160);
		NativeMethodInfoPtr_get_TimeSeparator_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673161);
		NativeMethodInfoPtr_get_CalendarIds_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673162);
		NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673163);
		NativeMethodInfoPtr_get_IsInvariantCulture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673164);
		NativeMethodInfoPtr_get_CultureName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673165);
		NativeMethodInfoPtr_get_SCOMPAREINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673166);
		NativeMethodInfoPtr_get_STEXTINFO_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673167);
		NativeMethodInfoPtr_get_UseUserOverride_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673168);
		NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673169);
		NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673170);
		NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673171);
		NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673172);
		NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673173);
		NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673174);
		NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673175);
		NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673176);
		NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673177);
		NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673178);
		NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673179);
		NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673180);
		NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673181);
		NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673182);
		NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673183);
		NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673184);
		NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673185);
		NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673186);
		NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673187);
		NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673188);
		NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673189);
		NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673190);
		NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673191);
		NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673192);
		NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673193);
		NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureData>.NativeClassPtr, 100673194);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819813, XrefRangeEnd = 819815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureData(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 819892, RefRangeEnd = 819893, XrefRangeStart = 819887, XrefRangeEnd = 819892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 819904, RefRangeEnd = 819908, XrefRangeStart = 819893, XrefRangeEnd = 819904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useUserOverride;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &datetimeIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &calendarId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &numberIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(iso2lang);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ansiCodePage;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &oemCodePage;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &macCodePage;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &ebcdicCodePage;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightToLeft;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(listSeparator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCultureData_Public_Static_CultureData_String_Boolean_Int32_Int32_Int32_String_Int32_Int32_Int32_Int32_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819908, XrefRangeEnd = 819909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void fill_culture_data(int datetimeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&datetimeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fill_culture_data_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 819919, RefRangeEnd = 819935, XrefRangeStart = 819909, XrefRangeEnd = 819919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CalendarData GetCalendar(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCalendar_Public_CalendarData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CalendarData>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 819981, RefRangeEnd = 819983, XrefRangeStart = 819950, XrefRangeEnd = 819981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<CalendarId> GetCalendarIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCalendarIds_Internal_Il2CppStructArray_1_CalendarId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CalendarId>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 819988, RefRangeEnd = 819990, XrefRangeStart = 819987, XrefRangeEnd = 819988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray EraNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 819991, RefRangeEnd = 819993, XrefRangeStart = 819990, XrefRangeEnd = 819991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray AbbrevEraNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbbrevEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 819994, RefRangeEnd = 819997, XrefRangeStart = 819993, XrefRangeEnd = 819994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray AbbreviatedEnglishEraNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbbreviatedEnglishEraNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 819998, RefRangeEnd = 820002, XrefRangeStart = 819997, XrefRangeEnd = 819998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray ShortDates(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 820003, RefRangeEnd = 820007, XrefRangeStart = 820002, XrefRangeEnd = 820003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray LongDates(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LongDates_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 820008, RefRangeEnd = 820012, XrefRangeStart = 820007, XrefRangeEnd = 820008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray YearMonths(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_YearMonths_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820013, RefRangeEnd = 820014, XrefRangeStart = 820012, XrefRangeEnd = 820013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray DayNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820015, RefRangeEnd = 820016, XrefRangeStart = 820014, XrefRangeEnd = 820015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray AbbreviatedDayNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbbreviatedDayNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820017, RefRangeEnd = 820018, XrefRangeStart = 820016, XrefRangeEnd = 820017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray MonthNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 820019, RefRangeEnd = 820024, XrefRangeStart = 820018, XrefRangeEnd = 820019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GenitiveMonthNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820025, RefRangeEnd = 820026, XrefRangeStart = 820024, XrefRangeEnd = 820025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray AbbreviatedMonthNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbbreviatedMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820027, RefRangeEnd = 820029, XrefRangeStart = 820026, XrefRangeEnd = 820027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray AbbreviatedGenitiveMonthNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AbbreviatedGenitiveMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820030, RefRangeEnd = 820032, XrefRangeStart = 820029, XrefRangeEnd = 820030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray LeapYearMonthNames(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeapYearMonthNames_Internal_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820033, RefRangeEnd = 820035, XrefRangeStart = 820032, XrefRangeEnd = 820033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string MonthDay(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonthDay_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 820039, RefRangeEnd = 820043, XrefRangeStart = 820035, XrefRangeEnd = 820039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DateSeparator(int calendarId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calendarId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DateSeparator_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820043, XrefRangeEnd = 820046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDateSeparator(string format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateSeparator_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820061, RefRangeEnd = 820062, XrefRangeStart = 820046, XrefRangeEnd = 820061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSeparator(string format, string timeParts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(timeParts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSeparator_Private_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820062, XrefRangeEnd = 820068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfTimePart(string format, int startIndex, string timeParts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(timeParts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfTimePart_Private_Static_Int32_String_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820082, RefRangeEnd = 820083, XrefRangeStart = 820068, XrefRangeEnd = 820082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UnescapeNlsString(string str, int start, int end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeNlsString_Private_Static_String_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray ReescapeWin32Strings(Il2CppStringArray array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReescapeWin32Strings_Internal_Static_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReescapeWin32String(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReescapeWin32String_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int strlen(byte* s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)s;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_strlen_Private_Static_Int32_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820083, XrefRangeEnd = 820086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string idx2string(byte* data, int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)data;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_idx2string_Private_Static_String_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 820090, RefRangeEnd = 820092, XrefRangeStart = 820086, XrefRangeEnd = 820090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> create_group_sizes_array(int gs0, int gs1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gs0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gs1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_group_sizes_array_Private_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820138, RefRangeEnd = 820139, XrefRangeStart = 820092, XrefRangeEnd = 820138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetNFIValues(NumberFormatInfo nfi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNFIValues_Internal_Void_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820139, XrefRangeEnd = 820140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nfe);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fill_number_data_Private_Static_ptr_Byte_Int32_byref_NumberFormatEntryManaged_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (byte*)result;
	}

	public CultureData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
