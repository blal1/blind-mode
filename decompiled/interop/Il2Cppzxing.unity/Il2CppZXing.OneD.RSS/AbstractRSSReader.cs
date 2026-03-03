using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.OneD.RSS;

public class AbstractRSSReader : OneDReader
{
	private static readonly IntPtr NativeFieldInfoPtr_MAX_AVG_VARIANCE;

	private static readonly IntPtr NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE;

	private static readonly IntPtr NativeFieldInfoPtr_decodeFinderCounters;

	private static readonly IntPtr NativeFieldInfoPtr_dataCharacterCounters;

	private static readonly IntPtr NativeFieldInfoPtr_oddRoundingErrors;

	private static readonly IntPtr NativeFieldInfoPtr_evenRoundingErrors;

	private static readonly IntPtr NativeFieldInfoPtr_oddCounts;

	private static readonly IntPtr NativeFieldInfoPtr_evenCounts;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_getDecodeFinderCounters_Protected_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getDataCharacterCounters_Protected_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getOddRoundingErrors_Protected_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_getEvenRoundingErrors_Protected_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_getOddCounts_Protected_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getEvenCounts_Protected_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_parseFinderValue_Protected_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_increment_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_decrement_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_isFinderPattern_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0;

	public unsafe static int MAX_AVG_VARIANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_AVG_VARIANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_AVG_VARIANCE, (void*)(&value));
		}
	}

	public unsafe static int MAX_INDIVIDUAL_VARIANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE, (void*)(&value));
		}
	}

	public unsafe Il2CppStructArray<int> decodeFinderCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeFinderCounters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeFinderCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> dataCharacterCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataCharacterCounters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataCharacterCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> oddRoundingErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oddRoundingErrors);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oddRoundingErrors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> evenRoundingErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evenRoundingErrors);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evenRoundingErrors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> oddCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oddCounts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oddCounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> evenCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evenCounts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evenCounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AbstractRSSReader()
	{
		Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS", "AbstractRSSReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_AVG_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "MAX_AVG_VARIANCE");
		NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "MAX_INDIVIDUAL_VARIANCE");
		NativeFieldInfoPtr_decodeFinderCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "decodeFinderCounters");
		NativeFieldInfoPtr_dataCharacterCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "dataCharacterCounters");
		NativeFieldInfoPtr_oddRoundingErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "oddRoundingErrors");
		NativeFieldInfoPtr_evenRoundingErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "evenRoundingErrors");
		NativeFieldInfoPtr_oddCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "oddCounts");
		NativeFieldInfoPtr_evenCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, "evenCounts");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_getDecodeFinderCounters_Protected_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_getDataCharacterCounters_Protected_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_getOddRoundingErrors_Protected_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_getEvenRoundingErrors_Protected_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_getOddCounts_Protected_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_getEvenCounts_Protected_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_parseFinderValue_Protected_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_increment_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_decrement_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_isFinderPattern_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr, 100664252);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424149, RefRangeEnd = 1424151, XrefRangeStart = 1424124, XrefRangeEnd = 1424149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AbstractRSSReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractRSSReader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> getDecodeFinderCounters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDecodeFinderCounters_Protected_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> getDataCharacterCounters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDataCharacterCounters_Protected_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> getOddRoundingErrors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getOddRoundingErrors_Protected_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> getEvenRoundingErrors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEvenRoundingErrors_Protected_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> getOddCounts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getOddCounts_Protected_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> getEvenCounts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEvenCounts_Protected_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424151, XrefRangeEnd = 1424161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool parseFinderValue(Il2CppStructArray<int> counters, Il2CppReferenceArray<Il2CppStructArray<int>> finderPatterns, out int value)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)finderPatterns);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseFinderValue_Protected_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424161, XrefRangeEnd = 1424162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void increment(Il2CppStructArray<int> array, Il2CppStructArray<float> errors)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errors);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_increment_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424162, XrefRangeEnd = 1424163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void decrement(Il2CppStructArray<int> array, Il2CppStructArray<float> errors)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errors);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decrement_Protected_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Single_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424164, RefRangeEnd = 1424166, XrefRangeStart = 1424163, XrefRangeEnd = 1424164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isFinderPattern(Il2CppStructArray<int> counters)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFinderPattern_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AbstractRSSReader(IntPtr pointer)
		: base(pointer)
	{
	}
}
