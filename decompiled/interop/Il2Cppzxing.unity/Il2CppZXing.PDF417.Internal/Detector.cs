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

namespace Il2CppZXing.PDF417.Internal;

public sealed class Detector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_INDEXES_START_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_INDEXES_STOP_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_START_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_STOP_PATTERN;

	private static readonly System.IntPtr NativeMethodInfoPtr_detect_Public_Static_PDF417DetectorResult_BinaryBitmap_IDictionary_2_DecodeHintType_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_detect_Private_Static_List_1_Il2CppReferenceArray_1_ResultPoint_Boolean_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findVertices_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copyToResult_Private_Static_Void_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findRowsWithPattern_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_patternMatchVariance_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	public unsafe static Il2CppStructArray<int> INDEXES_START_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDEXES_START_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDEXES_START_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> INDEXES_STOP_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDEXES_STOP_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDEXES_STOP_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> START_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_START_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_START_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> STOP_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STOP_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STOP_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Detector()
	{
		Il2CppClassPointerStore<Detector>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "Detector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Detector>.NativeClassPtr);
		NativeFieldInfoPtr_INDEXES_START_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "INDEXES_START_PATTERN");
		NativeFieldInfoPtr_INDEXES_STOP_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "INDEXES_STOP_PATTERN");
		NativeFieldInfoPtr_START_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "START_PATTERN");
		NativeFieldInfoPtr_STOP_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "STOP_PATTERN");
		NativeMethodInfoPtr_detect_Public_Static_PDF417DetectorResult_BinaryBitmap_IDictionary_2_DecodeHintType_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_detect_Private_Static_List_1_Il2CppReferenceArray_1_ResultPoint_Boolean_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_findVertices_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_copyToResult_Private_Static_Void_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_findRowsWithPattern_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_patternMatchVariance_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100663949);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419228, XrefRangeEnd = 1419245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PDF417DetectorResult detect(BinaryBitmap image, IDictionary<DecodeHintType, Il2CppSystem.Object> hints, bool multiple)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &multiple;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_detect_Public_Static_PDF417DetectorResult_BinaryBitmap_IDictionary_2_DecodeHintType_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PDF417DetectorResult>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1419282, RefRangeEnd = 1419286, XrefRangeStart = 1419245, XrefRangeEnd = 1419282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Il2CppReferenceArray<ResultPoint>> detect(bool multiple, BitMatrix bitMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&multiple);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bitMatrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_detect_Private_Static_List_1_Il2CppReferenceArray_1_ResultPoint_Boolean_BitMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<ResultPoint>>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419307, RefRangeEnd = 1419308, XrefRangeStart = 1419286, XrefRangeEnd = 1419307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ResultPoint> findVertices(BitMatrix matrix, int startRow, int startColumn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startRow;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startColumn;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findVertices_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419308, XrefRangeEnd = 1419311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copyToResult(Il2CppReferenceArray<ResultPoint> result, Il2CppReferenceArray<ResultPoint> tmpResult, Il2CppStructArray<int> destinationIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tmpResult);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copyToResult_Private_Static_Void_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419362, RefRangeEnd = 1419364, XrefRangeStart = 1419311, XrefRangeEnd = 1419362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ResultPoint> findRowsWithPattern(BitMatrix matrix, int height, int width, int startRow, int startColumn, Il2CppStructArray<int> pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startRow;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startColumn;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findRowsWithPattern_Private_Static_Il2CppReferenceArray_1_ResultPoint_BitMatrix_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1419381, RefRangeEnd = 1419384, XrefRangeStart = 1419364, XrefRangeEnd = 1419381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> findGuardPattern(BitMatrix matrix, int column, int row, int width, Il2CppStructArray<int> pattern, Il2CppStructArray<int> counters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int patternMatchVariance(Il2CppStructArray<int> counters, Il2CppStructArray<int> pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_patternMatchVariance_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Detector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
