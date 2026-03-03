using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded;

public sealed class RSSExpandedReader : AbstractRSSReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SYMBOL_WIDEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_EVEN_TOTAL_SUBSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_GSUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINDER_PATTERNS;

	private static readonly System.IntPtr NativeFieldInfoPtr_WEIGHTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINDER_PATTERN_SEQUENCES;

	private static readonly System.IntPtr NativeFieldInfoPtr_pairs;

	private static readonly System.IntPtr NativeFieldInfoPtr_rows;

	private static readonly System.IntPtr NativeFieldInfoPtr_startEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_startFromEven;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow2pairs_Internal_Boolean_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_List_1_ExpandedRow_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValidSequence_Private_Static_Boolean_List_1_ExpandedPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_storeRow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removePartialRows_Private_Static_Void_List_1_ExpandedPair_List_1_ExpandedRow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPartialRow_Private_Static_Boolean_IEnumerable_1_ExpandedPair_IEnumerable_1_ExpandedRow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_constructResult_Internal_Static_Result_List_1_ExpandedPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkChecksum_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNextSecondBar_Private_Static_Int32_BitArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_retrieveNextPair_Internal_ExpandedPair_BitArray_List_1_ExpandedPair_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findNextPair_Private_Boolean_BitArray_List_1_ExpandedPair_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reverseCounters_Private_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeDataCharacter_Internal_DataCharacter_BitArray_FinderPattern_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNotA1left_Private_Static_Boolean_FinderPattern_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<int> SYMBOL_WIDEST
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SYMBOL_WIDEST, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SYMBOL_WIDEST, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> EVEN_TOTAL_SUBSET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVEN_TOTAL_SUBSET, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVEN_TOTAL_SUBSET, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> GSUM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GSUM, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GSUM, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> FINDER_PATTERNS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINDER_PATTERNS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINDER_PATTERNS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> WEIGHTS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEIGHTS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEIGHTS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> FINDER_PATTERN_SEQUENCES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINDER_PATTERN_SEQUENCES, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINDER_PATTERN_SEQUENCES, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ExpandedPair> pairs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExpandedPair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ExpandedRow> rows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExpandedRow>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> startEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool startFromEven
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startFromEven);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startFromEven)) = value;
		}
	}

	static RSSExpandedReader()
	{
		Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded", "RSSExpandedReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr);
		NativeFieldInfoPtr_SYMBOL_WIDEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "SYMBOL_WIDEST");
		NativeFieldInfoPtr_EVEN_TOTAL_SUBSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "EVEN_TOTAL_SUBSET");
		NativeFieldInfoPtr_GSUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "GSUM");
		NativeFieldInfoPtr_FINDER_PATTERNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "FINDER_PATTERNS");
		NativeFieldInfoPtr_WEIGHTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "WEIGHTS");
		NativeFieldInfoPtr_FINDER_PATTERN_SEQUENCES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "FINDER_PATTERN_SEQUENCES");
		NativeFieldInfoPtr_pairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "pairs");
		NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "rows");
		NativeFieldInfoPtr_startEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "startEnd");
		NativeFieldInfoPtr_startFromEven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, "startFromEven");
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664315);
		NativeMethodInfoPtr_decodeRow2pairs_Internal_Boolean_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_List_1_ExpandedRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_isValidSequence_Private_Static_Boolean_List_1_ExpandedPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_storeRow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_removePartialRows_Private_Static_Void_List_1_ExpandedPair_List_1_ExpandedRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_isPartialRow_Private_Static_Boolean_IEnumerable_1_ExpandedPair_IEnumerable_1_ExpandedRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_constructResult_Internal_Static_Result_List_1_ExpandedPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_checkChecksum_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_getNextSecondBar_Private_Static_Int32_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_retrieveNextPair_Internal_ExpandedPair_BitArray_List_1_ExpandedPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_findNextPair_Private_Boolean_BitArray_List_1_ExpandedPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_reverseCounters_Private_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_decodeDataCharacter_Internal_DataCharacter_BitArray_FinderPattern_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_isNotA1left_Private_Static_Boolean_FinderPattern_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr, 100664333);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424479, XrefRangeEnd = 1424485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424485, XrefRangeEnd = 1424489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424502, RefRangeEnd = 1424504, XrefRangeStart = 1424489, XrefRangeEnd = 1424502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool decodeRow2pairs(int rowNumber, BitArray row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow2pairs_Internal_Boolean_Int32_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424520, RefRangeEnd = 1424522, XrefRangeStart = 1424504, XrefRangeEnd = 1424520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ExpandedPair> checkRows(bool reverse)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&reverse);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExpandedPair>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424551, RefRangeEnd = 1424553, XrefRangeStart = 1424522, XrefRangeEnd = 1424551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ExpandedPair> checkRows(List<ExpandedRow> collectedRows, int currentRow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collectedRows);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentRow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkRows_Private_List_1_ExpandedPair_List_1_ExpandedRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExpandedPair>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424563, RefRangeEnd = 1424564, XrefRangeStart = 1424553, XrefRangeEnd = 1424563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isValidSequence(List<ExpandedPair> pairs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValidSequence_Private_Static_Boolean_List_1_ExpandedPair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424590, RefRangeEnd = 1424591, XrefRangeStart = 1424564, XrefRangeEnd = 1424590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void storeRow(int rowNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rowNumber);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_storeRow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424620, RefRangeEnd = 1424621, XrefRangeStart = 1424591, XrefRangeEnd = 1424620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removePartialRows(List<ExpandedPair> pairs, List<ExpandedRow> rows)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rows);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removePartialRows_Private_Static_Void_List_1_ExpandedPair_List_1_ExpandedRow_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424663, RefRangeEnd = 1424664, XrefRangeStart = 1424621, XrefRangeEnd = 1424663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPartialRow(IEnumerable<ExpandedPair> pairs, IEnumerable<ExpandedRow> rows)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rows);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPartialRow_Private_Static_Boolean_IEnumerable_1_ExpandedPair_IEnumerable_1_ExpandedRow_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424664, XrefRangeEnd = 1424687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Result constructResult(List<ExpandedPair> pairs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_constructResult_Internal_Static_Result_List_1_ExpandedPair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424694, RefRangeEnd = 1424696, XrefRangeStart = 1424687, XrefRangeEnd = 1424694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkChecksum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkChecksum_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424696, XrefRangeEnd = 1424701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getNextSecondBar(BitArray row, int initialPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNextSecondBar_Private_Static_Int32_BitArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424726, RefRangeEnd = 1424728, XrefRangeStart = 1424701, XrefRangeEnd = 1424726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExpandedPair retrieveNextPair(BitArray row, List<ExpandedPair> previousPairs, int rowNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousPairs);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_retrieveNextPair_Internal_ExpandedPair_BitArray_List_1_ExpandedPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExpandedPair>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424749, RefRangeEnd = 1424750, XrefRangeStart = 1424728, XrefRangeEnd = 1424749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool findNextPair(BitArray row, List<ExpandedPair> previousPairs, int forcedOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousPairs);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findNextPair_Private_Boolean_BitArray_List_1_ExpandedPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424750, RefRangeEnd = 1424752, XrefRangeStart = 1424750, XrefRangeEnd = 1424750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reverseCounters(Il2CppStructArray<int> counters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reverseCounters_Private_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424781, RefRangeEnd = 1424782, XrefRangeStart = 1424752, XrefRangeEnd = 1424781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FinderPattern parseFoundFinderPattern(BitArray row, int rowNumber, bool oddPattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowNumber;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oddPattern;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FinderPattern>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424821, RefRangeEnd = 1424823, XrefRangeStart = 1424782, XrefRangeEnd = 1424821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataCharacter decodeDataCharacter(BitArray row, FinderPattern pattern, bool isOddPattern, bool leftChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOddPattern;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeDataCharacter_Internal_DataCharacter_BitArray_FinderPattern_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataCharacter>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool isNotA1left(FinderPattern pattern, bool isOddPattern, bool leftChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOddPattern;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNotA1left_Private_Static_Boolean_FinderPattern_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424830, RefRangeEnd = 1424831, XrefRangeStart = 1424823, XrefRangeEnd = 1424830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool adjustOddEvenCounts(int numModules)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numModules);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424853, RefRangeEnd = 1424855, XrefRangeStart = 1424831, XrefRangeEnd = 1424853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RSSExpandedReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSSExpandedReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RSSExpandedReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
