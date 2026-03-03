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

namespace Il2CppZXing.OneD.RSS;

public sealed class RSS14Reader : AbstractRSSReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OUTSIDE_EVEN_TOTAL_SUBSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_INSIDE_ODD_TOTAL_SUBSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_OUTSIDE_GSUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_INSIDE_GSUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_OUTSIDE_ODD_WIDEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_INSIDE_ODD_WIDEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINDER_PATTERNS;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleLeftPairs;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleRightPairs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addOrTally_Private_Static_Void_IList_1_Pair_Pair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_constructResult_Private_Static_Result_Pair_Pair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkChecksum_Private_Static_Boolean_Pair_Pair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodePair_Private_Pair_BitArray_Boolean_Int32_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeDataCharacter_Private_DataCharacter_BitArray_FinderPattern_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findFinderPattern_Private_Il2CppStructArray_1_Int32_BitArray_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Boolean_Int32_0;

	public unsafe static Il2CppStructArray<int> OUTSIDE_EVEN_TOTAL_SUBSET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OUTSIDE_EVEN_TOTAL_SUBSET, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OUTSIDE_EVEN_TOTAL_SUBSET, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> INSIDE_ODD_TOTAL_SUBSET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INSIDE_ODD_TOTAL_SUBSET, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INSIDE_ODD_TOTAL_SUBSET, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> OUTSIDE_GSUM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OUTSIDE_GSUM, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OUTSIDE_GSUM, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> INSIDE_GSUM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INSIDE_GSUM, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INSIDE_GSUM, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> OUTSIDE_ODD_WIDEST
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OUTSIDE_ODD_WIDEST, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OUTSIDE_ODD_WIDEST, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> INSIDE_ODD_WIDEST
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INSIDE_ODD_WIDEST, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INSIDE_ODD_WIDEST, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe List<Pair> possibleLeftPairs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleLeftPairs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Pair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleLeftPairs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Pair> possibleRightPairs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleRightPairs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Pair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleRightPairs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RSS14Reader()
	{
		Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS", "RSS14Reader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr);
		NativeFieldInfoPtr_OUTSIDE_EVEN_TOTAL_SUBSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "OUTSIDE_EVEN_TOTAL_SUBSET");
		NativeFieldInfoPtr_INSIDE_ODD_TOTAL_SUBSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "INSIDE_ODD_TOTAL_SUBSET");
		NativeFieldInfoPtr_OUTSIDE_GSUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "OUTSIDE_GSUM");
		NativeFieldInfoPtr_INSIDE_GSUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "INSIDE_GSUM");
		NativeFieldInfoPtr_OUTSIDE_ODD_WIDEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "OUTSIDE_ODD_WIDEST");
		NativeFieldInfoPtr_INSIDE_ODD_WIDEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "INSIDE_ODD_WIDEST");
		NativeFieldInfoPtr_FINDER_PATTERNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "FINDER_PATTERNS");
		NativeFieldInfoPtr_possibleLeftPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "possibleLeftPairs");
		NativeFieldInfoPtr_possibleRightPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, "possibleRightPairs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_addOrTally_Private_Static_Void_IList_1_Pair_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_constructResult_Private_Static_Result_Pair_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_checkChecksum_Private_Static_Boolean_Pair_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_decodePair_Private_Pair_BitArray_Boolean_Int32_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_decodeDataCharacter_Private_DataCharacter_BitArray_FinderPattern_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_findFinderPattern_Private_Il2CppStructArray_1_Int32_BitArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr, 100664287);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424218, RefRangeEnd = 1424220, XrefRangeStart = 1424202, XrefRangeEnd = 1424218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RSS14Reader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSS14Reader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424220, XrefRangeEnd = 1424237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424259, RefRangeEnd = 1424261, XrefRangeStart = 1424237, XrefRangeEnd = 1424259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addOrTally(IList<Pair> possiblePairs, Pair pair)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)possiblePairs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pair);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addOrTally_Private_Static_Void_IList_1_Pair_Pair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424261, XrefRangeEnd = 1424264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424264, XrefRangeEnd = 1424289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Result constructResult(Pair leftPair, Pair rightPair)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftPair);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightPair);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_constructResult_Private_Static_Result_Pair_Pair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool checkChecksum(Pair leftPair, Pair rightPair)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftPair);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightPair);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkChecksum_Private_Static_Boolean_Pair_Pair_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424310, RefRangeEnd = 1424312, XrefRangeStart = 1424289, XrefRangeEnd = 1424310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Pair decodePair(BitArray row, bool right, int rowNumber, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowNumber;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodePair_Private_Pair_BitArray_Boolean_Int32_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Pair>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1424346, RefRangeEnd = 1424348, XrefRangeStart = 1424312, XrefRangeEnd = 1424346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataCharacter decodeDataCharacter(BitArray row, FinderPattern pattern, bool outsideChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outsideChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeDataCharacter_Private_DataCharacter_BitArray_FinderPattern_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataCharacter>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424357, RefRangeEnd = 1424358, XrefRangeStart = 1424348, XrefRangeEnd = 1424357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> findFinderPattern(BitArray row, bool rightFinderPattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightFinderPattern;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findFinderPattern_Private_Il2CppStructArray_1_Int32_BitArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424386, RefRangeEnd = 1424387, XrefRangeStart = 1424358, XrefRangeEnd = 1424386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FinderPattern parseFoundFinderPattern(BitArray row, int rowNumber, bool right, Il2CppStructArray<int> startEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowNumber;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startEnd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseFoundFinderPattern_Private_FinderPattern_BitArray_Int32_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FinderPattern>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424396, RefRangeEnd = 1424397, XrefRangeStart = 1424387, XrefRangeEnd = 1424396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool adjustOddEvenCounts(bool outsideChar, int numModules)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&outsideChar);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numModules;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustOddEvenCounts_Private_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RSS14Reader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
