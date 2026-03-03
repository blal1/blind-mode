using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;
using Il2CppZXing.PDF417.Internal.EC;

namespace Il2CppZXing.PDF417.Internal;

public static class PDF417ScanningDecoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_errorCorrection;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_Static_DecoderResult_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_merge_Private_Static_DetectionResult_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustBoundingBox_Private_Static_BoundingBox_DetectionResultRowIndicatorColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMax_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBarcodeMetadata_Private_Static_BarcodeMetadata_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRowIndicatorColumn_Private_Static_DetectionResultRowIndicatorColumn_BitMatrix_BoundingBox_ResultPoint_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustCodewordCount_Private_Static_Boolean_DetectionResult_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createDecoderResult_Private_Static_DecoderResult_DetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createDecoderResultFromAmbiguousValues_Private_Static_DecoderResult_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createBarcodeMatrix_Private_Static_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_DetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValidBarcodeColumn_Private_Static_Boolean_DetectionResult_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStartColumn_Private_Static_Int32_DetectionResult_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_detectCodeword_Private_Static_Codeword_BitMatrix_Int32_Int32_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getModuleBitCount_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNumberOfECCodeWords_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustCodewordStartColumn_Private_Static_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkCodewordSkew_Private_Static_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeCodewords_Private_Static_DecoderResult_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_correctErrors_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_verifyCodewordCount_Private_Static_Boolean_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBitCountForCodeword_Private_Static_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	public unsafe static ErrorCorrection errorCorrection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_errorCorrection, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ErrorCorrection>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_errorCorrection, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PDF417ScanningDecoder()
	{
		Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "PDF417ScanningDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_errorCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, "errorCorrection");
		NativeMethodInfoPtr_decode_Public_Static_DecoderResult_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_merge_Private_Static_DetectionResult_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_adjustBoundingBox_Private_Static_BoundingBox_DetectionResultRowIndicatorColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_getMax_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_getBarcodeMetadata_Private_Static_BarcodeMetadata_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_getRowIndicatorColumn_Private_Static_DetectionResultRowIndicatorColumn_BitMatrix_BoundingBox_ResultPoint_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_adjustCodewordCount_Private_Static_Boolean_DetectionResult_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_createDecoderResult_Private_Static_DecoderResult_DetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_createDecoderResultFromAmbiguousValues_Private_Static_DecoderResult_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_createBarcodeMatrix_Private_Static_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_DetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_isValidBarcodeColumn_Private_Static_Boolean_DetectionResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_getStartColumn_Private_Static_Int32_DetectionResult_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_detectCodeword_Private_Static_Codeword_BitMatrix_Int32_Int32_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_getModuleBitCount_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_getNumberOfECCodeWords_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_adjustCodewordStartColumn_Private_Static_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_checkCodewordSkew_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_decodeCodewords_Private_Static_DecoderResult_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_correctErrors_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_verifyCodewordCount_Private_Static_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_getBitCountForCodeword_Private_Static_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ScanningDecoder>.NativeClassPtr, 100663941);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418977, RefRangeEnd = 1418978, XrefRangeStart = 1418909, XrefRangeEnd = 1418977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult decode(BitMatrix image, ResultPoint imageTopLeft, ResultPoint imageBottomLeft, ResultPoint imageTopRight, ResultPoint imageBottomRight, int minCodewordWidth, int maxCodewordWidth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageTopLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageBottomLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageTopRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageBottomRight);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minCodewordWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCodewordWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_Static_DecoderResult_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419004, RefRangeEnd = 1419005, XrefRangeStart = 1418978, XrefRangeEnd = 1419004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DetectionResult merge(DetectionResultRowIndicatorColumn leftRowIndicatorColumn, DetectionResultRowIndicatorColumn rightRowIndicatorColumn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftRowIndicatorColumn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightRowIndicatorColumn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_merge_Private_Static_DetectionResult_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DetectionResult>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419021, RefRangeEnd = 1419023, XrefRangeStart = 1419005, XrefRangeEnd = 1419021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoundingBox adjustBoundingBox(DetectionResultRowIndicatorColumn rowIndicatorColumn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rowIndicatorColumn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustBoundingBox_Private_Static_BoundingBox_DetectionResultRowIndicatorColumn_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419023, XrefRangeEnd = 1419027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getMax(Il2CppStructArray<int> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMax_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419027, XrefRangeEnd = 1419029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BarcodeMetadata getBarcodeMetadata(DetectionResultRowIndicatorColumn leftRowIndicatorColumn, DetectionResultRowIndicatorColumn rightRowIndicatorColumn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftRowIndicatorColumn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightRowIndicatorColumn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBarcodeMetadata_Private_Static_BarcodeMetadata_DetectionResultRowIndicatorColumn_DetectionResultRowIndicatorColumn_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BarcodeMetadata>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419029, XrefRangeEnd = 1419041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DetectionResultRowIndicatorColumn getRowIndicatorColumn(BitMatrix image, BoundingBox boundingBox, ResultPoint startPoint, bool leftToRight, int minCodewordWidth, int maxCodewordWidth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boundingBox);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startPoint);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftToRight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minCodewordWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCodewordWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRowIndicatorColumn_Private_Static_DetectionResultRowIndicatorColumn_BitMatrix_BoundingBox_ResultPoint_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DetectionResultRowIndicatorColumn>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419041, XrefRangeEnd = 1419054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool adjustCodewordCount(DetectionResult detectionResult, Il2CppReferenceArray<Il2CppReferenceArray<BarcodeValue>> barcodeMatrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResult);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)barcodeMatrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustCodewordCount_Private_Static_Boolean_DetectionResult_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419122, RefRangeEnd = 1419123, XrefRangeStart = 1419054, XrefRangeEnd = 1419122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult createDecoderResult(DetectionResult detectionResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createDecoderResult_Private_Static_DecoderResult_DetectionResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419132, RefRangeEnd = 1419133, XrefRangeStart = 1419123, XrefRangeEnd = 1419132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult createDecoderResultFromAmbiguousValues(int ecLevel, Il2CppStructArray<int> codewords, Il2CppStructArray<int> erasureArray, Il2CppStructArray<int> ambiguousIndexes, Il2CppReferenceArray<Il2CppStructArray<int>> ambiguousIndexValues)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)erasureArray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ambiguousIndexes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ambiguousIndexValues);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createDecoderResultFromAmbiguousValues_Private_Static_DecoderResult_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419151, RefRangeEnd = 1419152, XrefRangeStart = 1419133, XrefRangeEnd = 1419151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<BarcodeValue>> createBarcodeMatrix(DetectionResult detectionResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createBarcodeMatrix_Private_Static_Il2CppReferenceArray_1_Il2CppReferenceArray_1_BarcodeValue_DetectionResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<BarcodeValue>>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool isValidBarcodeColumn(DetectionResult detectionResult, int barcodeColumn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResult);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &barcodeColumn;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValidBarcodeColumn_Private_Static_Boolean_DetectionResult_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419155, RefRangeEnd = 1419156, XrefRangeStart = 1419152, XrefRangeEnd = 1419155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getStartColumn(DetectionResult detectionResult, int barcodeColumn, int imageRow, bool leftToRight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResult);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &barcodeColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &imageRow;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftToRight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStartColumn_Private_Static_Int32_DetectionResult_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1419177, RefRangeEnd = 1419181, XrefRangeStart = 1419156, XrefRangeEnd = 1419177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Codeword detectCodeword(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int startColumn, int imageRow, int minCodewordWidth, int maxCodewordWidth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxColumn;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftToRight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startColumn;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &imageRow;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &minCodewordWidth;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCodewordWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_detectCodeword_Private_Static_Codeword_BitMatrix_Int32_Int32_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Codeword>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419181, XrefRangeEnd = 1419188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> getModuleBitCount(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int startColumn, int imageRow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxColumn;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftToRight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startColumn;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &imageRow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getModuleBitCount_Private_Static_Il2CppStructArray_1_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int getNumberOfECCodeWords(int barcodeECLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&barcodeECLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNumberOfECCodeWords_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419188, XrefRangeEnd = 1419196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int adjustCodewordStartColumn(BitMatrix image, int minColumn, int maxColumn, bool leftToRight, int codewordStartColumn, int imageRow)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minColumn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxColumn;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftToRight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &codewordStartColumn;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &imageRow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustCodewordStartColumn_Private_Static_Int32_BitMatrix_Int32_Int32_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool checkCodewordSkew(int codewordSize, int minCodewordWidth, int maxCodewordWidth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&codewordSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minCodewordWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCodewordWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkCodewordSkew_Private_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419211, RefRangeEnd = 1419212, XrefRangeStart = 1419196, XrefRangeEnd = 1419211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult decodeCodewords(Il2CppStructArray<int> codewords, int ecLevel, Il2CppStructArray<int> erasures)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ecLevel;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)erasures);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeCodewords_Private_Static_DecoderResult_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419212, XrefRangeEnd = 1419217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int correctErrors(Il2CppStructArray<int> codewords, Il2CppStructArray<int> erasures, int numECCodewords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)erasures);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numECCodewords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_correctErrors_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool verifyCodewordCount(Il2CppStructArray<int> codewords, int numECCodewords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numECCodewords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_verifyCodewordCount_Private_Static_Boolean_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419217, XrefRangeEnd = 1419221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> getBitCountForCodeword(int codeword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codeword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBitCountForCodeword_Private_Static_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419221, XrefRangeEnd = 1419228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getCodewordBucketNumber(int codeword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codeword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int getCodewordBucketNumber(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodewordBucketNumber_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PDF417ScanningDecoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
