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

namespace Il2CppZXing.Datamatrix.Internal;

public static class DecodedBitStreamParser : Il2CppSystem.Object
{
	[OriginalName("zxing.unity.dll", "", "Mode")]
	public enum Mode
	{
		PAD_ENCODE,
		ASCII_ENCODE,
		C40_ENCODE,
		TEXT_ENCODE,
		ANSIX12_ENCODE,
		EDIFACT_ENCODE,
		BASE256_ENCODE
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_C40_BASIC_SET_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_C40_SHIFT2_SET_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_BASIC_SET_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_SHIFT2_SET_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_SHIFT3_SET_CHARS;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeAsciiSegment_Private_Static_Boolean_BitSource_StringBuilder_StringBuilder_byref_Mode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeC40Segment_Private_Static_Boolean_BitSource_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeTextSegment_Private_Static_Boolean_BitSource_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeAnsiX12Segment_Private_Static_Boolean_BitSource_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseTwoBytes_Private_Static_Void_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeEdifactSegment_Private_Static_Boolean_BitSource_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeBase256Segment_Private_Static_Boolean_BitSource_StringBuilder_IList_1_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unrandomize255State_Private_Static_Int32_Int32_Int32_0;

	public unsafe static Il2CppStructArray<char> C40_BASIC_SET_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_C40_BASIC_SET_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_C40_BASIC_SET_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> C40_SHIFT2_SET_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_C40_SHIFT2_SET_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_C40_SHIFT2_SET_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> TEXT_BASIC_SET_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_BASIC_SET_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_BASIC_SET_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> TEXT_SHIFT2_SET_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_SHIFT2_SET_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_SHIFT2_SET_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> TEXT_SHIFT3_SET_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_SHIFT3_SET_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_SHIFT3_SET_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecodedBitStreamParser()
	{
		Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Internal", "DecodedBitStreamParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr);
		NativeFieldInfoPtr_C40_BASIC_SET_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "C40_BASIC_SET_CHARS");
		NativeFieldInfoPtr_C40_SHIFT2_SET_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "C40_SHIFT2_SET_CHARS");
		NativeFieldInfoPtr_TEXT_BASIC_SET_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "TEXT_BASIC_SET_CHARS");
		NativeFieldInfoPtr_TEXT_SHIFT2_SET_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "TEXT_SHIFT2_SET_CHARS");
		NativeFieldInfoPtr_TEXT_SHIFT3_SET_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "TEXT_SHIFT3_SET_CHARS");
		NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_decodeAsciiSegment_Private_Static_Boolean_BitSource_StringBuilder_StringBuilder_byref_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_decodeC40Segment_Private_Static_Boolean_BitSource_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_decodeTextSegment_Private_Static_Boolean_BitSource_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_decodeAnsiX12Segment_Private_Static_Boolean_BitSource_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_parseTwoBytes_Private_Static_Void_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_decodeEdifactSegment_Private_Static_Boolean_BitSource_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_decodeBase256Segment_Private_Static_Boolean_BitSource_StringBuilder_IList_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_unrandomize255State_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100664596);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1427420, RefRangeEnd = 1427421, XrefRangeStart = 1427397, XrefRangeEnd = 1427420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult decode(Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427421, XrefRangeEnd = 1427444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeAsciiSegment(BitSource bits, StringBuilder result, StringBuilder resultTrailer, out Mode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTrailer);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeAsciiSegment_Private_Static_Boolean_BitSource_StringBuilder_StringBuilder_byref_Mode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427444, XrefRangeEnd = 1427482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeC40Segment(BitSource bits, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeC40Segment_Private_Static_Boolean_BitSource_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427482, XrefRangeEnd = 1427524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeTextSegment(BitSource bits, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeTextSegment_Private_Static_Boolean_BitSource_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427524, XrefRangeEnd = 1427540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeAnsiX12Segment(BitSource bits, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeAnsiX12Segment_Private_Static_Boolean_BitSource_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void parseTwoBytes(int firstByte, int secondByte, Il2CppStructArray<int> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&firstByte);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondByte;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseTwoBytes_Private_Static_Void_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427540, XrefRangeEnd = 1427544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeEdifactSegment(BitSource bits, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeEdifactSegment_Private_Static_Boolean_BitSource_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1427568, RefRangeEnd = 1427569, XrefRangeStart = 1427544, XrefRangeEnd = 1427568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeBase256Segment(BitSource bits, StringBuilder result, IList<Il2CppStructArray<byte>> byteSegments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteSegments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeBase256Segment_Private_Static_Boolean_BitSource_StringBuilder_IList_1_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int unrandomize255State(int randomizedBase256Codeword, int base256CodewordPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&randomizedBase256Codeword);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &base256CodewordPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unrandomize255State_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecodedBitStreamParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
