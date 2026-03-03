using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.QrCode.Internal;

public static class MatrixUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_POSITION_DETECTION_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_INFO_COORDINATES;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearMatrix_Public_Static_Void_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildMatrix_Public_Static_Void_BitArray_ErrorCorrectionLevel_Version_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedBasicPatterns_Public_Static_Void_Version_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedTypeInfo_Public_Static_Void_ErrorCorrectionLevel_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_maybeEmbedVersionInfo_Public_Static_Void_Version_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedDataBits_Public_Static_Void_BitArray_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMSBSet_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateBCHCode_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_makeTypeInfoBits_Public_Static_Void_ErrorCorrectionLevel_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_makeVersionInfoBits_Public_Static_Void_Version_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isEmpty_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedTimingPatterns_Private_Static_Void_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedDarkDotAtLeftBottomCorner_Private_Static_Void_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedHorizontalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedVerticalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedPositionAdjustmentPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedPositionDetectionPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_embedPositionDetectionPatternsAndSeparators_Private_Static_Void_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_maybeEmbedPositionAdjustmentPatterns_Private_Static_Void_Version_ByteMatrix_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> POSITION_DETECTION_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POSITION_DETECTION_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POSITION_DETECTION_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> POSITION_ADJUSTMENT_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> TYPE_INFO_COORDINATES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_INFO_COORDINATES, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_INFO_COORDINATES, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MatrixUtil()
	{
		Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "MatrixUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr);
		NativeFieldInfoPtr_POSITION_DETECTION_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, "POSITION_DETECTION_PATTERN");
		NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, "POSITION_ADJUSTMENT_PATTERN");
		NativeFieldInfoPtr_POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, "POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE");
		NativeFieldInfoPtr_TYPE_INFO_COORDINATES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, "TYPE_INFO_COORDINATES");
		NativeMethodInfoPtr_clearMatrix_Public_Static_Void_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_buildMatrix_Public_Static_Void_BitArray_ErrorCorrectionLevel_Version_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_embedBasicPatterns_Public_Static_Void_Version_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_embedTypeInfo_Public_Static_Void_ErrorCorrectionLevel_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_maybeEmbedVersionInfo_Public_Static_Void_Version_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_embedDataBits_Public_Static_Void_BitArray_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_findMSBSet_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_calculateBCHCode_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_makeTypeInfoBits_Public_Static_Void_ErrorCorrectionLevel_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_makeVersionInfoBits_Public_Static_Void_Version_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_isEmpty_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr_embedTimingPatterns_Private_Static_Void_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_embedDarkDotAtLeftBottomCorner_Private_Static_Void_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_embedHorizontalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr_embedVerticalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_embedPositionAdjustmentPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_embedPositionDetectionPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_embedPositionDetectionPatternsAndSeparators_Private_Static_Void_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_maybeEmbedPositionAdjustmentPatterns_Private_Static_Void_Version_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixUtil>.NativeClassPtr, 100663757);
	}

	[CallerCount(0)]
	public unsafe static void clearMatrix(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearMatrix_Public_Static_Void_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1417519, RefRangeEnd = 1417522, XrefRangeStart = 1417495, XrefRangeEnd = 1417519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void buildMatrix(BitArray dataBits, ErrorCorrectionLevel ecLevel, Version version, int maskPattern, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskPattern;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildMatrix_Public_Static_Void_BitArray_ErrorCorrectionLevel_Version_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417544, RefRangeEnd = 1417545, XrefRangeStart = 1417522, XrefRangeEnd = 1417544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedBasicPatterns(Version version, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedBasicPatterns_Public_Static_Void_Version_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417545, XrefRangeEnd = 1417561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedTypeInfo(ErrorCorrectionLevel ecLevel, int maskPattern, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskPattern;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedTypeInfo_Public_Static_Void_ErrorCorrectionLevel_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417577, RefRangeEnd = 1417578, XrefRangeStart = 1417561, XrefRangeEnd = 1417577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void maybeEmbedVersionInfo(Version version, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_maybeEmbedVersionInfo_Public_Static_Void_Version_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417586, RefRangeEnd = 1417587, XrefRangeStart = 1417578, XrefRangeEnd = 1417586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedDataBits(BitArray dataBits, int maskPattern, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskPattern;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedDataBits_Public_Static_Void_BitArray_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int findMSBSet(int value_Renamed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value_Renamed);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMSBSet_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1417595, RefRangeEnd = 1417598, XrefRangeStart = 1417587, XrefRangeEnd = 1417595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int calculateBCHCode(int value, int poly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &poly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateBCHCode_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417617, RefRangeEnd = 1417619, XrefRangeStart = 1417598, XrefRangeEnd = 1417617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void makeTypeInfoBits(ErrorCorrectionLevel ecLevel, int maskPattern, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskPattern;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_makeTypeInfoBits_Public_Static_Void_ErrorCorrectionLevel_Int32_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417619, XrefRangeEnd = 1417625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void makeVersionInfoBits(Version version, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_makeVersionInfoBits_Public_Static_Void_Version_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool isEmpty(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isEmpty_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417625, XrefRangeEnd = 1417631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedTimingPatterns(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedTimingPatterns_Private_Static_Void_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void embedDarkDotAtLeftBottomCorner(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedDarkDotAtLeftBottomCorner_Private_Static_Void_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1417634, RefRangeEnd = 1417637, XrefRangeStart = 1417631, XrefRangeEnd = 1417634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedHorizontalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yStart;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedHorizontalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1417640, RefRangeEnd = 1417643, XrefRangeStart = 1417637, XrefRangeEnd = 1417640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedVerticalSeparationPattern(int xStart, int yStart, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yStart;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedVerticalSeparationPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417648, RefRangeEnd = 1417650, XrefRangeStart = 1417643, XrefRangeEnd = 1417648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedPositionAdjustmentPattern(int xStart, int yStart, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yStart;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedPositionAdjustmentPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417650, XrefRangeEnd = 1417655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedPositionDetectionPattern(int xStart, int yStart, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yStart;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedPositionDetectionPattern_Private_Static_Void_Int32_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417682, RefRangeEnd = 1417683, XrefRangeStart = 1417655, XrefRangeEnd = 1417682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void embedPositionDetectionPatternsAndSeparators(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_embedPositionDetectionPatternsAndSeparators_Private_Static_Void_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417683, XrefRangeEnd = 1417695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void maybeEmbedPositionAdjustmentPatterns(Version version, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_maybeEmbedPositionAdjustmentPatterns_Private_Static_Void_Version_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MatrixUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
