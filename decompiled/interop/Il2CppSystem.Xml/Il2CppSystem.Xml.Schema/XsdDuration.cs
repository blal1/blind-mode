using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

[StructLayout(LayoutKind.Explicit)]
public struct XsdDuration
{
	[OriginalName("System.Xml.dll", "", "Parts")]
	public enum Parts
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 0x10,
		HasSeconds = 0x20
	}

	[OriginalName("System.Xml.dll", "", "DurationType")]
	public enum DurationType
	{
		Duration,
		YearMonthDuration,
		DayTimeDuration
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_years;

	private static readonly System.IntPtr NativeFieldInfoPtr_months;

	private static readonly System.IntPtr NativeFieldInfoPtr_days;

	private static readonly System.IntPtr NativeFieldInfoPtr_hours;

	private static readonly System.IntPtr NativeFieldInfoPtr_minutes;

	private static readonly System.IntPtr NativeFieldInfoPtr_seconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_nanoseconds;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Years_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Months_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Days_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Internal_String_DurationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0;

	[FieldOffset(0)]
	public int years;

	[FieldOffset(4)]
	public int months;

	[FieldOffset(8)]
	public int days;

	[FieldOffset(12)]
	public int hours;

	[FieldOffset(16)]
	public int minutes;

	[FieldOffset(20)]
	public int seconds;

	[FieldOffset(24)]
	public uint nanoseconds;

	public unsafe bool IsNegative
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Years
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Years_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Months
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Months_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Days
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Days_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Hours
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Minutes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Seconds
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Nanoseconds
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XsdDuration()
	{
		Il2CppClassPointerStore<XsdDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDuration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr);
		NativeFieldInfoPtr_years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "years");
		NativeFieldInfoPtr_months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "months");
		NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "days");
		NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "hours");
		NativeFieldInfoPtr_minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "minutes");
		NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "seconds");
		NativeFieldInfoPtr_nanoseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "nanoseconds");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668597);
		NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668598);
		NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668599);
		NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668600);
		NativeMethodInfoPtr_get_Years_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668601);
		NativeMethodInfoPtr_get_Months_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668602);
		NativeMethodInfoPtr_get_Days_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668603);
		NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668604);
		NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668605);
		NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668606);
		NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668607);
		NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668608);
		NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668609);
		NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668610);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668611);
		NativeMethodInfoPtr_ToString_Internal_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668612);
		NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668614);
		NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100668615);
	}

	[CallerCount(0)]
	public unsafe XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&isNegative);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &years;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &months;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &days;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hours;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minutes;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &seconds;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &nanoseconds;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951858, RefRangeEnd = 951861, XrefRangeStart = 951855, XrefRangeEnd = 951858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDuration(TimeSpan timeSpan, DurationType durationType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&timeSpan);
		*(DurationType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &durationType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951862, RefRangeEnd = 951865, XrefRangeStart = 951861, XrefRangeEnd = 951862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdDuration(string s, DurationType durationType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(DurationType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &durationType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951866, RefRangeEnd = 951869, XrefRangeStart = 951865, XrefRangeEnd = 951866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeSpan ToTimeSpan(DurationType durationType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&durationType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951870, RefRangeEnd = 951871, XrefRangeStart = 951869, XrefRangeEnd = 951870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Exception TryToTimeSpan(out TimeSpan result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 951876, RefRangeEnd = 951880, XrefRangeStart = 951871, XrefRangeEnd = 951876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Exception TryToTimeSpan(DurationType durationType, out TimeSpan result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&durationType);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951880, XrefRangeEnd = 951881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 951937, RefRangeEnd = 951941, XrefRangeStart = 951881, XrefRangeEnd = 951937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(DurationType durationType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&durationType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Internal_String_DurationType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951942, RefRangeEnd = 951943, XrefRangeStart = 951941, XrefRangeEnd = 951942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryParse(string s, out XsdDuration result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 952011, RefRangeEnd = 952015, XrefRangeStart = 951943, XrefRangeEnd = 952011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception TryParse(string s, DurationType durationType, out XsdDuration result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(DurationType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &durationType;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952015, XrefRangeEnd = 952019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eatDigits;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref numDigits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
