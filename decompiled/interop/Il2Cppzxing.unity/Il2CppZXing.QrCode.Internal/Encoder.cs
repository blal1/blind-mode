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

namespace Il2CppZXing.QrCode.Internal;

public static class Encoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ALPHANUMERIC_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_BYTE_MODE_ENCODING;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateMaskPenalty_Private_Static_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Static_QRCode_String_ErrorCorrectionLevel_IDictionary_2_EncodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_recommendVersion_Private_Static_Version_ErrorCorrectionLevel_Mode_BitArray_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateBitsNeeded_Private_Static_Int32_Mode_BitArray_BitArray_Version_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAlphanumericCode_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chooseMode_Private_Static_Mode_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOnlyDoubleByteKanji_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chooseMaskPattern_Private_Static_Int32_BitArray_ErrorCorrectionLevel_Version_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chooseVersion_Private_Static_Version_Int32_ErrorCorrectionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_willFit_Private_Static_Boolean_Int32_Version_ErrorCorrectionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_terminateBits_Internal_Static_Void_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNumDataBytesAndNumECBytesForBlockID_Internal_Static_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_interleaveWithECBytes_Internal_Static_BitArray_BitArray_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateECBytes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendModeInfo_Internal_Static_Void_Mode_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendLengthInfo_Internal_Static_Void_Int32_Version_Mode_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendBytes_Internal_Static_Void_String_Mode_BitArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendNumericBytes_Internal_Static_Void_String_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendAlphanumericBytes_Internal_Static_Void_String_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_append8BitBytes_Internal_Static_Void_String_BitArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendKanjiBytes_Internal_Static_Void_String_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_appendECI_Private_Static_Void_CharacterSetECI_BitArray_0;

	public unsafe static Il2CppStructArray<int> ALPHANUMERIC_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALPHANUMERIC_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALPHANUMERIC_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string DEFAULT_BYTE_MODE_ENCODING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_BYTE_MODE_ENCODING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_BYTE_MODE_ENCODING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static Encoder()
	{
		Il2CppClassPointerStore<Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "Encoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoder>.NativeClassPtr);
		NativeFieldInfoPtr_ALPHANUMERIC_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoder>.NativeClassPtr, "ALPHANUMERIC_TABLE");
		NativeFieldInfoPtr_DEFAULT_BYTE_MODE_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoder>.NativeClassPtr, "DEFAULT_BYTE_MODE_ENCODING");
		NativeMethodInfoPtr_calculateMaskPenalty_Private_Static_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_encode_Public_Static_QRCode_String_ErrorCorrectionLevel_IDictionary_2_EncodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_recommendVersion_Private_Static_Version_ErrorCorrectionLevel_Mode_BitArray_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr_calculateBitsNeeded_Private_Static_Int32_Mode_BitArray_BitArray_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr_getAlphanumericCode_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663712);
		NativeMethodInfoPtr_chooseMode_Private_Static_Mode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_isOnlyDoubleByteKanji_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr_chooseMaskPattern_Private_Static_Int32_BitArray_ErrorCorrectionLevel_Version_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663715);
		NativeMethodInfoPtr_chooseVersion_Private_Static_Version_Int32_ErrorCorrectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663716);
		NativeMethodInfoPtr_willFit_Private_Static_Boolean_Int32_Version_ErrorCorrectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663717);
		NativeMethodInfoPtr_terminateBits_Internal_Static_Void_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663718);
		NativeMethodInfoPtr_getNumDataBytesAndNumECBytesForBlockID_Internal_Static_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663719);
		NativeMethodInfoPtr_interleaveWithECBytes_Internal_Static_BitArray_BitArray_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr_generateECBytes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr_appendModeInfo_Internal_Static_Void_Mode_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr_appendLengthInfo_Internal_Static_Void_Int32_Version_Mode_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr_appendBytes_Internal_Static_Void_String_Mode_BitArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663724);
		NativeMethodInfoPtr_appendNumericBytes_Internal_Static_Void_String_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663725);
		NativeMethodInfoPtr_appendAlphanumericBytes_Internal_Static_Void_String_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663726);
		NativeMethodInfoPtr_append8BitBytes_Internal_Static_Void_String_BitArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr_appendKanjiBytes_Internal_Static_Void_String_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_appendECI_Private_Static_Void_CharacterSetECI_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100663729);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417054, RefRangeEnd = 1417056, XrefRangeStart = 1417049, XrefRangeEnd = 1417054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int calculateMaskPenalty(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateMaskPenalty_Private_Static_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417224, RefRangeEnd = 1417225, XrefRangeStart = 1417056, XrefRangeEnd = 1417224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static QRCode encode(string content, ErrorCorrectionLevel ecLevel, IDictionary<EncodeHintType, Il2CppSystem.Object> hints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Static_QRCode_String_ErrorCorrectionLevel_IDictionary_2_EncodeHintType_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<QRCode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417225, XrefRangeEnd = 1417237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version recommendVersion(ErrorCorrectionLevel ecLevel, Mode mode, BitArray headerBits, BitArray dataBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)headerBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_recommendVersion_Private_Static_Version_ErrorCorrectionLevel_Mode_BitArray_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417237, XrefRangeEnd = 1417238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int calculateBitsNeeded(Mode mode, BitArray headerBits, BitArray dataBits, Version version)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)headerBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateBitsNeeded_Private_Static_Int32_Mode_BitArray_BitArray_Version_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1417242, RefRangeEnd = 1417245, XrefRangeStart = 1417238, XrefRangeEnd = 1417242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getAlphanumericCode(int code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAlphanumericCode_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417266, RefRangeEnd = 1417267, XrefRangeStart = 1417245, XrefRangeEnd = 1417266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mode chooseMode(string content, string encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chooseMode_Private_Static_Mode_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417270, RefRangeEnd = 1417271, XrefRangeStart = 1417267, XrefRangeEnd = 1417270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isOnlyDoubleByteKanji(string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOnlyDoubleByteKanji_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417271, XrefRangeEnd = 1417284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int chooseMaskPattern(BitArray bits, ErrorCorrectionLevel ecLevel, Version version, ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chooseMaskPattern_Private_Static_Int32_BitArray_ErrorCorrectionLevel_Version_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1417294, RefRangeEnd = 1417298, XrefRangeStart = 1417284, XrefRangeEnd = 1417294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version chooseVersion(int numInputBits, ErrorCorrectionLevel ecLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numInputBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chooseVersion_Private_Static_Version_Int32_ErrorCorrectionLevel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417300, RefRangeEnd = 1417301, XrefRangeStart = 1417298, XrefRangeEnd = 1417300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool willFit(int numInputBits, Version version, ErrorCorrectionLevel ecLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&numInputBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_willFit_Private_Static_Boolean_Int32_Version_ErrorCorrectionLevel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417306, RefRangeEnd = 1417307, XrefRangeStart = 1417301, XrefRangeEnd = 1417306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void terminateBits(int numDataBytes, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numDataBytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_terminateBits_Internal_Static_Void_Int32_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417307, RefRangeEnd = 1417308, XrefRangeStart = 1417307, XrefRangeEnd = 1417307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getNumDataBytesAndNumECBytesForBlockID(int numTotalBytes, int numDataBytes, int numRSBlocks, int blockID, Il2CppStructArray<int> numDataBytesInBlock, Il2CppStructArray<int> numECBytesInBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&numTotalBytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numDataBytes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numRSBlocks;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)numDataBytesInBlock);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)numECBytesInBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNumDataBytesAndNumECBytesForBlockID_Internal_Static_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417392, RefRangeEnd = 1417393, XrefRangeStart = 1417308, XrefRangeEnd = 1417392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitArray interleaveWithECBytes(BitArray bits, int numTotalBytes, int numDataBytes, int numRSBlocks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numTotalBytes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numDataBytes;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numRSBlocks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_interleaveWithECBytes_Internal_Static_BitArray_BitArray_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417393, XrefRangeEnd = 1417408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> generateECBytes(Il2CppStructArray<byte> dataBytes, int numEcBytesInBlock)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numEcBytesInBlock;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateECBytes_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417408, XrefRangeEnd = 1417410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendModeInfo(Mode mode, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendModeInfo_Internal_Static_Void_Mode_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417410, XrefRangeEnd = 1417412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendLengthInfo(int numLetters, Version version, Mode mode, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&numLetters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendLengthInfo_Internal_Static_Void_Int32_Version_Mode_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417429, RefRangeEnd = 1417430, XrefRangeStart = 1417412, XrefRangeEnd = 1417429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendBytes(string content, Mode mode, BitArray bits, string encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendBytes_Internal_Static_Void_String_Mode_BitArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417430, XrefRangeEnd = 1417438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendNumericBytes(string content, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendNumericBytes_Internal_Static_Void_String_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417438, XrefRangeEnd = 1417450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendAlphanumericBytes(string content, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendAlphanumericBytes_Internal_Static_Void_String_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417450, XrefRangeEnd = 1417453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void append8BitBytes(string content, BitArray bits, string encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_append8BitBytes_Internal_Static_Void_String_BitArray_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417458, RefRangeEnd = 1417459, XrefRangeStart = 1417453, XrefRangeEnd = 1417458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendKanjiBytes(string content, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendKanjiBytes_Internal_Static_Void_String_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417459, XrefRangeEnd = 1417466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendECI(CharacterSetECI eci, BitArray bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eci);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendECI_Private_Static_Void_CharacterSetECI_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Encoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
