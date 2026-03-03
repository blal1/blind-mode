using System;
using System.Runtime.CompilerServices;
using Il2CppBigIntegerLibrary;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.PDF417.Internal;

public static class DecodedBitStreamParser : Il2CppSystem.Object
{
	[OriginalName("zxing.unity.dll", "", "Mode")]
	public enum Mode
	{
		ALPHA,
		LOWER,
		MIXED,
		PUNCT,
		ALPHA_SHIFT,
		PUNCT_SHIFT
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PUNCT_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIXED_CHARS;

	private static readonly System.IntPtr NativeFieldInfoPtr_EXP900;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEncoding_Private_Static_Encoding_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeMacroBlock_Internal_Static_Int32_Il2CppStructArray_1_Int32_Int32_PDF417ResultMetadata_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeTextCompaction_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_byteCompaction_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Encoding_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numericCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeBase900toBase10_Private_Static_String_Il2CppStructArray_1_Int32_Int32_0;

	public unsafe static Il2CppStructArray<char> PUNCT_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PUNCT_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PUNCT_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> MIXED_CHARS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIXED_CHARS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIXED_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<BigInteger> EXP900
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXP900, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BigInteger>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXP900, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecodedBitStreamParser()
	{
		Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "DecodedBitStreamParser");
		NativeFieldInfoPtr_PUNCT_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "PUNCT_CHARS");
		NativeFieldInfoPtr_MIXED_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "MIXED_CHARS");
		NativeFieldInfoPtr_EXP900 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, "EXP900");
		NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_getEncoding_Private_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_decodeMacroBlock_Internal_Static_Int32_Il2CppStructArray_1_Int32_Int32_PDF417ResultMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_textCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_decodeTextCompaction_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_byteCompaction_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Encoding_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_numericCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_decodeBase900toBase10_Private_Static_String_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedBitStreamParser>.NativeClassPtr, 100663869);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418285, RefRangeEnd = 1418286, XrefRangeStart = 1418221, XrefRangeEnd = 1418285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DecoderResult decode(Il2CppStructArray<int> codewords, string ecLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ecLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Internal_Static_DecoderResult_Il2CppStructArray_1_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418287, RefRangeEnd = 1418290, XrefRangeStart = 1418286, XrefRangeEnd = 1418287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding getEncoding(string encodingName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(encodingName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEncoding_Private_Static_Encoding_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418363, RefRangeEnd = 1418364, XrefRangeStart = 1418290, XrefRangeEnd = 1418363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decodeMacroBlock(Il2CppStructArray<int> codewords, int codeIndex, PDF417ResultMetadata resultMetadata)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &codeIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultMetadata);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMacroBlock_Internal_Static_Int32_Il2CppStructArray_1_Int32_Int32_PDF417ResultMetadata_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1418410, RefRangeEnd = 1418415, XrefRangeStart = 1418364, XrefRangeEnd = 1418410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int textCompaction(Il2CppStructArray<int> codewords, int codeIndex, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &codeIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418415, XrefRangeEnd = 1418447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void decodeTextCompaction(Il2CppStructArray<int> textCompactionData, Il2CppStructArray<int> byteCompactionData, int length, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textCompactionData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteCompactionData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeTextCompaction_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418468, RefRangeEnd = 1418469, XrefRangeStart = 1418447, XrefRangeEnd = 1418468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int byteCompaction(int mode, Il2CppStructArray<int> codewords, Encoding encoding, int codeIndex, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &codeIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_byteCompaction_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Encoding_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1418480, RefRangeEnd = 1418485, XrefRangeStart = 1418469, XrefRangeEnd = 1418480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int numericCompaction(Il2CppStructArray<int> codewords, int codeIndex, StringBuilder result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &codeIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numericCompaction_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1418502, RefRangeEnd = 1418504, XrefRangeStart = 1418485, XrefRangeEnd = 1418502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string decodeBase900toBase10(Il2CppStructArray<int> codewords, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeBase900toBase10_Private_Static_String_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DecodedBitStreamParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
