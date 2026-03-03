using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema;

[StructLayout(LayoutKind.Explicit)]
public struct XsdDateTime
{
	[OriginalName("System.Xml.dll", "", "DateTimeTypeCode")]
	public enum DateTimeTypeCode
	{
		DateTime,
		Time,
		Date,
		GYearMonth,
		GYear,
		GMonthDay,
		GDay,
		GMonth,
		XdrDateTime
	}

	[OriginalName("System.Xml.dll", "", "XsdDateTimeKind")]
	public enum XsdDateTimeKind
	{
		Unspecified,
		Zulu,
		LocalWestOfZulu,
		LocalEastOfZulu
	}

	public sealed class Parser : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_typeCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_year;

		private static readonly System.IntPtr NativeFieldInfoPtr_month;

		private static readonly System.IntPtr NativeFieldInfoPtr_day;

		private static readonly System.IntPtr NativeFieldInfoPtr_hour;

		private static readonly System.IntPtr NativeFieldInfoPtr_minute;

		private static readonly System.IntPtr NativeFieldInfoPtr_second;

		private static readonly System.IntPtr NativeFieldInfoPtr_fraction;

		private static readonly System.IntPtr NativeFieldInfoPtr_kind;

		private static readonly System.IntPtr NativeFieldInfoPtr_zoneHour;

		private static readonly System.IntPtr NativeFieldInfoPtr_zoneMinute;

		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		private static readonly System.IntPtr NativeFieldInfoPtr_length;

		private static readonly System.IntPtr NativeFieldInfoPtr_Power10;

		private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0;

		public unsafe DateTimeTypeCode typeCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeCode);
				return *(DateTimeTypeCode*)num;
			}
			set
			{
				*(DateTimeTypeCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeCode)) = value;
			}
		}

		public unsafe int year
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_year);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_year)) = value;
			}
		}

		public unsafe int month
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month)) = value;
			}
		}

		public unsafe int day
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day)) = value;
			}
		}

		public unsafe int hour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hour);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hour)) = value;
			}
		}

		public unsafe int minute
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minute);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minute)) = value;
			}
		}

		public unsafe int second
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second)) = value;
			}
		}

		public unsafe int fraction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraction);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraction)) = value;
			}
		}

		public unsafe XsdDateTimeKind kind
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kind);
				return *(XsdDateTimeKind*)num;
			}
			set
			{
				*(XsdDateTimeKind*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kind)) = value;
			}
		}

		public unsafe int zoneHour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneHour);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneHour)) = value;
			}
		}

		public unsafe int zoneMinute
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneMinute);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneMinute)) = value;
			}
		}

		public unsafe string text
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int length
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = value;
			}
		}

		public unsafe static Il2CppStructArray<int> Power10
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Power10, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Power10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "typeCode");
			NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "year");
			NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "month");
			NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "day");
			NativeFieldInfoPtr_hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "hour");
			NativeFieldInfoPtr_minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "minute");
			NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "second");
			NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "fraction");
			NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "kind");
			NativeFieldInfoPtr_zoneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "zoneHour");
			NativeFieldInfoPtr_zoneMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "zoneMinute");
			NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "text");
			NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "length");
			NativeFieldInfoPtr_Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "Power10");
			NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668586);
			NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668587);
			NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668588);
			NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668589);
			NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668590);
			NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668591);
			NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668592);
			NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668593);
			NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668594);
			NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100668595);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951176, RefRangeEnd = 951178, XrefRangeStart = 951143, XrefRangeEnd = 951176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse(string text, XsdDateTimeFlags kinds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinds;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Boolean_String_XsdDateTimeFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951213, RefRangeEnd = 951214, XrefRangeStart = 951178, XrefRangeEnd = 951213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDate(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&start);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDate_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951214, XrefRangeEnd = 951221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseTimeAndZoneAndWhitespace(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&start);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeAndZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951221, XrefRangeEnd = 951225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseTimeAndWhitespace(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&start);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 951269, RefRangeEnd = 951272, XrefRangeStart = 951225, XrefRangeEnd = 951269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseTime(ref int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref start);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTime_Private_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951305, RefRangeEnd = 951307, XrefRangeStart = 951272, XrefRangeEnd = 951305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseZoneAndWhitespace(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&start);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseZoneAndWhitespace_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951312, RefRangeEnd = 951313, XrefRangeStart = 951307, XrefRangeEnd = 951312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse4Dig(int start, ref int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&start);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse4Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 951316, RefRangeEnd = 951321, XrefRangeStart = 951313, XrefRangeEnd = 951316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse2Dig(int start, ref int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&start);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse2Dig_Private_Boolean_Int32_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool ParseChar(int start, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&start);
			*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseChar_Private_Boolean_Int32_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 629954, RefRangeEnd = 629965, XrefRangeStart = 629954, XrefRangeEnd = 629965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&left);
			*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Test_Private_Static_Boolean_XsdDateTimeFlags_XsdDateTimeFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Parser(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Parser()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_dt;

	private static readonly System.IntPtr NativeFieldInfoPtr_extra;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy_;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy_MM;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy_MM_;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy_MM_dd;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lzyyyy_MM_ddT;

	private static readonly System.IntPtr NativeFieldInfoPtr_LzHH;

	private static readonly System.IntPtr NativeFieldInfoPtr_LzHH_;

	private static readonly System.IntPtr NativeFieldInfoPtr_LzHH_mm;

	private static readonly System.IntPtr NativeFieldInfoPtr_LzHH_mm_;

	private static readonly System.IntPtr NativeFieldInfoPtr_LzHH_mm_ss;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz_;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz_zz;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz_zz_;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz_zz_zz;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz__;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz__mm;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz__mm_;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz__mm__;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz__mm_dd;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz___;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lz___dd;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeCodes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Parser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

	[FieldOffset(0)]
	public DateTime dt;

	[FieldOffset(8)]
	public uint extra;

	public unsafe static int Lzyyyy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy, (void*)(&value));
		}
	}

	public unsafe static int Lzyyyy_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy_, (void*)(&value));
		}
	}

	public unsafe static int Lzyyyy_MM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy_MM, (void*)(&value));
		}
	}

	public unsafe static int Lzyyyy_MM_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy_MM_, (void*)(&value));
		}
	}

	public unsafe static int Lzyyyy_MM_dd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy_MM_dd, (void*)(&value));
		}
	}

	public unsafe static int Lzyyyy_MM_ddT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lzyyyy_MM_ddT, (void*)(&value));
		}
	}

	public unsafe static int LzHH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LzHH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LzHH, (void*)(&value));
		}
	}

	public unsafe static int LzHH_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LzHH_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LzHH_, (void*)(&value));
		}
	}

	public unsafe static int LzHH_mm
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LzHH_mm, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LzHH_mm, (void*)(&value));
		}
	}

	public unsafe static int LzHH_mm_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LzHH_mm_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LzHH_mm_, (void*)(&value));
		}
	}

	public unsafe static int LzHH_mm_ss
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LzHH_mm_ss, (void*)(&value));
		}
	}

	public unsafe static int Lz_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz_, (void*)(&value));
		}
	}

	public unsafe static int Lz_zz
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz_zz, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz_zz, (void*)(&value));
		}
	}

	public unsafe static int Lz_zz_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz_zz_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz_zz_, (void*)(&value));
		}
	}

	public unsafe static int Lz_zz_zz
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz_zz_zz, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz_zz_zz, (void*)(&value));
		}
	}

	public unsafe static int Lz__
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz__, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz__, (void*)(&value));
		}
	}

	public unsafe static int Lz__mm
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz__mm, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz__mm, (void*)(&value));
		}
	}

	public unsafe static int Lz__mm_
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz__mm_, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz__mm_, (void*)(&value));
		}
	}

	public unsafe static int Lz__mm__
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz__mm__, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz__mm__, (void*)(&value));
		}
	}

	public unsafe static int Lz__mm_dd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz__mm_dd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz__mm_dd, (void*)(&value));
		}
	}

	public unsafe static int Lz___
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz___, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz___, (void*)(&value));
		}
	}

	public unsafe static int Lz___dd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lz___dd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lz___dd, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<XmlTypeCode> typeCodes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeCodes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<XmlTypeCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeCodes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DateTimeTypeCode InternalTypeCode
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DateTimeTypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe XsdDateTimeKind InternalKind
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(XsdDateTimeKind*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Year
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951440, RefRangeEnd = 951442, XrefRangeStart = 951436, XrefRangeEnd = 951440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Year_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Month
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 951446, RefRangeEnd = 951449, XrefRangeStart = 951442, XrefRangeEnd = 951446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Month_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Day
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951453, RefRangeEnd = 951455, XrefRangeStart = 951449, XrefRangeEnd = 951453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Day_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Hour
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951455, XrefRangeEnd = 951459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Minute
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951459, XrefRangeEnd = 951463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Second
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951463, XrefRangeEnd = 951467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Second_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Fraction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951479, RefRangeEnd = 951480, XrefRangeStart = 951467, XrefRangeEnd = 951479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int ZoneHour
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int ZoneMinute
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XsdDateTime()
	{
		Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDateTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr);
		NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "dt");
		NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "extra");
		NativeFieldInfoPtr_Lzyyyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy");
		NativeFieldInfoPtr_Lzyyyy_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_");
		NativeFieldInfoPtr_Lzyyyy_MM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM");
		NativeFieldInfoPtr_Lzyyyy_MM_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_");
		NativeFieldInfoPtr_Lzyyyy_MM_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_dd");
		NativeFieldInfoPtr_Lzyyyy_MM_ddT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lzyyyy_MM_ddT");
		NativeFieldInfoPtr_LzHH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH");
		NativeFieldInfoPtr_LzHH_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_");
		NativeFieldInfoPtr_LzHH_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm");
		NativeFieldInfoPtr_LzHH_mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_");
		NativeFieldInfoPtr_LzHH_mm_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "LzHH_mm_ss");
		NativeFieldInfoPtr_Lz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_");
		NativeFieldInfoPtr_Lz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz");
		NativeFieldInfoPtr_Lz_zz_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_");
		NativeFieldInfoPtr_Lz_zz_zz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz_zz_zz");
		NativeFieldInfoPtr_Lz__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__");
		NativeFieldInfoPtr_Lz__mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm");
		NativeFieldInfoPtr_Lz__mm_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_");
		NativeFieldInfoPtr_Lz__mm__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm__");
		NativeFieldInfoPtr_Lz__mm_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz__mm_dd");
		NativeFieldInfoPtr_Lz___ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___");
		NativeFieldInfoPtr_Lz___dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "Lz___dd");
		NativeFieldInfoPtr_typeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, "typeCodes");
		NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668560);
		NativeMethodInfoPtr__ctor_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668561);
		NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668562);
		NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668563);
		NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668564);
		NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668565);
		NativeMethodInfoPtr_get_InternalTypeCode_Private_get_DateTimeTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668566);
		NativeMethodInfoPtr_get_InternalKind_Private_get_XsdDateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668567);
		NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668568);
		NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668569);
		NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668570);
		NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668571);
		NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668572);
		NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668573);
		NativeMethodInfoPtr_get_Fraction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668574);
		NativeMethodInfoPtr_get_ZoneHour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668575);
		NativeMethodInfoPtr_get_ZoneMinute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668576);
		NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668577);
		NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668578);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668579);
		NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668580);
		NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668581);
		NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668582);
		NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668583);
		NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, 100668584);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 951329, RefRangeEnd = 951348, XrefRangeStart = 951321, XrefRangeEnd = 951329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDateTime(string text, XsdDateTimeFlags kinds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_XsdDateTimeFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951348, XrefRangeEnd = 951352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDateTime(Parser parser)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Parser_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951357, RefRangeEnd = 951360, XrefRangeStart = 951352, XrefRangeEnd = 951357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitiateXsdDateTime(Parser parser)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parser));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitiateXsdDateTime_Private_Void_Parser_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951369, RefRangeEnd = 951370, XrefRangeStart = 951360, XrefRangeEnd = 951369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinds;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_XsdDateTimeFlags_byref_XsdDateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 951396, RefRangeEnd = 951405, XrefRangeStart = 951370, XrefRangeEnd = 951396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DateTime_XsdDateTimeFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 951428, RefRangeEnd = 951436, XrefRangeStart = 951405, XrefRangeEnd = 951428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTimeOffset);
		*(XsdDateTimeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kinds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_XsdDateTimeFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 951588, RefRangeEnd = 951599, XrefRangeStart = 951480, XrefRangeEnd = 951588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator DateTime(XsdDateTime xdt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&xdt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_DateTime_XsdDateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 951666, RefRangeEnd = 951675, XrefRangeStart = 951599, XrefRangeEnd = 951666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator DateTimeOffset(XsdDateTime xdt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&xdt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_XsdDateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTimeOffset*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 951752, RefRangeEnd = 951769, XrefRangeStart = 951675, XrefRangeEnd = 951752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 951795, RefRangeEnd = 951797, XrefRangeStart = 951769, XrefRangeEnd = 951795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintDate(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintDate_Private_Void_StringBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951827, RefRangeEnd = 951828, XrefRangeStart = 951797, XrefRangeEnd = 951827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintTime(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintTime_Private_Void_StringBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951849, RefRangeEnd = 951850, XrefRangeStart = 951828, XrefRangeEnd = 951849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintZone(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintZone_Private_Void_StringBuilder_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 951850, RefRangeEnd = 951852, XrefRangeStart = 951850, XrefRangeEnd = 951850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IntToCharArray(Il2CppStructArray<char> text, int start, int value, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951852, RefRangeEnd = 951855, XrefRangeStart = 951852, XrefRangeEnd = 951852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShortToCharArray(Il2CppStructArray<char> text, int start, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortToCharArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDateTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
