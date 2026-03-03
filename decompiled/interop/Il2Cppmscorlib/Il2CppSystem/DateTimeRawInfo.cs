using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct DateTimeRawInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_num;

	private static readonly System.IntPtr NativeFieldInfoPtr_numCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_month;

	private static readonly System.IntPtr NativeFieldInfoPtr_year;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayOfWeek;

	private static readonly System.IntPtr NativeFieldInfoPtr_era;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSameDateAndTimeSeparators;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr num;

	[FieldOffset(8)]
	public int numCount;

	[FieldOffset(12)]
	public int month;

	[FieldOffset(16)]
	public int year;

	[FieldOffset(20)]
	public int dayOfWeek;

	[FieldOffset(24)]
	public int era;

	[FieldOffset(28)]
	public DateTimeParse.TM timeMark;

	[FieldOffset(32)]
	public double fraction;

	[FieldOffset(40)]
	[MarshalAs(UnmanagedType.U1)]
	public bool hasSameDateAndTimeSeparators;

	static DateTimeRawInfo()
	{
		Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeRawInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr);
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "num");
		NativeFieldInfoPtr_numCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "numCount");
		NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "month");
		NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "year");
		NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "dayOfWeek");
		NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "era");
		NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeMark");
		NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "fraction");
		NativeFieldInfoPtr_hasSameDateAndTimeSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "hasSameDateAndTimeSeparators");
		NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665100);
		NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665102);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727727, RefRangeEnd = 727728, XrefRangeStart = 727727, XrefRangeEnd = 727727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(int* numberBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)numberBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727728, RefRangeEnd = 727729, XrefRangeStart = 727728, XrefRangeEnd = 727728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNumber(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 727729, RefRangeEnd = 727772, XrefRangeStart = 727729, XrefRangeEnd = 727729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNumber(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
