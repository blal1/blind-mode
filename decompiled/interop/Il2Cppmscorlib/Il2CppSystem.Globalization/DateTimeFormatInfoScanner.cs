using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization;

public class DateTimeFormatInfoScanner : Object
{
	[OriginalName("mscorlib.dll", "", "FoundDatePattern")]
	public enum FoundDatePattern
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dateWords;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_knownWords;

	private static readonly System.IntPtr NativeFieldInfoPtr__ymdFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<string> m_dateWords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dateWords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dateWords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, string> s_knownWords
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_knownWords, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_knownWords, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FoundDatePattern _ymdFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ymdFlags);
			return *(FoundDatePattern*)num;
		}
		set
		{
			*(FoundDatePattern*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ymdFlags)) = value;
		}
	}

	public unsafe static Dictionary<string, string> KnownWords
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 817452, RefRangeEnd = 817453, XrefRangeStart = 817356, XrefRangeEnd = 817452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
	}

	static DateTimeFormatInfoScanner()
	{
		Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DateTimeFormatInfoScanner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr);
		NativeFieldInfoPtr_m_dateWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "m_dateWords");
		NativeFieldInfoPtr_s_knownWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "s_knownWords");
		NativeFieldInfoPtr__ymdFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, "_ymdFlags");
		NativeMethodInfoPtr_get_KnownWords_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672778);
		NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672779);
		NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672780);
		NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672781);
		NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672782);
		NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672783);
		NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672784);
		NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672785);
		NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672786);
		NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672787);
		NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672788);
		NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672789);
		NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672790);
		NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672791);
		NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672792);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr, 100672793);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817453, XrefRangeEnd = 817459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipWhiteSpacesAndNonLetter_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817489, RefRangeEnd = 817491, XrefRangeStart = 817459, XrefRangeEnd = 817489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDateWordOrPostfix(string formatPostfix, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDateWordOrPostfix_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817514, RefRangeEnd = 817516, XrefRangeStart = 817491, XrefRangeEnd = 817514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AddDateWords(string pattern, int index, string formatPostfix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(formatPostfix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDateWords_Internal_Int32_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817516, XrefRangeEnd = 817518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ScanRepeatChar(string pattern, char ch, int index, out int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanRepeatChar_Internal_Static_Int32_String_Char_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817534, RefRangeEnd = 817535, XrefRangeStart = 817518, XrefRangeEnd = 817534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddIgnorableSymbols(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddIgnorableSymbols_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 817559, RefRangeEnd = 817565, XrefRangeStart = 817535, XrefRangeEnd = 817559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScanDateWord(string pattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanDateWord_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817592, RefRangeEnd = 817593, XrefRangeStart = 817565, XrefRangeEnd = 817592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtfi);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDateWordsOfDTFI_Internal_Il2CppStringArray_DateTimeFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817593, XrefRangeEnd = 817598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FORMATFLAGS GetFormatFlagGenitiveMonth(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genitveMonthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)abbrevMonthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genetiveAbbrevMonthNames);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatFlagGenitiveMonth_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FORMATFLAGS*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817598, XrefRangeEnd = 817606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(Il2CppStringArray monthNames, Il2CppStringArray genitveMonthNames, Il2CppStringArray abbrevMonthNames, Il2CppStringArray genetiveAbbrevMonthNames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genitveMonthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)abbrevMonthNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)genetiveAbbrevMonthNames);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatFlagUseSpaceInMonthNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FORMATFLAGS*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817606, XrefRangeEnd = 817608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(Il2CppStringArray dayNames, Il2CppStringArray abbrevDayNames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dayNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)abbrevDayNames);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatFlagUseSpaceInDayNames_Internal_Static_FORMATFLAGS_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FORMATFLAGS*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&calID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormatFlagUseHebrewCalendar_Internal_Static_FORMATFLAGS_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FORMATFLAGS*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817608, XrefRangeEnd = 817611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EqualStringArrays(Il2CppStringArray array1, Il2CppStringArray array2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EqualStringArrays_Private_Static_Boolean_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 817617, RefRangeEnd = 817629, XrefRangeStart = 817611, XrefRangeEnd = 817617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ArrayElementsHaveSpace(Il2CppStringArray array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayElementsHaveSpace_Private_Static_Boolean_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 817640, RefRangeEnd = 817648, XrefRangeStart = 817629, XrefRangeEnd = 817640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ArrayElementsBeginWithDigit(Il2CppStringArray array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayElementsBeginWithDigit_Private_Static_Boolean_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817648, XrefRangeEnd = 817656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DateTimeFormatInfoScanner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeFormatInfoScanner>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DateTimeFormatInfoScanner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
