using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.QrCode.Internal;

public static class DecodedBitStreamParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ALPHANUMERIC_CHARS;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_Version_ErrorCorrectionLevel_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeHanziSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeKanjiSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeByteSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_CharacterSetECI_IList_1_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toAlphaNumericChar_Private_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeAlphanumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeNumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseECIValue_Private_Static_Int32_BitSource_0;

	public unsafe static Il2CppStructArray<char> ALPHANUMERIC_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALPHANUMERIC_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALPHANUMERIC_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecodedBitStreamParser()
	{
		Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "DecodedBitStreamParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr);
		NativeFieldInfoPtr_ALPHANUMERIC_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "ALPHANUMERIC_CHARS");
		NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_Version_ErrorCorrectionLevel_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_decodeHanziSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_decodeKanjiSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_decodeByteSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_CharacterSetECI_IList_1_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_toAlphaNumericChar_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_decodeAlphanumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_decodeNumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_parseECIValue_Private_Static_Int32_BitSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663594);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413558, RefRangeEnd = 1413559, XrefRangeStart = 1413447, XrefRangeEnd = 1413558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult decode(Il2CppStructArray<byte> bytes, Version version, ErrorCorrectionLevel ecLevel, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_Version_ErrorCorrectionLevel_IDictionary_2_DecodeHintType_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413570, RefRangeEnd = 1413571, XrefRangeStart = 1413559, XrefRangeEnd = 1413570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeHanziSegment(BitSource bits, StringBuilder result, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeHanziSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413582, RefRangeEnd = 1413583, XrefRangeStart = 1413571, XrefRangeEnd = 1413582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeKanjiSegment(BitSource bits, StringBuilder result, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeKanjiSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413598, RefRangeEnd = 1413599, XrefRangeStart = 1413583, XrefRangeEnd = 1413598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeByteSegment(BitSource bits, StringBuilder result, int count, CharacterSetECI currentCharacterSetECI, IList<Il2CppStructArray<byte>> byteSegments, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentCharacterSetECI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteSegments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeByteSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_CharacterSetECI_IList_1_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1413605, RefRangeEnd = 1413614, XrefRangeStart = 1413599, XrefRangeEnd = 1413605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char toAlphaNumericChar(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toAlphaNumericChar_Private_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413637, RefRangeEnd = 1413638, XrefRangeStart = 1413614, XrefRangeEnd = 1413637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeAlphanumericSegment(BitSource bits, StringBuilder result, int count, bool fc1InEffect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fc1InEffect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeAlphanumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413663, RefRangeEnd = 1413664, XrefRangeStart = 1413638, XrefRangeEnd = 1413663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeNumericSegment(BitSource bits, StringBuilder result, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeNumericSegment_Private_Static_Boolean_BitSource_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413664, XrefRangeEnd = 1413666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int parseECIValue(BitSource bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseECIValue_Private_Static_Int32_BitSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecodedBitStreamParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
