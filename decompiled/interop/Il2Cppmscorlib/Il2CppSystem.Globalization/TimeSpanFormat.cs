using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Globalization;

public static class TimeSpanFormat : Object
{
	[OriginalName("mscorlib.dll", "", "Pattern")]
	public enum Pattern
	{
		None,
		Minimum,
		Full
	}

	public sealed class FormatLiterals : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AppCompatLiteral;

		private static readonly System.IntPtr NativeFieldInfoPtr_dd;

		private static readonly System.IntPtr NativeFieldInfoPtr_hh;

		private static readonly System.IntPtr NativeFieldInfoPtr_mm;

		private static readonly System.IntPtr NativeFieldInfoPtr_ss;

		private static readonly System.IntPtr NativeFieldInfoPtr_ff;

		private static readonly System.IntPtr NativeFieldInfoPtr__literals;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Start_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_End_Internal_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0;

		public unsafe string AppCompatLiteral
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppCompatLiteral);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppCompatLiteral)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int dd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dd);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dd)) = value;
			}
		}

		public unsafe int hh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hh);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hh)) = value;
			}
		}

		public unsafe int mm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mm);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mm)) = value;
			}
		}

		public unsafe int ss
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ss);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ss)) = value;
			}
		}

		public unsafe int ff
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ff);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ff)) = value;
			}
		}

		public unsafe Il2CppStringArray _literals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__literals);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__literals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string Start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Start_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string DayHourSep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string HourMinuteSep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string MinuteSecondSep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string SecondFractionSep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe string End
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_End_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static FormatLiterals()
		{
			Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "FormatLiterals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr);
			NativeFieldInfoPtr_AppCompatLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "AppCompatLiteral");
			NativeFieldInfoPtr_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "dd");
			NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "hh");
			NativeFieldInfoPtr_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "mm");
			NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "ss");
			NativeFieldInfoPtr_ff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "ff");
			NativeFieldInfoPtr__literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, "_literals");
			NativeMethodInfoPtr_get_Start_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672808);
			NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672809);
			NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672810);
			NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672811);
			NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672812);
			NativeMethodInfoPtr_get_End_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672813);
			NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672814);
			NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, 100672815);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817726, XrefRangeEnd = 817751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormatLiterals InitInvariant(bool isNegative)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&isNegative);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FormatLiterals(pointer);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 817775, RefRangeEnd = 817776, XrefRangeStart = 817751, XrefRangeEnd = 817775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useInvariantFieldLengths;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_ReadOnlySpan_1_Char_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FormatLiterals(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FormatLiterals()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PositiveInvariantFormatLiterals;

	private static readonly System.IntPtr NativeFieldInfoPtr_NegativeInvariantFormatLiterals;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0;

	public unsafe static FormatLiterals PositiveInvariantFormatLiterals
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PositiveInvariantFormatLiterals, (void*)intPtr);
			return new FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PositiveInvariantFormatLiterals, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static FormatLiterals NegativeInvariantFormatLiterals
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NegativeInvariantFormatLiterals, (void*)intPtr);
			return new FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormatLiterals>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NegativeInvariantFormatLiterals, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	static TimeSpanFormat()
	{
		Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanFormat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr);
		NativeFieldInfoPtr_PositiveInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "PositiveInvariantFormatLiterals");
		NativeFieldInfoPtr_NegativeInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "NegativeInvariantFormatLiterals");
		NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672801);
		NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672802);
		NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672803);
		NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672804);
		NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672805);
		NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100672806);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 817778, RefRangeEnd = 817782, XrefRangeStart = 817776, XrefRangeEnd = 817778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendNonNegativeInt32_Private_Static_Void_StringBuilder_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 817790, RefRangeEnd = 817793, XrefRangeStart = 817782, XrefRangeEnd = 817790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817800, RefRangeEnd = 817801, XrefRangeStart = 817793, XrefRangeEnd = 817800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormat_Internal_Static_Boolean_TimeSpan_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817816, RefRangeEnd = 817818, XrefRangeStart = 817801, XrefRangeEnd = 817816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatToBuilder_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817818, XrefRangeEnd = 817862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, Pattern pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInvariant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(Pattern**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pattern;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatStandard_Private_Static_StringBuilder_TimeSpan_Boolean_ReadOnlySpan_1_Char_Pattern_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817909, RefRangeEnd = 817910, XrefRangeStart = 817862, XrefRangeEnd = 817909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatCustomized_Private_Static_StringBuilder_TimeSpan_ReadOnlySpan_1_Char_DateTimeFormatInfo_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	public TimeSpanFormat(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
